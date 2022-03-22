using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QuanLyShopQuanAo
{
    public partial class frmThongTinTaiKhoan : Form
    {
        public frmThongTinTaiKhoan()
        {
            InitializeComponent();
        }

        private TaiKhoanBUS _TaiKhoanBUS = new TaiKhoanBUS();
        private NhanVienBUS _NhanVienBUS = new NhanVienBUS();

        private TaiKhoanDTO layThongTinTaiKhoan()
        {
            frmDangNhap fdangNhap = new frmDangNhap();
            return fdangNhap.GetTK();
        }
        private void frmThongTinTaiKhoan_Load(object sender, EventArgs e)
        {
            frmGiaoDien fGiaoDien = new frmGiaoDien();

            if(fGiaoDien.GetNgonNgu()==false)
            {
                grbThongTin.Text = "Personal Information:";
                label2.Text = "Name:";
                label3.Text = "Salary:";
                label4.Text = "Phone number:";
                label5.Text = "Leave:";
                label6.Text = "Date of birth:";
                label7.Text = "Sex:";
                label8.Text = "New password:";
                label9.Text = "User name:";
                label10.Text = "Type:";
                label11.Text = "Confirm password:";
                btnXacNhanDoiMatKhau.Text = "     Finish";
                btnDoiMatKhau.Text = "     Change Password";
            }
            else
            {
                grbThongTin.Text = "Thông Tin Cá Nhân:";
                label2.Text = "Họ tên:";
                label3.Text = "Lương:";
                label4.Text = "SĐT:";
                label5.Text = "Số ngày nghỉ:";
                label6.Text = "Ngày sinh:";
                label7.Text = "Phái:";
                label8.Text = "Mật khẩu mới:";
                label9.Text = "Tên đăng nhập";
                label10.Text = "Chức vụ:";
                label11.Text = "Xác nhận mật khẩu:";
                btnXacNhanDoiMatKhau.Text = "     Hoàn thành";
                btnDoiMatKhau.Text = "     Đổi mật khẩu";
            }
            pnDoiMatKhau.Visible = false;
            NhanVienDTO ThongTinNhanVien = _NhanVienBUS.LayThongTinNhanVien(layThongTinTaiKhoan().ID);
            int t = layThongTinTaiKhoan().ID;

            lbTenDangNhap.Text = layThongTinTaiKhoan().TenDangNhap;
            lbChucVu.Text = layThongTinTaiKhoan().LoaiTK;
            lbHoTen.Text = ThongTinNhanVien.HoTen;
            lbLuong.Text = ThongTinNhanVien.Luong.ToString();
            lbSDT.Text = ThongTinNhanVien.SDT;
            lbNgaySinh.Text = ThongTinNhanVien.NgaySinh.ToString("dd/MM/yyyy");
            lbGioiTinh.Text = ThongTinNhanVien.Phai;
            lbNgayNghi.Text = ThongTinNhanVien.SoNgayNghi.ToString();
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            pnDoiMatKhau.Visible = true;
        }

        private void btnXacNhanDoiMatKhau_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMatKhau.Text) || string.IsNullOrEmpty(txtMatKhauXacNhan.Text)|| string.IsNullOrEmpty(txtMKCu.Text))
            {
                MessageBox.Show(ThongBao.MESS_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            frmDangNhap fDangNhap = new frmDangNhap();

            if (txtMKCu.Text.Equals(fDangNhap.GetTK().MatKhau.Trim()))
            {
                string MatKhauMoi;
                
                if (txtMatKhau.Text.Equals(txtMatKhauXacNhan.Text))
                {
                    MatKhauMoi = txtMatKhau.Text;
                    if (_TaiKhoanBUS.CapNhatTK(MatKhauMoi, layThongTinTaiKhoan().TenDangNhap))
                    {
                        MessageBox.Show(ThongBao.UPDATE_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        MessageBox.Show(ThongBao.UPDATE_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(ThongBao.CHECK_PASS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show(ThongBao.CHECK_PASS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
