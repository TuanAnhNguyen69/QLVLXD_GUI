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

namespace QLVLXD.GUI.NghiepVu
{
    public partial class ThongKeMuaHang : DevExpress.XtraEditors.XtraForm
    {
        List<DLL.HoaDonMuaHang> _Orginal = new List<DLL.HoaDonMuaHang>();
        List<DLL.HoaDonMuaHang> _Filter = new List<DLL.HoaDonMuaHang>();
        public Main_Form mainform;
        BLL_CTHoaDonMuaHang _CTHDMH = new BLL_CTHoaDonMuaHang();
        public bool IsReset;

        public ThongKeMuaHang()
        {
            InitializeComponent();

            // Tạo ds cho cb_TenNhanVien
            List<DLL.NhanVien> listuser = (new BLL_NhanVien()).GetList();
            List<string> listnameuser = new List<string>();
            listnameuser.Add("");
            foreach (DLL.NhanVien mem in listuser)
                listnameuser.Add(mem.TenNV.Trim());
            _CTHDMH.MakeComboBoxNoAuto(cb_TenNhanVien, listnameuser);

            // Combobox NCC
            List<string> listtenncc = new List<string>();
            listtenncc.Add("");
            List<DLL.NhaCungCap> listncc = (new BLL_NhaCungCap()).GetList();
            foreach (DLL.NhaCungCap mem in listncc)
            {
                listtenncc.Add(mem.TenNCC.Trim());
            }
            _CTHDMH.MakeComboBoxNoAuto(cb_TenNCC, listtenncc);

            _Orginal = (new BLL_HoaDonMuaHang()).GetList();
            Reset();
        }

        public void Reset()
        {
            cb_TenNCC.SelectedIndex = 0;
            cb_TenNhanVien.SelectedIndex = 0;
            num_SoVatLieu.Value = 0;
            rx_SoVatLieu.Checked = true;
            num_TongTien.Value = 0;
            rx_TongTien.Checked = true;
            rx_NgayLap.Checked = true;
            _Orginal.Clear();
            _Orginal = (new BLL_HoaDonMuaHang()).GetList();
            LoadGrid(_Orginal);
        }

        void LoadGrid(List<DLL.HoaDonMuaHang> ListHDMH)
        {
            grid.DataSource = null;
            grid.DataSource = ListHDMH;
            lb_SoHoaDon.Text = ListHDMH.Count.ToString();
        }

        private void ThongKeMuaHang_Load(object sender, EventArgs e)
        {
        }


        private void btn_In_Click(object sender, EventArgs e)
        {
            (new PrintDialog()).ShowDialog();
        }

        private void btn_Loc_Click(object sender, EventArgs e)
        {
            _Filter.Clear();
            foreach (DLL.HoaDonMuaHang orgi in _Orginal)
            {
                if (cb_TenNhanVien.Text != "" && orgi.TenNV.Trim() != cb_TenNhanVien.Text)
                    continue;
                if (cb_TenNCC.SelectedIndex != 0 || !rx_SoVatLieu.Checked)// NCC, Số vật liệu
                { 
                    var listct = _CTHDMH.GetListCTHoaDonMuaHang(orgi.MaHDMH.Trim());
                    if (cb_TenNCC.SelectedIndex != 0)
                    {
                        bool concc = false;
                        foreach (DLL.CTHoaDonMuaHang vari in listct)
                        {
                            var vl = (new BLL_VatLieu()).GetObjectFromID(vari.MaVL.Trim());
                            if (vl != null)
                            {
                                var ncc = (new BLL_NhaCungCap()).GetObjectFromID(vl.MaNCC.Trim());
                                if (ncc != null && ncc.TenNCC.Trim() == cb_TenNCC.Text)
                                {
                                    concc = true;
                                    break;
                                }
                            }
                        }
                        if (!concc)
                            continue;
                    }
                    if (!rx_SoVatLieu.Checked)
                    {
                        if ((rl_SoVatLieu.Checked && !(listct.Count > num_SoVatLieu.Value))
                            || (rn_SoVatLieu.Checked && !(listct.Count < num_SoVatLieu.Value))
                            || (rb_SoVatLieu.Checked && !(listct.Count == num_SoVatLieu.Value)))
                            continue;
                    }
                }
                if (!rx_TongTien.Checked)
                {
                    if ((rl_TongTien.Checked && !(orgi.TongTien > num_TongTien.Value))
                        || (rn_TongTien.Checked && !(orgi.TongTien < num_TongTien.Value))
                        || (rb_TongTien.Checked && !(orgi.TongTien == num_TongTien.Value)))
                        continue;
                }
                if (!rx_NgayLap.Checked)
                {
                    if ((rl_NgayLap.Checked && !(DateTime.Parse(orgi.NgayMua.ToShortDateString()) > DateTime.Parse(dtp_NgayLap.Value.ToShortDateString())))
                        || (rn_NgayLap.Checked && !(DateTime.Parse(orgi.NgayMua.ToShortDateString()) < DateTime.Parse(dtp_NgayLap.Value.ToShortDateString())))
                        || (rb_NgayLap.Checked && !(DateTime.Parse(orgi.NgayMua.ToShortDateString()) == DateTime.Parse(dtp_NgayLap.Value.ToShortDateString()))))
                        continue;
                }
                _Filter.Add(orgi);
            }
            LoadGrid(_Filter);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btn_XemChiTietHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selectedindex = gridView1.GetSelectedRows();
                var tt = gridView1.GetRow(selectedindex[0]);

                GUI.NghiepVu.XemHoaDonMuaHang form = new XemHoaDonMuaHang(((DLL.HoaDonMuaHang)tt).MaHDMH.Trim());
                form.main = this;
                form.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xem!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void grid_MouseDoubleClick(object sender, MouseEventArgs e)
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
                    filepath = browse.SelectedPath; if (filepath[filepath.Length - 1] != '\\') filepath = filepath + "\\";
                    string name = DateTime.Now.ToString();
                    if (tb_TenThongKe.Text == "")
                        tb_TenThongKe.Text = "Thống Kê Mua Hàng";
                    name = name.Replace('/', '-');
                    name = name.Replace(':', '-');
                    this.Enabled = false;
                    _CTHDMH.ExportExcel(gridView1, filepath, tb_TenThongKe.Text + " (" + name + ")");
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Enabled = true;
                }
            }
            catch
            {
                MessageBox.Show("Xuất Excel không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_XoaHoaDon_Click(object sender, EventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            BLLResult res = new BLLResult();
            try
            {
                int[] selectedindex = gridView1.GetSelectedRows();
                var tt = gridView1.GetRow(selectedindex[0]);
                res = (new BLL_HoaDonMuaHang()).Delete(((DLL.HoaDonMuaHang)tt).MaHDMH.Trim());
                _CTHDMH.MakeMessageBox(res);
                if ( res._Code == (int)BLLResultType.S_DELETE)
                {
                    _Orginal = (new BLL_HoaDonMuaHang()).GetList();
                    LoadGrid(_Orginal);
                    try { mainform.frm_muahang.IsReset = true; } catch { }
                }
            }
            catch (Exception)
            {
                _CTHDMH.MakeMessageBox(new BLLResult("Vui lòng chọn hóa đơn để xóa!"));
            }
        }

        private void ThongKeMuaHang_VisibleChanged(object sender, EventArgs e)
        {
            if (IsReset)
                if (MessageBox.Show("Cơ sở dữ liệu đã có thay đổi. \nBạn có muốn tắt tab này và mở lại để reset?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // Đồng ý mở lại
                {
                    mainform.ResetTab(mainform.IndexTabFormTenTab(E_FORM.THONGKEMUAHANG));
                    IsReset = false;
                }
        }
    }
}