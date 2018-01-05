using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVLXD.BLL;

namespace QLVLXD
{
    public partial class QuanLyThongTinNhanVien : Form
    {
        BLL_NhanVien nhanvien = new BLL_NhanVien();
        public Main_Form mainform;

        public QuanLyThongTinNhanVien()
        {
            InitializeComponent();

            /* Tao List ChucVu */
            HashSet<string> listchucvu = new HashSet<string>();
            listchucvu.Add("Bán Hàng");
            listchucvu.Add("Chủ Cửa Hàng");
            listchucvu.Add("Giao Hàng");
            listchucvu.Add("Bảo Vệ");
            listchucvu.Add("Kế Toán");
            listchucvu.Add("Thủ Kho");
            nhanvien.MakeComboBoxNoAuto(cbb_ChucVu, listchucvu.ToList());

            /* Tao List GioiTinh */
            List<string> gioitinh = new List<string>();
            gioitinh.Add("Nam");
            gioitinh.Add("Nữ");
            nhanvien.MakeComboBoxNoAuto(cbb_GioiTinh, gioitinh);

            ResetThongTin();
            Refresh_Grid();
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
        }

        private void Refresh_Grid()
        {
            this.gridControl_QuanLyNhanVien.DataSource = null;
            this.gridControl_QuanLyNhanVien.DataSource = nhanvien.GetList();
        }

        private void ResetThongTin()
        {
            lb_MaNhanVien.Text = nhanvien.NewMaNV();
            txt_TenNhanVien.Text = "";
            txt_DiaChi.Text = "";
            txt_SDT.Text = "";
            dTP_NgaySinh.Value = DateTime.Now;
            cbb_GioiTinh.SelectedIndex = 0;
            cbb_ChucVu.SelectedIndex = 0;
            txt_MucLuong.Text = "";
            txt_CMND.Text = "";
            txt_Email.Text = "";
            btn_Xoa.Visible = false;
            btn_CapNhat.Visible = false;
            btn_Them.Visible = true;
        }

        private bool KiemTraDuLieuNhap()
        {
            if (txt_TenNhanVien.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên nhân viên không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_SDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("Số điện thoại không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (DateTime.Today.Year - dTP_NgaySinh.Value.Year < 15)
            {
                MessageBox.Show("Tuổi của nhân viên phải từ 15 trở lên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbb_GioiTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Giới tính không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbb_ChucVu.Text.Trim().Length == 0)
            {
                MessageBox.Show("Chức vụ không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            try
            {
                if (Int32.Parse(txt_MucLuong.Text.Trim()) < 100000)
                {
                    MessageBox.Show("Mức lương tháng tối thiểu là 100 000 VNĐ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập lương sai! Vui lòng chỉ nhập số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_CMND.Text.Trim().Length == 0)
            {
                MessageBox.Show("CMND không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_Email.Text.Trim().Length == 0)
            {
                MessageBox.Show("Email không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            if (nhanvien.Insert(lb_MaNhanVien.Text, txt_TenNhanVien.Text, txt_DiaChi.Text, decimal.Parse(txt_SDT.Text), dTP_NgaySinh.Value, cbb_GioiTinh.Text, cbb_ChucVu.Text, decimal.Parse(txt_MucLuong.Text), decimal.Parse(txt_CMND.Text), txt_Email.Text))
            {
                Refresh_Grid();
                ResetThongTin();
                try { mainform.frm_thongkebanhang.IsReset = true; } catch { }
                try { mainform.frm_thongkemuahang.IsReset = true; } catch { }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (nhanvien.Delete(lb_MaNhanVien.Text.Trim()))
            {
                Refresh_Grid();
                ResetThongTin();
                try { mainform.frm_thongkebanhang.IsReset = true; } catch { }
                try { mainform.frm_thongkemuahang.IsReset = true; } catch { }
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            if (nhanvien.Update(lb_MaNhanVien.Text, txt_TenNhanVien.Text, txt_DiaChi.Text, decimal.Parse(txt_SDT.Text), dTP_NgaySinh.Value, cbb_GioiTinh.Text, cbb_ChucVu.Text, decimal.Parse(txt_MucLuong.Text), decimal.Parse(txt_CMND.Text), txt_Email.Text))
            {
                Refresh_Grid();
                ResetThongTin();
                try { mainform.frm_thongkebanhang.IsReset = true; } catch { }
                try { mainform.frm_thongkemuahang.IsReset = true; } catch { }
            }
        }

        private void btn_ResetThongTin_Click(object sender, EventArgs e)
        {
            ResetThongTin();
            btn_Them.Enabled = true;
        }

        private void gridControl_QuanLyNhanVien_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount != 1)
                return;

            btn_Them.Visible = false;
            btn_CapNhat.Visible = true;
            btn_Xoa.Visible = true;
            btn_ResetThongTin.Visible = true;

            lb_MaNhanVien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNV").ToString();
            txt_TenNhanVien.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNV").ToString();
            txt_DiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
            txt_SDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
            dTP_NgaySinh.Value = DateTime.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh").ToString());
            cbb_GioiTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioiTinh").ToString();
            cbb_ChucVu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ChucVu").ToString();
            txt_MucLuong.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MucLuong").ToString();
            txt_CMND.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
            txt_Email.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
            cbb_ChucVu.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ChucVu").ToString().Trim();
            cbb_GioiTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioiTinh").ToString().Trim();
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_MucLuong_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_SDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_MucLuong_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_MucLuong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btn_XuatFile_Click(object sender, EventArgs e)
        {
            try
            {
                string filepath = "";
                FolderBrowserDialog browse = new FolderBrowserDialog();
                browse.Description = "Chọn đường dẫn lưu file:";
                if (browse.ShowDialog() == DialogResult.OK)
                {
                    filepath = browse.SelectedPath; if (filepath[filepath.Length - 1] != '\\') filepath = filepath + "\\";
                    string name = DateTime.Now.ToString();
                    name = name.Replace('/', '-');
                    name = name.Replace(':', '-');
                    nhanvien.ExportExcel(gridView1, filepath, "Danh Sách Nhân Viên (" + name + ")");
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Xuất Excel không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            (new PrintDialog()).ShowDialog();
        }
    }
}
