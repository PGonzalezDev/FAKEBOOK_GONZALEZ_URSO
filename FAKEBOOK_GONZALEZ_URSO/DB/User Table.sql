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

CREATE TABLE [dbo].[User](
	[Id] [int] NOT NULL,
	[FirstName] [nvarchar](20) NOT NULL,
	[LastName] [nvarchar](20) NULL,
	[Email] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](300) NOT NULL,
	CONSTRAINT [Id] PRIMARY KEY CLUSTERED 
	(
		[Id] ASC
	)
) ON [PRIMARY]

GO


INSERT INTO [FAKEBOOK_DB].[dbo].[User]([Id],[FirstName],[LastName],[Email],[Password])
VALUES(1,N'Esteban',N'Urso',N'a@a.com',N'9DA272CEC373F0A07480EE236E13FAA4')
GO

