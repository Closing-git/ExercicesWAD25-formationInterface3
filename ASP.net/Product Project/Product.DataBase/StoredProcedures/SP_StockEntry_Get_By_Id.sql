CREATE PROCEDURE [dbo].[SP_StockEntry_Get_By_Id]
	@stockEntryId INT
AS
BEGIN
	SELECT [StockEntryId], [EntryDate], [StockOperation], [ProductId]
		FROM [StockEntry]
		WHERE [StockEntryId] = @stockEntryId
END