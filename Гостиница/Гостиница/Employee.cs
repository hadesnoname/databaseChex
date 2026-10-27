using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гостиница
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.сотрудникиBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.гостиницаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гостиницаDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.гостиницаDataSet.Сотрудники);

        }

        private static Employee f;
        public static Employee fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Employee();
                return f;
            }
        }
        public void ShowForm()
        {
            Show();
            Activate();
        }

        private void сотрудникиDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if ((сотрудникиDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value == null) ||
                (сотрудникиDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString() == ""))
            {
                e.CellStyle.BackColor = Color.LightGreen;
            }
            else
            {
                string dolzhnost = сотрудникиDataGridView.Rows[e.RowIndex].Cells["dataGridViewTextBoxColumn2"].Value.ToString();

                switch (dolzhnost.ToLower())
                {
                    case "администратор":
                        e.CellStyle.BackColor = Color.Red;
                        break;
                    case "управляющий":
                        e.CellStyle.BackColor = Color.Gold;
                        break;
                    default:
                        e.CellStyle.BackColor = Color.White;
                        break;
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

                for (int i = 0; i < сотрудникиBindingSource.Count; i++)
                {
                    DataRowView row = (DataRowView)сотрудникиBindingSource[i];
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
                    сотрудникиBindingSource.Position = 0;
                }
                else if (foundIndexes.Count == 1)
                {
                    сотрудникиBindingSource.Position = foundIndexes[0];
                }
                else
                {
                    // Перебираем найденных сотрудников по кругу
                    int currentPosition = сотрудникиBindingSource.Position;
                    int nextIndex = foundIndexes.FindIndex(idx => idx > currentPosition);

                    if (nextIndex == -1)
                    {
                        сотрудникиBindingSource.Position = foundIndexes[0];
                    }
                    else
                    {
                        сотрудникиBindingSource.Position = foundIndexes[nextIndex];
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
               (int)((DataRowView)сотрудникиBindingSource.Current)["employee_id"];
            else
                return -1;
        }

        private void Employee_Shown(object sender, EventArgs e)
        {
            сотрудникиBindingSource.Position = сотрудникиBindingSource.Find("employee_id", idCurrent);
        }
    }
}