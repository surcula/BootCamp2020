﻿CREATE TABLE [dbo].[Novels]
(
	[Id] INT NOT NULL IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Series] NVARCHAR(50) NOT NULL, 
    [Author] NVARCHAR(50) NOT NULL, 
    [SerialNumber] NVARCHAR(50) NULL, 
    [Price] INT NOT NULL, 
    [Informations] NVARCHAR(1000) NOT NULL, 
    [Langue] NVARCHAR(50) NOT NULL, 
    [Dimension] NVARCHAR(20) NOT NULL, 
    [Published] DATETIME2 NOT NULL, 
    CONSTRAINT [PK_Novels] PRIMARY KEY ([Id]), 
    CONSTRAINT [CK_Novels_Price] CHECK (Price > 0) 
)
