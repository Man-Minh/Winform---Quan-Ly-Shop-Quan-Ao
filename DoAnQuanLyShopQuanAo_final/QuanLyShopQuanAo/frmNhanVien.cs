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
    public partial class frmNhanVien : Form
    {
        private NhanVienBUS _nvBUS = new NhanVienBUS();
        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void fNhanVien_Load(object sender, EventArgs e)
        {
            frmGiaoDien fGiaoDien = new frmGiaoDien();

            if(fGiaoDien.GetNgonNgu()== false)
            {
                label1.Text = "Employee Manager";
                label2.Text = "The list of employee";
                label3.Text = "Search";
                HoTen.HeaderText = "Name";
                Phai.HeaderText = "Sex";
                Luong.HeaderText = "Salary";
                SDT.HeaderText = "Phone number";
                SoNgayNghi.HeaderText = "Leave";
                NgaySinh.HeaderText = "Date of birth";
                grbChiTiet.Text = "Details";
                lblMaNV.Text = "ID:";
                lblTenNV.Text = "Name:";
                lblGioiTinh.Text = "Sex:";
                lblLuong.Text = "Salary:";
                lblSDT.Text = "Phone number:";
                lblNgSinh.Text = "Date of birth:";
                btnThem.Text = "Add";
                btnXoa.Text = "  Delete";
                btnCapNhat.Text = "  Update";
                btnClear.Text = "   Clear";
                radNam.Text = "Men";
                radNu.Text = "Women";
            }
            else
            {
                label1.Text = "QUẢN LÝ NHÂN VIÊN";
                label2.Text = "Danh Sách Nhân Viên";
                label3.Text = "Tìm kiếm";
                HoTen.HeaderText = "Họ và tên";
                Phai.HeaderText = "Phái";
                Luong.HeaderText = "Lương";
                SDT.HeaderText = "SĐT";
                SoNgayNghi.HeaderText = "Số ngày nghỉ";
                NgaySinh.HeaderText = "Ngày sinh";
                grbChiTiet.Text = "Thông tin chi tiết";
                lblMaNV.Text = "Id nhân viên:";
                lblTenNV.Text = "Tên nhân viên:";
                lblGioiTinh.Text = "Phái:";
                lblLuong.Text = "Lương:";
                lblSDT.Text = "SĐT:";
                lblNgSinh.Text = "Ngày sinh:";
                btnThem.Text = "Thêm";
                btnXoa.Text = "  Xóa";
                btnCapNhat.Text = "  Cập nhật";
                btnClear.Text = "   Làm mới";
                radNam.Text = "Nam";
                radNu.Text = "Nữ";
            }
            dgvNhanVien.DataSource = _nvBUS.LayDSNhanVien();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {

                if ( (string.IsNullOrEmpty(txtTenNv.Text)) || (string.IsNullOrEmpty(txtLuong.Text)))
                {
                    MessageBox.Show(ThongBao.MESS_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                 
                //Kiểm tra ngày sinh nhân viên
                if( (DateTime.Now.Year - dateTimeNgaySinh.Value.Year) <18 )
                {
                    MessageBox.Show(ThongBao.ERRO_TIME, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    NhanVienDTO NhanVien = new NhanVienDTO();
                    NhanVien.HoTen = txtTenNv.Text;
                    NhanVien.NgaySinh = dateTimeNgaySinh.Value;
                    NhanVien.Phai = "";
                    if (radNam.Checked == true) NhanVien.Phai = "Nam";
                    else if (radNu.Checked == true) NhanVien.Phai = "Nữ";
                    NhanVien.Luong = Convert.ToDecimal(txtLuong.Text);
                    NhanVien.SDT = txtSDT.Text;
                    NhanVien.SoNgayNghi = 0;



                    if (_nvBUS.ThemNV(NhanVien))
                    {
                        MessageBox.Show(ThongBao.ADD_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvNhanVien.DataSource = _nvBUS.LayDSNhanVien();
                    }
                    else
                    {
                        MessageBox.Show(ThongBao.ADD_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (Exception x)
            {
                return;
            }
            
        }

      

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text))
            {
                return;
            }
            else
            {
                DialogResult result;
                result = MessageBox.Show(ThongBao.MESS_DELETE, ThongBao.MESS_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    frmDangNhap fDangNhap = new frmDangNhap();

                    if (fDangNhap.GetTK().ID == Convert.ToInt32(txtID.Text))
                    {
                        MessageBox.Show(ThongBao.MESS_STAFF, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                    if (_nvBUS.XoaNV(Convert.ToInt32(txtID.Text)))
                    {
                        MessageBox.Show(ThongBao.DELETE_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvNhanVien.DataSource = _nvBUS.LayDSNhanVien();
                    }
                    else
                    {
                        MessageBox.Show(ThongBao.DELETE_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void txtLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtTenNv.Text) || string.IsNullOrEmpty(dateTimeNgaySinh.Value.ToString()) || string.IsNullOrEmpty(txtLuong.Text))
                {
                    // Nếu bỏ trống thì hiện thông báo
                    MessageBox.Show(ThongBao.MESS_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return;
                }

                if ((DateTime.Now.Year - dateTimeNgaySinh.Value.Year) < 18)
                {
                    MessageBox.Show(ThongBao.ERRO_TIME, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                NhanVienDTO NhanVien = new NhanVienDTO();
                NhanVien.ID = Convert.ToInt32(txtID.Text);
                NhanVien.HoTen = txtTenNv.Text;
                NhanVien.NgaySinh = dateTimeNgaySinh.Value;
                NhanVien.Phai = "";
                if (radNam.Checked == true) NhanVien.Phai = "Nam";
                else if (radNu.Checked == true) NhanVien.Phai = "Nữ";
                NhanVien.Luong = Convert.ToDecimal(txtLuong.Text);
                NhanVien.SDT = txtSDT.Text;
                NhanVien.SoNgayNghi = 0;

                if (_nvBUS.CapNhatNV(NhanVien))
                {
                    MessageBox.Show(ThongBao.UPDATE_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvNhanVien.DataSource = _nvBUS.LayDSNhanVien();
                }
                else
                {
                    MessageBox.Show(ThongBao.UPDATE_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception x)
            {
                return;
            }
        }

    
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtTimKiem.Text))
                {
                    return;
                }
                dgvNhanVien.DataSource = _nvBUS.TimNhanVien(Convert.ToInt32(txtTimKiem.Text));
            }
            catch(Exception x)
            {
                return;
            }
        }

        private void btnQuayVeTrangChu_Click(object sender, EventArgs e)
        {
            this.Close();
            frmQuanLy fGdien = new frmQuanLy();
            
           
            
           
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvNhanVien.Rows[dgvNhanVien.CurrentCell.RowIndex];
            if(dgvNhanVien.Rows.Count>0)
            {
                txtID.Text = row.Cells[0].Value.ToString();
                txtTenNv.Text = row.Cells[1].Value.ToString();
                dateTimeNgaySinh.Text = row.Cells[2].Value.ToString();
                if (row.Cells[3].Value.ToString().Equals("Nam"))
                    radNam.Checked = true;
                else radNu.Checked = true;
                txtLuong.Text= row.Cells[4].Value.ToString();
               txtSDT.Text = row.Cells[5].Value.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtID.Text = "";
            txtTenNv.Text = "";
            dateTimeNgaySinh.Value = DateTime.Now;
            radNam.Checked = true;
            txtLuong.Text = " ";
            txtSDT.Text = "";
            dgvNhanVien.DataSource = _nvBUS.LayDSNhanVien();
        }

        private void txtTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

       
    }
}
