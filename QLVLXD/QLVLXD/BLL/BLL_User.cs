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

using QLVLXD.DLL;

// NOTES:
// - Kiểm tra tất cả các trường hợp có thể xảy ra lỗi trước khi thao tác đến CSDL, khi có lỗi thì dùng return

namespace QLVLXD.BLL
{
    class BLL_User : BLL
    {
        public bool IsUser(string MaNV)
        {
            var user = GetObjectFromMaNV(MaNV);
            if (user == null)
            {
                MessageBox.Show("Lỗi tìm NV", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return user.PhanQuyen.Trim() == "User";
        }

        public bool IsUser()
        {
            return IsUser(ReadNV());
        }

        public List<QLVLXD.DLL.User> GetList()
        {
            List<QLVLXD.DLL.User> list = new List<DLL.User>();
            foreach (QLVLXD.DLL.User var in DB.Users)
                if (var.Live.Trim() == "True")
                    list.Add(var);

            return list;
        }

        public void Insert(string TenUser, string TenDangNhap, string MaNV, string Password, string PhanQuyen)
        {
            try
            {
                /*Kiểm tra trùng MaNV */
                var listuser = GetList();
                foreach (DLL.User varia in listuser)
                    if (varia.MaNV.Trim() == MaNV.Trim())
                    {
                        MessageBox.Show("Vui lòng chọn nhân viên khác, nhân viên này đã có tài khoản!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                /* Kiểm tra trùng tên đăng nhập */
                List<string> DanhSachTen = new List<string>();
                foreach (QLVLXD.DLL.User user in DB.Users)
                {
                    DanhSachTen.Add(user.TenDangNhap.Trim());
                    if (CheckSameName(DanhSachTen, TenDangNhap))
                    {
                        MessageBox.Show("Vui lòng nhập tên đăng nhập khác, tên đăng nhập này đã được tạo trước đó!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Insert
                QLVLXD.DLL.User vari = new QLVLXD.DLL.User();
                vari.TenUser = TenUser;
                vari.TenDangNhap = TenDangNhap;
                vari.Password = Password;
                vari.PhanQuyen = PhanQuyen;
                vari.MaNV = MaNV;
                vari.Live = "True";
                DB.Users.InsertOnSubmit(vari);
                DB.SubmitChanges();

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(string MaNV)
        {
            try
            {
                var row = GetObjectFromMaNV(MaNV.Trim());

                DialogResult result = MessageBox.Show("Nhấn [Yes] để xác nhận xóa!", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.No)
                    return;

                row.Live = "False";

                DB.SubmitChanges();
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Xóa không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public bool Update(string MaNV, string TenUser, string Password)
        {
            try
            {
                var old_data = DB.Users.FirstOrDefault(data => data.MaNV.Trim() == MaNV.Trim());
                if (old_data == null)
                    throw new Exception();
                old_data.TenUser = TenUser;
                old_data.Password = Password;
                DB.SubmitChanges();

                MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
       
        public QLVLXD.DLL.User GetObjectFromID(string TenDangNhap)
        {
            var Return = DB.Users.FirstOrDefault(data => data.TenDangNhap.Trim() == TenDangNhap.Trim());
            if (Return != null && Return.Live.Trim() == "True")
                return Return;
            else
                return null;
        }

        public QLVLXD.DLL.User GetObjectFromMaNV(string MaNV)
        {
            try
            {
                var list = GetList();
                foreach (DLL.User vari in list)
                    if (vari.MaNV.Trim() == MaNV.Trim())
                    {
                        return vari;
                    }
                return null;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public QLVLXD.DLL.User GetObjectFromTenDanNhap(string TenDangNhap)
        {
            var Return = DB.Users.FirstOrDefault(data => data.TenDangNhap.Trim() == TenDangNhap);
            if (Return != null && Return.Live.Trim() == "True")
                return Return;
            else
                return null;
        }

        public QLVLXD.DLL.User GetObjectFromTenUser(string TenUser)
        {
            try
            {
                var list = GetList();
                foreach (DLL.User vari in list)
                    if (vari.TenUser.Trim() == TenUser.Trim())
                    {
                        return vari;
                    }
                return null;
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
