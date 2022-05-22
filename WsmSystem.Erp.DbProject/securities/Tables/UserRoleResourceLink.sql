CREATE TABLE [securities].[UserRoleResourceLink] (
    [IdClient]       INT           NOT NULL,
    [Id]             INT           NOT NULL,
    [IdUserResource] INT           NOT NULL,
    [IdUserRole]     INT           NOT NULL,
    [IsActive]       BIT           NOT NULL,
    [LastAction]     NVARCHAR (3)  NOT NULL,
    [MakeBy]         NVARCHAR (50) NOT NULL,
    [MakeDate]       DATETIME2 (7) NOT NULL,
    [UpdateBy]       NVARCHAR (50) NULL,
    [UpdateDate]     DATETIME2 (7) NULL,
    CONSTRAINT [PK_UserRoleResourceLink] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC),
    CONSTRAINT [FK_UserRoleResourceLink_UserResource] FOREIGN KEY ([IdClient], [IdUserResource]) REFERENCES [securities].[UserResource] ([IdClient], [Id]),
    CONSTRAINT [FK_UserRoleResourceLink_UserRole] FOREIGN KEY ([IdClient], [IdUserRole]) REFERENCES [securities].[UserRole] ([IdClient], [Id])
);

