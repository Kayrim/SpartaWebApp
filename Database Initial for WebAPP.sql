use master 

go

drop database if exists SpartaDB

go

create database SpartaDB

go

use SpartaDB

go

CREATE TABLE Category (
    CategoryID int not null primary key identity,
    CategoryName varchar (100)
);

go

CREATE TABLE Trainer (
    TrainerID int not null primary key identity,
    LastName varchar(30),
    FirstName varchar(30),
    Photo varchar(255),
    Bio varchar (255)
);

go

CREATE TABLE Course (
    CourseID int not null primary key identity,
    CourseName varchar(30),
    CatgeoryID int foreign key references Category(CategoryID),
    LengthOfCourse varchar (100),
    CourseDescription varchar (255)
);

go

CREATE TABLE Student (
    StudentID int not null primary key identity,
    LastName varchar(30),
    FirstName varchar(30),
    CourseID int foreign key references Course(CourseID),
    Photo varchar(255),
    Bio varchar (255),
    University varchar (100)
);

go 



CREATE TABLE Project (
    ProjectID int not null primary key identity,
    ProjectName varchar(50),
    StudentID int foreign key references Student(StudentID),
    ProjectDescription varchar (255)
);

go

CREATE TABLE TrainerCourses (
    TCID int not null primary key identity,
    CourseID int foreign key references Course(CourseID),
    TrainerID int foreign key references Trainer(TrainerID)

);

go

INSERT INTO Category Values
('Developer'),
('Business');

go

INSERT INTO Trainer (FirstName,LastName,Bio) Values
('Phil', 'Anderson' ,'I love Ketchup');

go

INSERT INTO Course (CourseName,CatgeoryID,LengthOfCourse,CourseDescription) Values
('C# Dev',1, '10 Weeks', 'C# Development courses for learning programming full stack'),
('Java Dev',1, '10 Weeks', 'Java Development courses for learning programming full stack'),
('Business Analyst',2, '5 Weeks', 'Agile and some SQL');

go

INSERT INTO Student (FirstName, LastName, CourseID, Bio,University) Values 
('Karim','Bakkali',1, 'I like food', 'Kings College'),
('Stephen','Callum',1,  'I want waves', 'Swansea University'),
('Jamie','Benjamin',1,  'I play games with my hands', 'Anglia Ruskin University'),
('Hassan','Abdullahi',1, 'I pray 5 times a day', 'Queen Mary'),
('James','Kavanagh',1,  'Wish I was as good as Jamie, Karim and Stephen', 'University of Kent'),
('Timothy','Wong',1,  'Ooooo I like that', 'Brunel University'),
('Jordan','Benbelaid',1, 'I left it on my home computer', 'Brunel University');

go



INSERT INTO Project (StudentID,ProjectName,ProjectDescription) Values
(1, 'Unity Game Project', 'Made a first person Shooter'),
(2, 'Unity Game Project', 'Made a third person platformer'),
(3, 'Unity Game Project', 'Made a flight simulator in space');

go

INSERT INTO TrainerCourses  Values
(1,1);




