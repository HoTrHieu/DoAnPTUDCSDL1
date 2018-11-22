namespace PROJECT.view
{
    partial class frmGiaoDienChinhSV
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
            this.btnQuanLyChuyenDe = new System.Windows.Forms.Button();
            this.btnQuanLyNhom = new System.Windows.Forms.Button();
            this.btnThonTinSinhVien = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lable1 = new System.Windows.Forms.Label();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.lable3 = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuanLyChuyenDe
            // 
            this.btnQuanLyChuyenDe.Location = new System.Drawing.Point(31, 29);
            this.btnQuanLyChuyenDe.Name = "btnQuanLyChuyenDe";
            this.btnQuanLyChuyenDe.Size = new System.Drawing.Size(124, 23);
            this.btnQuanLyChuyenDe.TabIndex = 0;
            this.btnQuanLyChuyenDe.Text = "Quản Lý Chuyên Đề";
            this.btnQuanLyChuyenDe.UseVisualStyleBackColor = true;
            // 
            // btnQuanLyNhom
            // 
            this.btnQuanLyNhom.Location = new System.Drawing.Point(31, 71);
            this.btnQuanLyNhom.Name = "btnQuanLyNhom";
            this.btnQuanLyNhom.Size = new System.Drawing.Size(124, 23);
            this.btnQuanLyNhom.TabIndex = 1;
            this.btnQuanLyNhom.Text = "Quản Lý Nhóm";
            this.btnQuanLyNhom.UseVisualStyleBackColor = true;
            // 
            // btnThonTinSinhVien
            // 
            this.btnThonTinSinhVien.Location = new System.Drawing.Point(31, 116);
            this.btnThonTinSinhVien.Name = "btnThonTinSinhVien";
            this.btnThonTinSinhVien.Size = new System.Drawing.Size(124, 23);
            this.btnThonTinSinhVien.TabIndex = 2;
            this.btnThonTinSinhVien.Text = "Thông Tin Chi Tiết Của Sinh Viên";
            this.btnThonTinSinhVien.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.lable3);
            this.groupBox1.Controls.Add(this.lblMaSinhVien);
            this.groupBox1.Controls.Add(this.lable1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(636, 132);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(19, 23);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(40, 13);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "MSSV:";
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(106, 23);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(49, 13);
            this.lblMaSinhVien.TabIndex = 1;
            this.lblMaSinhVien.Text = "1660197";
            // 
            // lable3
            // 
            this.lable3.AutoSize = true;
            this.lable3.Location = new System.Drawing.Point(19, 53);
            this.lable3.Name = "lable3";
            this.lable3.Size = new System.Drawing.Size(46, 13);
            this.lable3.TabIndex = 2;
            this.lable3.Text = "Họ Tên:";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(106, 53);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(77, 13);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Hồ Trung Hiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ngành:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Công Nghệ Thông Tin";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuanLyChuyenDe);
            this.groupBox2.Controls.Add(this.btnQuanLyNhom);
            this.groupBox2.Controls.Add(this.btnThonTinSinhVien);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(636, 225);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quản Lý";
            // 
            // frmGiaoDienChinhSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 441);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGiaoDienChinhSV";
            this.Text = "frmGiaoDienChinhSV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyChuyenDe;
        private System.Windows.Forms.Button btnQuanLyNhom;
        private System.Windows.Forms.Button btnThonTinSinhVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lable3;
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}