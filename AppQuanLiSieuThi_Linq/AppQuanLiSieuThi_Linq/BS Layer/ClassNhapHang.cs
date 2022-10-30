using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace AppQuanLiSieuThi_Linq.BS_Layer
{
    class ClassNhapHang
    {
        public System.Data.Linq.Table<NhapHang> LayMaNH()
        {
            DataSet ds = new DataSet();
            QuanLySieuThiDataContext qlnh = new QuanLySieuThiDataContext();
            return qlnh.NhapHangs;
        }
        public bool ThemNH(string MaNH, string MaHang, string GiaNhap, string SoLuong, string NgayNhap, string NgayHH, ref string err)
        {
            QuanLySieuThiDataContext qlnh = new QuanLySieuThiDataContext();
            NhapHang nh = new NhapHang();
            nh.manhaphang = MaNH;
            nh.MaHang = MaHang;
            nh.gianhap = Convert.ToDouble(GiaNhap);
            nh.soluongnhap = Convert.ToDouble(SoLuong);
            nh.ngaynhap = Convert.ToDateTime(NgayNhap);
            nh.ngayhethan = Convert.ToDateTime(NgayHH);

            qlnh.NhapHangs.InsertOnSubmit(nh);
            qlnh.NhapHangs.Context.SubmitChanges();
            return true;

        }
        public bool XoaNH(ref string err, string MaNH)
        {
            QuanLySieuThiDataContext qlnh = new QuanLySieuThiDataContext();
            var tpQuery = from nh in qlnh.NhapHangs
                          where nh.manhaphang == MaNH
                          select nh;
            qlnh.NhapHangs.DeleteAllOnSubmit(tpQuery);
            qlnh.SubmitChanges();
            return true;
        }
        public bool CapNhatNH(string MaNH, string MaHang, string GiaNhap, string SoLuong, string NgayNhap, string NgayHH, ref string err)
        {
            QuanLySieuThiDataContext qlnh = new QuanLySieuThiDataContext();
            var tpQuery = (from nh in qlnh.NhapHangs
                           where nh.manhaphang == MaNH
                           select nh).SingleOrDefault();
            if (tpQuery != null)
            {
                tpQuery.MaHang = MaHang;
                tpQuery.gianhap = Convert.ToDouble(GiaNhap);
                tpQuery.soluongnhap = Convert.ToDouble(SoLuong);
                tpQuery.ngaynhap = Convert.ToDateTime(NgayNhap);
                tpQuery.ngayhethan = Convert.ToDateTime(NgayHH);

                qlnh.SubmitChanges();
            }
            return true;
        }
        public double tinhTongChi(double giaTri, double soLuong)
        {
            return giaTri * soLuong;
        }
    }
}
