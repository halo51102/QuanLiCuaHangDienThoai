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
    public partial class FormKhuyenMai : Form
    {
        bool Them;
        string err;
        ClassKhuyenMai dbkm = new ClassKhuyenMai();
        public FormKhuyenMai()
        {
            InitializeComponent();
        }

        private void FormKhuyenMai_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
                dgvKhuyenMai.DataSource = from u in db.KhuyenMais
                                          select new
                                          {
                                              MaKM = u.MaKM,
                                              MaHang = u.MaHang,
                                              MucGiam = u.MucGiam,
                                              NgayHetHan = u.NgayHetHan

                                          };
                // Thay đổi độ rộng cột
                dgvKhuyenMai.AutoResizeColumns();
                txtMaKM.ResetText();
                txtMaHang.ResetText();
                txtMucGia.ResetText();
                txtNgayHH.ResetText();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                panel4.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //
                dgvKhuyenMai_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HangHoa. Lỗi rồi!!!");
            }
        }

        private void dgvKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvKhuyenMai.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaKM.Text =
            (string)dgvKhuyenMai.Rows[r].Cells[0].Value.ToString();
            this.txtMaHang.Text =
            (string)dgvKhuyenMai.Rows[r].Cells[1].Value.ToString();
            this.txtMucGia.Text =
            (string)dgvKhuyenMai.Rows[r].Cells[2].Value.ToString();
            this.txtNgayHH.Text =
            (string)dgvKhuyenMai.Rows[r].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaKM.ResetText();
            txtMaHang.ResetText();
            txtMucGia.ResetText();
            txtNgayHH.ResetText();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtMaHang
            this.txtMaKM.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvKhuyenMai.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strKhuyenMai =
                dgvKhuyenMai.Rows[r].Cells[0].Value.ToString();
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbkm.XoaKM(ref err, strKhuyenMai);

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
            dgvKhuyenMai_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaKM.Enabled = false;
            this.txtMaHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    ClassKhuyenMai blkm = new ClassKhuyenMai();
                    blkm.ThemKM(this.txtMaKM.Text, this.txtMaHang.Text, this.txtMucGia.Text, this.txtNgayHH.Text, ref err);
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
                ClassKhuyenMai blkm = new ClassKhuyenMai();
                blkm.CapNhatKM(this.txtMaKM.Text, this.txtMaHang.Text, this.txtMucGia.Text, this.txtNgayHH.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKM.ResetText();
            txtMaHang.ResetText();
            txtMucGia.ResetText();
            txtNgayHH.ResetText();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            panel4.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //
            dgvKhuyenMai_CellClick(null, null);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            dgvKhuyenMai.DataSource = null;
            LoadData();
            if (cbxThuocTinh.Text != "All")
            {
                if (cbxThuocTinh.Text.CompareTo("MaKM") == 0)
                {
                    dgvKhuyenMai.DataSource = from u in db.KhuyenMais
                                              where u.MaKM == txtYeuCau.Text.Trim()
                                              select new
                                              {
                                                  MaKM = u.MaKM,
                                                  MaHang = u.MaHang,
                                                  MucGiam = u.MucGiam,
                                                  NgayHetHan = u.NgayHetHan

                                              };
                }
                else if (cbxThuocTinh.Text.CompareTo("MaHang") == 0)
                {
                    dgvKhuyenMai.DataSource = from u in db.KhuyenMais
                                              where u.MaHang == txtYeuCau.Text.Trim()
                                              select new
                                              {
                                                  MaKM = u.MaKM,
                                                  MaHang = u.MaHang,
                                                  MucGiam = u.MucGiam,
                                                  NgayHetHan = u.NgayHetHan

                                              };
                }
                else if (cbxThuocTinh.Text.CompareTo("MucGiam") == 0)
                {
                    dgvKhuyenMai.DataSource = from u in db.KhuyenMais
                                              where u.MucGiam == Convert.ToInt32(txtYeuCau.Text)
                                              select new
                                              {
                                                  MaKM = u.MaKM,
                                                  MaHang = u.MaHang,
                                                  MucGiam = u.MucGiam,
                                                  NgayHetHan = u.NgayHetHan

                                              };
                }
                else if (cbxThuocTinh.Text.CompareTo("NgayHetHan") == 0)
                {
                    dgvKhuyenMai.DataSource = from u in db.KhuyenMais
                                              where u.NgayHetHan == Convert.ToDateTime(txtYeuCau.Text)
                                              select new
                                              {
                                                  MaKM = u.MaKM,
                                                  MaHang = u.MaHang,
                                                  MucGiam = u.MucGiam,
                                                  NgayHetHan = u.NgayHetHan

                                              };
                }
            }
        }
    }
}
