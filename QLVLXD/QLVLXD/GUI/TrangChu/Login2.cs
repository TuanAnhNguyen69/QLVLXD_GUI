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

namespace QLVLXD.GUI.TrangChu
{
    public partial class Login2 : Form
    {
        BLL_Login _Login = new BLL_Login();
        public Main_Form mainform;
        bool truee;
        int waiting;
        const int timetoopen = 1;

        public Login2()
        {
            InitializeComponent();
            Reset();
            timer1.Start();
        }

        public void Reset()
        {
            waiting = 0;
            truee = false;
            pic_Waiting.Visible = false;
            pic_Background.Visible = false;
            tb_Password.ResetText();
            tb_TenDangNhap.ResetText();
            tb_TenDangNhap.Focus();
            Visible = true;
            _Login = new BLL_Login();               
        }

        private void lb_DangNhap_Click(object sender, EventArgs e)
        {
            if (_Login.Login(tb_TenDangNhap.Text, tb_Password.Text))
            {
                pic_Waiting.Visible = true;
                pic_Background.Visible = true;
                truee = true;
            }
            else
                MessageBox.Show("Sai tên đăng nhập hoặc password. \nVui lòng thử lại!", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void lb_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Login2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lb_DangNhap_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                lb_Thoat_Click(null, null);
        }

        private void Login2_Shown(object sender, EventArgs e)
        {
            tb_TenDangNhap.Focus();
        }

        private void tb_Password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lb_DangNhap_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                lb_Thoat_Click(null, null);
        }

        private void tb_TenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                lb_DangNhap_Click(null, null);
            else if (e.KeyCode == Keys.Escape)
                lb_Thoat_Click(null, null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (truee && waiting < timetoopen + 1)
            {
                if (waiting == timetoopen)
                {
                    mainform = new Main_Form();
                    mainform.frm_login = this;                    
                    var nv = (new BLL_NhanVien()).GetObjectFromID(_Login.ReadNV());
                    var user = (new BLL_User()).GetObjectFromMaNV(nv.MaNV.Trim());
                    string ten = user == null ? nv.TenNV.Trim() : user.TenUser.Trim();
                    mainform.Text = mainform.Text + " (" + ten + " - " + ((new BLL_User()).IsUser(nv.MaNV.Trim()) ? "User)" : "Admin)");
                    mainform._NhanVienLogining = nv;
                    mainform.Show();
                    waiting++;
                }
                else
                    waiting++;
            }
        }
    }
}
