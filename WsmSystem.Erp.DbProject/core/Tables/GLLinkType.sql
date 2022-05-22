CREATE TABLE [core].[GLLinkType] (
    [Id]                    INT           NOT NULL,
    [IdClient]              INT           NOT NULL,
    [GLLinkType]            NVARCHAR (10) NOT NULL,
    [GLLinkTypeName]        NVARCHAR (50) NOT NULL,
    [IdReferenceType]       NVARCHAR (3)  NULL,
    [IdAuthorizationStatus] NVARCHAR (1)  NOT NULL,
    [MakeBy]                NVARCHAR (50) NOT NULL,
    [MakeDate]              DATETIME2 (7) NOT NULL,
    [LastAction]            NVARCHAR (3)  NOT NULL
);

