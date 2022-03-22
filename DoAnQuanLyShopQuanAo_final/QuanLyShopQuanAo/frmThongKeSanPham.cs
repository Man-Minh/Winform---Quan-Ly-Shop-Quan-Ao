using BUS;
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
    public partial class frmThongKeSanPham : Form
    {
        private QuanAoBUS _spBUS = new QuanAoBUS();
        public frmThongKeSanPham()
        {
            InitializeComponent();
        }

        private void frmThongKeSanPham_Load(object sender, EventArgs e)
        {

            this.rptvSanPham.RefreshReport();
        }

        public void DSSPBanHet()
        {
            rptvSanPham.LocalReport.ReportEmbeddedResource = "QuanLyShopQuanAo.rptSanPhamBanHet.rdlc";
            rptvSanPham.LocalReport.DataSources.Add(new ReportDataSource("SanPham", _spBUS.DSSPDaHet()));
            rptvSanPham.RefreshReport();
        }

        public void DSSPGanHet()
        {
            rptvSanPham.LocalReport.ReportEmbeddedResource = "QuanLyShopQuanAo.rptSanPhamGanHet.rdlc";
            rptvSanPham.LocalReport.DataSources.Add(new ReportDataSource("SanPham", _spBUS.DSSPGanHet()));
            rptvSanPham.RefreshReport();
        }

        public void DSSPKhongBanDuoc(int thang)
        {
            rptvSanPham.LocalReport.ReportEmbeddedResource = "QuanLyShopQuanAo.rptSPKhongBanDuoc.rdlc";
            rptvSanPham.LocalReport.DataSources.Add(new ReportDataSource("SanPham", _spBUS.DSSPKhongBanDuoc(thang)));
            rptvSanPham.RefreshReport();
        }
    }
}
