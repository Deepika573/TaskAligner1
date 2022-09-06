drop database TaskAligner

create database TaskAligner;

use TaskAligner;
create table Designation( DesignationId int Primary Key, DesignationName Varchar(30))
create table Department( DepartmentId int Primary Key, DepartmentName Varchar(30))
create table Users(EmployeeId varchar(30) Primary Key, EmployeeName Varchar(30) Not null , DesignationId int Not Null foreign key references Designation(DesignationId),DepartmentId int Not Null foreign key references Department(DepartmentId), UserName Varchar(30) Not Null, Passwords Varchar(30) Not Null,Email Varchar(100) Not Null)
create table DepartmentTeam(DepTeamId int Primary key, DepTeamName varchar(30) Not Null, RmId varchar(30)  Not Null foreign key references Users(EmployeeId),EmployeeId varchar(30) Not Null foreign key references Users(EmployeeId),DepartmentId int Not Null foreign key references Department(DepartmentId))
create table Project(ProjectId int Primary key Not Null, ProjectName Varchar(30) not null, ProjectDescription varchar(300), ProjectDeadLine Date not null,AssignedToUserId Varchar(30) Not Null foreign key references Users(EmployeeId))
create table ProjectTeam(ProjectTeamId int Primary key, ProjectId int Not Null foreign key references Project(ProjectId), ProjectHeadId varchar(30)  Not Null foreign key references Users(EmployeeId),ProjectTeamEmpId varchar(30) not null foreign key references Users(EmployeeId) )
create table IssueType(CategoryId int primary key not null, CategoryName varchar (30) not null)
create table Tasks(TaskId int Primary key, TaskName varchar(30) not null, TaskDescription varchar(300) not null, AssignedToId varchar(30) not null foreign key references Users(EmployeeId), ProjectId int not null foreign key references Project(ProjectId), TaskDeadline Date not null)
create table Issue(IssueId int primary key not null, CategoryId int not null foreign key references IssueType(CategoryId),IssueDescription varchar(300),  Urgency int not null , TaskId int not null foreign key references Tasks(TaskId))
insert into Department values(1, 'CEI')
insert into Department values(2, 'Sales')
insert into Department values(3, 'Finance')
insert into Designation values(1, 'Cloud Engineer')
insert into Designation values(2, ' Sr Cloud Engineer')
insert into Designation values(3, 'Tech Lead')
insert into Designation values(4, 'Sr Sales Executive')
insert into Users values('101', 'Deepika Rawat', 1, 1, 'Deepika', 'Deepika@123', 'Deepika.Rawat@hanu.com')
insert into Users values('102', 'Harshit Sehgal', 1, 1, 'Harshit', 'Harshit@123', 'Harshit.Sehgal@hanu.com')
insert into Users values('103', 'Atul Garg', 1, 1, 'Atul', 'Atul@123', 'Atul.Garg@hanu.com')
insert into Users values('104', 'Srishti Anand', 1, 1, 'Srishti', 'Srishti@123', 'Srishti.Anand@hanu.com')
insert into Users values('105', 'Shivam ', 1, 1, 'Shivam', 'Shivam@123', 'Shivam@hanu.com');
insert into DepartmentTeam values(1, 'CEI_AP','105','101',1)
insert into Project values(1, 'Ford', 'Full Stack Application in Azure', '2022-10-10', 105)
insert into ProjectTeam values(1, 1, 105, 101)
insert into IssueType values(1,'Hardware Problem')
insert into IssueType values(2,'Software Problem')
insert into IssueType values(3,'Bug')
insert into Tasks values(1,'Infrastructure Creation','Creating Azure Services', 101, 1, '2022-10-10')
insert into Issue values(1, 1,'Not Wroking',1,1)
select * from Department
select * from Designation
select * from Users
select * from Project
select * from IssueType
select * from Tasks
select * from Issue

DELETE Users


--ALTER TABLE Project
--ADD AssignedToUserId Varchar(30) Not Null foreign key references Users(EmployeeId);