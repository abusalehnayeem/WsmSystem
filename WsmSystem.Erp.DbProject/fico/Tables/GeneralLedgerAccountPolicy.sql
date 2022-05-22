CREATE TABLE [fico].[GeneralLedgerAccountPolicy] (
    [Id]                      INT           NOT NULL,
    [GLMaxLevel]              INT           NOT NULL,
    [GLAccountLength]         INT           NOT NULL,
    [TotalAssetAccountNo]     NVARCHAR (12) NOT NULL,
    [TotalLiabilityAccountNo] NVARCHAR (12) NOT NULL,
    [TotalIncomeAccountNo]    NVARCHAR (12) NOT NULL,
    [TotalExpenseAccountNo]   NVARCHAR (12) NOT NULL,
    [TotalEquityAccountNo]    NVARCHAR (12) NOT NULL,
    [IsClientWiseChart]       BIT           NOT NULL,
    [IdAuthorizationStatus]   NVARCHAR (1)  NOT NULL,
    [MakeBy]                  NVARCHAR (50) NOT NULL,
    [MakeDate]                DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_GeneralLedgerAccountPolicy] PRIMARY KEY CLUSTERED ([Id] ASC)
);

