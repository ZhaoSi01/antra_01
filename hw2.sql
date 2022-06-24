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
SELECT ORDERdate
from orders
