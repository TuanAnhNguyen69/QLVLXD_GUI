using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using QLVLXD.BLL;
using DevExpress.XtraTab;
using DevExpress.XtraTab.ViewInfo;
using QLVLXD.GUI;
using QLVLXD.GUI.TrangChu;

namespace QLVLXD
{
    public enum E_FORM { BANHANG, MUAHANG, VATLIEU, THONGKEBANHANG, TIENTE, NHANVIEN, NHACUNGCAP, KHACHHANG, LOAIKHACHHANG, USER, CAPNHATTAIKHOAN, CAUHINH, THONGKEMUAHANG, HOME };

    public partial class Main_Form : RibbonForm
    {
        public HoaDonBanHang frm_banhang; public
        GUI.HoaDonMuaHang frm_muahang; public
        GUI.NghiepVu.ThongKeBanHang frm_thongkebanhang; public
        GUI.NghiepVu.TienTeDonViTinhLoaiVatLieu frm_tiente; public
        VatLieu frm_vatlieu; public
        QuanLyThongTinNhanVien frm_nhanvien; public
        NhaCungCap frm_nhacungcap; public
        KhachHang frm_khachhang; public
        GUI.KH_NCC.QuyDinhKH_NCC frm_loaikhachhang;
        public GUI.TrangChu.Login2 frm_login; public
        GUI.NhanSu.QuanLyUser frm_user; public
        GUI.NhanSu.CapNhatTaiKhoan frm_capnhattaikhoan; public
        GUI.PhanMem.CauHinh frm_cauhinh;
        public GUI.NghiepVu.ThongKeMuaHang frm_thongkemuahang;
        GUI.TrangChu.Home frm_home;

        const int SOFORM = 14;
        bool[] IsOpen = new bool[SOFORM];
        string[] TitleTab = new string[SOFORM];
        public DLL.NhanVien _NhanVienLogining = new DLL.NhanVien();
        int _tabindex = 0;

        public Main_Form()
        {
            InitializeComponent();
        }

        public void SetTimerInterval(int Interval)
        {
            timer.Interval = Interval;
        }

        public bool IsOpened(E_FORM eform)
        {
            return IsOpen[(int)eform];
        }

        public void addTabPage(Form frm, String titleTab)
        {
            int i;
            for (i = 0; i < SOFORM; i++)
                if (titleTab == TitleTab[i])
                {
                    IsOpen[i] = true;
                    break;

                }

            XtraTabPage tabPage = new XtraTabPage();
            tabPage.Text = titleTab;
            frm.TopLevel = false;
            frm.AutoScroll = false;
            frm.Dock = DockStyle.Fill;
            frm.Parent = tabPage;

            this.tabcontrol.TabPages.Add(tabPage);
            this.tabcontrol.SelectedTabPageIndex = _tabindex;
            frm.Show();
            _tabindex++;
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {
        }
        
        public void btn_ThongKeMuaHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(E_FORM.THONGKEMUAHANG))
                SelectTab(E_FORM.THONGKEMUAHANG);
            else
            {
                frm_thongkemuahang = new GUI.NghiepVu.ThongKeMuaHang();
                this.addTabPage(frm_thongkemuahang, TitleTab[(int)E_FORM.THONGKEMUAHANG]);
                frm_thongkemuahang.mainform = this;
            }
        }

        // [Lập Hóa Đơn Mua Hàng]
        public void barButtonItem1_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(E_FORM.MUAHANG))
                SelectTab(E_FORM.MUAHANG);
            else
            {
                frm_muahang = new HoaDonMuaHang();
                this.addTabPage(frm_muahang, TitleTab[(int)E_FORM.MUAHANG]);
                frm_muahang.mainform = this;
            }
        }

        // [Quản Lý Vật Liệu]
        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsOpened(E_FORM.VATLIEU))
                SelectTab(E_FORM.VATLIEU);
            else
            {
                frm_vatlieu = new VatLieu();
                this.addTabPage(frm_vatlieu, TitleTab[(int)E_FORM.VATLIEU]);
            }
        }

        // [Lập Hóa Đơn Bán Hàng]
        public void btn_BanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(E_FORM.BANHANG))
                SelectTab(E_FORM.BANHANG);
            else
            {
                frm_banhang = new HoaDonBanHang();
                this.addTabPage(frm_banhang, TitleTab[(int)E_FORM.BANHANG]);
                frm_banhang.mainform = this;
                frm_banhang.SetNV(_NhanVienLogining);
            }
        }

        // [Close Tab]
        private void tabcontrol_CloseButtonClick(object sender, EventArgs e)
        {          
            ClosePageButtonEventArgs arg = e as ClosePageButtonEventArgs;
            if ((arg.Page as XtraTabPage).Text == TitleTab[(int)E_FORM.HOME])
                return;
            for (int i = 0; i < SOFORM; i++) // Set IsOpen false
                if ((arg.Page as XtraTabPage).Text == TitleTab[i])
                {
                    IsOpen[i] = false;
                    break;
                }
            (arg.Page as XtraTabPage).Dispose();
            if (_tabindex > 0)
                _tabindex--;
        }

        public int IndexTabFormTenTab(E_FORM eform)
        {
            int i;
            for (i = 0; i < tabcontrol.TabPages.Count; i++)
                if (tabcontrol.TabPages[i].Text == TitleTab[(int)eform])
                {
                    return i;
                }
            return 0;
        }

        public void SelectTab(E_FORM eform)
        {
            tabcontrol.SelectedTabPageIndex = IndexTabFormTenTab(eform);
        }

        // [Khởi động lại tab]
        public void ResetTab(int Index)
        {
            string nameindex = "";
            for (int i = 0; i < SOFORM; i++) // Set IsOpen false
            {
                if (tabcontrol.TabPages[Index].Text == TitleTab[i])
                {
                    IsOpen[i] = false;
                    nameindex = TitleTab[i];
                    break;
                }
            }

            tabcontrol.TabPages[Index].Dispose();
            if (_tabindex > 0)
                _tabindex--;

            if (nameindex == TitleTab[(int)E_FORM.BANHANG])
                btn_BanHang_ItemClick(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.MUAHANG])
                barButtonItem1_ItemClick_2(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.THONGKEBANHANG])
                btn_ThongKeBanHang_ItemClick(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.VATLIEU])
                barButtonItem6_ItemClick(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.TIENTE])
                btn_TienTeDVTTinhTrang_ItemClick(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.KHACHHANG])
                btn_KhachHang_ItemClick(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.NHACUNGCAP])
                btn_NhaCungCap_ItemClick(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.LOAIKHACHHANG])
                btn_LoaiKhachHang_ItemClick(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.CAPNHATTAIKHOAN])
                barButtonItem1_ItemClick(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.NHANVIEN])
                btn_QuanLyNhanVien_ItemClick(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.USER])
                btn_User_ItemClick(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.CAUHINH])
                btn_CauHinh_ItemClick(null, null);
            else if (nameindex == TitleTab[(int)E_FORM.THONGKEMUAHANG])
                btn_ThongKeMuaHang_ItemClick(null, null);
        }

        // [Close Tab dựa vào index]
        public void CloseTab(int Index)
        {
            for (int i = 0; i < SOFORM; i++) // Set IsOpen false
            {
                if (tabcontrol.TabPages[Index].Text == TitleTab[i])
                {
                    IsOpen[i] = false;
                    break;
                }
            }

            tabcontrol.TabPages[Index].Dispose();
            if (_tabindex > 0)
                _tabindex--;
        }

        // [Thống Kê Bán Hàng]
        public void btn_ThongKeBanHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(E_FORM.THONGKEBANHANG))
                SelectTab(E_FORM.THONGKEBANHANG);
            else
            {
                frm_thongkebanhang = new GUI.NghiepVu.ThongKeBanHang();
                this.addTabPage(frm_thongkebanhang, TitleTab[(int)E_FORM.THONGKEBANHANG]);
                frm_thongkebanhang.mainform = this;
            }
        }

        // [Tiền Tệ ... ]
        private void btn_TienTeDVTTinhTrang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsOpened(E_FORM.TIENTE))
                SelectTab(E_FORM.TIENTE);
            else
            {
                frm_tiente = new GUI.NghiepVu.TienTeDonViTinhLoaiVatLieu();
                this.addTabPage(frm_tiente, TitleTab[(int)E_FORM.TIENTE]);                
            }
        }

        // [Nhân Viên]
        private void btn_QuanLyNhanVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsOpened(E_FORM.NHANVIEN))
                SelectTab(E_FORM.NHANVIEN);
            else
            {
                frm_nhanvien = new QuanLyThongTinNhanVien();
                frm_nhanvien.mainform = this;
                this.addTabPage(frm_nhanvien, TitleTab[(int)E_FORM.NHANVIEN]);
            }
        }

        // [Loại Khách Hàng]
        private void btn_LoaiKhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsOpened(E_FORM.LOAIKHACHHANG))
                SelectTab(E_FORM.LOAIKHACHHANG);
            else
            {               
                frm_loaikhachhang = new GUI.KH_NCC.QuyDinhKH_NCC();
                frm_loaikhachhang.mainform = this;
                this.addTabPage(frm_loaikhachhang, TitleTab[(int)E_FORM.LOAIKHACHHANG]);
            }
        }

        // [Khách Hàng]
        private void btn_KhachHang_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsOpened(E_FORM.KHACHHANG))
                SelectTab(E_FORM.KHACHHANG);
            else
            {
                frm_khachhang = new KhachHang();
                frm_khachhang.mainform = this;
                this.addTabPage(frm_khachhang, TitleTab[(int)E_FORM.KHACHHANG]);
            }
        }

        // [Nhà Cung Cấp]
        private void btn_NhaCungCap_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsOpened(E_FORM.NHACUNGCAP))
                SelectTab(E_FORM.NHACUNGCAP);
            else
            {
                frm_nhacungcap = new NhaCungCap();
                frm_nhacungcap.mainform = this;
                this.addTabPage(frm_nhacungcap, TitleTab[(int)E_FORM.NHACUNGCAP]);
            }
        }

        private void Main_Form_Shown(object sender, EventArgs e)
        {
            // Thông báo hết hàng, giao hàng
            timer.Start();
           
            timer.Interval = (new BLL_CTHoaDonBanHang()).ReadConfig()._ThoiGianKiemTraCSDL * 60000;
            timer2.Start();
            strip_ThongBaoHetHang.ForeColor = Color.Red;
            chk_ThongBaoHetHang.Checked = true;
            chk_GiaoHang.Checked = true;
            strip_GiaoHang.Text = null;
            strip_ThongBaoHetHang.Text = (new BLL_VatLieu()).GetDanhSachHet();
            strip_GiaoHang.Text = (new BLL_HoaDonBanHang()).GetHanGiao();

            // Khởi tạo cho IsOpen và TitleTab
            for (int i = 0; i < SOFORM; i++)
                IsOpen[i] = false;
            TitleTab[(int)E_FORM.BANHANG] = "Lập Hóa Đơn Bán Hàng";
            TitleTab[(int)E_FORM.MUAHANG] = "Lập Hóa Đơn Mua Hàng";
            TitleTab[(int)E_FORM.THONGKEBANHANG] = "Thống Kê Bán Hàng";
            TitleTab[(int)E_FORM.VATLIEU] = " Quản Lý Vật Liệu";
            TitleTab[(int)E_FORM.TIENTE] = "Tiền Tệ - Đơn Vị Tính - Tình Trạng Vật Liệu";
            TitleTab[(int)E_FORM.NHANVIEN] = "Quản Lý Thông Tin Nhân Viên";
            TitleTab[(int)E_FORM.NHACUNGCAP] = "Nhà Cung Cấp";
            TitleTab[(int)E_FORM.KHACHHANG] = "Khách Hàng";
            TitleTab[(int)E_FORM.LOAIKHACHHANG] = "Loại Khách Hàng";
            TitleTab[(int)E_FORM.USER] = "Quản Lý User";
            TitleTab[(int)E_FORM.CAPNHATTAIKHOAN] = "Cập Nhật Tài Khoản";
            TitleTab[(int)E_FORM.CAUHINH] = "Cấu Hình";
            TitleTab[(int)E_FORM.THONGKEMUAHANG] = "Thống Kê Mua Hàng";
            TitleTab[(int)E_FORM.HOME] = "HOME";

            frm_home = new GUI.TrangChu.Home();
            this.addTabPage(frm_home, TitleTab[(int)E_FORM.HOME]);
            frm_home.mainform = this;

            this.frm_login.Visible = false;
        }

        private void Main_Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.frm_login.Close();
        }

        // [User]
        private void btn_User_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsOpened(E_FORM.USER))
                SelectTab(E_FORM.USER);
            else
            {
                frm_user = new GUI.NhanSu.QuanLyUser();
                this.addTabPage(frm_user, TitleTab[(int)E_FORM.USER]);
            }
        }

        // [Cập nhật tài khoản]
        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (IsOpened(E_FORM.CAPNHATTAIKHOAN))
                SelectTab(E_FORM.CAPNHATTAIKHOAN);
            else
            {
                frm_capnhattaikhoan = new GUI.NhanSu.CapNhatTaiKhoan();
                frm_capnhattaikhoan._NhanVien = _NhanVienLogining;
                frm_capnhattaikhoan.mainform = this;
                this.addTabPage(frm_capnhattaikhoan, TitleTab[(int)E_FORM.CAPNHATTAIKHOAN]);
            }
        }

        // [Thoát]
        private void btn_Thoat_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Thoát chương trình?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void btn_About_ItemClick(object sender, ItemClickEventArgs e)
        { }

        // [Cấu Hình]
        private void btn_CauHinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            if ((new BLL_User()).IsUser())
            {
                MessageBox.Show("Chức năng dành cho Admin, User thường không sử dụng được!", "Giới hạn quyền sử dụng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsOpened(E_FORM.CAUHINH))
                SelectTab(E_FORM.CAUHINH);
            else
            {
                frm_cauhinh = new GUI.PhanMem.CauHinh();
                frm_cauhinh.mainform = this;
                this.addTabPage(frm_cauhinh, TitleTab[(int)E_FORM.CAUHINH]);
            }
        }

        // [Timer check CSDL]
        private void timer_Tick(object sender, EventArgs e)
        {
            if (chk_ThongBaoHetHang.Checked)
                strip_ThongBaoHetHang.Text = (new BLL_VatLieu()).GetDanhSachHet();

            if (chk_GiaoHang.Checked)
                strip_GiaoHang.Text = (new BLL_HoaDonBanHang()).GetHanGiao();
        }

        // [Timer hiển thị]
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (chk_ThongBaoHetHang.Checked)
                strip_ThongBaoHetHang.Visible = strip_ThongBaoHetHang.Visible ? false : true;
            else
                strip_ThongBaoHetHang.Visible = false;

            if (chk_GiaoHang.Checked)
            {
                if (chk_ThongBaoHetHang.Checked)
                    strip_GiaoHang.Visible = !strip_ThongBaoHetHang.Visible;
                else
                    strip_GiaoHang.Visible = strip_GiaoHang.Visible ? false : true;
            }
            else
                strip_GiaoHang.Visible = false;
        }

        // Click thông báo hết hàng
        private void strip_HetHang_Click(object sender, EventArgs e)
        {
            if (strip_ThongBaoHetHang.Visible && strip_ThongBaoHetHang.Text != null)
                barButtonItem1_ItemClick_2(null, null);
            if (strip_GiaoHang.Visible && strip_GiaoHang.Text != null)
            {
                btn_ThongKeBanHang_ItemClick(null, null);
                frm_thongkebanhang.SetLocChuaGiao();
            }
        }

        // [Chuyển User]
        private void btn_ChuyenUser_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Chuyển User?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                frm_login.Reset();
                this.Dispose();
            }
        }
    }
}