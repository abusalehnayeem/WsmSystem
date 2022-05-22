CREATE TABLE [securities].[UserInfo] (
    [IdClient]       INT            NOT NULL,
    [Id]             INT            NOT NULL,
    [AccessLevel]    NVARCHAR (4)   NULL,
    [UserName]       NVARCHAR (50)  NOT NULL,
    [UserFullName]   NVARCHAR (100) NULL,
    [UserPassword]   NVARCHAR (500) NOT NULL,
    [PasswordSalt]   NVARCHAR (500) NULL,
    [IdRole]         INT            NULL,
    [IsActive]       BIT            CONSTRAINT [DF_UserInfo_IsActive] DEFAULT ((1)) NOT NULL,
    [UserEmail]      NVARCHAR (100) NULL,
    [IsLockedOut]    BIT            CONSTRAINT [DF_UserInfo_IsLockedOut] DEFAULT ((0)) NOT NULL,
    [ChangePassword] BIT            CONSTRAINT [DF_UserInfo_ChangePassword] DEFAULT ((0)) NULL,
    [LastAction]     NVARCHAR (3)   NOT NULL,
    [MakeBy]         NVARCHAR (50)  NOT NULL,
    [MakeDate]       DATETIME2 (7)  CONSTRAINT [DF_UserInfo_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]       NVARCHAR (50)  NULL,
    [UpdateDate]     DATETIME2 (7)  NULL,
    CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC),
    CONSTRAINT [FK_UserInfo_UserRole] FOREIGN KEY ([IdClient], [IdRole]) REFERENCES [securities].[UserRole] ([IdClient], [Id])
);

