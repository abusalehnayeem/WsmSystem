CREATE TABLE [skus].[ItemGroup] (
    [IdClient]              INT           NOT NULL,
    [Id]                    INT           NOT NULL,
    [ItemGroupShortCode]    NVARCHAR (5)  NOT NULL,
    [ItemGroupDesc]         NVARCHAR (50) NULL,
    [IsActive]              BIT           NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)  NOT NULL,
    [LastAction]            NVARCHAR (3)  NOT NULL,
    [MakeBy]                NVARCHAR (50) NOT NULL,
    [MakeDate]              DATETIME2 (7) NOT NULL,
    [UpdateBy]              VARCHAR (50)  NULL,
    [UpdateDate]            DATETIME2 (7) NULL,
    [FunctionId]            VARCHAR (6)   NULL,
    CONSTRAINT [PK_ItemGroup] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);

