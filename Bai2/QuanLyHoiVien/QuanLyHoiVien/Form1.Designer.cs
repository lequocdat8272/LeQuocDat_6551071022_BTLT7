namespace QuanLyHoiVien
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHoTen = new Label();
            lblSDT = new Label();
            lblEmail = new Label();
            lblNgaySinh = new Label();
            lblHangThanhVien = new Label();
            txtHoTen = new TextBox();
            txtSDT = new TextBox();
            txtEmail = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            cboHangThanhVien = new ComboBox();
            chkTrangThai = new CheckBox();
            grpGioiTinh = new GroupBox();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            txtTimKiem = new TextBox();
            lblTimHang = new Label();
            cboTimHang = new ComboBox();
            btnTimKiem = new Button();
            dgvHoiVien = new DataGridView();
            grpGioiTinh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoiVien).BeginInit();
            SuspendLayout();
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(20, 25);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(54, 19);
            lblHoTen.TabIndex = 0;
            lblHoTen.Text = "Họ tên";
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(20, 60);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(89, 19);
            lblSDT.TabIndex = 1;
            lblSDT.Text = "Số điện thoại";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(20, 95);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(41, 19);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(20, 130);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(70, 19);
            lblNgaySinh.TabIndex = 3;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblHangThanhVien
            // 
            lblHangThanhVien.AutoSize = true;
            lblHangThanhVien.Location = new Point(20, 165);
            lblHangThanhVien.Name = "lblHangThanhVien";
            lblHangThanhVien.Size = new Size(111, 19);
            lblHangThanhVien.TabIndex = 4;
            lblHangThanhVien.Text = "Hạng thành viên";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(140, 22);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(180, 26);
            txtHoTen.TabIndex = 5;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(140, 57);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(180, 26);
            txtSDT.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(140, 92);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(180, 26);
            txtEmail.TabIndex = 7;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.Location = new Point(140, 127);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(180, 26);
            dtpNgaySinh.TabIndex = 8;
            // 
            // cboHangThanhVien
            // 
            cboHangThanhVien.DropDownStyle = ComboBoxStyle.DropDownList;
            cboHangThanhVien.FormattingEnabled = true;
            cboHangThanhVien.Items.AddRange(new object[] { "Basic", "VIP", "Premium" });
            cboHangThanhVien.Location = new Point(140, 162);
            cboHangThanhVien.Name = "cboHangThanhVien";
            cboHangThanhVien.Size = new Size(180, 27);
            cboHangThanhVien.TabIndex = 9;
            // 
            // chkTrangThai
            // 
            chkTrangThai.AutoSize = true;
            chkTrangThai.Checked = true;
            chkTrangThai.CheckState = CheckState.Checked;
            chkTrangThai.Location = new Point(20, 205);
            chkTrangThai.Name = "chkTrangThai";
            chkTrangThai.Size = new Size(123, 23);
            chkTrangThai.TabIndex = 10;
            chkTrangThai.Text = "Đang hoạt động";
            chkTrangThai.UseVisualStyleBackColor = true;
            // 
            // grpGioiTinh
            // 
            grpGioiTinh.Controls.Add(rdoNu);
            grpGioiTinh.Controls.Add(rdoNam);
            grpGioiTinh.Location = new Point(350, 15);
            grpGioiTinh.Name = "grpGioiTinh";
            grpGioiTinh.Size = new Size(200, 60);
            grpGioiTinh.TabIndex = 11;
            grpGioiTinh.TabStop = false;
            grpGioiTinh.Text = "Giới tính";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(115, 25);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(47, 23);
            rdoNu.TabIndex = 1;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Checked = true;
            rdoNam.Location = new Point(25, 25);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(58, 23);
            rdoNam.TabIndex = 0;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(620, 18);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(140, 32);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(620, 56);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(140, 32);
            btnSua.TabIndex = 13;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(620, 94);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(140, 32);
            btnXoa.TabIndex = 14;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(620, 132);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(140, 32);
            btnLamMoi.TabIndex = 15;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Location = new Point(20, 245);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập họ tên cần tìm...";
            txtTimKiem.Size = new Size(290, 26);
            txtTimKiem.TabIndex = 16;
            // 
            // lblTimHang
            // 
            lblTimHang.AutoSize = true;
            lblTimHang.Location = new Point(320, 248);
            lblTimHang.Name = "lblTimHang";
            lblTimHang.Size = new Size(111, 19);
            lblTimHang.TabIndex = 17;
            lblTimHang.Text = "Hạng thành viên";
            // 
            // cboTimHang
            // 
            cboTimHang.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTimHang.FormattingEnabled = true;
            cboTimHang.Items.AddRange(new object[] { "Tất cả", "Basic", "VIP", "Premium" });
            cboTimHang.Location = new Point(435, 245);
            cboTimHang.Name = "cboTimHang";
            cboTimHang.Size = new Size(135, 27);
            cboTimHang.TabIndex = 18;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Location = new Point(620, 241);
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(140, 32);
            btnTimKiem.TabIndex = 19;
            btnTimKiem.Text = "Tìm kiếm";
            btnTimKiem.UseVisualStyleBackColor = true;
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // dgvHoiVien
            // 
            dgvHoiVien.AllowUserToAddRows = false;
            dgvHoiVien.AllowUserToDeleteRows = false;
            dgvHoiVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHoiVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHoiVien.Location = new Point(20, 285);
            dgvHoiVien.MultiSelect = false;
            dgvHoiVien.Name = "dgvHoiVien";
            dgvHoiVien.ReadOnly = true;
            dgvHoiVien.RowHeadersWidth = 30;
            dgvHoiVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHoiVien.Size = new Size(740, 240);
            dgvHoiVien.TabIndex = 20;
            dgvHoiVien.CellClick += dgvHoiVien_CellClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 541);
            Controls.Add(dgvHoiVien);
            Controls.Add(btnTimKiem);
            Controls.Add(cboTimHang);
            Controls.Add(lblTimHang);
            Controls.Add(txtTimKiem);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(grpGioiTinh);
            Controls.Add(chkTrangThai);
            Controls.Add(cboHangThanhVien);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtEmail);
            Controls.Add(txtSDT);
            Controls.Add(txtHoTen);
            Controls.Add(lblHangThanhVien);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblEmail);
            Controls.Add(lblSDT);
            Controls.Add(lblHoTen);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Hội Viên Phòng Gym FitZone";
            Load += Form1_Load;
            grpGioiTinh.ResumeLayout(false);
            grpGioiTinh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHoiVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHoTen;
        private Label lblSDT;
        private Label lblEmail;
        private Label lblNgaySinh;
        private Label lblHangThanhVien;
        private TextBox txtHoTen;
        private TextBox txtSDT;
        private TextBox txtEmail;
        private DateTimePicker dtpNgaySinh;
        private ComboBox cboHangThanhVien;
        private CheckBox chkTrangThai;
        private GroupBox grpGioiTinh;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private TextBox txtTimKiem;
        private Label lblTimHang;
        private ComboBox cboTimHang;
        private Button btnTimKiem;
        private DataGridView dgvHoiVien;
    }
}
