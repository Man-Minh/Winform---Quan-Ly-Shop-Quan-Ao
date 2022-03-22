using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
   public class NhanVienDAO
    {
       private ShopQuanAoEntities _qlShop = new ShopQuanAoEntities();

       public List<NhanVienDTO> LayDSNhanVien()
       {
           return _qlShop.NhanViens.Where(v => v.TrangThai == 1).Select(u => new NhanVienDTO { ID = u.ID, HoTen = u.HoTen, NgaySinh = u.NgaySinh.Value, Luong = u.Luong.Value, Phai = u.Phai, SDT = u.SDT, SoNgayNghi = u.SoNgayNghi.Value }).ToList();
       }

       public bool ThemNV(NhanVienDTO nv)
       {
           int kq = _qlShop.THEMNV(nv.HoTen, nv.NgaySinh, nv.Phai, nv.Luong, nv.SDT);
           return kq > 0;
       }
       public bool CapNhatNV(NhanVienDTO nv)
       {

           int kq = _qlShop.CAPNHATNV(nv.ID, nv.HoTen, nv.NgaySinh, nv.Phai, nv.Luong, nv.SDT, nv.SoNgayNghi);
           return kq > 0;
       }
       public bool XoaNV(int idNV)
       {

           int kq = _qlShop.XOANV(idNV);
           return kq > 0;
       }

       public List<NhanVienDTO> TimNhanVien(int idNV)
       {
           List<NhanVienDTO> lsHD = new List<NhanVienDTO>();
           lsHD = _qlShop.NhanViens.Where(v => v.TrangThai == 1 && v.ID== idNV).Select(u => new NhanVienDTO { ID = u.ID, HoTen = u.HoTen, NgaySinh = u.NgaySinh.Value, Luong = u.Luong.Value, Phai = u.Phai, SDT = u.SDT, SoNgayNghi = u.SoNgayNghi.Value }).ToList();
 
           return lsHD;
       }
       // Kiểm tra nhân viên có tồn tại hay ko
       public bool KiemTraNhanVien(int idNV)
       {
           NhanVien nv = _qlShop.NhanViens.SingleOrDefault(u => u.TrangThai == 1 && u.ID == idNV);

           if (nv == null) return false;
           return true;
       }

       //Lấy thông tin hiển thị lên form thông tin tài khoản
       public NhanVienDTO LayThongTinNhanVien(int idNV)
       {
           NhanVien  nv = _qlShop.NhanViens.SingleOrDefault(u => u.TrangThai == 1 && u.ID == idNV);
           if (nv == null) return null;

           NhanVienDTO ThongTinNhanVien = new NhanVienDTO
           {
               HoTen = nv.HoTen,
               NgaySinh = nv.NgaySinh.Value,
               Phai = nv.Phai,
               Luong = nv.Luong.Value,
               SDT = nv.SDT,
               SoNgayNghi = nv.SoNgayNghi.Value
           };

           return ThongTinNhanVien;
       }

    }
}
