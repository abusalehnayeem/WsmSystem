CREATE TABLE [settings].[ProcessWiseStageMapping] (
    [IdClient]              INT           NOT NULL,
    [Id]                    INT           NOT NULL,
    [IdProcess]             INT           NOT NULL,
    [IdStage]               INT           NOT NULL,
    [IsActive]              BIT           NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)  NOT NULL,
    [LastAction]            NVARCHAR (3)  NOT NULL,
    [MakeBy]                NVARCHAR (50) NOT NULL,
    [MakeDate]              DATETIME2 (7) NOT NULL,
    [UpdateBy]              VARCHAR (50)  NULL,
    [UpdateDate]            DATETIME2 (7) NULL
);

