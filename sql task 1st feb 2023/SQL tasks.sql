use Adventureworks
go 

--1
select FirstName,LastName
from Person.Person
where Title is not null

--2
select FirstName,LastName
from Person.Person
where FirstName like '%a%' and LastName like '%a%'

--3
select name,sc.CurrencyCode,scc.CurrencyCode
from Sales.Currency sc,Sales.CountryRegionCurrency scc

--4
select * 
into hr_dept
from HumanResources.Department
select * from hr_dept

--5
create table sno
(
regno int,
firstname varchar(20),
lastname varchar(20),
city varchar(20),
country varchar(20)
)
insert into sno
values('1','abc','def','chennai','india')
insert into sno
values('2','abc','def','chennai','india')
insert into sno
values('3','abc','def','chennai','india')
insert into sno
values('4','abc','def','chennai','india')
insert into sno
values('5','abc','def','chennai','india')
insert into sno
values('6','abc','def','chennai','india')
insert into sno
values('7','abc','def','chennai','india')
insert into sno
values('8','abc','def','chennai','india')
insert into sno
values('9','abc','def','chennai','india')
insert into sno
values('10','abc','def','chennai','india')
insert into sno
values('11','abc','def','chennai','india')
insert into sno
values('12','abc','def','chennai','india')
insert into sno
values('13','abc','def','chennai','india')
insert into sno
values('14','abc','def','chennai','india')
insert into sno
values('15','abc','def','chennai','india')
insert into sno
values('16','abc','def','chennai','india')
insert into sno
values('17','abc','def','chennai','india')
insert into sno
values('18','abc','def','chennai','india')
insert into sno
values('19','abc','def','chennai','india')
insert into sno
values('20','abc','def','chennai','india')
select * from sno

--6
select pr.BusinessEntityID, AddressTypeID
from HumanResources.Department dept
join Person.BusinessEntityAddress pr
on dept.DepartmentID = pr.BusinessEntityID


--7
select distinct GroupName
from HumanResources.Department

--8
select sum(ListPrice), sum(p.StandardCost), ProductSubcategoryID
from Production.ProductCostHistory p 
join Production.Product prod
on p.ProductID = prod.ProductID
group by ProductSubcategoryID

--9
select DATEDIFF(year, StartDate, EndDate) Role
from HumanResources.EmployeeDepartmentHistory

--11
select max(TaxRate) Max_taxrate
from Sales.SalesTaxRate

--12
select dept.DepartmentID, emp.BusinessEntityID, dh.ShiftID, emp.BirthDate
from HumanResources.Department dept 
join HumanResources.Employee emp 
on dept.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dh
on dh.BusinessEntityID = emp.BusinessEntityID

--13
create view Name_age
as
Select dept.DepartmentID, emp.BusinessEntityID, dhis.ShiftID, emp.BirthDate, getdate() as CurrentDate, year(getdate())-year(emp.BirthDate) as age 
from HumanResources.Department dept
join HumanResources.Employee emp 
on dept.DepartmentID = emp.BusinessEntityID
join HumanResources.EmployeeDepartmentHistory dhis
on dhis.BusinessEntityID = emp.BusinessEntityID

--14
select count(*) [No_of_rows] from HumanResources.Department, HumanResources.Employee

--15
select max(Rate) Max_Rate,Name
from HumanResources.EmployeePayHistory e join
HumanResources.Department d
on e.BusinessEntityID = d.DepartmentID
group by Name

--16
select FirstName,MiddleName,Title,AddressTypeID,b.BusinessEntityID
from Person.Person p
left join Person.BusinessEntityAddress b
on p.BusinessEntityID=b.BusinessEntityID
where Title is not null 

--17
select ProductID,pl.LocationID,Shelf
from Production.ProductInventory pi
join Production.Location pl
on pi.LocationID=pl.LocationID
where ProductID>=300 and ProductID<=350 and pl.LocationID=50 or Shelf='E'

--18
select Shelf,Name,pi.LocationID
from Production.ProductInventory pi
join Production.Location pl
on pi.LocationID=pl.LocationID

--19 
select AddressID,AddressLine1,AddressLine2,st.StateProvinceID,StateProvinceCode,CountryRegionCode
from Person.StateProvince st
join Person.Address pa
on st.StateProvinceID=pa.StateProvinceID

--20
select  CurrencyCode,Sum(SubTotal+TaxAmt) as total
from Sales.SalesOrderHeader s
join Sales.SalesTerritory st
on st.TerritoryID=s.TerritoryID
join Sales.CountryRegionCurrency crc
on crc.CountryRegionCode=st.CountryRegionCode
group by CurrencyCode


