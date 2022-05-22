﻿CREATE TABLE [skus].[PartnerMaster] (
    [IdClient]                   INT             NOT NULL,
    [Id]                         INT             NOT NULL,
    [TraderCode]                 NVARCHAR (5)    NULL,
    [TraderName]                 NVARCHAR (500)  NOT NULL,
    [TraderPhone]                NVARCHAR (25)   NULL,
    [TraderEmail]                NVARCHAR (40)   NULL,
    [TraderContactPerson]        NVARCHAR (150)  NULL,
    [TraderAddress]              NVARCHAR (1000) NULL,
    [Instruction]                NVARCHAR (400)  NULL,
    [IdCountry]                  INT             NULL,
    [IdBusinessPartnerType]      INT             NOT NULL,
    [IdTraderNature]             INT             NULL,
    [CustomField1]               NVARCHAR (100)  NULL,
    [CustomField2]               NVARCHAR (100)  NULL,
    [CustomField3]               NVARCHAR (100)  NULL,
    [AccountOpeningDate]         DATETIME2 (7)   NULL,
    [IdProduct]                  INT             NULL,
    [IdCurrency]                 INT             NULL,
    [CurrentBalanceLcy]          NUMERIC (24, 6) NULL,
    [CurrentBalanceCcy]          NUMERIC (24, 6) NULL,
    [BalanceLcy]                 NUMERIC (24, 6) NULL,
    [BalanceCcy]                 NUMERIC (24, 6) NULL,
    [BlockedAmount]              NUMERIC (24, 6) NULL,
    [HoldAmount]                 NUMERIC (24, 6) NULL,
    [AdvanceAmount]              NUMERIC (24, 6) NULL,
    [LastStatementGeneratedDate] DATETIME2 (7)   NULL,
    [LastTransactionDate]        DATETIME2 (7)   NULL,
    [LastAction]                 NVARCHAR (3)    NOT NULL,
    [MakeBy]                     NVARCHAR (50)   NOT NULL,
    [MakeDate]                   DATETIME        NOT NULL,
    [IdAuthorizationStatus]      NVARCHAR (1)    NOT NULL,
    [ApprovedBy]                 NVARCHAR (50)   NULL,
    [ApprovedDate]               DATETIME        NULL,
    [RejectionRemarks]           NVARCHAR (100)  NULL,
    [UpdateBy]                   NVARCHAR (50)   NULL,
    [UpdateDate]                 DATETIME2 (7)   NULL,
    CONSTRAINT [PK_BusinessPartnerMaster] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);

