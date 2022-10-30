using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AppQuanLiSieuThi_Linq.BS_Layer
{
    class ClassNhanVien
    {
        public System.Data.Linq.Table<NhanVien> LayMaNV()
        {
            DataSet ds = new DataSet();
            QuanLySieuThiDataContext qlnv = new QuanLySieuThiDataContext();
            return qlnv.NhanViens;
        }
        public bool ThemNV(string MaNV, string TenNV, string SDT, string DiaChi, string Luong, ref string err)
        {
            QuanLySieuThiDataContext qlnv = new QuanLySieuThiDataContext();
            NhanVien nv = new NhanVien();
            nv.MaNV = MaNV;
            nv.TenNV = TenNV;
            nv.SDT = SDT;
            nv.DiaChi = DiaChi;
            nv.Luong = Convert.ToDouble(Luong);

            qlnv.NhanViens.InsertOnSubmit(nv);
            qlnv.NhanViens.Context.SubmitChanges();
            return true;

        }
        public bool XoaNV(ref string err, string MaNV)
        {
            QuanLySieuThiDataContext qlnv = new QuanLySieuThiDataContext();
            var tpQuery = from nv in qlnv.NhanViens
                          where nv.MaNV == MaNV
                          select nv;
            qlnv.NhanViens.DeleteAllOnSubmit(tpQuery);
            qlnv.SubmitChanges();
            return true;
        }
        public bool CapNhatNV(string MaNV, string TenNV, string SDT, string DiaChi, string Luong, ref string err)
        {
            QuanLySieuThiDataContext qlnv = new QuanLySieuThiDataContext();
            var tpQuery = (from nv in qlnv.NhanViens
                           where nv.MaNV == MaNV
                           select nv).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.TenNV = TenNV;
                tpQuery.SDT = SDT;
                tpQuery.DiaChi = DiaChi;
                tpQuery.Luong = Convert.ToDouble(Luong);

                qlnv.SubmitChanges();
            }
            return true;
        }
        
    }
}
