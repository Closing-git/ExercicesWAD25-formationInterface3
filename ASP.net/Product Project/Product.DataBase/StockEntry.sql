CREATE TABLE [dbo].[StockEntry]
(
	[StockEntryId] INT NOT NULL IDENTITY,
	[EntryDate] DATETIME NOT NULL,
	[StockOperation] INT NOT NULL,
	[ProductId] INT NOT NULL,
	CONSTRAINT PK_StockEntry PRIMARY KEY ([StockEntryId]), 
	CONSTRAINT [FK_StockEntry_Product] FOREIGN KEY ([ProductId]) REFERENCES [Product]([ProductId])

)
