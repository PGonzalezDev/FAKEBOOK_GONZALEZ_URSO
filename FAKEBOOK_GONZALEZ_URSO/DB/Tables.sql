USE [FAKEBOOK_DB]
GO

/****** Object:  Table [dbo].[User]    Script Date: 11/14/2014 19:24:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF  EXISTS (SELECT name FROM sys.tables WHERE name = N'User')
	DROP TABLE [dbo].[User];
GO
IF  EXISTS (SELECT name FROM sys.tables WHERE name = N'Publication')
	DROP TABLE [dbo].[Publication];
GO

CREATE TABLE [dbo].[User](
	[Id] [int] IDENTITY PRIMARY KEY,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](300) NOT NULL
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[Publication](
	[Id] [int] IDENTITY PRIMARY KEY,
	[UserId] [int] NOT NULL,
	[Txt] [nvarchar](500) NOT NULL,
	[Img] [nvarchar](MAX) NOT NULL,
	[Date_Time] [DateTime] NOT NULL
) ON [PRIMARY]

GO


INSERT INTO [FAKEBOOK_DB].[dbo].[User]([FirstName],[LastName],[Email],[Password])
VALUES(N'Esteban',N'Urso',N'a@a.com',N'9DA272CEC373F0A07480EE236E13FAA4')
GO

