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

