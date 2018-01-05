using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLVLXD.BLL;
using QLVLXD.DLL;

namespace QLVLXD.GUI.NhanSu
{
    public partial class QuanLyUser : DevExpress.XtraEditors.XtraForm
    {
         BLL_User quanlyuser = new BLL_User();

        public QuanLyUser()
        {
            InitializeComponent();

            /* Tao List phan quyen */            
            HashSet<string> listphanquyen = new HashSet<string>();
            listphanquyen.Add("Admin");
            listphanquyen.Add("User");
            quanlyuser.MakeComboBoxNoAuto(cbb_PhanQuyen, listphanquyen.ToList());
            cbb_PhanQuyen.SelectedIndex = 0;

            // Tạo ds cho cb_TenNhanVien
            List<DLL.NhanVien> bll_nhanvien = (new BLL_NhanVien()).GetList();
            List<string> namenv = new List<string>();
            foreach (DLL.NhanVien mem in bll_nhanvien)
                namenv.Add(mem.TenNV.Trim());
            quanlyuser.MakeComboBoxNoAuto(cb_TenNhanVien, namenv);
            cb_TenNhanVien.SelectedIndex = 0;

            txt_Password.PasswordChar = '*';

            Refresh_Grid();
            ResetThongTin();
        }

        private void QuanLyUser_Load(object sender, EventArgs e)
        {}

        private void ResetThongTin()
        {
            txt_TenUser.Text = null;
            txt_TenDangNhap.Text = null;
            txt_Password.Text = null;
            btn_Them.Visible = true;
            btn_Xoa.Visible = false;
            btn_XemChiTiet.Visible = false;
            txt_Password.Enabled = true;
        }

        private void Refresh_Grid()
        {
            this.gridControl_QuanlyUser.DataSource = null;
            this.gridControl_QuanlyUser.DataSource = quanlyuser.GetList();
        }

        private bool KiemTraDuLieuNhap()
        {
            if (txt_TenUser.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên User không được để trống,", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_TenDangNhap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên đăng nhập không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_Password.Text.Trim().Length < 6)
            {
                MessageBox.Show("Password phải từ 6 kí tự trở lên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
        
        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            var nv = (new BLL_NhanVien()).GetObjectFromTenNhanVien(cb_TenNhanVien.Text);
            if (nv == null)
            {
                MessageBox.Show("Không tìm thấy nhân viên đã chọn! ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            quanlyuser.Insert(txt_TenUser.Text, txt_TenDangNhap.Text, nv.MaNV.Trim(), txt_Password.Text, cbb_PhanQuyen.Text);
            Refresh_Grid();
            ResetThongTin();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selectedindex = gridView1.GetSelectedRows();
                var dvt = gridView1.GetRow(selectedindex[0]);
                if (((DLL.User)dvt).MaNV.ToString().Trim() == (new BLL_CTHoaDonBanHang()).ReadNV())
                {
                    MessageBox.Show("Không được xóa tài khoản hiện tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                quanlyuser.Delete(((DLL.User)dvt).MaNV.ToString());
                Refresh_Grid();
                ResetThongTin();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ResetThongTin_Click(object sender, EventArgs e)
        {
            ResetThongTin();
        }

        private void btn_XemChiTiet_Click(object sender, EventArgs e)
        {
            //QuanLyUser_XemChiTiet xemchitiet = new QuanLyUser_XemChiTiet();
            //xemchitiet.Show();
        }

        private void gridControl_QuanlyUser_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount != 1)
                return;

            btn_Them.Visible = false;
            btn_Xoa.Visible = true;
            btn_XemChiTiet.Visible = true;
            txt_Password.Enabled = false;

            txt_TenUser.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenUser").ToString();
            txt_TenDangNhap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenDangNhap").ToString();
            cbb_PhanQuyen.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "PhanQuyen").ToString();
        }

        private void cb_TenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_TenUser.Text = (new BLL_NhanVien()).GetObjectFromTenNhanVien(cb_TenNhanVien.Text).TenNV.Trim();
        }
    }
}