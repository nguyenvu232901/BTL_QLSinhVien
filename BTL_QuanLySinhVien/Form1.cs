using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLySinhVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string tenTK;

        public string TenTK { get => tenTK; set => tenTK = value; }

        private void quảnLýSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLSV qlsv = new QLSV();
            qlsv.MdiParent = this;
            qlsv.Show();
        }

        private void quảnLýLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLLop qll = new QLLop();
            qll.MdiParent = this;
            qll.Show();
        }

        private void quảnLíMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLMonHoc qlmh = new QLMonHoc();
            qlmh.MdiParent = this;
            qlmh.Show();
        }

        private void quảnLíĐiểmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLDiem qld = new QLDiem();
            qld.MdiParent = this;
            qld.Show();

        }

        private void quảnLíKhoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QLKhoa qlk = new QLKhoa();
            qlk.MdiParent = this;
            qlk.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void hiệnDSSVTheoMônToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DSSVtheoMon f = new DSSVtheoMon();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void đăngKíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dangki f = new dangki();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMK f = new DoiMK();
            this.Hide();
            f.ShowDialog();
            this.Close();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình ??", "Thông báo ", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                Close();
        }
    }
}
