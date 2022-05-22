CREATE TABLE [core].[ProductLedgers] (
    [IdClient]              INT            NOT NULL,
    [IdProduct]             INT            NOT NULL,
    [IdGLLinkType]          INT            NOT NULL,
    [GLAccountNo]           NUMERIC (12)   NULL,
    [IdReferenceType]       NVARCHAR (3)   NULL,
    [IsActive]              BIT            NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)   NOT NULL,
    [FunctionId]            NVARCHAR (6)   NOT NULL,
    [LastAction]            NVARCHAR (3)   NOT NULL,
    [MakeBy]                NVARCHAR (50)  NOT NULL,
    [MakeDate]              DATETIME2 (7)  NOT NULL,
    [ApprovedBy]            NVARCHAR (50)  NULL,
    [ApprovedDate]          DATETIME2 (7)  NULL,
    [RejectRemarks]         NVARCHAR (100) NULL
);

