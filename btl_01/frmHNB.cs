using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace QlyCHVT
{
    public partial class frmHNB : Form
    {
        public frmHNB()
        {
            InitializeComponent();
        }


        private void frmHNB_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            txtMa_HDB.ReadOnly = false;
            txtMaNV.ReadOnly = false;
            txtMaKH.ReadOnly = false;
            txtTen_mayVT.ReadOnly = false;
            txtMa_mayVT.ReadOnly = false;
    
            txtThanh_tien.ReadOnly = false;
            txtTong_tien.ReadOnly = false;
            txtTong_tien.Text = "0";
            
        }

        private void dataGridView_HDB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa_HDB.Text = dataGridView_HDB.CurrentRow.Cells["MaHDN"].Value.ToString();
            txtMa_mayVT.Text = dataGridView_HDB.CurrentRow.Cells["MaMayVT"].Value.ToString();
            txtSo_luong.Text = dataGridView_HDB.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtTen_mayVT.Text = dataGridView_HDB.CurrentRow.Cells["TenMayVT"].Value.ToString();
            txtThanh_tien.Text = dataGridView_HDB.CurrentRow.Cells["ThanhTien"].Value.ToString();

            txtMa_HDB.Enabled = false;
            txtMa_mayVT.Enabled = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa_HDB.Text = "";
            txtMaNV.Text = "";
            txtMaKH.Text = "";
            dtpNgayban.Text = "";
            txtSo_luong.Text = "";
            txtTen_mayVT.Text = "";
            txtThanh_tien.Text = "";
            txtMa_mayVT.Text = "";
            txtMa_HDB.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnDong.Enabled = true;
        }
        private void ResetValues()
        {
            txtMa_HDB.Text = "";
            dtpNgayban.Text = DateTime.Now.ToShortDateString();
            txtMaNV.Text = "";
            txtMaKH.Text = "";
            txtTong_tien.Text = "0";
            txtSo_luong.Text = "";
            txtTen_mayVT.Text = "";
          
        }
        private void TxtSoluong_TextChanged(object sender, EventArgs e)
        {
            double sl ;
            if (txtSo_luong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSo_luong.Text);
        
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT Ma_HDB, So_luong, Ma_mayVT FROM tblChitietHDB WHERE Ma_HDB = N'" + txtMa_HDB.Text + "'";
                DataTable tbl = ThucthiSQL.DocBang(sql);
                sql = "DELETE tblHDB WHERE Ma_HDB = N'" + txtMa_HDB.Text + "'";
                ThucthiSQL.CapNhatDuLieu(sql);
                ResetValues();
                Hienthi_Luoi();
                // cập nhật lại số lượng máy tính 
                for (int i = 0; i < tbl.Rows.Count; i++)
                    DelUpdateSo_luongMVT(tbl.Rows[i][0].ToString(),
                    Convert.ToDouble(tbl.Rows[0][1]),
                    Convert.ToDouble(tbl.Rows[0][2]));
                btnHuy.Enabled = false;

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtpNgayban.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayban.Focus();
                return;
            }
            if (txtMa_HDB.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Hóa Đơn nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa_HDB.Focus();
                return;
            }
            if (txtMaKH.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaKH.Focus();
                return;
            }
            if (txtMaNV.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập Mã Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }

            sql = "INSERT INTO tblHDB(Ma_HDB,MaNV,MaKH,Ngayban,Tong_tien) VALUES(N'" + txtMa_HDB.Text.Trim() + "',N'" + txtMaNV.Text + "',N'" + txtMaKH.Text + "',N'" + dtpNgayban.Value.ToShortDateString() + "'," + txtTong_tien.Text + ")";
            ThucthiSQL.CapNhatDuLieu(sql);
            btnLuu.Enabled = false;

            // Lưu thông tin của các mặt hàng
            if (txtMa_mayVT.Text.Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã máy vi tính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa_mayVT.Focus();
                return;
            }


            if ((txtSo_luong.Text.Length == 0) || (txtSo_luong.Text == "0"))
            {
                MessageBox.Show("Bạn phải nhập số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSo_luong.Text = "";
                txtSo_luong.Focus();
                return;
            }
           

            sql = "SELECT Ma_mayVT FROM tblChitietHDB WHERE Ma_mayVT=N'" + txtMa_mayVT.Text +
                 "' AND Ma_HDB = N'" + txtMa_HDB.Text.Trim() + "'";
            if (ThucthiSQL.DocBang(sql).Rows.Count > 0)
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
                txtMa_mayVT.Focus();
                return;
            }

            sql = "INSERT INTO tblChitietHDN(Ma_HDN,Ma_mayVT,TenNL,So_luong,Don_gia,Thanh_tien) VALUES(N'" + txtMa_HDB.Text.Trim() + "','" + txtMa_mayVT.Text.ToString() + "',N'" + txtSo_luong.Text.ToString() + "'," + txtSo_luong.Text +"," + txtThanh_tien.Text + ")";
            ThucthiSQL.CapNhatDuLieu(sql);
            Hienthi_Luoi();

           
            //Cập nhập số lượng mới vào bảng nguyên liệu theo công thức
            //Slg mới= Slg trong bảng dboMay_vi_tinh - Slg đang nhập trên frmChitietHDB
            double sl = Convert.ToDouble(ThucthiSQL.DocBang("SELECT So_luong FROM dboMay_vi_tinh WHERE Ma_mayVT=N'" +
                txtMa_mayVT.Text + "'").Rows[0][0].ToString());
            double slmoi = sl - Convert.ToDouble(txtSo_luong.Text);
            sql = "UPDATE dboMay_vi_tinh SET So_luong=" + slmoi + "WHERE Ma_mayVT=N'" + txtMa_mayVT.Text + "'";
            ThucthiSQL.CapNhatDuLieu(sql);

        }
        private void Hienthi_Luoi()
        {
            string sql;
            sql = "SELECT a.Ma_HDN,b.Ma_mayVT, b.Ten_mayVT, a.So_luong,a.Thanh_tien FROM tblChitietHDB as a, dboMay_vi_tinh as b WHERE a.Ma_HDB = N'" +
                txtMa_HDB.Text + "'AND a.Ma_mayVT=b.Ma_mayVT";
            dataGridView_HDB.DataSource = ThucthiSQL.DocBang(sql);
            dataGridView_HDB.Columns[0].HeaderText = "Mã HDN";
            dataGridView_HDB.Columns[1].HeaderText = "Mã MVT";
            dataGridView_HDB.Columns[3].HeaderText = "Tên MVT";
            dataGridView_HDB.Columns[2].HeaderText = "Số lượng ";
            dataGridView_HDB.Columns[4].HeaderText = "Thành tiền";
            dataGridView_HDB.Columns[0].Width = 100;
            dataGridView_HDB.Columns[1].Width = 100;
            dataGridView_HDB.Columns[2].Width = 100;
            dataGridView_HDB.Columns[3].Width = 100;
            dataGridView_HDB.Columns[4].Width = 100;
            dataGridView_HDB.AllowUserToAddRows = false;
            dataGridView_HDB.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void DelUpdateSo_luongMVT(string ma_mayVTxoa, double slxoa, double giabanxoa)
        {
            //Cập nhập số lượng nguyên liệu vào bảng nguyên liệu theo công thức
            //Slmoi= slg trong bảng nguyên liệu - slg đã bị xóa
            double sl = Convert.ToDouble(ThucthiSQL.DocBang("SELECT So_luong FROM dboMay_vi_tinh WHERE Ma_mayVT=N'" + ma_mayVTxoa + "'").Rows[0][0].ToString());
            double slmoi = sl - slxoa;
            string sql = "UPDATE dboMay_vi_tinh SET So_luong=" + slmoi + "WHERE Ma_mayVT=N'" + ma_mayVTxoa + "'";
            ThucthiSQL.CapNhatDuLieu(sql);
           
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
