using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppQuanLiSieuThi_Linq
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnHangHoa_Click(object sender, EventArgs e)
        {
            FormHangHoa hh = new FormHangHoa();
            hh.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FormHoaDon hd = new FormHoaDon();
            hd.ShowDialog();
        }

        private void btnKhuyenMai_Click(object sender, EventArgs e)
        {
            FormKhuyenMai km = new FormKhuyenMai();
            km.ShowDialog();
        }

        private void btnLoaiHang_Click(object sender, EventArgs e)
        {
            FormLoaiHang lh = new FormLoaiHang();
            lh.ShowDialog();
        }

        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            FormNhaCungCap ncc = new FormNhaCungCap();
            ncc.ShowDialog();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien nv = new FormNhanVien();
            nv.ShowDialog();
        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            FormNhapHang nh = new FormNhapHang();
            nh.ShowDialog();
        }

        private void btnThe_Click(object sender, EventArgs e)
        {
            FormThe the = new FormThe();
            the.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult tl = MessageBox.Show("Bạn có muốn thoát", "Thoát Ứng Dụng",
                MessageBoxButtons.OKCancel);
            if (tl == DialogResult.OK)
                this.Close();
        }
    }
}
