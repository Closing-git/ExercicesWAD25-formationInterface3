CREATE PROCEDURE [dbo].[SP_Book_Insert]
	@title NVARCHAR(255),
	@releaseDate DATE,
	@author NVARCHAR(128),
	@isbn CHAR(13)
AS
BEGIN

	SET NOCOUNT ON

	INSERT 
		INTO [Book] (
			[Title],
			[Author],
			[ReleaseDate],
			[ISBN])
		OUTPUT [inserted].[BookId]
		VALUES (
			@title, 
			@author,
			@releaseDate, 
			@isbn)

END
