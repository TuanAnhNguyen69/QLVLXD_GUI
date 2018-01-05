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
    struct RecordThongKeBanHang
    {
        public string MaHDBH, MaNV, TenNV, MaKH, TenKH, TrangThai, GhiChu;
        public DateTime NgayGiao, NgayLap;
        public long SoVatLieu, TienVatLieu, TienKhuyenMai, TienKMKH, TongTien, LaiSuat, Von;        
    }

    class BLL_ThongKeBanHang : BLL
    {
        BLL_CTHoaDonBanHang _CTHoaDonBanHang = new BLL_CTHoaDonBanHang();
        BLL_KhachHang _KhachHang = new BLL_KhachHang();
        BLL_LoaiKhachHang _LoaiKhachHang = new BLL_LoaiKhachHang();
        BLL_HoaDonBanHang _HoaDonBanHang = new BLL_HoaDonBanHang();
        BLL_NhanVien _NhanVien = new BLL_NhanVien();
        BLL_VatLieu _VatLieu = new BLL_VatLieu();

        public RecordThongKeBanHang GetNullRecord()
        {
            RecordThongKeBanHang record = new RecordThongKeBanHang();
            record.MaHDBH = null;
            return record;
        }

        // null nếu hóa đơn truyền vào lỗi
        public RecordThongKeBanHang GetRecord(HoaDonBanHang HoaDon)
        {
            try
            {
                RecordThongKeBanHang record = new RecordThongKeBanHang();
                if (HoaDon == null) // Có lỗi hóa đơn truyền vào
                {
                    return GetNullRecord();
                }
                else // Tính toán
                {
                    record.MaHDBH = HoaDon.MaHDBH.Trim();
                    record.NgayGiao = HoaDon.NgayBan;
                    {
                        record.MaNV = HoaDon.MaNV.Trim();
                        var nhanvien = _NhanVien.GetObjectFromID(record.MaNV);
                        if (nhanvien == null)
                            return GetNullRecord();
                        record.TenNV = nhanvien.TenNV.Trim();
                    }
                    {
                        record.MaKH = HoaDon.MaKH.Trim();
                        var khachhang = _KhachHang.GetObjectFromID(record.MaKH);
                        if (khachhang == null)
                            return GetNullRecord();
                        record.TenKH = khachhang.TenKH.Trim();
                    }
                    record.NgayLap = (DateTime)HoaDon.NgayLap;
                    record.GhiChu = HoaDon.GhiChu.Trim();
                    record.TrangThai = HoaDon.TrangThai.Trim();
                    {
                        var listcthd = _CTHoaDonBanHang.GetListFromHDBH(record.MaHDBH);
                        if (listcthd == null)
                            return GetNullRecord();
                        record.SoVatLieu = record.TienVatLieu = record.TienKhuyenMai = record.TienKMKH = record.TongTien = record.LaiSuat = record.Von = 0;
                        foreach (CTHoaDonBanHang var in listcthd)
                        {
                            record.TienVatLieu += (int)var.TienKMKH;
                            record.TienKhuyenMai += (int)var.TienKM;
                            var vatlieu = _VatLieu.GetObjectFromTenVL(var.TenVL.Trim());
                            if (vatlieu == null)
                                return GetNullRecord();
                            record.Von += (int)(vatlieu.GiaMua) * (int)(var.TongSL);
                        }
                        record.SoVatLieu = listcthd.Count;
                        record.TongTien = record.TienVatLieu - record.TienKhuyenMai;
                        record.TienKMKH = Math.Abs(_HoaDonBanHang.GetTienKMKH(record.TongTien, record.MaKH, record.MaHDBH));
                        record.TongTien -= record.TienKMKH;
                        record.LaiSuat = record.TongTien - record.Von;
                    }
                }
                return record;
            }
            catch (Exception) // Lỗi ngoài ý
            {
                return GetNullRecord();
            }
        }

        public List<RecordThongKeBanHang> GetListOrginal()
        {
            try
            {
                List<RecordThongKeBanHang> list = new List<RecordThongKeBanHang>();
                var listhd = _HoaDonBanHang.GetList();
                foreach (HoaDonBanHang var in listhd)
                {
                    var rec = GetRecord(var);
                    if (rec.MaHDBH != null)
                        list.Add(rec);
                }
                return list;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool IsHoaDonCoNCC(RecordThongKeBanHang Record, string NCCFilter)
        {
            try
            {
                if (NCCFilter == "")
                    return true;
                var listct = _CTHoaDonBanHang.GetListFromHDBH(Record.MaHDBH.Trim());
                if (listct == null)
                    return false;
                foreach (CTHoaDonBanHang vari in listct)
                    if (TextinText(vari.TenNCC.Trim(), NCCFilter, false))
                        return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
