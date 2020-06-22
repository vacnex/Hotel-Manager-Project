namespace QuanLyThuePhong.DichVu
{
    partial class Frm_DichVuModified
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Modified = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_DVM_SerUnit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_DVM_SerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_DVM_IdService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DVM_SerPrice = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Huy
            // 
            this.btn_Huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Huy.Location = new System.Drawing.Point(286, 206);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.Size = new System.Drawing.Size(147, 36);
            this.btn_Huy.TabIndex = 40;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.UseVisualStyleBackColor = true;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(132, 206);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(147, 36);
            this.btn_Luu.TabIndex = 39;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Modified);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 51);
            this.panel1.TabIndex = 38;
            // 
            // lbl_Modified
            // 
            this.lbl_Modified.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Modified.Location = new System.Drawing.Point(12, 9);
            this.lbl_Modified.Name = "lbl_Modified";
            this.lbl_Modified.Size = new System.Drawing.Size(439, 31);
            this.lbl_Modified.TabIndex = 10;
            this.lbl_Modified.Text = "THÊM THÔNG TIN DỊCH VỤ";
            this.lbl_Modified.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 24);
            this.label4.TabIndex = 36;
            this.label4.Text = "Giá dịch vụ";
            // 
            // txt_DVM_SerUnit
            // 
            this.txt_DVM_SerUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DVM_SerUnit.Location = new System.Drawing.Point(132, 132);
            this.txt_DVM_SerUnit.Name = "txt_DVM_SerUnit";
            this.txt_DVM_SerUnit.Size = new System.Drawing.Size(301, 29);
            this.txt_DVM_SerUnit.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 35;
            this.label3.Text = "Đơn vị tính";
            // 
            // txt_DVM_SerName
            // 
            this.txt_DVM_SerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DVM_SerName.Location = new System.Drawing.Point(132, 97);
            this.txt_DVM_SerName.Name = "txt_DVM_SerName";
            this.txt_DVM_SerName.Size = new System.Drawing.Size(301, 29);
            this.txt_DVM_SerName.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 24);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tên dịch vụ";
            // 
            // txt_DVM_IdService
            // 
            this.txt_DVM_IdService.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DVM_IdService.Location = new System.Drawing.Point(132, 62);
            this.txt_DVM_IdService.MaxLength = 9;
            this.txt_DVM_IdService.Name = "txt_DVM_IdService";
            this.txt_DVM_IdService.Size = new System.Drawing.Size(301, 29);
            this.txt_DVM_IdService.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã dịch vụ";
            // 
            // txt_DVM_SerPrice
            // 
            this.txt_DVM_SerPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_DVM_SerPrice.Location = new System.Drawing.Point(132, 167);
            this.txt_DVM_SerPrice.Name = "txt_DVM_SerPrice";
            this.txt_DVM_SerPrice.Size = new System.Drawing.Size(301, 29);
            this.txt_DVM_SerPrice.TabIndex = 41;
            // 
            // Frm_DichVuModified
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 253);
            this.Controls.Add(this.txt_DVM_SerPrice);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_DVM_SerUnit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_DVM_SerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_DVM_IdService);
            this.Controls.Add(this.label1);
            this.Name = "Frm_DichVuModified";
            this.Text = "Frm_DichVuModified";
            this.Load += new System.EventHandler(this.Frm_DichVuModified_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Huy;
        private System.Windows.Forms.Button btn_Luu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Modified;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_DVM_SerUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_DVM_SerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_DVM_IdService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DVM_SerPrice;
    }
}