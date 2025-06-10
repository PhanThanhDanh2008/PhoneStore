-- Tạo CSDL 
CREATE DATABASE PhoneStore;
GO
USE PhoneStore;
GO

-- Bảng Khách Hàng (thay cho TheLuuDong)
CREATE TABLE KhachHang (
    MaKH CHAR(6) PRIMARY KEY,  
    HoTen NVARCHAR(100) NOT NULL,  
    Email NVARCHAR(255) NULL UNIQUE,  
    SoDienThoai NVARCHAR(20) NOT NULL UNIQUE,
    DiaChi NVARCHAR(255) NULL,
    DiemTichLuy INT DEFAULT 0,
    TrangThai BIT NOT NULL DEFAULT 1  
);
GO

-- Bảng Nhân Viên
CREATE TABLE NhanVien (
    MaNV CHAR(6) PRIMARY KEY, 
    HoTen NVARCHAR(100) NOT NULL, 
    Email NVARCHAR(255) NOT NULL UNIQUE,  
    MatKhau NVARCHAR(255) NOT NULL,
    VaiTro BIT NOT NULL,  -- 1: Admin, 0: Nhân viên
    TrangThai BIT NOT NULL DEFAULT 1  
);
GO

-- Bảng Hãng Sản Xuất (thay cho LoaiSanPham)
CREATE TABLE HangSanXuat (
    MaHang CHAR(6) PRIMARY KEY, 
    TenHang NVARCHAR(100) NOT NULL UNIQUE,  
    QuocGia NVARCHAR(100) NULL,
    Logo NVARCHAR(MAX) NULL,
    GhiChu NVARCHAR(MAX) NULL  
);
GO

-- Bảng Loại Sản Phẩm (điện thoại, phụ kiện, v.v.)
CREATE TABLE LoaiSanPham (
    MaLoai CHAR(6) PRIMARY KEY, 
    TenLoai NVARCHAR(100) NOT NULL UNIQUE,  
    GhiChu NVARCHAR(MAX) NULL  
);
GO

-- Bảng Sản Phẩm
CREATE TABLE SanPham (
    MaSP CHAR(6) PRIMARY KEY,
    TenSP NVARCHAR(100) NOT NULL, 
    MaHang CHAR(6) NOT NULL,
    MaLoai CHAR(6) NOT NULL,
    DonGia DECIMAL(12,0) NOT NULL CHECK (DonGia >= 0),  
    SoLuongTon INT NOT NULL DEFAULT 0,
    MoTa NVARCHAR(MAX) NULL,
    ThongSoKyThuat NVARCHAR(MAX) NULL,
    HinhAnh NVARCHAR(MAX) NULL, 
    TrangThai BIT NOT NULL DEFAULT 1,  
    CONSTRAINT FK_SanPham_Hang FOREIGN KEY (MaHang) REFERENCES HangSanXuat(MaHang) 
        ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_SanPham_Loai FOREIGN KEY (MaLoai) REFERENCES LoaiSanPham(MaLoai) 
        ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Bảng Hóa Đơn (thay cho PhieuBanHang)
CREATE TABLE HoaDon (
    MaHD CHAR(6) PRIMARY KEY,  
    MaKH CHAR(6) NULL,  
    MaNV CHAR(6) NULL,  
    NgayTao DATETIME NOT NULL DEFAULT GETDATE(),  
    TongTien DECIMAL(12,0) NOT NULL DEFAULT 0,
    GiamGia DECIMAL(5,2) DEFAULT 0,
    ThanhTien DECIMAL(12,0) NOT NULL DEFAULT 0,
    TrangThai BIT NOT NULL DEFAULT 0,  -- 0: Chưa thanh toán, 1: Đã thanh toán
    CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH) 
        ON DELETE SET NULL ON UPDATE CASCADE,
    CONSTRAINT FK_HoaDon_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) 
        ON DELETE SET NULL ON UPDATE CASCADE
);
GO

-- Bảng Chi Tiết Hóa Đơn (thay cho ChiTietPhieu)
CREATE TABLE ChiTietHD (
    MaCTHD CHAR(6) PRIMARY KEY,  
    MaHD CHAR(6) NOT NULL,  
    MaSP CHAR(6) NOT NULL,  
    SoLuong INT NOT NULL CHECK (SoLuong > 0),  
    DonGia DECIMAL(12,0) NOT NULL CHECK (DonGia >= 0),  
    ThanhTien DECIMAL(12,0) NOT NULL,
    CONSTRAINT FK_ChiTietHD_HoaDon FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD) 
        ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_ChiTietHD_SanPham FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP) 
        ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Bảng Phiếu Nhập Hàng
CREATE TABLE PhieuNhap (
    MaPN CHAR(6) PRIMARY KEY,
    MaNV CHAR(6) NULL,
    NgayNhap DATETIME NOT NULL DEFAULT GETDATE(),
    TongTien DECIMAL(12,0) NOT NULL DEFAULT 0,
    GhiChu NVARCHAR(MAX) NULL,
    CONSTRAINT FK_PhieuNhap_NhanVien FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV) 
        ON DELETE SET NULL ON UPDATE CASCADE
);
GO

-- Bảng Chi Tiết Phiếu Nhập
CREATE TABLE ChiTietPN (
    MaCTPN CHAR(6) PRIMARY KEY,
    MaPN CHAR(6) NOT NULL,
    MaSP CHAR(6) NOT NULL,
    SoLuong INT NOT NULL CHECK (SoLuong > 0),
    DonGiaNhap DECIMAL(12,0) NOT NULL CHECK (DonGiaNhap >= 0),
    ThanhTien DECIMAL(12,0) NOT NULL,
    CONSTRAINT FK_ChiTietPN_PhieuNhap FOREIGN KEY (MaPN) REFERENCES PhieuNhap(MaPN) 
        ON DELETE CASCADE ON UPDATE CASCADE,
    CONSTRAINT FK_ChiTietPN_SanPham FOREIGN KEY (MaSP) REFERENCES SanPham(MaSP) 
        ON DELETE CASCADE ON UPDATE CASCADE
);
GO

-- Thêm trigger để tự động cập nhật tổng tiền hóa đơn
CREATE TRIGGER trg_UpdateTongTienHD
ON ChiTietHD
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @MaHD CHAR(6)
    
    -- Lấy mã hóa đơn từ bản ghi bị ảnh hưởng
    SELECT @MaHD = MaHD FROM inserted
    IF @MaHD IS NULL
        SELECT @MaHD = MaHD FROM deleted
    
    -- Cập nhật tổng tiền và thành tiền
    UPDATE HoaDon
    SET TongTien = (SELECT SUM(ThanhTien) FROM ChiTietHD WHERE MaHD = @MaHD),
        ThanhTien = (SELECT SUM(ThanhTien) FROM ChiTietHD WHERE MaHD = @MaHD) * (1 - GiamGia/100)
    WHERE MaHD = @MaHD
END;
GO

-- Thêm trigger để tự động cập nhật tổng tiền phiếu nhập
CREATE TRIGGER trg_UpdateTongTienPN
ON ChiTietPN
AFTER INSERT, UPDATE, DELETE
AS
BEGIN
    DECLARE @MaPN CHAR(6)
    
    -- Lấy mã phiếu nhập từ bản ghi bị ảnh hưởng
    SELECT @MaPN = MaPN FROM inserted
    IF @MaPN IS NULL
        SELECT @MaPN = MaPN FROM deleted
    
    -- Cập nhật tổng tiền
    UPDATE PhieuNhap
    SET TongTien = (SELECT SUM(ThanhTien) FROM ChiTietPN WHERE MaPN = @MaPN)
    WHERE MaPN = @MaPN
END;
GO

-- Thêm trigger để cập nhật số lượng tồn khi nhập hàng
CREATE TRIGGER trg_UpdateSoLuongTon_Nhap
ON ChiTietPN
AFTER INSERT
AS
BEGIN
    UPDATE SanPham
    SET SoLuongTon = SoLuongTon + i.SoLuong
    FROM SanPham sp
    INNER JOIN inserted i ON sp.MaSP = i.MaSP
END;
GO

-- Thêm trigger để cập nhật số lượng tồn khi bán hàng
CREATE TRIGGER trg_UpdateSoLuongTon_Ban
ON ChiTietHD
AFTER INSERT
AS
BEGIN
    UPDATE SanPham
    SET SoLuongTon = SoLuongTon - i.SoLuong
    FROM SanPham sp
    INNER JOIN inserted i ON sp.MaSP = i.MaSP
END;
GO

-- Thêm dữ liệu mẫu
-- Hãng sản xuất
INSERT INTO HangSanXuat (MaHang, TenHang, QuocGia) VALUES
('HANG01', N'Apple', N'Mỹ'),
('HANG02', N'Samsung', N'Hàn Quốc'),
('HANG03', N'Xiaomi', N'Trung Quốc'),
('HANG04', N'Oppo', N'Trung Quốc'),
('HANG05', N'Nokia', N'Phần Lan');
GO

-- Loại sản phẩm
INSERT INTO LoaiSanPham (MaLoai, TenLoai) VALUES
('LSP01', N'Điện thoại'),
('LSP02', N'Máy tính bảng'),
('LSP03', N'Phụ kiện'),
('LSP04', N'Đồng hồ thông minh'),
('LSP05', N'Laptop');
GO

-- Sản phẩm
INSERT INTO SanPham (MaSP, TenSP, MaHang, MaLoai, DonGia, SoLuongTon, ThongSoKyThuat) VALUES
('SP001', N'iPhone 15 Pro Max', 'HANG01', 'LSP01', 30000000, 50, N'Màn hình 6.7", Chip A17 Pro, RAM 8GB, 256GB'),
('SP002', N'Galaxy S23 Ultra', 'HANG02', 'LSP01', 25000000, 40, N'Màn hình 6.8", Snapdragon 8 Gen 2, RAM 12GB, 256GB'),
('SP003', N'Redmi Note 12', 'HANG03', 'LSP01', 5000000, 100, N'Màn hình 6.67", Snapdragon 685, RAM 6GB, 128GB'),
('SP004', N'AirPods Pro 2', 'HANG01', 'LSP03', 6000000, 80, N'Tai nghe không dây, chống ồn chủ động'),
('SP005', N'Galaxy Tab S9', 'HANG02', 'LSP02', 18000000, 30, N'Màn hình 11", Snapdragon 8 Gen 2, RAM 12GB, 256GB');
GO

-- Nhân viên
INSERT INTO NhanVien (MaNV, HoTen, Email, MatKhau, VaiTro, TrangThai) VALUES
('NV001', N'Nguyễn Văn Quản trị', 'admin@phonestore.com', '123456', 1, 1),
('NV002', N'Trần Thị Nhân viên', 'nhanvien@phonestore.com', '123456', 0, 1),
('NV003', N'Lê Văn Bán hàng', 'banhang@phonestore.com', '123456', 0, 1);
GO

-- Khách hàng
INSERT INTO KhachHang (MaKH, HoTen, Email, SoDienThoai, DiemTichLuy) VALUES
('KH001', N'Phạm Văn Khách', 'khach1@gmail.com', '0987654321', 100),
('KH002', N'Hoàng Thị Hàng', 'khach2@gmail.com', '0987654322', 50),
('KH003', N'Đỗ Văn VIP', 'khach3@gmail.com', '0987654323', 500);
GO

-- Hóa đơn
INSERT INTO HoaDon (MaHD, MaKH, MaNV, NgayTao, TrangThai) VALUES
('HD001', 'KH001', 'NV002', '2023-10-01 09:00:00', 1),
('HD002', 'KH002', 'NV003', '2023-10-02 10:30:00', 1),
('HD003', 'KH003', 'NV002', '2023-10-03 14:15:00', 1);
GO

-- Chi tiết hóa đơn
INSERT INTO ChiTietHD (MaCTHD, MaHD, MaSP, SoLuong, DonGia, ThanhTien) VALUES
('CT001', 'HD001', 'SP001', 1, 30000000, 30000000),
('CT002', 'HD001', 'SP004', 1, 6000000, 6000000),
('CT003', 'HD002', 'SP002', 1, 25000000, 25000000),
('CT004', 'HD003', 'SP003', 2, 5000000, 10000000),
('CT005', 'HD003', 'SP005', 1, 18000000, 18000000);
GO

-- Phiếu nhập
INSERT INTO PhieuNhap (MaPN, MaNV, NgayNhap) VALUES
('PN001', 'NV001', '2023-09-28 08:00:00'),
('PN002', 'NV001', '2023-09-29 10:00:00');
GO

-- Chi tiết phiếu nhập
INSERT INTO ChiTietPN (MaCTPN, MaPN, MaSP, SoLuong, DonGiaNhap, ThanhTien) VALUES
('CTN01', 'PN001', 'SP001', 20, 28000000, 560000000),
('CTN02', 'PN001', 'SP002', 15, 23000000, 345000000),
('CTN03', 'PN002', 'SP003', 50, 4500000, 225000000),
('CTN04', 'PN002', 'SP004', 30, 5500000, 165000000),
('CTN05', 'PN002', 'SP005', 10, 17000000, 170000000);
GO