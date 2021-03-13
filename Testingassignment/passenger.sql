USE [master]
GO
/****** Object:  Database [passenger ]    Script Date: 03-03-2021 11:51:07 ******/
CREATE DATABASE [passenger ]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Passanger', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\Passanger.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Passanger_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS01\MSSQL\DATA\Passanger_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [passenger ] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [passenger ].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [passenger ] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [passenger ] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [passenger ] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [passenger ] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [passenger ] SET ARITHABORT OFF 
GO
ALTER DATABASE [passenger ] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [passenger ] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [passenger ] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [passenger ] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [passenger ] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [passenger ] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [passenger ] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [passenger ] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [passenger ] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [passenger ] SET  DISABLE_BROKER 
GO
ALTER DATABASE [passenger ] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [passenger ] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [passenger ] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [passenger ] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [passenger ] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [passenger ] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [passenger ] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [passenger ] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [passenger ] SET  MULTI_USER 
GO
ALTER DATABASE [passenger ] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [passenger ] SET DB_CHAINING OFF 
GO
ALTER DATABASE [passenger ] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [passenger ] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [passenger ] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [passenger ] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [passenger ] SET QUERY_STORE = OFF
GO
USE [passenger ]
GO
/****** Object:  Table [dbo].[passe_test]    Script Date: 03-03-2021 11:51:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[passe_test](
	[Passenger_number] [int] IDENTITY(1,1) NOT NULL,
	[Firstname] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Phonenumber] [nvarchar](15) NOT NULL,
 CONSTRAINT [PK_passe_test] PRIMARY KEY CLUSTERED 
(
	[Passenger_number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [passenger ] SET  READ_WRITE 
GO
