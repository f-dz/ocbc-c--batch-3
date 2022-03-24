Latihan Sesi-06
Nama	: Fatin Dzakiyah
Kode	: FSDO003ONL002
Tools	: SQL Server 2019

A. Buat Database baru dengan nama staff
CREATE DATABASE db_staff

B. Buat Table data_staff dengan desain spt perintah
CREATE TABLE data_staff(
    nik int NULL,
    nama varchar(50) NULL,
    alamat varchar(200) NULL,
	handphone varchar(15) NULL    
)

C. Masukkan data ke dalam table data_staff sesuai dengan table diatas
INSERT INTO data_staff VALUES
(123, 'saya', 'pekalongan', '089999999')

D. Masukkan lebih dari 1 data ke dalam table data masih dalam table diatas.
INSERT INTO data_staff VALUES
(234, 'dia', 'semarang', '0877777777'),
(345, 'rika', 'bandung', '0866666666'),
(456, 'anda', 'jakarta', '0855555555')

E. Tambahkan kolom baru pada table data_staff yaitu joindate sekaligus masukan 1 data kedalam table data_staff
ALTER TABLE data_staff
ADD joindate DATE NULL
INSERT INTO data_staff VALUES
(567, 'kami', 'depok', '0844444444', '2022-03-23')

F. Tampilkan 2 data SQL kalian sekarang
SELECT TOP 2 * FROM data_staff

G. Tampilkan 3 data SQL kalian sekarang
SELECT TOP 3 * FROM data_staff

H. Buat Table baru staffoutsource dengan isi yang sama seperti data_staff
CREATE TABLE staffoutsource(
    nik int NULL,
    nama varchar(50) NULL,
    alamat varchar(200) NULL,
	handphone varchar(15) NULL,
    joindate DATE null
)

I. Masukkan 10 data baru ke table staffoutsource
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

J. Tampilkan data pada 2 Table yang sudah kalian buat dengan joindate yang sama
SELECT TOP 2 * FROM data_staff JOIN staffoutsource
ON data_staff.joindate = staffoutsource.joindate

K. Tampilkan seluruh data sebelah kanan yang sama pada table staff_outsource
SELECT staffoutSource.* FROM data_staff JOIN staffoutsource
ON data_staff.joindate = staffoutsource.joindate

L. Tampilkan seluruh data staff sebelah kiri yang punya nilai tidak sama akan bernilai null
SELECT data_staff.* FROM data_staff RIGHT JOIN staffoutsource
ON data_staff.joindate = staffoutsource.joindate

M. Tampilkan seluruh data antara 2 tabel baik itu tidak punya kesamaan dan bernilai null.
SELECT * FROM data_staff RIGHT JOIN staffoutsource
ON data_staff.joindate = staffoutsource.joindate