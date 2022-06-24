use AdventureWorks2019
GO
--1
SELECT c.Name as Country,s.Name as Province 
from Person.StateProvince s
join
Person.CountryRegion c
on
s.CountryRegionCode = c.CountryRegionCode;

--2
SELECT c.Name as Country,s.Name as Province 
from Person.StateProvince s
join
Person.CountryRegion c
on
s.CountryRegionCode = c.CountryRegionCode
where c.Name in ('Germany', 'Canada');

--3
-- DECLARE @today DATETIME
-- SELECT @today = GETDATE()

Use Northwind
Go

SELECT ode.ProductName
from [Order Details Extended] ode
join [Order Details] od 
on od.OrderID = ode.OrderID
join Orders o 
on od.OrderID = o.OrderID
where datediff(year, GETDATE(),o.OrderDate) < 25 
GROUP by ode.ProductName

--4
-- List top 5 locations (Zip Code) where the products sold most in last 25 years.
SELECT top 5 COUNT(o.ShipPostalCode) AS count ,o.ShipPostalCode
from Orders o 
where datediff(year, GETDATE(),o.OrderDate) < 25 
GROUP by ShipPostalCode
order by count desc


--5
Select city, count(customerID)as count 
from Customers
group by city
--order by COUNT desc

--6
select help.city, help.COUNT
from
(Select city, count(customerID)as count 
from Customers
group by city) as help
where help.COUNT > 2;

--7
SELECT customers.companyName, sum(Quantity) as productsTheyBought
from
(SELECT distinct c.companyName,c.CustomerID, o.orderID
from Customers c
join orders o
on o.CustomerID = c.customerId ) as customers
JOIN
[Order Details] as od 
on od.orderID = customers.orderID
group by customers.companyName

--8
select companyName, productsTheyBought from
(SELECT customers.companyName, sum(Quantity) as productsTheyBought
from
(SELECT distinct c.companyName,c.CustomerID, o.orderID
from Customers c
join orders o
on o.CustomerID = c.customerId ) as customers
JOIN
[Order Details] as od 
on od.orderID = customers.orderID
group by customers.companyName) help
where productsTheyBought > 100

--9
select DISTINCT s1.companyName as [Supplier Company Name], s2.companyName as [Shippping Company Name]
from Suppliers s1
cross join 
Shippers s2

--10
SELECT distinct o.ORDERdate,  p.productName
from orders o
join [order details]od
on od.orderID = o.orderID
join products p
on od.productID= p.productID

--11
select distinct e1.firstName+' '+e1.lastName , e2.firstName+' '+ e2.lastname 
from employees e1
join employees e2
on e1.title = e2.title 
where e1.employeeID != e2.employeeID

--12
select Manager from 
(select count(j.firstName+' '+j.lastName) as count1,j.firstName+' '+j.lastName as Manager
from employees j
join employees e
on e.ReportsTo = j.employeeID
GROUP by j.firstName+' '+j.lastName)a

--13
--need to use funvtion for type
SELECT c.city as city, c.CompanyName as name , c.ContactName as [Contact Name]
from Customers c
UNION ALL
SELECT s.city as city, s.CompanyName as name , s.ContactName as [Contact Name]
FROM Suppliers s

--14
select City
from Customers
UNION
select City
from Employees

--15
--a
select City
from Customers
where city not in (select City
from Employees)

--b
select c.City as city
from Customers c
left JOIN
Employees E
where City not in Employees E
--Wrong

--16
SELECT p.ProductName, Sum(od.quantity) 
from Products p 
join [Order Details] od 
on p.ProductID = od.ProductID 
join Orders o 
ON od.OrderID = o.OrderID
group by p.ProductName
--GROUP BY p.ProductID

--17
--A
--union

(select distinct City
FROM Customers)
UNION


--b
--no union
select City from(SELECT City, count(customerID)as co
FROM Customers c
GROUP BY c.City)help
where co >=2


--18
select a.Cities
from 
(select c.city as Cities, p.ProductName as Produ
from orders o
join Customers C
on o.CustomerID = c.customerID
join [Order Details]od 
on od.OrderID = o.OrderID
join Products p 
on p.ProductID = od.ProductID) a 
where count(Produ) >=2
group by a.Cities


--19
select top 5 AVG(products.unitprice) from Products

--20
select top 1 shipcity, count(orderID) as co
from Orders
group by shipcity
ORDER by co desc


--21
--1 use distinct constrains
--2 use delete method to remove the selected data

