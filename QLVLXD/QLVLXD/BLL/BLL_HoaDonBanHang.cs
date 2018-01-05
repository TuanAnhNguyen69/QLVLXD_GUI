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
using QLVLXD.BLL;

namespace QLVLXD.BLL
{
    class BLL_HoaDonBanHang : BLL
    {
        BLL_CTHoaDonBanHang _BLL_CTHoaDonBanHang = new BLL_CTHoaDonBanHang();
        BLL_KhachHang _BLL_KhachHang = new BLL_KhachHang();
        BLL_LoaiKhachHang _LoaiKhachHang = new BLL_LoaiKhachHang();

        public BLLResult CheckData(bool IsInsert, string MaHDBH, DateTime NgayGiao, string MaNV, string MaKH, DateTime NgayLap, string GhiChu, string TrangThai)
        {
            // Mã HD
            if (IsInsert && GetObjectFromID(MaHDBH) != null)
            {
                return new BLLResult("Mã hóa đơn bán hàng đã tồn tại");
            }

            return new BLLResult((int)BLLResultType.SUCCESS);
        }

        public BLLResult Insert(string MaHDBH, DateTime NgayGiao, string MaNV, string MaKH, DateTime NgayLap, string GhiChu, string TrangThai)
        {
            try
            {
                QLVLXD.DLL.HoaDonBanHang hdbh = new QLVLXD.DLL.HoaDonBanHang();
                hdbh.MaHDBH = MaHDBH;
                hdbh.NgayBan = NgayGiao;
                hdbh.MaNV = MaNV;
                hdbh.MaKH = MaKH;
                hdbh.NgayLap = NgayLap;
                hdbh.TrangThai = TrangThai;
                hdbh.GhiChu = GhiChu;
                hdbh.Live = "True";
                DB.HoaDonBanHangs.InsertOnSubmit(hdbh);
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_ADD);
            }
            catch
            {
                return new BLLResult(11000852);
            }
        }

        public BLLResult Update(string MaHDBH, DateTime NgayGiao, string MaNV, string MaKH, DateTime NgayLap, string GhiChu, string TrangThai)
        {
            try
            {
                var old_data = GetObjectFromID(MaHDBH);
                old_data.NgayBan = NgayGiao;
                old_data.MaNV = MaNV;
                old_data.MaKH = MaKH;
                old_data.NgayLap = NgayLap;
                old_data.TrangThai = TrangThai;
                old_data.GhiChu = GhiChu;
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.S_UPDATE);
            }
            catch
            {
                return new BLLResult(11000456);
            }
        }

        public BLLResult Delete(string MaHDBH, bool IsSure)
        {
            try
            {
                MaHDBH = MaHDBH.Trim();
                var row = GetObjectFromID(MaHDBH);
                if (row != null)
                {
                    if (!IsSure)
                    {
                        DialogResult result = MessageBox.Show("Xóa hóa đơn này?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.No)
                            return new BLLResult((int)BLLResultType.NOT_DELETE);
                    }
                    {// Phần xóa các CT
                        var listct = (new BLL_CTHoaDonBanHang()).GetListFromHDBH(MaHDBH);
                        foreach (CTHoaDonBanHang vari in listct)
                            (new BLL_CTHoaDonBanHang()).Delete(vari.MaCTHDBH.Trim(), true);
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

        public BLLResult SetDaTinhKM(string MaHDBH)
        {
            try
            {
                var ob = GetObjectFromID(MaHDBH.Trim());
                if (ob == null)
                    throw new Exception();
                ob.GhiChu = "True";
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.SUCCESS);
            }
            catch
            {
                return new BLLResult(100008545);
            }
        }

        public List<QLVLXD.DLL.HoaDonBanHang> GetListHDBHChuaTinhKMFromKH(string MaKH)
        {
            try
            {
                List<QLVLXD.DLL.HoaDonBanHang> listret = new List<HoaDonBanHang>();
                var list = GetList();
                foreach (DLL.HoaDonBanHang var in list)
                    if ((var.GhiChu == null || var.GhiChu.Trim() == "False") && var.MaKH.Trim() == MaKH.Trim())
                        listret.Add(var);
                return listret;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<QLVLXD.DLL.HoaDonBanHang> GetListHDBHChuaTinhKMFromKH(string MaKH, string FromMaHDBH)
        {
            try
            {
                List<QLVLXD.DLL.HoaDonBanHang> listret = new List<HoaDonBanHang>();
                var list = GetList();
                for (int i = list.Count - 1; i >= 0; i--)
                {
                    if (FromMaHDBH == "" || list[i].MaHDBH.Trim() == FromMaHDBH) // Chọn nơi bắt đầu tính
                    {
                        if (FromMaHDBH != "") // Tính từ HD
                            i--;
                        for (int x = i; x >= 0; x--)
                        {
                            if (list[x].MaKH.Trim() == MaKH.Trim())
                            {
                                if (list[x].GhiChu == null || list[x].GhiChu.Trim() == "False")
                                    listret.Add(list[x]);
                                else 
                                    break;
                            }
                        }
                        break;
                    }
                }
                return listret;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public BLLResult SetListTinhKM(string MaKH)
        {
            try
            {
                List<QLVLXD.DLL.HoaDonBanHang> listret = GetListHDBHChuaTinhKMFromKH(MaKH.Trim());
                if (listret == null)
                    throw new Exception();
                foreach (DLL.HoaDonBanHang var in listret)
                {
                    if (SetDaTinhKM(var.MaHDBH.Trim())._Code != (int)BLLResultType.SUCCESS)
                        throw new Exception();
                }
                return new BLLResult((int)BLLResultType.SUCCESS);
            }
            catch (Exception)
            {
                return new BLLResult(10000666);
            }
        }

        public BLLResult SetTrangThai(string TenTrangThai, string MaHDBH)
        {
            try
            {
                var hd = GetObjectFromID(MaHDBH.Trim());
                if (hd == null)
                    throw new Exception();
                hd.TrangThai = TenTrangThai;
                DB.SubmitChanges();
                return new BLLResult((int)BLLResultType.SUCCESS);
            }
            catch (Exception)
            {
                return new BLLResult(10000999);
            }
        }

        public string NewMaHDBH()
        {
            try
            {
                List<string> danhsach = new List<string>();
                foreach (QLVLXD.DLL.HoaDonBanHang var in DB.HoaDonBanHangs)
                    danhsach.Add(var.MaHDBH.Trim());
                return NewID(danhsach, "HDBH");
            }
            catch (Exception)
            {

                return null;
            }
        }

        public int GetTienKMKH(long TongTienTruocKM, string MaKH, string MaHDBH)
        {
            var loaikh = _LoaiKhachHang.GetObjectFromID(_BLL_KhachHang.GetObjectFromID(MaKH.Trim()).KHTT.Trim());
            if (loaikh == null)
            {
                return 0;
            }
            if (loaikh.SoLanMuaToiThieu != null || loaikh.TriGiaHoaDonToiThieu != null) // KH ko phải loại thường
            {
                if (loaikh.SoLanMuaToiThieu != null) // KM dựa trên số lần mua của KH
                {
                    List<DLL.HoaDonBanHang> dshoadonchuatinhkm = GetListHDBHChuaTinhKMFromKH(MaKH.Trim(), MaHDBH);
                    if (dshoadonchuatinhkm.Count >= loaikh.SoLanMuaToiThieu - 1) // Số hóa đơn chưa tính KM đủ để tính KM
                    {
                        if (MaHDBH == "") // K tính lần mới nhất (trước lập bán hàng)
                        {
                            if (TongTienTruocKM < loaikh.TriGiaToiThieuMoiLanMua)
                                return 0;
                        }

                        foreach (DLL.HoaDonBanHang var in dshoadonchuatinhkm)
                            if (_BLL_CTHoaDonBanHang.GetTongTienHDBH(var.MaHDBH.Trim()) < loaikh.TriGiaToiThieuMoiLanMua) // Có 1 hóa đơn k thỏa đk thì xác định
                            {
                                return 0;
                            }

                        // Tính KM
                        return -1 * (int)(TongTienTruocKM * (decimal)loaikh.PhanTramGiamLanMuaCuoi / 100);
                    }

                }
                else // KM dựa trên Trị giá hóa đơn mua
                {
                    if (TongTienTruocKM >= loaikh.TriGiaHoaDonToiThieu) // Thỏa điều kiện
                    {
                        return (int)(TongTienTruocKM * (decimal)loaikh.PhanTramGiam / 100);
                    }
                }
            }
            return 0;
        }

        public string GetHanGiao()
        {
            try
            {
                string name = "";
                var list = GetList();
                foreach (DLL.HoaDonBanHang vari in list)
                    if (vari.TrangThai.Trim() == "Chưa Giao" && vari.NgayBan.ToShortDateString() == DateTime.Today.ToShortDateString())
                        name = name + (new BLL_KhachHang()).GetObjectFromID(vari.MaKH.Trim()).TenKH.Trim() + ", ";
                if (name == "")
                    return null;
                else
                {
                    name = name.Substring(0, name.Length - 2);
                    return "Hôm nay là ngày giao hàng của các khách hàng:" + name + " (Nhấp vào để thiết lập trạng thái cho các hóa đơn này)";
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<QLVLXD.DLL.HoaDonBanHang> GetList()
        {
            try
            {
                List<QLVLXD.DLL.HoaDonBanHang> list = new List<DLL.HoaDonBanHang>();
                foreach (QLVLXD.DLL.HoaDonBanHang var in DB.HoaDonBanHangs)
                    if (VarLive(var.Live))
                        list.Add(var);

                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<QLVLXD.DLL.HoaDonBanHang> GetListAll()
        {
            try
            {
                List<QLVLXD.DLL.HoaDonBanHang> list = new List<DLL.HoaDonBanHang>();
                foreach (QLVLXD.DLL.HoaDonBanHang var in DB.HoaDonBanHangs)
                    list.Add(var);
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public QLVLXD.DLL.HoaDonBanHang GetObjectFromID(string MaHDBH)
        {
            try
            {
                var Return = DB.HoaDonBanHangs.FirstOrDefault(data => data.MaHDBH.Trim() == MaHDBH.Trim());
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
    }
}
