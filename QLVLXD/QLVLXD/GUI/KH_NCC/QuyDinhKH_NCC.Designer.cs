namespace QLVLXD.GUI.KH_NCC
{
    partial class QuyDinhKH_NCC
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
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl15 = new DevExpress.XtraEditors.LabelControl();
            this.tb_TenLoaiKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.num_TriGiaHoaDonToiThieu = new System.Windows.Forms.NumericUpDown();
            this.num_PhanTramGiam = new System.Windows.Forms.NumericUpDown();
            this.loaiKhachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVLXDDataSet20 = new QLVLXD.QLVLXDDataSet20();
            this.loaiKhachHangTableAdapter = new QLVLXD.QLVLXDDataSet20TableAdapters.LoaiKhachHangTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaLoaiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLanMuaToiThieu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTriGiaToiThieuMoiLanMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanTramGiamLanMuaCuoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MocTieuThu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPhanTramGiam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grid = new DevExpress.XtraGrid.GridControl();
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenLoaiKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TriGiaHoaDonToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PhanTramGiam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiKhachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet20)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Appearance.Options.UseForeColor = true;
            this.btn_Xoa.Location = new System.Drawing.Point(1045, 328);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(82, 79);
            this.btn_Xoa.TabIndex = 87;
            this.btn_Xoa.Text = "-";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 54.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Appearance.Options.UseForeColor = true;
            this.btn_Them.Location = new System.Drawing.Point(947, 328);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(92, 79);
            this.btn_Them.TabIndex = 85;
            this.btn_Them.Text = "+";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // labelControl15
            // 
            this.labelControl15.Location = new System.Drawing.Point(13, 39);
            this.labelControl15.Name = "labelControl15";
            this.labelControl15.Size = new System.Drawing.Size(122, 17);
            this.labelControl15.TabIndex = 80;
            this.labelControl15.Text = "Tên loại khách hàng";
            // 
            // tb_TenLoaiKH
            // 
            this.tb_TenLoaiKH.Location = new System.Drawing.Point(190, 36);
            this.tb_TenLoaiKH.Name = "tb_TenLoaiKH";
            this.tb_TenLoaiKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenLoaiKH.Properties.Appearance.ForeColor = System.Drawing.Color.Purple;
            this.tb_TenLoaiKH.Properties.Appearance.Options.UseFont = true;
            this.tb_TenLoaiKH.Properties.Appearance.Options.UseForeColor = true;
            this.tb_TenLoaiKH.Size = new System.Drawing.Size(456, 24);
            this.tb_TenLoaiKH.TabIndex = 75;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 138);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(76, 17);
            this.labelControl2.TabIndex = 80;
            this.labelControl2.Text = "Mốc tiêu thụ";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 166);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(97, 17);
            this.labelControl3.TabIndex = 80;
            this.labelControl3.Text = "Phần trăm giảm";
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(947, 417);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(180, 46);
            this.btn_Reset.TabIndex = 99;
            this.btn_Reset.Text = "Reset";
            // 
            // num_TriGiaHoaDonToiThieu
            // 
            this.num_TriGiaHoaDonToiThieu.Location = new System.Drawing.Point(190, 131);
            this.num_TriGiaHoaDonToiThieu.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_TriGiaHoaDonToiThieu.Name = "num_TriGiaHoaDonToiThieu";
            this.num_TriGiaHoaDonToiThieu.Size = new System.Drawing.Size(454, 24);
            this.num_TriGiaHoaDonToiThieu.TabIndex = 98;
            this.num_TriGiaHoaDonToiThieu.ThousandsSeparator = true;
            // 
            // num_PhanTramGiam
            // 
            this.num_PhanTramGiam.DecimalPlaces = 1;
            this.num_PhanTramGiam.Location = new System.Drawing.Point(190, 166);
            this.num_PhanTramGiam.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_PhanTramGiam.Name = "num_PhanTramGiam";
            this.num_PhanTramGiam.Size = new System.Drawing.Size(454, 24);
            this.num_PhanTramGiam.TabIndex = 98;
            // 
            // loaiKhachHangBindingSource
            // 
            this.loaiKhachHangBindingSource.DataMember = "LoaiKhachHang";
            this.loaiKhachHangBindingSource.DataSource = this.qLVLXDDataSet20;
            // 
            // qLVLXDDataSet20
            // 
            this.qLVLXDDataSet20.DataSetName = "QLVLXDDataSet20";
            this.qLVLXDDataSet20.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loaiKhachHangTableAdapter
            // 
            this.loaiKhachHangTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.num_PhanTramGiam);
            this.groupBox1.Controls.Add(this.num_TriGiaHoaDonToiThieu);
            this.groupBox1.Controls.Add(this.tb_TenLoaiKH);
            this.groupBox1.Controls.Add(this.labelControl15);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(262, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(657, 196);
            this.groupBox1.TabIndex = 102;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin loại khách hàng";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaLoaiKH,
            this.colTenLoaiKH,
            this.colSoLanMuaToiThieu,
            this.colTriGiaToiThieuMoiLanMua,
            this.colPhanTramGiamLanMuaCuoi,
            this.MocTieuThu,
            this.colPhanTramGiam,
            this.colLive});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaLoaiKH
            // 
            this.colMaLoaiKH.FieldName = "MaLoaiKH";
            this.colMaLoaiKH.Name = "colMaLoaiKH";
            // 
            // colTenLoaiKH
            // 
            this.colTenLoaiKH.Caption = "Tên Loại Khách Hàng";
            this.colTenLoaiKH.FieldName = "TenLoaiKH";
            this.colTenLoaiKH.Name = "colTenLoaiKH";
            this.colTenLoaiKH.Visible = true;
            this.colTenLoaiKH.VisibleIndex = 0;
            this.colTenLoaiKH.Width = 146;
            // 
            // colSoLanMuaToiThieu
            // 
            this.colSoLanMuaToiThieu.Caption = "Số Lần Mua Tối Thiểu";
            this.colSoLanMuaToiThieu.FieldName = "SoLanMuaToiThieu";
            this.colSoLanMuaToiThieu.Name = "colSoLanMuaToiThieu";
            this.colSoLanMuaToiThieu.Width = 146;
            // 
            // colTriGiaToiThieuMoiLanMua
            // 
            this.colTriGiaToiThieuMoiLanMua.Caption = "Trị Giá Tối Thiểu Mỗi Lần Mua";
            this.colTriGiaToiThieuMoiLanMua.FieldName = "TriGiaToiThieuMoiLanMua";
            this.colTriGiaToiThieuMoiLanMua.Name = "colTriGiaToiThieuMoiLanMua";
            this.colTriGiaToiThieuMoiLanMua.Width = 159;
            // 
            // colPhanTramGiamLanMuaCuoi
            // 
            this.colPhanTramGiamLanMuaCuoi.Caption = "Phần Trăm Giảm Lần Mua Cuối";
            this.colPhanTramGiamLanMuaCuoi.FieldName = "PhanTramGiamLanMuaCuoi";
            this.colPhanTramGiamLanMuaCuoi.Name = "colPhanTramGiamLanMuaCuoi";
            this.colPhanTramGiamLanMuaCuoi.Width = 203;
            // 
            // MocTieuThu
            // 
            this.MocTieuThu.Caption = "Mốc Tiêu Thụ";
            this.MocTieuThu.FieldName = "TriGiaHoaDonToiThieu";
            this.MocTieuThu.Name = "MocTieuThu";
            this.MocTieuThu.Visible = true;
            this.MocTieuThu.VisibleIndex = 1;
            this.MocTieuThu.Width = 130;
            // 
            // colPhanTramGiam
            // 
            this.colPhanTramGiam.Caption = "Phần Trăm Giảm";
            this.colPhanTramGiam.FieldName = "PhanTramGiam";
            this.colPhanTramGiam.Name = "colPhanTramGiam";
            this.colPhanTramGiam.Visible = true;
            this.colPhanTramGiam.VisibleIndex = 2;
            this.colPhanTramGiam.Width = 97;
            // 
            // colLive
            // 
            this.colLive.FieldName = "Live";
            this.colLive.Name = "colLive";
            // 
            // grid
            // 
            this.grid.DataSource = this.loaiKhachHangBindingSource;
            this.grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.grid.Location = new System.Drawing.Point(262, 12);
            this.grid.MainView = this.gridView1;
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1054, 265);
            this.grid.TabIndex = 101;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid.Click += new System.EventHandler(this.grid_Click);
            // 
            // QuyDinhKH_NCC
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 530);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuyDinhKH_NCC";
            this.Text = "Quy Định Về Khách Hàng";
            this.Load += new System.EventHandler(this.QuyDinhKH_NCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tb_TenLoaiKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_TriGiaHoaDonToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_PhanTramGiam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiKhachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet20)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.LabelControl labelControl15;
        private DevExpress.XtraEditors.TextEdit tb_TenLoaiKH;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton btn_Reset;
        private System.Windows.Forms.NumericUpDown num_TriGiaHoaDonToiThieu;
        private System.Windows.Forms.NumericUpDown num_PhanTramGiam;
        private QLVLXDDataSet20 qLVLXDDataSet20;
        private System.Windows.Forms.BindingSource loaiKhachHangBindingSource;
        private QLVLXDDataSet20TableAdapters.LoaiKhachHangTableAdapter loaiKhachHangTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaLoaiKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiKH;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLanMuaToiThieu;
        private DevExpress.XtraGrid.Columns.GridColumn colTriGiaToiThieuMoiLanMua;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanTramGiamLanMuaCuoi;
        private DevExpress.XtraGrid.Columns.GridColumn MocTieuThu;
        private DevExpress.XtraGrid.Columns.GridColumn colPhanTramGiam;
        private DevExpress.XtraGrid.Columns.GridColumn colLive;
        private DevExpress.XtraGrid.GridControl grid;
    }
}