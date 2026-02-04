CREATE PROCEDURE [dbo].[SP_UserProfile_Get_ById]
	@id UNIQUEIDENTIFIER
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
			WHERE [UserProfileId] = @id
	END