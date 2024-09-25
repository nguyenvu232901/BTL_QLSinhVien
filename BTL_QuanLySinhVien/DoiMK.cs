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
    public partial class DoiMK : Form
    {
        public DoiMK()
        {
            InitializeComponent();
        }
        private string ctr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;


        private string mkCu;
        #region Event
        private void layMkCu()
        {
            using (SqlConnection cnn = new SqlConnection(ctr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select sMK from username where sTenTK = N'" + txbTK.Text + "'", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        if (rd.Read())
                        {
                            mkCu = rd["sMK"].ToString();
                        }
                    }
                }
            }
        }

        #endregion



        private void fDoiMK_Load(object sender, EventArgs e)
        {
            txbTK.Text = Form1.tenTK.ToString();
            txbTK.Enabled = false;
            layMkCu();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbMKCu.Text) || string.IsNullOrEmpty(txbMKMoi.Text)
                || string.IsNullOrEmpty(txbNhapLai.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (txbMKCu.Text != mkCu)
            {
                MessageBox.Show("Mật khẩu cũ không chính xác !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMKCu.Clear();
            }
            else if (txbMKCu.Text == txbMKMoi.Text)
            {
                MessageBox.Show("Mật khẩu mới phải khác mật khẩu cũ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbMKMoi.Clear();
                txbNhapLai.Clear();
            }
            else if (txbMKMoi.Text != txbNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu nhập lại phải trùng mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txbNhapLai.Clear();
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(ctr))
                {
                    cnn.Open();
                    using (SqlCommand cmd = new SqlCommand(" update username set sMK = N'" + txbMKMoi.Text + "' where sTenTK = N'" + txbTK.Text + "'", cnn))
                    {
                        cmd.CommandType = CommandType.Text;
                        int i = 0;
                        i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Thay đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txbMKCu.Clear();
                            txbMKMoi.Clear();
                            txbNhapLai.Clear();
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn hủy bỏ ?", "Thông báo",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
