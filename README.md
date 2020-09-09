<!--lint disable no-literal-urls-->
<p align="center">
  <a href="https://nodejs.org/">
    <img
      alt="Node.js"
      src="https://github.com/gehmlichj/greenLib/blob/master/icon.svg"
      width="300"
    />
  </a>
</p>

# greenLib
Mithilfe von greenLib sollen die Arbeitsabläufe der Lehrbuchausgabe, -rückgabe sowie die des normalen Verleihs und die Verwaltung der verschiedenen Bücher vereinfacht werden.

Übersicht
---------------------
 * Installation
 * Funktionen
 * Support
 * Autoren
 
 Installation
------------
Vor dem ersten Start von greenLib in Microsoft Visual Studio werden einige Zusatzkomponenten benötigt, deren Installation in diesem Abschnitt erläutert wird. Zu diesen zählen:
> * Full b-PAC SDK von Brother
> * MetroModernUI von Dennis Magno
> * Microsoft SQL Server

Folgen Sie den nachfolgenden Anweisungen Schritt für Schritt.

1. Downloaden Sie die greenLib Software und importieren Sie das Projekt in Microsoft Visual Studio.

2. Downloaden und installieren Sie die Full b-PAC SDK von Brother (https://www.brother.co.jp/eng/dev/bpac/download/index.aspx). Weitere Hinweise hierzu finden Sie unter dem angegebenen Link.

3. Downloaden und binden Sie das Nuget-Package MetroModernUI von Dennis Magno (https://www.nuget.org/packages/MetroModernUI/1.4.0?_src=template) in ihr Microsoft Visual Studio Projekt ein. Folgen Sie auch hier den Anweisungen unter dem dazugehörigen Link.

4. Downloaden und installieren Sie die aktuelle Version des Microsoft SQL-Servers (https://www.microsoft.com/en-us/sql-server/sql-server-downloads). SQL-Server und greenLib müssen nicht zwangsläufig auf ein und derselben Maschiene laufen, solange eine Verbindung zwischen beiden existiert. Da im nächsten Schritt ein SQL-Sript ausgeführt werden muss, empfielt sich auch die Installation des SQL Server Management Studios (https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15).

5. Führen Sie nun das bereitgestellte SQL-Skript für die greenLib-Datenbank aus. Schließlich müssen für die Datenbank noch die Rechte vergeben werden. Entweder erfolgt der Login über die greenLib-Software per Windows-Authentifizierung oder über die SQL Authentifizierung. Für letztere müssen ein Benutzername und ein Kennwort, sowie die entsprechenden Berechtigungen vergeben werden.

 Funktionen
------------
* Verwaltung von:
 >* Büchern
 >* Exemplaren
 >* Bucheigenschaften (Autor, Genre, Zustand, Verlag, Sprachen)
 >* Kundendaten
 >* Klassen
* Zuordnung von:
 >* Büchern zu Fächern und Klassenstufen
 >* Kunden zu Klassenstufen
 >* Fächern zu Kunden
 >* Klassen zu Klassenstufen
* Verleih und Rückgabe von Büchern (Verleih und Rückgabe mehrerer Bücher gleichzeitig möglich)
* automatisierte Lehrbuchausgabe und -rückgabe am Anfang bzw. Ende des Schuljahres

 Support
------------
Bei Fragen, Problemen, Anregungen, etc. kontaktieren Sie uns bitte unter: greendev@web.de

 Autoren
------------
* **Laurenz** - *Developer* - [???](https://github.com/Laurenz01)
* **Robert** - *Developer* - [???](https://github.com/RobJeh)
* **Justin** - *Developer* - [???](https://github.com/Just2407)
* **Josua** - *Project leadership* - [gehmlichj](https://github.com/jgehmlich)
* **Erik** - *Graphics and design* - [EGoesche](https://github.com/EGoesche)

Um zu erfahren, wer zusätzlich an diesem Projekt gearbeitet hat, lesen Sie bitte die contributors-Datei.
