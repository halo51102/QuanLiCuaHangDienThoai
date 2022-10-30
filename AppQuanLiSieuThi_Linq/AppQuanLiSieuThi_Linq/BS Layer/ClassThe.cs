using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AppQuanLiSieuThi_Linq.BS_Layer
{
    class ClassThe
    {
        public System.Data.Linq.Table<The> LaySDT()
        {
            DataSet ds = new DataSet();
            QuanLySieuThiDataContext qlthe = new QuanLySieuThiDataContext();
            return qlthe.Thes;
        }
        public bool ThemThe(string MaThe, string SDT, string TenKH, string TongTien, string Hang, ref string err)
        {
            QuanLySieuThiDataContext qlthe = new QuanLySieuThiDataContext();
            The th = new The();
            th.MaThe = MaThe;
            th.SDT = SDT;
            th.TenKH = TenKH;
            th.Tongtien = Convert.ToDouble(TongTien);
            th.Hang = Hang;

            qlthe.Thes.InsertOnSubmit(th);
            qlthe.Thes.Context.SubmitChanges();
            return true;

        }
        public bool XoaThe(ref string err, string MaThe)
        {
            QuanLySieuThiDataContext qlthe = new QuanLySieuThiDataContext();
            var tpQuery = from th in qlthe.Thes
                          where th.MaThe == MaThe
                          select th;
            qlthe.Thes.DeleteAllOnSubmit(tpQuery);
            qlthe.SubmitChanges();
            return true;
        }
        public bool CapNhatThe(string MaThe, string SDT, string TenKH, string TongTien, string Hang, ref string err)
        {
            QuanLySieuThiDataContext qlthe = new QuanLySieuThiDataContext();
            var tpQuery = (from th in qlthe.Thes
                           where th.MaThe == MaThe
                           select th).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.SDT = SDT;
                tpQuery.TenKH = TenKH;
                tpQuery.Tongtien = Convert.ToDouble(TongTien);
                tpQuery.Hang = Hang;

                qlthe.SubmitChanges();
            }
            return true;
        }
    }
}
