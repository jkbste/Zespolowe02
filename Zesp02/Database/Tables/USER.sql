﻿CREATE TABLE [dbo].[USER]
(
	[ID] BIGINT NOT NULL IDENTITY (1, 1), 
    [LOGIN] NVARCHAR(30) NOT NULL UNIQUE,
	[PASSWORD] NVARCHAR(30) NOT NULL, 
    [ADDRESS] NVARCHAR(100) NULL, 
    [LEVEL] INT NULL DEFAULT 1, 
    [EXPERIENCE] BIGINT NULL DEFAULT 0, 
    [THUMBNAIL] IMAGE NULL, 
    [RATING] FLOAT NULL, 
    [RATINGS] INT NULL DEFAULT 0, 
    CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED ([ID] ASC)
)
