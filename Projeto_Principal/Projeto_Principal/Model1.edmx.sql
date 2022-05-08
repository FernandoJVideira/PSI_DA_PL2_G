
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/07/2022 19:47:24
-- Generated from EDMX file: C:\Users\rodri\Desktop\code\Projeto_Principal\Projeto_Principal\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Projeto];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_RestauranteMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Restaurante] DROP CONSTRAINT [FK_RestauranteMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_PessoaMorada]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa] DROP CONSTRAINT [FK_PessoaMorada];
GO
IF OBJECT_ID(N'[dbo].[FK_Cliente_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Cliente] DROP CONSTRAINT [FK_Cliente_inherits_Pessoa];
GO
IF OBJECT_ID(N'[dbo].[FK_Trabalhador_inherits_Pessoa]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Pessoa_Trabalhador] DROP CONSTRAINT [FK_Trabalhador_inherits_Pessoa];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Pessoa]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa];
GO
IF OBJECT_ID(N'[dbo].[Morada]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Morada];
GO
IF OBJECT_ID(N'[dbo].[Restaurante]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Restaurante];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Cliente]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Cliente];
GO
IF OBJECT_ID(N'[dbo].[Pessoa_Trabalhador]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Pessoa_Trabalhador];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Pessoa'
CREATE TABLE [dbo].[Pessoa] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Telemovel] nvarchar(max)  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'Morada'
CREATE TABLE [dbo].[Morada] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Rua] nvarchar(max)  NOT NULL,
    [Cidade] nvarchar(max)  NOT NULL,
    [Pais] nvarchar(max)  NOT NULL,
    [CodPostal] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Restaurante'
CREATE TABLE [dbo].[Restaurante] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Morada_Id] int  NOT NULL
);
GO

-- Creating table 'Pedido'
CREATE TABLE [dbo].[Pedido] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ValorTotal] decimal(18,0)  NOT NULL,
    [EstadoId] int  NOT NULL,
    [PagamentoId] int  NOT NULL,
    [Trabalhador_Id] int  NOT NULL,
    [Cliente_Id] int  NOT NULL
);
GO

-- Creating table 'Estado'
CREATE TABLE [dbo].[Estado] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Pronto] bit  NOT NULL
);
GO

-- Creating table 'Pagamento'
CREATE TABLE [dbo].[Pagamento] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Valor] nvarchar(max)  NOT NULL,
    [MetodoPagamento_Id] int  NOT NULL,
    [Pedido_Id] int  NOT NULL
);
GO

-- Creating table 'MetodoPagamento'
CREATE TABLE [dbo].[MetodoPagamento] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'ItemMenu'
CREATE TABLE [dbo].[ItemMenu] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CategoriaId] int  NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Fotografia] nvarchar(max)  NOT NULL,
    [Ingredientes] nvarchar(max)  NOT NULL,
    [Preco] decimal(18,0)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Categoria'
CREATE TABLE [dbo].[Categoria] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Nome] nvarchar(max)  NOT NULL,
    [Ativo] bit  NOT NULL
);
GO

-- Creating table 'Pessoa_Trabalhador'
CREATE TABLE [dbo].[Pessoa_Trabalhador] (
    [Salario] decimal(18,0)  NOT NULL,
    [Posicao] nvarchar(max)  NOT NULL,
    [RestauranteId] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Pessoa_Cliente'
CREATE TABLE [dbo].[Pessoa_Cliente] (
    [NIF] nvarchar(max)  NOT NULL,
    [TotalGasto] decimal(18,0)  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'ItemMenuPedido'
CREATE TABLE [dbo].[ItemMenuPedido] (
    [ItemMenu_Id] int  NOT NULL,
    [ItemMenuPedido_ItemMenu_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Pessoa'
ALTER TABLE [dbo].[Pessoa]
ADD CONSTRAINT [PK_Pessoa]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Morada'
ALTER TABLE [dbo].[Morada]
ADD CONSTRAINT [PK_Morada]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Restaurante'
ALTER TABLE [dbo].[Restaurante]
ADD CONSTRAINT [PK_Restaurante]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [PK_Pedido]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Estado'
ALTER TABLE [dbo].[Estado]
ADD CONSTRAINT [PK_Estado]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pagamento'
ALTER TABLE [dbo].[Pagamento]
ADD CONSTRAINT [PK_Pagamento]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'MetodoPagamento'
ALTER TABLE [dbo].[MetodoPagamento]
ADD CONSTRAINT [PK_MetodoPagamento]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ItemMenu'
ALTER TABLE [dbo].[ItemMenu]
ADD CONSTRAINT [PK_ItemMenu]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Categoria'
ALTER TABLE [dbo].[Categoria]
ADD CONSTRAINT [PK_Categoria]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoa_Trabalhador'
ALTER TABLE [dbo].[Pessoa_Trabalhador]
ADD CONSTRAINT [PK_Pessoa_Trabalhador]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pessoa_Cliente'
ALTER TABLE [dbo].[Pessoa_Cliente]
ADD CONSTRAINT [PK_Pessoa_Cliente]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [ItemMenu_Id], [ItemMenuPedido_ItemMenu_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [PK_ItemMenuPedido]
    PRIMARY KEY CLUSTERED ([ItemMenu_Id], [ItemMenuPedido_ItemMenu_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Morada_Id] in table 'Restaurante'
ALTER TABLE [dbo].[Restaurante]
ADD CONSTRAINT [FK_RestauranteMorada]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Morada]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteMorada'
CREATE INDEX [IX_FK_RestauranteMorada]
ON [dbo].[Restaurante]
    ([Morada_Id]);
GO

-- Creating foreign key on [Morada_Id] in table 'Pessoa'
ALTER TABLE [dbo].[Pessoa]
ADD CONSTRAINT [FK_PessoaMorada]
    FOREIGN KEY ([Morada_Id])
    REFERENCES [dbo].[Morada]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PessoaMorada'
CREATE INDEX [IX_FK_PessoaMorada]
ON [dbo].[Pessoa]
    ([Morada_Id]);
GO

-- Creating foreign key on [RestauranteId] in table 'Pessoa_Trabalhador'
ALTER TABLE [dbo].[Pessoa_Trabalhador]
ADD CONSTRAINT [FK_RestauranteTrabalhador]
    FOREIGN KEY ([RestauranteId])
    REFERENCES [dbo].[Restaurante]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_RestauranteTrabalhador'
CREATE INDEX [IX_FK_RestauranteTrabalhador]
ON [dbo].[Pessoa_Trabalhador]
    ([RestauranteId]);
GO

-- Creating foreign key on [Trabalhador_Id] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [FK_PedidoTrabalhador]
    FOREIGN KEY ([Trabalhador_Id])
    REFERENCES [dbo].[Pessoa_Trabalhador]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoTrabalhador'
CREATE INDEX [IX_FK_PedidoTrabalhador]
ON [dbo].[Pedido]
    ([Trabalhador_Id]);
GO

-- Creating foreign key on [Cliente_Id] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [FK_PedidoCliente]
    FOREIGN KEY ([Cliente_Id])
    REFERENCES [dbo].[Pessoa_Cliente]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PedidoCliente'
CREATE INDEX [IX_FK_PedidoCliente]
ON [dbo].[Pedido]
    ([Cliente_Id]);
GO

-- Creating foreign key on [EstadoId] in table 'Pedido'
ALTER TABLE [dbo].[Pedido]
ADD CONSTRAINT [FK_EstadoPedido]
    FOREIGN KEY ([EstadoId])
    REFERENCES [dbo].[Estado]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_EstadoPedido'
CREATE INDEX [IX_FK_EstadoPedido]
ON [dbo].[Pedido]
    ([EstadoId]);
GO

-- Creating foreign key on [MetodoPagamento_Id] in table 'Pagamento'
ALTER TABLE [dbo].[Pagamento]
ADD CONSTRAINT [FK_PagamentoMetodoPagamento]
    FOREIGN KEY ([MetodoPagamento_Id])
    REFERENCES [dbo].[MetodoPagamento]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoMetodoPagamento'
CREATE INDEX [IX_FK_PagamentoMetodoPagamento]
ON [dbo].[Pagamento]
    ([MetodoPagamento_Id]);
GO

-- Creating foreign key on [Pedido_Id] in table 'Pagamento'
ALTER TABLE [dbo].[Pagamento]
ADD CONSTRAINT [FK_PagamentoPedido]
    FOREIGN KEY ([Pedido_Id])
    REFERENCES [dbo].[Pedido]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_PagamentoPedido'
CREATE INDEX [IX_FK_PagamentoPedido]
ON [dbo].[Pagamento]
    ([Pedido_Id]);
GO

-- Creating foreign key on [ItemMenu_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_ItemMenu]
    FOREIGN KEY ([ItemMenu_Id])
    REFERENCES [dbo].[ItemMenu]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [ItemMenuPedido_ItemMenu_Id] in table 'ItemMenuPedido'
ALTER TABLE [dbo].[ItemMenuPedido]
ADD CONSTRAINT [FK_ItemMenuPedido_Pedido]
    FOREIGN KEY ([ItemMenuPedido_ItemMenu_Id])
    REFERENCES [dbo].[Pedido]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemMenuPedido_Pedido'
CREATE INDEX [IX_FK_ItemMenuPedido_Pedido]
ON [dbo].[ItemMenuPedido]
    ([ItemMenuPedido_ItemMenu_Id]);
GO

-- Creating foreign key on [CategoriaId] in table 'ItemMenu'
ALTER TABLE [dbo].[ItemMenu]
ADD CONSTRAINT [FK_CategoriaItemMenu]
    FOREIGN KEY ([CategoriaId])
    REFERENCES [dbo].[Categoria]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategoriaItemMenu'
CREATE INDEX [IX_FK_CategoriaItemMenu]
ON [dbo].[ItemMenu]
    ([CategoriaId]);
GO

-- Creating foreign key on [Id] in table 'Pessoa_Trabalhador'
ALTER TABLE [dbo].[Pessoa_Trabalhador]
ADD CONSTRAINT [FK_Trabalhador_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoa]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Pessoa_Cliente'
ALTER TABLE [dbo].[Pessoa_Cliente]
ADD CONSTRAINT [FK_Cliente_inherits_Pessoa]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Pessoa]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------