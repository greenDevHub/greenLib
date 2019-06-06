# Allgemeines zur Bibliotheksverwaltungs-Software
Mithilfe der neuen Software zur Verwaltung der Bibliothek sollen die Arbeitsabläufe der Lehrbuchausgabe, -rückgabe sowie die des normalen Verleihs und die Verwaltung der verschiedenen Bücher vereinfacht werden.
# Inhalt
1. Funktionsumfang
2. Nutzung der einzelnen Funktionen
3. Installation
4. 
## 1. Funktionen

- Verwaltung von:
	- Büchern
	- Exemplaren
	- Bucheigenschaften (Autor, Genre, Zustand, Verlag, Sprachen)
	- Kundendaten
-	Zuordnung von:
	-	Büchern zu Fächern und Klassenstufen
	-	Kunden zu Klassenstufen
	-	Fächern zu Kunden
-	Verleih und Rückgabe von Büchern (Verleih und Rückgabe mehrerer Bücher gleichzeitig möglich)
-	Lehrbuchausgabe und -rückgabe am Anfang bzw. Ende des Schuljahres

## 2. Nutzungsanleitung
### 2.1 Allgemeiner Aufbau der Oberfläche
- Die Oberfläche des Programmes ist farblich gegliedert in verschiedene Bereiche, welche vom Hauptmenü aus erreichbar sind.
- Alle Hauptfenster sind aufgebaut in:
	- links: Eingabefelder für Werte; Schaltflächen
	- rechts: Anzeige der Datensätze in tabellarischer Form
- Die Fenster der Bucheigenschaften bestehen aus einer Tabelle, in welcher neue Zeilen eingefügt werden können und Schaltflächen am unteren Rand.
- Buchausgabe?
### 2.2 Verwaltung der Buchdaten
Die Buchdaten in der Verwaltungssoftware sind gegliedert in **Bücher**, **Exemplare** und **Eigenschaften**.
#### 2.2.1 Bücher:
- Unter dem Begriff *Bücher* werden alle unterschiedlichen Buchtypen zusammengefasst. Jedes Buch ist immer nur einmal vorhanden und hat verschiedene Eigenschaften: ISBN, Titel, Autor, Verlag, Genre, Sprache, Auflage, Neupreis, Erscheinungsdatum und Bild des Buches.
- Man kann Bücher hinzufügen, bearbeiten und entfernen. Die jeweils notwendigen Informationen werden im Programm mit einem * markiert.
- Der Titel, der Autor, der Verlag und ein Bild des Buches können mit einer Internetverbindung nach Eingabe der ISBN automatisch geladen werden (funktioniert nicht bei jedem Buch). Mithilfe der Schaltfläche neben dem Eingabefeld der ISBN oder der Entertaste wird dieser Vorgang gestartet (bei Eingabe mit Barcodescanner passiert dies automatisch).
- Mithilfe den Schaltflächen rechts neben den Eingabefeldern für Autor, Verlag, Genre und Sprache lassen sich diese neu hinzufügen (dazu später mehr). Wenn entsprechende Einträge schon vorhanden sein sollten, können diese aus der Liste ausgewählt werden.
- Bei der Eingabe mehrerer Autoren muss zuerst das Kästchen links neben dem Eingabefeld abgehakt und dann die Autoren in der Liste ausgewählt werden.
- Mit der Schaltfläche *Hinzufügen* wird das Buch schließlich in die Datenbank gespeichert und kann ab sofort im rechten Bereich gefunden werden.
- Nach erfolgreichem Hinzufügen des Buches öffnet sich ein neues Fenster, um seine *Exemplare* zu verwalten.
#### 2.2.2 Exemplare
-	Exemplare sind die verschiedenen Einheiten eines Buchtypes, die in der Bibliothek vorhanden sind. (z.B.: Für das Lehrbuch *Elemente der Mathematik 11* sind 100 Exemplare vorhanden)
-	Jedes Exemplar hat eine ID, einen Zustand und ein Aufnahmedatum. Anhand der ID kann jedes Exemplar eindeutig identifiziert werden.
-	Das Hinzufügen, Bearbeiten und Löschen von Exemplaren funktioniert nach dem gleichen Prinzip, wie bei Büchern. Mithilfe der Eingabe der Anzahl der Exemplare lassen sich gleich mehrere Einheiten gleichzeitig hinzufügen (z.B. bei einer Lieferung von 20 neuen Exemplaren eines Buches).
-	Jedes Exemplar bekommt anhand seiner ID einen Barcode zugeordnet, welcher über die entsprechende Schaltfläche gedruckt werden kann (Barcodedrucker vorausgesetzt). Dieser kann auf den Buchrücken geklebt werden, um mithilfe eines Scanners alle Vorgänge zu erleichtern.
-	Durch Markieren mehrerer Exemplare in der Tabelle rechts und einem Rechtsklick lassen sich auch für alle ausgewählten Exemplare gleichzeitig die Barcodes drucken.

## Switch to another file

All your files are listed in the file explorer. You can switch from one to another by clicking a file in the list.

## Rename a file

You can rename the current file by clicking the file name in the navigation bar or by clicking the **Rename** button in the file explorer.

## Delete a file

You can delete the current file by clicking the **Remove** button in the file explorer. The file will be moved into the **Trash** folder and automatically deleted after 7 days of inactivity.

## Export a file

You can export the current file by clicking **Export to disk** in the menu. You can choose to export the file as plain Markdown, as HTML using a Handlebars template or as a PDF.


# Synchronization

Synchronization is one of the biggest features of StackEdit. It enables you to synchronize any file in your workspace with other files stored in your **Google Drive**, your **Dropbox** and your **GitHub** accounts. This allows you to keep writing on other devices, collaborate with people you share the file with, integrate easily into your workflow... The synchronization mechanism takes place every minute in the background, downloading, merging, and uploading file modifications.

There are two types of synchronization and they can complement each other:

- The workspace synchronization will sync all your files, folders and settings automatically. This will allow you to fetch your workspace on any other device.
	> To start syncing your workspace, just sign in with Google in the menu.

- The file synchronization will keep one file of the workspace synced with one or multiple files in **Google Drive**, **Dropbox** or **GitHub**.
	> Before starting to sync files, you must link an account in the **Synchronize** sub-menu.

## Open a file

You can open a file from **Google Drive**, **Dropbox** or **GitHub** by opening the **Synchronize** sub-menu and clicking **Open from**. Once opened in the workspace, any modification in the file will be automatically synced.

## Save a file

You can save any file of the workspace to **Google Drive**, **Dropbox** or **GitHub** by opening the **Synchronize** sub-menu and clicking **Save on**. Even if a file in the workspace is already synced, you can save it to another location. StackEdit can sync one file with multiple locations and accounts.

## Synchronize a file

Once your file is linked to a synchronized location, StackEdit will periodically synchronize it by downloading/uploading any modification. A merge will be performed if necessary and conflicts will be resolved.

If you just have modified your file and you want to force syncing, click the **Synchronize now** button in the navigation bar.

> **Note:** The **Synchronize now** button is disabled if you have no file to synchronize.

## Manage file synchronization

Since one file can be synced with multiple locations, you can list and manage synchronized locations by clicking **File synchronization** in the **Synchronize** sub-menu. This allows you to list and remove synchronized locations that are linked to your file.


# Publication

Publishing in StackEdit makes it simple for you to publish online your files. Once you're happy with a file, you can publish it to different hosting platforms like **Blogger**, **Dropbox**, **Gist**, **GitHub**, **Google Drive**, **WordPress** and **Zendesk**. With [Handlebars templates](http://handlebarsjs.com/), you have full control over what you export.

> Before starting to publish, you must link an account in the **Publish** sub-menu.

## Publish a File

You can publish your file by opening the **Publish** sub-menu and by clicking **Publish to**. For some locations, you can choose between the following formats:

- Markdown: publish the Markdown text on a website that can interpret it (**GitHub** for instance),
- HTML: publish the file converted to HTML via a Handlebars template (on a blog for example).

## Update a publication

After publishing, StackEdit keeps your file linked to that publication which makes it easy for you to re-publish it. Once you have modified your file and you want to update your publication, click on the **Publish now** button in the navigation bar.

> **Note:** The **Publish now** button is disabled if your file has not been published yet.

## Manage file publication

Since one file can be published to multiple locations, you can list and manage publish locations by clicking **File publication** in the **Publish** sub-menu. This allows you to list and remove publication locations that are linked to your file.


# Markdown extensions

StackEdit extends the standard Markdown syntax by adding extra **Markdown extensions**, providing you with some nice features.

> **ProTip:** You can disable any **Markdown extension** in the **File properties** dialog.


## SmartyPants

SmartyPants converts ASCII punctuation characters into "smart" typographic punctuation HTML entities. For example:

|                |ASCII                          |HTML                         |
|----------------|-------------------------------|-----------------------------|
|Single backticks|`'Isn't this fun?'`            |'Isn't this fun?'            |
|Quotes          |`"Isn't this fun?"`            |"Isn't this fun?"            |
|Dashes          |`-- is en-dash, --- is em-dash`|-- is en-dash, --- is em-dash|


## KaTeX

You can render LaTeX mathematical expressions using [KaTeX](https://khan.github.io/KaTeX/):

The *Gamma function* satisfying $\Gamma(n) = (n-1)!\quad\forall n\in\mathbb N$ is via the Euler integral

$$
\Gamma(z) = \int_0^\infty t^{z-1}e^{-t}dt\,.
$$

> You can find more information about **LaTeX** mathematical expressions [here](http://meta.math.stackexchange.com/questions/5020/mathjax-basic-tutorial-and-quick-reference).


## UML diagrams

You can render UML diagrams using [Mermaid](https://mermaidjs.github.io/). For example, this will produce a sequence diagram:

```mermaid
sequenceDiagram
Alice ->> Bob: Hello Bob, how are you?
Bob-->>John: How about you John?
Bob--x Alice: I am good thanks!
Bob-x John: I am good thanks!
Note right of John: Bob thinks a long<br/>long time, so long<br/>that the text does<br/>not fit on a row.

Bob-->Alice: Checking with John...
Alice->John: Yes... John, how are you?
```

And this will produce a flow chart:

```mermaid
graph LR
A[Square Rect] -- Link text --> B((Circle))
A --> C(Round Rect)
B --> D{Rhombus}
C --> D
```
