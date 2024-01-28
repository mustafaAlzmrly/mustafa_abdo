
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/28/2024 22:33:24
-- Generated from EDMX file: C:\Users\HP\source\repos\AMS_PRO_MAX1\AMS_PRO_MAX\AMS_PRO_MAX\Model3.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DB_AMS_PRO];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK__Inventory__ItemI__3B75D760]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Inventory] DROP CONSTRAINT [FK__Inventory__ItemI__3B75D760];
GO
IF OBJECT_ID(N'[dbo].[FK__InvoiceIt__Invoi__412EB0B6]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceItems] DROP CONSTRAINT [FK__InvoiceIt__Invoi__412EB0B6];
GO
IF OBJECT_ID(N'[dbo].[FK__InvoiceIt__ItemI__4222D4EF]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InvoiceItems] DROP CONSTRAINT [FK__InvoiceIt__ItemI__4222D4EF];
GO
IF OBJECT_ID(N'[dbo].[FK__Invoices__UserID__3E52440B]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Invoices] DROP CONSTRAINT [FK__Invoices__UserID__3E52440B];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Alerts]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Alerts];
GO
IF OBJECT_ID(N'[dbo].[Inventory]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Inventory];
GO
IF OBJECT_ID(N'[dbo].[InvoiceItems]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InvoiceItems];
GO
IF OBJECT_ID(N'[dbo].[Invoices]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Invoices];
GO
IF OBJECT_ID(N'[dbo].[Items]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Items];
GO
IF OBJECT_ID(N'[dbo].[Users]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Users];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Alerts'
CREATE TABLE [dbo].[Alerts] (
    [AlertID] int IDENTITY(1,1) NOT NULL,
    [ProductName] varchar(255)  NULL,
    [ExpiryDate] datetime  NULL,
    [AvailableQuantity] int  NULL
);
GO

-- Creating table 'Inventories'
CREATE TABLE [dbo].[Inventories] (
    [InventoryID] int  NOT NULL,
    [ItemID] int  NULL,
    [Quantity] int  NULL
);
GO

-- Creating table 'InvoiceItems'
CREATE TABLE [dbo].[InvoiceItems] (
    [InvoiceItemID] int  NOT NULL,
    [InvoiceID] int  NULL,
    [ItemID] int  NULL,
    [Quantity] int  NULL
);
GO

-- Creating table 'Invoices'
CREATE TABLE [dbo].[Invoices] (
    [InvoiceID] int  NOT NULL,
    [UserID] int  NULL,
    [InvoiceDate] datetime  NULL,
    [Status] varchar(20)  NULL
);
GO

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [ItemID] int IDENTITY(1,1) NOT NULL,
    [Name] varchar(100)  NOT NULL,
    [Description] varchar(max)  NULL,
    [Image] varchar(255)  NULL,
    [Price] decimal(10,2)  NOT NULL,
    [ExpiryDate] datetime  NULL,
    [QuantityAvailable] int  NULL
);
GO

-- Creating table 'Users'
CREATE TABLE [dbo].[Users] (
    [UserID] int IDENTITY(1,1) NOT NULL,
    [Username] varchar(50)  NOT NULL,
    [Password] varchar(50)  NOT NULL,
    [Fullname] varchar(100)  NOT NULL,
    [state] bit  NOT NULL,
    [RoleID] int  NOT NULL,
    [state1] bit  NULL,
    [RoleID1] int  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [AlertID] in table 'Alerts'
ALTER TABLE [dbo].[Alerts]
ADD CONSTRAINT [PK_Alerts]
    PRIMARY KEY CLUSTERED ([AlertID] ASC);
GO

-- Creating primary key on [InventoryID] in table 'Inventories'
ALTER TABLE [dbo].[Inventories]
ADD CONSTRAINT [PK_Inventories]
    PRIMARY KEY CLUSTERED ([InventoryID] ASC);
GO

-- Creating primary key on [InvoiceItemID] in table 'InvoiceItems'
ALTER TABLE [dbo].[InvoiceItems]
ADD CONSTRAINT [PK_InvoiceItems]
    PRIMARY KEY CLUSTERED ([InvoiceItemID] ASC);
GO

-- Creating primary key on [InvoiceID] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [PK_Invoices]
    PRIMARY KEY CLUSTERED ([InvoiceID] ASC);
GO

-- Creating primary key on [ItemID] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([ItemID] ASC);
GO

-- Creating primary key on [UserID] in table 'Users'
ALTER TABLE [dbo].[Users]
ADD CONSTRAINT [PK_Users]
    PRIMARY KEY CLUSTERED ([UserID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ItemID] in table 'Inventories'
ALTER TABLE [dbo].[Inventories]
ADD CONSTRAINT [FK__Inventory__ItemI__3B75D760]
    FOREIGN KEY ([ItemID])
    REFERENCES [dbo].[Items]
        ([ItemID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Inventory__ItemI__3B75D760'
CREATE INDEX [IX_FK__Inventory__ItemI__3B75D760]
ON [dbo].[Inventories]
    ([ItemID]);
GO

-- Creating foreign key on [InvoiceID] in table 'InvoiceItems'
ALTER TABLE [dbo].[InvoiceItems]
ADD CONSTRAINT [FK__InvoiceIt__Invoi__412EB0B6]
    FOREIGN KEY ([InvoiceID])
    REFERENCES [dbo].[Invoices]
        ([InvoiceID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__InvoiceIt__Invoi__412EB0B6'
CREATE INDEX [IX_FK__InvoiceIt__Invoi__412EB0B6]
ON [dbo].[InvoiceItems]
    ([InvoiceID]);
GO

-- Creating foreign key on [ItemID] in table 'InvoiceItems'
ALTER TABLE [dbo].[InvoiceItems]
ADD CONSTRAINT [FK__InvoiceIt__ItemI__4222D4EF]
    FOREIGN KEY ([ItemID])
    REFERENCES [dbo].[Items]
        ([ItemID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__InvoiceIt__ItemI__4222D4EF'
CREATE INDEX [IX_FK__InvoiceIt__ItemI__4222D4EF]
ON [dbo].[InvoiceItems]
    ([ItemID]);
GO

-- Creating foreign key on [UserID] in table 'Invoices'
ALTER TABLE [dbo].[Invoices]
ADD CONSTRAINT [FK__Invoices__UserID__3E52440B]
    FOREIGN KEY ([UserID])
    REFERENCES [dbo].[Users]
        ([UserID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK__Invoices__UserID__3E52440B'
CREATE INDEX [IX_FK__Invoices__UserID__3E52440B]
ON [dbo].[Invoices]
    ([UserID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------