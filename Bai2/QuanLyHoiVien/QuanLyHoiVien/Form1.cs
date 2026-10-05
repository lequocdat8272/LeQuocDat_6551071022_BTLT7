using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyHoiVien.Models;

namespace QuanLyHoiVien
{
    public partial class Form1 : Form
    {
        private readonly QuanLyHoiVienContext _context;
        private int _selectedMaHv = 0;

        public Form1()
        {
            InitializeComponent();
            _context = new QuanLyHoiVienContext();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Nạp giá trị mặc định cho ComboBox
                if (cboHangThanhVien.Items.Count > 0)
                {
                    cboHangThanhVien.SelectedIndex = 0;
                }

                if (cboTimHang.Items.Count > 0)
                {
                    cboTimHang.SelectedIndex = 0; // "Tất cả"
                }

                rdoNam.Checked = true;
                chkTrangThai.Checked = true;
                dtpNgaySinh.Value = new DateTime(2000, 1, 1);

                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Tải toàn bộ danh sách hội viên lên DataGridView
        /// </summary>
        private async Task LoadDataAsync()
        {
            try
            {
                var list = await _context.HoiViens
                    .AsNoTracking()
                    .OrderBy(hv => hv.MaHv)
                    .ToListAsync();

                DisplayData(list);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Hiển thị danh sách hội viên lên DataGridView với định dạng hiển thị trực quan
        /// </summary>
        private void DisplayData(List<HoiVien> list)
        {
            var displayList = list.Select(hv => new
            {
                MaHV = hv.MaHv,
                HoTen = hv.HoTen,
                GioiTinh = hv.GioiTinh == true ? "Nam" : "Nữ",
                NgaySinh = hv.NgaySinh.HasValue ? hv.NgaySinh.Value.ToString("dd/MM/yyyy") : string.Empty,
                SDT = hv.Sdt,
                HangThanhVien = hv.HangThanhVien,
                TrangThai = hv.TrangThai == true ? "Đang hoạt động" : "Tạm ngưng"
            }).ToList();

            dgvHoiVien.DataSource = displayList;

            // Đổi tiêu đề cột tiếng Việt
            if (dgvHoiVien.Columns.Contains("MaHV")) dgvHoiVien.Columns["MaHV"]!.HeaderText = "Mã HV";
            if (dgvHoiVien.Columns.Contains("HoTen")) dgvHoiVien.Columns["HoTen"]!.HeaderText = "Họ tên";
            if (dgvHoiVien.Columns.Contains("GioiTinh")) dgvHoiVien.Columns["GioiTinh"]!.HeaderText = "Giới tính";
            if (dgvHoiVien.Columns.Contains("NgaySinh")) dgvHoiVien.Columns["NgaySinh"]!.HeaderText = "Ngày sinh";
            if (dgvHoiVien.Columns.Contains("SDT")) dgvHoiVien.Columns["SDT"]!.HeaderText = "SĐT";
            if (dgvHoiVien.Columns.Contains("HangThanhVien")) dgvHoiVien.Columns["HangThanhVien"]!.HeaderText = "Hạng thành viên";
            if (dgvHoiVien.Columns.Contains("TrangThai")) dgvHoiVien.Columns["TrangThai"]!.HeaderText = "Trạng thái";
        }

        /// <summary>
        /// Xử lý sự kiện click chọn dòng trên DataGridView - tự đổ dữ liệu lên toàn bộ controls
        /// </summary>
        private async void dgvHoiVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvHoiVien.Rows.Count) return;

            try
            {
                var row = dgvHoiVien.Rows[e.RowIndex];
                if (row.Cells["MaHV"]?.Value == null) return;

                int maHv = Convert.ToInt32(row.Cells["MaHV"].Value);
                _selectedMaHv = maHv;

                // Lấy thông tin chi tiết từ DbContext
                var hv = await _context.HoiViens.AsNoTracking().FirstOrDefaultAsync(x => x.MaHv == maHv);
                if (hv != null)
                {
                    txtHoTen.Text = hv.HoTen;
                    txtSDT.Text = hv.Sdt ?? string.Empty;
                    txtEmail.Text = hv.Email ?? string.Empty;

                    // Giới tính (RadioButton)
                    if (hv.GioiTinh == true)
                    {
                        rdoNam.Checked = true;
                    }
                    else
                    {
                        rdoNu.Checked = true;
                    }

                    // Ngày sinh (DateTimePicker)
                    if (hv.NgaySinh.HasValue)
                    {
                        dtpNgaySinh.Value = hv.NgaySinh.Value.ToDateTime(TimeOnly.MinValue);
                    }
                    else
                    {
                        dtpNgaySinh.Value = DateTime.Today;
                    }

                    // Hạng thành viên (ComboBox)
                    if (!string.IsNullOrEmpty(hv.HangThanhVien) && cboHangThanhVien.Items.Contains(hv.HangThanhVien))
                    {
                        cboHangThanhVien.SelectedItem = hv.HangThanhVien;
                    }
                    else if (cboHangThanhVien.Items.Count > 0)
                    {
                        cboHangThanhVien.SelectedIndex = 0;
                    }

                    // Trạng thái (CheckBox)
                    chkTrangThai.Checked = hv.TrangThai == true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi chọn dòng: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Kiểm tra và xác thực dữ liệu đầu vào theo đúng yêu cầu nghiệp vụ
        /// </summary>
        private bool ValidateInput()
        {
            // 1. Validate Họ tên
            string hoTen = txtHoTen.Text.Trim();
            if (string.IsNullOrWhiteSpace(hoTen))
            {
                MessageBox.Show("Họ tên không được để trống!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return false;
            }

            // 2. Validate Số điện thoại: chỉ chứa chữ số và đủ 9-11 ký tự
            string sdt = txtSDT.Text.Trim();
            if (string.IsNullOrWhiteSpace(sdt))
            {
                MessageBox.Show("Số điện thoại không được để trống!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }
            if (!Regex.IsMatch(sdt, @"^\d{9,11}$"))
            {
                MessageBox.Show("Số điện thoại chỉ được chứa chữ số và phải có độ dài từ 9 đến 11 số!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSDT.Focus();
                return false;
            }

            // 3. Validate Email: phải chứa ký tự '@'
            string email = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Email không được để trống!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (!email.Contains("@") || !Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Email không đúng định dạng (phải chứa ký tự '@' và tên miền hợp lệ)!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }

            // 4. Validate Tuổi: tính từ NgaySinh đến hiện tại phải từ 15 tuổi trở lên
            DateTime birthDate = dtpNgaySinh.Value.Date;
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            if (age < 15)
            {
                MessageBox.Show($"Tuổi của hội viên là {age} tuổi. Hội viên phải từ 15 tuổi trở lên mới được đăng ký!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtpNgaySinh.Focus();
                return false;
            }

            // 5. Validate Hạng thành viên
            if (cboHangThanhVien.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn hạng thành viên!", "Lỗi xác thực", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboHangThanhVien.Focus();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Thêm hội viên mới
        /// </summary>
        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            try
            {
                var hoiVien = new HoiVien
                {
                    HoTen = txtHoTen.Text.Trim(),
                    GioiTinh = rdoNam.Checked,
                    NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value),
                    Sdt = txtSDT.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    HangThanhVien = cboHangThanhVien.SelectedItem?.ToString(),
                    NgayDangKy = DateTime.Now,
                    TrangThai = chkTrangThai.Checked
                };

                _context.HoiViens.Add(hoiVien);
                await _context.SaveChangesAsync();

                MessageBox.Show("Thêm hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadDataAsync();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm hội viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Cập nhật thông tin hội viên đã chọn
        /// </summary>
        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (_selectedMaHv == 0)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần sửa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateInput()) return;

            try
            {
                var hoiVien = await _context.HoiViens.FindAsync(_selectedMaHv);
                if (hoiVien == null)
                {
                    MessageBox.Show("Không tìm thấy hội viên trong cơ sở dữ liệu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                hoiVien.HoTen = txtHoTen.Text.Trim();
                hoiVien.GioiTinh = rdoNam.Checked;
                hoiVien.NgaySinh = DateOnly.FromDateTime(dtpNgaySinh.Value);
                hoiVien.Sdt = txtSDT.Text.Trim();
                hoiVien.Email = txtEmail.Text.Trim();
                hoiVien.HangThanhVien = cboHangThanhVien.SelectedItem?.ToString();
                hoiVien.TrangThai = chkTrangThai.Checked;

                await _context.SaveChangesAsync();

                MessageBox.Show("Cập nhật thông tin hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                await LoadDataAsync();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật hội viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Xóa hội viên đã chọn với hộp thoại xác nhận Yes/No và thông báo kết quả sau khi SaveChangesAsync()
        /// </summary>
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (_selectedMaHv == 0)
            {
                MessageBox.Show("Vui lòng chọn hội viên cần xóa từ danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa hội viên \"{txtHoTen.Text}\" (Mã HV: {_selectedMaHv}) không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                var hoiVien = await _context.HoiViens.FindAsync(_selectedMaHv);
                if (hoiVien == null)
                {
                    MessageBox.Show("Không tìm thấy hội viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                _context.HoiViens.Remove(hoiVien);
                int rowsAffected = await _context.SaveChangesAsync();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Xóa hội viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Không có dữ liệu nào được xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                await LoadDataAsync();
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa hội viên: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Làm mới các ô nhập liệu và thiết lập lại trạng thái ban đầu
        /// </summary>
        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetForm();
            txtTimKiem.Clear();
            if (cboTimHang.Items.Count > 0)
            {
                cboTimHang.SelectedIndex = 0;
            }
            await LoadDataAsync();
        }

        /// <summary>
        /// Đặt lại các trường nhập liệu trên form
        /// </summary>
        private void ResetForm()
        {
            _selectedMaHv = 0;
            txtHoTen.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            rdoNam.Checked = true;
            dtpNgaySinh.Value = new DateTime(2000, 1, 1);
            if (cboHangThanhVien.Items.Count > 0)
            {
                cboHangThanhVien.SelectedIndex = 0;
            }
            chkTrangThai.Checked = true;
            dgvHoiVien.ClearSelection();
        }

        /// <summary>
        /// Tìm kiếm kết hợp 2 điều kiện cùng lúc:
        /// - Theo Họ tên (gần đúng, Contains)
        /// - VÀ theo Hạng thành viên (chọn từ ComboBox lọc riêng)
        /// Minh họa LINQ Where với nhiều điều kiện nối bằng toán tử &&
        /// </summary>
        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtTimKiem.Text.Trim();
                string selectedHang = cboTimHang.SelectedItem?.ToString() ?? "Tất cả";

                // Sử dụng LINQ Where kết hợp nhiều điều kiện bằng toán tử &&
                var result = await _context.HoiViens
                    .AsNoTracking()
                    .Where(hv => (string.IsNullOrEmpty(keyword) || hv.HoTen.Contains(keyword))
                              && (selectedHang == "Tất cả" || string.IsNullOrEmpty(selectedHang) || hv.HangThanhVien == selectedHang))
                    .OrderBy(hv => hv.MaHv)
                    .ToListAsync();

                DisplayData(result);

                if (result.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy hội viên nào thỏa mãn điều kiện tìm kiếm!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
