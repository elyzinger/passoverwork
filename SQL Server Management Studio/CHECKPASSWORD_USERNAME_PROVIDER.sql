CREATE PROCEDURE CHECKPASSWORD_USERNAME_SUPPLIER
@USERNAME varchar(50),
@PASS varchar(50)
AS
BEGIN
IF EXISTS (SELECT * FROM suppliers AS s WHERE username = @USERNAME AND pass = @PASS)
SELECT 1
ELSE
SELECT 0
END