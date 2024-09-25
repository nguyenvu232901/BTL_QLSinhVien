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
    public partial class dangki : Form
    {
        public dangki()
        {
            InitializeComponent();
        }
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbTaiKhoan.Text) || string.IsNullOrEmpty(txbMatKhau.Text)
                || string.IsNullOrEmpty(txbNhapLaiMK.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin để đăng kí tài khoản !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            if (txbMatKhau.Text != txbNhapLaiMK.Text)
            {
                MessageBox.Show("Mật khẩu không trùng nhau vui lòng nhập lại !",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txbTaiKhoan.Clear();
                txbMatKhau.Clear();
                txbNhapLaiMK.Clear();
                txbTaiKhoan.ContainsFocus.ToString();
            }
            else
            {
                string counter = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
                using (SqlConnection cnn = new SqlConnection(counter))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand("pcDangKi ", cnn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@sTenTK", txbTaiKhoan.Text);
                        cmd.Parameters.AddWithValue("@sMK", txbMatKhau.Text);
                        int i = 0;
                        i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            if (MessageBox.Show("Đăng kí thành công", "Thông báo", MessageBoxButtons.OK) == DialogResult.OK)
                            {
                                Login f = new Login();
                                this.Hide();
                                f.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đăng kí thất bại!",
                                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txbTaiKhoan.Clear();
                            txbMatKhau.Clear();
                            txbNhapLaiMK.Clear();
                            txbTaiKhoan.ContainsFocus.ToString();
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Login f = new Login();
            this.Hide();
            f.Show();
        }
    }
}
