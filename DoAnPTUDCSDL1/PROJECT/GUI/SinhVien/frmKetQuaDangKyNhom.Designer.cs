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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetQuaDangKyNhom));
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
            this.btnThoat = new System.Windows.Forms.Button();
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
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(108, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 29);
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
            this.lblHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(79, 54);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(90, 13);
            this.lblHoTen.TabIndex = 3;
            this.lblHoTen.Text = "Hồ Trung Hiếu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Họ Tên:";
            // 
            // lblMaSinhVien
            // 
            this.lblMaSinhVien.AutoSize = true;
            this.lblMaSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSinhVien.Location = new System.Drawing.Point(78, 32);
            this.lblMaSinhVien.Name = "lblMaSinhVien";
            this.lblMaSinhVien.Size = new System.Drawing.Size(56, 13);
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
            this.lblMaChuyenDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaChuyenDe.Location = new System.Drawing.Point(153, 78);
            this.lblMaChuyenDe.Name = "lblMaChuyenDe";
            this.lblMaChuyenDe.Size = new System.Drawing.Size(53, 13);
            this.lblMaChuyenDe.TabIndex = 13;
            this.lblMaChuyenDe.Text = "CĐ000X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 77);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Mã chuyên đề:";
            // 
            // lblTenChuyenDe
            // 
            this.lblTenChuyenDe.AutoSize = true;
            this.lblTenChuyenDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenChuyenDe.Location = new System.Drawing.Point(153, 102);
            this.lblTenChuyenDe.Name = "lblTenChuyenDe";
            this.lblTenChuyenDe.Size = new System.Drawing.Size(84, 13);
            this.lblTenChuyenDe.TabIndex = 12;
            this.lblTenChuyenDe.Text = "PTUDCSDL 1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tên chuyên đề:";
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenNhom.Location = new System.Drawing.Point(153, 150);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(57, 13);
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
            this.lblMaNhom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaNhom.Location = new System.Drawing.Point(153, 126);
            this.lblMaNhom.Name = "lblMaNhom";
            this.lblMaNhom.Size = new System.Drawing.Size(39, 13);
            this.lblMaNhom.TabIndex = 8;
            this.lblMaNhom.Text = "NH01";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mã Nhóm:";
            // 
            // lblMaLop
            // 
            this.lblMaLop.AutoSize = true;
            this.lblMaLop.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaLop.Location = new System.Drawing.Point(153, 54);
            this.lblMaLop.Name = "lblMaLop";
            this.lblMaLop.Size = new System.Drawing.Size(42, 13);
            this.lblMaLop.TabIndex = 6;
            this.lblMaLop.Text = "16ck1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 52);
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
            this.dgvDSThanhVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSThanhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThanhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSThanhVien.Location = new System.Drawing.Point(3, 16);
            this.dgvDSThanhVien.Name = "dgvDSThanhVien";
            this.dgvDSThanhVien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSThanhVien.Size = new System.Drawing.Size(503, 163);
            this.dgvDSThanhVien.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Honeydew;
            this.btnThoat.Location = new System.Drawing.Point(393, 545);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 38);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnChuyenNhom
            // 
            this.btnChuyenNhom.BackColor = System.Drawing.Color.SeaGreen;
            this.btnChuyenNhom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnChuyenNhom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChuyenNhom.ForeColor = System.Drawing.Color.White;
            this.btnChuyenNhom.Location = new System.Drawing.Point(31, 32);
            this.btnChuyenNhom.Name = "btnChuyenNhom";
            this.btnChuyenNhom.Size = new System.Drawing.Size(127, 37);
            this.btnChuyenNhom.TabIndex = 6;
            this.btnChuyenNhom.Text = "Chuyển Nhóm";
            this.btnChuyenNhom.UseVisualStyleBackColor = false;
            this.btnChuyenNhom.Click += new System.EventHandler(this.btnChuyenNhom_Click_1);
            // 
            // btnRutKhoiNhom
            // 
            this.btnRutKhoiNhom.BackColor = System.Drawing.Color.SeaGreen;
            this.btnRutKhoiNhom.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRutKhoiNhom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRutKhoiNhom.ForeColor = System.Drawing.Color.White;
            this.btnRutKhoiNhom.Location = new System.Drawing.Point(197, 32);
            this.btnRutKhoiNhom.Name = "btnRutKhoiNhom";
            this.btnRutKhoiNhom.Size = new System.Drawing.Size(127, 37);
            this.btnRutKhoiNhom.TabIndex = 7;
            this.btnRutKhoiNhom.Text = "Rút Khỏi Nhóm";
            this.btnRutKhoiNhom.UseVisualStyleBackColor = false;
            this.btnRutKhoiNhom.Click += new System.EventHandler(this.btnRutKhoiNhom_Click_1);
            // 
            // btnHuyDangKy
            // 
            this.btnHuyDangKy.BackColor = System.Drawing.Color.SeaGreen;
            this.btnHuyDangKy.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHuyDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuyDangKy.ForeColor = System.Drawing.Color.White;
            this.btnHuyDangKy.Location = new System.Drawing.Point(363, 32);
            this.btnHuyDangKy.Name = "btnHuyDangKy";
            this.btnHuyDangKy.Size = new System.Drawing.Size(111, 37);
            this.btnHuyDangKy.TabIndex = 8;
            this.btnHuyDangKy.Text = "Hủy Đăng Ký";
            this.btnHuyDangKy.UseVisualStyleBackColor = false;
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
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(530, 588);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKetQuaDangKyNhom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Quả Đăng Ký Nhóm";
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
        private System.Windows.Forms.Button btnThoat;
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