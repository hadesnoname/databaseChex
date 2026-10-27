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
    public partial class RoomInHotel : Form
    {
        public RoomInHotel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "гостиницаDataSet.Номера_в_гостинице". При необходимости она может быть перемещена или удалена.
            this.номера_в_гостиницеTableAdapter.Fill(this.гостиницаDataSet.Номера_в_гостинице);
            номера_в_гостиницеBindingSource.PositionChanged += номера_в_гостиницеBindingSource_PositionChanged;

            // Обновляем label при загрузке формы
            UpdateCategoryLabel();
        }

        private void номера_в_гостиницеBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.номера_в_гостиницеBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.гостиницаDataSet);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        string fileImage = "";
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialogPhoto.Title = "Укажите файл для фото";
            if (openFileDialogPhoto.ShowDialog() == DialogResult.OK)
            {
                fileImage = openFileDialogPhoto.FileName;
                фотографияPictureBox.Image = new
               Bitmap(openFileDialogPhoto.FileName);

            }
            else fileImage = "";
        }

        private static RoomInHotel f;
        public static RoomInHotel fw
        {
            get
            {
                if (f == null || f.IsDisposed) f = new RoomInHotel();
                return f;
            }
        }

        public void ShowForm()
        {
            Show();
            Activate();
        }

        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButton1.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
               (int)((DataRowView)номера_в_гостиницеBindingSource.Current)["room_id"];
            else
                return -1;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void UpdateCategoryLabel()
        {
            if (номера_в_гостиницеBindingSource.Current != null)
            {
                var currentRow = (DataRowView)номера_в_гостиницеBindingSource.Current;
                if (currentRow["Категория"] != DBNull.Value)
                {
                    string category = currentRow["Категория"].ToString();
                    // Замени labelCategory на имя твоего Label в RoomInHotel форме
                    категорияComboBox.Text = category;
                }
                else
                {
                    категорияComboBox.Text = "Категория не выбрана";
                }
            }
        }

        private void номера_в_гостиницеBindingSource_PositionChanged(object sender, EventArgs e)
        {
            UpdateCategoryLabel();
        }

        private void RoomInHotel_Shown(object sender, EventArgs e)
        {
            if (idCurrent >= 0)
            {
                номера_в_гостиницеBindingSource.Position = номера_в_гостиницеBindingSource.Find("room_id", idCurrent);
            }
            UpdateCategoryLabel();
        }
    }
}
