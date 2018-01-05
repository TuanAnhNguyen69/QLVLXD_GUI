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
    public partial class XemHoaDonMuaHang : DevExpress.XtraEditors.XtraForm
    {
        DLL.HoaDonMuaHang _HDMH = new DLL.HoaDonMuaHang();
        List<DLL.CTHoaDonMuaHang> _ListCT = new List<CTHoaDonMuaHang>();
        public ThongKeMuaHang main;

        public XemHoaDonMuaHang(string MaHDMH)
        {
            InitializeComponent();
            _HDMH = (new BLL_HoaDonMuaHang()).GetObjectFromID(MaHDMH.Trim());
            _ListCT = (new BLL.BLL_CTHoaDonMuaHang()).GetListCTHoaDonMuaHang(_HDMH.MaHDMH.Trim());
        }

        private void XemHoaDonMuaHang_Load(object sender, EventArgs e)
        {
            lb_MaHDBH.Text = _HDMH.MaHDMH.Trim();
            Text = Text + " (" + lb_MaHDBH.Text + ")";
            lb_MaNV.Text = _HDMH.MaNV.Trim();
            lb_NgayMua.Text = _HDMH.NgayMua.ToShortDateString();
            lb_TongTien.Text = ((long)_HDMH.TongTien).ToString("# ### ### ###").Trim() + " VNĐ";
            lb_TenNV.Text = _HDMH.TenNV.Trim();
            lb_SoVatLieu.Text = _ListCT.Count.ToString() + " Vật liệu";

            grid.DataSource = null;
            grid.DataSource = _ListCT;     
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
                res = (new BLL_HoaDonMuaHang()).Delete(_HDMH.MaHDMH.Trim());
                (new BLL_CTHoaDonBanHang()).MakeMessageBox(res);
                if (res._Code == (int)BLLResultType.S_DELETE)
                {
                    main.Reset();
                    Close();                   
                }
            }
            catch (Exception)
            {
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
                    if (tb_TenThongKe.Text == "")
                        tb_TenThongKe.Text = "Hóa Đơn Mua Hàng";
                    name = name.Replace('/', '-');
                    name = name.Replace(':', '-');
                    this.Enabled = false;
                    (new BLL_CTHoaDonMuaHang()).ExportExcel(gridView1, filepath, tb_TenThongKe.Text + " (" + name + ")");
                    MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Enabled = true;
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