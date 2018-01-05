namespace QLVLXD.GUI.TrangChu
{
    partial class Login2
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
            this.tb_TenDangNhap = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lb_DangNhap = new System.Windows.Forms.Label();
            this.lb_Thoat = new System.Windows.Forms.Label();
            this.pic_Waiting = new System.Windows.Forms.PictureBox();
            this.pic_Background = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Waiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_TenDangNhap
            // 
            this.tb_TenDangNhap.BackColor = System.Drawing.Color.White;
            this.tb_TenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_TenDangNhap.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_TenDangNhap.Location = new System.Drawing.Point(315, 97);
            this.tb_TenDangNhap.Name = "tb_TenDangNhap";
            this.tb_TenDangNhap.Size = new System.Drawing.Size(266, 40);
            this.tb_TenDangNhap.TabIndex = 0;
            this.tb_TenDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_TenDangNhap_KeyDown);
            // 
            // tb_Password
            // 
            this.tb_Password.BackColor = System.Drawing.Color.White;
            this.tb_Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_Password.Font = new System.Drawing.Font("Tahoma", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(315, 143);
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(266, 40);
            this.tb_Password.TabIndex = 0;
            this.tb_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Password_KeyDown);
            // 
            // lb_DangNhap
            // 
            this.lb_DangNhap.AutoSize = true;
            this.lb_DangNhap.BackColor = System.Drawing.Color.Transparent;
            this.lb_DangNhap.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_DangNhap.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lb_DangNhap.Location = new System.Drawing.Point(311, 210);
            this.lb_DangNhap.Name = "lb_DangNhap";
            this.lb_DangNhap.Size = new System.Drawing.Size(109, 19);
            this.lb_DangNhap.TabIndex = 1;
            this.lb_DangNhap.Text = "ĐĂNG NHẬP";
            this.lb_DangNhap.Click += new System.EventHandler(this.lb_DangNhap_Click);
            // 
            // lb_Thoat
            // 
            this.lb_Thoat.AutoSize = true;
            this.lb_Thoat.BackColor = System.Drawing.Color.Transparent;
            this.lb_Thoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Thoat.ForeColor = System.Drawing.Color.White;
            this.lb_Thoat.Location = new System.Drawing.Point(514, 210);
            this.lb_Thoat.Name = "lb_Thoat";
            this.lb_Thoat.Size = new System.Drawing.Size(67, 19);
            this.lb_Thoat.TabIndex = 1;
            this.lb_Thoat.Text = "THOÁT";
            this.lb_Thoat.Click += new System.EventHandler(this.lb_Thoat_Click);
            // 
            // pic_Waiting
            // 
            this.pic_Waiting.Image = global::QLVLXD.Properties.Resources.giphy;
            this.pic_Waiting.Location = new System.Drawing.Point(262, 12);
            this.pic_Waiting.Name = "pic_Waiting";
            this.pic_Waiting.Size = new System.Drawing.Size(241, 231);
            this.pic_Waiting.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_Waiting.TabIndex = 2;
            this.pic_Waiting.TabStop = false;
            // 
            // pic_Background
            // 
            this.pic_Background.Image = global::QLVLXD.Properties.Resources.giphy2;
            this.pic_Background.Location = new System.Drawing.Point(-25, -13);
            this.pic_Background.Name = "pic_Background";
            this.pic_Background.Size = new System.Drawing.Size(836, 277);
            this.pic_Background.TabIndex = 3;
            this.pic_Background.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Login2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QLVLXD.Properties.Resources._19466879716_fcca804c8c_k1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(774, 255);
            this.Controls.Add(this.pic_Waiting);
            this.Controls.Add(this.pic_Background);
            this.Controls.Add(this.lb_Thoat);
            this.Controls.Add(this.lb_DangNhap);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_TenDangNhap);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login2";
            this.Shown += new System.EventHandler(this.Login2_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pic_Waiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_Background)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_TenDangNhap;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lb_DangNhap;
        private System.Windows.Forms.Label lb_Thoat;
        private System.Windows.Forms.PictureBox pic_Waiting;
        private System.Windows.Forms.PictureBox pic_Background;
        private System.Windows.Forms.Timer timer1;
    }
}