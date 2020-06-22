namespace QuanLyThuePhong.DichVu
{
    partial class Frm_DichVu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cMTLabel = new System.Windows.Forms.Label();
            this.txt_IdService = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_SerUnit = new System.Windows.Forms.TextBox();
            this.gTLabel = new System.Windows.Forms.Label();
            this.hotenLabel = new System.Windows.Forms.Label();
            this.txt_SerName = new System.Windows.Forms.TextBox();
            this.sDTLabel = new System.Windows.Forms.Label();
            this.txt_SerPrice = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.dgv_DichVu = new System.Windows.Forms.DataGridView();
            this.colIdService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSerPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(931, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "QUẢN LÝ DỊCH VỤ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(955, 70);
            this.panel1.TabIndex = 10;
            // 
            // cMTLabel
            // 
            this.cMTLabel.AutoSize = true;
            this.cMTLabel.Location = new System.Drawing.Point(37, 30);
            this.cMTLabel.Name = "cMTLabel";
            this.cMTLabel.Size = new System.Drawing.Size(82, 16);
            this.cMTLabel.TabIndex = 6;
            this.cMTLabel.Text = "Mã dịch vụ";
            // 
            // txt_IdService
            // 
            this.txt_IdService.Location = new System.Drawing.Point(143, 27);
            this.txt_IdService.MaxLength = 12;
            this.txt_IdService.Name = "txt_IdService";
            this.txt_IdService.Size = new System.Drawing.Size(231, 22);
            this.txt_IdService.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_SerUnit);
            this.groupBox1.Controls.Add(this.cMTLabel);
            this.groupBox1.Controls.Add(this.txt_IdService);
            this.groupBox1.Controls.Add(this.gTLabel);
            this.groupBox1.Controls.Add(this.hotenLabel);
            this.groupBox1.Controls.Add(this.txt_SerName);
            this.groupBox1.Controls.Add(this.sDTLabel);
            this.groupBox1.Controls.Add(this.txt_SerPrice);
            this.groupBox1.Controls.Add(this.btn_Them);
            this.groupBox1.Controls.Add(this.btn_Sua);
            this.groupBox1.Controls.Add(this.btn_Thoat);
            this.groupBox1.Controls.Add(this.btn_Xoa);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(934, 144);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // txt_SerUnit
            // 
            this.txt_SerUnit.Location = new System.Drawing.Point(538, 27);
            this.txt_SerUnit.Name = "txt_SerUnit";
            this.txt_SerUnit.Size = new System.Drawing.Size(231, 22);
            this.txt_SerUnit.TabIndex = 15;
            // 
            // gTLabel
            // 
            this.gTLabel.AutoSize = true;
            this.gTLabel.Location = new System.Drawing.Point(424, 30);
            this.gTLabel.Name = "gTLabel";
            this.gTLabel.Size = new System.Drawing.Size(79, 16);
            this.gTLabel.TabIndex = 10;
            this.gTLabel.Text = "Đơn vị tính";
            // 
            // hotenLabel
            // 
            this.hotenLabel.AutoSize = true;
            this.hotenLabel.Location = new System.Drawing.Point(37, 68);
            this.hotenLabel.Name = "hotenLabel";
            this.hotenLabel.Size = new System.Drawing.Size(88, 16);
            this.hotenLabel.TabIndex = 12;
            this.hotenLabel.Text = "Tên dịch vụ";
            // 
            // txt_SerName
            // 
            this.txt_SerName.Location = new System.Drawing.Point(143, 65);
            this.txt_SerName.Name = "txt_SerName";
            this.txt_SerName.Size = new System.Drawing.Size(231, 22);
            this.txt_SerName.TabIndex = 1;
            // 
            // sDTLabel
            // 
            this.sDTLabel.AutoSize = true;
            this.sDTLabel.Location = new System.Drawing.Point(424, 68);
            this.sDTLabel.Name = "sDTLabel";
            this.sDTLabel.Size = new System.Drawing.Size(85, 16);
            this.sDTLabel.TabIndex = 14;
            this.sDTLabel.Text = "Giá dịch vụ";
            // 
            // txt_SerPrice
            // 
            this.txt_SerPrice.Location = new System.Drawing.Point(538, 65);
            this.txt_SerPrice.Name = "txt_SerPrice";
            this.txt_SerPrice.Size = new System.Drawing.Size(231, 22);
            this.txt_SerPrice.TabIndex = 4;
            // 
            // btn_Them
            // 
            this.btn_Them.Location = new System.Drawing.Point(117, 104);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(84, 27);
            this.btn_Them.TabIndex = 5;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = true;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Location = new System.Drawing.Point(282, 104);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(84, 27);
            this.btn_Sua.TabIndex = 6;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = true;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(612, 104);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(84, 27);
            this.btn_Thoat.TabIndex = 7;
            this.btn_Thoat.Text = "Thoát";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Location = new System.Drawing.Point(447, 104);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(84, 27);
            this.btn_Xoa.TabIndex = 7;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = true;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // dgv_DichVu
            // 
            this.dgv_DichVu.AllowUserToAddRows = false;
            this.dgv_DichVu.AllowUserToDeleteRows = false;
            this.dgv_DichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIdService,
            this.colSerName,
            this.colSerUnit,
            this.colSerPrice});
            this.dgv_DichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_DichVu.Location = new System.Drawing.Point(3, 18);
            this.dgv_DichVu.Name = "dgv_DichVu";
            this.dgv_DichVu.RowHeadersVisible = false;
            this.dgv_DichVu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_DichVu.Size = new System.Drawing.Size(928, 202);
            this.dgv_DichVu.TabIndex = 0;
            this.dgv_DichVu.Click += new System.EventHandler(this.dgv_DichVu_Click);
            // 
            // colIdService
            // 
            this.colIdService.DataPropertyName = "IdService";
            this.colIdService.HeaderText = "Mã dịch vụ";
            this.colIdService.Name = "colIdService";
            this.colIdService.ReadOnly = true;
            // 
            // colSerName
            // 
            this.colSerName.DataPropertyName = "SerName";
            this.colSerName.HeaderText = "Tên dịch vụ";
            this.colSerName.Name = "colSerName";
            this.colSerName.ReadOnly = true;
            // 
            // colSerUnit
            // 
            this.colSerUnit.DataPropertyName = "SerUnit";
            this.colSerUnit.HeaderText = "Đơn vị tính";
            this.colSerUnit.Name = "colSerUnit";
            this.colSerUnit.ReadOnly = true;
            // 
            // colSerPrice
            // 
            this.colSerPrice.DataPropertyName = "SerPrice";
            this.colSerPrice.HeaderText = "Giá dịch vụ";
            this.colSerPrice.Name = "colSerPrice";
            this.colSerPrice.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_DichVu);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(934, 223);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách dịch vụ";
            // 
            // Frm_DichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Frm_DichVu";
            this.Text = "Frm_DichVu";
            this.Load += new System.EventHandler(this.Frm_DichVu_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DichVu)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label cMTLabel;
        private System.Windows.Forms.TextBox txt_IdService;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label gTLabel;
        private System.Windows.Forms.Label hotenLabel;
        private System.Windows.Forms.TextBox txt_SerName;
        private System.Windows.Forms.Label sDTLabel;
        private System.Windows.Forms.TextBox txt_SerPrice;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Button btn_Thoat;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.DataGridView dgv_DichVu;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_SerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIdService;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSerPrice;
    }
}