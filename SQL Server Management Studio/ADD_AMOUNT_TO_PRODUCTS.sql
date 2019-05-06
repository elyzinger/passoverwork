CREATE PROCEDURE ADD_AMOUNT_TO_PRODUCTS
@PRODUCT_NAME varchar(50),
@AMOUNT varchar(50)

AS
BEGIN

UPDATE products set quantity= quantity + @AMOUNT where products.productname=@PRODUCT_NAME 

END