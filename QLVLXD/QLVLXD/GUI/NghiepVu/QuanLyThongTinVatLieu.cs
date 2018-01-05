using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using QLVLXD.BLL;

namespace QLVLXD
{
    public partial class VatLieu : Form
    {
        //    // Các biến BLL
        //    BLL_NhaCungCap _BLL_NhaCungCap = new BLL_NhaCungCap();
        //    BLL_VatLieu _BLL_VatLieu = new BLL_VatLieu();
        //    BLL_QuanLyDonViTinh _QuanLyDonViTinh = new BLL_QuanLyDonViTinh();
        //    BLL_QuanLyTienTe _QuanLyTienTe = new BLL_QuanLyTienTe();
        //    BLL_TinhTrangVatLieu _TinhTrangVatLieu = new BLL_TinhTrangVatLieu();
        //    BLL_KhuyenMai _KhuyenMai = new BLL_KhuyenMai();
        //    BLL_DonViTinhVatLieu _DonViTinhVatLieu = new BLL_DonViTinhVatLieu();

        //    public Main_Form mainform;
        //    public bool IsReset;

        //    // Các biến khác
        //    bool IsAddNew;
        //    string _TienTeCu;

        //    // Các biến về vật liệu đang chọn trong Gridview
        //    DLL.VatLieu _VatLieuGridViewSelected = new DLL.VatLieu();
        //    string _TenKMGridViewSelected;
        //    string _TenTinhTrangGridViewSelected;

        //    public VatLieu()
        //    {
        //        InitializeComponent();
        //        LoadDataToForm();
        //        ResetForNewInsert();
        //    }

        //    private void btn_Them_Click(object sender, EventArgs e)
        //    {

        //    }

        //    void LoadGridView()
        //    {
        //        var listvl = _BLL_VatLieu.GetList();
        //        lb_SoVatLieu.Text = "(" + listvl.Count.ToString() + " Vật liệu)";

        //        for (; grid_VatLieu.Rows.Count > 0;) // Xóa hết dòng
        //            grid_VatLieu.Rows.RemoveAt(0);

        //        foreach (DLL.VatLieu var in listvl)
        //        {
        //            string MaKM = var.MaKM == null ? "None" : var.MaKM.Trim();
        //            string TenTinhTrang = _TinhTrangVatLieu.GetTenTinhTrangFromMaTinhTrang(var.MaTinhTrang);
        //            TenTinhTrang = TenTinhTrang == null ? "Tốt" : TenTinhTrang;

        //            grid_VatLieu.Rows.Add(var.MaVL.Trim(), var.TenVL.Trim(), var.MaNCC.Trim(), var.SoLuong, var.DVT_Goc.Trim(), var.GiaMua, var.GiaBanLe, var.GiaBanSi, var.SoLuongBanSi, var.MaTinhTrang.Trim(), MaKM, var.SoLuongToiThieu, TenTinhTrang, _KhuyenMai.MakeTenKM(var.MaKM), var.GhiChu);
        //        }
        //    }

        //    private void VatLieu_Load(object sender, EventArgs e)
        //    {

        //    }

        //    // Nhấn [Thêm] :
        //    private void btn_Them_Click_1(object sender, EventArgs e)
        //    {
        //        // Thiết đặt
        //        if (!IsAddNew || !CheckInput())
        //            return;

        //        BLLResult result;

        //        #region Chuẩn bị data để insert
        //        // Phần tên
        //        string MaTinhTrang = _TinhTrangVatLieu.GetMaTTFromTenTT(cb_TinhTrang.Text.Trim());
        //        if (MaTinhTrang == null)
        //            MaTinhTrang = "TTVL001";
        //        string GhiChu = tb_GhiChu.Text;
        //        if (GhiChu == null || GhiChu == "")
        //            GhiChu = "<Không có ghi chú>";
        //        // Phần DVT
        //        if (chk_NhieuDonViTinh.Checked) // Có nhiều DVT
        //        {
        //            string dvt2, dvt3;
        //            decimal tile2, tile3;
        //            if (cb_DonViTinh2.Text == "None")
        //            {
        //                dvt2 = "";
        //                tile2 = 0;
        //            }
        //            else
        //            {
        //                dvt2 = cb_DonViTinh2.Text;
        //                tile2 = num_TiLe2.Value;
        //            }

        //            if (cb_DonViTinh3.Text == "None")
        //            {
        //                dvt3 = "";
        //                tile3 = 0;
        //            }
        //            else
        //            {
        //                dvt3 = cb_DonViTinh3.Text;
        //                tile3 = num_TiLe3.Value;
        //            }
        //            result = _DonViTinhVatLieu.Insert(lb_MaVatLieu.Text.Trim(), dvt2, tile2, dvt3, tile3); // Thêm DVT phụ
        //            if (result._Code != (int)BLLResultType.S_ADD)
        //            {
        //                _BLL_VatLieu.MakeMessageBox(result);
        //                return;
        //            }
        //        }//return;
        //        // Phần giá
        //        if (!chk_CoBanSi.Checked)
        //        {
        //            num_SoLuongDeBanSi.Value = 0;
        //            num_GiaBanSi.Value = 0;
        //        }
        //        // Phần KM
        //        string MaKM;
        //        //if (chk_CoKhuyenMai.Checked) // Có KM
        //        //{
        //        //    MaKM = _KhuyenMai.NewMaKM();
        //        //    string TenKM = tb_TenKM.Text;
        //        //    if (TenKM == null || TenKM == "")
        //        //        GhiChu = "<Mặc định>";
        //        //    decimal sl, tien;
        //        //    if (r_SoLuongKhuyenMai.Checked)
        //        //    {
        //        //        sl = num_SoLuongKM.Value;
        //        //        tien = 0;
        //        //    }
        //        //    else
        //        //    {
        //        //        sl = 0;
        //        //        tien = num_TienKhuyenMai.Value;
        //        //    }
        //        //    result = _KhuyenMai.Insert(TenKM, lb_MaVatLieu.Text.Trim(), num_SoLuongDeCoKM.Value, sl, tien, cb_DonViTinhKM.Text.Trim());
        //        //    if (result._Code != (int)BLLResultType.S_ADD)
        //        //    {
        //        //        _BLL_VatLieu.MakeMessageBox(result);
        //        //        return;
        //        //    }
        //        //}
        //        //else // Ko có KM
        //        //    MaKM = null;
        //        //#endregion

        //        // Kiểm tra dữ liệu truyền vào
        //        //result = _BLL_VatLieu.CheckData(true, lb_MaVatLieu.Text.Trim(), tb_TenVatLieu.Text.Trim(), lb_MaNhaCungCap.Text.Trim(), num_SoLuong.Value, cb_DonViTinh.Text.Trim(), num_GiaMua.Value, num_GiaBanLe.Value, num_GiaBanSi.Value, num_SoLuongDeBanSi.Value, MaTinhTrang, MaKM, num_SoLuongToiThieu.Value, GhiChu);

        //        // Lỗi dữ liệu truyền vào khi checkdata
        //        if (result._Code == 111)
        //        {
        //            _BLL_VatLieu.MakeMessageBox(result);
        //            return;
        //        }

        //        // Insert
        //        UpdateGia(cb_DonViTienTe.Text.Trim(), "VND"); // Khi lưu vào CSCL chỉ lưu VND
        //        result = _BLL_VatLieu.Insert(lb_MaVatLieu.Text.Trim(), tb_TenVatLieu.Text.Trim(), lb_MaNhaCungCap.Text.Trim(), num_SoLuong.Value, cb_DonViTinh.Text.Trim(), Decimal.Round(num_GiaMua.Value, 0), Decimal.Round(num_GiaBanLe.Value, 0), Decimal.Round(num_GiaBanSi.Value, 0), num_SoLuongDeBanSi.Value, MaTinhTrang, MaKM, num_SoLuongToiThieu.Value, GhiChu);
        //        UpdateGia("VND", cb_DonViTienTe.Text.Trim());
        //        _BLL_VatLieu.MakeMessageBox(result);

        //        if (result._Code == (int)BLLResultType.S_ADD) // Thành công thì Reset
        //        {
        //            ResetForNewInsert();
        //            LoadGridView();
        //             try {mainform.frm_banhang.IsReset = true; } catch {}
        //             try {mainform.frm_muahang.IsReset = true; } catch {}
        //        }
        //    }

        //    void LoadDataToForm()
        //    {
        //        // Các combobox DVT
        //        List<string> listdvt = _QuanLyDonViTinh.GetDanhSachDonViTinh();
        //        _BLL_VatLieu.MakeComboBox(cb_DonViTinh, listdvt);
        //        cb_DonViTinh2.Items.Add("None"); cb_DonViTinh2.AutoCompleteCustomSource.Add("None");
        //        _BLL_VatLieu.MakeComboBox(cb_DonViTinh2, listdvt);
        //        cb_DonViTinh3.Items.Add("None"); cb_DonViTinh3.AutoCompleteCustomSource.Add("None");
        //        _BLL_VatLieu.MakeComboBox(cb_DonViTinh3, listdvt);

        //        // Combobox NCC
        //        List<string> listtenncc = new List<string>();
        //        List<DLL.NhaCungCap> listncc = _BLL_NhaCungCap.GetList();
        //        foreach (DLL.NhaCungCap mem in listncc)
        //        {
        //            listtenncc.Add(mem.TenNCC.Trim());
        //        }
        //        _BLL_VatLieu.MakeComboBox(cb_TenNhaCungCap, listtenncc);

        //        _BLL_VatLieu.MakeComboBoxNoAuto(cb_DonViTienTe, _QuanLyTienTe.GetDanhSachTienTe());

        //        _BLL_VatLieu.MakeComboBox(cb_TinhTrang, _TinhTrangVatLieu.GetDanhSachTinhTrangVatLieu());


        //        LoadGridView();
        //    }

        //    // Reset Form để thêm mới
        //    void ResetForNewInsert()
        //    {
        //        // Phần tên
        //        tb_TenVatLieu.Text = "";
        //        lb_MaVatLieu.Text = _BLL_VatLieu.NewMaVL();
        //        tb_GhiChu.Text = "<Không có ghi chú>";
        //        cb_TinhTrang.Text = "Tốt";
        //        if (cb_DonViTienTe.Text == "") // Lần khởi động đầu tiên thì là VND
        //        {
        //            _TienTeCu = "VND";
        //            cb_DonViTienTe.SelectedIndex = 0;
        //        }

        //        // Đơn vị tính
        //        cb_DonViTinh.SelectedIndex = 0;
        //        chk_NhieuDonViTinh.Checked = false;
        //        cb_DonViTinh2.SelectedIndex = 0;
        //        num_TiLe2.Value = 0;
        //        cb_DonViTinh3.SelectedIndex = 0;
        //        num_TiLe3.Value = 0;
        //        chk_NhieuDonViTinh_CheckedChanged(null, null);

        //        // Phần giá
        //        num_GiaMua.Value = 0;
        //        num_GiaBanLe.Value = 0;
        //        num_SoLuongDeBanSi.Value = 0;
        //        num_GiaBanSi.Value = 0;
        //        chk_CoBanSi.Checked = false;
        //        chk_CoBanSi_CheckedChanged(null, null);
        //        num_SoLuongToiThieu.Value = (new BLL_CTHoaDonBanHang()).ReadConfig()._SoLuongToiThieu;



        //        // Nút
        //        IsAddNew = true;
        //        btn_Them.Visible = true;
        //        btn_CapNhat.Visible = false;
        //        btn_Xoa.Visible = false;
        //        lb_MaVatLieu.ForeColor = Color.Green;
        //    }

        //    private bool CheckInput()
        //    {
        //        #region Phần tên vật liệu
        //        if (tb_TenVatLieu.Text == "")
        //        {
        //            MessageBox.Show("Vui lòng nhập tên vật liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        if (_BLL_VatLieu.CheckNotInComboBox(cb_TenNhaCungCap))
        //        {
        //            MessageBox.Show("Vui lòng chọn tên nhà cung cấp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        if (_BLL_VatLieu.CheckNotInComboBox(cb_TinhTrang))
        //        {
        //            MessageBox.Show("Vui lòng chọn tình trạng vật liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        if (tb_GhiChu.Text.Length >= 99)
        //        {
        //            MessageBox.Show("Vui lòng viết Ghi chú ít hơn 100 kí tự!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        #endregion

        //        #region Phần DVT            
        //        if (_BLL_VatLieu.CheckNotInComboBox(cb_DonViTinh))
        //        {
        //            MessageBox.Show("Vui lòng chọn đơn vị tính!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        if (chk_NhieuDonViTinh.Checked) // Nhiều dvt
        //        {
        //            if (cb_DonViTinh2.Text.Trim() == cb_DonViTinh.Text.Trim()
        //                || cb_DonViTinh3.Text.Trim() == cb_DonViTinh.Text.Trim())
        //            {
        //                MessageBox.Show("Vui lòng chọn đơn vị tính phụ khác đơn vị tính gốc!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //            if (_BLL_VatLieu.CheckNotInComboBox(cb_DonViTinh2) || (num_TiLe2.Value < 2 && cb_DonViTinh2.Text.Trim() != "None"))
        //            {
        //                MessageBox.Show("Vui lòng chọn tên và nhập tỉ lệ lớn 1 cho đơn vị tính 2!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //            if (_BLL_VatLieu.CheckNotInComboBox(cb_DonViTinh3) || (num_TiLe3.Value < 2 && cb_DonViTinh3.Text.Trim() != "None"))
        //            {
        //                MessageBox.Show("Vui lòng chọn tên và nhập tỉ lệ lớn 1 cho đơn vị tính 3!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //            if (cb_DonViTinh2.Text.Trim() == "None" && cb_DonViTinh3.Text.Trim() == "None")
        //            {
        //                MessageBox.Show("Vui lòng chọn tên và nhập tỉ lệ cho đơn vị tính thứ hai và thứ ba!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }
        //        #endregion

        //        #region Phần giá mua
        //        if ((cb_DonViTienTe.Text.Trim() == "VND" && num_GiaMua.Value < 1000) || num_GiaMua.Value == 0)
        //        {
        //            MessageBox.Show("Vui lòng nhập giá mua từ 1000 VND hoặc lớn hơn 0 với tiền tệ khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }

        //        if ((cb_DonViTienTe.Text.Trim() == "VND" && num_GiaBanLe.Value < 1000) || num_GiaBanLe.Value == 0)
        //        {
        //            MessageBox.Show("Vui lòng nhập giá bán lẻ từ 1000 VND hoặc lớn hơn 0 với tiền tệ khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return false;
        //        }
        //        if (chk_CoBanSi.Checked) // Có bán sỉ
        //        {
        //            if (num_SoLuongDeBanSi.Value < 2)
        //            {
        //                MessageBox.Show("Vui lòng nhập Số lượng để bán sỉ từ 2 trở lên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //            if ((cb_DonViTienTe.Text.Trim() == "VND" && num_GiaBanSi.Value < 1000) || num_GiaBanSi.Value == 0)
        //            {
        //                MessageBox.Show("Vui lòng nhập giá bán sỉ từ 1000 VND hoặc lớn hơn 0 với tiền tệ khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //                return false;
        //            }
        //        }
        //        #endregion

        //        #region Phần Khuyến mãi

        //        #endregion

        //        return true;
        //    }

        //    private void btn_Reset_Click(object sender, EventArgs e)
        //    {
        //        ResetForNewInsert();
        //    }

        //    // [Xóa]
        //    private void btn_Xoa_Click(object sender, EventArgs e)
        //    {
        //        if (IsAddNew)
        //            return;

        //        BLLResult result = _BLL_VatLieu.Delete(lb_MaVatLieu.Text.Trim(), false);

        //        if (result._Code != (int)BLLResultType.NOT_DELETE)
        //            _BLL_NhaCungCap.MakeMessageBox(result);

        //        if (result._Code == (int)BLLResultType.S_DELETE)
        //        {
        //            LoadGridView();
        //            ResetForNewInsert();
        //             try {mainform.frm_banhang.IsReset = true; } catch {}
        //             try {mainform.frm_muahang.IsReset = true; } catch {}
        //        }
        //    }

        //    // Nhấn [Cập nhật] :
        //    private void btn_CapNhat_Click(object sender, EventArgs e)
        //    {
        //        // Thiết đặt
        //        if (IsAddNew || !CheckInput())
        //            return;

        //        BLLResult result;

        //        #region Chuẩn bị data để insert
        //        // Phần tên
        //        string MaTinhTrang = _TinhTrangVatLieu.GetMaTTFromTenTT(cb_TinhTrang.Text.Trim());
        //        if (MaTinhTrang == null)
        //            MaTinhTrang = "TTVL001";
        //        string GhiChu = tb_GhiChu.Text;
        //        if (GhiChu == null || GhiChu == "")
        //            GhiChu = "<Không có ghi chú>";
        //        // Phần DVT
        //        string dvt2, dvt3;
        //        decimal tile2, tile3;
        //        if (chk_NhieuDonViTinh.Checked) // Có nhiều DVT
        //        {
        //            if (cb_DonViTinh2.Text == "None")
        //            {
        //                dvt2 = "";
        //                tile2 = 0;
        //            }
        //            else
        //            {
        //                dvt2 = cb_DonViTinh2.Text;
        //                tile2 = num_TiLe2.Value;
        //            }

        //            if (cb_DonViTinh3.Text == "None")
        //            {
        //                dvt3 = "";
        //                tile3 = 0;
        //            }
        //            else
        //            {
        //                dvt3 = cb_DonViTinh3.Text;
        //                tile3 = num_TiLe3.Value;
        //            }
        //            result = _DonViTinhVatLieu.Update(lb_MaVatLieu.Text.Trim(), dvt2, tile2, dvt3, tile3); // Cập nhật DVT phụ
        //            if (result._Code != (int)BLLResultType.S_UPDATE)
        //            {
        //                _BLL_VatLieu.MakeMessageBox(result);
        //                return;
        //            }
        //        }
        //        else // K có DVT phụ
        //        {
        //            dvt2 = "";
        //            tile2 = 0;
        //            dvt3 = "";
        //            tile3 = 0;

        //            result = _DonViTinhVatLieu.Update(lb_MaVatLieu.Text.Trim(), dvt2, tile2, dvt3, tile3); // Cập nhật DVT phụ
        //            if (result._Code != (int)BLLResultType.S_UPDATE)
        //            {
        //                _BLL_VatLieu.MakeMessageBox(result);
        //                return;
        //            }
        //        }
        //        // Phần giá
        //        if (!chk_CoBanSi.Checked)
        //        {
        //            num_SoLuongDeBanSi.Value = 0;
        //            num_GiaBanSi.Value = 0;
        //        }
        //        // Phần KM
        //        //if (chk_CoKhuyenMai.Checked) // Có KM
        //        //{
        //        //    MaKM = _KhuyenMai.NewMaKM();
        //        //    string TenKM = tb_TenKM.Text;
        //        //    if (TenKM == null || TenKM == "")
        //        //        GhiChu = "<Mặc định>";
        //        //    decimal sl, tien;
        //        //    if (r_SoLuongKhuyenMai.Checked)
        //        //    {
        //        //        sl = num_SoLuongKM.Value;
        //        //        tien = 0;
        //        //    }
        //        //    else
        //        //    {
        //        //        sl = 0;
        //        //        tien = num_TienKhuyenMai.Value;
        //        //    }
        //        //    result = _KhuyenMai.Update(TenKM, lb_MaVatLieu.Text.Trim(), num_SoLuongDeCoKM.Value, sl, tien, cb_DonViTinhKM.Text.Trim()); // Trường hợp đã có KM trước
        //        //    if (result.IsErrorException())
        //        //    {
        //        //        _BLL_VatLieu.MakeMessageBox(result);
        //        //        return;
        //        //    }
        //        //    else if (result._Code == (int)BLLResultType.NOT_EXIST) // Trường hợp chưa có KM trước
        //        //    {
        //        //        result = _KhuyenMai.Insert(TenKM, lb_MaVatLieu.Text.Trim(), num_SoLuongDeCoKM.Value, sl, tien, cb_DonViTinhKM.Text.Trim());
        //        //        if (result._Code != (int)BLLResultType.S_ADD)
        //        //        {
        //        //            _BLL_VatLieu.MakeMessageBox(result);
        //        //            return;
        //        //        }
        //        //    }
        //        //}
        //        else // Ko có KM
        //        {
        //            string MaKM;

        //            var tmp = _KhuyenMai.GetObjectFromMaVL(lb_MaVatLieu.Text.Trim());
        //            if (tmp != null) // // Trường hợp đã có KM trước
        //            {
        //                result = _KhuyenMai.Delete(tmp.MaKM.Trim(), true);
        //                if (result.IsErrorException())
        //                {
        //                    result = new BLLResult("Có lỗi xảy ra lúc xóa Khuyến mãi của vật liệu này!");
        //                    _BLL_VatLieu.MakeMessageBox(result);
        //                }
        //            }
        //            MaKM = null;
        //        }
        //        #endregion

        //        // Kiểm tra dữ liệu truyền vào
        //        //result = _BLL_VatLieu.CheckData(false, lb_MaVatLieu.Text.Trim(), tb_TenVatLieu.Text.Trim(), lb_MaNhaCungCap.Text.Trim(), num_SoLuong.Value, cb_DonViTinh.Text.Trim(), num_GiaMua.Value, num_GiaBanLe.Value, num_GiaBanSi.Value, num_SoLuongDeBanSi.Value, MaTinhTrang, MaKM, num_SoLuongToiThieu.Value, GhiChu);

        //        // Lỗi dữ liệu truyền vào khi checkdata
        //        if (result._Code == 111)
        //        {
        //            _BLL_VatLieu.MakeMessageBox(result);
        //            return;
        //        }

        //        // Update
        //        UpdateGia(cb_DonViTienTe.Text.Trim(), "VND"); // Khi lưu vào CSCL chỉ lưu VND
        //       // result = _BLL_VatLieu.Update(lb_MaVatLieu.Text.Trim(), tb_TenVatLieu.Text.Trim(), lb_MaNhaCungCap.Text.Trim(), num_SoLuong.Value, cb_DonViTinh.Text.Trim(), Decimal.Round(num_GiaMua.Value, 0), Decimal.Round(num_GiaBanLe.Value, 0), Decimal.Round(num_GiaBanSi.Value, 0), num_SoLuongDeBanSi.Value, MaTinhTrang, MaKM, num_SoLuongToiThieu.Value, GhiChu);
        //        UpdateGia("VND", cb_DonViTienTe.Text.Trim());
        //        _BLL_VatLieu.MakeMessageBox(result);

        //        if (result._Code == (int)BLLResultType.S_UPDATE) // Thành công thì Reset
        //        {
        //            ResetForNewInsert();
        //            LoadGridView();
        //             try {mainform.frm_banhang.IsReset = true; } catch {}
        //             try {mainform.frm_muahang.IsReset = true; } catch {}
        //            try { mainform.frm_thongkebanhang.IsReset = true; } catch { }
        //        }
        //    }

        //    private void btn_XemInfoNCC_Click(object sender, EventArgs e)
        //    {
        //        //if (gridView1.SelectedRowsCount != 1)
        //        //    return;

        //        //int[] selectedindex = gridView1.GetSelectedRows();
        //        //DLL.VatLieu vldangchon = (QLVLXD.DLL.VatLieu)gridView1.GetRow(selectedindex[0]);

        //        //GUI.XemThongTinNCC form = new GUI.XemThongTinNCC(vldangchon.TenNCC.Trim());
        //        //form.Show();
        //    }

        //    private void cb_TenNhaCungCap_SelectedIndexChanged_1(object sender, EventArgs e)
        //    {
        //        DLL.NhaCungCap data = _BLL_NhaCungCap.GetObjectFromTenNhaCungCap(cb_TenNhaCungCap.Text.Trim());
        //        if (data != null)
        //        {
        //            lb_MaNhaCungCap.Text = data.MaNCC.Trim();
        //        }
        //    }

        //    // Nhấn phím [Esc] thì thoát:
        //    private void VatLieu_KeyDown(object sender, KeyEventArgs e)
        //    {
        //        //if (e.KeyCode == Keys.Escape)
        //        //{
        //        //    if (IsAddNew && (tb_TenVatLieu.Text != "" || nud_SoLuong.Value > 0 || nud_DonGia.Value > 0 || nud_DonGiaBan.Value > 0))
        //        //    {
        //        //        DialogResult result = MessageBox.Show("Hủy việc Thêm vào? Nhấn [Yes] để thoát hoặc nhấn [No] để tiếp tục.", "Thông báo", MessageBoxButtons.YesNo,
        //        //                      MessageBoxIcon.Information);

        //        //        if (result == DialogResult.Yes)
        //        //            this.Close();
        //        //    }
        //        //}

        //        Application.Exit();

        //    }

        //    private void gridControl1_Click(object sender, EventArgs e)
        //    {

        //    }

        //    private void grid_DanhSachVatLieuCuaHang_Click(object sender, EventArgs e)
        //    {

        //    }

        //    private void chk_NhieuDonViTinh_CheckedChanged(object sender, EventArgs e)
        //    {
        //        if (chk_NhieuDonViTinh.Checked)
        //        {
        //            cb_DonViTinh2.Enabled = true;
        //            num_TiLe2.Enabled = true;
        //            cb_DonViTinh3.Enabled = true;
        //            num_TiLe3.Enabled = true;
        //        }
        //        else
        //        {
        //            cb_DonViTinh2.Enabled = false;
        //            num_TiLe2.Enabled = false;
        //            cb_DonViTinh3.Enabled = false;
        //            num_TiLe3.Enabled = false;
        //        }
        //    }

        //    private void chk_CoBanSi_CheckedChanged(object sender, EventArgs e)
        //    {
        //        if (chk_CoBanSi.Checked)
        //        {
        //            num_GiaBanSi.Enabled = true;
        //            num_SoLuongDeBanSi.Enabled = true;
        //        }
        //        else
        //        {
        //            num_GiaBanSi.Enabled = false;
        //            num_SoLuongDeBanSi.Enabled = false;
        //        }
        //    }

        //    private void chk_CoKhuyenMai_CheckedChanged(object sender, EventArgs e)
        //    {

        //    }

        //    private void grid_VatLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //    {

        //    }

        //    void UpdateGia(string TienTeCu, string TienTeMoi)
        //    {
        //        // Tiền xử lý
        //        TienTeCu = TienTeCu.Trim();
        //        TienTeMoi = TienTeMoi.Trim();
        //        if (TienTeCu == TienTeMoi) // Nếu trùng thì khỏi đổi
        //            return;
        //        var tmp = _QuanLyTienTe.GetObjectFromTenTienTe(TienTeCu.Trim()).TriGiaVND;
        //        var tmp2 = _QuanLyTienTe.GetObjectFromTenTienTe(TienTeMoi.Trim()).TriGiaVND;
        //        decimal tile, tile2;
        //        if (tmp == null || tmp2 == null)
        //        {
        //            MessageBox.Show("Lỗi UpdateGia()", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }
        //        else // Phần đổi:
        //        {
        //            tile = (decimal)tmp;
        //            tile2 = (decimal)tmp2;
        //            _TienTeCu = TienTeMoi;

        //            // Đổi cũ thành VND
        //            num_GiaMua.Value *= tile;
        //            num_GiaBanLe.Value *= tile;
        //            num_GiaBanSi.Value *= tile;

        //            // Từ VND thành mới
        //            num_GiaMua.Value /= tile2;
        //            num_GiaBanLe.Value /= tile2;
        //            num_GiaBanSi.Value /= tile2;
        //        }
        //    }

        //    // Click vào GridView
        //    private void grid_VatLieu_CellClick(object sender, DataGridViewCellEventArgs e)
        //    {
        //        // Tiền xử lý
        //        if (!IsAddNew)
        //            ResetForNewInsert();
        //        int rowindex = grid_VatLieu.SelectedCells[0].RowIndex;
        //        grid_VatLieu.Rows[rowindex].Selected = true;

        //        #region Load vào biến _VatLieuGridViewSelected
        //        _VatLieuGridViewSelected.MaVL = grid_VatLieu.Rows[rowindex].Cells[0].Value.ToString().Trim();
        //        _VatLieuGridViewSelected.TenVL = grid_VatLieu.Rows[rowindex].Cells[1].Value.ToString().Trim();
        //        _VatLieuGridViewSelected.MaNCC = grid_VatLieu.Rows[rowindex].Cells[2].Value.ToString().Trim();
        //        _VatLieuGridViewSelected.SoLuong = Decimal.Parse(grid_VatLieu.Rows[rowindex].Cells[3].Value.ToString().Trim());
        //        _VatLieuGridViewSelected.DVT_Goc = grid_VatLieu.Rows[rowindex].Cells[4].Value.ToString().Trim();
        //        _VatLieuGridViewSelected.GiaMua = Decimal.Parse(grid_VatLieu.Rows[rowindex].Cells[5].Value.ToString().Trim());
        //        _VatLieuGridViewSelected.GiaBanLe = Decimal.Parse(grid_VatLieu.Rows[rowindex].Cells[6].Value.ToString().Trim());
        //        _VatLieuGridViewSelected.GiaBanSi = Decimal.Parse(grid_VatLieu.Rows[rowindex].Cells[7].Value.ToString().Trim());
        //        _VatLieuGridViewSelected.SoLuongBanSi = Decimal.Parse(grid_VatLieu.Rows[rowindex].Cells[8].Value.ToString().Trim());
        //        _VatLieuGridViewSelected.MaTinhTrang = grid_VatLieu.Rows[rowindex].Cells[9].Value.ToString().Trim();
        //        _VatLieuGridViewSelected.MaKM = grid_VatLieu.Rows[rowindex].Cells[10].Value.ToString().Trim();
        //        _VatLieuGridViewSelected.SoLuongToiThieu = Decimal.Parse(grid_VatLieu.Rows[rowindex].Cells[11].Value.ToString().Trim());
        //        _TenTinhTrangGridViewSelected = grid_VatLieu.Rows[rowindex].Cells[12].Value.ToString().Trim();
        //        _TenKMGridViewSelected = grid_VatLieu.Rows[rowindex].Cells[13].Value.ToString().Trim();
        //        {// Ghi chú
        //            var tmp = grid_VatLieu.Rows[rowindex].Cells[14].Value;
        //            string ghichu = tmp == null ? "" : tmp.ToString().Trim();
        //            _VatLieuGridViewSelected.GhiChu = ghichu;
        //        }
        //        #endregion

        //        #region Load thông tin lên form
        //        IsAddNew = false;
        //        btn_Them.Visible = false;
        //        btn_CapNhat.Visible = true;
        //        btn_Xoa.Visible = true;
        //        lb_MaVatLieu.ForeColor = Color.Red;

        //        // Phần tên vl
        //        tb_TenVatLieu.Text = _VatLieuGridViewSelected.TenVL.Trim();
        //        lb_MaVatLieu.Text = _VatLieuGridViewSelected.MaVL.Trim();
        //        cb_TenNhaCungCap.Text = _BLL_NhaCungCap.GetTenNCCFromMaNCC(_VatLieuGridViewSelected.MaNCC.Trim());
        //        lb_MaNhaCungCap.Text = _VatLieuGridViewSelected.MaNCC.Trim();
        //        cb_TinhTrang.Text = _TenTinhTrangGridViewSelected.Trim();
        //        tb_GhiChu.Text = _VatLieuGridViewSelected.GhiChu;

        //        // Giá
        //        num_GiaMua.Value = (decimal)_VatLieuGridViewSelected.GiaMua;
        //        num_GiaBanLe.Value = (decimal)_VatLieuGridViewSelected.GiaBanLe;
        //        if (_VatLieuGridViewSelected.GiaBanSi != 0) // Có bán sỉ
        //        {
        //            chk_CoBanSi.Checked = true;
        //            chk_CoBanSi_CheckedChanged(null, null);
        //            num_GiaBanSi.Value = (decimal)_VatLieuGridViewSelected.GiaBanSi;
        //            num_SoLuongDeBanSi.Value = (decimal)_VatLieuGridViewSelected.SoLuongBanSi;
        //        }
        //        num_SoLuongToiThieu.Value = (decimal)_VatLieuGridViewSelected.SoLuongToiThieu;

        //        // Đvt
        //        cb_DonViTinh.Text = _VatLieuGridViewSelected.DVT_Goc.Trim();
        //        var dsdvt = _DonViTinhVatLieu.GetDanhSachDonViTinhVatLieu(_VatLieuGridViewSelected.MaVL.Trim());
        //        if (dsdvt.Count > 0) // Có dvt phụ
        //        {
        //            chk_NhieuDonViTinh.Checked = true;
        //            chk_NhieuDonViTinh_CheckedChanged(null, null);

        //            var dvt = _QuanLyDonViTinh.GetObjectFromID(dsdvt[0].MaDVT);
        //            cb_DonViTinh2.Text = dvt.TenDVT.Trim();
        //            num_TiLe2.Value = (decimal)dsdvt[0].TiLe;

        //            if (dsdvt.Count == 2) // Có 2 dvt phụ
        //            {
        //                dvt = _QuanLyDonViTinh.GetObjectFromID(dsdvt[1].MaDVT);
        //                cb_DonViTinh3.Text = dvt.TenDVT.Trim();
        //                num_TiLe3.Value = (decimal)dsdvt[1].TiLe;
        //            }
        //        }

        //        // Phần KM
        //        var km = _KhuyenMai.GetObjectFromMaVL(_VatLieuGridViewSelected.MaVL.Trim());


        //        UpdateGia("VND", cb_DonViTienTe.Text.Trim());
        //        #endregion
        //    }

        //    private void r_SoLuongKhuyenMai_CheckedChanged(object sender, EventArgs e)
        //    {

        //    }

        //    private void r_TienKhuyenMai_CheckedChanged(object sender, EventArgs e)
        //    {
        //        r_SoLuongKhuyenMai_CheckedChanged(null, null);
        //    }

        //    private void cb_DonViTienTe_SelectedIndexChanged(object sender, EventArgs e)
        //    {
        //        UpdateGia(_TienTeCu, cb_DonViTienTe.Text.Trim());
        //    }

        //    private void num_SoLuongKM_MouseDown(object sender, MouseEventArgs e)
        //    {
        //        r_SoLuongKhuyenMai_CheckedChanged(null, null);
        //    }

        //    private void num_TienKhuyenMai_MouseDown(object sender, MouseEventArgs e)
        //    {
        //        r_TienKhuyenMai_CheckedChanged(null, null);
        //    }

        //    private void cb_DonViTinh2_SelectedIndexChanged(object sender, EventArgs e)
        //    {
        //        if (cb_DonViTinh2.Text.Trim() == "None")
        //            num_TiLe2.Value = 0;
        //    }

        //    private void cb_DonViTinh3_SelectedIndexChanged(object sender, EventArgs e)
        //    {
        //        if (cb_DonViTinh3.Text.Trim() == "None")
        //            num_TiLe3.Value = 0;
        //    }

        //    private void VatLieu_VisibleChanged(object sender, EventArgs e)
        //    {
        //        if (IsReset)
        //            if (MessageBox.Show("Cơ sở dữ liệu đã có thay đổi. \nBạn có muốn tắt tab này và mở lại để reset?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // Đồng ý mở lại
        //            {
        //                mainform.ResetTab(mainform.IndexTabFormTenTab(E_FORM.VATLIEU));
        //                IsReset = false;
        //            }
        //    }

        //    // [Xuất file]
        //    private void btn_XuatFile_Click(object sender, EventArgs e)
        //    {
        //        try
        //        {
        //            string filepath = "";
        //            FolderBrowserDialog browse = new FolderBrowserDialog();
        //            browse.Description = "Chọn đường dẫn lưu file:";
        //            if (browse.ShowDialog() == DialogResult.OK)
        //            {
        //                filepath = browse.SelectedPath;
        //                if (filepath[filepath.Length - 1] != '\\')
        //                    filepath = filepath + "\\";  
        //                string name = DateTime.Now.ToString();
        //                name = name.Replace('/', '-');
        //                name = name.Replace(':', '-');                    
        //                _BLL_VatLieu.ExportExcel(grid_VatLieu, filepath, "Danh Sách Vật Liệu (" + name + ")");
        //                MessageBox.Show("Xuất Excel thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        }
        //        catch
        //        {
        //            MessageBox.Show("Xuất Excel không thành công", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }

        //    // [In]
        //    private void btn_In_Click(object sender, EventArgs e)
        //    {
        //        (new PrintDialog()).ShowDialog();
        //    }
        //}
    }
}

