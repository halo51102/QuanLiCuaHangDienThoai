using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AppQuanLiSieuThi_Linq.BS_Layer
{
    class ClassNhaCungCap
    {
        public System.Data.Linq.Table<NhaCungCap> LayMaNCC()
        {
            DataSet ds = new DataSet();
            QuanLySieuThiDataContext qlncc = new QuanLySieuThiDataContext();
            return qlncc.NhaCungCaps;
        }
        public bool ThemNCC(string MaNCC, string TenNCC, string DiaChi, string SDT, ref string err)
        {
            QuanLySieuThiDataContext qlncc = new QuanLySieuThiDataContext();
            NhaCungCap ncc = new NhaCungCap();
            ncc.MaNCC = MaNCC;
            ncc.TenNCC = TenNCC;
            ncc.DiaChi = DiaChi;
            ncc.Sdt = SDT;

            qlncc.NhaCungCaps.InsertOnSubmit(ncc);
            qlncc.NhaCungCaps.Context.SubmitChanges();
            return true;

        }
        public bool XoaNCC(ref string err, string MaNCC)
        {
            QuanLySieuThiDataContext qlncc = new QuanLySieuThiDataContext();
            var tpQuery = from ncc in qlncc.NhaCungCaps
                          where ncc.MaNCC == MaNCC
                          select ncc;
            qlncc.NhaCungCaps.DeleteAllOnSubmit(tpQuery);
            qlncc.SubmitChanges();
            return true;
        }
        public bool CapNhatNCC(string MaNCC, string TenNCC, string DiaChi, string SDT, ref string err)
        {
            QuanLySieuThiDataContext qlncc = new QuanLySieuThiDataContext();
            var tpQuery = (from ncc in qlncc.NhaCungCaps
                           where ncc.MaNCC == MaNCC
                           select ncc).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.TenNCC = TenNCC;
                tpQuery.DiaChi = DiaChi;
                tpQuery.Sdt = SDT;

                qlncc.SubmitChanges();
            }
            return true;
        }
    }
}
