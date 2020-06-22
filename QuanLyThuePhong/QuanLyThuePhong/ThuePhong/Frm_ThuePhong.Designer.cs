namespace QuanLyThuePhong.ThuePhong
{
    partial class Frm_ThuePhong
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.colidCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcusAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcusGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcusPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ChonKhachHang = new System.Windows.Forms.Button();
            this.btn_ThemKhachHang = new System.Windows.Forms.Button();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Phong = new System.Windows.Forms.DataGridView();
            this.colIdRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbb_LoaiPhong = new System.Windows.Forms.ComboBox();
            this.btn_ChonPhong = new System.Windows.Forms.Button();
            this.txt_NhanVien = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_IdRoomBook = new System.Windows.Forms.TextBox();
            this.txt_NgayDi = new System.Windows.Forms.TextBox();
            this.dgv_ThuePhong = new System.Windows.Forms.DataGridView();
            this.colIdRoomBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayDi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_ThuePhong = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.dgv_KhachHang);
            this.groupBox1.Controls.Add(this.btn_ChonKhachHang);
            this.groupBox1.Controls.Add(this.btn_ThemKhachHang);
            this.groupBox1.Controls.Add(this.txt_CMND);
            this.groupBox1.Location = new System.Drawing.Point(12, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1086, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Location = new System.Drawing.Point(963, 62);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(112, 23);
            this.btn_TimKiem.TabIndex = 6;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // dgv_KhachHang
            // 
            this.dgv_KhachHang.AllowUserToAddRows = false;
            this.dgv_KhachHang.AllowUserToDeleteRows = false;
            this.dgv_KhachHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_KhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_KhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colidCard,
            this.colcusName,
            this.colcusAddress,
            this.colcusGender,
            this.colcusPhone});
            this.dgv_KhachHang.Location = new System.Drawing.Point(6, 19);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersVisible = false;
            this.dgv_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KhachHang.Size = new System.Drawing.Size(941, 170);
            this.dgv_KhachHang.TabIndex = 5;
            // 
            // colidCard
            // 
            this.colidCard.DataPropertyName = "IdCard";
            this.colidCard.HeaderText = "Chứng minh nhân dân";
            this.colidCard.Name = "colidCard";
            this.colidCard.ReadOnly = true;
            // 
            // colcusName
            // 
            this.colcusName.DataPropertyName = "CusName";
            this.colcusName.HeaderText = "Họ tên";
            this.colcusName.Name = "colcusName";
            this.colcusName.ReadOnly = true;
            // 
            // colcusAddress
            // 
            this.colcusAddress.DataPropertyName = "CusAddress";
            this.colcusAddress.HeaderText = "Địa chỉ";
            this.colcusAddress.Name = "colcusAddress";
            this.colcusAddress.ReadOnly = true;
            // 
            // colcusGender
            // 
            this.colcusGender.DataPropertyName = "CusGender";
            this.colcusGender.HeaderText = "Giới tính";
            this.colcusGender.Name = "colcusGender";
            this.colcusGender.ReadOnly = true;
            // 
            // colcusPhone
            // 
            this.colcusPhone.DataPropertyName = "CusPhone";
            this.colcusPhone.HeaderText = "Số điện thoại";
            this.colcusPhone.Name = "colcusPhone";
            this.colcusPhone.ReadOnly = true;
            // 
            // btn_ChonKhachHang
            // 
            this.btn_ChonKhachHang.Location = new System.Drawing.Point(963, 140);
            this.btn_ChonKhachHang.Name = "btn_ChonKhachHang";
            this.btn_ChonKhachHang.Size = new System.Drawing.Size(112, 23);
            this.btn_ChonKhachHang.TabIndex = 4;
            this.btn_ChonKhachHang.Text = "Chọn khách";
            this.btn_ChonKhachHang.UseVisualStyleBackColor = true;
            this.btn_ChonKhachHang.Click += new System.EventHandler(this.btn_ChonKhachHang_Click);
            // 
            // btn_ThemKhachHang
            // 
            this.btn_ThemKhachHang.Location = new System.Drawing.Point(963, 100);
            this.btn_ThemKhachHang.Name = "btn_ThemKhachHang";
            this.btn_ThemKhachHang.Size = new System.Drawing.Size(112, 23);
            this.btn_ThemKhachHang.TabIndex = 3;
            this.btn_ThemKhachHang.Text = "Thêm khách hàng";
            this.btn_ThemKhachHang.UseVisualStyleBackColor = true;
            this.btn_ThemKhachHang.Click += new System.EventHandler(this.btn_ThemKhachHang_Click);
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(963, 19);
            this.txt_CMND.MaxLength = 9;
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(112, 20);
            this.txt_CMND.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Phong);
            this.groupBox2.Controls.Add(this.cbb_LoaiPhong);
            this.groupBox2.Controls.Add(this.btn_ChonPhong);
            this.groupBox2.Location = new System.Drawing.Point(12, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1086, 243);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin phòng";
            // 
            // dgv_Phong
            // 
            this.dgv_Phong.AllowUserToAddRows = false;
            this.dgv_Phong.AllowUserToDeleteRows = false;
            this.dgv_Phong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdRoom,
            this.colRType,
            this.colRPrice,
            this.colRStatus});
            this.dgv_Phong.Location = new System.Drawing.Point(6, 19);
            this.dgv_Phong.Name = "dgv_Phong";
            this.dgv_Phong.RowHeadersVisible = false;
            this.dgv_Phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Phong.Size = new System.Drawing.Size(941, 218);
            this.dgv_Phong.TabIndex = 7;
            // 
            // colIdRoom
            // 
            this.colIdRoom.DataPropertyName = "IdRoom";
            this.colIdRoom.HeaderText = "Mã phòng";
            this.colIdRoom.Name = "colIdRoom";
            this.colIdRoom.ReadOnly = true;
            // 
            // colRType
            // 
            this.colRType.DataPropertyName = "RType";
            this.colRType.HeaderText = "Loại phòng";
            this.colRType.Name = "colRType";
            this.colRType.ReadOnly = true;
            // 
            // colRPrice
            // 
            this.colRPrice.DataPropertyName = "RPrice";
            this.colRPrice.HeaderText = "Giá phòng";
            this.colRPrice.Name = "colRPrice";
            this.colRPrice.ReadOnly = true;
            // 
            // colRStatus
            // 
            this.colRStatus.DataPropertyName = "RStatus";
            this.colRStatus.HeaderText = "Tình trạng";
            this.colRStatus.Name = "colRStatus";
            this.colRStatus.ReadOnly = true;
            // 
            // cbb_LoaiPhong
            // 
            this.cbb_LoaiPhong.FormattingEnabled = true;
            this.cbb_LoaiPhong.Location = new System.Drawing.Point(963, 84);
            this.cbb_LoaiPhong.Name = "cbb_LoaiPhong";
            this.cbb_LoaiPhong.Size = new System.Drawing.Size(112, 21);
            this.cbb_LoaiPhong.TabIndex = 6;
            this.cbb_LoaiPhong.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiPhong_SelectedIndexChanged);
            // 
            // btn_ChonPhong
            // 
            this.btn_ChonPhong.Location = new System.Drawing.Point(963, 146);
            this.btn_ChonPhong.Name = "btn_ChonPhong";
            this.btn_ChonPhong.Size = new System.Drawing.Size(112, 23);
            this.btn_ChonPhong.TabIndex = 5;
            this.btn_ChonPhong.Text = "Chọn phòng";
            this.btn_ChonPhong.UseVisualStyleBackColor = true;
            this.btn_ChonPhong.Click += new System.EventHandler(this.btn_ChonPhong_Click);
            // 
            // txt_NhanVien
            // 
            this.txt_NhanVien.Enabled = false;
            this.txt_NhanVien.Location = new System.Drawing.Point(963, 56);
            this.txt_NhanVien.Name = "txt_NhanVien";
            this.txt_NhanVien.Size = new System.Drawing.Size(112, 20);
            this.txt_NhanVien.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_IdRoomBook);
            this.groupBox3.Controls.Add(this.txt_NgayDi);
            this.groupBox3.Controls.Add(this.dgv_ThuePhong);
            this.groupBox3.Controls.Add(this.btn_ThuePhong);
            this.groupBox3.Controls.Add(this.txt_NhanVien);
            this.groupBox3.Location = new System.Drawing.Point(12, 450);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1086, 175);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin thuê phòng";
            // 
            // txt_IdRoomBook
            // 
            this.txt_IdRoomBook.Location = new System.Drawing.Point(963, 19);
            this.txt_IdRoomBook.Name = "txt_IdRoomBook";
            this.txt_IdRoomBook.Size = new System.Drawing.Size(112, 20);
            this.txt_IdRoomBook.TabIndex = 7;
            // 
            // txt_NgayDi
            // 
            this.txt_NgayDi.Location = new System.Drawing.Point(963, 95);
            this.txt_NgayDi.Name = "txt_NgayDi";
            this.txt_NgayDi.Size = new System.Drawing.Size(112, 20);
            this.txt_NgayDi.TabIndex = 7;
            // 
            // dgv_ThuePhong
            // 
            this.dgv_ThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdRoomBook,
            this.colCMND,
            this.colMaPhong,
            this.colNgayDen,
            this.colNgayDi,
            this.colNhanVien});
            this.dgv_ThuePhong.Location = new System.Drawing.Point(6, 19);
            this.dgv_ThuePhong.Name = "dgv_ThuePhong";
            this.dgv_ThuePhong.RowHeadersVisible = false;
            this.dgv_ThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ThuePhong.Size = new System.Drawing.Size(941, 150);
            this.dgv_ThuePhong.TabIndex = 6;
            // 
            // colIdRoomBook
            // 
            this.colIdRoomBook.DataPropertyName = "IdRoomBook";
            this.colIdRoomBook.HeaderText = "Mã thuê phòng";
            this.colIdRoomBook.Name = "colIdRoomBook";
            this.colIdRoomBook.Width = 130;
            // 
            // colCMND
            // 
            this.colCMND.DataPropertyName = "IdCard";
            this.colCMND.HeaderText = "Số CMND";
            this.colCMND.Name = "colCMND";
            // 
            // colMaPhong
            // 
            this.colMaPhong.DataPropertyName = "IdRoom";
            this.colMaPhong.HeaderText = "Mã phòng";
            this.colMaPhong.Name = "colMaPhong";
            this.colMaPhong.Width = 150;
            // 
            // colNgayDen
            // 
            this.colNgayDen.DataPropertyName = "StartDate";
            this.colNgayDen.HeaderText = "Ngày đến";
            this.colNgayDen.Name = "colNgayDen";
            this.colNgayDen.Width = 200;
            // 
            // colNgayDi
            // 
            this.colNgayDi.DataPropertyName = "EndDate";
            this.colNgayDi.HeaderText = "Ngày đi";
            this.colNgayDi.Name = "colNgayDi";
            this.colNgayDi.Width = 200;
            // 
            // colNhanVien
            // 
            this.colNhanVien.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNhanVien.DataPropertyName = "StaffName";
            this.colNhanVien.HeaderText = "Nhân viên";
            this.colNhanVien.Name = "colNhanVien";
            // 
            // btn_ThuePhong
            // 
            this.btn_ThuePhong.Location = new System.Drawing.Point(963, 146);
            this.btn_ThuePhong.Name = "btn_ThuePhong";
            this.btn_ThuePhong.Size = new System.Drawing.Size(112, 23);
            this.btn_ThuePhong.TabIndex = 5;
            this.btn_ThuePhong.Text = "Thuê phòng";
            this.btn_ThuePhong.UseVisualStyleBackColor = true;
            this.btn_ThuePhong.Click += new System.EventHandler(this.btn_ThuePhong_Click);
            // 
            // Frm_ThuePhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 631);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_ThuePhong";
            this.Text = "Frm_ThuePhong";
            this.Load += new System.EventHandler(this.Frm_ThuePhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThuePhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_ChonKhachHang;
        private System.Windows.Forms.Button btn_ThemKhachHang;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbb_LoaiPhong;
        private System.Windows.Forms.Button btn_ChonPhong;
        private System.Windows.Forms.TextBox txt_NhanVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_ThuePhong;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcusAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcusGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcusPhone;
        private System.Windows.Forms.DataGridView dgv_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRStatus;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.DataGridView dgv_ThuePhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRoomBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayDi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNhanVien;
        private System.Windows.Forms.TextBox txt_NgayDi;
        private System.Windows.Forms.TextBox txt_IdRoomBook;
    }
}