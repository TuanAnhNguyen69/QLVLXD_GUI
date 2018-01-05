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
    class BLL_KhuyenMai : BLL
    {
        public List<QLVLXD.DLL.KhuyenMai> GetList()
        {
            try
            {
                List<QLVLXD.DLL.KhuyenMai> list = new List<DLL.KhuyenMai>();
                foreach (QLVLXD.DLL.KhuyenMai var in DB.KhuyenMais)
                    if (VarLive(var.Live))
                        list.Add(var);

                return list;
            }
            catch
            {
                return null;
            }
        }

        public QLVLXD.DLL.KhuyenMai GetObjectFromID(string MaKM)
        {
            try
            {
                var Return = DB.KhuyenMais.FirstOrDefault(data => data.MaKM.Trim() == MaKM.Trim());
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

        public QLVLXD.DLL.KhuyenMai GetObjectFromMaVL(string MaVL)
        {
            try
            {                
                var Return = DB.KhuyenMais.FirstOrDefault(data => data.MaVL.Trim() == MaVL.Trim());
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

        public bool ExistNoiDungKhuyenMai(string TenKM, string MaVL, decimal SoLuongToiThieu, decimal SoLuongKM, decimal TienKM, string DonViTinh)
        {
            try
            {
                bool co = false;
                foreach (QLVLXD.DLL.KhuyenMai var in DB.KhuyenMais)
                    if (VarLive(var.Live)
                        && var.TenKM.Trim() == TenKM.Trim()
                        && var.MaVL.Trim() == MaVL.Trim()
                        && var.DonViTinh.Trim() == DonViTinh.Trim()
                        && var.SoLuongKM == SoLuongKM
                        && var.SoLuongToiThieu == SoLuongToiThieu)
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

        public BLLResult Insert(string TenKM, string MaVL, decimal SoLuongToiThieu, decimal SoLuongKM, decimal TienKM, string DonViTinh)
        {
            try
            {
                if (ExistNoiDungKhuyenMai(TenKM, MaVL, SoLuongToiThieu, SoLuongKM, TienKM, DonViTinh)) // Đã tồn tại
                    return new BLLResult("Khuyến mãi này đã tồn tại!");
                else // K tồn tại thì thêm vào
                {
                    KhuyenMai tmp = new KhuyenMai();
                    tmp.MaKM = NewMaKM();
                    if (tmp.MaKM == null)
                        return new BLLResult(8000418);
                    tmp.TenKM = TenKM;
                    tmp.MaVL = MaVL;
                    tmp.SoLuongToiThieu = SoLuongToiThieu;
                    tmp.SoLuongKM = SoLuongKM;
                    tmp.TienKM = TienKM;
                    tmp.DonViTinh = DonViTinh;
                    tmp.Live = "True";
                    DB.KhuyenMais.InsertOnSubmit(tmp);
                    DB.SubmitChanges();
                    return new BLLResult((int)BLLResultType.S_ADD);
                }
            }
            catch (Exception)
            {
                return new BLLResult(8000541);
            }
        }

        public BLLResult Update(string TenKM, string MaVL, decimal SoLuongToiThieu, decimal SoLuongKM, decimal TienKM, string DonViTinh)
        {
            try
            {
                KhuyenMai tmp = GetObjectFromMaVL(MaVL);
                if (tmp == null)
                    return new BLLResult((int)BLLResultType.NOT_EXIST);
                tmp.TenKM = TenKM;
                tmp.SoLuongToiThieu = SoLuongToiThieu;
                tmp.SoLuongKM = SoLuongKM;
                tmp.TienKM = TienKM;
                tmp.DonViTinh = DonViTinh;
                tmp.Live = "True";
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_UPDATE);
            }
            catch (Exception)
            {
                return new BLLResult(8000541);
            }
        }

        public BLLResult Delete(string MaKM, bool IsSure)
        {
            try
            {
                var row = GetObjectFromID(MaKM);
                if (row != null)
                {
                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa khuyến mãi?", "Chú ý", MessageBoxButtons.YesNo,
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
                return new BLLResult(80008521);
            }
        }

        public string MakeTenKM(string MaKM)
        {
            if (MaKM == null || MaKM == "")
                return "Không có";

            var tmp = GetObjectFromID(MaKM.Trim());
            if (tmp == null)
                return "Không có";
            if (tmp.TenKM.Trim() == "<Mặc định>" || tmp.TenKM == null)
            {
                string tenvm = "Mua " + tmp.SoLuongToiThieu.ToString() + " " + tmp.DonViTinh.Trim() + " Tặng ";
                if ((decimal)tmp.TienKM == 0)
                    tenvm += tmp.SoLuongKM.ToString() + " " + tmp.DonViTinh.Trim();
                else
                    tenvm += tmp.TienKM.ToString() + " VND";
                return tenvm;
            }
            else
                return tmp.TenKM.Trim();
        }

        public string NewMaKM()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.KhuyenMai var in DB.KhuyenMais)
                    danhsach.Add(var.MaKM.Trim());
                return NewID(danhsach, "KM");
            }
            catch
            {
                return null;
            }
        }
    }
}
