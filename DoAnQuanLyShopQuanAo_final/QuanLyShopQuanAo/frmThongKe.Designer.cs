namespace QuanLyShopQuanAo
{
    partial class frmThongKe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.txtTieuChi = new System.Windows.Forms.TextBox();
            this.cboTieuChi = new System.Windows.Forms.ComboBox();
            this.lblTC = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblKetThuc = new System.Windows.Forms.Label();
            this.lblBatDau = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rptDoanhThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnTimKiem2 = new System.Windows.Forms.Button();
            this.btnTimKiemNgay = new System.Windows.Forms.Button();
            this.lblTieuChi = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDoanhThu = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNgayLapBC = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTieuChi
            // 
            this.txtTieuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTieuChi.Location = new System.Drawing.Point(353, 109);
            this.txtTieuChi.Name = "txtTieuChi";
            this.txtTieuChi.Size = new System.Drawing.Size(144, 26);
            this.txtTieuChi.TabIndex = 4;
            this.txtTieuChi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTieuChi_KeyPress);
            // 
            // cboTieuChi
            // 
            this.cboTieuChi.DisplayMember = "1";
            this.cboTieuChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTieuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTieuChi.FormattingEnabled = true;
            this.cboTieuChi.Items.AddRange(new object[] {
            "IDNVien"});
            this.cboTieuChi.Location = new System.Drawing.Point(98, 107);
            this.cboTieuChi.Name = "cboTieuChi";
            this.cboTieuChi.Size = new System.Drawing.Size(149, 28);
            this.cboTieuChi.TabIndex = 3;
            this.cboTieuChi.ValueMember = "0";
            // 
            // lblTC
            // 
            this.lblTC.AutoSize = true;
            this.lblTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTC.Location = new System.Drawing.Point(22, 115);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(70, 20);
            this.lblTC.TabIndex = 37;
            this.lblTC.Text = "Tiêu Chí:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM/dd/yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(353, 62);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(144, 24);
            this.dtpEnd.TabIndex = 1;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM/dd/yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(96, 62);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(151, 24);
            this.dtpStart.TabIndex = 0;
            // 
            // lblKetThuc
            // 
            this.lblKetThuc.AutoSize = true;
            this.lblKetThuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKetThuc.Location = new System.Drawing.Point(266, 66);
            this.lblKetThuc.Name = "lblKetThuc";
            this.lblKetThuc.Size = new System.Drawing.Size(81, 20);
            this.lblKetThuc.TabIndex = 33;
            this.lblKetThuc.Text = "Đến ngày:";
            // 
            // lblBatDau
            // 
            this.lblBatDau.AutoSize = true;
            this.lblBatDau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatDau.Location = new System.Drawing.Point(21, 66);
            this.lblBatDau.Name = "lblBatDau";
            this.lblBatDau.Size = new System.Drawing.Size(69, 20);
            this.lblBatDau.TabIndex = 32;
            this.lblBatDau.Text = "Từ ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 29);
            this.label1.TabIndex = 31;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // rptDoanhThu
            // 
            this.rptDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rptDoanhThu.DocumentMapWidth = 97;
            this.rptDoanhThu.Location = new System.Drawing.Point(0, 160);
            this.rptDoanhThu.Name = "rptDoanhThu";
            this.rptDoanhThu.Size = new System.Drawing.Size(920, 351);
            this.rptDoanhThu.TabIndex = 44;
            // 
            // btnTimKiem2
            // 
            this.btnTimKiem2.BackColor = System.Drawing.Color.White;
            this.btnTimKiem2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem2.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem2.Image")));
            this.btnTimKiem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem2.Location = new System.Drawing.Point(530, 108);
            this.btnTimKiem2.Name = "btnTimKiem2";
            this.btnTimKiem2.Size = new System.Drawing.Size(108, 28);
            this.btnTimKiem2.TabIndex = 43;
            this.btnTimKiem2.Text = " Tìm Kiếm";
            this.btnTimKiem2.UseVisualStyleBackColor = false;
            this.btnTimKiem2.Click += new System.EventHandler(this.btnTimKiem2_Click);
            // 
            // btnTimKiemNgay
            // 
            this.btnTimKiemNgay.BackColor = System.Drawing.Color.White;
            this.btnTimKiemNgay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiemNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiemNgay.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiemNgay.Image")));
            this.btnTimKiemNgay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiemNgay.Location = new System.Drawing.Point(530, 58);
            this.btnTimKiemNgay.Name = "btnTimKiemNgay";
            this.btnTimKiemNgay.Size = new System.Drawing.Size(108, 28);
            this.btnTimKiemNgay.TabIndex = 2;
            this.btnTimKiemNgay.Text = " Tìm Kiếm";
            this.btnTimKiemNgay.UseVisualStyleBackColor = false;
            this.btnTimKiemNgay.Click += new System.EventHandler(this.btnTimKiemNgay_Click);
            // 
            // lblTieuChi
            // 
            this.lblTieuChi.AutoSize = true;
            this.lblTieuChi.BackColor = System.Drawing.Color.White;
            this.lblTieuChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuChi.Location = new System.Drawing.Point(12, 280);
            this.lblTieuChi.Name = "lblTieuChi";
            this.lblTieuChi.Size = new System.Drawing.Size(64, 16);
            this.lblTieuChi.TabIndex = 53;
            this.lblTieuChi.Text = "Từ ngày";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(631, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 54;
            this.label7.Text = "Tổng doanh thu: ";
            // 
            // lblDoanhThu
            // 
            this.lblDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDoanhThu.AutoSize = true;
            this.lblDoanhThu.BackColor = System.Drawing.Color.White;
            this.lblDoanhThu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDoanhThu.Location = new System.Drawing.Point(754, 280);
            this.lblDoanhThu.Name = "lblDoanhThu";
            this.lblDoanhThu.Size = new System.Drawing.Size(29, 16);
            this.lblDoanhThu.TabIndex = 55;
            this.lblDoanhThu.Text = "0 đ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, 192);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(920, 74);
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::QuanLyShopQuanAo.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 192);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(163, 58);
            this.pictureBox2.TabIndex = 57;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(305, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "THỐNG KÊ DOANH THU";
            // 
            // lblNgayLapBC
            // 
            this.lblNgayLapBC.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNgayLapBC.AutoSize = true;
            this.lblNgayLapBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayLapBC.Location = new System.Drawing.Point(732, 234);
            this.lblNgayLapBC.Name = "lblNgayLapBC";
            this.lblNgayLapBC.Size = new System.Drawing.Size(51, 16);
            this.lblNgayLapBC.TabIndex = 59;
            this.lblNgayLapBC.Text = "label6";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(660, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ngày lập:";
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(920, 511);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNgayLapBC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDoanhThu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblTieuChi);
            this.Controls.Add(this.rptDoanhThu);
            this.Controls.Add(this.btnTimKiem2);
            this.Controls.Add(this.txtTieuChi);
            this.Controls.Add(this.cboTieuChi);
            this.Controls.Add(this.lblTC);
            this.Controls.Add(this.btnTimKiemNgay);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.lblKetThuc);
            this.Controls.Add(this.lblBatDau);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Doanh Thu";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTieuChi;
        private System.Windows.Forms.ComboBox cboTieuChi;
        private System.Windows.Forms.Label lblTC;
        private System.Windows.Forms.Button btnTimKiemNgay;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblKetThuc;
        private System.Windows.Forms.Label lblBatDau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimKiem2;
        private Microsoft.Reporting.WinForms.ReportViewer rptDoanhThu;
        private System.Windows.Forms.Label lblTieuChi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDoanhThu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNgayLapBC;
        private System.Windows.Forms.Label label2;
    }
}