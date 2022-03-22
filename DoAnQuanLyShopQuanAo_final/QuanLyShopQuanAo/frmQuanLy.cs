using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo
{
    public partial class frmQuanLy : Form
    {

        public frmQuanLy()
        {
            InitializeComponent();
            panelTrangThaiMenu.Height = btnTrangChu.Height;
        }

        private bool PhanQuyen()// Man HAKI da chinh sua 8:49 : 05/27/2021 
        {
            frmDangNhap fLogin = new frmDangNhap();
            return fLogin.GetLoai();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {         
            // cap nhat trang thai cho thanh panel
            panelTrangThaiMenu.Height = btnTrangChu.Height;
            panelTrangThaiMenu.Top = btnTrangChu.Top;

            panel2.Hide();
        }
        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            
            panel2.Hide();
            if (PhanQuyen() == true)
            {
                btnNhanVien.Enabled = false;
                btnTaiKhoan.Enabled = false;
            }
            //Đổi ngôn ngữ
            frmGiaoDien fGiaoDien= new frmGiaoDien();
            if (fGiaoDien.GetNgonNgu() == true)
            {
                btnTrangChu.Text = "  Trang chủ";
                btnSanPham.Text = "  Sản Phẩm";
                btnNhanVien.Text = "  Nhân Viên";
                btnHoaDon.Text = "  Hóa Đơn";
                btnThongKe.Text = "  Thống Kê";
                btnTaiKhoan.Text = "  Tài Khoản";
            }
            else
            {
                btnTrangChu.Text = "  Home";
                btnSanPham.Text = "  Products";
                btnNhanVien.Text = "  Staffs";
                btnHoaDon.Text = "  Bills";
                btnThongKe.Text = "  Statistics";
                btnTaiKhoan.Text = "  Accounts";
            }
        }


        private void btnThongKe_Click(object sender, EventArgs e)
        {
            // cap nhat trang thai cho thanh panel
            panelTrangThaiMenu.Height = btnThongKe.Height;
            panelTrangThaiMenu.Top = btnThongKe.Top;

            panel2.Controls.Clear();

            panel2.Show();
            // khai bao form san pham
            frmNoiDungThongKe frm = new frmNoiDungThongKe();
            frm.TopLevel = false;

            panel2.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();                        
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            // cap nhat trang thai cho thanh panel 
            panelTrangThaiMenu.Height = btnNhanVien.Height;
            panelTrangThaiMenu.Top = btnNhanVien.Top;

            panel2.Controls.Clear();

            panel2.Show();
            // khai bao form san pham
            frmNhanVien frm = new frmNhanVien();
         
            frm.TopLevel = false;

            panel2.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();                     
        }

        private void btnTrangChu_Click_1(object sender, EventArgs e)
        {
            panel2.Hide();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {                   
            panelTrangThaiMenu.Height = btnSanPham.Height;
            panelTrangThaiMenu.Top = btnSanPham.Top;

            panel2.Controls.Clear();
           // panel2.Controls.RemoveAt(0);

            // cap nhat trang thai cho thanh panel 
            panel2.Show();

            frmSanPham fSPham = new frmSanPham();

            fSPham.TopLevel = false;

            panel2.Controls.Add(fSPham);
            fSPham.Dock = DockStyle.Fill;
            fSPham.Show();                        
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            panelTrangThaiMenu.Height = btnHoaDon.Height;
            panelTrangThaiMenu.Top = btnHoaDon.Top;

            panel2.Controls.Clear();        
            // cap nhat trang thai cho thanh panel 
            panel2.Show();
            // khai bao form san pham
            frmHoaDon frm = new frmHoaDon();
          
            frm.TopLevel = false;

            panel2.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();          
        }

        private void btnTaiKhoan_Click_1(object sender, EventArgs e)
        {
            panelTrangThaiMenu.Height = btnTaiKhoan.Height;
            panelTrangThaiMenu.Top = btnTaiKhoan.Top;

            panel2.Controls.Clear();       
            // cap nhat trang thai cho thanh panel 
            panel2.Show();
            // khai bao form san pham
            frmTaiKhoan frm = new frmTaiKhoan();
       
            frm.TopLevel = false;

            panel2.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
   
    }
}
