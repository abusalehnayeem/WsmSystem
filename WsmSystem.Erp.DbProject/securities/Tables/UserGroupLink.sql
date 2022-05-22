CREATE TABLE [securities].[UserGroupLink] (
    [IdClient]    INT           NOT NULL,
    [Id]          INT           NOT NULL,
    [IdUser]      INT           NOT NULL,
    [IdUserGroup] INT           NOT NULL,
    [IsActive]    BIT           CONSTRAINT [DF_UserGroupLink_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction]  NVARCHAR (3)  NOT NULL,
    [MakeBy]      NVARCHAR (50) NOT NULL,
    [MakeDate]    DATETIME2 (7) CONSTRAINT [DF_UserGroupLink_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]    NVARCHAR (50) NULL,
    [UpdateDate]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_UserGroupLink] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC),
    CONSTRAINT [FK_UserGroupLink_UserGroup] FOREIGN KEY ([IdClient], [IdUserGroup]) REFERENCES [securities].[UserGroup] ([IdClient], [Id]),
    CONSTRAINT [FK_UserGroupLink_UserInfo] FOREIGN KEY ([IdClient], [IdUser]) REFERENCES [securities].[UserInfo] ([IdClient], [Id])
);

