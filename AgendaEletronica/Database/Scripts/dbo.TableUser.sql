CREATE TABLE [dbo].[User]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Name] NCHAR(50) NOT NULL, 
    [Email] NCHAR(50) NOT NULL, 
    [EmailPassword] NVARCHAR(50) NOT NULL, 
    [User] NVARCHAR(50) NOT NULL, 
    [Password] NVARCHAR(50) NOT NULL, 
    [Email_Smtp] NCHAR(50) NULL, 
    [Email_Port] NCHAR(4) NULL, 
    [CompanyId] INT NOT NULL, 
    CONSTRAINT [FK_User_ToCompany] FOREIGN KEY ([CompanyId]) REFERENCES [Company]([Id])
)
