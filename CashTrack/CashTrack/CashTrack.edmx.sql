
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/10/2022 15:42:49
-- Generated from EDMX file: C:\_GIT\CashTrack\CashTrack\CashTrack\CashTrack.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [CashTrackDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Clients'
CREATE TABLE [dbo].[Clients] (
    [id] int IDENTITY(1,1) NOT NULL,
    [isEnabled] smallint  NOT NULL,
    [firstName] nvarchar(max)  NOT NULL,
    [lastName] nvarchar(max)  NOT NULL,
    [birthDate] datetime  NOT NULL,
    [email] nvarchar(max)  NOT NULL,
    [password] nvarchar(max)  NOT NULL,
    [createdAt] time  NOT NULL,
    [updateAt] time  NOT NULL
);
GO

-- Creating table 'Companies'
CREATE TABLE [dbo].[Companies] (
    [id] int IDENTITY(1,1) NOT NULL,
    [isEnabled] smallint  NOT NULL,
    [name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Locations'
CREATE TABLE [dbo].[Locations] (
    [id] int IDENTITY(1,1) NOT NULL,
    [city] nvarchar(max)  NOT NULL,
    [address] nvarchar(max)  NOT NULL,
    [zipcode] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TransactionCategories'
CREATE TABLE [dbo].[TransactionCategories] (
    [id] int IDENTITY(1,1) NOT NULL,
    [isEnabled] smallint  NOT NULL,
    [description] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TransactionTypes'
CREATE TABLE [dbo].[TransactionTypes] (
    [id] int IDENTITY(1,1) NOT NULL,
    [transactionType] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Transactions'
CREATE TABLE [dbo].[Transactions] (
    [id] int IDENTITY(1,1) NOT NULL,
    [isEnabled] smallint  NOT NULL,
    [value] float  NOT NULL,
    [transactionDate] datetime  NOT NULL,
    [description] nvarchar(max)  NOT NULL,
    [transactionCategoryID] int  NOT NULL,
    [transactionTypeID] int  NOT NULL,
    [companyID] int  NOT NULL,
    [clientID] int  NOT NULL
);
GO

-- Creating table 'ClientLocation'
CREATE TABLE [dbo].[ClientLocation] (
    [Clients_id] int  NOT NULL,
    [Locations_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Clients'
ALTER TABLE [dbo].[Clients]
ADD CONSTRAINT [PK_Clients]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Companies'
ALTER TABLE [dbo].[Companies]
ADD CONSTRAINT [PK_Companies]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Locations'
ALTER TABLE [dbo].[Locations]
ADD CONSTRAINT [PK_Locations]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'TransactionCategories'
ALTER TABLE [dbo].[TransactionCategories]
ADD CONSTRAINT [PK_TransactionCategories]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'TransactionTypes'
ALTER TABLE [dbo].[TransactionTypes]
ADD CONSTRAINT [PK_TransactionTypes]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [PK_Transactions]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Clients_id], [Locations_id] in table 'ClientLocation'
ALTER TABLE [dbo].[ClientLocation]
ADD CONSTRAINT [PK_ClientLocation]
    PRIMARY KEY CLUSTERED ([Clients_id], [Locations_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [transactionCategoryID] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_TransactionCategoryTransaction]
    FOREIGN KEY ([transactionCategoryID])
    REFERENCES [dbo].[TransactionCategories]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionCategoryTransaction'
CREATE INDEX [IX_FK_TransactionCategoryTransaction]
ON [dbo].[Transactions]
    ([transactionCategoryID]);
GO

-- Creating foreign key on [transactionTypeID] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_TransactionTypeTransaction]
    FOREIGN KEY ([transactionTypeID])
    REFERENCES [dbo].[TransactionTypes]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TransactionTypeTransaction'
CREATE INDEX [IX_FK_TransactionTypeTransaction]
ON [dbo].[Transactions]
    ([transactionTypeID]);
GO

-- Creating foreign key on [companyID] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_CompanyTransaction]
    FOREIGN KEY ([companyID])
    REFERENCES [dbo].[Companies]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CompanyTransaction'
CREATE INDEX [IX_FK_CompanyTransaction]
ON [dbo].[Transactions]
    ([companyID]);
GO

-- Creating foreign key on [clientID] in table 'Transactions'
ALTER TABLE [dbo].[Transactions]
ADD CONSTRAINT [FK_ClientTransaction]
    FOREIGN KEY ([clientID])
    REFERENCES [dbo].[Clients]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientTransaction'
CREATE INDEX [IX_FK_ClientTransaction]
ON [dbo].[Transactions]
    ([clientID]);
GO

-- Creating foreign key on [Clients_id] in table 'ClientLocation'
ALTER TABLE [dbo].[ClientLocation]
ADD CONSTRAINT [FK_ClientLocation_Client]
    FOREIGN KEY ([Clients_id])
    REFERENCES [dbo].[Clients]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Locations_id] in table 'ClientLocation'
ALTER TABLE [dbo].[ClientLocation]
ADD CONSTRAINT [FK_ClientLocation_Location]
    FOREIGN KEY ([Locations_id])
    REFERENCES [dbo].[Locations]
        ([id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientLocation_Location'
CREATE INDEX [IX_FK_ClientLocation_Location]
ON [dbo].[ClientLocation]
    ([Locations_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------