CREATE TABLE [dbo].[CustomerEmail]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Email] NCHAR(10) NOT NULL, 
    [Active] TINYINT NOT NULL DEFAULT 1, 
    [CustomerId] INT NOT NULL, 
    CONSTRAINT [FK_CustomerEmail_ToCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([Id])
)
