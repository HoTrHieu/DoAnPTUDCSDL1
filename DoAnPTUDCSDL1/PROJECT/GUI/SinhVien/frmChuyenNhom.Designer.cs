﻿namespace PROJECT.GUI
{
    partial class frmChuyenNhom
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
            this.cbxMaNhom = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTenNhom = new System.Windows.Forms.Label();
            this.btnChuyenNhom = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhóm";
            // 
            // cbxMaNhom
            // 
            this.cbxMaNhom.FormattingEnabled = true;
            this.cbxMaNhom.Location = new System.Drawing.Point(124, 61);
            this.cbxMaNhom.Name = "cbxMaNhom";
            this.cbxMaNhom.Size = new System.Drawing.Size(121, 21);
            this.cbxMaNhom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên Nhóm";
            // 
            // lblTenNhom
            // 
            this.lblTenNhom.AutoSize = true;
            this.lblTenNhom.Location = new System.Drawing.Point(121, 103);
            this.lblTenNhom.Name = "lblTenNhom";
            this.lblTenNhom.Size = new System.Drawing.Size(50, 13);
            this.lblTenNhom.TabIndex = 3;
            this.lblTenNhom.Text = "Nhóm 01";
            // 
            // btnChuyenNhom
            // 
            this.btnChuyenNhom.Location = new System.Drawing.Point(124, 150);
            this.btnChuyenNhom.Name = "btnChuyenNhom";
            this.btnChuyenNhom.Size = new System.Drawing.Size(75, 23);
            this.btnChuyenNhom.TabIndex = 4;
            this.btnChuyenNhom.Text = "Chuyển";
            this.btnChuyenNhom.UseVisualStyleBackColor = true;
            this.btnChuyenNhom.Click += new System.EventHandler(this.btnChuyenNhom_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(143, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CHUYỂN NHÓM";
            // 
            // frmChuyenNhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnChuyenNhom);
            this.Controls.Add(this.lblTenNhom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxMaNhom);
            this.Controls.Add(this.label1);
            this.Name = "frmChuyenNhom";
            this.Text = "frmChuyenNhom";
            this.Load += new System.EventHandler(this.frmChuyenNhom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMaNhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTenNhom;
        private System.Windows.Forms.Button btnChuyenNhom;
        private System.Windows.Forms.Label label4;
    }
}