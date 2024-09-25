
namespace BTL_QuanLySinhVien
{
    partial class DoiMK
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txbNhapLai = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txbMKMoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txbMKCu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txbTK = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thay đổi mật khẩu ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThoat);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 254);
            this.panel1.TabIndex = 1;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(461, 187);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(65, 42);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Hủy bỏ";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCapNhat.Location = new System.Drawing.Point(371, 187);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 42);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = false;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txbNhapLai);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(44, 141);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(567, 40);
            this.panel5.TabIndex = 4;
            // 
            // txbNhapLai
            // 
            this.txbNhapLai.Location = new System.Drawing.Point(225, 11);
            this.txbNhapLai.Name = "txbNhapLai";
            this.txbNhapLai.PasswordChar = '*';
            this.txbNhapLai.Size = new System.Drawing.Size(253, 22);
            this.txbNhapLai.TabIndex = 1;
            this.txbNhapLai.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập lại mật khẩu";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txbMKMoi);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(44, 95);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(567, 40);
            this.panel4.TabIndex = 3;
            // 
            // txbMKMoi
            // 
            this.txbMKMoi.Location = new System.Drawing.Point(225, 11);
            this.txbMKMoi.Name = "txbMKMoi";
            this.txbMKMoi.PasswordChar = '*';
            this.txbMKMoi.Size = new System.Drawing.Size(253, 22);
            this.txbMKMoi.TabIndex = 1;
            this.txbMKMoi.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(87, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mật khẩu mới";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txbMKCu);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(44, 49);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(564, 40);
            this.panel3.TabIndex = 2;
            // 
            // txbMKCu
            // 
            this.txbMKCu.Location = new System.Drawing.Point(228, 8);
            this.txbMKCu.Name = "txbMKCu";
            this.txbMKCu.PasswordChar = '*';
            this.txbMKCu.Size = new System.Drawing.Size(253, 22);
            this.txbMKCu.TabIndex = 1;
            this.txbMKCu.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txbTK);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(44, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(567, 40);
            this.panel2.TabIndex = 0;
            // 
            // txbTK
            // 
            this.txbTK.Location = new System.Drawing.Point(225, 8);
            this.txbTK.Name = "txbTK";
            this.txbTK.ReadOnly = true;
            this.txbTK.Size = new System.Drawing.Size(253, 22);
            this.txbTK.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Người dùng";
            // 
            // fDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 316);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "fDoiMK";
            this.Text = "fDoiMK";
            this.Load += new System.EventHandler(this.fDoiMK_Load);
            this.panel1.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txbTK;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txbNhapLai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txbMKMoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txbMKCu;
        private System.Windows.Forms.Label label3;
    }
}