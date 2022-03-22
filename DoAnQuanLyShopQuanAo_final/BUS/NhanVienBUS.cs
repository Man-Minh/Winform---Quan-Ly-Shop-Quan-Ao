using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NhanVienBUS
    {
        private NhanVienDAO _nv = new NhanVienDAO();

        public List<NhanVienDTO> LayDSNhanVien()
        {
            return _nv.LayDSNhanVien();
        }

        public bool ThemNV(NhanVienDTO nv)
        {
            return _nv.ThemNV(nv); 
        }
        public bool CapNhatNV(NhanVienDTO nv)
        {

            return _nv.CapNhatNV(nv);
        }
        public bool XoaNV(int idNV)
        {

            return _nv.XoaNV(idNV);
        }

        public List<NhanVienDTO> TimNhanVien(int idNV)
        {
            return _nv.TimNhanVien(idNV);
        }

        public bool KiemTraNhanVien(int idNV)
        {
            return _nv.KiemTraNhanVien(idNV);
        }

        // da them vao ngay 28/05 
        public NhanVienDTO LayThongTinNhanVien(int maNV)
        {
            return _nv.LayThongTinNhanVien(maNV);
        }

        

    }
}
