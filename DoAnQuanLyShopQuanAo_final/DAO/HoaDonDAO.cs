using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class HoaDonDAO
    {
        private ShopQuanAoEntities _qlShop = new ShopQuanAoEntities();
        public List<HoaDonDTO> LayDSHoaDon()
    {
        return _qlShop.HoaDons.Where(v => v.TrangThai == 1).Select(u => new HoaDonDTO { MaHD = u.MaHD, IDNVien = u.IDNVien.Value, NgayLapHD = u.NgayLapHD.Value, ThanhTien = u.ThanhTien.Value }).ToList();
    }

        public bool ThemHD(HoaDonDTO hd)
        {
            int kq = _qlShop.THEMHOADON(hd.MaHD, hd.NgayLapHD, hd.IDNVien, hd.ThanhTien);
            return kq > 0;
        }

        //Liệt kê danh sách hóa đơn trong khoảng tgian người dùng nhập
        public List<HoaDonDTO> TimHD(DateTime ngayA, DateTime ngayB)
        {
            List<HoaDonDTO> lsHD = new List<HoaDonDTO>();

            lsHD = _qlShop.HoaDons.Where(v => v.TrangThai == 1 && v.NgayLapHD>=ngayA && v.NgayLapHD<=ngayB).Select(u => new HoaDonDTO { MaHD = u.MaHD, IDNVien = u.IDNVien.Value, NgayLapHD = u.NgayLapHD.Value, ThanhTien = u.ThanhTien.Value }).ToList();
            return lsHD;
        }
        //Liệt kê danh sách hóa đơn theo tieu chi người dùng chọn
        public List<HoaDonDTO> TimTheoTieuChi( string tieuChi, string id)
        {
            List<HoaDonDTO> lsHD = new List<HoaDonDTO>();

            if (tieuChi.Equals("MaHD"))
            {
                lsHD = _qlShop.HoaDons.Where(v => v.TrangThai == 1 && v.MaHD.Equals(id)).Select(u => new HoaDonDTO { MaHD = u.MaHD, IDNVien = u.IDNVien.Value, NgayLapHD = u.NgayLapHD.Value, ThanhTien = u.ThanhTien.Value }).ToList();
            }
            else
            {
                int idNV= int.Parse(id);

                lsHD = _qlShop.HoaDons.Where(v => v.TrangThai == 1 && v.IDNVien==idNV).Select(u => new HoaDonDTO { MaHD = u.MaHD, IDNVien = u.IDNVien.Value, NgayLapHD = u.NgayLapHD.Value, ThanhTien = u.ThanhTien.Value }).ToList();
            }
           
            return lsHD;
        }

        public bool CapNhatHD(HoaDonDTO hd)
        {
            int kq = _qlShop.CAPNHATHD(hd.MaHD, hd.NgayLapHD, hd.IDNVien, hd.ThanhTien);
            return kq > 0;
        }

        public bool XoaHD(string maHD)
        {
            int kq = _qlShop.XOAHD(maHD);
            return kq > 0;
        }
        //Kiểm tra hóa đơn đã tồn tại hay chưa
        public bool KTraHD(string maHD)
        {
            HoaDon hd = _qlShop.HoaDons.SingleOrDefault(u =>u.MaHD.Equals(maHD));
            if (hd == null) return false;
            return true;
        }
    }
}
