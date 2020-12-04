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
        public DataTable dt;
        public DataGridView dgvDanhSach;
        public DateTime date1, date2;
        public TimeSpan time;
        public int day;
        bool MaDocGia = true;
        bool SoLuong = true;
        bool Ma1 = true;
        bool Ma2 = true;
        bool Ma3 = true;
        public Formmuontra()
        {
            dgvDanhsach = new DataGridView();
            {

                dgvDanhsach.Location = new Point(7, 341);
                dgvDanhsach.Size = new Size(678, 196);
                dgvDanhsach.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dgvNhanVien.ReadOnly = true;

                dgvDanhsach.ColumnCount = 9;
                dgvDanhsach.Columns[0].HeaderText = "STT";
                dgvDanhsach.Columns[1].HeaderText = "Mã độc giả";
                dgvDanhsach.Columns[2].HeaderText = "Tên độc giả";
                dgvDanhsach.Columns[3].HeaderText = "Mã sách";
                dgvDanhsach.Columns[4].HeaderText = "Tên sách";
                dgvDanhsach.Columns[5].HeaderText = "Tác giả";
                dgvDanhsach.Columns[6].HeaderText = "Ngày mượn";
                dgvDanhsach.Columns[7].HeaderText = "Số lượng đang mượn";
                dgvDanhsach.Columns[8].HeaderText = "Trạng thái";
                dgvDanhsach.RowCount = 6;
                dgvDanhsach.Rows[0].Cells[0].Value = "1";
                dgvDanhsach.Rows[1].Cells[0].Value = "2";
                dgvDanhsach.Rows[2].Cells[0].Value = "3";
                dgvDanhsach.Rows[3].Cells[0].Value = "4";
                dgvDanhsach.Rows[4].Cells[0].Value = "5";
                dgvDanhsach.Rows[5].Cells[0].Value = "6";

                dgvDanhsach.Rows[0].Cells[1].Value = "AN0101";
                dgvDanhsach.Rows[1].Cells[1].Value = "AN0102";
                dgvDanhsach.Rows[2].Cells[1].Value = "AN0103";
                dgvDanhsach.Rows[3].Cells[1].Value = "AN0104";
                dgvDanhsach.Rows[4].Cells[1].Value = "AN0105";
                dgvDanhsach.Rows[5].Cells[1].Value = "AN0106";


                dgvDanhsach.Rows[0].Cells[2].Value = "Lê Văn Phiêu";
                dgvDanhsach.Rows[1].Cells[2].Value = "Trần Sang Anh";
                dgvDanhsach.Rows[2].Cells[2].Value = "Lê Duy Dũng";
                dgvDanhsach.Rows[3].Cells[2].Value = "Mạnh Tuấn Đạt";
                dgvDanhsach.Rows[4].Cells[2].Value = "SoneXay";
                dgvDanhsach.Rows[5].Cells[2].Value = "Lê Duy Dũng";

                dgvDanhsach.Rows[0].Cells[3].Value = "SGK1000";
                dgvDanhsach.Rows[1].Cells[3].Value = "SGK1001";
                dgvDanhsach.Rows[2].Cells[3].Value = "SGK1010";
                dgvDanhsach.Rows[3].Cells[3].Value = "SGK1000";
                dgvDanhsach.Rows[4].Cells[3].Value = "SGK1010";
                dgvDanhsach.Rows[5].Cells[3].Value = "SGK1001";


                dgvDanhsach.Rows[0].Cells[4].Value = "Sách giáo khoa TV1";
                dgvDanhsach.Rows[1].Cells[4].Value = "Sách giáo khoa HH9";
                dgvDanhsach.Rows[2].Cells[4].Value = "Sách giáo khoa T11";
                dgvDanhsach.Rows[3].Cells[4].Value = "Sách Tiếng Anh 9";
                dgvDanhsach.Rows[4].Cells[4].Value = "Sách giáo khoa Ngữ Văn";
                dgvDanhsach.Rows[5].Cells[4].Value = "Sách Bé tập tô";


                dgvDanhsach.Rows[0].Cells[5].Value = "Nhà xuất bản giáo dục";
                dgvDanhsach.Rows[1].Cells[5].Value = "Nhà xuất bản ĐH Quốc Gia";
                dgvDanhsach.Rows[2].Cells[5].Value = "Nhà xuất bản Kim Đồng";
                dgvDanhsach.Rows[3].Cells[5].Value = "Nhà xuất bản giáo dục";
                dgvDanhsach.Rows[4].Cells[5].Value = "Nhà xuất bản Hà Nội";
                dgvDanhsach.Rows[5].Cells[5].Value = "Nhà xuất bản Kim Đồng";

                dgvDanhsach.Rows[0].Cells[6].Value = "01/12/2020";
                dgvDanhsach.Rows[1].Cells[6].Value = "01/11/2020";
                dgvDanhsach.Rows[2].Cells[6].Value = "11/12/2020";
                dgvDanhsach.Rows[3].Cells[6].Value = "15/12/2020";
                dgvDanhsach.Rows[4].Cells[6].Value = "09/11/2020";
                dgvDanhsach.Rows[5].Cells[6].Value = "12/12/2020";

                dgvDanhsach.Rows[0].Cells[7].Value = "3";
                dgvDanhsach.Rows[1].Cells[7].Value = "1";
                dgvDanhsach.Rows[2].Cells[7].Value = "2";
                dgvDanhsach.Rows[3].Cells[7].Value = "1";
                dgvDanhsach.Rows[4].Cells[7].Value = "3";
                dgvDanhsach.Rows[5].Cells[7].Value = "2";

                dgvDanhsach.Rows[0].Cells[8].Value = "Xanh";
                dgvDanhsach.Rows[1].Cells[8].Value = "Vàng";
                dgvDanhsach.Rows[2].Cells[8].Value = "Đỏ";
                dgvDanhsach.Rows[3].Cells[8].Value = "Xanh";
                dgvDanhsach.Rows[4].Cells[8].Value = "Vàng";
                dgvDanhsach.Rows[5].Cells[8].Value = "Xanh";
            }
            dt = new DataTable();
            {
                dt = (DataTable)dgvDanhsach.DataSource;
            }
            InitializeComponent();


        }
        Themsuaxoa t = new Themsuaxoa(); public int dem;
        public void loaddata()
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


            //dgvDanhsach.DataSource = dt;

            dgvDanhsach.ColumnCount = 9;
            dgvDanhsach.Columns[0].HeaderText = "STT";
            dgvDanhsach.Columns[1].HeaderText = "Mã độc giả";
            dgvDanhsach.Columns[2].HeaderText = "Tên độc giả";
            dgvDanhsach.Columns[3].HeaderText = "Mã sách";
            dgvDanhsach.Columns[4].HeaderText = "Tên sách";
            dgvDanhsach.Columns[5].HeaderText = "Tác giả";
            dgvDanhsach.Columns[6].HeaderText = "Ngày mượn";
            dgvDanhsach.Columns[7].HeaderText = "Số lượng đang mượn";
            dgvDanhsach.Columns[8].HeaderText = "Trạng thái";
            dgvDanhsach.RowCount = 6;
            dgvDanhsach.Rows[0].Cells[0].Value = "1";
            dgvDanhsach.Rows[1].Cells[0].Value = "2";
            dgvDanhsach.Rows[2].Cells[0].Value = "3";
            dgvDanhsach.Rows[3].Cells[0].Value = "4";
            dgvDanhsach.Rows[4].Cells[0].Value = "5";
            dgvDanhsach.Rows[5].Cells[0].Value = "6";

            dgvDanhsach.Rows[0].Cells[1].Value = "AN0101";
            dgvDanhsach.Rows[1].Cells[1].Value = "AN0102";
            dgvDanhsach.Rows[2].Cells[1].Value = "AN0103";
            dgvDanhsach.Rows[3].Cells[1].Value = "AN0104";
            dgvDanhsach.Rows[4].Cells[1].Value = "AN0105";
            dgvDanhsach.Rows[5].Cells[1].Value = "AN0106";


            dgvDanhsach.Rows[0].Cells[2].Value = "Lê Văn Phiêu";
            dgvDanhsach.Rows[1].Cells[2].Value = "Trần Sang Anh";
            dgvDanhsach.Rows[2].Cells[2].Value = "Lê Duy Dũng";
            dgvDanhsach.Rows[3].Cells[2].Value = "Mạnh Tuấn Đạt";
            dgvDanhsach.Rows[4].Cells[2].Value = "SoneXay";
            dgvDanhsach.Rows[5].Cells[2].Value = "Lê Duy Dũng";

            dgvDanhsach.Rows[0].Cells[3].Value = "SGK1000";
            dgvDanhsach.Rows[1].Cells[3].Value = "SGK1001";
            dgvDanhsach.Rows[2].Cells[3].Value = "SGK1010";
            dgvDanhsach.Rows[3].Cells[3].Value = "SGK1000";
            dgvDanhsach.Rows[4].Cells[3].Value = "SGK1010";
            dgvDanhsach.Rows[5].Cells[3].Value = "SGK1001";


            dgvDanhsach.Rows[0].Cells[4].Value = "Sách giáo khoa TV1";
            dgvDanhsach.Rows[1].Cells[4].Value = "Sách giáo khoa HH9";
            dgvDanhsach.Rows[2].Cells[4].Value = "Sách giáo khoa T11";
            dgvDanhsach.Rows[3].Cells[4].Value = "Sách Tiếng Anh 9";
            dgvDanhsach.Rows[4].Cells[4].Value = "Sách giáo khoa Ngữ Văn";
            dgvDanhsach.Rows[5].Cells[4].Value = "Sách Bé tập tô";


            dgvDanhsach.Rows[0].Cells[5].Value = "Nhà xuất bản giáo dục";
            dgvDanhsach.Rows[1].Cells[5].Value = "Nhà xuất bản ĐH Quốc Gia";
            dgvDanhsach.Rows[2].Cells[5].Value = "Nhà xuất bản Kim Đồng";
            dgvDanhsach.Rows[3].Cells[5].Value = "Nhà xuất bản giáo dục";
            dgvDanhsach.Rows[4].Cells[5].Value = "Nhà xuất bản Hà Nội";
            dgvDanhsach.Rows[5].Cells[5].Value = "Nhà xuất bản Kim Đồng";

            dgvDanhsach.Rows[0].Cells[6].Value = "01/12/2020";
            dgvDanhsach.Rows[1].Cells[6].Value = "01/11/2020";
            dgvDanhsach.Rows[2].Cells[6].Value = "11/12/2020";
            dgvDanhsach.Rows[3].Cells[6].Value = "15/12/2020";
            dgvDanhsach.Rows[4].Cells[6].Value = "09/11/2020";
            dgvDanhsach.Rows[5].Cells[6].Value = "12/12/2020";

            dgvDanhsach.Rows[0].Cells[7].Value = "3";
            dgvDanhsach.Rows[1].Cells[7].Value = "1";
            dgvDanhsach.Rows[2].Cells[7].Value = "2";
            dgvDanhsach.Rows[3].Cells[7].Value = "1";
            dgvDanhsach.Rows[4].Cells[7].Value = "3";
            dgvDanhsach.Rows[5].Cells[7].Value = "2";

            dgvDanhsach.Rows[0].Cells[8].Value = "Xanh";
            dgvDanhsach.Rows[1].Cells[8].Value = "Vàng";
            dgvDanhsach.Rows[2].Cells[8].Value = "Đỏ";
            dgvDanhsach.Rows[3].Cells[8].Value = "Xanh";
            dgvDanhsach.Rows[4].Cells[8].Value = "Vàng";
            dgvDanhsach.Rows[5].Cells[8].Value = "Xanh";

            dt = (DataTable)dgvDanhsach.DataSource;
        }

        public void loadcombo()
        {



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
        public void loaddata1()
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


        public void Formmuontra_Load(object sender, EventArgs e)
        {
            loaddata();
            loaddata1();

        }

        public void tab2_Click(object sender, EventArgs e)
        {


        }

        //public void luoi_SelectionChanged(object sender, EventArgs e)
        //{
        //    txtmaphieu.Text = luoi.CurrentRow.Cells[0].Value.ToString();
        //    comdocgia.Text = luoi.CurrentRow.Cells[1].Value.ToString();
        //    comnhanvien.Text = luoi.CurrentRow.Cells[2].Value.ToString();
        //}

        public void them_Click(object sender, EventArgs e)
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

        public void thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f = new Formchinh();
            f.Show();
        }

        //public void luu_Click(object sender, EventArgs e)
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

        //public void sua_Click(object sender, EventArgs e)
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

        //public void xoa_Click(object sender, EventArgs e)
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



        public void luoi1_SelectionChanged(object sender, EventArgs e)
        {

            //commaphieumuon.Text = dgvDanhsach.CurrentRow.Cells[0].Value.ToString();
            //commasach.Text = dgvDanhsach.CurrentRow.Cells[1].Value.ToString();
            //ngaymuon.Text = dgvDanhsach.CurrentRow.Cells[2].Value.ToString();
            //ngaytra.Text = dgvDanhsach.CurrentRow.Cells[3].Value.ToString();
            //ghichu.Text = dgvDanhsach.CurrentRow.Cells[4].Value.ToString();
        }

        public void them1_Click(object sender, EventArgs e)
        {
            ngaymuon.Text = "";
            DateTime result = DateTime.Today.Subtract(TimeSpan.FromDays(-3));//lay ngay hien tai tang them 3 ngay
            ngaytra.Value = result;


            btnXoa.Enabled = true;

            //xoa1.Enabled = false;
            //sua1.Text = "hủy";
            //them1.Enabled = false;
            //dgvDanhsach.Enabled = false;
        }

        public void luu1_Click(object sender, EventArgs e)
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

        public void sua1_Click(object sender, EventArgs e)
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

        public void label26_Click(object sender, EventArgs e)
        {

        }

        public void label7_Click(object sender, EventArgs e)
        {

        }

        public void label6_Click(object sender, EventArgs e)
        {

        }

        public void ngaytra_ValueChanged(object sender, EventArgs e)
        {

        }

        public void Closed_FormMuonSach(object sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đóng chương trình không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                Formmuontra frm = new Formmuontra();
                frm.Show();
            }

        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Formchinh frm = new Formchinh();
            frm.Show();
        }

        public void luu_Click(object sender, EventArgs e)
        {
            if (MaDocGia == true && SoLuong == true && Ma1 == true && Ma2 == true && Ma3 == true)
            {
                DialogResult re = new DialogResult();
                re = MessageBox.Show("Có chắc chắn thêm không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (re == DialogResult.Yes)
                {
                    loaddata();
                    MessageBox.Show("Thêm thành công!");
                    dgvDanhsach.RowCount += 1;
                    int a = dgvDanhsach.RowCount - 1;
                    dgvDanhsach.Rows[a].Cells[0].Value = "7";//(Int32.Parse(dgvDanhsach.Rows[a - 1].Cells[0].Value.ToString()) + 1).ToString();
                    dgvDanhsach.Rows[a].Cells[1].Value = txtMaDocGia.Text;
                    dgvDanhsach.Rows[a].Cells[2].Value = txtTenDocGia.Text;
                    dgvDanhsach.Rows[a].Cells[3].Value = txtMa1.Text;
                    dgvDanhsach.Rows[a].Cells[4].Value = txtTenSach1.Text;
                    dgvDanhsach.Rows[a].Cells[5].Value = txtTacGia1.Text;
                    dgvDanhsach.Rows[a].Cells[6].Value = DateTime.Now;
                    dgvDanhsach.Rows[a].Cells[7].Value = Int32.Parse(txtSLDangMuon.Text) + 1;
                    dgvDanhsach.Rows[a].Cells[8].Value = "Xanh";
                }
            }
            else
            {
                MessageBox.Show("Chưa điền đủ thông tin!");
            }

        }

        public void txtMaDocGia_TextChanged(object sender, EventArgs e)
        {
            if (cbSLMuon.Text != "")
            {

            }
            if (txtMaDocGia.Text == "AN1010" | txtMaDocGia.Text == "AN1000" | txtMaDocGia.Text == "AN1001")
            {
                pbMaDocGia.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\V.png");
                if (txtMaDocGia.Text == "AN1010")
                {
                    txtTenDocGia.Text = "Nguyễn Công Phượng";
                    txtSLDangMuon.Text = "2";
                }
                if (txtMaDocGia.Text == "AN1000")
                {
                    txtTenDocGia.Text = "Nguyễn Quang Hải";
                    txtSLDangMuon.Text = "0";
                }
                if (txtMaDocGia.Text == "AN1001")
                {
                    txtTenDocGia.Text = "Đặng Văn Lâm";
                    txtSLDangMuon.Text = "1";
                }
                cbSLMuon.Enabled = true;

            }
            else
            {
                cbSLMuon.Enabled = false;
                pbMaDocGia.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\X.png");
            }
        }

        public void SetMacDinhcbSLMuon()
        {
            txtMa1.Text = "";
            txtMa2.Text = "";
            txtMa3.Text = "";
            txtTenSach1.Text = "";
            txtTenSach2.Text = "";
            txtTenSach3.Text = "";
            txtTacGia1.Text = "";
            txtTacGia2.Text = "";
            txtTacGia3.Text = "";
            txtMa1.Enabled = false;
            txtMa2.Enabled = false;
            txtMa3.Enabled = false;
            Ma1 = true;
            Ma2 = true;
            Ma3 = true;
        }

        public void cbSLMuon_textChanged(object sender, EventArgs e)
        {
            if (Int32.Parse(txtSLDangMuon.Text) + Int32.Parse(cbSLMuon.Text) <= 3)
            {
                if (txtMa1.Text != "")
                {
                    DialogResult re = new DialogResult();
                    re = MessageBox.Show("Bạn có muốn thay đổi lựa chọn không?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (re == DialogResult.Yes)
                    {
                        SetMacDinhcbSLMuon();
                    }

                }
                SoLuong = true;
                pbSLMuon.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\V.png");
                if (Int32.Parse(cbSLMuon.Text) == 1)
                {
                    txtMa1.Enabled = true;
                    txtMa2.Enabled = false;
                    txtMa3.Enabled = false;
                    Ma1 = false;
                    Ma2 = true;
                    Ma3 = true;
                }
                if (Int32.Parse(cbSLMuon.Text) == 2)
                {
                    txtMa1.Enabled = true;
                    txtMa2.Enabled = true;
                    txtMa3.Enabled = false;
                    Ma1 = false;
                    Ma2 = false;
                    Ma3 = true;
                }
                if (Int32.Parse(cbSLMuon.Text) == 3)
                {
                    txtMa1.Enabled = true;
                    txtMa2.Enabled = true;
                    txtMa3.Enabled = true;
                    Ma1 = false;
                    Ma2 = false;
                    Ma3 = false;
                }

            }
            else
            {
                SoLuong = false;
                pbSLMuon.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\X.png");
            }
        }

        public void txtMa1_TextChanged(object sender, EventArgs e)
        {
            if (txtMa1.Text == "SGK1000" | txtMa1.Text == "SGK1001" | txtMa1.Text == "SGK1010")
            {
                pbMa1.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\V.png");
                Ma1 = true;
                if (txtMa1.Text == "SGK1000")
                {
                    txtTenSach1.Text = "Sách giáo khoa Hóa học 9";
                    txtTacGia1.Text = "Nhà xuất bản Giáo dục";
                    pbAnh1.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\hoahoc.png");
                }
                if (txtMa1.Text == "SGK1001")
                {
                    txtTenSach1.Text = "Sách giáo khoa Ngữ Văn 11";
                    txtTacGia1.Text = "Nhà xuất bản Giáo dục";
                    pbAnh1.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\nguvan.png");
                }
                if (txtMa1.Text == "SGK1010")
                {
                    txtTenSach1.Text = "Tôi yêu em";
                    txtTacGia1.Text = "Lép tôn tôi";
                    pbAnh1.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\tv.jpg");
                }
            }
            else
            {
                Ma1 = false;
                pbMa1.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\X.png");
                txtTenSach1.Text = "";
                txtTacGia1.Text = "";
                pbAnh1.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\anhxam.jpg");
            }
        }

        public void txtMa2_TextChanged(object sender, EventArgs e)
        {
            if (txtMa2.Text == "SGK1000" | txtMa2.Text == "SGK1001" | txtMa2.Text == "SGK1010")
            {
                pbMa2.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\V.png");
                Ma2 = true;
                if (txtMa2.Text == "SGK1000")
                {
                    txtTenSach2.Text = "Sách giáo khoa Hóa học 9";
                    txtTacGia2.Text = "Nhà xuất bản Giáo dục";
                    pbAnh2.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\hoahoc.png");
                }
                if (txtMa2.Text == "SGK1001")
                {
                    txtTenSach2.Text = "Sách giáo khoa Ngữ Văn 11";
                    txtTacGia2.Text = "Nhà xuất bản Giáo dục";
                    pbAnh2.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\nguvan.png");
                }
                if (txtMa2.Text == "SGK1010")
                {
                    txtTenSach2.Text = "Tôi yêu em";
                    txtTacGia2.Text = "Lép tôn tôi";
                    pbAnh2.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\tv.jpg");
                }
            }
            else
            {
                Ma2 = false;
                pbMa2.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\X.png");
                txtTenSach2.Text = "";
                txtTacGia2.Text = "";
                pbAnh2.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\anhxam.jpg");
            }
        }

        public void txtMa3_TextChanged(object sender, EventArgs e)
        {

            if (txtMa3.Text == "SGK1000" | txtMa3.Text == "SGK1001" | txtMa3.Text == "SGK1010")
            {
                pbMa3.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\V.png");
                Ma3 = true;
                if (txtMa3.Text == "SGK1000")
                {
                    txtTenSach3.Text = "Sách giáo khoa Hóa học 9";
                    txtTacGia3.Text = "Nhà xuất bản Giáo dục";
                    pbAnh3.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\hoahoc.png");
                }
                if (txtMa3.Text == "SGK1001")
                {
                    txtTenSach3.Text = "Sách giáo khoa Ngữ Văn 11";
                    txtTacGia3.Text = "Nhà xuất bản Giáo dục";
                    pbAnh3.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\nguvan.png");
                }
                if (txtMa3.Text == "SGK1010")
                {
                    txtTenSach3.Text = "Tôi yêu em";
                    txtTacGia3.Text = "Lép tôn tôi";
                    pbAnh3.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\tv.jpg");
                }
            }
            else
            {
                Ma3 = false;
                pbMa3.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\X.png");
                txtTenSach3.Text = "";
                txtTacGia3.Text = "";
                pbAnh3.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\anhxam.jpg");
            }
        }

        public void dgvDanhSach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaDocGia2.Text = dgvDanhsach.CurrentRow.Cells[1].Value.ToString();
            txtTenDocGia2.Text = dgvDanhsach.CurrentRow.Cells[2].Value.ToString();
            txtMaSach2.Text = dgvDanhsach.CurrentRow.Cells[3].Value.ToString();
            txtTenSachMuon2.Text = dgvDanhsach.CurrentRow.Cells[4].Value.ToString();

        }

        public void txtMaSach2_TextChanged(object sender, EventArgs e)
        {
            if (txtMaSach2.Text == "SGK1000")
            {
                pbAnh.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\hoahoc.png");
            }
            if (txtMaSach2.Text == "SGK1001")
            {
                pbAnh.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\nguvan.png");
            }
            if (txtMaSach2.Text == "SGK1010")
            {
                pbAnh.Image = Image.FromFile("D:\\QuanLiThuVien\\QuanLiThuVien\\tv.jpg");
            }

        }

        public void txtTimTenDocGia_TextChanged(object sender, EventArgs e)
        {
            DataTable dtTen = new DataTable();

            foreach (DataRow row in dt.Rows)
            {
                string ten = row[2].ToString();
                if (ten.Contains(txtTimTenDocGia.Text))
                {
                    dtTen.Rows.Add(row);
                }
            }

            dgvDanhsach.DataSource = dtTen;
        }

        public void txtTimMaDocGia_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtTimMaSach_TextChanged(object sender, EventArgs e)
        {

        }

        public void txtTimTenSach_TextChanged(object sender, EventArgs e)
        {

        }



        public void xoa1_Click(object sender, EventArgs e)
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









