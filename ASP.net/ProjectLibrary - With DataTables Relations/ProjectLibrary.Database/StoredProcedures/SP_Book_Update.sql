CREATE PROCEDURE [dbo].[SP_Book_Update]
	@bookId UNIQUEIDENTIFIER,
	@title NVARCHAR(255),
	@releaseDate DATE,
	@author NVARCHAR(128),
	@isbn CHAR(13)
AS
BEGIN

	SET NOCOUNT ON

	UPDATE [Book] 
		SET [Title] = @title,
			[ReleaseDate] = @releaseDate,
			[Author] = @author,
			[ISBN] = @isbn
		WHERE [BookId] = @bookId

END
