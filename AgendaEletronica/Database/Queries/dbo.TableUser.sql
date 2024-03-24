CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Name] NCHAR(50) NOT NULL, 
    [Email] NCHAR(50) NOT NULL, 
    [User] NVARCHAR(MAX) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Email_Smtp] NCHAR(50) NULL, 
    [Email_Port] NCHAR(4) NULL, 
    [CompanyId] INT NOT NULL, 
    CONSTRAINT [FK_User_ToCompany] FOREIGN KEY ([CompanyId]) REFERENCES [Company]([Id])
)
