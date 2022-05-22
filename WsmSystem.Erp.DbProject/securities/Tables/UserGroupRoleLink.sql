CREATE TABLE [securities].[UserGroupRoleLink] (
    [IdClient]    INT           NOT NULL,
    [Id]          INT           NOT NULL,
    [IdUserGroup] INT           NOT NULL,
    [IdUserRole]  INT           NOT NULL,
    [IsActive]    BIT           CONSTRAINT [DF_UserGroupRoleLink_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction]  NVARCHAR (3)  NOT NULL,
    [MakeBy]      NVARCHAR (50) NOT NULL,
    [MakeDate]    DATETIME2 (7) CONSTRAINT [DF_UserGroupRoleLink_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]    VARCHAR (50)  NULL,
    [UpdateDate]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_UserGroupWiseRoleMapping] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC),
    CONSTRAINT [FK_UserGroupRoleLink_UserGroup] FOREIGN KEY ([IdClient], [IdUserGroup]) REFERENCES [securities].[UserGroup] ([IdClient], [Id]),
    CONSTRAINT [FK_UserGroupRoleLink_UserRole] FOREIGN KEY ([IdClient], [IdUserRole]) REFERENCES [securities].[UserRole] ([IdClient], [Id])
);

