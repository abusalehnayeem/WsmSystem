CREATE TABLE [skus].[HsCode] (
    [IdClient]              INT            NOT NULL,
    [Id]                    INT            NOT NULL,
    [HsCodeNo]              NVARCHAR (15)  NOT NULL,
    [HsCodeDescription]     NVARCHAR (50)  NULL,
    [IdUnitOfMeasurement]   INT            NOT NULL,
    [IsActive]              BIT            NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)   NOT NULL,
    [LastAction]            NVARCHAR (3)   NOT NULL,
    [MakeBy]                NVARCHAR (50)  NOT NULL,
    [MakeDate]              DATETIME2 (7)  NOT NULL,
    [UpdateBy]              NVARCHAR (50)  NULL,
    [UpdateDate]            DATETIME2 (7)  NULL,
    [ApprovedBy]            NVARCHAR (50)  NULL,
    [ApprovedDate]          DATETIME2 (7)  NULL,
    [RejectionRemarks]      NVARCHAR (500) NULL,
    [FunctionId]            NVARCHAR (50)  NULL,
    CONSTRAINT [PK_HsCode] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);

