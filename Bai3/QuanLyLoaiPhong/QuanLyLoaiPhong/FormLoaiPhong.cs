using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyLoaiPhong.Models;

namespace QuanLyLoaiPhong
{
    public partial class FormLoaiPhong : Form
    {
        private QuanLyLoaiPhongContext _context;

        public FormLoaiPhong()
        {
            InitializeComponent();
            _context = new QuanLyLoaiPhongContext();
        }

        private void FormLoaiPhong_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                var list = _context.LoaiPhongs
                    .Select(lp => new
                    {
                        lp.MaLoai,
                        lp.TenLoai,
                        lp.GiaMoiDem,
                        lp.MoTa
                    })
                    .ToList();

                dgvLoaiPhong.AutoGenerateColumns = false;
                dgvLoaiPhong.DataSource = list;
                ClearInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearInputs()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            nudGiaMoiDem.Value = 0;
            txtMoTa.Clear();
            dgvLoaiPhong.ClearSelection();
        }

        private void dgvLoaiPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvLoaiPhong.Rows.Count)
            {
                var row = dgvLoaiPhong.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["colMaLoai"].Value?.ToString() ?? "";
                txtTenLoai.Text = row.Cells["colTenLoai"].Value?.ToString() ?? "";
                
                if (decimal.TryParse(row.Cells["colGiaMoiDem"].Value?.ToString(), out decimal gia))
                {
                    nudGiaMoiDem.Value = Math.Min(Math.Max(gia, nudGiaMoiDem.Minimum), nudGiaMoiDem.Maximum);
                }
                else
                {
                    nudGiaMoiDem.Value = 0;
                }

                txtMoTa.Text = row.Cells["colMoTa"].Value?.ToString() ?? "";
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenLoai = txtTenLoai.Text.Trim();
            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return;
            }

            try
            {
                var loaiPhong = new LoaiPhong
                {
                    TenLoai = tenLoai,
                    GiaMoiDem = nudGiaMoiDem.Value,
                    MoTa = txtMoTa.Text.Trim()
                };

                _context.LoaiPhongs.Add(loaiPhong);
                _context.SaveChanges();

                MessageBox.Show("Thêm loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaLoai.Text, out int maLoai))
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần sửa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string tenLoai = txtTenLoai.Text.Trim();
            if (string.IsNullOrEmpty(tenLoai))
            {
                MessageBox.Show("Vui lòng nhập tên loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenLoai.Focus();
                return;
            }

            try
            {
                var loaiPhong = _context.LoaiPhongs.Find(maLoai);
                if (loaiPhong == null)
                {
                    MessageBox.Show("Không tìm thấy loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                loaiPhong.TenLoai = tenLoai;
                loaiPhong.GiaMoiDem = nudGiaMoiDem.Value;
                loaiPhong.MoTa = txtMoTa.Text.Trim();

                _context.SaveChanges();
                MessageBox.Show("Cập nhật loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtMaLoai.Text, out int maLoai))
            {
                MessageBox.Show("Vui lòng chọn loại phòng cần xóa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa loại phòng này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes) return;

            try
            {
                bool hasPhongs = _context.Phongs.Any(p => p.MaLoai == maLoai);
                if (hasPhongs)
                {
                    MessageBox.Show("Không thể xóa loại phòng này vì đang có phòng thuộc loại phòng này!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var loaiPhong = _context.LoaiPhongs.Find(maLoai);
                if (loaiPhong != null)
                {
                    _context.LoaiPhongs.Remove(loaiPhong);
                    _context.SaveChanges();
                    MessageBox.Show("Xóa loại phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosed(e);
        }
    }
}
