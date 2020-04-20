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
    public partial class frmHDN : Form
    {
        public frmHDN()
        {
            InitializeComponent();
        }

        private void frmHDN_Load(object sender, EventArgs e)
        {
            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
            txtMaNV.ReadOnly = false;
            txtMa_HDN.ReadOnly = false;
            txtMaNCC.ReadOnly = false;
            dtpNgay_nhap.Text = "";
            txtSo_luong.ReadOnly = false;
            txtDon_gia.ReadOnly = false;
            txtTong_tien.ReadOnly = false;
            txtTong_tien.Text = "";
            txtThanh_tien.ReadOnly = false;
        }

        private void dataGridView_HDN_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtMa_HDN.Text = dataGridView_HDN.CurrentRow.Cells["MaHDN"].Value.ToString();
            txtMa_mayVT.Text = dataGridView_HDN.CurrentRow.Cells["MaMayVT"].Value.ToString();
            txtSo_luong.Text = dataGridView_HDN.CurrentRow.Cells["SoLuong"].Value.ToString();
            txtDon_gia.Text = dataGridView_HDN.CurrentRow.Cells["DonGia"].Value.ToString();
            txtThanh_tien.Text = dataGridView_HDN.CurrentRow.Cells["ThanhTien"].Value.ToString();

            txtMa_HDN.Enabled = false;
            txtMa_mayVT.Enabled = false;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            txtMa_HDN.Text = "";
            txtMaNV.Text = "";
            txtMaNCC.Text = "";
            dtpNgay_nhap.Text = "";
            txtSo_luong.Text = "";
            txtDon_gia.Text = "";
            txtThanh_tien.Text = "";
            txtMa_HDN.Enabled = true;
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            btnThem.Enabled = false;
            btnDong.Enabled = true;
        }

        private void ResetValues()
        {
            txtMa_HDN.Text = "";
            dtpNgay_nhap.Text = DateTime.Now.ToShortDateString();
            txtMaNV.Text = "";
            txtMaNCC.Text = "";
            txtTong_tien.Text = "0";
            txtSo_luong.Text = "";
            txtDon_gia.Text = "";
            txtThanh_tien.Text = "0";
        }
        private void TxtSoluong_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtSo_luong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSo_luong.Text);
            if (txtDon_gia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDon_gia.Text);
            tt = sl * dg;
            txtThanh_tien.Text = tt.ToString();
        }

        private void TxtDongia_TextChanged(object sender, EventArgs e)
        {
            double tt, sl, dg;
            if (txtSo_luong.Text == "")
                sl = 0;
            else
                sl = Convert.ToDouble(txtSo_luong.Text);
            if (txtDon_gia.Text == "")
                dg = 0;
            else
                dg = Convert.ToDouble(txtDon_gia.Text);
            tt = sl * dg;
            txtThanh_tien.Text = tt.ToString();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (dtpNgay_nhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập ngày nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgay_nhap.Focus();
                return;
            }
            if (txtMa_HDN.Text == "")
            {
                MessageBox.Show("Bạn phải nhập Mã Hóa Đơn nhập hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa_HDN.Focus();
                return;
            }
            if (txtMaNCC.Text == "")
            {
                MessageBox.Show("Bạn phải nhập nhà cung cấp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNCC.Focus();
                return;
            }
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Bạn phải nhập Mã Nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaNV.Focus();
                return;
            }
            else
            {
                sql = "INSERT INTO tblHDN VALUES('" + txtMa_HDN.Text + "','" + dtpNgay_nhap.Text + "','" + txtMaNV.Text + "','" + txtMaNCC.Text + "'";
                if (txtTong_tien.Text != "")
                    sql = sql + "," + txtTong_tien.Text.Trim();
                sql = sql + ")";
                ThucthiSQL.CapNhatDuLieu(sql);
                btnLuu.Enabled = false;
            }    

            sql = "INSERT INTO tblHDN(Ma_HDN, Ngay_nhap, MaNV, MaNCC, Thanh_tien) VALUES(N'" +
            txtMa_HDN.Text + "','" + dtpNgay_nhap.Text + "','" + txtMaNV.Text + "','" + txtMaNCC.Text + "'," + txtTong_tien.Text + ")";
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
            if (txtDon_gia.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập đơn giá", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDon_gia.Text = "";
                txtDon_gia.Focus();
                return;
            }

            sql = "SELECT Ma_mayVT FROM tblChitietHBN WHERE Ma_mayVT=N'" + txtMa_mayVT.Text +
                 "' AND Ma_HDN = N'" + txtMa_HDN.Text.Trim() + "'";
            if (ThucthiSQL.DocBang(sql).Rows.Count > 0)
            {
                MessageBox.Show("Mã hàng này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
                txtMa_mayVT.Focus();
                return;
            }

            sql = "INSERT INTO tblChitietHBN(Ma_HDN, Ma_mayVT, So_luong, Don_gia, Thanh_tien) VALUES(N'" +
          txtMa_HDN.Text.Trim() + "','" + txtMa_mayVT.Text.ToString() + "','" + txtSo_luong.Text.ToString() + "'," + txtDon_gia.Text.ToString() + "," + txtThanh_tien.Text.ToString() + ")";
            ThucthiSQL.CapNhatDuLieu(sql);
            Hienthi_Luoi();

            

            //Cập nhập số lượng mới vào bảng máy vi tính theo công thức
            //Slg mới= Slg trong bảng dbomayvi tính + Slg đang nhập trên frmHoadonnhap
            double sl = Convert.ToDouble(ThucthiSQL.DocBang("SELECT So_luong FROM dboMay_vi_tinh WHERE Ma_mayVT=N'" +
                txtMa_mayVT.Text + "'").Rows[0][0].ToString());
            double slmoi = sl + Convert.ToDouble(txtSo_luong.Text);
            sql = "UPDATE dboMay_vi_tinh SET So_luong=" + slmoi + "WHERE Ma_mayVT=N'" + txtMa_mayVT.Text + "'";
            ThucthiSQL.CapNhatDuLieu(sql);

            //Cập nhập đơn giá nhập mới vào bảng nguyên liệu theo công thức
            //Đơn giá nhập mới= (slg trong bảng tblNguyenlieu * Đơn giá nhập trong tblNguyenlieu + slg đang nhập trên frmHoadonnhap * 
            //Đơn giá nhập trên frmHoadonhap)/(Slg trong bảng nguyên liệu +slg đang nhập trên frmHoadonnhap)
            double dgn = Convert.ToDouble(ThucthiSQL.DocBang("SELECT Dongia FROM tblNguyenlieu WHERE MaNL = N'" +
                txtMa_mayVT.Text + "'").Rows[0][0].ToString());
            double dgnmoi = Math.Round(((sl * dgn) + (Convert.ToDouble(txtSo_luong.Text) * Convert.ToDouble(txtDon_gia.Text))) / (sl + Convert.ToDouble(txtSo_luong.Text)), 2);
            sql = "UPDATE dboMay_vi_tinh SET Gia_nhap =" + dgnmoi + "WHERE Ma_mayVT = N'" + txtMa_mayVT.Text + "'";
            ThucthiSQL.CapNhatDuLieu(sql);
            ResetValues();
            btnHuy.Enabled = true;
 
        }
        private void Hienthi_Luoi()
        {
            string sql;
            sql = "SELECT Ma_HDN,Ma_mayVT,So_luong,Don_gia,Thanh_tien FROM tblChitietHBN WHERE Ma_HDN = N'" +
                txtMa_HDN.Text + "'";
            dataGridView_HDN.DataSource = ThucthiSQL.DocBang(sql);
            dataGridView_HDN.Columns[0].HeaderText = "Mã HDN";
            dataGridView_HDN.Columns[1].HeaderText = "Mã MVT";
            dataGridView_HDN.Columns[2].HeaderText = "Số lượng ";
            dataGridView_HDN.Columns[3].HeaderText = "Đơn giá";
            dataGridView_HDN.Columns[4].HeaderText = "Thành tiền";
            dataGridView_HDN.Columns[0].Width = 100;
            dataGridView_HDN.Columns[1].Width = 100;
            dataGridView_HDN.Columns[2].Width = 100;
            dataGridView_HDN.Columns[3].Width = 100;
            dataGridView_HDN.Columns[4].Width = 100;
            dataGridView_HDN.AllowUserToAddRows = false;
            dataGridView_HDN.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn hủy hóa đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string sql = "SELECT Ma_HDN, So_luong,Don_gia FROM tblChitietHBN WHERE MaHDNhap = N'" + txtMa_HDN.Text + "'";
                DataTable tbl = ThucthiSQL.DocBang(sql);
                sql = "DELETE tblHDN WHERE Ma_HDNp= N'" + txtMa_HDN.Text + "'";
                ThucthiSQL.CapNhatDuLieu(sql);
                ResetValues();
                Hienthi_Luoi();
                // cập nhật lại số lượng máy tính , đgia nhập cho từng nguyên liệu bị xóa
                for (int i = 0; i < tbl.Rows.Count; i++)
                    DelUpdateSo_luongMVT(tbl.Rows[i][0].ToString(),
                    Convert.ToDouble(tbl.Rows[0][1]),
                    Convert.ToDouble(tbl.Rows[0][2]));
                btnHuy.Enabled = false;
                
            }
        }
        private void DelUpdateSo_luongMVT(string ma_mayVTxoa, double slxoa, double gianhapxoa)
        {
            //Cập nhập số lượng nguyên liệu vào bảng nguyên liệu theo công thức
            //Slmoi= slg trong bảng nguyên liệu - slg đã bị xóa
            double sl = Convert.ToDouble(ThucthiSQL.DocBang("SELECT So_luong FROM dboMay_vi_tinh WHERE Ma_mayVT=N'" + ma_mayVTxoa + "'").Rows[0][0].ToString());
            double slmoi = sl - slxoa;
            string sql = "UPDATE dboMay_vi_tinh SET So_luong=" + slmoi + "WHERE Ma_mayVT=N'" + ma_mayVTxoa + "'";
            ThucthiSQL.CapNhatDuLieu(sql);
            //Cập nhập lại đơn giá nhập vào bảng Máy vi tính sau khi xóa máy vi tính trong chi tiết hóa đơn nhập
            //Đơn giá nhập mới=(slg trong bảng nguyên liệu trước khi xóa * Đơn giá nhập trong bảng nguyên liệu trước khi xóa - slg của nguyên 
            //liệu bị xóa * Đơn giá nhập nguyên liệu bị xóa)/Slg trong bảng nguyên liệu sau khi xóa
            double dgn = Convert.ToDouble(ThucthiSQL.DocBang("SELECT Gia_nhap FROM dboMa_vi_tinh WHERE Ma_mayVT=N'" +
                ma_mayVTxoa + "'").Rows[0][0].ToString());
            double dgnmoi = (sl * dgn) - (slxoa * gianhapxoa) / slxoa;
            string sql1 = "UPDATE dboMay_vi_tinh SET Gia_nhap =" + dgnmoi + "WHERE Ma_mayVT=N'" + ma_mayVTxoa + "'";
            ThucthiSQL.CapNhatDuLieu(sql);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
    
}

