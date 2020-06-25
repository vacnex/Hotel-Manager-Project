namespace QuanLyThuePhong
{
    partial class Frm_TrangChu
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
            this.mnu_MenuChinh = new System.Windows.Forms.MenuStrip();
            this.mnu_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_QLTaiKhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_DangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_QuanLyDuLieu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_QLKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_QLPhong = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_QLDichVu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_ChucNang = new System.Windows.Forms.ToolStripMenuItem();
            this.thuêPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trảPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sửDụngDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmKháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmPhòngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnu_MenuChinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnu_MenuChinh
            // 
            this.mnu_MenuChinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_HeThong,
            this.mnu_QuanLyDuLieu,
            this.mnu_ChucNang,
            this.tìmKiếmToolStripMenuItem});
            this.mnu_MenuChinh.Location = new System.Drawing.Point(0, 0);
            this.mnu_MenuChinh.Name = "mnu_MenuChinh";
            this.mnu_MenuChinh.Size = new System.Drawing.Size(800, 24);
            this.mnu_MenuChinh.TabIndex = 1;
            this.mnu_MenuChinh.Text = "menuStrip1";
            // 
            // mnu_HeThong
            // 
            this.mnu_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_QLTaiKhoan,
            this.mnu_DangXuat,
            this.mnu_Thoat});
            this.mnu_HeThong.Name = "mnu_HeThong";
            this.mnu_HeThong.Size = new System.Drawing.Size(69, 20);
            this.mnu_HeThong.Text = "Hệ thống";
            // 
            // mnu_QLTaiKhoan
            // 
            this.mnu_QLTaiKhoan.Name = "mnu_QLTaiKhoan";
            this.mnu_QLTaiKhoan.Size = new System.Drawing.Size(179, 22);
            this.mnu_QLTaiKhoan.Text = "Quản lý tài khoản";
            // 
            // mnu_DangXuat
            // 
            this.mnu_DangXuat.Name = "mnu_DangXuat";
            this.mnu_DangXuat.Size = new System.Drawing.Size(179, 22);
            this.mnu_DangXuat.Text = "Đăng xuất (Ctrl + X)";
            // 
            // mnu_Thoat
            // 
            this.mnu_Thoat.Name = "mnu_Thoat";
            this.mnu_Thoat.Size = new System.Drawing.Size(179, 22);
            this.mnu_Thoat.Text = "Thoát (Alt + F4)";
            // 
            // mnu_QuanLyDuLieu
            // 
            this.mnu_QuanLyDuLieu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnu_QLKhachHang,
            this.mnu_QLPhong,
            this.mnu_QLDichVu});
            this.mnu_QuanLyDuLieu.Name = "mnu_QuanLyDuLieu";
            this.mnu_QuanLyDuLieu.Size = new System.Drawing.Size(99, 20);
            this.mnu_QuanLyDuLieu.Text = "Quản lý dữ liệu";
            // 
            // mnu_QLKhachHang
            // 
            this.mnu_QLKhachHang.Name = "mnu_QLKhachHang";
            this.mnu_QLKhachHang.Size = new System.Drawing.Size(180, 22);
            this.mnu_QLKhachHang.Text = "Quản lý khách";
            this.mnu_QLKhachHang.Click += new System.EventHandler(this.mnu_QLKhachHang_Click);
            // 
            // mnu_QLPhong
            // 
            this.mnu_QLPhong.Name = "mnu_QLPhong";
            this.mnu_QLPhong.Size = new System.Drawing.Size(180, 22);
            this.mnu_QLPhong.Text = "Quản lý phòng";
            this.mnu_QLPhong.Click += new System.EventHandler(this.mnu_QLPhong_Click);
            // 
            // mnu_QLDichVu
            // 
            this.mnu_QLDichVu.Name = "mnu_QLDichVu";
            this.mnu_QLDichVu.Size = new System.Drawing.Size(180, 22);
            this.mnu_QLDichVu.Text = "Quản lý dịch vụ";
            // 
            // mnu_ChucNang
            // 
            this.mnu_ChucNang.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thuêPhòngToolStripMenuItem,
            this.trảPhòngToolStripMenuItem,
            this.sửDụngDịchVụToolStripMenuItem});
            this.mnu_ChucNang.Name = "mnu_ChucNang";
            this.mnu_ChucNang.Size = new System.Drawing.Size(77, 20);
            this.mnu_ChucNang.Text = "Chức năng";
            // 
            // thuêPhòngToolStripMenuItem
            // 
            this.thuêPhòngToolStripMenuItem.Name = "thuêPhòngToolStripMenuItem";
            this.thuêPhòngToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.thuêPhòngToolStripMenuItem.Text = "Thuê phòng";
            // 
            // trảPhòngToolStripMenuItem
            // 
            this.trảPhòngToolStripMenuItem.Name = "trảPhòngToolStripMenuItem";
            this.trảPhòngToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.trảPhòngToolStripMenuItem.Text = "Trả phòng";
            // 
            // sửDụngDịchVụToolStripMenuItem
            // 
            this.sửDụngDịchVụToolStripMenuItem.Name = "sửDụngDịchVụToolStripMenuItem";
            this.sửDụngDịchVụToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sửDụngDịchVụToolStripMenuItem.Text = "Sử dụng dịch vụ";
            // 
            // tìmKiếmToolStripMenuItem
            // 
            this.tìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tìmKiếmKháchHàngToolStripMenuItem,
            this.tìmKiếmPhòngToolStripMenuItem});
            this.tìmKiếmToolStripMenuItem.Name = "tìmKiếmToolStripMenuItem";
            this.tìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.tìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // tìmKiếmKháchHàngToolStripMenuItem
            // 
            this.tìmKiếmKháchHàngToolStripMenuItem.Name = "tìmKiếmKháchHàngToolStripMenuItem";
            this.tìmKiếmKháchHàngToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.tìmKiếmKháchHàngToolStripMenuItem.Text = "Tìm kiếm khách hàng";
            // 
            // tìmKiếmPhòngToolStripMenuItem
            // 
            this.tìmKiếmPhòngToolStripMenuItem.Name = "tìmKiếmPhòngToolStripMenuItem";
            this.tìmKiếmPhòngToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.tìmKiếmPhòngToolStripMenuItem.Text = "Tìm kiếm phòng";
            // 
            // Frm_TrangChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnu_MenuChinh);
            this.Name = "Frm_TrangChu";
            this.Text = "TRANG CHỦ";
            this.Load += new System.EventHandler(this.Frm_TrangChu_Load);
            this.mnu_MenuChinh.ResumeLayout(false);
            this.mnu_MenuChinh.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnu_MenuChinh;
        private System.Windows.Forms.ToolStripMenuItem mnu_HeThong;
        private System.Windows.Forms.ToolStripMenuItem mnu_QLTaiKhoan;
        private System.Windows.Forms.ToolStripMenuItem mnu_DangXuat;
        private System.Windows.Forms.ToolStripMenuItem mnu_Thoat;
        private System.Windows.Forms.ToolStripMenuItem mnu_QuanLyDuLieu;
        private System.Windows.Forms.ToolStripMenuItem mnu_QLKhachHang;
        private System.Windows.Forms.ToolStripMenuItem mnu_QLPhong;
        private System.Windows.Forms.ToolStripMenuItem mnu_QLDichVu;
        private System.Windows.Forms.ToolStripMenuItem mnu_ChucNang;
        private System.Windows.Forms.ToolStripMenuItem thuêPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trảPhòngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sửDụngDịchVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmKháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmPhòngToolStripMenuItem;
    }
}

