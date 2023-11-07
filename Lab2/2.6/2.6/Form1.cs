using System.Data.SqlClient;
namespace _2._6
{
    public partial class frmQLSV : Form
    {
        string strCon = @"Data Source=DESKTOP-V8JTTMC\MSSQLSERVER01;Initial Catalog=QLSV;Integrated Security=True";
        SqlConnection sqlCon = null;
        string mssv = null;
        public frmQLSV()
        {
            InitializeComponent();
        }

        private void frmQLSV_Load(object sender, EventArgs e)
        {
            Connect();
            if (chkXemDS.Checked) HienThiTatCaSinhVien();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT DISTINCT MALOP FROM SINHVIEN";
            cmd.Connection = sqlCon;

            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string maLop = reader.GetString(0);
                cboMALOP.Items.Add(maLop);
            }
            reader.Close();
        }
        private void Connect()
        {
            if (sqlCon == null)
                sqlCon = new SqlConnection(strCon);
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
        }
        private void HienThiTatCaSinhVien()
        {
            Connect();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "SELECT *FROM SINHVIEN";
            sqlCmd.Connection = sqlCon;

            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string mahv = reader.GetString(0);
                string malop = reader.GetString(1);
                string hoten = reader.GetString(2);
                DateTime ngsinh = reader.GetDateTime(3);
                string ngaysinh = ngsinh.ToShortDateString();
                string gioitinh = reader.GetString(4);
                string noisinh = (reader.IsDBNull(5)) ? "null" : reader.GetString(5);
                string diachi = (reader.IsDBNull(6)) ? "null" : reader.GetString(6);
                string sdt = (reader.IsDBNull(7)) ? "null" : reader.GetString(7);

                ListViewItem lvi = new ListViewItem(mahv);
                lvi.SubItems.Add(malop);
                lvi.SubItems.Add(hoten);
                lvi.SubItems.Add(ngaysinh);
                lvi.SubItems.Add(gioitinh);
                lvi.SubItems.Add(noisinh);
                lvi.SubItems.Add(diachi);
                lvi.SubItems.Add(sdt);

                lsvDSSV.Items.Add(lvi);
            }
            reader.Close();
        }
        private void HienThiSinhVienTheoML(string ml)
        {
            Connect();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            sqlCmd.CommandText = "SELECT *FROM SINHVIEN WHERE MALOP = '" + ml +"'";
            sqlCmd.Connection = sqlCon;
            lsvDSSV.Items.Clear();
            
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string mahv = reader.GetString(0);
                string malop = reader.GetString(1);
                string hoten = reader.GetString(2);
                DateTime ngsinh = reader.GetDateTime(3);
                string ngaysinh = ngsinh.ToShortDateString();
                string gioitinh = reader.GetString(4);
                string noisinh = (reader.IsDBNull(5)) ? "null" : reader.GetString(5);
                string diachi = (reader.IsDBNull(6)) ? "null" : reader.GetString(6);
                string sdt = (reader.IsDBNull(7)) ? "null" : reader.GetString(7);

                ListViewItem lvi = new ListViewItem(mahv);
                lvi.SubItems.Add(malop);
                lvi.SubItems.Add(hoten);
                lvi.SubItems.Add(ngaysinh);
                lvi.SubItems.Add(gioitinh);
                lvi.SubItems.Add(noisinh);
                lvi.SubItems.Add(diachi);
                lvi.SubItems.Add(sdt);

                lsvDSSV.Items.Add(lvi);
            }
            reader.Close();
        }

        private void chkXemDS_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkXemDS.Checked) lsvDSSV.Items.Clear();
            else
            {
                if (cboMALOP.SelectedIndex == -1)
                    HienThiTatCaSinhVien();
                else
                    HienThiSinhVienTheoML(cboMALOP.SelectedItem.ToString());
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát khỏi chương trình ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                Close();
        }

        private void cboMALOP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMALOP.SelectedIndex != -1 && chkXemDS.Checked)
                HienThiSinhVienTheoML(cboMALOP.SelectedItem.ToString());
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (mssv == null) mssv = txtMAHV.Text;
            if (mssv == null)
                MessageBox.Show("Chưa chọn sinh viên cần xóa !");
            else
            {
                Connect();
                SqlCommand sqlCmd = new SqlCommand();
                sqlCmd.CommandType = System.Data.CommandType.Text;
                sqlCmd.CommandText = "DELETE FROM SINHVIEN WHERE MAHV = '" + mssv + "'";
                sqlCmd.Connection = sqlCon;

                int result = sqlCmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Xóa dữ liệu thành công !");
                    if (chkXemDS.Checked)
                        HienThiTatCaSinhVien();
                }
                else
                    MessageBox.Show("Xóa không thành công !");
            }
        }

        private void lsvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvDSSV.SelectedItems.Count == 0) return;
            ListViewItem lvi = lsvDSSV.SelectedItems[0];
            mssv = lvi.SubItems[0].Text;
        }


    }
}