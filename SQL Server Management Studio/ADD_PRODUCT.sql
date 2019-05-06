
CREATE PROCEDURE ADD_PRODUCT
@PRODUCT_NAME varchar(50),
@SUPPLIER_ID int,
@PRICE int,
@quantity int

AS
BEGIN
INSERT INTO products(productname, supplierid, price, quantity) values (@PRODUCT_NAME, @SUPPLIER_ID, @PRICE, @quantity)
 
END