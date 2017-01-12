use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_buecher]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_buecher]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_buecher]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_buecher](
	[buch_id] [int] IDENTITY(1,1) NOT NULL,
	[buch_titel] [nvarchar](128) NOT NULL,
	[buch_isbn] [nvarchar](32) NOT NULL,
	[buch_genre] [nvarchar](128) NOT NULL,
	[buch_autor_id] [nvarchar](128) NOT NULL,
	[buch_verlag_id] [nvarchar](128) NOT NULL,
	[buch_ort] [nvarchar](128) NOT NULL,
	[buch_zustand_id] [int] NOT NULL,
	[buch_erscheinungsdatum] [date] NOT NULL,
	[buch_sprache] [nvarchar](128) NOT NULL,
	[buch_auflage] [nvarchar](128) NOT NULL,
	[buch_neupreis] [numeric](18,2) NOT NULL,
	[buch_aufnahmedatum] [date] NOT NULL,
	[buch_bestand_id] [int] NOT NULL,
	PRIMARY KEY (buch_id),
	FOREIGN KEY (buch_zustand_id)
		REFERENCES t_s_zustand (zu_id))
	INSERT INTO t_s_buecher (buch_titel, buch_isbn, buch_genre, buch_autor_id, buch_verlag_id, buch_ort, 
	buch_zustand_id, buch_erscheinungsdatum, buch_sprache, buch_auflage, buch_neupreis, buch_aufnahmedatum, Buch_bestand_id) VALUES 
	('Der Herr der Ringe', '978-3608938289', 'Fantasy', 1, 1, 'Regal 3', 1, '01.12.2014', 'Deutsch', 'Auflage 6', 49.95, '01.12.2015', 1)
	INSERT INTO t_s_buecher (buch_titel, buch_isbn, buch_genre, buch_autor_id, buch_verlag_id, buch_ort, 
	buch_zustand_id, buch_erscheinungsdatum, buch_sprache, buch_auflage, buch_neupreis, buch_aufnahmedatum, buch_bestand_id) VALUES
	('Der kleine Hobbit', '978-3423715669', 'Roman', 1, 2, 'Regal 9 3/4', 3, '01.11.2013', 'Deutsch', 'Auflage 1', 8.95, '11.05.2014', 2)
	Select * from t_s_buecher
	END