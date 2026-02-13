BEGIN TRANSACTION

DECLARE @id INT
DECLARE @productIds TABLE([productID] INT)

INSERT INTO @productIds([productId])

EXEC SP_Product_Insert @name = 'Samsung S20', 
@description = 'Un GSM à l''ancienne, mais efficace. En bleu, noir ou rouge',
@currentPrice = 95.99


SELECT @id = [ProductId] FROM @productIds
DELETE FROM @productIds
EXEC [SP_StockEntry_Insert]
@entryDate = '2026-01-10', @stockOperation = 2, @productId = @id

EXEC [SP_StockEntry_Insert]
@entryDate = '2026-01-10', @stockOperation = -1, @productId = @id





INSERT INTO @productIds([productId])

EXEC SP_Product_Insert @name = 'Pot de fleur', 
@description = 'Un joli pot de fleur pour y mettre vos plus belles tulipes',
@currentPrice = 10.50

SELECT @id = [ProductId] FROM @productIds
DELETE FROM @productIds

EXEC [SP_StockEntry_Insert]
@entryDate = '2026-02-26', @stockOperation = 10, @productId = @id

EXEC [SP_StockEntry_Insert]
@entryDate = '2026-01-22', @stockOperation = 4, @productId = @id

EXEC [SP_StockEntry_Insert]
@entryDate = '2026-02-26', @stockOperation = -5, @productId = @id




INSERT INTO @productIds([productId])

EXEC SP_Product_Insert @name = 'Canard en plastique', 
@description = 'Un sympathique canard à qui parler de tous vos problèmes !',
@currentPrice = 5.33


SELECT @id = [ProductId] FROM @productIds
DELETE FROM @productIds

EXEC [SP_StockEntry_Insert]
@entryDate = '2025-10-26', @stockOperation = -2, @productId = @id

EXEC [SP_StockEntry_Insert]
@entryDate = '2025-10-24', @stockOperation = 2, @productId = @id


COMMIT
GO