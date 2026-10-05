using Microsoft.EntityFrameworkCore;
using QuanLyLichKhamBenh.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichKhamBenh
{
    public partial class Form1 : Form
    {
        private int? _selectedMaLich = null;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            // Thiết lập giá trị mặc định cho DateTimePicker
            dtpNgayKham.Value = DateTime.Today;
            dtpGioKham.Value = DateTime.Now;
            dtpTuNgay.Value = DateTime.Today.AddMonths(-1);
            dtpDenNgay.Value = DateTime.Today.AddMonths(1);

            cboTrangThai.SelectedIndex = 0;

            await LoadComboBoxBacSiAsync();
            await LoadDanhSachLichKhamAsync();
        }

        /// <summary>
        /// Nạp danh sách bác sĩ vào ComboBox chọn bác sĩ và ComboBox lọc tìm kiếm
        /// </summary>
        private async Task LoadComboBoxBacSiAsync()
        {
            try
            {
                using var context = new QuanLyLichKhamBenhContext();
                var danhSachBacSi = await context.BacSis
                    .OrderBy(b => b.HoTen)
                    .ToListAsync();

                // ComboBox chọn bác sĩ ở Form nhập liệu
                cboBacSi.DataSource = null;
                cboBacSi.DisplayMember = "DisplayText";
                cboBacSi.ValueMember = "MaBs";
                cboBacSi.DataSource = danhSachBacSi;
                if (danhSachBacSi.Count > 0)
                {
                    cboBacSi.SelectedIndex = 0;
                }

                // ComboBox lọc bác sĩ ở thanh tìm kiếm (có thêm tùy chọn Tất cả)
                var danhSachLoc = new List<BacSiItem>
                {
                    new BacSiItem { MaBs = 0, DisplayText = "-- Tất cả bác sĩ --" }
                };
                danhSachLoc.AddRange(danhSachBacSi.Select(b => new BacSiItem
                {
                    MaBs = b.MaBs,
                    DisplayText = b.DisplayText
                }));

                cboLocBacSi.DataSource = null;
                cboLocBacSi.DisplayMember = "DisplayText";
                cboLocBacSi.ValueMember = "MaBs";
                cboLocBacSi.DataSource = danhSachLoc;
                cboLocBacSi.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh mục bác sĩ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hiển thị danh sách lịch khám kèm thông tin Bác sĩ qua LINQ Include
        /// </summary>
        private async Task LoadDanhSachLichKhamAsync(IQueryable<LichKham>? customQuery = null)
        {
            try
            {
                using var context = new QuanLyLichKhamBenhContext();

                // Sử dụng LINQ Include(x => x.MaBsNavigation) để nạp kèm dữ liệu bác sĩ trong 1 câu truy vấn
                var query = customQuery ?? context.LichKhams.Include(x => x.MaBsNavigation);

                var list = await query
                    .OrderByDescending(x => x.NgayKham)
                    .ThenBy(x => x.GioKham)
                    .Select(x => new
                    {
                        MaLich = x.MaLich,
                        TenBenhNhan = x.TenBenhNhan,
                        SDT = x.Sdt,
                        NgayKhamRaw = x.NgayKham,
                        NgayKham = x.NgayKham.HasValue ? x.NgayKham.Value.ToString("dd/MM/yyyy") : "",
                        GioKham = x.GioKham,
                        MaBs = x.MaBs,
                        BacSi = x.MaBsNavigation != null ? x.MaBsNavigation.DisplayText : "",
                        ChuyenKhoa = x.MaBsNavigation != null ? (x.MaBsNavigation.ChuyenKhoa ?? "") : "",
                        TrangThai = x.TrangThai
                    })
                    .ToListAsync();

                dgvLichKham.DataSource = list;

                // Định dạng tiêu đề các cột hiển thị trên DataGridView
                if (dgvLichKham.Columns["MaLich"] is { } colML) { colML.HeaderText = "Mã lịch"; colML.Width = 80; }
                if (dgvLichKham.Columns["TenBenhNhan"] is { } colTBN) { colTBN.HeaderText = "Tên bệnh nhân"; colTBN.Width = 160; }
                if (dgvLichKham.Columns["SDT"] is { } colSDT) { colSDT.HeaderText = "SĐT"; colSDT.Width = 110; }
                if (dgvLichKham.Columns["NgayKham"] is { } colNK) { colNK.HeaderText = "Ngày khám"; colNK.Width = 120; }
                if (dgvLichKham.Columns["GioKham"] is { } colGK) { colGK.HeaderText = "Giờ khám"; colGK.Width = 90; }
                if (dgvLichKham.Columns["BacSi"] is { } colBS) { colBS.HeaderText = "Bác sĩ"; colBS.Width = 220; }
                if (dgvLichKham.Columns["ChuyenKhoa"] is { } colCK) { colCK.HeaderText = "Chuyên khoa"; colCK.Width = 130; }
                if (dgvLichKham.Columns["TrangThai"] is { } colTT) { colTT.HeaderText = "Trạng thái"; colTT.Width = 100; }

                // Ẩn các cột bổ trợ không cần hiển thị
                if (dgvLichKham.Columns["NgayKhamRaw"] is { } colNKRaw) colNKRaw.Visible = false;
                if (dgvLichKham.Columns["MaBs"] is { } colMaBs) colMaBs.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách lịch khám: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            _selectedMaLich = null;
            txtTenBenhNhan.Clear();
            txtSDT.Clear();
            dtpNgayKham.Value = DateTime.Today;
            dtpGioKham.Value = DateTime.Now;
            if (cboBacSi.Items.Count > 0) cboBacSi.SelectedIndex = 0;
            if (cboTrangThai.Items.Count > 0) cboTrangThai.SelectedIndex = 0;
            txtTenBenhNhan.Focus();
        }

        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            await LoadDanhSachLichKhamAsync();
        }

        private void dgvLichKham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvLichKham.Rows[e.RowIndex].Cells["MaLich"].Value != null)
            {
                var row = dgvLichKham.Rows[e.RowIndex];
                _selectedMaLich = Convert.ToInt32(row.Cells["MaLich"].Value);

                txtTenBenhNhan.Text = row.Cells["TenBenhNhan"].Value?.ToString() ?? "";
                txtSDT.Text = row.Cells["SDT"].Value?.ToString() ?? "";

                if (row.Cells["NgayKhamRaw"].Value is DateOnly dateOnly)
                {
                    dtpNgayKham.Value = dateOnly.ToDateTime(TimeOnly.MinValue);
                }
                else if (DateTime.TryParse(row.Cells["NgayKham"].Value?.ToString(), out DateTime parsedDate))
                {
                    dtpNgayKham.Value = parsedDate;
                }

                string? gioKhamStr = row.Cells["GioKham"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(gioKhamStr) && TimeSpan.TryParse(gioKhamStr, out TimeSpan parsedTime))
                {
                    dtpGioKham.Value = DateTime.Today.Add(parsedTime);
                }

                if (row.Cells["MaBs"].Value != null && int.TryParse(row.Cells["MaBs"].Value.ToString(), out int maBs))
                {
                    cboBacSi.SelectedValue = maBs;
                }

                string? trangThai = row.Cells["TrangThai"].Value?.ToString();
                if (!string.IsNullOrWhiteSpace(trangThai) && cboTrangThai.Items.Contains(trangThai))
                {
                    cboTrangThai.SelectedItem = trangThai;
                }
            }
        }

        /// <summary>
        /// Kiểm tra tính hợp lệ dữ liệu đầu vào
        /// </summary>
        private bool ValidateInput(bool isUpdate = false)
        {
            if (string.IsNullOrWhiteSpace(txtTenBenhNhan.Text))
            {
                MessageBox.Show("Tên bệnh nhân không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBenhNhan.Focus();
                return false;
            }

            if (cboBacSi.SelectedValue is not int maBs || maBs <= 0)
            {
                MessageBox.Show("Vui lòng chọn bác sĩ khám!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboBacSi.Focus();
                return false;
            }

            // Validate: Không cho đặt lịch khám vào ngày trong quá khứ
            if (dtpNgayKham.Value.Date < DateTime.Today)
            {
                MessageBox.Show("Không cho phép đặt lịch khám vào ngày trong quá khứ!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgayKham.Focus();
                return false;
            }

            return true;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                using var context = new QuanLyLichKhamBenhContext();

                var lichKham = new LichKham
                {
                    TenBenhNhan = txtTenBenhNhan.Text.Trim(),
                    Sdt = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim(),
                    NgayKham = DateOnly.FromDateTime(dtpNgayKham.Value.Date),
                    GioKham = dtpGioKham.Value.ToString("HH:mm"),
                    MaBs = (int)(cboBacSi.SelectedValue ?? 0),
                    TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Chờ khám"
                };

                context.LichKhams.Add(lichKham);
                await context.SaveChangesAsync();

                MessageBox.Show("Thêm lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                await LoadDanhSachLichKhamAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm lịch khám: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaLich == null)
            {
                MessageBox.Show("Vui lòng tích chọn một lịch khám từ danh sách để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput(isUpdate: true)) return;

            try
            {
                using var context = new QuanLyLichKhamBenhContext();
                var lichKham = await context.LichKhams.FindAsync(_selectedMaLich.Value);
                if (lichKham == null)
                {
                    MessageBox.Show("Không tìm thấy lịch khám cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                lichKham.TenBenhNhan = txtTenBenhNhan.Text.Trim();
                lichKham.Sdt = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim();
                lichKham.NgayKham = DateOnly.FromDateTime(dtpNgayKham.Value.Date);
                lichKham.GioKham = dtpGioKham.Value.ToString("HH:mm");
                lichKham.MaBs = (int)(cboBacSi.SelectedValue ?? 0);
                lichKham.TrangThai = cboTrangThai.SelectedItem?.ToString() ?? "Chờ khám";

                await context.SaveChangesAsync();

                MessageBox.Show("Cập nhật lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                await LoadDanhSachLichKhamAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật lịch khám: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaLich == null)
            {
                MessageBox.Show("Vui lòng tích chọn một lịch khám từ danh sách để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Bắt buộc hiển thị hộp thoại xác nhận YesNo trước khi gọi SaveChangesAsync()
            var result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa lịch khám mã {_selectedMaLich} của bệnh nhân '{txtTenBenhNhan.Text}' không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes) return;

            try
            {
                using var context = new QuanLyLichKhamBenhContext();
                var lichKham = await context.LichKhams.FindAsync(_selectedMaLich.Value);
                if (lichKham == null)
                {
                    MessageBox.Show("Không tìm thấy lịch khám cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                context.LichKhams.Remove(lichKham);
                await context.SaveChangesAsync();

                MessageBox.Show("Xóa lịch khám thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                await LoadDanhSachLichKhamAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa lịch khám: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tìm kiếm kết hợp: khoảng Ngày khám (>= Từ ngày, <= Đến ngày) VÀ theo Bác sĩ (==)
        /// </summary>
        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                var tuNgay = DateOnly.FromDateTime(dtpTuNgay.Value.Date);
                var denNgay = DateOnly.FromDateTime(dtpDenNgay.Value.Date);

                if (tuNgay > denNgay)
                {
                    MessageBox.Show("Ngày bắt đầu (Từ ngày) không được lớn hơn ngày kết thúc (Đến ngày)!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using var context = new QuanLyLichKhamBenhContext();

                // Minh họa LINQ Include kết hợp Where với nhiều điều kiện (>=, <=) và (==)
                var query = context.LichKhams
                    .Include(x => x.MaBsNavigation)
                    .Where(x => x.NgayKham >= tuNgay && x.NgayKham <= denNgay);

                // Lọc theo Bác sĩ nếu được chọn
                if (cboLocBacSi.SelectedValue is int maBs && maBs > 0)
                {
                    query = query.Where(x => x.MaBs == maBs);
                }

                var list = await query
                    .OrderByDescending(x => x.NgayKham)
                    .ThenBy(x => x.GioKham)
                    .Select(x => new
                    {
                        MaLich = x.MaLich,
                        TenBenhNhan = x.TenBenhNhan,
                        SDT = x.Sdt,
                        NgayKhamRaw = x.NgayKham,
                        NgayKham = x.NgayKham.HasValue ? x.NgayKham.Value.ToString("dd/MM/yyyy") : "",
                        GioKham = x.GioKham,
                        MaBs = x.MaBs,
                        BacSi = x.MaBsNavigation != null ? x.MaBsNavigation.DisplayText : "",
                        ChuyenKhoa = x.MaBsNavigation != null ? (x.MaBsNavigation.ChuyenKhoa ?? "") : "",
                        TrangThai = x.TrangThai
                    })
                    .ToListAsync();

                dgvLichKham.DataSource = list;

                if (list.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy lịch khám nào phù hợp với điều kiện tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Mở Form phụ "Quản lý Bác sĩ"
        /// </summary>
        private async void btnDiDen_Click(object sender, EventArgs e)
        {
            using var formBacSi = new FormBacSi();
            formBacSi.ShowDialog(this);

            // Nạp lại danh sách bác sĩ và làm mới bảng lịch khám sau khi thao tác bên Form Bác sĩ
            await LoadComboBoxBacSiAsync();
            await LoadDanhSachLichKhamAsync();
        }

        private class BacSiItem
        {
            public int MaBs { get; set; }
            public string DisplayText { get; set; } = string.Empty;
        }
    }
}
