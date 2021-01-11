CREATE PROCEDURE [RegChacha].[Novels_GetOne]
	@Id int 
AS
	SELECT * from [Novels] where Id = @Id
RETURN 0
