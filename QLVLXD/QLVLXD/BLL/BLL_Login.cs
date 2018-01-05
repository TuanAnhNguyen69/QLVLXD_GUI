using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using QLVLXD.BLL;
using QLVLXD.DLL;

namespace QLVLXD.BLL
{
    class BLL_Login : BLL
    {
        BLL_User _User = new BLL_User();
        
        public bool Login(string TenDangNhap, string Password)
        {
            var user = _User.GetObjectFromTenDanNhap(TenDangNhap);
            if (user == null || !VarLive(user.Live))
                return false;
            else
            {
                if (user.Password.Trim() != Password)
                    return false;
                _User.WriteNV(user.MaNV.Trim());
            }
            return true;
        }
    }
}