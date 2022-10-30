using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AppQuanLiSieuThi_Linq.BS_Layer
{
    class ClassKhuyenMai
    {
        
        public System.Data.Linq.Table<KhuyenMai> LayKhuyenMai()
        {
            DataSet ds = new DataSet();
            QuanLySieuThiDataContext qlkm = new QuanLySieuThiDataContext();
            return qlkm.KhuyenMais;
        }
        public bool ThemKM(string MaKM, string MaHang, string Mucgiam, string HetHan, ref string err)
        {
            QuanLySieuThiDataContext qlkm = new QuanLySieuThiDataContext();
            KhuyenMai km = new KhuyenMai();
            km.MaKM = MaKM;
            km.MaHang = MaHang;
            km.MucGiam = Convert.ToInt32(Mucgiam);
            km.NgayHetHan = Convert.ToDateTime(HetHan);

            qlkm.KhuyenMais.InsertOnSubmit(km);
            qlkm.KhuyenMais.Context.SubmitChanges();
          
            
            return true;

        }
        public bool XoaKM(ref string err, string MaKM)
        {
            
            QuanLySieuThiDataContext qlkm = new QuanLySieuThiDataContext();
            var tpQuery = from km in qlkm.KhuyenMais
                          where km.MaKM == MaKM
                          select km;
           
            qlkm.KhuyenMais.DeleteAllOnSubmit(tpQuery);
            qlkm.SubmitChanges();
            
            return true;
        }
        public bool CapNhatKM(string MaKM, string MaHang, string Mucgiam, string HetHan, ref string err)
        {

            QuanLySieuThiDataContext qlkm = new QuanLySieuThiDataContext();
            var tpQuery = (from km in qlkm.KhuyenMais
                          where km.MaKM == MaKM
                          select km).SingleOrDefault();
            if (tpQuery != null)
            {
                
                tpQuery.MaHang = MaHang;
                tpQuery.MucGiam = Convert.ToInt32(Mucgiam);
                tpQuery.NgayHetHan = Convert.ToDateTime(HetHan);

                qlkm.SubmitChanges();
            }
           
            return true;
        }
        public void CapNhatGia()
        {
            QuanLySieuThiDataContext qlkm = new QuanLySieuThiDataContext();
            foreach (var s in qlkm.HangHoas)
            {
                var km = (from i in qlkm.KhuyenMais
                          where i.MaHang == s.MaHang
                          select i).SingleOrDefault();
                if (km != null)
                {
                    s.GiaKM = s.Gia - s.Gia * km.MucGiam / 100;
                    qlkm.SubmitChanges();
                }
                else
                {
                    s.GiaKM = null;
                    qlkm.SubmitChanges();
                }
            }

        }
    }
}
