namespace QuanLyLoaiPhong
{
    partial class FormLoaiPhong
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
            lblTitle = new Label();
            lblMaLoai = new Label();
            txtMaLoai = new TextBox();
            lblTenLoai = new Label();
            txtTenLoai = new TextBox();
            lblGiaMoiDem = new Label();
            nudGiaMoiDem = new NumericUpDown();
            lblMoTa = new Label();
            txtMoTa = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvLoaiPhong = new DataGridView();
            colMaLoai = new DataGridViewTextBoxColumn();
            colTenLoai = new DataGridViewTextBoxColumn();
            colGiaMoiDem = new DataGridViewTextBoxColumn();
            colMoTa = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudGiaMoiDem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkSlateBlue;
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(225, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản Lý Loại Phòng";
            // 
            // lblMaLoai
            // 
            lblMaLoai.AutoSize = true;
            lblMaLoai.Location = new Point(25, 65);
            lblMaLoai.Name = "lblMaLoai";
            lblMaLoai.Size = new Size(62, 20);
            lblMaLoai.TabIndex = 1;
            lblMaLoai.Text = "Mã loại:";
            // 
            // txtMaLoai
            // 
            txtMaLoai.Location = new Point(120, 62);
            txtMaLoai.Name = "txtMaLoai";
            txtMaLoai.ReadOnly = true;
            txtMaLoai.Size = new Size(180, 27);
            txtMaLoai.TabIndex = 2;
            // 
            // lblTenLoai
            // 
            lblTenLoai.AutoSize = true;
            lblTenLoai.Location = new Point(25, 105);
            lblTenLoai.Name = "lblTenLoai";
            lblTenLoai.Size = new Size(66, 20);
            lblTenLoai.TabIndex = 3;
            lblTenLoai.Text = "Tên loại:";
            // 
            // txtTenLoai
            // 
            txtTenLoai.Location = new Point(120, 102);
            txtTenLoai.Name = "txtTenLoai";
            txtTenLoai.Size = new Size(180, 27);
            txtTenLoai.TabIndex = 4;
            // 
            // lblGiaMoiDem
            // 
            lblGiaMoiDem.AutoSize = true;
            lblGiaMoiDem.Location = new Point(330, 65);
            lblGiaMoiDem.Name = "lblGiaMoiDem";
            lblGiaMoiDem.Size = new Size(71, 20);
            lblGiaMoiDem.TabIndex = 5;
            lblGiaMoiDem.Text = "Giá/đêm:";
            // 
            // nudGiaMoiDem
            // 
            nudGiaMoiDem.DecimalPlaces = 0;
            nudGiaMoiDem.Increment = new decimal(new int[] { 5000, 0, 0, 0 });
            nudGiaMoiDem.Location = new Point(415, 62);
            nudGiaMoiDem.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudGiaMoiDem.Name = "nudGiaMoiDem";
            nudGiaMoiDem.Size = new Size(200, 27);
            nudGiaMoiDem.TabIndex = 6;
            nudGiaMoiDem.ThousandsSeparator = true;
            // 
            // lblMoTa
            // 
            lblMoTa.AutoSize = true;
            lblMoTa.Location = new Point(330, 105);
            lblMoTa.Name = "lblMoTa";
            lblMoTa.Size = new Size(51, 20);
            lblMoTa.TabIndex = 7;
            lblMoTa.Text = "Mô tả:";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(415, 102);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(260, 27);
            txtMoTa.TabIndex = 8;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(25, 150);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(85, 32);
            btnThem.TabIndex = 9;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(125, 150);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(85, 32);
            btnSua.TabIndex = 10;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(225, 150);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(85, 32);
            btnXoa.TabIndex = 11;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(325, 150);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(85, 32);
            btnLamMoi.TabIndex = 12;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvLoaiPhong
            // 
            dgvLoaiPhong.AllowUserToAddRows = false;
            dgvLoaiPhong.AllowUserToDeleteRows = false;
            dgvLoaiPhong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvLoaiPhong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLoaiPhong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoaiPhong.Columns.AddRange(new DataGridViewColumn[] { colMaLoai, colTenLoai, colGiaMoiDem, colMoTa });
            dgvLoaiPhong.Location = new Point(25, 195);
            dgvLoaiPhong.MultiSelect = false;
            dgvLoaiPhong.Name = "dgvLoaiPhong";
            dgvLoaiPhong.ReadOnly = true;
            dgvLoaiPhong.RowHeadersWidth = 51;
            dgvLoaiPhong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLoaiPhong.Size = new Size(650, 240);
            dgvLoaiPhong.TabIndex = 13;
            dgvLoaiPhong.CellClick += dgvLoaiPhong_CellClick;
            // 
            // colMaLoai
            // 
            colMaLoai.DataPropertyName = "MaLoai";
            colMaLoai.FillWeight = 50F;
            colMaLoai.HeaderText = "Mã loại";
            colMaLoai.MinimumWidth = 6;
            colMaLoai.Name = "colMaLoai";
            colMaLoai.ReadOnly = true;
            // 
            // colTenLoai
            // 
            colTenLoai.DataPropertyName = "TenLoai";
            colTenLoai.FillWeight = 100F;
            colTenLoai.HeaderText = "Tên loại phòng";
            colTenLoai.MinimumWidth = 6;
            colTenLoai.Name = "colTenLoai";
            colTenLoai.ReadOnly = true;
            // 
            // colGiaMoiDem
            // 
            colGiaMoiDem.DataPropertyName = "GiaMoiDem";
            colGiaMoiDem.FillWeight = 80F;
            colGiaMoiDem.HeaderText = "Giá / đêm";
            colGiaMoiDem.MinimumWidth = 6;
            colGiaMoiDem.Name = "colGiaMoiDem";
            colGiaMoiDem.ReadOnly = true;
            // 
            // colMoTa
            // 
            colMoTa.DataPropertyName = "MoTa";
            colMoTa.FillWeight = 120F;
            colMoTa.HeaderText = "Mô tả";
            colMoTa.MinimumWidth = 6;
            colMoTa.Name = "colMoTa";
            colMoTa.ReadOnly = true;
            // 
            // FormLoaiPhong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 455);
            Controls.Add(dgvLoaiPhong);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtMoTa);
            Controls.Add(lblMoTa);
            Controls.Add(nudGiaMoiDem);
            Controls.Add(lblGiaMoiDem);
            Controls.Add(txtTenLoai);
            Controls.Add(lblTenLoai);
            Controls.Add(txtMaLoai);
            Controls.Add(lblMaLoai);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormLoaiPhong";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Quản Lý Loại Phòng";
            Load += FormLoaiPhong_Load;
            ((System.ComponentModel.ISupportInitialize)nudGiaMoiDem).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvLoaiPhong).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private Label lblTitle;
        private Label lblMaLoai;
        private TextBox txtMaLoai;
        private Label lblTenLoai;
        private TextBox txtTenLoai;
        private Label lblGiaMoiDem;
        private NumericUpDown nudGiaMoiDem;
        private Label lblMoTa;
        private TextBox txtMoTa;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dgvLoaiPhong;
        private DataGridViewTextBoxColumn colMaLoai;
        private DataGridViewTextBoxColumn colTenLoai;
        private DataGridViewTextBoxColumn colGiaMoiDem;
        private DataGridViewTextBoxColumn colMoTa;
    }
}
