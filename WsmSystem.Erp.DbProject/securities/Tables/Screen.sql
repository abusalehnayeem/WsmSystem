CREATE TABLE [securities].[Screen] (
    [IdClient]              INT            NOT NULL,
    [ScreenCode]            INT            NOT NULL,
    [ScreenName]            NVARCHAR (100) NOT NULL,
    [IdModule]              INT            NOT NULL,
    [IdSubModule]           INT            NOT NULL,
    [IdSubModuleSection]    INT            NOT NULL,
    [Ordinal]               SMALLINT       NULL,
    [ScreenUri]             NVARCHAR (MAX) NOT NULL,
    [ScreenDescription]     NVARCHAR (MAX) NULL,
    [IsRequiredForApproval] BIT            CONSTRAINT [DF_Screen_IsRequiredForApproval] DEFAULT ((0)) NOT NULL,
    [IsFinancialScreen]     BIT            CONSTRAINT [DF_Screen_IsFinancialScreen] DEFAULT ((0)) NOT NULL,
    [IconName]              NVARCHAR (50)  NULL,
    [IsActive]              BIT            CONSTRAINT [DF_Screen_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction]            NVARCHAR (50)  NOT NULL,
    [MakeBy]                NVARCHAR (50)  NOT NULL,
    [MakeDate]              DATETIME2 (7)  CONSTRAINT [DF_Screen_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]              NVARCHAR (50)  NULL,
    [UpdateDate]            DATETIME2 (7)  NULL,
    CONSTRAINT [PK_Screen] PRIMARY KEY CLUSTERED ([IdClient] ASC, [ScreenCode] ASC),
    CONSTRAINT [FK_Screen_SubModuleSection] FOREIGN KEY ([IdClient], [IdSubModuleSection], [IdModule], [IdSubModule]) REFERENCES [securities].[SubModuleSection] ([IdClient], [Id], [IdModule], [IdSubModule])
);

