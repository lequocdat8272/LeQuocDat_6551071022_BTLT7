namespace QuanLyLichKhamBenh
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            lblTenBenhNhan = new Label();
            txtTenBenhNhan = new TextBox();
            lblSDT = new Label();
            txtSDT = new TextBox();
            lblNgayKham = new Label();
            dtpNgayKham = new DateTimePicker();
            lblGioKham = new Label();
            dtpGioKham = new DateTimePicker();
            lblBacSi = new Label();
            cboBacSi = new ComboBox();
            lblTrangThai = new Label();
            cboTrangThai = new ComboBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            lblTuNgay = new Label();
            dtpTuNgay = new DateTimePicker();
            lblDenNgay = new Label();
            dtpDenNgay = new DateTimePicker();
            cboLocBacSi = new ComboBox();
            btnTimKiem = new Button();
            btnDiDen = new Button();
            dgvLichKham = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).BeginInit();
            SuspendLayout();
            // 
            // lblTenBenhNhan
            // 
            lblTenBenhNhan.AutoSize = true;
            lblTenBenhNhan.Font = new Font("Segoe UI", 9.5F);
            lblTenBenhNhan.Location = new Point(18, 22);
            lblTenBenhNhan.Name = "lblTenBenhNhan";
            lblTenBenhNhan.Size = new Size(111, 21);
            lblTenBenhNhan.TabIndex = 0;
            lblTenBenhNhan.Text = "Tên bệnh nhân";
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Font = new Font("Segoe UI", 9.5F);
            txtTenBenhNhan.Location = new Point(135, 18);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(210, 29);
            txtTenBenhNhan.TabIndex = 1;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Font = new Font("Segoe UI", 9.5F);
            lblSDT.Location = new Point(18, 62);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(101, 21);
            lblSDT.TabIndex = 2;
            lblSDT.Text = "Số điện thoại";
            // 
            // txtSDT
            // 
            txtSDT.Font = new Font("Segoe UI", 9.5F);
            txtSDT.Location = new Point(135, 58);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(210, 29);
            txtSDT.TabIndex = 3;
            // 
            // lblNgayKham
            // 
            lblNgayKham.AutoSize = true;
            lblNgayKham.Font = new Font("Segoe UI", 9.5F);
            lblNgayKham.Location = new Point(18, 102);
            lblNgayKham.Name = "lblNgayKham";
            lblNgayKham.Size = new Size(90, 21);
            lblNgayKham.TabIndex = 4;
            lblNgayKham.Text = "Ngày khám";
            // 
            // dtpNgayKham
            // 
            dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            dtpNgayKham.Font = new Font("Segoe UI", 9.5F);
            dtpNgayKham.Format = DateTimePickerFormat.Short;
            dtpNgayKham.Location = new Point(135, 98);
            dtpNgayKham.Name = "dtpNgayKham";
            dtpNgayKham.Size = new Size(210, 29);
            dtpNgayKham.TabIndex = 5;
            // 
            // lblGioKham
            // 
            lblGioKham.AutoSize = true;
            lblGioKham.Font = new Font("Segoe UI", 9.5F);
            lblGioKham.Location = new Point(365, 62);
            lblGioKham.Name = "lblGioKham";
            lblGioKham.Size = new Size(77, 21);
            lblGioKham.TabIndex = 6;
            lblGioKham.Text = "Giờ khám";
            // 
            // dtpGioKham
            // 
            dtpGioKham.CustomFormat = "HH:mm";
            dtpGioKham.Font = new Font("Segoe UI", 9.5F);
            dtpGioKham.Format = DateTimePickerFormat.Custom;
            dtpGioKham.Location = new Point(365, 98);
            dtpGioKham.Name = "dtpGioKham";
            dtpGioKham.ShowUpDown = true;
            dtpGioKham.Size = new Size(130, 29);
            dtpGioKham.TabIndex = 7;
            // 
            // lblBacSi
            // 
            lblBacSi.AutoSize = true;
            lblBacSi.Font = new Font("Segoe UI", 9.5F);
            lblBacSi.Location = new Point(515, 62);
            lblBacSi.Name = "lblBacSi";
            lblBacSi.Size = new Size(50, 21);
            lblBacSi.TabIndex = 8;
            lblBacSi.Text = "Bác sĩ";
            // 
            // cboBacSi
            // 
            cboBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboBacSi.Font = new Font("Segoe UI", 9.5F);
            cboBacSi.FormattingEnabled = true;
            cboBacSi.Location = new Point(515, 98);
            cboBacSi.Name = "cboBacSi";
            cboBacSi.Size = new Size(320, 29);
            cboBacSi.TabIndex = 9;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Segoe UI", 9.5F);
            lblTrangThai.Location = new Point(855, 62);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(79, 21);
            lblTrangThai.TabIndex = 10;
            lblTrangThai.Text = "Trạng thái";
            // 
            // cboTrangThai
            // 
            cboTrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTrangThai.Font = new Font("Segoe UI", 9.5F);
            cboTrangThai.FormattingEnabled = true;
            cboTrangThai.Items.AddRange(new object[] { "Chờ khám", "Đã khám", "Đã hủy" });
            cboTrangThai.Location = new Point(855, 98);
            cboTrangThai.Name = "cboTrangThai";
            cboTrangThai.Size = new Size(205, 29);
            cboTrangThai.TabIndex = 11;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9.5F);
            btnThem.Location = new Point(765, 18);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(70, 32);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9.5F);
            btnSua.Location = new Point(843, 18);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(70, 32);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9.5F);
            btnXoa.Location = new Point(921, 18);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(70, 32);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 9.5F);
            btnLamMoi.Location = new Point(999, 18);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(80, 32);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // lblTuNgay
            // 
            lblTuNgay.AutoSize = true;
            lblTuNgay.Font = new Font("Segoe UI", 9.5F);
            lblTuNgay.Location = new Point(18, 150);
            lblTuNgay.Name = "lblTuNgay";
            lblTuNgay.Size = new Size(66, 21);
            lblTuNgay.TabIndex = 16;
            lblTuNgay.Text = "Từ ngày";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.CustomFormat = "dd/MM/yyyy";
            dtpTuNgay.Font = new Font("Segoe UI", 9.5F);
            dtpTuNgay.Format = DateTimePickerFormat.Short;
            dtpTuNgay.Location = new Point(88, 146);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(130, 29);
            dtpTuNgay.TabIndex = 17;
            // 
            // lblDenNgay
            // 
            lblDenNgay.AutoSize = true;
            lblDenNgay.Font = new Font("Segoe UI", 9.5F);
            lblDenNgay.Location = new Point(232, 150);
            lblDenNgay.Name = "lblDenNgay";
            lblDenNgay.Size = new Size(76, 21);
            lblDenNgay.TabIndex = 18;
            lblDenNgay.Text = "Đến ngày";
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.CustomFormat = "dd/MM/yyyy";
            dtpDenNgay.Font = new Font("Segoe UI", 9.5F);
            dtpDenNgay.Format = DateTimePickerFormat.Short;
            dtpDenNgay.Location = new Point(312, 146);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(130, 29);
            dtpDenNgay.TabIndex = 19;
            // 
            // cboLocBacSi
            // 
            cboLocBacSi.DropDownStyle = ComboBoxStyle.DropDownList;
            cboLocBacSi.Font = new Font("Segoe UI", 9.5F);
            cboLocBacSi.FormattingEnabled = true;
            cboLocBacSi.Location = new Point(460, 146);
            cboLocBacSi.Name = "cboLocBacSi";
            cboLocBacSi.Size = new Size(300, 29);
            cboLocBacSi.TabIndex = 20;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Font = new Font("Segoe UI", 9.5F);
            btnTimKiem.Location = new Point(775, 145);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(95, 31);
            btnTimKiem.TabIndex = 21;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // btnDiDen
            // 
            btnDiDen.Font = new Font("Segoe UI", 9.5F);
            btnDiDen.Location = new Point(995, 145);
            btnDiDen.Name = "btnDiDen";
            btnDiDen.Size = new Size(84, 31);
            btnDiDen.TabIndex = 22;
            btnDiDen.Text = "Đi Đến";
            btnDiDen.UseVisualStyleBackColor = true;
            btnDiDen.Click += btnDiDen_Click;
            // 
            // dgvLichKham
            // 
            dgvLichKham.AllowUserToAddRows = false;
            dgvLichKham.AllowUserToDeleteRows = false;
            dgvLichKham.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLichKham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichKham.BackgroundColor = SystemColors.Window;
            dgvLichKham.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichKham.Location = new Point(18, 192);
            dgvLichKham.MultiSelect = false;
            dgvLichKham.Name = "dgvLichKham";
            dgvLichKham.ReadOnly = true;
            dgvLichKham.RowHeadersWidth = 30;
            dgvLichKham.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLichKham.Size = new Size(1061, 375);
            dgvLichKham.TabIndex = 23;
            dgvLichKham.CellClick += dgvLichKham_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 580);
            Controls.Add(dgvLichKham);
            Controls.Add(btnDiDen);
            Controls.Add(btnTimKiem);
            Controls.Add(cboLocBacSi);
            Controls.Add(dtpDenNgay);
            Controls.Add(lblDenNgay);
            Controls.Add(dtpTuNgay);
            Controls.Add(lblTuNgay);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(cboTrangThai);
            Controls.Add(lblTrangThai);
            Controls.Add(cboBacSi);
            Controls.Add(lblBacSi);
            Controls.Add(dtpGioKham);
            Controls.Add(lblGioKham);
            Controls.Add(dtpNgayKham);
            Controls.Add(lblNgayKham);
            Controls.Add(txtSDT);
            Controls.Add(lblSDT);
            Controls.Add(txtTenBenhNhan);
            Controls.Add(lblTenBenhNhan);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Lịch Khám Bệnh - An Khang Clinic";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLichKham).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTenBenhNhan;
        private TextBox txtTenBenhNhan;
        private Label lblSDT;
        private TextBox txtSDT;
        private Label lblNgayKham;
        private DateTimePicker dtpNgayKham;
        private Label lblGioKham;
        private DateTimePicker dtpGioKham;
        private Label lblBacSi;
        private ComboBox cboBacSi;
        private Label lblTrangThai;
        private ComboBox cboTrangThai;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private Label lblTuNgay;
        private DateTimePicker dtpTuNgay;
        private Label lblDenNgay;
        private DateTimePicker dtpDenNgay;
        private ComboBox cboLocBacSi;
        private Button btnTimKiem;
        private Button btnDiDen;
        private DataGridView dgvLichKham;
    }
}
