
namespace QuanLyTaiKhoan
{
    partial class frmTrangChu
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
            this.lbName = new System.Windows.Forms.Label();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.điệnThoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_DangKy = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_QuenMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.máyTínhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_SanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_LoaiSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.chuộtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_HoaDonNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_HoaDonXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_TonKho = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_nd = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip3.SuspendLayout();
            this.panel_nd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(732, 21);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 39);
            this.lbName.TabIndex = 0;
            // 
            // menuStrip3
            // 
            this.menuStrip3.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.điệnThoạiToolStripMenuItem,
            this.máyTínhToolStripMenuItem,
            this.chuộtToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(9, 21);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(558, 43);
            this.menuStrip3.TabIndex = 4;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // điệnThoạiToolStripMenuItem
            // 
            this.điệnThoạiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_DangXuat,
            this.mn_DangKy,
            this.mn_QuenMatKhau,
            this.thoátToolStripMenuItem});
            this.điệnThoạiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.điệnThoạiToolStripMenuItem.Name = "điệnThoạiToolStripMenuItem";
            this.điệnThoạiToolStripMenuItem.Size = new System.Drawing.Size(144, 39);
            this.điệnThoạiToolStripMenuItem.Text = "Hệ Thống";
            // 
            // mn_DangXuat
            // 
            this.mn_DangXuat.Name = "mn_DangXuat";
            this.mn_DangXuat.Size = new System.Drawing.Size(287, 40);
            this.mn_DangXuat.Text = "Đăng Xuất";
            this.mn_DangXuat.Click += new System.EventHandler(this.mn_DangXuat_Click);
            // 
            // mn_DangKy
            // 
            this.mn_DangKy.Name = "mn_DangKy";
            this.mn_DangKy.Size = new System.Drawing.Size(287, 40);
            this.mn_DangKy.Text = "Đăng Ký";
            this.mn_DangKy.Click += new System.EventHandler(this.mn_DangKy_Click);
            // 
            // mn_QuenMatKhau
            // 
            this.mn_QuenMatKhau.Name = "mn_QuenMatKhau";
            this.mn_QuenMatKhau.Size = new System.Drawing.Size(287, 40);
            this.mn_QuenMatKhau.Text = "Quên Mật Khẩu";
            this.mn_QuenMatKhau.Click += new System.EventHandler(this.mn_QuenMatKhau_Click);
            // 
            // máyTínhToolStripMenuItem
            // 
            this.máyTínhToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_SanPham,
            this.mn_LoaiSanPham});
            this.máyTínhToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.máyTínhToolStripMenuItem.Name = "máyTínhToolStripMenuItem";
            this.máyTínhToolStripMenuItem.Size = new System.Drawing.Size(118, 39);
            this.máyTínhToolStripMenuItem.Text = "Quản lý";
            // 
            // mn_SanPham
            // 
            this.mn_SanPham.AccessibleName = "mn_SanPham";
            this.mn_SanPham.Name = "mn_SanPham";
            this.mn_SanPham.Size = new System.Drawing.Size(274, 40);
            this.mn_SanPham.Text = "Sản Phẩm";
            this.mn_SanPham.Click += new System.EventHandler(this.mn_SanPham_Click);
            // 
            // mn_LoaiSanPham
            // 
            this.mn_LoaiSanPham.Name = "mn_LoaiSanPham";
            this.mn_LoaiSanPham.Size = new System.Drawing.Size(274, 40);
            this.mn_LoaiSanPham.Text = "Loại Sản Phẩm";
            // 
            // chuộtToolStripMenuItem
            // 
            this.chuộtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_HoaDonNhap,
            this.mn_HoaDonXuat,
            this.mn_TonKho});
            this.chuộtToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.chuộtToolStripMenuItem.Name = "chuộtToolStripMenuItem";
            this.chuộtToolStripMenuItem.Size = new System.Drawing.Size(132, 39);
            this.chuộtToolStripMenuItem.Text = "Hoá Đơn";
            // 
            // mn_HoaDonNhap
            // 
            this.mn_HoaDonNhap.Name = "mn_HoaDonNhap";
            this.mn_HoaDonNhap.Size = new System.Drawing.Size(278, 40);
            this.mn_HoaDonNhap.Text = "Hoá Đơn Nhập";
            // 
            // mn_HoaDonXuat
            // 
            this.mn_HoaDonXuat.Name = "mn_HoaDonXuat";
            this.mn_HoaDonXuat.Size = new System.Drawing.Size(278, 40);
            this.mn_HoaDonXuat.Text = "Hoá Đơn Xuất";
            // 
            // mn_TonKho
            // 
            this.mn_TonKho.Name = "mn_TonKho";
            this.mn_TonKho.Size = new System.Drawing.Size(278, 40);
            this.mn_TonKho.Text = "Tồn Kho";
            // 
            // panel_nd
            // 
            this.panel_nd.Controls.Add(this.pictureBox1);
            this.panel_nd.Controls.Add(this.label1);
            this.panel_nd.Location = new System.Drawing.Point(9, 128);
            this.panel_nd.Name = "panel_nd";
            this.panel_nd.Size = new System.Drawing.Size(1584, 867);
            this.panel_nd.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(574, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 95);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý ";
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.AccessibleName = "mn_Thoat";
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(287, 40);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuanLyTaiKhoan.Properties.Resources.DoodleTown_Nursery;
            this.pictureBox1.Location = new System.Drawing.Point(-10, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1766, 714);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmTrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 961);
            this.Controls.Add(this.panel_nd);
            this.Controls.Add(this.menuStrip3);
            this.Controls.Add(this.lbName);
            this.Name = "frmTrangChu";
            this.Text = "frmTrangChu";
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.panel_nd.ResumeLayout(false);
            this.panel_nd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripMenuItem điệnThoạiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem mn_QuenMatKhau;
        private System.Windows.Forms.ToolStripMenuItem máyTínhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_SanPham;
        private System.Windows.Forms.ToolStripMenuItem mn_LoaiSanPham;
        private System.Windows.Forms.ToolStripMenuItem chuộtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mn_HoaDonNhap;
        private System.Windows.Forms.ToolStripMenuItem mn_HoaDonXuat;
        private System.Windows.Forms.ToolStripMenuItem mn_TonKho;
        private System.Windows.Forms.Panel panel_nd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mn_DangKy;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}