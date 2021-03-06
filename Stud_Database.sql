USE [master]
GO
/****** Object:  Database [Stud_Database]    Script Date: 18/05/2022 4:15:18 pm ******/
CREATE DATABASE [Stud_Database]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Stud_Database', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Stud_Database.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Stud_Database_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\Stud_Database.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Stud_Database] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Stud_Database].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Stud_Database] SET ANSI_NULL_DEFAULT ON 
GO
ALTER DATABASE [Stud_Database] SET ANSI_NULLS ON 
GO
ALTER DATABASE [Stud_Database] SET ANSI_PADDING ON 
GO
ALTER DATABASE [Stud_Database] SET ANSI_WARNINGS ON 
GO
ALTER DATABASE [Stud_Database] SET ARITHABORT ON 
GO
ALTER DATABASE [Stud_Database] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Stud_Database] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Stud_Database] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Stud_Database] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Stud_Database] SET CURSOR_DEFAULT  LOCAL 
GO
ALTER DATABASE [Stud_Database] SET CONCAT_NULL_YIELDS_NULL ON 
GO
ALTER DATABASE [Stud_Database] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Stud_Database] SET QUOTED_IDENTIFIER ON 
GO
ALTER DATABASE [Stud_Database] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Stud_Database] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Stud_Database] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Stud_Database] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Stud_Database] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Stud_Database] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Stud_Database] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Stud_Database] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Stud_Database] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Stud_Database] SET RECOVERY FULL 
GO
ALTER DATABASE [Stud_Database] SET  MULTI_USER 
GO
ALTER DATABASE [Stud_Database] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Stud_Database] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Stud_Database] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Stud_Database] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Stud_Database] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Stud_Database] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Stud_Database] SET QUERY_STORE = OFF
GO
USE [Stud_Database]
GO
/****** Object:  Table [dbo].[Course_Details]    Script Date: 18/05/2022 4:15:19 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Course_Details](
	[Course_Id] [int] IDENTITY(1,1) NOT NULL,
	[Course_Name] [varchar](50) NULL,
 CONSTRAINT [PK__Course_D__37E005DBF19D4F42] PRIMARY KEY CLUSTERED 
(
	[Course_Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student_Info]    Script Date: 18/05/2022 4:15:19 pm ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student_Info](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Mobile] [varchar](10) NULL,
	[Email] [varchar](50) NULL,
	[Course_ID] [int] NULL,
 CONSTRAINT [PK__Student___3214EC07D6D3BE00] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Course_Details] ON 

INSERT [dbo].[Course_Details] ([Course_Id], [Course_Name]) VALUES (1, N'L5-IS')
INSERT [dbo].[Course_Details] ([Course_Id], [Course_Name]) VALUES (2, N'L6-SD')
INSERT [dbo].[Course_Details] ([Course_Id], [Course_Name]) VALUES (3, N'L5-ITTS')
INSERT [dbo].[Course_Details] ([Course_Id], [Course_Name]) VALUES (4, N'L6-SA')
SET IDENTITY_INSERT [dbo].[Course_Details] OFF
GO
SET IDENTITY_INSERT [dbo].[Student_Info] ON 

INSERT [dbo].[Student_Info] ([Id], [Name], [Mobile], [Email], [Course_ID]) VALUES (1, N'Jatinder', N'258963258', N'Jatinder@Techtorium.ac.nz', 3)
INSERT [dbo].[Student_Info] ([Id], [Name], [Mobile], [Email], [Course_ID]) VALUES (2, N'Beer', N'258741258', N'Beer@Techtorium.ac.nz', 2)
INSERT [dbo].[Student_Info] ([Id], [Name], [Mobile], [Email], [Course_ID]) VALUES (3, N'Rashmi', N'741258963', N'Rashmi@techtorium.ac.nz', 3)
INSERT [dbo].[Student_Info] ([Id], [Name], [Mobile], [Email], [Course_ID]) VALUES (4, N'Jati', N'2589632587', N'jati@gmail.com', 1)
INSERT [dbo].[Student_Info] ([Id], [Name], [Mobile], [Email], [Course_ID]) VALUES (6, N'Ram', N'456987899', N'Ram@gmail.com', 4)
INSERT [dbo].[Student_Info] ([Id], [Name], [Mobile], [Email], [Course_ID]) VALUES (7, N'Shar', N'147852369', N'Shar', 2)
INSERT [dbo].[Student_Info] ([Id], [Name], [Mobile], [Email], [Course_ID]) VALUES (8, N'Shar', N'147852369', N'Shar', 2)
INSERT [dbo].[Student_Info] ([Id], [Name], [Mobile], [Email], [Course_ID]) VALUES (9, N'Ram', N'456987899', N'Ram@gmail.com', 4)
SET IDENTITY_INSERT [dbo].[Student_Info] OFF
GO
ALTER TABLE [dbo].[Student_Info]  WITH CHECK ADD  CONSTRAINT [FK_Student_Info_Course_Details] FOREIGN KEY([Course_ID])
REFERENCES [dbo].[Course_Details] ([Course_Id])
GO
ALTER TABLE [dbo].[Student_Info] CHECK CONSTRAINT [FK_Student_Info_Course_Details]
GO
USE [master]
GO
ALTER DATABASE [Stud_Database] SET  READ_WRITE 
GO
