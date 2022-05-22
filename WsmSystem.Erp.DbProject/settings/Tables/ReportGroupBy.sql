CREATE TABLE [settings].[ReportGroupBy] (
    [IdClient]      INT           NOT NULL,
    [Id]            INT           NOT NULL,
    [GroupByName]   NVARCHAR (60) NOT NULL,
    [OperationType] NVARCHAR (60) NOT NULL,
    [IsActive]      BIT           NOT NULL,
    [LastAction]    NVARCHAR (3)  NOT NULL,
    [MakeBy]        NVARCHAR (50) NOT NULL,
    [MakeDate]      DATETIME2 (7) NOT NULL,
    [UpdateBy]      NVARCHAR (50) NULL,
    [UpdateDate]    DATETIME2 (7) NULL
);

