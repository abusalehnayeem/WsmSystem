CREATE TABLE [skus].[UoM] (
    [IdClient]              INT           NOT NULL,
    [Id]                    INT           NOT NULL,
    [UnitName]              VARCHAR (10)  NOT NULL,
    [UnitDescription]       VARCHAR (200) NULL,
    [IsActive]              BIT           NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)  NOT NULL,
    [LastAction]            VARCHAR (3)   NOT NULL,
    [MakeBy]                VARCHAR (50)  NOT NULL,
    [MakeDate]              DATETIME2 (7) NOT NULL,
    [UpdateBy]              VARCHAR (50)  NULL,
    [UpdateDate]            DATETIME2 (7) NULL,
    [ApprovedBy]            VARCHAR (50)  NULL,
    [ApprovedDate]          DATETIME2 (7) NULL,
    [RejectionRemarks]      VARCHAR (500) NULL,
    [FunctionId]            VARCHAR (6)   NULL,
    CONSTRAINT [PK_UoM] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);

