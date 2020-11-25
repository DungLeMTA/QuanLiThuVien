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
    public partial class Formmuontra : Form
    {

        public DateTime date1, date2;
        public TimeSpan time;
        public int day;
        public Formmuontra()
        {
            InitializeComponent();
        }
        Themsuaxoa t = new Themsuaxoa(); public int dem;
        private void loaddata()
        {
            //DataTable dt = t.docdulieu("select * from phieumuon");
            ////l.Text = dt.Rows.Count.ToString();
            //loadcombo();
            //if (dt != null)
            //{
            //    luoi.DataSource = dt;
            //}
            //luoi.Columns[0].HeaderText = "Mã phiếu mượn";
            //luoi.Columns[1].HeaderText = "Mã độc giả";
            //luoi.Columns[2].HeaderText = "Mã nhân viên";
            //luoi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            //xoa.Enabled = true;
            //sua.Text = "Sửa";
            //them.Enabled = true;
            //sua.Enabled = true;
            //xoa.Enabled = true;
            //luu.Enabled = false;
            //luoi.Enabled = true;
            //DataTable dt = new DataTable();

            //dt.Rows[1][0] = "AN0101";
            //dt.Rows[1][1] = "Lê Văn Phiêu";
            //dt.Rows[0][2] = "SGK0101";
            //dt.Rows[0][3] = "Sách giáo khoa TV1";
            //dt.Rows[0][4] = "01/11/2020";
            //dt.Rows[0][5] = "Chưa trả";

            //dgvDanhsach.DataSource = dt;

            dgvDanhsach.ColumnCount = 8;
            dgvDanhsach.Columns[0].HeaderText = "STT";
            dgvDanhsach.Columns[1].HeaderText = "Mã độc giả";
            dgvDanhsach.Columns[2].HeaderText = "Tên độc giả";
            dgvDanhsach.Columns[3].HeaderText = "Mã sách";
            dgvDanhsach.Columns[4].HeaderText = "Tên sách";
            dgvDanhsach.Columns[5].HeaderText = "Tác giả";
            dgvDanhsach.Columns[6].HeaderText = "Ngày mượn";
            dgvDanhsach.Columns[7].HeaderText = "Trạng thái";
            dgvDanhsach.RowCount = 3;
            dgvDanhsach.Rows[0].Cells[0].Value = "1";
            dgvDanhsach.Rows[1].Cells[0].Value = "2";
            dgvDanhsach.Rows[2].Cells[0].Value = "3";
            dgvDanhsach.Rows[0].Cells[1].Value = "AN0101";
            dgvDanhsach.Rows[1].Cells[1].Value = "AN0102";
            dgvDanhsach.Rows[2].Cells[1].Value = "AN0103";
            dgvDanhsach.Rows[0].Cells[2].Value = "Lê Văn Phiêu";
            dgvDanhsach.Rows[1].Cells[2].Value = "Trần Sang Anh";
            dgvDanhsach.Rows[2].Cells[2].Value = "Lê Duy Dũng";
            dgvDanhsach.Rows[0].Cells[3].Value = "SGK01";
            dgvDanhsach.Rows[1].Cells[3].Value = "SGK04";
            dgvDanhsach.Rows[2].Cells[3].Value = "SGK10";
            dgvDanhsach.Rows[0].Cells[4].Value = "Sách giáo khoa TV1";
            dgvDanhsach.Rows[1].Cells[4].Value = "Sách giáo khoa HH9";
            dgvDanhsach.Rows[2].Cells[4].Value = "Sách giáo khoa T11";
            dgvDanhsach.Rows[0].Cells[5].Value = "Nhà xuất bản giáo dục";
            dgvDanhsach.Rows[1].Cells[5].Value = "Nhà xuất bản giáo dục";
            dgvDanhsach.Rows[2].Cells[5].Value = "Nhà xuất bản Kim Đồng";
            dgvDanhsach.Rows[0].Cells[6].Value = "01/12/2020";
            dgvDanhsach.Rows[1].Cells[6].Value = "01/11/2020";
            dgvDanhsach.Rows[2].Cells[6].Value = "11/12/2020";

        }

        private void loadcombo()
        {
            DataTable dt = t.docdulieu("select * from docgia");
            DataTable dt1 = t.docdulieu("select * from nhanvien");
            DataTable dt2 = t.docdulieu("select * from phieumuon");
            DataTable dt3 = t.docdulieu("select * from sach");
            


            //comdocgia.DataSource = dt;
            //comdocgia.DisplayMember = "hoten";
            //comdocgia.ValueMember = "madocgia";
          
            //comnhanvien.DataSource = dt1;
            //comnhanvien.DisplayMember = "hoten";
            //comnhanvien.ValueMember = "manv";

            //commaphieumuon.DataSource = dt2;
            //commaphieumuon.DisplayMember = "maphieu";
            //commaphieumuon.ValueMember = "maphieu";

            //commasach.DataSource = dt3;
            //commasach.DisplayMember = "masach";
            //commasach.ValueMember = "masach";
            

        }
        private void loaddata1()
        {
            //DataTable dt = t.docdulieu("select * from chitietmuon");
            //l.Text = dt.Rows.Count.ToString();
            ////l.Text = dt.Rows.Count.ToString();
            ////loadcombo();
            //if (dt != null)
            //{
            //    luoi1.DataSource = dt;
            //}
            //luoi1.Columns[0].HeaderText = "Mã phiếu mượn";
            //luoi1.Columns[1].HeaderText = "Mã sách";
            //luoi1.Columns[2].HeaderText = "Ngày mượn";
            //luoi1.Columns[3].HeaderText = "Ngày trả";
            //luoi1.Columns[4].HeaderText = "Ghi chú";
            

            //xoa1.Enabled = true;
            //sua1.Text = "Gia hạn";
            //them1.Enabled = true;
            //sua1.Enabled = true;
            //xoa1.Enabled = true;
            //luu1.Enabled = false;
            //luoi1.Enabled = true;

        }


        private void Formmuontra_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata1();

        }

        private void tab2_Click(object sender, EventArgs e)
        {
            

        }

        private void luoi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void luoi_SelectionChanged(object sender, EventArgs e)
        //{
        //    txtmaphieu.Text = luoi.CurrentRow.Cells[0].Value.ToString();
        //    comdocgia.Text = luoi.CurrentRow.Cells[1].Value.ToString();
        //    comnhanvien.Text = luoi.CurrentRow.Cells[2].Value.ToString();
        //}

        private void them_Click(object sender, EventArgs e)
        {

           // DataTable dt = t.docdulieu("select * from phieumuon");
        
           //dem = dt.Rows.Count;
           // dem = dem + 1;
           // txtmaphieu.Text = dem.ToString();
           // //l.Text = dt.Rows.Count.ToString();
           // luu.Enabled = true;
           // //sua.Enabled = false;
           // xoa.Enabled = false;
           // sua.Text = "hủy";
           // them.Enabled = false;
           // luoi.Enabled = false;
        }

        private void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        //private void luu_Click(object sender, EventArgs e)
        //{


        //    if (t.thucthidulieu("INSERT INTO phieumuon VALUES (N'" + dem + "','" + comdocgia.SelectedValue.ToString() + "','" + comnhanvien.SelectedValue.ToString() + "')") == true)
        //    {

        //        MessageBox.Show("Thêm thành công");
        //        loaddata();


        //    }
        //    else
        //    {
        //        MessageBox.Show("Lỗi không thể thêm");



               

        //    }
        //}

        //private void sua_Click(object sender, EventArgs e)
        //{
        //    if (sua.Text == "hủy")
        //    {
        //        luu.Enabled = false;
        //        sua.Enabled = true;
        //        xoa.Enabled = true;
        //        xoa.Text = "Xóa";
        //        sua.Text = "Sửa";
        //        them.Enabled = true;
        //        loaddata();
        //        luoi.Enabled = true;
        //    }
        //    else
        //    {

        //        if (comdocgia.Text == "")
        //        {
        //            MessageBox.Show("Chưa chọn mã độc giả");

        //        }
        //        else if (comnhanvien.Text == "")
        //        {
        //            MessageBox.Show("Chưa nhập địa chỉ");
               


        //        }
        //        else if (t.thucthidulieu("update  phieumuon set madg=N'" + comdocgia.Text + "', manv=N'" + comnhanvien.Text +  "'where maphieu=N'" + txtmaphieu.Text + "'") == true)
        //        {

        //            MessageBox.Show("Cập nhật dữ liệu thành công");
        //            loaddata();


        //        }
        //        else MessageBox.Show("Không thể cập nhật dữ liệu");


        //    }


            
        //}

        //private void xoa_Click(object sender, EventArgs e)
        //{
        //    if (xoa.Text == "hủy")
        //    {

        //        luu.Enabled = false;
        //        sua.Enabled = true;
        //        xoa.Enabled = true;
        //        xoa.Text = "Xóa";
        //        sua.Text = "Sửa";
        //        them.Enabled = true;
        //        loaddata();
        //        luoi.Enabled = true;




        //    }
        //    else
        //    {
        //        DialogResult chon = MessageBox.Show("Bạn có muốn xóa nhân viên có mã số " + txtmaphieu.Text + "", "thông báo", MessageBoxButtons.YesNo);
        //        if (chon == DialogResult.Yes)
        //        {
        //            try
        //            {

        //                t.thucthidulieu("delete from phieumuon where maphieu='" + txtmaphieu.Text + "'");
        //                MessageBox.Show("Xóa thành Công", "Thông báo");
        //                loaddata();


        //            }
        //            catch (Exception)
        //            {
        //                MessageBox.Show("Không thể xóa", "Thông báo");
        //                throw;
        //            }

        //        }
        //        else loaddata();





        //    }
        //}

        private void luoi1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void luoi1_SelectionChanged(object sender, EventArgs e)
        {
            
            //commaphieumuon.Text = dgvDanhsach.CurrentRow.Cells[0].Value.ToString();
            //commasach.Text = dgvDanhsach.CurrentRow.Cells[1].Value.ToString();
            //ngaymuon.Text = dgvDanhsach.CurrentRow.Cells[2].Value.ToString();
            //ngaytra.Text = dgvDanhsach.CurrentRow.Cells[3].Value.ToString();
            //ghichu.Text = dgvDanhsach.CurrentRow.Cells[4].Value.ToString();
        }

        private void them1_Click(object sender, EventArgs e)
        {
            ngaymuon.Text = "";
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(-3));//lay ngay hien tai tang them 3 ngay
            ngaytra.Value = result;

           
              luu1.Enabled = true;
       
            //xoa1.Enabled = false;
            //sua1.Text = "hủy";
            //them1.Enabled = false;
            //dgvDanhsach.Enabled = false;
        }

        private void luu1_Click(object sender, EventArgs e)
        {
            //string ngayhh = ngaymuon.Value.ToString("yyyy/MM/dd");//dịnh dạng ngày để insert vào sql
            //string ngayhhh = ngaytra.Value.ToString("yyyy/MM/dd");
            //date1 = Convert.ToDateTime(ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            //date2 = Convert.ToDateTime(ngaytra.Text);
            //time = date2.Subtract(date1);
            //day = time.Days;
            //DataTable dt = t.docdulieu("select * from chitietmuon where masach= N'"+ commasach.Text+ "'");
            
            //if (dt.Rows.Count==1)
            //{
            //    MessageBox.Show("Sách đã được mượn, vui lòng chọn cuốn khác", "Thông báo");
            //    commasach.Focus();
            //} 
            //else if (day<0)
            //{
            //    MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
            //    ngaytra.Focus();

            //}
            //else if (t.thucthidulieu("INSERT INTO chitietmuon VALUES (N'" + commaphieumuon.SelectedValue.ToString() + "','" + commasach.SelectedValue.ToString() + "','" + ngayhh + "','" + ngayhhh + "','" + ghichu.Text + "')") == true)
            //{

            //    MessageBox.Show("Thêm thành công");
            //    loaddata1();
            //}
            //else
            //{
            //    MessageBox.Show("Lỗi không thể thực hiện được");
  

            //}
        }

        private void sua1_Click(object sender, EventArgs e)
        {
            //string ngayhhh = ngaytra.Value.ToString("yyyy/MM/dd");
            //date1 = Convert.ToDateTime(ngaymuon.Text);//lấy thông tin ngày mượn ngày trả để kiêm tra đk ngày mượn<=ngày trả.
            //date2 = Convert.ToDateTime(ngaytra.Text);
            //time = date2.Subtract(date1);
            //day = time.Days;
            //if (sua1.Text == "hủy")
            //{
            //    luu1.Enabled = false;
            //    sua1.Enabled = true;
            //    xoa1.Enabled = true;
            //    xoa1.Text = "Xóa";
            //    sua1.Text = "Gia hạn";
            //    them1.Enabled = true;
            //    loaddata1();
            //    dgvDanhsach.Enabled = true;
            //} else if (day < 0)
            //{
            //    MessageBox.Show("Lỗi, ngày hẹn trả không hợp lý", "Thông báo");
            //    ngaytra.Focus();

            //}
            //else if (t.thucthidulieu("update  chitietmuon set ngaytra=N'" + ngayhhh + "'where masach=N'" + commasach.Text + "'") == true)
            //    {

            //        MessageBox.Show("Gia hạn thành công");
            //        loaddata1();


            //    }
            //else MessageBox.Show("Không thể gia hạn sách");


            
        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ngaytra_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Closed_FormMuonSach(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng chương trình không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else{
                Formmuontra frm = new Formmuontra();
                frm.Show();
                 }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formchinh frm = new Formchinh();
            frm.Show();
        }

        private void luu_Click(object sender, EventArgs e)
        {
            DialogResult re = new DialogResult();
            re = MessageBox.Show("Có chắc chắn thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(re == DialogResult.Yes)
            {
                MessageBox.Show("Thêm thành công!");
            }
        }

        private void xoa1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xóa thành công");
            //if (xoa1.Text == "hủy")
            //{

            //    luu1.Enabled = false;
            //    sua1.Enabled = true;
            //    xoa1.Enabled = true;
            //    xoa1.Text = "Trả sách";
            //    sua1.Text = "Gia hạn";
            //    them1.Enabled = true;
            //    loaddata1();
            //    dgvDanhsach.Enabled = true;




            //}
            //else
            //{
            //    DialogResult chon = MessageBox.Show("Bạn có muốn xóa trả sách có mã " + commasach.Text + "", "thông báo", MessageBoxButtons.YesNo);
            //    if (chon == DialogResult.Yes)
            //    {
            //        try
            //        {

            //            t.thucthidulieu("delete from chitietmuon where masach='" + commasach.Text + "'");
            //            MessageBox.Show("Đã trả sach"+ commasach.Text +"", "Thông báo");
            //            loaddata1();


            //        }
            //        catch (Exception)
            //        {
            //            MessageBox.Show("Không thể xóa", "Thông báo");
            //            throw;
            //        }

            //    }
            //    else loaddata1();





            //}
        }
    }
}









