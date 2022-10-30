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
    public partial class FormNhapHang : Form
    {
        bool Them;
        string err;
        ClassNhapHang dbnh = new ClassNhapHang();
        public FormNhapHang()
        {
            InitializeComponent();
        }

        private void FormNhapHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
                dgvNhapHang.DataSource = from u in db.NhapHangs
                                         select new
                                         {
                                             manhaphang = u.manhaphang,
                                             MaHang = u.MaHang,
                                             gianhap = u.gianhap,
                                             soluongnhap = u.soluongnhap,
                                             ngaynhap = u.ngaynhap,
                                             ngayhethan = u.ngayhethan

                                         };
                // Thay đổi độ rộng cột
                dgvNhapHang.AutoResizeColumns();
                txtMaNH.ResetText();
                txtMaHang.ResetText();
                txtGiaNhap.ResetText();
                txtSLNhap.ResetText();
                txtNgayNhap.ResetText();
                txtNgayHH.ResetText();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                panel4.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //
                dgvNhapHang_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HangHoa. Lỗi rồi!!!");
            }
        }

        private void dgvNhapHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhapHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaNH.Text =
            (string)dgvNhapHang.Rows[r].Cells[0].Value.ToString();
            this.txtMaHang.Text =
            (string)dgvNhapHang.Rows[r].Cells[1].Value.ToString();
            this.txtGiaNhap.Text =
            (string)dgvNhapHang.Rows[r].Cells[2].Value.ToString();
            this.txtSLNhap.Text =
            (string)dgvNhapHang.Rows[r].Cells[3].Value.ToString();
            this.txtNgayNhap.Text =
            (string)dgvNhapHang.Rows[r].Cells[4].Value.ToString();
            this.txtNgayHH.Text =
            (string)dgvNhapHang.Rows[r].Cells[5].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaNH.ResetText();
            txtMaHang.ResetText();
            txtGiaNhap.ResetText();
            txtSLNhap.ResetText();
            txtNgayNhap.ResetText();
            txtNgayHH.ResetText();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtMaHang
            this.txtMaNH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvNhapHang.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strNH =
                dgvNhapHang.Rows[r].Cells[0].Value.ToString();
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbnh.XoaNH(ref err, strNH);

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
            dgvNhapHang_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaNH.Enabled = false;
            this.txtMaHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    ClassNhapHang blnh = new ClassNhapHang();
                    blnh.ThemNH(this.txtMaNH.Text, this.txtMaHang.Text, this.txtGiaNhap.Text, this.txtSLNhap.Text, this.txtNgayNhap.Text, this.txtNgayHH.Text, ref err);
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
                ClassNhapHang blnh = new ClassNhapHang();
                blnh.CapNhatNH(this.txtMaNH.Text, this.txtMaHang.Text, this.txtGiaNhap.Text, this.txtSLNhap.Text, this.txtNgayNhap.Text, this.txtNgayHH.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNH.ResetText();
            txtMaHang.ResetText();
            txtGiaNhap.ResetText();
            txtSLNhap.ResetText();
            txtNgayNhap.ResetText();
            txtNgayHH.ResetText();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            panel4.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //
            dgvNhapHang_CellClick(null, null);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            dgvNhapHang.DataSource = null;
            LoadData();
            if (cbxThuocTinh.Text != "All")
            {


                if (cbxThuocTinh.Text.CompareTo("manhaphang") == 0)
                {
                    dgvNhapHang.DataSource = from u in db.NhapHangs
                                             where u.manhaphang == txtYeuCau.Text.Trim()
                                             select new
                                             {
                                                 manhaphang = u.manhaphang,
                                                 MaHang = u.MaHang,
                                                 gianhap = u.gianhap,
                                                 soluongnhap = u.soluongnhap,
                                                 ngaynhap = u.ngaynhap,
                                                 ngayhethan = u.ngayhethan

                                             };
                }
                else if (cbxThuocTinh.Text.CompareTo("MaHang") == 0)
                {
                    dgvNhapHang.DataSource = from u in db.NhapHangs
                                             where u.MaHang == txtYeuCau.Text.Trim()
                                             select new
                                             {
                                                 manhaphang = u.manhaphang,
                                                 MaHang = u.MaHang,
                                                 gianhap = u.gianhap,
                                                 soluongnhap = u.soluongnhap,
                                                 ngaynhap = u.ngaynhap,
                                                 ngayhethan = u.ngayhethan

                                             };
                }
                else if (cbxThuocTinh.Text.CompareTo("gianhap") == 0)
                {
                    dgvNhapHang.DataSource = from u in db.NhapHangs
                                             where u.gianhap == Convert.ToDouble(txtYeuCau.Text)
                                             select new
                                             {
                                                 manhaphang = u.manhaphang,
                                                 MaHang = u.MaHang,
                                                 gianhap = u.gianhap,
                                                 soluongnhap = u.soluongnhap,
                                                 ngaynhap = u.ngaynhap,
                                                 ngayhethan = u.ngayhethan

                                             };
                }
                else if (cbxThuocTinh.Text.CompareTo("soluongnhap") == 0)
                {
                    dgvNhapHang.DataSource = from u in db.NhapHangs
                                             where u.soluongnhap == Convert.ToDouble(txtYeuCau.Text)
                                             select new
                                             {
                                                 manhaphang = u.manhaphang,
                                                 MaHang = u.MaHang,
                                                 gianhap = u.gianhap,
                                                 soluongnhap = u.soluongnhap,
                                                 ngaynhap = u.ngaynhap,
                                                 ngayhethan = u.ngayhethan

                                             };
                }
                else if (cbxThuocTinh.Text.CompareTo("ngaynhap") == 0)
                {
                    dgvNhapHang.DataSource = from u in db.NhapHangs
                                             where u.ngaynhap == Convert.ToDateTime(txtYeuCau.Text)
                                             select new
                                             {
                                                 manhaphang = u.manhaphang,
                                                 MaHang = u.MaHang,
                                                 gianhap = u.gianhap,
                                                 soluongnhap = u.soluongnhap,
                                                 ngaynhap = u.ngaynhap,
                                                 ngayhethan = u.ngayhethan

                                             };
                }
                else if (cbxThuocTinh.Text.CompareTo("ngayhethan") == 0)
                {
                    dgvNhapHang.DataSource = from u in db.NhapHangs
                                             where u.ngayhethan == Convert.ToDateTime(txtYeuCau.Text)
                                             select new
                                             {
                                                 manhaphang = u.manhaphang,
                                                 MaHang = u.MaHang,
                                                 gianhap = u.gianhap,
                                                 soluongnhap = u.soluongnhap,
                                                 ngaynhap = u.ngaynhap,
                                                 ngayhethan = u.ngayhethan

                                             };
                }
            }
        }

        private void btnTongChiSP_Click(object sender, EventArgs e)
        {
            int stt = dgvNhapHang.CurrentCell.RowIndex;

            string gianhap = dgvNhapHang.Rows[stt].Cells[2].Value.ToString();
            string soLuongNhap = dgvNhapHang.Rows[stt].Cells[3].Value.ToString();

            txtTongChi.Enabled = false;
            txtTongChi.Text = dbnh.tinhTongChi(double.Parse(gianhap),
                                                    double.Parse(soLuongNhap)).ToString() + "VND";
        }
    }
}
