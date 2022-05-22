CREATE TABLE [fico].[GLChartLevelPolicy] (
    [GLLevelNo]             INT           NOT NULL,
    [GLLevelName]           NVARCHAR (50) NULL,
    [GLLevelLength]         INT           NOT NULL,
    [GLLevelStartPoint]     INT           NOT NULL,
    [GLLevelEndPoint]       INT           NOT NULL,
    [GLLevelIncrementBy]    INT           NOT NULL,
    [IdAuthorizationStatus] NVARCHAR (1)  NOT NULL,
    [MakeBy]                NVARCHAR (50) NOT NULL,
    [MakeDate]              DATETIME2 (7) NOT NULL
);

