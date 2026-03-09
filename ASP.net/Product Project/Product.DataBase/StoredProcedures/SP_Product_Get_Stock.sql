CREATE PROCEDURE [dbo].[SP_Product_Get_Stock]
	@productId INT
AS
	BEGIN
	SELECT SUM([StockEntry].StockOperation)
	FROM [StockEntry] WHERE [StockEntry].ProductId = @productId
	

	END
