USE [PosX2019]
GO
/****** Object:  StoredProcedure [dbo].[spProduct_Insert]    Script Date: 9/14/2019 4:32:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[spProduct_Insert]
	@PlaceNumber int,
	@PlaceName nvarchar(50),
	@PrizeAmount money,
	@PrizePercentage float,
	@id int=0 output
AS
BEGIN
	SET NOCOUNT ON;
	insert into dbo.Prizes(PlaceNumber,PlaceName,PrizeAmount,PrizePercentage)
	values (@PlaceNumber,@PlaceName,@PrizeAmount,@PrizePercentage);
select @id=SCOPE_IDENTITY();
END
