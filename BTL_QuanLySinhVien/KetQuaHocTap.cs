using CrystalDecisions.CrystalReports.Engine;
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
    public partial class KetQuaHocTap : Form
    {
        private string maSV;
        public KetQuaHocTap()
        {
            InitializeComponent();
        }

        public string MaSV { get => maSV; set => maSV = value; }

        private string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;

        private void hienKQHT()
        {
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("pcKetQuaHocTap ", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaSV", txbMaSV.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable dt = new DataTable();
                        ad.Fill(dt);
                        BaoCao.baocaoKetQuaHocTap rpt = new BaoCao.baocaoKetQuaHocTap();
                        rpt.SetDataSource(dt);
                        crtKQHT.ReportSource = rpt;

                        crtKQHT.Refresh();
                    }

                }
                cnn.Close();
            }
        }



        private void KetQuaHocTap_Load_1(object sender, EventArgs e)
        {
            txbMaSV.Text = maSV.ToString();
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("pcThongTinKQHT ", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@sMaSV", txbMaSV.Text);
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            txbHoTen.Text = rd["sTenSV"].ToString();
                            DateTime ngaySinh = (DateTime)rd["dNgaySinh"];
                            string ngaySinhFormatted = ngaySinh.ToString("dd/MM/yyyy");
                            txbNgaySinh.Text = ngaySinhFormatted;
                            txbGioiTinh.Text = rd["sGT"].ToString();
                            txbLop.Text = rd["sTenLop"].ToString();
                            txbKhoa.Text = rd["sTenKhoa"].ToString();

                        }
                        rd.Close();
                    }
                }
                cnn.Close();
            }

            hienKQHT();
        }

        private void crtKQHT_Load_1(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            cry.Load(@"C:\C#\BTL_QuanLySinhVien\BTL_QuanLySinhVien\BaoCao\baocaoKetQuaHocTap.rpt");
            crtKQHT.ReportSource = cry;
            crtKQHT.Refresh();
            hienKQHT();
        }
    }
}
