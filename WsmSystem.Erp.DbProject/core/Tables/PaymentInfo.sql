CREATE TABLE [core].[PaymentInfo] (
    [Id]                    INT            NOT NULL,
    [IdClient]              INT            NOT NULL,
    [IdTrader]              NVARCHAR (5)   NULL,
    [IdPaymentType]         NVARCHAR (1)   NULL,
    [IdTransactionMode]     NVARCHAR (3)   NULL,
    [IdBank]                NVARCHAR (3)   NULL,
    [IdBankBranch]          NVARCHAR (5)   NULL,
    [IdAccountType]         NVARCHAR (2)   NULL,
    [BankAccountNo]         NVARCHAR (50)  NULL,
    [AccountPayeeName]      NVARCHAR (300) NULL,
    [IsActive]              BIT            NULL,
    [LastAction]            NVARCHAR (3)   NULL,
    [MakeBy]                NVARCHAR (50)  NULL,
    [MakeDate]              DATETIME2 (7)  NULL,
    [AuthorizationStatusId] NVARCHAR (1)   NULL,
    [ApprovedBy]            NVARCHAR (50)  NULL,
    [ApprovedDate]          DATETIME2 (7)  NULL,
    [RejectionRemarks]      NVARCHAR (500) NULL,
    [FunctionId]            NVARCHAR (6)   NULL
);

