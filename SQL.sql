-- Tạo database
CREATE DATABASE IF NOT EXISTS HoaDonDB
  CHARACTER SET utf8mb4
  COLLATE utf8mb4_unicode_ci;

USE HoaDonDB;

-- Bảng tài khoản
DROP TABLE IF EXISTS account;
CREATE TABLE account (
  id INT AUTO_INCREMENT PRIMARY KEY,
  username VARCHAR(50) NOT NULL UNIQUE,
  password VARCHAR(100) NOT NULL
);

-- Bảng hóa đơn
DROP TABLE IF EXISTS hoadon;
CREATE TABLE hoadon (
  MaHD INT AUTO_INCREMENT PRIMARY KEY,
  NgayGhi DATE NOT NULL,
  KhachHang VARCHAR(100) NOT NULL,
  Tencongty_khachhang VARCHAR(150),
  DiaChi VARCHAR(200),
  TongTien DECIMAL(15,2) NOT NULL DEFAULT 0.00,
  MaSoThue VARCHAR(20)
);

-- User mẫu
INSERT INTO account(username, password) VALUES 
('admin', '123456'),
('user1', '111111'),
('user2', '222222');

-- Dữ liệu mẫu bảng hóa đơn
INSERT INTO hoadon (NgayGhi, KhachHang, Tencongty_khachhang, DiaChi, TongTien, MaSoThue) VALUES
('2025-09-01','Nguyen Van A','CTCP ABC','Ha Noi',1500000,'0101234567'),
('2025-09-02','Tran Thi B','CT TNHH B','Ho Chi Minh',3200000,'0312345678'),
('2025-09-05','Le Van C','CTCP XYZ','Da Nang',2500000,'0408765432'),
('2025-09-07','Pham Thi D','CTCP DEF','Hai Phong',4500000,'0209876543'),
('2025-09-10','Hoang Van E','CT TNHH EFG','Can Tho',5000000,'0601928374');