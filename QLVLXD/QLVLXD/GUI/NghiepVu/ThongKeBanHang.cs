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
using DevExpress.XtraTab;

namespace QLVLXD.GUI.NghiepVu
{
    public partial class ThongKeBanHang : DevExpress.XtraEditors.XtraForm
    {
        List<RecordThongKeBanHang> _ListOrginal = new List<RecordThongKeBanHang>();
        List<RecordThongKeBanHang> _ListFilter = new List<RecordThongKeBanHang>();
        BLL_ThongKeBanHang _ThongKeBanHang = new BLL_ThongKeBanHang();
        BLL_CTHoaDonBanHang _CTHoaDonBanHang = new BLL_CTHoaDonBanHang();
        BLL_User _User = new BLL_User();
        BLL_KhachHang _KhachHang = new BLL_KhachHang();
        BLL_NhaCungCap _NhaCungCap = new BLL_NhaCungCap();
        BLL_HoaDonBanHang _HoaDonBanHang = new BLL_HoaDonBanHang();
        public bool IsReset;
        public Main_Form mainform;

        public ThongKeBanHang()
        {
            InitializeComponent();
            _ListOrginal = _ThongKeBanHang.GetListOrginal();
            Reset();
            // Tạo ds cho cb_TenNhanVien
            List<DLL.NhanVien> listuser = (new BLL_NhanVien()).GetList();
            List<string> listnameuser = new List<string>();
            listnameuser.Add("");
            foreach (DLL.NhanVien mem in listuser)
                listnameuser.Add(mem.TenNV.Trim());
            _CTHoaDonBanHang.MakeComboBoxNoAuto(cb_TenNhanVien, listnameuser);
            // Tạo ds cho cb_TenKH
            List<DLL.KhachHang> listKH = _KhachHang.GetList();
            List<string> listnamekh = new List<string>();
            listnamekh.Add("");
            foreach (DLL.KhachHang mem in listKH)
                listnamekh.Add(mem.TenKH.Trim());
            _CTHoaDonBanHang.MakeComboBoxNoAuto(cb_TenKhachHang, listnamekh);
            // Tạo ds cho cb_TrangThai
            List<string> liststt = new List<string>();
            liststt.Add("");
            liststt.Add("Giao Ngay Lúc Lập");
            liststt.Add("Chưa Giao");
            liststt.Add("Đang Giao");
            liststt.Add("Đã Giao");
            _NhaCungCap.MakeComboBoxNoAuto(cb_TrangThai, liststt);
            liststt.Clear();
            liststt.Add("Đang Giao");
            liststt.Add("Đã Giao");
            _HoaDonBanHang.MakeComboBoxNoAuto(cb_ThietLapTrangThai, liststt);
            cb_ThietLapTrangThai.SelectedIndex = 0;
        }

        void LoadGrid(List<RecordThongKeBanHang> ListRecord)
        {
            try
            {
                for (; grid_Filter.Rows.Count > 0;) // Xóa hết dòng
                    grid_Filter.Rows.RemoveAt(0);
            }
            catch
            { }
            try
            {
                lb_SoHoaDon.Text = ListRecord.Count.ToString();
                foreach (RecordThongKeBanHang vari in ListRecord)
                {
                    grid_Filter.Rows.Add(vari.MaHDBH, vari.NgayGiao.ToShortDateString(), vari.NgayLap.ToShortDateString(), vari.MaNV, vari.TenNV, vari.MaKH, vari.TenKH, vari.SoVatLieu, vari.TienVatLieu, vari.TienKhuyenMai, vari.TienKMKH, vari.TongTien, vari.LaiSuat, vari.Von, vari.TrangThai, vari.GhiChu);
                }
            }
            catch (Exception)
            { }
        }

        public void SetLocChuaGiao()
        {
            cb_TrangThai.Text = "Chưa Giao";
            rb_NgayGiao.Checked = true;
            btn_Loc_Click(null, null);
        }

        void Reset()
        {
            IsReset = false;
            LoadGrid(_ListOrginal);
            btn_OkThietLapTrangThai.Enabled = false;
            foreach (Control vari in this.panel4.Controls)
            {
                if (vari is System.Windows.Forms.GroupBox)
                {
                    foreach (Control vari2 in ((System.Windows.Forms.GroupBox)vari).Controls)
                    {
                        if (vari2 is System.Windows.Forms.NumericUpDown)
                            ((System.Windows.Forms.NumericUpDown)vari2).Value = 0;
                        else if (vari2 is System.Windows.Forms.ComboBox)
                        {
                            ((System.Windows.Forms.ComboBox)vari2).Text = "";
                            ((System.Windows.Forms.ComboBox)vari2).SelectedText = "";
                        }
                        else if (vari2 is System.Windows.Forms.RadioButton && vari2.Name.Substring(0, 2) == "rx")
                            ((System.Windows.Forms.RadioButton)vari2).Checked = true;
                        else if (vari2 is System.Windows.Forms.NumericUpDown)
                            ((System.Windows.Forms.NumericUpDown)vari2).Value = 0;
                    }
                }
            }
        }

        bool TextinText(string Father, string Son, bool IsCase)
        {
            if (Son == ""
                || (IsCase && Father.Contains(Son))
                || Father.ToUpper().Contains(Son.ToUpper()))
                return true;
            return false;
        }

        // [Lọc]
        public void btn_Loc_Click(object sender, EventArgs e)
        {
            IsReset = false;
            _ListFilter.Clear();
            foreach (RecordThongKeBanHang orgi in _ListOrginal)
            {
                if (!TextinText(orgi.TenNV, cb_TenNhanVien.Text, false))
                    continue;
                if (!TextinText(orgi.TenKH, cb_TenKhachHang.Text, false))
                    continue;
                if (!TextinText(orgi.TrangThai, cb_TrangThai.Text, false))
                    continue;
                if (!rx_GhiChu.Checked)
                {
                    if ((rco_GhiChu.Checked && orgi.GhiChu != "True")
                        || (rkhong_GhiChu.Checked && orgi.GhiChu != "False"))
                        continue;
                }
                {
                    if (!rx_NgayLap.Checked)
                    {
                        if ((rl_NgayLap.Checked && !(DateTime.Parse(orgi.NgayLap.ToShortDateString()) > DateTime.Parse(dtp_NgayLap.Value.ToShortDateString())))
                            || (rn_NgayLap.Checked && !(DateTime.Parse(orgi.NgayLap.ToShortDateString()) < DateTime.Parse(dtp_NgayLap.Value.ToShortDateString())))
                            || (rb_NgayLap.Checked && !(DateTime.Parse(orgi.NgayLap.ToShortDateString()) == DateTime.Parse(dtp_NgayLap.Value.ToShortDateString()))))
                            continue;
                    }
                }
                {
                    if (!rx_NgayGiao.Checked)
                    {
                        if ((rl_NgayGiao.Checked && !(DateTime.Parse(orgi.NgayGiao.ToShortDateString()) > DateTime.Parse(dtp_NgayGiao.Value.ToShortDateString())))
                            || (rn_NgayGiao.Checked && !(DateTime.Parse(orgi.NgayGiao.ToShortDateString()) < DateTime.Parse(dtp_NgayGiao.Value.ToShortDateString())))
                            || (rb_NgayGiao.Checked && !(DateTime.Parse(orgi.NgayGiao.ToShortDateString()) == DateTime.Parse(dtp_NgayGiao.Value.ToShortDateString()))))
                            continue;
                    }
                }
                {
                    if (!rx_SoVatLieu.Checked)
                    {
                        if ((rl_SoVatLieu.Checked && !(orgi.SoVatLieu > num_SoVatLieu.Value))
                            || (rn_SoVatLieu.Checked && !(orgi.SoVatLieu < num_SoVatLieu.Value))
                            || (rb_SoVatLieu.Checked && !(orgi.SoVatLieu == num_SoVatLieu.Value)))
                            continue;
                    }
                }
                {
                    if (!rx_LaiSuat.Checked)
                    {
                        if ((rl_LaiSuat.Checked && !(orgi.LaiSuat > num_LaiSuat.Value))
                            || (rn_LaiSuat.Checked && !(orgi.LaiSuat < num_LaiSuat.Value))
                            || (rb_LaiSuat.Checked && !(orgi.LaiSuat == num_LaiSuat.Value)))
                            continue;
                    }
                }
                {
                    if (!rx_TongTien.Checked)
                    {
                        if ((rl_TongTien.Checked && !(orgi.TongTien > num_TongTien.Value))
                            || (rn_TongTien.Checked && !(orgi.TongTien < num_TongTien.Value))
                            || (rb_TongTien.Checked && !(orgi.TongTien == num_TongTien.Value)))
                            continue;
                    }
                }
                {
                    if (!rx_TienVatLieu.Checked)
                    {
                        if ((rl_TienVatLieu.Checked && !(orgi.TienVatLieu > num_TienVatLieu.Value))
                            || (rn_TienVatLieu.Checked && !(orgi.TienVatLieu < num_TienVatLieu.Value))
                            || (rb_TienVatLieu.Checked && !(orgi.TienVatLieu == num_TienVatLieu.Value)))
                            continue;
                    }
                }
                {
                    if (!rx_TienKhuyenMai.Checked)
                    {
                        if ((rl_TienKhuyenMai.Checked && !(orgi.TienKhuyenMai > num_TienKhuyenMai.Value))
                            || (rn_TienKhuyenMai.Checked && !(orgi.TienKhuyenMai < num_TienKhuyenMai.Value))
                            || (rb_TienKhuyenMai.Checked && !(orgi.TienKhuyenMai == num_TienKhuyenMai.Value)))
                            continue;
                    }
                }
                {
                    if (!rx_TienKMKH.Checked)
                    {
                        if ((rl_TienKMKH.Checked && !(orgi.TienKMKH > num_TienKMKH.Value))
                            || (rn_TienKMKH.Checked && !(orgi.TienKMKH < num_TienKMKH.Value))
                            || (rb_TienKMKH.Checked && !(orgi.TienKMKH == num_TienKMKH.Value)))
                            continue;
                    }
                }
                {
                    if (!rx_Von.Checked)
                    {
                        if ((rl_Von.Checked && !(orgi.Von > num_Von.Value))
                            || (rn_Von.Checked && !(orgi.Von < num_Von.Value))
                            || (rb_Von.Checked && !(orgi.Von == num_Von.Value)))
                            continue;
                    }
                }

                _ListFilter.Add(orgi);
            }
            LoadGrid(_ListFilter);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void grid_Filter_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int rowindex = grid_Filter.SelectedCells[0].RowIndex;
                grid_Filter.Rows[rowindex].Selected = true;
                string trangthai = grid_Filter.Rows[rowindex].Cells["TrangThai"].Value.ToString().Trim();
                if (trangthai == "Đã Giao" || trangthai == "Giao Ngay Lúc Lập")
                    btn_OkThietLapTrangThai.Enabled = false;
                else
                    btn_OkThietLapTrangThai.Enabled = true;
            }
            catch (Exception)
            {

            }            
        }

        // [Xóa hóa đơn]
        private void btn_XoaHoaDon_Click(object sender, EventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int rowindex = grid_Filter.SelectedCells[0].RowIndex;
                string mahd = grid_Filter.Rows[rowindex].Cells[0].Value.ToString().Trim();
                XoaHoaDon(mahd);
            }
            catch (Exception)
            {
                _HoaDonBanHang.MakeMessageBox(new BLLResult("Vui lòng chọn hóa đơn để xóa!"));
            }
        }

        public bool XoaHoaDon(string MaHD)
        {
            MaHD = MaHD.Trim();
            BLLResult res = new BLLResult();
            res = _HoaDonBanHang.Delete(MaHD, false);
            _HoaDonBanHang.MakeMessageBox(res);
            if (res._Code == (int)BLLResultType.S_DELETE) // Xóa thành công
            {
                foreach (RecordThongKeBanHang vari in _ListOrginal)
                    if (vari.MaHDBH == MaHD)
                    {
                        _ListOrginal.Remove(vari);
                        break;
                    }
                Reset();
                return true;
            }
            return false;
        }

        // [OK]
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BLLResult res = new BLLResult();
            try
            {
                int rowindex = grid_Filter.SelectedCells[0].RowIndex;
                string mahd = grid_Filter.Rows[rowindex].Cells[0].Value.ToString().Trim();
                if (cb_ThietLapTrangThai.Text == "Đã Giao")// Trừ công nợ cho KH
                {
                    int tongtien = Int32.Parse(grid_Filter.Rows[rowindex].Cells[11].Value.ToString().Trim());
                    string tenkh = grid_Filter.Rows[rowindex].Cells[6].Value.ToString().Trim();
                    res = _KhachHang.CongNoPlus(-tongtien, tenkh);
                    if (res._Code != (int)BLLResultType.SUCCESS)
                    {
                        _KhachHang.MakeMessageBox(res);
                        return;
                    }
                }
                res = _HoaDonBanHang.SetTrangThai(cb_ThietLapTrangThai.Text, mahd);
                if (res._Code == (int)BLLResultType.SUCCESS) // Thành công
                {
                    MessageBox.Show("Thiết lập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try { mainform.frm_khachhang.IsReset = true; } catch { }
                    RecordThongKeBanHang record = new RecordThongKeBanHang();
                    foreach (RecordThongKeBanHang vari in _ListOrginal)
                        if (vari.MaHDBH == mahd)
                        {
                            record = vari;
                            _ListOrginal.Remove(vari);
                            break;
                        }
                    record.TrangThai = cb_ThietLapTrangThai.Text;
                    _ListOrginal.Add(record);
                    Reset();
                }
            }
            catch (Exception)
            {
                _HoaDonBanHang.MakeMessageBox(res);
            }
        }

        private void ThongKeBanHang_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btn_Loc_Click(null, null);
        }

        // [Xuất ra File]
        private async void btn_XuatFile_Click(object sender, EventArgs e)
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
                    if (tb_TenThongKe.Text == "")
                        tb_TenThongKe.Text = "Thống Kê Bán Hàng";
                    name = name.Replace('/', '-');
                    name = name.Replace(':', '-');
                    this.Enabled = false;
                    _HoaDonBanHang.ExportExcel(grid_Filter, filepath, tb_TenThongKe.Text + " (" + name + ")");
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Xuất Excel không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        // [Xem chi tiết hóa đơn]
        private void btn_XemChiTietHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = grid_Filter.SelectedCells[0].RowIndex;
                string mahd = grid_Filter.Rows[rowindex].Cells[0].Value.ToString().Trim();
                if ((new BLL_HoaDonBanHang()).GetObjectFromID(mahd) == null)
                {
                    if (DialogResult.Yes == MessageBox.Show("Hóa đơn bạn chọn đã bị xóa. Vui lòng Reset để load lại dữ liệu. Reset?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error))
                    {
                        mainform.ResetTab(mainform.IndexTabFormTenTab(E_FORM.THONGKEBANHANG));
                    }
                    return;
                }
                GUI.NghiepVu.XemHoaDonBanHang form = new XemHoaDonBanHang(mahd);
                form.main = this;
                form.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ThongKeBanHang_Load(object sender, EventArgs e)
        {

        }

        private void grid_Filter_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btn_XemChiTietHoaDon_Click(null, null);
        }

        private void ThongKeBanHang_Enter(object sender, EventArgs e)
        {
        }

        private void ThongKeBanHang_VisibleChanged(object sender, EventArgs e)
        {
            if (IsReset)
                if (MessageBox.Show("Cơ sở dữ liệu đã có thay đổi. \nBạn có muốn tắt tab này và mở lại để reset?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // Đồng ý mở lại
                {
                    mainform.ResetTab(mainform.IndexTabFormTenTab(E_FORM.THONGKEBANHANG));
                    IsReset = false;
                }
        }

        private void ThongKeBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ThongKeBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void btn_In_Click(object sender, EventArgs e)
        {
            (new PrintDialog()).ShowDialog();
        }
    }
}