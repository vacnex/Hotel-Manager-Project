namespace QuanLyThuePhong.Phong
{
    partial class Frm_PhongModified
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
            this.cbb_PM_rType = new System.Windows.Forms.ComboBox();
            this.btn_Huy = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.cbb_PM_rStatus = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Modified = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_PM_rPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PM_idRoom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbb_PM_rType
            // 
            this.cbb_PM_rType.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_PM_rType.FormattingEnabled = true;
            this.cbb_PM_rType.Items.AddRange(new object[] {
            "Hạng thường (đơn)",
            "Hạng thường (đôi)",
            "Hạng Vip (đơn)",
            "Hạng Vip (đôi)",
            "Hạng sang (đơn)",
            "Hạng sang (đôi)"});
            this.cbb_PM_rType.Location = new System.Drawing.Point(143, 92);
            this.cbb_PM_rType.Name = "cbb_PM_rType";
            this.cbb_PM_rType.Size = new System.Drawing.Size(301, 32);
            this.cbb_PM_rType.TabIndex = 39;
            this.cbb_PM_rType.Text = "Chọn loại phòng";
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(297, 203);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(147, 36);
            this.btn_Huy.TabIndex = 38;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(143, 203);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(147, 36);
            this.btn_Luu.TabIndex = 37;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // cbb_PM_rStatus
            // 
            this.cbb_PM_rStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_PM_rStatus.FormattingEnabled = true;
            this.cbb_PM_rStatus.Items.AddRange(new object[] {
            "Có khách",
            "Trống",
            "Đã đặt"});
            this.cbb_PM_rStatus.Location = new System.Drawing.Point(143, 165);
            this.cbb_PM_rStatus.Name = "cbb_PM_rStatus";
            this.cbb_PM_rStatus.Size = new System.Drawing.Size(301, 32);
            this.cbb_PM_rStatus.TabIndex = 33;
            this.cbb_PM_rStatus.Text = "Chọn tình trạng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Modified);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 51);
            this.panel1.TabIndex = 36;
            // 
            // lbl_Modified
            // 
            this.lbl_Modified.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modified.Location = new System.Drawing.Point(12, 9);
            this.lbl_Modified.Name = "lbl_Modified";
            this.lbl_Modified.Size = new System.Drawing.Size(452, 31);
            this.lbl_Modified.TabIndex = 10;
            this.lbl_Modified.Text = "THÊM THÔNG TIN PHÒNG";
            this.lbl_Modified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 35;
            this.label4.Text = "Tình trạng";
            // 
            // txt_PM_rPrice
            // 
            this.txt_PM_rPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PM_rPrice.Location = new System.Drawing.Point(143, 130);
            this.txt_PM_rPrice.Name = "txt_PM_rPrice";
            this.txt_PM_rPrice.Size = new System.Drawing.Size(301, 29);
            this.txt_PM_rPrice.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 24);
            this.label3.TabIndex = 34;
            this.label3.Text = "Giá phòng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Loại phòng";
            // 
            // txt_PM_idRoom
            // 
            this.txt_PM_idRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PM_idRoom.Location = new System.Drawing.Point(143, 57);
            this.txt_PM_idRoom.MaxLength = 9;
            this.txt_PM_idRoom.Name = "txt_PM_idRoom";
            this.txt_PM_idRoom.Size = new System.Drawing.Size(301, 29);
            this.txt_PM_idRoom.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã phòng";
            // 
            // Frm_PhongModified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 248);
            this.Controls.Add(this.cbb_PM_rType);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.cbb_PM_rStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_PM_rPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_PM_idRoom);
            this.Controls.Add(this.label1);
            this.Name = "Frm_PhongModified";
            this.Text = "Frm_PhongModified";
            this.Load += new System.EventHandler(this.Frm_PhongModified_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbb_PM_rType;
        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.ComboBox cbb_PM_rStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Modified;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_PM_rPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PM_idRoom;
        private System.Windows.Forms.Label label1;
    }
}