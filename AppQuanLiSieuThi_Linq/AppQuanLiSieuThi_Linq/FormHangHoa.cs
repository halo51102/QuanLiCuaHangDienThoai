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
    public partial class FormHangHoa : Form
    {
        bool Them;
        string err;
        ClassHangHoa dbhh = new ClassHangHoa();
        public FormHangHoa()
        {
            InitializeComponent();
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
                dgvHangHoa.DataSource = from u in db.HangHoas
                                        select new
                                        {
                                            MaHang = u.MaHang,
                                            TenHang = u.TenHang,
                                            Gia = u.Gia,
                                            GiaKM = u.GiaKM,
                                            Soluongconkho = u.Soluongconkho,
                                            MaLoaiHang = u.MaLoaiHang,
                                            MaNCC = u.MaNCC
                                       };
                // Thay đổi độ rộng cột
                dgvHangHoa.AutoResizeColumns();
                txtGia.ResetText();
                txtGiaKM.ResetText();
                txtLoaiHang.ResetText();
                txtMaHang.ResetText();
                txtNhaCC.ResetText();
                txtSLKho.ResetText();
                txtTenHang.ResetText();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                panel4.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //
                dgvHangHoa_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HangHoa. Lỗi rồi!!!");
            }
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvHangHoa.CurrentCell.RowIndex;

            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            // Chuyển thông tin lên panel
            this.txtMaHang.Text =
            (string)dgvHangHoa.Rows[r].Cells[0].Value.ToString();
            this.txtTenHang.Text =
            (string)dgvHangHoa.Rows[r].Cells[1].Value.ToString();
            this.txtGia.Text =
            (string)dgvHangHoa.Rows[r].Cells[2].Value.ToString();
            var GiaKM = (
                         from i in db.KhuyenMais
                         where i.MaHang == txtMaHang.Text.Trim()
                         select i).SingleOrDefault();
            
            if (GiaKM != null)
            {
                this.txtGiaKM.Text =
            (string)dgvHangHoa.Rows[r].Cells[3].Value.ToString();
            }
            else { this.txtGiaKM.Text = null; }
            this.txtSLKho.Text =
            (string)dgvHangHoa.Rows[r].Cells[4].Value.ToString();
            this.txtLoaiHang.Text =
            (string)dgvHangHoa.Rows[r].Cells[5].Value.ToString();
            this.txtNhaCC.Text =
            (string)dgvHangHoa.Rows[r].Cells[6].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtGia.ResetText();
            txtGiaKM.ResetText();
            txtLoaiHang.ResetText();
            txtMaHang.ResetText();
            txtNhaCC.ResetText();
            txtSLKho.ResetText();
            txtTenHang.ResetText();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtMaHang
            this.txtMaHang.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvHangHoa.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strHANGHOA =
                dgvHangHoa.Rows[r].Cells[0].Value.ToString();
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbhh.XoaHangHoa(ref err, strHANGHOA);
                
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
            dgvHangHoa_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaHang.Enabled = false;
            this.txtTenHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    ClassHangHoa blhh = new ClassHangHoa();
                    blhh.ThemHangHoa(this.txtMaHang.Text, this.txtTenHang.Text, this.txtGia.Text, this.txtGiaKM.Text, this.txtSLKho.Text,this.txtLoaiHang.Text,
                        this.txtNhaCC.Text, ref err);
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
                ClassHangHoa blhh = new ClassHangHoa();
                blhh.CapNhatHangHoa(this.txtMaHang.Text, this.txtTenHang.Text, this.txtGia.Text, this.txtGiaKM.Text, this.txtSLKho.Text,this.txtLoaiHang.Text,
                        this.txtNhaCC.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtGia.ResetText();
            txtGiaKM.ResetText();
            txtLoaiHang.ResetText();
            txtMaHang.ResetText();
            txtNhaCC.ResetText();
            txtSLKho.ResetText();
            txtTenHang.ResetText();

            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            panel4.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //
            dgvHangHoa_CellClick(null, null);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            dgvHangHoa.DataSource = null;
            LoadData();
            if (cbxThuocTinh.Text != "All")
            {


                if (cbxThuocTinh.Text.CompareTo("MaHang") == 0)
                {
                    dgvHangHoa.DataSource = from u in db.HangHoas
                                           where u.MaHang == txtYeuCau.Text.Trim()
                                           select new
                                           {
                                               MaHang = u.MaHang,
                                               TenHang = u.TenHang,
                                               Gia = u.Gia,
                                               GiaKM = u.GiaKM,
                                               Soluongconkho = u.Soluongconkho,
                                               MaLoaiHang = u.MaLoaiHang,
                                               MaNCC = u.MaNCC
                                           };
                }
                else if (cbxThuocTinh.Text.CompareTo("TenHang") == 0)
                {
                    dgvHangHoa.DataSource = from u in db.HangHoas
                                            where u.TenHang == txtYeuCau.Text.Trim()
                                            select new
                                            {
                                                MaHang = u.MaHang,
                                                TenHang = u.TenHang,
                                                Gia = u.Gia,
                                                GiaKM = u.GiaKM,
                                                Soluongconkho = u.Soluongconkho,
                                                MaLoaiHang = u.MaLoaiHang,
                                                MaNCC = u.MaNCC
                                            };
                }
                else if (cbxThuocTinh.Text.CompareTo("Gia") == 0)
                {
                    dgvHangHoa.DataSource = from u in db.HangHoas
                                            where u.Gia == Convert.ToDouble(txtYeuCau.Text)
                                            select new
                                            {
                                                MaHang = u.MaHang,
                                                TenHang = u.TenHang,
                                                Gia = u.Gia,
                                                GiaKM = u.GiaKM,
                                                Soluongconkho = u.Soluongconkho,
                                                MaLoaiHang = u.MaLoaiHang,
                                                MaNCC = u.MaNCC
                                            };
                }
                else if (cbxThuocTinh.Text.CompareTo("GiaKM") == 0)
                {
                    dgvHangHoa.DataSource = from u in db.HangHoas
                                            where u.GiaKM == Convert.ToDouble(txtYeuCau.Text)
                                            select new
                                            {
                                                MaHang = u.MaHang,
                                                TenHang = u.TenHang,
                                                Gia = u.Gia,
                                                GiaKM = u.GiaKM,
                                                Soluongconkho = u.Soluongconkho,
                                                MaLoaiHang = u.MaLoaiHang,
                                                MaNCC = u.MaNCC
                                            };
                }
                else if (cbxThuocTinh.Text.CompareTo("Soluongconkho") == 0)
                {
                    dgvHangHoa.DataSource = from u in db.HangHoas
                                            where u.Soluongconkho == Convert.ToDouble(txtYeuCau.Text)
                                            select new
                                            {
                                                MaHang = u.MaHang,
                                                TenHang = u.TenHang,
                                                Gia = u.Gia,
                                                GiaKM = u.GiaKM,
                                                Soluongconkho = u.Soluongconkho,
                                                MaLoaiHang = u.MaLoaiHang,
                                                MaNCC = u.MaNCC
                                            };
                }
                else if (cbxThuocTinh.Text.CompareTo("MaLoaiHang") == 0)
                {
                    dgvHangHoa.DataSource = from u in db.HangHoas
                                            where u.MaLoaiHang == txtYeuCau.Text.Trim()
                                            select new
                                            {
                                                MaHang = u.MaHang,
                                                TenHang = u.TenHang,
                                                Gia = u.Gia,
                                                GiaKM = u.GiaKM,
                                                Soluongconkho = u.Soluongconkho,
                                                MaLoaiHang = u.MaLoaiHang,
                                                MaNCC = u.MaNCC
                                            };
                }
                else if (cbxThuocTinh.Text.CompareTo("MaNCC") == 0)
                {
                    dgvHangHoa.DataSource = from u in db.HangHoas
                                            where u.MaNCC == txtYeuCau.Text.Trim()
                                            select new
                                            {
                                                MaHang = u.MaHang,
                                                TenHang = u.TenHang,
                                                Gia = u.Gia,
                                                GiaKM = u.GiaKM,
                                                Soluongconkho = u.Soluongconkho,
                                                MaLoaiHang = u.MaLoaiHang,
                                                MaNCC = u.MaNCC
                                            };
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            ClassKhuyenMai km = new ClassKhuyenMai();
            km.CapNhatGia();
            LoadData();
        }

        private void btnTTGiaKM_Click(object sender, EventArgs e)
        {
            FormKhuyenMai kmshow = new FormKhuyenMai();
            kmshow.Show();
        }

        private void btnTTNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapHang nh = new FormNhapHang();
            nh.Show();
        }

        private void btnTTNCC_Click(object sender, EventArgs e)
        {
            FormNhaCungCap ncc = new FormNhaCungCap();
            ncc.Show();
        }

        private void btnTTLoaiHang_Click(object sender, EventArgs e)
        {
            FormLoaiHang lh = new FormLoaiHang();
            lh.Show();
        }
    }
    
}
