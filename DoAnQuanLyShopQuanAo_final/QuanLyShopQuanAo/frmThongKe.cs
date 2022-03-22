using BUS;
using DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class frmThongKe : Form
    {
        private HoaDonBUS _hd = new HoaDonBUS();
        private CT_HoaDonBUS _ct = new CT_HoaDonBUS();
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            frmGiaoDien fGiaoDien= new frmGiaoDien();

            if(fGiaoDien.GetNgonNgu()== false)
            {
                label1.Text= "REVENUE STACTISTICS";
                lblBatDau.Text= "From";
                lblKetThuc.Text= "To";
                btnTimKiemNgay.Text= " Search";
                btnTimKiem2.Text= " Search";
                lblTC.Text= "Criteria";
                label5.Text= "REVENUE STACTISTICS";
                label2.Text= "Date created";
                label7.Text= "Total revenue";
            }
            else
            {
                label1.Text= "THỐNG KÊ DOANH THU";
                lblBatDau.Text= "Từ ngày";
                lblKetThuc.Text= "Đến ngày";
                btnTimKiemNgay.Text= " Tìm kiếm";
                btnTimKiem2.Text= " Tìm kiếm";
                lblTC.Text= "Tiêu chí";
                label5.Text= "THỐNG KÊ DOANH THU";
                label2.Text= "Ngày lập";
                label7.Text= "Tổng doanh thu";
            }
            dtpStart.CustomFormat = "MM dd yyyy";
            cboTieuChi.SelectedIndex = 0;

            this.rptDoanhThu.RefreshReport();
        }

        private void btnTimKiemNgay_Click(object sender, EventArgs e)
        {
            this.Refresh();
            string kq = _ct.TKDoanhThu(dtpStart.Value, dtpEnd.Value).ToString();

            lblNgayLapBC.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblTieuChi.Text = "Từ ngày " + dtpStart.Text + " đến ngày " + dtpEnd.Text;
           
           lblDoanhThu.Text = kq + "đ";
           XemBCTheoNgay();
        }

        private void btnTimKiem2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTieuChi.Text))
            {
                MessageBox.Show(ThongBao.INFO_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
                string kq = _ct.TKDoanhThu(cboTieuChi.Text, txtTieuChi.Text).ToString();

                lblNgayLapBC.Text = DateTime.Now.ToString("dd/MM/yyyy");
                lblTieuChi.Text = "Theo " + cboTieuChi.Text;
                lblDoanhThu.Text = kq + "đ";

                XemBCTheoTieuChi();
        }

        public void XemBCTheoNgay()
        {
            rptDoanhThu.Reset();
            rptDoanhThu.LocalReport.ReportEmbeddedResource = "QuanLyShopQuanAo.rptHoaDonTheoNgay.rdlc";
            rptDoanhThu.LocalReport.DataSources.Add(new ReportDataSource("DoanhThu", _hd.TimHD(dtpStart.Value, dtpEnd.Value)));
            rptDoanhThu.RefreshReport();
        }

        public void XemBCTheoTieuChi()
        {
            rptDoanhThu.Reset();
            rptDoanhThu.LocalReport.ReportEmbeddedResource = "QuanLyShopQuanAo.rptHDTheoTieuChi.rdlc";
            rptDoanhThu.LocalReport.DataSources.Add(new ReportDataSource("HoaDon", _hd.TimTheoTieuChi(cboTieuChi.Text, txtTieuChi.Text)));
            rptDoanhThu.RefreshReport();
        }

        private void txtTieuChi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
