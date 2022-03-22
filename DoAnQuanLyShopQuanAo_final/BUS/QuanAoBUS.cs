using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class QuanAoBUS
    {
        private QuanAoDAO _sanpham = new QuanAoDAO();

        public List<QuanAoDTO> LayDSQuanAO()
        {
            return _sanpham.LayDSQuanAo();
        }

        public bool ThemSP(QuanAoDTO sp)
        {
            return _sanpham.ThemSP(sp);
        }

        public bool XoaSP(string masp)
        {
            return _sanpham.XoaSP(masp);
        }

        public bool CapNhatSP(QuanAoDTO sp)
        {

            return _sanpham.CapNhatSP(sp);
        }

        public List<QuanAoDTO> TimSp(string tieuChi, string dieuKien)
        {
            return _sanpham.TimSp(tieuChi, dieuKien);
        }

        public QuanAoDTO LaythongTinSP(string maSp)
        {
            return _sanpham.LayThongTinSp(maSp);
        }

        public string MaxMaSP()
        {
            return _sanpham.MaxMaSP();
        }
        //
        public int KTraSoLUONG(string maSP)
        {
            return _sanpham.KTraSoLUONG(maSP);
        }
        //Lấy danh sách sp có số lượng < 5
        public List<QuanAoDTO> DSSPGanHet()
        {
            return _sanpham.DSSPGanHet();
        }
        //Lấy danh sách sản phẩm đã bán hết
        public List<QuanAoDTO> DSSPDaHet()
        {
            return _sanpham.DSSPDaHet();
        }
        //Lấy danh sách sản phẩm không bán được
        public List<QuanAoDTO> DSSPKhongBanDuoc(int thang)
        {
            return _sanpham.DSSPKhongBanDuoc(thang);
        }
    }
}
