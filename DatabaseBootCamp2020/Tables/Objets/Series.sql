CREATE TABLE [dbo].[Series]
(
	[Id] INT NOT NULL Identity, 
    [Nom] NVARCHAR(75) NOT NULL, 
    CONSTRAINT [PK_Series] PRIMARY KEY ([Id]) 
)
