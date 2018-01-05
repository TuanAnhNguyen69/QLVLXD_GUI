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
    class BLL_NhaCungCap : BLL
    {
        // Hàm GetList để lấy danh sách tất cả các dòng của bảng. (chỉ các đối tượng Live = "True")
        public List<QLVLXD.DLL.NhaCungCap> GetList()
        {
            List<QLVLXD.DLL.NhaCungCap> list = new List<DLL.NhaCungCap>();
            foreach (QLVLXD.DLL.NhaCungCap var in DB.NhaCungCaps)
                if (var.Live.Trim() == "True")
                    list.Add(var);

            return list;
        }

        // Hàm GetObjectFromID để lấy thông tin 1 vật liệu từ mã vật liệu, nếu ko có thì trả về null.
        public QLVLXD.DLL.NhaCungCap GetObjectFromID(string MaNCC)
        {
            var Return = DB.NhaCungCaps.FirstOrDefault(data => data.MaNCC.Trim() == MaNCC);
            if (Return != null && Return.Live.Trim() == "True")
                return Return;
            else
                return null;
        }

        public QLVLXD.DLL.NhaCungCap GetObjectFromTenNhaCungCap(string TenNhaCungCap)
        {
            var Return = DB.NhaCungCaps.FirstOrDefault(data => data.TenNCC.Trim() == TenNhaCungCap);
            if (Return != null && Return.Live.Trim() == "True")
                return Return;
            else
                return null;
        }

        public string NewMaNCC()
        {
            List<string> danhsach = new List<string>();
            foreach (QLVLXD.DLL.NhaCungCap var in DB.NhaCungCaps)
                danhsach.Add(var.MaNCC.Trim());
            return NewID(danhsach, "NCC");
        }

        public bool Delete(string MaNCC)
        {
            try
            {
                var row = GetObjectFromID(MaNCC);
                if (row == null)
                    return false;
                {// Kiểm tra nhà cung cấp này có sử dụng hay không
                    /* CTBH */
                    var list = (new BLL_CTHoaDonBanHang()).GetList();
                    foreach (DLL.CTHoaDonBanHang vari in list)
                        if (vari.TenNCC.Trim() == row.TenNCC.Trim())
                        {
                            (new BLL_CTHoaDonBanHang()).MakeMessageBox(new BLLResult("Nhà cung cấp này cung cấp vật liệu cho các hóa đơn bán hàng hiện tại nên không thể xóa!"));
                            return false;
                        }
                    /* Vật liệu */
                    var list2 = (new BLL_VatLieu()).GetList();
                    foreach (DLL.VatLieu vari in list2)
                        if (vari.MaNCC.Trim() == MaNCC)
                        {
                            (new BLL_CTHoaDonBanHang()).MakeMessageBox(new BLLResult("Nhà cung cấp này cung cấp vật liệu cho kho hàng hiện tại nên không thể xóa!"));
                            return false;
                        }
                }
                DialogResult result = MessageBox.Show("Nhấn [Yes] để xác nhận xóa nhà cung cấp " + row.TenNCC.Trim() + " - " + row.MaNCC.Trim() + "Hoặc nhấn [No] để hủy xóa.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.No)
                    return false;

                // Xóa bên bảng NhaCungCap
                row.Live = "False";

                DB.SubmitChanges();

                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return true;
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public bool Update(string MaNCC, string TenNCC, decimal SDT, string DiaChi)
        {
            try
            {
                var old_data = DB.NhaCungCaps.FirstOrDefault(data => data.MaNCC.Trim() == MaNCC);  

                /* Kiểm tra trùng tên */
                if (old_data.TenNCC.Trim() != TenNCC)
                {
                    List<string> DanhSachTen = new List<string>();
                    foreach (QLVLXD.DLL.NhaCungCap ncc in DB.NhaCungCaps)
                    {
                        DanhSachTen.Add(ncc.TenNCC.Trim());
                        if (CheckSameName(DanhSachTen, TenNCC))
                        {
                            MessageBox.Show("Vui lòng nhập tên nhà cung cấp khác, tên nhà cung cấp đã có trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                {// Update tên ncc trong bản CTHDBH, HDMH
                    var list = (new BLL_CTHoaDonBanHang()).GetList();
                    foreach (DLL.CTHoaDonBanHang vari in list)
                        if (vari.TenNCC.Trim() == old_data.TenNCC.Trim())
                            vari.TenNCC = TenNCC;
                    var list2 = (new BLL_HoaDonMuaHang()).GetList();
                    foreach (DLL.HoaDonMuaHang vari in list2)
                        if (vari.TenNCC.Trim() == old_data.TenNCC.Trim())
                            vari.TenNCC = TenNCC;
                }
                /* Cập nhật ở bảng NhaCungCap */
                old_data.TenNCC = TenNCC;
                old_data.SDT = SDT;
                old_data.DiaChi = DiaChi;
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
        
        public bool Insert(string MaNCC, string TenNCC, decimal SDT, string DiaChi)
        {
            try
            {
                /* Kiểm tra trùng tên */
                List<string> DanhSachTen = new List<string>();
                foreach (QLVLXD.DLL.NhaCungCap ncc in DB.NhaCungCaps)
                {
                    DanhSachTen.Add(ncc.TenNCC.Trim());
                    if (CheckSameName(DanhSachTen, MaNCC))
                    {
                        MessageBox.Show("Vui lòng nhập tên nhà cung cấp khác, tên nhà cung cấp đã có trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }

                // ---------------------------------------------------------
                // Nếu hợp lệ thì thêm vào CSDL:
                // ---------------------------------------------------------

                QLVLXD.DLL.NhaCungCap var = new QLVLXD.DLL.NhaCungCap();
                var.MaNCC = MaNCC;
                var.TenNCC = TenNCC;
                var.SDT = SDT;
                var.DiaChi = DiaChi;
                var.Live = "True";

                DB.NhaCungCaps.InsertOnSubmit(var);
                DB.SubmitChanges();

                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            catch
            {
                MessageBox.Show("Thêm không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public string GetTenNCCFromMaNCC(string MaNCC)
        {
            var Return = DB.NhaCungCaps.FirstOrDefault(data => data.MaNCC.Trim() == MaNCC.Trim());
            if (Return != null && Return.Live.Trim() == "True")
                return Return.TenNCC.Trim();
            else
                return null;
        }
    }
}
