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
            this.lvDSSinhVienDangKyChuyenDe = new System.Windows.Forms.ListView();
            this.colSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMLop = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTen = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMaGVQL = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTimTheoYeuCau
            // 
            this.btnTimTheoYeuCau.Location = new System.Drawing.Point(168, 59);
            this.btnTimTheoYeuCau.Name = "btnTimTheoYeuCau";
            this.btnTimTheoYeuCau.Size = new System.Drawing.Size(152, 23);
            this.btnTimTheoYeuCau.TabIndex = 3;
            this.btnTimTheoYeuCau.Text = "Hiển thị theo bộ lọc";
            this.btnTimTheoYeuCau.UseVisualStyleBackColor = true;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbHocKy.Location = new System.Drawing.Point(66, 28);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(33, 21);
            this.cmbHocKy.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Năm Học";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Học Kỳ";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.btnHienThiTatCaChuyenDe);
            this.groupBox3.Controls.Add(this.btnTimTheoYeuCau);
            this.groupBox3.Controls.Add(this.cmbChuyenDe);
            this.groupBox3.Controls.Add(this.cmbNamHoc);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.cmbHocKy);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(19, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(627, 96);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin tìm kiếm kết quả đăng ký";
            // 
            // btnHienThiTatCaChuyenDe
            // 
            this.btnHienThiTatCaChuyenDe.Location = new System.Drawing.Point(333, 59);
            this.btnHienThiTatCaChuyenDe.Name = "btnHienThiTatCaChuyenDe";
            this.btnHienThiTatCaChuyenDe.Size = new System.Drawing.Size(137, 23);
            this.btnHienThiTatCaChuyenDe.TabIndex = 3;
            this.btnHienThiTatCaChuyenDe.Text = "Hiển thị tất cả chuyên đề";
            this.btnHienThiTatCaChuyenDe.UseVisualStyleBackColor = true;
            // 
            // cmbChuyenDe
            // 
            this.cmbChuyenDe.FormattingEnabled = true;
            this.cmbChuyenDe.Items.AddRange(new object[] {
            "Toán Rời Rạc",
            "Kỹ Thuật Lập Trình",
            "Tin Học Cơ Sở",
            "Nhập Môn Lập Trình",
            "Lập trình Web1"});
            this.cmbChuyenDe.Location = new System.Drawing.Point(434, 28);
            this.cmbChuyenDe.Name = "cmbChuyenDe";
            this.cmbChuyenDe.Size = new System.Drawing.Size(178, 21);
            this.cmbChuyenDe.TabIndex = 2;
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.Items.AddRange(new object[] {
            "2016 - 2017",
            "2017 - 2018",
            "2018 - 2019",
            "2019 - 2020"});
            this.cmbNamHoc.Location = new System.Drawing.Point(199, 28);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(106, 21);
            this.cmbNamHoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn Chuyên Đề";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvDSSinhVienDangKyChuyenDe);
            this.groupBox2.Location = new System.Drawing.Point(19, 173);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(627, 319);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên đăng ký chuyên đề";
            // 
            // lvDSSinhVienDangKyChuyenDe
            // 
            this.lvDSSinhVienDangKyChuyenDe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colSTT,
            this.colMLop,
            this.colMSSV,
            this.colHoTen,
            this.colMaGVQL});
            this.lvDSSinhVienDangKyChuyenDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvDSSinhVienDangKyChuyenDe.GridLines = true;
            this.lvDSSinhVienDangKyChuyenDe.Location = new System.Drawing.Point(3, 16);
            this.lvDSSinhVienDangKyChuyenDe.Name = "lvDSSinhVienDangKyChuyenDe";
            this.lvDSSinhVienDangKyChuyenDe.Size = new System.Drawing.Size(621, 300);
            this.lvDSSinhVienDangKyChuyenDe.TabIndex = 3;
            this.lvDSSinhVienDangKyChuyenDe.UseCompatibleStateImageBehavior = false;
            this.lvDSSinhVienDangKyChuyenDe.View = System.Windows.Forms.View.Details;
            // 
            // colSTT
            // 
            this.colSTT.Text = "STT";
            // 
            // colMLop
            // 
            this.colMLop.Text = "Lớp";
            this.colMLop.Width = 81;
            // 
            // colMSSV
            // 
            this.colMSSV.Text = "MSSV";
            this.colMSSV.Width = 61;
            // 
            // colHoTen
            // 
            this.colHoTen.Text = "Họ Tên";
            this.colHoTen.Width = 127;
            // 
            // colMaGVQL
            // 
            this.colMaGVQL.Text = "Giáo Viên Quản Lý";
            this.colMaGVQL.Width = 219;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "DANH SÁCH SINH VIÊN ĐĂNG KÝ CHUYÊN ĐỀ";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(568, 498);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // frmKetQuaDangKyChuyenDeGiaoVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 535);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmKetQuaDangKyChuyenDeGiaoVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmKetQuaDangKyChuyenDeGiaoVu";
            this.Load += new System.EventHandler(this.frmKetQuaDangKyChuyenDeGiaoVu_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.ListView lvDSSinhVienDangKyChuyenDe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cmbChuyenDe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader colSTT;
        private System.Windows.Forms.ColumnHeader colMLop;
        private System.Windows.Forms.ColumnHeader colMSSV;
        private System.Windows.Forms.ColumnHeader colHoTen;
        private System.Windows.Forms.ColumnHeader colMaGVQL;
        private System.Windows.Forms.Button btnHienThiTatCaChuyenDe;
    }
}