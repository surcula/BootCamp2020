CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL IDENTITY, 
    [Email] NVARCHAR(230) NOT NULL, 
    [Passwd] BINARY(64) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [BirthDate] DateTime2(7) NOT NULL,
    [Address] NVARCHAR(250) NOT NULL, 
    [Cp] INT NOT NULL, 
    [Land] NVARCHAR(50) NOT NULL, 
    [Phone] INT NOT NULL, 
    CONSTRAINT [PK_Users] PRIMARY KEY ([Id]) 
)
