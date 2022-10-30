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
    public partial class FormLoaiHang : Form
    {
        bool Them;
        string err;
        ClassLoaiHang dblh = new ClassLoaiHang();
        public FormLoaiHang()
        {
            InitializeComponent();
        }

        private void FormLoaiHang_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dgvLoaiHang.DataSource = dblh.LayLoaiHang();
                // Thay đổi độ rộng cột
                dgvLoaiHang.AutoResizeColumns();
                txtMaLH.ResetText();
                txtTenLoaiHang.ResetText();


                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                panel4.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //
                dgvLoaiHang_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HangHoa. Lỗi rồi!!!");
            }
        }

        private void dgvLoaiHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvLoaiHang.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaLH.Text =
            (string)dgvLoaiHang.Rows[r].Cells[0].Value.ToString();
            this.txtTenLoaiHang.Text =
            (string)dgvLoaiHang.Rows[r].Cells[1].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaLH.ResetText();
            txtTenLoaiHang.ResetText();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtMaHang
            this.txtMaLH.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvLoaiHang.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strLH =
                dgvLoaiHang.Rows[r].Cells[0].Value.ToString();
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dblh.XoaLH(ref err, strLH);

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
            dgvLoaiHang_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaLH.Enabled = false;
            this.txtTenLoaiHang.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    ClassLoaiHang bllh = new ClassLoaiHang();
                    bllh.ThemLH(this.txtMaLH.Text, this.txtTenLoaiHang.Text, ref err);
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
                ClassLoaiHang bllh = new ClassLoaiHang();
                bllh.CapNhatLH(this.txtMaLH.Text, this.txtTenLoaiHang.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaLH.ResetText();
            txtTenLoaiHang.ResetText();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            panel4.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //
            dgvLoaiHang_CellClick(null, null);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            dgvLoaiHang.DataSource = null;
            LoadData();
            if (cbxThuocTinh.Text != "All")
            {


                if (cbxThuocTinh.Text.CompareTo("MaLoaiHang") == 0)
                {
                    dgvLoaiHang.DataSource = from u in db.LoaiHangs
                                             where u.MaLoaiHang == txtYeuCau.Text.Trim()
                                             select new
                                             {
                                                 MaLoaiHang = u.MaLoaiHang,
                                                 TenLoaiHang = u.TenLoaiHang

                                             };
                }
                else if (cbxThuocTinh.Text.CompareTo("TenLoaiHang") == 0)
                {
                    dgvLoaiHang.DataSource = from u in db.LoaiHangs
                                             where u.TenLoaiHang == txtYeuCau.Text.Trim()
                                             select new
                                             {
                                                 MaLoaiHang = u.MaLoaiHang,
                                                 TenLoaiHang = u.TenLoaiHang

                                             };
                }
            }
        }
    }
}
