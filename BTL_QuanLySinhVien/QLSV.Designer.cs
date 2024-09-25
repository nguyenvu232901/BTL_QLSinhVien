
namespace BTL_QuanLySinhVien
{
    partial class QLSV
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dt_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.cb_lop = new System.Windows.Forms.ComboBox();
            this.txt_quequan = new System.Windows.Forms.TextBox();
            this.txt_tenSV = new System.Windows.Forms.TextBox();
            this.txt_gt = new System.Windows.Forms.TextBox();
            this.txt_MaSV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_QLSV = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.btn_Them = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cb_inbaocao = new System.Windows.Forms.ComboBox();
            this.btn_inbaoCao = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.txt_timkiem = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLSV)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dt_ngaysinh);
            this.panel1.Controls.Add(this.cb_lop);
            this.panel1.Controls.Add(this.txt_quequan);
            this.panel1.Controls.Add(this.txt_tenSV);
            this.panel1.Controls.Add(this.txt_gt);
            this.panel1.Controls.Add(this.txt_MaSV);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(33, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 289);
            this.panel1.TabIndex = 0;
            // 
            // dt_ngaysinh
            // 
            this.dt_ngaysinh.CustomFormat = "dd/MM/yyyy";
            this.dt_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dt_ngaysinh.Location = new System.Drawing.Point(128, 148);
            this.dt_ngaysinh.Name = "dt_ngaysinh";
            this.dt_ngaysinh.Size = new System.Drawing.Size(202, 22);
            this.dt_ngaysinh.TabIndex = 12;
            this.dt_ngaysinh.Validating += new System.ComponentModel.CancelEventHandler(this.dt_ngaysinh_Validating);
            // 
            // cb_lop
            // 
            this.cb_lop.FormattingEnabled = true;
            this.cb_lop.Location = new System.Drawing.Point(126, 242);
            this.cb_lop.Name = "cb_lop";
            this.cb_lop.Size = new System.Drawing.Size(204, 24);
            this.cb_lop.TabIndex = 11;
            this.cb_lop.SelectedIndexChanged += new System.EventHandler(this.cb_lop_SelectedIndexChanged);
            // 
            // txt_quequan
            // 
            this.txt_quequan.Location = new System.Drawing.Point(126, 197);
            this.txt_quequan.Name = "txt_quequan";
            this.txt_quequan.Size = new System.Drawing.Size(204, 22);
            this.txt_quequan.TabIndex = 9;
            this.txt_quequan.Validating += new System.ComponentModel.CancelEventHandler(this.txt_quequan_Validating);
            // 
            // txt_tenSV
            // 
            this.txt_tenSV.Location = new System.Drawing.Point(126, 56);
            this.txt_tenSV.Name = "txt_tenSV";
            this.txt_tenSV.Size = new System.Drawing.Size(204, 22);
            this.txt_tenSV.TabIndex = 8;
            this.txt_tenSV.Validating += new System.ComponentModel.CancelEventHandler(this.txt_tenSV_Validating);
            // 
            // txt_gt
            // 
            this.txt_gt.Location = new System.Drawing.Point(126, 101);
            this.txt_gt.Name = "txt_gt";
            this.txt_gt.Size = new System.Drawing.Size(204, 22);
            this.txt_gt.TabIndex = 7;
            this.txt_gt.Validating += new System.ComponentModel.CancelEventHandler(this.txt_gt_Validating);
            // 
            // txt_MaSV
            // 
            this.txt_MaSV.Location = new System.Drawing.Point(126, 14);
            this.txt_MaSV.Name = "txt_MaSV";
            this.txt_MaSV.Size = new System.Drawing.Size(204, 22);
            this.txt_MaSV.TabIndex = 6;
            this.txt_MaSV.Validating += new System.ComponentModel.CancelEventHandler(this.txt_MaSV_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mã lớp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quê quán";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Giới tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sinh viên";
            // 
            // dgv_QLSV
            // 
            this.dgv_QLSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLSV.Location = new System.Drawing.Point(439, 12);
            this.dgv_QLSV.Name = "dgv_QLSV";
            this.dgv_QLSV.RowHeadersWidth = 51;
            this.dgv_QLSV.RowTemplate.Height = 24;
            this.dgv_QLSV.Size = new System.Drawing.Size(1114, 524);
            this.dgv_QLSV.TabIndex = 1;
            this.dgv_QLSV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLSV_CellClick);
            this.dgv_QLSV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLSV_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Xoa);
            this.panel2.Controls.Add(this.btn_Sua);
            this.panel2.Controls.Add(this.btn_Them);
            this.panel2.Location = new System.Drawing.Point(33, 321);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 69);
            this.panel2.TabIndex = 2;
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.Location = new System.Drawing.Point(255, 16);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(101, 41);
            this.btn_Xoa.TabIndex = 2;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.Location = new System.Drawing.Point(128, 16);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(94, 41);
            this.btn_Sua.TabIndex = 1;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.Location = new System.Drawing.Point(13, 16);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(94, 41);
            this.btn_Them.TabIndex = 0;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cb_inbaocao);
            this.panel3.Controls.Add(this.btn_inbaoCao);
            this.panel3.Location = new System.Drawing.Point(33, 464);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(381, 72);
            this.panel3.TabIndex = 3;
            // 
            // cb_inbaocao
            // 
            this.cb_inbaocao.FormattingEnabled = true;
            this.cb_inbaocao.Location = new System.Drawing.Point(8, 23);
            this.cb_inbaocao.Name = "cb_inbaocao";
            this.cb_inbaocao.Size = new System.Drawing.Size(224, 24);
            this.cb_inbaocao.TabIndex = 13;
            this.cb_inbaocao.SelectedIndexChanged += new System.EventHandler(this.cb_inbaocao_SelectedIndexChanged);
            // 
            // btn_inbaoCao
            // 
            this.btn_inbaoCao.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_inbaoCao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_inbaoCao.Location = new System.Drawing.Point(238, 14);
            this.btn_inbaoCao.Name = "btn_inbaoCao";
            this.btn_inbaoCao.Size = new System.Drawing.Size(127, 41);
            this.btn_inbaoCao.TabIndex = 4;
            this.btn_inbaoCao.Text = "In Báo Cáo";
            this.btn_inbaoCao.UseVisualStyleBackColor = false;
            this.btn_inbaoCao.Click += new System.EventHandler(this.btn_inbaoCao_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            this.txt_timkiem.Location = new System.Drawing.Point(130, 416);
            this.txt_timkiem.Name = "txt_timkiem";
            this.txt_timkiem.Size = new System.Drawing.Size(284, 22);
            this.txt_timkiem.TabIndex = 5;
            this.txt_timkiem.TextChanged += new System.EventHandler(this.txt_timkiem_TextChanged);
            // 
            // QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1604, 597);
            this.Controls.Add(this.txt_timkiem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv_QLSV);
            this.Controls.Add(this.panel1);
            this.Name = "QLSV";
            this.Text = "QLSV";
            this.Load += new System.EventHandler(this.QLSV_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLSV)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_quequan;
        private System.Windows.Forms.TextBox txt_tenSV;
        private System.Windows.Forms.TextBox txt_gt;
        private System.Windows.Forms.TextBox txt_MaSV;
        private System.Windows.Forms.ComboBox cb_lop;
        private System.Windows.Forms.DateTimePicker dt_ngaysinh;
        private System.Windows.Forms.DataGridView dgv_QLSV;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.ComboBox cb_inbaocao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_inbaoCao;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txt_timkiem;
        private System.Windows.Forms.Label label7;
    }
}