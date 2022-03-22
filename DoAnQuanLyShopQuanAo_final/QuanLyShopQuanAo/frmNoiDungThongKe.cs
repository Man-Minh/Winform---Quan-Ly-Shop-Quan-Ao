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
    public partial class frmNoiDungThongKe : Form
    {
        public frmNoiDungThongKe()
        {
            InitializeComponent();
        }


        private void frmNoiDungThongKe_Load(object sender, EventArgs e)
        {
            frmGiaoDien fGiaoDien = new frmGiaoDien();
            if (fGiaoDien.GetNgonNgu() == false)
            {
                radDoanhThu.Text = "Revenue statistics";
                radSoLuong.Text = "Quantity of products <= 5";
                radSPDaHet.Text = "The product is sold out";
                radSPKhongBanDuoc.Text = "The product is not for sale:";
                btnXem.Text = "     View";
                label1.Text = "STATISTICAL";
                groupBox1.Text = "Statistical content";
            }
            else
            {
                if (fGiaoDien.GetNgonNgu() == false)
                {
                    radDoanhThu.Text = "Thống kê doanh thu";
                    radSoLuong.Text = "Các sản phẩm có số lượng <=5";
                    radSPDaHet.Text = "Các sản phẩm đã bán hết";
                    radSPKhongBanDuoc.Text = "Các sản phẩm không bán được trong tháng:";
                    btnXem.Text = "     Xem";
                    label1.Text = "THỐNG KÊ";
                    groupBox1.Text = "Nội dung thống kê";
                }
            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (radDoanhThu.Checked == true)
            {
                frmThongKe fDoanhThu = new frmThongKe();
                fDoanhThu.ShowDialog();
            }
            else
            {
                frmThongKeSanPham frm = new frmThongKeSanPham();
                if (radSPDaHet.Checked == true)
                {
                    frm.DSSPBanHet();
                    frm.ShowDialog();
                }
                if (radSoLuong.Checked == true)
                {
                    frm.DSSPGanHet();
                    frm.ShowDialog();
                }
                if (radSPKhongBanDuoc.Checked == true)
                {
                    frm.DSSPKhongBanDuoc(int.Parse(nbrThang.Value.ToString()));
                    frm.ShowDialog();
                }
            }
        }
    }
}
