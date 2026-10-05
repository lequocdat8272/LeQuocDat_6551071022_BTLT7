-- Tạo cơ sở dữ liệu QuanLyLoaiPhong
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'QuanLyLoaiPhong')
BEGIN
    CREATE DATABASE QuanLyLoaiPhong;
END
GO

USE QuanLyLoaiPhong;
GO

-- Bảng Loại phòng
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='LoaiPhong' AND xtype='U')
BEGIN
    CREATE TABLE LoaiPhong (
        MaLoai INT IDENTITY(1,1) PRIMARY KEY,
        TenLoai NVARCHAR(100) NOT NULL,
        GiaMoiDem DECIMAL(18,2),
        MoTa NVARCHAR(255)
    );
END
GO

-- Bảng Phòng
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='Phong' AND xtype='U')
BEGIN
    CREATE TABLE Phong (
        MaPhong INT IDENTITY(1,1) PRIMARY KEY,
        SoPhong VARCHAR(10) NOT NULL,
        TangSo INT,
        TinhTrang NVARCHAR(20), -- Trống / Đang ở / Đang dọn
        HinhAnh NVARCHAR(255),  -- Tên file ảnh
        MaLoai INT FOREIGN KEY REFERENCES LoaiPhong(MaLoai)
    );
END
GO

-- Dữ liệu mẫu bảng Loại phòng
IF NOT EXISTS (SELECT 1 FROM LoaiPhong)
BEGIN
    INSERT INTO LoaiPhong (TenLoai, GiaMoiDem, MoTa) VALUES 
    (N'Phòng Đơn', 35000, N'Phòng 1 giường đơn'),
    (N'Phòng Đôi', 20000, N'Phòng 1 giường đôi hoặc 2 giường đơn'),
    (N'Phòng VIP', 30000, N'Phòng cao cấp đầy đủ tiện nghi');
END
GO

-- Dữ liệu mẫu bảng Phòng
IF NOT EXISTS (SELECT 1 FROM Phong)
BEGIN
    DECLARE @MaDon INT = (SELECT TOP 1 MaLoai FROM LoaiPhong WHERE TenLoai = N'Phòng Đơn');
    DECLARE @MaDoi INT = (SELECT TOP 1 MaLoai FROM LoaiPhong WHERE TenLoai = N'Phòng Đôi');
    DECLARE @MaVIP INT = (SELECT TOP 1 MaLoai FROM LoaiPhong WHERE TenLoai = N'Phòng VIP');

    INSERT INTO Phong (SoPhong, TangSo, TinhTrang, HinhAnh, MaLoai) VALUES
    ('1', 1, N'Trống', 'phong1.jpg', @MaDon),
    ('2', 1, N'Đang ở', 'phong2.jpg', @MaDoi),
    ('3', 2, N'Đang dọn', 'phong3.jpg', @MaDon),
    ('4', 4, N'Đang dọn', 'phong4.jpg', @MaDoi),
    ('5', 5, N'Đang dọn', 'phong5.jpg', @MaVIP);
END
GO
