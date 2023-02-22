create table dept
(
DepartmentId int identity(51,1),
DepartmentName varchar(50)
constraint pk_deptid primary key(DepartmentId)
)
create table employee
(
Employeeid int identity(100,1),
Employeename varchar(50),
Empgender varchar(20),
Deptid int,
constraint pk_empid primary key(Employeeid),
constraint fk_deptid foreign key(Deptid)
references dept(DepartmentId) 
)
alter table employee
add empgen varchar(10) check(empgen in('m','f'))

sp_help 'employee'