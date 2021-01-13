CREATE VIEW [dbo].[V_User]
	AS SELECT 
	[Email],
	[LastName],
	[FirstName],
	[BirthDate],
	[Address],
	[Cp],
	[Land],
	[Phone]
	
	FROM [Users]
