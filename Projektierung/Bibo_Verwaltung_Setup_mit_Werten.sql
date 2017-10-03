/****** Object:  Database [Bibo_Verwaltung]    Script Date: 03.11.2016 18:54:35 ******/
IF  EXISTS (SELECT name FROM sys.databases WHERE name = N'Bibo_Verwaltung')
DROP DATABASE [Bibo_Verwaltung]
GO

/****** Object:  Database [Bibo_Verwaltung]    Script Date: 03.11.2016 18:54:35 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'Bibo_Verwaltung')
BEGIN
CREATE DATABASE [Bibo_Verwaltung]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Bibo_Verwaltung', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Bibo_Verwaltung.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Bibo_Verwaltung_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\Bibo_Verwaltung_log.ldf' , SIZE = 2048KB , MAXSIZE = 10240000KB , FILEGROWTH = 102400KB )
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
	INSERT into t_s_autor (au_autor) VALUES ('J.R.R. Tolkien')
	Select * from t_s_autor
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
	INSERT INTO t_s_genre (ger_name) VALUES ('Sachbuch')
	INSERT INTO t_s_genre (ger_name) VALUES ('Roman')
	INSERT INTO t_s_genre (ger_name) VALUES ('Fantasy')
	Select * from t_s_genre
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
	INSERT INTO t_s_kunden (kunde_vorname, kunde_nachname, 
	kunde_strasse, kunde_hausnummer, kunde_postleitzahl, kunde_ort, kunde_vertrauensw�rdigkeit,
	kunde_klasse, kunde_mail, kunde_telefonnummer) VALUES ('Uwe', 'Decker', 'Gubener Str.', '75a',
	'03711', 'Miesbach', '', '11/4', 'UweDecker@mail.com', '08024/160807')
	Select * from t_s_kunden
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
	INSERT INTO t_s_sprache (sprach_name) VALUES ('Deutsch')
	INSERT INTO t_s_sprache (sprach_name) VALUES ('Englisch')
	Select * from t_s_sprache
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
	Insert INTO t_s_verlag (ver_name) VALUES ('Klett-Cotta')
	INSERT INTO t_s_verlag (ver_name) VALUES ('dtv Verlagsgesellschaft')
	Select * from t_s_verlag
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
	INSERT INTO t_s_zustand (zu_zustand) VALUES ('neuwertig')
	INSERT INTO t_s_zustand (zu_zustand) VALUES ('gut')
	INSERT INTO t_s_zustand (zu_zustand) VALUES ('gebraucht')
	INSERT INTO t_s_zustand (zu_zustand) VALUES ('besch�digt')
	Select * from t_s_zustand
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
	[buch_auflage] [nvarchar](128) NOT NULL,
	[buch_neupreis] [numeric](18,2) NOT NULL,
	[buch_bild] [nvarchar] (256),


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
	[aus_barcode] [nvarchar] (128) NOT NULL,
	PRIMARY KEY (aus_leihnummer),
	FOREIGN KEY (aus_buchid)
		REFERENCES t_s_buchid (bu_id),
    FOREIGN KEY (aus_kundenid)
	    REFERENCES t_s_kunden (kunde_id))

	INSERT INTO t_bd_ausgeliehen (aus_buchid, aus_leihdatum, aus_r�ckgabedatum, aus_kundenid, aus_barcode) 
	VALUES (1, '11.11.2016', '18.11.2016', 1,'233254')
	Select * from t_bd_ausgeliehen
	END