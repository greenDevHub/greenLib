use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_sprache]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_sprache]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_sprache]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_sprache](
	[sprach_id] [int] IDENTITY (1,1) NOT NULL,
	[sprach_name][nvarchar] (128) NOT NULL,
	PRIMARY KEY (sprach_id))
	INSERT INTO t_s_sprache (sprach_name) VALUES ('Deutsch')
	INSERT INTO t_s_sprache (sprach_name) VALUES ('Englisch')
	Select * from t_s_sprache
	END