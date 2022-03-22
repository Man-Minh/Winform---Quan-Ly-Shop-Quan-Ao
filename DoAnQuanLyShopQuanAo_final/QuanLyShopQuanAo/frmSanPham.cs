using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShopQuanAo
{
    public partial class frmSanPham : Form
    {
        private QuanAoBUS _sanPham = new QuanAoBUS();
        public frmSanPham()
        {
            InitializeComponent();
            cbbLoai.SelectedIndex = 0;
        }

        private void fSanPham_Load(object sender, EventArgs e)
        {
            frmGiaoDien fGiaoDien = new frmGiaoDien();
            if (fGiaoDien.GetNgonNgu() == false)
            {
                lblQuanLySP.Text = "Product Management";
                lblTimKiem.Text = "Search";
                grbChiTietSP.Text = "Product details";
                lblMaSP.Text = "Product ID:";
                lblTenSP.Text = "Product name:";
                lblSoLuong.Text = "Amount:";
                lblGiaSP.Text = "Price:";
                lblLoai.Text = "Type:";
                lblGiam.Text = "Sell (%):";
                btnCapNhat.Text = "Update";
                btnThem.Text = "Add";
                btnXoa.Text = "Delete";
                btnClear.Text = "Clear";
                lblDanhSachSP.Text = "List of products";
               
                TenSP.HeaderText = "Product name";
                MaSP.HeaderText = "Product ID";
                Loai.HeaderText = "Type";
                SoLuong.HeaderText = "Amount";
                DonGia.HeaderText = "Price";
                GiamGia.HeaderText = "Sell ( % )";
            }
            else
            {
                lblQuanLySP.Text = "Quản Lý Sản Phẩm";
                lblTimKiem.Text = "Tìm kiếm";
                grbChiTietSP.Text = "Thông tin chi tiết";
                lblMaSP.Text = "Mã SP:";
                lblTenSP.Text = "Tên SP:";
                lblSoLuong.Text = "Số lượng:";
                lblGiaSP.Text = "Giá SP:";
                lblLoai.Text = "Loại:";
                lblGiam.Text = "Giảm(%):";
                btnCapNhat.Text = "Cập Nhật";
                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";
                btnClear.Text = "Làm Mới";
                lblDanhSachSP.Text = "Danh sách sản phẩm";

                TenSP.HeaderText = "Tên SP";
                MaSP.HeaderText = "Mã SP";
                Loai.HeaderText = "Loại";
                SoLuong.HeaderText = "Số lượng";
                DonGia.HeaderText = "Đơn giá";
                GiamGia.HeaderText = "Giảm giá ( % )";
            }
            txtMaSanPham.Text = _sanPham.MaxMaSP();
            dgvSanPham.DataSource = _sanPham.LayDSQuanAO();
            cbbTieuChiTimKiem.SelectedIndex = 0;
            cbbSize.SelectedIndex = 0;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaSanPham.Text) || pbSanPham.Image == null)
            {
                // Nếu bỏ trống thì hiện thông báo
                MessageBox.Show(ThongBao.MESS_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            // Kiểm tra sản phẩm đã tồn tại trong ds chưa
            if (_sanPham.LaythongTinSP(txtMaSanPham.Text) != null)
            {
                if (txtMaSanPham.Text == _sanPham.LaythongTinSP(txtMaSanPham.Text).MaSP)
                {
                    MessageBox.Show(ThongBao.MESS_PRODUCT, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
           
            else
            {
                QuanAoDTO SPQuanAo = new QuanAoDTO();
                SPQuanAo.TenSP = txtTenSanPham.Text;
                SPQuanAo.MaSP = _sanPham.MaxMaSP();
                SPQuanAo.LoaiSP = cbbLoai.SelectedItem.ToString();
                SPQuanAo.Size = cbbSize.SelectedItem.ToString();
                SPQuanAo.SoLuong = Convert.ToInt32(nudSoLuong.Value);
                SPQuanAo.DonGia = Convert.ToDecimal(nbrGia.Value.ToString());
                SPQuanAo.Anh = string.Format("{0}.jpg", txtMaSanPham.Text);
                SaveImage(pbSanPham.Image);
                SPQuanAo.GiamGia = Convert.ToInt32(nudGiam.Value);              

                if (_sanPham.ThemSP(SPQuanAo))
                {
                    MessageBox.Show(ThongBao.ADD_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSanPham.DataSource = _sanPham.LayDSQuanAO();
                }
                else
                {
                    MessageBox.Show(ThongBao.ADD_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }

            }
        }

        private void SaveImage(Image image)
        {
            Bitmap bmp = new Bitmap(image);
            string path = string.Format(@"{0}\..\..\Image_SP\{1}.jpg", Environment.CurrentDirectory,
                txtMaSanPham.Text);

            bmp.Save(path, ImageFormat.Jpeg);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(ThongBao.MESS_DELETE, ThongBao.MESS_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string masp = txtMaSanPham.Text;
                if (_sanPham.XoaSP(masp))
                {
                    MessageBox.Show(ThongBao.DELETE_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvSanPham.DataSource = _sanPham.LayDSQuanAO();
                }
                else
                {
                    MessageBox.Show(ThongBao.DELETE_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtMaSanPham.Text) || String.IsNullOrEmpty(txtTenSanPham.Text) )
            {
                // Nếu bỏ trống thì hiện thông báo
                MessageBox.Show(ThongBao.MESS_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            QuanAoDTO SPQuanAo = new QuanAoDTO();
            SPQuanAo.TenSP = txtTenSanPham.Text;
            SPQuanAo.MaSP = txtMaSanPham.Text;
            SPQuanAo.LoaiSP = cbbLoai.SelectedItem.ToString();
            SPQuanAo.Size = cbbSize.SelectedItem.ToString();
            SPQuanAo.SoLuong = Convert.ToInt32(nudSoLuong.Value);
            SPQuanAo.DonGia = Convert.ToDecimal(nbrGia.Value.ToString());
            SPQuanAo.GiamGia = Convert.ToInt32(nudGiam.Value);

            if (_sanPham.CapNhatSP(SPQuanAo))
            {
                MessageBox.Show(ThongBao.UPDATE_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvSanPham.DataSource = _sanPham.LayDSQuanAO();
            }
            else
            {
                MessageBox.Show(ThongBao.UPDATE_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dgvSanPham.Rows[dgvSanPham.CurrentCell.RowIndex];

                if (dgvSanPham.Rows.Count > 0)
                {
                    txtTenSanPham.Text = row.Cells[0].Value.ToString();
                    txtMaSanPham.Text = row.Cells[1].Value.ToString();
                    cbbLoai.Text = row.Cells[2].Value.ToString();
                    cbbSize.Text = row.Cells[3].Value.ToString();
                    nudSoLuong.Text = row.Cells[4].Value.ToString();
                    nbrGia.Value = decimal.Parse(row.Cells[5].Value.ToString());

                    string path = string.Format(@"{0}\..\..\Image_SP\{1}", Environment.CurrentDirectory,
                    dgvSanPham.Rows[e.RowIndex].Cells[6].Value.ToString());

                    nudGiam.Text = row.Cells[7].Value.ToString();
                    pbSanPham.Image = Image.FromFile(path);
                }
            }
            catch(Exception x)
            {
                return;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTimKiem.Text))
            {
                return;
            }
            if (_sanPham.TimSp(cbbTieuChiTimKiem.Text, txtTimKiem.Text) == null)
            {
                MessageBox.Show(ThongBao.MESS_PRODUCT, ThongBao.MESS_TITLE, MessageBoxButtons.OK);
            }
            dgvSanPham.DataSource = _sanPham.TimSp(cbbTieuChiTimKiem.Text, txtTimKiem.Text);
        }

        private void pbSanPham_Click(object sender, EventArgs e)
        {
            if(ofdImage.ShowDialog() == DialogResult.OK)
            {
                pbSanPham.Image = Image.FromFile(ofdImage.FileName);
            }
        }

        // Man HAKI da chinh sua 8:49 : 05/27/2021 - Rang Buoc Khong cho nguoi dung nhap chu vao - Chi co the nhap so 
        private void txtMaSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            txtMaSanPham.Text = _sanPham.MaxMaSP();
            txtTenSanPham.Text = string.Empty;
            nudSoLuong.Value = 1;
            nudGiam.Value = 0;
            nbrGia.Value = 1;
            cbbSize.SelectedIndex = 0;
            cbbLoai.SelectedIndex = 0;
            txtTimKiem.Text = string.Empty;
            dgvSanPham.DataSource = _sanPham.LayDSQuanAO();
            pbSanPham.Image = null;
        }
     
    }
}
