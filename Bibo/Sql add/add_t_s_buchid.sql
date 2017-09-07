use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_buchid]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_buchid]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_buchid]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_buchid](
	[bu_id] [int] IDENTITY (1,1) NOT NULL,
	[bu_isbn] [nvarchar] (32) NOT NULL,
	[bu_zustandsid] [int] NOT NULL,
	[bu_aufnahmedatum] [date] NOT NULL,

	PRIMARY KEY (bu_id),
	FOREIGN KEY (bu_zustandsid)
		REFERENCES t_s_zustand (zu_id),
	FOREIGN KEY (bu_isbn)
		REFERENCES t_s_buecher (buch_isbn))

	INSERT INTO t_s_buchid (bu_isbn, bu_zustandsid, bu_aufnahmedatum) VALUES ('978-3423715669', 1, '01.01.2017')
	INSERT INTO t_s_buchid (bu_isbn, bu_zustandsid, bu_aufnahmedatum) VALUES ('978-3423715669', 3, '09.11.2012')
	Select * from t_s_buchid
	END