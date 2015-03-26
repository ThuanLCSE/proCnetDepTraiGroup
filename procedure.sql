--declare @procName varchar(500)
--declare cur cursor
--    for select [name] from sys.objects where type = 'p'
--open cur

--fetch next from cur into @procName
--      while @@fetch_status = 0
--      begin
--            if @procName <> 'DeleteAllProcedures'
--                  exec('drop procedure ' + @procName)
--                  fetch next from cur into @procName
--      end

--close cur
--deallocate cur

-----------------------
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
	
	BEGIN	
		INSERT INTO HR.Employees (lastname,firstname,title,titleofcourtesy,birthdate,hiredate,address,city,region,postalcode,country,phone,mgrid)
		VALUES (@lastname,@firstname,@title,@titleofcourtesy,@birthdate,@hiredate,@address,@city,@region,@postalcode,@country,@phone,@mgrid)
	END

END
GO
---------------------

CREATE PROCEDURE [UpdateEmployee]

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
	UPDATE HR.Employees SET lastname=@lastname,firstname=@firstname,title=@title,titleofcourtesy=@titleofcourtesy,birthdate=@birthdate,hiredate=@hiredate,address=@address,city=@city,region=@region,postalcode=@postalcode,country=@country,phone=@phone,mgrid=@mgrid
	
END
GO
-----------------------------------

CREATE PROCEDURE [DeleteEmployee]
@id int
AS
BEGIN
	DELETE FROM HR.Employees WHERE empid=@id
END
GO
-----------------------------------

CREATE PROCEDURE [InsertCustomers]
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
	INSERT INTO  Sales.Customers  (companyname,contactname,contacttitle,address,city,region,postalcode,country,phone,fax)
	Values  (@companyname,@contactname,@contacttitle,@address,@city,@region,@postalcode,@country,@phone,@fax)
End
GO
 --EXECUTE InsertCustomers @companyname='hihi2',@contactname='cc2',@contacttitle='ee',@address='ee',@city='ee',@region='ee',@postalcode='ee',@country='ee',@phone='ee',@fax='ee'

--------------

CREATE PROCEDURE [UpdateCustomer]
@id int,
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
	UPDATE  Sales.Customers 
	SET companyname=@companyname ,contactname=@contactname ,contacttitle=@contacttitle ,address=@address ,city=@city ,region=@region ,postalcode=@postalcode ,country=@country ,phone=@phone ,fax=@fax
	WHERE custid = @id;
End
GO
--EXECUTE UpdateCustomer @companyname='hihi1',@contactname='cc1',@contacttitle='ee2',@address='ee3',@city='ee',@region='ee',@postalcode='ee',@country='ee',@phone='ee',@fax='ee', @id =1

------------
CREATE PROCEDURE [DeleteCustomer]
@id int
AS
BEGIN
	DELETE FROM Sales.Customers WHERE  custid=@id
END
GO
-----------
CREATE PROCEDURE [InsertCategories]
@categoryname nvarchar (15),
@description nvarchar (200)
 
AS
BEGIN
INSERT INTO  Production.Categories   (categoryname,description)
Values  (@categoryname,@description)
End
GO
--------------------------
CREATE PROCEDURE [UpdateCategories]
@id int ,
@categoryname nvarchar (15),
@description nvarchar (200)
AS
BEGIN
UPDATE   Production.Categories     SET categoryname=@categoryname ,description=@description   WHERE categoryid =@id;
End
GO
----------------------
CREATE PROCEDURE [DeleteCategories]
@id int
AS
BEGIN
	DELETE FROM Production.Categories WHERE  categoryid=@id
END
GO
----------------------
CREATE PROCEDURE  [InsertSupliers]
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
INSERT INTO   Production.Suppliers (companyname,contactname,contacttitle,address,city,region,postalcode,country,phone,fax)
Values  (@companyname,@contactname,@contacttitle,@address,@city,@region,@postalcode,@country,@phone,@fax)
End
GO
------
CREATE PROCEDURE  [UpdateSupliers]
@id int ,
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
WHERE supplierid = @id;
End
GO
---------------------------
CREATE PROCEDURE [DeleteSuplier]
@id int
AS
BEGIN
	DELETE FROM Production.Suppliers WHERE  supplierid=@id
END
GO
---------------------------
CREATE PROCEDURE [InsertShippers]
@companyname nvarchar (40),
@phone nvarchar (24)
 
AS
BEGIN
INSERT INTO    Sales.Shippers (companyname,phone)
Values  (@companyname,@phone)
End
GO
-------
CREATE PROCEDURE  [UpdateShippers]
@id int ,
@companyname nvarchar (40),
@phone nvarchar (24)
AS

BEGIN
UPDATE   Sales.Shippers     SET companyname=@companyname ,phone=@phone  WHERE shipperid = @id;
End
GO
--------------------------
CREATE PROCEDURE .[DeleteShipper]
@id int
AS
BEGIN
	DELETE FROM Sales.Shippers WHERE  shipperid=@id
END
GO
--------------------------
CREATE PROCEDURE  [InsertProduct]
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

CREATE PROCEDURE  [UpdateProduct]
@id int ,
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
	WHERE productid= @id; 
	END
End
GO
------------
CREATE PROCEDURE [DeleteProduct]
@id int
AS
BEGIN
	DELETE FROM Production.Products WHERE  productid=@id
END
GO
--------------
CREATE PROCEDURE [InsertOrder]
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
		INSERT INTO  Sales.Orders (custid,empid,orderdate,requireddate,shippeddate,shipperid,freight,shipname,shipaddress,shipcity,shipregion,shippostalcode,shipcountry)
		Values  (@custid,@empid,@orderdate,@requireddate,@shippeddate,@shipperid,@freight,@shipname,@shipaddress,@shipcity,@shipregion,@shippostalcode,@shipcountry)
	END
End

GO
----------------

CREATE PROCEDURE [UpdateOrder]
@id int ,
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
		WHERE orderid = @id;
	END
End
GO
---------------------
CREATE PROCEDURE [DeleteOrder]
@id int
AS
BEGIN
	DELETE FROM  Sales.Orders  WHERE  orderid=@id
	DELETE FROM Sales.OrderDetails WHERE orderid = @id
END
GO
---------------------

CREATE PROCEDURE [InsertOrderDetail]
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

CREATE PROCEDURE [UpdateOrderDetail]
@id int ,
@productid int,
@unitprice money,
@qty smallint,
@discount numeric (4,3)
AS
BEGIN
	IF( @productid in (SELECT productid FROM Production.Product ) )
	BEGIN
	UPDATE   Sales.OrderDetails     SET productid=@productid ,unitprice=@unitprice ,qty=@qty ,discount=@discount
	WHERE orderid =@id ; 
	END
End
GO
-------------
