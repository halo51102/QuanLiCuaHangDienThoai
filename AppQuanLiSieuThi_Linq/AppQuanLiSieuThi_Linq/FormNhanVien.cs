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
    public partial class FormNhanVien : Form
    {
        bool Them;
        string err;
        ClassNhanVien dbnv = new ClassNhanVien();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dgvNhanVien.DataSource = dbnv.LayMaNV();
                // Thay đổi độ rộng cột
                dgvNhanVien.AutoResizeColumns();
                txtMaNV.ResetText();
                txtTenNV.ResetText();
                txtSDT.ResetText();
                txtDiaChi.ResetText();
                txtLuong.ResetText();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                panel4.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //
                dgvNhanVien_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HangHoa. Lỗi rồi!!!");
            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhanVien.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaNV.Text =
            (string)dgvNhanVien.Rows[r].Cells[0].Value.ToString();
            this.txtTenNV.Text =
            (string)dgvNhanVien.Rows[r].Cells[1].Value.ToString();
            this.txtSDT.Text =
            (string)dgvNhanVien.Rows[r].Cells[2].Value.ToString();
            this.txtDiaChi.Text =
            (string)dgvNhanVien.Rows[r].Cells[3].Value.ToString();
            this.txtLuong.Text =
            (string)dgvNhanVien.Rows[r].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            txtLuong.ResetText();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtMaHang
            this.txtMaNV.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvNhanVien.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strNV =
                dgvNhanVien.Rows[r].Cells[0].Value.ToString();
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbnv.XoaNV(ref err, strNV);

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
            dgvNhanVien_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaNV.Enabled = false;
            this.txtTenNV.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    ClassNhanVien blnv = new ClassNhanVien();
                    blnv.ThemNV(this.txtMaNV.Text, this.txtTenNV.Text, this.txtSDT.Text, this.txtDiaChi.Text, this.txtLuong.Text, ref err);
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
                ClassNhanVien blnv = new ClassNhanVien();
                blnv.CapNhatNV(this.txtMaNV.Text, this.txtTenNV.Text, this.txtSDT.Text, this.txtDiaChi.Text, this.txtLuong.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNV.ResetText();
            txtTenNV.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            txtLuong.ResetText();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            panel4.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //
            dgvNhanVien_CellClick(null, null);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            dgvNhanVien.DataSource = null;
            LoadData();
            if (cbxThuocTinh.Text != "All")
            {


                if (cbxThuocTinh.Text.CompareTo("MaNV") == 0)
                {
                    dgvNhanVien.DataSource = from u in db.NhanViens
                                          where u.MaNV == txtYeuCau.Text.Trim()
                                          select new
                                          {
                                              MaNV = u.MaNV,
                                              TenNV = u.TenNV,
                                              SDT = u.SDT,
                                              DiaChi = u.DiaChi,
                                              Luong = u.Luong

                                          };
                }
                else if (cbxThuocTinh.Text.CompareTo("TenNV") == 0)
                {
                    dgvNhanVien.DataSource = from u in db.NhanViens
                                             where u.TenNV == txtYeuCau.Text.Trim()
                                             select new
                                             {
                                                 MaNV = u.MaNV,
                                                 TenNV = u.TenNV,
                                                 SDT = u.SDT,
                                                 DiaChi = u.DiaChi,
                                                 Luong = u.Luong

                                             };
                }
                else if (cbxThuocTinh.Text.CompareTo("SDT") == 0)
                {
                    dgvNhanVien.DataSource = from u in db.NhanViens
                                             where u.SDT == txtYeuCau.Text.Trim()
                                             select new
                                             {
                                                 MaNV = u.MaNV,
                                                 TenNV = u.TenNV,
                                                 SDT = u.SDT,
                                                 DiaChi = u.DiaChi,
                                                 Luong = u.Luong

                                             };
                }
                else if (cbxThuocTinh.Text.CompareTo("DiaChi") == 0)
                {
                    dgvNhanVien.DataSource = from u in db.NhanViens
                                             where u.DiaChi == txtYeuCau.Text.Trim()
                                             select new
                                             {
                                                 MaNV = u.MaNV,
                                                 TenNV = u.TenNV,
                                                 SDT = u.SDT,
                                                 DiaChi = u.DiaChi,
                                                 Luong = u.Luong

                                             };
                }
                else if (cbxThuocTinh.Text.CompareTo("Luong") == 0)
                {
                    dgvNhanVien.DataSource = from u in db.NhanViens
                                             where u.Luong == Convert.ToDouble(txtYeuCau.Text)
                                             select new
                                             {
                                                 MaNV = u.MaNV,
                                                 TenNV = u.TenNV,
                                                 SDT = u.SDT,
                                                 DiaChi = u.DiaChi,
                                                 Luong = u.Luong

                                             };
                }
            }
        }
        
        private void btnTongLuong_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            double sum = (from u in db.NhanViens
                       select u.Luong).Sum();
            this.txtTongLuong.Text = sum.ToString() + "VND";
        }

        private void btnLuongMax_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            double max = (from u in db.NhanViens
                          select u.Luong).Max();
            this.txtTongLuong.Text = max.ToString() + "VND";
        }

        private void btnLuongMin_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            double min = (from u in db.NhanViens
                          select u.Luong).Min();
            this.txtTongLuong.Text = min.ToString() + "VND";
        }

        private void btnAVE_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            double avg = (from u in db.NhanViens
                          select u.Luong).Average();
            this.txtTongLuong.Text = avg.ToString() + "VND";
        }
    }
}
