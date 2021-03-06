--C:\Users\Beosama\Desktop\Study\colledge\Kiểm thử phần mềm\DemoDATABASE
CREATE DATABASE DemoQuanLyThuVienAlpha
GO

USE DemoQuanLyThuVienAlpha
GO

-- Book
-- BookCategory
-- Account
-- Student
-- Rent / phieu muon
-- RentInfo / thong tin phieu


CREATE TABLE Student
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Học sinh chưa có tên',
	mssv NVARCHAR(100) NOT NULL DEFAULT N'113',
	--khoa
	status NVARCHAR(100) NOT NULL DEFAULT N'' -- đang thuê || chưa thuê
	
)
GO
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Gia Lai',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

CREATE TABLE BookCategory -- danh mục sách
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

CREATE TABLE Book
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.BookCategory(id)
	
)
GO

CREATE TABLE Rent
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idStudent INT NOT NULL,
	status INT NOT NULL DEFAULT 0 
	
	FOREIGN KEY (idStudent) REFERENCES dbo.Student(id)
)
GO

CREATE TABLE RentInfo
(
	id INT IDENTITY PRIMARY KEY,
	idRent INT NOT NULL,
	idBook INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idRent) REFERENCES dbo.Rent(id),
	FOREIGN KEY (idBook) REFERENCES dbo.Book(id)
)
GO
-- New 

CREATE TABLE Author
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idAuthor INT NOT NULL,
	
	FOREIGN KEY (idAuthor) REFERENCES dbo.Book(id)
)
GO

INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'Admin' , -- UserName - nvarchar(100)
          N'Gia Lai' , -- DisplayName - nvarchar(100)
          N'123' , -- PassWord - nvarchar(1000)
          1  -- Type - int
        )
INSERT INTO dbo.Account
        ( UserName ,
          DisplayName ,
          PassWord ,
          Type
        )
VALUES  ( N'staff' , -- UserName - nvarchar(100)
          N'staff' , -- DisplayName - nvarchar(100)
          N'123' , -- PassWord - nvarchar(1000)
          0  -- Type - int
        )
GO

--INSERT INTO dbo.Book
--	(	
--		name,
--		idCategory,
--		price
--	)
--VALUES	(	
--			N'Cách để thông đít cực mạnh',
--			N'1001',
--			64000
--		)
--GO

--USP = User Procedures
CREATE PROC USP_GetAccountByUserName
@userName nvarchar(100)
AS
BEGIN
	SELECT * FROM dbo.Account WHERE UserName = @userName
END
GO

EXEC dbo.USP_GetAccountByUserName @userName = N'staff' -- nvarchar(100)

