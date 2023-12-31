USE [master]
GO
/****** Object:  Database [ambulance]    Script Date: 18.10.2023 16:11:48 ******/
CREATE DATABASE [ambulance]
GO
ALTER DATABASE [ambulance] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [ambulance].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [ambulance] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [ambulance] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [ambulance] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [ambulance] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [ambulance] SET ARITHABORT OFF 
GO
ALTER DATABASE [ambulance] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [ambulance] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [ambulance] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [ambulance] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [ambulance] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [ambulance] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [ambulance] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [ambulance] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [ambulance] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [ambulance] SET  DISABLE_BROKER 
GO
ALTER DATABASE [ambulance] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [ambulance] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [ambulance] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [ambulance] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [ambulance] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [ambulance] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [ambulance] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [ambulance] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [ambulance] SET  MULTI_USER 
GO
ALTER DATABASE [ambulance] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [ambulance] SET DB_CHAINING OFF 
GO
ALTER DATABASE [ambulance] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [ambulance] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [ambulance] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [ambulance] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [ambulance] SET QUERY_STORE = OFF
GO
USE [ambulance]
GO
/****** Object:  Table [dbo].[Actions]    Script Date: 18.10.2023 16:11:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Actions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Description_actions] [nvarchar](1000) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brigades]    Script Date: 18.10.2023 16:11:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brigades](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[ID_specialization] [int] NOT NULL,
	[ID_actions] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Calls]    Script Date: 18.10.2023 16:11:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Calls](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ID_brigade] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Time] [time](7) NOT NULL,
	[Address] [nvarchar](50) NOT NULL,
	[ID_patient] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Patients]    Script Date: 18.10.2023 16:11:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patients](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Surname] [nchar](20) NOT NULL,
	[Name] [nchar](20) NOT NULL,
	[Lastname] [nchar](20) NULL,
	[Date_of_birth] [date] NOT NULL,
	[Sex] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Specializations]    Script Date: 18.10.2023 16:11:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Specializations](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nchar](20) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Actions] ON 

INSERT [dbo].[Actions] ([ID], [Description_actions]) VALUES (1, N'Реанимационная деятельность')
INSERT [dbo].[Actions] ([ID], [Description_actions]) VALUES (2, N'Диагностирование заболевания или травмы, требующей стационарного лечения')
INSERT [dbo].[Actions] ([ID], [Description_actions]) VALUES (3, N'Диагностирование заболевания, подразумевающего амбулаторное лечение')
SET IDENTITY_INSERT [dbo].[Actions] OFF
GO
SET IDENTITY_INSERT [dbo].[Brigades] ON 

INSERT [dbo].[Brigades] ([ID], [Number], [ID_specialization], [ID_actions]) VALUES (2, 960, 1, 1)
INSERT [dbo].[Brigades] ([ID], [Number], [ID_specialization], [ID_actions]) VALUES (3, 356, 2, 2)
INSERT [dbo].[Brigades] ([ID], [Number], [ID_specialization], [ID_actions]) VALUES (4, 127, 3, 3)
SET IDENTITY_INSERT [dbo].[Brigades] OFF
GO
SET IDENTITY_INSERT [dbo].[Calls] ON 

INSERT [dbo].[Calls] ([ID], [ID_brigade], [Date], [Time], [Address], [ID_patient]) VALUES (1, 1, CAST(N'2023-07-20' AS Date), CAST(N'14:40:00' AS Time), N'Коменданский 23, кв560', 3)
INSERT [dbo].[Calls] ([ID], [ID_brigade], [Date], [Time], [Address], [ID_patient]) VALUES (3, 2, CAST(N'2023-08-02' AS Date), CAST(N'10:00:00' AS Time), N'Арцеуловская 17, кв795', 2)
INSERT [dbo].[Calls] ([ID], [ID_brigade], [Date], [Time], [Address], [ID_patient]) VALUES (5, 2, CAST(N'2023-06-13' AS Date), CAST(N'20:30:00' AS Time), N'Лидии Зверевой 5, 23', 1)
INSERT [dbo].[Calls] ([ID], [ID_brigade], [Date], [Time], [Address], [ID_patient]) VALUES (6, 3, CAST(N'0203-05-01' AS Date), CAST(N'18:20:00' AS Time), N'Комендантский 32, 652', 6)
INSERT [dbo].[Calls] ([ID], [ID_brigade], [Date], [Time], [Address], [ID_patient]) VALUES (8, 3, CAST(N'2023-09-08' AS Date), CAST(N'12:30:00' AS Time), N'Арцеуловская аллея 23к1стр1, 349', 4)
INSERT [dbo].[Calls] ([ID], [ID_brigade], [Date], [Time], [Address], [ID_patient]) VALUES (9, 2, CAST(N'2023-10-03' AS Date), CAST(N'16:58:00' AS Time), N'Глухарская 13, 76', 5)
SET IDENTITY_INSERT [dbo].[Calls] OFF
GO
SET IDENTITY_INSERT [dbo].[Patients] ON 

INSERT [dbo].[Patients] ([ID], [Surname], [Name], [Lastname], [Date_of_birth], [Sex]) VALUES (1, N'Федорова            ', N'Варвара             ', N'Максимовна          ', CAST(N'2005-09-04' AS Date), N'Ж         ')
INSERT [dbo].[Patients] ([ID], [Surname], [Name], [Lastname], [Date_of_birth], [Sex]) VALUES (2, N'Прудова             ', N'Виктория            ', N'Андреевна           ', CAST(N'2005-12-29' AS Date), N'Ж         ')
INSERT [dbo].[Patients] ([ID], [Surname], [Name], [Lastname], [Date_of_birth], [Sex]) VALUES (3, N'Поливчак            ', N'Алена               ', N'Олеговна            ', CAST(N'2004-09-27' AS Date), N'Ж         ')
INSERT [dbo].[Patients] ([ID], [Surname], [Name], [Lastname], [Date_of_birth], [Sex]) VALUES (4, N'Карплюк             ', N'Иван                ', N'Михайлович          ', CAST(N'2005-05-23' AS Date), N'М         ')
INSERT [dbo].[Patients] ([ID], [Surname], [Name], [Lastname], [Date_of_birth], [Sex]) VALUES (5, N'Кутявин             ', N'Артем               ', N'Юрьевич             ', CAST(N'2005-03-14' AS Date), N'М         ')
INSERT [dbo].[Patients] ([ID], [Surname], [Name], [Lastname], [Date_of_birth], [Sex]) VALUES (6, N'Голов               ', N'Данила              ', N'Ильич               ', CAST(N'2005-07-30' AS Date), N'М         ')
SET IDENTITY_INSERT [dbo].[Patients] OFF
GO
SET IDENTITY_INSERT [dbo].[Specializations] ON 

INSERT [dbo].[Specializations] ([ID], [Title]) VALUES (1, N'Реанимация          ')
INSERT [dbo].[Specializations] ([ID], [Title]) VALUES (2, N'Госпитализация      ')
INSERT [dbo].[Specializations] ([ID], [Title]) VALUES (3, N'Врач терапевт       ')
SET IDENTITY_INSERT [dbo].[Specializations] OFF
GO
USE [master]
GO
ALTER DATABASE [ambulance] SET  READ_WRITE 
GO
