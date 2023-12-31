USE [master]
GO
/****** Object:  Database [TOPUPWEB]    Script Date: 12/20/2023 1:07:46 AM ******/
CREATE DATABASE [TOPUPWEB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TOPUPWEB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.ELIOT\MSSQL\DATA\TOPUPWEB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TOPUPWEB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.ELIOT\MSSQL\DATA\TOPUPWEB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TOPUPWEB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TOPUPWEB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TOPUPWEB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TOPUPWEB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TOPUPWEB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TOPUPWEB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TOPUPWEB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TOPUPWEB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TOPUPWEB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TOPUPWEB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TOPUPWEB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TOPUPWEB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TOPUPWEB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TOPUPWEB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TOPUPWEB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TOPUPWEB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TOPUPWEB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TOPUPWEB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TOPUPWEB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TOPUPWEB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TOPUPWEB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TOPUPWEB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TOPUPWEB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TOPUPWEB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TOPUPWEB] SET RECOVERY FULL 
GO
ALTER DATABASE [TOPUPWEB] SET  MULTI_USER 
GO
ALTER DATABASE [TOPUPWEB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TOPUPWEB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TOPUPWEB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TOPUPWEB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TOPUPWEB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TOPUPWEB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TOPUPWEB', N'ON'
GO
ALTER DATABASE [TOPUPWEB] SET QUERY_STORE = ON
GO
ALTER DATABASE [TOPUPWEB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TOPUPWEB]
GO
/****** Object:  Table [dbo].[ITRANSACTION]    Script Date: 12/20/2023 1:07:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ITRANSACTION](
	[TID] [int] IDENTITY(30000000,1) NOT NULL,
	[IUID] [int] NULL,
	[PURCHASEID] [int] NULL,
	[PAYDATE] [date] NOT NULL,
	[TOTAL] [real] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IUSER]    Script Date: 12/20/2023 1:07:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IUSER](
	[IUID] [int] IDENTITY(40000000,1) NOT NULL,
	[USERNAME] [varchar](20) NOT NULL,
	[IPASSWORD] [varchar](20) NOT NULL,
	[IEMAIL] [varchar](50) NOT NULL,
 CONSTRAINT [PK__IUSER__44F173D8A8D51CDF] PRIMARY KEY CLUSTERED 
(
	[IUID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PRODUCT]    Script Date: 12/20/2023 1:07:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PRODUCT](
	[PRODUCTID] [int] IDENTITY(20000000,1) NOT NULL,
	[PNAME] [nvarchar](50) NOT NULL,
	[PRICE] [real] NOT NULL,
	[PIMAGE] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[PRODUCTID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PURCHASE]    Script Date: 12/20/2023 1:07:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PURCHASE](
	[PURCHASEID] [int] IDENTITY(10000000,1) NOT NULL,
	[PRODUCTID] [int] NULL,
	[QUANTITY] [int] NOT NULL,
	[PRICE] [real] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PURCHASEID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[IUSER] ON 

INSERT [dbo].[IUSER] ([IUID], [USERNAME], [IPASSWORD], [IEMAIL]) VALUES (40000000, N'demo', N'demo', N'nnn@em.com')
INSERT [dbo].[IUSER] ([IUID], [USERNAME], [IPASSWORD], [IEMAIL]) VALUES (40000001, N'aaa', N'aaa', N'aaa')
INSERT [dbo].[IUSER] ([IUID], [USERNAME], [IPASSWORD], [IEMAIL]) VALUES (40000002, N'bbb', N'bbb', N'bbb')
INSERT [dbo].[IUSER] ([IUID], [USERNAME], [IPASSWORD], [IEMAIL]) VALUES (40001001, N'bbb', N'bbb', N'bbb@gmail.com')
INSERT [dbo].[IUSER] ([IUID], [USERNAME], [IPASSWORD], [IEMAIL]) VALUES (40001002, N'', N'', N'')
INSERT [dbo].[IUSER] ([IUID], [USERNAME], [IPASSWORD], [IEMAIL]) VALUES (40001003, N'aaa', N'aaa', N'aaa')
INSERT [dbo].[IUSER] ([IUID], [USERNAME], [IPASSWORD], [IEMAIL]) VALUES (40001004, N'', N'', N'')
SET IDENTITY_INSERT [dbo].[IUSER] OFF
GO
ALTER TABLE [dbo].[ITRANSACTION]  WITH CHECK ADD  CONSTRAINT [FK_ITRANSACTION_IUSER] FOREIGN KEY([IUID])
REFERENCES [dbo].[IUSER] ([IUID])
GO
ALTER TABLE [dbo].[ITRANSACTION] CHECK CONSTRAINT [FK_ITRANSACTION_IUSER]
GO
ALTER TABLE [dbo].[ITRANSACTION]  WITH CHECK ADD  CONSTRAINT [FK_ITRANSACTION_PURCHASE] FOREIGN KEY([PURCHASEID])
REFERENCES [dbo].[PURCHASE] ([PURCHASEID])
GO
ALTER TABLE [dbo].[ITRANSACTION] CHECK CONSTRAINT [FK_ITRANSACTION_PURCHASE]
GO
ALTER TABLE [dbo].[PURCHASE]  WITH CHECK ADD  CONSTRAINT [FK_PURCHASE_PRODUCT] FOREIGN KEY([PRODUCTID])
REFERENCES [dbo].[PRODUCT] ([PRODUCTID])
GO
ALTER TABLE [dbo].[PURCHASE] CHECK CONSTRAINT [FK_PURCHASE_PRODUCT]
GO
/****** Object:  StoredProcedure [dbo].[dbLogIn]    Script Date: 12/20/2023 1:07:46 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[dbLogIn] (@Username varchar(20), @Password varchar(20), @Check varchar(10) OUTPUT) 
as
if exists (select * from IUSER where USERNAME = @Username and IPASSWORD = @Password) 
set @Check = 'true'
else 
set @Check = 'false'
GO
USE [master]
GO
ALTER DATABASE [TOPUPWEB] SET  READ_WRITE 
GO
