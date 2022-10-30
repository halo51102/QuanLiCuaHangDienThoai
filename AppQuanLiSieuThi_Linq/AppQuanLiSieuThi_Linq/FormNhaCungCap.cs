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
    public partial class FormNhaCungCap : Form
    {
        bool Them;
        string err;
        ClassNhaCungCap dbncc = new ClassNhaCungCap();
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dgvNhaCC.DataSource = dbncc.LayMaNCC();
                // Thay đổi độ rộng cột
                dgvNhaCC.AutoResizeColumns();
                txtMaNCC.ResetText();
                txtTenNCC.ResetText();
                txtDiaChi.ResetText();
                txtSDT.ResetText();
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                panel4.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //
                dgvNhaCC_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HangHoa. Lỗi rồi!!!");
            }
        }

        private void dgvNhaCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvNhaCC.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaNCC.Text =
            (string)dgvNhaCC.Rows[r].Cells[0].Value.ToString();
            this.txtTenNCC.Text =
            (string)dgvNhaCC.Rows[r].Cells[1].Value.ToString();
            this.txtDiaChi.Text =
            (string)dgvNhaCC.Rows[r].Cells[2].Value.ToString();
            this.txtSDT.Text =
            (string)dgvNhaCC.Rows[r].Cells[3].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtMaHang
            this.txtMaNCC.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvNhaCC.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strNCC =
                dgvNhaCC.Rows[r].Cells[0].Value.ToString();
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbncc.XoaNCC(ref err, strNCC);

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
            dgvNhaCC_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaNCC.Enabled = false;
            this.txtTenNCC.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    ClassNhaCungCap blncc = new ClassNhaCungCap();
                    blncc.ThemNCC(this.txtMaNCC.Text, this.txtTenNCC.Text, this.txtDiaChi.Text, this.txtSDT.Text, ref err);
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
                ClassNhaCungCap blncc = new ClassNhaCungCap();
                blncc.CapNhatNCC(this.txtMaNCC.Text, this.txtTenNCC.Text, this.txtDiaChi.Text, this.txtSDT.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaNCC.ResetText();
            txtTenNCC.ResetText();
            txtDiaChi.ResetText();
            txtSDT.ResetText();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            panel4.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //
            dgvNhaCC_CellClick(null, null);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            dgvNhaCC.DataSource = null;
            LoadData();
            if (cbxThuocTinh.Text != "All")
            {


                if (cbxThuocTinh.Text.CompareTo("MaNCC") == 0)
                {
                   dgvNhaCC.DataSource = from u in db.NhaCungCaps
                                             where u.MaNCC == txtYeuCau.Text.Trim()
                                             select new
                                             {
                                                 MaNCC = u.MaNCC,
                                                 TenNCC = u.TenNCC,
                                                 DiaChi = u.DiaChi,
                                                 Sdt = u.Sdt

                                             };
                }
                else if (cbxThuocTinh.Text.CompareTo("TenNCC") == 0)
                {
                    dgvNhaCC.DataSource = from u in db.NhaCungCaps
                                          where u.TenNCC == txtYeuCau.Text.Trim()
                                          select new
                                          {
                                              MaNCC = u.MaNCC,
                                              TenNCC = u.TenNCC,
                                              DiaChi = u.DiaChi,
                                              Sdt = u.Sdt

                                          };
                }
                else if (cbxThuocTinh.Text.CompareTo("DiaChi") == 0)
                {
                    dgvNhaCC.DataSource = from u in db.NhaCungCaps
                                          where u.DiaChi == txtYeuCau.Text.Trim()
                                          select new
                                          {
                                              MaNCC = u.MaNCC,
                                              TenNCC = u.TenNCC,
                                              DiaChi = u.DiaChi,
                                              Sdt = u.Sdt

                                          };
                }
                else if (cbxThuocTinh.Text.CompareTo("Sdt") == 0)
                {
                    dgvNhaCC.DataSource = from u in db.NhaCungCaps
                                          where u.Sdt == txtYeuCau.Text.Trim()
                                          select new
                                          {
                                              MaNCC = u.MaNCC,
                                              TenNCC = u.TenNCC,
                                              DiaChi = u.DiaChi,
                                              Sdt = u.Sdt

                                          };
                }
            }
        }
    }
}
