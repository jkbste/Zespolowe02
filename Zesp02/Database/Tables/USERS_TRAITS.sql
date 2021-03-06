﻿CREATE TABLE [dbo].[USERS_TRAITS]
(
	[ID] BIGINT NOT NULL IDENTITY(1, 1), 
    [TRAIT_ID] BIGINT NOT NULL, 
    [USER_ID] BIGINT NOT NULL,
	CONSTRAINT [PK_USERS_TRAITS] PRIMARY KEY CLUSTERED ([ID] ASC),
	CONSTRAINT [FK_USERS_TRAITS_TRAIT] FOREIGN KEY ([TRAIT_ID]) REFERENCES [dbo].[TRAIT] ([ID]),
	CONSTRAINT [FK_USERS_TRAITS_USER] FOREIGN KEY ([USER_ID]) REFERENCES [dbo].[USER] ([ID])
)
