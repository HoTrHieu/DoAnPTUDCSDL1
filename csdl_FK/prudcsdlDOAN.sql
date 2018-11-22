--database QuanLyChyenDe
create database QuanLyChuyenDe07
go
use QuanLyChuyenDe07
go

--tạo bảng
create table SINHVIEN 
(
	MaSinhVien nchar(10)NOT NULL PRIMARY KEY,
	TenSinhVien nvarchar(50),
	Phai bit,--true and 1 is men, 0 is women
	NgaySinh datetime,
	DiaChi nvarchar(50),
	MaTaiKhoan nchar(10),
	MaNganh nchar(10)
);
go
create table TAIKHOAN 
(
	MaTaiKhoan nchar(10) NOT NULL PRIMARY KEY,
	MaSinhVien nchar(10),
	MatKhau nchar(20),
	MaGiaoVu nchar(10)
);
go
create table THONGTINDANGKY 
(
	MaDangKy nchar(10) NOT NULL PRIMARY KEY,
	MaSinhVien nchar(10),
	MaThongTinMoChuyenDe nchar(10)
);
go
create table LOPHOC
(
	MaLop nchar(10) NOT NULL PRIMARY KEY,
	TenLop nvarchar(50),
	MaDangKy nchar(10)
);
go
create table NHOM 
(
	MaNhom nchar(10),
	TenNhom nvarchar(30),
	MaLop nchar(10),
	PRIMARY KEY(MaNhom,MaLop)
);
go
create table THANHVIEN
(
	MaSinhVien nchar(10),
	MaLop nchar(10),
	MaNhom nchar(10),
	VaiTro nchar(20)	--nhomtruong, thanhvien!
	PRIMARY KEY(MaLop,MaNhom,MaSinhVien)
);
go
create table NGHANH 
(
	MaNganh nchar(10)NOT NULL PRIMARY KEY,
	TenNganh nvarchar(50),
	SoSinhVienTheoHoc int,
	SoChuyenDeToiDa int
);
go
create table THONGTINMOCHUYENDE 
(
	MaThongTinMoChuyenDe nchar(10)NOT NULL PRIMARY KEY,
	HocKy int,
	NienHoc int,
	MaGiaoVu nchar(10),
	MaChuyenDe nchar(10)
);
go
create table CHUYENDE 
(
	MaChuyenDe nchar(10)NOT NULL PRIMARY KEY,
	TenChuyenDe nvarchar(50),
	SoSinhVienToiDa int,
	MaGVPhuTrach nchar(10),
	MaNganh nchar(10)
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
	MaGiaoVu nchar(10)NOT NULL PRIMARY KEY,
	TenGiaoVu nvarchar(50),
);



go
-----------------------------khoa ngoai
--k1
ALTER TABLE [dbo].[CHUYENDE]  WITH CHECK
ADD  CONSTRAINT [FK_CHUYENDE_NGHANH] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[NGHANH] ([MaNganh])
GO
--k2
ALTER TABLE [dbo].[LOPHOC]  WITH CHECK 
ADD  CONSTRAINT [FK_LOPHOC_THONGTINDANGKY] FOREIGN KEY([MaDangKy])
REFERENCES [dbo].[THONGTINDANGKY] ([MaDangKy])
GO
--k3
ALTER TABLE [dbo].[NHOM]  WITH CHECK 
ADD  CONSTRAINT [FK_NHOM_LOPHOC] FOREIGN KEY([MaLop])
REFERENCES [dbo].[LOPHOC] ([MaLop])
GO
--k4
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK 
ADD  CONSTRAINT [FK_SINHVIEN_NGHANH] FOREIGN KEY([MaNganh])
REFERENCES [dbo].[NGHANH] ([MaNganh])
GO
--k5
ALTER TABLE [dbo].[SINHVIEN]  WITH CHECK 
ADD  CONSTRAINT [FK_SINHVIEN_TAIKHOAN] FOREIGN KEY([MaTaiKhoan])
REFERENCES [dbo].[TAIKHOAN] ([MaTaiKhoan])
GO
--k6
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK 
ADD  CONSTRAINT [FK_TAIKHOAN_GIAOVU] FOREIGN KEY([MaGiaoVu])
REFERENCES [dbo].[GIAOVU] ([MaGiaoVu])
GO
--k7
ALTER TABLE [dbo].[THANHVIEN]  WITH CHECK 
ADD  CONSTRAINT [FK_THANHVIEN_NHOM] FOREIGN KEY([MaNhom], [MaLop])
REFERENCES [dbo].[NHOM] ([MaNhom], [MaLop])
GO
--k8
ALTER TABLE [dbo].[THANHVIEN]  WITH CHECK 
ADD  CONSTRAINT [FK_THANHVIEN_SINHVIEN] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[SINHVIEN] ([MaSinhVien])
GO
--k9
ALTER TABLE [dbo].[THONGTINDANGKY]  WITH CHECK 
ADD  CONSTRAINT [FK_THONGTINDANGKY_SINHVIEN] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[SINHVIEN] ([MaSinhVien])
GO
--k10
ALTER TABLE [dbo].[THONGTINDANGKY]  WITH CHECK 
ADD  CONSTRAINT [FK_THONGTINDANGKY_THONGTINMOCHUYENDE] FOREIGN KEY([MaThongTinMoChuyenDe])
REFERENCES [dbo].[THONGTINMOCHUYENDE] ([MaThongTinMoChuyenDe])
GO
--k11
ALTER TABLE [dbo].[THONGTINMOCHUYENDE]  WITH CHECK 
ADD  CONSTRAINT [FK_THONGTINMOCHUYENDE_CHUYENDE] FOREIGN KEY([MaChuyenDe])
REFERENCES [dbo].[CHUYENDE] ([MaChuyenDe])
GO
--k12
ALTER TABLE [dbo].[THONGTINMOCHUYENDE]  WITH CHECK 
ADD  CONSTRAINT [FK_THONGTINMOCHUYENDE_GIAOVU] FOREIGN KEY([MaGiaoVu])
REFERENCES [dbo].[GIAOVU] ([MaGiaoVu])
GO
--k13
ALTER TABLE [dbo].[THONGTINMOCHUYENDE]  WITH CHECK 
ADD  CONSTRAINT [FK_THONGTINMOCHUYENDE_HOCKY] FOREIGN KEY([HocKy], [NienHoc])
REFERENCES [dbo].[HOCKY] ([HocKy], [NienHoc])
GO




