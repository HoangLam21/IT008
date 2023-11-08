using System.Data.SqlClient;
namespace _2._6
{
    public partial class frmQLSV : Form
    {
        string strCon = @"Data Source=MSI\SQLEXPRESS;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True";
        SqlConnection sqlCon = null;
        string mssv = null;
        public frmQLSV()
        {
            InitializeComponent();
            lsvDSSV.ItemSelectionChanged += lsvDSSV_ItemSelectionChanged;
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

        private void lsvDSSV_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                ListViewItem selectedRow = e.Item;
                txtMAHV.Text = selectedRow.SubItems[0].Text;
                cboMALOP.SelectedItem = selectedRow.SubItems[1].Text;
                txtHOTEN.Text = selectedRow.SubItems[2].Text;
                dtpNgSinh.Text = selectedRow.SubItems[3].Text;
                txtGIOITINH.Text = selectedRow.SubItems[4].Text;
                txtNOISINH.Text = selectedRow.SubItems[5].Text;
                txtDIACHI.Text = selectedRow.SubItems[6].Text;
                txtSDT.Text = selectedRow.SubItems[7].Text;
                //txtMAHV.ReadOnly = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Connect();
            SqlCommand sqlCmd;
            sqlCmd = new SqlCommand();
            sqlCmd.CommandType = System.Data.CommandType.Text;
            DateTime nsinh = dtpNgSinh.Value;
            sqlCmd.CommandText = "INSERT INTO SINHVIEN VALUES ('" + txtMAHV.Text + "','" + cboMALOP.SelectedItem + "',N'" + txtHOTEN.Text + "','" + nsinh + "',N'" + txtGIOITINH.Text + "',N'" + txtNOISINH.Text + "',N'" + txtDIACHI.Text + "','" + txtSDT.Text + "')";
            sqlCmd.Connection = sqlCon;

            int result = sqlCmd.ExecuteNonQuery();
            if (result > 0)
            {
                MessageBox.Show("Đã thêm sinh viên thành công!");
                if (chkXemDS.Checked)
                {
                    HienThiTatCaSinhVien();
                }
            }
            else
            {
                MessageBox.Show("Thêm sinh viên không thành công!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (lsvDSSV.SelectedItems[0].Text != txtMAHV.Text)
                MessageBox.Show("Không được sửa MSSV");
            else
            {
                Connect();
                SqlCommand sqlCmd;
                sqlCmd = new SqlCommand();
                sqlCmd.CommandType = System.Data.CommandType.Text;
                DateTime nsinh = dtpNgSinh.Value;
                sqlCmd.CommandText = "UPDATE SINHVIEN SET  MAHV='" + txtMAHV.Text + "',MALOP='" + cboMALOP.SelectedItem + "',HOTEN=N'" + txtHOTEN.Text + "',NGSINH='" + nsinh + "',GIOITINH=N'" + txtGIOITINH.Text + "',NOISINH=N'" + txtNOISINH.Text + "',DIACHI=N'" + txtDIACHI.Text + "',SDT='" + txtSDT.Text + "'WHERE MAHV =  '" + txtMAHV.Text + "'";
                sqlCmd.Connection = sqlCon;

                int result = sqlCmd.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Sửa sinh viên thành công!");
                    if (chkXemDS.Checked)
                    {
                        HienThiTatCaSinhVien();

                    }
                }

                else
                {
                    MessageBox.Show("Sửa sinh viên không thành công!");
                }
            }
        }
    }

}