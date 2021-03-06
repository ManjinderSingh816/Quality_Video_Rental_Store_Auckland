USE [master]
GO
/****** Object:  Database [Quality_Video_Rental_Store_Auckland]    Script Date: 30-07-2021 2.14.32 AM ******/
CREATE DATABASE [Quality_Video_Rental_Store_Auckland]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Quality_Video_Rental_Store_Auckland_Database_Data', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Quality_Video_Rental_Store_Auckland_Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Quality_Video_Rental_Store_Auckland_Database_Log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Quality_Video_Rental_Store_Auckland_Database.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Quality_Video_Rental_Store_Auckland].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET ARITHABORT OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET  MULTI_USER 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Quality_Video_Rental_Store_Auckland', N'ON'
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET QUERY_STORE = OFF
GO
USE [Quality_Video_Rental_Store_Auckland]
GO
/****** Object:  Table [dbo].[tdCustomers]    Script Date: 30-07-2021 2.14.32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tdCustomers](
	[CstId] [int] IDENTITY(1,1) NOT NULL,
	[CstName] [nvarchar](50) NULL,
	[CstContact] [nvarchar](50) NULL,
	[CstAddress] [nvarchar](50) NULL,
	[CstAge] [nvarchar](50) NULL,
	[CstGender] [nvarchar](50) NULL,
	[CstIdentification] [nvarchar](50) NULL,
 CONSTRAINT [PK_tdCustomers] PRIMARY KEY CLUSTERED 
(
	[CstId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tdRentals]    Script Date: 30-07-2021 2.14.32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tdRentals](
	[RtId] [int] IDENTITY(1,1) NOT NULL,
	[CstId] [int] NULL,
	[VdId] [int] NULL,
	[RtIssueDate] [nvarchar](50) NULL,
	[RtReturnDate] [nvarchar](50) NULL,
 CONSTRAINT [PK_tdRentals] PRIMARY KEY CLUSTERED 
(
	[RtId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tdVideos]    Script Date: 30-07-2021 2.14.32 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tdVideos](
	[VdId] [int] IDENTITY(1,1) NOT NULL,
	[VdTitle] [nvarchar](50) NULL,
	[VdRating] [nvarchar](50) NULL,
	[VdYear] [nvarchar](50) NULL,
	[VdCost] [nvarchar](50) NULL,
	[VdNumberOfCopies] [nvarchar](50) NULL,
	[VdPlot] [nvarchar](50) NULL,
	[VdGenre] [nvarchar](50) NULL,
 CONSTRAINT [PK_tdVideos] PRIMARY KEY CLUSTERED 
(
	[VdId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tdCustomers] ON 

INSERT [dbo].[tdCustomers] ([CstId], [CstName], [CstContact], [CstAddress], [CstAge], [CstGender], [CstIdentification]) VALUES (1006, N'John', N'64974656', N'Auckland', N'25', N'Male', N'None')
SET IDENTITY_INSERT [dbo].[tdCustomers] OFF
GO
SET IDENTITY_INSERT [dbo].[tdRentals] ON 

INSERT [dbo].[tdRentals] ([RtId], [CstId], [VdId], [RtIssueDate], [RtReturnDate]) VALUES (1003, 1006, 9, N'18-07-2021', N'18-07-2021')
SET IDENTITY_INSERT [dbo].[tdRentals] OFF
GO
SET IDENTITY_INSERT [dbo].[tdVideos] ON 

INSERT [dbo].[tdVideos] ([VdId], [VdTitle], [VdRating], [VdYear], [VdCost], [VdNumberOfCopies], [VdPlot], [VdGenre]) VALUES (9, N'Krish', N'5', N'2020', N'5', N'2', N'Desi', N'Moives')
SET IDENTITY_INSERT [dbo].[tdVideos] OFF
GO
USE [master]
GO
ALTER DATABASE [Quality_Video_Rental_Store_Auckland] SET  READ_WRITE 
GO
