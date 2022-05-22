CREATE TABLE [securities].[SecurityPolicy] (
    [Id]                             INT           NOT NULL,
    [IdClient]                       INT           NOT NULL,
    [MaximumWrongLoginTry]           INT           NOT NULL,
    [MinimumPasswordLength]          INT           NOT NULL,
    [PasswordAttemptWindow]          INT           NULL,
    [UserOnlineTimeWindow]           INT           NULL,
    [IsAlphaNumericPasswordRequired] BIT           CONSTRAINT [DF_SecurityPolicy_IsAlphaNumericPasswordRequired] DEFAULT ((0)) NOT NULL,
    [IsPasswordSaltRequired]         BIT           CONSTRAINT [DF_SecurityPolicy_IsPasswordSaltRequired] DEFAULT ((0)) NULL,
    [IsPasswordStrengthRequired]     BIT           CONSTRAINT [DF_SecurityPolicy_IsPasswordStrengthRequired] DEFAULT ((0)) NOT NULL,
    [IsUniqueEmailRequired]          BIT           CONSTRAINT [DF_SecurityPolicy_IsUniqueEmailRequired] DEFAULT ((0)) NOT NULL,
    [IsActive]                       BIT           CONSTRAINT [DF_SecurityPolicy_IsActive] DEFAULT ((1)) NOT NULL,
    [LastAction]                     NVARCHAR (3)  NOT NULL,
    [MakeBy]                         NVARCHAR (50) NOT NULL,
    [MakeDate]                       DATETIME2 (7) CONSTRAINT [DF_SecurityPolicy_MakeDate] DEFAULT (getdate()) NOT NULL,
    [UpdateBy]                       NVARCHAR (50) NULL,
    [UpdateDate]                     DATETIME2 (7) NULL,
    CONSTRAINT [PK_SecurityPolicy] PRIMARY KEY CLUSTERED ([Id] ASC, [IdClient] ASC)
);

