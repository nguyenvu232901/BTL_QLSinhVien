using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class DSSVtheoMon : Form
    {
        public DSSVtheoMon()
        {
            InitializeComponent();
            hienTenMonHoc();
        }

        void hienTenMonHoc()
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                cnn.Open();
                using (SqlCommand cmd = new SqlCommand("select *from tblLop", cnn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            cbo.Items.Add(rd["sTenLop"].ToString());
                        }
                    }
                }
                cnn.Close();
            }

        }

        private void DSSVtheoMon_Load(object sender, EventArgs e)
        {
            
        }

        /*private void btn_hien_Click(object sender, EventArgs e)
        {

            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "[sp_locbangdiem]";
                    cmd.Parameters.AddWithValue("@fDiemA", txt_diemA.Text);
                    cmd.Parameters.AddWithValue("@fDiemB", txt_diemB.Text);
                    //cmd.Parameters.AddWithValue("@sMonHoc", cb_tenmon.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        ad.Fill(data);

                        BaoCao.BangDiemTheoMon rpt = new BaoCao.BangDiemTheoMon();
                        rpt.SetDataSource(data);

                        ParameterFieldDefinition pdfA = rpt.DataDefinition.ParameterFields["@fDiemA"];
                        ParameterDiscreteValue pdvA = new ParameterDiscreteValue();
                        pdvA.Value = txt_diemA.Text;
                        pdfA.CurrentValues.Clear();
                        pdfA.CurrentValues.Add(pdvA);
                        pdfA.ApplyCurrentValues(pdfA.CurrentValues);

                        ParameterFieldDefinition pdfB = rpt.DataDefinition.ParameterFields["@fDiemB"];
                        ParameterDiscreteValue pdvB = new ParameterDiscreteValue();
                        pdvB.Value = txt_diemB.Text;
                        pdfB.CurrentValues.Add(pdvB);
                        pdfB.CurrentValues.Clear();
                        pdfB.ApplyCurrentValues(pdfB.CurrentValues);

                        cry_DSSVtheoMon.ReportSource = rpt;
                        cry_DSSVtheoMon.Refresh();
                    }
                }
            }
        }*/

        private void cry_DSSVtheoMon_Load(object sender, EventArgs e)
        {
            ReportDocument cry = new ReportDocument();
            cry.Load(@"C:\C#\BTL_QuanLySinhVien\BTL_QuanLySinhVien\BaoCao\BangDiemTheoMon.rpt");


            cry_DSSVtheoMon.ReportSource = cry;
            cry_DSSVtheoMon.Refresh();
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = cnn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "sp_DSSVtheolop";
                    cmd.Parameters.AddWithValue("@TenLop", cbo.Text);
                    using (SqlDataAdapter ad = new SqlDataAdapter())
                    {
                        ad.SelectCommand = cmd;
                        DataTable data = new DataTable();
                        ad.Fill(data);

                        BaoCao.BangDiemTheoMon rpt = new BaoCao.BangDiemTheoMon();
                        rpt.SetDataSource(data);
                        ParameterFieldDefinition pdfMon = rpt.DataDefinition.ParameterFields["@TenLop"];
                        ParameterDiscreteValue pdvMon = new ParameterDiscreteValue();
                        pdvMon.Value = cbo.SelectedValue;
                        pdfMon.CurrentValues.Clear();
                        pdfMon.CurrentValues.Add(pdvMon);
                        pdfMon.ApplyCurrentValues(pdfMon.CurrentValues);

                        cry_DSSVtheoMon.ReportSource = rpt;
                        cry_DSSVtheoMon.Refresh();
                    }
                }
            }
        }
    }
}
