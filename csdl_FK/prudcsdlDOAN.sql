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
	DiaChi nvarchar(231),
	--MaTaiKhoan char(10),
	MaNganh char(10)
);
go
create table TAIKHOAN 
(
	MaTaiKhoan char(10) NOT NULL PRIMARY KEY,
	MatKhau nchar(20),
	LoaiTaiKhoan char(5),
	MaGiaoVuTao char(10)
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
	NienHoc char(20),
	MaGiaoVu char(10),
	MaChuyenDe char(10),
	TrangThai bit --0 Dong, 1: Dang Mo
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
	NienHoc char(20),
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
	DiaChi nvarchar(231)
);
create table GIAOVIEN
(
	MaGiaoVien char(10) NOT NULL PRIMARY KEY,
	TenGiaoVien nvarchar(50),
	Phai bit, --1 nam, 0 nu
	NgaySinh datetime,
	DiaChi nvarchar(231),
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
ADD  CONSTRAINT [FK_SINHVIEN_TAIKHOAN] FOREIGN KEY([MaSinhVien])
REFERENCES [dbo].[TAIKHOAN] ([MaTaiKhoan])
GO
--k5
ALTER TABLE [dbo].[TAIKHOAN]  WITH CHECK 
ADD  CONSTRAINT [FK_TAIKHOAN_GIAOVU] FOREIGN KEY([MaGiaoVuTao])
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
--k14
ALTER TABLE [dbo].[GIAOVU]  WITH CHECK 
ADD  CONSTRAINT [FK_GIAOVU_TAIKHOAN] FOREIGN KEY([MaGiaoVu])
REFERENCES [dbo].[TAIKHOAN] ([MaTaiKhoan])


-------------------------------
-----UPDATE THÊM DỮ LIỆU

--INSERT INTO NGANH
insert into NGANH(MaNganh,TenNganh,SoSinhVienTheoHoc,SoChuyenDeToiDa)
values ('N1',N'Công Nghệ Thông Tin',500,5),
		('N2',N'Công Nghệ Sinh Học',500,5),
		('N3',N'Vật Lí',200,4),
		('N4',N'Hoá Học',350,6),
		('N5',N'Sinh Học',400,7),
		('N6',N'Môi Trường',100,5),
		('N7',N'Vật Lí Hạt Nhân',50,4)
--INSERT INTO CHUYENDE
insert into CHUYENDE(MaChuyenDe, TenChuyenDe, SoSinhVienToiDa, MaNganh)
values ('CD1',N'Mạng Máy Tính',50,'N1'),
	   ('CD2',N'Quản trị cơ sở dữ liệu',150,'N1'),
	   ('CD3',N'Xác suất thống kê',50,'N2'),
	   ('CD4',N'Cơ nhiệt',80,'N3'),
	   ('CD5',N'Hóa đại cương 1',150,'N4'),
	   ('CD6',N'Hóa phân tích 1',75,'N4'),
	   ('CD7',N'Sinh Lý Thực Vật',70,'N5'),
	   ('CD8',N'Sinh học tế bào',60,'N5'),
	   ('CD9',N'Kinh tế môi trường',70,'N6'),
	   ('CD10',N'Điện Tử Cao Tần',80,'N7'),
	   ('CD11',N'Khoa Học Vật Liệu Cơ Bản',50,'N7')
--INSERT INTO GIAOVIEN
insert into GIAOVIEN(MaGiaoVien,TenGiaoVien,Phai,NgaySinh,DiaChi,MaChuyenDe)
values('GV1',N'Tô Ngọc Vân',0,18-08-1992,N'Số 1 Nguyễn Văn Cừ, phường Cầu Ông Lãnh, quận 1, TP Hồ Chí Minh','CD1'),
	  ('GV2',N'Phạm Nguyễn Sơn Tùng',1,18-08-1984,N'Số 2 Phạm Ngũ Lão, phường Cầu Ông Lãnh, quận 1, TP Hồ Chí Minh','CD1'),
	  ('GV3',N'Nguyễn Đức Huy',1,20-03-1990,N'Số 3 Trần Hưng Đạo, phường Cầu Ông Lãnh, quận 1, TP Hồ Chí Minh','CD3'),
	  ('GV4',N'Thái Hùng Văn',1,11-09-1980,N'Số 4 Nguyễn Cư Trinh, quận 2, TP Hồ Chí Minh','CD4'),
	  ('GV5',N'Đặng Bình Phương',1,01-02-1984,N'Số 5 Hoàng Hoa Thám, quận 3, TP Hồ Chí Minh','CD5'),
	  ('GV6',N'Nguyễn Ngọc Thảo',0,08-08-1987,N'Số 6 Trương Định, quận 4, TP Hồ Chí Minh','CD6'),
	  ('GV7',N'Tiết Gia Hồng',0,02-02-1984,N'Số 7 Nguyễn Tri Phương, quận 8, TP Hồ Chí Minh','CD7'),
	  ('GV8',N'Nguyễn Phạm Phương Nam',1,10-02-1984,N'Số 8 An Dương Vương, quận Tân Bình, TP Hồ Chí Minh','CD8'),
	  ('GV9',N'Hồ Lê Thị Kim Nhung',0,18-08-1990,N'Số 9 Lý Thái Tổ, quận 5, TP Hồ Chí Minh','CD9'),
	  ('GV10',N'Lương Vỹ Minh',1,05-05-1984,N'Số 10 Lê Lai, quận 1, TP Hồ Chí Minh','CD10'),
	  ('GV11',N'Hồ Tuấn Thanh',1,23-08-1980,N'Số 11, quận 3, TP Hồ Chí Minh','CD11'),
	  ('GV12',N'Hồ Trung Hiếu',1,01-06-1997,N'Số 135 Trần Hưng Đạo, phường Cầu Ông Lãnh, quận 1, TP Hồ Chí Minh','CD2')
--INSERT TAI KHOAN GIAO VU GOC
insert into TAIKHOAN(MaTaiKhoan,MatKhau,LoaiTaiKhoan,MaGiaoVuTao)
values('GVU1','GVU1','GVU',null)
--INSERT GIAOVU GOC
insert into GIAOVU(MaGiaoVu,TenGiaoVu,Phai,NgaySinh ,DiaChi)
values('GVU1',N'Nguyễn Bá Đạo',1 ,18-06-1992,N'Số 16C Tôn Đức Thắng, phường Mỹ Bình, TP. Long Xuyên, tỉnh An Giang')


--INSERT INTO TAIKHOAN GIAOVU
insert into TAIKHOAN(MaTaiKhoan,MatKhau,LoaiTaiKhoan,MaGiaoVuTao)
values
	  ('GVU2','GVU2','GVU','GVU1'),
	  ('GVU3','GVU3','GVU','GVU1'),
	  ('GVU4','GVU4','GVU','GVU1'),
	  ('GVU5','GVU5','GVU','GVU1')
--INSERT INTO GIAOVU
insert into GIAOVU(MaGiaoVu,TenGiaoVu,Phai,NgaySinh ,DiaChi)
values
	  ('GVU2',N'Nguyễn Tường Minh',1,18-06-1982,N'Số 1 Phạm Văn Đồng, phường Phước Trung, TP. Bà Rịa, tỉnh Bà Rịa – Vũng Tàu'),
	  ('GVU3',N'Hoàng Bảo Ngân',0,18-06-1991,N'Số 04 đường Phan Đình Phùng, phường 3, TP.Bạc Liêu, tỉnh Bạc Liêu'),
	  ('GVU4',N'Minh Huyền',0,18-06-1990,N'Số 82  đường Hùng Vương, TP. Bắc Giang, tỉnh Bắc Giang'),
	  ('GVU5',N'Phan Bá Tánh',1,18-06-1993,N'Tổ 1A, phường Phùng Chí Kiên, TX.Bắc Kạn, tỉnh Bắc Kạn')
--INSERT INTO TAIKHOAN SINHVINE
insert into TAIKHOAN(MaTaiKhoan,MatKhau,LoaiTaiKhoan,MaGiaoVuTao)
values('SV1','SV1','SV','GVU1'),
	  ('SV2','SV2','SV','GVU1'),
	  ('SV3','SV3','SV','GVU2'),
	  ('SV4','SV4','SV','GVU3'),
	  ('SV5','SV5','SV','GVU4'),
	  ('SV6','SV6','SV','GVU2'),
	  ('SV7','SV7','SV','GVU1')
--INSERT INTO SINHVIEN
insert into SINHVIEN(MaSinhVien, TenSinhVien,Phai,NgaySinh,DiaChi,MaNganh)
values('SV1', N'Hoàng Nguyễn Bình An',1,31-6-1998,N'Số 7D, Đường số 4, Khu phố 6, Phường Hiệp Bình Phước, Quận Thủ Đức, TP Hồ Chí Minh','N1'),
	  ('SV2', N'Phạm Thiên Thành',1,1-4-1998,N'465 An Dương Vương, Phường 03, Quận 5, TP Hồ Chí Minh','N2'),
	  ('SV3', N'Dương Hoàng Anh',1,1-5-1998,N'Tòa nhà Hưng Bình, Số 404-406-406/2 Ung Văn Khiêm, Phường 25, Quận Bình Thạnh, TP Hồ Chí Minh','N3'),
	  ('SV4', N'Nguyễn Vũ Minh Ngọc',0,5-8-1998,N'19N Nguyễn Hữu Cảnh, Phường 19, Quận Bình Thạnh, TP Hồ Chí Minh','N4'),
	  ('SV5', N'Mai Minh Phương',0,12-8-1998,N'Lô L2-12,L2 Vincom Center Landmark 81,số 772 Điện Biên Phủ, Phường 22, Quận Bình Thạnh, TP Hồ Chí Minh','N5'),
	  ('SV6', N'Vũ Minh Thư',0,21-6-1998,N'Số 7-9 Nguyễn Bỉnh Khiêm, Phường Bến Nghé, Quận 1, TP Hồ Chí Minh','N1'),
	  ('SV7', N'Nguyễn Mạnh Tùng',1,9-10-1998,N'Phòng 501, Lầu 5, số 13C đường 12, Khu phố 4, Phường Bình An, Quận 2, TP Hồ Chí Minh','N3')
--INSERT INTO HOCKY
insert into HOCKY(HocKy,NienHoc,NgayBatDau,NgayKetThuc)
values(1,'2015-2016',01-08-2015,31-12-2015),
	  (2,'2015-2016',01-01-2016,31-05-2016),
	  (1,'2016-2017',01-08-2016,31-12-2016),
	  (2,'2016-2017',01-01-2017,31-05-2017),
	  (1,'2017-2018',01-08-2017,31-12-2017),
	  (2,'2017-2018',01-01-2018,31-05-2018),
	  (1,'2018-2019',01-08-2018,31-12-2018),
	  (2,'2018-2019',01-01-2019,31-05-2019)
--INSERT INTO LOP
insert into LOPHOC(MaLop,TenLop)
values('L1','CQO1'),
	  ('L2','CQO2'),
	  ('L3','CQO3'),
	  ('L4','CQO4'),
	  ('L5','CQO5')
--INSERT INTO THONGTINMOCHUYENDE
insert THONGTINMOCHUYENDE(MaThongTinMoChuyenDe, HocKy, NienHoc, MaGiaoVu, MaChuyenDe,TrangThai)
	values('MCD1',1,'2017-2018','GVU1','CD1',0),
		  ('MCD2',1,'2017-2018','GVU2','CD2',1),
		  ('MCD3',1,'2017-2018','GVU5','CD3',1),
		  ('MCD4',1,'2017-2018','GVU3','CD4',1),
		  ('MCD5',1,'2017-2018','GVU4','CD5',1),
		  ('MCD6',2,'2017-2018','GVU1','CD6',1),
		  ('MCD7',2,'2017-2018','GVU4','CD7',1),
		  ('MCD8',2,'2017-2018','GVU2','CD8',1),
		  ('MCD9',2,'2017-2018','GVU5','CD9',1),
		  ('MCD10',2,'2017-2018','GVU3','CD10',1)
--INSERT INTO THONGTINDANGKY
insert THONGTINDANGKY(MaDangKy, MaSinhVien, MaThongTinMoChuyenDe, MaLop)
  VALUES('DK1','SV1','MCD1','L1'),
		('DK2','SV1','MCD2','L2'),
		('DK3','SV2','MCD1','L1'),
		('DK4','SV2','MCD2','L2'),
		('DK5','SV2','MCD4','L4'),
		('DK6','SV3','MCD5','L2'),
		('DK7','SV4','MCD6','L3'),
		('DK8','SV5','MCD3','L4'),
		('DK9','SV5','MCD7','L4'),
		('DK10','SV6','MCD9','L5')
--INSERT NHOM
insert into NHOM(MaNhom,TenNhom,TrangThai)
  VALUES('NH1',N'0 anh em',1),--MCD1
		('NH2',N'1 anh em',1),--MCD2
		('NH3',N'2 anh em',0),--MCD2
		('NH4',N'3 anh em',1),--MCD3
		('NH5',N'4 anh em',0)--MCD4
--INSERT THANHVIEN
insert into THANHVIEN(MaDangKy,MaNhom,VaiTro)
  VALUES('DK1','NH1',N'trưởng nhóm'),--MCD1
		('DK3','NH1',N'thành viên'),
		('DK2','NH4',N'trưởng nhóm'),--MCD2
		('DK4','NH3',N'trưởng nhóm'),--MCD2
		('DK8','NH4',N'thành viên'),--MCD3
		('DK5','NH5',N'trưởng nhóm')--MCD4


select *
from THONGTINDANGKY