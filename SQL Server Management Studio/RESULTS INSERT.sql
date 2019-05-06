INSERT INTO Results(x_value, operation, y_value)
select x.x_value, o.operation, y.y_value
from(X AS x cross join Operation as o cross join Y as y)