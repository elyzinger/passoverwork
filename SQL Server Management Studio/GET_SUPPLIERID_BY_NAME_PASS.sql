CREATE PROCEDURE GET_SUPPLIERID_BY_NAME_PASS
@SUPPLIER_NAME varchar(50),
@PASS varchar(50)

AS
BEGIN

SELECT s.id from suppliers as s where s.username = @SUPPLIER_NAME and s.pass= @PASS

END