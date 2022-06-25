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


