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
    public partial class QLMonHoc : Form
    {
        public QLMonHoc()
        {
            InitializeComponent();
        }

        private void QLMonHoc_Load(object sender, EventArgs e)
        {
            dataview_load();
        }

        public void dataview_load()
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select sMaMH[Mã MH] ,sTenMH [Tên Môn], iSoTC[Số tín chỉ] from tblMonHoc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("MH");
                        ad.Fill(tb);
                        dgv_MonHoc.DataSource = tb;

                    }
                }
            }
        }

        public static bool themMon(string maMon, string tenMon, int soTC)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            string sqlInsert = "INSERT INTO tblMonHoc (sMaMH, sTenMH, iSoTC) VALUES (N'" + maMon + "',N'" + tenMon + "','" + soTC + "')";

            using (SqlConnection cnn = new SqlConnection(constr))
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

        private bool KiemTraTonTaiMaMH(string maMon)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            string sqlSelect = "SELECT COUNT(*) FROM tblMonHoc WHERE sMaMH = @MaMH";

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, cnn))
                {
                    cmd.Parameters.AddWithValue("@MaMH", maMon);
                    cnn.Open();
                    int i = (int)cmd.ExecuteScalar();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maMon, tenMon;
            int soTC;
            maMon = txt_MaMon.Text;
            tenMon = txt_TenMon.Text;
            soTC = int.Parse(txt_STC.Text);

            if (KiemTraTonTaiMaMH(maMon))
            {
                MessageBox.Show("Mã Môn học đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (themMon(maMon, tenMon, soTC))
            {

                MessageBox.Show("Them thanh cong", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataview_load();
            }
            else
            {
                MessageBox.Show("Them that bai", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static bool suaMon(string maMon, string tenMon, string soTC)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;

            string update = "update tblMonHoc set sTenMH = '" + tenMon + "', iSoTC = '" + soTC + "' where sMaMH = '" + maMon + "'";
            Console.WriteLine(update);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(update, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            string maMon, tenMon, soTC;
            maMon = txt_MaMon.Text;
            tenMon = txt_TenMon.Text;
            soTC = txt_STC.Text;
            if (suaMon(maMon, tenMon, soTC))
            {

                MessageBox.Show("Sua thanh cong", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataview_load();
            }
            else
            {
                MessageBox.Show("Sua that bai", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static bool xoaMon(string maMon)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;

            string update = "delete from tblMonHoc where sMaMH = '" + maMon + "'";
            Console.WriteLine(update);
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(update, cnn))
                {
                    cmd.CommandType = System.Data.CommandType.Text;
                    cnn.Open();
                    int i = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return i > 0;
                }
            }
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string maMon = txt_MaMon.Text;
            if (xoaMon(maMon))
            {

                MessageBox.Show("Xóa thanh cong", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataview_load();
            }
            else
            {
                MessageBox.Show("Xóa that bai", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    

        private void txt_MaMon_Validating(object sender, CancelEventArgs e)
        {
            string maMon = txt_MaMon.Text;
            if (maMon == "")
            {
                MessageBox.Show("không được để trống");
                txt_MaMon.Focus();
                e.Cancel = true;
            }
        }

        private void txt_TenMon_Validating(object sender, CancelEventArgs e)
        {
            string tenMon = txt_TenMon.Text;
            if (tenMon == "")
            {
                MessageBox.Show("không được để trống");
                txt_TenMon.Focus();
                e.Cancel = true;
            }
        }

        private void txt_STC_Validating(object sender, CancelEventArgs e)
        {
            string soTC = txt_STC.Text;
            if (soTC == "")
            {
                MessageBox.Show("không được để trống");
                txt_STC.Focus();
                e.Cancel = true;
            }
        }

        private void dgv_MonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaMon.Text = dgv_MonHoc.CurrentRow.Cells["Mã MH"].Value.ToString();
            txt_TenMon.Text = dgv_MonHoc.CurrentRow.Cells["Tên Môn"].Value.ToString();
            txt_STC.Text = dgv_MonHoc.CurrentRow.Cells["Số tín chỉ"].Value.ToString();
        }

        private void search_textbox(string x)
        {
            string sql = "SELECT * FROM tblMonHoc WHERE CONCAT (sMaMH , sTenMH ) LIKE '%" + x + "%'";
            string couter = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tk_MH");
                        ad.Fill(tb);
                        dgv_MonHoc.DataSource = tb;
                    }
                }
            }
        }
        private void txt_TimKiem_TextChanged(object sender, EventArgs e)
        {
            search_textbox(txt_TimKiem.Text);
        }
    }
}
