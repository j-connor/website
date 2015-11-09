USE [MyWebsite]
GO

/****** Object:  Table [dbo].[CarouselResource]    Script Date: 11/8/2015 10:52:28 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[CarouselResource](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](100) NULL,
	[LinkText] [varchar](100) NULL,
	[ImgSrc] [varchar](100) NULL,
	[Ordinal] [int] NULL,
	[Active] [bit] NOT NULL,
	[ResourceDate] [datetime] NULL,
	[LinkUrl] [varchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO


