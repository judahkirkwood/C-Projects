CREATE TABLE [dbo].[SignUps] (
    [Id]           INT           NOT NULL,
    [FirstName]    VARCHAR (50)  NULL,
    [LastName]     VARCHAR (50)  NULL,
    [EmailAddress] VARCHAR (100) NULL,
    [SocialSecutrityNumber] VARCHAR(15) NULL, 
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

