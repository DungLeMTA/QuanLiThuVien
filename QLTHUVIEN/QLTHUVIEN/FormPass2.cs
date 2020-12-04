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
    public partial class FormPass2 : Form
    {
        public FormPass2()
        {
            InitializeComponent();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtPass.Text == "123")
            {
                MessageBox.Show("Mật khẩu đúng");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Mật khẩu sai");
            }
        }
    }
}
