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
    public partial class QLSV : Form
    {
        public QLSV()
        {
            InitializeComponent();
        }
        private void QLSV_Load(object sender, EventArgs e)
        {
            layDSLop();
            dataview_load();
            cb_inbaocao.Items.Add("Hiện DSSV theo môn học");
            cb_inbaocao.Items.Add("Kết quả học tập");
        }

        private void layDSLop()
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from tblLop", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        cb_lop.DataSource = tb;
                        cb_lop.DisplayMember = "sTenLop";
                        cb_lop.ValueMember = "sMaLop";
                    }
                }
            }
        }

        public void dataview_load()
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select sMaSV[Mã SV] ,sTenSV [Tên SV],dNgaySinh[Ngày sinh],sQueQuan[Quê quán],sMaLop[Tên lớp],sGT[Giới tính] from tblSinhVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("SV");
                        ad.Fill(tb);
                        dgv_QLSV.DataSource = tb;
                        dgv_QLSV.Columns["Ngày sinh"].DefaultCellStyle.Format = "dd/MM/yyyy";
                        

                    }
                }
            }
        }

        public static bool themSV(string lop, string maSV, string tenSV, DateTime ngaysinh, string gioitinh, string quequan)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            string sqlInsert = "INSERT INTO tblSinhVien (sMaSV,sTenSV,dNgaySinh,sQueQuan,sMaLop,sGT) VALUES ('" + maSV + "',N'" + tenSV + "',N'" + ngaysinh + "',N'" + quequan + "' ,N'" + lop + "','" + gioitinh + "')";

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

        private bool KiemTraTonTaiMaSV(string maSV)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;
            string sqlSelect = "SELECT COUNT(*) FROM tblSinhVien WHERE sMaSV = @MaSV";

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(sqlSelect, cnn))
                {
                    cmd.Parameters.AddWithValue("@MaSV", maSV);
                    cnn.Open();
                    int i = (int)cmd.ExecuteScalar();
                    cnn.Close();

                    return i > 0;
                }
            }
        }
        private void btn_Them_Click(object sender, EventArgs e)
        {
            string lop, maSV, tenSV, gioitinh,quequan;
            DateTime ngaysinh;
            lop = cb_lop.SelectedValue.ToString();
            maSV = txt_MaSV.Text;
            tenSV = txt_tenSV.Text;
            ngaysinh = dt_ngaysinh.Value;
            gioitinh = txt_gt.Text;
            quequan = txt_quequan.Text;
            
            //MessageBox.Show(lop);
            if (KiemTraTonTaiMaSV(maSV))
    {
        MessageBox.Show("Mã SV đã tồn tại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
    }
            if (themSV(lop, maSV, tenSV, ngaysinh, gioitinh,quequan))
            {

                MessageBox.Show("Them thanh cong", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataview_load();
            }
            else
            {
                MessageBox.Show("Them that bai", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static bool suaSV(string lop, string maSV, string tenSV, DateTime ngaysinh, string gioitinh, string quequan)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;

            string update = "update tblSinhVien set sTenSV = '" + tenSV + "',dNgaySinh = '" + ngaysinh + "',sMaLop = '" + lop + "',sGT = '" + quequan + "',sQueQuan = '" + gioitinh + "' where sMaSV = '" + maSV + "'";
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
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            string lop, maSV, tenSV, gioitinh, quequan;
            DateTime ngaysinh;
            lop = cb_lop.SelectedValue.ToString();
            maSV = txt_MaSV.Text;
            tenSV = txt_tenSV.Text;
            ngaysinh = dt_ngaysinh.Value;
            gioitinh = txt_gt.Text;
            quequan = txt_quequan.Text;
            
            //MessageBox.Show(lop);
            if (suaSV(lop, maSV, tenSV, ngaysinh, gioitinh,quequan))
            {

                MessageBox.Show("Sua thanh cong", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataview_load();

            }
            else
            {
                MessageBox.Show("Sua that bai", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public static bool xoaSV(string lop, string maSV)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;

            string update = "delete from tblSinhVien where sMaSV = '" + maSV + "'and sMaLop = '" + lop + "'";
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
        private void txt_MaSV_Validating(object sender, CancelEventArgs e)
        {
            string maSV = txt_MaSV.Text;
            if (maSV == "")
            {
                MessageBox.Show("không được để trống Mã sinh viên");
                //txt_MaSV.Focus();
                e.Cancel = true;
            }
                /*rrorProvider1.SetError(txt_MaSV, "Không được để trống họ tên!");
            else errorProvider1.SetError(etxt_MaSV, "");*/


        }

        private void txt_tenSV_Validating(object sender, CancelEventArgs e)
        {
            string tenSV = txt_tenSV.Text;
            if (tenSV == "")
            {
                MessageBox.Show("không được để trống tên sinh viên");
                txt_tenSV.Focus();
                e.Cancel = true;
            }
        }

        private void txt_gt_Validating(object sender, CancelEventArgs e)
        {
            string gioitinh = txt_gt.Text;
            if (gioitinh == "")
            {
                MessageBox.Show("Không được để trống giới tính");
                txt_gt.Focus();
                e.Cancel = true; // Hủy bỏ sự kiện Validating
            }
            else if (gioitinh != "Nam" && gioitinh != "Nữ")
            {
                MessageBox.Show("Giới tính không hợp lệ. Vui lòng nhập 'Nam' hoặc 'Nữ'.");
                txt_gt.Focus();
                e.Cancel = true; // Hủy bỏ sự kiện Validating
            }


        }

        private void txt_quequan_Validating(object sender, CancelEventArgs e)
        {
            string quequan = txt_quequan.Text;
            if (quequan == "")
            {
                MessageBox.Show("không được để trống");
                txt_quequan.Focus();
                e.Cancel = true;
            }
        }

        private void dt_ngaysinh_Validating(object sender, CancelEventArgs e)
        {
            DateTime ngaySinh = dt_ngaysinh.Value;
            DateTime ngayHienTai = DateTime.Now;
            DateTime ngayHieuLuc = ngayHienTai.AddYears(-18); // Ngày hiện tại trừ đi 18 năm

            if (ngaySinh > ngayHieuLuc)
            {
                MessageBox.Show("Ngày sinh phải nhỏ hơn hiện tại ít nhất 18 năm.");
                dt_ngaysinh.Focus();
                e.Cancel = true; // Hủy bỏ sự kiện Validating
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            string lop, maSV;
            lop = cb_lop.SelectedValue.ToString();
            maSV = txt_MaSV.Text;

            //MessageBox.Show(lop);
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này không ??", "Thông báo", MessageBoxButtons.YesNo);
            if (result==DialogResult.Yes)
            {
                xoaSV(lop, maSV);
                MessageBox.Show("Xóa thành công", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataview_load();
            }
            else
            {
                MessageBox.Show("Xóa thất bại", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_QLSV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_QLSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_MaSV.Text = dgv_QLSV.CurrentRow.Cells["Mã SV"].Value.ToString();
            txt_tenSV.Text = dgv_QLSV.CurrentRow.Cells["Tên SV"].Value.ToString();
            txt_gt.Text = dgv_QLSV.CurrentRow.Cells["Giới tính"].Value.ToString();
            txt_quequan.Text = dgv_QLSV.CurrentRow.Cells["Quê quán"].Value.ToString();
            DateTime ngaySinh;
            if (DateTime.TryParse(dgv_QLSV.CurrentRow.Cells["Ngày sinh"].Value.ToString(), out ngaySinh))
            {
                dt_ngaysinh.Value = ngaySinh;
            }
            cb_lop.SelectedValue = dgv_QLSV.CurrentRow.Cells["Tên lớp"].Value.ToString();
        }

        private void search_textbox(string x)
        {
            string sql = "SELECT * FROM tblSinhVien WHERE sMaSV like concat('%','"+x+"','%') or sMaLop like concat('%', '"+x+"','%')";
            string couter = ConfigurationManager.ConnectionStrings["qlsv"].ConnectionString;

            using (SqlConnection cnn = new SqlConnection(couter))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter ad = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("tb_SinhVien");
                        ad.Fill(tb);
                        if (tb.Rows.Count > 0)
                        {
                            dgv_QLSV.DataSource = tb;

                        }
                        else
                            MessageBox.Show("Không tìm thấy");
                           
                    }
                }
            }
        }
        private void txt_timkiem_TextChanged(object sender, EventArgs e)
        {
             
            search_textbox(txt_timkiem.Text);

        }

        private void btn_inbaoCao_Click(object sender, EventArgs e)
        {
            if (cb_inbaocao.SelectedIndex == 0)
            {
                DSSVtheoMon f = new DSSVtheoMon();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (cb_inbaocao.SelectedIndex == 1)
            {
                if (!string.IsNullOrEmpty(txt_MaSV.Text))
                {
                    KetQuaHocTap f = new KetQuaHocTap();
                    f.MaSV = txt_MaSV.Text;
                    this.Hide();
                    f.ShowDialog();
                    this.Show();


                }
                else
                {
                    MessageBox.Show("Mã sinh viên để trống\n Không thể xem!!!",
                        "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //throw new Exception("Bạn lựa chọn chưa chính xác");
                MessageBox.Show("Lựa chọn chưa chính xác để xem", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
            

        private void cb_lop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb_inbaocao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
