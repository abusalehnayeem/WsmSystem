CREATE TABLE [securities].[AppClient] (
    [Id]             INT            NOT NULL,
    [AppClientName]  NVARCHAR (300) NOT NULL,
    [ApplicationKey] NVARCHAR (50)  NULL,
    [ExpireDate]     DATETIME2 (7)  NULL,
    [IsActive]       BIT            CONSTRAINT [DF_AppClient_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction]     VARCHAR (3)    NOT NULL,
    [MakeBy]         NVARCHAR (50)  NOT NULL,
    [MakeDate]       DATETIME2 (7)  CONSTRAINT [DF_AppClient_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]       NVARCHAR (50)  NULL,
    [UpdateDate]     DATETIME2 (7)  NULL,
    CONSTRAINT [PK_ApplicationRoot] PRIMARY KEY CLUSTERED ([Id] ASC)
);

