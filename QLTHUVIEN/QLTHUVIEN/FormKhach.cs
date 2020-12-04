using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class FormKhach : Form
    {
        public FormKhach()
        {
            InitializeComponent();
        }

        private void liênHệToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new FormLienHe();
            this.Hide();
            f.Show();
        }

        private void tàiKhoảnCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTaiKhoan f = new FormTaiKhoan();
            this.Hide();
            f.Show();
        }
    }
}
