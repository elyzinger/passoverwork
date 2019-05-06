USE [Passover]
GO
/****** Object:  StoredProcedure [dbo].[CHECK_STUCK]    Script Date: 01/05/2019 19:10:54 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[CHECK_STUCK]
@PRODUCT_NAME varchar(50),
@QUANTITY INT
AS
BEGIN
IF EXISTS (SELECT * FROM products WHERE productname = @PRODUCT_NAME AND quantity >= @QUANTITY)
SELECT 1
ELSE
SELECT 0
END