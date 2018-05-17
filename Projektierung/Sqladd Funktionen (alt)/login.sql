use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_benutzer]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_benutzer]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_benutzer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_benutzer](
	[b_name] [nvarchar] (128) NOT NULL,
	[b_password] [varbinary] (max) NOT NULL,
	PRIMARY KEY (b_name))
	Insert INTO t_s_benutzer (b_name, b_password) 
	VALUES ('Laurenz', CAST('123' AS VARBINARY(MAX)))
	END