USE [master]
GO

/****** Object:  Database [FAKEBOOK_DB]    Script Date: 11/22/2014 20:34:04 ******/
CREATE DATABASE [FAKEBOOK_DB] ON  PRIMARY 
( NAME = N'FAKEBOOK_DB', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\FAKEBOOK_DB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FAKEBOOK_DB_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10_50.SQLEXPRESS\MSSQL\DATA\FAKEBOOK_DB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [FAKEBOOK_DB] SET COMPATIBILITY_LEVEL = 100
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FAKEBOOK_DB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [FAKEBOOK_DB] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET ARITHABORT OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET AUTO_CLOSE ON 
GO

ALTER DATABASE [FAKEBOOK_DB] SET AUTO_CREATE_STATISTICS ON 
GO

ALTER DATABASE [FAKEBOOK_DB] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [FAKEBOOK_DB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [FAKEBOOK_DB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET  ENABLE_BROKER 
GO

ALTER DATABASE [FAKEBOOK_DB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [FAKEBOOK_DB] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [FAKEBOOK_DB] SET  READ_WRITE 
GO

ALTER DATABASE [FAKEBOOK_DB] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [FAKEBOOK_DB] SET  MULTI_USER 
GO

ALTER DATABASE [FAKEBOOK_DB] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [FAKEBOOK_DB] SET DB_CHAINING OFF 
GO


