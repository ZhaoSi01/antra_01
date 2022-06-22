use AdventureWorks2019
GO
--1
SELECT ProductID, Name, Color ,ListPrice
FROM Production.Product;
--2
SELECT ProductID, Name, Color ,ListPrice
FROM Production.Product
where ListPrice != 0;
--3
SELECT ProductID, Name, Color ,ListPrice
FROM Production.Product
where color is not null;
--4
SELECT ProductID, Name, Color ,ListPrice
FROM Production.Product
where color is not null
and ListPrice > 0;
--5
SELECT Name+''+ Color 
FROM Production.Product
where color is not null;
--6
SELECT top 6 'Name:'+Name+'--Color:'+ Color 
FROM Production.Product
where color is not null;
--7
SELECT ProductID, Name
FROM Production.Product
WHERE ProductID BETWEEN 400 and 500;
--8
SELECT ProductID, Name, color
FROM Production.Product
WHERE color = 'Black' or color = 'Blue';
--8 (2)
SELECT ProductID, Name, color
FROM Production.Product
WHERE color in ('Black' , 'Blue');
--9
SELECT  Name, color
FROM Production.Product
WHERE Name LIKE 'S%';
--10
(SELECT Name, ListPrice
FROM Production.Product
WHERE Name LIKE  'A%'
)union
(SELECT top 2 Name, ListPrice
FROM Production.Product
WHERE Name LIKE  'Seat%'
)ORDER BY name
--11
SELECT Name
FROM Production.Product
WHERE Name LIKE  'SPO[^K]%'
ORDER BY NAME
--12
SELECT DISTINCT ProductSubcategoryID, Color
FROM Production.Product
WHERE color is not null
and  
ProductSubcategoryID is not null
;


