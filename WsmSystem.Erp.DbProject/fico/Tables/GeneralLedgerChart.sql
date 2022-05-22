CREATE TABLE [fico].[GeneralLedgerChart] (
    [GLAccountNo]           NUMERIC (12)   NOT NULL,
    [GLAccountName]         NVARCHAR (120) NOT NULL,
    [GLPrefix]              NVARCHAR (4)   NOT NULL,
    [TotalingAccountNo]     NVARCHAR (12)  NULL,
    [GLType]                NVARCHAR (1)   NOT NULL,
    [GLAccountType]         NVARCHAR (1)   NOT NULL,
    [GLLevel]               INT            NOT NULL,
    [IdCurrency]            INT            NOT NULL,
    [Postable]              BIT            NOT NULL,
    [PreviousGLCode]        NVARCHAR (20)  NULL,
    [BalanceSheetItemFlag]  BIT            NOT NULL,
    [OpeningDate]           DATETIME2 (7)  NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)   NOT NULL,
    [FunctionId]            NVARCHAR (6)   NOT NULL,
    [MakeBy]                NVARCHAR (50)  NOT NULL,
    [MakeDate]              DATETIME2 (7)  NOT NULL,
    [ApprovedBy]            NVARCHAR (50)  NULL,
    [ApprovedDate]          DATETIME2 (7)  NULL,
    [RejectionRemarks]      NVARCHAR (500) NULL
);

