CREATE TABLE [core].[ApplicableEvent] (
    [IdClient]              INT           NOT NULL,
    [Id]                    INT           NOT NULL,
    [ApplicableEventName]   NVARCHAR (50) NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)  NOT NULL,
    [MakeBy]                NVARCHAR (50) NOT NULL,
    [MakeDate]              DATETIME2 (7) NOT NULL,
    [LastAction]            NVARCHAR (3)  NOT NULL
);

