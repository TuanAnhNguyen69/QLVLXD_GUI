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
    public partial class NhaCungCap : Form
    {
        BLL_NhaCungCap nhacungcap = new BLL_NhaCungCap();
        public Main_Form mainform;
        public bool IsReset;

        public NhaCungCap()
        {
            InitializeComponent();

            ResetThongTin();
            Refresh_Grid();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
        }

        private void Refresh_Grid()
        {
            this.gridControl_NCC.DataSource = null;
            this.gridControl_NCC.DataSource = nhacungcap.GetList();
        }
        private void ResetThongTin()
        {
            lb_MaNhaCungCap.Text = nhacungcap.NewMaNCC();
            txt_TenNCC.Text = null;
            txt_SDT_NCC.Text = null;
            txt_DiaChiNCC.Text = null;
            btn_Xoa.Visible = false;
            btn_CapNhat.Visible = false;
            btn_Them.Visible = true;
        }

        private bool KiemTraDuLieuNhap()
        {
            if (lb_MaNhaCungCap.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã NCC không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_TenNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên NCC không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_SDT_NCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("SDT NCC không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_DiaChiNCC.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ NCC không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            if (nhacungcap.Insert(lb_MaNhaCungCap.Text, txt_TenNCC.Text, decimal.Parse(txt_SDT_NCC.Text), txt_DiaChiNCC.Text))
            {
                Refresh_Grid();
                ResetThongTin();
                try { mainform.frm_thongkemuahang.IsReset = true; } catch { }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (nhacungcap.Delete(lb_MaNhaCungCap.Text.Trim()))
            {
                Refresh_Grid();
                ResetThongTin();
                try { mainform.frm_thongkemuahang.IsReset = true; } catch { }
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            if (nhacungcap.Update(lb_MaNhaCungCap.Text, txt_TenNCC.Text, decimal.Parse(txt_SDT_NCC.Text), txt_DiaChiNCC.Text))
            {
                Refresh_Grid();
                ResetThongTin();
                try { mainform.frm_thongkemuahang.IsReset = true; } catch { }
            }
        }

        private void btn_ResetThongTin_Click(object sender, EventArgs e)
        {
            ResetThongTin();
            btn_Them.Enabled = true;
        }

        private void txt_SDT_NCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gridControl_NCC_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount != 1)
                return;

            btn_Them.Visible = false;
            btn_CapNhat.Visible = true;
            btn_Xoa.Visible = true;
            btn_ResetThongTin.Visible = true;

            lb_MaNhaCungCap.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaNCC").ToString();
            txt_TenNCC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenNCC").ToString();
            txt_SDT_NCC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
            txt_DiaChiNCC.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
        }

        private void txt_SDT_NCC_KeyPress_1(object sender, KeyPressEventArgs e)
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
                    filepath = browse.SelectedPath;
                    if (filepath[filepath.Length - 1] != '\\')
                        filepath = filepath + "\\";
                    string name = DateTime.Now.ToString();
                    name = name.Replace('/', '-');
                    name = name.Replace(':', '-');
                    nhacungcap.ExportExcel(gridView1, filepath, "Danh Sách Nhà Cung Cấp (" + name + ")");
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
