CREATE PROCEDURE [RegChacha].[Type_update]
	@Id int,
	@type nvarchar(50)
AS
	UPDATE [Types]
	set [type]=@type
	where id = @Id
RETURN 0
