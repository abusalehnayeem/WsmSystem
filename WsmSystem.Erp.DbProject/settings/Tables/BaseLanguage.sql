CREATE TABLE [settings].[BaseLanguage] (
    [IdClient]          INT           NOT NULL,
    [Id]                INT           NOT NULL,
    [DescriptionDetail] NVARCHAR (30) NULL,
    [DescriptionShort]  NVARCHAR (5)  NULL,
    [IsActive]          BIT           NOT NULL,
    [LastAction]        NVARCHAR (50) NOT NULL,
    [MakeBy]            NVARCHAR (50) NOT NULL,
    [MakeDate]          DATETIME2 (7) NOT NULL,
    [UpdateBy]          NVARCHAR (50) NULL,
    [UpdateDate]        DATETIME2 (7) NULL
);

