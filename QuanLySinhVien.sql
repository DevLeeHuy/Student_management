create database StdManagement;
use StdManagement;
create table users(
	id int not null identity(1,1) primary key,
	username varchar(20),
	password varchar(20)
);
INSERT	INTO dbo.users
(
    username,
    password
)
VALUES
(   '', -- username - varchar(20)
    ''  -- password - varchar(20)
    )
INSERT INTO dbo.student
(
    id,
    lname,
    fname,
    BirthDate,
    gender,
    phone,
    address,
    img
)
VALUES
(   N'', -- id - nvarchar(100)
    N'', -- lname - nvarchar(100)
    N'', -- fname - nvarchar(100)
    N'', -- BirthDate - nvarchar(100)
    N'', -- gender - nvarchar(100)
    N'', -- phone - nvarchar(100)
    N'', -- address - nvarchar(100)
    NULL -- img - image
    )
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
 TRUNCATE TABLE dbo.student

 ALTER TABLE dbo.student
 ALTER COLUMN BirthDate DATETIME;

 CREATE TABLE course(
	id INT  PRIMARY KEY,
	label NVARCHAR(50) NOT NULL,
	period int ,
	description TEXT
 )
 GO
 DROP TABLE course
GO
INSERT INTO dbo.course
(
   
    label,
    description
)
VALUES
(   
    N'window programming', -- label - nvarchar(50)
    'New course'   -- description - text
    )