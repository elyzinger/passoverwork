select x.x_value, operation.operation, y.y_value from x cross  join operation join y on x.id = y.id
