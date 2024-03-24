CREATE TABLE [dbo].[CustomerGroup]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(50) NOT NULL, 
    [CustomerRegionId] INT NOT NULL, 
    [Active] TINYINT NOT NULL DEFAULT 1,
    CONSTRAINT [FK_CustomerGroup_ToCustomerRegion] FOREIGN KEY ([CustomerRegionId]) REFERENCES [CustomerRegion]([Id])
)
