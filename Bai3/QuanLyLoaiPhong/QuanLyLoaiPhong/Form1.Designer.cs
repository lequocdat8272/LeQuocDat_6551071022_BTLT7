namespace QuanLyLoaiPhong
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblSoPhong = new Label();
            txtSoPhong = new TextBox();
            lblTangSo = new Label();
            nudTangSo = new NumericUpDown();
            lblLoaiPhong = new Label();
            cboLoaiPhong = new ComboBox();
            lblTinhTrang = new Label();
            cboTinhTrang = new ComboBox();
            picHinhAnh = new PictureBox();
            btnChonAnh = new Button();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            btnQLLoaiPhong = new Button();
            cboLocLoaiPhong = new ComboBox();
            cboLocTinhTrang = new ComboBox();
            btnTimKiem = new Button();
            dgvPhong = new DataGridView();
            colMaPhong = new DataGridViewTextBoxColumn();
            colHinhAnh = new DataGridViewImageColumn();
            colSoPhong = new DataGridViewTextBoxColumn();
            colTangSo = new DataGridViewTextBoxColumn();
            colTenLoai = new DataGridViewTextBoxColumn();
            colGiaMoiDem = new DataGridViewTextBoxColumn();
            colTinhTrang = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudTangSo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).BeginInit();
            SuspendLayout();
            // 
            // lblSoPhong
            // 
            lblSoPhong.AutoSize = true;
            lblSoPhong.Location = new Point(15, 20);
            lblSoPhong.Name = "lblSoPhong";
            lblSoPhong.Size = new Size(74, 20);
            lblSoPhong.TabIndex = 0;
            lblSoPhong.Text = "Số phòng";
            // 
            // txtSoPhong
            // 
            txtSoPhong.Location = new Point(15, 48);
            txtSoPhong.Name = "txtSoPhong";
            txtSoPhong.Size = new Size(125, 27);
            txtSoPhong.TabIndex = 1;
            // 
            // lblTangSo
            // 
            lblTangSo.AutoSize = true;
            lblTangSo.Location = new Point(155, 20);
            lblTangSo.Name = "lblTangSo";
            lblTangSo.Size = new Size(61, 20);
            lblTangSo.TabIndex = 2;
            lblTangSo.Text = "Tầng số";
            // 
            // nudTangSo
            // 
            nudTangSo.Location = new Point(155, 48);
            nudTangSo.Maximum = new decimal(new int[] { 100, 0, 0, 0 });
            nudTangSo.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTangSo.Name = "nudTangSo";
            nudTangSo.Size = new Size(95, 27);
            nudTangSo.TabIndex = 3;
            nudTangSo.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblLoaiPhong
            // 
            lblLoaiPhong.AutoSize = true;
            lblLoaiPhong.Location = new Point(270, 20);
            lblLoaiPhong.Name = "lblLoaiPhong";
            lblLoaiPhong.Size = new Size(84, 20);
            lblLoaiPhong.TabIndex = 4;
            lblLoaiPhong.Text = "Loại phòng";
            // 
            // cboLoaiPhong
            // 
            cboLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLoaiPhong.FormattingEnabled = true;
            cboLoaiPhong.Location = new Point(270, 48);
            cboLoaiPhong.Name = "cboLoaiPhong";
            cboLoaiPhong.Size = new Size(125, 28);
            cboLoaiPhong.TabIndex = 5;
            // 
            // lblTinhTrang
            // 
            lblTinhTrang.AutoSize = true;
            lblTinhTrang.Location = new Point(415, 20);
            lblTinhTrang.Name = "lblTinhTrang";
            lblTinhTrang.Size = new Size(76, 20);
            lblTinhTrang.TabIndex = 6;
            lblTinhTrang.Text = "Tình trạng";
            // 
            // cboTinhTrang
            // 
            cboTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTinhTrang.FormattingEnabled = true;
            cboTinhTrang.Items.AddRange(new object[] { "Trống", "Đang ở", "Đang dọn" });
            cboTinhTrang.Location = new Point(415, 48);
            cboTinhTrang.Name = "cboTinhTrang";
            cboTinhTrang.Size = new Size(120, 28);
            cboTinhTrang.TabIndex = 7;
            // 
            // picHinhAnh
            // 
            picHinhAnh.BorderStyle = BorderStyle.FixedSingle;
            picHinhAnh.Location = new Point(555, 12);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(95, 68);
            picHinhAnh.SizeMode = PictureBoxSizeMode.Zoom;
            picHinhAnh.TabIndex = 8;
            picHinhAnh.TabStop = false;
            // 
            // btnChonAnh
            // 
            btnChonAnh.Location = new Point(555, 84);
            btnChonAnh.Name = "btnChonAnh";
            btnChonAnh.Size = new Size(95, 28);
            btnChonAnh.TabIndex = 9;
            btnChonAnh.Text = "Chọn ảnh...";
            btnChonAnh.UseVisualStyleBackColor = true;
            btnChonAnh.Click += btnChonAnh_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(690, 25);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(70, 32);
            btnThem.TabIndex = 10;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(768, 25);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(70, 32);
            btnSua.TabIndex = 11;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(846, 25);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 32);
            btnXoa.TabIndex = 12;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(924, 25);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(75, 32);
            btnLamMoi.TabIndex = 13;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnQLLoaiPhong
            // 
            btnQLLoaiPhong.Location = new Point(846, 75);
            btnQLLoaiPhong.Name = "btnQLLoaiPhong";
            btnQLLoaiPhong.Size = new Size(153, 32);
            btnQLLoaiPhong.TabIndex = 14;
            btnQLLoaiPhong.Text = "QL Loại phòng...";
            btnQLLoaiPhong.UseVisualStyleBackColor = true;
            btnQLLoaiPhong.Click += btnQLLoaiPhong_Click;
            // 
            // cboLocLoaiPhong
            // 
            cboLocLoaiPhong.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocLoaiPhong.FormattingEnabled = true;
            cboLocLoaiPhong.Location = new Point(15, 125);
            cboLocLoaiPhong.Name = "cboLocLoaiPhong";
            cboLocLoaiPhong.Size = new Size(200, 28);
            cboLocLoaiPhong.TabIndex = 15;
            // 
            // cboLocTinhTrang
            // 
            cboLocTinhTrang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocTinhTrang.FormattingEnabled = true;
            cboLocTinhTrang.Location = new Point(225, 125);
            cboLocTinhTrang.Name = "cboLocTinhTrang";
            cboLocTinhTrang.Size = new Size(200, 28);
            cboLocTinhTrang.TabIndex = 16;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(435, 123);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(95, 32);
            btnTimKiem.TabIndex = 17;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvPhong
            // 
            dgvPhong.AllowUserToAddRows = false;
            dgvPhong.AllowUserToDeleteRows = false;
            dgvPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPhong.BackgroundColor = SystemColors.Window;
            dgvPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPhong.Columns.AddRange(new DataGridViewColumn[] { colMaPhong, colHinhAnh, colSoPhong, colTangSo, colTenLoai, colGiaMoiDem, colTinhTrang });
            dgvPhong.Location = new Point(15, 165);
            dgvPhong.MultiSelect = false;
            dgvPhong.Name = "dgvPhong";
            dgvPhong.ReadOnly = true;
            dgvPhong.RowHeadersWidth = 30;
            dgvPhong.RowTemplate.Height = 55;
            dgvPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPhong.Size = new Size(985, 360);
            dgvPhong.TabIndex = 18;
            dgvPhong.CellClick += dgvPhong_CellClick;
            // 
            // colMaPhong
            // 
            colMaPhong.DataPropertyName = "MaPhong";
            colMaPhong.FillWeight = 55F;
            colMaPhong.HeaderText = "Mã phòng";
            colMaPhong.MinimumWidth = 6;
            colMaPhong.Name = "colMaPhong";
            colMaPhong.ReadOnly = true;
            // 
            // colHinhAnh
            // 
            colHinhAnh.DataPropertyName = "HinhAnhThumb";
            colHinhAnh.FillWeight = 65F;
            colHinhAnh.HeaderText = "Ảnh";
            colHinhAnh.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colHinhAnh.MinimumWidth = 6;
            colHinhAnh.Name = "colHinhAnh";
            colHinhAnh.ReadOnly = true;
            // 
            // colSoPhong
            // 
            colSoPhong.DataPropertyName = "SoPhong";
            colSoPhong.FillWeight = 75F;
            colSoPhong.HeaderText = "Số phòng";
            colSoPhong.MinimumWidth = 6;
            colSoPhong.Name = "colSoPhong";
            colSoPhong.ReadOnly = true;
            // 
            // colTangSo
            // 
            colTangSo.DataPropertyName = "TangSo";
            colTangSo.FillWeight = 60F;
            colTangSo.HeaderText = "Tầng";
            colTangSo.MinimumWidth = 6;
            colTangSo.Name = "colTangSo";
            colTangSo.ReadOnly = true;
            // 
            // colTenLoai
            // 
            colTenLoai.DataPropertyName = "TenLoai";
            colTenLoai.FillWeight = 110F;
            colTenLoai.HeaderText = "Loại phòng";
            colTenLoai.MinimumWidth = 6;
            colTenLoai.Name = "colTenLoai";
            colTenLoai.ReadOnly = true;
            // 
            // colGiaMoiDem
            // 
            colGiaMoiDem.DataPropertyName = "GiaMoiDemFormat";
            colGiaMoiDem.FillWeight = 90F;
            colGiaMoiDem.HeaderText = "Giá/đêm";
            colGiaMoiDem.MinimumWidth = 6;
            colGiaMoiDem.Name = "colGiaMoiDem";
            colGiaMoiDem.ReadOnly = true;
            // 
            // colTinhTrang
            // 
            colTinhTrang.DataPropertyName = "TinhTrang";
            colTinhTrang.FillWeight = 90F;
            colTinhTrang.HeaderText = "Tình trạng";
            colTinhTrang.MinimumWidth = 6;
            colTinhTrang.Name = "colTinhTrang";
            colTinhTrang.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 540);
            Controls.Add(dgvPhong);
            Controls.Add(btnTimKiem);
            Controls.Add(cboLocTinhTrang);
            Controls.Add(cboLocLoaiPhong);
            Controls.Add(btnQLLoaiPhong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(btnChonAnh);
            Controls.Add(picHinhAnh);
            Controls.Add(cboTinhTrang);
            Controls.Add(lblTinhTrang);
            Controls.Add(cboLoaiPhong);
            Controls.Add(lblLoaiPhong);
            Controls.Add(nudTangSo);
            Controls.Add(lblTangSo);
            Controls.Add(txtSoPhong);
            Controls.Add(lblSoPhong);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Phòng - Sunrise Homestay";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudTangSo).EndInit();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblSoPhong;
        private TextBox txtSoPhong;
        private Label lblTangSo;
        private NumericUpDown nudTangSo;
        private Label lblLoaiPhong;
        private ComboBox cboLoaiPhong;
        private Label lblTinhTrang;
        private ComboBox cboTinhTrang;
        private PictureBox picHinhAnh;
        private Button btnChonAnh;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Button btnQLLoaiPhong;
        private ComboBox cboLocLoaiPhong;
        private ComboBox cboLocTinhTrang;
        private Button btnTimKiem;
        private DataGridView dgvPhong;
        private DataGridViewTextBoxColumn colMaPhong;
        private DataGridViewImageColumn colHinhAnh;
        private DataGridViewTextBoxColumn colSoPhong;
        private DataGridViewTextBoxColumn colTangSo;
        private DataGridViewTextBoxColumn colTenLoai;
        private DataGridViewTextBoxColumn colGiaMoiDem;
        private DataGridViewTextBoxColumn colTinhTrang;
    }
}
