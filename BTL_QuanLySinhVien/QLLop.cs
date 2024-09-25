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
    public partial class QLLop : Form
    {
        public QLLop()
        {
            InitializeComponent();
        }
        private void btn_ThemLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mask_maLop.Text) || string.IsNullOrEmpty(mask_tenLop.Text) ||
                  string.IsNullOrEmpty(combo_maKhoa.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                themLop(Convert.ToString(mask_maLop.Text), Convert.ToString(mask_tenLop.Text), Convert.ToString(combo_maKhoa.Text));
                laydataGridLop();
            }
        }

        private void layDSLop()
        {
            string ctr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(ctr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblLop", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);

                        DataView v = new DataView(tb);
                        v.Sort = "sTenLop";
                        combo_maKhoa.DataSource = v;
                        combo_maKhoa.DisplayMember = "sTenLop";
                        combo_maKhoa.ValueMember = "sMaKhoa";

                    }
                }
            }
        }


        public static void themLop(string malop, string tenlop, string makhoa)
        {
            string counter = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            string sqlInsert = "INSERT INTO tblLop (sMalop , sTenLop , sMaKhoa , fSoSV) " +
                "VALUES( '" + malop + "' , N'" + tenlop + "' , '" + ")";
            using (SqlConnection cnn = new SqlConnection(counter))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();

                    cnn.Close();

                }
            }
        }

        public void laydataGridLop()
        {
            string couter = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT sMaLop AS 'Mã lớp' , sTenLop AS 'Tên lớp' , sMaKhoa AS 'Mã khoa' FROM tblLop", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_Lop");
                        ad.Fill(tb);
                        dtGridLop.DataSource = tb;
                    }
                }
            }
        }

        public static bool suaLop(string maLop, string tenLop)
        {
            string ctr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            string sqlInsert = "Update tblLop SET sTenSV = N'" + tenLop + "' WHERE sMaSV = '" + maLop + "'  ";
            using (SqlConnection cnn = new SqlConnection(ctr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }

        }

        public static bool xoaaLop(string maLop)
        {
            string ctr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            string sqlInsert = "DELETE FROM tblLop WHERE sMaLop = '" + maLop + " '  ";
            using (SqlConnection cnn = new SqlConnection(ctr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlInsert, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }

        private void btn_suaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mask_maLop.Text) || string.IsNullOrEmpty(mask_tenLop.Text) ||
                 string.IsNullOrEmpty(combo_maKhoa.Text))
            {
                MessageBox.Show("Bạn cần nhập đầy đủ thông tin",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                suaLop(Convert.ToString(mask_maLop.Text), Convert.ToString(mask_tenLop.Text));
                laydataGridLop();
                mask_maLop.Enabled = true;
            }

        }

        private void btn_xoaLop_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mask_maLop.Text))
            {
                MessageBox.Show("Bạn cần nhập mã lớp cần xóa",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa lop này ??", "Thông báo ", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    xoaaLop(Convert.ToString(mask_maLop.Text));
                    laydataGridLop();
                }
                else
                    Close();
            }
        }
        private void layKhoa()
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM tblKhoa", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("Lop");
                        ad.Fill(tb);
                        combo_maKhoa.DataSource = tb;
                        combo_maKhoa.DisplayMember = "sMaKhoa";
                        combo_maKhoa.ValueMember = "sTenKhoa";
                    }
                }
            }
        }

        private void dtGridLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            mask_maLop.Text = dtGridLop.CurrentRow.Cells["Mã lớp"].Value.ToString();
            mask_tenLop.Text = dtGridLop.CurrentRow.Cells["Tên lớp"].Value.ToString();
            mask_maLop.Enabled = false;
        }

        private void QLLop_Load(object sender, EventArgs e)
        {

            laydataGridLop();
            layKhoa();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            laydataGridLop();

        }

        private void tb_Search_TextChanged(object sender, EventArgs e)
        {
            /*
            string sql = "SELECT * FROM tblSINHVIEN WHERE sGioitinh LIKE '%" + tb_Search.Text.ToString() + "%'";
            string couter = ConfigurationManager.ConnectionStrings["btl_c#"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_Lop");
                        ad.Fill(tb);
                        dtGridLop.DataSource = tb;
                    }
                }
            }

            */
            search_textbox(tb_Search.Text);

        }
        private void search_textbox(string x)
        {
            string sql = "SELECT * FROM tblLop WHERE CONCAT(sMaLop , sTenLop ) LIKE '%" + x + "%' OR sMaKhoa LIKE '%" + x + "%'";
            string couter = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_Lop");
                        ad.Fill(tb);
                        dtGridLop.DataSource = tb;
                    }
                }
            }
        }
    }
}
