USE [master]
GO
/****** Object:  Database [simpleshopmanagement]    Script Date: 4/29/2021 10:23:18 PM ******/
CREATE DATABASE [simpleshopmanagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'simpleshopmanagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\simpleshopmanagement.mdf' , SIZE = 51200KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'simpleshopmanagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\simpleshopmanagement_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [simpleshopmanagement] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [simpleshopmanagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [simpleshopmanagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [simpleshopmanagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [simpleshopmanagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [simpleshopmanagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET  DISABLE_BROKER 
GO
ALTER DATABASE [simpleshopmanagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [simpleshopmanagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [simpleshopmanagement] SET  MULTI_USER 
GO
ALTER DATABASE [simpleshopmanagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [simpleshopmanagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [simpleshopmanagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [simpleshopmanagement] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [simpleshopmanagement]
GO
/****** Object:  Table [dbo].[OrderTbl]    Script Date: 4/29/2021 10:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrderTbl](
	[orderid] [int] IDENTITY(1,1) NOT NULL,
	[uname] [varchar](50) NOT NULL,
	[customername] [varchar](50) NOT NULL,
	[amount] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[orderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ProductTbl]    Script Date: 4/29/2021 10:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ProductTbl](
	[pid] [int] IDENTITY(1,1) NOT NULL,
	[pName] [varchar](50) NOT NULL,
	[pCat] [varchar](50) NOT NULL,
	[pQty] [int] NOT NULL,
	[pPrice] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[pid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SalesmanTbl]    Script Date: 4/29/2021 10:23:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SalesmanTbl](
	[uid] [int] IDENTITY(500,1) NOT NULL,
	[uname] [varchar](50) NOT NULL,
	[uphone] [varchar](50) NOT NULL,
	[uadd] [varchar](50) NOT NULL,
	[upass] [varchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[uid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
USE [master]
GO
ALTER DATABASE [simpleshopmanagement] SET  READ_WRITE 
GO
