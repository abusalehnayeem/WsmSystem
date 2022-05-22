CREATE TABLE [core].[ExpenseType] (
    [Id]                     INT            NOT NULL,
    [IdClient]               INT            NOT NULL,
    [ExpenseTypeName]        NVARCHAR (100) NOT NULL,
    [ExpenseTypeDescription] NVARCHAR (250) NULL,
    [IdAuthorizationStatus]  NVARCHAR (1)   NOT NULL,
    [FunctionId]             NVARCHAR (6)   NOT NULL,
    [MakeBy]                 NVARCHAR (50)  NOT NULL,
    [MakeDate]               DATETIME2 (7)  NOT NULL,
    [ApprovedBy]             NVARCHAR (50)  NULL,
    [ApprovedDate]           DATETIME       NULL,
    [LastAction]             NVARCHAR (3)   NOT NULL,
    [RejectionRemarks]       NVARCHAR (100) NULL
);

