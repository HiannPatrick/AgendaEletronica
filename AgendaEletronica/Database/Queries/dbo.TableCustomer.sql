CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Reference] NCHAR(35) NULL, 
    [Email] NVARCHAR(MAX) NULL,
    [CustomerGroupId] INT NOT NULL, 
    CONSTRAINT [FK_Customer_ToCustomerGroup] FOREIGN KEY ([CustomerGroupId]) REFERENCES [CustomerGroup]([Id])
)
