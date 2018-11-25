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
values ('N01',N'Công Nghệ Thông Tin',500,5),
		('N02',N'Công Nghệ Sinh Học',500,5),
		('N03',N'Vật Lí',200,4),
		('N04',N'Hoá Học',350,6),
		('N05',N'Sinh Học',400,7),
		('N06',N'Môi Trường',100,5),
		('N07',N'Vật Lí Hạt Nhân',50,4)
--INSERT INTO CHUYENDE
insert into CHUYENDE(MaChuyenDe, TenChuyenDe, SoSinhVienToiDa, MaNganh)
values ('CD01',N'Mạng Máy Tính',50,'N01'),
	   ('CD02',N'Quản trị cơ sở dữ liệu',150,'N01'),
	   ('CD03',N'Xác suất thống kê',50,'N02'),
	   ('CD04',N'Cơ nhiệt',80,'N03'),
	   ('CD05',N'Hóa đại cương 1',150,'N04'),
	   ('CD06',N'Hóa phân tích 1',75,'N04'),
	   ('CD07',N'Sinh Lý Thực Vật',70,'N05'),
	   ('CD08',N'Sinh học tế bào',60,'N05'),
	   ('CD09',N'Kinh tế môi trường',70,'N06'),
	   ('CD10',N'Điện Tử Cao Tần',80,'N07'),
	   ('CD11',N'Khoa Học Vật Liệu Cơ Bản',50,'N07')
--INSERT INTO GIAOVIEN
insert into GIAOVIEN(MaGiaoVien,TenGiaoVien,Phai,NgaySinh,DiaChi,MaChuyenDe)
values('GV01',N'Tô Ngọc Vân',0,18-08-1992,N'Số 1 Nguyễn Văn Cừ, phường Cầu Ông Lãnh, quận 1, TP Hồ Chí Minh','CD01'),
	  ('GV02',N'Phạm Nguyễn Sơn Tùng',1,18-08-1984,N'Số 2 Phạm Ngũ Lão, phường Cầu Ông Lãnh, quận 1, TP Hồ Chí Minh','CD01'),
	  ('GV03',N'Nguyễn Đức Huy',1,20-03-1990,N'Số 3 Trần Hưng Đạo, phường Cầu Ông Lãnh, quận 1, TP Hồ Chí Minh','CD03'),
	  ('GV04',N'Thái Hùng Văn',1,11-09-1980,N'Số 4 Nguyễn Cư Trinh, quận 2, TP Hồ Chí Minh','CD04'),
	  ('GV05',N'Đặng Bình Phương',1,01-02-1984,N'Số 5 Hoàng Hoa Thám, quận 3, TP Hồ Chí Minh','CD05'),
	  ('GV06',N'Nguyễn Ngọc Thảo',0,08-08-1987,N'Số 6 Trương Định, quận 4, TP Hồ Chí Minh','CD06'),
	  ('GV07',N'Tiết Gia Hồng',0,02-02-1984,N'Số 7 Nguyễn Tri Phương, quận 8, TP Hồ Chí Minh','CD07'),
	  ('GV08',N'Nguyễn Phạm Phương Nam',1,10-02-1984,N'Số 8 An Dương Vương, quận Tân Bình, TP Hồ Chí Minh','CD08'),
	  ('GV09',N'Hồ Lê Thị Kim Nhung',0,18-08-1990,N'Số 9 Lý Thái Tổ, quận 5, TP Hồ Chí Minh','CD09'),
	  ('GV10',N'Lương Vỹ Minh',1,05-05-1984,N'Số 10 Lê Lai, quận 1, TP Hồ Chí Minh','CD10'),
	  ('GV11',N'Hồ Tuấn Thanh',1,23-08-1980,N'Số 11, quận 3, TP Hồ Chí Minh','CD11'),
	  ('GV12',N'Hồ Trung Hiếu',1,01-06-1997,N'Số 135 Trần Hưng Đạo, phường Cầu Ông Lãnh, quận 1, TP Hồ Chí Minh','CD02')
--INSERT TAI KHOAN GIAO VU GOC
insert into TAIKHOAN(MaTaiKhoan,MatKhau,LoaiTaiKhoan,MaGiaoVuTao)
values('GVU01','GVU01','GVU',null)
--INSERT GIAOVU GOC
insert into GIAOVU(MaGiaoVu,TenGiaoVu,Phai,NgaySinh ,DiaChi)
values('GVU01',N'Nguyễn Bá Đạo',1 ,18-06-1992,N'Số 16C Tôn Đức Thắng, phường Mỹ Bình, TP. Long Xuyên, tỉnh An Giang')


--INSERT INTO TAIKHOAN GIAOVU
insert into TAIKHOAN(MaTaiKhoan,MatKhau,LoaiTaiKhoan,MaGiaoVuTao)
values
	  ('GVU02','GVU02','GVU','GVU01'),
	  ('GVU03','GVU03','GVU','GVU01'),
	  ('GVU04','GVU04','GVU','GVU01'),
	  ('GVU05','GVU05','GVU','GVU01')
--INSERT INTO GIAOVU
insert into GIAOVU(MaGiaoVu,TenGiaoVu,Phai,NgaySinh ,DiaChi)
values
	  ('GVU02',N'Nguyễn Tường Minh',1,18-06-1982,N'Số 1 Phạm Văn Đồng, phường Phước Trung, TP. Bà Rịa, tỉnh Bà Rịa – Vũng Tàu'),
	  ('GVU03',N'Hoàng Bảo Ngân',0,18-06-1991,N'Số 04 đường Phan Đình Phùng, phường 3, TP.Bạc Liêu, tỉnh Bạc Liêu'),
	  ('GVU04',N'Minh Huyền',0,18-06-1990,N'Số 82  đường Hùng Vương, TP. Bắc Giang, tỉnh Bắc Giang'),
	  ('GVU05',N'Phan Bá Tánh',1,18-06-1993,N'Tổ 1A, phường Phùng Chí Kiên, TX.Bắc Kạn, tỉnh Bắc Kạn')
--INSERT INTO TAIKHOAN SINHVINE
insert into TAIKHOAN(MaTaiKhoan,MatKhau,LoaiTaiKhoan,MaGiaoVuTao)
values('SV01','SV01','SV','GVU01'),
	  ('SV02','SV02','SV','GVU01'),
	  ('SV03','SV03','SV','GVU02'),
	  ('SV04','SV04','SV','GVU03'),
	  ('SV05','SV05','SV','GVU04'),
	  ('SV06','SV06','SV','GVU02'),
	  ('SV07','SV07','SV','GVU01')
--INSERT INTO SINHVIEN
insert into SINHVIEN(MaSinhVien, TenSinhVien,Phai,NgaySinh,DiaChi,MaNganh)
values('SV01', N'Hoàng Nguyễn Bình An',1,31-6-1998,N'Số 7D, Đường số 4, Khu phố 6, Phường Hiệp Bình Phước, Quận Thủ Đức, TP Hồ Chí Minh','N01'),
	  ('SV02', N'Phạm Thiên Thành',1,1-4-1998,N'465 An Dương Vương, Phường 03, Quận 5, TP Hồ Chí Minh','N02'),
	  ('SV03', N'Dương Hoàng Anh',1,1-5-1998,N'Tòa nhà Hưng Bình, Số 404-406-406/2 Ung Văn Khiêm, Phường 25, Quận Bình Thạnh, TP Hồ Chí Minh','N03'),
	  ('SV04', N'Nguyễn Vũ Minh Ngọc',0,5-8-1998,N'19N Nguyễn Hữu Cảnh, Phường 19, Quận Bình Thạnh, TP Hồ Chí Minh','N04'),
	  ('SV05', N'Mai Minh Phương',0,12-8-1998,N'Lô L2-12,L2 Vincom Center Landmark 81,số 772 Điện Biên Phủ, Phường 22, Quận Bình Thạnh, TP Hồ Chí Minh','N05'),
	  ('SV06', N'Vũ Minh Thư',0,21-6-1998,N'Số 7-9 Nguyễn Bỉnh Khiêm, Phường Bến Nghé, Quận 1, TP Hồ Chí Minh','N01'),
	  ('SV07', N'Nguyễn Mạnh Tùng',1,9-10-1998,N'Phòng 501, Lầu 5, số 13C đường 12, Khu phố 4, Phường Bình An, Quận 2, TP Hồ Chí Minh','N03')
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
values('L01','CQO1'),
	  ('L02','CQO2'),
	  ('L03','CQO3'),
	  ('L04','CQO4'),
	  ('L05','CQO5')
--INSERT INTO THONGTINMOCHUYENDE
insert THONGTINMOCHUYENDE(MaThongTinMoChuyenDe, HocKy, NienHoc, MaGiaoVu, MaChuyenDe)
	values('MCD01',1,'2017-2018','GVU01','CD01'),
		  ('MCD02',1,'2017-2018','GVU02','CD02'),
		  ('MCD03',1,'2017-2018','GVU05','CD03'),
		  ('MCD04',1,'2017-2018','GVU03','CD04'),
		  ('MCD05',1,'2017-2018','GVU04','CD05'),
		  ('MCD06',2,'2017-2018','GVU01','CD06'),
		  ('MCD07',2,'2017-2018','GVU04','CD07'),
		  ('MCD08',2,'2017-2018','GVU02','CD08'),
		  ('MCD09',2,'2017-2018','GVU05','CD09'),
		  ('MCD10',2,'2017-2018','GVU03','CD10')
--INSERT INTO THONGTINDANGKY
insert THONGTINDANGKY(MaDangKy, MaSinhVien, MaThongTinMoChuyenDe, MaLop)
values('DK01','SV01','MCD01','L01'),
		('DK02','SV01','MCD02','L02'),
		('DK03','SV02','MCD01','L01'),
		('DK04','SV02','MCD02','L02'),
		('DK05','SV02','MCD04','L04'),
		('DK06','SV03','MCD05','L02'),
		('DK07','SV04','MCD06','L03'),
		('DK08','SV05','MCD03','L04'),
		('DK09','SV05','MCD07','L04'),
		('DK10','SV06','MCD09','L05')
--INSERT NHOM
insert into NHOM(MaNhom,TenNhom,TrangThai)
values('NHOM00',N'0 anh em',1),
('NHOM01',N'1 anh em',1),
('NHOM02',N'2 anh em',0),
('NHOM03',N'3 anh em',1),
('NHOM04',N'4 anh em',0),
('NHOM05',N'5 anh em',0)
--INSERT THANHVIEN
insert into THANHVIEN(MaDangKy,MaNhom,VaiTro)
values  ('DK01','NHOM01','trưởng nhóm'),
		('DK02','NHOM02','trưởng nhóm'),
		('DK03','NHOM03','trưởng nhóm'),
		('DK04','NHOM03','thành viên'),
		('DK05','NHOM03','thành viên'),
		('DK06','NHOM04','trưởng nhóm'),
		('DK07','NHOM05','trưởng nhóm'),
		('DK08','NHOM05','thành viên'),
		('DK09','NHOM05','thành viên'),
		('DK10','NHOM05','thành viên')

select *
from THONGTINDANGKY