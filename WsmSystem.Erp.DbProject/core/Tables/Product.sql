CREATE TABLE [core].[Product] (
    [IdClient]              INT            NOT NULL,
    [Id]                    INT            NOT NULL,
    [ProductName]           NVARCHAR (100) NOT NULL,
    [ProductType]           NVARCHAR (8)   NOT NULL,
    [LastAction]            NVARCHAR (3)   NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)   NOT NULL,
    [MakeBy]                NVARCHAR (50)  NOT NULL,
    [MakeDate]              DATETIME2 (7)  NOT NULL
);

