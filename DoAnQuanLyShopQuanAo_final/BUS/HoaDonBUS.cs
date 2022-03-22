using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDonBUS
    {
        private HoaDonDAO _hoaDon = new HoaDonDAO();

        public List<HoaDonDTO> LayDSHoaDon()
        {
            return _hoaDon.LayDSHoaDon();
        }

        public bool ThemHD(HoaDonDTO hd)
        {
            return _hoaDon.ThemHD(hd);
        }

        public List<HoaDonDTO> TimHD(DateTime ngayA, DateTime ngayB)
        {
            return _hoaDon.TimHD(ngayA, ngayB);
        }
        public List<HoaDonDTO> TimTheoTieuChi(string tieuChi, string id)
        {
            return _hoaDon.TimTheoTieuChi(tieuChi, id);
        }

        public bool CapNhatHD(HoaDonDTO hd)
        {
            return _hoaDon.CapNhatHD(hd);
        }

        public bool XoaHD(string maHD)
        {
            return _hoaDon.XoaHD(maHD);
        }

         //Kiểm tra hóa đơn đã tồn tại hay chưa
        public bool KTraHD(string maHD)
        {
            return _hoaDon.KTraHD(maHD);
        }
    }
}
