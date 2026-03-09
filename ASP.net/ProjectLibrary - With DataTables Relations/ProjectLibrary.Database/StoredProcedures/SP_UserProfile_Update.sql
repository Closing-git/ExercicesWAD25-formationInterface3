CREATE PROCEDURE [dbo].[SP_UserProfile_Update]
	@userprofileid UNIQUEIDENTIFIER,
	@biography NVARCHAR(512),
	@readingSkill TINYINT,
	@newsletterSubscribed BIT
AS
BEGIN
	SET NOCOUNT ON
	UPDATE [UserProfile]
		SET	[Biography] = @biography,
			[ReadingSkill] = @readingSkill,
			[NewsLetterSubscribed] = @newsletterSubscribed
		WHERE [UserProfileId] = @userprofileid
END
