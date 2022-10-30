using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using AppQuanLiSieuThi_Linq.BS_Layer;
namespace AppQuanLiSieuThi_Linq
{
    public partial class FormHoaDon : Form
    {
        bool Them;
        string err;
        ClassHoaDon dbhd = new ClassHoaDon();
        //QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
        public FormHoaDon()
        {
            InitializeComponent();
        }

        private void FormHoaDon_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
                dgvHoaDon.DataSource = from u in db.HoaDons
                                       select new
                                       {

                                           MaHoaDon = u.MaHoaDon,
                                           Mathe = u.MaThe,
                                           MaNv = u.MaNV,
                                           Ngay = u.Ngay,
                                           tongbill = u.tongbill
                                       };
                //dgvHoaDon.DataSource = dbhd.LayHoaDon();
                // Thay đổi độ rộng cột
                dgvHoaDon.AutoResizeColumns();
                txtMaHD.ResetText();
                txtMaThe.ResetText();
                txtMaNV.ResetText();
                txtNgay.ResetText();
                txtTongTien.ResetText();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                panel4.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //
                dgvHoaDon_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HangHoa. Lỗi rồi!!!");
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHoaDon.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaHD.Text =
            (string)dgvHoaDon.Rows[r].Cells[0].Value.ToString();
            this.txtMaThe.Text =
            (string)dgvHoaDon.Rows[r].Cells[1].Value.ToString();
            this.txtMaNV.Text =
            (string)dgvHoaDon.Rows[r].Cells[2].Value.ToString();
            this.txtNgay.Text =
            (string)dgvHoaDon.Rows[r].Cells[3].Value.ToString();
            this.txtTongTien.Text =
            (string)dgvHoaDon.Rows[r].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaHD.ResetText();
            txtMaThe.ResetText();
            txtMaNV.ResetText();
            txtNgay.ResetText();
            txtTongTien.ResetText();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtMaHang
            this.txtMaHD.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvHoaDon.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strHOADON =
                dgvHoaDon.Rows[r].Cells[0].Value.ToString();
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbhd.XoaHoaDon(ref err, strHOADON);

                    // Cập nhật lại DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã xóa xong!");
                }
                else
                {
                    // Thông báo
                    MessageBox.Show("Không thực hiện việc xóa mẫu tin!");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Không xóa được. Lỗi rồi!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Them = false;
            // Cho phép thao tác trên Panel
            this.panel4.Enabled = true;
            dgvHoaDon_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaHD.Enabled = false;
            this.txtMaNV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    ClassHoaDon blhd = new ClassHoaDon();
                    blhd.ThemHoaDon(this.txtMaHD.Text, this.txtMaThe.Text, this.txtMaNV.Text, this.txtNgay.Text, this.txtTongTien.Text, ref err);
                    // Load lại dữ liệu trên DataGridView
                    LoadData();
                    // Thông báo
                    MessageBox.Show("Đã thêm xong!");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Không thêm được. Lỗi rồi!");
                }
            }
            else
            {
                // Thực hiện lệnh
                ClassHoaDon blhd = new ClassHoaDon();
                blhd.CapNhatHoaDon(this.txtMaHD.Text, this.txtMaThe.Text, this.txtMaNV.Text, this.txtNgay.Text, this.txtTongTien.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaHD.ResetText();
            txtMaNV.ResetText();
            txtNgay.ResetText();
            txtTongTien.ResetText();

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            panel4.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //
            dgvHoaDon_CellClick(null, null);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            dgvHoaDon.DataSource = null;
            LoadData();
            if (cbxThuocTinh.Text != "All")
            {

                
                if (cbxThuocTinh.Text.CompareTo("MaHoaDon") == 0)
                {
                    dgvHoaDon.DataSource = from u in db.HoaDons
                                           where u.MaHoaDon == txtYeuCau.Text.Trim()
                                           select new
                                           {
                                               MaHoaDon = u.MaHoaDon,
                                               Mathe = u.MaThe,
                                               MaNv = u.MaNV,
                                               Ngay = u.Ngay,
                                               tongbill = u.tongbill
                                           };
                }
                else if (cbxThuocTinh.Text.CompareTo("MaThe") == 0)
                {
                    dgvHoaDon.DataSource = from u in db.HoaDons
                                           where u.MaThe == txtYeuCau.Text.Trim()
                                           select new
                                           {
                                               MaHoaDon = u.MaHoaDon,
                                               Mathe = u.MaThe,
                                               MaNv = u.MaNV,
                                               Ngay = u.Ngay,
                                               tongbill = u.tongbill
                                           };
                }
                else if (cbxThuocTinh.Text.CompareTo("MaNV") == 0)
                {
                    dgvHoaDon.DataSource = from u in db.HoaDons
                                           where u.MaNV == txtYeuCau.Text.Trim()
                                           select new
                                           {
                                               MaHoaDon = u.MaHoaDon,
                                               Mathe = u.MaThe,
                                               MaNv = u.MaNV,
                                               Ngay = u.Ngay,
                                               tongbill = u.tongbill
                                           };
                }
                else if (cbxThuocTinh.Text.CompareTo("Ngay") == 0)
                {
                    dgvHoaDon.DataSource = from u in db.HoaDons
                                           where u.Ngay == Convert.ToDateTime(txtYeuCau.Text)
                                           select new
                                           {
                                               MaHoaDon = u.MaHoaDon,
                                               Mathe = u.MaThe,
                                               MaNv = u.MaNV,
                                               Ngay = u.Ngay,
                                               tongbill = u.tongbill
                                           };
                }
                else if(cbxThuocTinh.Text.CompareTo("tongbill") == 0)
                {
                    dgvHoaDon.DataSource = from u in db.HoaDons
                                           where u.tongbill == Convert.ToDouble(txtYeuCau.Text)
                                           select new
                                           {
                                               MaHoaDon = u.MaHoaDon,
                                               Mathe = u.MaThe,
                                               MaNv = u.MaNV,
                                               Ngay = u.Ngay,
                                               tongbill = u.tongbill
                                           };
                }
            }

        }

        private void btnTTNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien nv_hd = new FormNhanVien();
            nv_hd.Show();
        }

        private void btnTTThe_Click(object sender, EventArgs e)
        {
            FormThe th = new FormThe();
            th.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            FormThongKe tk = new FormThongKe();
            tk.Show();
        }
    }
}
