CREATE VIEW [RegChacha].[V_User]
	AS SELECT 
	[Id] ,
    [Email] ,
    [LastName],
    [FirstName],
    [BirthDate] ,
    [Address] ,
    [Cp] ,
    [Land],
    [Phone]
	FROM [Users]
