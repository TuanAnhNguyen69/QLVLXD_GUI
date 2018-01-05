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
    class BLL_CTHoaDonMuaHang : BLL
    {
        public string Insert(List<QLVLXD.DLL.CTHoaDonMuaHang> DanhSachVatLieu)
        {
            try
            {
                BLL_VatLieu vatlieu = new BLL_VatLieu();
                foreach (QLVLXD.DLL.CTHoaDonMuaHang member in DanhSachVatLieu)
                {
                    vatlieu.UpdateSoLuongPlus(member.MaVL.Trim(), member.SoLuong);
                    DB.CTHoaDonMuaHangs.InsertOnSubmit(member);
                }

                DB.SubmitChanges();

                return "Success";
            }
            catch
            {
                return "Error";
            }
        }

        public string Update(List<QLVLXD.DLL.CTHoaDonMuaHang> DanhSachVatLieu)
        {
            try
            {
                // Thằng nào trong DanhSachVatLieu mà không có trong CSDL thì thêm vào, còn có thì cập nhật lại dữ liệu
                foreach (CTHoaDonMuaHang mem in DanhSachVatLieu)
                {
                    var variable = GetObjectFromID(mem.MaCTHDMH.Trim());
                    if (variable == null) // Không có thì insert
                    {
                        DB.CTHoaDonMuaHangs.InsertOnSubmit(mem);
                        DB.SubmitChanges();
                    }
                    else // Còn có rồi thì update lại
                        variable = mem;
                }

                // Thằng nào trong CSDL mà không có trong DanhSachVatLieu thì xóa trong CSDL
                foreach (CTHoaDonMuaHang mem in DB.CTHoaDonMuaHangs)
                {
                    if (mem.Live.Trim() == "False")
                        continue;

                    bool IsHaveInDanhSach = false;
                    foreach (CTHoaDonMuaHang memDS in DanhSachVatLieu)
                        if (mem.MaHDMH.Trim() != memDS.MaHDMH.Trim() || mem.MaCTHDMH.Trim() == memDS.MaCTHDMH.Trim())
                        {
                            IsHaveInDanhSach = true;
                            break;
                        }

                    if (!IsHaveInDanhSach)
                    {
                        mem.Live = "False";
                        DB.SubmitChanges();
                    }
                }

                return "Success";
            }
            catch
            {
                return "Error";
            }
        }

        public string DeleteFromMaHDMH(string MaHDMH)
        {
            try
            {
                foreach (CTHoaDonMuaHang mem in DB.CTHoaDonMuaHangs)
                    if (mem.MaHDMH.Trim() == MaHDMH && mem.Live.Trim() == "True")
                        mem.Live = "False";

                DB.SubmitChanges();

                return "Success";
            }
            catch
            {
                return "Error";
            }
        }

        public string DeleteFromMaCTHDMH(string MaCTHDMH)
        {
            try
            {
                var row = GetObjectFromID(MaCTHDMH);

                if (row == null)
                    return "Error";

                row.Live = "False";

                DB.SubmitChanges();

                return "Success";
            }
            catch
            {
                return "Error";
            }
        }

        public string NewMaCTHDMH()
        {
            List<string> danhsach = new List<string>();
            foreach (QLVLXD.DLL.CTHoaDonMuaHang var in DB.CTHoaDonMuaHangs)
                danhsach.Add(var.MaCTHDMH.Trim());
            return NewID(danhsach, "CTHDMH");
            // Hàm NewID là hàm trả về mã một đối tượng mà chưa có trong danh sách mã. 
            // Ví dụ:
            // + Danh sách mã là VL001, VL003 thì hàm nãy sẽ trả về VL002
            // + Danh sách mã là VL001, VL002, VL003 thì hàm nãy sẽ trả về VL004        
        }
        public string NewMaCTHDMH(List<string> DS_Ma)
        {
            return NewID(DS_Ma, "CTHDMH");
            // Hàm NewID là hàm trả về mã một đối tượng mà chưa có trong danh sách mã. 
            // Ví dụ:
            // + Danh sách mã là VL001, VL003 thì hàm nãy sẽ trả về VL002
            // + Danh sách mã là VL001, VL002, VL003 thì hàm nãy sẽ trả về VL004        
        }

        public List<QLVLXD.DLL.CTHoaDonMuaHang> GetList()
        {
            List<QLVLXD.DLL.CTHoaDonMuaHang> list = new List<DLL.CTHoaDonMuaHang>();
            foreach (QLVLXD.DLL.CTHoaDonMuaHang var in DB.CTHoaDonMuaHangs)
                if (var.Live.Trim() == "True")
                    list.Add(var);

            return list;
        }

        public List<QLVLXD.DLL.CTHoaDonMuaHang> GetListAll()
        {
            List<QLVLXD.DLL.CTHoaDonMuaHang> list = new List<DLL.CTHoaDonMuaHang>();
            foreach (QLVLXD.DLL.CTHoaDonMuaHang var in DB.CTHoaDonMuaHangs)
                list.Add(var);

            return list;
        }

        public List<QLVLXD.DLL.CTHoaDonMuaHang> GetListCTHoaDonMuaHang(string MaHDMH)
        {
            try
            {                
                List<QLVLXD.DLL.CTHoaDonMuaHang> list = new List<DLL.CTHoaDonMuaHang>();
                foreach (QLVLXD.DLL.CTHoaDonMuaHang var in DB.CTHoaDonMuaHangs)
                    if (var.Live.Trim() == "True" && var.MaHDMH.Trim() == MaHDMH.Trim())
                        list.Add(var);

                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public QLVLXD.DLL.CTHoaDonMuaHang GetObjectFromID(string MaCTHDMH)
        {
            var Return = DB.CTHoaDonMuaHangs.FirstOrDefault(data => data.MaCTHDMH.Trim() == MaCTHDMH);
            if (Return != null && Return.Live.Trim() == "True")
                return Return;
            else
                return null;
        }

    }
}
