using Microsoft.EntityFrameworkCore;
using QuanLyLichKhamBenh.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLichKhamBenh
{
    public partial class FormBacSi : Form
    {
        public FormBacSi()
        {
            InitializeComponent();
        }

        private async void FormBacSi_Load(object sender, EventArgs e)
        {
            await LoadDanhSachBacSiAsync();
        }

        private async Task LoadDanhSachBacSiAsync()
        {
            try
            {
                using var context = new QuanLyLichKhamBenhContext();
                var list = await context.BacSis
                    .Select(b => new
                    {
                        b.MaBs,
                        b.HoTen,
                        b.ChuyenKhoa,
                        b.Sdt
                    })
                    .ToListAsync();

                dgvBacSi.DataSource = list;

                if (dgvBacSi.Columns["MaBs"] is { } colMaBs) colMaBs.HeaderText = "Mã BS";
                if (dgvBacSi.Columns["HoTen"] is { } colHoTen) colHoTen.HeaderText = "Họ tên";
                if (dgvBacSi.Columns["ChuyenKhoa"] is { } colCK) colCK.HeaderText = "Chuyên khoa";
                if (dgvBacSi.Columns["Sdt"] is { } colSdt) colSdt.HeaderText = "Số điện thoại";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi tải danh sách bác sĩ: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaBS.Clear();
            txtHoTen.Clear();
            txtChuyenKhoa.Clear();
            txtSDT.Clear();
            txtHoTen.Focus();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void dgvBacSi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvBacSi.Rows[e.RowIndex].Cells["MaBs"].Value != null)
            {
                var row = dgvBacSi.Rows[e.RowIndex];
                txtMaBS.Text = row.Cells["MaBs"].Value?.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value?.ToString();
                txtChuyenKhoa.Text = row.Cells["ChuyenKhoa"].Value?.ToString();
                txtSDT.Text = row.Cells["Sdt"].Value?.ToString();
            }
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên bác sĩ không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            try
            {
                using var context = new QuanLyLichKhamBenhContext();
                var bacSi = new BacSi
                {
                    HoTen = txtHoTen.Text.Trim(),
                    ChuyenKhoa = string.IsNullOrWhiteSpace(txtChuyenKhoa.Text) ? null : txtChuyenKhoa.Text.Trim(),
                    Sdt = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim()
                };

                context.BacSis.Add(bacSi);
                await context.SaveChangesAsync();

                MessageBox.Show("Thêm bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                await LoadDanhSachBacSiAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaBS.Text, out int maBs))
            {
                MessageBox.Show("Vui lòng chọn bác sĩ từ danh sách để sửa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtHoTen.Text))
            {
                MessageBox.Show("Họ tên bác sĩ không được để trống!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHoTen.Focus();
                return;
            }

            try
            {
                using var context = new QuanLyLichKhamBenhContext();
                var bacSi = await context.BacSis.FindAsync(maBs);
                if (bacSi == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin bác sĩ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                bacSi.HoTen = txtHoTen.Text.Trim();
                bacSi.ChuyenKhoa = string.IsNullOrWhiteSpace(txtChuyenKhoa.Text) ? null : txtChuyenKhoa.Text.Trim();
                bacSi.Sdt = string.IsNullOrWhiteSpace(txtSDT.Text) ? null : txtSDT.Text.Trim();

                await context.SaveChangesAsync();
                MessageBox.Show("Cập nhật thông tin bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                await LoadDanhSachBacSiAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi sửa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaBS.Text, out int maBs))
            {
                MessageBox.Show("Vui lòng chọn bác sĩ từ danh sách để xóa!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa bác sĩ này cùng toàn bộ lịch khám liên quan không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dialogResult != DialogResult.Yes) return;

            try
            {
                using var context = new QuanLyLichKhamBenhContext();
                var bacSi = await context.BacSis
                    .Include(b => b.LichKhams)
                    .FirstOrDefaultAsync(b => b.MaBs == maBs);

                if (bacSi == null)
                {
                    MessageBox.Show("Không tìm thấy bác sĩ cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (bacSi.LichKhams.Any())
                {
                    context.LichKhams.RemoveRange(bacSi.LichKhams);
                }

                context.BacSis.Remove(bacSi);
                await context.SaveChangesAsync();

                MessageBox.Show("Xóa bác sĩ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearInputs();
                await LoadDanhSachBacSiAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
