CREATE PROCEDURE [dbo].[SP_User_SetAsAdministrator]
	@userID UNIQUEIDENTIFIER
AS
BEGIN
	INSERT
		INTO [Administator]
		Values (@userID)

END