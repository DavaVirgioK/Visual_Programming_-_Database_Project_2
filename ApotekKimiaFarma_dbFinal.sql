CREATE DATABASE UAS_Visprog
USE UAS_Visprog

SELECT * FROM Medicine

CREATE TABLE Employee
(
	EmployeeID varchar(8) PRIMARY KEY,
	EmployeeName VARCHAR (25),
	EmployeePosition VARCHAR (10),
	EmployeeAddress VARCHAR (50),
	UserName VARCHAR (20),
	Pasword VARCHAR (40),
	Email VARCHAR (50),
	[Date] varchar (50)
);
-- Berhasil di jalankan
CREATE TABLE Customer
(
	CustID INT IDENTITY(1,1) PRIMARY KEY,
	CustName VARCHAR (20),
	CustAddress VARCHAR (30),
	CustPhone VARCHAR (30),
);
-- udah berhasil di jalankan
CREATE TABLE Suplier 
(
  SuplierID INT IDENTITY(1,1) PRIMARY KEY,
  SuplierName VARCHAR (20),
  SuplierAddress VARCHAR (40),
  SuplierPhone VARCHAR (20),
);

-- Berhasil dijalankan
CREATE TABLE Medicine
(
	MedicineID Varchar (8) PRIMARY KEY,
	MedicineName VARCHAR (40) NOT NULL,
	MedicinePrice INT NOT NULL,
	MedicineQuantity INT NOT NULL,
	MedicineDate varchar(50)

);

-- Berhasil di jalankan
CREATE TABLE TransactionDetail
(
	TransactionID VARCHAR (10) PRIMARY KEY
	FOREIGN KEY REFERENCES Transaksi(TransactionID),
	MedicineID VARCHAR(8) NOT NULL
	FOREIGN KEY REFERENCES Medicine(MedicineID),
	Quantity VARCHAR(10) NOT NULL
);

CREATE TABLE Transaksi (
  TransactionID VARCHAR (10) PRIMARY KEY,
  MedicineName VARCHAR (30),
  MedicinePrice INT,
  MedicineQuantity INT,
  Totalharga INT
);



