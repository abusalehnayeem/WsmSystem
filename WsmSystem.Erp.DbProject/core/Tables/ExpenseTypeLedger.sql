CREATE TABLE [core].[ExpenseTypeLedger] (
    [IdClient]              INT            NOT NULL,
    [IdProduct]             INT            NOT NULL,
    [IdExpenseType]         NVARCHAR (4)   NOT NULL,
    [GLAccountNo]           NVARCHAR (12)  NOT NULL,
    [IsVATApplicable]       BIT            NOT NULL,
    [IdVATProfile]          NVARCHAR (3)   NULL,
    [IsTaxApplicable]       BIT            NOT NULL,
    [IdTaxProfile]          NVARCHAR (3)   NULL,
    [IdAuthorizationStatus] NVARCHAR (1)   NOT NULL,
    [MakeBy]                NVARCHAR (50)  NOT NULL,
    [MakeDate]              DATETIME2 (7)  NOT NULL,
    [ApprovedBy]            NVARCHAR (50)  NULL,
    [ApprovedDate]          DATETIME2 (7)  NULL,
    [RejectRemarks]         NVARCHAR (100) NULL,
    [FunctionId]            NVARCHAR (6)   NOT NULL,
    [LastAction]            NVARCHAR (3)   NOT NULL
);

