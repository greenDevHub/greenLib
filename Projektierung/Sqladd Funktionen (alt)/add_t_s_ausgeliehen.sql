use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_ausgeliehen]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_ausgeliehen]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_ausgeliehen]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_ausgeliehen](
	[aus_leihnummer] [int] IDENTITY(1,1) NOT NULL,
	[aus_buchid] [int] NOT NULL,
	[aus_leihdatum] [date] NOT NULL,
	[aus_rückgabedatum] [date] NOT NULL,
	[aus_kundenid] [int] NOT NULL,
	PRIMARY KEY (aus_leihnummer),
	FOREIGN KEY (aus_buchid)
		REFERENCES t_s_buecher (buch_id),
<<<<<<< HEAD
    FOREIGN KEY (aus_kundenid)
	    REFERENCES t_s_kunden (kunde_id))
=======
	FOREIGN KEY (aus_kundenid)
		REFERENCES t_s_kunden (kunde_ID))
>>>>>>> origin/InfoAG
	INSERT INTO t_s_ausgeliehen (aus_buchid, aus_leihdatum, aus_rückgabedatum, aus_kundenid) 
	VALUES (1, '11.11.2016', '18.11.2016', 1)
	Select * from t_s_ausgeliehen
	END