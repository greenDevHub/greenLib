use Bibo_Verwaltung
CREATE TABLE [dbo].[t_s_buecher](
	[buch_id] [int] IDENTITY(1,1) NOT NULL,
	[buch_titel] [nvarchar](128) NOT NULL,
	[buch_isbn] [nvarchar](32) NOT NULL,
	[buch_genre] [nvarchar](128) NOT NULL,
	[buch_autor] [nvarchar](128) NOT NULL,
	[buch_verlag] [nvarchar](128) NOT NULL,
	[buch_ort] [nvarchar](128) NOT NULL,
	[buch_zustand] [nvarchar](128) NOT NULL,
	[buch_erscheinungsdatum] [datetime] NOT NULL,
	[buch_sprache] [nvarchar](128) NOT NULL,
	[buch_auflage] [int] NOT NULL,
	[buch_neupreis] [numeric](18,2) NOT NULL,
	[buch_aufnahmedatum] [datetime] NOT NULL,
	PRIMARY KEY (buch_id))
	Select * from t_s_buecher
