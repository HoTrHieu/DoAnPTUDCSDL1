namespace PROJECT.GUI
{
    partial class frmKetQuaDangKyChuyenDeGiaoVu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKetQuaDangKyChuyenDeGiaoVu));
            this.btnTimTheoYeuCau = new System.Windows.Forms.Button();
            this.cmbHocKy = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnHienThiTatCaChuyenDe = new System.Windows.Forms.Button();
            this.cmbChuyenDe = new System.Windows.Forms.ComboBox();
            this.cmbNamHoc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSSinhVienDangKyChuyenDe = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVienDangKyChuyenDe)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimTheoYeuCau
            // 
            this.btnTimTheoYeuCau.BackColor = System.Drawing.Color.Honeydew;
            this.btnTimTheoYeuCau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimTheoYeuCau.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimTheoYeuCau.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnTimTheoYeuCau.Location = new System.Drawing.Point(269, 66);
            this.btnTimTheoYeuCau.Name = "btnTimTheoYeuCau";
            this.btnTimTheoYeuCau.Size = new System.Drawing.Size(137, 34);
            this.btnTimTheoYeuCau.TabIndex = 3;
            this.btnTimTheoYeuCau.Text = "Hiển thị theo bộ lọc";
            this.btnTimTheoYeuCau.UseVisualStyleBackColor = false;
            this.btnTimTheoYeuCau.Click += new System.EventHandler(this.btnTimTheoYeuCau_Click_1);
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Location = new System.Drawing.Point(177, 28);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(46, 21);
            this.cmbHocKy.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Năm Học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(129, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Học Kỳ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SeaGreen;
            this.groupBox3.Controls.Add(this.btnHienThiTatCaChuyenDe);
            this.groupBox3.Controls.Add(this.cmbChuyenDe);
            this.groupBox3.Controls.Add(this.cmbNamHoc);
            this.groupBox3.Controls.Add(this.btnTimTheoYeuCau);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbHocKy);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(821, 117);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin tìm kiếm kết quả đăng ký";
            // 
            // btnHienThiTatCaChuyenDe
            // 
            this.btnHienThiTatCaChuyenDe.BackColor = System.Drawing.Color.Honeydew;
            this.btnHienThiTatCaChuyenDe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienThiTatCaChuyenDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHienThiTatCaChuyenDe.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnHienThiTatCaChuyenDe.Location = new System.Drawing.Point(445, 66);
            this.btnHienThiTatCaChuyenDe.Name = "btnHienThiTatCaChuyenDe";
            this.btnHienThiTatCaChuyenDe.Size = new System.Drawing.Size(137, 34);
            this.btnHienThiTatCaChuyenDe.TabIndex = 3;
            this.btnHienThiTatCaChuyenDe.Text = "Hiển thị tất cả ";
            this.btnHienThiTatCaChuyenDe.UseVisualStyleBackColor = false;
            this.btnHienThiTatCaChuyenDe.Click += new System.EventHandler(this.btnHienThiTatCaChuyenDe_Click_1);
            // 
            // cmbChuyenDe
            // 
            this.cmbChuyenDe.FormattingEnabled = true;
            this.cmbChuyenDe.Location = new System.Drawing.Point(522, 28);
            this.cmbChuyenDe.Name = "cmbChuyenDe";
            this.cmbChuyenDe.Size = new System.Drawing.Size(222, 21);
            this.cmbChuyenDe.TabIndex = 2;
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Location = new System.Drawing.Point(294, 28);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(106, 21);
            this.cmbNamHoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn Chuyên Đề";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSSinhVienDangKyChuyenDe);
            this.groupBox2.Location = new System.Drawing.Point(12, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(818, 319);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên đăng ký chuyên đề";
            // 
            // dgvDSSinhVienDangKyChuyenDe
            // 
            this.dgvDSSinhVienDangKyChuyenDe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSSinhVienDangKyChuyenDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSinhVienDangKyChuyenDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSSinhVienDangKyChuyenDe.Location = new System.Drawing.Point(3, 16);
            this.dgvDSSinhVienDangKyChuyenDe.Name = "dgvDSSinhVienDangKyChuyenDe";
            this.dgvDSSinhVienDangKyChuyenDe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDSSinhVienDangKyChuyenDe.Size = new System.Drawing.Size(812, 300);
            this.dgvDSSinhVienDangKyChuyenDe.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(166, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(512, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "DANH SÁCH SINH VIÊN ĐĂNG KÝ CHUYÊN ĐỀ";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Honeydew;
            this.btnThoat.Location = new System.Drawing.Point(736, 495);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 34);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmKetQuaDangKyChuyenDeGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 538);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKetQuaDangKyChuyenDeGiaoVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kết Quả Đăng Ký Chuyên Đề";
            this.Load += new System.EventHandler(this.frmKetQuaDangKyChuyenDeGiaoVu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSinhVienDangKyChuyenDe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimTheoYeuCau;
        private System.Windows.Forms.ComboBox cmbHocKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbNamHoc;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbChuyenDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHienThiTatCaChuyenDe;
        private System.Windows.Forms.DataGridView dgvDSSinhVienDangKyChuyenDe;
    }
}