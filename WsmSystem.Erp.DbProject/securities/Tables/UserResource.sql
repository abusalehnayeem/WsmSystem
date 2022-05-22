CREATE TABLE [securities].[UserResource] (
    [IdClient]     INT            NOT NULL,
    [Id]           INT            NOT NULL,
    [ApiUrl]       NVARCHAR (MAX) NOT NULL,
    [IdHttpMethod] INT            NOT NULL,
    [IsActive]     BIT            CONSTRAINT [DF_UserResource_IsActive] DEFAULT ((0)) NOT NULL,
    [LastAction]   NVARCHAR (3)   NOT NULL,
    [MakeBy]       NVARCHAR (50)  NOT NULL,
    [MakeDate]     DATETIME2 (7)  CONSTRAINT [DF_UserResource_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]     NVARCHAR (50)  NULL,
    [UpdateDate]   DATETIME2 (7)  NULL,
    CONSTRAINT [PK_UserResource] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC),
    CONSTRAINT [FK_UserResource_HttpRequestType] FOREIGN KEY ([IdClient], [IdHttpMethod]) REFERENCES [securities].[HttpRequestType] ([IdClient], [Id])
);

