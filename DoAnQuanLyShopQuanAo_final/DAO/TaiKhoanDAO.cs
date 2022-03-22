using DTO;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class TaiKhoanDAO
    {
        private ShopQuanAoEntities _qlShopEntities = new ShopQuanAoEntities();

        public List<TaiKhoanDTO> LayDSTaiKhoan()
        {
            return _qlShopEntities.TaiKhoans.Where(v => v.TrangThai == 1).Select(u => new TaiKhoanDTO { TenDangNhap = u.TenDangNhap, MatKhau = u.MatKhau, LoaiTK = u.LoaiTK, ID= u.ID.Value }).ToList();
        }

        public bool ThemTK(TaiKhoanDTO tk)
        {
            int kq = _qlShopEntities.THEMTK(tk.TenDangNhap, tk.MatKhau, tk.LoaiTK, tk.ID);
            return kq > 0;
        }

        public bool CapNhatTK(string tenTK, string matKhau)
        {
            int kq = _qlShopEntities.CAPNHATTK(matKhau, tenTK);
            return kq > 0;
        }

        public bool XoaTK(string tenTK)
        {
            int kq = _qlShopEntities.XOATK(tenTK);
            return kq > 0;
        }

        //Kiểm tra người dùng nhập đúng thông tin tài khoản ko
        public TaiKhoanDTO KTTaiKhoan(string taiKhoan, string matKhau)
        {
            TaiKhoan _TaiKhoan = _qlShopEntities.TaiKhoans.SingleOrDefault(u => u.TenDangNhap == taiKhoan && u.MatKhau == matKhau && u.TrangThai== 1);

            if (_TaiKhoan == null) return null;

            TaiKhoanDTO ThongTinTK = new TaiKhoanDTO
            {
                TenDangNhap = _TaiKhoan.TenDangNhap,
                MatKhau = _TaiKhoan.MatKhau,
                LoaiTK = _TaiKhoan.LoaiTK,
                ID = _TaiKhoan.ID.Value
            };

            return ThongTinTK;
        }

        //Kiểm tra tài khoản nhập vào có tồn tại hay không 
        public TaiKhoanDTO KTTaiKhoan(string taiKhoan)
        {
            TaiKhoan _TaiKhoan = _qlShopEntities.TaiKhoans.SingleOrDefault(u => u.TenDangNhap == taiKhoan && u.TrangThai==1);

            if (_TaiKhoan == null) return null;

            TaiKhoanDTO ThongTinTK = new TaiKhoanDTO
            {
                TenDangNhap = _TaiKhoan.TenDangNhap,
                MatKhau = _TaiKhoan.MatKhau,
                LoaiTK = _TaiKhoan.LoaiTK,
                ID = _TaiKhoan.ID.Value
            };

            return ThongTinTK;
        }
    }
}
