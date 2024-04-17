CREATE TABLE [dbo].[Email]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY,
    [UserId] INT NOT NULL, 
    [UserEmail] NVARCHAR(50) NOT NULL, 
    [Draft] TINYINT NOT NULL DEFAULT 1, 
    [Subject] NVARCHAR(50) NOT NULL, 
    [Body] NVARCHAR(MAX) NULL,
    CONSTRAINT [FK_Email_ToUser] FOREIGN KEY ([UserId]) REFERENCES [User]([Id])
)
