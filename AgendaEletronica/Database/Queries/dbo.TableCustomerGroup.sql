CREATE TABLE [dbo].[CustomerGroup]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(50) NOT NULL, 
    [CustomerRegionId] INT NOT NULL, 
    CONSTRAINT [FK_CustomerGroup_ToCustomerRegion] FOREIGN KEY ([CustomerRegionId]) REFERENCES [CustomerRegion]([Id])
)
