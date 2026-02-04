CREATE PROCEDURE [dbo].[SP_UserProfile_Delete]
	@userprofileid UNIQUEIDENTIFIER
AS
BEGIN
	SET NOCOUNT ON
	DELETE FROM [UserProfile]
		WHERE [UserProfileId] = @userprofileid
END
