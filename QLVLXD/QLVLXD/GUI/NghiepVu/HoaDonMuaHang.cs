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
    public partial class HoaDonMuaHang : DevExpress.XtraEditors.XtraForm
    {
        BLL.BLL_VatLieu _BLL_VatLieu = new BLL.BLL_VatLieu();
        BLL.BLL_CTHoaDonMuaHang _BLL_CTHoaDonMuaHang = new BLL.BLL_CTHoaDonMuaHang();
        BLL.BLL_HoaDonMuaHang _BLL_HoaDonMuaHang = new BLL.BLL_HoaDonMuaHang();
        BLL.BLL_NhanVien _BLL_NhanVien = new BLL.BLL_NhanVien();
        BLL.BLL_NhaCungCap _BLL_NhaCungCap = new BLL.BLL_NhaCungCap();

        List<DLL.CTHoaDonMuaHang> _ListVatLieuHoaDon = new List<DLL.CTHoaDonMuaHang>();
        List<string> _ListMaCTHDMH_New = new List<string>();
        List<DLL.CTHoaDonMuaHang> _ListCTHoaDonMuaHang = new List<DLL.CTHoaDonMuaHang>();
        List<DLL.HoaDonMuaHang> _List_HoaDonMuaHang = new List<DLL.HoaDonMuaHang>();
        List<DLL.VatLieu> _List_Them = new List<DLL.VatLieu>();
        List<DLL.CTHoaDonMuaHang> _List_Bot = new List<DLL.CTHoaDonMuaHang>();
        DLL.NhanVien _NhanVien = new DLL.NhanVien();

        bool IsAddNew;
        decimal TongTien = 0;
        public Main_Form mainform;
        public bool IsReset;

        public HoaDonMuaHang()
        {
            InitializeComponent();

            _List_HoaDonMuaHang = _BLL_HoaDonMuaHang.GetList();
            _ListCTHoaDonMuaHang = _BLL_CTHoaDonMuaHang.GetListAll();

            // Nhân viên
            _NhanVien = _BLL_NhanVien.GetObjectFromID(_BLL_NhanVien.ReadNV());
            lb_TenNhanVien.Text = _NhanVien.TenNV.Trim();
            lb_MaNV.Text = _NhanVien.MaNV.Trim();

            ResetForNewInsert();
        }

        void ResetForNewInsert()
        {
            lb_MaHDMH.Text = _BLL_HoaDonMuaHang.NewMaHDMH();
            lb_NgayMua.Text = DateTime.Today.ToShortDateString();
            lb_MaNCC.Text = "(Mã Khách Hàng)";
            lb_TongTien.Text = "0 VNĐ";
            lb_SoVatLieu.Text = "0";
            nud_SoLuong.Value = 10;
            dt_NgayMua.Visible = false;

            _ListVatLieuHoaDon.Clear();
            _ListMaCTHDMH_New.Clear();
            _List_Bot.Clear();
            _List_Them.Clear();

            IsAddNew = true;
            btn_Them.Visible = true;
            btn_Xoa.Visible = false;
            btn_AddVatLieu.Enabled = true;
            btn_DeleteVatLieu.Enabled = true;
            lb_MaHDMH.ForeColor = Color.Green;

            grid_DanhSachHoaDonMuaHang.DataSource = null;
            grid_DanhSachVatLieuCuaHang.DataSource = null;
            grid_DanhSachVatLieuCuaHang.DataSource = _BLL_VatLieu.GetList();
            grid_DanhSachHoaDonMuaHang.DataSource = _BLL_HoaDonMuaHang.GetList();
            grid_DanhSachVatLieuHoaDon.DataSource = null;

            ResetSearch();
        }

        //Return true là cho chuyển
        bool MakeBreak()
        {
            if (_List_Them.Count == 0 && _List_Bot.Count == 0)
                return true;

            DialogResult res = MessageBox.Show("Hủy những vật liệu đã chỉnh sửa?", "Thông báo", MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes) // Phục hồi
            {
                // Cập nhật lại số lượng vật liệu đã lỡ thêm
                foreach (DLL.VatLieu mem in _List_Them)
                {
                    _BLL_VatLieu.UpdateSoLuongPlus(mem.MaVL.Trim(), (decimal)mem.SoLuong);

                    // Cập nhật lại list vl hd (đéo hiểu tại sao fải cập nhật cái này) :
                    foreach (DLL.CTHoaDonMuaHang mem2 in _ListVatLieuHoaDon)
                        if (mem2.MaVL.Trim() == mem.MaVL.Trim())
                        {
                            mem2.SoLuong -= (decimal)mem.SoLuong;
                            break;
                        }
                }

                _List_Them.Clear();

                // Danh sách bớt
                foreach (DLL.CTHoaDonMuaHang mem in _List_Bot)
                {
                    _BLL_VatLieu.UpdateSoLuongPlus(mem.MaVL.Trim(), -mem.SoLuong);
                }

                _List_Bot.Clear();

                grid_DanhSachVatLieuCuaHang.DataSource = _BLL_VatLieu.GetListForBanHang();
                return true;
            }
            else
                return false;
        }

        // Hàm trống!!
        private void HoaDonMuaHang_Load(object sender, EventArgs e)
        {
        }

        // Nút thêm vật liệu [>>] :
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // ---------------------------------------------------------
            // Kiểm tra các trường hợp lỗi trước:
            // ---------------------------------------------------------

            // Lỗi không chọn hàng nào trong bảng:
            if (gridView1.SelectedRowsCount != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 vật liệu để thêm vào!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto del_timkiem;
            }

            // Lỗi nhập số lượng nhỏ hơn 1
            if (nud_SoLuong.Value < 1)
            {
                MessageBox.Show("Vui lòng nhập số lượng vật liệu lớn hơn 0!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int[] selectedindex = gridView1.GetSelectedRows();
            QLVLXD.DLL.VatLieu vatlieudangchon = (QLVLXD.DLL.VatLieu)gridView1.GetRow(selectedindex[0]);

            // ---------------------------------------------------------
            // Thêm vào ds vl hóa đơn:
            // ---------------------------------------------------------

            bool haveinlist = false;
            decimal tientang = nud_SoLuong.Value * (decimal)vatlieudangchon.GiaMua;

            // Nếu có trong list vl hóa đơn rồi thì chỉ cộng số lượng thôi
            foreach (DLL.CTHoaDonMuaHang mem in _ListVatLieuHoaDon)
                if (vatlieudangchon.MaVL.Trim() == mem.MaVL.Trim())
                {
                    mem.SoLuong += nud_SoLuong.Value;
                    mem.TongTien += tientang;
                    haveinlist = true;
                    break;
                }

            // Còn không có trong list vl hóa đơn thì thêm mới vào list vl hóa đơn:
            if (!haveinlist)
            {
                DLL.CTHoaDonMuaHang add = new DLL.CTHoaDonMuaHang();
                add.MaHDMH = lb_MaHDMH.Text;
                add.Live = "True";
                add.DonViTinh = vatlieudangchon.DVT_Goc;
                add.MaVL = vatlieudangchon.MaVL;
                add.SoLuong = nud_SoLuong.Value;
                add.TenVL = vatlieudangchon.TenVL;
                add.TongTien = tientang;

                List<string> DS_MaCTHDMH = new List<string>();
                foreach (DLL.CTHoaDonMuaHang mem in _ListCTHoaDonMuaHang)
                    DS_MaCTHDMH.Add(mem.MaCTHDMH.Trim());

                if (_ListMaCTHDMH_New.Count > 0)
                    foreach (string mem in _ListMaCTHDMH_New)
                        DS_MaCTHDMH.Add(mem);

                add.MaCTHDMH = _BLL_CTHoaDonMuaHang.NewMaCTHDMH(DS_MaCTHDMH);
                _ListMaCTHDMH_New.Add(add.MaCTHDMH);

                _ListVatLieuHoaDon.Add(add);
            }

            // Cập nhật lb_TongTien, lb_SoVatLieu
            TongTien += tientang;
            lb_TongTien.Text = ((long)TongTien).ToString("### ### ### ###").Trim() + " VNĐ";
            lb_SoVatLieu.Text = _ListVatLieuHoaDon.Count.ToString();

            // Cập nhật lại bảng
            grid_DanhSachVatLieuHoaDon.DataSource = null;
            grid_DanhSachVatLieuHoaDon.DataSource = _ListVatLieuHoaDon;

            del_timkiem:// ---------------------------------------------------------
            // Reset khung tìm kiếm:
            // ---------------------------------------------------------
            ResetSearch();
        }

        void ResetSearch()
        {
            if (te_TimKiemVatLieu.Text != "")
                te_TimKiemVatLieu.Text = "";

            if (te_TimKiemHDMH.Text != "")
                te_TimKiemHDMH.Text = "";

            if (te_TimKiemVatLieuTrongHoaDon.Text != "")
                te_TimKiemVatLieuTrongHoaDon.Text = "";
        }

        // Nhấn [Reset để thêm mới]:
        private void btn_Reset_Click(object sender, EventArgs e)
        {

            if (!MakeBreak())
                return;

            ResetForNewInsert();
        }

        // Khi bấm vào 1 dòng trong danh sách vật liệu của cửa hàng thì cập nhật lb_DonViTinh
        private void grid_DanhSachVatLieuCuaHang_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount != 1)
                return;

            int[] selectedindex = gridView1.GetSelectedRows();
            QLVLXD.DLL.VatLieu vatlieudangchon = (QLVLXD.DLL.VatLieu)gridView1.GetRow(selectedindex[0]);
            lb_DonViTinh.Text = vatlieudangchon.DVT_Goc.Trim();
            var ncc = _BLL_NhaCungCap.GetObjectFromID(vatlieudangchon.MaNCC.Trim());
            lb_TenNCC.Text = ncc.TenNCC.Trim();
            lb_MaNCC.Text = ncc.MaNCC.Trim();
        }

        // Thoát form
        private void HoaDonMuaHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!MakeBreak())
                e.Cancel = true;
        }

        // Khi chọn Tên nhân viên thì đổi mã nhân viên
        private void lb_TenNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Kiểm tra đã nhập đủ hay chưa:
        private bool CheckInput()
        {
            if (_ListVatLieuHoaDon.Count < 1)
            {
                MessageBox.Show("Vui lòng thêm vật liệu cho hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!IsAddNew && dt_NgayMua.DateTime > DateTime.Today)
            {
                MessageBox.Show("Vui lòng chọn ngày mua là từ ngày hiện tại trở về trước!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        // Bấm nút Thêm [Thêm]:
        private void btn_Them_Click(object sender, EventArgs e)
        {
            // ---------------------------------------------------------
            // Reset khung tìm kiếm:
            // ---------------------------------------------------------
            te_TimKiemVatLieu.Text = "";

            if (!IsAddNew || !CheckInput())
            {
                ResetSearch();
                return;
            }

            DLL.NhaCungCap kh = _BLL_NhaCungCap.GetObjectFromID(lb_MaNCC.Text);

            // Thêm HDMH trước
            string result = _BLL_HoaDonMuaHang.Insert(lb_MaHDMH.Text, DateTime.Today, lb_TenNhanVien.Text, lb_MaNV.Text, lb_MaNCC.Text, lb_TenNCC.Text, kh.SDT, TongTien);

            if (result != "Success")
            {
                if (result != "Error")
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else //this.Close();
                    MessageBox.Show("Không thể thêm mới! Đã có lỗi xảy ra, vui lòng kiểm tra lại dữ liệu nhập vào cũng như là cơ sở dữ liệu! (Mã lỗi 9658)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ResetSearch();
                return;
            }

            // Thêm các CTHDMH
            result = _BLL_CTHoaDonMuaHang.Insert(_ListVatLieuHoaDon);

            if (result == "Error")
            {
                MessageBox.Show("Không thể thêm mới! Đã có lỗi xảy ra, vui lòng kiểm tra lại dữ liệu nhập vào cũng như là cơ sở dữ liệu! (Mã lỗi 94444)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                _BLL_HoaDonMuaHang.Delete(lb_MaHDMH.Text);

                ResetSearch();
                return;
            }

            _ListCTHoaDonMuaHang = _BLL_CTHoaDonMuaHang.GetListAll();
            _List_HoaDonMuaHang.Clear();
            _List_HoaDonMuaHang = _BLL_HoaDonMuaHang.GetList();

            ResetForNewInsert();
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            try { mainform.frm_thongkemuahang.IsReset = true; } catch { }
            try { mainform.frm_banhang.IsReset = true; } catch { }
        }

        // Bấm nút [<<]:
        private void btn_DeleteVatLieu_Click(object sender, EventArgs e)
        {
            // ---------------------------------------------------------
            // Kiểm tra các trường hợp lỗi trước:
            // ---------------------------------------------------------

            // Lỗi không chọn hàng nào trong bảng:
            if (gridView2.SelectedRowsCount != 1)
            {
                MessageBox.Show("Vui lòng chọn 1 vật liệu để bớt ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                goto del_timkiem2;
            }

            int[] selectedindex = gridView2.GetSelectedRows();
            QLVLXD.DLL.CTHoaDonMuaHang vatlieudangchon = (QLVLXD.DLL.CTHoaDonMuaHang)gridView2.GetRow(selectedindex[0]);

            if (_BLL_VatLieu.GetObjectFromID(vatlieudangchon.MaVL) == null)
            {
                MessageBox.Show("Vậy liệu bạn chọn không còn trong Cơ sở dữ liệu, vui lòng chọn vật liệu khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Nếu có trong mã mới thì xóa trong list này
            bool haveinlist = false;
            foreach (string mem in _ListMaCTHDMH_New)
                if (vatlieudangchon.MaCTHDMH.Trim() == mem)
                {
                    haveinlist = true;
                    _ListMaCTHDMH_New.Remove(mem);
                    break;
                }

            // Phần phục hồi            
            DLL.CTHoaDonMuaHang ct = new DLL.CTHoaDonMuaHang();
            ct.MaVL = vatlieudangchon.MaVL;
            ct.MaHDMH = vatlieudangchon.MaHDMH;
            ct.MaCTHDMH = vatlieudangchon.MaCTHDMH;
            ct.SoLuong = vatlieudangchon.SoLuong;
            _List_Bot.Add(ct);

            // Cập nhật lb_TongTien, lb_SoVatLieu
            TongTien -= vatlieudangchon.TongTien;
            lb_TongTien.Text = ((long)TongTien).ToString("### ### ### ###").Trim() + " VNĐ";
            lb_SoVatLieu.Text = (_ListVatLieuHoaDon.Count - 1).ToString();

            // Cập nhật lại số lượng (đéo hiểu) :
            if (!haveinlist)
            {
                foreach (DLL.VatLieu vl in _List_Them)
                    if (vl.MaVL.Trim() == vatlieudangchon.MaVL.Trim())
                        vatlieudangchon.SoLuong -= (decimal)vl.SoLuong;
            }

            // Cập nhật _ListVatLieuHoaDon
            _ListVatLieuHoaDon.Remove(vatlieudangchon);

            // Cập nhật lại bảng
            grid_DanhSachVatLieuCuaHang.DataSource = _BLL_VatLieu.GetListForBanHang();
            grid_DanhSachVatLieuHoaDon.DataSource = null;
            grid_DanhSachVatLieuHoaDon.DataSource = _ListVatLieuHoaDon;

            del_timkiem2:
            ResetSearch();
        }

        // Khi chọn Tên khách hàng thì đổi mã NCC
        private void lb_TenNCC_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        // Bấm vào bảng danh sách HDMH khác thì cập nhật form:
        private void grid_DanhSachHoaDonMuaHang_MouseCaptureChanged(object sender, EventArgs e)
        {
            if (gridView3.SelectedRowsCount != 1)
                return;

            if (!MakeBreak())
                return;

            IsAddNew = false;
            btn_Them.Visible = false;
            btn_AddVatLieu.Enabled = false;
            btn_DeleteVatLieu.Enabled = false;
            btn_Xoa.Visible = true;
            lb_MaHDMH.ForeColor = Color.Red;
            dt_NgayMua.Visible = true;

            int[] selectedindex = gridView3.GetSelectedRows();
            DLL.HoaDonMuaHang hoadondangchon = (QLVLXD.DLL.HoaDonMuaHang)gridView3.GetRow(selectedindex[0]);

            lb_MaHDMH.Text = hoadondangchon.MaHDMH.Trim();
            dt_NgayMua.DateTime = hoadondangchon.NgayMua;
            lb_MaNV.Text = hoadondangchon.MaNV.Trim();
            lb_TenNhanVien.Text = hoadondangchon.TenNV.Trim();
            TongTien = (long)hoadondangchon.TongTien;
            lb_TongTien.Text = TongTien.ToString() + " VNĐ";
            lb_MaNCC.Text = hoadondangchon.MaNCC.Trim();
            lb_TenNCC.Text = hoadondangchon.TenNCC.Trim();

            _ListVatLieuHoaDon.Clear();
            _ListMaCTHDMH_New.Clear();

            _ListVatLieuHoaDon = _BLL_CTHoaDonMuaHang.GetListCTHoaDonMuaHang(hoadondangchon.MaHDMH.Trim());

            lb_SoVatLieu.Text = _ListVatLieuHoaDon.Count.ToString();

            //grid_DanhSachVatLieuHoaDon.DataSource = null;
            grid_DanhSachVatLieuHoaDon.DataSource = _ListVatLieuHoaDon;

        }

        // Bấm nút [Xóa] :
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            te_TimKiemVatLieu.Text = "";

            if (gridView3.SelectedRowsCount != 1)
            {
                ResetSearch();
                return;
            }

            int[] selectedindex = gridView3.GetSelectedRows();
            DLL.HoaDonMuaHang hoadondangchon = (QLVLXD.DLL.HoaDonMuaHang)gridView3.GetRow(selectedindex[0]);

            BLLResult result = _BLL_HoaDonMuaHang.Delete(lb_MaHDMH.Text.Trim());

            if (result._Code != (int)BLLResultType.S_DELETE)
            {
                _BLL_CTHoaDonMuaHang.MakeMessageBox(result);
                return;
            }

            ResetForNewInsert();

            _List_HoaDonMuaHang.Clear();
            _List_HoaDonMuaHang = _BLL_HoaDonMuaHang.GetList();

            grid_DanhSachHoaDonMuaHang.DataSource = null;
            grid_DanhSachHoaDonMuaHang.DataSource = _List_HoaDonMuaHang;

            ResetSearch();
            try { mainform.frm_thongkemuahang.IsReset = true; } catch { }
            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Bấm nút [Cập nhật] :
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            te_TimKiemVatLieu.Text = "";

            if (IsAddNew || !CheckInput())
            {
                ResetSearch();
                return;
            }

            DLL.NhaCungCap kh = _BLL_NhaCungCap.GetObjectFromID(lb_MaNCC.Text);

            //Phần có lỗi thì phục hòi lại
            DLL.HoaDonMuaHang oldget = _BLL_HoaDonMuaHang.GetObjectFromID(lb_MaHDMH.Text.Trim());
            DLL.HoaDonMuaHang old = new DLL.HoaDonMuaHang();
            old.MaHDMH = oldget.MaHDMH.Trim();
            old.MaNCC = oldget.MaNCC;
            old.Live = "True";
            old.MaNV = oldget.MaNV;
            old.SDTNCC = oldget.SDTNCC;
            old.TenNV = oldget.TenNV;
            old.TongTien = oldget.TongTien;
            old.TenNCC = oldget.TenNCC;
            old.NgayMua = oldget.NgayMua;

            //Cập nhật HDMH trước
            string result = _BLL_HoaDonMuaHang.Update(lb_MaHDMH.Text.Trim(), dt_NgayMua.DateTime, lb_TenNhanVien.Text, lb_MaNV.Text, lb_MaNCC.Text, lb_TenNCC.Text, kh.SDT, TongTien);

            if (result != "Success")
            {
                if (result != "Error")
                    MessageBox.Show(result, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Không thể cập nhật! Đã có lỗi xảy ra, vui lòng kiểm tra lại dữ liệu nhập vào cũng như là cơ sở dữ liệu! (Mã lỗi 9874)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ResetSearch();
                return;
            }

            // Cập nhật các CTHDMH
            result = _BLL_CTHoaDonMuaHang.Update(_ListVatLieuHoaDon);

            if (result == "Error")
            {
                MessageBox.Show("Không thể cập nhật! Đã có lỗi xảy ra, vui lòng kiểm tra lại dữ liệu nhập vào cũng như là cơ sở dữ liệu! (Mã lỗi 9857)", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Nếu sai thì phục hồi cập nhật HDMH
                _BLL_HoaDonMuaHang.Update(old.MaHDMH, old.NgayMua, old.TenNV, old.MaNV, old.MaNCC, old.TenNCC, old.SDTNCC, old.TongTien);

                ResetSearch();
                return;
            }

            ResetForNewInsert();

            _ListCTHoaDonMuaHang = _BLL_CTHoaDonMuaHang.GetListAll();

            _List_HoaDonMuaHang.Clear();
            _List_HoaDonMuaHang = _BLL_HoaDonMuaHang.GetList();

            grid_DanhSachHoaDonMuaHang.DataSource = null;
            grid_DanhSachHoaDonMuaHang.DataSource = _List_HoaDonMuaHang;

            ResetSearch();

            MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Khung tìm kiếm vật liệu của cửa hàng:
        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {
            if (te_TimKiemVatLieu.Text != "")
            {
                List<DLL.VatLieu> listvl = _BLL_VatLieu.GetListForBanHang();
                List<DLL.VatLieu> data = new List<DLL.VatLieu>();

                foreach (DLL.VatLieu mem in listvl)
                    if (mem.TenVL.ToUpper().Contains(te_TimKiemVatLieu.Text.ToUpper()))
                        data.Add(mem);

                grid_DanhSachVatLieuCuaHang.DataSource = data;
            }
            else
            {
                grid_DanhSachVatLieuCuaHang.DataSource = _BLL_VatLieu.GetListForBanHang();
            }
        }

        // Thay đổi tên thì sửa mã:
        private void lb_TenNhanVien_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DLL.NhanVien data = _BLL_NhanVien.GetObjectFromTenNhanVien(lb_TenNhanVien.Text);
            if (data != null)
            {
                lb_MaNV.Text = data.MaNV.Trim();
            }
        }

        // Nhấn [Xóa tìm kiếm] :
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            te_TimKiemVatLieu.Text = "";
        }

        // Nhấn [Xóa tìm kiếm HDMH] :
        private void btn_XoaTimKiemHDMH_Click(object sender, EventArgs e)
        {
            te_TimKiemHDMH.Text = "";
        }

        // Nhấn [Xóa tìm kiếm Vật liệu trong Hóa đơn] :
        private void btn_XoaTimKiemVatLieuTrongHoaDon_Click(object sender, EventArgs e)
        {
            te_TimKiemVatLieuTrongHoaDon.Text = "";
        }

        // Khung tìm kiếm vật liệu trong hóa đơn:
        private void te_TimKiemVatLieuTrongHoaDon_EditValueChanged(object sender, EventArgs e)
        {
            if (te_TimKiemVatLieuTrongHoaDon.Text != "")
            {
                List<DLL.CTHoaDonMuaHang> data = new List<DLL.CTHoaDonMuaHang>();

                foreach (DLL.CTHoaDonMuaHang mem in _ListVatLieuHoaDon)
                    if (mem.TenVL.ToUpper().Contains(te_TimKiemVatLieuTrongHoaDon.Text.ToUpper()))
                        data.Add(mem);

                grid_DanhSachVatLieuHoaDon.DataSource = data;
            }
            else
            {
                grid_DanhSachVatLieuHoaDon.DataSource = _ListVatLieuHoaDon;
            }
        }
        // Xử lý khi đóng
        private void HoaDonMuaHang_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!MakeBreak())
                return;
        }

        // Khung tìm kiếm HDMH
        private void te_TimKiemHDMH_EditValueChanged(object sender, EventArgs e)
        {
            if (te_TimKiemHDMH.Text != "")
            {
                List<DLL.HoaDonMuaHang> data = new List<DLL.HoaDonMuaHang>();

                foreach (DLL.HoaDonMuaHang mem in _List_HoaDonMuaHang)
                    if (mem.TenNCC.ToUpper().Contains(te_TimKiemHDMH.Text.ToUpper()) || mem.TenNV.ToUpper().Contains(te_TimKiemHDMH.Text.ToUpper()))
                        data.Add(mem);

                grid_DanhSachHoaDonMuaHang.DataSource = data;
            }
            else
            {
                grid_DanhSachHoaDonMuaHang.DataSource = _List_HoaDonMuaHang;
            }
        }

        // Tmp
        private void labelControl10_Click(object sender, EventArgs e)
        {
        }

        // Tmp
        private void lb_DonViTinh_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(_ListVatLieuHoaDon.Count.ToString());
        }

        private void lb_TenNCC_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            DLL.NhaCungCap data = _BLL_NhaCungCap.GetObjectFromTenNhaCungCap(lb_TenNCC.Text);
            if (data != null)
            {
                lb_MaNCC.Text = data.MaNCC.Trim();
            }
        }

        private void HoaDonMuaHang_VisibleChanged(object sender, EventArgs e)
        {
            if (IsReset)
                if (MessageBox.Show("Cơ sở dữ liệu đã có thay đổi. \nBạn có muốn tắt tab này và mở lại để reset?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) // Đồng ý mở lại
                {
                    mainform.ResetTab(mainform.IndexTabFormTenTab(E_FORM.MUAHANG));
                    IsReset = false;
                }
        }
    }
}