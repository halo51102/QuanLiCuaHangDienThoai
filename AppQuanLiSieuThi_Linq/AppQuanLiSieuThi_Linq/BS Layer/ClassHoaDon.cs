using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace AppQuanLiSieuThi_Linq.BS_Layer
{
    class ClassHoaDon
    {
        
        public System.Data.Linq.Table<HoaDon> LayHoaDon()
        {
            DataSet ds = new DataSet();
            QuanLySieuThiDataContext db = new QuanLySieuThiDataContext();

            return db.HoaDons;
        }
        public bool ThemHoaDon(string MaHD, string MaThe, string MaNV, string Date, string Bill, ref string err)
        {
            QuanLySieuThiDataContext qlHD = new QuanLySieuThiDataContext();
            HoaDon hd = new HoaDon();
            hd.MaHoaDon = MaHD;
            hd.MaThe = MaThe;
            hd.MaNV = MaNV;
            hd.Ngay = Convert.ToDateTime(Date);
            hd.tongbill = Convert.ToDouble(Bill);
            

            qlHD.HoaDons.InsertOnSubmit(hd);
            qlHD.HoaDons.Context.SubmitChanges();
            return true;

        }
        public bool XoaHoaDon(ref string err, string MaHD)
        {
            QuanLySieuThiDataContext qlHD = new QuanLySieuThiDataContext();
            var tpQuery = from hd in qlHD.HoaDons
                          where hd.MaHoaDon == MaHD
                          select hd;
            qlHD.HoaDons.DeleteAllOnSubmit(tpQuery);
            qlHD.SubmitChanges();
            return true;
        }
        public bool CapNhatHoaDon(string MaHD, string MaThe, string MaNV, string Date, string Bill, ref string err)
        {
            QuanLySieuThiDataContext qlHD = new QuanLySieuThiDataContext();
            var tpQuery = (from hd in qlHD.HoaDons
                           where hd.MaHoaDon == MaHD
                           select hd).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.MaThe = MaThe;
                tpQuery.MaNV = MaNV;
                tpQuery.Ngay = Convert.ToDateTime(Date);
                tpQuery.tongbill = Convert.ToDouble(Bill);
                
                qlHD.SubmitChanges();
            }
            return true;
        }
    }
}
