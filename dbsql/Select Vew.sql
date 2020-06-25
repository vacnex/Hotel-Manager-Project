select * from dbo.tbl_account
go
select * from dbo.tbl_customer
go
select * from dbo.tbl_roombook
go
select * from dbo.tbl_room
go
select * from dbo.tbl_services
go
select * from dbo.tbl_servicesuse
go
DBCC CHECKIDENT (tbl_roombook, RESEED, 6);
DBCC CHECKIDENT (tbl_servicesuse, RESEED, 3);
go
