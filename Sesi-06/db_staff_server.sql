CREATE DATABASE db_staff

USE db_staff

CREATE TABLE data_staff(
    nik int NULL,
    nama varchar(50) NULL,
    alamat varchar(200) NULL,
	handphone varchar(15) NULL    
)

INSERT INTO data_staff VALUES
(123, 'saya', 'pekalongan', '089999999')

INSERT INTO data_staff VALUES
(234, 'dia', 'semarang', '0877777777'),
(345, 'rika', 'bandung', '0866666666'),
(456, 'anda', 'jakarta', '0855555555')
    
ALTER TABLE data_staff
ADD joindate DATE NULL

UPDATE data_staff
SET joindate = '2022-03-17' WHERE nik = 123

UPDATE data_staff
SET joindate = '2022-03-16' WHERE nik = 234

UPDATE data_staff
SET joindate = '2022-03-15' WHERE nik = 345

UPDATE data_staff
SET joindate = '2022-03-14' WHERE nik = 456

INSERT INTO data_staff VALUES
(567, 'kami', 'depok', '0844444444', '2022-03-23')

SELECT TOP 2 * FROM data_staff

SELECT TOP 3 * FROM data_staff

CREATE TABLE staffoutsource(
    nik int NULL,
    nama varchar(50) NULL,
    alamat varchar(200) NULL,
	handphone varchar(15) NULL,
    joindate DATE null
)

INSERT INTO staffoutSource VALUES
(123, 'saya', 'pekalongan', '089999999', '2022-03-17'),
(234, 'dia', 'semarang', '0877777777', '2022-03-16'),
(345, 'rika', 'bandung', '0866666666', '2022-03-15'),
(456, 'anda', 'jakarta', '0855555555', '2022-03-14'),
(567, 'kami', 'depok', '0844444444', '2022-03-23'),
(678, 'me', 'london', '021111111', '2022-03-22'),
(789, 'you', 'austin', '022222222', '2022-03-21'),
(890, 'us', 'bangkok', '023333333', '2022-03-20'),
(901, 'them', 'beijing', '0244444444', '2022-03-19'),
(012, 'her', 'seoul', '0255555555', '2022-03-18')
    
SELECT TOP 2 * FROM data_staff JOIN staffoutsource
ON data_staff.joindate = staffoutsource.joindate

SELECT staffoutSource.* FROM data_staff JOIN staffoutsource
ON data_staff.joindate = staffoutsource.joindate

SELECT data_staff.* FROM data_staff RIGHT JOIN staffoutsource
ON data_staff.joindate = staffoutsource.joindate

SELECT * FROM data_staff RIGHT JOIN staffoutsource
ON data_staff.joindate = staffoutsource.joindate