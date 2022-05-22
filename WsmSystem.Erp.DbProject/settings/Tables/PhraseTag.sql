CREATE TABLE [settings].[PhraseTag] (
    [IdClient]   INT            NOT NULL,
    [Id]         INT            NOT NULL,
    [PhraseName] NVARCHAR (30)  NOT NULL,
    [UsageIn]    NVARCHAR (500) NULL,
    [IsActive]   BIT            NOT NULL,
    [LastAction] NVARCHAR (50)  NOT NULL,
    [MakeBy]     NVARCHAR (50)  NOT NULL,
    [MakeDate]   DATETIME2 (7)  NOT NULL,
    [UpdateBy]   NVARCHAR (50)  NULL,
    [UpdateDate] DATETIME2 (7)  NULL
);

