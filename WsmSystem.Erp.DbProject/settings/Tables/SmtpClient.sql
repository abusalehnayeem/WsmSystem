CREATE TABLE [settings].[SmtpClient] (
    [IdClient]              INT            NOT NULL,
    [Server]                NVARCHAR (100) NOT NULL,
    [Port]                  INT            NOT NULL,
    [UseDefaultCredentials] BIT            NOT NULL,
    [UserName]              NVARCHAR (100) NULL,
    [Password]              NVARCHAR (256) NULL,
    [EnableSsl]             BIT            NOT NULL,
    [Timeout]               INT            NOT NULL,
    [SenderMail]            VARCHAR (128)  NOT NULL,
    [LastAction]            NVARCHAR (50)  NULL,
    [MakeBy]                NVARCHAR (50)  NOT NULL,
    [MakeDate]              DATETIME2 (7)  NOT NULL,
    [UpdateBy]              VARCHAR (50)   NULL,
    [UpdateDate]            DATETIME2 (7)  NULL
);

