namespace QuanLyThuePhong.ThuePhong
{
    partial class Frm_TraPhong
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
            this.btn_LamMoi = new System.Windows.Forms.Button();
            this.dgv_Phong = new System.Windows.Forms.DataGridView();
            this.colIdRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TimKiem = new System.Windows.Forms.Button();
            this.txt_MaPhong = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DiaChi = new System.Windows.Forms.TextBox();
            this.txt_GioiTinh = new System.Windows.Forms.TextBox();
            this.txt_HoTen = new System.Windows.Forms.TextBox();
            this.txt_SDT = new System.Windows.Forms.TextBox();
            this.txt_CMND = new System.Windows.Forms.TextBox();
            this.dgv_ThuePhong = new System.Windows.Forms.DataGridView();
            this.colIdRoomBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIdRoom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStaffName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_TraPhong = new System.Windows.Forms.Button();
            this.btn_ThanhToan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThuePhong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_LamMoi);
            this.groupBox1.Controls.Add(this.dgv_Phong);
            this.groupBox1.Controls.Add(this.btn_TimKiem);
            this.groupBox1.Controls.Add(this.txt_MaPhong);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 167);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu phòng cần trả";
            // 
            // btn_LamMoi
            // 
            this.btn_LamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LamMoi.Location = new System.Drawing.Point(147, 88);
            this.btn_LamMoi.Name = "btn_LamMoi";
            this.btn_LamMoi.Size = new System.Drawing.Size(129, 31);
            this.btn_LamMoi.TabIndex = 4;
            this.btn_LamMoi.Text = "Làm mới";
            this.btn_LamMoi.UseVisualStyleBackColor = true;
            this.btn_LamMoi.Click += new System.EventHandler(this.btn_LamMoi_Click);
            // 
            // dgv_Phong
            // 
            this.dgv_Phong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Phong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdRoom,
            this.colRType,
            this.colRPrice,
            this.colRStatus});
            this.dgv_Phong.Location = new System.Drawing.Point(282, 19);
            this.dgv_Phong.Name = "dgv_Phong";
            this.dgv_Phong.ReadOnly = true;
            this.dgv_Phong.RowHeadersVisible = false;
            this.dgv_Phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Phong.Size = new System.Drawing.Size(488, 140);
            this.dgv_Phong.TabIndex = 3;
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
            this.colRType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.colRPrice.Width = 150;
            // 
            // colRStatus
            // 
            this.colRStatus.DataPropertyName = "RStatus";
            this.colRStatus.HeaderText = "Trạng thái";
            this.colRStatus.Name = "colRStatus";
            this.colRStatus.ReadOnly = true;
            this.colRStatus.Width = 150;
            // 
            // btn_TimKiem
            // 
            this.btn_TimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TimKiem.Location = new System.Drawing.Point(147, 51);
            this.btn_TimKiem.Name = "btn_TimKiem";
            this.btn_TimKiem.Size = new System.Drawing.Size(129, 31);
            this.btn_TimKiem.TabIndex = 2;
            this.btn_TimKiem.Text = "Tìm kiếm";
            this.btn_TimKiem.UseVisualStyleBackColor = true;
            this.btn_TimKiem.Click += new System.EventHandler(this.btn_TimKiem_Click);
            // 
            // txt_MaPhong
            // 
            this.txt_MaPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MaPhong.Location = new System.Drawing.Point(147, 19);
            this.txt_MaPhong.Name = "txt_MaPhong";
            this.txt_MaPhong.Size = new System.Drawing.Size(129, 26);
            this.txt_MaPhong.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập mã phòng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txt_DiaChi);
            this.groupBox2.Controls.Add(this.txt_GioiTinh);
            this.groupBox2.Controls.Add(this.txt_HoTen);
            this.groupBox2.Controls.Add(this.txt_SDT);
            this.groupBox2.Controls.Add(this.txt_CMND);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 123);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin khách hàng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Địa chỉ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(410, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(371, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số CMND";
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DiaChi.Location = new System.Drawing.Point(119, 86);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.ReadOnly = true;
            this.txt_DiaChi.Size = new System.Drawing.Size(246, 26);
            this.txt_DiaChi.TabIndex = 0;
            // 
            // txt_GioiTinh
            // 
            this.txt_GioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_GioiTinh.Location = new System.Drawing.Point(492, 54);
            this.txt_GioiTinh.Name = "txt_GioiTinh";
            this.txt_GioiTinh.ReadOnly = true;
            this.txt_GioiTinh.Size = new System.Drawing.Size(246, 26);
            this.txt_GioiTinh.TabIndex = 0;
            // 
            // txt_HoTen
            // 
            this.txt_HoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_HoTen.Location = new System.Drawing.Point(119, 54);
            this.txt_HoTen.Name = "txt_HoTen";
            this.txt_HoTen.ReadOnly = true;
            this.txt_HoTen.Size = new System.Drawing.Size(246, 26);
            this.txt_HoTen.TabIndex = 0;
            // 
            // txt_SDT
            // 
            this.txt_SDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_SDT.Location = new System.Drawing.Point(492, 22);
            this.txt_SDT.Name = "txt_SDT";
            this.txt_SDT.ReadOnly = true;
            this.txt_SDT.Size = new System.Drawing.Size(246, 26);
            this.txt_SDT.TabIndex = 0;
            // 
            // txt_CMND
            // 
            this.txt_CMND.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_CMND.Location = new System.Drawing.Point(119, 22);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.ReadOnly = true;
            this.txt_CMND.Size = new System.Drawing.Size(246, 26);
            this.txt_CMND.TabIndex = 0;
            // 
            // dgv_ThuePhong
            // 
            this.dgv_ThuePhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThuePhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdRoomBook,
            this.colIdCard,
            this.colIdRoom1,
            this.colStartDate,
            this.colEndDate,
            this.colStaffName});
            this.dgv_ThuePhong.Location = new System.Drawing.Point(12, 314);
            this.dgv_ThuePhong.Name = "dgv_ThuePhong";
            this.dgv_ThuePhong.RowHeadersVisible = false;
            this.dgv_ThuePhong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ThuePhong.Size = new System.Drawing.Size(641, 150);
            this.dgv_ThuePhong.TabIndex = 5;
            this.dgv_ThuePhong.Click += new System.EventHandler(this.dgv_ThuePhong_Click);
            // 
            // colIdRoomBook
            // 
            this.colIdRoomBook.DataPropertyName = "IdRoomBook";
            this.colIdRoomBook.HeaderText = "Mã thuê phòng";
            this.colIdRoomBook.Name = "colIdRoomBook";
            this.colIdRoomBook.Width = 110;
            // 
            // colIdCard
            // 
            this.colIdCard.DataPropertyName = "IdCard";
            this.colIdCard.HeaderText = "Số CMND";
            this.colIdCard.Name = "colIdCard";
            // 
            // colIdRoom1
            // 
            this.colIdRoom1.DataPropertyName = "IdRoom";
            this.colIdRoom1.HeaderText = "Mã phòng";
            this.colIdRoom1.Name = "colIdRoom1";
            // 
            // colStartDate
            // 
            this.colStartDate.DataPropertyName = "StartDate";
            this.colStartDate.HeaderText = "Ngày đến";
            this.colStartDate.Name = "colStartDate";
            // 
            // colEndDate
            // 
            this.colEndDate.DataPropertyName = "EndDate";
            this.colEndDate.HeaderText = "Ngày đi";
            this.colEndDate.Name = "colEndDate";
            // 
            // colStaffName
            // 
            this.colStaffName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colStaffName.DataPropertyName = "StaffName";
            this.colStaffName.HeaderText = "Tên nhân viên";
            this.colStaffName.Name = "colStaffName";
            // 
            // btn_TraPhong
            // 
            this.btn_TraPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_TraPhong.Location = new System.Drawing.Point(659, 365);
            this.btn_TraPhong.Name = "btn_TraPhong";
            this.btn_TraPhong.Size = new System.Drawing.Size(129, 31);
            this.btn_TraPhong.TabIndex = 4;
            this.btn_TraPhong.Text = "Trả phòng";
            this.btn_TraPhong.UseVisualStyleBackColor = true;
            this.btn_TraPhong.Click += new System.EventHandler(this.btn_TraPhong_Click);
            // 
            // btn_ThanhToan
            // 
            this.btn_ThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ThanhToan.Location = new System.Drawing.Point(659, 420);
            this.btn_ThanhToan.Name = "btn_ThanhToan";
            this.btn_ThanhToan.Size = new System.Drawing.Size(129, 31);
            this.btn_ThanhToan.TabIndex = 5;
            this.btn_ThanhToan.Text = "Thanh toán";
            this.btn_ThanhToan.UseVisualStyleBackColor = true;
            this.btn_ThanhToan.Click += new System.EventHandler(this.btn_ThanhToan_Click);
            // 
            // Frm_TraPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 474);
            this.Controls.Add(this.btn_TraPhong);
            this.Controls.Add(this.btn_ThanhToan);
            this.Controls.Add(this.dgv_ThuePhong);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Frm_TraPhong";
            this.Text = "Frm_TraPhong";
            this.Load += new System.EventHandler(this.Frm_TraPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThuePhong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgv_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRStatus;
        private System.Windows.Forms.Button btn_TimKiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaPhong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DiaChi;
        private System.Windows.Forms.TextBox txt_GioiTinh;
        private System.Windows.Forms.TextBox txt_HoTen;
        private System.Windows.Forms.TextBox txt_SDT;
        private System.Windows.Forms.TextBox txt_CMND;
        private System.Windows.Forms.DataGridView dgv_ThuePhong;
        private System.Windows.Forms.Button btn_TraPhong;
        private System.Windows.Forms.Button btn_ThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRoomBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRoom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStaffName;
        private System.Windows.Forms.Button btn_LamMoi;
    }
}