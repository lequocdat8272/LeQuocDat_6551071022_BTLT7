namespace QuanLyLichKhamBenh.Models;

public partial class BacSi
{
    public string DisplayText => string.IsNullOrWhiteSpace(ChuyenKhoa)
        ? HoTen
        : $"{HoTen} - {ChuyenKhoa}";

    public override string ToString() => DisplayText;
}
