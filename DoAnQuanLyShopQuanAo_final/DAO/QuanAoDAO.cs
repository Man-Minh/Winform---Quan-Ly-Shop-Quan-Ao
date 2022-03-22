using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class QuanAoDAO
    {
        private ShopQuanAoEntities _qlShop = new ShopQuanAoEntities();
        private static string _connectionStr = @"Data Source=DESKTOP-QE3S3NR\SQLEXPRESS;Initial Catalog=ShopQuanAo;Integrated Security=True";
        private SqlConnection _conn = new SqlConnection(_connectionStr);
        public List<QuanAoDTO> LayDSQuanAo()
        {
            return _qlShop.QuanAos.Where(u => u.TrangThai == 1).Select(a => new QuanAoDTO
            {
                TenSP = a.TenSP,
                MaSP = a.MaSP,
                LoaiSP = a.Loai,
                Size = a.Size,
                SoLuong = a.SoLuong.Value,
                DonGia = a.DonGia.Value,
                Anh = a.Anh,
                GiamGia = a.GiamGia.Value
            }
            ).ToList();
        }

        public bool ThemSP(QuanAoDTO sp)
        {
            int kq = _qlShop.THEMSANPHAM(sp.TenSP, sp.MaSP, sp.LoaiSP, sp.Size, sp.SoLuong, sp.DonGia, sp.Anh, sp.GiamGia);
            return kq > 0;
        }

        public bool XoaSP(string masp)
        {

            int kq = _qlShop.XOASANPHAM(masp);
            return kq > 0;
        }

        public bool CapNhatSP(QuanAoDTO sp)
        {

            int kq = _qlShop.SUASANPHAM(sp.TenSP, sp.MaSP, sp.LoaiSP, sp.Size, sp.SoLuong, sp.DonGia, sp.GiamGia);
            return kq > 0;
        }

        public QuanAoDTO LayThongTinSp(string maSp)
        {
             QuanAo _QuanAo = _qlShop.QuanAos.SingleOrDefault(u => u.MaSP == maSp);
             if (_QuanAo == null) return null;

             QuanAoDTO KetQua = new QuanAoDTO
             {
                 MaSP = _QuanAo.MaSP,
                 DonGia= _QuanAo.DonGia.Value
             };

             return KetQua;
        }
       
        public List<QuanAoDTO> TimSp(string tieuChi, string dieuKien)
        {
            List<QuanAoDTO> lstQuanAo =new List<QuanAoDTO>();

            if(tieuChi.Equals("MaSP"))
            {
                lstQuanAo = _qlShop.QuanAos.Where(u => u.MaSP == dieuKien).Select(a => new QuanAoDTO
                {
                    TenSP = a.TenSP,
                    MaSP = a.MaSP,
                    LoaiSP = a.Loai,
                    Size = a.Size,
                    SoLuong = a.SoLuong.Value,
                    DonGia = a.DonGia.Value,
                    Anh = a.Anh,
                    GiamGia = a.GiamGia.Value
                }  ).ToList();
                if (lstQuanAo == null) return null;
            }
            else if(tieuChi.Equals("LoaiSP"))
            {
                lstQuanAo = _qlShop.QuanAos.Where(u => u.Loai == dieuKien).Select(a => new QuanAoDTO
                {
                    TenSP = a.TenSP,
                    MaSP = a.MaSP,
                    LoaiSP = a.Loai,
                    Size = a.Size,
                    SoLuong = a.SoLuong.Value,
                    DonGia = a.DonGia.Value,
                    Anh = a.Anh,
                    GiamGia = a.GiamGia.Value
                }).ToList();
                if (lstQuanAo == null) return null;
            }
            else
            {
                lstQuanAo = _qlShop.QuanAos.Where(u => u.Size == dieuKien).Select(a => new QuanAoDTO
                {
                    TenSP = a.TenSP,
                    MaSP = a.MaSP,
                    LoaiSP = a.Loai,
                    Size = a.Size,
                    SoLuong = a.SoLuong.Value,
                    DonGia = a.DonGia.Value,
                    Anh = a.Anh,
                    GiamGia = a.GiamGia.Value
                }).ToList();
                if (lstQuanAo == null) return null;
            }

            return lstQuanAo;
        }
        //Lấy mã sp mới
        public string MaxMaSP()
        {
            int max = int.Parse(_qlShop.QuanAos.Max(u => u.MaSP)) +1;
            return 0 + max.ToString();
        }

        //kiểm tra số lượng sp
        public int KTraSoLUONG(string maSP)
        {
          QuanAo sp= _qlShop.QuanAos.SingleOrDefault(u => u.MaSP == maSP);
          return sp.SoLuong.Value;
        }
        //Lấy danh sách sp có số lượng < 5
        public List<QuanAoDTO> DSSPGanHet()
        {
            List<QuanAoDTO> lstQuanAo = new List<QuanAoDTO>();
            lstQuanAo = _qlShop.QuanAos.Where(v => v.TrangThai == 1 && v.SoLuong <= 5 && v.SoLuong>0).Select(u => new QuanAoDTO
            {
                TenSP = u.TenSP,
                MaSP = u.MaSP,
                LoaiSP = u.Loai,
                Size = u.Size,
                SoLuong = u.SoLuong.Value,
                DonGia = u.DonGia.Value,
                Anh = u.Anh,
                GiamGia = u.GiamGia.Value
            }).ToList();
            return lstQuanAo;
        }
        //Lấy danh sách sản phẩm đã bán hết
        public List<QuanAoDTO> DSSPDaHet()
        {
            List<QuanAoDTO> lstQuanAo = new List<QuanAoDTO>();
            lstQuanAo = _qlShop.QuanAos.Where(v => v.TrangThai == 1 && v.SoLuong == 0).Select(u => new QuanAoDTO
            {
                TenSP = u.TenSP,
                MaSP = u.MaSP,
                LoaiSP = u.Loai,
                Size = u.Size,
                SoLuong = u.SoLuong.Value,
                DonGia = u.DonGia.Value,
                Anh = u.Anh,
                GiamGia = u.GiamGia.Value
            }).ToList();
            return lstQuanAo;
        }
        //Lấy danh sách sản phẩm không bán được
        public List<QuanAoDTO> DSSPKhongBanDuoc(int thang)
        {
            List<QuanAoDTO> lstQuanAo = new List<QuanAoDTO>();

            _conn.Open();

            string sql = @" SELECT * FROM QUANAO 
                           WHERE TRANGTHAI=1 AND MASP NOT IN(SELECT MASP FROM CT_HoaDon A, HoaDon B 
                                                             WHERE A.MaHD= B.MaHD  AND A.TRANGTHAI=1 AND MONTH(B.NgayLapHD ) = @thang AND YEAR(B.NgayLapHD)= YEAR(GETDATE())) ";
            SqlParameter parameter = new SqlParameter("@thang", thang);
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.Add(parameter);

            SqlDataReader rder = cmd.ExecuteReader();

            if (rder.HasRows)
            {
                while (rder.Read())
                {
                    QuanAoDTO sp = new QuanAoDTO()
                    {
                        TenSP = rder.GetString(0),
                        MaSP = rder.GetString(1),
                        LoaiSP = rder.GetString(2),
                        Size = rder.GetString(3),
                        SoLuong = rder.GetInt32(4),
                        DonGia = rder.GetDecimal(5),
                        Anh = rder.GetString(6),
                        GiamGia = rder.GetInt32(8)
                    };
                    lstQuanAo.Add(sp);
                }
            }
            _conn.Close();

            return lstQuanAo;
        }
    }
  

}
