/****** Object:  Database [Bibo_Verwaltung]    Script Date: 23.07.2018 Robert Jehring ******/
use master
ALTER DATABASE [Bibo_Verwaltung] SET single_user
GO

IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'Bibo_Verwaltung')
DROP DATABASE [Bibo_Verwaltung]
GO

IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'Bibo_Verwaltung')
BEGIN
CREATE DATABASE [Bibo_Verwaltung]
END
GO

ALTER DATABASE [Bibo_Verwaltung] SET COMPATIBILITY_LEVEL = 120
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Bibo_Verwaltung].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [Bibo_Verwaltung] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET ARITHABORT OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET AUTO_SHRINK ON 
GO

ALTER DATABASE [Bibo_Verwaltung] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [Bibo_Verwaltung] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [Bibo_Verwaltung] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET  DISABLE_BROKER 
GO

ALTER DATABASE [Bibo_Verwaltung] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [Bibo_Verwaltung] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [Bibo_Verwaltung] SET  MULTI_USER 
GO

ALTER DATABASE [Bibo_Verwaltung] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [Bibo_Verwaltung] SET DB_CHAINING OFF 
GO

ALTER DATABASE [Bibo_Verwaltung] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [Bibo_Verwaltung] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO

ALTER DATABASE [Bibo_Verwaltung] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [Bibo_Verwaltung] SET  READ_WRITE 
GO

use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_autor]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_autor]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_autor]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_autor](
	[au_id] [int] IDENTITY (1,1) NOT NULL,
	[au_autor] [nvarchar] (128) NOT NULL,
	PRIMARY KEY (au_id))
END

use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_genre]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_genre]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_genre]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_genre](
	[ger_id] [int] IDENTITY (1,1) NOT NULL,
	[ger_name] [nvarchar] (128) NOT NULL,
	PRIMARY KEY (ger_id))
END

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
	[kunde_vertrauensw�rdigkeit] [nvarchar](128),
	[kunde_klasse] [nvarchar](6),
	[kunde_mail] [nvarchar](128) NOT NULL,
	[kunde_telefonnummer] [nvarchar](128) NOT NULL,
	PRIMARY KEY (kunde_id))
END

use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_sprache]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_sprache]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_sprache]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_sprache](
	[sprach_id] [int] IDENTITY (1,1) NOT NULL,
	[sprach_name][nvarchar] (128) NOT NULL,
	PRIMARY KEY (sprach_id))
END

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
END

use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_autorListe]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_autorListe]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_autorListe]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_autorListe](
	[a_id] [int] IDENTITY (1,1) NOT NULL,
	[a_0] [int] NOT NULL,
	[a_1] [int], 
	[a_2] [int],
	[a_3] [int], 
	[a_4] [int], 
	[a_5] [int], 
	[a_6] [int], 
	[a_7] [int], 
	[a_8] [int], 
	[a_9] [int], 
	PRIMARY KEY (a_id),
	FOREIGN KEY (a_0)
		REFERENCES t_s_autor (au_id),
	FOREIGN KEY (a_1)
		REFERENCES t_s_autor (au_id),
	FOREIGN KEY (a_2)
		REFERENCES t_s_autor (au_id),
	FOREIGN KEY (a_3)
		REFERENCES t_s_autor (au_id),
	FOREIGN KEY (a_4)
		REFERENCES t_s_autor (au_id),
	FOREIGN KEY (a_5)
		REFERENCES t_s_autor (au_id),
	FOREIGN KEY (a_6)
		REFERENCES t_s_autor (au_id),
	FOREIGN KEY (a_7)
		REFERENCES t_s_autor (au_id),
	FOREIGN KEY (a_8)
		REFERENCES t_s_autor (au_id),
	FOREIGN KEY (a_9)
		REFERENCES t_s_autor (au_id))
END

use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_zustand]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_zustand]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_zustand]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_zustand](
	[zu_id] [int] IDENTITY (1,1) NOT NULL,
	[zu_zustand] [nvarchar](128) NOT NULL,
	PRIMARY KEY (zu_id))
END

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
	[buch_auflage] [nvarchar](128),
	[buch_neupreis] [numeric](18,2) NOT NULL,
	[buch_bild] [nvarchar] (256),
	[buch_anzahl] [int] NOT NULL,
	[buch_image] [varbinary](max),
	[buch_imageDate] [datetime],
	[buch_activated] [BIT] NOT NULL,
	PRIMARY KEY (buch_isbn),
	FOREIGN KEY (buch_genre_id)
		REFERENCES t_s_genre (ger_id),
	FOREIGN KEY (buch_autor_id)
		REFERENCES t_s_autorListe (a_id),
	FOREIGN KEY (buch_verlag_id)
		REFERENCES t_s_verlag (ver_id),
	FOREIGN KEY (buch_sprache_id)
		REFERENCES t_s_sprache (sprach_id))
END

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
	[bu_activated] [BIT] NOT NULL,
	PRIMARY KEY (bu_id),
	FOREIGN KEY (bu_zustandsid)
		REFERENCES t_s_zustand (zu_id),
	FOREIGN KEY (bu_isbn)
		REFERENCES t_s_buecher (buch_isbn))
END

use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_bd_ausgeliehen]') AND type in (N'U'))
DROP TABLE [dbo].[t_bd_ausgeliehen]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_bd_ausgeliehen]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_bd_ausgeliehen](
	[aus_leihnummer] [int] IDENTITY(1,1) NOT NULL,
	[aus_buchid] [int] NOT NULL,
	[aus_leihdatum] [date] NOT NULL,
	[aus_r�ckgabedatum] [date] NOT NULL,
	[aus_kundenid] [int] NOT NULL,
	PRIMARY KEY (aus_leihnummer),
	FOREIGN KEY (aus_buchid)
		REFERENCES t_s_buchid (bu_id),
    FOREIGN KEY (aus_kundenid)
	    REFERENCES t_s_kunden (kunde_id))
END

use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_verlauf]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_genre]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_verlauf]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_verlauf](
	[ver_id] [int] IDENTITY (1,1) NOT NULL,
	[id_buch] [int] NOT NULL,
	[k_id] [int] NOT NULL,
	[zu_vor] [nvarchar] (128) NOT NULL,
	[zu_nach] [nvarchar] (128) NOT NULL,
	[aus_geliehen] [date] NOT NULL,
	[aus_ruckgabe] [date] NOT NULL,
	PRIMARY KEY (ver_id),
	FOREIGN KEY (id_buch)
		REFERENCES t_s_buchid (bu_id),
    FOREIGN KEY (k_id)
	    REFERENCES t_s_kunden (kunde_id))
END

use Bibo_Verwaltung
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_benutzer]') AND type in (N'U'))
DROP TABLE [dbo].[t_s_benutzer]
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[t_s_benutzer]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[t_s_benutzer](
	[b_name] [nvarchar] (128) NOT NULL,
	[b_password] [varbinary] (max) NOT NULL,
	[b_rechte] [int] NOT NULL,
	PRIMARY KEY (b_name))
END