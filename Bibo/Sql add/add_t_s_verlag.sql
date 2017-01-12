use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_verlag]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_verlag]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_verlag]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_verlag](
	[ver_id] [int] IDENTITY (1,1) NOT NULL,
	[ver_name] [nvarchar] (128) NOT NULL,
	PRIMARY KEY (ver_id))
	Insert INTO t_s_verlag (ver_name) VALUES ('Klett-Cotta')
	INSERT INTO t_s_verlag (ver_name) VALUES ('dtv Verlagsgesellschaft')
	Select * from t_s_verlag
	END
