UPDATE Results  set result = 
case operation
when '+' THEN X_VALUE + Y_VALUE 
when '-' THEN X_VALUE - Y_VALUE 
when '*' THEN X_VALUE * Y_VALUE 
when '/' THEN (X_VALUE * 1.00) / Y_VALUE
END
