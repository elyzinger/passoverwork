
CREATE PROCEDURE SHOW_SUPPLIER_PRODUCTS

@SUPPLIER_ID int
AS
BEGIN
SELECT * from products where products.supplierid =  @SUPPLIER_ID 

END