use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_buecher]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_buecher]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_buecher]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_buecher](
	[buch_isbn] [nvarchar](32) NOT NULL,
	[buch_titel] [nvarchar](128) NOT NULL,
	[buch_genre_id] [int] NOT NULL,
	[buch_autor_id] [int] NOT NULL,
	[buch_verlag_id] [int] NOT NULL,
	[buch_erscheinungsdatum] [date] NOT NULL,
	[buch_sprache_id] [int] NOT NULL,
	[buch_auflage] [nvarchar](128) NOT NULL,
	[buch_neupreis] [numeric](18,2) NOT NULL,

	PRIMARY KEY (buch_isbn),
	FOREIGN KEY (buch_genre_id)
		REFERENCES t_s_genre (ger_id),
	FOREIGN KEY (buch_autor_id)
		REFERENCES t_s_autor (au_id),
	FOREIGN KEY (buch_verlag_id)
		REFERENCES t_s_verlag (ver_id),
	FOREIGN KEY (buch_sprache_id)
		REFERENCES t_s_sprache (sprach_id))

	INSERT INTO t_s_buecher (buch_isbn, buch_titel, buch_genre_id, buch_autor_id, buch_verlag_id,
	buch_erscheinungsdatum, buch_sprache_id, buch_auflage, buch_neupreis) VALUES 
	('978-3608938289', 'Der Herr der Ringe', 3, 1, 1, '01.12.2014', 1, 'Auflage 6', 49.95)
	INSERT INTO t_s_buecher (buch_isbn, buch_titel, buch_genre_id, buch_autor_id, buch_verlag_id, 
	buch_erscheinungsdatum, buch_sprache_id, buch_auflage, buch_neupreis) VALUES
	('978-3423715669', 'Der kleine Hobbit', 2, 1, 2, '01.11.2013', 1, 'Auflage 1', 8.95)

	Select * from t_s_buecher
	END