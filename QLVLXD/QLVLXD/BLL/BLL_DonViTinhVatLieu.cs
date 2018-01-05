using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLVLXD.DLL;
using System.Windows.Forms;

namespace QLVLXD.BLL
{
    class BLL_DonViTinhVatLieu : BLL
    {
        BLL_QuanLyDonViTinh _QuanLyDonViTinh = new BLL_QuanLyDonViTinh();

        public List<QLVLXD.DLL.DonViTinhVatLieu> GetList()
        {
            try
            {
                List<QLVLXD.DLL.DonViTinhVatLieu> list = new List<DLL.DonViTinhVatLieu>();
                foreach (QLVLXD.DLL.DonViTinhVatLieu var in DB.DonViTinhVatLieus)
                    if (VarLive(var.Live))
                        list.Add(var);

                return list;
            }
            catch
            {
                return null;
            }
        }

        public QLVLXD.DLL.DonViTinhVatLieu GetObjectFromID(string MaDVTVL)
        {
            try
            {
                var Return = DB.DonViTinhVatLieus.FirstOrDefault(data => data.DVTVL.Trim() == MaDVTVL.Trim());
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

        public List<QLVLXD.DLL.DonViTinhVatLieu> GetDanhSachDonViTinhVatLieu(string MaVL)
        {
            try
            {
                List<QLVLXD.DLL.DonViTinhVatLieu> list = new List<QLVLXD.DLL.DonViTinhVatLieu>();
                foreach (QLVLXD.DLL.DonViTinhVatLieu var in DB.DonViTinhVatLieus)
                    if (VarLive(var.Live) && var.MaVL.Trim() == MaVL.Trim())
                        list.Add(var);

                return list;
            }
            catch
            {
                return null;
            }
        }

        public bool ExistDonViTinhPhu(string MaVL, string TenDVT)
        {
            try
            {
                string MaDVT = _QuanLyDonViTinh.GetMaDVTFromTenDVT(TenDVT.Trim());

                List<QLVLXD.DLL.DonViTinhVatLieu> listdvt = GetDanhSachDonViTinhVatLieu(MaVL);
                foreach (QLVLXD.DLL.DonViTinhVatLieu var in listdvt)
                    if (var.MaVL.Trim() == MaVL.Trim() && var.MaDVT.Trim() == MaDVT.Trim())
                    {
                        return true;
                    }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public string NewMaDVTTT()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.DonViTinhVatLieu var in DB.DonViTinhVatLieus)
                    danhsach.Add(var.DVTVL.Trim());
                return NewID(danhsach, "DVTVL");
            }
            catch
            {
                return null;
            }
        }

        public BLLResult Insert(string MaVL, string TenDVT, decimal TiLe)
        {
            try
            {
                if (ExistDonViTinhPhu(MaVL.Trim(), TenDVT.Trim())) // Đã tồn tại
                    return new BLLResult("Đơn vị tính đã tồn tại!");
                else // K tồn tại thì thêm vào
                {
                    DonViTinhVatLieu dvt = new DonViTinhVatLieu();
                    dvt.DVTVL = NewMaDVTTT();
                    dvt.MaDVT = _QuanLyDonViTinh.GetMaDVTFromTenDVT(TenDVT);
                    dvt.MaVL = MaVL.Trim();
                    dvt.TiLe = TiLe;
                    dvt.Live = "True";
                    DB.DonViTinhVatLieus.InsertOnSubmit(dvt);
                    DB.SubmitChanges();
                    return new BLLResult((int)BLLResultType.S_ADD);
                }
            }
            catch (Exception)
            {
                return new BLLResult(9000521);
            }
        }

        public BLLResult Insert(string MaVL, string TenDVT1, decimal TiLe1, string TenDVT2, decimal TiLe2)
        {
            try
            {
                BLLResult res;
                if (TenDVT1.Length > 1)
                {
                    res = Insert(MaVL, TenDVT1, TiLe1);
                    if (res._Code != (int)BLLResultType.S_ADD)
                        return new BLLResult("Lỗi thêm đơn vị tính 2");
                }

                if (TenDVT2.Length > 1)
                {
                    res = Insert(MaVL, TenDVT2, TiLe2);
                    if (res._Code != (int)BLLResultType.S_ADD)
                        return new BLLResult("Lỗi thêm đơn vị tính 3");
                }

                return new BLLResult((int)BLLResultType.S_ADD);
            }
            catch (Exception)
            {
                return new BLLResult(9000456);
            }
        }

        public BLLResult Update(string MaVL, string TenDVT1, decimal TiLe1, string TenDVT2, decimal TiLe2)
        {
            try
            {
                List<DonViTinhVatLieu> listdvt = GetDanhSachDonViTinhVatLieu(MaVL);
                BLLResult res = new BLLResult((int)BLLResultType.S_ADD);

                if (listdvt.Count == 0) // Vật liệu chưa có dvt phụ thì thêm mới
                {
                    res = Insert(MaVL, TenDVT1, TiLe1, TenDVT2, TiLe2);
                    if (res._Code == (int)BLLResultType.S_ADD)
                        return new BLLResult((int)BLLResultType.S_UPDATE);
                    else
                        return res;                    
                }
                else if (listdvt.Count == 1) // Có 1 rồi thì update 1, thêm 1
                {
                    if (listdvt[0].MaDVT.Trim() == _QuanLyDonViTinh.GetMaDVTFromTenDVT(TenDVT1))
                    {
                        listdvt[0].TiLe = TiLe1;

                        if (TenDVT2.Length > 1)
                            res = Insert(MaVL, TenDVT2, TiLe2);

                        if (res._Code == (int)BLLResultType.S_ADD)
                        {
                            DB.SubmitChanges();
                            return new BLLResult((int)BLLResultType.S_UPDATE);
                        }
                        else
                            return new BLLResult("Lỗi cập nhật đơn vị tính 3");
                    }
                    else if (listdvt[0].MaDVT.Trim() == _QuanLyDonViTinh.GetMaDVTFromTenDVT(TenDVT2))
                    {
                        listdvt[0].TiLe = TiLe2;

                        if (TenDVT1.Length > 1)
                            res = Insert(MaVL, TenDVT1, TiLe1);

                        if (res._Code == (int)BLLResultType.S_ADD)
                        {
                            DB.SubmitChanges();
                            return new BLLResult((int)BLLResultType.S_UPDATE);
                        }
                        else
                            return new BLLResult("Lỗi cập nhật đơn vị tính 2");
                    }
                    else
                    {
                        if (TenDVT1.Length > 1)
                        {
                            listdvt[0].MaDVT = _QuanLyDonViTinh.GetMaDVTFromTenDVT(TenDVT1);
                            listdvt[0].TiLe = TiLe1;
                        }
                        else if (Delete(listdvt[0].MaVL.Trim(), _QuanLyDonViTinh.GetTenDVTFromMaDVT(listdvt[0].MaDVT.Trim()), true).IsErrorException())
                            return new BLLResult("Lỗi xóa đơn vị tính 2");

                        if (TenDVT2.Length > 1)
                            res = Insert(MaVL, TenDVT2, TiLe2);

                        if (res._Code == (int)BLLResultType.S_ADD)
                        {
                            DB.SubmitChanges();
                            return new BLLResult((int)BLLResultType.S_UPDATE);
                        }
                        else
                            return new BLLResult("Lỗi cập nhật đơn vị tính 3");
                    }
                }
                else if (listdvt.Count == 2) // Đã có 2 dvt
                {
                    if (TenDVT1.Length > 1)
                    {
                        listdvt[0].MaDVT = _QuanLyDonViTinh.GetMaDVTFromTenDVT(TenDVT1);
                        listdvt[0].TiLe = TiLe1;
                    }
                    else
                    {
                        if (Delete(listdvt[0].MaVL.Trim(), _QuanLyDonViTinh.GetTenDVTFromMaDVT(listdvt[0].MaDVT.Trim()), true).IsErrorException())
                            return new BLLResult("Lỗi xóa đơn vị tính 2");
                    }

                    if (TenDVT2.Length > 1)
                    {
                        listdvt[1].MaDVT = _QuanLyDonViTinh.GetMaDVTFromTenDVT(TenDVT2);
                        listdvt[1].TiLe = TiLe2;
                    }
                    else
                    {
                        if (Delete(listdvt[1].MaVL.Trim(), _QuanLyDonViTinh.GetTenDVTFromMaDVT(listdvt[1].MaDVT.Trim()), true).IsErrorException())
                            return new BLLResult("Lỗi xóa đơn vị tính 3");
                    }

                    DB.SubmitChanges();
                }

                return new BLLResult((int)BLLResultType.S_UPDATE);
            }
            catch (Exception)
            {
                return new BLLResult(9000456);
            }
        }

        public QLVLXD.DLL.DonViTinhVatLieu GetObject(string MaVL, string TenDVT)
        {
            try
            {
                string MaDVT = _QuanLyDonViTinh.GetMaDVTFromTenDVT(TenDVT);

                foreach (QLVLXD.DLL.DonViTinhVatLieu var in DB.DonViTinhVatLieus)
                    if (VarLive(var.Live) && var.MaVL.Trim() == MaVL.Trim() && var.MaDVT.Trim() == MaDVT.Trim())
                        return var;

                return null;
            }
            catch
            {
                return null;
            }
        }

        public BLLResult Delete(string MaVL, string TenDVT, bool IsSure)
        {
            try
            {
                var row = GetObject(MaVL, TenDVT);
                if (row != null)
                {
                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa đơn vị tính này?", "Chú ý", MessageBoxButtons.YesNo,
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
                return new BLLResult(9000587);
            }
        }
    }
}
