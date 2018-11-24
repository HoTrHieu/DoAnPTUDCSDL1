--database QuanLyChyenDe
create database QuanLyChuyenDe
go
use QuanLyChuyenDe
go

--tạo bảng
create table SINHVIEN 
(
	MaSinhVien char(10)NOT NULL PRIMARY KEY,
	TenSinhVien nvarchar(50),
	Phai bit,--true and 1 is men, 0 is women
	NgaySinh datetime,
	DiaChi text,
	MaTaiKhoan char(10),
	MaNganh char(10)
);
go
create table TAIKHOAN 
(
	MaTaiKhoan char(10) NOT NULL PRIMARY KEY,
	MaSinhVien char(10),
	MatKhau nchar(20),
	MaGiaoVu char(10)
);
go
create table THONGTINDANGKY 
(
	MaDangKy char(10) NOT NULL PRIMARY KEY,
	MaSinhVien char(10),
	MaThongTinMoChuyenDe char(10),
	MaLop char(10)
);
go
create table LOPHOC
(
	MaLop char(10) NOT NULL PRIMARY KEY,
	TenLop nvarchar(50),
);
go
create table NHOM 
(
	MaNhom char(10) not null PRIMARY KEY(MaNhom),
	TenNhom nvarchar(30),
	TrangThai bit --0 đủ thành viên, 1 thiếu thành viên
);
go
create table THANHVIEN
(
	MaDangKy char(10),
	MaNhom char(10),
	VaiTro nchar(20)	--nhomtruong, thanhvien!
	PRIMARY KEY(MaNhom,MaDangKy)
);
go
create table NGANH 
(
	MaNganh char(10)NOT NULL PRIMARY KEY,
	TenNganh nvarchar(50),
	SoSinhVienTheoHoc int,
	SoChuyenDeToiDa int
);
go
create table THONGTINMOCHUYENDE 
(
	MaThongTinMoChuyenDe char(10)NOT NULL PRIMARY KEY,
	HocKy int,
	NienHoc int,
	MaGiaoVu char(10),
	MaChuyenDe char(10)
);
go
create table CHUYENDE 
(
	MaChuyenDe char(10)NOT NULL PRIMARY KEY,
	TenChuyenDe nvarchar(50),
	SoSinhVienToiDa int,
	MaNganh char(10)
);
go
create table HOCKY 
(
	HocKy int,
	NienHoc int,
	NgayBatDau datetime,
	NgayKetThuc datetime
	PRIMARY KEY(HocKy,NienHoc)
);
go
create table GIAOVU 
(
	MaGiaoVu char(10)NOT NULL PRIMARY KEY,
	TenGiaoVu nvarchar(50),
	Phai bit,
	NgaySinh datetime,
	DiaChi text
);
create table GIAOVIEN
(
	MaGiaoVien char(10) NOT NULL PRIMARY KEY,
	TenGiaoVien nvarchar(50),
	Phai bit, --1 nam, 0 nu
	NgaySinh datetime,
	DiaChi text,
	MaChuyenDe char(10)
)


go
-----------------------------khoa ngoai
--k1
ALTER TABLE [dbo].[CHUYENDE]  WITH CHECK
ADD  CONSTRAINT [FK_CHUYENDE_NGANH] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[NGANH] ([MaNganh])
GO
--k2
ALTER TABLE [dbo].[THONGTINDANGKY]  WITH CHECK 
ADD  CONSTRAINT [FK_THONGTINDANGKY_LOPHOC] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOPHOC] ([MaLop])
GO
--k3
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK 
ADD  CONSTRAINT [FK_SINHVIEN_NGANH] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[NGANH] ([MaNganh])
GO
--k4
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK 
ADD  CONSTRAINT [FK_SINHVIEN_TAIKHOAN] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TAIKHOAN] ([MaTaiKhoan])
GO
--k5
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK 
ADD  CONSTRAINT [FK_TAIKHOAN_GIAOVU] FOREIGN KEY([MaGiaoVu])
REFERENCES [dbo].[GIAOVU] ([MaGiaoVu])
GO
--k6
ALTER TABLE [dbo].[THANHVIEN]  WITH CHECK 
ADD  CONSTRAINT [FK_THANHVIEN_NHOM] FOREIGN KEY([MaNhom])
REFERENCES [dbo].[NHOM] ([MaNhom])
GO
--k7
ALTER TABLE [dbo].[THANHVIEN]  WITH CHECK 
ADD  CONSTRAINT [FK_THANHVIEN_THONGTINDANGKY] FOREIGN KEY([MaDangKy])
REFERENCES [dbo].[THONGTINDANGKY] ([MaDangKy])
GO
--k8
ALTER TABLE [dbo].[THONGTINDANGKY]  WITH CHECK 
ADD  CONSTRAINT [FK_THONGTINDANGKY_SINHVIEN] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[SINHVIEN] ([MaSinhVien])
GO
--k9
ALTER TABLE [dbo].[THONGTINDANGKY]  WITH CHECK 
ADD  CONSTRAINT [FK_THONGTINDANGKY_THONGTINMOCHUYENDE] FOREIGN KEY([MaThongTinMoChuyenDe])
REFERENCES [dbo].[THONGTINMOCHUYENDE] ([MaThongTinMoChuyenDe])
GO
--k10
ALTER TABLE [dbo].[THONGTINMOCHUYENDE]  WITH CHECK 
ADD  CONSTRAINT [FK_THONGTINMOCHUYENDE_CHUYENDE] FOREIGN KEY([MaChuyenDe])
REFERENCES [dbo].[CHUYENDE] ([MaChuyenDe])
GO
--k11
ALTER TABLE [dbo].[THONGTINMOCHUYENDE]  WITH CHECK 
ADD  CONSTRAINT [FK_THONGTINMOCHUYENDE_GIAOVU] FOREIGN KEY([MaGiaoVu])
REFERENCES [dbo].[GIAOVU] ([MaGiaoVu])
GO
--k12
ALTER TABLE [dbo].[THONGTINMOCHUYENDE]  WITH CHECK 
ADD  CONSTRAINT [FK_THONGTINMOCHUYENDE_HOCKY] FOREIGN KEY([HocKy], [NienHoc])
REFERENCES [dbo].[HOCKY] ([HocKy], [NienHoc])
GO
--k13
ALTER TABLE [dbo].[GIAOVIEN]  WITH CHECK 
ADD  CONSTRAINT [FK_GIAOVIEN_CHUYENDE] FOREIGN KEY([MaChuyenDe])
REFERENCES [dbo].[CHUYENDE] ([MaChuyenDe])




