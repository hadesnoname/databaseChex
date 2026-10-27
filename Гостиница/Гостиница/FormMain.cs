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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FromMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = MessageBox.Show("Вы хотите закрыть программу?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes;

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР,ФВС,Чех С. В.,группа 523,2026", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client.fw.ShowForm();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Employee.fw.ShowForm();
        }

        private void номераВГостиницеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoomInHotel.fw.ShowForm();
        }

        private void договорыToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Contract.fw.ShowForm();
        }

        private void sQLЗапросыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSQL.fw.ShowForm();
        }
    }
}
