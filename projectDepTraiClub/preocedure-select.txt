CREATE PROCEDURE selectEmployee
AS
	SELECT * FROM HR.Employees;
EXEC selectEmployee;

CREATE PROCEDURE selectCategories
AS
	SELECT * FROM Production.Categories;
	GO
CREATE PROCEDURE selectProduct
AS
	SELECT * FROM Production.Products;
	GO
	CREATE PROCEDURE selectSupplier
AS
	SELECT * FROM Production.Suppliers;
	GO
		CREATE PROCEDURE selectCustomer
AS
	SELECT * FROM Sales.Customers;
	GO
CREATE PROCEDURE selectOrderDetail
AS
	SELECT * FROM Sales.Customers;
	GO
	CREATE PROCEDURE selectOrder
AS
	SELECT * FROM Sales.Orders;
	GO
	CREATE PROCEDURE selectShipper
AS
	SELECT * FROM Sales.Shippers;
	
	