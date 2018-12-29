namespace PROJECT.GUI
{
    partial class frmKetQuaDangKyNhom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblMaSinhVien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMaChuyenDe = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTenChuyenDe = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTenNhom = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblMaNhom = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMaLop = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMaDKChuyenDe = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDSThanhVien = new System.Windows.Forms.DataGridView();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnChuyenNhom = new System.Windows.Forms.Button();
            this.btnRutKhoiNhom = new System.Windows.Forms.Button();
            this.btnHuyDangKy = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhVien)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "KẾT QUẢ ĐĂNG KÝ NHÓM";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblHoTen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblMaSinhVien);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 182);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(79, 66);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(77, 13);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Hồ Trung Hiếu";
            this.lblHoTen.Click += new System.EventHandler(this.lblHoTen_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ Tên:";
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Location = new System.Drawing.Point(78, 32);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(49, 13);
            this.lblMaSinhVien.TabIndex = 1;
            this.lblMaSinhVien.Text = "1660197";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "MSSV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMaChuyenDe);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.lblTenChuyenDe);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblTenNhom);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblMaNhom);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblMaLop);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbMaDKChuyenDe);
            this.groupBox2.Location = new System.Drawing.Point(235, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 182);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lọc Thông Tin";
            // 
            // lblMaChuyenDe
            // 
            this.lblMaChuyenDe.AutoSize = true;
            this.lblMaChuyenDe.Location = new System.Drawing.Point(153, 76);
            this.lblMaChuyenDe.Name = "lblMaChuyenDe";
            this.lblMaChuyenDe.Size = new System.Drawing.Size(47, 13);
            this.lblMaChuyenDe.TabIndex = 13;
            this.lblMaChuyenDe.Text = "CĐ000X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mã chuyên đề:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // lblTenChuyenDe
            // 
            this.lblTenChuyenDe.AutoSize = true;
            this.lblTenChuyenDe.Location = new System.Drawing.Point(153, 101);
            this.lblTenChuyenDe.Name = "lblTenChuyenDe";
            this.lblTenChuyenDe.Size = new System.Drawing.Size(74, 13);
            this.lblTenChuyenDe.TabIndex = 12;
            this.lblTenChuyenDe.Text = "PTUDCSDL 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên chuyên đề:";
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.Location = new System.Drawing.Point(153, 152);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(50, 13);
            this.lblTenNhom.TabIndex = 10;
            this.lblTenNhom.Text = "Nhóm 07";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Tên Nhóm:";
            // 
            // lblMaNhom
            // 
            this.lblMaNhom.AutoSize = true;
            this.lblMaNhom.Location = new System.Drawing.Point(153, 124);
            this.lblMaNhom.Name = "lblMaNhom";
            this.lblMaNhom.Size = new System.Drawing.Size(35, 13);
            this.lblMaNhom.TabIndex = 8;
            this.lblMaNhom.Text = "NH01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã Nhóm:";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Location = new System.Drawing.Point(153, 54);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(37, 13);
            this.lblMaLop.TabIndex = 6;
            this.lblMaLop.Text = "16ck1";
            this.lblMaLop.Click += new System.EventHandler(this.lblLop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã Đăng Ký Chuyên Đề:";
            // 
            // cbMaDKChuyenDe
            // 
            this.cbMaDKChuyenDe.FormattingEnabled = true;
            this.cbMaDKChuyenDe.Location = new System.Drawing.Point(153, 24);
            this.cbMaDKChuyenDe.Name = "cbMaDKChuyenDe";
            this.cbMaDKChuyenDe.Size = new System.Drawing.Size(121, 21);
            this.cbMaDKChuyenDe.TabIndex = 3;
            this.cbMaDKChuyenDe.SelectedValueChanged += new System.EventHandler(this.cbMaDKChuyenDe_SelectedValueChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDSThanhVien);
            this.groupBox3.Location = new System.Drawing.Point(11, 357);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(509, 182);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Thành Viên";
            // 
            // dgvDSThanhVien
            // 
            this.dgvDSThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThanhVien.Location = new System.Drawing.Point(6, 26);
            this.dgvDSThanhVien.Name = "dgvDSThanhVien";
            this.dgvDSThanhVien.Size = new System.Drawing.Size(485, 150);
            this.dgvDSThanhVien.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(427, 545);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnChuyenNhom
            // 
            this.btnChuyenNhom.Location = new System.Drawing.Point(19, 34);
            this.btnChuyenNhom.Name = "btnChuyenNhom";
            this.btnChuyenNhom.Size = new System.Drawing.Size(108, 23);
            this.btnChuyenNhom.TabIndex = 6;
            this.btnChuyenNhom.Text = "Chuyển Nhóm";
            this.btnChuyenNhom.UseVisualStyleBackColor = true;
            this.btnChuyenNhom.Click += new System.EventHandler(this.btnChuyenNhom_Click_1);
            // 
            // btnRutKhoiNhom
            // 
            this.btnRutKhoiNhom.Location = new System.Drawing.Point(186, 34);
            this.btnRutKhoiNhom.Name = "btnRutKhoiNhom";
            this.btnRutKhoiNhom.Size = new System.Drawing.Size(108, 23);
            this.btnRutKhoiNhom.TabIndex = 7;
            this.btnRutKhoiNhom.Text = "Rút Khỏi Nhóm";
            this.btnRutKhoiNhom.UseVisualStyleBackColor = true;
            this.btnRutKhoiNhom.Click += new System.EventHandler(this.btnRutKhoiNhom_Click_1);
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.Location = new System.Drawing.Point(351, 34);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(92, 23);
            this.btnHuyDangKy.TabIndex = 8;
            this.btnHuyDangKy.Text = "Hủy Đăng Ký";
            this.btnHuyDangKy.UseVisualStyleBackColor = true;
            this.btnHuyDangKy.Click += new System.EventHandler(this.btnHuyDangKy_Click_1);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnChuyenNhom);
            this.groupBox4.Controls.Add(this.btnHuyDangKy);
            this.groupBox4.Controls.Add(this.btnRutKhoiNhom);
            this.groupBox4.Location = new System.Drawing.Point(12, 249);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(508, 93);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chỉnh Sửa Nhóm";
            // 
            // frmKetQuaDangKyNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 580);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmKetQuaDangKyNhom";
            this.Text = "frmKetQuaDangKyNhom";
            this.Load += new System.EventHandler(this.frmKetQuaDangKyNhom_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThanhVien)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMaSinhVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTenNhom;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblMaNhom;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaLop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbMaDKChuyenDe;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDSThanhVien;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnChuyenNhom;
        private System.Windows.Forms.Button btnRutKhoiNhom;
        private System.Windows.Forms.Button btnHuyDangKy;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblTenChuyenDe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMaChuyenDe;
        private System.Windows.Forms.Label label9;
    }
}