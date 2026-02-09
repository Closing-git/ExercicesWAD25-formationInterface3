CREATE PROCEDURE [dbo].[SP_User_RemoveAdministrator]
	@userid UNIQUEIDENTIFIER
AS
BEGIN
	DELETE 
		FROM [Administator] 
		WHERE [UserID] = @userid
END