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
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.клиентыBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.гостиницаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Client_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гостиницаDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.гостиницаDataSet.Клиенты);
        }

        private static Client f;
        public static Client fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Client();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
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

                for (int i = 0; i < клиентыBindingSource.Count; i++)
                {
                    DataRowView row = (DataRowView)клиентыBindingSource[i];
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
                    клиентыBindingSource.Position = 0;
                }
                else if (foundIndexes.Count == 1)
                {
                    клиентыBindingSource.Position = foundIndexes[0];
                }
                else
                {
                    // Перебираем найденных сотрудников по кругу
                    int currentPosition = клиентыBindingSource.Position;
                    int nextIndex = foundIndexes.FindIndex(idx => idx > currentPosition);

                    if (nextIndex == -1)
                    {
                        клиентыBindingSource.Position = foundIndexes[0];
                    }
                    else
                    {
                        клиентыBindingSource.Position = foundIndexes[nextIndex];
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

        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (int)((DataRowView)клиентыBindingSource.Current)["client_id"];
            else
                return -1;
        }

        private void Client_Shown(object sender, EventArgs e)
        {
            клиентыBindingSource.Position = клиентыBindingSource.Find("client_id", idCurrent);
        }
    }
}
