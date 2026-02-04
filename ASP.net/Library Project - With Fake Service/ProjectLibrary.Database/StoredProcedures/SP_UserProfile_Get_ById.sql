CREATE PROCEDURE [dbo].[SP_UserProfile_Get_ById]
	@UserProfileId UNIQUEIDENTIFIER
AS
	BEGIN
		SELECT	[UserProfileId],
				[LastName],
				[FirstName],
				[BirthDate],
				[Biography],
				[ReadingSkill],
				[NewsLetterSubscribed],
				[RegisteredDate],
				[DisabledDate]
			FROM [UserProfile]
			WHERE [UserProfileId] = @UserProfileId
	END