use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_bestand]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_bestand]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_bestand]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_bestand](
	[bes_id] [int] NOT NULL,
	[bes_soll] [int] NOT NULL,
	[bes_ist] [int] NOT NULL,
	PRIMARY KEY (bes_id))
	INSERT t_s_bestand (bes_id, bes_soll, bes_ist) VALUES (1, 5, 4)
	INSERT t_s_bestand (bes_id, bes_soll, bes_ist) VALUES (2, 4, 1)
	Select * from t_s_bestand
	END