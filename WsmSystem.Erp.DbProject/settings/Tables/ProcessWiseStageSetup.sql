CREATE TABLE [settings].[ProcessWiseStageSetup] (
    [IdClient]              INT            NOT NULL,
    [Id]                    INT            NOT NULL,
    [StageName]             NVARCHAR (100) NOT NULL,
    [IsActive]              BIT            NOT NULL,
    [IdAuthorizationStatus] VARCHAR (1)    NOT NULL,
    [LastAction]            VARCHAR (3)    NOT NULL,
    [MakeBy]                VARCHAR (50)   NOT NULL,
    [MakeDate]              DATETIME2 (7)  NOT NULL,
    [UpdateBy]              VARCHAR (50)   NULL,
    [UpdateDate]            DATETIME2 (7)  NULL
);

