CREATE TABLE [dbo].[Novels]
(
	[Id] INT NOT NULL IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [SerieId] INT NOT NULL, 
    [Authors] NVARCHAR(50) NOT NULL, 
    [SerialNumber] NVARCHAR(50) NULL, 
    [Price] FLOAT NOT NULL, 
    [Informations] NVARCHAR(1000) NOT NULL, 
    [Langue] NVARCHAR(50) NOT NULL, 
    [Dimension] NVARCHAR(20) NOT NULL, 
    [Published] DATETIME2 NOT NULL, 
    [Type] INT NOT NULL, 
    CONSTRAINT [PK_Novels] PRIMARY KEY ([Id]), 
    CONSTRAINT [CK_Novels_Price] CHECK (Price > 0), 
    CONSTRAINT [FK_Novels_Type] FOREIGN KEY ([Type]) REFERENCES [Types]([Id]), 
    CONSTRAINT [FK_Novels_Serie] FOREIGN KEY ([SerieId]) REFERENCES [Series]([id]) 
)
