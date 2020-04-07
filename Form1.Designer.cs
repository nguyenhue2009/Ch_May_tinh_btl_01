namespace Cua_hang_maytinh
{
    partial class HD_NH
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtMa_HDN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMa_NCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTong_tien_nhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMa_NV = new System.Windows.Forms.TextBox();
            this.dataGridViewHDN = new System.Windows.Forms.DataGridView();
            this.Ma_HDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngay_nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma_NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tong_tien_nhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.dtpNgay_nhap = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMa_HDN
            // 
            this.txtMa_HDN.Location = new System.Drawing.Point(137, 38);
            this.txtMa_HDN.Name = "txtMa_HDN";
            this.txtMa_HDN.Size = new System.Drawing.Size(100, 20);
            this.txtMa_HDN.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã HDN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mã NCC";
            // 
            // txtMa_NCC
            // 
            this.txtMa_NCC.Location = new System.Drawing.Point(137, 125);
            this.txtMa_NCC.Name = "txtMa_NCC";
            this.txtMa_NCC.Size = new System.Drawing.Size(100, 20);
            this.txtMa_NCC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(313, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng tiền nhập";
            this.label3.UseMnemonic = false;
            // 
            // txtTong_tien_nhap
            // 
            this.txtTong_tien_nhap.Location = new System.Drawing.Point(433, 81);
            this.txtTong_tien_nhap.Name = "txtTong_tien_nhap";
            this.txtTong_tien_nhap.Size = new System.Drawing.Size(100, 20);
            this.txtTong_tien_nhap.TabIndex = 4;
            this.txtTong_tien_nhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTong_tien_nhap_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mã NV";
            // 
            // txtMa_NV
            // 
            this.txtMa_NV.Location = new System.Drawing.Point(137, 79);
            this.txtMa_NV.Name = "txtMa_NV";
            this.txtMa_NV.Size = new System.Drawing.Size(100, 20);
            this.txtMa_NV.TabIndex = 8;
            // 
            // dataGridViewHDN
            // 
            this.dataGridViewHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_HDN,
            this.Ngay_nhap,
            this.Ma_NV,
            this.Ma_NCC,
            this.Tong_tien_nhap});
            this.dataGridViewHDN.Location = new System.Drawing.Point(12, 172);
            this.dataGridViewHDN.Name = "dataGridViewHDN";
            this.dataGridViewHDN.Size = new System.Drawing.Size(573, 184);
            this.dataGridViewHDN.TabIndex = 10;
            this.dataGridViewHDN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHDN_CellContentClick);
            // 
            // Ma_HDN
            // 
            this.Ma_HDN.DataPropertyName = "Ma_HDN";
            this.Ma_HDN.FillWeight = 30F;
            this.Ma_HDN.HeaderText = "Mã HĐN";
            this.Ma_HDN.Name = "Ma_HDN";
            // 
            // Ngay_nhap
            // 
            this.Ngay_nhap.DataPropertyName = "Ngay_nhap";
            this.Ngay_nhap.HeaderText = "Ngày nhập";
            this.Ngay_nhap.Name = "Ngay_nhap";
            // 
            // Ma_NV
            // 
            this.Ma_NV.DataPropertyName = "Ma_NV";
            this.Ma_NV.HeaderText = "Mã Nhân viên";
            this.Ma_NV.Name = "Ma_NV";
            // 
            // Ma_NCC
            // 
            this.Ma_NCC.DataPropertyName = "Ma_NCC";
            this.Ma_NCC.HeaderText = "Mã Nhà cung cấp";
            this.Ma_NCC.Name = "Ma_NCC";
            this.Ma_NCC.Width = 120;
            // 
            // Tong_tien_nhap
            // 
            this.Tong_tien_nhap.DataPropertyName = "Tong_tien_nhap";
            this.Tong_tien_nhap.HeaderText = "Tổng tiền nhập";
            this.Tong_tien_nhap.Name = "Tong_tien_nhap";
            this.Tong_tien_nhap.Width = 110;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThem.Location = new System.Drawing.Point(12, 374);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(99, 31);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm mới";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnSua.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSua.Location = new System.Drawing.Point(137, 374);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 12;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThoat.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnThoat.Location = new System.Drawing.Point(558, 374);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 31);
            this.btnThoat.TabIndex = 13;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnHuy.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuy.Location = new System.Drawing.Point(458, 374);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 31);
            this.btnHuy.TabIndex = 14;
            this.btnHuy.Text = "Hủy bỏ";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoa.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnXoa.Location = new System.Drawing.Point(350, 374);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLuu.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLuu.Location = new System.Drawing.Point(239, 374);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 31);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // dtpNgay_nhap
            // 
            this.dtpNgay_nhap.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgay_nhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgay_nhap.Location = new System.Drawing.Point(433, 36);
            this.dtpNgay_nhap.Name = "dtpNgay_nhap";
            this.dtpNgay_nhap.Size = new System.Drawing.Size(79, 22);
            this.dtpNgay_nhap.TabIndex = 17;
            this.dtpNgay_nhap.Value = new System.DateTime(2020, 4, 7, 0, 0, 0, 0);
            // 
            // HD_NH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.dtpNgay_nhap);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridViewHDN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtMa_NV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTong_tien_nhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMa_NCC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMa_HDN);
            this.Name = "HD_NH";
            this.Text = "Hóa đơn nhập hàng";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMa_HDN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMa_NCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTong_tien_nhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMa_NV;
        private System.Windows.Forms.DataGridView dataGridViewHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngay_nhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma_NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tong_tien_nhap;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.DateTimePicker dtpNgay_nhap;
    }
}

