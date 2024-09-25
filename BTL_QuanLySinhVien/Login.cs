using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLySinhVien
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private string ctr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbUserName.Text) || string.IsNullOrEmpty(txbPassWord.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin",
                         "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(ctr))
                {
                    using (SqlCommand cmd = new SqlCommand("pcDangNhap " + txbUserName.Text + ", " + txbPassWord.Text, cnn))
                    {
                        cnn.Open();
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            if (rd.Read())
                            {
                                Form1 f = new Form1();
                                f.TenTK = txbUserName.Text;
                                this.Hide();
                                f.ShowDialog();
                                this.Show();
                            }
                            else
                            {
                                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác !",
                                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        cnn.Close();
                        txbUserName.Clear();
                        txbPassWord.Clear();
                    }
                }
            }

        }

        private void lbDangKi_Click(object sender, EventArgs e)
        {
            dangki f = new dangki();
            this.Hide();
            f.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
                e.Cancel = true;
        }
    }
}
