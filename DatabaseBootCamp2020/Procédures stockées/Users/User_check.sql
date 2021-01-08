CREATE PROCEDURE [dbo].[User_check]
	@Email nvarchar(230),
	@passwd nvarchar(20)
AS
	SELECT [Email],[LastName],[FirstName],[BirthDate],[Address],[Cp],[Land],[Phone] from Users where [Email]=@Email and [Passwd]=@passwd
RETURN 0
