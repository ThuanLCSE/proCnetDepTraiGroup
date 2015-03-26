
---------------------
CREATE PROCEDURE [InsertEmployee]

	@lastname nvarchar(20) ,
	@firstname nvarchar(10), 
	@title nvarchar(30),
	@titleofcourtesy nvarchar(25),
	@birthdate datetime,
	@hiredate datetime,
	@address nvarchar(60), 
	@city nvarchar(15), 
	@region nvarchar(15), 
	@postalcode nvarchar(10), 
	@country nvarchar(15), 
	@phone nvarchar (24), 
	@mgrid int 

AS
BEGIN
	IF( @mgrid in (SELECT empID FROM [HR].[Employees] )
	BEGIN	
		INSERT INTO Employees (lastname,firstname,title,titleofcourtesy,birthdate,hiredate,address,city,region,postalcode,country,phone,mgrid)
		VALUES (@lastname,@firstname,@title,@titleofcourtesy,@birthdate,@hiredate,@address,@city,@region,@postalcode,@country,@phone,@mgrid)
	
END
GO
---------------------

CREATE PROCEDURE [HR].[UpdateEmployee]

	@lastname nvarchar(20) ,
	@firstname nvarchar(10), 
	@title nvarchar(30),
	@titleofcourtesy nvarchar(25),
	@birthdate datetime,
	@hiredate datetime,
	@address nvarchar(60), 
	@city nvarchar(15), 
	@region nvarchar(15), 
	@postalcode nvarchar(10), 
	@country nvarchar(15), 
	@phone nvarchar (24), 
	@mgrid int 

AS
BEGIN
	UPDATE Employees SET lastname=@lastname,firstname=@firstname,title=@title,titleofcourtesy=@titleofcourtesy,birthdate=@birthdate,hiredate=@hiredate,address=@address,city=@city,region=@region,postalcode=@postalcode,country=@country,phone=@phone,mgrid=@mgrid
	
END
GO
-----------------------------------
CREATE PROCEDURE [HR].[DeleteEmployee]
@id int
AS
BEGIN
	DELETE FROM Employees WHERE empid=@id
END
GO
-----------------------------------

CREATE PROCEDURE [Sales].[InsertCustomers]
@companyname nvarchar (40),
@contactname nvarchar (30),
@contacttitle nvarchar (30),
@address nvarchar (60),
@city nvarchar (15),
@region nvarchar (15),
@postalcode nvarchar (10),
@country nvarchar (15),
@phone nvarchar (24),
@fax nvarchar (24)
 
AS
BEGIN
INSERT INTO  Customers  (companyname,contactname,contacttitle,address,city,region,postalcode,country,phone,fax)
Values  (@companyname,@contactname,@contacttitle,@address,@city,@region,@postalcode,@country,@phone,@fax)
End
GO

--------------
CREATE PROCEDURE [Sales].[UpdateCustomer]
@companyname nvarchar (40),
@contactname nvarchar (30),
@contacttitle nvarchar (30),
@address nvarchar (60),
@city nvarchar (15),
@region nvarchar (15),
@postalcode nvarchar (10),
@country nvarchar (15),
@phone nvarchar (24),
@fax nvarchar (24)
 AS
BEGIN
UPDATE  Customers SET companyname=@companyname ,contactname=@contactname ,contacttitle=@contacttitle ,address=@address ,city=@city ,region=@region ,postalcode=@postalcode ,country=@country ,phone=@phone ,fax=@fax
End
GO
------------
CREATE PROCEDURE [Sales].[DeleteCustomer]
@id int
AS
BEGIN
	DELETE FROM Sales.Customers WHERE  custid=@id
END
GO
-----------
CREATE PROCEDURE [Production].[InsertCategories]
@categoryname nvarchar (15),
@description nvarchar (200)
 
AS
BEGIN
INSERT INTO  Categories   (categoryname,description)
Values  (@categoryname,@description)
End
GO
--------------------------
CREATE PROCEDURE [Production].[UpdateCategories]
@categoryname nvarchar (15),
@description nvarchar (200)
AS
BEGIN
UPDATE   Categories     SET categoryname=@categoryname ,description=@description  
End
GO
----------------------
CREATE PROCEDURE [Production].[DeleteCategories]
@id int
AS
BEGIN
	DELETE FROM Production.Categories WHERE  categoryid=@id
END
GO
----------------------
CREATE PROCEDURE  [Production].[InsertSupliers]
@companyname nvarchar (40),
@contactname nvarchar (30),
@contacttitle nvarchar (30),
@address nvarchar (60),
@city nvarchar (15),
@region nvarchar (15),
@postalcode nvarchar (10),
@country nvarchar (15),
@phone nvarchar (24),
@fax nvarchar (24)
 
AS
BEGIN
INSERT INTO   Production.Suppliers(companyname,contactname,contacttitle,address,city,region,postalcode,country,phone,fax)
Values  (@companyname,@contactname,@contacttitle,@address,@city,@region,@postalcode,@country,@phone,@fax)
End
GO
------
CREATE PROCEDURE  [Production].[UpdateSupliers]
@companyname nvarchar (40),
@contactname nvarchar (30),
@contacttitle nvarchar (30),
@address nvarchar (60),
@city nvarchar (15),
@region nvarchar (15),
@postalcode nvarchar (10),
@country nvarchar (15),
@phone nvarchar (24),
@fax nvarchar (24)
AS
BEGIN
UPDATE Production.Suppliers       SET companyname=@companyname ,contactname=@contactname ,contacttitle=@contacttitle ,address=@address ,city=@city ,region=@region ,postalcode=@postalcode ,country=@country ,phone=@phone ,fax=@fax 
End
GO
---------------------------
CREATE PROCEDURE [Production].[DeleteSuplier]
@id int
AS
BEGIN
	DELETE FROM Production.Suppliers WHERE  supplierid=@id
END
GO
---------------------------
CREATE PROCEDURE  [Sales].[InsertShippers]
@companyname nvarchar (40),
@phone nvarchar (24)
 
AS
BEGIN
INSERT INTO    Sales.Shippers (companyname,phone)
Values  (@companyname,@phone)
End
GO
-------
CREATE PROCEDURE  [Sales].[UpdateShippers]
@companyname nvarchar (40),
@phone nvarchar (24)
AS

BEGIN
UPDATE   Sales.Shippers     SET companyname=@companyname ,phone=@phone 
End
GO
--------------------------
CREATE PROCEDURE [Sales].[DeleteShipper]
@id int
AS
BEGIN
	DELETE FROM Sales.Shippers WHERE  shipperid=@id
END
GO
--------------------------
CREATE PROCEDURE  [Production].[InsertProduct]
@productname nvarchar (40),
@supplierid int,
@categoryid int,
@unitprice money,
@discontinued bit
 
AS
BEGIN
	IF ( @supplierid in (SELECT supplierID FROM Production.Suppliers ) and @categoryid in (SELECT categoryID FROM Production.Categories) )
	BEGIN
		INSERT INTO  Production.Products (productname,supplierid,categoryid,unitprice,discontinued)
		Values  (@productname,@supplierid,@categoryid,@unitprice,@discontinued)
	END
End
GO
-------------

CREATE PROCEDURE  [Production].[UpdateProduct]
@productname nvarchar (40),
@supplierid int,
@categoryid int,
@unitprice money,
@discontinued bit
AS
BEGIN
	IF ( @supplierid in (SELECT supplierID FROM Production.Suppliers ) and @categoryid in (SELECT categoryID FROM Production.Categories) )
	BEGIN
	UPDATE  Production.Products     SET productname=@productname ,supplierid=@supplierid ,categoryid=@categoryid ,unitprice=@unitprice ,discontinued=@discontinued 
	END
End
GO
------------
CREATE PROCEDURE [Production].[DeleteProduct]
@id int
AS
BEGIN
	DELETE FROM Production.Products WHERE  productid=@id
END
GO
--------------
CREATE PROCEDURE [Sales].[InsertOrder]
@custid int,
@empid int,
@orderdate datetime,
@requireddate datetime,
@shippeddate datetime,
@shipperid int,
@freight money,
@shipname nvarchar (40),
@shipaddress nvarchar (60),
@shipcity nvarchar (15),
@shipregion nvarchar (15),
@shippostalcode nvarchar (10),
@shipcountry nvarchar (15)
 
AS
BEGIN
	IF( @custid in (SELECT custid FROM Sales.Customers) AND @empid in ( SELECT empid FROM HR.Employees) and @shipperid in (SELECT shipperID from Sales.Shippers))
	BEGIN
		INSERT INTO  Sales.Orders(custid,empid,orderdate,requireddate,shippeddate,shipperid,freight,shipname,shipaddress,shipcity,shipregion,shippostalcode,shipcountry)
		Values  (@custid,@empid,@orderdate,@requireddate,@shippeddate,@shipperid,@freight,@shipname,@shipaddress,@shipcity,@shipregion,@shippostalcode,@shipcountry)
	END
End

GO
----------------

CREATE PROCEDURE [Sales].[UpdateOrder]
@custid int,
@empid int,
@orderdate datetime,
@requireddate datetime,
@shippeddate datetime,
@shipperid int,
@freight money,
@shipname nvarchar (40),
@shipaddress nvarchar (60),
@shipcity nvarchar (15),
@shipregion nvarchar (15),
@shippostalcode nvarchar (10),
@shipcountry nvarchar (15)
AS
BEGIN
	IF( @custid in (SELECT custid FROM Sales.Customers) AND @empid in ( SELECT empid FROM HR.Employees) and @shipperid in (SELECT shipperID from Sales.Shippers))
	BEGIN
		UPDATE  Sales.Orders      SET custid=@custid ,empid=@empid ,orderdate=@orderdate ,requireddate=@requireddate ,shippeddate=@shippeddate ,shipperid=@shipperid ,freight=@freight ,shipname=@shipname ,shipaddress=@shipaddress ,shipcity=@shipcity ,shipregion=@shipregion ,shippostalcode=@shippostalcode ,shipcountry=@shipcountry 
	END
End
GO
---------------------
CREATE PROCEDURE [Sales].[DeleteOrder]
@id int
AS
BEGIN
	DELETE FROM  Sales.Orders  WHERE  orderid=@id
END
GO
---------------------

CREATE PROCEDURE [Sales].[InsertOrderDetail]
@productid int,
@unitprice money,
@qty smallint,
@discount numeric (4,3)

 
AS
BEGIN
	IF( @productid in (SELECT productid FROM Production.Product ) )
	BEGIN
		INSERT INTO  Sales.OrderDetails (productid,unitprice,qty,discount)
		Values  (@productid,@unitprice,@qty,@discount)
	END
End
GO
--------------------------------------------

CREATE PROCEDURE [Sales].[UpdateOrderDetail]
@productid int,
@unitprice money,
@qty smallint,
@discount numeric (4,3)
AS
BEGIN
	IF( @productid in (SELECT productid FROM Production.Product ) )
	BEGIN
	UPDATE   Sales.OrderDetails     SET productid=@productid ,unitprice=@unitprice ,qty=@qty ,discount=@discount 
	END
End
GO
-------------
