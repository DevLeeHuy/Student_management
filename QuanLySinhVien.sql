create database StdManagement;
use StdManagement;
create table users(
	id int not null identity(1,1) primary key,
	username varchar(20),
	password varchar(20),
	fname nvarchar(20),
	lname nvarchar(20),
	img image
);
INSERT INTO users VALUES('huy','pass','huy','le',null)
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
	id INT NOT NULL,
	lname nvarchar(100) NOT NULL,
	fname nvarchar(100) NOT NULL,
	BirthDate nvarchar(100) NOT NULL, 
	gender nvarchar(100)  NOT NULL,
	phone nvarchar(100),
	address nvarchar(100),
	img image,
	PRIMARY KEY (id)
	);
	DROP TABLE dbo.student
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
 ALTER TABLE dbo.course
 ADD semester int
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

CREATE TABLE Study(
	sid INT FOREIGN KEY REFERENCES dbo.student(id) ON DELETE CASCADE,
	cid INT FOREIGN KEY REFERENCES dbo.course(id) ON DELETE CASCADE
)
INSERT INTO dbo.Study
(
    sid,
    cid
)
VALUES
(   18110063, -- sid - int
    20 -- cid - int
    )
DROP TABLE dbo.Study

INSERT INTO dbo.Study
(
    sid,
    cid
)
VALUES
(   N'', -- sid - nvarchar(100)
    0    -- cid - int
    )

GO
SELECT * FROM dbo.student
SELECT * FROM dbo.course
SELECT * FROM dbo.Study

GO 
ALTER FUNCTION getListStudy(@id int)
RETURNS TABLE
AS
RETURN	(
	SELECT s.id, s.lname,s.fname,s.gender,stdy.stdScore as score,stdy.description FROM dbo.course AS c,dbo.student AS s,dbo.Score AS stdy 
	WHERE c.id = stdy.cid
	AND	s.id = stdy.sid
	AND	c.id = @id
)

GO
SELECT * FROM getListStudy(1)

CREATE TABLE Score(
	sid INT FOREIGN KEY REFERENCES dbo.student(id) ON DELETE CASCADE,
	cid INT	FOREIGN KEY REFERENCES dbo.course(id) ON DELETE CASCADE,
	stdScore FLOAT,
	description TEXT,
	CONSTRAINT pk_scoreID PRIMARY KEY(sid,cid)
)
DROP TABLE dbo.Score

INSERT INTO dbo.Score
(
    sid,
    cid,
    stdScore,
    description
)
VALUES
(   1810016,   -- sid - int
    1,   -- cid - int
    NULL, -- stdScore - float
    'chua co diem'   -- description - text
    )
GO	
CREATE FUNCTION	avgScore()
RETURNS TABLE 
AS	
RETURN(
	SELECT c.label, AVG(stdScore)AS AvgScore FROM dbo.course AS c, dbo.Score AS s
	WHERE c.id = s.cid
	GROUP BY c.label
)
GO
SELECT * FROM	dbo.avgScore()

SELECT * FROM dbo.Score
SELECT * FROM dbo.student
SELECT * FROM dbo.course
select * from dbo.users

go
update Score set stdScore= null where sid = 18110063 and cid = 2

go
alter function getCnameByCid(@cid int)
returns varchar(20)
as begin
declare @name varchar(20)
select TOP (1) @name = label from course where id = @cid 
return @name
end
select dbo.getCnameByCid(2);
go
SELECT student.id ,stdScore FROM student LEFT JOIN Score ON student.id = Score.sid AND cid =2;
go
SELECT sid as id, avg(stdScore) as "Average Score" FROM Score GROUP BY sid
go

create database HR_management;
use HR_management;
create table contact(
    id int not null identity(1,1) primary key,
	fname nvarchar(20),
	lname nvarchar(20),
    phone varchar(20),
    address nvarchar(50),
    email varchar(20),
    uid int foreign key references users(id) ,
    gid int foreign key references groups(id) on delete cascade,
	img image
)
create table groups(
    id int not null identity(1,1) primary key,
    name varchar(20),
     uid int foreign key references users(id) on delete cascade,
)

select * from groups
select * from contact

SELECT student.id, avg(stdScore) as 'Average Score' FROM student, Score,course WHERE student.id = Score.sid AND course.id= Score.cid AND course.semester=1 GROUP BY student.id