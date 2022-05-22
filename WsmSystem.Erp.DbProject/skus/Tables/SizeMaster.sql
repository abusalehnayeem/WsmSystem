CREATE TABLE [skus].[SizeMaster] (
    [IdClient]              INT            NOT NULL,
    [Id]                    INT            NOT NULL,
    [ItemSizeId]            NVARCHAR (3)   NULL,
    [ItemSizeNo]            NVARCHAR (200) NOT NULL,
    [SizeDescription]       NVARCHAR (100) NULL,
    [FriendlyName]          NVARCHAR (100) NULL,
    [IsActive]              BIT            NOT NULL,
    [IsDefaultSize]         BIT            NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)   NOT NULL,
    [LastAction]            NVARCHAR (3)   NOT NULL,
    [MakeBy]                NVARCHAR (50)  NOT NULL,
    [MakeDate]              DATETIME2 (7)  NOT NULL,
    [UpdateBy]              VARCHAR (50)   NULL,
    [UpdateDate]            DATETIME2 (7)  NULL,
    CONSTRAINT [PK_SizeMaster] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);

