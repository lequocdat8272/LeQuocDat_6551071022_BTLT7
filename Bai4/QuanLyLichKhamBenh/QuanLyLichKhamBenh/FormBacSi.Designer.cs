namespace QuanLyLichKhamBenh
{
    partial class FormBacSi
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
            groupBox1 = new GroupBox();
            txtSDT = new TextBox();
            lblSDT = new Label();
            txtChuyenKhoa = new TextBox();
            lblChuyenKhoa = new Label();
            txtHoTen = new TextBox();
            lblHoTen = new Label();
            txtMaBS = new TextBox();
            lblMaBS = new Label();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvBacSi = new DataGridView();
            lblTieuDe = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBacSi).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(lblSDT);
            groupBox1.Controls.Add(txtChuyenKhoa);
            groupBox1.Controls.Add(lblChuyenKhoa);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(lblHoTen);
            groupBox1.Controls.Add(txtMaBS);
            groupBox1.Controls.Add(lblMaBS);
            groupBox1.Font = new Font("Segoe UI", 9.5F);
            groupBox1.Location = new Point(20, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 160);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin Bác sĩ";
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(125, 120);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(395, 29);
            txtSDT.TabIndex = 7;
            // 
            // lblSDT
            // 
            lblSDT.AutoSize = true;
            lblSDT.Location = new Point(15, 123);
            lblSDT.Name = "lblSDT";
            lblSDT.Size = new Size(104, 21);
            lblSDT.TabIndex = 6;
            lblSDT.Text = "Số điện thoại:";
            // 
            // txtChuyenKhoa
            // 
            txtChuyenKhoa.Location = new Point(125, 87);
            txtChuyenKhoa.Name = "txtChuyenKhoa";
            txtChuyenKhoa.Size = new Size(395, 29);
            txtChuyenKhoa.TabIndex = 5;
            // 
            // lblChuyenKhoa
            // 
            lblChuyenKhoa.AutoSize = true;
            lblChuyenKhoa.Location = new Point(15, 90);
            lblChuyenKhoa.Name = "lblChuyenKhoa";
            lblChuyenKhoa.Size = new Size(105, 21);
            lblChuyenKhoa.TabIndex = 4;
            lblChuyenKhoa.Text = "Chuyên khoa:";
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(125, 54);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(395, 29);
            txtHoTen.TabIndex = 3;
            // 
            // lblHoTen
            // 
            lblHoTen.AutoSize = true;
            lblHoTen.Location = new Point(15, 57);
            lblHoTen.Name = "lblHoTen";
            lblHoTen.Size = new Size(59, 21);
            lblHoTen.TabIndex = 2;
            lblHoTen.Text = "Họ tên:";
            // 
            // txtMaBS
            // 
            txtMaBS.Location = new Point(125, 21);
            txtMaBS.Name = "txtMaBS";
            txtMaBS.ReadOnly = true;
            txtMaBS.Size = new Size(150, 29);
            txtMaBS.TabIndex = 1;
            // 
            // lblMaBS
            // 
            lblMaBS.AutoSize = true;
            lblMaBS.Location = new Point(15, 24);
            lblMaBS.Name = "lblMaBS";
            lblMaBS.Size = new Size(81, 21);
            lblMaBS.TabIndex = 0;
            lblMaBS.Text = "Mã bác sĩ:";
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnThem.Location = new Point(580, 65);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(110, 34);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnSua.Location = new Point(580, 105);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(110, 34);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnXoa.Location = new Point(580, 145);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(110, 34);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnLamMoi.Location = new Point(580, 185);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(110, 34);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvBacSi
            // 
            dgvBacSi.AllowUserToAddRows = false;
            dgvBacSi.AllowUserToDeleteRows = false;
            dgvBacSi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBacSi.BackgroundColor = SystemColors.Window;
            dgvBacSi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBacSi.Location = new Point(20, 230);
            dgvBacSi.MultiSelect = false;
            dgvBacSi.Name = "dgvBacSi";
            dgvBacSi.ReadOnly = true;
            dgvBacSi.RowHeadersVisible = false;
            dgvBacSi.RowHeadersWidth = 51;
            dgvBacSi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBacSi.Size = new Size(670, 240);
            dgvBacSi.TabIndex = 5;
            dgvBacSi.CellClick += dgvBacSi_CellClick;
            // 
            // lblTieuDe
            // 
            lblTieuDe.AutoSize = true;
            lblTieuDe.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTieuDe.ForeColor = Color.DarkSlateBlue;
            lblTieuDe.Location = new Point(230, 15);
            lblTieuDe.Name = "lblTieuDe";
            lblTieuDe.Size = new Size(236, 32);
            lblTieuDe.TabIndex = 6;
            lblTieuDe.Text = "QUẢN LÝ BÁC SĨ";
            // 
            // FormBacSi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(710, 485);
            Controls.Add(lblTieuDe);
            Controls.Add(dgvBacSi);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormBacSi";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản Lý Bác Sĩ";
            Load += FormBacSi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBacSi).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox txtSDT;
        private Label lblSDT;
        private TextBox txtChuyenKhoa;
        private Label lblChuyenKhoa;
        private TextBox txtHoTen;
        private Label lblHoTen;
        private TextBox txtMaBS;
        private Label lblMaBS;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvBacSi;
        private Label lblTieuDe;
    }
}
