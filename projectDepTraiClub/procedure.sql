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
--DROP PROCEDURE [SearchEmployee]
CREATE PROCEDURE [SearchEmployee]
@lastname nvarchar(20),
@firstname nvarchar(10)
AS
BEGIN

	SELECT 	* FROM HR.Employees WHERE ( lastname LIKE '%'+@lastname+'%' AND firstname LIKE '%'+@firstname+'%' );
END

--------------

--DROP PROCEDURE [InsertEmployee]
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
		IF (@mgrid is null)
		BEGIN	
		INSERT INTO HR.Employees (lastname,firstname,title,titleofcourtesy,birthdate,hiredate,[address],city,region,postalcode,country,phone,mgrid)
		VALUES (@lastname,@firstname,@title,@titleofcourtesy,@birthdate,@hiredate,@address,@city,@region,@postalcode,@country,@phone,@mgrid)
		END
		ELSE 
			BEGIN
				IF (@mgrid IN (SELECT empid FROM HR.Employees) ) 
				BEGIN	
				INSERT INTO HR.Employees (lastname,firstname,title,titleofcourtesy,birthdate,hiredate,[address],city,region,postalcode,country,phone,mgrid)
				VALUES (@lastname,@firstname,@title,@titleofcourtesy,@birthdate,@hiredate,@address,@city,@region,@postalcode,@country,@phone,@mgrid)
				END
				ELSE RAISERROR ('ko biet xai raiserro',1,1)
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
	UPDATE HR.Employees SET lastname=@lastname,firstname=@firstname,title=@title,titleofcourtesy=@titleofcourtesy,birthdate=@birthdate,hiredate=@hiredate,[address]=@address,city=@city,region=@region,postalcode=@postalcode,country=@country,phone=@phone,mgrid=@mgrid
	
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

CREATE PROCEDURE [SearchCustomers]

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
	SELECT * FROM  Sales.Customers    WHERE ( companyname LIKE '%'+@companyname+'%' AND contactname LIKE '%'+@contactname+'%' AND contacttitle LIKE '%'+@contacttitle+'%' AND [address] LIKE '%'+@address+'%' AND city LIKE '%'+@city+'%' AND region LIKE '%'+@region+'%' AND postalcode LIKE '%'+@postalcode+'%' AND country LIKE '%'+@country+'%' AND phone LIKE '%'+@phone+'%' AND fax LIKE '%'+@fax+'%' )
End
GO
----execute SearchCustomers @companyname='hi',@contactname='',@contacttitle='',@address ='',@city='',@region='',@postalcode='',@country='',@phone='',@fax=''

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
	INSERT INTO  Sales.Customers  (companyname,contactname,contacttitle,[address],city,region,postalcode,country,phone,fax)
	Values  (@companyname,@contactname,@contacttitle,@address,@city,@region,@postalcode,@country,@phone,@fax)
End
GO
 ------execute InsertCustomers @companyname='hihi2',@contactname='cc2',@contacttitle='ee',@address='ee',@city='ee',@region='ee',@postalcode='ee',@country='ee',@phone='ee',@fax='ee'

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
	SET companyname=@companyname ,contactname=@contactname ,contacttitle=@contacttitle ,[address]=@address ,city=@city ,region=@region ,postalcode=@postalcode ,country=@country ,phone=@phone ,fax=@fax
	WHERE custid = @id;
End
GO
------execute UpdateCustomer @companyname='hihi1',@contactname='cc1',@contacttitle='ee2',@address='ee3',@city='ee',@region='ee',@postalcode='ee',@country='ee',@phone='ee',@fax='ee', @id =1

------------
--DROP PROCEDURE [DeleteCustomer]
CREATE PROCEDURE [DeleteCustomer]
@id int
AS
BEGIN
	IF @id NOT IN (SELECT custid FROM Sales.Orders )
	BEGIN
	DELETE FROM Sales.Customers WHERE  custid=@id
	
	END
	ELSE RAISERROR ('ko biet xai raiserror', 16, 1);
END
GO
------execute DeleteCustomer @id =5
-----------
CREATE PROCEDURE [SearchCategories]
@categoryname nvarchar (15) ,
@description nvarchar (200)  
 
AS
BEGIN
SELECT * FROM  Production.Categories    WHERE ( categoryname LIKE '%'+@categoryname+'%' AND description LIKE '%'+@description+'%' );
End
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
CREATE PROCEDURE [SearchSupliers]

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
SELECT * FROM Production.Supliers    WHERE ( companyname LIKE '%'+@companyname+'%' AND contactname LIKE '%'+@contactname+'%' AND contacttitle LIKE '%'+@contacttitle+'%' AND [address] LIKE '%'+@address+'%' AND city LIKE '%'+@city+'%' AND region LIKE '%'+@region+'%' AND postalcode LIKE '%'+@postalcode+'%' AND country LIKE '%'+@country+'%' AND phone LIKE '%'+@phone+'%' AND fax LIKE '%'+@fax+'%'  )
End
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
INSERT INTO   Production.Suppliers (companyname,contactname,contacttitle,[address],city,region,postalcode,country,phone,fax)
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
UPDATE Production.Suppliers       SET companyname=@companyname ,contactname=@contactname ,contacttitle=@contacttitle ,[address]=@address ,city=@city ,region=@region ,postalcode=@postalcode ,country=@country ,phone=@phone ,fax=@fax
WHERE supplierid = @id;
End
GO
---------------------------
--DROP PROCEDURE [DeleteSuplier]
CREATE PROCEDURE [DeleteSuplier]
@id int
AS
BEGIN
	IF @id NOT IN (SELECT supplierid FROM Production.Products )
	BEGIN
	DELETE FROM Production.Suppliers WHERE  supplierid=@id
	END 
	ELSE RAISERROR ('ko biet xai raiserror', 16, 1);
END
GO
---------------------------
CREATE PROCEDURE [SearchShippers]
@companyname nvarchar (40),
@phone nvarchar (24)
 
AS
BEGIN
	SELECT * FROM  Sales.Shippers    WHERE ( companyname LIKE '%'+@companyname+'%' AND phone LIKE '%'+@phone+'%'  )
END
GO
------------------------------
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
--DROP PROCEDURE [DeleteShipper]
CREATE PROCEDURE [DeleteShipper]
@id int
AS
BEGIN
	IF @id NOT IN (SELECT shipperid FROM Sales.Orders )
	BEGIN
	DELETE FROM Sales.Shippers WHERE  shipperid=@id
	END 
	ELSE RAISERROR ('ko biet xai raiserror', 16, 1);
END
GO
--------------------------
--DROP PROCEDURE [SearchProduct]
CREATE PROCEDURE [SearchProduct]
@productname nvarchar (40),
@supplierid int,
@categoryid int,
@unitprice money,
@discontinued bit
AS
BEGIN
	SELECT * FROM Production.Products WHERE ( productname LIKE '%'+@productname+'%' AND (supplierid=@supplierid OR @supplierid IS null) AND (categoryid=@categoryid OR @categoryid IS null )AND (unitprice= @unitprice OR @unitprice IS null) AND (discontinued=@discontinued OR @discontinued IS NULL) )
END
----execute SearchProduct @productname ='',@supplierid=null, @categoryid=null , @unitprice= null, @discontinued= true
--------------------------
--DROP PROCEDURE  [InsertProduct]
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
	ELSE RAISERROR ('cant insert product' ,16,1)
End
GO
-------------
--DROP PROCEDURE  [UpdateProduct]
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
	ELSE RAISERROR ('ko nhap dc' ,16,1 )
End
GO
EXECUTE UpdateProduct @id = 1 , @productname = 'asus' , @supplierid = 1,@categoryid =1 , @unitprice = 100.0 , @discontinued= true;
------------
DROP PROCEDURE [DeleteProduct]
CREATE PROCEDURE [DeleteProduct]
@id int
AS
BEGIN
	IF @id NOT IN (SELECT productid FROM Sales.OrderDetails )
	BEGIN
	DELETE FROM Production.Products WHERE  productid=@id
	END
	ELSE RAISERROR ('ko biet xai raiserror', 16, 1);
END
GO
--------------
CREATE PROCEDURE [SearchOrder]
@custid int,
@empid int,
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
SELECT * FROM  Sales.Orders    WHERE ( (custid=@custid OR @custid is null ) AND (empid =@empid OR @empid is null)  AND (shipperid =@shipperid OR @shipperid is null )AND ( @freight is null OR freight =@freight) AND shipname LIKE '%'+@shipname+'%' AND shipaddress LIKE '%'+@shipaddress+'%' AND shipcity LIKE '%'+@shipcity+'%' AND shipregion LIKE '%'+@shipregion+'%' AND shippostalcode LIKE '%'+@shippostalcode+'%' AND shipcountry LIKE '%'+@shipcountry+'%'  )
End
GO
----------------
--DROP	PROCEDURE [InsertOrder]
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
	ELSE RAISERROR ('ko nhap dc' ,16,1)
End

GO
----------------
--DROP PROCEDURE [UpdateOrder]
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
	ELSE RAISERROR ('ko update dc' ,16,1)
End
GO
---------------------
--DROP PROCEDURE [DeleteOrder]
CREATE PROCEDURE [DeleteOrder]
@id int
AS
BEGIN
	DELETE FROM  Sales.Orders  WHERE  orderid=@id
	DELETE FROM Sales.OrderDetails WHERE orderid =@id
END
GO
---------------------
CREATE PROCEDURE [SearchOrderDetail]
@OrderID int 
AS
BEGIN 
	SELECT * FROM Sales.OrderDetails WHERE orderid = @OrderID;
END
--------------------
--DROP PROCEDURE [InsertOrderDetail]
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
	ELSE RAISERROR ('ko insert dc' ,16,1)
End
GO
--------------------------------------------
--DROP PROCEDURE [UpdateOrderDetail]
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
	ELSE RAISERROR  ('ko update dc' , 16,1)
End
GO
-------------
