create database Employee
use Employee

create table EmployeeDetails
(
EmployeeId int primary key  ,
EmployeeName varchar(100),
Gender varchar(10),
Salary int,
Department varchar(50)
)

insert into EmployeeDetails values(1,'Ridhi','Female',20000,'IT')
insert into EmployeeDetails values(2,'Ansh','Male',50000,'HR')
insert into EmployeeDetails values(3,'Pooja','Female',35000,'Finance')

select * from EmployeeDetails