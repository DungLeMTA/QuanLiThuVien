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
    public partial class Formthongkedocgia : Form
    {
        public Formthongkedocgia()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa();
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void loaddata()
        {
            DataTable dt = t.docdulieu("select * from docgia");

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã độc giả";
            luoi.Columns[1].HeaderText = "Tên độc giả";
            luoi.Columns[2].HeaderText = "Ngày sinh";
            luoi.Columns[3].HeaderText = "Giới";
            luoi.Columns[4].HeaderText = "Lớp";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }
        private void loaddata2()
        {
            DataTable dt = t.docdulieu("select distinct docgia.madocgia,docgia.hoten, docgia.ngaysinh,docgia.gioitinh, docgia.thongtin from docgia, phieumuon,chitietmuon where (docgia.madocgia=phieumuon.madg and phieumuon.maphieu=chitietmuon.mapm and chitietmuon.ngaytra<GETDATE())");
         

            if (dt != null)
            {
                luoi.DataSource = dt;
            }
            luoi.Columns[0].HeaderText = "Mã độc giả";
            luoi.Columns[1].HeaderText = "Tên độc giả";
            luoi.Columns[2].HeaderText = "Ngày sinh";
            luoi.Columns[3].HeaderText = "Giới";
            luoi.Columns[4].HeaderText = "Lớp";
            //  luoi.Columns[5].HeaderText = "Mã tác giả";
            luoi.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);

            luoi.Enabled = true;

        }

        private void Formthongkedocgia_Load(object sender, EventArgs e)
        {
            loaddata();
            tuychon.Text = "Tất cả độc giả";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tuychon.Text == "Tất cả độc giả")
                loaddata();
            else loaddata2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();

            DataTable dt = (DataTable)luoi.DataSource;
            excel.Export(dt, "Độc giả", "Thống kê độc giả");
           
        }
    }
}
