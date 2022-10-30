using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppQuanLiSieuThi_Linq.BS_Layer
{
    class ClassHangHoa
    {
        public System.Data.Linq.Table<HangHoa> LayHangHoa()
        {
            DataSet ds = new DataSet();
            QuanLySieuThiDataContext qlHH = new QuanLySieuThiDataContext();
            return qlHH.HangHoas;
        }
        public bool ThemHangHoa(string txtMaHang, string txtTenHang, string txtGia, string txtGiaKM,
            string txtSLKho, string txtLoaiHang, string txtNhaCC, ref string err)
        {
            QuanLySieuThiDataContext qlHH = new QuanLySieuThiDataContext();
            HangHoa hh = new HangHoa();
            hh.MaHang = txtMaHang;
            hh.TenHang = txtTenHang;
            hh.Gia = Convert.ToDouble(txtGia);
            hh.GiaKM = Convert.ToDouble(txtGiaKM);
            hh.Soluongconkho = Convert.ToDouble(txtSLKho);
            hh.MaLoaiHang = txtLoaiHang;
            hh.MaNCC = txtNhaCC;
           
            qlHH.HangHoas.InsertOnSubmit(hh);
            qlHH.HangHoas.Context.SubmitChanges();
            return true;

        }
        public bool XoaHangHoa(ref string err, string MaHang)
        {
            QuanLySieuThiDataContext qlHH = new QuanLySieuThiDataContext();
            var tpQuery = from hh in qlHH.HangHoas
                          where hh.MaHang == MaHang
                          select hh;
            qlHH.HangHoas.DeleteAllOnSubmit(tpQuery);
            qlHH.SubmitChanges();
            return true;
        }
        public bool CapNhatHangHoa(string txtMaHang, string txtTenHang, string txtGia, string txtGiaKM,
            string txtSLKho, string txtLoaiHang, string txtNhaCC, ref string err)
        {
            QuanLySieuThiDataContext qlHH = new QuanLySieuThiDataContext();
            var tpQuery = (from hh in qlHH.HangHoas
                          where hh.MaHang == txtMaHang
                          select hh).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.TenHang = txtTenHang;
                tpQuery.Gia = Convert.ToDouble(txtGia);
                if (string.IsNullOrEmpty(txtGiaKM))
                {
                    tpQuery.GiaKM = null;
                }
                else
                {
                    tpQuery.GiaKM = Convert.ToDouble(txtGiaKM);
                }
                tpQuery.Soluongconkho = Convert.ToDouble(txtSLKho);
                tpQuery.MaLoaiHang = txtLoaiHang;
                tpQuery.MaNCC = txtNhaCC;
                qlHH.SubmitChanges();
            }
            return true;
        }
        
    }
}
