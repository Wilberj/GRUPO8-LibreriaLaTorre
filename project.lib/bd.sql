USE [BDproyectolibreria]
GO
/****** Object:  Table [dbo].[bodega]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[bodega](
	[Id_Bodega] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[Direccion] [varchar](350) NULL,
	[Telefono] [int] NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_bodega] PRIMARY KEY CLUSTERED 
(
	[Id_Bodega] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[Id_Categoria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[Id_Categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[cliente]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[cliente](
	[Id_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Telefono] [int] NULL,
	[Fecha_Ingreso] [smalldatetime] NOT NULL,
	[Nombre_Cliente] [varchar](150) NOT NULL,
 CONSTRAINT [PK_cliente] PRIMARY KEY CLUSTERED 
(
	[Id_Cliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[Id_Compra] [int] IDENTITY(1,1) NOT NULL,
	[Id_Proveedor] [int] NOT NULL,
	[Fecha_Compra] [date] NOT NULL,
	[Total] [decimal](10, 2) NOT NULL,
	[Id_Usuario] [int] NULL,
	[Sub_Total] [decimal](10, 2) NOT NULL,
	[IVA] [decimal](10, 2) NULL,
	[Descuento] [decimal](10, 2) NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[Id_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[configuracion]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[configuracion](
	[id_libreria] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Direccion] [varchar](200) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Estado] [bit] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle venta]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle venta](
	[Id_Detalle_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Id_Articulo] [int] NOT NULL,
	[Id_Venta] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Marca] [decimal](10, 2) NOT NULL,
	[IVA] [decimal](10, 2) NOT NULL,
	[Subtotal] [decimal](10, 2) NOT NULL,
	[Total_Venta] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_detalle venta] PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[detalle_compra]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[detalle_compra](
	[Id_Detalle_Compra] [int] IDENTITY(1,1) NOT NULL,
	[Id_Compra] [int] NOT NULL,
	[Cantidad_Compra] [int] NOT NULL,
	[Precio_Compra] [decimal](10, 2) NOT NULL,
	[Articulo] [varchar](100) NOT NULL,
	[Subtotal_Compra] [decimal](10, 2) NOT NULL,
	[IVA] [decimal](10, 2) NULL,
	[Total_Compra] [decimal](10, 2) NOT NULL,
	[Descuento] [decimal](10, 2) NULL,
 CONSTRAINT [PK_detalle_compra] PRIMARY KEY CLUSTERED 
(
	[Id_Detalle_Compra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[IdMarca] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Descripcion] [varchar](200) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[permisos_usuarios]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[permisos_usuarios](
	[Id_Permisos] [int] IDENTITY(1,1) NOT NULL,
	[Id_rol_usuario] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Fecha_registro] [date] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[Id_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](100) NULL,
	[Estado] [bit] NOT NULL,
	[Nombre] [varchar](350) NOT NULL,
	[Id_Categoria] [int] NOT NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[Id_Producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto_dañado]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto_dañado](
	[Id_Articulo_D] [int] IDENTITY(1,1) NOT NULL,
	[Estado_Venta] [bit] NOT NULL,
	[Descripcion] [varchar](150) NOT NULL,
	[Usuario] [int] NULL,
	[fecha_de_baja] [date] NULL,
 CONSTRAINT [PK_Producto_dañado] PRIMARY KEY CLUSTERED 
(
	[Id_Articulo_D] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[proveedor]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[proveedor](
	[Id_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[Dirección] [varchar](100) NULL,
	[Telefono] [varchar](10) NULL,
	[Estado] [int] NOT NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[Id_Proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[rol_usuario]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[rol_usuario](
	[Id_Rol_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Rol] [varchar](10) NOT NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_rol_usuario] PRIMARY KEY CLUSTERED 
(
	[Id_Rol_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock_articulos]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock_articulos](
	[Id_StockArticulo] [int] IDENTITY(1,1) NOT NULL,
	[Id_Producto] [int] NOT NULL,
	[Id_Bodega] [int] NULL,
	[Id_Compra] [int] NULL,
	[Cantidad] [int] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Valor_Unitario] [nchar](10) NOT NULL,
	[Precio_Compra] [decimal](10, 2) NOT NULL,
	[Precio_Venta] [int] NOT NULL,
	[Descripcion] [char](250) NOT NULL,
	[Fecha_Ingreso] [date] NULL,
	[Condicion_Prod] [int] NOT NULL,
	[Color] [varchar](50) NULL,
	[IdMarca] [int] NULL,
	[Dimensiones] [varchar](50) NULL,
 CONSTRAINT [PK_articulos] PRIMARY KEY CLUSTERED 
(
	[Id_StockArticulo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuario]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuario](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Id_Rol_Usuario] [int] NULL,
	[Estado] [bit] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[venta]    Script Date: 14/7/2022 01:36:10 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[venta](
	[Id_Venta] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Id_Usuario] [int] NULL,
	[Valor_Total] [decimal](10, 2) NOT NULL,
	[Nro_Venta] [int] NOT NULL,
	[Fecha_Ingreso] [date] NOT NULL,
	[Estado] [bit] NOT NULL,
	[Cliente_Nombre] [varchar](150) NOT NULL,
	[Sub_Total] [decimal](10, 2) NOT NULL,
	[IVA] [decimal](10, 2) NOT NULL,
	[Total] [decimal](10, 2) NOT NULL,
 CONSTRAINT [PK_venta] PRIMARY KEY CLUSTERED 
(
	[Id_Venta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[bodega] ON 

INSERT [dbo].[bodega] ([Id_Bodega], [Nombre], [Direccion], [Telefono], [Estado]) VALUES (1, N'Bod1', N'Hacia aca', 25324323, 1)
INSERT [dbo].[bodega] ([Id_Bodega], [Nombre], [Direccion], [Telefono], [Estado]) VALUES (2, N'easdasd', N'sdasdasdasdasd', 232323223, 1)
INSERT [dbo].[bodega] ([Id_Bodega], [Nombre], [Direccion], [Telefono], [Estado]) VALUES (3, N'easdasd', N'sdasdasdasdasd', 232323223, 1)
INSERT [dbo].[bodega] ([Id_Bodega], [Nombre], [Direccion], [Telefono], [Estado]) VALUES (4, N'easdasd', N'sdasdasdasdasd', 232323223, 1)
INSERT [dbo].[bodega] ([Id_Bodega], [Nombre], [Direccion], [Telefono], [Estado]) VALUES (5, N'easdasd', N'sdasdasdasdasd', 232323223, 1)
INSERT [dbo].[bodega] ([Id_Bodega], [Nombre], [Direccion], [Telefono], [Estado]) VALUES (6, N'easdasd', N'sdasdasdasdasd', 232323223, 1)
INSERT [dbo].[bodega] ([Id_Bodega], [Nombre], [Direccion], [Telefono], [Estado]) VALUES (7, N'easdasd', N'sdasdasdasdasd', 232323223, 1)
INSERT [dbo].[bodega] ([Id_Bodega], [Nombre], [Direccion], [Telefono], [Estado]) VALUES (8, N'easdasd', N'sdasdasdasdasd', 232323223, 1)
INSERT [dbo].[bodega] ([Id_Bodega], [Nombre], [Direccion], [Telefono], [Estado]) VALUES (9, N'asas', N'asas', 12131312, 1)
INSERT [dbo].[bodega] ([Id_Bodega], [Nombre], [Direccion], [Telefono], [Estado]) VALUES (10, N'Bod2', N'Aqui', 89654, 0)
SET IDENTITY_INSERT [dbo].[bodega] OFF
GO
SET IDENTITY_INSERT [dbo].[categoria] ON 

INSERT [dbo].[categoria] ([Id_Categoria], [Nombre], [Estado]) VALUES (1, N'Papeleria', 1)
INSERT [dbo].[categoria] ([Id_Categoria], [Nombre], [Estado]) VALUES (2, N'Oficina', 1)
INSERT [dbo].[categoria] ([Id_Categoria], [Nombre], [Estado]) VALUES (3, N'Manualidades', 0)
INSERT [dbo].[categoria] ([Id_Categoria], [Nombre], [Estado]) VALUES (4, N'Escolar', 1)
SET IDENTITY_INSERT [dbo].[categoria] OFF
GO
SET IDENTITY_INSERT [dbo].[Compra] ON 

INSERT [dbo].[Compra] ([Id_Compra], [Id_Proveedor], [Fecha_Compra], [Total], [Id_Usuario], [Sub_Total], [IVA], [Descuento], [Estado]) VALUES (1, 1, CAST(N'2022-07-13' AS Date), CAST(1234.00 AS Decimal(10, 2)), 0, CAST(1234.00 AS Decimal(10, 2)), CAST(100.00 AS Decimal(10, 2)), CAST(100.00 AS Decimal(10, 2)), 1)
SET IDENTITY_INSERT [dbo].[Compra] OFF
GO
SET IDENTITY_INSERT [dbo].[producto] ON 

INSERT [dbo].[producto] ([Id_Producto], [Descripcion], [Estado], [Nombre], [Id_Categoria]) VALUES (1, N'Almohadillas y Tintas', 1, N'Tintas', 4)
INSERT [dbo].[producto] ([Id_Producto], [Descripcion], [Estado], [Nombre], [Id_Categoria]) VALUES (2, N'Cintas Ahdesivas y Doble Contacto', 1, N'Adhesivos', 4)
INSERT [dbo].[producto] ([Id_Producto], [Descripcion], [Estado], [Nombre], [Id_Categoria]) VALUES (3, N'Marcadores y resaltadores', 1, N'Marcadores', 4)
INSERT [dbo].[producto] ([Id_Producto], [Descripcion], [Estado], [Nombre], [Id_Categoria]) VALUES (4, N'Lapiceros y plumas', 1, N'Lapices', 4)
INSERT [dbo].[producto] ([Id_Producto], [Descripcion], [Estado], [Nombre], [Id_Categoria]) VALUES (5, N'Foamys', 1, N'Foamy', 3)
INSERT [dbo].[producto] ([Id_Producto], [Descripcion], [Estado], [Nombre], [Id_Categoria]) VALUES (6, N'Pintura acrílica ', 1, N'Pinturas', 3)
INSERT [dbo].[producto] ([Id_Producto], [Descripcion], [Estado], [Nombre], [Id_Categoria]) VALUES (7, N'Papel bond', 1, N'Papel bond', 1)
INSERT [dbo].[producto] ([Id_Producto], [Descripcion], [Estado], [Nombre], [Id_Categoria]) VALUES (8, N'Cartón delgado', 1, N'Cartulina', 1)
INSERT [dbo].[producto] ([Id_Producto], [Descripcion], [Estado], [Nombre], [Id_Categoria]) VALUES (9, N'Papel crepé', 1, N'Papel crepé', 1)
SET IDENTITY_INSERT [dbo].[producto] OFF
GO
SET IDENTITY_INSERT [dbo].[proveedor] ON 

INSERT [dbo].[proveedor] ([Id_Proveedor], [Nombre], [Dirección], [Telefono], [Estado]) VALUES (1, N'Lib Gomper', N'Km 5  Distrito VII, Managua ', N'78236954', 1)
INSERT [dbo].[proveedor] ([Id_Proveedor], [Nombre], [Dirección], [Telefono], [Estado]) VALUES (2, N'Lib Jardin', N' Km 4.5 carretera Norte, Managua', N'2264 8888', 1)
INSERT [dbo].[proveedor] ([Id_Proveedor], [Nombre], [Dirección], [Telefono], [Estado]) VALUES (3, N'Lib San Jerónimo', N'Masaya, Ave. Los Leones, Petronic 30 vrs. al Sur, Masaya', N'2522 4752', 1)
SET IDENTITY_INSERT [dbo].[proveedor] OFF
GO
SET IDENTITY_INSERT [dbo].[usuario] ON 

INSERT [dbo].[usuario] ([Id_Usuario], [Username], [Id_Rol_Usuario], [Estado]) VALUES (1, N'vendedor', NULL, 1)
INSERT [dbo].[usuario] ([Id_Usuario], [Username], [Id_Rol_Usuario], [Estado]) VALUES (2, N'seller', NULL, 1)
SET IDENTITY_INSERT [dbo].[usuario] OFF
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_proveedor] FOREIGN KEY([Id_Proveedor])
REFERENCES [dbo].[proveedor] ([Id_Proveedor])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_proveedor]
GO
ALTER TABLE [dbo].[detalle venta]  WITH CHECK ADD  CONSTRAINT [FK_detalle venta_venta1] FOREIGN KEY([Id_Venta])
REFERENCES [dbo].[venta] ([Id_Venta])
GO
ALTER TABLE [dbo].[detalle venta] CHECK CONSTRAINT [FK_detalle venta_venta1]
GO
ALTER TABLE [dbo].[detalle_compra]  WITH CHECK ADD  CONSTRAINT [FK_detalle_compra_Compra] FOREIGN KEY([Id_Compra])
REFERENCES [dbo].[Compra] ([Id_Compra])
GO
ALTER TABLE [dbo].[detalle_compra] CHECK CONSTRAINT [FK_detalle_compra_Compra]
GO
ALTER TABLE [dbo].[Marca]  WITH CHECK ADD  CONSTRAINT [FK_Detalle_Articulo_stock_articulos] FOREIGN KEY([IdMarca])
REFERENCES [dbo].[stock_articulos] ([Id_StockArticulo])
GO
ALTER TABLE [dbo].[Marca] CHECK CONSTRAINT [FK_Detalle_Articulo_stock_articulos]
GO
ALTER TABLE [dbo].[permisos_usuarios]  WITH CHECK ADD  CONSTRAINT [FK_permisos_usuarios_rol_usuario] FOREIGN KEY([Id_rol_usuario])
REFERENCES [dbo].[rol_usuario] ([Id_Rol_Usuario])
GO
ALTER TABLE [dbo].[permisos_usuarios] CHECK CONSTRAINT [FK_permisos_usuarios_rol_usuario]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_categoria] FOREIGN KEY([Id_Categoria])
REFERENCES [dbo].[categoria] ([Id_Categoria])
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_categoria]
GO
ALTER TABLE [dbo].[Producto_dañado]  WITH CHECK ADD  CONSTRAINT [FK_Producto_dañado_stock_articulos] FOREIGN KEY([Id_Articulo_D])
REFERENCES [dbo].[stock_articulos] ([Id_StockArticulo])
GO
ALTER TABLE [dbo].[Producto_dañado] CHECK CONSTRAINT [FK_Producto_dañado_stock_articulos]
GO
ALTER TABLE [dbo].[stock_articulos]  WITH CHECK ADD  CONSTRAINT [FK_articulos_producto] FOREIGN KEY([Id_Producto])
REFERENCES [dbo].[producto] ([Id_Producto])
GO
ALTER TABLE [dbo].[stock_articulos] CHECK CONSTRAINT [FK_articulos_producto]
GO
ALTER TABLE [dbo].[stock_articulos]  WITH CHECK ADD  CONSTRAINT [FK_stock_articulos_Compra] FOREIGN KEY([Id_Compra])
REFERENCES [dbo].[Compra] ([Id_Compra])
GO
ALTER TABLE [dbo].[stock_articulos] CHECK CONSTRAINT [FK_stock_articulos_Compra]
GO
ALTER TABLE [dbo].[stock_articulos]  WITH CHECK ADD  CONSTRAINT [FK_stock_bodega] FOREIGN KEY([Id_Bodega])
REFERENCES [dbo].[bodega] ([Id_Bodega])
GO
ALTER TABLE [dbo].[stock_articulos] CHECK CONSTRAINT [FK_stock_bodega]
GO
ALTER TABLE [dbo].[usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_rol_usuario] FOREIGN KEY([Id_Rol_Usuario])
REFERENCES [dbo].[rol_usuario] ([Id_Rol_Usuario])
ON UPDATE CASCADE
GO
ALTER TABLE [dbo].[usuario] CHECK CONSTRAINT [FK_usuario_rol_usuario]
GO
