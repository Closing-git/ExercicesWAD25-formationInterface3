CREATE TABLE [dbo].[Product]
(
	[ProductId] INT NOT NULL IDENTITY,
	[Name] NVARCHAR(64) NOT NULL,
	[Description] NVARCHAR(512),
	[CurrentPrice] MONEY NOT NULL,
	CONSTRAINT PK_Product PRIMARY KEY ([ProductId])
)
