CREATE TABLE [dbo].[Contact]
(
	[Id] INT IDENTITY(1,1) PRIMARY KEY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Reference] NCHAR(35) NULL, 
    [Phone1] NCHAR(20) NULL,
    [Phone2] NCHAR(20) NULL,
    [Active] TINYINT NOT NULL DEFAULT 1, 
    [ContactGroupId] INT NOT NULL, 
    CONSTRAINT [FK_Contact_ToContactGroup] FOREIGN KEY ([ContactGroupId]) REFERENCES [ContactGroup]([Id])
)
