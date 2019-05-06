
CREATE PROCEDURE CHECK_ID_IN_PRODUCT
@PRODUCT_NAME varchar(50)

AS
BEGIN

IF EXISTS (SELECT p.supplierid from products as p where p.productname = @PRODUCT_NAME)
SELECT 1 
ELSE
SELECT 0   

END