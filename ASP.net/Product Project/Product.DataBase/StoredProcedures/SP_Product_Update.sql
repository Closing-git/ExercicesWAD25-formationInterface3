CREATE PROCEDURE [dbo].[SP_Product_Update]

	@productId INT,
	@name NVARCHAR(64),
	@description NVARCHAR(512),
	@currentPrice MONEY
AS
BEGIN
	
	SET NOCOUNT ON

	UPDATE [Product]
		SET [Name] = @name,
			[Description] = @description,
			[CurrentPrice] = @currentPrice
		WHERE [ProductId] = @productId

END
