CREATE TABLE [settings].[PhraseTagTranslation] (
    [IdClient]    INT            NOT NULL,
    [Id]          INT            NOT NULL,
    [IdPhraseTag] INT            NOT NULL,
    [IdLanguage]  INT            NOT NULL,
    [Expression]  NVARCHAR (250) NULL,
    [IsActive]    BIT            NOT NULL,
    [LastAction]  NVARCHAR (50)  NOT NULL,
    [MakeBy]      NVARCHAR (50)  NOT NULL,
    [MakeDate]    DATETIME2 (7)  NOT NULL,
    [UpdateBy]    NVARCHAR (50)  NULL,
    [UpdateDate]  DATETIME2 (7)  NULL
);

