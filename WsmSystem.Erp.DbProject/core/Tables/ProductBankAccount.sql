CREATE TABLE [core].[ProductBankAccount] (
    [IdClient]              INT            NOT NULL,
    [IdProduct]             INT            NOT NULL,
    [IdBankAccount]         INT            NOT NULL,
    [IsActive]              BIT            NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)   NOT NULL,
    [FunctionId]            NVARCHAR (6)   NOT NULL,
    [MakeBy]                NVARCHAR (50)  NOT NULL,
    [MakeDate]              DATETIME2 (7)  NOT NULL,
    [ApprovedBy]            NVARCHAR (50)  NULL,
    [ApprovedDate]          DATETIME2 (7)  NULL,
    [LastAction]            NVARCHAR (3)   NOT NULL,
    [RejectionRemarks]      NVARCHAR (100) NULL
);

