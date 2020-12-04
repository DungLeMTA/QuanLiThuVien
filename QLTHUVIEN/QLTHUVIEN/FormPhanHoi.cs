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
    public partial class FormPhanHoi : Form
    {
        public FormPhanHoi()
        {
            InitializeComponent();
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void FormPhanHoi_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Đã xóa");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formchinh f = new Formchinh();
            this.Hide();
            f.Show();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label6.Font = new Font("Times New Roman",16, FontStyle.Regular);

            
        }

        private void label10_Click(object sender, EventArgs e)
        {
            label10.Font = new Font("Times New Roman", 16, FontStyle.Regular);
        }
    }
}
