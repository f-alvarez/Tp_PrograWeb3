
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/18/2016 01:55:56
-- Generated from EDMX file: C:\Users\Cesar\Documents\workspace\Tp_PrograWeb3\AccesoADatos\EDMPW3.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PW3_TP_20161C];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Comentarios_Eventos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comentarios] DROP CONSTRAINT [FK_Comentarios_Eventos];
GO
IF OBJECT_ID(N'[dbo].[FK_Comentarios_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Comentarios] DROP CONSTRAINT [FK_Comentarios_Usuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_Eventos_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Eventos] DROP CONSTRAINT [FK_Eventos_Usuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_EventosRecetas_Eventos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventosRecetas] DROP CONSTRAINT [FK_EventosRecetas_Eventos];
GO
IF OBJECT_ID(N'[dbo].[FK_EventosRecetas_Recetas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[EventosRecetas] DROP CONSTRAINT [FK_EventosRecetas_Recetas];
GO
IF OBJECT_ID(N'[dbo].[FK_Recetas_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Recetas] DROP CONSTRAINT [FK_Recetas_Usuarios];
GO
IF OBJECT_ID(N'[dbo].[FK_Reservas_Eventos]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservas] DROP CONSTRAINT [FK_Reservas_Eventos];
GO
IF OBJECT_ID(N'[dbo].[FK_Reservas_Recetas]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservas] DROP CONSTRAINT [FK_Reservas_Recetas];
GO
IF OBJECT_ID(N'[dbo].[FK_Reservas_Usuarios]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Reservas] DROP CONSTRAINT [FK_Reservas_Usuarios];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Comentarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Comentarios];
GO
IF OBJECT_ID(N'[dbo].[Eventos]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Eventos];
GO
IF OBJECT_ID(N'[dbo].[EventosRecetas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[EventosRecetas];
GO
IF OBJECT_ID(N'[dbo].[Recetas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Recetas];
GO
IF OBJECT_ID(N'[dbo].[Reservas]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Reservas];
GO
IF OBJECT_ID(N'[dbo].[Usuarios]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Usuarios];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Comentarios'
CREATE TABLE [dbo].[Comentarios] (
    [IdComentario] int IDENTITY(1,1) NOT NULL,
    [IdEvento] int  NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Puntuacion] tinyint  NOT NULL,
    [Comentarios1] nvarchar(400)  NOT NULL
);
GO

-- Creating table 'Eventos'
CREATE TABLE [dbo].[Eventos] (
    [IdEvento] int IDENTITY(1,1) NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Nombre] nvarchar(50)  NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Descripcion] nvarchar(700)  NOT NULL,
    [CantidadComensales] int  NOT NULL,
    [Ubicacion] nvarchar(400)  NOT NULL,
    [NombreFoto] nvarchar(50)  NOT NULL,
    [Precio] decimal(18,2)  NOT NULL,
    [Estado] tinyint  NOT NULL
);
GO

-- Creating table 'Recetas'
CREATE TABLE [dbo].[Recetas] (
    [IdReceta] int IDENTITY(1,1) NOT NULL,
    [IdUsuario] int  NOT NULL,
    [Nombre] nvarchar(50)  NOT NULL,
    [TiempoCoccion] int  NOT NULL,
    [Descripcion] nvarchar(3000)  NOT NULL,
    [Ingredientes] nvarchar(3000)  NOT NULL,
    [Tipo] tinyint  NOT NULL
);
GO

-- Creating table 'Reservas'
CREATE TABLE [dbo].[Reservas] (
    [IdReserva] int IDENTITY(1,1) NOT NULL,
    [IdUsuario] int  NOT NULL,
    [IdEvento] int  NOT NULL,
    [IdReceta] int  NOT NULL,
    [Cantidad] int  NOT NULL
);
GO

-- Creating table 'Usuarios'
CREATE TABLE [dbo].[Usuarios] (
    [IdUsuario] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(50)  NOT NULL,
    [Email] nvarchar(200)  NOT NULL,
    [Password] nvarchar(50)  NOT NULL,
    [FechaRegistracion] datetime  NOT NULL,
    [IdTipoUsuario] tinyint  NOT NULL
);
GO

-- Creating table 'EventosRecetas'
CREATE TABLE [dbo].[EventosRecetas] (
    [Eventos_IdEvento] int  NOT NULL,
    [Recetas_IdReceta] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdComentario] in table 'Comentarios'
ALTER TABLE [dbo].[Comentarios]
ADD CONSTRAINT [PK_Comentarios]
    PRIMARY KEY CLUSTERED ([IdComentario] ASC);
GO

-- Creating primary key on [IdEvento] in table 'Eventos'
ALTER TABLE [dbo].[Eventos]
ADD CONSTRAINT [PK_Eventos]
    PRIMARY KEY CLUSTERED ([IdEvento] ASC);
GO

-- Creating primary key on [IdReceta] in table 'Recetas'
ALTER TABLE [dbo].[Recetas]
ADD CONSTRAINT [PK_Recetas]
    PRIMARY KEY CLUSTERED ([IdReceta] ASC);
GO

-- Creating primary key on [IdReserva] in table 'Reservas'
ALTER TABLE [dbo].[Reservas]
ADD CONSTRAINT [PK_Reservas]
    PRIMARY KEY CLUSTERED ([IdReserva] ASC);
GO

-- Creating primary key on [IdUsuario] in table 'Usuarios'
ALTER TABLE [dbo].[Usuarios]
ADD CONSTRAINT [PK_Usuarios]
    PRIMARY KEY CLUSTERED ([IdUsuario] ASC);
GO

-- Creating primary key on [Eventos_IdEvento], [Recetas_IdReceta] in table 'EventosRecetas'
ALTER TABLE [dbo].[EventosRecetas]
ADD CONSTRAINT [PK_EventosRecetas]
    PRIMARY KEY NONCLUSTERED ([Eventos_IdEvento], [Recetas_IdReceta] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdEvento] in table 'Comentarios'
ALTER TABLE [dbo].[Comentarios]
ADD CONSTRAINT [FK_Comentarios_Eventos]
    FOREIGN KEY ([IdEvento])
    REFERENCES [dbo].[Eventos]
        ([IdEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Comentarios_Eventos'
CREATE INDEX [IX_FK_Comentarios_Eventos]
ON [dbo].[Comentarios]
    ([IdEvento]);
GO

-- Creating foreign key on [IdUsuario] in table 'Comentarios'
ALTER TABLE [dbo].[Comentarios]
ADD CONSTRAINT [FK_Comentarios_Usuarios]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Comentarios_Usuarios'
CREATE INDEX [IX_FK_Comentarios_Usuarios]
ON [dbo].[Comentarios]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdUsuario] in table 'Eventos'
ALTER TABLE [dbo].[Eventos]
ADD CONSTRAINT [FK_Eventos_Usuarios]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Eventos_Usuarios'
CREATE INDEX [IX_FK_Eventos_Usuarios]
ON [dbo].[Eventos]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdEvento] in table 'Reservas'
ALTER TABLE [dbo].[Reservas]
ADD CONSTRAINT [FK_Reservas_Eventos]
    FOREIGN KEY ([IdEvento])
    REFERENCES [dbo].[Eventos]
        ([IdEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Reservas_Eventos'
CREATE INDEX [IX_FK_Reservas_Eventos]
ON [dbo].[Reservas]
    ([IdEvento]);
GO

-- Creating foreign key on [IdUsuario] in table 'Recetas'
ALTER TABLE [dbo].[Recetas]
ADD CONSTRAINT [FK_Recetas_Usuarios]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Recetas_Usuarios'
CREATE INDEX [IX_FK_Recetas_Usuarios]
ON [dbo].[Recetas]
    ([IdUsuario]);
GO

-- Creating foreign key on [IdReceta] in table 'Reservas'
ALTER TABLE [dbo].[Reservas]
ADD CONSTRAINT [FK_Reservas_Recetas]
    FOREIGN KEY ([IdReceta])
    REFERENCES [dbo].[Recetas]
        ([IdReceta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Reservas_Recetas'
CREATE INDEX [IX_FK_Reservas_Recetas]
ON [dbo].[Reservas]
    ([IdReceta]);
GO

-- Creating foreign key on [IdUsuario] in table 'Reservas'
ALTER TABLE [dbo].[Reservas]
ADD CONSTRAINT [FK_Reservas_Usuarios]
    FOREIGN KEY ([IdUsuario])
    REFERENCES [dbo].[Usuarios]
        ([IdUsuario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Reservas_Usuarios'
CREATE INDEX [IX_FK_Reservas_Usuarios]
ON [dbo].[Reservas]
    ([IdUsuario]);
GO

-- Creating foreign key on [Eventos_IdEvento] in table 'EventosRecetas'
ALTER TABLE [dbo].[EventosRecetas]
ADD CONSTRAINT [FK_EventosRecetas_Eventos]
    FOREIGN KEY ([Eventos_IdEvento])
    REFERENCES [dbo].[Eventos]
        ([IdEvento])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Recetas_IdReceta] in table 'EventosRecetas'
ALTER TABLE [dbo].[EventosRecetas]
ADD CONSTRAINT [FK_EventosRecetas_Recetas]
    FOREIGN KEY ([Recetas_IdReceta])
    REFERENCES [dbo].[Recetas]
        ([IdReceta])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EventosRecetas_Recetas'
CREATE INDEX [IX_FK_EventosRecetas_Recetas]
ON [dbo].[EventosRecetas]
    ([Recetas_IdReceta]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------