using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гостиница
{
    public partial class Contract : Form
    {
        public Contract()
        {
            InitializeComponent();
        }

        private void договорыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.договорыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.гостиницаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Contract_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гостиницаDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.гостиницаDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гостиницаDataSet.Номера_в_гостинице". При необходимости она может быть перемещена или удалена.
            this.номера_в_гостиницеTableAdapter.Fill(this.гостиницаDataSet.Номера_в_гостинице);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гостиницаDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.гостиницаDataSet.Сотрудники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гостиницаDataSet.Договоры". При необходимости она может быть перемещена или удалена.
            this.договорыTableAdapter.Fill(this.гостиницаDataSet.Договоры);

            договорыBindingSource.PositionChanged += договорыBindingSource_PositionChanged_1;

            // Обновляем label при загрузке формы
            UpdateEmployeeLabel();
            UpdateRoomLabel();
            UpdateClientLabel();
        }

        private static Contract f;
        public static Contract fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Contract();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void договорыDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < договорыDataGridView.Rows.Count)
            {
                var statusCell = договорыDataGridView.Rows[e.RowIndex].Cells["dataGridViewCheckBoxColumn1"];

                if (statusCell.Value != null)
                {
                    bool isActive = false;

                    if (statusCell.Value is bool)
                    {
                        isActive = (bool)statusCell.Value;
                    }
                    else if (statusCell.Value != DBNull.Value)
                    {
                        bool.TryParse(statusCell.Value.ToString(), out isActive);
                    }

                    if (isActive)
                    {
                        e.CellStyle.BackColor = Color.LightGreen;
                        e.CellStyle.ForeColor = Color.DarkGreen;
                    }
                    else
                    {
                        e.CellStyle.BackColor = Color.LightCoral;
                        e.CellStyle.ForeColor = Color.DarkRed;
                    }
                }
                else
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                    e.CellStyle.ForeColor = Color.DarkRed;
                }
            }
        }

        private void toolStripButtonFind_Click(object sender, EventArgs e)
        {
            if (toolStripTextBoxFind.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (comboBoxSearchColumn.SelectedItem == null)
            {
                MessageBox.Show("Выберите столбец для поиска", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string searchValue = toolStripTextBoxFind.Text.Trim();
                string selectedColumn = comboBoxSearchColumn.SelectedItem.ToString();

                List<int> foundIndexes = new List<int>();

                for (int i = 0; i < договорыBindingSource.Count; i++)
                {
                    DataRowView row = (DataRowView)договорыBindingSource[i];
                    object cellValue = row[selectedColumn];

                    if (cellValue != null && cellValue.ToString().IndexOf(searchValue, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        foundIndexes.Add(i);
                    }
                }

                if (foundIndexes.Count == 0)
                {
                    MessageBox.Show($"Значение '{searchValue}' не найдено в столбце '{selectedColumn}'", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    договорыBindingSource.Position = 0;
                }
                else if (foundIndexes.Count == 1)
                {
                    договорыBindingSource.Position = foundIndexes[0];
                }
                else
                {
                    // Перебираем найденных сотрудников по кругу
                    int currentPosition = договорыBindingSource.Position;
                    int nextIndex = foundIndexes.FindIndex(idx => idx > currentPosition);

                    if (nextIndex == -1)
                    {
                        договорыBindingSource.Position = foundIndexes[0];
                    }
                    else
                    {
                        договорыBindingSource.Position = foundIndexes[nextIndex];
                    }

                    MessageBox.Show($"Найдено {foundIndexes.Count} записей в столбце '{selectedColumn}'. " +
                                   "Нажимайте 'Поиск' еще раз для перехода к следующей.",
                                   "Найдено несколько",
                                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }

        }

        private void buttonWorker_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)договорыBindingSource.Current)["employee_id"].ToString() != "")
            {
                id = (int)(((DataRowView)договорыBindingSource.Current)["employee_id"]);
            }

            id = Employee.fw.ShowSelectForm(id);
            if (id >= 0)
            {
                ((DataRowView)договорыBindingSource.Current)["employee_id"] = id;
                договорыBindingSource.EndEdit();
                UpdateEmployeeLabel(id);
            }
        }

        // Метод для обновления label с ФИО сотрудника
        private void UpdateEmployeeLabel()
        {
            if (договорыBindingSource.Current != null)
            {
                var currentRow = (DataRowView)договорыBindingSource.Current;
                if (currentRow["employee_id"] != DBNull.Value)
                {
                    int employeeId = (int)currentRow["employee_id"];
                    UpdateEmployeeLabel(employeeId);
                }
                else
                {
                    label2.Text = "Сотрудник не выбран";
                }
            }
        }

        private void договорыBindingSource_PositionChanged_1(object sender, EventArgs e)
        {
            UpdateEmployeeLabel();
            UpdateRoomLabel();
            UpdateClientLabel();
        }

        private void buttonRoom_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)договорыBindingSource.Current)["room_id"].ToString() != "")
            {
                id = (int)(((DataRowView)договорыBindingSource.Current)["room_id"]);
            }

            id = RoomInHotel.fw.ShowSelectForm(id);
            if (id >= 0)
            {
                ((DataRowView)договорыBindingSource.Current)["room_id"] = id;
                договорыBindingSource.EndEdit();
                UpdateRoomLabel(id);
            }
        }

        private void UpdateEmployeeLabel(int employeeId)
        {
            try
            {
                var employeeRow = гостиницаDataSet.Сотрудники.FindByemployee_id(employeeId);
                if (employeeRow != null)
                {
                    string fio = employeeRow["ФИО"].ToString();
                    label2.Text = fio;
                }
                else
                {
                    label2.Text = "Сотрудник не найден";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении данных сотрудника: " + ex.Message);
                label2.Text = "Ошибка";
            }
        }

        private void UpdateRoomLabel()
        {
            if (договорыBindingSource.Current != null)
            {
                var currentRow = (DataRowView)договорыBindingSource.Current;
                if (currentRow["room_id"] != DBNull.Value)
                {
                    int roomId = (int)currentRow["room_id"];
                    UpdateRoomLabel(roomId);
                }
                else
                {
                    // Замени label4 на имя твоего Label для категории номера
                    label4.Text = "Категория не выбрана";
                }
            }
        }

        private void UpdateRoomLabel(int roomId)
        {
            try
            {
                // Находим номер в таблице номеров
                var roomRow = гостиницаDataSet.Номера_в_гостинице.FindByroom_id(roomId);
                if (roomRow != null && roomRow["Категория"] != DBNull.Value)
                {
                    string category = roomRow["Категория"].ToString();
                    label4.Text = category; // Просто название категории
                }
                else
                {
                    label4.Text = "Категория не найдена";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении категории номера: " + ex.Message);
                label4.Text = "Ошибка";
            }
        }

        private void buttonClient_Click(object sender, EventArgs e)
        {
            int id = -1;
            if (((DataRowView)договорыBindingSource.Current)["client_id"].ToString() != "")
            {
                id = (int)(((DataRowView)договорыBindingSource.Current)["client_id"]);
            }

            id = Client.fw.ShowSelectForm(id);
            if (id >= 0)
            {
                ((DataRowView)договорыBindingSource.Current)["client_id"] = id;
                договорыBindingSource.EndEdit();
                UpdateClientLabel(id); // Обновляем Label после выбора
            }
        }


        private void UpdateClientLabel()
        {
            if (договорыBindingSource.Current != null)
            {
                var currentRow = (DataRowView)договорыBindingSource.Current;
                if (currentRow["client_id"] != DBNull.Value)
                {
                    int clientId = (int)currentRow["client_id"];
                    UpdateClientLabel(clientId);
                }
                else
                {
                    label6.Text = "Клиент не выбран";
                }
            }
        }

        private void UpdateClientLabel(int clientId)
        {
            try
            {
                var clientRow = гостиницаDataSet.Клиенты.FindByclient_id(clientId);
                if (clientRow != null)
                {
                    string fio = clientRow["ФИО"].ToString();
                    label6.Text = fio;
                }
                else
                {
                    label6.Text = "Клиент не найден";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при получении данных клиента: " + ex.Message);
                label6.Text = "Ошибка";
            }
        }
    }
}
