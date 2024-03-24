﻿CREATE TABLE [dbo].[Email]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [UserId] INT NOT NULL, 
    [UserEmail] NVARCHAR(50) NOT NULL, 
    [Draft] TINYINT NOT NULL DEFAULT 1, 
    [Subject] NVARCHAR(50) NOT NULL, 
    [Body] NVARCHAR(MAX) NULL
)
