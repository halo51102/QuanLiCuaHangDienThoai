using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AppQuanLiSieuThi_Linq.BS_Layer
{
    class ClassLoaiHang
    {
        public System.Data.Linq.Table<LoaiHang> LayLoaiHang()
        {
            DataSet ds = new DataSet();
            QuanLySieuThiDataContext qllh = new QuanLySieuThiDataContext();
            return qllh.LoaiHangs;
        }
        public bool ThemLH(string MaLH, string TenLH, ref string err)
        {
            QuanLySieuThiDataContext qllh = new QuanLySieuThiDataContext();
            LoaiHang lh = new LoaiHang();
            lh.MaLoaiHang = MaLH;
            lh.TenLoaiHang = TenLH;

            qllh.LoaiHangs.InsertOnSubmit(lh);
            qllh.LoaiHangs.Context.SubmitChanges();
            return true;

        }
        public bool XoaLH(ref string err, string MaLH)
        {
            QuanLySieuThiDataContext qllh = new QuanLySieuThiDataContext();
            var tpQuery = from lh in qllh.LoaiHangs
                          where lh.MaLoaiHang == MaLH
                          select lh;
            qllh.LoaiHangs.DeleteAllOnSubmit(tpQuery);
            qllh.SubmitChanges();
            return true;
        }
        public bool CapNhatLH(string MaLH, string TenLH, ref string err)
        {
            QuanLySieuThiDataContext qllh = new QuanLySieuThiDataContext();
            var tpQuery = (from lh in qllh.LoaiHangs
                           where lh.MaLoaiHang == MaLH
                           select lh).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.TenLoaiHang = TenLH;

                qllh.SubmitChanges();
            }
            return true;
        }
    }
}
