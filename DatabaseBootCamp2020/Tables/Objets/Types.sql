﻿CREATE TABLE [dbo].[Types]
(
	[Id] INT NOT NULL IDENTITY, 
    [type] NVARCHAR(50) NOT NULL, 
    CONSTRAINT [PK_Types] PRIMARY KEY ([Id]) 
)
