using BUS;
using DTO;
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
    public partial class frmTaiKhoan : Form
    {
        private TaiKhoanBUS _taiKhoan = new TaiKhoanBUS();
        private NhanVienBUS _nhanVien = new NhanVienBUS();
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void fTaiKhoan_Load(object sender, EventArgs e)
        {
            frmGiaoDien fGiaoDien= new frmGiaoDien();

            if (fGiaoDien.GetNgonNgu() == false)
            {
                label1.Text = "ACCOUNT INFORMATION";
                label2.Text = "User name:";
                label3.Text = "Password:";
                label4.Text = "Type:";
                label5.Text = "Employee Id:";
                btnThem.Text = "Add";
                btnXoa.Text = "Delete";
                btnCapNhat.Text = "Update";
                btnClear.Text = "Clear";

                TenTaiKhoan.HeaderText = "User name";
                MatKhau.HeaderText = "Password";
                LoaiTaiKhoan.HeaderText = "Type";
            }
            else
            {
                label1.Text = "THÔNG TIN TÀI KHOẢN";
                label2.Text = "Tên TK:";
                label3.Text = "Mật khẩu:";
                label4.Text = "Loại TK:";
                label5.Text = "Tên nhân viên:";
                btnThem.Text = "Thêm";
                btnXoa.Text = "Xóa";
                btnCapNhat.Text = "Cập nhật";

                TenTaiKhoan.HeaderText = "Tên TK";
                MatKhau.HeaderText = "Mật khẩu";
                LoaiTaiKhoan.HeaderText = "Loại TK";
                btnClear.Text = "Làm mới";
            }
            dgvTaiKhoan.DataSource = _taiKhoan.LayDSTaiKhoan();
            cbbLoaiTaiKhoan.SelectedIndex = 1;
            cbbNhanVien.DataSource = _nhanVien.LayDSNhanVien();
            cbbNhanVien.DisplayMember = "HoTen";
            cbbNhanVien.ValueMember = "ID";
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvTaiKhoan.Rows[dgvTaiKhoan.CurrentCell.RowIndex];
            if(dgvTaiKhoan.Rows.Count>0)
            {
                txtTaiKhoan.Text = row.Cells[0].Value.ToString();
                txtMatKhau.Text = row.Cells[1].Value.ToString();

                if (row.Cells[2].Value.ToString().Equals("admin"))
                {
                    cbbLoaiTaiKhoan.SelectedIndex = 0;
                }
                else cbbLoaiTaiKhoan.SelectedIndex = 1;

                int id= int.Parse(row.Cells[3].Value.ToString());
                cbbNhanVien.Text = _nhanVien.LayThongTinNhanVien(id).HoTen;
            }
            
        }

        
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(ThongBao.MESS_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // kiểm tra tên tk có bị trùng ko
            if (_taiKhoan.KTTaiKhoan(txtTaiKhoan.Text) != null )
            {
                    MessageBox.Show(ThongBao.ACCOUNT_IS_EXIST, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if (_nhanVien.LayThongTinNhanVien(int.Parse(cbbNhanVien.SelectedValue.ToString())) == null)
            {
                MessageBox.Show(ThongBao.ERRO_ID, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             else
             {
                    TaiKhoanDTO taiKhoan = new TaiKhoanDTO()
                    {
                        TenDangNhap= txtTaiKhoan.Text,
                        MatKhau= txtMatKhau.Text,
                        LoaiTK= cbbLoaiTaiKhoan.Text,
                        ID = Convert.ToInt32(cbbNhanVien.SelectedValue.ToString()) 
                    };
                    if(_taiKhoan.ThemTK(taiKhoan))
                    {
                        MessageBox.Show(ThongBao.ADD_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTaiKhoan.DataSource = _taiKhoan.LayDSTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show(ThongBao.ADD_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }               
             }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show(ThongBao.MESS_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (_taiKhoan.CapNhatTK(txtMatKhau.Text, txtTaiKhoan.Text))
           {
               MessageBox.Show(ThongBao.UPDATE_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
               dgvTaiKhoan.DataSource = _taiKhoan.LayDSTaiKhoan();
           }
           else
           {
               MessageBox.Show(ThongBao.UPDATE_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
               return;
           }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            frmDangNhap fDangNhap = new frmDangNhap();
            DialogResult result;
            result = MessageBox.Show(ThongBao.MESS_DELETE, ThongBao.MESS_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (string.IsNullOrEmpty(txtTaiKhoan.Text) || string.IsNullOrEmpty(txtMatKhau.Text))
                {
                    MessageBox.Show(ThongBao.MESS_ERRO, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtTaiKhoan.Text.Equals(fDangNhap.GetTK().TenDangNhap))
                {
                    MessageBox.Show(ThongBao.MESS_ACC, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                {
                    if (_taiKhoan.XoaTK(txtTaiKhoan.Text))
                    {
                        MessageBox.Show(ThongBao.DELETE_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvTaiKhoan.DataSource = _taiKhoan.LayDSTaiKhoan();
                    }
                    else
                    {
                        MessageBox.Show(ThongBao.DELETE_FAIL, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTaiKhoan.Text = " ";
            txtMatKhau.Text = "";
            cbbNhanVien.SelectedIndex = 0;
        }
    }
}
