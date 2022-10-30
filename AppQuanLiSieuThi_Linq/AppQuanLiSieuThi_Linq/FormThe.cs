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
    public partial class FormThe : Form
    {
        bool Them;
        string err;
        ClassThe dbthe = new ClassThe();
        public FormThe()
        {
            InitializeComponent();
        }

        private void FormThe_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dgvThe.DataSource = dbthe.LaySDT();
                // Thay đổi độ rộng cột
                dgvThe.AutoResizeColumns();
                txtMaThe.ResetText();
                txtSDT.ResetText();
                txtTenKH.ResetText();
                txtSoDu.ResetText();
                cbxHangThe.ResetText();

                btnLuu.Enabled = false;
                btnHuy.Enabled = false;

                panel4.Enabled = false;

                btnThem.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                //
                dgvThe_CellClick(null, null);
            }
            catch
            {
                MessageBox.Show("Không lấy được nội dung trong table HangHoa. Lỗi rồi!!!");
            }
        }

        private void dgvThe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvThe.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            this.txtMaThe.Text =
            (string)dgvThe.Rows[r].Cells[0].Value.ToString();
            this.txtSDT.Text =
            (string)dgvThe.Rows[r].Cells[1].Value.ToString();
            this.txtTenKH.Text =
            (string)dgvThe.Rows[r].Cells[2].Value.ToString();
            this.txtSoDu.Text =
            (string)dgvThe.Rows[r].Cells[3].Value.ToString();
            this.cbxHangThe.Text =
            (string)dgvThe.Rows[r].Cells[4].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Them = true;
            txtMaThe.ResetText();
            txtSDT.ResetText();
            txtTenKH.ResetText();
            txtSoDu.ResetText();
            cbxHangThe.ResetText();

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            // Đưa con trỏ đến TextField txtMaHang
            this.txtMaThe.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thứ tự record hiện hành
                int r = dgvThe.CurrentCell.RowIndex;
                // Lấy MaKH của record hiện hành
                string strMaThe =
                dgvThe.Rows[r].Cells[0].Value.ToString();
                // Khai báo biến traloi
                DialogResult traloi;
                // Hiện hộp thoại hỏi đáp
                traloi = MessageBox.Show("Chắc xóa mẫu tin này không?", "Trả lời",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                // Kiểm tra có nhắp chọn nút Ok không?
                if (traloi == DialogResult.Yes)
                {
                    dbthe.XoaThe(ref err, strMaThe);

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
            dgvThe_CellClick(null, null);
            // Cho thao tác trên các nút Lưu / Hủy / Panel
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;

            panel4.Enabled = true;

            btnThem.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;

            // Đưa con trỏ đến TextField txtMaKH
            this.txtMaThe.Enabled = false;
            this.txtSDT.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (Them)
            {
                try
                {
                    // Thực hiện lệnh
                    ClassThe blthe = new ClassThe();
                    blthe.ThemThe(this.txtMaThe.Text, this.txtSDT.Text, this.txtTenKH.Text, this.txtSoDu.Text, this.cbxHangThe.Text, ref err);
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
                ClassThe blthe = new ClassThe();
                blthe.CapNhatThe(this.txtMaThe.Text, this.txtSDT.Text, this.txtTenKH.Text, this.txtSoDu.Text, this.cbxHangThe.Text, ref err);// Load lại dữ liệu trên DataGridView
                LoadData();
                // Thông báo
                MessageBox.Show("Đã sửa xong!");
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaThe.ResetText();
            txtSDT.ResetText();
            txtTenKH.ResetText();
            txtSoDu.ResetText();
            cbxHangThe.ResetText();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;

            panel4.Enabled = false;

            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            //
            dgvThe_CellClick(null, null);
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
            dgvThe.DataSource = null;
            LoadData();
            if (cbxThuocTinh.Text != "All")
            {
                if (cbxThuocTinh.Text.CompareTo("MaThe") == 0)
                {
                    dgvThe.DataSource = from u in db.Thes
                                        where u.MaThe == txtYeuCau.Text.Trim()
                                        select new
                                        {
                                            MaThe = u.MaThe,
                                            SDT = u.SDT,
                                            TenKH = u.TenKH,
                                            Tongtien = u.Tongtien,
                                            Hang = u.Hang

                                        };
                }

                else if (cbxThuocTinh.Text.CompareTo("SDT") == 0)
                {
                    dgvThe.DataSource = from u in db.Thes
                                             where u.SDT == txtYeuCau.Text.Trim()
                                             select new
                                             {
                                                 MaThe = u.MaThe,
                                                 SDT = u.SDT,
                                                 TenKH = u.TenKH,
                                                 Tongtien = u.Tongtien,
                                                 Hang = u.Hang

                                             };
                }
                else if (cbxThuocTinh.Text.CompareTo("TenKH") == 0)
                {
                    dgvThe.DataSource = from u in db.Thes
                                        where u.TenKH == txtYeuCau.Text.Trim()
                                        select new
                                        {
                                            MaThe = u.MaThe,
                                            SDT = u.SDT,
                                            TenKH = u.TenKH,
                                            Tongtien = u.Tongtien,
                                            Hang = u.Hang

                                        };
                }
                else if (cbxThuocTinh.Text.CompareTo("Tongtien") == 0)
                {
                    dgvThe.DataSource = from u in db.Thes
                                        where u.Tongtien == Convert.ToDouble(txtYeuCau.Text)
                                        select new
                                        {
                                            MaThe = u.MaThe,
                                            SDT = u.SDT,
                                            TenKH = u.TenKH,
                                            Tongtien = u.Tongtien,
                                            Hang = u.Hang

                                        };
                }
                else if (cbxThuocTinh.Text.CompareTo("Hang") == 0)
                {
                    dgvThe.DataSource = from u in db.Thes
                                        where u.Hang == txtYeuCau.Text.Trim()
                                        select new
                                        {
                                            MaThe = u.MaThe,
                                            SDT = u.SDT,
                                            TenKH = u.TenKH,
                                            Tongtien = u.Tongtien,
                                            Hang = u.Hang

                                        };
                }
            }
        }
    }
}
