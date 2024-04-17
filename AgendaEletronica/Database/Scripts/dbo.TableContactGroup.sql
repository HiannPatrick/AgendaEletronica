CREATE TABLE [dbo].[ContactGroup]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
    [Name] NCHAR(50) NOT NULL, 
    [ContactRegionId] INT NOT NULL, 
    [Active] TINYINT NOT NULL DEFAULT 1,
    CONSTRAINT [FK_ContactGroup_ToContactRegion] FOREIGN KEY ([ContactRegionId]) REFERENCES [ContactRegion]([Id])
)
