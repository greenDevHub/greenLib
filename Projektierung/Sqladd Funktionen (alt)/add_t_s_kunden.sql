use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_kunden]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_kunden]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_kunden]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_kunden](
	[kunde_ID] [int] IDENTITY (1,1) NOT NULL,
	[kunde_vorname] [nvarchar](128) NOT NULL,
	[kunde_nachname] [nvarchar](128) NOT NULL,
	[kunde_strasse] [nvarchar](128) NOT NULL,
	[kunde_hausnummer] [nvarchar](4) NOT NULL,
	[kunde_postleitzahl] [nvarchar](16) NOT NULL,
	[kunde_ort] [nvarchar](128) NOT NULL,
	[kunde_vertrauenswürdigkeit] [nvarchar](128),
	[kunde_klasse] [nvarchar](6),
	[kunde_mail] [nvarchar](128) NOT NULL,
	[kunde_telefonnummer] [nvarchar](128) NOT NULL,
	PRIMARY KEY (kunde_id))
	INSERT INTO t_s_kunden (kunde_vorname, kunde_nachname, 
	kunde_strasse, kunde_hausnummer, kunde_postleitzahl, kunde_ort, kunde_vertrauenswürdigkeit,
	kunde_klasse, kunde_mail, kunde_telefonnummer) VALUES ('Uwe', 'Decker', 'Gubener Str.', '75a',
	'03711', 'Miesbach', '', '11/4', 'UweDecker@mail.com', '08024/160807')
	Select * from t_s_kunden
	END
