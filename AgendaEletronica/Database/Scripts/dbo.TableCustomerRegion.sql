﻿CREATE TABLE [dbo].[CustomerRegion]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(50) NOT NULL,
	[Active] TINYINT NOT NULL DEFAULT 1, 
)
