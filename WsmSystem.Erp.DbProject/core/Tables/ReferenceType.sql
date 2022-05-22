CREATE TABLE [core].[ReferenceType] (
    [IdClient]              NVARCHAR (8)   NOT NULL,
    [Id]                    NVARCHAR (3)   NOT NULL,
    [ReferenceTableName]    NVARCHAR (100) NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)   NOT NULL,
    [LastAction]            NVARCHAR (3)   NOT NULL,
    [MakeBy]                NVARCHAR (50)  NOT NULL,
    [MakeDate]              DATETIME2 (7)  NOT NULL
);

