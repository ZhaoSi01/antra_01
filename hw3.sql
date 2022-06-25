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
CREATE Table city_Yu(cid int, cid int)
CREATE Table people_Yu(pid int, pName varchar(20), cid int)

