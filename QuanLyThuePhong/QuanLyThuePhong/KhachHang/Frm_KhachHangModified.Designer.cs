namespace QuanLyThuePhong.KhachHang
{
    partial class Frm_KhachHangModified
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
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cbb_KHM_cusGender = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Modified = new System.Windows.Forms.Label();
            this.txt_KHM_cusPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_KHM_cusAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_KHM_cusName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_KHM_idCard = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(314, 235);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(147, 36);
            this.btn_Huy.TabIndex = 27;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(160, 235);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(147, 36);
            this.btn_Luu.TabIndex = 26;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cbb_KHM_cusGender
            // 
            this.cbb_KHM_cusGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_KHM_cusGender.FormattingEnabled = true;
            this.cbb_KHM_cusGender.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbb_KHM_cusGender.Location = new System.Drawing.Point(160, 162);
            this.cbb_KHM_cusGender.Name = "cbb_KHM_cusGender";
            this.cbb_KHM_cusGender.Size = new System.Drawing.Size(301, 32);
            this.cbb_KHM_cusGender.TabIndex = 20;
            this.cbb_KHM_cusGender.Text = "Chọn giới tính";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Modified);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 51);
            this.panel1.TabIndex = 25;
            // 
            // lbl_Modified
            // 
            this.lbl_Modified.AutoSize = true;
            this.lbl_Modified.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modified.Location = new System.Drawing.Point(12, 9);
            this.lbl_Modified.Name = "lbl_Modified";
            this.lbl_Modified.Size = new System.Drawing.Size(463, 31);
            this.lbl_Modified.TabIndex = 10;
            this.lbl_Modified.Text = "THÊM THÔNG TIN KHÁCH HÀNG";
            // 
            // txt_KHM_cusPhone
            // 
            this.txt_KHM_cusPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KHM_cusPhone.Location = new System.Drawing.Point(160, 200);
            this.txt_KHM_cusPhone.MaxLength = 10;
            this.txt_KHM_cusPhone.Name = "txt_KHM_cusPhone";
            this.txt_KHM_cusPhone.Size = new System.Drawing.Size(301, 29);
            this.txt_KHM_cusPhone.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 24);
            this.label4.TabIndex = 23;
            this.label4.Text = "Giới tính";
            // 
            // txt_KHM_cusAddress
            // 
            this.txt_KHM_cusAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KHM_cusAddress.Location = new System.Drawing.Point(160, 127);
            this.txt_KHM_cusAddress.Name = "txt_KHM_cusAddress";
            this.txt_KHM_cusAddress.Size = new System.Drawing.Size(301, 29);
            this.txt_KHM_cusAddress.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(80, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 22;
            this.label3.Text = "Địa chỉ";
            // 
            // txt_KHM_cusName
            // 
            this.txt_KHM_cusName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KHM_cusName.Location = new System.Drawing.Point(160, 92);
            this.txt_KHM_cusName.Name = "txt_KHM_cusName";
            this.txt_KHM_cusName.Size = new System.Drawing.Size(301, 29);
            this.txt_KHM_cusName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(82, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Họ tên";
            // 
            // txt_KHM_idCard
            // 
            this.txt_KHM_idCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_KHM_idCard.Location = new System.Drawing.Point(160, 57);
            this.txt_KHM_idCard.MaxLength = 9;
            this.txt_KHM_idCard.Name = "txt_KHM_idCard";
            this.txt_KHM_idCard.Size = new System.Drawing.Size(301, 29);
            this.txt_KHM_idCard.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 16;
            this.label1.Text = "CMND";
            // 
            // Frm_KhachHangModified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 280);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.cbb_KHM_cusGender);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_KHM_cusPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_KHM_cusAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_KHM_cusName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_KHM_idCard);
            this.Controls.Add(this.label1);
            this.Name = "Frm_KhachHangModified";
            this.Text = "THAY ĐỔI THÔNG TIN KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.Frm_KhachHangModified_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.ComboBox cbb_KHM_cusGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Modified;
        private System.Windows.Forms.TextBox txt_KHM_cusPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_KHM_cusAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_KHM_cusName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_KHM_idCard;
        private System.Windows.Forms.Label label1;
    }
}