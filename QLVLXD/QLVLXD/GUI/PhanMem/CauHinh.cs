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

namespace QLVLXD.GUI.PhanMem
{
    public partial class CauHinh : DevExpress.XtraEditors.XtraForm
    {
        public Main_Form mainform;

        public CauHinh()
        {
            InitializeComponent();            
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            try
            {
                (new BLL.BLL_DonViTinhVatLieu())._SoLuongVatLieuToiThieu = (int)num_SoLuongToiThieu.Value;
                Config config = new Config();
               config._SoLuongToiThieu = (int)num_SoLuongToiThieu.Value;
                mainform.SetTimerInterval((int)num_ThoiGianKiemTra.Value * 60000);
                config._ThoiGianKiemTraCSDL = (int)num_ThoiGianKiemTra.Value;
                (new BLL_CTHoaDonBanHang()).WriteConfig(config);
                MessageBox.Show("Đã cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi cập nhật!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CauHinh_Load(object sender, EventArgs e)
        {
            if (mainform != null)
            {
                Config config = new Config();
                config = (new BLL_CTHoaDonBanHang()).ReadConfig();
                num_SoLuongToiThieu.Value = config._SoLuongToiThieu;
                num_ThoiGianKiemTra.Value = config._ThoiGianKiemTraCSDL;
            }
        }

        private void CauHinh_VisibleChanged(object sender, EventArgs e)
        {
            CauHinh_Load(null, null);
        }
    }
}