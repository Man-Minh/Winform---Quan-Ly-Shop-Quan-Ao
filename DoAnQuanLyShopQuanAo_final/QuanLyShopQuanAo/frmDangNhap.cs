using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo
{
    public partial class frmDangNhap : Form
    {
        private TaiKhoanBUS _taiKhoanBUS = new TaiKhoanBUS();
        private static string LoaiTK = "";
        public static TaiKhoanDTO  TaiKhoan;

        public frmDangNhap()
        { 
            // Hàm Dựng
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            // Kiểm tra người dùng có điền thông tin tài khoản
            if (String.IsNullOrEmpty(txtTaiKhoan.Text) || String.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(ThongBao.MESS_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            if (_taiKhoanBUS.KTTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text) != null)
            {
                LoaiTK = _taiKhoanBUS.KTTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text).LoaiTK;
                TaiKhoan = _taiKhoanBUS.KTTaiKhoan(txtTaiKhoan.Text, txtMatKhau.Text);

                frmGiaoDien fGiaoDien = new frmGiaoDien();
                this.Hide();
                fGiaoDien.ShowDialog();
            }
            else
            {
                MessageBox.Show(ThongBao.ERRO_ACCOUNT, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }                   
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Clear();
            txtMatKhau.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(ThongBao.MESS_EXIT, ThongBao.MESS_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        public bool GetLoai() // Man HAKI da chinh sua 8:49 : 05/27/2021 
        {
            if (String.Compare(LoaiTK.Trim(), "user", true) == 0)
            {
                return true;
            }
            return false;
        } 

        public TaiKhoanDTO GetTK()
        {
            return TaiKhoan;
        }

    }
}
