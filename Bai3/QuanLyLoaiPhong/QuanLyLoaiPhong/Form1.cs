using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QuanLyLoaiPhong.Models;

namespace QuanLyLoaiPhong
{
    public partial class Form1 : Form
    {
        private QuanLyLoaiPhongContext _context;
        private string? _currentImageFileName = null;
        private int? _selectedMaPhong = null;

        public Form1()
        {
            InitializeComponent();
            _context = new QuanLyLoaiPhongContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLoaiPhongComboBoxes();
            LoadTinhTrangComboBoxes();
            LoadDanhSachPhong();
        }

        private void LoadLoaiPhongComboBoxes()
        {
            try
            {
                var loaiPhongs = _context.LoaiPhongs.OrderBy(lp => lp.MaLoai).ToList();

                // ComboBox chọn Loại phòng khi nhập liệu
                cboLoaiPhong.DataSource = null;
                cboLoaiPhong.DataSource = loaiPhongs.ToList();
                cboLoaiPhong.DisplayMember = "TenLoai";
                cboLoaiPhong.ValueMember = "MaLoai";

                // ComboBox lọc theo Loại phòng
                var filterList = new List<LoaiPhongFilterItem>
                {
                    new LoaiPhongFilterItem { MaLoai = 0, TenLoai = "Lọc theo loại phòng" }
                };
                foreach (var lp in loaiPhongs)
                {
                    filterList.Add(new LoaiPhongFilterItem { MaLoai = lp.MaLoai, TenLoai = lp.TenLoai });
                }

                cboLocLoaiPhong.DataSource = null;
                cboLocLoaiPhong.DataSource = filterList;
                cboLocLoaiPhong.DisplayMember = "TenLoai";
                cboLocLoaiPhong.ValueMember = "MaLoai";
                cboLocLoaiPhong.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách loại phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTinhTrangComboBoxes()
        {
            // ComboBox nhập liệu
            cboTinhTrang.SelectedIndex = 0;

            // ComboBox lọc
            cboLocTinhTrang.Items.Clear();
            cboLocTinhTrang.Items.Add("Lọc theo tình trạng");
            cboLocTinhTrang.Items.Add("Trống");
            cboLocTinhTrang.Items.Add("Đang ở");
            cboLocTinhTrang.Items.Add("Đang dọn");
            cboLocTinhTrang.SelectedIndex = 0;
        }

        private void LoadDanhSachPhong(IQueryable<Phong>? customQuery = null)
        {
            try
            {
                // LINQ Include - Eager loading MaLoaiNavigation
                var query = customQuery ?? _context.Phongs.Include(p => p.MaLoaiNavigation);

                var list = query
                    .OrderBy(p => p.MaPhong)
                    .Select(p => new
                    {
                        p.MaPhong,
                        p.SoPhong,
                        p.TangSo,
                        p.TinhTrang,
                        p.HinhAnh,
                        p.MaLoai,
                        TenLoai = p.MaLoaiNavigation != null ? p.MaLoaiNavigation.TenLoai : "",
                        GiaMoiDem = p.MaLoaiNavigation != null ? p.MaLoaiNavigation.GiaMoiDem : null
                    })
                    .ToList();

                var viewList = list.Select(p => new PhongViewModel
                {
                    MaPhong = p.MaPhong,
                    HinhAnhThumb = LoadImageSafe(p.HinhAnh),
                    HinhAnhFileName = p.HinhAnh,
                    SoPhong = p.SoPhong,
                    TangSo = p.TangSo,
                    MaLoai = p.MaLoai,
                    TenLoai = p.TenLoai,
                    GiaMoiDem = p.GiaMoiDem,
                    TinhTrang = p.TinhTrang ?? ""
                }).ToList();

                dgvPhong.AutoGenerateColumns = false;
                dgvPhong.DataSource = viewList;

                // Nếu có dòng, chọn dòng đầu tiên như hình minh họa
                if (viewList.Count > 0)
                {
                    dgvPhong.ClearSelection();
                    dgvPhong.Rows[0].Selected = true;
                    HienThiChiTiet(viewList[0]);
                }
                else
                {
                    ClearInputs();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image? LoadImageSafe(string? fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName)) return null;

            string folder = Path.Combine(Application.StartupPath, "Images");
            string fullPath = Path.Combine(folder, fileName);

            if (!File.Exists(fullPath))
            {
                // Kiểm tra thư mục Images trong thư mục gốc project khi chạy debug
                string projectImages = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "..", "Images"));
                fullPath = Path.Combine(projectImages, fileName);
                if (!File.Exists(fullPath)) return null;
            }

            try
            {
                using (var fs = new FileStream(fullPath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
                {
                    using (var img = Image.FromStream(fs))
                    {
                        return new Bitmap(img);
                    }
                }
            }
            catch
            {
                return null;
            }
        }

        private void HienThiChiTiet(PhongViewModel item)
        {
            _selectedMaPhong = item.MaPhong;
            txtSoPhong.Text = item.SoPhong;
            nudTangSo.Value = item.TangSo ?? 1;

            if (item.MaLoai.HasValue)
            {
                cboLoaiPhong.SelectedValue = item.MaLoai.Value;
            }

            if (!string.IsNullOrEmpty(item.TinhTrang))
            {
                cboTinhTrang.SelectedItem = item.TinhTrang;
            }

            _currentImageFileName = item.HinhAnhFileName;

            // Hiển thị ảnh lên PictureBox
            if (picHinhAnh.Image != null)
            {
                picHinhAnh.Image.Dispose();
                picHinhAnh.Image = null;
            }
            picHinhAnh.Image = LoadImageSafe(_currentImageFileName);
        }

        private void ClearInputs()
        {
            _selectedMaPhong = null;
            _currentImageFileName = null;
            txtSoPhong.Clear();
            nudTangSo.Value = 1;
            if (cboLoaiPhong.Items.Count > 0) cboLoaiPhong.SelectedIndex = 0;
            if (cboTinhTrang.Items.Count > 0) cboTinhTrang.SelectedIndex = 0;

            if (picHinhAnh.Image != null)
            {
                picHinhAnh.Image.Dispose();
                picHinhAnh.Image = null;
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPhong.Rows.Count)
            {
                if (dgvPhong.Rows[e.RowIndex].DataBoundItem is PhongViewModel item)
                {
                    HienThiChiTiet(item);
                }
            }
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.webp";
                ofd.Title = "Chọn hình ảnh phòng";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string sourceFile = ofd.FileName;
                        string originalName = Path.GetFileName(sourceFile);
                        string uniqueName = $"{DateTime.Now:yyyyMMddHHmmss}_{originalName}";

                        string appImagesDir = Path.Combine(Application.StartupPath, "Images");
                        if (!Directory.Exists(appImagesDir))
                        {
                            Directory.CreateDirectory(appImagesDir);
                        }

                        string targetPath = Path.Combine(appImagesDir, uniqueName);
                        File.Copy(sourceFile, targetPath, true);

                        // Lưu bản sao vào thư mục project để giữ ảnh khi Clean/Rebuild
                        try
                        {
                            string projectImages = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", "..", "..", "Images"));
                            if (Directory.Exists(projectImages))
                            {
                                File.Copy(sourceFile, Path.Combine(projectImages, uniqueName), true);
                            }
                        }
                        catch { }

                        // Chỉ lưu tên file
                        _currentImageFileName = uniqueName;

                        if (picHinhAnh.Image != null)
                        {
                            picHinhAnh.Image.Dispose();
                            picHinhAnh.Image = null;
                        }
                        picHinhAnh.Image = LoadImageSafe(_currentImageFileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tải ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string soPhong = txtSoPhong.Text.Trim();
            if (string.IsNullOrEmpty(soPhong))
            {
                MessageBox.Show("Vui lòng nhập số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoPhong.Focus();
                return;
            }

            if (cboLoaiPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiPhong.Focus();
                return;
            }

            try
            {
                int maLoai = (int)cboLoaiPhong.SelectedValue;
                string tinhTrang = cboTinhTrang.SelectedItem?.ToString() ?? "Trống";
                int tangSo = (int)nudTangSo.Value;

                var phongMoi = new Phong
                {
                    SoPhong = soPhong,
                    TangSo = tangSo,
                    TinhTrang = tinhTrang,
                    HinhAnh = _currentImageFileName,
                    MaLoai = maLoai
                };

                _context.Phongs.Add(phongMoi);
                _context.SaveChanges();

                MessageBox.Show("Thêm phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (!_selectedMaPhong.HasValue)
            {
                MessageBox.Show("Vui lòng chọn phòng cần sửa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string soPhong = txtSoPhong.Text.Trim();
            if (string.IsNullOrEmpty(soPhong))
            {
                MessageBox.Show("Vui lòng nhập số phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoPhong.Focus();
                return;
            }

            if (cboLoaiPhong.SelectedValue == null)
            {
                MessageBox.Show("Vui lòng chọn loại phòng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLoaiPhong.Focus();
                return;
            }

            try
            {
                var phong = _context.Phongs.Find(_selectedMaPhong.Value);
                if (phong == null)
                {
                    MessageBox.Show("Không tìm thấy thông tin phòng cần sửa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                phong.SoPhong = soPhong;
                phong.TangSo = (int)nudTangSo.Value;
                phong.MaLoai = (int)cboLoaiPhong.SelectedValue;
                phong.TinhTrang = cboTinhTrang.SelectedItem?.ToString() ?? "Trống";
                phong.HinhAnh = _currentImageFileName;

                _context.SaveChanges();
                MessageBox.Show("Cập nhật thông tin phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDanhSachPhong();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi sửa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (!_selectedMaPhong.HasValue)
            {
                MessageBox.Show("Vui lòng chọn phòng cần xóa trên danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirm = MessageBox.Show($"Bạn có chắc chắn muốn xóa phòng {txtSoPhong.Text} (Mã: {_selectedMaPhong.Value}) không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm != DialogResult.Yes) return;

            try
            {
                var phong = _context.Phongs.Find(_selectedMaPhong.Value);
                if (phong != null)
                {
                    _context.Phongs.Remove(phong);
                    _context.SaveChanges();
                    MessageBox.Show("Xóa phòng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDanhSachPhong();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa phòng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ClearInputs();
            cboLocLoaiPhong.SelectedIndex = 0;
            cboLocTinhTrang.SelectedIndex = 0;
            LoadDanhSachPhong();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            try
            {
                // LINQ Where kết hợp Include để vừa lọc vừa lấy kèm tên loại phòng
                var query = _context.Phongs.Include(p => p.MaLoaiNavigation).AsQueryable();

                // Lọc theo loại phòng nếu được chọn
                if (cboLocLoaiPhong.SelectedValue is int maLoai && maLoai > 0)
                {
                    query = query.Where(p => p.MaLoai == maLoai);
                }

                // Lọc theo tình trạng nếu được chọn
                string? tinhTrang = cboLocTinhTrang.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(tinhTrang) && tinhTrang != "Lọc theo tình trạng")
                {
                    query = query.Where(p => p.TinhTrang == tinhTrang);
                }

                LoadDanhSachPhong(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQLLoaiPhong_Click(object sender, EventArgs e)
        {
            using (var f = new FormLoaiPhong())
            {
                f.ShowDialog(this);
            }

            // Sau khi form Loại phòng đóng, nạp lại danh sách loại phòng và cập nhật lại danh sách phòng
            LoadLoaiPhongComboBoxes();
            LoadDanhSachPhong();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _context?.Dispose();
            base.OnFormClosed(e);
        }
    }

    public class LoaiPhongFilterItem
    {
        public int MaLoai { get; set; }
        public string TenLoai { get; set; } = "";
    }

    public class PhongViewModel
    {
        public int MaPhong { get; set; }
        public Image? HinhAnhThumb { get; set; }
        public string? HinhAnhFileName { get; set; }
        public string SoPhong { get; set; } = "";
        public int? TangSo { get; set; }
        public int? MaLoai { get; set; }
        public string TenLoai { get; set; } = "";
        public decimal? GiaMoiDem { get; set; }
        public string GiaMoiDemFormat => GiaMoiDem.HasValue ? GiaMoiDem.Value.ToString("N0") : "";
        public string TinhTrang { get; set; } = "";
    }
}
