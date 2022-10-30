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

namespace AppQuanLiSieuThi_Linq
{
    public partial class FormThongKe : Form
    {
        public FormThongKe()
        {
            InitializeComponent();
        }

        private void FormThongKe_Load(object sender, EventArgs e)
        {
            loadData();
        }
        void loadData()
        {
            try
            {
                QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();
                dgvThongKe.DataSource = from u in db.HoaDons
                                        group u by u.Ngay.Year into g
                                        select new
                                        {
                                            Nam = g.Key,
                                            TongThu = g.Sum(x=>x.tongbill)
                                        };
                                        
            }
            catch (SqlException)
            {
                MessageBox.Show("Lỗi ở đâu rồi !!");
            }
        }
    }
}
