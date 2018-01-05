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

namespace QLVLXD.BLL
{
    class BLL_HoaDonMuaHang : BLL
    {
        public string Insert(string MaHDMH, DateTime NgayMua, string TenNV, string MaNV, string MaNCC, string TenNCC, decimal SDTNCC, decimal TongTien)
        {
            try
            {
                // ---------------------------------------------------------
                // Kiểm tra các thông tin nhập vào có hợp cmn lệ hay không:
                // ---------------------------------------------------------

                /* Kiểm tra có trùng MaVL hay không */
                if (GetObjectFromID(MaHDMH) != null)
                {
                    return "Mã hóa đơn đã tồn tại trong CSDL! Vui lòng nhấn nút [Reset thông tin để thêm mới] để thêm mới.";
                }

                // ---------------------------------------------------------
                // Nếu hợp lệ thì thêm vào CSDL:
                // ---------------------------------------------------------

                QLVLXD.DLL.HoaDonMuaHang variable = new QLVLXD.DLL.HoaDonMuaHang();

                variable.MaHDMH = MaHDMH;
                variable.NgayMua = NgayMua;
                variable.TenNV = TenNV;
                variable.MaNV = MaNV;
                variable.MaNCC = MaNCC;
                variable.TenNCC = TenNCC;
                variable.SDTNCC = SDTNCC;
                variable.TongTien = TongTien;
                variable.Live = "True";

                DB.HoaDonMuaHangs.InsertOnSubmit(variable);
                DB.SubmitChanges();

                return "Success";

            }
            catch
            {
                return "Error";
            }
        }

        public string Update(string MaHDMH, DateTime NgayMua, string TenNV, string MaNV, string MaNCC, string TenNCC, decimal SDTNCC, decimal TongTien)
        {
            try
            {
                var old_data = GetObjectFromID(MaHDMH);

                if (old_data == null)
                    return "Lỗi không tìm thấy hóa đơn!";

                old_data.NgayMua = NgayMua;
                old_data.TenNV = TenNV;
                old_data.MaNV = MaNV;
                old_data.MaNCC = MaNCC;
                old_data.TenNCC = TenNCC;
                old_data.SDTNCC = SDTNCC;
                old_data.TongTien = TongTien;
                old_data.Live = "True";

                DB.SubmitChanges();

                return "Success";
            }
            catch
            {
                return "Error";
            }
        }

        public BLLResult Delete(string MaHDMH)
        {
            try
            {
                var row = GetObjectFromID(MaHDMH);

                DialogResult result = MessageBox.Show("Nhấn [Yes] để xác nhận xóa hóa đơn " + row.MaHDMH.Trim() + ". Hoặc nhấn [No] để hủy xóa.", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.No)
                    return new BLLResult((int)BLLResultType.NOT_DELETE);

                // Xóa Hóa đơn mua hàng
                row.Live = "False";

                // Xóa CTHoaDonMuaHang của Hóa đơn này
                BLL_CTHoaDonMuaHang CTHDMH = new BLL_CTHoaDonMuaHang();
                if (CTHDMH.DeleteFromMaHDMH(MaHDMH) == "Error")
                    throw new Exception();

                DB.SubmitChanges();

                return new BLLResult((int)BLLResultType.S_DELETE);
            }
            catch
            {
                return new BLLResult(15000852);
            }
        }

        public string NewMaHDMH()
        {
            List<string> danhsach = new List<string>();
            foreach (QLVLXD.DLL.HoaDonMuaHang var in DB.HoaDonMuaHangs)
                danhsach.Add(var.MaHDMH.Trim());
            return NewID(danhsach, "HDMH");
            // Hàm NewID là hàm trả về mã một đối tượng mà chưa có trong danh sách mã. 
            // Ví dụ:
            // + Danh sách mã là VL001, VL003 thì hàm nãy sẽ trả về VL002
            // + Danh sách mã là VL001, VL002, VL003 thì hàm nãy sẽ trả về VL004        
        }

        public List<QLVLXD.DLL.HoaDonMuaHang> GetList()
        {
            List<QLVLXD.DLL.HoaDonMuaHang> list = new List<DLL.HoaDonMuaHang>();
            foreach (QLVLXD.DLL.HoaDonMuaHang var in DB.HoaDonMuaHangs)
                if (var.Live.Trim() == "True")
                    list.Add(var);

            return list;
        }

        public List<QLVLXD.DLL.HoaDonMuaHang> GetListAll()
        {
            List<QLVLXD.DLL.HoaDonMuaHang> list = new List<DLL.HoaDonMuaHang>();
            foreach (QLVLXD.DLL.HoaDonMuaHang var in DB.HoaDonMuaHangs)
                list.Add(var);

            return list;
        }

        public QLVLXD.DLL.HoaDonMuaHang GetObjectFromID(string MaHDMH)
        {
            var Return = DB.HoaDonMuaHangs.FirstOrDefault(data => data.MaHDMH.Trim() == MaHDMH);
            if (Return != null && Return.Live.Trim() == "True")
                return Return;
            else
                return null;
        }

    }
}
