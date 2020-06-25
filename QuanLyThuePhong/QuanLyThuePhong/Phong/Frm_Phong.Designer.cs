namespace QuanLyThuePhong.Phong
{
    partial class Frm_Phong
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
            this.dgv_Phong = new System.Windows.Forms.DataGridView();
            this.colIdRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbb_QLP_rType = new System.Windows.Forms.ComboBox();
            this.cMTLabel = new System.Windows.Forms.Label();
            this.txt_QLP_idRoom = new System.Windows.Forms.TextBox();
            this.gTLabel = new System.Windows.Forms.Label();
            this.cbb_QLP_rStatus = new System.Windows.Forms.ComboBox();
            this.hotenLabel = new System.Windows.Forms.Label();
            this.sDTLabel = new System.Windows.Forms.Label();
            this.txt_QLP_rPrice = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_Phong);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 238);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(804, 223);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách phòng";
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
            this.dgv_Phong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_Phong.Location = new System.Drawing.Point(3, 18);
            this.dgv_Phong.Name = "dgv_Phong";
            this.dgv_Phong.RowHeadersVisible = false;
            this.dgv_Phong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Phong.Size = new System.Drawing.Size(798, 202);
            this.dgv_Phong.TabIndex = 0;
            this.dgv_Phong.Click += new System.EventHandler(this.dgv_Phong_Click);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbb_QLP_rType);
            this.groupBox1.Controls.Add(this.cMTLabel);
            this.groupBox1.Controls.Add(this.txt_QLP_idRoom);
            this.groupBox1.Controls.Add(this.gTLabel);
            this.groupBox1.Controls.Add(this.cbb_QLP_rStatus);
            this.groupBox1.Controls.Add(this.hotenLabel);
            this.groupBox1.Controls.Add(this.sDTLabel);
            this.groupBox1.Controls.Add(this.txt_QLP_rPrice);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 156);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phòng";
            // 
            // cbb_QLP_rType
            // 
            this.cbb_QLP_rType.FormattingEnabled = true;
            this.cbb_QLP_rType.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_QLP_rType.Location = new System.Drawing.Point(143, 60);
            this.cbb_QLP_rType.Name = "cbb_QLP_rType";
            this.cbb_QLP_rType.Size = new System.Drawing.Size(231, 24);
            this.cbb_QLP_rType.TabIndex = 15;
            // 
            // cMTLabel
            // 
            this.cMTLabel.AutoSize = true;
            this.cMTLabel.Location = new System.Drawing.Point(37, 30);
            this.cMTLabel.Name = "cMTLabel";
            this.cMTLabel.Size = new System.Drawing.Size(76, 16);
            this.cMTLabel.TabIndex = 6;
            this.cMTLabel.Text = "Mã phòng";
            // 
            // txt_QLP_idRoom
            // 
            this.txt_QLP_idRoom.Location = new System.Drawing.Point(143, 27);
            this.txt_QLP_idRoom.MaxLength = 12;
            this.txt_QLP_idRoom.Name = "txt_QLP_idRoom";
            this.txt_QLP_idRoom.Size = new System.Drawing.Size(231, 22);
            this.txt_QLP_idRoom.TabIndex = 0;
            // 
            // gTLabel
            // 
            this.gTLabel.AutoSize = true;
            this.gTLabel.Location = new System.Drawing.Point(424, 30);
            this.gTLabel.Name = "gTLabel";
            this.gTLabel.Size = new System.Drawing.Size(79, 16);
            this.gTLabel.TabIndex = 10;
            this.gTLabel.Text = "Giá phòng";
            // 
            // cbb_QLP_rStatus
            // 
            this.cbb_QLP_rStatus.FormattingEnabled = true;
            this.cbb_QLP_rStatus.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_QLP_rStatus.Location = new System.Drawing.Point(538, 65);
            this.cbb_QLP_rStatus.Name = "cbb_QLP_rStatus";
            this.cbb_QLP_rStatus.Size = new System.Drawing.Size(231, 24);
            this.cbb_QLP_rStatus.TabIndex = 3;
            // 
            // hotenLabel
            // 
            this.hotenLabel.AutoSize = true;
            this.hotenLabel.Location = new System.Drawing.Point(37, 68);
            this.hotenLabel.Name = "hotenLabel";
            this.hotenLabel.Size = new System.Drawing.Size(85, 16);
            this.hotenLabel.TabIndex = 12;
            this.hotenLabel.Text = "Loại phòng";
            // 
            // sDTLabel
            // 
            this.sDTLabel.AutoSize = true;
            this.sDTLabel.Location = new System.Drawing.Point(424, 68);
            this.sDTLabel.Name = "sDTLabel";
            this.sDTLabel.Size = new System.Drawing.Size(77, 16);
            this.sDTLabel.TabIndex = 14;
            this.sDTLabel.Text = "Tình trạng";
            // 
            // txt_QLP_rPrice
            // 
            this.txt_QLP_rPrice.Location = new System.Drawing.Point(538, 27);
            this.txt_QLP_rPrice.Name = "txt_QLP_rPrice";
            this.txt_QLP_rPrice.Size = new System.Drawing.Size(231, 22);
            this.txt_QLP_rPrice.TabIndex = 4;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(125, 110);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(84, 27);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(290, 110);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(84, 27);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(620, 110);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(84, 27);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(455, 110);
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
            this.panel1.Size = new System.Drawing.Size(831, 70);
            this.panel1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(804, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ PHÒNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Frm_Phong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 468);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_Phong";
            this.Text = "Frm_Phong";
            this.Load += new System.EventHandler(this.Frm_Phong_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Phong)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_Phong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbb_QLP_rType;
        private System.Windows.Forms.Label cMTLabel;
        private System.Windows.Forms.TextBox txt_QLP_idRoom;
        private System.Windows.Forms.Label gTLabel;
        private System.Windows.Forms.ComboBox cbb_QLP_rStatus;
        private System.Windows.Forms.Label hotenLabel;
        private System.Windows.Forms.Label sDTLabel;
        private System.Windows.Forms.TextBox txt_QLP_rPrice;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}