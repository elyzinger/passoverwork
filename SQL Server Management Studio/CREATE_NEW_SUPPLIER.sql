
CREATE PROCEDURE CREATE_NEW_SUPPLIER
@USERNAME varchar(50),
@PASS varchar(50),
@COMPANY_NAME varchar(50)

AS
BEGIN
INSERT INTO suppliers(username, pass,companyname ) values (@USERNAME, @PASS, @COMPANY_NAME)
 
END