CREATE PROCEDURE [RegChacha].[Series_Update]
	@Id int,
	@nom nvarchar(75)
AS
	UPDATE [Series]
	set Nom = @nom
	where id = @Id
RETURN 0
