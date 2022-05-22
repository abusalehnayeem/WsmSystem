CREATE TABLE [core].[ProductGlLinkType] (
    [IdClient]              INT           NOT NULL,
    [IdProduct]             INT           NOT NULL,
    [IdGLLinkType]          INT           NOT NULL,
    [IsDisplay]             BIT           NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)  NOT NULL,
    [MakeBy]                NVARCHAR (50) NOT NULL,
    [MakeDate]              DATETIME2 (7) NOT NULL,
    [LastAction]            NVARCHAR (3)  NOT NULL,
    [LedgerType]            NVARCHAR (4)  NOT NULL
);

