﻿CREATE TABLE [dbo].[SentMail]
(
	[EmailId] INT NOT NULL, 
    [CustomerId] INT NOT NULL, 
    [WasSended] TINYINT NOT NULL DEFAULT 0, 
    [SentDate] DATETIME NOT NULL, 
    [HasError] TINYINT NOT NULL DEFAULT 0, 
    [ErrorMessage] NVARCHAR(MAX) NOT NULL, 
    [CustomerEmail] NVARCHAR(MAX) NOT NULL, 
    PRIMARY KEY (EmailId, CustomerId),
    CONSTRAINT [FK_SentMail_ToEmail] FOREIGN KEY ([EmailId]) REFERENCES [Email]([Id]), 
    CONSTRAINT [FK_SentMail_ToCustomer] FOREIGN KEY ([CustomerId]) REFERENCES [Customer]([Id]), 
)