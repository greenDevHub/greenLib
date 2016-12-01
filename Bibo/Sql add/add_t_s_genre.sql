use Bibo_Verwaltung
/****** Object:  Table [dbo].[t_s_genre]    Script Date: 03.11.2016 18:51:50 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_genre]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_genre]
GO

/****** Object:  Table [dbo].[t_s_genre]    Script Date: 03.11.2016 18:51:50 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_genre]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_genre](
	[ger_id] [numeric](18, 0) IDENTITY(1,1) NOT NULL,
	[ger_bez] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_t_s_genre] PRIMARY KEY CLUSTERED 
(
	[ger_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO


