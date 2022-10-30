using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace AppQuanLiSieuThi_Linq.BS_Layer
{
    class ClassLogin
    {
        public bool Search(string tendangnhap, string matkhau)
        {
            QuanLySieuThiDataContext qlST = new QuanLySieuThiDataContext();
            var query = (from tk in qlST.TaiKhoans
                         where tk.tendangnhap == tendangnhap && tk.Matkhau == matkhau
                         select tk).SingleOrDefault();
            //DataTable result =   ImportData(query).Tables[0];
            if (query == null)
            {
                return false;
            }
            return true;
        }
        public bool Them(string txtTenDN, string txtHoVaTen, string txtMatKhau, string txtMaNV, ref string err)
        {
            QuanLySieuThiDataContext qlST = new QuanLySieuThiDataContext();
            TaiKhoan tk = new TaiKhoan();
            tk.tendangnhap = txtTenDN;
            tk.tenhienthi = txtHoVaTen;
            tk.Matkhau = txtMatKhau;
            tk.MaNV = txtMaNV;
            qlST.TaiKhoans.InsertOnSubmit(tk);            
            qlST.TaiKhoans.Context.SubmitChanges();
            return true;
        }
        public bool kiemTraTaiKhoan(string tendangnhap)
        {
            QuanLySieuThiDataContext qlST = new QuanLySieuThiDataContext();
            var query = (from tk in qlST.TaiKhoans
                         where tk.tendangnhap == tendangnhap
                         select tk).SingleOrDefault();
            if (query == null)
            {
                return false;
            }
            return true;
        }
    }
}
