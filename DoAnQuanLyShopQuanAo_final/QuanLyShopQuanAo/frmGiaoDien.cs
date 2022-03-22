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
    public partial class frmGiaoDien : Form
    {
        public static bool _ngonNgu = true;

        public frmGiaoDien()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLy fQuanLy = new frmQuanLy();

            fQuanLy.MdiParent = this;
            fQuanLy.Dock = DockStyle.Fill;
            fQuanLy.Show();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinTaiKhoan fThongTinTaiKhoan = new frmThongTinTaiKhoan();

            fThongTinTaiKhoan.MdiParent = this;
            fThongTinTaiKhoan.Dock = DockStyle.Fill;

            fThongTinTaiKhoan.Show();
        }

      
        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  

        private void frmGiaoDien_Load(object sender, EventArgs e)
        {
            frmQuanLy fQuanLy = new frmQuanLy();
            fQuanLy.MdiParent = this;
            fQuanLy.Dock = DockStyle.Fill;
            fQuanLy.Show();
        }

        private void tiếngAnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _ngonNgu = false;
            mtQuanLy.Text = "Mananger";
            mtThongTinTK.Text = "Account information";
            mtDangXuat.Text = "Log out";
            mtNgonNgu.Text = "Language";
            mtTiengAnh.Text = "English";
            mtTiengViet.Text = "Vietnamese";

            quảnLýToolStripMenuItem_Click(sender, e);
        }

        private void mtTiengViet_Click(object sender, EventArgs e)
        {
            _ngonNgu = true;
            mtQuanLy.Text = "Quản lý";
            mtThongTinTK.Text = "Thông tin tài khoản";
            mtDangXuat.Text = "Đăng xuất";
            mtNgonNgu.Text = "Ngôn ngữ";
            mtTiengAnh.Text = "Tiếng Anh";
            mtTiengViet.Text = "Tiếng Việt";

            quảnLýToolStripMenuItem_Click(sender, e);
        }

        public bool GetNgonNgu()
        {
            return _ngonNgu;
        }
    }
}
