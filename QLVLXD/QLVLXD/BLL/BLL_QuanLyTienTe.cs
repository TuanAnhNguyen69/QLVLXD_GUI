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
    class BLL_QuanLyTienTe : BLL
    {
        public List<QLVLXD.DLL.QuanLyTienTe> GetList()
        {
            try
            {
                List<QLVLXD.DLL.QuanLyTienTe> list = new List<DLL.QuanLyTienTe>();
                foreach (QLVLXD.DLL.QuanLyTienTe var in DB.QuanLyTienTes)
                    if (VarLive(var.Live))
                        list.Add(var);

                return list;
            }
            catch
            {
                return null;
            }
        }

        public QLVLXD.DLL.QuanLyTienTe GetObjectFromID(string MaTT)
        {
            try
            {
                var Return = DB.QuanLyTienTes.FirstOrDefault(data => data.MaTT.Trim() == MaTT);
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

        public QLVLXD.DLL.QuanLyTienTe GetObjectFromTenTienTe(string TenTT)
        {
            try
            {
                var Return = DB.QuanLyTienTes.FirstOrDefault(data => data.TenTT.Trim() == TenTT);
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

        public List<string> GetDanhSachTienTe()
        {
            try
            {
                List<string> list = new List<string>();
                foreach (QLVLXD.DLL.QuanLyTienTe var in DB.QuanLyTienTes)
                    if (VarLive(var.Live))
                        list.Add(var.TenTT.Trim());

                return list;
            }
            catch
            {
                return null;
            }
        }

        public bool ExistTenTienTe(string value)
        {
            try
            {
                bool co = false;
                foreach (QLVLXD.DLL.QuanLyTienTe var in DB.QuanLyTienTes)
                    if (VarLive(var.Live) && var.TenTT.Trim() == value.Trim())
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

        public BLLResult Insert(string TenTT, int TriGia)
        {
            try
            {  
                if (ExistTenTienTe(TenTT)) // Đã tồn tại
                    return new BLLResult("Tiền tệ này đã tồn tại!");
                else // K tồn tại thì thêm vào
                {
                    QuanLyTienTe dvt = new QuanLyTienTe();
                    dvt.MaTT = NewMaTT();
                    if (dvt.MaTT == null)
                        return new BLLResult(6000418);
                    dvt.TenTT = TenTT.Trim();
                    dvt.TriGiaVND = TriGia;
                    dvt.Live = "True";

                    DB.QuanLyTienTes.InsertOnSubmit(dvt);
                    DB.SubmitChanges();
                    return new BLLResult((int)BLLResultType.S_ADD);
                }
            }
            catch (Exception)
            {
                return new BLLResult(6000541);
            }
        }

        public BLLResult Delete(string MaTT, bool IsSure)
        {
            try
            {
                var row = GetObjectFromID(MaTT);
                if (row != null)
                {
                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa tiền tệ " + row.TenTT.Trim() + " ?", "Chú ý", MessageBoxButtons.YesNo,
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
                return new BLLResult(60008521);
            }
        }

        public string NewMaTT()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.QuanLyTienTe var in DB.QuanLyTienTes)
                    danhsach.Add(var.MaTT.Trim());
                return NewID(danhsach, "TT");
            }
            catch
            {
                return null;
            }
        }

        // Chú ý: Ko có Tên tiền tệ truyền vào thì trả về giá trị cũ
        public decimal ToVND(string TenTT, decimal Value)
        {
            if (TenTT.Trim() == "VND")
                return Value;
            else
            {
                var tt = GetObjectFromTenTienTe(TenTT);
                if (tt == null)
                    return Value;
                else
                    return Value * (decimal)tt.TriGiaVND;
            }               
        }
    }
}
