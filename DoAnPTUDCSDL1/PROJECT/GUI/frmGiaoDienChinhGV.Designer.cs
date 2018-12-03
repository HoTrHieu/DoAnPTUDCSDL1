namespace PROJECT.GUI
{
    partial class frmGiaoDienChinhGV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDsSV = new System.Windows.Forms.Button();
            this.btnThemTKSV = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDsCDMo = new System.Windows.Forms.Button();
            this.btnMoCD = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMaGV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.btnDsSVDK = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDsSV);
            this.groupBox1.Controls.Add(this.btnThemTKSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quản Lý Sinh Viên";
            // 
            // btnDsSV
            // 
            this.btnDsSV.Location = new System.Drawing.Point(225, 48);
            this.btnDsSV.Name = "btnDsSV";
            this.btnDsSV.Size = new System.Drawing.Size(166, 50);
            this.btnDsSV.TabIndex = 1;
            this.btnDsSV.Text = "Xem Danh Sách Sinh Viên";
            this.btnDsSV.UseVisualStyleBackColor = true;
            this.btnDsSV.Click += new System.EventHandler(this.btnDsSV_Click);
            // 
            // btnThemTKSV
            // 
            this.btnThemTKSV.Location = new System.Drawing.Point(32, 48);
            this.btnThemTKSV.Name = "btnThemTKSV";
            this.btnThemTKSV.Size = new System.Drawing.Size(149, 50);
            this.btnThemTKSV.TabIndex = 0;
            this.btnThemTKSV.Text = "Thêm Tài Khoản Sinh Viên";
            this.btnThemTKSV.UseVisualStyleBackColor = true;
            this.btnThemTKSV.Click += new System.EventHandler(this.btnThemTKSV_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDsSVDK);
            this.groupBox2.Controls.Add(this.btnDsCDMo);
            this.groupBox2.Controls.Add(this.btnMoCD);
            this.groupBox2.Location = new System.Drawing.Point(20, 271);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(595, 134);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chuyên đề";
            // 
            // btnDsCDMo
            // 
            this.btnDsCDMo.Location = new System.Drawing.Point(217, 58);
            this.btnDsCDMo.Name = "btnDsCDMo";
            this.btnDsCDMo.Size = new System.Drawing.Size(166, 47);
            this.btnDsCDMo.TabIndex = 3;
            this.btnDsCDMo.Text = "Danh Sách Chuyên Đề Đã Mở / Chỉnh Sửa/ Vô Hiệu Hóa";
            this.btnDsCDMo.UseVisualStyleBackColor = true;
            this.btnDsCDMo.Click += new System.EventHandler(this.btnDsCDMo_Click);
            // 
            // btnMoCD
            // 
            this.btnMoCD.Location = new System.Drawing.Point(24, 58);
            this.btnMoCD.Name = "btnMoCD";
            this.btnMoCD.Size = new System.Drawing.Size(149, 47);
            this.btnMoCD.TabIndex = 0;
            this.btnMoCD.Text = "Mở Chuyên Đề";
            this.btnMoCD.UseVisualStyleBackColor = true;
            this.btnMoCD.Click += new System.EventHandler(this.btnMoCD_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.lblMaGV);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(603, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông Tin Giao Vụ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(129, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lớn Văn Lên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ Tên:";
            // 
            // lblMaGV
            // 
            this.lblMaGV.AutoSize = true;
            this.lblMaGV.Location = new System.Drawing.Point(129, 34);
            this.lblMaGV.Name = "lblMaGV";
            this.lblMaGV.Size = new System.Drawing.Size(34, 13);
            this.lblMaGV.TabIndex = 1;
            this.lblMaGV.Text = "GV01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Giáo Vụ";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(338, 438);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(88, 37);
            this.button5.TabIndex = 3;
            this.button5.Text = "Đăng Xuất";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnDsSVDK
            // 
            this.btnDsSVDK.Location = new System.Drawing.Point(412, 58);
            this.btnDsSVDK.Name = "btnDsSVDK";
            this.btnDsSVDK.Size = new System.Drawing.Size(166, 47);
            this.btnDsSVDK.TabIndex = 4;
            this.btnDsSVDK.Text = "Danh Sách Sinh Viên Đã Đăng Ký";
            this.btnDsSVDK.UseVisualStyleBackColor = true;
            this.btnDsSVDK.Click += new System.EventHandler(this.btnDsSVDK_Click);
            // 
            // frmGiaoDienChinhGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 489);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmGiaoDienChinhGV";
            this.Text = "frmGiaoDienChinhGV";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThemTKSV;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnMoCD;
        private System.Windows.Forms.Button btnDsCDMo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnDsSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnDsSVDK;
    }
}