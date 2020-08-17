CREATE TABLE class(
	class_id varchar(20) primary key ,
	class_name varchar(50),
);

CREATE TABLE subjects(
	subject_id varchar(20) primary key,
	class_id varchar(20) foreign key references class, 
	subject_name varchar(50),

);
Create Table userpass (
	username varchar(30) primary key,
	pw varchar(20) unique
);


CREATE TABLE Student(
	
	RollNumber varchar(20) primary key NOT NULL,
	FName varchar(50) NOT NULL,
	LName  varchar(50) NOT NULL,
	FatherName varchar(50),
	class_id varchar(20) foreign key references class NOT NULL, 
	DOB date,
	BForm varchar(13) ,
	Phone varchar(15) NOT NULL,
	Std_Address varchar(300),
	city varchar(20),
	province varchar(20),
	religion varchar(20),
	Gender varchar(20) NOT NULL,
	FeeStatus varchar(20) NOT NULL,

);

CREATE TABLE teacher(
	TeacherId int IDENTITY(405,16) primary key ,
	class_id varchar(20) foreign key references class NOT NULL,
	TeacherName varchar(50) NOT NULL,
	TeacherFather varchar(50),
	CNIC varchar(13) NOT NULL,
	Teacher_DOB Date,
	Teacher_Phone varchar(20),
	Teacher_Address varchar(300),
);
CREATE TABLE result(
	RollNumber varchar(20) foreign key references student,
	class_id varchar(20) foreign key references class,
	subject_id varchar(20) foreign key references subjects,

);
delete from Student where RollNumber=1233;
select * from teacher;
insert into userpass values('huzaifa','huzaifa');
Alter Table userpass ADD designation varchar(30); 
select * from