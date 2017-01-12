use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_autor]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_autor]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_autor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_autor](
	[au_id] [int] IDENTITY (1,1) NOT NULL,
	[au_autor] [nvarchar] (128) NOT NULL,
	PRIMARY KEY (au_id))
	INSERT into t_s_autor (au_autor) VALUES ('J.R.R. Tolkien')
	Select * from t_s_autor
	END