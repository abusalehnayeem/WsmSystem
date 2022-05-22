CREATE TABLE [skus].[Country] (
    [IdClient]    INT            NOT NULL,
    [Id]          INT            NOT NULL,
    [CountryName] NVARCHAR (100) NOT NULL,
    [CountryCode] NVARCHAR (3)   NULL,
    [Nationality] NVARCHAR (100) NULL,
    [IsActive]    BIT            NOT NULL,
    [IsLocal]     BIT            NULL,
    [HasState]    BIT            NULL,
    [LastAction]  NVARCHAR (3)   NOT NULL,
    [MakeBy]      VARCHAR (50)   NOT NULL,
    [MakeDate]    DATETIME2 (7)  NOT NULL,
    CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED ([IdClient] ASC, [Id] ASC)
);

