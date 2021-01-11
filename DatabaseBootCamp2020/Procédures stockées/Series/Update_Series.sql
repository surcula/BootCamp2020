CREATE PROCEDURE [RegChacha].[Update_Series]
	@Id int,
	@nom nvarchar(75)
AS
	UPDATE [Series]
	set Nom = @nom
	where id = @Id
RETURN 0
