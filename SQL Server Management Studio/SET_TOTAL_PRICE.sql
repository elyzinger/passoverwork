CREATE PROCEDURE SET_TOTAL_PRICE
AS 
update orders set totalprice = (select totalprice = amount * p.price from products as p where orders.productid = p.id)