namespace QLVLXD
{
    partial class QuanLyThongTinNhanVien
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
            this.gridControl_QuanLyNhanVien = new DevExpress.XtraGrid.GridControl();
            this.nhanVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLVLXDDataSet19 = new QLVLXD.QLVLXDDataSet19();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenNV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgaySinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGioiTinh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChucVu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMucLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEmail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_ChucVu = new System.Windows.Forms.ComboBox();
            this.cbb_GioiTinh = new System.Windows.Forms.ComboBox();
            this.btn_ResetThongTin = new DevExpress.XtraEditors.SimpleButton();
            this.btn_CapNhat = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.btn_Them = new DevExpress.XtraEditors.SimpleButton();
            this.lb_MaNhanVien = new DevExpress.XtraEditors.LabelControl();
            this.dTP_NgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txt_SDT = new DevExpress.XtraEditors.TextEdit();
            this.txt_CMND = new DevExpress.XtraEditors.TextEdit();
            this.txt_Email = new DevExpress.XtraEditors.TextEdit();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.nhanVienTableAdapter = new QLVLXD.QLVLXDDataSet19TableAdapters.NhanVienTableAdapter();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MucLuong = new DevExpress.XtraEditors.TextEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_XuatFile = new DevExpress.XtraEditors.SimpleButton();
            this.btn_In = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuanLyNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MucLuong.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl_QuanLyNhanVien
            // 
            this.gridControl_QuanLyNhanVien.DataSource = this.nhanVienBindingSource;
            this.gridControl_QuanLyNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_QuanLyNhanVien.Location = new System.Drawing.Point(16, 353);
            this.gridControl_QuanLyNhanVien.MainView = this.gridView1;
            this.gridControl_QuanLyNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl_QuanLyNhanVien.Name = "gridControl_QuanLyNhanVien";
            this.gridControl_QuanLyNhanVien.Size = new System.Drawing.Size(1493, 236);
            this.gridControl_QuanLyNhanVien.TabIndex = 20;
            this.gridControl_QuanLyNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl_QuanLyNhanVien.MouseCaptureChanged += new System.EventHandler(this.gridControl_QuanLyNhanVien_MouseCaptureChanged);
            // 
            // nhanVienBindingSource
            // 
            this.nhanVienBindingSource.DataMember = "NhanVien";
            this.nhanVienBindingSource.DataSource = this.qLVLXDDataSet19;
            // 
            // qLVLXDDataSet19
            // 
            this.qLVLXDDataSet19.DataSetName = "QLVLXDDataSet19";
            this.qLVLXDDataSet19.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaNV,
            this.colTenNV,
            this.colDiaChi,
            this.colSDT,
            this.colNgaySinh,
            this.colGioiTinh,
            this.colChucVu,
            this.colCMND,
            this.colMucLuong,
            this.colEmail,
            this.colLive});
            this.gridView1.GridControl = this.gridControl_QuanLyNhanVien;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colMaNV
            // 
            this.colMaNV.Caption = "Mã NV";
            this.colMaNV.FieldName = "MaNV";
            this.colMaNV.Name = "colMaNV";
            // 
            // colTenNV
            // 
            this.colTenNV.Caption = "Tên NV";
            this.colTenNV.FieldName = "TenNV";
            this.colTenNV.Name = "colTenNV";
            this.colTenNV.Visible = true;
            this.colTenNV.VisibleIndex = 0;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 1;
            // 
            // colSDT
            // 
            this.colSDT.Caption = "SĐT";
            this.colSDT.FieldName = "SDT";
            this.colSDT.Name = "colSDT";
            this.colSDT.Visible = true;
            this.colSDT.VisibleIndex = 2;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Caption = "Ngày Sinh";
            this.colNgaySinh.FieldName = "NgaySinh";
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Visible = true;
            this.colNgaySinh.VisibleIndex = 3;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Caption = "Giới Tính";
            this.colGioiTinh.FieldName = "GioiTinh";
            this.colGioiTinh.Name = "colGioiTinh";
            this.colGioiTinh.Visible = true;
            this.colGioiTinh.VisibleIndex = 4;
            // 
            // colChucVu
            // 
            this.colChucVu.Caption = "Chức Vụ";
            this.colChucVu.FieldName = "ChucVu";
            this.colChucVu.Name = "colChucVu";
            this.colChucVu.Visible = true;
            this.colChucVu.VisibleIndex = 5;
            // 
            // colCMND
            // 
            this.colCMND.Caption = "CMND";
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 6;
            // 
            // colMucLuong
            // 
            this.colMucLuong.Caption = "Lương";
            this.colMucLuong.FieldName = "MucLuong";
            this.colMucLuong.Name = "colMucLuong";
            this.colMucLuong.Visible = true;
            this.colMucLuong.VisibleIndex = 7;
            // 
            // colEmail
            // 
            this.colEmail.Caption = "Email";
            this.colEmail.FieldName = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Visible = true;
            this.colEmail.VisibleIndex = 8;
            // 
            // colLive
            // 
            this.colLive.FieldName = "Live";
            this.colLive.Name = "colLive";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 58;
            this.label1.Text = "Giới tính";
            // 
            // cbb_ChucVu
            // 
            this.cbb_ChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_ChucVu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_ChucVu.FormattingEnabled = true;
            this.cbb_ChucVu.Location = new System.Drawing.Point(569, 89);
            this.cbb_ChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_ChucVu.Name = "cbb_ChucVu";
            this.cbb_ChucVu.Size = new System.Drawing.Size(223, 25);
            this.cbb_ChucVu.TabIndex = 57;
            // 
            // cbb_GioiTinh
            // 
            this.cbb_GioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_GioiTinh.FormattingEnabled = true;
            this.cbb_GioiTinh.Location = new System.Drawing.Point(569, 32);
            this.cbb_GioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_GioiTinh.Name = "cbb_GioiTinh";
            this.cbb_GioiTinh.Size = new System.Drawing.Size(223, 25);
            this.cbb_GioiTinh.TabIndex = 56;
            // 
            // btn_ResetThongTin
            // 
            this.btn_ResetThongTin.Location = new System.Drawing.Point(397, 318);
            this.btn_ResetThongTin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_ResetThongTin.Name = "btn_ResetThongTin";
            this.btn_ResetThongTin.Size = new System.Drawing.Size(112, 28);
            this.btn_ResetThongTin.TabIndex = 55;
            this.btn_ResetThongTin.Text = "Reset";
            this.btn_ResetThongTin.Click += new System.EventHandler(this.btn_ResetThongTin_Click);
            // 
            // btn_CapNhat
            // 
            this.btn_CapNhat.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_CapNhat.Appearance.Options.UseFont = true;
            this.btn_CapNhat.Location = new System.Drawing.Point(1312, 186);
            this.btn_CapNhat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CapNhat.Name = "btn_CapNhat";
            this.btn_CapNhat.Size = new System.Drawing.Size(120, 48);
            this.btn_CapNhat.TabIndex = 54;
            this.btn_CapNhat.Text = "Cập nhật";
            this.btn_CapNhat.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Appearance.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btn_Xoa.Appearance.Options.UseFont = true;
            this.btn_Xoa.Appearance.Options.UseForeColor = true;
            this.btn_Xoa.Location = new System.Drawing.Point(1312, 94);
            this.btn_Xoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(120, 85);
            this.btn_Xoa.TabIndex = 53;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.Appearance.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Them.Appearance.Options.UseFont = true;
            this.btn_Them.Appearance.Options.UseForeColor = true;
            this.btn_Them.Location = new System.Drawing.Point(1312, 94);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(120, 140);
            this.btn_Them.TabIndex = 52;
            this.btn_Them.Text = "Thêm \r\nNhân \r\nViên";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // lb_MaNhanVien
            // 
            this.lb_MaNhanVien.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_MaNhanVien.Location = new System.Drawing.Point(155, 33);
            this.lb_MaNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lb_MaNhanVien.Name = "lb_MaNhanVien";
            this.lb_MaNhanVien.Size = new System.Drawing.Size(106, 19);
            this.lb_MaNhanVien.TabIndex = 51;
            this.lb_MaNhanVien.Text = "(Mã nhân viên)";
            // 
            // dTP_NgaySinh
            // 
            this.dTP_NgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dTP_NgaySinh.Location = new System.Drawing.Point(155, 241);
            this.dTP_NgaySinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTP_NgaySinh.Name = "dTP_NgaySinh";
            this.dTP_NgaySinh.Size = new System.Drawing.Size(241, 23);
            this.dTP_NgaySinh.TabIndex = 50;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Location = new System.Drawing.Point(155, 196);
            this.txt_SDT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Properties.Appearance.Options.UseFont = true;
            this.txt_SDT.Size = new System.Drawing.Size(243, 24);
            this.txt_SDT.TabIndex = 48;
            this.txt_SDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_SDT_KeyPress_1);
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(569, 196);
            this.txt_CMND.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMND.Properties.Appearance.Options.UseFont = true;
            this.txt_CMND.Size = new System.Drawing.Size(224, 24);
            this.txt_CMND.TabIndex = 47;
            this.txt_CMND.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CMND_KeyPress);
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(569, 245);
            this.txt_Email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Email.Properties.Appearance.Options.UseFont = true;
            this.txt_Email.Size = new System.Drawing.Size(224, 24);
            this.txt_Email.TabIndex = 46;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(155, 140);
            this.txt_DiaChi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Properties.Appearance.Options.UseFont = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(243, 24);
            this.txt_DiaChi.TabIndex = 45;
            // 
            // txt_TenNhanVien
            // 
            this.txt_TenNhanVien.Location = new System.Drawing.Point(155, 89);
            this.txt_TenNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_TenNhanVien.Name = "txt_TenNhanVien";
            this.txt_TenNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TenNhanVien.Properties.Appearance.ForeColor = System.Drawing.Color.Purple;
            this.txt_TenNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txt_TenNhanVien.Properties.Appearance.Options.UseForeColor = true;
            this.txt_TenNhanVien.Size = new System.Drawing.Size(243, 24);
            this.txt_TenNhanVien.TabIndex = 44;
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl10.Location = new System.Drawing.Point(8, 92);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(115, 19);
            this.labelControl10.TabIndex = 43;
            this.labelControl10.Text = "Tên nhân viên";
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl9.Location = new System.Drawing.Point(460, 249);
            this.labelControl9.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(45, 19);
            this.labelControl9.TabIndex = 42;
            this.labelControl9.Text = "Email";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl8.Location = new System.Drawing.Point(460, 199);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(49, 19);
            this.labelControl8.TabIndex = 41;
            this.labelControl8.Text = "CMND";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl7.Location = new System.Drawing.Point(460, 92);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(69, 21);
            this.labelControl7.TabIndex = 40;
            this.labelControl7.Text = "Chức vụ";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Location = new System.Drawing.Point(8, 249);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 19);
            this.labelControl4.TabIndex = 38;
            this.labelControl4.Text = "Ngày sinh";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Location = new System.Drawing.Point(8, 199);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 21);
            this.labelControl3.TabIndex = 37;
            this.labelControl3.Text = "Điện thoại";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Location = new System.Drawing.Point(8, 144);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 21);
            this.labelControl2.TabIndex = 36;
            this.labelControl2.Text = "Địa chỉ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Location = new System.Drawing.Point(8, 37);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(108, 19);
            this.labelControl1.TabIndex = 35;
            this.labelControl1.Text = "Mã nhân viên";
            // 
            // nhanVienTableAdapter
            // 
            this.nhanVienTableAdapter.ClearBeforeFill = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl6.Location = new System.Drawing.Point(457, 144);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(91, 21);
            this.labelControl6.TabIndex = 39;
            this.labelControl6.Text = "Mức lương";
            // 
            // txt_MucLuong
            // 
            this.txt_MucLuong.Location = new System.Drawing.Point(569, 140);
            this.txt_MucLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_MucLuong.Name = "txt_MucLuong";
            this.txt_MucLuong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MucLuong.Properties.Appearance.Options.UseFont = true;
            this.txt_MucLuong.Size = new System.Drawing.Size(224, 24);
            this.txt_MucLuong.TabIndex = 49;
            this.txt_MucLuong.EditValueChanged += new System.EventHandler(this.txt_MucLuong_EditValueChanged);
            this.txt_MucLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_MucLuong_KeyPress_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbb_ChucVu);
            this.groupBox1.Controls.Add(this.cbb_GioiTinh);
            this.groupBox1.Controls.Add(this.lb_MaNhanVien);
            this.groupBox1.Controls.Add(this.dTP_NgaySinh);
            this.groupBox1.Controls.Add(this.txt_MucLuong);
            this.groupBox1.Controls.Add(this.txt_SDT);
            this.groupBox1.Controls.Add(this.txt_CMND);
            this.groupBox1.Controls.Add(this.txt_Email);
            this.groupBox1.Controls.Add(this.txt_DiaChi);
            this.groupBox1.Controls.Add(this.txt_TenNhanVien);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(397, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(817, 278);
            this.groupBox1.TabIndex = 59;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhân Viên";
            // 
            // btn_XuatFile
            // 
            this.btn_XuatFile.Location = new System.Drawing.Point(1047, 300);
            this.btn_XuatFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_XuatFile.Name = "btn_XuatFile";
            this.btn_XuatFile.Size = new System.Drawing.Size(103, 43);
            this.btn_XuatFile.TabIndex = 91;
            this.btn_XuatFile.Text = "Xuất ra File\r";
            this.btn_XuatFile.Click += new System.EventHandler(this.btn_XuatFile_Click);
            // 
            // btn_In
            // 
            this.btn_In.Location = new System.Drawing.Point(1157, 300);
            this.btn_In.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_In.Name = "btn_In";
            this.btn_In.Size = new System.Drawing.Size(61, 43);
            this.btn_In.TabIndex = 90;
            this.btn_In.Text = "In\r\n";
            this.btn_In.Click += new System.EventHandler(this.btn_In_Click);
            // 
            // QuanLyThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1525, 604);
            this.Controls.Add(this.btn_XuatFile);
            this.Controls.Add(this.btn_In);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_ResetThongTin);
            this.Controls.Add(this.btn_CapNhat);
            this.Controls.Add(this.btn_Xoa);
            this.Controls.Add(this.gridControl_QuanLyNhanVien);
            this.Controls.Add(this.btn_Them);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QuanLyThongTinNhanVien";
            this.Text = "Quản Lý Thông Tin Nhân Viên";
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_QuanLyNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanVienBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLVLXDDataSet19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SDT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MucLuong.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControl_QuanLyNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_ChucVu;
        private System.Windows.Forms.ComboBox cbb_GioiTinh;
        private DevExpress.XtraEditors.SimpleButton btn_ResetThongTin;
        private DevExpress.XtraEditors.SimpleButton btn_CapNhat;
        private DevExpress.XtraEditors.SimpleButton btn_Xoa;
        private DevExpress.XtraEditors.SimpleButton btn_Them;
        private DevExpress.XtraEditors.LabelControl lb_MaNhanVien;
        private System.Windows.Forms.DateTimePicker dTP_NgaySinh;
        private DevExpress.XtraEditors.TextEdit txt_SDT;
        private DevExpress.XtraEditors.TextEdit txt_CMND;
        private DevExpress.XtraEditors.TextEdit txt_Email;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraEditors.TextEdit txt_TenNhanVien;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private QLVLXDDataSet19 qLVLXDDataSet19;
        private System.Windows.Forms.BindingSource nhanVienBindingSource;
        private QLVLXDDataSet19TableAdapters.NhanVienTableAdapter nhanVienTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colMaNV;
        private DevExpress.XtraGrid.Columns.GridColumn colTenNV;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
        private DevExpress.XtraGrid.Columns.GridColumn colSDT;
        private DevExpress.XtraGrid.Columns.GridColumn colNgaySinh;
        private DevExpress.XtraGrid.Columns.GridColumn colGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn colChucVu;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colMucLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colEmail;
        private DevExpress.XtraGrid.Columns.GridColumn colLive;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_MucLuong;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btn_XuatFile;
        private DevExpress.XtraEditors.SimpleButton btn_In;
    }
}