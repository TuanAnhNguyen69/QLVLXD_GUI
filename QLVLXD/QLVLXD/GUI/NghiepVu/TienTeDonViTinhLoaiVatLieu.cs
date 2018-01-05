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

namespace QLVLXD.GUI.NghiepVu
{
    public partial class TienTeDonViTinhLoaiVatLieu : DevExpress.XtraEditors.XtraForm
    {        
        //BLL_TinhTrangVatLieu _TinhTrang = new BLL_TinhTrangVatLieu();
        //BLL_QuanLyTienTe _TienTe = new BLL_QuanLyTienTe();
        //BLL_QuanLyDonViTinh _DVT = new BLL_QuanLyDonViTinh();
        //public Main_Form mainform;
        //public bool IsReset;

        //public TienTeDonViTinhLoaiVatLieu()
        //{
        //    InitializeComponent();
        //    UpdateGridDVT();
        //    UpdateGridTinhTrang();
        //    UpdateGridTienTe();
        //}

        //private void TienTeDonViTinhLoaiVatLieu_Load(object sender, EventArgs e)
        //{
        //    //this.tinhTrangVatLieuTableAdapter.Fill(this.qLVLXDDataSet15.TinhTrangVatLieu);
        //    //this.quanLyDonViTinhTableAdapter.Fill(this.qLVLXDDataSet14.QuanLyDonViTinh);
        //    //this.quanLyTienTeTableAdapter.Fill(this.qLVLXDDataSet13.QuanLyTienTe);
        //}

        //void UpdateGridDVT()
        //{
        //    grid_DVT.DataSource = null;
        //    grid_DVT.DataSource = _DVT.GetList();
        //}

        //void UpdateGridTienTe()
        //{
        //    grid_TienTe.DataSource = null;
        //    grid_TienTe.DataSource = _TienTe.GetList();
        //}

        //void UpdateGridTinhTrang()
        //{
        //    grid_TinhTrang.DataSource = null;
        //    grid_TinhTrang.DataSource = _TinhTrang.GetList();
        //}
       
        //// [Thêm DVT]
        //private void btn_ThemDVT_Click(object sender, EventArgs e)
        //{
        //    if (tb_DonViTinh.Text == "")
        //    {
        //        _DVT.MakeMessageBox(new BLLResult("Vui lòng nhập đơn vị tính mới!"));
        //        return;
        //    }
        //    BLLResult res = _DVT.Insert(tb_DonViTinh.Text.Trim());
        //    _DVT.MakeMessageBox(res);
        //    if (res._Code == (int)BLLResultType.S_ADD)
        //    {
        //        UpdateGridDVT();
        //         try {mainform.frm_vatlieu.IsReset = true; } catch {}
        //    }
        //}

        //// [Xóa DVT]
        //private void btn_XoaDVT_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int[] selectedindex = gridView3.GetSelectedRows();
        //        var dvt = gridView3.GetRow(selectedindex[0]);               

        //        BLLResult res = _DVT.Delete(((DLL.QuanLyDonViTinh)dvt).MaDVT.ToString(), false);
        //        _DVT.MakeMessageBox(res);
        //        if (res._Code == (int)BLLResultType.S_DELETE)
        //        {
        //            UpdateGridDVT();
        //             try {mainform.frm_vatlieu.IsReset = true; } catch {}
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Vui lòng chọn đơn vị tính để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //// [Thêm tiền tệ]
        //private void btn_ThemTienTe_Click(object sender, EventArgs e)
        //{
        //    if (tb_TienTie.Text == "" || num_TienTe.Value < 1)
        //    {
        //        _DVT.MakeMessageBox(new BLLResult("Vui lòng nhập tên tiền tệ và Trị giá VND từ 1 VND trở lên!"));
        //        return;
        //    }           

        //    BLLResult res = _TienTe.Insert(tb_TienTie.Text.Trim(), (int)num_TienTe.Value);
        //    _DVT.MakeMessageBox(res);
        //    if (res._Code == (int)BLLResultType.S_ADD)
        //    {
        //        UpdateGridTienTe();
        //         try {mainform.frm_vatlieu.IsReset = true; } catch {}
        //    }
        //}

        //// [Xóa tiền tệ]
        //private void btn_XoaTienTe_Click(object sender, EventArgs e)
        //{
        //    try
        //    {

        //        int[] selectedindex = gridView2.GetSelectedRows();
        //        var dvt = gridView2.GetRow(selectedindex[0]);
        //        if (((DLL.QuanLyTienTe)dvt).TenTT.Trim() == "VND") // Ko cho xóa VND
        //        {
        //            _DVT.MakeMessageBox(new BLLResult("VND là tiền tệ bắt buộc phải có nên không thể xóa tiền tệ VND!"));
        //            return;
        //        }

        //        BLLResult res = _TienTe.Delete(((DLL.QuanLyTienTe)dvt).MaTT.ToString(), false);
        //        _TienTe.MakeMessageBox(res);
        //        if (res._Code == (int)BLLResultType.S_DELETE)
        //        {
        //            UpdateGridTienTe();
        //            try {mainform.frm_vatlieu.IsReset = true; }
        //            catch {}
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Vui lòng chọn tiền tệ để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //// [Thêm tình trạng]
        //private void btn_ThemTinhTrang_Click(object sender, EventArgs e)
        //{
        //    if (tb_TinhTrang.Text == "")
        //    {
        //        _DVT.MakeMessageBox(new BLLResult("Vui lòng nhập nội dung tình trạng mới!"));
        //        return;
        //    }

        //    BLLResult res = _TinhTrang.Insert(tb_TinhTrang.Text.Trim());
        //    _TienTe.MakeMessageBox(res);
        //    if (res._Code == (int)BLLResultType.S_ADD)
        //    {
        //        UpdateGridTinhTrang();
        //         try {mainform.frm_vatlieu.IsReset = true; } catch {}
        //    }
        //}

        //// [Xóa tình trạng]
        //private void btn_XoaTinhTrang_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int[] selectedindex = gridView1.GetSelectedRows();
        //        var tt = gridView1.GetRow(selectedindex[0]);
        //        if (((DLL.TinhTrangVatLieu)tt).NoiDungTinhTrangVL.Trim() == "Tốt") // Ko cho xóa Tốt
        //        {
        //            _DVT.MakeMessageBox(new BLLResult("Tốt là tình trạng bắt buộc phải có khi thêm vật liệu mới nên không thể xóa!"));
        //            return;
        //        }

        //        BLLResult res = _TinhTrang.Delete(((DLL.TinhTrangVatLieu)tt).MaTinhTrangVL.ToString(), false);
        //        _TienTe.MakeMessageBox(res);
        //        if (res._Code == (int)BLLResultType.S_DELETE)
        //        {
        //            UpdateGridTinhTrang();
        //             try {mainform.frm_vatlieu.IsReset = true; } catch {}
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        MessageBox.Show("Vui lòng chọn tình trạng để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
    }
}