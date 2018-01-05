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

namespace QLVLXD.GUI.NhanSu
{
    public partial class CapNhatTaiKhoan : DevExpress.XtraEditors.XtraForm
    {
        BLL_User _User = new BLL_User();
        public DLL.NhanVien _NhanVien = new DLL.NhanVien();
        public Main_Form mainform;

        public CapNhatTaiKhoan()
        {
            InitializeComponent();
        }
        
        private void lb_CapNhat_Click(object sender, EventArgs e)
        {
            if (tb_TenUser.Text.Trim().Length == 0)
            {
                MessageBox.Show("Tên User không được để trống,", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tb_PassMoi.Text.Trim().Length < 6)
            {
                MessageBox.Show("Password phải từ 6 kí tự trở lên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tb_PassMoi2.Text.Trim() != tb_PassMoi.Text.Trim())
            {
                MessageBox.Show("Password nhập lại không trùng với password mới nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = _User.GetObjectFromMaNV(_NhanVien.MaNV.Trim());
            if (tb_PassCu.Text.Trim() != user.Password.Trim())
            {
                MessageBox.Show("Password cũ không đúng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_User.Update(_NhanVien.MaNV.Trim(), tb_TenUser.Text.Trim(), tb_PassMoi.Text.Trim()))
                mainform.Text = "Quản Lý Cửa Hàng Vật Liệu Xây Dựng (" + tb_TenUser.Text.Trim() + " - " + ((new BLL_User()).IsUser() ? "User)" : "Admin)");
        }

        private void lb_Thoat_Click(object sender, EventArgs e)
        {
            mainform.CloseTab(mainform.IndexTabFormTenTab(E_FORM.CAPNHATTAIKHOAN));
        }
    }
}