select x.xvalue, operation.operation, y.yvalue from x cross join operation join y on x.id=y.id