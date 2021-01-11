Create PROCEDURE  [RegChacha].[Series_Add]
	(
	@Nom nvarchar(75)
	)
	
AS
	INSERT INTO [Series] (nom) values(@Nom)
RETURN 0
