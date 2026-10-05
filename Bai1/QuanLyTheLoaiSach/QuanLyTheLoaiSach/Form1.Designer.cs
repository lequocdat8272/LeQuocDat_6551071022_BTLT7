namespace QuanLyTheLoaiSach
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitleMaTL = new System.Windows.Forms.Label();
            this.txtMaTL = new System.Windows.Forms.TextBox();
            this.lblTitleTenTL = new System.Windows.Forms.Label();
            this.txtTenTheLoai = new System.Windows.Forms.TextBox();
            this.lblTitleMoTa = new System.Windows.Forms.Label();
            this.txtMoTa = new System.Windows.Forms.TextBox();
            this.lblTitleNgayTao = new System.Windows.Forms.Label();
            this.lblNgayTao = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvTheLoai = new System.Windows.Forms.DataGridView();
            this.colMaTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenTL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleMaTL
            // 
            this.lblTitleMaTL.AutoSize = true;
            this.lblTitleMaTL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleMaTL.Location = new System.Drawing.Point(18, 25);
            this.lblTitleMaTL.Name = "lblTitleMaTL";
            this.lblTitleMaTL.Size = new System.Drawing.Size(77, 17);
            this.lblTitleMaTL.TabIndex = 0;
            this.lblTitleMaTL.Text = "Mã thể loại";
            // 
            // txtMaTL
            // 
            this.txtMaTL.BackColor = System.Drawing.Color.White;
            this.txtMaTL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaTL.Location = new System.Drawing.Point(115, 22);
            this.txtMaTL.Name = "txtMaTL";
            this.txtMaTL.PlaceholderText = "ReadOnly";
            this.txtMaTL.ReadOnly = true;
            this.txtMaTL.Size = new System.Drawing.Size(260, 25);
            this.txtMaTL.TabIndex = 1;
            // 
            // lblTitleTenTL
            // 
            this.lblTitleTenTL.AutoSize = true;
            this.lblTitleTenTL.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleTenTL.Location = new System.Drawing.Point(18, 59);
            this.lblTitleTenTL.Name = "lblTitleTenTL";
            this.lblTitleTenTL.Size = new System.Drawing.Size(76, 17);
            this.lblTitleTenTL.TabIndex = 2;
            this.lblTitleTenTL.Text = "Tên thể loại";
            // 
            // txtTenTheLoai
            // 
            this.txtTenTheLoai.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTenTheLoai.Location = new System.Drawing.Point(115, 56);
            this.txtTenTheLoai.Name = "txtTenTheLoai";
            this.txtTenTheLoai.Size = new System.Drawing.Size(260, 25);
            this.txtTenTheLoai.TabIndex = 3;
            // 
            // lblTitleMoTa
            // 
            this.lblTitleMoTa.AutoSize = true;
            this.lblTitleMoTa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitleMoTa.Location = new System.Drawing.Point(18, 93);
            this.lblTitleMoTa.Name = "lblTitleMoTa";
            this.lblTitleMoTa.Size = new System.Drawing.Size(43, 17);
            this.lblTitleMoTa.TabIndex = 4;
            this.lblTitleMoTa.Text = "Mô tả";
            // 
            // txtMoTa
            // 
            this.txtMoTa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoTa.Location = new System.Drawing.Point(115, 93);
            this.txtMoTa.Multiline = true;
            this.txtMoTa.Name = "txtMoTa";
            this.txtMoTa.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMoTa.Size = new System.Drawing.Size(260, 68);
            this.txtMoTa.TabIndex = 5;
            // 
            // lblTitleNgayTao
            // 
            this.lblTitleNgayTao.AutoSize = true;
            this.lblTitleNgayTao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblTitleNgayTao.ForeColor = System.Drawing.Color.Gray;
            this.lblTitleNgayTao.Location = new System.Drawing.Point(18, 169);
            this.lblTitleNgayTao.Name = "lblTitleNgayTao";
            this.lblTitleNgayTao.Size = new System.Drawing.Size(58, 15);
            this.lblTitleNgayTao.TabIndex = 6;
            this.lblTitleNgayTao.Text = "Ngày tạo:";
            // 
            // lblNgayTao
            // 
            this.lblNgayTao.AutoSize = true;
            this.lblNgayTao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgayTao.ForeColor = System.Drawing.Color.Navy;
            this.lblNgayTao.Location = new System.Drawing.Point(115, 169);
            this.lblNgayTao.Name = "lblNgayTao";
            this.lblNgayTao.Size = new System.Drawing.Size(24, 15);
            this.lblNgayTao.TabIndex = 7;
            this.lblNgayTao.Text = "---";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnThem.Location = new System.Drawing.Point(530, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(85, 30);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSua.Location = new System.Drawing.Point(625, 20);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(85, 30);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.Location = new System.Drawing.Point(720, 20);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(85, 30);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLamMoi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLamMoi.Location = new System.Drawing.Point(815, 20);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(85, 30);
            this.btnLamMoi.TabIndex = 11;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTimKiem.Location = new System.Drawing.Point(18, 198);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.PlaceholderText = "Nhập tên thể loại cần tìm...";
            this.txtTimKiem.Size = new System.Drawing.Size(357, 25);
            this.txtTimKiem.TabIndex = 12;
            this.txtTimKiem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyDown);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.White;
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTimKiem.Location = new System.Drawing.Point(385, 196);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(120, 28);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvTheLoai
            // 
            this.dgvTheLoai.AllowUserToAddRows = false;
            this.dgvTheLoai.AllowUserToDeleteRows = false;
            this.dgvTheLoai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTheLoai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTheLoai.BackgroundColor = System.Drawing.Color.White;
            this.dgvTheLoai.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTheLoai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTheLoai.ColumnHeadersHeight = 32;
            this.dgvTheLoai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaTL,
            this.colTenTL,
            this.colMoTa,
            this.colSoLuong,
            this.colNgayTao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTheLoai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTheLoai.EnableHeadersVisualStyles = true;
            this.dgvTheLoai.Location = new System.Drawing.Point(18, 235);
            this.dgvTheLoai.MultiSelect = false;
            this.dgvTheLoai.Name = "dgvTheLoai";
            this.dgvTheLoai.ReadOnly = true;
            this.dgvTheLoai.RowHeadersWidth = 35;
            this.dgvTheLoai.RowTemplate.Height = 28;
            this.dgvTheLoai.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTheLoai.Size = new System.Drawing.Size(882, 280);
            this.dgvTheLoai.TabIndex = 14;
            this.dgvTheLoai.SelectionChanged += new System.EventHandler(this.dgvTheLoai_SelectionChanged);
            // 
            // colMaTL
            // 
            this.colMaTL.DataPropertyName = "MaTl";
            this.colMaTL.FillWeight = 40F;
            this.colMaTL.HeaderText = "Mã TL";
            this.colMaTL.MinimumWidth = 60;
            this.colMaTL.Name = "colMaTL";
            this.colMaTL.ReadOnly = true;
            // 
            // colTenTL
            // 
            this.colTenTL.DataPropertyName = "TenTheLoai";
            this.colTenTL.FillWeight = 85F;
            this.colTenTL.HeaderText = "Tên thể loại";
            this.colTenTL.MinimumWidth = 120;
            this.colTenTL.Name = "colTenTL";
            this.colTenTL.ReadOnly = true;
            // 
            // colMoTa
            // 
            this.colMoTa.DataPropertyName = "MoTa";
            this.colMoTa.FillWeight = 130F;
            this.colMoTa.HeaderText = "Mô tả";
            this.colMoTa.MinimumWidth = 150;
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.ReadOnly = true;
            // 
            // colSoLuong
            // 
            this.colSoLuong.DataPropertyName = "SoLuongSach";
            this.colSoLuong.FillWeight = 60F;
            this.colSoLuong.HeaderText = "Số lượng sách";
            this.colSoLuong.MinimumWidth = 80;
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.ReadOnly = true;
            // 
            // colNgayTao
            // 
            this.colNgayTao.DataPropertyName = "NgayTao";
            this.colNgayTao.FillWeight = 85F;
            this.colNgayTao.HeaderText = "Ngày tạo";
            this.colNgayTao.MinimumWidth = 120;
            this.colNgayTao.Name = "colNgayTao";
            this.colNgayTao.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(918, 527);
            this.Controls.Add(this.dgvTheLoai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblNgayTao);
            this.Controls.Add(this.lblTitleNgayTao);
            this.Controls.Add(this.txtMoTa);
            this.Controls.Add(this.lblTitleMoTa);
            this.Controls.Add(this.txtTenTheLoai);
            this.Controls.Add(this.lblTitleTenTL);
            this.Controls.Add(this.txtMaTL);
            this.Controls.Add(this.lblTitleMaTL);
            this.MinimumSize = new System.Drawing.Size(900, 500);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Thể Loại Sách - Tri Thức Books";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleMaTL;
        private System.Windows.Forms.TextBox txtMaTL;
        private System.Windows.Forms.Label lblTitleTenTL;
        private System.Windows.Forms.TextBox txtTenTheLoai;
        private System.Windows.Forms.Label lblTitleMoTa;
        private System.Windows.Forms.TextBox txtMoTa;
        private System.Windows.Forms.Label lblTitleNgayTao;
        private System.Windows.Forms.Label lblNgayTao;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvTheLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenTL;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgayTao;
    }
}
