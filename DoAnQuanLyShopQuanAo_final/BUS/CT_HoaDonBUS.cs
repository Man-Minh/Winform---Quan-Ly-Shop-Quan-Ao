using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CT_HoaDonBUS
    {
        private CT_HoaDonDAO _ctHD = new CT_HoaDonDAO();

        public List<CT_HoaDonDTO> LayCT_HoaDon()
        {
            return _ctHD.LayCT_HD();
        }

        public bool ThemCT_HD(CT_HoaDonDTO ct)
        {
            return _ctHD.ThemCT_HD(ct);
        }

        public List<CT_HoaDonDTO> LayCT_HDTheoMa(string maHD)
        {
            return _ctHD.LayCT_HDTheoMa(maHD);
        }
         //Kiểm tra chi tiết hóa đơn đã tồn tại hay chưa
        public bool KTra_CTHD(string maHD, string maSP)
        {
            return _ctHD.KTra_CTHD(maHD, maSP);
        }

         //Thống kê doanh thu theo ngày
        public decimal TKDoanhThu(DateTime ngay1, DateTime ngay2)
        {
            return _ctHD.TKDoanhThu(ngay1, ngay2);
        }
        //Thống kê doanh thu theo tiêu chí
        public decimal TKDoanhThu(string tieuChi, string ma)
        {
            return _ctHD.TKDoanhThu(tieuChi, ma);
        }

        public bool CapNhatCT_HD(CT_HoaDonDTO chiTietHD)
        {
            return _ctHD.CapNhatCT_HD(chiTietHD);
        }

        public bool XoaCT_HD(string maHD, string maSP)
        {
            return _ctHD.XoaCT_HD(maHD, maSP);
        }
    }
}
