CREATE TABLE [securities].[SubModule] (
    [IdClient]      INT            NOT NULL,
    [Id]            INT            NOT NULL,
    [IdModule]      INT            NOT NULL,
    [SubModuleName] NVARCHAR (100) NOT NULL,
    [IconName]      NVARCHAR (50)  NULL,
    [Ordinal]       SMALLINT       NULL,
    [IsActive]      BIT            CONSTRAINT [DF_SubModule_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction]    NVARCHAR (3)   NOT NULL,
    [MakeBy]        NVARCHAR (50)  NOT NULL,
    [MakeDate]      DATETIME2 (7)  CONSTRAINT [DF_SubModule_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]      NVARCHAR (50)  NULL,
    [UpdateDate]    DATETIME2 (7)  NULL,
    CONSTRAINT [PK_SubModule] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC, [IdModule] ASC),
    CONSTRAINT [FK_SubModule_Module] FOREIGN KEY ([IdClient], [IdModule]) REFERENCES [securities].[Module] ([IdClient], [Id])
);

