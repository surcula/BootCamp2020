CREATE PROCEDURE [dbo].[User_Del]
	@Id int
AS
	Delete [Users] where Id=@Id;
RETURN 0
