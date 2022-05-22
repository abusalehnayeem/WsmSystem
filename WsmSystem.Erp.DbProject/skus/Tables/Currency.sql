CREATE TABLE [skus].[Currency] (
    [IdClient]              INT             NOT NULL,
    [Id]                    INT             CONSTRAINT [DF_Currency_Id] DEFAULT ((10001001)) NOT NULL,
    [CurrencyName]          NVARCHAR (100)  NOT NULL,
    [CurrencyShortName]     NVARCHAR (4)    NOT NULL,
    [CurrencyReportName]    NVARCHAR (50)   NOT NULL,
    [CurrencyDecimalName]   NVARCHAR (50)   NOT NULL,
    [ExchangeRate]          NUMERIC (18, 6) NOT NULL,
    [IsLocalCurrency]       BIT             NOT NULL,
    [LastAction]            NVARCHAR (3)    NOT NULL,
    [MakeBy]                NVARCHAR (50)   NOT NULL,
    [MakeDate]              DATETIME2 (7)   NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)    NOT NULL,
    CONSTRAINT [PK_Currency] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);

