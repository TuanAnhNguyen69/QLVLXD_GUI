namespace QLVLXD
{
    partial class NhaCungCap
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
            this.nhaCungCapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_SDT_NCC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ResetThongTin = new DevExpress.XtraEditors.SimpleButton();
            this.lb_MaNhaCungCap = new DevExpress.XtraEditors.LabelControl();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_DiaChiNCC = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenNCC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nhaCungCapBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLVLXDDataSet17 = new QLVLXD.QLVLXDDataSet17();
            this.nhaCungCapTableAdapter = new QLVLXD.QLVLXDDataSet17TableAdapters.NhaCungCapTableAdapter();
            this.gridControl_NCC = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_XuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.btn_In = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChiNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNCC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NCC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_SDT_NCC
            // 
            this.txt_SDT_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT_NCC.Location = new System.Drawing.Point(515, 44);
            this.txt_SDT_NCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SDT_NCC.Name = "txt_SDT_NCC";
            this.txt_SDT_NCC.Size = new System.Drawing.Size(188, 23);
            this.txt_SDT_NCC.TabIndex = 39;
            this.txt_SDT_NCC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_NCC_KeyPress_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 17);
            this.label1.TabIndex = 38;
            this.label1.Text = "Số điện thoại";
            // 
            // btn_ResetThongTin
            // 
            this.btn_ResetThongTin.Location = new System.Drawing.Point(419, 212);
            this.btn_ResetThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ResetThongTin.Name = "btn_ResetThongTin";
            this.btn_ResetThongTin.Size = new System.Drawing.Size(95, 34);
            this.btn_ResetThongTin.TabIndex = 37;
            this.btn_ResetThongTin.Text = "Reset";
            this.btn_ResetThongTin.Click += new System.EventHandler(this.btn_ResetThongTin_Click);
            // 
            // lb_MaNhaCungCap
            // 
            this.lb_MaNhaCungCap.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNhaCungCap.Location = new System.Drawing.Point(187, 50);
            this.lb_MaNhaCungCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_MaNhaCungCap.Name = "lb_MaNhaCungCap";
            this.lb_MaNhaCungCap.Size = new System.Drawing.Size(139, 21);
            this.lb_MaNhaCungCap.TabIndex = 36;
            this.lb_MaNhaCungCap.Text = "(Mã nhà cung cấp)";
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Location = new System.Drawing.Point(1260, 128);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(168, 59);
            this.btn_CapNhat.TabIndex = 35;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Appearance.Options.UseForeColor = true;
            this.btn_Xoa.Location = new System.Drawing.Point(1260, 50);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(168, 70);
            this.btn_Xoa.TabIndex = 34;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Appearance.Options.UseForeColor = true;
            this.btn_Them.Location = new System.Drawing.Point(1260, 50);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(168, 137);
            this.btn_Them.TabIndex = 33;
            this.btn_Them.Text = "Thêm Nhà \r\nCung Cấp";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_DiaChiNCC
            // 
            this.txt_DiaChiNCC.Location = new System.Drawing.Point(515, 114);
            this.txt_DiaChiNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DiaChiNCC.Name = "txt_DiaChiNCC";
            this.txt_DiaChiNCC.Size = new System.Drawing.Size(189, 22);
            this.txt_DiaChiNCC.TabIndex = 32;
            // 
            // txt_TenNCC
            // 
            this.txt_TenNCC.Location = new System.Drawing.Point(187, 113);
            this.txt_TenNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenNCC.Name = "txt_TenNCC";
            this.txt_TenNCC.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNCC.Properties.Appearance.ForeColor = System.Drawing.Color.Purple;
            this.txt_TenNCC.Properties.Appearance.Options.UseFont = true;
            this.txt_TenNCC.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TenNCC.Size = new System.Drawing.Size(161, 24);
            this.txt_TenNCC.TabIndex = 31;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(389, 118);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(40, 17);
            this.labelControl4.TabIndex = 30;
            this.labelControl4.Text = "Địa chỉ";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 53);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 17);
            this.labelControl2.TabIndex = 29;
            this.labelControl2.Text = "Mã nhà cung cấp";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 117);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(111, 17);
            this.labelControl1.TabIndex = 28;
            this.labelControl1.Text = "Tên nhà cung cấp";
            // 
            // nhaCungCapBindingSource1
            // 
            this.nhaCungCapBindingSource1.DataMember = "NhaCungCap";
            this.nhaCungCapBindingSource1.DataSource = this.qLVLXDDataSet17;
            // 
            // qLVLXDDataSet17
            // 
            this.qLVLXDDataSet17.DataSetName = "QLVLXDDataSet17";
            this.qLVLXDDataSet17.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhaCungCapTableAdapter
            // 
            this.nhaCungCapTableAdapter.ClearBeforeFill = true;
            // 
            // gridControl_NCC
            // 
            this.gridControl_NCC.DataSource = this.nhaCungCapBindingSource1;
            this.gridControl_NCC.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_NCC.Location = new System.Drawing.Point(12, 265);
            this.gridControl_NCC.MainView = this.gridView1;
            this.gridControl_NCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_NCC.Name = "gridControl_NCC";
            this.gridControl_NCC.Size = new System.Drawing.Size(1497, 325);
            this.gridControl_NCC.TabIndex = 42;
            this.gridControl_NCC.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl_NCC.MouseCaptureChanged += new System.EventHandler(this.gridControl_NCC_MouseCaptureChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNCC,
            this.colTenNCC,
            this.colSDT,
            this.colDiaChi,
            this.colLive});
            this.gridView1.GridControl = this.gridControl_NCC;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaNCC
            // 
            this.colMaNCC.Caption = "Mã Nhà Cung Cấp";
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            this.colMaNCC.Visible = true;
            this.colMaNCC.VisibleIndex = 0;
            // 
            // colTenNCC
            // 
            this.colTenNCC.Caption = "Tên Nhà Cung Cấp";
            this.colTenNCC.FieldName = "TenNCC";
            this.colTenNCC.Name = "colTenNCC";
            this.colTenNCC.Visible = true;
            this.colTenNCC.VisibleIndex = 1;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "Số Điện Thoại";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 2;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 3;
            // 
            // colLive
            // 
            this.colLive.FieldName = "Live";
            this.colLive.Name = "colLive";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SDT_NCC);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb_MaNhaCungCap);
            this.groupBox1.Controls.Add(this.txt_DiaChiNCC);
            this.groupBox1.Controls.Add(this.txt_TenNCC);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(419, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(737, 181);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhà cung cấp";
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Location = new System.Drawing.Point(943, 212);
            this.btn_XuatFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(124, 43);
            this.btn_XuatFile.TabIndex = 95;
            this.btn_XuatFile.Text = "Xuất ra File\r";
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(1075, 212);
            this.btn_In.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(81, 43);
            this.btn_In.TabIndex = 94;
            this.btn_In.Text = "In\r\n";
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // NhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 604);
            this.Controls.Add(this.btn_XuatFile);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gridControl_NCC);
            this.Controls.Add(this.btn_ResetThongTin);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Xoa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "NhaCungCap";
            this.Text = "Quản Lý Thông Tin Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChiNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNCC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhaCungCapBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_NCC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource nhaCungCapBindingSource;
        private System.Windows.Forms.TextBox txt_SDT_NCC;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btn_ResetThongTin;
        private DevExpress.XtraEditors.LabelControl lb_MaNhaCungCap;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.TextEdit txt_DiaChiNCC;
        private DevExpress.XtraEditors.TextEdit txt_TenNCC;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private QLVLXDDataSet17 qLVLXDDataSet17;
        private System.Windows.Forms.BindingSource nhaCungCapBindingSource1;
        private QLVLXDDataSet17TableAdapters.NhaCungCapTableAdapter nhaCungCapTableAdapter;
        private DevExpress.XtraGrid.GridControl gridControl_NCC;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colLive;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_XuatFile;
        private DevExpress.XtraEditors.SimpleButton btn_In;
    }
}