USE [HOTEL]
GO
/****** Object:  Table [dbo].[TIPOSDOCUMENTOS]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TIPOSDOCUMENTOS](
	[id_tipo_doc] [nvarchar](50) NOT NULL,
	[nombre_tipo] [nvarchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERVICIOXHOTEL]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICIOXHOTEL](
	[id_hotel] [nvarchar](50) NOT NULL,
	[id_servicio] [nvarchar](50) NOT NULL,
	[costo] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SERVICIOXHOTEL] PRIMARY KEY CLUSTERED 
(
	[id_hotel] ASC,
	[id_servicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SERVICIOS]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SERVICIOS](
	[id_servicio] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](80) NOT NULL,
 CONSTRAINT [PK_SERVICIOS] PRIMARY KEY CLUSTERED 
(
	[id_servicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PUESTOS]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PUESTOS](
	[id_puesto] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PUESTOS] PRIMARY KEY CLUSTERED 
(
	[id_puesto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INSTALACIONXHOTEL]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INSTALACIONXHOTEL](
	[id_instalacion] [nvarchar](50) NOT NULL,
	[id_hotel] [nvarchar](50) NOT NULL,
	[disponible] [int] NOT NULL,
 CONSTRAINT [PK_INSTALACIONXHOTEL] PRIMARY KEY CLUSTERED 
(
	[id_instalacion] ASC,
	[id_hotel] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[INSTALACIONES]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[INSTALACIONES](
	[id_instalacion] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_INSTALACIONES] PRIMARY KEY CLUSTERED 
(
	[id_instalacion] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HUESPEDXSERVICIO]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HUESPEDXSERVICIO](
	[id_habitacion] [nvarchar](50) NOT NULL,
	[pasaporte] [nvarchar](50) NOT NULL,
	[fecha_servicio] [date] NOT NULL,
	[fecha_alojamiento] [nvarchar](50) NOT NULL,
	[id_empleado] [nvarchar](50) NOT NULL,
	[id_servicio] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HUESPEDXSERVICIO] PRIMARY KEY CLUSTERED 
(
	[pasaporte] ASC,
	[fecha_servicio] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HUESPEDXINSTALACION]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HUESPEDXINSTALACION](
	[id_habitacion] [nvarchar](50) NOT NULL,
	[fecha_alojamiento] [nvarchar](50) NOT NULL,
	[id_instalacion] [nvarchar](50) NOT NULL,
	[pasaporte] [nvarchar](50) NOT NULL,
	[fecha_hora_uso] [date] NOT NULL,
 CONSTRAINT [PK_HUESPEDXINSTALACION] PRIMARY KEY CLUSTERED 
(
	[pasaporte] ASC,
	[fecha_hora_uso] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HUESPEDXHABITACION]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HUESPEDXHABITACION](
	[id_habitacion] [nvarchar](50) NOT NULL,
	[pasaporte] [nvarchar](50) NOT NULL,
	[fecha_alojamiento] [date] NOT NULL,
 CONSTRAINT [PK_HUESPEDXHABITACION] PRIMARY KEY CLUSTERED 
(
	[id_habitacion] ASC,
	[pasaporte] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HUESPEDES]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HUESPEDES](
	[tipo_doc] [nvarchar](50) NOT NULL,
	[num_doc] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[ciudad] [nvarchar](50) NOT NULL,
	[numero_tarjeta] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HUESPEDES] PRIMARY KEY CLUSTERED 
(
	[tipo_doc] ASC,
	[num_doc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HOTELES]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HOTELES](
	[id_hotel] [nvarchar](50) NOT NULL,
	[nombre_hotel] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HOTELES] PRIMARY KEY CLUSTERED 
(
	[id_hotel] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HABITACIONXHOTEL]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HABITACIONXHOTEL](
	[id_habitacion] [nvarchar](50) NOT NULL,
	[id_hotel] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_HABITACIONXHOTEL] PRIMARY KEY CLUSTERED 
(
	[id_habitacion] ASC,
	[id_hotel] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HABITACIONES]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[HABITACIONES](
	[id_habitacion] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[descripcion] [varchar](50) NOT NULL,
	[disponible] [int] NOT NULL,
	[id_hotel] [varchar](50) NOT NULL,
 CONSTRAINT [PK_HABITACIONES] PRIMARY KEY CLUSTERED 
(
	[id_habitacion] ASC,
	[nombre] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FACTURAS]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FACTURAS](
	[numero_factura] [nchar](10) NOT NULL,
	[fecha] [date] NOT NULL,
 CONSTRAINT [PK_FACTURAS] PRIMARY KEY CLUSTERED 
(
	[numero_factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EMPLEADOS]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EMPLEADOS](
	[apellido] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[fecha_ingreso] [date] NOT NULL,
	[id_hotel] [nvarchar](50) NOT NULL,
	[tipo_doc] [nvarchar](50) NOT NULL,
	[num_doc] [nvarchar](50) NOT NULL,
	[id_puesto] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_EMPLEADOS] PRIMARY KEY CLUSTERED 
(
	[num_doc] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DETALLES_FACTURAS]    Script Date: 10/02/2018 05:57:55 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DETALLES_FACTURAS](
	[numero_detalle] [nvarchar](50) NOT NULL,
	[id_habitacion] [nvarchar](50) NOT NULL,
	[id_servicio] [nvarchar](50) NOT NULL,
	[costo_servicio] [nvarchar](50) NOT NULL,
	[costo_habitacion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_DETALLES_FACTURAS] PRIMARY KEY CLUSTERED 
(
	[numero_detalle] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
