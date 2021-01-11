CREATE PROCEDURE [RegChacha].[Novels_Del]
	@Id int
AS
	DELETE from [Novels] where Id = @Id
RETURN 0
