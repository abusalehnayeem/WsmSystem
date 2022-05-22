CREATE TABLE [securities].[SubModuleSection] (
    [IdClient]    INT           NOT NULL,
    [Id]          INT           NOT NULL,
    [IdModule]    INT           NOT NULL,
    [IdSubModule] INT           NOT NULL,
    [SectionName] NVARCHAR (50) NULL,
    [IconName]    NVARCHAR (50) NULL,
    [IsActive]    BIT           NOT NULL,
    [LastAction]  NVARCHAR (50) NOT NULL,
    [MakeBy]      NVARCHAR (50) NOT NULL,
    [MakeDate]    DATETIME2 (7) NOT NULL,
    [UpdateBy]    NVARCHAR (50) NULL,
    [UpdateDate]  DATETIME2 (7) NULL,
    CONSTRAINT [PK_SubModuleSection] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC, [IdModule] ASC, [IdSubModule] ASC),
    CONSTRAINT [FK_SubModuleSection_SubModule] FOREIGN KEY ([IdClient], [IdSubModule], [IdModule]) REFERENCES [securities].[SubModule] ([IdClient], [Id], [IdModule])
);

