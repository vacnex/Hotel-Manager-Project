create database Db_Hotel_Manager
go
use Db_Hotel_Manager
go
CREATE TABLE tbl_room(
	idRoom nvarchar(5) NOT NULL,
	rType nvarchar(25) NOT NULL,
	rPrice int NOT NULL,
	rStatus nvarchar(15) NOT NULL,
 CONSTRAINT PK_tbl_room PRIMARY KEY (idRoom));
 GO
CREATE TABLE tbl_customer(
	idCard nvarchar(12) NOT NULL,
	cusName nvarchar(255) NOT NULL,
	cusAddress nvarchar(255) NOT NULL,
	cusGender nvarchar(5) NOT NULL,
	cusPhone nvarchar(15) NULL,
 CONSTRAINT PK_tbl_customer PRIMARY KEY (idCard));
 GO
CREATE TABLE tbl_services(
	idService nvarchar(10) NOT NULL,
	serName nvarchar(50) NOT NULL,
	serPrice float NOT NULL,
	serUnit nvarchar(50) NOT NULL,
 CONSTRAINT PK_tbl_services PRIMARY KEY (idService)); 
 GO
CREATE TABLE tbl_roombook(
	idRoombook int IDENTITY(1,1) NOT NULL,
	idCard nvarchar(12) NOT NULL,
	idRoom nvarchar(5) NOT NULL,
	startDate date NOT NULL,
	endDate date NULL,
	staffName nvarchar(30) NOT NULL,

 CONSTRAINT PK_tbl_roombook PRIMARY KEY (idRoombook)); 
 GO
CREATE TABLE tbl_servicesuse(
	idServiceuse int IDENTITY(1,1) NOT NULL,
	idCard nvarchar(12) NOT NULL,
	idService nvarchar(10) NOT NULL,
	number int NOT NULL,
	dateUse [date] NOT NULL,
	idRoom nvarchar(5) NULL,
 CONSTRAINT [PK_SDDV_1] PRIMARY KEY (idServiceuse,idCard,idService));
 GO
CREATE TABLE tbl_account(
	[Username] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Taikhoan] PRIMARY KEY (Username));
 GO

INSERT INTO tbl_room (idRoom, rType, rPrice, rStatus)
 VALUES (N'T101', N'Đơn thường', 300000, N'Trống'),
		(N'T102', N'Đơn thường', 300000, N'Trống'),
		(N'T103', N'Đơn thường', 300000, N'Có khách'),
		(N'T104', N'Đơn thường', 300000, N'Trống'),
		(N'T201', N'Đôi thường', 400000, N'Có khách'),
		(N'T202', N'Đôi thường', 400000, N'Trống'),
		(N'T203', N'Đôi thường', 400000, N'Có khách'),
		(N'T204', N'Đôi thường', 400000, N'Có khách'),
		(N'V101', N'VIP đơn', 600000, N'Trống'),
		(N'V102', N'VIP đơn', 600000, N'Trống'),
		(N'V103', N'VIP đơn', 600000, N'Trống'),
		(N'V104', N'VIP đơn', 600000, N'Trống'),
		(N'V201', N'VIP đôi', 800000, N'Trống'),
		(N'V202', N'VIP đôi', 800000, N'Trống'),
		(N'V203', N'VIP đôi', 800000, N'Trống'),
		(N'V204', N'VIP đôi', 800000, N'Có khách'),
		(N'L101', N'Hạng sang đơn', 1000000, N'Trống'),
		(N'L102', N'Hạng sang đơn', 1000000, N'Trống'),
		(N'L103', N'Hạng sang đơn', 1000000, N'Trống'),
		(N'L104', N'Hạng sang đơn', 1000000, N'Trống'),
		(N'L201', N'Hạng sang đôi', 1300000, N'Trống'),
		(N'L202', N'Hạng sang đôi', 1300000, N'Trống'),
		(N'L203', N'Hạng sang đôi', 1300000, N'Trống'),
		(N'L204', N'Hạng sang đôi', 1300000, N'Trống');
		GO
	
INSERT INTO tbl_customer (idCard, cusName, cusAddress, cusGender, cusPhone)
VALUES (N'012434832', N'Cao Thị Linh', N'18 Thanh Bình', N'Nữ', N'0984234567'),
		(N'123253454', N'Vũ Tuấn Anh', N'Bà Triệu', N'Nam', N'01235243234'),
		(N'123383294', N'Nguyễn Thị Mai', N'Lộc Hạ', N'Nữ', N'0987654356'),
		(N'145573262', N'Phạm Vân Anh', N'Nguyễn Du', N'Nữ', N'0956243242'),
		(N'152015415', N'Hoàng Đức Hưng', N'Lộc Hạ', N'Nam', N'0963243462'),
		(N'190023198', N'Phạm Anh Khoa', N'Hạ Long', N'Nam', N'0955734823'),
		(N'183658428', N'Dương Thị Ngân', N'Hồ Tây', N'Nữ', N'0986395276'),
		(N'234453134', N'Đào Đức Đủ', N'Bà Triệu', N'Nam', N'0942963929');
		GO

INSERT INTO tbl_services (idService, serName, serPrice, serUnit)
VALUES (N'DV001', N'Bia Sài Gòn 330ml', 15000, N'lon'),
		(N'DV002', N'Bia Heniken 330ml', 20000, N'lon'),
		(N'DV003', N'Bia Halida 330ml', 15000, N'lon'),
		(N'DV004', N'Rượu Vodka 330ml', 100000, N'chai'),
		(N'DV005', N'Hoa quả tươi', 100000, N'đĩa');
		GO

SET IDENTITY_INSERT dbo.tbl_roombook ON
INSERT INTO dbo.tbl_roombook (idRoombook, idCard, idRoom, startDate, endDate, staffName)
VALUES	(1, N'012434832', N'T101', CAST(0x073C0B00 AS Date), CAST(0x103C0B00 AS Date), N'Ngân'),
		(2, N'012434832', N'T103', CAST(0x083C0B00 AS Date), CAST(0x103C0B00 AS Date), N'Ngân'),
		(3, N'012434832', N'V102', CAST(0x083C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(4, N'123383294', N'V101', CAST(0x083C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(5, N'145573262', N'T102', CAST(0x073C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(6, N'145573262', N'T202', CAST(0x073C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(7, N'012434832', N'L101', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(8, N'012434832', N'T101', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(9, N'012434832', N'T101', CAST(0x093C0B00 AS Date), CAST(0x113C0B00 AS Date), N'Ngân'),
		(10, N'012434832', N'T102', CAST(0x093C0B00 AS Date), NULL, N'Ngân'),
		(11, N'123383294', N'T103', CAST(0x093C0B00 AS Date), NULL, N'Ngân'),
		(12, N'123383294', N'T201', CAST(0x093C0B00 AS Date), NULL, N'Ngân'),
		(13, N'145573262', N'T104', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(14, N'145573262', N'T204', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(15, N'145573262', N'L203', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(16, N'152015415', N'V201', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(17, N'152015415', N'V202', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(18, N'152015415', N'V203', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(19, N'152015415', N'V204', CAST(0x093C0B00 AS Date), CAST(0x093C0B00 AS Date), N'Ngân'),
		(20, N'012434832', N'T202', CAST(0x093C0B00 AS Date), CAST(0x113C0B00 AS Date), N'Hưng'),
		(21, N'012434832', N'T203', CAST(0x093C0B00 AS Date), NULL, N'Hưng'),
		(22, N'012434832', N'T204', CAST(0x093C0B00 AS Date), NULL, N'Hưng')
SET IDENTITY_INSERT dbo.tbl_roombook OFF
		GO
		
SET IDENTITY_INSERT dbo.tbl_servicesuse ON
INSERT INTO dbo.tbl_servicesuse(idServiceuse, idCard, idService, number, dateUse, idRoom) 
VALUES	(1, N'012434832', N'DV001', 10, CAST(0x0F3C0B00 AS Date), N'T101'),
		(2, N'012434832', N'DV002', 10, CAST(0x0F3C0B00 AS Date), N'T102'),
		(3, N'012434832', N'DV001', 10, CAST(0x0F3C0B00 AS Date), N'T102'),
		(5, N'012434832', N'DV003', 10, CAST(0x0F3C0B00 AS Date), N'T101');
SET IDENTITY_INSERT dbo.tbl_servicesuse OFF
		GO

INSERT INTO dbo.tbl_account (Username, Pass, Name)
VALUES	(N'linhadmin', N'linhadmin', N'Cao Thị Linh'),
		(N'tuananh', N'tuananh', N'Vũ Tuấn Anh'),
		(N'nguyenmai', N'nguyenmai', N'Nguyễn Thị Mai'),
		(N'vananh', N'vananh', N'Phạm Vân Anh'),
		(N'hoanghung', N'hoanghung', N'Hoàng Đức Hưng'),
		(N'khoaadmin', N'khoaadmin', N'Phạm Anh Khoa'),
		(N'duongngan', N'duongngan', N'Dương Thị Ngân'),
		(N'ducdu', N'ducdu', N'Đào Đức Đủ');
		GO 
		

ALTER TABLE dbo.tbl_servicesuse ADD CONSTRAINT FK_Servicesuse_Services FOREIGN KEY(idService)
REFERENCES dbo.tbl_services (idService);
GO

ALTER TABLE dbo.tbl_servicesuse ADD CONSTRAINT FK_Servicesuse_Customer FOREIGN KEY(idCard)
REFERENCES dbo.tbl_customer (idCard);
GO

ALTER TABLE dbo.tbl_servicesuse ADD CONSTRAINT FK_Servicesuse_Room FOREIGN KEY(idRoom)
REFERENCES dbo.tbl_room (idRoom);
GO

ALTER TABLE dbo.tbl_roombook ADD CONSTRAINT FK_Roombook_Customer FOREIGN KEY(idCard)
REFERENCES dbo.tbl_customer (idCard);
GO

ALTER TABLE dbo.tbl_roombook ADD CONSTRAINT FK_Roombook_Room FOREIGN KEY (idRoom)
REFERENCES dbo.tbl_room (idRoom);
GO
