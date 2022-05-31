CREATE TABLE [securities].[UserGroup] (
    [IdClient]         INT            NOT NULL,
    [Id]               INT            NOT NULL,
    [GroupName]        NVARCHAR (50)  NOT NULL,
    [GroupDescription] NVARCHAR (500) NULL,
    [IsActive]         BIT            CONSTRAINT [DF_UserGroup_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction]       NVARCHAR (3)   NOT NULL,
    [MakeBy]           NVARCHAR (50)  NOT NULL,
    [MakeDate]         DATETIME2 (7)  CONSTRAINT [DF_UserGroup_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]         VARCHAR (50)   NULL,
    [UpdateDate]       DATETIME2 (7)  NULL,
    CONSTRAINT [PK_UserGroup] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);



