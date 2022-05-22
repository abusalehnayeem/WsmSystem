CREATE TABLE [securities].[UserRole] (
    [IdClient]        INT            NOT NULL,
    [Id]              INT            NOT NULL,
    [RoleName]        NVARCHAR (50)  NOT NULL,
    [RoleDescription] NVARCHAR (500) NULL,
    [IsActive]        BIT            CONSTRAINT [DF_UserRole_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction]      NVARCHAR (3)   NOT NULL,
    [MakeBy]          NVARCHAR (50)  NOT NULL,
    [MakeDate]        DATETIME2 (7)  CONSTRAINT [DF_UserRole_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]        NVARCHAR (50)  NULL,
    [UpdateDate]      DATETIME2 (7)  NULL,
    CONSTRAINT [PK_UserRole] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);

