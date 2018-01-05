using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QLVLXD.BLL;

namespace QLVLXD.GUI
{
    public partial class HoaDonBanHang : DevExpress.XtraEditors.XtraForm
    {
        // Biến BLL
        BLL.BLL_NhanVien _NhanVien = new BLL_NhanVien();
        BLL.BLL_VatLieu _BLL_VatLieu = new BLL.BLL_VatLieu();
        BLL.BLL_CTHoaDonBanHang _BLL_CTHoaDonBanHang = new BLL.BLL_CTHoaDonBanHang();
        BLL.BLL_HoaDonBanHang _BLL_HoaDonBanHang = new BLL.BLL_HoaDonBanHang();
        BLL.BLL_KhachHang _BLL_KhachHang = new BLL.BLL_KhachHang();
        BLL.BLL_LoaiKhachHang _LoaiKhachHang = new BLL.BLL_LoaiKhachHang();
        BLL.BLL_QuanLyTienTe _QuanLyTienTe = new BLL.BLL_QuanLyTienTe();
        BLL.BLL_NhaCungCap _NhaCungCap = new BLL.BLL_NhaCungCap();
        BLL.BLL_KhuyenMai _KhuyenMai = new BLL.BLL_KhuyenMai();
        BLL.BLL_DonViTinhVatLieu _DonViTinhVatLieu = new BLL.BLL_DonViTinhVatLieu();
        BLL.BLL_QuanLyDonViTinh _QuanLyDonViTinh = new BLL.BLL_QuanLyDonViTinh();
        BLL.BLL_TinhTrangVatLieu _TinhTrangVatLieu = new BLL.BLL_TinhTrangVatLieu();
       
        //// Biến lưu dữ liệu load
        List<DLL.CTHoaDonBanHang> _ListVatLieuHoaDon = new List<DLL.CTHoaDonBanHang>();
        DLL.CTHoaDonBanHang _CTHDBHEditting = new DLL.CTHoaDonBanHang();
        DLL.HoaDonBanHang _HDBHEditting = new DLL.HoaDonBanHang();

        // Biến khác
        public bool IsAddNew, _IsKMSoLanMua, IsReset;
        public long iTongTien;
        public Main_Form mainform;

        public HoaDonBanHang()
        {
            InitializeComponent();

            LoadDataToForm();
            ResetForNewInsert();
        }
        
        decimal TienVatLieu(long SoLuongMua, decimal GiaLe, decimal GiaSi, long SoLuongSi)
        {
            long sosi;
            if (SoLuongSi == 0)
                sosi = 0;
            else
                sosi = SoLuongMua / SoLuongSi;
            long sole = SoLuongMua - sosi * SoLuongSi;
            return sosi * GiaSi + sole * GiaLe;
        }

        decimal TienVatLieu(DLL.CTHoaDonBanHang CTHDBH)
        {
            return TienVatLieu((long)CTHDBH.SoLuongMua, (decimal)CTHDBH.GiaLe, (decimal)CTHDBH.GiaSi, (long)CTHDBH.SoLuongDeBanSi);
        }

        void LoadGridView(List<DLL.CTHoaDonBanHang> ListCTHDBH)
        {
            try
            {
                for (; grid_VatLieu.Rows.Count > 0;) // Xóa hết dòng
                    grid_VatLieu.Rows.RemoveAt(0);
            }
            catch
            { }

            foreach (DLL.CTHoaDonBanHang var in ListCTHDBH)
            {
                grid_VatLieu.Rows.Add(var.MaCTHDBH.Trim(), var.TenVL.Trim(), var.TinhTrangVL.Trim(), var.TenNCC.Trim(), var.DonViTinh.Trim(), var.SoLuongMua, var.SoLuongKM, var.TongSL, var.GiaLe, var.GiaSi, var.SoLuongDeBanSi, var.TienKMKH, var.TienKM, var.TongTien, var.GhiChu);
            }
        }

        public void SetNV(DLL.NhanVien NhanVien)
        {
            if (NhanVien == null)
                return;

            lb_TenNhanVien.Text = NhanVien.TenNV.Trim();
            lb_MaNV.Text = NhanVien.MaNV.Trim();
        }

        void LoadDataToForm()
        {
            // Tạo ds cho cb_TenKH
            List<DLL.KhachHang> listKH = _BLL_KhachHang.GetList();
            List<string> listnamekh = new List<string>();
            foreach (DLL.KhachHang mem in listKH)
                listnamekh.Add(mem.TenKH.Trim());
            _BLL_CTHoaDonBanHang.MakeComboBox(cb_TenKhachHang, listnamekh);

            // Tạo ds cho cb_TenVatLieu
            List<DLL.VatLieu> listVL = _BLL_VatLieu.GetListForBanHang();
            List<string> listnamevl = new List<string>();
            foreach (DLL.VatLieu mem in listVL)
                listnamevl.Add(mem.TenVL.Trim());
            _BLL_CTHoaDonBanHang.MakeComboBox(cb_TenVatLieu, listnamevl);

            // Tạo ds cho cb_TrangThai
            List<string> liststt = new List<string>();
            liststt.Add("Giao Ngay Lúc Lập");
            liststt.Add("Chưa Giao");
            liststt.Add("Đang Giao");
            liststt.Add("Đã Giao");
            _NhaCungCap.MakeComboBoxNoAuto(cb_TrangThai, liststt);

            // Tiền tệ
            _BLL_VatLieu.MakeComboBoxNoAuto(cb_DonViTienTe, _QuanLyTienTe.GetDanhSachTienTe());
        }

        void ResetForNewInsert()
        {
            // Phần Thông Tin Hóa Đơn
            lb_MaHDBH.Text = _BLL_HoaDonBanHang.NewMaHDBH();
            lb_NgayLap.Text = DateTime.Today.ToShortDateString();
            dtp_NgayGiao.Value = DateTime.Today;
            cb_TenKhachHang.Text = "[Không Tên]";

            // Phần thống kê hóa đơn           
            ResetThongKe();
            cb_TrangThai.Text = "Giao ngay lúc lập";
            cb_DonViTienTe.Text = "VND";

            // Phần thêm vật liệu
            cb_TenVatLieu.Text = "";
            lb_TenNCC.Text = "(Tên NCC)";
            cb_DonViTinh.Text = "";
            tb_GhiChuVatLieu.Text = "<Không có ghi chú>";
            lb_GiaBanLe.Text = "(Số liệu)";
            lb_GiaBanSi.Text = "(Số liệu)";
            ResetThemVatLieu();

            _ListVatLieuHoaDon.Clear();
            LoadGridView(_ListVatLieuHoaDon);

            // Phần nút và thiết lập
            btn_Them.Visible = true;
            lb_MaHDBH.ForeColor = Color.Green;
            IsAddNew = true;
            _IsKMSoLanMua = false;
        }

        void ResetThongKe()
        {
            lb_TongTien.Text = "(Số liệu)";
            lb_TongTienVatLieu.Text = "(Số liệu)";
            lb_TongTienKhuyenMai.Text = "(Số liệu)";
        }

        void ResetThemVatLieu()
        {
            lb_TongSoLuong.Text = "(Số liệu)";
            lb_TongTienAddVatLieu.Text = "(Số liệu)";
            nud_SoLuongMua.Value = 0;
        }

        private void HoaDonBanHang_Load(object sender, EventArgs e)
        {

        }
        
        void ResetSearch()
        {
            //if (te_TimKiemVatLieu.Text != "")
            //    te_TimKiemVatLieu.Text = "";

            //if (te_TimKiemHDBH.Text != "")
            //    te_TimKiemHDBH.Text = "";

            //if (te_TimKiemVatLieuTrongHoaDon.Text != "")
            //    te_TimKiemVatLieuTrongHoaDon.Text = "";
        }

        private void grid_DanhSachVatLieuCuaHang_Click(object sender, EventArgs e)
        {

        }

        // Nhấn [Reset để thêm mới]:
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetForNewInsert();
        }

        private void grid_DanhSachVatLieuCuaHang_FocusedViewChanged(object sender, DevExpress.XtraGrid.ViewFocusEventArgs e)
        {

        }

        private void grid_DanhSachVatLieuCuaHang_MouseDown(object sender, MouseEventArgs e)
        {

        }

        // Khi bấm vào 1 dòng trong danh sách vật liệu của cửa hàng thì cập nhật lb_DonViTinh
        private void grid_DanhSachVatLieuCuaHang_MouseCaptureChanged(object sender, EventArgs e)
        {
            //if (gridView1.SelectedRowsCount != 1)
            //    return;

            //int[] selectedindex = gridView1.GetSelectedRows();
            //QLVLXD.DLL.VatLieu vatlieudangchon = (QLVLXD.DLL.VatLieu)gridView1.GetRow(selectedindex[0]);
            //lb_DonViTinh.Text = vatlieudangchon.DonViTinh.Trim();
        }

        private void grid_DanhSachVatLieuCuaHang_DataSourceChanged(object sender, EventArgs e)
        {
        }

        private void grid_DanhSachVatLieuCuaHang_ProcessGridKey(object sender, KeyEventArgs e)
        {
        }

        // Thoát form
        private void HoaDonBanHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (!MakeBreak())
            //    e.Cancel = true;
        }

        // Khi chọn Tên nhân viên thì đổi mã nhân viên
        private void cb_TenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        // Kiểm tra đã nhập đủ hay chưa:
        private bool CheckInput()
        {
            // Phần thông tin hóa đơn
            if (dtp_NgayGiao.Value < DateTime.Today)
            {
                MessageBox.Show("Vui lòng chọn Ngày giao từ ngày hiện tại trở về trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_BLL_CTHoaDonBanHang.CheckNotInComboBox(cb_TenKhachHang))
            {
                MessageBox.Show("Vui lòng chọn Khách hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Phần thêm vật liệu cho hóa đơn
            if (_ListVatLieuHoaDon.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm vật liệu cho hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Bấm nút Thêm [Thêm]:
        private void btn_Them_Click(object sender, EventArgs e)
        {
            // Thiết đặt
            if (!IsAddNew || !CheckInput())
                return;

            BLLResult result;

            // Kiểm tra dữ liệu truyền vào HDBH
            result = _BLL_HoaDonBanHang.CheckData(true, lb_MaHDBH.Text, dtp_NgayGiao.Value, lb_MaNV.Text, lb_MaKH.Text, DateTime.Today, _IsKMSoLanMua ? "True" : "False", cb_TrangThai.Text);
            if (result._Code != (long)BLLResultType.SUCCESS)
            {
                _BLL_VatLieu.MakeMessageBox(result);
                return;
            }

            // Kiểm tra check CTHDBH, cập nhật số vật liệu
            foreach (DLL.CTHoaDonBanHang var in _ListVatLieuHoaDon)
            {
                result = _BLL_CTHoaDonBanHang.CheckData(true, var);
                if (result._Code != (long)BLLResultType.SUCCESS)
                {
                    _BLL_VatLieu.MakeMessageBox(result);
                    return;
                }
                result = _BLL_VatLieu.UpdateSoLuongSub(var.TenVL, (long)var.TongSL); // Cập nhật số lượng vật liệu trong CSDL
                if (result._Code != (long)BLLResultType.SUCCESS)
                {
                    _BLL_VatLieu.MakeMessageBox(result);
                    return;
                }
            }

            //// Set các hóa đơn trước đó thành đã khuyến mãi
            //if (_IsKMSoLanMua)
            //{
            //    result = _BLL_HoaDonBanHang.SetListTinhKM(lb_MaKH.Text);
            //    if (result._Code != (long)BLLResultType.SUCCESS)
            //    {
            //        _BLL_VatLieu.MakeMessageBox(result);
            //        return;
            //    }
            //}

            // Công nợ khách hàng
            if (cb_TrangThai.Text != "Đã Giao"
                && cb_TrangThai.Text != "Giao Ngay Lúc Lập")
            {
                result = _BLL_KhachHang.CongNoPlus(iTongTien, cb_TenKhachHang.Text);
                if (result._Code != (long)BLLResultType.SUCCESS)
                {
                    _BLL_CTHoaDonBanHang.MakeMessageBox(result);
                    return;
                }                
            }

            // Insert HDBH
            //UpdateGia(cb_DonViTienTe.Text.Trim(), "VND"); // Khi lưu vào CSCL chỉ lưu VND
            result = _BLL_HoaDonBanHang.Insert(lb_MaHDBH.Text, dtp_NgayGiao.Value, lb_MaNV.Text, lb_MaKH.Text, DateTime.Today, _IsKMSoLanMua ? "True" : "False", cb_TrangThai.Text);
            //UpdateGia("VND", cb_DonViTienTe.Text.Trim());
            if (result._Code != (long)BLLResultType.S_ADD)
            {
                _BLL_VatLieu.MakeMessageBox(result);
                return;
            }

            // Insert CTHDBH
            foreach (DLL.CTHoaDonBanHang var in _ListVatLieuHoaDon)
            {
                result = _BLL_CTHoaDonBanHang.Insert(var);
                if (result._Code != (long)BLLResultType.S_ADD)
                {
                    _BLL_VatLieu.MakeMessageBox(result);
                    return;
                }
            }

            _BLL_VatLieu.MakeMessageBox(result);

            if (result._Code == (long)BLLResultType.S_ADD) // Thành công thì Reset
            {
                ResetForNewInsert();
                _ListVatLieuHoaDon.Clear();
                LoadGridView(_ListVatLieuHoaDon);
                 try {mainform.frm_thongkebanhang.IsReset = true; } catch {}
            }
        }

        // Bấm nút [<<]:
        private void btn_DeleteVatLieu_Click(object sender, EventArgs e)
        {
            int rowindex = grid_VatLieu.SelectedCells[0].RowIndex;
            grid_VatLieu.Rows[rowindex].Selected = true;
            string mact = grid_VatLieu.Rows[rowindex].Cells[0].Value.ToString().Trim();
            foreach (DLL.CTHoaDonBanHang var in _ListVatLieuHoaDon)
                if (var.MaCTHDBH.Trim() == mact)
                {
                    _ListVatLieuHoaDon.Remove(var);
                    break;
                }
            LoadGridView(_ListVatLieuHoaDon);
            SetFormHoaDon();
        }

        // Khi chọn Tên khách hàng thì đổi mã KH
        private void cb_TenKH_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Bấm vào bảng danh sách HDBH khác thì cập nhật form:
        private void grid_DanhSachHoaDonBanHang_MouseCaptureChanged(object sender, EventArgs e)
        {
            //if (gridView3.SelectedRowsCount != 1)
            //    return;

            //if (!MakeBreak())
            //    return;

            //IsAddNew = false;
            //btn_Them.Visible = false;
            //btn_CapNhat.Visible = true;
            //btn_Xoa.Visible = true;
            //lb_MaHDBH.ForeColor = Color.Red;
            //dt_NgayBan.Visible = true;

            //int[] selectedindex = gridView3.GetSelectedRows();
            //DLL.HoaDonBanHang hoadondangchon = (QLVLXD.DLL.HoaDonBanHang)gridView3.GetRow(selectedindex[0]);

            //lb_MaHDBH.Text = hoadondangchon.MaHDBH.Trim();
            //dt_NgayBan.DateTime = hoadondangchon.NgayBan;
            //lb_MaNV.Text = hoadondangchon.MaNV.Trim();
            //cb_TenNhanVien.Text = hoadondangchon.TenNV.Trim();
            //TongTien = (long)hoadondangchon.TongTien;
            //lb_TongTien.Text = TongTien.ToString() + " VNĐ";
            //lb_MaKH.Text = hoadondangchon.MaKH.Trim();
            //cb_TenKhachHang.Text = hoadondangchon.TenKH.Trim();

            //_ListVatLieuHoaDon.Clear();
            //_ListMaCTHDBH_New.Clear();

            //_ListVatLieuHoaDon = _BLL_CTHoaDonBanHang.GetListCTHoaDonBanHang(hoadondangchon.MaHDBH.Trim());

            //lb_SoVatLieu.Text = _ListVatLieuHoaDon.Count.ToString();

            ////grid_DanhSachVatLieuHoaDon.DataSource = null;
            //grid_DanhSachVatLieuHoaDon.DataSource = _ListVatLieuHoaDon;

        }

        // Bấm nút [Xóa] :
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            //// ---------------------------------------------------------
            //// Reset khung tìm kiếm:
            //// ---------------------------------------------------------
            //te_TimKiemVatLieu.Text = "";

            //if (gridView3.SelectedRowsCount != 1)
            //{
            //    ResetSearch();
            //    return;
            //}

            //int[] selectedindex = gridView3.GetSelectedRows();
            //DLL.HoaDonBanHang hoadondangchon = (QLVLXD.DLL.HoaDonBanHang)gridView3.GetRow(selectedindex[0]);

            //string result = _BLL_HoaDonBanHang.Delete(lb_MaHDBH.Text.Trim());

            //if (result != "Success")
            //{
            //    if (result == "Error")
            //        MessageBox.Show("Không thể xóa! Đã có lỗi xảy ra, vui lòng kiểm tra lại dữ liệu nhập vào cũng như là cơ sở dữ liệu! (Mã lỗi 1478)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    return;
            //}

            //ResetForNewInsert();

            //_List_HoaDonBanHang.Clear();
            //_List_HoaDonBanHang = _BLL_HoaDonBanHang.GetList();

            //grid_DanhSachHoaDonBanHang.DataSource = null;
            //grid_DanhSachHoaDonBanHang.DataSource = _List_HoaDonBanHang;

            //ResetSearch();

            //MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Bấm nút [Cập nhật] :
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            //// ---------------------------------------------------------
            //// Reset khung tìm kiếm:
            //// ---------------------------------------------------------
            //te_TimKiemVatLieu.Text = "";

            //if (IsAddNew || !CheckInput())
            //{
            //    ResetSearch();
            //    return;
            //}

            //DLL.KhachHang kh = _BLL_KhachHang.GetObjectFromID(lb_MaKH.Text);

            ////Phần có lỗi thì phục hòi lại
            //DLL.HoaDonBanHang oldget = _BLL_HoaDonBanHang.GetObjectFromID(lb_MaHDBH.Text.Trim());
            //DLL.HoaDonBanHang old = new DLL.HoaDonBanHang();
            //old.MaHDBH = oldget.MaHDBH.Trim();
            //old.MaKH = oldget.MaKH;
            //old.Live = "True";
            //old.MaNV = oldget.MaNV;
            //old.SDTKH = oldget.SDTKH;
            //old.TenNV = oldget.TenNV;
            //old.TongTien = oldget.TongTien;
            //old.TenKH = oldget.TenKH;
            //old.NgayBan = oldget.NgayBan;

            ////Cập nhật HDBH trước
            //string result = _BLL_HoaDonBanHang.Update(lb_MaHDBH.Text.Trim(), dt_NgayBan.DateTime, cb_TenNhanVien.Text, lb_MaNV.Text, lb_MaKH.Text, cb_TenKhachHang.Text, kh.SDT, TongTien);

            //if (result != "Success")
            //{
            //    if (result != "Error")
            //        MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    else
            //        MessageBox.Show("Không thể cập nhật! Đã có lỗi xảy ra, vui lòng kiểm tra lại dữ liệu nhập vào cũng như là cơ sở dữ liệu! (Mã lỗi 1478)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    ResetSearch();
            //    return;
            //}

            //// Cập nhật các CTHDBH
            //result = _BLL_CTHoaDonBanHang.Update(_ListVatLieuHoaDon);

            //if (result == "Error")
            //{
            //    MessageBox.Show("Không thể cập nhật! Đã có lỗi xảy ra, vui lòng kiểm tra lại dữ liệu nhập vào cũng như là cơ sở dữ liệu! (Mã lỗi 1024)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    // Nếu sai thì phục hồi cập nhật HDBH
            //    _BLL_HoaDonBanHang.Update(old.MaHDBH, old.NgayBan, old.TenNV, old.MaNV, old.MaKH, old.TenKH, old.SDTKH, old.TongTien);

            //    ResetSearch();
            //    return;
            //}

            //ResetForNewInsert();

            //_ListCTHoaDonBanHang = _BLL_CTHoaDonBanHang.GetListAll();

            //_List_HoaDonBanHang.Clear();
            //_List_HoaDonBanHang = _BLL_HoaDonBanHang.GetList();

            //grid_DanhSachHoaDonBanHang.DataSource = null;
            //grid_DanhSachHoaDonBanHang.DataSource = _List_HoaDonBanHang;

            //ResetSearch();

            //MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Khung tìm kiếm vật liệu của cửa hàng:
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            //if (te_TimKiemVatLieu.Text != "")
            //{
            //    List<DLL.VatLieu> listvl = _BLL_VatLieu.GetListForBanHang();
            //    List<DLL.VatLieu> data = new List<DLL.VatLieu>();

            //    foreach (DLL.VatLieu mem in listvl)
            //        if (mem.TenVL.ToUpper().Contains(te_TimKiemVatLieu.Text.ToUpper()))
            //            data.Add(mem);

            //    grid_DanhSachVatLieuCuaHang.DataSource = data;
            //}
            //else
            //{
            //    grid_DanhSachVatLieuCuaHang.DataSource = _BLL_VatLieu.GetListForBanHang();
            //}
        }

        // Thay đổi tên thì sửa mã:
        private void cb_TenKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            DLL.KhachHang data = _BLL_KhachHang.GetObjectFromTenKhachHang(cb_TenKhachHang.Text);
            if (data != null)
            {
                lb_MaKH.Text = data.MaKH.Trim();
                SetFormHoaDon();
                var loai = _LoaiKhachHang.GetObjectFromID(data.KHTT.Trim());
                if (loai == null)
                {
                    _BLL_VatLieu.MakeMessageBox(new BLL.BLLResult(12000777));
                    return;
                }
                lb_LoaiKH.Text = loai.TenLoaiKH.Trim();
                lb_HinhThucKM.Text = _LoaiKhachHang.GetTenKhuyenMai(lb_LoaiKH.Text);
                {// Set tình trạng theo tên KH
                    if (cb_TenKhachHang.Text == "[Không Tên]")
                    {
                        cb_TrangThai.SelectedIndex = 0;
                        cb_TrangThai.Enabled = false;
                    }
                    else
                        cb_TrangThai.Enabled = true;
                }
                // Màu
                if (loai.TenLoaiKH.Trim() == "Khách Hàng Vàng")
                    lb_LoaiKH.ForeColor = Color.Gold;
                else if (loai.TenLoaiKH.Trim() == "Khách Hàng Bạc")
                    lb_LoaiKH.ForeColor = Color.DimGray;
                else if (loai.TenLoaiKH.Trim() == "Khách Hàng Kim Cương")
                    lb_LoaiKH.ForeColor = Color.SteelBlue;
                else
                    lb_LoaiKH.ForeColor = Color.Black;
            }
            else
                lb_LoaiKH.ForeColor = Color.Black;
        }
      
        // Nhấn [Xóa tìm kiếm] :
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            //te_TimKiemVatLieu.Text = "";
        }

        // Khung tìm kiếm vật liệu trong hóa đơn:
        private void te_TimKiemVatLieuTrongHoaDon_EditValueChanged(object sender, EventArgs e)
        {
            //if (te_TimKiemVatLieuTrongHoaDon.Text != "")
            //{
            //    List<DLL.CTHoaDonBanHang> data = new List<DLL.CTHoaDonBanHang>();

            //    foreach (DLL.CTHoaDonBanHang mem in _ListVatLieuHoaDon)
            //        if (mem.TenVL.ToUpper().Contains(te_TimKiemVatLieuTrongHoaDon.Text.ToUpper()))
            //            data.Add(mem);

            //    grid_DanhSachVatLieuHoaDon.DataSource = data;
            //}
            //else
            //{
            //    grid_DanhSachVatLieuHoaDon.DataSource = _ListVatLieuHoaDon;
            //}
        }

        // Xử lý khi đóng
        private void HoaDonBanHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (!MakeBreak())
            //    return;
        }

        long SoLuongDVTGoc(DLL.VatLieu VatLieu)
        {
            if (cb_DonViTinh.Text.Trim() == VatLieu.DVT_Goc.Trim())
                return (long)nud_SoLuongMua.Value;
            else
            {
                var dvt = _DonViTinhVatLieu.GetObject(VatLieu.MaVL.Trim(), cb_DonViTinh.Text.Trim());
                if (dvt == null)
                {
                    _BLL_VatLieu.MakeMessageBox(new BLL.BLLResult(12000961));
                    return -1;
                }
                return (long)nud_SoLuongMua.Value * (long)dvt.TiLe;
            }
        }

        bool ThemVatLieuOK()
        {
            // Điền đủ 3 khung 
            if (_BLL_VatLieu.CheckNotInComboBox(cb_TenVatLieu)
                || nud_SoLuongMua.Value == 0
                || _BLL_VatLieu.CheckNotInComboBox(cb_DonViTinh))
                return false;
            // K đủ số lượng
            if (SoLuongVatLieu() < SoLuongDVTGoc(_BLL_VatLieu.GetObjectFromTenVL(cb_TenVatLieu.Text.Trim()))) 
            {
                MessageBox.Show("Vật liệu chỉ còn " + SoLuongVatLieu().ToString("# ### ###").Trim() + " " + (new BLL_VatLieu()).GetObjectFromTenVL(cb_TenVatLieu.Text).DVT_Goc.Trim() + "!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        void SetFormVatLieuHoaDon()
        {
            if (!ThemVatLieuOK())
            {
                ResetThemVatLieu();
                return;
            }
            // Lấy vật liệu
            var vl = _BLL_VatLieu.GetObjectFromTenVL(cb_TenVatLieu.Text.Trim());
            if (vl == null)
            {
                _BLL_VatLieu.MakeMessageBox(new BLL.BLLResult(12000963));
                return;
            }
            // Kiểm tra vật liệu đang chọn có trong ListVatLieuHoaDon chưa
            foreach (DLL.CTHoaDonBanHang var in _ListVatLieuHoaDon)
                if (var.TenVL.Trim() == cb_TenVatLieu.Text.Trim()) // Đã có trong LisVatLieuHoaDon
                {
                    if (_BLL_CTHoaDonBanHang.MakeMessageBox(new BLL.BLLResult("Vật liệu bạn chọn đã có trong danh sách vật liệu của hóa đơn! \nXóa vậy liệu này trong hóa đơn và thêm lại số lượng mới?"), MessageBoxButtons.YesNo) == DialogResult.Yes) // Đồng ý xóa
                    {
                        _ListVatLieuHoaDon.Remove(var);
                        LoadGridView(_ListVatLieuHoaDon);                        
                        break;
                    }
                    else // K đồng ý xóa thì reset phần thêm vật liệu
                    {
                        cb_TenVatLieu.SelectedText = "";
                        nud_SoLuongMua.Value = 0;
                        return;
                    }
                }
            SetFormHoaDon();
            _CTHDBHEditting = new DLL.CTHoaDonBanHang();
            // Số lượng KM, Tiền KM
            var km = _KhuyenMai.GetObjectFromMaVL(vl.MaVL.Trim());
            if (km == null || km.MaKM.Trim() != vl.MaKM.Trim()) // Ko có KM 
            {
                _CTHDBHEditting.SoLuongKM = 0;
                _CTHDBHEditting.TienKM = 0;
            }
            else // Có KM
            {
                long slkmtoithieu, slkmdvtgoc = 1;
                var dvt = _DonViTinhVatLieu.GetObject(km.MaVL.Trim(), km.DonViTinh.Trim());
                if (dvt == null) // ĐVT của KM là DVT gốc luôn
                {
                    slkmtoithieu = (long)km.SoLuongToiThieu;
                    slkmdvtgoc = (long)km.SoLuongKM;
                }
                else // Đổi số lượng tối thiểu, số lượng KM của KM ra số lượng của DVT gốc
                {
                    slkmtoithieu = (long)km.SoLuongToiThieu * (long)dvt.TiLe;
                    slkmdvtgoc = (long)km.SoLuongKM * (long)dvt.TiLe;
                }

                if (km.SoLuongKM == 0) // KM tiền
                {
                    _CTHDBHEditting.TienKM = (SoLuongDVTGoc(vl) / slkmtoithieu) * (long)km.TienKM;
                    _CTHDBHEditting.SoLuongKM = 0;
                }
                else // KM sp
                {
                    _CTHDBHEditting.SoLuongKM = (SoLuongDVTGoc(vl) / slkmtoithieu) * slkmdvtgoc;
                    _CTHDBHEditting.TienKM = 0;
                }
            }
            // Còn lại           
            _CTHDBHEditting.SoLuongMua = SoLuongDVTGoc(vl);
            _CTHDBHEditting.TongSL = SoLuongDVTGoc(vl) + _CTHDBHEditting.SoLuongKM;
            _CTHDBHEditting.DonViTinh = cb_DonViTinh.Text.Trim();
            _CTHDBHEditting.TenVL = cb_TenVatLieu.Text.Trim();
            _CTHDBHEditting.TenNCC = lb_TenNCC.Text.Trim();
            _CTHDBHEditting.GiaLe = vl.GiaBanLe;
            _CTHDBHEditting.GiaSi = vl.GiaBanSi;
            _CTHDBHEditting.SoLuongDeBanSi = vl.SoLuongBanSi;
            _CTHDBHEditting.TienKMKH = TienVatLieu(_CTHDBHEditting);
            _CTHDBHEditting.TongTien = (decimal)_CTHDBHEditting.TienKMKH - (decimal)_CTHDBHEditting.TienKM;
            var gettile = _DonViTinhVatLieu.GetObject(vl.MaVL.Trim(), cb_DonViTinh.Text.Trim());
            decimal tile;
            if (gettile == null)
                tile = 1;
            else
                tile = (decimal)gettile.TiLe;
            lb_TongSoLuong.Text = (_CTHDBHEditting.TongSL / tile).ToString() + " " + cb_DonViTinh.Text;
            lb_TongTienAddVatLieu.Text = ((decimal)_CTHDBHEditting.TongTien).ToString("# ### ###").Trim();
        }

        // Chọn tên vật liệu thì load lên form
        private void cb_TenVatLieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy vật liệu
            var vl = _BLL_VatLieu.GetObjectFromTenVL(cb_TenVatLieu.Text.Trim());
            if (vl == null)
            {
                //_BLL_VatLieu.MakeMessageBox(new BLL.BLLResult(12000941));
                return;
            }

            // Load giá của VL
            lb_GiaBanLe.Text = ((long)vl.GiaBanLe).ToString("# ### ###").Trim() + "/" + vl.DVT_Goc.Trim();
            if (vl.GiaBanSi == 0)
                lb_GiaBanSi.Text = "(Không bán sỉ)";
            else
            {
                lb_GiaBanSi.Text = ((long)vl.GiaBanSi).ToString("# ### ###").Trim() + "/" + ((long)vl.SoLuongBanSi).ToString() + " " + vl.DVT_Goc.Trim();
            }
            // Load Hình thức KM
            // Load NCC
            var ncc = _NhaCungCap.GetObjectFromID(vl.MaNCC.Trim());
            if (ncc == null)
            {
                _BLL_VatLieu.MakeMessageBox(new BLL.BLLResult(12000964));
                return;
            }
            lb_TenNCC.Text = ncc.TenNCC.Trim();

            // Load DVT
            cb_DonViTinh.Items.Clear();
            var listdvt = _DonViTinhVatLieu.GetDanhSachDonViTinhVatLieu(vl.MaVL.Trim());
            if (listdvt == null)
            {
                _BLL_VatLieu.MakeMessageBox(new BLL.BLLResult(12000911));
                return;
            }
            List<string> listnamedvt = new List<string>();
            foreach (DLL.DonViTinhVatLieu var in listdvt)
                listnamedvt.Add(_QuanLyDonViTinh.GetTenDVTFromMaDVT(var.MaDVT));
            listnamedvt.Add(vl.DVT_Goc.Trim());
            _BLL_CTHoaDonBanHang.MakeComboBoxNoAuto(cb_DonViTinh, listnamedvt);
            cb_DonViTinh.SelectedIndex = cb_DonViTinh.Items.Count - 1;

            // Load tình trạng vl
            var tt = _TinhTrangVatLieu.GetTenTinhTrangFromMaTinhTrang(vl.MaTinhTrang.Trim());
            if (tt == null)
            {
                _BLL_VatLieu.MakeMessageBox(new BLL.BLLResult(12000142));
                return;
            }

            // Tính toán
            SetFormVatLieuHoaDon();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void nud_SoLuongMua_ValueChanged(object sender, EventArgs e)
        {
            SetFormVatLieuHoaDon();
        }

        private void cb_DonViTinh_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetFormVatLieuHoaDon();
        }

        private void nud_SoLuongMua_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void nud_SoLuongMua_Validating(object sender, CancelEventArgs e)
        {

        }

        private void nud_SoLuongMua_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        void SetFormHoaDon()
        {
            if (_ListVatLieuHoaDon.Count == 0)
            {
                ResetThongKe();
                return;
            }

            // Thống kê
            long TongTienVatLieu = 0, TongTienKM = 0, TongTienTruocKM = 0, TongTien = 0, TienKMKH = 0;
            _IsKMSoLanMua = false;
            foreach (DLL.CTHoaDonBanHang var in _ListVatLieuHoaDon)
            {
                TongTienVatLieu += (long)var.TienKMKH;
                TongTienKM += (long)var.TienKM;
            }
            TongTienTruocKM = TongTienVatLieu - TongTienKM;
            TienKMKH = 0;
            TongTien = TongTienTruocKM;
            lb_TongTienVatLieu.Text = TongTienVatLieu.ToString("# ### ###").Trim();
            lb_TongTienKhuyenMai.Text = TongTienKM == 0 ? "(Không khuyến mãi)" : TongTienKM.ToString("# ### ###").Trim();

            // Tính TiềnKMKH
            TienKMKH = _BLL_HoaDonBanHang.GetTienKMKH(TongTienTruocKM, lb_MaKH.Text.Trim(), "");
            if (TienKMKH < 0) // KM dựa trên số lần mua
            {
                _IsKMSoLanMua = true;
                TienKMKH *= -1;
            }
            TongTien -= TienKMKH;
            lb_TongTien.Text = TongTien.ToString("# ### ###").Trim();
            iTongTien = TongTien;
        }

        long SoLuongVatLieu()
        {
            var ob = _BLL_VatLieu.GetObjectFromTenVL(cb_TenVatLieu.Text.Trim());
            if (ob == null)
                return 0;
            return (long)ob.SoLuong;
        }

        private void grid_VatLieu_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowindex = grid_VatLieu.SelectedCells[0].RowIndex;
            grid_VatLieu.Rows[rowindex].Selected = true;
        }

        private void btn_XemChiTietHoaDon_Click(object sender, EventArgs e)
        {            
            try
            {
                var listhd = _BLL_HoaDonBanHang.GetList();
                GUI.NghiepVu.XemHoaDonBanHang form = new NghiepVu.XemHoaDonBanHang(listhd[listhd.Count - 1].MaHDBH.Trim());
                form.main = null;
                form.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Không xem được, đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HoaDonBanHang_VisibleChanged(object sender, EventArgs e)
        {
            if (IsReset)
                if (MessageBox.Show("Cơ sở dữ liệu đã có thay đổi. \nBạn có muốn tắt tab này và mở lại để reset?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // Đồng ý mở lại
                {
                    mainform.ResetTab(mainform.IndexTabFormTenTab(E_FORM.BANHANG));
                    IsReset = false;
                }
        }

        private void labelControl15_Click(object sender, EventArgs e)
        {

        }

        // [+]
        private void btn_ThemVatLieu_Click(object sender, EventArgs e)
        {
            #region Kiểm tra            
            if (!ThemVatLieuOK())
            {
                _BLL_CTHoaDonBanHang.MakeMessageBox(new BLL.BLLResult("Vui lòng chọn vật liệu và số lượng lớn hơn 0!"));
                return;
            }
            var vl = _BLL_VatLieu.GetObjectFromTenVL(cb_TenVatLieu.Text.Trim());
            if (vl == null)
                return;
            // Số lượng còn đủ để bán hay không
            if (SoLuongDVTGoc(vl) > SoLuongVatLieu())
            {
                _BLL_CTHoaDonBanHang.MakeMessageBox(new BLL.BLLResult("Vật liệu bạn chọn không còn đủ số lượng! Vui lòng chọn số lượng nhỏ hơn."));
                return;
            }
            if (_BLL_CTHoaDonBanHang.CheckNotInComboBox(cb_TenKhachHang))
            {
                _BLL_CTHoaDonBanHang.MakeMessageBox(new BLL.BLLResult("Vui lòng chọn tên khách hàng!"));
                return;
            }
            #endregion

            // Hoàn thành biến _CTHDBHEditting
            _CTHDBHEditting.MaCTHDBH = _BLL_CTHoaDonBanHang.NewMaCTHDBH(_ListVatLieuHoaDon);
            _CTHDBHEditting.MaHDBH = lb_MaHDBH.Text;
            _CTHDBHEditting.Live = "True";
            if (tb_GhiChuVatLieu.Text == null || tb_GhiChuVatLieu.Text == "")
                _CTHDBHEditting.GhiChu = "<Không có ghi chú>";
            else
                _CTHDBHEditting.GhiChu = tb_GhiChuVatLieu.Text;

            // Thêm vào _ListVatLieuHoaDon và Reset
            _ListVatLieuHoaDon.Add(_CTHDBHEditting);
            LoadGridView(_ListVatLieuHoaDon);
            SetFormHoaDon();
            ResetThemVatLieu();
        }
    }
}