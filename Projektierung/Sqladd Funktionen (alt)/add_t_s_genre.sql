use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_genre]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_genre]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_genre]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_genre](
	[ger_id] [int] IDENTITY (1,1) NOT NULL,
	[ger_name] [nvarchar] (128) NOT NULL,
	PRIMARY KEY (ger_id))
	INSERT INTO t_s_genre (ger_name) VALUES ('Sachbuch')
	INSERT INTO t_s_genre (ger_name) VALUES ('Roman')
	INSERT INTO t_s_genre (ger_name) VALUES ('Fantasy')
	Select * from t_s_genre
	END