using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyTheLoaiSach.Models;

namespace QuanLyTheLoaiSach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        /// <summary>
        /// Tải toàn bộ danh sách thể loại sách từ SQL Server lên DataGridView
        /// </summary>
        private async Task LoadDataAsync()
        {
            try
            {
                using var context = new QuanLyTheLoaiSachContext();
                var list = await context.TheLoaiSaches
                    .OrderBy(tl => tl.MaTl)
                    .ToListAsync();

                dgvTheLoai.DataSource = list;
                ClearInput();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối cơ sở dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Sự kiện chọn dòng trên DataGridView -> Đổ dữ liệu lên các TextBox
        /// </summary>
        private void dgvTheLoai_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTheLoai.CurrentRow != null && dgvTheLoai.CurrentRow.DataBoundItem is TheLoaiSach selected)
            {
                txtMaTL.Text = selected.MaTl.ToString();
                txtTenTheLoai.Text = selected.TenTheLoai;
                txtMoTa.Text = selected.MoTa ?? string.Empty;
                lblNgayTao.Text = selected.NgayTao.HasValue 
                    ? selected.NgayTao.Value.ToString("dd/MM/yyyy HH:mm:ss") 
                    : "---";
            }
        }

        /// <summary>
        /// Chức năng Thêm mới thể loại sách
        /// </summary>
        private async void btnThem_Click(object sender, EventArgs e)
        {
            string tenTheLoai = txtTenTheLoai.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            // 1. Kiểm tra không được để trống Tên thể loại
            if (string.IsNullOrWhiteSpace(tenTheLoai))
            {
                MessageBox.Show("Vui lòng nhập Tên thể loại sách!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTheLoai.Focus();
                return;
            }

            try
            {
                using var context = new QuanLyTheLoaiSachContext();

                // 2. Kiểm tra trùng tên thể loại khi thêm mới (không phân biệt hoa/thường)
                bool isExisted = await context.TheLoaiSaches
                    .AnyAsync(tl => tl.TenTheLoai.ToLower() == tenTheLoai.ToLower());

                if (isExisted)
                {
                    MessageBox.Show($"Thể loại '{tenTheLoai}' đã tồn tại trong hệ thống. Vui lòng chọn tên khác!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTheLoai.Focus();
                    return;
                }

                // 3. Thêm mới thực thể
                var newTheLoai = new TheLoaiSach
                {
                    TenTheLoai = tenTheLoai,
                    MoTa = string.IsNullOrWhiteSpace(moTa) ? null : moTa,
                    SoLuongSach = 0,
                    NgayTao = DateTime.Now
                };

                context.TheLoaiSaches.Add(newTheLoai);
                await context.SaveChangesAsync();

                MessageBox.Show("Thêm mới thể loại sách thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi thêm mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Chức năng Cập nhật thông tin thể loại sách
        /// </summary>
        private async void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaTL.Text, out int maTL))
            {
                MessageBox.Show("Vui lòng chọn thể loại sách từ danh sách để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenTheLoai = txtTenTheLoai.Text.Trim();
            string moTa = txtMoTa.Text.Trim();

            // 1. Kiểm tra không được để trống Tên thể loại
            if (string.IsNullOrWhiteSpace(tenTheLoai))
            {
                MessageBox.Show("Tên thể loại không được để trống!", "Thiếu dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenTheLoai.Focus();
                return;
            }

            try
            {
                using var context = new QuanLyTheLoaiSachContext();

                // 2. Kiểm tra trùng tên với thể loại khác
                bool isExisted = await context.TheLoaiSaches
                    .AnyAsync(tl => tl.MaTl != maTL && tl.TenTheLoai.ToLower() == tenTheLoai.ToLower());

                if (isExisted)
                {
                    MessageBox.Show($"Tên thể loại '{tenTheLoai}' đã trùng với thể loại khác!", "Trùng dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTenTheLoai.Focus();
                    return;
                }

                // 3. Tìm và cập nhật
                var theLoai = await context.TheLoaiSaches.FindAsync(maTL);
                if (theLoai == null)
                {
                    MessageBox.Show("Không tìm thấy thể loại sách này trong cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                theLoai.TenTheLoai = tenTheLoai;
                theLoai.MoTa = string.IsNullOrWhiteSpace(moTa) ? null : moTa;

                await context.SaveChangesAsync();

                MessageBox.Show("Cập nhật thông tin thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                await LoadDataAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi cập nhật: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Chức năng Xóa thể loại sách
        /// </summary>
        private async void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaTL.Text, out int maTL))
            {
                MessageBox.Show("Vui lòng chọn thể loại sách từ danh sách để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Hộp thoại xác nhận YesNo
            var confirmResult = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa thể loại: \"{txtTenTheLoai.Text}\"?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmResult != DialogResult.Yes)
            {
                return;
            }

            try
            {
                using var context = new QuanLyTheLoaiSachContext();
                var theLoai = await context.TheLoaiSaches.FindAsync(maTL);

                if (theLoai != null)
                {
                    context.TheLoaiSaches.Remove(theLoai);
                    await context.SaveChangesAsync();

                    MessageBox.Show("Xóa thể loại thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    await LoadDataAsync();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy thể loại cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (DbUpdateException)
            {
                // Bắt lỗi ràng buộc khóa ngoại (foreign key constraint) khi có sách khác tham chiếu
                MessageBox.Show("Không thể xóa thể loại này vì đang có sách thuộc thể loại này tham chiếu tới!", 
                                "Lỗi ràng buộc dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi xóa thể loại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Chức năng Tìm kiếm theo Tên thể loại dùng LINQ (Where + Contains)
        /// </summary>
        private async void btnTimKiem_Click(object sender, EventArgs e)
        {
            await ExecuteSearchAsync();
        }

        private async void txtTimKiem_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await ExecuteSearchAsync();
            }
        }

        private async Task ExecuteSearchAsync()
        {
            string keyword = txtTimKiem.Text.Trim();

            try
            {
                using var context = new QuanLyTheLoaiSachContext();

                List<TheLoaiSach> result;
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    result = await context.TheLoaiSaches
                        .OrderBy(tl => tl.MaTl)
                        .ToListAsync();
                }
                else
                {
                    // Lọc bằng LINQ Where + Contains
                    result = await context.TheLoaiSaches
                        .Where(tl => tl.TenTheLoai.Contains(keyword))
                        .OrderBy(tl => tl.MaTl)
                        .ToListAsync();
                }

                dgvTheLoai.DataSource = result;

                if (result.Count == 0)
                {
                    MessageBox.Show($"Không tìm thấy thể loại nào phù hợp với từ khóa '{keyword}'!", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Chức năng Làm mới (Reset form và tải lại danh sách đầy đủ)
        /// </summary>
        private async void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            await LoadDataAsync();
        }

        /// <summary>
        /// Xóa trắng các trường nhập liệu
        /// </summary>
        private void ClearInput()
        {
            txtMaTL.Clear();
            txtTenTheLoai.Clear();
            txtMoTa.Clear();
            lblNgayTao.Text = "---";
            dgvTheLoai.ClearSelection();
        }
    }
}
