USE PW3_TP_20161C;
GO
DELETE FROM [dbo].[Comentarios];
DELETE FROM [dbo].[Reservas];
DELETE FROM [dbo].[EventosRecetas];
DELETE FROM [dbo].[Eventos];
DELETE FROM [dbo].[Recetas];
DELETE FROM [dbo].[Usuarios];
GO

SET IDENTITY_INSERT [dbo].[Usuarios] ON;
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Email], [Password], [FechaRegistracion], [IdTipoUsuario]) VALUES (1, 'Xena', 'xena@cocineros.com', 'XENA12345', 2016/06/22, 2)
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Email], [Password], [FechaRegistracion], [IdTipoUsuario]) VALUES (2, 'Hercules', 'hercules@comensales.com', 'HERCULES12345', 2016/06/22, 1)
SET IDENTITY_INSERT [dbo].[Usuarios] OFF;

SET IDENTITY_INSERT [dbo].[Recetas] ON;
INSERT [dbo].[Recetas] ([IdReceta], [IdUsuario], [Nombre], [TiempoCoccion], [Descripcion], [Ingredientes], [Tipo]) VALUES (1, 1, N'Oreotorta', 30, N'Torta hecha de oreos.', N'Oreos. Dulce de leche. Queso crema.', 3)
SET IDENTITY_INSERT [dbo].[Recetas] OFF;


SET IDENTITY_INSERT [dbo].[Eventos] ON;
INSERT [dbo].[Eventos] ([IdEvento], [IdUsuario], [Nombre], [Fecha], [Descripcion], [CantidadComensales], [Ubicacion], [NombreFoto], [Precio], [Estado]) VALUES (1, 1, N'Tortas', 2016/06/29, N'Tortas variadas', 20, N'Buenos Aires', N'f746b6216e82d399ea57956e65a74961.jpg', CAST(1000.00 AS Decimal(18, 2)), 3)
SET IDENTITY_INSERT [dbo].[Eventos] OFF;

INSERT [dbo].[EventosRecetas] ([IdEvento], [IdReceta]) VALUES (1, 1)

SET IDENTITY_INSERT [dbo].[Reservas] ON;
INSERT [dbo].[Reservas] ([IdReserva], [IdUsuario], [IdEvento], [IdReceta], [Cantidad]) VALUES (1, 2, 1, 1, 19)
SET IDENTITY_INSERT [dbo].[Reservas] OFF	;

SET IDENTITY_INSERT [dbo].[Comentarios] ON;
INSERT [dbo].[Comentarios] ([IdComentario], [IdEvento], [IdUsuario], [Puntuacion], [Comentarios]) VALUES (1, 1, 2, 1, N'Excelente pero el precio muy caro.')
SET IDENTITY_INSERT [dbo].[Comentarios] OFF;