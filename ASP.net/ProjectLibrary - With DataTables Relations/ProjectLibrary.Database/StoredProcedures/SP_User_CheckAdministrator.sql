CREATE PROCEDURE [dbo].[SP_User_CheckAdministrator]
	@userid UNIQUEIDENTIFIER
AS
BEGIN
	SELECT [UserId] 
		FROM [Administator]
		WHERE [UserID] = @userid
END
