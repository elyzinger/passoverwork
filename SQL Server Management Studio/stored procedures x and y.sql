USE [Passover]
GO
/****** Object:  StoredProcedure [dbo].[INSERT_X_Y]    Script Date: 25/04/2019 01:45:43 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[INSERT_X_Y] 
@X_VALUE INT,
@Y_VALUE INT
AS
INSERT INTO x(x_value) values (@X_VALUE); 
INSERT INTO y(y_value) values (@Y_VALUE); 