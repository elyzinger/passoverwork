CREATE PROCEDURE BUY_PRODUCT
@PRODUCT_NAME varchar(50),
@QUANTITY INT,
@USER_NAME varchar(50)
AS
BEGIN
INSERT INTO orders  (customerid, productid, amount) values ((select c.id from customers as c where c.username = @USER_NAME), 
(select p.id FROM products as p where p.productname = @PRODUCT_NAME), @QUANTITY)

END