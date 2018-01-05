using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVLXD.DLL;
using QLVLXD.BLL;
using System.Windows.Forms;

namespace QLVLXD.BLL
{
    class BLL_TinhTrangVatLieu : BLL
    {
        public List<QLVLXD.DLL.TinhTrangVatLieu> GetList()
        {
            try
            {
                List<QLVLXD.DLL.TinhTrangVatLieu> list = new List<DLL.TinhTrangVatLieu>();
                foreach (QLVLXD.DLL.TinhTrangVatLieu var in DB.TinhTrangVatLieus)
                    if (VarLive(var.Live))
                        list.Add(var);

                return list;
            }
            catch
            {
                return null;
            }
        }

        public QLVLXD.DLL.TinhTrangVatLieu GetObjectFromID(string MaTinhTrangVL)
        {
            try
            {
                var Return = DB.TinhTrangVatLieus.FirstOrDefault(data => data.MaTinhTrangVL.Trim() == MaTinhTrangVL);
                if (Return != null && VarLive(Return.Live))
                    return Return;
                else
                    return null;
            }
            catch
            {

                return null;
            }
        }

        public string GetTenTinhTrangFromMaTinhTrang(string MaTinhTrangVL)
        {
            try
            {                
                var Return = DB.TinhTrangVatLieus.FirstOrDefault(data => data.MaTinhTrangVL.Trim() == MaTinhTrangVL.Trim());
                if (Return != null && VarLive(Return.Live))
                    return Return.NoiDungTinhTrangVL.Trim();
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public string GetMaTTFromTenTT(string TenTT)
        {
            try
            {
                var Return = DB.TinhTrangVatLieus.FirstOrDefault(data => data.NoiDungTinhTrangVL.Trim() == TenTT.Trim());
                if (Return != null && VarLive(Return.Live))
                    return Return.MaTinhTrangVL.Trim();
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public List<string> GetDanhSachTinhTrangVatLieu()
        {
            try
            {
                List<string> list = new List<string>();
                foreach (QLVLXD.DLL.TinhTrangVatLieu var in DB.TinhTrangVatLieus)
                    if (VarLive(var.Live))
                        list.Add(var.NoiDungTinhTrangVL.Trim());

                return list;
            }
            catch
            {

                return null;
            }
        }

        public bool ExistNoiDungTinhTrangVatLieu(string value)
        {
            try
            {
                bool co = false;
                foreach (QLVLXD.DLL.TinhTrangVatLieu var in DB.TinhTrangVatLieus)
                    if (VarLive(var.Live) && var.NoiDungTinhTrangVL.Trim() == value.Trim())
                    {
                        co = true;
                        break;
                    }
                return co;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public BLLResult Insert(string value)
        {
            try
            {
                if (ExistNoiDungTinhTrangVatLieu(value)) // Đã tồn tại
                    return new BLLResult("Tình trạng vật liệu này đã tồn tại!");
                else // K tồn tại thì thêm vào
                {
                    TinhTrangVatLieu dvt = new TinhTrangVatLieu();
                    dvt.MaTinhTrangVL = NewMaTinhTrangVL();
                    if (dvt.MaTinhTrangVL == null)
                        return new BLLResult(7000418);
                    dvt.NoiDungTinhTrangVL = value.Trim();
                    dvt.Live = "True";

                    DB.TinhTrangVatLieus.InsertOnSubmit(dvt);
                    DB.SubmitChanges();
                    return new BLLResult((int)BLLResultType.S_ADD);
                }
            }
            catch (Exception)
            {
                return new BLLResult(7000541);
            }
        }

        public BLLResult Delete(string MaTinhTrangVL, bool IsSure)
        {
            try
            {
                var row = GetObjectFromID(MaTinhTrangVL);
                { // Kiểm tra tình trạng này có xài trong CSDL hay không:
                    var listbh = (new BLL_CTHoaDonBanHang()).GetList();
                    foreach (CTHoaDonBanHang vari in listbh)
                        if (vari.TinhTrangVL.Trim() == row.NoiDungTinhTrangVL.Trim())
                            return new BLLResult("Tình trạng này có sử dụng các trong các hóa đơn nên không xóa được!");                   
                    var vl = (new BLL_VatLieu()).GetList();
                    foreach (DLL.VatLieu vari in vl)
                        if (vari.MaTinhTrang.Trim() == row.MaTinhTrangVL.Trim())
                            return new BLLResult("Tình trạng này có sử dụng các trong các hóa đơn nên không xóa được!");
                }
                if (row != null)
                {
                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa tình trạng \"" + row.NoiDungTinhTrangVL.Trim() + "\" ?", "Chú ý", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                            return new BLLResult((int)BLLResultType.NOT_DELETE);
                    }
                    row.Live = "False";
                    DB.SubmitChanges();
                    return new BLLResult((int)BLLResultType.S_DELETE);
                }
                return new BLLResult((int)BLLResultType.NOT_EXIST);
            }
            catch
            {
                return new BLLResult(70008521);
            }
        }

        public string NewMaTinhTrangVL()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.TinhTrangVatLieu var in DB.TinhTrangVatLieus)
                    danhsach.Add(var.MaTinhTrangVL.Trim());
                return NewID(danhsach, "TTVL");
            }
            catch
            {
                return null;
            }
        }
    }
}
