namespace QLVLXD.GUI.TrangChu
{
    partial class Home
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
            this.TMUAHANG = new System.Windows.Forms.PictureBox();
            this.TBANHANG = new System.Windows.Forms.PictureBox();
            this.MUAHANG = new System.Windows.Forms.PictureBox();
            this.BANHANG = new System.Windows.Forms.PictureBox();
            this.LB_BANHANG = new System.Windows.Forms.Label();
            this.LB_TBANHANG = new System.Windows.Forms.Label();
            this.LB_TMUAHANG = new System.Windows.Forms.Label();
            this.LB_MUAHANG = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TMUAHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBANHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUAHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BANHANG)).BeginInit();
            this.SuspendLayout();
            // 
            // TMUAHANG
            // 
            this.TMUAHANG.Image = global::QLVLXD.Properties.Resources.pie_chart_5122;
            this.TMUAHANG.Location = new System.Drawing.Point(612, 310);
            this.TMUAHANG.Name = "TMUAHANG";
            this.TMUAHANG.Size = new System.Drawing.Size(165, 155);
            this.TMUAHANG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TMUAHANG.TabIndex = 0;
            this.TMUAHANG.TabStop = false;
            this.TMUAHANG.Click += new System.EventHandler(this.TMUAHANG_Click);
            // 
            // TBANHANG
            // 
            this.TBANHANG.Image = global::QLVLXD.Properties.Resources.piechart;
            this.TBANHANG.Location = new System.Drawing.Point(120, 310);
            this.TBANHANG.Name = "TBANHANG";
            this.TBANHANG.Size = new System.Drawing.Size(165, 155);
            this.TBANHANG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TBANHANG.TabIndex = 0;
            this.TBANHANG.TabStop = false;
            this.TBANHANG.Click += new System.EventHandler(this.TBANHANG_Click);
            // 
            // MUAHANG
            // 
            this.MUAHANG.Image = global::QLVLXD.Properties.Resources.mua;
            this.MUAHANG.Location = new System.Drawing.Point(612, 58);
            this.MUAHANG.Name = "MUAHANG";
            this.MUAHANG.Size = new System.Drawing.Size(165, 155);
            this.MUAHANG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MUAHANG.TabIndex = 0;
            this.MUAHANG.TabStop = false;
            this.MUAHANG.Click += new System.EventHandler(this.MUAHANG_Click);
            // 
            // BANHANG
            // 
            this.BANHANG.Image = global::QLVLXD.Properties.Resources.banhang;
            this.BANHANG.Location = new System.Drawing.Point(120, 58);
            this.BANHANG.Name = "BANHANG";
            this.BANHANG.Size = new System.Drawing.Size(165, 155);
            this.BANHANG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BANHANG.TabIndex = 0;
            this.BANHANG.TabStop = false;
            this.BANHANG.Click += new System.EventHandler(this.BANHANG_Click);
            // 
            // LB_BANHANG
            // 
            this.LB_BANHANG.AutoSize = true;
            this.LB_BANHANG.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_BANHANG.ForeColor = System.Drawing.Color.Gray;
            this.LB_BANHANG.Location = new System.Drawing.Point(307, 117);
            this.LB_BANHANG.Name = "LB_BANHANG";
            this.LB_BANHANG.Size = new System.Drawing.Size(142, 29);
            this.LB_BANHANG.TabIndex = 1;
            this.LB_BANHANG.Text = "BÁN HÀNG";
            this.LB_BANHANG.Click += new System.EventHandler(this.LB_BANHANG_Click);
            // 
            // LB_TBANHANG
            // 
            this.LB_TBANHANG.AutoSize = true;
            this.LB_TBANHANG.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TBANHANG.ForeColor = System.Drawing.Color.Gray;
            this.LB_TBANHANG.Location = new System.Drawing.Point(307, 374);
            this.LB_TBANHANG.Name = "LB_TBANHANG";
            this.LB_TBANHANG.Size = new System.Drawing.Size(276, 29);
            this.LB_TBANHANG.TabIndex = 1;
            this.LB_TBANHANG.Text = "THỐNG KÊ BÁN HÀNG";
            this.LB_TBANHANG.Click += new System.EventHandler(this.LB_TBANHANG_Click);
            // 
            // LB_TMUAHANG
            // 
            this.LB_TMUAHANG.AutoSize = true;
            this.LB_TMUAHANG.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_TMUAHANG.ForeColor = System.Drawing.Color.Gray;
            this.LB_TMUAHANG.Location = new System.Drawing.Point(797, 374);
            this.LB_TMUAHANG.Name = "LB_TMUAHANG";
            this.LB_TMUAHANG.Size = new System.Drawing.Size(280, 29);
            this.LB_TMUAHANG.TabIndex = 1;
            this.LB_TMUAHANG.Text = "THỐNG KÊ MUA HÀNG";
            this.LB_TMUAHANG.Click += new System.EventHandler(this.LB_TMUAHANG_Click);
            // 
            // LB_MUAHANG
            // 
            this.LB_MUAHANG.AutoSize = true;
            this.LB_MUAHANG.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LB_MUAHANG.ForeColor = System.Drawing.Color.Gray;
            this.LB_MUAHANG.Location = new System.Drawing.Point(797, 117);
            this.LB_MUAHANG.Name = "LB_MUAHANG";
            this.LB_MUAHANG.Size = new System.Drawing.Size(146, 29);
            this.LB_MUAHANG.TabIndex = 1;
            this.LB_MUAHANG.Text = "MUA HÀNG";
            this.LB_MUAHANG.Click += new System.EventHandler(this.LB_MUAHANG_Click);
            // 
            // Home
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 530);
            this.Controls.Add(this.LB_MUAHANG);
            this.Controls.Add(this.LB_TMUAHANG);
            this.Controls.Add(this.LB_TBANHANG);
            this.Controls.Add(this.LB_BANHANG);
            this.Controls.Add(this.TMUAHANG);
            this.Controls.Add(this.TBANHANG);
            this.Controls.Add(this.MUAHANG);
            this.Controls.Add(this.BANHANG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "V";
            ((System.ComponentModel.ISupportInitialize)(this.TMUAHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TBANHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MUAHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BANHANG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BANHANG;
        private System.Windows.Forms.PictureBox MUAHANG;
        private System.Windows.Forms.PictureBox TBANHANG;
        private System.Windows.Forms.PictureBox TMUAHANG;
        private System.Windows.Forms.Label LB_BANHANG;
        private System.Windows.Forms.Label LB_TBANHANG;
        private System.Windows.Forms.Label LB_TMUAHANG;
        private System.Windows.Forms.Label LB_MUAHANG;
    }
}