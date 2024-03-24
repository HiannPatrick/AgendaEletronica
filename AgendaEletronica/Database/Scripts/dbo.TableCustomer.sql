CREATE TABLE [dbo].[Customer]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Reference] NCHAR(35) NULL, 
    [Phone1] NCHAR(20) NULL,
    [Phone2] NCHAR(20) NULL,
    [Active] TINYINT NOT NULL DEFAULT 1, 
    [CustomerGroupId] INT NOT NULL, 
    CONSTRAINT [FK_Customer_ToCustomerGroup] FOREIGN KEY ([CustomerGroupId]) REFERENCES [CustomerGroup]([Id])
)
