CREATE TABLE [dbo].[SentMail]
(
	[EmailId] INT NOT NULL, 
    [ContactId] INT NOT NULL, 
    [WasSended] TINYINT NOT NULL DEFAULT 0, 
    [SentDate] DATETIME NOT NULL, 
    [HasError] TINYINT NOT NULL DEFAULT 0, 
    [ErrorMessage] NVARCHAR(MAX) NOT NULL, 
    [ContactEmail] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY (EmailId, ContactId),
    CONSTRAINT [FK_SentMail_ToEmail] FOREIGN KEY ([EmailId]) REFERENCES [Email]([Id]), 
    CONSTRAINT [FK_SentMail_ToContact] FOREIGN KEY ([ContactId]) REFERENCES [Contact]([Id]), 
)
