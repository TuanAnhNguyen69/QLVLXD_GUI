namespace QLVLXD
{
    partial class KhachHang
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
            this.gridControl_KhachHang = new DevExpress.XtraGrid.GridControl();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVLXDDataSet18 = new QLVLXD.QLVLXDDataSet18();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKHTT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCongNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cbb_LoaiKH = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_ResetThongTin = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.txt_CMND = new DevExpress.XtraEditors.TextEdit();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.dtP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_TenKH = new DevExpress.XtraEditors.TextEdit();
            this.lb_MaKH = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.khachHangTableAdapter = new QLVLXD.QLVLXDDataSet18TableAdapters.KhachHangTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_CongNo = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_XuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.btn_In = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_KhachHang
            // 
            this.gridControl_KhachHang.DataSource = this.khachHangBindingSource;
            this.gridControl_KhachHang.Location = new System.Drawing.Point(12, 290);
            this.gridControl_KhachHang.MainView = this.gridView1;
            this.gridControl_KhachHang.Name = "gridControl_KhachHang";
            this.gridControl_KhachHang.Size = new System.Drawing.Size(1120, 200);
            this.gridControl_KhachHang.TabIndex = 15;
            this.gridControl_KhachHang.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl_KhachHang.Click += new System.EventHandler(this.gridControl_KhachHang_Click);
            this.gridControl_KhachHang.MouseCaptureChanged += new System.EventHandler(this.gridControl_KhachHang_MouseCaptureChanged);
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataMember = "KhachHang";
            this.khachHangBindingSource.DataSource = this.qLVLXDDataSet18;
            // 
            // qLVLXDDataSet18
            // 
            this.qLVLXDDataSet18.DataSetName = "QLVLXDDataSet18";
            this.qLVLXDDataSet18.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colDiaChi,
            this.colSDT,
            this.colCMND,
            this.colEmail,
            this.colKHTT,
            this.colLive,
            this.colCongNo});
            this.gridView1.GridControl = this.gridControl_KhachHang;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaKH
            // 
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.Name = "colMaKH";
            // 
            // colTenKH
            // 
            this.colTenKH.Caption = "Tên KH";
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 0;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày Sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 1;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 2;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 3;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "SĐT";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 4;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 5;
            // 
            // colEmail
            // 
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 6;
            // 
            // colKHTT
            // 
            this.colKHTT.Caption = "Loại KH";
            this.colKHTT.FieldName = "KHTT";
            this.colKHTT.Name = "colKHTT";
            this.colKHTT.Visible = true;
            this.colKHTT.VisibleIndex = 7;
            // 
            // colLive
            // 
            this.colLive.FieldName = "Live";
            this.colLive.Name = "colLive";
            // 
            // colCongNo
            // 
            this.colCongNo.Caption = "Công Nợ";
            this.colCongNo.FieldName = "CongNo";
            this.colCongNo.Name = "colCongNo";
            this.colCongNo.Visible = true;
            this.colCongNo.VisibleIndex = 8;
            // 
            // cbb_LoaiKH
            // 
            this.cbb_LoaiKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_LoaiKH.FormattingEnabled = true;
            this.cbb_LoaiKH.Location = new System.Drawing.Point(387, 220);
            this.cbb_LoaiKH.Name = "cbb_LoaiKH";
            this.cbb_LoaiKH.Size = new System.Drawing.Size(157, 21);
            this.cbb_LoaiKH.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(300, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "Loại KH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(300, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Số điện thoại";
            // 
            // btn_ResetThongTin
            // 
            this.btn_ResetThongTin.Location = new System.Drawing.Point(962, 212);
            this.btn_ResetThongTin.Name = "btn_ResetThongTin";
            this.btn_ResetThongTin.Size = new System.Drawing.Size(160, 23);
            this.btn_ResetThongTin.TabIndex = 61;
            this.btn_ResetThongTin.Text = "Reset thông tin";
            this.btn_ResetThongTin.Click += new System.EventHandler(this.btn_ResetThongTin_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Location = new System.Drawing.Point(962, 158);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(160, 48);
            this.btn_CapNhat.TabIndex = 60;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Appearance.Options.UseForeColor = true;
            this.btn_Xoa.Location = new System.Drawing.Point(962, 79);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(160, 73);
            this.btn_Xoa.TabIndex = 59;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Appearance.Options.UseForeColor = true;
            this.btn_Them.Location = new System.Drawing.Point(962, 79);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(160, 127);
            this.btn_Them.TabIndex = 58;
            this.btn_Them.Text = "Thêm \r\nKhách \r\nHàng";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(387, 168);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(157, 20);
            this.txt_Email.TabIndex = 57;
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(387, 114);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(157, 20);
            this.txt_CMND.TabIndex = 56;
            this.txt_CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CMND_KeyPress_1);
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(387, 64);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Size = new System.Drawing.Size(157, 20);
            this.txt_SDT.TabIndex = 55;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress_1);
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(107, 220);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(169, 20);
            this.txt_DiaChi.TabIndex = 54;
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Location = new System.Drawing.Point(107, 167);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(169, 21);
            this.cbb_GioiTinh.TabIndex = 53;
            // 
            // dtP_NgaySinh
            // 
            this.dtP_NgaySinh.Location = new System.Drawing.Point(107, 114);
            this.dtP_NgaySinh.Name = "dtP_NgaySinh";
            this.dtP_NgaySinh.Size = new System.Drawing.Size(169, 20);
            this.dtP_NgaySinh.TabIndex = 52;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(107, 64);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenKH.Properties.Appearance.ForeColor = System.Drawing.Color.Purple;
            this.txt_TenKH.Properties.Appearance.Options.UseFont = true;
            this.txt_TenKH.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TenKH.Size = new System.Drawing.Size(169, 20);
            this.txt_TenKH.TabIndex = 51;
            // 
            // lb_MaKH
            // 
            this.lb_MaKH.AutoSize = true;
            this.lb_MaKH.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaKH.Location = new System.Drawing.Point(103, 23);
            this.lb_MaKH.Name = "lb_MaKH";
            this.lb_MaKH.Size = new System.Drawing.Size(104, 16);
            this.lb_MaKH.TabIndex = 50;
            this.lb_MaKH.Text = "(Mã khách hàng)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(300, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(300, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "CMND";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 47;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 46;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 45;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Tên khách hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Mã khách hàng";
            // 
            // khachHangTableAdapter
            // 
            this.khachHangTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_LoaiKH);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lb_CongNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_CMND);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.cbb_GioiTinh);
            this.groupBox1.Controls.Add(this.dtP_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_TenKH);
            this.groupBox1.Controls.Add(this.lb_MaKH);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(349, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(585, 272);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách Hàng";
            // 
            // lb_CongNo
            // 
            this.lb_CongNo.AutoSize = true;
            this.lb_CongNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_CongNo.Location = new System.Drawing.Point(384, 26);
            this.lb_CongNo.Name = "lb_CongNo";
            this.lb_CongNo.Size = new System.Drawing.Size(59, 13);
            this.lb_CongNo.TabIndex = 62;
            this.lb_CongNo.Text = "(Dữ Liệu)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(300, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 62;
            this.label10.Text = "Công nợ";
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Location = new System.Drawing.Point(962, 239);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(93, 35);
            this.btn_XuatFile.TabIndex = 93;
            this.btn_XuatFile.Text = "Xuất ra File\r";
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(1061, 239);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(61, 35);
            this.btn_In.TabIndex = 92;
            this.btn_In.Text = "In\r\n";
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1227, 491);
            this.Controls.Add(this.btn_XuatFile);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ResetThongTin);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.gridControl_KhachHang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KhachHang";
            this.Text = "Quản Lý Thông Tin Khách Hàng";
            this.Load += new System.EventHandler(this.KhachHang_Load);
            this.VisibleChanged += new System.EventHandler(this.KhachHang_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_KhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl_KhachHang;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ComboBox cbb_LoaiKH;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SimpleButton btn_ResetThongTin;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.TextEdit txt_CMND;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private System.Windows.Forms.DateTimePicker dtP_NgaySinh;
        private DevExpress.XtraEditors.TextEdit txt_TenKH;
        private System.Windows.Forms.Label lb_MaKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private QLVLXDDataSet18 qLVLXDDataSet18;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private QLVLXDDataSet18TableAdapters.KhachHangTableAdapter khachHangTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colKHTT;
        private DevExpress.XtraGrid.Columns.GridColumn colLive;
        private DevExpress.XtraGrid.Columns.GridColumn colCongNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_CongNo;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.SimpleButton btn_XuatFile;
        private DevExpress.XtraEditors.SimpleButton btn_In;
    }
}