﻿CREATE TABLE [dbo].[TRAIT]
(
	[ID] BIGINT NOT NULL IDENTITY (1, 1), 
    [TITLE] NVARCHAR(50) NOT NULL, 
    [DESCRIPTION] NVARCHAR(MAX) NULL,
	CONSTRAINT [PK_TRAIT] PRIMARY KEY CLUSTERED ([ID] ASC)
)
