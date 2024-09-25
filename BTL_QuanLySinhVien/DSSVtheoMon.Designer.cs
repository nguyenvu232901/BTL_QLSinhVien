
namespace BTL_QuanLySinhVien
{
    partial class DSSVtheoMon
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
            this.cry_DSSVtheoMon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cry_DSSVtheoMon
            // 
            this.cry_DSSVtheoMon.ActiveViewIndex = -1;
            this.cry_DSSVtheoMon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cry_DSSVtheoMon.Cursor = System.Windows.Forms.Cursors.Default;
            this.cry_DSSVtheoMon.Location = new System.Drawing.Point(12, 134);
            this.cry_DSSVtheoMon.Name = "cry_DSSVtheoMon";
            this.cry_DSSVtheoMon.Size = new System.Drawing.Size(1395, 694);
            this.cry_DSSVtheoMon.TabIndex = 0;
            this.cry_DSSVtheoMon.Load += new System.EventHandler(this.cry_DSSVtheoMon_Load);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(478, 100);
            this.panel1.TabIndex = 1;
            // 
            // cbo
            // 
            this.cbo.FormattingEnabled = true;
            this.cbo.Location = new System.Drawing.Point(131, 53);
            this.cbo.Name = "cbo";
            this.cbo.Size = new System.Drawing.Size(240, 24);
            this.cbo.TabIndex = 2;
            this.cbo.SelectedIndexChanged += new System.EventHandler(this.cbo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập tên Lớp";
            // 
            // DSSVtheoMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 840);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cry_DSSVtheoMon);
            this.Name = "DSSVtheoMon";
            this.Text = "DSSVtheoMon";
            this.Load += new System.EventHandler(this.DSSVtheoMon_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer cry_DSSVtheoMon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo;
    }
}