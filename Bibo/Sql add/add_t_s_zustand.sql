use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_zustand]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_zustand]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_zustand]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_zustand](
	[zu_id] [int] NOT NULL,
	[zu_zustand] [nvarchar](128) NOT NULL,
	[zu_verleihf�hig] [nvarchar](16) NOT NULL,
	PRIMARY KEY (zu_id))
	INSERT INTO t_s_zustand (zu_id, zu_zustand, zu_verleihf�hig) VALUES (1, 'neuwertig', 'ja')
	INSERT INTO t_s_zustand (zu_id, zu_zustand, zu_verleihf�hig) VALUES (2, 'gut', 'ja')
	INSERT INTO t_s_zustand (zu_id, zu_zustand, zu_verleihf�hig) VALUES (3, 'gebraucht', 'ja')
	INSERT INTO t_s_zustand (zu_id, zu_zustand, zu_verleihf�hig) VALUES (4, 'besch�digt', 'nein')
	Select * from t_s_zustand
	END
