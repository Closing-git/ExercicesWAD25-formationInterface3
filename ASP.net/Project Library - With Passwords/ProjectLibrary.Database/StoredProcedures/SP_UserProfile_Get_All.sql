CREATE PROCEDURE [dbo].[SP_UserProfile_Get_All]
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
	END