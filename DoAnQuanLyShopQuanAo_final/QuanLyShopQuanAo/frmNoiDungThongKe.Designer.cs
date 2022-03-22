namespace QuanLyShopQuanAo
{
    partial class frmNoiDungThongKe
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXem = new System.Windows.Forms.Button();
            this.nbrThang = new System.Windows.Forms.NumericUpDown();
            this.radSoLuong = new System.Windows.Forms.RadioButton();
            this.radSPDaHet = new System.Windows.Forms.RadioButton();
            this.radSPKhongBanDuoc = new System.Windows.Forms.RadioButton();
            this.radDoanhThu = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrThang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(309, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 30);
            this.label1.TabIndex = 18;
            this.label1.Text = "THỐNG KÊ";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.PowderBlue;
            this.groupBox1.Controls.Add(this.btnXem);
            this.groupBox1.Controls.Add(this.nbrThang);
            this.groupBox1.Controls.Add(this.radSoLuong);
            this.groupBox1.Controls.Add(this.radSPDaHet);
            this.groupBox1.Controls.Add(this.radSPKhongBanDuoc);
            this.groupBox1.Controls.Add(this.radDoanhThu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(0, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 439);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nội dung thống kê";
            // 
            // btnXem
            // 
            this.btnXem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXem.BackColor = System.Drawing.Color.White;
            this.btnXem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.Black;
            this.btnXem.Image = global::QuanLyShopQuanAo.Properties.Resources.them21;
            this.btnXem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXem.Location = new System.Drawing.Point(537, 368);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(113, 35);
            this.btnXem.TabIndex = 5;
            this.btnXem.Text = "       Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // nbrThang
            // 
            this.nbrThang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.nbrThang.Location = new System.Drawing.Point(530, 241);
            this.nbrThang.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nbrThang.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nbrThang.Name = "nbrThang";
            this.nbrThang.Size = new System.Drawing.Size(120, 30);
            this.nbrThang.TabIndex = 4;
            this.nbrThang.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // radSoLuong
            // 
            this.radSoLuong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSoLuong.AutoSize = true;
            this.radSoLuong.Location = new System.Drawing.Point(81, 115);
            this.radSoLuong.Name = "radSoLuong";
            this.radSoLuong.Size = new System.Drawing.Size(307, 29);
            this.radSoLuong.TabIndex = 1;
            this.radSoLuong.TabStop = true;
            this.radSoLuong.Text = "Các sản phẩm có số lượng <= 5";
            this.radSoLuong.UseVisualStyleBackColor = true;
            // 
            // radSPDaHet
            // 
            this.radSPDaHet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSPDaHet.AutoSize = true;
            this.radSPDaHet.Location = new System.Drawing.Point(81, 172);
            this.radSPDaHet.Name = "radSPDaHet";
            this.radSPDaHet.Size = new System.Drawing.Size(254, 29);
            this.radSPDaHet.TabIndex = 2;
            this.radSPDaHet.TabStop = true;
            this.radSPDaHet.Text = "Các sản phẩm đã bán hết";
            this.radSPDaHet.UseVisualStyleBackColor = true;
            // 
            // radSPKhongBanDuoc
            // 
            this.radSPKhongBanDuoc.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radSPKhongBanDuoc.AutoSize = true;
            this.radSPKhongBanDuoc.Location = new System.Drawing.Point(81, 242);
            this.radSPKhongBanDuoc.Name = "radSPKhongBanDuoc";
            this.radSPKhongBanDuoc.Size = new System.Drawing.Size(405, 29);
            this.radSPKhongBanDuoc.TabIndex = 3;
            this.radSPKhongBanDuoc.TabStop = true;
            this.radSPKhongBanDuoc.Text = "Các sản phẩm không bán được trong tháng";
            this.radSPKhongBanDuoc.UseVisualStyleBackColor = true;
            // 
            // radDoanhThu
            // 
            this.radDoanhThu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.radDoanhThu.AutoSize = true;
            this.radDoanhThu.Location = new System.Drawing.Point(81, 57);
            this.radDoanhThu.Name = "radDoanhThu";
            this.radDoanhThu.Size = new System.Drawing.Size(205, 29);
            this.radDoanhThu.TabIndex = 0;
            this.radDoanhThu.TabStop = true;
            this.radDoanhThu.Text = "Thống kê doanh thu";
            this.radDoanhThu.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyShopQuanAo.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 45);
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // frmNoiDungThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(747, 499);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNoiDungThongKe";
            this.Text = "frmNoiDungThongKe";
            this.Load += new System.EventHandler(this.frmNoiDungThongKe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbrThang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nbrThang;
        private System.Windows.Forms.RadioButton radSoLuong;
        private System.Windows.Forms.RadioButton radSPDaHet;
        private System.Windows.Forms.RadioButton radSPKhongBanDuoc;
        private System.Windows.Forms.RadioButton radDoanhThu;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}