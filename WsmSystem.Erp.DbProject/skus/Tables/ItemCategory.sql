CREATE TABLE [skus].[ItemCategory] (
    [IdClient]              INT           NOT NULL,
    [Id]                    INT           NOT NULL,
    [ItemCategoryDesc]      NVARCHAR (50) NOT NULL,
    [ItemCategoryShortCode] NVARCHAR (5)  NULL,
    [IsActive]              BIT           NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)  NOT NULL,
    [LastAction]            NVARCHAR (3)  NOT NULL,
    [MakeBy]                NVARCHAR (50) NOT NULL,
    [MakeDate]              DATETIME2 (7) NOT NULL,
    [UpdateBy]              VARCHAR (50)  NULL,
    [UpdateDate]            DATETIME2 (7) NULL,
    CONSTRAINT [PK_ItemCategory] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);

