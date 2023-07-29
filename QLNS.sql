create database QLNSu
use QLNSu



GO
DROP TABLE [CHITIETBANGCHAMCONG] 
GO
DROP TABLE [BANGCHAMCONG] 
GO
DROP TABLE [CHITIETBANGLUONG] 
GO
DROP TABLE [TRINHDOHOCVAN] 
GO
DROP TABLE [PHONGBAN] 
GO
DROP TABLE [BANGLUONG] 
GO
DROP TABLE [NHANVIEN] 
GO


CREATE TABLE [NHANVIEN]
(
	[MANV] VARCHAR(50) NOT NULL,
	[TENNV] NVARCHAR(50) NULL,
	[DIACHI] NVARCHAR(50) NULL,
	[GIOITINH] BIT NULL,
	[NGAYSINH] DATE NULL,
	[EMAIL] nVARCHAR(50) null,
	[SDT] nVARCHAR(11) null,
	[DANTOC] NVARCHAR(50) NULL,
	[MAPHONGBAN] NVARCHAR(50) NOT NULL,
	[MATRINHDO] NVARCHAR(50) NOT NULL
PRIMARY KEY ([MANV])
) 
GO

CREATE TABLE ACCOUNT(
	[IDACCOUNT] NVARCHAR(50),
	[USERNAME] NVARCHAR(50) unique,
	[PASSWORD] NVARCHAR(50),
	[ROLE] int,
	[TRANGTHAI] int,
	[MANV] VARCHAR(50) not null,
	Primary key ([IDACCOUNT]),
	Foreign key (MANV) references NHANVIEN([MANV])
)
CREATE TABLE [BANGLUONG]
(
	[MABANGLUONG] NVARCHAR(50) NOT NULL,
	[HESOPHUCAP] Float NULL,
	[HESOLUONG] Float NULL,
	[LUONGCOBAN] FLOAT NULL,
PRIMARY KEY ([MABANGLUONG])
) 
GO

CREATE TABLE [PHONGBAN]
(
	[MAPHONGBAN] NVARCHAR(50) NOT NULL,
	[TENPHONGBAN] NVARCHAR(50) NULL,
	[SOLUONGNHANVIEN] int NULL,
	[TRANGTHAI] int,
	PRIMARY KEY ([MAPHONGBAN])
) 
GO

CREATE TABLE [TRINHDOHOCVAN]
(
	[MATRINHDO] NVARCHAR(50) NOT NULL,
	[TENTRINHDO] NVARCHAR(50) NULL,
	[CHUYENNGANH] NVARCHAR(50) NULL,
PRIMARY KEY ([MATRINHDO])
) 
GO

CREATE TABLE [CHITIETBANGLUONG]
(
	[MANV] VARCHAR(50) NOT NULL,
	[MABANGLUONG] NVARCHAR(50) NOT NULL,
	[SONGAYCONG] NVARCHAR(50) NULL,
	[MABANGCHAMCONG] NVARCHAR(50) NOT NULL,
PRIMARY KEY ([MANV],[MABANGLUONG])
) 
GO

CREATE TABLE [BANGCHAMCONG]
(
	[MABANGCHAMCONG] NVARCHAR(50) NOT NULL,
PRIMARY KEY ([MABANGCHAMCONG])
) 
GO

CREATE TABLE [CHITIETBANGCHAMCONG]
(
	[MANV] VARCHAR(50) NOT NULL,
	[MABANGCHAMCONG] NVARCHAR(50) NOT NULL,
	[NGAYCHAMCONG] NVARCHAR(50) NULL,
PRIMARY KEY ([MANV],[MABANGCHAMCONG])
) 

GO
ALTER TABLE [CHITIETBANGLUONG] ADD  FOREIGN KEY([MANV]) REFERENCES [NHANVIEN] ([MANV])  ON UPDATE NO ACTION ON DELETE NO ACTION 
GO
ALTER TABLE [CHITIETBANGCHAMCONG] ADD  FOREIGN KEY([MANV]) REFERENCES [NHANVIEN] ([MANV])  ON UPDATE NO ACTION ON DELETE NO ACTION 
GO
ALTER TABLE [CHITIETBANGLUONG] ADD  FOREIGN KEY([MABANGLUONG]) REFERENCES [BANGLUONG] ([MABANGLUONG])  ON UPDATE NO ACTION ON DELETE NO ACTION 
GO
ALTER TABLE [NHANVIEN] ADD  FOREIGN KEY([MAPHONGBAN]) REFERENCES [PHONGBAN] ([MAPHONGBAN])  ON UPDATE NO ACTION ON DELETE NO ACTION 
GO
ALTER TABLE [NHANVIEN] ADD  FOREIGN KEY([MATRINHDO]) REFERENCES [TRINHDOHOCVAN] ([MATRINHDO])  ON UPDATE NO ACTION ON DELETE NO ACTION 
GO
ALTER TABLE [CHITIETBANGCHAMCONG] ADD  FOREIGN KEY([MABANGCHAMCONG]) REFERENCES [BANGCHAMCONG] ([MABANGCHAMCONG])  ON UPDATE NO ACTION ON DELETE NO ACTION 
GO
ALTER TABLE [CHITIETBANGLUONG] ADD  FOREIGN KEY([MABANGCHAMCONG]) REFERENCES [BANGCHAMCONG] ([MABANGCHAMCONG])  ON UPDATE NO ACTION ON DELETE NO ACTION 
GO


SET QUOTED_IDENTIFIER ON
GO


SET QUOTED_IDENTIFIER OFF
GO
