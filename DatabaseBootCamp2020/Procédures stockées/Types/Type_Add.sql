CREATE PROCEDURE [RegChacha].[Type_Add]
	(
	@type nvarchar(50)
	)
	
AS
	INSERT INTO [Types] ([type]) values(@type)
RETURN 0
