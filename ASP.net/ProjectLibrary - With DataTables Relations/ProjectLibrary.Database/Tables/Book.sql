CREATE TABLE [dbo].[Book]
(
	[BookId] UNIQUEIDENTIFIER NOT NULL CONSTRAINT PK_Book PRIMARY KEY DEFAULT NEWID(),
	[Title] NVARCHAR(255) NOT NULL,
	[Author] NVARCHAR(128), 
	[ISBN] CHAR(13) CONSTRAINT UK_Book_ISBN UNIQUE,
	[ReleaseDate] DATE NOT NULL,
	[RegisteredDate] DATETIME2 NOT NULL DEFAULT GETDATE(),
	[DisabledDate] DATETIME2
)
GO

CREATE TRIGGER [dbo].[TR_Book_Delete]
    ON [dbo].[Book]
    INSTEAD OF DELETE
    AS
    BEGIN
        SET NoCount ON
		DECLARE @bookId UNIQUEIDENTIFIER
		SELECT @bookId = [BookId]
			FROM [deleted]

		UPDATE [Book]
			SET [DisabledDate] = GETDATE()
			WHERE [BookId] = @bookId
    END