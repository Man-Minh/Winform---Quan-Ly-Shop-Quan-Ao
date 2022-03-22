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
    public partial class frmCT_HoaDon : Form
    {
        private NhanVienBUS _nv = new NhanVienBUS();
        private QuanAoBUS _sp = new QuanAoBUS();
        private HoaDonBUS _hd = new HoaDonBUS();
        private CT_HoaDonBUS _ct = new CT_HoaDonBUS();
        public frmCT_HoaDon()
        {
            InitializeComponent();
        }

        private void fCT_HoaDon_Load(object sender, EventArgs e)
        {
            frmGiaoDien fGiaoDien = new frmGiaoDien();

            if(fGiaoDien.GetNgonNgu()== false)
            {
                lblTieuDe.Text = "INVOICE DETAIL";
                lblMaHD.Text = "Bill ID";
                lblMaHD2.Text = "Bill ID";
                lblNgayLap.Text = "Date created";
                lblMaSP.Text = "Product ID";
                lblSoLuong.Text = "Amount";
                lblDonGia.Text = "Price";
                lblMaNV.Text = "Employee ID";
                grbSanPham.Text = "Invoice detail";
                grbThongTinHD.Text = "Bill";
                btnThem.Text = "     Add";
                btnThemCT_HD.Text = "     Add";
                btnThoat.Text = "      Exit";
                btnClear.Text = "      Clear";
                lblTenNV.Text = "Employee name:";
            }
            else
            {
                lblTieuDe.Text = "CHI TIẾT HÓA ĐƠN";
                lblMaHD.Text = "Mã HD";
                lblMaHD2.Text = "Mã HD";
                lblNgayLap.Text = "Ngày lập HD";
                lblMaSP.Text = "Mã SP";
                lblSoLuong.Text = "Số lượng";
                lblDonGia.Text = "Đơn giá";
                lblMaNV.Text = "Id nhân viên";
                grbSanPham.Text = "Chi tiết hóa đơn";
                grbThongTinHD.Text = "Hóa đơn";
                btnThem.Text = "     Thêm";
                btnThemCT_HD.Text = "     Thêm";
                btnThoat.Text = "      Thoát";
                btnClear.Text = "      Làm mới";
                lblTenNV.Text = "Tên nhân viên:";
                
            }

            cbbMaSP.DataSource = _sp.LayDSQuanAO();
            cbbMaSP.DisplayMember = "MaSP";

            cbbMaHD.DataSource = _hd.LayDSHoaDon();
            cbbMaHD.DisplayMember = "MaHD";

            frmDangNhap fDangNhap = new frmDangNhap();
            TaiKhoanDTO taiKhoan = fDangNhap.GetTK();

            txtMaNV.Text = taiKhoan.ID.ToString();
            txtTenNV.Text = _nv.LayThongTinNhanVien(taiKhoan.ID).HoTen;
            txtDonGia.Text = Math.Round(_sp.LaythongTinSP(cbbMaSP.Text).DonGia, 0).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtMaHD.Text))
            {
                MessageBox.Show(ThongBao.MESS_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(_hd.KTraHD(txtMaHD.Text))
            {
                MessageBox.Show(ThongBao.BILL_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else
            {
                HoaDonDTO hoadon = new HoaDonDTO()
                {
                    MaHD = txtMaHD.Text,
                    NgayLapHD = dtNgayLapHD.Value,
                    IDNVien = Convert.ToInt32(txtMaNV.Text),
                    ThanhTien = 0
                };

                if (_hd.ThemHD(hoadon))
                {
                    MessageBox.Show(ThongBao.ADD_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cbbMaHD.DataSource = _hd.LayDSHoaDon();
                    cbbMaHD.DisplayMember = "MaHD";
                }

                else MessageBox.Show(ThongBao.ADD_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThemCT_HD_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbbMaHD.Text) || nbSoLuong.Value<=0)
            {
                MessageBox.Show(ThongBao.MESS_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_ct.KTra_CTHD(cbbMaHD.Text, cbbMaSP.Text))
            {
                MessageBox.Show(ThongBao.DETAIL_BILL_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            if(nbSoLuong.Value > _sp.KTraSoLUONG(cbbMaSP.Text))
            {
                MessageBox.Show(ThongBao.ERRO_NUMBER_PRODUCT, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                CT_HoaDonDTO ctHD = new CT_HoaDonDTO()
                {
                    MaHD = cbbMaHD.Text,
                    MaSP = cbbMaSP.Text,
                    SoLuong = Convert.ToInt32(nbSoLuong.Value),
                    DonGia = Convert.ToDecimal(txtDonGia.Text)
                };

                if (_ct.ThemCT_HD(ctHD))
                {
                    MessageBox.Show(ThongBao.ADD_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                MessageBox.Show(ThongBao.ADD_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            nbSoLuong.Value = 1;
            txtMaHD.Text = string.Empty;
            txtDonGia.Text = "0";
            cbbMaHD.SelectedIndex = 0;
            cbbMaSP.SelectedIndex = 0;
            dtNgayLapHD.Value = DateTime.Now;
        }

        private void cbbMaSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cbbMaSP.Text);
            try
            {
                txtDonGia.Text = Math.Round(_sp.LaythongTinSP(cbbMaSP.Text).DonGia,0).ToString();
            } catch(Exception x)
            {
                return;
            }
        }

        private void nbSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
