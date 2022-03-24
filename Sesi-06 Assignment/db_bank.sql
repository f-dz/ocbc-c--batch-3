CREATE DATABASE db_bank

USE db_bank

-- NOMOR 3
CREATE TABLE Productlines(
	productLine varchar(20) PRIMARY KEY,
	textDescription text NULL,
	htmlDescription text NULL,
	image varchar(50) NULL
)

-- NOMOR 2
CREATE TABLE Product(
	productCode varchar(10) PRIMARY KEY,
	productName varchar(10) NULL,
	productLine varchar(20) FOREIGN KEY
	REFERENCES Productlines(productLine),
	productScale varchar(20) NULL,
	productVendor varchar(50) NULL,
	productDescription text NULL,
	quantitylnStock int NULL,
	buyPrice int NULL,
	MSRP varchar(20) NULL
)

-- NOMOR 8
CREATE TABLE Offices(
	officeCode varchar(10) PRIMARY KEY,
	city varchar(20) NULL,
	phone varchar(15) NULL,
	addressLine1 varchar(100) NULL,
	addressLine2 varchar(100) NULL,
	state varchar(20) NULL,
	country varchar(20) NULL,
	postalCode varchar(10) NULL,
	territory varchar(20) NULL
)

-- NOMOR 7
CREATE TABLE Employees(
	employeeNumber varchar(10) PRIMARY KEY,
	lastName varchar(10) NULL,
	firstName varchar(10) NULL,
	extension varchar(30) NULL,
	email varchar(50) NULL,
	officeCode varchar(10) FOREIGN KEY
	REFERENCES Offices(officeCode),
	reportsTo varchar(30) NULL,
	jobTitle varchar(30) NULL
)

-- NOMOR 1
CREATE TABLE Customers(
	customerNumber varchar(10) PRIMARY KEY,
	customerName varchar(30) NULL,
	contactLastName varchar(10) NULL,
	contactFirstName varchar(10) NULL,
	phone varchar(15) NULL,
	addressLine1 varchar(100) NULL,
	addressLine2 varchar(100) NULL,
	city varchar(20) NULL,
	state varchar(20) NULL,
	postalCode varchar(10) NULL,
	country varchar(20) NULL,
	salesRepEmployeeNumber varchar(10) FOREIGN KEY
	REFERENCES Employees(employeeNumber),
	creditLimit int NULL
)

-- NOMOR 4
CREATE TABLE Orders(
	orderNumber varchar(10) PRIMARY KEY,
	orderDate DATE NULL,
	requiredDate DATE NULL,
	shippedDate DATE NULL,
	status varchar(15) NULL,
	comments varchar(100) NULL,
	customerNumber varchar(10) FOREIGN KEY
	REFERENCES Customers(customerNumber)
)

-- NOMOR 6
CREATE TABLE Payments(
    customerNumber varchar(10) FOREIGN KEY
	REFERENCES Customers(customerNumber),
	checkNumber varchar(10) PRIMARY KEY,
	paymentDate DATE NULL,
	amount int NULL,
)

-- NOMOR 5
CREATE TABLE OrderDetails(
	orderNumber varchar(10) FOREIGN KEY
	REFERENCES Orders(orderNumber),
	productCode varchar(10) FOREIGN KEY
	REFERENCES Product(productCode),
	quantityOrder int NULL,
	priceEach int NULL,
	orderLineNumber varchar(10) NULL,
)

-- MASUKAN DATA 
INSERT INTO Offices VALUES
('001', 'Semarang', '021212121', 'Tembalang', 'Banyumanik', 'Jawa Tengah', 'Indonesia', '50275', 'Semarang Atas')

INSERT INTO Employees VALUES
('111', 'Stark', 'Sansa', '10101', 'sansa@gmail.com', '001', '-', 'Developer'),
('122', 'Stark', 'Arya', '10202', 'arya@gmail.com', '001', '-', 'Analyst')

INSERT INTO Customers VALUES
('100', 'Dany', 'Dany', 'Mrs.', '089999999', 'Hayam', 'Wuruk', 'Pekalongan', 'Jawa Tengah', '51160', 'Indonesia', '111', 100000),
('200', 'John', 'John', 'Mr.', '088888888', 'Hayam', 'Wuruk', 'Pekalongan', 'Jawa Tengah', '51160', 'Indonesia', '111', 200000),
('300', 'Khal', 'Khal', 'Mr.', '087777777', 'Hayam', 'Wuruk', 'Pekalongan', 'Jawa Tengah', '51160', 'Indonesia', '122', 300000)

INSERT INTO Payments VALUES
('300', '01', '2022-02-02', 100000)

INSERT INTO Orders VALUES
('1', '2022-02-03', '2022-02-02', '2022-02-01', 'Selesai', 'Bagus Sekali', '100'),
('2', '2022-03-03', '2022-03-02', '2022-03-01', 'Selesai', 'Kurang Memuaskan', '100')

INSERT INTO Productlines VALUES
('Kendaraan', 'Kendaraan terdiri dari motor, mobil, dll.', 'Jenis-jenis kendaraan', 'bit.ly/gambar1.jpg'),
('Makanan', 'Makanan terdiri dari snack, manisan, dll.', 'Jenis-jenis makanan', 'bit.ly/gambar2.jpg')

INSERT INTO Product VALUES
('1AA', 'Mobil', 'Kendaraan', '1000CC', 'MobilGroup', 'Ini adalah mobil', 20, 500000000, '-'),
('1BB', 'Motor', 'Kendaraan', '500CC', 'MotorGroup', 'Ini adalah motor', 50, 10000000, '-')

INSERT INTO OrderDetails VALUES
('1', '1BB', 2, 20000000, '0001'),
('2', '1AA', 1, 500000000, '0002')