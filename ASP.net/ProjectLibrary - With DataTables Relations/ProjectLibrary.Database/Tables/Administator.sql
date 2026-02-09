CREATE TABLE [dbo].[Administator]
(
	[UserId] UNIQUEIDENTIFIER CONSTRAINT PK_Administrator PRIMARY KEY,
	CONSTRAINT FK_Administrator_User FOREIGN KEY ([UserId]) REFERENCES [User] ([UserId])

)
