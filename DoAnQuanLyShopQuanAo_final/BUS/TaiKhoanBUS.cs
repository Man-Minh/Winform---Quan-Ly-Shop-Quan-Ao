using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TaiKhoanBUS
    {
        private TaiKhoanDAO _taiKhoan = new TaiKhoanDAO();

         public List<TaiKhoanDTO> LayDSTaiKhoan()
        {
            return _taiKhoan.LayDSTaiKhoan();
        }

         public bool ThemTK(TaiKhoanDTO tk)
         {
             return _taiKhoan.ThemTK(tk);
         }

         public bool CapNhatTK(string tenTK, string matKhau)
         {
             return _taiKhoan.CapNhatTK(matKhau, tenTK);
         }

         public bool XoaTK(string tenTK)
         {
             return _taiKhoan.XoaTK(tenTK);
             
         }

         // Man HAKI da chinh sua 8:49 : 05/27/2021 
         public TaiKhoanDTO KTTaiKhoan(string taiKhoan, string matKhau)
         {
             return _taiKhoan.KTTaiKhoan(taiKhoan, matKhau);
         }

         public TaiKhoanDTO KTTaiKhoan(string taiKhoan)
         {
             return _taiKhoan.KTTaiKhoan(taiKhoan);
         }

    }
}
