create database StdManagement;
use StdManagement;
create table users(
	id int not null identity(1,1) primary key,
	username varchar(20),
	password varchar(20)
);

insert into users(username, password) 
values('lehuy','1234');
select * from users;

create table student(
	id nvarchar(100) NOT NULL,
	lname nvarchar(100) NOT NULL,
	fname nvarchar(100) NOT NULL,
	BirthDate nvarchar(100) NOT NULL, 
	gender nvarchar(100)  NOT NULL,
	phone nvarchar(100),
	address nvarchar(100),
	img image,
	PRIMARY KEY (id)
	);
 select * from student;
