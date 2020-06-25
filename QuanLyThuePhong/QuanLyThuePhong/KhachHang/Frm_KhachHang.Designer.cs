namespace QuanLyThuePhong.KhachHang
{
    partial class Frm_KhachHang
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_KhachHang = new System.Windows.Forms.DataGridView();
            this.colidCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcusName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcusAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcusGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colcusPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cMTLabel = new System.Windows.Forms.Label();
            this.txt_idCard = new System.Windows.Forms.TextBox();
            this.diachiLabel = new System.Windows.Forms.Label();
            this.txt_cusAddress = new System.Windows.Forms.TextBox();
            this.gTLabel = new System.Windows.Forms.Label();
            this.cbb_cusGender = new System.Windows.Forms.ComboBox();
            this.hotenLabel = new System.Windows.Forms.Label();
            this.txt_cusName = new System.Windows.Forms.TextBox();
            this.sDTLabel = new System.Windows.Forms.Label();
            this.txt_cusPhone = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_KhachHang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 223);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
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
            this.dgv_KhachHang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_KhachHang.Location = new System.Drawing.Point(3, 18);
            this.dgv_KhachHang.Name = "dgv_KhachHang";
            this.dgv_KhachHang.RowHeadersVisible = false;
            this.dgv_KhachHang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_KhachHang.Size = new System.Drawing.Size(928, 202);
            this.dgv_KhachHang.TabIndex = 0;
            this.dgv_KhachHang.Click += new System.EventHandler(this.dgv_KhachHang_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cMTLabel);
            this.groupBox1.Controls.Add(this.txt_idCard);
            this.groupBox1.Controls.Add(this.diachiLabel);
            this.groupBox1.Controls.Add(this.txt_cusAddress);
            this.groupBox1.Controls.Add(this.gTLabel);
            this.groupBox1.Controls.Add(this.cbb_cusGender);
            this.groupBox1.Controls.Add(this.hotenLabel);
            this.groupBox1.Controls.Add(this.txt_cusName);
            this.groupBox1.Controls.Add(this.sDTLabel);
            this.groupBox1.Controls.Add(this.txt_cusPhone);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // cMTLabel
            // 
            this.cMTLabel.AutoSize = true;
            this.cMTLabel.Location = new System.Drawing.Point(37, 30);
            this.cMTLabel.Name = "cMTLabel";
            this.cMTLabel.Size = new System.Drawing.Size(75, 16);
            this.cMTLabel.TabIndex = 6;
            this.cMTLabel.Text = "Số CMND";
            // 
            // txt_idCard
            // 
            this.txt_idCard.Location = new System.Drawing.Point(143, 27);
            this.txt_idCard.MaxLength = 12;
            this.txt_idCard.Name = "txt_idCard";
            this.txt_idCard.Size = new System.Drawing.Size(231, 22);
            this.txt_idCard.TabIndex = 0;
            // 
            // diachiLabel
            // 
            this.diachiLabel.AutoSize = true;
            this.diachiLabel.Location = new System.Drawing.Point(37, 106);
            this.diachiLabel.Name = "diachiLabel";
            this.diachiLabel.Size = new System.Drawing.Size(55, 16);
            this.diachiLabel.TabIndex = 8;
            this.diachiLabel.Text = "Địa chỉ";
            // 
            // txt_cusAddress
            // 
            this.txt_cusAddress.Location = new System.Drawing.Point(143, 103);
            this.txt_cusAddress.Name = "txt_cusAddress";
            this.txt_cusAddress.Size = new System.Drawing.Size(231, 22);
            this.txt_cusAddress.TabIndex = 2;
            // 
            // gTLabel
            // 
            this.gTLabel.AutoSize = true;
            this.gTLabel.Location = new System.Drawing.Point(424, 30);
            this.gTLabel.Name = "gTLabel";
            this.gTLabel.Size = new System.Drawing.Size(64, 16);
            this.gTLabel.TabIndex = 10;
            this.gTLabel.Text = "Giới tính";
            // 
            // cbb_cusGender
            // 
            this.cbb_cusGender.FormattingEnabled = true;
            this.cbb_cusGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_cusGender.Location = new System.Drawing.Point(538, 27);
            this.cbb_cusGender.Name = "cbb_cusGender";
            this.cbb_cusGender.Size = new System.Drawing.Size(231, 24);
            this.cbb_cusGender.TabIndex = 3;
            // 
            // hotenLabel
            // 
            this.hotenLabel.AutoSize = true;
            this.hotenLabel.Location = new System.Drawing.Point(37, 68);
            this.hotenLabel.Name = "hotenLabel";
            this.hotenLabel.Size = new System.Drawing.Size(53, 16);
            this.hotenLabel.TabIndex = 12;
            this.hotenLabel.Text = "Họ tên";
            // 
            // txt_cusName
            // 
            this.txt_cusName.Location = new System.Drawing.Point(143, 65);
            this.txt_cusName.Name = "txt_cusName";
            this.txt_cusName.Size = new System.Drawing.Size(231, 22);
            this.txt_cusName.TabIndex = 1;
            // 
            // sDTLabel
            // 
            this.sDTLabel.AutoSize = true;
            this.sDTLabel.Location = new System.Drawing.Point(424, 68);
            this.sDTLabel.Name = "sDTLabel";
            this.sDTLabel.Size = new System.Drawing.Size(99, 16);
            this.sDTLabel.TabIndex = 14;
            this.sDTLabel.Text = "Số điện thoại";
            // 
            // txt_cusPhone
            // 
            this.txt_cusPhone.Location = new System.Drawing.Point(538, 65);
            this.txt_cusPhone.Name = "txt_cusPhone";
            this.txt_cusPhone.Size = new System.Drawing.Size(231, 22);
            this.txt_cusPhone.TabIndex = 4;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(114, 139);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(84, 27);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(279, 139);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(84, 27);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(609, 139);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(84, 27);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(444, 139);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(84, 27);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(957, 70);
            this.panel1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(931, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ KHÁCH HÀNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 489);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_KhachHang";
            this.Text = "THÔNG TIN KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.Frm_KhachHang_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_KhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_KhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn colidCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcusName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcusAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcusGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colcusPhone;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label cMTLabel;
        private System.Windows.Forms.TextBox txt_idCard;
        private System.Windows.Forms.Label diachiLabel;
        private System.Windows.Forms.TextBox txt_cusAddress;
        private System.Windows.Forms.Label gTLabel;
        private System.Windows.Forms.ComboBox cbb_cusGender;
        private System.Windows.Forms.Label hotenLabel;
        private System.Windows.Forms.TextBox txt_cusName;
        private System.Windows.Forms.Label sDTLabel;
        private System.Windows.Forms.TextBox txt_cusPhone;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}