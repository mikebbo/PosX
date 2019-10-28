
use PosX2019

GO

CREATE PROCEDURE sp_insertProduct (
 @barcode numeric, @itmNumb numeric, @name varchar(100), 
					@description varchar(100),  @buyprice money, @sellPrice money, @quant numeric)
			

AS 
BEGIN
	INSERT INTO [dbo].[tblProduct] (itmNumb, barcode, name,description, buyPrice,sellPrice) VALUES (
		@barcode, @itmNumb, @name,@description,@buyPrice,@sellPrice, @quant)
	)
END

GO