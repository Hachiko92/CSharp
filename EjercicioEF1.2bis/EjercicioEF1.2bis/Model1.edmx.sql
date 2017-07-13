
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 07/13/2017 15:44:47
-- Generated from EDMX file: C:\Users\Web2017\Documents\CursoWeb\CSharp\EjercicioEF1.2bis\EjercicioEF1.2bis\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Tienda];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientesPedidos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidosSet] DROP CONSTRAINT [FK_ClientesPedidos];
GO
IF OBJECT_ID(N'[dbo].[FK_ProductosPedidos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[PedidosSet] DROP CONSTRAINT [FK_ProductosPedidos];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ProductosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ProductosSet];
GO
IF OBJECT_ID(N'[dbo].[PedidosSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PedidosSet];
GO
IF OBJECT_ID(N'[dbo].[ClientesSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientesSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ProductosSet'
CREATE TABLE [dbo].[ProductosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProductName] nvarchar(max)  NOT NULL,
    [UnitPrice] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'PedidosSet'
CREATE TABLE [dbo].[PedidosSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Cantidad] int  NOT NULL,
    [ClienteID] int  NOT NULL,
    [ProductoID] int  NOT NULL,
    [Clientes_Id] int  NOT NULL,
    [Productos_Id] int  NOT NULL
);
GO

-- Creating table 'ClientesSet'
CREATE TABLE [dbo].[ClientesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CompanyName] nvarchar(max)  NOT NULL,
    [Address] nvarchar(max)  NOT NULL,
    [Phone] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ProductosSet'
ALTER TABLE [dbo].[ProductosSet]
ADD CONSTRAINT [PK_ProductosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'PedidosSet'
ALTER TABLE [dbo].[PedidosSet]
ADD CONSTRAINT [PK_PedidosSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientesSet'
ALTER TABLE [dbo].[ClientesSet]
ADD CONSTRAINT [PK_ClientesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Clientes_Id] in table 'PedidosSet'
ALTER TABLE [dbo].[PedidosSet]
ADD CONSTRAINT [FK_ClientesPedidos]
    FOREIGN KEY ([Clientes_Id])
    REFERENCES [dbo].[ClientesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientesPedidos'
CREATE INDEX [IX_FK_ClientesPedidos]
ON [dbo].[PedidosSet]
    ([Clientes_Id]);
GO

-- Creating foreign key on [Productos_Id] in table 'PedidosSet'
ALTER TABLE [dbo].[PedidosSet]
ADD CONSTRAINT [FK_ProductosPedidos]
    FOREIGN KEY ([Productos_Id])
    REFERENCES [dbo].[ProductosSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ProductosPedidos'
CREATE INDEX [IX_FK_ProductosPedidos]
ON [dbo].[PedidosSet]
    ([Productos_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------