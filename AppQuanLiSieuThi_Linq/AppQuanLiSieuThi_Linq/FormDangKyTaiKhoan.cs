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
    public partial class FormDangKyTaiKhoan : Form
    {
        ClassLogin login = null;
        string err;
        public FormDangKyTaiKhoan()
        {
            InitializeComponent();
            login = new ClassLogin();
        }

        private void FormDangKyTaiKhoan_Load(object sender, EventArgs e)
        {

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (!txtHoVaTen.Text.Trim().Equals("") &
                !txtMaNV.Text.Trim().Equals("") &
                !txtMatKhau.Text.Trim().Equals("") &
                !txtTenDN.Text.Trim().Equals("") &
                !txtNhapLaiMK.Text.Trim().Equals(""))
            {
                if (login.kiemTraTaiKhoan(txtTenDN.Text.Trim()) == false)
                {
                    if (txtMatKhau.Text.Trim().Equals(txtNhapLaiMK.Text.Trim()))
                    {
                        try
                        {
                            login.Them(this.txtTenDN.Text, this.txtHoVaTen.Text, this.txtMatKhau.Text, this.txtMaNV.Text, ref err);
                            MessageBox.Show("Đã Đăng kí thành công thành công!!");
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Mã Nhân Viên không hợp lệ");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng nhau");
                        txtMatKhau.Text = "";
                        txtNhapLaiMK.Text = "";
                        txtMatKhau.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tên Đăng Nhập đã tồn tại");
                    txtTenDN.Text = "";
                    txtTenDN.Focus();
                }
            }
            else
            {
                MessageBox.Show("Thiếu thông tin kìa !!");
                txtTenDN.Focus();
            }
        }
    }
}
