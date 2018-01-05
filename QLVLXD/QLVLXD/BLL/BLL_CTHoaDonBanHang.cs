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
    class BLL_CTHoaDonBanHang : BLL
    {
        public BLLResult CheckData(bool IsInsert, string MaCTHDBH, string MaHDBH, string TenVL, decimal SoLuongMua, string DonviTinh, decimal TongTien, string TinhTrangVL, string TenNCC, decimal SoLuongKM, decimal TongSL, decimal GiaLe, decimal GiaSi, decimal SoLuongBanSi, decimal TienKM, decimal TienKMKH, string GhiChu)
        {
            try
            {
                if (IsInsert && GetObjectFromID(MaCTHDBH) != null)
                {
                    return new BLLResult("Mã chi tiết hóa đơn đã tồn tại");
                }

                return new BLLResult((int)BLLResultType.SUCCESS);
            }
            catch (Exception)
            {
                return new BLLResult(12000156);
            }
        }

        public BLLResult CheckData(bool IsInsert, CTHoaDonBanHang CT)
        {
            try
            {
                if (IsInsert && GetObjectFromID(CT.MaCTHDBH.Trim()) != null)
                {
                    return new BLLResult("Mã chi tiết hóa đơn đã tồn tại");
                }

                return new BLLResult((int)BLLResultType.SUCCESS);
            }
            catch (Exception)
            {
                return new BLLResult(12000852);
            }
        }

        public BLLResult Insert(string MaCTHDBH, string MaHDBH, string TenVL, decimal SoLuongMua, string DonviTinh, decimal TongTien, string TinhTrangVL, string TenNCC, decimal SoLuongKM, decimal TongSL, decimal GiaLe, decimal GiaSi, decimal SoLuongBanSi, decimal TienKM, decimal TienKMKH, string GhiChu)
        {
            try
            {
                QLVLXD.DLL.CTHoaDonBanHang ct = new QLVLXD.DLL.CTHoaDonBanHang();
                ct.TenVL = TenVL;
                ct.MaCTHDBH = MaCTHDBH;
                ct.MaHDBH = MaHDBH;
                ct.TenNCC = TenNCC;
                ct.SoLuongMua = SoLuongMua;
                ct.DonViTinh = DonviTinh;
                ct.GiaLe = GiaLe;
                ct.GiaSi = GiaSi;
                ct.SoLuongDeBanSi = SoLuongBanSi;
                ct.TinhTrangVL = TinhTrangVL;
                ct.TongTien = TongTien;
                ct.SoLuongKM = SoLuongKM;
                ct.GhiChu = GhiChu;
                ct.TongSL = TongSL;
                ct.TienKMKH = TienKMKH;
                ct.TienKM = TienKM;
                ct.Live = "True";
                DB.CTHoaDonBanHangs.InsertOnSubmit(ct);
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_ADD);
            }
            catch
            {
                return new BLLResult(12000741);
            }
        }

        public BLLResult Insert(DLL.CTHoaDonBanHang ct)
        {
            try
            {
                DB.CTHoaDonBanHangs.InsertOnSubmit(ct);
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_ADD);
            }
            catch
            {
                return new BLLResult(12000771);
            }
        }

        public BLLResult Delete(string MaCTHDBH, bool IsSure)
        {
            try
            {
                var row = GetObjectFromID(MaCTHDBH);
                if (row != null)
                {
                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa chi tiết hóa đơn \"" + row.TenVL.Trim() + "\" ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
                return new BLLResult(100008521);
            }
        }

        public BLLResult Update(string MaCTHDBH, string MaHDBH, string TenVL, decimal SoLuongMua, string DonviTinh, decimal TongTien, string TinhTrangVL, string TenNCC, decimal SoLuongKM, decimal TongSL, decimal GiaLe, decimal GiaSi, decimal SoLuongBanSi, decimal TienKM, decimal TienKMKH, string GhiChu)
        {
            try
            {
                var old_data = GetObjectFromID(MaCTHDBH);
                old_data.TenVL = TenVL;
                old_data.MaHDBH = MaHDBH;
                old_data.TenNCC = TenNCC;
                old_data.SoLuongMua = SoLuongMua;
                old_data.DonViTinh = DonviTinh;
                old_data.GiaLe = GiaLe;
                old_data.GiaSi = GiaSi;
                old_data.SoLuongDeBanSi = SoLuongBanSi;
                old_data.TinhTrangVL = TinhTrangVL;
                old_data.TongTien = TongTien;
                old_data.SoLuongKM = SoLuongKM;
                old_data.GhiChu = GhiChu;
                old_data.TongSL = TongSL;
                old_data.TienKMKH = TienKMKH;
                old_data.TienKM = TienKM;
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_UPDATE);
            }
            catch
            {
                return new BLLResult(12000456);
            }
        }

        public string NewMaCTHDBH()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.CTHoaDonBanHang var in DB.CTHoaDonBanHangs)
                    danhsach.Add(var.MaCTHDBH.Trim());
                return NewID(danhsach, "CTHDBH");
            }
            catch (Exception)
            {
                return null;
            }
        }

        public string NewMaCTHDBH(List<CTHoaDonBanHang> ListOtherCTHDBH)
        {
            try
            {
                List<string> danhsach = new List<string>();
                List<CTHoaDonBanHang> listhd = new List<CTHoaDonBanHang>(ListOtherCTHDBH);
                listhd.AddRange(GetListAll());
                foreach (QLVLXD.DLL.CTHoaDonBanHang var in listhd)
                    danhsach.Add(var.MaCTHDBH.Trim());
                return NewID(danhsach, "CTHDBH");
            }
            catch (Exception)
            {
                return null;
            }
        }

        DLL.CTHoaDonBanHang RealCTHDBH(DLL.CTHoaDonBanHang Orginal)
        {
            DLL.CTHoaDonBanHang neww = new CTHoaDonBanHang();
            neww = Orginal;
            var vl = (new BLL_VatLieu()).GetObjectFromTenVL(neww.TenVL.Trim());
            if (vl != null)
            {
                if (neww.DonViTinh.Trim() != vl.DVT_Goc.Trim()) // CTHD này là đơn vị tính phụ
                {
                    var dvt = (new BLL_DonViTinhVatLieu()).GetObject(vl.MaVL.Trim(), neww.DonViTinh.Trim());
                    if (dvt != null)
                    {
                        neww.SoLuongMua = (decimal)neww.SoLuongMua / (decimal)dvt.TiLe;
                        neww.SoLuongKM = (decimal)neww.SoLuongKM / (decimal)dvt.TiLe;
                        neww.TongSL = (decimal)neww.TongSL / (decimal)dvt.TiLe;
                    }
                }
            }
            return neww;
        }

        public List<QLVLXD.DLL.CTHoaDonBanHang> GetList()
        {
            try
            {
                List<QLVLXD.DLL.CTHoaDonBanHang> list = new List<DLL.CTHoaDonBanHang>();
                foreach (QLVLXD.DLL.CTHoaDonBanHang var in DB.CTHoaDonBanHangs)
                    if (VarLive(var.Live))
                        list.Add(RealCTHDBH(var));

                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<QLVLXD.DLL.CTHoaDonBanHang> GetListAll()
        {
            try
            {
                List<QLVLXD.DLL.CTHoaDonBanHang> list = new List<DLL.CTHoaDonBanHang>();
                foreach (QLVLXD.DLL.CTHoaDonBanHang var in DB.CTHoaDonBanHangs)
                    list.Add(RealCTHDBH(var));

                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public QLVLXD.DLL.CTHoaDonBanHang GetObjectFromID(string MaCTHDBH)
        {
            try
            {
                var Return = DB.CTHoaDonBanHangs.FirstOrDefault(data => data.MaCTHDBH.Trim() == MaCTHDBH.Trim());
                if (Return != null && VarLive(Return.Live))
                    return RealCTHDBH(Return);
                else
                    return null;
            }
            catch
            {
                return null;
            }
        }

        public List<QLVLXD.DLL.CTHoaDonBanHang> GetListFromHDBH(string MaHDBH)
        {
            try
            {
                List<QLVLXD.DLL.CTHoaDonBanHang> list = new List<DLL.CTHoaDonBanHang>();
                foreach (QLVLXD.DLL.CTHoaDonBanHang var in DB.CTHoaDonBanHangs)
                    if (VarLive(var.Live) && var.MaHDBH.Trim() == MaHDBH.Trim())
                        list.Add(RealCTHDBH(var));

                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public int GetTongTienHDBH(string MaHDBH)
        {
            try
            {
                var ds = GetListFromHDBH(MaHDBH);
                int TongTien = 0;
                foreach (DLL.CTHoaDonBanHang var in ds)
                    TongTien += (int)var.TongTien;
                return TongTien;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }
}
