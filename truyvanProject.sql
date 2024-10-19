-- Xóa các bảng theo thứ tự từ phụ thuộc đến chính
DROP TABLE IF EXISTS ChiTietHD;
DROP TABLE IF EXISTS NhapHang;
DROP TABLE IF EXISTS DonNhapHang;
DROP TABLE IF EXISTS HoaDon;
DROP TABLE IF EXISTS KhachHang;
DROP TABLE IF EXISTS LinhKien;
DROP TABLE IF EXISTS NhaCungCap;
DROP TABLE IF EXISTS NhomLinhKien;
DROP TABLE IF EXISTS PhanCa;
DROP TABLE IF EXISTS CaLamViec;
DROP TABLE IF EXISTS NhanVien;

-- Tạo bảng NhanVien
CREATE TABLE NhanVien (
    MaNV NVARCHAR(30) CONSTRAINT PK_MaNV PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    SDT CHAR(11) CHECK (LEN(SDT) = 10) NOT NULL,
    NgayBDLamViec DATE CHECK (DATEDIFF(day, NgayBDLamViec, GETDATE()) >= 0) NOT NULL,
    NgaySinh DATE CHECK (DATEDIFF(year, NgaySinh, GETDATE()) >= 18),
    GioiTinh NVARCHAR(3),
    DiaChi NVARCHAR(100),
    Luong FLOAT CHECK (Luong >= 0) NOT NULL
);

-- Tạo bảng CaLamViec
CREATE TABLE CaLamViec (
    MaCa NVARCHAR(30) CONSTRAINT PK_MaCa PRIMARY KEY,
    TenCa NVARCHAR(10) NOT NULL,
    Ngay DATE NOT NULL,
    ThoiGianBD TIME(0) NOT NULL,
    ThoiGianKT TIME(0) NOT NULL,
    CONSTRAINT CHK_ThoiGian CHECK (ThoiGianBD < ThoiGianKT)
);

-- Tạo bảng PhanCa
CREATE TABLE PhanCa (
    MaNhanVien NVARCHAR(30) CONSTRAINT FK_PhanCa_MaNhanVien FOREIGN KEY REFERENCES NhanVien(MaNV),
    MaCa NVARCHAR(30) CONSTRAINT FK_PhanCa_MaCa FOREIGN KEY REFERENCES CaLamViec(MaCa),
    CONSTRAINT PK_PhanCa PRIMARY KEY (MaNhanVien, MaCa)
);

-- Tạo bảng NhomLinhKien
CREATE TABLE NhomLinhKien (
    MaNhom NVARCHAR(30) CONSTRAINT PK_MaNhom PRIMARY KEY,
    TenNhom NVARCHAR(50) NOT NULL,
    SoLuongLK INT CHECK (SoLuongLK >= 0) NOT NULL
);

-- Tạo bảng NhaCungCap
CREATE TABLE NhaCungCap (
    MaNCC NVARCHAR(30) CONSTRAINT PK_MaNCC PRIMARY KEY,
    SDT CHAR(11) CHECK (LEN(SDT) = 10) NOT NULL,
    TenNhaCungCap NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(50) NOT NULL
);

-- Tạo bảng LinhKien
CREATE TABLE LinhKien (
    MaLK NVARCHAR(30) CONSTRAINT PK_MaLK PRIMARY KEY,
    TenLK NVARCHAR(50) NOT NULL,
    GiaTien FLOAT CHECK (GiaTien > 0) NOT NULL,
    MoTa NVARCHAR(500) NOT NULL,
    TrangThai NVARCHAR(20) NOT NULL,
    SoLuong INT CHECK (SoLuong >= 0) NOT NULL,
    MaNhom NVARCHAR(30) CONSTRAINT FK_LinhKien_MaNhom FOREIGN KEY REFERENCES NhomLinhKien(MaNhom),
    MaNCC NVARCHAR(30) CONSTRAINT FK_LinhKien_MaNCC FOREIGN KEY REFERENCES NhaCungCap(MaNCC)
);

Go

ALTER TABLE LinhKien
ADD AnhLK VARBINARY(MAX);
Go

Alter VIEW LinhKienView AS
SELECT 
	LinhKien.MaLK,
    LinhKien.TenLK, 
	LinhKien.SoLuong,
    NhomLinhKien.TenNhom,	 
	LinhKien.TrangThai,
	LinhKien.GiaTien,
	LinhKien.AnhLK,
	LinhKien.MoTa
FROM 
    LinhKien join NhomLinhKien on LinhKien.MaNhom = NhomLinhKien.MaNhom
Go

-- Tạo bảng KhachHang
CREATE TABLE KhachHang (
    MaKH NVARCHAR(30) CONSTRAINT PK_MaKH PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    SDT CHAR(11) CHECK (LEN(SDT) = 10) NOT NULL,
    Email NVARCHAR(50),
    DiaChi NVARCHAR(50) NOT NULL
);

-- Tạo bảng HoaDon
CREATE TABLE HoaDon (
    MaHD NVARCHAR(30) CONSTRAINT PK_MaHD PRIMARY KEY,
    NgayXuat DATE CHECK (DATEDIFF(day, NgayXuat, GETDATE()) >= 0) NOT NULL,
    TongGiaTri FLOAT CHECK (TongGiaTri > 0) NOT NULL,
    MaKH NVARCHAR(30) CONSTRAINT FK_HoaDon_MaKH FOREIGN KEY REFERENCES KhachHang(MaKH),
    MaNV NVARCHAR(30) CONSTRAINT FK_HoaDon_MaNV FOREIGN KEY REFERENCES NhanVien(MaNV)
);

-- Tạo bảng ChiTietHD
CREATE TABLE ChiTietHD (
    MaLK NVARCHAR(30) CONSTRAINT FK_ChiTietHD_MaLK FOREIGN KEY REFERENCES LinhKien(MaLK),
    MaHD NVARCHAR(30) CONSTRAINT FK_ChiTietHD_MaHD FOREIGN KEY REFERENCES HoaDon(MaHD),
    SoLuong INT CHECK (SoLuong > 0) NOT NULL,
    DonGia FLOAT CHECK (DonGia > 0) NOT NULL,
    TongTien FLOAT CHECK (TongTien > 0) NOT NULL,
    CONSTRAINT PK_ChiTietHD PRIMARY KEY (MaLK, MaHD)
);

-- Tạo bảng DonNhapHang
CREATE TABLE DonNhapHang (
    MaDonNhap NVARCHAR(30) CONSTRAINT PK_MaDonNhap PRIMARY KEY,
    NgayNhap DATE CHECK (DATEDIFF(day, NgayNhap, GETDATE()) >= 0) NOT NULL,
    MaNCC NVARCHAR(30) CONSTRAINT FK_DonNhapHang_MaNCC FOREIGN KEY REFERENCES NhaCungCap(MaNCC) NOT NULL,
    GiaTriDonNhap FLOAT CHECK (GiaTriDonNhap > 0) NOT NULL
);

-- Tạo bảng NhapHang
CREATE TABLE NhapHang (
    MaLK NVARCHAR(30) CONSTRAINT FK_NhapHang_MaLK FOREIGN KEY REFERENCES LinhKien(MaLK),
    MaDonNhap NVARCHAR(30) CONSTRAINT FK_NhapHang_MaDonNhap FOREIGN KEY REFERENCES DonNhapHang(MaDonNhap),
    SoLuong INT CHECK (SoLuong > 0),
    DonGia FLOAT CHECK (DonGia > 0),
    TongTien FLOAT CHECK (TongTien > 0),
    CONSTRAINT PK_NhapHang PRIMARY KEY (MaLK, MaDonNhap)
);

-- Xóa các thủ tục
DROP PROCEDURE IF EXISTS sp_InsertKhachHang;
DROP PROCEDURE IF EXISTS sp_InsertLinhKien;
DROP PROCEDURE IF EXISTS sp_UpdateLinhKien;
DROP PROCEDURE IF EXISTS sp_InsertDonNhapHang;
DROP PROCEDURE IF EXISTS sp_InsertNhapHang;
DROP PROCEDURE IF EXISTS sp_insertHoaDon;
DROP PROCEDURE IF EXISTS sp_insertChiTietHD;
DROP PROCEDURE IF EXISTS sp_danhSachDonHang;

-- Xóa các trigger
DROP TRIGGER IF EXISTS tg_genCustomerID;
DROP TRIGGER IF EXISTS trg_genMaDonNhap;
DROP TRIGGER IF EXISTS trg_genMaHD;

-- Xóa các hàm
DROP FUNCTION IF EXISTS fn_checkPhone;
DROP FUNCTION IF EXISTS fn_timTenNV;
DROP FUNCTION IF EXISTS fn_timTenLK;
DROP FUNCTION IF EXISTS fn_timTheoGiaLK;
DROP FUNCTION IF EXISTS fn_timNhomLK;
DROP FUNCTION IF EXISTS fn_timTheoNgayXuat;
DROP FUNCTION IF EXISTS fn_timTheoGiaTri;

Go 
-- Procedure thêm 1 khách hàng vào bảng KhachHang
CREATE PROCEDURE sp_InsertKhachHang
    @HoTen NVARCHAR(50),
    @Phone CHAR(11), 
    @Email NVARCHAR(50),
    @DiaChi NVARCHAR(100)
AS
BEGIN
    INSERT INTO KhachHang (HoTen, SDT, Email, DiaChi)
    VALUES (@HoTen, @Phone, @Email, @DiaChi);
END;
GO

-- Trigger tự động tạo mã khách hàng khi insert vào bảng 
CREATE TRIGGER tg_genCustomerID
ON KhachHang
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO KhachHang (MaKH, HoTen, SDT, Email, DiaChi)
    SELECT 'KH' + i.SDT, i.HoTen, i.SDT, i.Email, i.DiaChi
    FROM inserted i;
END;
GO

-- Hàm kiểm tra số điện thoại đã tồn tại hay chưa
CREATE FUNCTION fn_checkPhone
(
    @Phone CHAR(11)
)
RETURNS BIT
AS
BEGIN
    DECLARE @Result BIT;
    IF EXISTS (
        SELECT 1 
        FROM KhachHang
        WHERE SDT = @Phone
    )
        SET @Result = 1;
    ELSE
        SET @Result = 0;
    RETURN @Result;
END;
GO

-- Procedure thêm 1 linh kiện vào bảng LinhKien
CREATE PROCEDURE sp_InsertLinhKien
    @MaLK NVARCHAR(30),
    @TenLK NVARCHAR(50),
    @GiaTien FLOAT,
    @MoTa NVARCHAR(500),
    @TrangThai NVARCHAR(20),
    @SoLuong INT,
    @MaNhom NVARCHAR(10),
    @MaNCC NVARCHAR(10)
AS
BEGIN
    INSERT INTO LinhKien (MaLK, TenLK, GiaTien, MoTa, TrangThai, SoLuong, MaNhom, MaNCC)
    VALUES (@MaLK, @TenLK, @GiaTien, @MoTa, @TrangThai, @SoLuong, @MaNhom, @MaNCC);
END;
GO

-- Procedure sửa thông tin 1 linh kiện
CREATE PROCEDURE sp_UpdateLinhKien
    @MaLK NVARCHAR(30),
    @TenLK NVARCHAR(50),
    @GiaTien FLOAT,
    @MoTa NVARCHAR(500),
    @TrangThai NVARCHAR(20),
    @SoLuong INT,
    @MaNhom NVARCHAR(30),
    @MaNCC NVARCHAR(30)
AS
BEGIN
    UPDATE LinhKien
    SET TenLK=@TenLK, GiaTien=@GiaTien, MoTa=@MoTa, TrangThai=@TrangThai, SoLuong=@SoLuong, MaNhom=@MaNhom, MaNCC=@MaNCC
    WHERE MaLK = @MaLK;
END;
GO

-- Procedure thêm 1 đơn nhập hàng
CREATE PROCEDURE sp_InsertDonNhapHang
    @NgayNhap DATE,
    @MaNCC NVARCHAR(30),
    @GiaTriDonNhap FLOAT
AS
BEGIN
    INSERT INTO DonNhapHang (NgayNhap, MaNCC, GiaTriDonNhap)
    VALUES (@NgayNhap, @MaNCC, @GiaTriDonNhap);
END;
GO

-- Trigger tự động tạo mã đơn nhập khi thêm đơn nhập hàng
CREATE TRIGGER trg_genMaDonNhap
ON DonNhapHang
INSTEAD OF INSERT 
AS
BEGIN
    INSERT INTO DonNhapHang (MaDonNhap, NgayNhap, MaNCC, GiaTriDonNhap)
    SELECT RTRIM(i.MaNCC) + '_' + FORMAT(i.NgayNhap,'yyMMdd'), i.NgayNhap, i.MaNCC, i.GiaTriDonNhap
    FROM inserted i;
END;
GO

-- Procedure thêm vào bảng NhapHang
CREATE PROCEDURE sp_InsertNhapHang
    @MaLK NVARCHAR(30),
    @MaDonNhap NVARCHAR(30),
    @SoLuong INT,
    @DonGia FLOAT,
    @TongTien FLOAT
AS
BEGIN 
    INSERT INTO NhapHang(MaLK, MaDonNhap, SoLuong, DonGia, TongTien)
    VALUES(@MaLK, @MaDonNhap, @SoLuong, @DonGia, @TongTien);
END;
GO

-- Procedure thêm vào bảng HoaDon
CREATE PROCEDURE sp_insertHoaDon
    @NgayXuat DATE,
    @TongGiaTri FLOAT,
    @MaKH NVARCHAR(30),
    @MaNV NVARCHAR(30)
AS
BEGIN
    INSERT INTO HoaDon(NgayXuat, TongGiaTri, MaKH, MaNV)
    VALUES(@NgayXuat, @TongGiaTri, @MaKH, @MaNV);
END;
GO

-- Tạo function danh sách hóa đơn
Create Function fn_GetHoaDonByMaNV (@MaNV nvarchar(30))
Returns Table
As
Return 
(
    Select 
        HoaDon.MaKH,
        HoaDon.MaHD,
        HoaDon.NgayXuat,
        HoaDon.TongGiaTri,
        KhachHang.HoTen
    From HoaDon 
    Join KhachHang on HoaDon.MaKH = KhachHang.MaKH
    Where HoaDon.MaNV = @MaNV
);
Go	
-- Trigger tự động tạo mã hóa đơn
CREATE TRIGGER trg_genMaHD
ON HoaDon
INSTEAD OF INSERT 
AS
BEGIN
    INSERT INTO HoaDon(MaHD, NgayXuat, TongGiaTri, MaKH, MaNV)
    SELECT RTRIM(i.MaKH) + '_' + RTRIM(i.MaNV) + '_' + FORMAT(i.NgayXuat,'yyMMdd'), i.NgayXuat, i.TongGiaTri, i.MaKH, i.MaNV
    FROM inserted i;
END;
GO

-- Procedure thêm vào bảng ChiTietHD
CREATE PROCEDURE sp_insertChiTietHD
    @MaLK NVARCHAR(30),
    @MaHD NVARCHAR(30),
    @SoLuong INT,
    @DonGia FLOAT,
    @TongTien FLOAT
AS
BEGIN
    INSERT INTO ChiTietHD(MaLK, MaHD, SoLuong, DonGia, TongTien)
    VALUES(@MaLK, @MaHD, @SoLuong, @DonGia, @TongTien);
END;
GO

-- Hàm tìm nhân viên theo tên 
CREATE FUNCTION fn_timTenNV(@name NVARCHAR(50))
RETURNS TABLE
AS
RETURN(
    SELECT * FROM NhanVien WHERE HoTen LIKE '%' + @name + '%'
);
GO

-- Hàm tìm linh kiện theo tên 
ALTER FUNCTION fn_timTenLK(@TenLK NVARCHAR(50))
RETURNS TABLE 
AS
RETURN(
    SELECT *
    FROM LinhKienView
    WHERE TenLK LIKE '%' + @TenLK + '%'
);
GO

-- Hàm tìm linh kiện theo giá tiền (<=)
CREATE FUNCTION fn_timTheoGiaLK(@GiaTien FLOAT)
RETURNS TABLE
AS
RETURN(
    SELECT *
    FROM LinhKien
    WHERE GiaTien <= @GiaTien
);
GO

-- Hàm tìm linh kiện theo nhóm LK
CREATE FUNCTION fn_timNhomLK(@MaNhom NVARCHAR(30))
RETURNS TABLE
AS
RETURN(
    SELECT *
    FROM LinhKien
    WHERE MaNhom LIKE '%' + @MaNhom + '%'
);
GO

-- Procedure hiển thị danh sách lịch sử đơn hàng mà nhân viên đó phụ trách
CREATE PROCEDURE sp_danhSachDonHang
    @MaNV NVARCHAR(30)
AS
BEGIN
    SELECT *
    FROM HoaDon
    WHERE MaNV = @MaNV;
END;
GO

-- Hàm tìm hóa đơn theo ngày xuất hóa đơn
CREATE FUNCTION fn_timTheoNgayXuat(@NgayXuat DATE, @MaNV NVARCHAR(30))
RETURNS TABLE
AS
RETURN(
    SELECT * 
    FROM HoaDon
    WHERE MaNV = @MaNV AND NgayXuat = @NgayXuat
);
GO

-- Hàm tìm hóa đơn theo giá trị hóa đơn
CREATE FUNCTION fn_timTheoGiaTri(@GiaTriMin FLOAT, @GiaTriMax FLOAT, @MaNV NVARCHAR(30))
RETURNS TABLE
AS
RETURN(
    SELECT 
        HoaDon.MaKH,
        HoaDon.MaHD,
        HoaDon.NgayXuat,
        HoaDon.TongGiaTri,
        KhachHang.HoTen
    FROM  HoaDon Join KhachHang on HoaDon.MaKH = KhachHang.MaKH
    WHERE HoaDon.MaNV = @MaNV AND TongGiaTri >= @GiaTriMin AND TongGiaTri <= @GiaTriMax
);
GO

-- Thêm cột trạng thái vào bảng phân ca để xác định đã chấm công hay chưa
ALTER TABLE PhanCa
ADD TrangThai BIT;


-- Thủ tục lấy danh sách ca làm việc đã làm  của nhân viên 
CREATE PROCEDURE sp_GetCaLamViecByNhanVien
    @MaNV NVARCHAR(30)
AS
BEGIN
    SELECT 
        CL.MaCa, 
        CL.TenCa, 
        CL.Ngay, 
        CL.ThoiGianBD, 
        CL.ThoiGianKT
    FROM 
        PhanCa PC
        JOIN CaLamViec CL ON PC.MaCa = CL.MaCa
    WHERE 
        PC.MaNhanVien = @MaNV and
		pc.trangthai=1;
END;
GO
-- Hamf lấy doanh thu theo ca 
CREATE FUNCTION fn_GetDoanhThuByMaCaVaNhanVien (
    @MaCa NVARCHAR(30),
    @MaNhanVien NVARCHAR(30)
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        PC.MaCa, 
        CL.Ngay, 
        ISNULL(COUNT(DISTINCT HD.MaHD), 0) AS SoLuongDonHang, 
        ISNULL(SUM(CTHD.SoLuong), 0) AS SoLuongLinhKien, 
        ISNULL(SUM(HD.TongGiaTri), 0) AS TongDoanhThu
    FROM PhanCa PC
    JOIN CaLamViec CL ON PC.MaCa = CL.MaCa
    LEFT JOIN HoaDon HD ON HD.MaNV = PC.MaNhanVien AND HD.NgayXuat = CL.Ngay
    LEFT JOIN ChiTietHD CTHD ON CTHD.MaHD = HD.MaHD
    WHERE PC.MaCa = @MaCa AND PC.MaNhanVien = @MaNhanVien
    GROUP BY PC.MaCa, CL.Ngay
);
GO
--hàm thực hiện xem doanh thu của nhân viên theo ca trong khoảng thời gian 
Create   FUNCTION fn_GetDoanhThuTheoNgay (
    @MaNhanVien NVARCHAR(30),
    @NgayBatDau DATE,
    @NgayKetThuc DATE
)
RETURNS TABLE
AS
RETURN
(
    SELECT 
        PC.MaCa, 
        CL.Ngay, 
        COUNT(DISTINCT HD.MaHD) AS SoLuongDonHang, 
        ISNULL(SUM(CTHD.SoLuong), 0) AS SoLuongLinhKien, 
        ISNULL(SUM(HD.TongGiaTri), 0) AS TongDoanhThu
    FROM PhanCa PC
    JOIN CaLamViec CL ON PC.MaCa = CL.MaCa
    LEFT JOIN HoaDon HD ON HD.MaNV = PC.MaNhanVien AND HD.NgayXuat = CL.Ngay
    LEFT JOIN ChiTietHD CTHD ON CTHD.MaHD = HD.MaHD
    WHERE  
       PC.MaNhanVien = @MaNhanVien
      AND CL.Ngay BETWEEN @NgayBatDau AND @NgayKetThuc
    GROUP BY PC.MaCa, CL.Ngay
);
GO
-- thủ tục lấy ca làm việc được phân gần nhất để thực hiện chấm công 
Create  PROCEDURE sp_GetCaLamViec
    @MaNV NVARCHAR(30)
AS
BEGIN
    SELECT TOP 1 -- Chỉ lấy 1 phân ca gần nhất
        CL.MaCa, 
        CL.TenCa, 
        CL.Ngay, 
        CL.ThoiGianBD, 
        CL.ThoiGianKT
    FROM 
        PhanCa PC
        JOIN CaLamViec CL ON PC.MaCa = CL.MaCa
    WHERE 
        PC.MaNhanVien = @MaNV
        AND PC.TrangThai = 0 -- Chỉ lấy các phân ca chưa chấm công
        
    ORDER BY 
        DATEDIFF(MINUTE, GETDATE(), CAST(CONCAT(CL.Ngay, ' ', CL.ThoiGianBD) AS DATETIME)) ASC; -- Sắp xếp theo độ gần gũi với thời gian hiện tại
END;
GO
-- thủ tục thực hiện chấm công 
CREATE PROCEDURE sp_ChamCong
    @MaNV NVARCHAR(30),
    @MaCa NVARCHAR(30)
AS
BEGIN
    UPDATE PhanCa
    SET TrangThai = 1 -- 1 có thể đại diện cho "Đã Chấm Công"
    WHERE MaNhanVien = @MaNV AND MaCa = @MaCa;
END;
GO


