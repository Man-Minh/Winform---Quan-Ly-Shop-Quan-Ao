using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class CT_HoaDonDAO
    {
        private static string _connectionStr = @"Data Source=DESKTOP-QE3S3NR\SQLEXPRESS;Initial Catalog=ShopQuanAo;Integrated Security=True";
        private SqlConnection _conn = new SqlConnection(_connectionStr);

        public List<CT_HoaDonDTO> LayCT_HD()
        {
            List<CT_HoaDonDTO> lsCTHD = new List<CT_HoaDonDTO>();

            _conn.Open();
            string sql = "SELECT * FROM CT_HOADON WHERE TRANGTHAI=1";
            SqlCommand cmd = new SqlCommand(sql, _conn);
            SqlDataReader rder = cmd.ExecuteReader();

            if(rder.HasRows)
            {
                while(rder.Read())
                {
                    CT_HoaDonDTO cTiet = new CT_HoaDonDTO()
                    {
                        MaHD = rder.GetString(0),
                        MaSP = rder.GetString(1),
                        SoLuong = rder.GetInt32(2),
                        DonGia = rder.GetDecimal(3)
                    };
                    lsCTHD.Add(cTiet);
                }
            }
            _conn.Close();

            return lsCTHD;
        }
        //Thêm chi tiết hóa đơn
        public bool ThemCT_HD(CT_HoaDonDTO ct)
        {
            _conn.Open();
            string sql = @"INSERT INTO CT_HoaDon(MaHD, MaSP, SoLuong, DonGia, TrangThai)
                           VALUES (@mahd, @masp, @soluong, @dongia, 1)
                           UPDATE HoaDon
                           SET ThanhTien= (SELECT SUM(SOLUONG*DONGIA) FROM CT_HoaDon WHERE MaHD=@mahd AND TRANGTHAI=1)
                           WHERE MAHD= @mahd
                           UPDATE QUANAO 
                           SET SOLUONG= SOLUONG - @SOLUONG WHERE MASP= @masp";
            List<SqlParameter> parameter = new List<SqlParameter>();

            parameter.Add(new SqlParameter("@mahd", ct.MaHD));
            parameter.Add(new SqlParameter("@masp", ct.MaSP));
            parameter.Add(new SqlParameter("@soluong", ct.SoLuong));
            parameter.Add(new SqlParameter("@dongia", ct.DonGia));
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddRange(parameter.ToArray());
            int kq = cmd.ExecuteNonQuery();
            _conn.Close();

            return kq > 0;
        }
        //Cập nhật chi tiết hóa đơn
        public bool CapNhatCT_HD(CT_HoaDonDTO chiTietHD)
        {
            _conn.Open();

            string sql = @"UPDATE CT_HOADON SET SOLUONG= @soLuong, DONGIA= @donGia WHERE MaHD= @maHD AND MASP= @maSP
                          UPDATE HoaDon
                          SET ThanhTien= (SELECT SUM(SOLUONG*DONGIA) FROM CT_HoaDon WHERE MaHD=@maHD AND TRANGTHAI=1)
                          WHERE MaHD= @maHD";
            List<SqlParameter> parameter= new List<SqlParameter>();

            parameter.Add(new SqlParameter("@soLuong", chiTietHD.SoLuong));
            parameter.Add(new SqlParameter("@donGia", chiTietHD.DonGia));
            parameter.Add(new SqlParameter("@maHD", chiTietHD.MaHD));
            parameter.Add(new SqlParameter("@maSP", chiTietHD.MaSP));

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddRange(parameter.ToArray());

            int kq = cmd.ExecuteNonQuery();
             _conn.Close();

          
            return kq > 0;
        }
        //Xóa chi tiết hóa đơn
        public bool XoaCT_HD(string maHD, string maSP)
        {
            _conn.Open();

            string sql = @"UPDATE CT_HOADON SET TRANGTHAI= 0 WHERE MaHD= @maHD AND MASP= @maSP
                          UPDATE HoaDon
                          SET ThanhTien= (SELECT 0 + SUM(SOLUONG*DONGIA) FROM CT_HoaDon WHERE MaHD=@maHD AND TRANGTHAI=1)
                          WHERE MaHD= @maHD
                           IF (SELECT ThanhTien FROM HOADON WHERE MAHD=@mahd) IS NULL 
						 BEGIN Update HoaDon SET THANHTIEN=0 WHERE MAHD=@mahd AND TRANGTHAI=1 END";
            List<SqlParameter> parameter = new List<SqlParameter>();

            parameter.Add(new SqlParameter("@maHD", maHD));
            parameter.Add(new SqlParameter("@maSP", maSP));

            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddRange(parameter.ToArray());

            int kq = cmd.ExecuteNonQuery();
            _conn.Close();


            return kq > 0;
        }
        //Lấy danh sách hóa đơn theo mã hd
        public List<CT_HoaDonDTO> LayCT_HDTheoMa(string maHD)
        {
            List<CT_HoaDonDTO> lstCT_HoaDon = new List<CT_HoaDonDTO>();

            _conn.Open();
            string sql = "SELECT * FROM CT_HOADON WHERE TRANGTHAI=1 and MaHD=@ma";
            List<SqlParameter> parameter = new List<SqlParameter>();

            parameter.Add(new SqlParameter("@ma", maHD));
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddRange(parameter.ToArray());
            SqlDataReader rder = cmd.ExecuteReader();

            if (rder.HasRows)
            {
                while (rder.Read())
                {
                    CT_HoaDonDTO cTiet = new CT_HoaDonDTO()
                    {
                        MaHD = rder.GetString(0),
                        MaSP = rder.GetString(1),
                        SoLuong = rder.GetInt32(2),
                        DonGia = rder.GetDecimal(3)
                    };
                    lstCT_HoaDon.Add(cTiet);
                }
            }
            _conn.Close();

            return lstCT_HoaDon;
        }
        //Kiểm tra chi tiết hóa đơn đã tồn tại hay chưa
        public bool KTra_CTHD(string maHD, string maSP)
        {
            _conn.Open();
            
            string sql = "SELECT COUNT(*) FROM CT_HOADON WHERE MAHD=@mahd AND MASP= @masp";
            List<SqlParameter> parameter = new List<SqlParameter>();

            parameter.Add(new SqlParameter("@mahd", maHD));
            parameter.Add(new SqlParameter("@masp", maSP));
            SqlCommand cmd = new SqlCommand(sql, _conn);
            cmd.Parameters.AddRange(parameter.ToArray());
            int kq = (int)cmd.ExecuteScalar();
           
            _conn.Close();
            
            return kq > 0;
        }

        //Thống kê doanh thu theo ngày
        public decimal TKDoanhThu(DateTime ngay1, DateTime ngay2)
        {
            try
            {
                _conn.Open();
              
                string sql = @"SELECT SUM(SOLUONG * DONGIA) FROM HOADON a, CT_HOADON b
                         WHERE a.MAHD= b.MAHD AND b.TRANGTHAI=1 AND a.NGAYLAPHD>= @ngay1 AND a.NGAYLAPHD<= @ngay2";
                List<SqlParameter> parameter = new List<SqlParameter>();

                parameter.Add(new SqlParameter("@ngay1", ngay1));
                parameter.Add(new SqlParameter("@ngay2", ngay2));

                SqlCommand cmd = new SqlCommand(sql, _conn);

                cmd.Parameters.AddRange(parameter.ToArray());
                decimal kq = (decimal)cmd.ExecuteScalar();

                _conn.Close();

                return kq;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

        //Thống kê doanh thu theo tiêu chí
        public decimal TKDoanhThu(string tieuChi, string ma)
        {
            try
            {
                string sql;
               
                _conn.Open();
               
                List<SqlParameter> parameter = new List<SqlParameter>();
                if (tieuChi.Equals("MaHD"))
                {
                    sql = @"SELECT SUM(SOLUONG * DONGIA) FROM CT_HOADON 
                         WHERE TRANGTHAI= 1 AND MAHD= @ma";
                    parameter.Add(new SqlParameter("@ma", ma));
                }
                else
                {
                    sql = @"SELECT SUM(SOLUONG * DONGIA) FROM HOADON a, CT_HOADON b
                         WHERE a.MAHD= b.MAHD AND a.TRANGTHAI= 1 AND IDNVIEN= @ma";
                    int idNV = int.Parse(ma);
                    parameter.Add(new SqlParameter("@ma", idNV));
                }
               

                SqlCommand cmd = new SqlCommand(sql, _conn);

                cmd.Parameters.AddRange(parameter.ToArray());
                decimal kq = (decimal)cmd.ExecuteScalar();

                _conn.Close();

                return kq;
            }
            catch (Exception e)
            {
                return 0;
            }
        }

    }
}
