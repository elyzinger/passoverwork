CREATE PROCEDURE CREATE_NEW_CUSTOMER
@USERNAME varchar(50),
@PASS varchar(50),
@FIRST_NAME varchar(50),
@LAST_NAME varchar(50),
@CC varchar(50)
AS
BEGIN
INSERT INTO customers(username, pass, firstname, lastname,cc) values (@USERNAME, @PASS, @FIRST_NAME, @LAST_NAME, @CC)
 
END