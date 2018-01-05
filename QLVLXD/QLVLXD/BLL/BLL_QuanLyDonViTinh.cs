using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVLXD.DLL;
using System.Windows.Forms;

namespace QLVLXD.BLL
{
    class BLL_QuanLyDonViTinh : BLL
    {
        //BLL_CTHoaDonBanHang _CTHDBH = new BLL_CTHoaDonBanHang();
        //BLL_CTHoaDonMuaHang _CTHDMH = new BLL_CTHoaDonMuaHang();
        //BLL_DonViTinhVatLieu _DVTVL = new BLL_DonViTinhVatLieu();

        public List<QLVLXD.DLL.QuanLyDonViTinh> GetList()
        {
            try
            {
                List<QLVLXD.DLL.QuanLyDonViTinh> list = new List<DLL.QuanLyDonViTinh>();
                foreach (QLVLXD.DLL.QuanLyDonViTinh var in DB.QuanLyDonViTinhs)
                    if (VarLive(var.Live))
                        list.Add(var);

                return list;
            }
            catch
            {
                return null;
            }
        }

        public QLVLXD.DLL.QuanLyDonViTinh GetObjectFromID(string MaDVT)
        {
            try
            {
                var Return = DB.QuanLyDonViTinhs.FirstOrDefault(data => data.MaDVT.Trim() == MaDVT);
                if (Return != null && Return.Live.Trim() == "True")
                    return Return;
                else
                    return null;
            }
            catch
            {

                return null;
            }
        }

        public List<string> GetDanhSachDonViTinh()
        {
            try
            {
                List<string> list = new List<string>();
                foreach (QLVLXD.DLL.QuanLyDonViTinh var in DB.QuanLyDonViTinhs)
                    if (VarLive(var.Live))
                        list.Add(var.TenDVT.Trim());

                return list;
            }
            catch
            {

                return null;
            }
        }

        public string GetMaDVTFromTenDVT(string TenDVT)
        {
            try
            {
                var Return = DB.QuanLyDonViTinhs.FirstOrDefault(data => data.TenDVT.Trim() == TenDVT);
                if (Return != null && Return.Live.Trim() == "True")
                    return Return.MaDVT.Trim();
                else
                    return null;
            }
            catch
            {

                return null;
            }
        }

        public string GetTenDVTFromMaDVT(string MaDVT)
        {
            try
            {
                var Return = DB.QuanLyDonViTinhs.FirstOrDefault(data => data.MaDVT.Trim() == MaDVT);
                if (Return != null && Return.Live.Trim() == "True")
                    return Return.TenDVT.Trim();
                else
                    return null;
            }
            catch
            {

                return null;
            }
        }

        public BLLResult Insert(string TenDVT)
        {
            try
            {
                // Kiểm tra đã có DVT này hay chưa:
                bool co = false;
                foreach (QLVLXD.DLL.QuanLyDonViTinh var in DB.QuanLyDonViTinhs)
                    if (VarLive(var.Live) && var.TenDVT.Trim() == TenDVT.Trim())
                    {
                        co = true;
                        break;
                    }

                if (co) // Đã tồn tại
                    return new BLLResult("Đơn vị tính đã tồn tại!");
                else // K tồn tại thì thêm vào
                {
                    QuanLyDonViTinh dvt = new QuanLyDonViTinh();
                    dvt.MaDVT = NewMaDVT();
                    if (dvt.MaDVT == null)
                        throw new Exception();
                    dvt.TenDVT = TenDVT.Trim();
                    dvt.Live = "True";

                    DB.QuanLyDonViTinhs.InsertOnSubmit(dvt);
                    DB.SubmitChanges();
                    return new BLLResult((int)BLLResultType.S_ADD);
                }
            }
            catch (Exception)
            {
                return new BLLResult(500);
            }
        }

        public BLLResult Delete(string MaDVT, bool IsSure)
        {
            try
            {
                var row = GetObjectFromID(MaDVT);
                if (row != null)
                {
                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa đơn vị " + row.TenDVT.Trim() + " ?", "Chú ý", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                            return new BLLResult((int)BLLResultType.NOT_DELETE);
                    }
                    { // Kiểm tra dvt này có xài trong CSDL hay không:
                        var listbh = (new BLL_CTHoaDonBanHang()).GetList();
                        foreach (CTHoaDonBanHang vari in listbh)
                            if (vari.DonViTinh.Trim() == row.TenDVT.Trim())
                                return new BLLResult("Đơn vị tính này có sử dụng các trong các hóa đơn nên không xóa được!");
                        var listmh = (new BLL_CTHoaDonMuaHang()).GetList();
                        foreach (CTHoaDonMuaHang vari in listmh)
                            if (vari.DonViTinh.Trim() == row.TenDVT.Trim())
                                return new BLLResult("Đơn vị tính này có sử dụng các trong các hóa đơn nên không xóa được!");
                        var listdvtvl = (new BLL_DonViTinhVatLieu()).GetList();
                        foreach (DonViTinhVatLieu vari in listdvtvl)
                            if (vari.MaDVT.Trim() == row.MaDVT.Trim())
                                return new BLLResult("Đơn vị tính này có sử dụng các trong các hóa đơn nên không xóa được!");
                        var vl = (new BLL_VatLieu()).GetList();
                        foreach (DLL.VatLieu vari in vl)
                            if (vari.DVT_Goc.Trim() == row.TenDVT.Trim())
                                return new BLLResult("Đơn vị tính này có sử dụng các trong các hóa đơn nên không xóa được!");
                    }
                    row.Live = "False";
                    DB.SubmitChanges();
                    return new BLLResult((int)BLLResultType.S_DELETE);
                }
                return new BLLResult((int)BLLResultType.NOT_EXIST);
            }
            catch
            {
                return new BLLResult(60008521);
            }
        }

        public string NewMaDVT()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.QuanLyDonViTinh var in DB.QuanLyDonViTinhs)
                    danhsach.Add(var.MaDVT.Trim());
                return NewID(danhsach, "DVT");
            }
            catch
            {
                return null;
            }
        }
    }
}
