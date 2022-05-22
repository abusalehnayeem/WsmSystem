CREATE TABLE [settings].[EmailTemplate] (
    [IdClient]         INT            NOT NULL,
    [Id]               INT            NOT NULL,
    [TemplateName]     NVARCHAR (60)  NOT NULL,
    [Subject]          NVARCHAR (500) NULL,
    [TemplateFor]      INT            NOT NULL,
    [TemplateBody]     VARCHAR (MAX)  NULL,
    [IsUseKeyword]     BIT            NOT NULL,
    [IsSystemRequired] BIT            NOT NULL,
    [IsActive]         BIT            NOT NULL,
    [LastAction]       NVARCHAR (50)  NOT NULL,
    [MakeBy]           NVARCHAR (50)  NOT NULL,
    [MakeDate]         DATETIME2 (7)  NOT NULL,
    [UpdateBy]         NVARCHAR (50)  NULL,
    [UpdateDate]       DATETIME2 (7)  NULL
);

