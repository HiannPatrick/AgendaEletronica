CREATE TABLE [dbo].[EmailAttachment]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FileName] NVARCHAR(MAX) NOT NULL, 
    [File] VARBINARY(MAX) NULL, 
    [EmailId] INT NOT NULL, 
    CONSTRAINT [FK_EmailAttachment_ToEmail] FOREIGN KEY ([EmailId]) REFERENCES [Email]([Id])
)
