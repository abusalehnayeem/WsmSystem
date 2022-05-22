CREATE TABLE [core].[ItemTransactionMasterHistory] (
    [IdClient]              INT             NOT NULL,
    [Id]                    INT             NOT NULL,
    [IdItemMasterSize]      INT             NOT NULL,
    [TransactionDate]       DATETIME2 (7)   NOT NULL,
    [IdWarehouse]           INT             NULL,
    [OpeningStockQty]       NUMERIC (18, 2) NOT NULL,
    [StockInBondQty]        NUMERIC (18, 2) NOT NULL,
    [StockOutBondQty]       NUMERIC (18, 2) NOT NULL,
    [CurrentStockQty]       NUMERIC (18, 2) NOT NULL,
    [RejectInBondQty]       NUMERIC (18, 2) NOT NULL,
    [RejectOutBondQty]      NUMERIC (18, 2) NOT NULL,
    [RejectStockQty]        NUMERIC (18, 2) NOT NULL,
    [SortOrder]             INT             NOT NULL,
    [IsActive]              BIT             NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)    NOT NULL,
    [LastAction]            NVARCHAR (3)    NOT NULL,
    [MakeBy]                NVARCHAR (50)   NOT NULL,
    [MakeDate]              DATETIME2 (7)   NOT NULL,
    [UpdateBy]              NVARCHAR (50)   NULL,
    [UpdateDate]            DATETIME2 (7)   NULL
);

