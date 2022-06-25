use Northwind
go

--1
CREATE VIEW [view_product_order_(YangYu)] AS 
SELECT p.ProductName, sum(od.Quantity) as totalOrders
FROM Products p
JOIN [Order Details] od 
on od.ProductID = p.ProductID
GROUP by p.ProductName

-- DROP VIEW IF EXISTS [view_product_order_(YangYu)];
--select * from [view_product_order_(YangYu)];

--2
CREATE PROC [sp_product_order_(YangYu)]
 @a int
 AS
BEGIN
SELECT p.productID, p.ProductName, sum(od.Quantity) as totalOrders
FROM Products p
JOIN [Order Details] od 
on od.ProductID = p.ProductID
GROUP by p.ProductName,p.productID
having  p.productID = @a
END


 --exec [sp_product_order_(YangYu)] 23;




 -- [sp_product_order_(YangYu)]

-- SELECT p.ProductName, sum(od.Quantity) as totalOrders, p.productID
-- FROM Products p
-- JOIN [Order Details] od 
-- on od.ProductID = p.ProductID
-- GROUP by p.ProductName,p.productID

-- drop proc [sp_product_order_(YangYu)]


--3

CREATE PROC [sp_product_order_city_(Yu)]
@chai [nvarchar](40) 
AS
BEGIN
select top 5 o.shipcity , count(o.shipcity)
from PROducts P
join [Order Details] Od 
on p.productID = od.productID
join Orders o 
on O.orderID = od.orderID
where p.PROductName = @chai
GROUP by o.shipcity
order by count(o.shipcity) desc
END

--exec [sp_product_order_city_(Yu)] 'Chai';
--exec [sp_product_order_city_(Yu)] 'Tofu';


-- drop proc [sp_product_order_city_(Yu)]
-- select top 5 o.shipcity,count(o.shipcity)
-- from PROducts P
-- join [Order Details] Od 
-- on p.productID = od.productID
-- join Orders o 
-- on O.orderID = od.orderID
-- where p.PROductName = @chai
-- GROUP by o.shipcity
-- order by count(o.shipcity) desc

--4 
CREATE Table city_Yu
(cid int,
 cName varchar(20))

create table people_Yu
(
Id int,
PName varchar(20),
Cid int
)
INSERT into city_Yu VALUEs(1,'Seattle')
INSERT into city_Yu VALUES
(2,'Green Bay')

--select * from city_Yu 

INSERT into people_Yu VALUEs(1,'Aaron Rodgers', 2)
INSERT into people_Yu VALUEs(2,'Russell Wilson', 1)
INSERT into people_Yu VALUEs(3,'Jody Nelson', 2)
--select * from people_Yu

UPDATE people_Yu SET
cid = 3
where cid = 1;

INSERT into city_Yu VALUEs(3,'Madison')
DELETE FROM city_Yu WHERE 'Seattle' = cName;

CREATE VIEW [Packers_your_name] AS 
SELECT p.pName
from people_Yu p
join city_Yu C
on c.cid = p.Cid 
where c.cName = 'Green Bay'

--5




CREATE PROC [sp_birthday_employees_(YangYu)]
AS
BEGIN
-- select Month(e.BirthDate) as Month, e.EmployeeID
create table [birthday_employees_your_last_name_(YangYu)]
(
Month int,
eid int
)
insert into [birthday_employees_your_last_name_(YangYu)] select Month(e.BirthDate) as Month, e.EmployeeID from  Employees e where Month(e.BirthDate) = 2
End

exec [sp_birthday_employees_(YangYu)]
select * from [birthday_employees_your_last_name_(YangYu)];

DROP table [birthday_employees_your_last_name_(YangYu)]


-- DROP table [birthday_employees_your_last_name_(YangYu)]
 --drop proc [sp_birthday_employees_(YangYu)]
 

--6
--if both results of full table a except full table b and
--full table b except full table a are blank, the two tables are totally same
--Example 
select * 
from city_Yu a
EXCEPT 
select * 
from city_Yu b

select * 
from city_Yu b
EXCEPT 
select * 
from city_Yu a