namespace QLVLXD.GUI.NghiepVu
{
    partial class XemHoaDonMuaHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_TenThongKe = new System.Windows.Forms.TextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_XoaHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_In = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoVatLieu = new DevExpress.XtraEditors.LabelControl();
            this.lb_TongTien = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lb_NgayMua = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl16 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaHDBH = new DevExpress.XtraEditors.LabelControl();
            this.lb_TenNV = new DevExpress.XtraEditors.LabelControl();
            this.lb_MaNV = new DevExpress.XtraEditors.LabelControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.cTHoaDonMuaHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVLXDDataSet25 = new QLVLXD.QLVLXDDataSet25();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCTHDMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaHDMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaVL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenVL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonViTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cTHoaDonMuaHangTableAdapter = new QLVLXD.QLVLXDDataSet25TableAdapters.CTHoaDonMuaHangTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonMuaHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb_TenThongKe);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.btn_XoaHoaDon);
            this.groupBox1.Controls.Add(this.btn_In);
            this.groupBox1.Controls.Add(this.btn_XuatFile);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox1.Location = new System.Drawing.Point(900, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 260);
            this.groupBox1.TabIndex = 132;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // tb_TenThongKe
            // 
            this.tb_TenThongKe.Location = new System.Drawing.Point(24, 55);
            this.tb_TenThongKe.Name = "tb_TenThongKe";
            this.tb_TenThongKe.Size = new System.Drawing.Size(197, 21);
            this.tb_TenThongKe.TabIndex = 95;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(161, 37);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 13);
            this.labelControl3.TabIndex = 94;
            this.labelControl3.Text = "Tên hóa đơn";
            // 
            // btn_XoaHoaDon
            // 
            this.btn_XoaHoaDon.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaHoaDon.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_XoaHoaDon.Appearance.Options.UseFont = true;
            this.btn_XoaHoaDon.Appearance.Options.UseForeColor = true;
            this.btn_XoaHoaDon.Image = global::QLVLXD.Properties.Resources.Delete_icon___Copy;
            this.btn_XoaHoaDon.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.btn_XoaHoaDon.Location = new System.Drawing.Point(24, 122);
            this.btn_XoaHoaDon.Name = "btn_XoaHoaDon";
            this.btn_XoaHoaDon.Size = new System.Drawing.Size(197, 125);
            this.btn_XoaHoaDon.TabIndex = 0;
            this.btn_XoaHoaDon.Text = "Xóa hóa đơn\r\nvà thoát";
            this.btn_XoaHoaDon.Click += new System.EventHandler(this.btn_XoaHoaDon_Click);
            // 
            // btn_In
            // 
            this.btn_In.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_In.Appearance.Options.UseFont = true;
            this.btn_In.Location = new System.Drawing.Point(161, 82);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(60, 34);
            this.btn_In.TabIndex = 0;
            this.btn_In.Text = "In";
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatFile.Appearance.Options.UseFont = true;
            this.btn_XuatFile.Location = new System.Drawing.Point(24, 82);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(131, 34);
            this.btn_XuatFile.TabIndex = 0;
            this.btn_XuatFile.Text = "Xuất ra File";
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.lb_SoVatLieu);
            this.groupBox2.Controls.Add(this.lb_TongTien);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.lb_NgayMua);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl16);
            this.groupBox2.Controls.Add(this.labelControl4);
            this.groupBox2.Controls.Add(this.lb_MaHDBH);
            this.groupBox2.Controls.Add(this.lb_TenNV);
            this.groupBox2.Controls.Add(this.lb_MaNV);
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.groupBox2.Location = new System.Drawing.Point(22, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 261);
            this.groupBox2.TabIndex = 131;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Hóa Đơn";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Appearance.ForeColor = System.Drawing.Color.Black;
            this.labelControl7.Location = new System.Drawing.Point(295, 180);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(74, 19);
            this.labelControl7.TabIndex = 123;
            this.labelControl7.Text = "Tổng tiền:";
            // 
            // lb_SoVatLieu
            // 
            this.lb_SoVatLieu.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_SoVatLieu.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_SoVatLieu.Location = new System.Drawing.Point(383, 60);
            this.lb_SoVatLieu.Name = "lb_SoVatLieu";
            this.lb_SoVatLieu.Size = new System.Drawing.Size(100, 19);
            this.lb_SoVatLieu.TabIndex = 129;
            this.lb_SoVatLieu.Text = "(Số vật liệu)";
            // 
            // lb_TongTien
            // 
            this.lb_TongTien.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TongTien.Appearance.ForeColor = System.Drawing.Color.DeepPink;
            this.lb_TongTien.Location = new System.Drawing.Point(383, 177);
            this.lb_TongTien.Name = "lb_TongTien";
            this.lb_TongTien.Size = new System.Drawing.Size(118, 25);
            this.lb_TongTien.TabIndex = 127;
            this.lb_TongTien.Text = "(Tổng tiền)";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl8.Location = new System.Drawing.Point(295, 61);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(65, 16);
            this.labelControl8.TabIndex = 128;
            this.labelControl8.Text = "Số vật liệu:";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Location = new System.Drawing.Point(39, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 16);
            this.labelControl1.TabIndex = 73;
            this.labelControl1.Text = "Mã hóa đơn";
            // 
            // lb_NgayMua
            // 
            this.lb_NgayMua.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NgayMua.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_NgayMua.Location = new System.Drawing.Point(383, 122);
            this.lb_NgayMua.Name = "lb_NgayMua";
            this.lb_NgayMua.Size = new System.Drawing.Size(72, 19);
            this.lb_NgayMua.TabIndex = 91;
            this.lb_NgayMua.Text = "(Dữ liệu)";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl2.Location = new System.Drawing.Point(295, 121);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 16);
            this.labelControl2.TabIndex = 74;
            this.labelControl2.Text = "Ngày mua";
            // 
            // labelControl16
            // 
            this.labelControl16.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl16.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl16.Location = new System.Drawing.Point(39, 121);
            this.labelControl16.Name = "labelControl16";
            this.labelControl16.Size = new System.Drawing.Size(79, 16);
            this.labelControl16.TabIndex = 74;
            this.labelControl16.Text = "Mã Nhân Viên";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl4.Location = new System.Drawing.Point(39, 180);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 16);
            this.labelControl4.TabIndex = 76;
            this.labelControl4.Text = "Tên nhân viên";
            // 
            // lb_MaHDBH
            // 
            this.lb_MaHDBH.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaHDBH.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_MaHDBH.Location = new System.Drawing.Point(142, 58);
            this.lb_MaHDBH.Name = "lb_MaHDBH";
            this.lb_MaHDBH.Size = new System.Drawing.Size(72, 19);
            this.lb_MaHDBH.TabIndex = 85;
            this.lb_MaHDBH.Text = "(Dữ liệu)";
            // 
            // lb_TenNV
            // 
            this.lb_TenNV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_TenNV.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_TenNV.Location = new System.Drawing.Point(142, 180);
            this.lb_TenNV.Name = "lb_TenNV";
            this.lb_TenNV.Size = new System.Drawing.Size(72, 19);
            this.lb_TenNV.TabIndex = 91;
            this.lb_TenNV.Text = "(Dữ liệu)";
            // 
            // lb_MaNV
            // 
            this.lb_MaNV.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNV.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_MaNV.Location = new System.Drawing.Point(142, 122);
            this.lb_MaNV.Name = "lb_MaNV";
            this.lb_MaNV.Size = new System.Drawing.Size(72, 19);
            this.lb_MaNV.TabIndex = 91;
            this.lb_MaNV.Text = "(Dữ liệu)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QLVLXD.Properties.Resources.MediaBuying_graphic;
            this.pictureBox1.Location = new System.Drawing.Point(591, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 131;
            this.pictureBox1.TabStop = false;
            // 
            // grid
            // 
            this.grid.DataSource = this.cTHoaDonMuaHangBindingSource;
            this.grid.Location = new System.Drawing.Point(22, 289);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1120, 229);
            this.grid.TabIndex = 133;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // cTHoaDonMuaHangBindingSource
            // 
            this.cTHoaDonMuaHangBindingSource.DataMember = "CTHoaDonMuaHang";
            this.cTHoaDonMuaHangBindingSource.DataSource = this.qLVLXDDataSet25;
            // 
            // qLVLXDDataSet25
            // 
            this.qLVLXDDataSet25.DataSetName = "QLVLXDDataSet25";
            this.qLVLXDDataSet25.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCTHDMH,
            this.colMaHDMH,
            this.colMaVL,
            this.colTenVL,
            this.colSoLuong,
            this.colDonViTinh,
            this.colTongTien,
            this.colLive});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaCTHDMH
            // 
            this.colMaCTHDMH.Caption = "Mã CTHDBH";
            this.colMaCTHDMH.FieldName = "MaCTHDMH";
            this.colMaCTHDMH.Name = "colMaCTHDMH";
            this.colMaCTHDMH.Visible = true;
            this.colMaCTHDMH.VisibleIndex = 0;
            // 
            // colMaHDMH
            // 
            this.colMaHDMH.Caption = "Mã HDBH";
            this.colMaHDMH.FieldName = "MaHDMH";
            this.colMaHDMH.Name = "colMaHDMH";
            // 
            // colMaVL
            // 
            this.colMaVL.Caption = "Mã Vật Liệu";
            this.colMaVL.FieldName = "MaVL";
            this.colMaVL.Name = "colMaVL";
            this.colMaVL.Visible = true;
            this.colMaVL.VisibleIndex = 1;
            // 
            // colTenVL
            // 
            this.colTenVL.Caption = "Tên Vật Liệu";
            this.colTenVL.FieldName = "TenVL";
            this.colTenVL.Name = "colTenVL";
            this.colTenVL.Visible = true;
            this.colTenVL.VisibleIndex = 2;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số Lượng Mua";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 3;
            // 
            // colDonViTinh
            // 
            this.colDonViTinh.Caption = "Đơn Vị Tính";
            this.colDonViTinh.FieldName = "DonViTinh";
            this.colDonViTinh.Name = "colDonViTinh";
            this.colDonViTinh.Visible = true;
            this.colDonViTinh.VisibleIndex = 4;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 5;
            // 
            // colLive
            // 
            this.colLive.FieldName = "Live";
            this.colLive.Name = "colLive";
            // 
            // cTHoaDonMuaHangTableAdapter
            // 
            this.cTHoaDonMuaHangTableAdapter.ClearBeforeFill = true;
            // 
            // XemHoaDonMuaHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 530);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "XemHoaDonMuaHang";
            this.Text = "Xem Hóa Đơn Mua Hàng";
            this.Load += new System.EventHandler(this.XemHoaDonMuaHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cTHoaDonMuaHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_TenThongKe;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_XoaHoaDon;
        private DevExpress.XtraEditors.SimpleButton btn_In;
        private DevExpress.XtraEditors.SimpleButton btn_XuatFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl lb_SoVatLieu;
        private DevExpress.XtraEditors.LabelControl lb_TongTien;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lb_NgayMua;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl16;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl lb_MaHDBH;
        private DevExpress.XtraEditors.LabelControl lb_TenNV;
        private DevExpress.XtraEditors.LabelControl lb_MaNV;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVLXDDataSet25 qLVLXDDataSet25;
        private System.Windows.Forms.BindingSource cTHoaDonMuaHangBindingSource;
        private QLVLXDDataSet25TableAdapters.CTHoaDonMuaHangTableAdapter cTHoaDonMuaHangTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCTHDMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHDMH;
        private DevExpress.XtraGrid.Columns.GridColumn colMaVL;
        private DevExpress.XtraGrid.Columns.GridColumn colTenVL;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonViTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colLive;
    }
}