CREATE PROCEDURE MY_SHOPING_HISTORY
@custmoer_name varchar(50)

AS
BEGIN

select c.firstname, p.productname, o.amount, o.totalprice from customers as c cross join products as p join orders as o on c.id = o.customerid where c.username = @custmoer_name

END