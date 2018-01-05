namespace QLVLXD.GUI.NghiepVu
{
    partial class ThongKeMuaHang
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
            this.btn_Loc = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Reset = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.num_TongTien = new System.Windows.Forms.NumericUpDown();
            this.rx_TongTien = new System.Windows.Forms.RadioButton();
            this.rn_TongTien = new System.Windows.Forms.RadioButton();
            this.rb_TongTien = new System.Windows.Forms.RadioButton();
            this.rl_TongTien = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb_TenNCC = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.cb_TenNhanVien = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtp_NgayLap = new System.Windows.Forms.DateTimePicker();
            this.rx_NgayLap = new System.Windows.Forms.RadioButton();
            this.rn_NgayLap = new System.Windows.Forms.RadioButton();
            this.rb_NgayLap = new System.Windows.Forms.RadioButton();
            this.rl_NgayLap = new System.Windows.Forms.RadioButton();
            this.btn_XemChiTietHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XoaHoaDon = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lb_SoHoaDon = new DevExpress.XtraEditors.LabelControl();
            this.grid = new DevExpress.XtraGrid.GridControl();
            this.hoaDonMuaHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVLXDDataSet24 = new QLVLXD.QLVLXDDataSet24();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHDMH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayMua = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDTNCC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hoaDonMuaHangTableAdapter = new QLVLXD.QLVLXDDataSet24TableAdapters.HoaDonMuaHangTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.num_SoVatLieu = new System.Windows.Forms.NumericUpDown();
            this.rx_SoVatLieu = new System.Windows.Forms.RadioButton();
            this.rn_SoVatLieu = new System.Windows.Forms.RadioButton();
            this.rb_SoVatLieu = new System.Windows.Forms.RadioButton();
            this.rl_SoVatLieu = new System.Windows.Forms.RadioButton();
            this.btn_In = new DevExpress.XtraEditors.SimpleButton();
            this.btn_XuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.tb_TenThongKe = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TongTien)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonMuaHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoVatLieu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Loc
            // 
            this.btn_Loc.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Loc.Appearance.ForeColor = System.Drawing.Color.Orange;
            this.btn_Loc.Appearance.Options.UseFont = true;
            this.btn_Loc.Appearance.Options.UseForeColor = true;
            this.btn_Loc.Location = new System.Drawing.Point(974, 41);
            this.btn_Loc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Loc.Name = "btn_Loc";
            this.btn_Loc.Size = new System.Drawing.Size(114, 60);
            this.btn_Loc.TabIndex = 103;
            this.btn_Loc.Text = "Lọc";
            this.btn_Loc.Click += new System.EventHandler(this.btn_Loc_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(1095, 41);
            this.btn_Reset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(73, 64);
            this.btn_Reset.TabIndex = 102;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.num_TongTien);
            this.groupBox10.Controls.Add(this.rx_TongTien);
            this.groupBox10.Controls.Add(this.rn_TongTien);
            this.groupBox10.Controls.Add(this.rb_TongTien);
            this.groupBox10.Controls.Add(this.rl_TongTien);
            this.groupBox10.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(756, 108);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox10.Size = new System.Drawing.Size(195, 89);
            this.groupBox10.TabIndex = 97;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Tổng Tiền";
            // 
            // num_TongTien
            // 
            this.num_TongTien.Location = new System.Drawing.Point(10, 55);
            this.num_TongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_TongTien.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_TongTien.Name = "num_TongTien";
            this.num_TongTien.Size = new System.Drawing.Size(177, 24);
            this.num_TongTien.TabIndex = 36;
            this.num_TongTien.ThousandsSeparator = true;
            // 
            // rx_TongTien
            // 
            this.rx_TongTien.AutoSize = true;
            this.rx_TongTien.Location = new System.Drawing.Point(150, 25);
            this.rx_TongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rx_TongTien.Name = "rx_TongTien";
            this.rx_TongTien.Size = new System.Drawing.Size(39, 21);
            this.rx_TongTien.TabIndex = 0;
            this.rx_TongTien.TabStop = true;
            this.rx_TongTien.Text = "X";
            this.rx_TongTien.UseVisualStyleBackColor = true;
            // 
            // rn_TongTien
            // 
            this.rn_TongTien.AutoSize = true;
            this.rn_TongTien.Location = new System.Drawing.Point(104, 25);
            this.rn_TongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rn_TongTien.Name = "rn_TongTien";
            this.rn_TongTien.Size = new System.Drawing.Size(40, 21);
            this.rn_TongTien.TabIndex = 0;
            this.rn_TongTien.TabStop = true;
            this.rn_TongTien.Text = "<";
            this.rn_TongTien.UseVisualStyleBackColor = true;
            // 
            // rb_TongTien
            // 
            this.rb_TongTien.AutoSize = true;
            this.rb_TongTien.Location = new System.Drawing.Point(57, 25);
            this.rb_TongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_TongTien.Name = "rb_TongTien";
            this.rb_TongTien.Size = new System.Drawing.Size(40, 21);
            this.rb_TongTien.TabIndex = 0;
            this.rb_TongTien.TabStop = true;
            this.rb_TongTien.Text = "=";
            this.rb_TongTien.UseVisualStyleBackColor = true;
            // 
            // rl_TongTien
            // 
            this.rl_TongTien.AutoSize = true;
            this.rl_TongTien.Location = new System.Drawing.Point(10, 25);
            this.rl_TongTien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rl_TongTien.Name = "rl_TongTien";
            this.rl_TongTien.Size = new System.Drawing.Size(40, 21);
            this.rl_TongTien.TabIndex = 0;
            this.rl_TongTien.TabStop = true;
            this.rl_TongTien.Text = ">";
            this.rl_TongTien.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb_TenNCC);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(756, 41);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(195, 60);
            this.groupBox4.TabIndex = 92;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tên Nhà Cung Cấp";
            // 
            // cb_TenNCC
            // 
            this.cb_TenNCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TenNCC.FormattingEnabled = true;
            this.cb_TenNCC.Location = new System.Drawing.Point(7, 23);
            this.cb_TenNCC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_TenNCC.Name = "cb_TenNCC";
            this.cb_TenNCC.Size = new System.Drawing.Size(177, 25);
            this.cb_TenNCC.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.cb_TenNhanVien);
            this.groupBox5.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(533, 41);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(195, 60);
            this.groupBox5.TabIndex = 93;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tên nhân viên";
            // 
            // cb_TenNhanVien
            // 
            this.cb_TenNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_TenNhanVien.FormattingEnabled = true;
            this.cb_TenNhanVien.Location = new System.Drawing.Point(7, 23);
            this.cb_TenNhanVien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_TenNhanVien.Name = "cb_TenNhanVien";
            this.cb_TenNhanVien.Size = new System.Drawing.Size(177, 25);
            this.cb_TenNhanVien.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtp_NgayLap);
            this.groupBox1.Controls.Add(this.rx_NgayLap);
            this.groupBox1.Controls.Add(this.rn_NgayLap);
            this.groupBox1.Controls.Add(this.rb_NgayLap);
            this.groupBox1.Controls.Add(this.rl_NgayLap);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(533, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(195, 89);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ngày Mua";
            // 
            // dtp_NgayLap
            // 
            this.dtp_NgayLap.CustomFormat = "";
            this.dtp_NgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_NgayLap.Location = new System.Drawing.Point(7, 55);
            this.dtp_NgayLap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp_NgayLap.Name = "dtp_NgayLap";
            this.dtp_NgayLap.Size = new System.Drawing.Size(177, 24);
            this.dtp_NgayLap.TabIndex = 0;
            // 
            // rx_NgayLap
            // 
            this.rx_NgayLap.AutoSize = true;
            this.rx_NgayLap.Location = new System.Drawing.Point(150, 25);
            this.rx_NgayLap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rx_NgayLap.Name = "rx_NgayLap";
            this.rx_NgayLap.Size = new System.Drawing.Size(39, 21);
            this.rx_NgayLap.TabIndex = 0;
            this.rx_NgayLap.TabStop = true;
            this.rx_NgayLap.Text = "X";
            this.rx_NgayLap.UseVisualStyleBackColor = true;
            // 
            // rn_NgayLap
            // 
            this.rn_NgayLap.AutoSize = true;
            this.rn_NgayLap.Location = new System.Drawing.Point(104, 25);
            this.rn_NgayLap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rn_NgayLap.Name = "rn_NgayLap";
            this.rn_NgayLap.Size = new System.Drawing.Size(40, 21);
            this.rn_NgayLap.TabIndex = 0;
            this.rn_NgayLap.TabStop = true;
            this.rn_NgayLap.Text = "<";
            this.rn_NgayLap.UseVisualStyleBackColor = true;
            // 
            // rb_NgayLap
            // 
            this.rb_NgayLap.AutoSize = true;
            this.rb_NgayLap.Location = new System.Drawing.Point(57, 25);
            this.rb_NgayLap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_NgayLap.Name = "rb_NgayLap";
            this.rb_NgayLap.Size = new System.Drawing.Size(40, 21);
            this.rb_NgayLap.TabIndex = 0;
            this.rb_NgayLap.TabStop = true;
            this.rb_NgayLap.Text = "=";
            this.rb_NgayLap.UseVisualStyleBackColor = true;
            // 
            // rl_NgayLap
            // 
            this.rl_NgayLap.AutoSize = true;
            this.rl_NgayLap.Location = new System.Drawing.Point(10, 25);
            this.rl_NgayLap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rl_NgayLap.Name = "rl_NgayLap";
            this.rl_NgayLap.Size = new System.Drawing.Size(40, 21);
            this.rl_NgayLap.TabIndex = 0;
            this.rl_NgayLap.TabStop = true;
            this.rl_NgayLap.Text = ">";
            this.rl_NgayLap.UseVisualStyleBackColor = true;
            // 
            // btn_XemChiTietHoaDon
            // 
            this.btn_XemChiTietHoaDon.Appearance.ForeColor = System.Drawing.Color.Green;
            this.btn_XemChiTietHoaDon.Appearance.Options.UseForeColor = true;
            this.btn_XemChiTietHoaDon.Location = new System.Drawing.Point(533, 251);
            this.btn_XemChiTietHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XemChiTietHoaDon.Name = "btn_XemChiTietHoaDon";
            this.btn_XemChiTietHoaDon.Size = new System.Drawing.Size(139, 32);
            this.btn_XemChiTietHoaDon.TabIndex = 105;
            this.btn_XemChiTietHoaDon.Text = "Xem chi tiết hóa đơn";
            this.btn_XemChiTietHoaDon.Click += new System.EventHandler(this.btn_XemChiTietHoaDon_Click);
            // 
            // btn_XoaHoaDon
            // 
            this.btn_XoaHoaDon.Appearance.ForeColor = System.Drawing.Color.Maroon;
            this.btn_XoaHoaDon.Appearance.Options.UseForeColor = true;
            this.btn_XoaHoaDon.Location = new System.Drawing.Point(679, 251);
            this.btn_XoaHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XoaHoaDon.Name = "btn_XoaHoaDon";
            this.btn_XoaHoaDon.Size = new System.Drawing.Size(92, 32);
            this.btn_XoaHoaDon.TabIndex = 106;
            this.btn_XoaHoaDon.Text = "Xóa hóa đơn";
            this.btn_XoaHoaDon.Click += new System.EventHandler(this.btn_XoaHoaDon_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(89, 267);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(79, 17);
            this.labelControl3.TabIndex = 108;
            this.labelControl3.Text = "Số Hóa Đơn:";
            // 
            // lb_SoHoaDon
            // 
            this.lb_SoHoaDon.Location = new System.Drawing.Point(167, 267);
            this.lb_SoHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lb_SoHoaDon.Name = "lb_SoHoaDon";
            this.lb_SoHoaDon.Size = new System.Drawing.Size(81, 17);
            this.lb_SoHoaDon.TabIndex = 109;
            this.lb_SoHoaDon.Text = "(Số hóa đơn)";
            // 
            // grid
            // 
            this.grid.DataSource = this.hoaDonMuaHangBindingSource;
            this.grid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid.Location = new System.Drawing.Point(89, 290);
            this.grid.MainView = this.gridView1;
            this.grid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(1080, 321);
            this.grid.TabIndex = 110;
            this.grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.grid_MouseDoubleClick);
            // 
            // hoaDonMuaHangBindingSource
            // 
            this.hoaDonMuaHangBindingSource.DataMember = "HoaDonMuaHang";
            this.hoaDonMuaHangBindingSource.DataSource = this.qLVLXDDataSet24;
            // 
            // qLVLXDDataSet24
            // 
            this.qLVLXDDataSet24.DataSetName = "QLVLXDDataSet24";
            this.qLVLXDDataSet24.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHDMH,
            this.colNgayMua,
            this.colMaNV,
            this.colTenNV,
            this.colMaNCC,
            this.colTenNCC,
            this.colSDTNCC,
            this.colTongTien,
            this.colLive});
            this.gridView1.GridControl = this.grid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaHDMH
            // 
            this.colMaHDMH.Caption = "Mã Hóa Đơn";
            this.colMaHDMH.FieldName = "MaHDMH";
            this.colMaHDMH.Name = "colMaHDMH";
            this.colMaHDMH.Visible = true;
            this.colMaHDMH.VisibleIndex = 0;
            // 
            // colNgayMua
            // 
            this.colNgayMua.Caption = "Ngày Mua";
            this.colNgayMua.FieldName = "NgayMua";
            this.colNgayMua.Name = "colNgayMua";
            this.colNgayMua.Visible = true;
            this.colNgayMua.VisibleIndex = 1;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã NV";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            this.colMaNV.Visible = true;
            this.colMaNV.VisibleIndex = 2;
            // 
            // colTenNV
            // 
            this.colTenNV.Caption = "Tên NV";
            this.colTenNV.FieldName = "TenNV";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Visible = true;
            this.colTenNV.VisibleIndex = 3;
            // 
            // colMaNCC
            // 
            this.colMaNCC.FieldName = "MaNCC";
            this.colMaNCC.Name = "colMaNCC";
            // 
            // colTenNCC
            // 
            this.colTenNCC.FieldName = "TenNCC";
            this.colTenNCC.Name = "colTenNCC";
            // 
            // colSDTNCC
            // 
            this.colSDTNCC.FieldName = "SDTNCC";
            this.colSDTNCC.Name = "colSDTNCC";
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng Tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 4;
            // 
            // colLive
            // 
            this.colLive.FieldName = "Live";
            this.colLive.Name = "colLive";
            // 
            // hoaDonMuaHangTableAdapter
            // 
            this.hoaDonMuaHangTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.num_SoVatLieu);
            this.groupBox2.Controls.Add(this.rx_SoVatLieu);
            this.groupBox2.Controls.Add(this.rn_SoVatLieu);
            this.groupBox2.Controls.Add(this.rb_SoVatLieu);
            this.groupBox2.Controls.Add(this.rl_SoVatLieu);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(974, 108);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(195, 89);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Số Vật Liệu";
            // 
            // num_SoVatLieu
            // 
            this.num_SoVatLieu.Location = new System.Drawing.Point(10, 55);
            this.num_SoVatLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.num_SoVatLieu.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.num_SoVatLieu.Name = "num_SoVatLieu";
            this.num_SoVatLieu.Size = new System.Drawing.Size(177, 24);
            this.num_SoVatLieu.TabIndex = 36;
            this.num_SoVatLieu.ThousandsSeparator = true;
            // 
            // rx_SoVatLieu
            // 
            this.rx_SoVatLieu.AutoSize = true;
            this.rx_SoVatLieu.Location = new System.Drawing.Point(150, 25);
            this.rx_SoVatLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rx_SoVatLieu.Name = "rx_SoVatLieu";
            this.rx_SoVatLieu.Size = new System.Drawing.Size(39, 21);
            this.rx_SoVatLieu.TabIndex = 0;
            this.rx_SoVatLieu.TabStop = true;
            this.rx_SoVatLieu.Text = "X";
            this.rx_SoVatLieu.UseVisualStyleBackColor = true;
            // 
            // rn_SoVatLieu
            // 
            this.rn_SoVatLieu.AutoSize = true;
            this.rn_SoVatLieu.Location = new System.Drawing.Point(104, 25);
            this.rn_SoVatLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rn_SoVatLieu.Name = "rn_SoVatLieu";
            this.rn_SoVatLieu.Size = new System.Drawing.Size(40, 21);
            this.rn_SoVatLieu.TabIndex = 0;
            this.rn_SoVatLieu.TabStop = true;
            this.rn_SoVatLieu.Text = "<";
            this.rn_SoVatLieu.UseVisualStyleBackColor = true;
            // 
            // rb_SoVatLieu
            // 
            this.rb_SoVatLieu.AutoSize = true;
            this.rb_SoVatLieu.Location = new System.Drawing.Point(57, 25);
            this.rb_SoVatLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_SoVatLieu.Name = "rb_SoVatLieu";
            this.rb_SoVatLieu.Size = new System.Drawing.Size(40, 21);
            this.rb_SoVatLieu.TabIndex = 0;
            this.rb_SoVatLieu.TabStop = true;
            this.rb_SoVatLieu.Text = "=";
            this.rb_SoVatLieu.UseVisualStyleBackColor = true;
            // 
            // rl_SoVatLieu
            // 
            this.rl_SoVatLieu.AutoSize = true;
            this.rl_SoVatLieu.Location = new System.Drawing.Point(10, 25);
            this.rl_SoVatLieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rl_SoVatLieu.Name = "rl_SoVatLieu";
            this.rl_SoVatLieu.Size = new System.Drawing.Size(40, 21);
            this.rl_SoVatLieu.TabIndex = 0;
            this.rl_SoVatLieu.TabStop = true;
            this.rl_SoVatLieu.Text = ">";
            this.rl_SoVatLieu.UseVisualStyleBackColor = true;
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(1114, 251);
            this.btn_In.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(57, 37);
            this.btn_In.TabIndex = 102;
            this.btn_In.Text = "In";
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Location = new System.Drawing.Point(1035, 251);
            this.btn_XuatFile.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(72, 37);
            this.btn_XuatFile.TabIndex = 102;
            this.btn_XuatFile.Text = "Xuất File";
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // tb_TenThongKe
            // 
            this.tb_TenThongKe.Location = new System.Drawing.Point(860, 258);
            this.tb_TenThongKe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_TenThongKe.Name = "tb_TenThongKe";
            this.tb_TenThongKe.Size = new System.Drawing.Size(167, 23);
            this.tb_TenThongKe.TabIndex = 113;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(860, 235);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(86, 17);
            this.labelControl2.TabIndex = 112;
            this.labelControl2.Text = "Tên Thống Kê";
            // 
            // ThongKeMuaHang
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 652);
            this.Controls.Add(this.tb_TenThongKe);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.btn_XemChiTietHoaDon);
            this.Controls.Add(this.btn_XoaHoaDon);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lb_SoHoaDon);
            this.Controls.Add(this.btn_Loc);
            this.Controls.Add(this.btn_XuatFile);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ThongKeMuaHang";
            this.Text = "ThongKeMuaHang";
            this.Load += new System.EventHandler(this.ThongKeMuaHang_Load);
            this.VisibleChanged += new System.EventHandler(this.ThongKeMuaHang_VisibleChanged);
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_TongTien)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonMuaHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_SoVatLieu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btn_Loc;
        private DevExpress.XtraEditors.SimpleButton btn_Reset;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.NumericUpDown num_TongTien;
        private System.Windows.Forms.RadioButton rx_TongTien;
        private System.Windows.Forms.RadioButton rn_TongTien;
        private System.Windows.Forms.RadioButton rb_TongTien;
        private System.Windows.Forms.RadioButton rl_TongTien;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cb_TenNCC;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cb_TenNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtp_NgayLap;
        private System.Windows.Forms.RadioButton rx_NgayLap;
        private System.Windows.Forms.RadioButton rn_NgayLap;
        private System.Windows.Forms.RadioButton rb_NgayLap;
        private System.Windows.Forms.RadioButton rl_NgayLap;
        private DevExpress.XtraEditors.SimpleButton btn_XemChiTietHoaDon;
        private DevExpress.XtraEditors.SimpleButton btn_XoaHoaDon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl lb_SoHoaDon;
        private DevExpress.XtraGrid.GridControl grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private QLVLXDDataSet24 qLVLXDDataSet24;
        private System.Windows.Forms.BindingSource hoaDonMuaHangBindingSource;
        private QLVLXDDataSet24TableAdapters.HoaDonMuaHangTableAdapter hoaDonMuaHangTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHDMH;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayMua;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colSDTNCC;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colLive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown num_SoVatLieu;
        private System.Windows.Forms.RadioButton rx_SoVatLieu;
        private System.Windows.Forms.RadioButton rn_SoVatLieu;
        private System.Windows.Forms.RadioButton rb_SoVatLieu;
        private System.Windows.Forms.RadioButton rl_SoVatLieu;
        private DevExpress.XtraEditors.SimpleButton btn_In;
        private DevExpress.XtraEditors.SimpleButton btn_XuatFile;
        private System.Windows.Forms.TextBox tb_TenThongKe;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}