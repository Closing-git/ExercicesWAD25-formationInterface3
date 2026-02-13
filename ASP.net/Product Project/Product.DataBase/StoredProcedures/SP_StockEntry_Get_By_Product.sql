CREATE PROCEDURE [dbo].[SP_StockEntry_Get_By_Product]
	@productId INT
AS
BEGIN

	SELECT [StockEntry].[StockEntryId],
			[StockEntry].EntryDate,
			[StockEntry].StockOperation

		FROM [StockEntry]
	
	WHERE [ProductId] = @productId
		

END