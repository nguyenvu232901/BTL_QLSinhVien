
namespace BTL_QuanLySinhVien
{
    partial class QLLop
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mask_maLop = new System.Windows.Forms.MaskedTextBox();
            this.mask_tenLop = new System.Windows.Forms.MaskedTextBox();
            this.combo_maKhoa = new System.Windows.Forms.ComboBox();
            this.dtGridLop = new System.Windows.Forms.DataGridView();
            this.btn_ThemLop = new System.Windows.Forms.Button();
            this.btn_suaLop = new System.Windows.Forms.Button();
            this.btn_xoaLop = new System.Windows.Forms.Button();
            this.tb_Search = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLop)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã khoa";
            // 
            // mask_maLop
            // 
            this.mask_maLop.Location = new System.Drawing.Point(98, 11);
            this.mask_maLop.Name = "mask_maLop";
            this.mask_maLop.Size = new System.Drawing.Size(264, 22);
            this.mask_maLop.TabIndex = 4;
            // 
            // mask_tenLop
            // 
            this.mask_tenLop.Location = new System.Drawing.Point(98, 61);
            this.mask_tenLop.Name = "mask_tenLop";
            this.mask_tenLop.Size = new System.Drawing.Size(264, 22);
            this.mask_tenLop.TabIndex = 5;
            // 
            // combo_maKhoa
            // 
            this.combo_maKhoa.FormattingEnabled = true;
            this.combo_maKhoa.Location = new System.Drawing.Point(98, 117);
            this.combo_maKhoa.Name = "combo_maKhoa";
            this.combo_maKhoa.Size = new System.Drawing.Size(264, 24);
            this.combo_maKhoa.TabIndex = 6;
            // 
            // dtGridLop
            // 
            this.dtGridLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridLop.Location = new System.Drawing.Point(397, 12);
            this.dtGridLop.Name = "dtGridLop";
            this.dtGridLop.RowHeadersWidth = 51;
            this.dtGridLop.RowTemplate.Height = 24;
            this.dtGridLop.Size = new System.Drawing.Size(574, 269);
            this.dtGridLop.TabIndex = 8;
            this.dtGridLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridLop_CellClick);
            // 
            // btn_ThemLop
            // 
            this.btn_ThemLop.Location = new System.Drawing.Point(30, 3);
            this.btn_ThemLop.Name = "btn_ThemLop";
            this.btn_ThemLop.Size = new System.Drawing.Size(79, 49);
            this.btn_ThemLop.TabIndex = 9;
            this.btn_ThemLop.Text = "Thêm";
            this.btn_ThemLop.UseVisualStyleBackColor = true;
            this.btn_ThemLop.Click += new System.EventHandler(this.btn_ThemLop_Click);
            // 
            // btn_suaLop
            // 
            this.btn_suaLop.Location = new System.Drawing.Point(156, 3);
            this.btn_suaLop.Name = "btn_suaLop";
            this.btn_suaLop.Size = new System.Drawing.Size(79, 49);
            this.btn_suaLop.TabIndex = 10;
            this.btn_suaLop.Text = "Sửa";
            this.btn_suaLop.UseVisualStyleBackColor = true;
            this.btn_suaLop.Click += new System.EventHandler(this.btn_suaLop_Click);
            // 
            // btn_xoaLop
            // 
            this.btn_xoaLop.Location = new System.Drawing.Point(283, 3);
            this.btn_xoaLop.Name = "btn_xoaLop";
            this.btn_xoaLop.Size = new System.Drawing.Size(79, 49);
            this.btn_xoaLop.TabIndex = 11;
            this.btn_xoaLop.Text = "Xóa";
            this.btn_xoaLop.UseVisualStyleBackColor = true;
            this.btn_xoaLop.Click += new System.EventHandler(this.btn_xoaLop_Click);
            // 
            // tb_Search
            // 
            this.tb_Search.Location = new System.Drawing.Point(97, 8);
            this.tb_Search.Name = "tb_Search";
            this.tb_Search.Size = new System.Drawing.Size(265, 22);
            this.tb_Search.TabIndex = 12;
            this.tb_Search.TextChanged += new System.EventHandler(this.tb_Search_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.mask_maLop);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.mask_tenLop);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.combo_maKhoa);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 157);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_ThemLop);
            this.panel2.Controls.Add(this.btn_suaLop);
            this.panel2.Controls.Add(this.btn_xoaLop);
            this.panel2.Location = new System.Drawing.Point(12, 175);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 55);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.tb_Search);
            this.panel3.Location = new System.Drawing.Point(12, 237);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 44);
            this.panel3.TabIndex = 16;
            // 
            // QLLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtGridLop);
            this.Name = "QLLop";
            this.Text = "QLLop";
            this.Load += new System.EventHandler(this.QLLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridLop)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mask_maLop;
        private System.Windows.Forms.MaskedTextBox mask_tenLop;
        private System.Windows.Forms.ComboBox combo_maKhoa;
        private System.Windows.Forms.DataGridView dtGridLop;
        private System.Windows.Forms.Button btn_ThemLop;
        private System.Windows.Forms.Button btn_suaLop;
        private System.Windows.Forms.Button btn_xoaLop;
        private System.Windows.Forms.TextBox tb_Search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

    }
}