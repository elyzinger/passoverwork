USE [Passover]
GO
/****** Object:  StoredProcedure [dbo].[MY_SHOPING_HISTORY]    Script Date: 03/05/2019 23:09:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[MY_SHOPING_HISTORY]
@custmoer_name varchar(50)

AS
BEGIN

select c.firstname,p.productname, o.amount, o.totalprice from customers c inner join products p on c.username = @custmoer_name  inner join orders o on o.customerid = c.id


END