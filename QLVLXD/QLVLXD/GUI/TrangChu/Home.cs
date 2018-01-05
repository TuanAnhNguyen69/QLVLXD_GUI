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

namespace QLVLXD.GUI.TrangChu
{
    public partial class Home : DevExpress.XtraEditors.XtraForm
    {
        public Main_Form mainform;

        public Home()
        {
            InitializeComponent();
        }

        private void BANHANG_Click(object sender, EventArgs e)
        {
            mainform.btn_BanHang_ItemClick(null, null);
        }

        private void LB_BANHANG_Click(object sender, EventArgs e)
        {
            mainform.btn_BanHang_ItemClick(null, null);
        }

        private void MUAHANG_Click(object sender, EventArgs e)
        {
            mainform.barButtonItem1_ItemClick_2(null, null);
        }

        private void LB_MUAHANG_Click(object sender, EventArgs e)
        {
            mainform.barButtonItem1_ItemClick_2(null, null);
        }

        private void TBANHANG_Click(object sender, EventArgs e)
        {
            mainform.btn_ThongKeBanHang_ItemClick(null, null);
        }

        private void LB_TBANHANG_Click(object sender, EventArgs e)
        {
            mainform.btn_ThongKeBanHang_ItemClick(null, null);
        }

        private void TMUAHANG_Click(object sender, EventArgs e)
        {
            mainform.btn_ThongKeMuaHang_ItemClick(null, null);
        }

        private void LB_TMUAHANG_Click(object sender, EventArgs e)
        {
            mainform.btn_ThongKeMuaHang_ItemClick(null, null);
        }
    }
}