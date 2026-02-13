CREATE PROCEDURE [dbo].[SP_Product_Get_All]
AS
BEGIN
	SELECT 
		[ProductId],
		[Name],
		[Description],
		[CurrentPrice]
	FROM [Product]
END