CREATE TABLE [securities].[ClientInfo] (
    [Id]             INT            NOT NULL,
    [IdAppClient]    INT            NOT NULL,
    [CompanyName]    NVARCHAR (300) NULL,
    [CompanyEmail]   NVARCHAR (200) NULL,
    [CompanyUrl]     NVARCHAR (MAX) NULL,
    [CompanyAddress] NVARCHAR (MAX) NULL,
    [LogoUrl]        NVARCHAR (100) NULL,
    [IsActive]       BIT            CONSTRAINT [DF_ClientInfo_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction]     NVARCHAR (3)   NOT NULL,
    [MakeBy]         NVARCHAR (50)  NOT NULL,
    [MakeDate]       DATETIME2 (7)  CONSTRAINT [DF_ClientInfo_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]       NVARCHAR (50)  NULL,
    [UpdateDate]     DATETIME2 (7)  NULL,
    CONSTRAINT [PK_ClientInfo] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ClientInfo_AppClient] FOREIGN KEY ([IdAppClient]) REFERENCES [securities].[AppClient] ([Id])
);

