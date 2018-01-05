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
    public partial class KhachHang : Form
    {
        BLL_KhachHang khachhang = new BLL_KhachHang();
        BLL_LoaiKhachHang bll_loaikh = new BLL_LoaiKhachHang();
        public Main_Form mainform;
        public bool IsReset;

        public KhachHang()
        {
            InitializeComponent();

            /* Tao List GioiTinh */
            List<string> listgioitinh = new List<string>();
            listgioitinh.Add("Nam");
            listgioitinh.Add("Nữ");
            khachhang.MakeComboBoxNoAuto(cbb_GioiTinh, listgioitinh.ToList());

            /* Tao List LoaiKH */
            var listloaikh = bll_loaikh.GetList();
            List<string> nameloaikh = new List<string>();
            foreach (DLL.LoaiKhachHang mem in listloaikh)
                nameloaikh.Add(mem.TenLoaiKH.Trim());
            bll_loaikh.MakeComboBoxNoAuto(cbb_LoaiKH, nameloaikh);

            ResetThongTin();
            Refresh_Grid();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
        }

        private void Refresh_Grid()
        {
            this.gridControl_KhachHang.DataSource = null;
            this.gridControl_KhachHang.DataSource = khachhang.GetList();
        }

        private void ResetThongTin()
        {
            lb_MaKH.Text = khachhang.NewMaKH();
            txt_TenKH.Text = null;
            dtP_NgaySinh.Value = DateTime.Now;
            cbb_GioiTinh.SelectedIndex = 0;
            txt_DiaChi.Text = null;
            txt_SDT.Text = null;
            txt_CMND.Text = null;
            txt_Email.Text = null;
            cbb_LoaiKH.SelectedIndex = 0;
            lb_CongNo.Text = "0 VNĐ";
            btn_Xoa.Visible = false;
            btn_CapNhat.Visible = false;
            btn_Them.Visible = true;
        }

        private bool KiemTraDuLieuNhap()
        {
            if (lb_MaKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Mã khách hàng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_TenKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên khách hàng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (DateTime.Today.Year - dtP_NgaySinh.Value.Year < 4)
            {
                MessageBox.Show("Tuổi của khách hàng phải lớn hơn 3!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (cbb_GioiTinh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Giới tính không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_DiaChi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Địa chỉ không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (txt_SDT.Text.Trim().Length == 0)
            {
                MessageBox.Show("SDT không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            if (cbb_LoaiKH.Text.Trim().Length == 0)
            {
                MessageBox.Show("Loại khách hàng không được để trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (KiemTraDuLieuNhap() == false)
                return;
            var kh = bll_loaikh.GetObjectFromTenLoaiKH(cbb_LoaiKH.Text.Trim());
            if (kh == null)
                return;

            if (khachhang.Insert(lb_MaKH.Text, txt_TenKH.Text, dtP_NgaySinh.Value, cbb_GioiTinh.Text, txt_DiaChi.Text, decimal.Parse(txt_SDT.Text), decimal.Parse(txt_CMND.Text), txt_Email.Text, kh.MaLoaiKH.Trim()))
            {
                Refresh_Grid();
                ResetThongTin();
                 try {mainform.frm_banhang.IsReset = true; } catch {}
                 try {mainform.frm_thongkebanhang.IsReset = true; } catch {}
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            var kh = khachhang.GetObjectFromID(lb_MaKH.Text.Trim());
            if (kh.TenKH.Trim() == "[Không Tên]")
            {
                MessageBox.Show("Đây là khách hàng mặc định, không thể xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (khachhang.Delete(lb_MaKH.Text.Trim()))
            {
                Refresh_Grid();
                ResetThongTin();
                 try {mainform.frm_banhang.IsReset = true; } catch {}
                 try {mainform.frm_thongkebanhang.IsReset = true; } catch {}
            }
        }

        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            var khor = khachhang.GetObjectFromID(lb_MaKH.Text.Trim());
            if (khor.TenKH.Trim() == "[Không Tên]")
            {
                MessageBox.Show("Đây là khách hàng mặc định, không thể cập nhật!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!KiemTraDuLieuNhap())
                return;

            var kh = bll_loaikh.GetObjectFromTenLoaiKH(cbb_LoaiKH.Text.Trim());
            if (kh == null)
                return;

            if (khachhang.Update(lb_MaKH.Text, txt_TenKH.Text, dtP_NgaySinh.Value, cbb_GioiTinh.Text, txt_DiaChi.Text, decimal.Parse(txt_SDT.Text), decimal.Parse(txt_CMND.Text), txt_Email.Text, kh.MaLoaiKH.Trim()))
            {
                Refresh_Grid();
                ResetThongTin();
                 try {mainform.frm_banhang.IsReset = true; } catch {}
                 try {mainform.frm_thongkebanhang.IsReset = true; } catch {}
            }
        }

        private void btn_ResetThongTin_Click(object sender, EventArgs e)
        {
            ResetThongTin();
            btn_Them.Enabled = true;
        }

        private void txt_SDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_CMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void gridControl_KhachHang_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount != 1)
                return;

            btn_Xoa.Visible = true;
            btn_CapNhat.Visible = true;
            btn_Them.Visible = false;

            lb_MaKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
            txt_TenKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenKH").ToString();
            dtP_NgaySinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "NgaySinh").ToString();
            cbb_GioiTinh.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "GioiTinh").ToString();
            txt_DiaChi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "DiaChi").ToString();
            txt_SDT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SDT").ToString();
            txt_CMND.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CMND").ToString();
            txt_Email.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Email").ToString();
            int congno = Int32.Parse(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CongNo").ToString());
            lb_CongNo.Text = (congno == 0 ? "0" : congno.ToString("# ### ###").Trim()) + " VNĐ";
            var loai = bll_loaikh.GetObjectFromID(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "KHTT").ToString().Trim());
            cbb_LoaiKH.Text = loai.TenLoaiKH.Trim();
        }

        private void txt_SDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
       (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_CMND_KeyPress_1(object sender, KeyPressEventArgs e)
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

        private void gridControl_KhachHang_Click(object sender, EventArgs e)
        {

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
                    khachhang.ExportExcel(gridView1, filepath, "Danh Sách Khách Hàng (" + name + ")");
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

        private void KhachHang_VisibleChanged(object sender, EventArgs e)
        {
            if (IsReset)
                if (MessageBox.Show("Cơ sở dữ liệu đã có thay đổi. \nBạn có muốn tắt tab này và mở lại để reset?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // Đồng ý mở lại
                {
                    mainform.ResetTab(mainform.IndexTabFormTenTab(E_FORM.KHACHHANG));
                    IsReset = false;
                }
        }
    }
}