CREATE TABLE [securities].[RoleWiseScreenPermission] (
    [IdRole]      INT           NOT NULL,
    [IdClient]    INT           NOT NULL,
    [ScreenCode]  INT           NOT NULL,
    [AccessRight] NVARCHAR (4)  NULL,
    [IsActive]    BIT           CONSTRAINT [DF_RoleWiseScreenPermission_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction]  NVARCHAR (3)  NOT NULL,
    [MakeBy]      NVARCHAR (50) NOT NULL,
    [MakeDate]    DATETIME2 (7) CONSTRAINT [DF_RoleWiseScreenPermission_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]    NVARCHAR (50) NULL,
    [UpdateDate]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_RoleWiseScreenPermission] PRIMARY KEY CLUSTERED ([IdRole] ASC, [IdClient] ASC, [ScreenCode] ASC),
    CONSTRAINT [FK_RoleWiseScreenPermission_Screen] FOREIGN KEY ([IdClient], [ScreenCode]) REFERENCES [securities].[Screen] ([IdClient], [ScreenCode]),
    CONSTRAINT [FK_RoleWiseScreenPermission_UserRole] FOREIGN KEY ([IdClient], [IdRole]) REFERENCES [securities].[UserRole] ([IdClient], [Id])
);

