using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cua_hang_maytinh
{
    public partial class HD_NH : Form
    {
        public HD_NH()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection();
        private void Form1_Load(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-KMNS09Q;Initial Catalog=CH_Ban_MayTinh;Integrated Security=True";

            con.ConnectionString = connectionString;
            con.Open();
            loaddatatoGridview();
        } 
        private void loaddatatoGridview()
        {
           try
           {
                string sql = "Select * From Hoa_don_nhap";

                SqlDataAdapter adp = new SqlDataAdapter(sql, con);

                DataTable tableHoa_don_nhap = new DataTable();

                adp.Fill(tableHoa_don_nhap);

                dataGridViewHDN.AutoGenerateColumns = false;
                dataGridViewHDN.DataSource = tableHoa_don_nhap;
                dataGridViewHDN.Refresh();
           } 
           catch(SqlException)
           {
                MessageBox.Show("error");
           }
        }

        private void dataGridViewHDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa_HDN.Text = dataGridViewHDN.CurrentRow.Cells["Ma_HDN"].Value.ToString();
            dtpNgay_nhap.Text = dataGridViewHDN.CurrentRow.Cells["Ngay_nhap"].Value.ToString();
            txtMa_NV.Text = dataGridViewHDN.CurrentRow.Cells["Ma_NV"].Value.ToString();
            txtMa_NCC.Text = dataGridViewHDN.CurrentRow.Cells["Ma_NCC"].Value.ToString();
            txtTong_tien_nhap.Text = dataGridViewHDN.CurrentRow.Cells["Tong_tien_nhap"].Value.ToString();

            txtMa_HDN.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa_HDN.Text = "";
            dtpNgay_nhap.Text= "";
            txtMa_NV.Text = "";
            txtMa_NCC.Text = "";
            txtTong_tien_nhap.Text = "";
            txtMa_HDN.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            btnThoat.Enabled = false;
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
 
            if (txtMa_HDN.Text == "")
            {
                MessageBox.Show("Ban can nhap ma Hoa don nhap hang", "Thong báo");
                txtMa_HDN.Focus();
                return;
            }
            if (dtpNgay_nhap.Text == "")
            {
                MessageBox.Show("Ban can nhap ngay nhap hang"," Thông báo");
                dtpNgay_nhap.Focus();
            }
            if (txtMa_NV.Text == "")
            {
                MessageBox.Show("Ban can nhap Ma NV nhap hang","Thông báo");
                txtMa_NV.Focus();
            }
            else
            {
                string sql = "Insert into Hoa_don_nhap values ('" + txtMa_HDN.Text + "','" + dtpNgay_nhap.Text + "','" + txtMa_NV.Text + "','"+txtMa_NCC.Text+"'";
                //if (txtMa_NCC.Text != "")
                //    sql = sql + "," + txtMa_NCC.Text.Trim();
                if (txtTong_tien_nhap.Text != "")
                    sql = sql + "," + txtTong_tien_nhap.Text.Trim();
                sql = sql + ")";

                try
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    loaddatatoGridview();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                txtMa_HDN.Text = "";
                dtpNgay_nhap.Text = "";
                txtMa_NV.Text = "";
                txtMa_NCC.Text = "";
                txtTong_tien_nhap.Text = "";
                //txtMa_HDN.Enabled = true;
                btnLuu.Enabled = false;
                btnHuy.Enabled = false;
                btnSua.Enabled = true;
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnThoat.Enabled = true;
                return;
            }
            
        }
  
    private void txtTong_tien_nhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) ||
                (Convert.ToInt32(e.KeyChar) == 8) ||
                (Convert.ToInt32(e.KeyChar) == 13))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                string sql = " Delete From Hoa_don_nhap Where Ma_HDN = '" + dataGridViewHDN.CurrentRow.Cells["Ma_HDN"].Value.ToString() + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                loaddatatoGridview();
            }    
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            btnThem.Enabled = false;
            txtMa_HDN.Text = "";
            dtpNgay_nhap.Text = "";
            txtMa_NV.Text = "";
            txtMa_NCC.Text = "";
            txtTong_tien_nhap.Text = "";
            //txtMa_HDN.Enabled = true;
            btnLuu.Enabled = false;
            //btnHuy.Enabled = false;
            btnSua.Enabled = false;
            
            btnXoa.Enabled = true;
            btnThoat.Enabled = true;
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
