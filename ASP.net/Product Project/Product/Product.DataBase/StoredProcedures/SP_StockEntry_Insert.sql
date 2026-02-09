CREATE PROCEDURE [dbo].[SP_StockEntry_Insert]
	@entryDate DATETIME,
	@stockOperation INT,
	@productId INT
AS
BEGIN
	SET NOCOUNT ON

	INSERT
		INTO [StockEntry] (
		[EntryDate],
		[StockOperation],
		[ProductId])

		OUTPUT [inserted].[StockEntryId]

		VALUES (
		@entryDate,
		@stockOperation,
		@productId)

END