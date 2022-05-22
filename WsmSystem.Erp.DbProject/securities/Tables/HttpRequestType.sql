CREATE TABLE [securities].[HttpRequestType] (
    [IdClient]       INT           NOT NULL,
    [Id]             INT           NOT NULL,
    [HttpMethodType] NVARCHAR (10) NOT NULL,
    [IsActive]       BIT           CONSTRAINT [DF_HttpRequestType_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction]     NVARCHAR (3)  NOT NULL,
    [MakeBy]         NVARCHAR (50) NOT NULL,
    [MakeDate]       DATETIME2 (7) CONSTRAINT [DF_HttpRequestType_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]       NVARCHAR (50) NULL,
    [UpdateDate]     DATETIME2 (7) NULL,
    CONSTRAINT [PK_HttpRequestType] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);

