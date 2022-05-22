CREATE TABLE [securities].[Module] (
    [IdClient]   INT            NOT NULL,
    [Id]         INT            NOT NULL,
    [ModuleName] NVARCHAR (100) NULL,
    [IconName]   NVARCHAR (50)  NULL,
    [IsActive]   BIT            CONSTRAINT [DF_Module_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction] NVARCHAR (3)   NOT NULL,
    [MakeBy]     NVARCHAR (50)  NOT NULL,
    [MakeDate]   DATETIME2 (7)  CONSTRAINT [DF_Module_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]   NVARCHAR (50)  NULL,
    [UpdateDate] DATETIME2 (7)  NULL,
    CONSTRAINT [PK_Module] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);

