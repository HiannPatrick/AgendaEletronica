CREATE TABLE [dbo].[ContactEmail]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Email] NCHAR(10) NOT NULL, 
    [Active] TINYINT NOT NULL DEFAULT 1, 
    [ContactId] INT NOT NULL, 
    CONSTRAINT [FK_ContactEmail_ToContact] FOREIGN KEY ([ContactId]) REFERENCES [Contact]([Id])
)
