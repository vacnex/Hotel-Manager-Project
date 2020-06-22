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
 CONSTRAINT [PK_SDDV_1] PRIMARY KEY (idServiceuse));
 GO

CREATE TABLE tbl_account(
	[Username] [nvarchar](50) NOT NULL,
	[Pass] [nvarchar](50) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Taikhoan] PRIMARY KEY (Username));
 GO
SELECT * FROM sys.foreign_keys go


while(exists(select 1 from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where CONSTRAINT_TYPE='FOREIGN KEY'))
begin
	declare @sql nvarchar(2000)
	SELECT TOP 1 @sql=('ALTER TABLE ' + TABLE_SCHEMA + '.[' + TABLE_NAME
	+ '] DROP CONSTRAINT [' + CONSTRAINT_NAME + ']')
	FROM information_schema.table_constraints
	WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
	exec (@sql)
end
go
DROP TABLE dbo.tbl_customer;
DROP TABLE dbo.tbl_room; 
DROP TABLE dbo.tbl_roombook; 
DROP TABLE dbo.tbl_services; 
DROP TABLE dbo.tbl_servicesuse; 
DROP TABLE dbo.tbl_account; 


INSERT INTO tbl_room (idRoom, rType, rPrice, rStatus)
 VALUES (N'T101', N'Thường Đơn', 300000, N'Trống'),
		(N'T102', N'Thường Đơn', 300000, N'Có khách'),
		(N'T103', N'Thường Đơn', 300000, N'Đã đặt'),
		(N'T104', N'Thường Đơn', 300000, N'Trống'),
		(N'T201', N'Thường Đôi', 400000, N'Có khách'),
		(N'T202', N'Thường Đôi', 400000, N'Đã đặt'),
		(N'T203', N'Thường Đôi', 400000, N'Trống'),
		(N'T204', N'Thường Đôi', 400000, N'Trống'),
		(N'V101', N'VIP Đơn', 600000, N'Đã đặt'),
		(N'V102', N'VIP Đơn', 600000, N'Trống'),
		(N'V103', N'VIP Đơn', 600000, N'Trống'),
		(N'V104', N'VIP Đơn', 600000, N'Trống'),
		(N'V201', N'VIP Đôi', 800000, N'Trống'),
		(N'V202', N'VIP Đôi', 800000, N'Trống'),
		(N'V203', N'VIP Đôi', 800000, N'Trống'),
		(N'V204', N'VIP Đôi', 800000, N'Có khách'),
		(N'L101', N'Hạng Sang Đơn', 1000000, N'Trống'),
		(N'L102', N'Hạng Sang Đơn', 1000000, N'Trống'),
		(N'L103', N'Hạng Sang Đơn', 1000000, N'Trống'),
		(N'L104', N'Hạng Sang Đơn', 1000000, N'Trống'),
		(N'L201', N'Hạng Sang Đôi', 1300000, N'Trống'),
		(N'L202', N'Hạng Sang Đôi', 1300000, N'Trống'),
		(N'L203', N'Hạng Sang Đôi', 1300000, N'Trống'),
		(N'L204', N'Hạng Sang Đôi', 1300000, N'Trống');
		GO
	
INSERT INTO tbl_customer (idCard, cusName, cusAddress, cusGender, cusPhone)
VALUES	(N'012434832', N'Cao Thị Linh', N'18 Thanh Bình', N'Nữ', N'0984234567'),
		(N'123253454', N'Vũ Tuấn Anh', N'Bà Triệu', N'Nam', N'01235243234'),
		(N'123383294', N'Nguyễn Thị Mai', N'Lộc Hạ', N'Nữ', N'0987654356'),
		(N'145573262', N'Phạm Vân Anh', N'Nguyễn Du', N'Nữ', N'0956243242'),
		(N'152015415', N'Hoàng Đức Hưng', N'Lộc Hạ', N'Nam', N'0963243462'),
		(N'190023198', N'Phạm Anh Khoa', N'Hạ Long', N'Nam', N'0955734823');
		--(N'183658428', N'Dương Thị Ngân', N'Hồ Tây', N'Nữ', N'0986395276'),
		--(N'234453134', N'Đào Đức Đủ', N'Bà Triệu', N'Nam', N'0942963929');
		GO

INSERT INTO tbl_services (idService, serName, serPrice, serUnit)
VALUES	(N'DV001', N'Bia Sài Gòn 330ml', 15000, N'lon'),
		(N'DV002', N'Bia Heniken 330ml', 20000, N'lon'),
		(N'DV003', N'Bia Halida 330ml', 15000, N'lon'),
		(N'DV004', N'Rượu Vodka 330ml', 100000, N'chai'),
		(N'DV005', N'Hoa quả tươi', 100000, N'đĩa');
		GO

SET IDENTITY_INSERT dbo.tbl_roombook ON
INSERT INTO dbo.tbl_roombook (idRoombook, idCard, idRoom, startDate, endDate, staffName)
VALUES	(1, N'012434832', N'T102', '2020-06-01', '2020-06-03', N'Lê Thị Đào'),
		(2, N'123253454', N'T103', '2020-06-03', '2020-06-06', N'Lê Minh Triệu'),
		(3, N'123383294', N'T201', '2020-06-03', '2020-06-04', N'Nguyễn Thanh Vũ'),
		(4, N'145573262', N'V204', '2020-06-10', '2020-06-15', N'Võ Thị Kiều Vân'),
		(5, N'152015415', N'T202', '2020-06-06', '2020-06-10', N'Nguyễn Đỗ Anh Thy'),
		(6, N'190023198', N'V101', '2020-06-06', '2020-06-10', N'Nguyễn Đỗ Anh Thy');
SET IDENTITY_INSERT dbo.tbl_roombook OFF
		GO
		
SET IDENTITY_INSERT dbo.tbl_servicesuse ON
INSERT INTO dbo.tbl_servicesuse(idServiceuse, idCard, idService, number, dateUse) 
VALUES	(1, N'012434832', N'DV001', 3, '2020-06-02'),
		(2, N'012434832', N'DV005', 1, '2020-06-02'),
		(3, N'123383294', N'DV002', 1, '2020-06-03');

SET IDENTITY_INSERT dbo.tbl_servicesuse OFF
		GO

INSERT INTO dbo.tbl_account (Username, Pass, Name)
VALUES	(N'daoadmin', N'daoadmin', N'Lê Thị Đào'),
		(N'quangvinh', N'quangvinh', N'Phạm Vũ Quang Vinh'),
		(N'baoloc', N'baoloc', N'Nguyễn Bảo Lộc'),
		(N'minhtrieu', N'minhtrieu', N'Lê Minh Triệu'),
		(N'vanadmin', N'vanadmin', N'Võ Thị Kiều Vân'),
		(N'anhthy', N'anhthy', N'Nguyễn Đỗ Anh Thy'),
		(N'nhuthi', N'nhuthi', N'Dương Hà Như Thi'),
		(N'thanhvu', N'thanhvu', N'Nguyễn Thanh Vũ');
		GO 
		

ALTER TABLE dbo.tbl_servicesuse ADD CONSTRAINT FK_Servicesuse_Services FOREIGN KEY(idService)
REFERENCES dbo.tbl_services (idService);
GO

alter table dbo.tbl_servicesuse  drop constraint FK_Servicesuse_Customer
ALTER TABLE dbo.tbl_servicesuse ADD CONSTRAINT FK_Servicesuse_Customer FOREIGN KEY(idCard)
REFERENCES dbo.tbl_customer (idCard);
GO

alter table tbl_roombook  drop constraint FK_Roombook_Customer
ALTER TABLE dbo.tbl_roombook ADD CONSTRAINT FK_Roombook_Customer FOREIGN KEY(idCard)
REFERENCES dbo.tbl_customer (idCard);
GO

alter table tbl_roombook  drop constraint FK_Roombook_Room
ALTER TABLE dbo.tbl_roombook ADD CONSTRAINT FK_Roombook_Room FOREIGN KEY (idRoom)
REFERENCES dbo.tbl_room (idRoom);
GO

