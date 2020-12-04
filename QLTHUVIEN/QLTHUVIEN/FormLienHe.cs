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
    public partial class FormLienHe : Form
    {
        public FormLienHe()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTieuDe.Text == "")
            {

                MessageBox.Show("Chưa nhập tiêu đề");
            }
            else
            {
                if(rtbNoiDung.Text == "")
                {
                    MessageBox.Show("Chưa điền nội dung");
                }
                else
                {
                    MessageBox.Show("Gửi thành công");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn có muốn hủy không?","Cảnh báo",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(re == DialogResult.Yes)
            {
                this.Hide();
                Form f = new FormKhach();
                f.Show();
            }
        }
    }
}
