create database QuanLySinhVien;
use QuanLySinhVien;
create table users(
	id varchar(10),
	username varchar(20),
	password varchar(20)
);

insert into users 
values('001','lehuy','1234');

create table student(
	id nvarchar(100) NOT NULL,
	lname nvarchar(100) NOT NULL,
	fname nvarchar(100) NOT NULL,
	BirthDate nvarchar(100) NOT NULL, 
	gender nvarchar(100)  NOT NULL,
	phone nvarchar(100),
	address nvarchar(100),
	img nvarchar(200),
	PRIMARY KEY (id)
);
 select * from student;
 truncate table student;