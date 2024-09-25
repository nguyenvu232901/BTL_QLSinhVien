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
    public partial class QLKhoa : Form
    {
        public QLKhoa()
        {
            InitializeComponent();
        }

        private void QLKhoa_Load(object sender, EventArgs e)
        {
            dataview_load();
        }

        public void dataview_load()
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select sMaKhoa[Mã Khoa] ,sTenKhoa [Tên Khoa], sSDT[Số điện thoại], sDiaChiKhoa[Địa chỉ], TruongKhoa[Trưởng Khoa] from tblKhoa", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("khoa");
                        ad.Fill(tb);
                        dgv_Khoa.DataSource = tb;

                    }
                }
            }
        }

        public static bool themMon(string maKhoa, string tenKhoa, string sdt, string diachi, string truongkhoa)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            string sqlInsert = "INSERT INTO tblKhoa (sMaKhoa, sTenKhoa, sSDT, sDiaChiKhoa, TruongKhoa) VALUES (N'" + maKhoa + "',N'" + tenKhoa + "','" + sdt + "',N'" + diachi + "', N'" + truongkhoa + "')";

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

        private bool KiemTraTonTaiMaKhoa(string maKhoa)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            string sqlSelect = "SELECT COUNT(*) FROM tblKhoa WHERE sMaKhoa = @MaKhoa";

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, cnn))
                {
                    cmd.Parameters.AddWithValue("@MaKhoa", maKhoa);
                    cnn.Open();
                    int i = (int)cmd.ExecuteScalar();
                    cnn.Close();

                    return i > 0;
                }
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string maKhoa, tenKhoa, sdt, diachi, truongkhoa;
            maKhoa = txt_maKhoa.Text;
            tenKhoa = txt_tenKhoa.Text;
            sdt = txt_sdt.Text;
            diachi = txt_dchi.Text;
            truongkhoa = txt_TrKhoa.Text;

            if (KiemTraTonTaiMaKhoa(maKhoa))
            {
                MessageBox.Show("Mã Khoa đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (themMon(maKhoa, tenKhoa, sdt, diachi, truongkhoa))
            {

                MessageBox.Show("Them thanh cong", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataview_load();
            }
            else
            {
                MessageBox.Show("Them that bai", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
