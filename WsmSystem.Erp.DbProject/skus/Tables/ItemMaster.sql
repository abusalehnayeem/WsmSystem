﻿CREATE TABLE [skus].[ItemMaster] (
    [IdClient]              INT             NOT NULL,
    [Id]                    INT             NOT NULL,
    [ItemNo]                NVARCHAR (30)   NOT NULL,
    [IdItemGroup]           INT             NOT NULL,
    [IdItemCategory]        INT             NOT NULL,
    [ItemDescription1]      NVARCHAR (500)  NULL,
    [IsMixItem]             BIT             NULL,
    [IdHsCode]              INT             NOT NULL,
    [HasItemSize]           BIT             CONSTRAINT [DF_WsmSku_HasItemSize] DEFAULT ((0)) NULL,
    [IdCurrency]            INT             NULL,
    [UnitPrice]             NUMERIC (18, 3) NULL,
    [IdPartner]             INT             NULL,
    [ImportDuty]            NUMERIC (18, 2) CONSTRAINT [DF_WsmSku_ImportDuty] DEFAULT ((0)) NULL,
    [AtiTax]                NUMERIC (18, 2) CONSTRAINT [DF_WsmSku_AtiTax] DEFAULT ((0)) NULL,
    [IsActive]              BIT             CONSTRAINT [DF_WsmSku_IsActive] DEFAULT ((1)) NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)    NOT NULL,
    [Remarks]               NVARCHAR (500)  NULL,
    [LastAction]            NVARCHAR (3)    NOT NULL,
    [MakeBy]                NVARCHAR (50)   NOT NULL,
    [MakeDate]              DATETIME2 (7)   CONSTRAINT [DF_WsmSku_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]              VARCHAR (50)    NULL,
    [UpdateDate]            DATETIME2 (7)   NULL,
    CONSTRAINT [PK_WsmSku] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC),
    CONSTRAINT [FK_Sku_Currency] FOREIGN KEY ([IdClient], [IdCurrency]) REFERENCES [skus].[Currency] ([IdClient], [Id]),
    CONSTRAINT [FK_Sku_HsCode] FOREIGN KEY ([IdClient], [IdHsCode]) REFERENCES [skus].[HsCode] ([IdClient], [Id]),
    CONSTRAINT [FK_Sku_ItemCategory] FOREIGN KEY ([IdClient], [IdItemCategory]) REFERENCES [skus].[ItemCategory] ([IdClient], [Id]),
    CONSTRAINT [FK_Sku_ItemGroup] FOREIGN KEY ([IdClient], [IdItemGroup]) REFERENCES [skus].[ItemGroup] ([IdClient], [Id])
);
