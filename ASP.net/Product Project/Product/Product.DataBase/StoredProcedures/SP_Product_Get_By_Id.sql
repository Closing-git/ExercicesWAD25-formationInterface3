CREATE PROCEDURE [dbo].[SP_Product_Get_By_Id]
	@productId INT
AS
BEGIN 
	SELECT 
		[ProductId],
		[Name],
		[Description],
		[CurrentPrice]
	FROM [Product]
	WHERE [ProductId] = @productId

END