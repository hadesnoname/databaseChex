using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Гостиница
{
    public partial class FormSQL : Form
    {
        public FormSQL()
        {
            InitializeComponent();
            if (panelClient != null) panelClient.Visible = false;
        }

        string connStr = Properties.Settings.Default.ГостиницаConnectionString;

        private DataTable FillDataGridView(string sqlSelect)
        {
            try
            {
                SqlConnection connection = new SqlConnection(connStr);
                SqlCommand command = connection.CreateCommand();
                command.CommandText = sqlSelect;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка SQL:\n" + ex.Message + "\n\nЗапрос:\n" + sqlSelect,
                               "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        #region Вкладка 1: Примеры запросов
        private void radioButtonClients_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonClients.Checked)
                dataGridViewSelect.DataSource = FillDataGridView("SELECT * FROM Клиенты");
        }

        private void radioButtonRooms_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRooms.Checked)
            {
                if (string.IsNullOrEmpty(textBoxCategory.Text))
                {
                    MessageBox.Show("Введите категорию номера!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                // ВАЖНО: имя таблицы с пробелами в квадратных скобках
                string sql = "SELECT room_id, Категория, Этаж FROM [Номера в гостинице] WHERE Категория LIKE @cat";
                SqlConnection conn = new SqlConnection(connStr);
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@cat", textBoxCategory.Text + "%");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dataGridViewSelect.DataSource = dt;
            }
        }

        private void radioButtonContracts_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonContracts.Checked)
            {
                string sql = @"SELECT d.contract_id, c.ФИО AS [Клиент], s.ФИО AS [Сотрудник], 
                                      r.Категория AS [Категория номера], r.Этаж,
                                      d.Тариф, d.Дата_бронирования, d.date_start, d.date_end, d.Статус
                               FROM Договоры d
                               INNER JOIN Клиенты c ON d.client_id = c.client_id
                               INNER JOIN Сотрудники s ON d.employee_id = s.employee_id
                               INNER JOIN [Номера в гостинице] r ON d.room_id = r.room_id";
                dataGridViewSelect.DataSource = FillDataGridView(sql);
            }
        }
        #endregion

        #region Вкладка 2: Полная запись SELECT
        private void buttonF_select_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxMinCount.Text))
            {
                MessageBox.Show("Укажите минимальное количество договоров!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxMinCount.Text, out int minCount))
            {
                MessageBox.Show("Количество должно быть целым числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = @"SELECT s.employee_id, s.ФИО, s.Должность, COUNT(d.contract_id) AS [Кол-во договоров],
                          SUM(d.Тариф) AS [Общая прибыль]
                   FROM Сотрудники s
                   INNER JOIN Договоры d ON s.employee_id = d.employee_id
                   GROUP BY s.employee_id, s.ФИО, s.Должность
                   HAVING COUNT(d.contract_id) >= @min_count";  // ✅ Изменено > на >=

            if (checkBoxOrder.Checked)
                sql += " ORDER BY [Общая прибыль] DESC";

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@min_count", minCount);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewFSelect.DataSource = dt;

            if (dt.Rows.Count == 0)
                MessageBox.Show("Сотрудников с таким количеством договоров не найдено.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Вкладка 3: Подзапросы
        private void buttonSubquery_Click(object sender, EventArgs e)
        {
            string sql = "";
            string category = textBoxCategorySub.Text.Trim();

            if (radioButtonNoCorrelated.Checked)
            {
                // Некоррелированный: клиенты, бронировавшие номера определенной категории
                sql = @"SELECT client_id, ФИО, Паспорт = Серия_и_номер, Номер_телефона
                        FROM Клиенты 
                        WHERE client_id IN (
                            SELECT client_id FROM Договоры 
                            WHERE room_id IN (
                                SELECT room_id FROM [Номера в гостинице] WHERE Категория = @cat
                            )
                        )";
            }
            else if (radioButtonCorrelated.Checked)
            {
                // Коррелированный: номера, которые хотя бы раз бронировались
                sql = @"SELECT room_id, Категория, Этаж 
                        FROM [Номера в гостинице] n
                        WHERE EXISTS (
                            SELECT 1 FROM Договоры d WHERE d.room_id = n.room_id
                        )";
            }
            else
            {
                MessageBox.Show("Выберите тип подзапроса!"); return;
            }

            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            if (radioButtonNoCorrelated.Checked)
                cmd.Parameters.AddWithValue("@cat", category);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridViewSubquery.DataSource = dt;

            if (dt.Rows.Count == 0)
                MessageBox.Show("Нет значений!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region Вкладка 4: DML операции
        private void radioButtonInsert_CheckedChanged(object sender, EventArgs e) { panelClient.Visible = true; }
        private void radioButtonUpdate_CheckedChanged(object sender, EventArgs e) { panelClient.Visible = true; }
        private void radioButtonDelete_CheckedChanged(object sender, EventArgs e) { panelClient.Visible = false; }

        private void buttonExecuteDML_Click(object sender, EventArgs e)
        {
            if (radioButtonInsert.Checked) InsertClient();
            else if (radioButtonUpdate.Checked) UpdateClient();
            else if (radioButtonDelete.Checked) DeleteClient();
            else MessageBox.Show("Выберите операцию!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        void InsertClient()
        {
            if (string.IsNullOrEmpty(textBoxId.Text) || string.IsNullOrEmpty(textBoxFio.Text))
            {
                MessageBox.Show("Обязательно введите Код и ФИО клиента!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxId.Text, out int id))
            {
                MessageBox.Show("Код клиента должен быть числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "INSERT INTO Клиенты (client_id, ФИО, Серия_и_номер, Номер_телефона) VALUES (@id, @fio, @pas, @tel)";
            ExecuteDML(sql, id);
        }

        void UpdateClient()
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Укажите Код клиента для обновления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxId.Text, out int id))
            {
                MessageBox.Show("Код должен быть числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "UPDATE Клиенты SET ";
            string setClauses = "";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand("", conn);

            if (!string.IsNullOrEmpty(textBoxFio.Text)) { setClauses += "ФИО = @fio, "; cmd.Parameters.AddWithValue("@fio", textBoxFio.Text); }
            if (!string.IsNullOrEmpty(textBoxPas.Text)) { setClauses += "Серия_и_номер = @pas, "; cmd.Parameters.AddWithValue("@pas", textBoxPas.Text); }
            if (!string.IsNullOrEmpty(textBoxTel.Text)) { setClauses += "Номер_телефона = @tel, "; cmd.Parameters.AddWithValue("@tel", textBoxTel.Text); }

            if (string.IsNullOrEmpty(setClauses))
            {
                MessageBox.Show("Нет данных для обновления! Заполните хотя бы одно поле.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            setClauses = setClauses.Substring(0, setClauses.Length - 2);
            sql += setClauses + " WHERE client_id = @id";
            cmd.Parameters.AddWithValue("@id", id);
            cmd.CommandText = sql;

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные успешно обновлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err) { MessageBox.Show("Ошибка UPDATE:\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { conn.Close(); }

            RefreshDMLTable();
        }

        void DeleteClient()
        {
            if (string.IsNullOrEmpty(textBoxId.Text))
            {
                MessageBox.Show("Укажите Код клиента для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxId.Text, out int id))
            {
                MessageBox.Show("Код должен быть числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "DELETE FROM Клиенты WHERE client_id = @id";
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Клиент успешно удален!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                if (err.Message.Contains("REFERENCE") || err.Message.Contains("конфликт") || err.Message.Contains("PRIMARY KEY"))
                    MessageBox.Show("Нельзя удалить клиента, так как на него есть активные Договоры!", "Ошибка целостности", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Ошибка DELETE:\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { conn.Close(); }

            RefreshDMLTable();
        }

        void ExecuteDML(string sql, int id)
        {
            SqlConnection conn = new SqlConnection(connStr);
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@fio", textBoxFio.Text);
            cmd.Parameters.AddWithValue("@pas", string.IsNullOrEmpty(textBoxPas.Text) ? (object)DBNull.Value : textBoxPas.Text);
            cmd.Parameters.AddWithValue("@tel", string.IsNullOrEmpty(textBoxTel.Text) ? (object)DBNull.Value : textBoxTel.Text);

            try
            {
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Данные успешно добавлены!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err) { MessageBox.Show("Ошибка INSERT:\n" + err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { conn.Close(); }

            RefreshDMLTable();
        }

        private void RefreshDMLTable()
        {
            dataGridViewDML.DataSource = FillDataGridView("SELECT client_id AS [Код], ФИО, Серия_и_номер AS [Паспорт], Номер_телефона AS [Телефон] FROM Клиенты");
        }

        private void buttonShowAll_Click(object sender, EventArgs e)
        {
            RefreshDMLTable();
        }
        #endregion

        private static FormSQL f;
        public static FormSQL fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new FormSQL();
                return f;
            }
        }
        public void ShowForm() { Show(); Activate(); }
    }
}