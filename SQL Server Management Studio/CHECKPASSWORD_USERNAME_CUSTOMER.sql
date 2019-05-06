CREATE PROCEDURE GET_SUPPLIERID_FROM_PRODUCTS
@PRODUCT_NAME varchar(50)

AS
BEGIN

SELECT p.supplierid from products as p where p.productname = @PRODUCT_NAME   

END