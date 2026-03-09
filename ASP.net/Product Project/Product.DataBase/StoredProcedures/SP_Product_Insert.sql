CREATE PROCEDURE [dbo].[SP_Product_Insert]

	@name NVARCHAR(64),
	@description NVARCHAR(512),
	@currentPrice MONEY

AS
BEGIN

	SET NOCOUNT ON

	INSERT
		INTO [Product] (
			[Name],
			[Description],
			[CurrentPrice])

		OUTPUT [inserted].[ProductId]

		VALUES (
			@name,
			@description,
			@currentPrice)

END
