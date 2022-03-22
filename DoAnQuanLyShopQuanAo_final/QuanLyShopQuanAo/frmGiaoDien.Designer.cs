namespace QuanLyShopQuanAo
{
    partial class frmGiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGiaoDien));
            this.menustrGiaoDien = new System.Windows.Forms.MenuStrip();
            this.mtQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.mtThongTinTK = new System.Windows.Forms.ToolStripMenuItem();
            this.mtDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mtNgonNgu = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTiengAnh = new System.Windows.Forms.ToolStripMenuItem();
            this.mtTiengViet = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrGiaoDien.SuspendLayout();
            this.SuspendLayout();
            // 
            // menustrGiaoDien
            // 
            this.menustrGiaoDien.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtQuanLy,
            this.mtThongTinTK,
            this.mtDangXuat,
            this.mtNgonNgu});
            this.menustrGiaoDien.Location = new System.Drawing.Point(0, 0);
            this.menustrGiaoDien.Name = "menustrGiaoDien";
            this.menustrGiaoDien.Size = new System.Drawing.Size(1095, 24);
            this.menustrGiaoDien.TabIndex = 1;
            this.menustrGiaoDien.Text = "menuStrip1";
            // 
            // mtQuanLy
            // 
            this.mtQuanLy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.mtQuanLy.Name = "mtQuanLy";
            this.mtQuanLy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.mtQuanLy.Size = new System.Drawing.Size(62, 20);
            this.mtQuanLy.Text = "Quản Lý";
            this.mtQuanLy.Click += new System.EventHandler(this.quảnLýToolStripMenuItem_Click);
            // 
            // mtThongTinTK
            // 
            this.mtThongTinTK.Name = "mtThongTinTK";
            this.mtThongTinTK.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.mtThongTinTK.Size = new System.Drawing.Size(126, 20);
            this.mtThongTinTK.Text = "Thông Tin Tài Khoản";
            this.mtThongTinTK.Click += new System.EventHandler(this.thôngTinTàiKhoảnToolStripMenuItem_Click);
            // 
            // mtDangXuat
            // 
            this.mtDangXuat.Name = "mtDangXuat";
            this.mtDangXuat.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.mtDangXuat.Size = new System.Drawing.Size(74, 20);
            this.mtDangXuat.Text = "Đăng Xuất";
            this.mtDangXuat.Click += new System.EventHandler(this.ĐăngXuấtToolStripMenuItem_Click);
            // 
            // mtNgonNgu
            // 
            this.mtNgonNgu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mtTiengAnh,
            this.mtTiengViet});
            this.mtNgonNgu.Name = "mtNgonNgu";
            this.mtNgonNgu.Size = new System.Drawing.Size(75, 20);
            this.mtNgonNgu.Text = "Ngôn Ngữ";
            // 
            // mtTiengAnh
            // 
            this.mtTiengAnh.Name = "mtTiengAnh";
            this.mtTiengAnh.Size = new System.Drawing.Size(152, 22);
            this.mtTiengAnh.Text = "Tiếng Anh";
            this.mtTiengAnh.Click += new System.EventHandler(this.tiếngAnhToolStripMenuItem_Click);
            // 
            // mtTiengViet
            // 
            this.mtTiengViet.Name = "mtTiengViet";
            this.mtTiengViet.Size = new System.Drawing.Size(152, 22);
            this.mtTiengViet.Text = "Tiếng Việt";
            this.mtTiengViet.Click += new System.EventHandler(this.mtTiengViet_Click);
            // 
            // frmGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 547);
            this.Controls.Add(this.menustrGiaoDien);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menustrGiaoDien;
            this.Name = "frmGiaoDien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý";
            this.Load += new System.EventHandler(this.frmGiaoDien_Load);
            this.menustrGiaoDien.ResumeLayout(false);
            this.menustrGiaoDien.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menustrGiaoDien;
        private System.Windows.Forms.ToolStripMenuItem mtQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mtThongTinTK;
        private System.Windows.Forms.ToolStripMenuItem mtDangXuat;
        private System.Windows.Forms.ToolStripMenuItem mtNgonNgu;
        private System.Windows.Forms.ToolStripMenuItem mtTiengAnh;
        private System.Windows.Forms.ToolStripMenuItem mtTiengViet;
    }
}