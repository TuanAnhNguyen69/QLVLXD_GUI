namespace QLVLXD.GUI.NghiepVu
{
    partial class TienTeDonViTinhLoaiVatLieu
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
            this.btn_XoaDVT = new DevExpress.XtraEditors.SimpleButton();
            this.btn_ThemDVT = new DevExpress.XtraEditors.SimpleButton();
            this.grid_DVT = new DevExpress.XtraGrid.GridControl();
            this.quanLyDonViTinhBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVLXDDataSet14 = new QLVLXD.QLVLXDDataSet14();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenDVT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl18 = new DevExpress.XtraEditors.LabelControl();
            this.tb_DonViTinh = new DevExpress.XtraEditors.TextEdit();
            this.quanLyTienTeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVLXDDataSet13 = new QLVLXD.QLVLXDDataSet13();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tinhTrangVatLieuBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVLXDDataSet15 = new QLVLXD.QLVLXDDataSet15();
            this.quanLyTienTeTableAdapter = new QLVLXD.QLVLXDDataSet13TableAdapters.QuanLyTienTeTableAdapter();
            this.quanLyDonViTinhTableAdapter = new QLVLXD.QLVLXDDataSet14TableAdapters.QuanLyDonViTinhTableAdapter();
            this.tinhTrangVatLieuTableAdapter = new QLVLXD.QLVLXDDataSet15TableAdapters.TinhTrangVatLieuTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.grid_DVT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDonViTinhBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DonViTinh.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTienTeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet13)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangVatLieuBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet15)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_XoaDVT
            // 
            this.btn_XoaDVT.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XoaDVT.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_XoaDVT.Appearance.Options.UseFont = true;
            this.btn_XoaDVT.Appearance.Options.UseForeColor = true;
            this.btn_XoaDVT.Location = new System.Drawing.Point(545, 480);
            this.btn_XoaDVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XoaDVT.Name = "btn_XoaDVT";
            this.btn_XoaDVT.Size = new System.Drawing.Size(37, 28);
            this.btn_XoaDVT.TabIndex = 88;
            this.btn_XoaDVT.Text = "-";
            // 
            // btn_ThemDVT
            // 
            this.btn_ThemDVT.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThemDVT.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btn_ThemDVT.Appearance.Options.UseFont = true;
            this.btn_ThemDVT.Appearance.Options.UseForeColor = true;
            this.btn_ThemDVT.Location = new System.Drawing.Point(501, 480);
            this.btn_ThemDVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_ThemDVT.Name = "btn_ThemDVT";
            this.btn_ThemDVT.Size = new System.Drawing.Size(37, 28);
            this.btn_ThemDVT.TabIndex = 86;
            this.btn_ThemDVT.Text = "+";
            // 
            // grid_DVT
            // 
            this.grid_DVT.DataSource = this.quanLyDonViTinhBindingSource;
            this.grid_DVT.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid_DVT.Location = new System.Drawing.Point(7, 107);
            this.grid_DVT.MainView = this.gridView3;
            this.grid_DVT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid_DVT.Name = "grid_DVT";
            this.grid_DVT.Size = new System.Drawing.Size(1298, 340);
            this.grid_DVT.TabIndex = 82;
            this.grid_DVT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // quanLyDonViTinhBindingSource
            // 
            this.quanLyDonViTinhBindingSource.DataMember = "QuanLyDonViTinh";
            this.quanLyDonViTinhBindingSource.DataSource = this.qLVLXDDataSet14;
            // 
            // qLVLXDDataSet14
            // 
            this.qLVLXDDataSet14.DataSetName = "QLVLXDDataSet14";
            this.qLVLXDDataSet14.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaDVT,
            this.colTenDVT,
            this.colLive});
            this.gridView3.CustomizationFormBounds = new System.Drawing.Rectangle(854, 449, 210, 172);
            this.gridView3.GridControl = this.grid_DVT;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsBehavior.Editable = false;
            this.gridView3.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colMaDVT
            // 
            this.colMaDVT.Caption = "Tên Đơn Vị Tính";
            this.colMaDVT.FieldName = "MaDVT";
            this.colMaDVT.Name = "colMaDVT";
            // 
            // colTenDVT
            // 
            this.colTenDVT.Caption = "Tên Đơn Vị Tính";
            this.colTenDVT.FieldName = "TenDVT";
            this.colTenDVT.Name = "colTenDVT";
            this.colTenDVT.Visible = true;
            this.colTenDVT.VisibleIndex = 0;
            // 
            // colLive
            // 
            this.colLive.FieldName = "Live";
            this.colLive.Name = "colLive";
            // 
            // labelControl18
            // 
            this.labelControl18.Location = new System.Drawing.Point(10, 487);
            this.labelControl18.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl18.Name = "labelControl18";
            this.labelControl18.Size = new System.Drawing.Size(97, 17);
            this.labelControl18.TabIndex = 79;
            this.labelControl18.Text = "Tên Đơn Vị Tính";
            // 
            // tb_DonViTinh
            // 
            this.tb_DonViTinh.Location = new System.Drawing.Point(118, 484);
            this.tb_DonViTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_DonViTinh.Name = "tb_DonViTinh";
            this.tb_DonViTinh.Size = new System.Drawing.Size(377, 22);
            this.tb_DonViTinh.TabIndex = 76;
            // 
            // quanLyTienTeBindingSource
            // 
            this.quanLyTienTeBindingSource.DataMember = "QuanLyTienTe";
            this.quanLyTienTeBindingSource.DataSource = this.qLVLXDDataSet13;
            // 
            // qLVLXDDataSet13
            // 
            this.qLVLXDDataSet13.DataSetName = "QLVLXDDataSet13";
            this.qLVLXDDataSet13.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox2);
            this.groupBox2.Controls.Add(this.grid_DVT);
            this.groupBox2.Controls.Add(this.btn_XoaDVT);
            this.groupBox2.Controls.Add(this.tb_DonViTinh);
            this.groupBox2.Controls.Add(this.btn_ThemDVT);
            this.groupBox2.Controls.Add(this.labelControl18);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(1311, 553);
            this.groupBox2.TabIndex = 100;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản Lý Đơn Vị Tính";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QLVLXD.Properties.Resources.unnamed;
            this.pictureBox2.Location = new System.Drawing.Point(155, 16);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(131, 92);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 89;
            this.pictureBox2.TabStop = false;
            // 
            // tinhTrangVatLieuBindingSource
            // 
            this.tinhTrangVatLieuBindingSource.DataMember = "TinhTrangVatLieu";
            this.tinhTrangVatLieuBindingSource.DataSource = this.qLVLXDDataSet15;
            // 
            // qLVLXDDataSet15
            // 
            this.qLVLXDDataSet15.DataSetName = "QLVLXDDataSet15";
            this.qLVLXDDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // quanLyTienTeTableAdapter
            // 
            this.quanLyTienTeTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyDonViTinhTableAdapter
            // 
            this.quanLyDonViTinhTableAdapter.ClearBeforeFill = true;
            // 
            // tinhTrangVatLieuTableAdapter
            // 
            this.tinhTrangVatLieuTableAdapter.ClearBeforeFill = true;
            // 
            // TienTeDonViTinhLoaiVatLieu
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 604);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TienTeDonViTinhLoaiVatLieu";
            this.Text = "TienTeDonViTinhLoaiVatLieu";
            ((System.ComponentModel.ISupportInitialize)(this.grid_DVT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyDonViTinhBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_DonViTinh.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyTienTeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet13)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tinhTrangVatLieuBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet15)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_XoaDVT;
        private DevExpress.XtraEditors.SimpleButton btn_ThemDVT;
        private DevExpress.XtraGrid.GridControl grid_DVT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.LabelControl labelControl18;
        private DevExpress.XtraEditors.TextEdit tb_DonViTinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private QLVLXDDataSet13 qLVLXDDataSet13;
        private System.Windows.Forms.BindingSource quanLyTienTeBindingSource;
        private QLVLXDDataSet13TableAdapters.QuanLyTienTeTableAdapter quanLyTienTeTableAdapter;
        private QLVLXDDataSet14 qLVLXDDataSet14;
        private System.Windows.Forms.BindingSource quanLyDonViTinhBindingSource;
        private QLVLXDDataSet14TableAdapters.QuanLyDonViTinhTableAdapter quanLyDonViTinhTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDVT;
        private DevExpress.XtraGrid.Columns.GridColumn colLive;
        private QLVLXDDataSet15 qLVLXDDataSet15;
        private System.Windows.Forms.BindingSource tinhTrangVatLieuBindingSource;
        private QLVLXDDataSet15TableAdapters.TinhTrangVatLieuTableAdapter tinhTrangVatLieuTableAdapter;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}