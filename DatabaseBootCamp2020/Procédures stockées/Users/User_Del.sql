CREATE PROCEDURE [RegChacha].[User_Del]
	@Id int
AS
	Delete [Users] where Id=@Id;
RETURN 0
