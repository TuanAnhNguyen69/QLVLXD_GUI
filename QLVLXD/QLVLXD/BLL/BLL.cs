
using System;
using System.Collections.Generic;
using System.Linq;
using QLVLXD.DLL;
using System.Windows.Forms;
using app = Microsoft.Office.Interop.Excel.Application;
using System.IO;

namespace QLVLXD.BLL
{
    enum BLLResultType { SUCCESS, S_ADD, S_UPDATE, S_DELETE, NOT_EXIST, NOT_DELETE };

    struct BLLResult
    {
        public MessageBoxIcon _Icon;
        public string _Content;
        public int _Code; // Lỗi chủ quan: 111, lỗi exception > 1000

        public bool IsErrorException() { return _Code > 1000; }
        public BLLResult(MessageBoxIcon Icon, string Content, int Code) { _Code = Code; _Icon = Icon; _Content = Content; }

        public BLLResult(string Content)
        {
            _Icon = MessageBoxIcon.Error;
            _Content = Content;
            _Code = 111;
        }

        public BLLResult(int iCode)
        {
            _Code = iCode;
            if (iCode == (int)BLLResultType.SUCCESS)
            {
                _Icon = MessageBoxIcon.Information; _Content = "Success";
            }
            else if (iCode == (int)BLLResultType.S_ADD)
            {
                _Icon = MessageBoxIcon.Information; _Content = "Thêm thành công!";
            }
            else if (iCode == (int)BLLResultType.S_DELETE)
            {
                _Icon = MessageBoxIcon.Information; _Content = "Xóa thành công!";
            }
            else if (iCode == (int)BLLResultType.S_UPDATE)
            {
                _Icon = MessageBoxIcon.Information; _Content = "Cập nhật thành công!";
            }
            else if (iCode == (int)BLLResultType.NOT_DELETE)
            {
                _Icon = MessageBoxIcon.Information; _Content = "Không xóa dữ liệu";
            }
            else if (iCode == (int)BLLResultType.NOT_EXIST)
            {
                _Icon = MessageBoxIcon.Error; _Content = "Dữ liệu không tồn tại!";
            }
            else // Lỗi khác
            {
                _Icon = MessageBoxIcon.Error; _Content = "[Error] Đã có lỗi truy suất dữ liệu xảy ra! (Mã lỗi " + iCode.ToString() + ")";
            }
        }
    }

    public struct Config
    {
        public int _SoLuongToiThieu;
        public int _ThoiGianKiemTraCSDL;
    }

    class BLL
    {
        protected QLVLXD_DATABASEDataContext DB = new QLVLXD_DATABASEDataContext();
        public int _SoLuongVatLieuToiThieu = 100;

        public BLL()
        {
            _SoLuongVatLieuToiThieu = ReadConfig()._SoLuongToiThieu;
        }

        public void MakeComboBox(System.Windows.Forms.ComboBox MSComBoBox, List<string> DanhSach)
        {
            System.Windows.Forms.AutoCompleteStringCollection str = new System.Windows.Forms.AutoCompleteStringCollection();

            foreach (string mem in DanhSach)
            {
                MSComBoBox.Items.Add(mem.Trim());
                str.Add(mem.Trim());
            }

            MSComBoBox.AutoCompleteCustomSource = str;
            MSComBoBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            MSComBoBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
        }

        public void ExportExcel(DevExpress.XtraGrid.Views.Grid.GridView grid, string path, string name)
        {
            GUI.PhanMem.Waiting wait = new GUI.PhanMem.Waiting();
            wait.Show();

            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 20;

            for (int i = 1; i < grid.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = grid.Columns[i - 1].GetCaption();
            }

            for (int i = 0; i < grid.RowCount; i++)
            {
                for (int j = 0; j < grid.Columns.Count; j++)
                {
                    string value = "";
                    var ob = grid.GetRowCellValue(i, grid.Columns[j].FieldName);
                    if (ob != null)
                        value = ob.ToString();
                    obj.Cells[i + 2, j + 1] = value;
                }
            }

            obj.ActiveWorkbook.SaveCopyAs(path + name + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            wait.Close();
        }

        public void ExportExcel(DataGridView grid, string path, string name)
        {
            GUI.PhanMem.Waiting wait = new GUI.PhanMem.Waiting();
            wait.Show();

            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 20;

            for (int i = 1; i < grid.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = grid.Columns[i - 1].HeaderText;
            }

            for (int i = 0; i < grid.Rows.Count; i++)
            {
                for (int j = 0; j < grid.Columns.Count; j++)
                {
                    if (grid.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = grid.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }

            obj.ActiveWorkbook.SaveCopyAs(path + name + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            wait.Close();
        }

        public void ExportHoaDonBanHang(string lb_TrangThai, string lb_HinhThucKM, string lb_TongTienKMKH, string lb_TongTienKhuyenMai, string lb_TongTienVatLieu, string lb_SoVatLieu, string lb_TongTien, string lb_LoaiKH, string lb_NgayLap, string lb_MaHDBH, string lb_TenKH, string lb_TenNV, string lb_NgayGiao, DevExpress.XtraGrid.Views.Grid.GridView grid, string path, string name)
        {
            GUI.PhanMem.Waiting wait = new GUI.PhanMem.Waiting();
            wait.Show();

            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 20;
            const int infocolumnindex1 = 1, infocolumnindex2 = 5, gridrowindex = 10;

            #region Ghi Info
            obj.Cells[1, infocolumnindex1] = "Mã hóa đơn";
            obj.Cells[2, infocolumnindex1] = "Ngày lập";
            obj.Cells[3, infocolumnindex1] = "Ngày giao";
            obj.Cells[4, infocolumnindex1] = "Tên nhân viên";
            obj.Cells[5, infocolumnindex1] = "Tên khách hàng";
            obj.Cells[6, infocolumnindex1] = "Loại khách hàng";
            obj.Cells[1, infocolumnindex2] = "Số vật liệu";
            obj.Cells[2, infocolumnindex2] = "Tổng tiền vật liệu";
            obj.Cells[3, infocolumnindex2] = "Tổng tiền khuyến mãi";
            obj.Cells[4, infocolumnindex2] = "Khuyến mãi khách hàng";
            obj.Cells[5, infocolumnindex2] = "Hình thức khuyến mãi";
            obj.Cells[6, infocolumnindex2] = "Tổng tiền";
            obj.Cells[7, infocolumnindex2] = "Trạng thái";
            obj.Cells[1, infocolumnindex1 + 1] = lb_MaHDBH;
            obj.Cells[2, infocolumnindex1 + 1] = lb_NgayLap;
            obj.Cells[3, infocolumnindex1 + 1] = lb_NgayGiao;
            obj.Cells[4, infocolumnindex1 + 1] = lb_TenNV;
            obj.Cells[5, infocolumnindex1 + 1] = lb_TenKH;
            obj.Cells[6, infocolumnindex1 + 1] = lb_LoaiKH;
            obj.Cells[1, infocolumnindex2 + 1] = lb_SoVatLieu;
            obj.Cells[2, infocolumnindex2 + 1] = lb_TongTienVatLieu;
            obj.Cells[3, infocolumnindex2 + 1] = lb_TongTienKhuyenMai;
            obj.Cells[4, infocolumnindex2 + 1] = lb_TongTienKMKH;
            obj.Cells[5, infocolumnindex2 + 1] = lb_HinhThucKM;
            obj.Cells[6, infocolumnindex2 + 1] = lb_TongTien;
            obj.Cells[7, infocolumnindex2 + 1] = lb_TrangThai;
            #endregion

            // Ghi Grid            
            for (int i = 1; i < grid.Columns.Count + 1; i++)
            {
                obj.Cells[1 + gridrowindex, i] = grid.Columns[i - 1].GetCaption();
            }
            for (int i = 0; i < grid.RowCount; i++)
            {
                for (int j = 0; j < grid.Columns.Count; j++)
                {
                    string value = "";
                    var ob = grid.GetRowCellValue(i, grid.Columns[j].FieldName);
                    if (ob != null)
                        value = ob.ToString();
                    obj.Cells[i + 2 + gridrowindex, j + 1] = value;
                }
            }

            obj.ActiveWorkbook.SaveCopyAs(path + name + ".xlsx");
            obj.ActiveWorkbook.Saved = true;
            wait.Close();
        }

        //public void ExportHoaDonBanHang(string lb_TrangThai, string lb_HinhThucKM, string lb_TongTienKMKH, string lb_TongTienKhuyenMai, string lb_TongTienVatLieu, string lb_SoVatLieu, string lb_TongTien, string lb_LoaiKH, string lb_NgayLap, string lb_MaHDBH, string lb_TenKH, string lb_TenNV, string lb_NgayGiao, DevExpress.XtraGrid.Views.Grid.GridView grid, string path, string name)
        //{
        //    GUI.PhanMem.Waiting wait = new GUI.PhanMem.Waiting();
        //    wait.Show();

        //    app obj = new app();
        //    obj.Application.Workbooks.Add(Type.Missing);
        //    obj.Columns.ColumnWidth = 20;
        //    const int infocolumnindex1 = 1, infocolumnindex2 = 5, gridrowindex = 10;

        //    #region Ghi Info
        //    obj.Cells[1, infocolumnindex1] = "Mã hóa đơn";
        //    obj.Cells[2, infocolumnindex1] = "Ngày lập";
        //    obj.Cells[3, infocolumnindex1] = "Ngày giao";
        //    obj.Cells[4, infocolumnindex1] = "Tên nhân viên";
        //    obj.Cells[5, infocolumnindex1] = "Tên khách hàng";
        //    obj.Cells[6, infocolumnindex1] = "Loại khách hàng";
        //    obj.Cells[1, infocolumnindex2] = "Số vật liệu";
        //    obj.Cells[2, infocolumnindex2] = "Tổng tiền vật liệu";
        //    obj.Cells[3, infocolumnindex2] = "Tổng tiền khuyến mãi";
        //    obj.Cells[4, infocolumnindex2] = "Khuyến mãi khách hàng";
        //    obj.Cells[5, infocolumnindex2] = "Hình thức khuyến mãi";
        //    obj.Cells[6, infocolumnindex2] = "Tổng tiền";
        //    obj.Cells[7, infocolumnindex2] = "Trạng thái";
        //    obj.Cells[1, infocolumnindex1 + 1] = lb_MaHDBH;
        //    obj.Cells[2, infocolumnindex1 + 1] = lb_NgayLap;
        //    obj.Cells[3, infocolumnindex1 + 1] = lb_NgayGiao;
        //    obj.Cells[4, infocolumnindex1 + 1] = lb_TenNV;
        //    obj.Cells[5, infocolumnindex1 + 1] = lb_TenKH;
        //    obj.Cells[6, infocolumnindex1 + 1] = lb_LoaiKH;
        //    obj.Cells[1, infocolumnindex2 + 1] = lb_SoVatLieu;
        //    obj.Cells[2, infocolumnindex2 + 1] = lb_TongTienVatLieu;
        //    obj.Cells[3, infocolumnindex2 + 1] = lb_TongTienKhuyenMai;
        //    obj.Cells[4, infocolumnindex2 + 1] = lb_TongTienKMKH;
        //    obj.Cells[5, infocolumnindex2 + 1] = lb_HinhThucKM;
        //    obj.Cells[6, infocolumnindex2 + 1] = lb_TongTien;
        //    obj.Cells[7, infocolumnindex2 + 1] = lb_TrangThai;
        //    #endregion

        //    // Ghi Grid            
        //    for (int i = 1; i < grid.Columns.Count + 1; i++)
        //    {
        //        obj.Cells[1 + gridrowindex, i] = grid.Columns[i - 1].GetCaption();
        //    }
        //    for (int i = 0; i < grid.RowCount; i++)
        //    {
        //        for (int j = 0; j < grid.Columns.Count; j++)
        //        {
        //            string value = "";
        //            var ob = grid.GetRowCellValue(i, grid.Columns[j].FieldName);
        //            if (ob != null)
        //                value = ob.ToString();
        //            obj.Cells[i + 2 + gridrowindex, j + 1] = value;
        //        }
        //    }

        //    obj.ActiveWorkbook.SaveCopyAs(path + name + ".xlsx");
        //    obj.ActiveWorkbook.Saved = true;
        //    wait.Close();
        //}

        public void MakeComboBoxNoAuto(System.Windows.Forms.ComboBox MSComBoBox, List<string> DanhSach)
        {
            foreach (string mem in DanhSach)
            {
                MSComBoBox.Items.Add(mem.Trim());
            }
        }

        public bool CheckCMND(List<decimal> DanhSachCMND, decimal CMND)
        {
            foreach (decimal var in DanhSachCMND)
                if (var.Equals(CMND))
                    return true;
            return false;
        }

        public bool TextinText(string Father, string Son, bool IsCase)
        {
            if (Son == ""
                || (IsCase && Father.Contains(Son))
                || Father.ToUpper().Contains(Son.ToUpper()))
                return true;
            return false;
        }

        public DialogResult MakeMessageBox(BLLResult res)
        {
            string title = "";
            if (res._Icon == MessageBoxIcon.Information)
            {
                title = "Thông báo";
            }
            else if (res._Icon == MessageBoxIcon.Warning)
            {
                title = "Chú ý";
            }
            else if (res._Icon == MessageBoxIcon.Question)
            {
                title = "Tùy chọn";
            }
            else if (res._Icon == MessageBoxIcon.Error)
            {
                title = "Lỗi";
            }

            return MessageBox.Show(res._Content, title, MessageBoxButtons.OK, res._Icon);
        }

        public Config ReadConfig()
        {
            Config config = new Config();
            try
            {
                using (StreamReader readtext = new StreamReader("Config.txt"))
                {
                    config._SoLuongToiThieu = Int32.Parse(readtext.ReadLine());
                    config._ThoiGianKiemTraCSDL = Int32.Parse(readtext.ReadLine());
                    return config;
                }
            }
            catch
            {
                config._SoLuongToiThieu = 100;
                config._ThoiGianKiemTraCSDL = 10;
                return config;
            }
        }

        public string ReadNV()
        {            
            try
            {
                using (StreamReader readtext = new StreamReader("NhanVien.txt"))
                {
                    return readtext.ReadLine();
                }
            }
            catch
            {
                return null;
            }
        }

        public void WriteConfig(Config _Config)
        {
            using (StreamWriter writetext = new StreamWriter("Config.txt", false))
            {
                writetext.WriteLine(_Config._SoLuongToiThieu);
                writetext.WriteLine(_Config._ThoiGianKiemTraCSDL);
            }
        }

        public void WriteNV(string MaNV)
        {
            using (StreamWriter writetext = new StreamWriter("NhanVien.txt", false))
            {
                writetext.WriteLine(MaNV);
            }
        }

        public bool VarLive(string live)
        {
            return live.Trim() == "True";
        }

        public DialogResult MakeMessageBox(BLLResult res, MessageBoxButtons button)
        {
            string title = "";
            if (res._Icon == MessageBoxIcon.Information)
            {
                title = "Thông báo";
            }
            else if (res._Icon == MessageBoxIcon.Warning)
            {
                title = "Chú ý";
            }
            else if (res._Icon == MessageBoxIcon.Question)
            {
                title = "Tùy chọn";
            }
            else if (res._Icon == MessageBoxIcon.Error)
            {
                title = "Lỗi";
            }

            return MessageBox.Show(res._Content, title, button, res._Icon);
        }

        public string NewID(List<string> DanhSachID, string Letters)
        {
            List<decimal> dsMa = new List<decimal>();
            foreach (string var in DanhSachID)
            {
                dsMa.Add(Decimal.Parse(var.Substring(Letters.Length)));
            }

            dsMa.Sort();

            int num = dsMa.Count();
            decimal ireturn = 0;
            decimal[] dsMA = new decimal[dsMa.Count()];
            foreach (decimal var in dsMa)
            {
                dsMA[(int)ireturn++] = var;
            }

            for (int i = 0; i < num; i++)
                if (i < num - 1)
                {
                    if (dsMA[i] != dsMA[i + 1] - 1)
                    {
                        ireturn = dsMA[i] + 1;
                        break;
                    }
                }
                else
                {
                    ireturn = dsMA[i] + 1;
                }

            if (ireturn < 10)
                return Letters + "00" + ireturn.ToString();
            else if (ireturn < 100)
                return Letters + "0" + ireturn.ToString();
            else
                return Letters + ireturn.ToString();
        }

        // Hàm kiểm tra chuỗi nhập vào có nằm trong list phần tử của ComboBoxEdit (DevExpress) chưa:
        public bool CheckNotInComboBox(DevExpress.XtraEditors.ComboBoxEdit DevComboBox)
        {
            foreach (string mem in DevComboBox.Properties.Items)
                if ((string)mem == DevComboBox.Text)
                    return false;

            return true;
        }

        public bool CheckNotInComboBox(System.Windows.Forms.ComboBox MSComboBox)
        {
            foreach (string mem in MSComboBox.Items)
                if ((string)mem == MSComboBox.Text)
                    return false;

            return true;
        }

        public bool CheckSameName(List<string> DanhSachTen, string Name)
        {
            foreach (string var in DanhSachTen)
                if (var.Equals(Name))
                    return true;
            return false;
        }
    }
}
