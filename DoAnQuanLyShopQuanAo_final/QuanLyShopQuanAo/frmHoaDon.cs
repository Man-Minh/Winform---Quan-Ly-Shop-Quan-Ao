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
    public partial class frmHoaDon : Form
    {
        private HoaDonBUS _hd = new HoaDonBUS();
        private CT_HoaDonBUS _ctHD = new CT_HoaDonBUS();
        private NhanVienBUS _nvBUS = new NhanVienBUS();
        public frmHoaDon()
        {
            InitializeComponent();
        }

        private void fHoaDon_Load(object sender, EventArgs e)
        {
            frmGiaoDien fGiaoDien = new frmGiaoDien();

            if(fGiaoDien.GetNgonNgu()== false)
            {
                label1.Text = "Bill List";
                label2.Text = "Detail";
                MaHD.HeaderText = "Bill ID";
                MaHoaDon.HeaderText = "Bill ID";
                NgayLapHD.HeaderText = "Date created";
                IDNVien.HeaderText = "Employee ID";
                ThanhTien.HeaderText = "Money";
                MaSP.HeaderText = "Product ID";
                SoLuong.HeaderText = "Amount";
                DonGia.HeaderText = "Price";
                btnThem.Text = "Add";
            }
            else
            {
                label1.Text = "DANH SÁCH HÓA ĐƠN";
                label2.Text = "CHI TIẾT HÓA ĐƠN";
                MaHD.HeaderText = "Mã HD";
                MaHoaDon.HeaderText = "Mã HD";
                NgayLapHD.HeaderText = "Ngày lập HD";
                IDNVien.HeaderText = "Id nhân viên";
                ThanhTien.HeaderText = "Thành tiền";
                MaSP.HeaderText = "Mã SP";
                SoLuong.HeaderText = "Số lượng";
                DonGia.HeaderText = "Đơn giá";
                btnThem.Text = "  Thêm";
            }
            dgvHoaDon.DataSource = _hd.LayDSHoaDon();
            dgvCTHoaDon.DataSource = _ctHD.LayCT_HoaDon();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmQuanLy fGiaoDien = new frmQuanLy();
            this.Close();
            fGiaoDien.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmCT_HoaDon fCT_HoaDon = new frmCT_HoaDon();
            this.Hide();
            fCT_HoaDon.Show();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            frmCT_HoaDon frm = new frmCT_HoaDon();

           // this.Hide();
            frm.ShowDialog();

            dgvHoaDon.DataSource = _hd.LayDSHoaDon();
            dgvCTHoaDon.DataSource = _ctHD.LayCT_HoaDon();
        }
        //Sự kiện click vào bảng chi tiết hóa đơn
        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvHoaDon.Rows[dgvHoaDon.CurrentCell.RowIndex];
            if (dgvHoaDon.Rows.Count > 0)
            {
                dgvCTHoaDon.DataSource = _ctHD.LayCT_HDTheoMa(row.Cells[0].Value.ToString());//Lấy danh sách chi tiết HĐ the mã HĐ     
            }
            return;
        }

       
        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult result;
            result = MessageBox.Show(ThongBao.MESS_DELETE, ThongBao.MESS_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {

                    DataGridViewRow row = dgvHoaDon.Rows[dgvHoaDon.CurrentCell.RowIndex];
                    if (_hd.XoaHD(row.Cells[0].Value.ToString()))
                    {
                        MessageBox.Show(ThongBao.DELETE_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgvHoaDon.DataSource = _hd.LayDSHoaDon();
                        dgvCTHoaDon.DataSource = _ctHD.LayCT_HoaDon();
                    }
                    else
                    {
                        MessageBox.Show(ThongBao.DELETE_FAIL, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                catch (Exception x)
                {
                    return;
                }
            }
        }

        private void btnXoaCT_HD_Click(object sender, EventArgs e)
        {
             DialogResult result;
            result = MessageBox.Show(ThongBao.MESS_DELETE, ThongBao.MESS_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    DataGridViewRow row = dgvCTHoaDon.Rows[dgvCTHoaDon.CurrentCell.RowIndex];
                    if (dgvCTHoaDon.Rows.Count > 0)
                    {
                        string maHD = row.Cells[0].Value.ToString();
                        string maSP = row.Cells[1].Value.ToString();
                        if (_ctHD.XoaCT_HD(maHD, maSP))
                        {
                            MessageBox.Show(ThongBao.DELETE_SUCCESS, ThongBao.MESS_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dgvCTHoaDon.DataSource = _ctHD.LayCT_HoaDon();
                            dgvHoaDon.DataSource = _hd.LayDSHoaDon();
                        }
                        else
                        {
                            MessageBox.Show(ThongBao.DELETE_FAIL, "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                            return;
                        }
                    }
                    return;
                }
                catch (Exception x)
                {
                    return;
                }
            }
        }

       
    }
}
