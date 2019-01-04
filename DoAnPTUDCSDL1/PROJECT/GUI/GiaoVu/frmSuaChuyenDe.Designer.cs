namespace PROJECT.GUI.GiaoVu
{
    partial class frmSuaChuyenDe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaChuyenDe));
            this.txtSVToiDa = new System.Windows.Forms.TextBox();
            this.txtTenChuyenDe = new System.Windows.Forms.TextBox();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhau = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbNganh = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSVToiDa
            // 
            this.txtSVToiDa.Location = new System.Drawing.Point(103, 55);
            this.txtSVToiDa.Name = "txtSVToiDa";
            this.txtSVToiDa.Size = new System.Drawing.Size(172, 20);
            this.txtSVToiDa.TabIndex = 2;
            // 
            // txtTenChuyenDe
            // 
            this.txtTenChuyenDe.Location = new System.Drawing.Point(103, 18);
            this.txtTenChuyenDe.Name = "txtTenChuyenDe";
            this.txtTenChuyenDe.Size = new System.Drawing.Size(172, 20);
            this.txtTenChuyenDe.TabIndex = 1;
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lblTenTaiKhoan.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenTaiKhoan.ForeColor = System.Drawing.Color.White;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(2, 21);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(79, 14);
            this.lblTenTaiKhoan.TabIndex = 3;
            this.lblTenTaiKhoan.Text = "Tên chuyên đề";
            // 
            // lblMatKhau
            // 
            this.lblMatKhau.AutoSize = true;
            this.lblMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.lblMatKhau.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatKhau.ForeColor = System.Drawing.Color.White;
            this.lblMatKhau.Location = new System.Drawing.Point(2, 58);
            this.lblMatKhau.Name = "lblMatKhau";
            this.lblMatKhau.Size = new System.Drawing.Size(95, 14);
            this.lblMatKhau.TabIndex = 4;
            this.lblMatKhau.Text = "Số sinh viên tối đa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.cmbNganh);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSVToiDa);
            this.panel1.Controls.Add(this.txtTenChuyenDe);
            this.panel1.Controls.Add(this.lblTenTaiKhoan);
            this.panel1.Controls.Add(this.lblMatKhau);
            this.panel1.Location = new System.Drawing.Point(9, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 114);
            this.panel1.TabIndex = 15;
            // 
            // cmbNganh
            // 
            this.cmbNganh.FormattingEnabled = true;
            this.cmbNganh.Location = new System.Drawing.Point(103, 85);
            this.cmbNganh.Name = "cmbNganh";
            this.cmbNganh.Size = new System.Drawing.Size(173, 21);
            this.cmbNganh.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ngành";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SeaGreen;
            this.label3.Location = new System.Drawing.Point(57, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 23);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sửa Chuyên Đề";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnCapNhat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCapNhat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.ForeColor = System.Drawing.Color.Honeydew;
            this.btnCapNhat.Location = new System.Drawing.Point(9, 192);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(135, 32);
            this.btnCapNhat.TabIndex = 13;
            this.btnCapNhat.Text = "Cập Nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.SeaGreen;
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThoat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.Honeydew;
            this.btnThoat.Location = new System.Drawing.Point(153, 192);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(135, 32);
            this.btnThoat.TabIndex = 14;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmSuaChuyenDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 241);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.btnThoat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSuaChuyenDe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa Chuyên Đề";
            this.Load += new System.EventHandler(this.frmSuaChuyenDe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSVToiDa;
        private System.Windows.Forms.TextBox txtTenChuyenDe;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Label lblMatKhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbNganh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
    }
}