namespace Bibo_Verwaltung
{
    partial class w_s_main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_main));
            this.lb_Ausleihzahl = new MetroFramework.Controls.MetroLabel();
            this.lb_Ausgeliehen = new MetroFramework.Controls.MetroLabel();
            this.lb_Lagerzahl = new MetroFramework.Controls.MetroLabel();
            this.lb_IstBestand = new MetroFramework.Controls.MetroLabel();
            this.lb_Bestandzahl = new MetroFramework.Controls.MetroLabel();
            this.lb_Bestand = new MetroFramework.Controls.MetroLabel();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.mT_Kunden = new MetroFramework.Controls.MetroTile();
            this.mt_Autor = new MetroFramework.Controls.MetroTile();
            this.mT_Verlage = new MetroFramework.Controls.MetroTile();
            this.mT_Zustand = new MetroFramework.Controls.MetroTile();
            this.mT_Sprachen = new MetroFramework.Controls.MetroTile();
            this.mT_Faecher = new MetroFramework.Controls.MetroTile();
            this.mT_Buecher = new MetroFramework.Controls.MetroTile();
            this.mT_Genres = new MetroFramework.Controls.MetroTile();
            this.mT_Klassenstufen = new MetroFramework.Controls.MetroTile();
            this.mT_ausleihen = new MetroFramework.Controls.MetroTile();
            this.mT_Einstellungen = new MetroFramework.Controls.MetroTile();
            this.mT_Benutzerverwaltung = new MetroFramework.Controls.MetroTile();
            this.mT_Abmelden = new MetroFramework.Controls.MetroTile();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.mT_Statistik = new MetroFramework.Controls.MetroTile();
            this.image = new MetroFramework.Controls.MetroLink();
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mT_ausgabe = new MetroFramework.Controls.MetroTile();
            this.mT_rueckgabe = new MetroFramework.Controls.MetroTile();
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.bt_zu = new MetroFramework.Controls.MetroTile();
            this.panel1 = new Bibo_Verwaltung.TransparentPanel();
            this.transparentPanel1 = new Bibo_Verwaltung.TransparentPanel();
            this.mT_klassenstufebuch = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.mT_klassenstufefach = new MetroFramework.Controls.MetroTile();
            this.mT_fachbuch = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.transparentPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Ausleihzahl
            // 
            this.lb_Ausleihzahl.AutoSize = true;
            this.lb_Ausleihzahl.Location = new System.Drawing.Point(161, 48);
            this.lb_Ausleihzahl.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Ausleihzahl.Name = "lb_Ausleihzahl";
            this.lb_Ausleihzahl.Size = new System.Drawing.Size(15, 19);
            this.lb_Ausleihzahl.TabIndex = 4;
            this.lb_Ausleihzahl.Text = "-";
            // 
            // lb_Ausgeliehen
            // 
            this.lb_Ausgeliehen.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Ausgeliehen, "In diesem Feld wird ihnen die aktuelle Anzahl von Bücheren angezeigt, welche mome" +
        "ntan ausgeliehen sind.");
            this.lb_Ausgeliehen.Location = new System.Drawing.Point(3, 48);
            this.lb_Ausgeliehen.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Ausgeliehen.Name = "lb_Ausgeliehen";
            this.helpProvider.SetShowHelp(this.lb_Ausgeliehen, true);
            this.lb_Ausgeliehen.Size = new System.Drawing.Size(124, 19);
            this.lb_Ausgeliehen.TabIndex = 2;
            this.lb_Ausgeliehen.Text = "Bücher ausgeliehen:";
            // 
            // lb_Lagerzahl
            // 
            this.lb_Lagerzahl.AutoSize = true;
            this.lb_Lagerzahl.Location = new System.Drawing.Point(161, 26);
            this.lb_Lagerzahl.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Lagerzahl.Name = "lb_Lagerzahl";
            this.lb_Lagerzahl.Size = new System.Drawing.Size(15, 19);
            this.lb_Lagerzahl.TabIndex = 3;
            this.lb_Lagerzahl.Text = "-";
            // 
            // lb_IstBestand
            // 
            this.lb_IstBestand.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_IstBestand, "In diesem Feld wird ihnen die aktuelle Anzahl von Bücheren angezeigt, welche sich" +
        " im Lager befinden.");
            this.lb_IstBestand.Location = new System.Drawing.Point(3, 26);
            this.lb_IstBestand.Margin = new System.Windows.Forms.Padding(3);
            this.lb_IstBestand.Name = "lb_IstBestand";
            this.helpProvider.SetShowHelp(this.lb_IstBestand, true);
            this.lb_IstBestand.Size = new System.Drawing.Size(109, 19);
            this.lb_IstBestand.TabIndex = 1;
            this.lb_IstBestand.Text = "Bücher im Lager:";
            // 
            // lb_Bestandzahl
            // 
            this.lb_Bestandzahl.AutoSize = true;
            this.lb_Bestandzahl.Location = new System.Drawing.Point(161, 3);
            this.lb_Bestandzahl.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Bestandzahl.Name = "lb_Bestandzahl";
            this.lb_Bestandzahl.Size = new System.Drawing.Size(15, 19);
            this.lb_Bestandzahl.TabIndex = 2;
            this.lb_Bestandzahl.Text = "-";
            // 
            // lb_Bestand
            // 
            this.lb_Bestand.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Bestand, "In diesem Feld wird ihnen die aktuelle Anzahl von Bücheren angezeigt, welche sich" +
        " im Bestand befinden.");
            this.lb_Bestand.Location = new System.Drawing.Point(3, 3);
            this.lb_Bestand.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Bestand.Name = "lb_Bestand";
            this.helpProvider.SetShowHelp(this.lb_Bestand, true);
            this.lb_Bestand.Size = new System.Drawing.Size(121, 19);
            this.lb_Bestand.TabIndex = 0;
            this.lb_Bestand.Text = "Bücher im Bestand:";
            // 
            // mT_Kunden
            // 
            this.mT_Kunden.ActiveControl = null;
            this.mT_Kunden.Location = new System.Drawing.Point(663, 4);
            this.mT_Kunden.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Kunden.Name = "mT_Kunden";
            this.mT_Kunden.Size = new System.Drawing.Size(157, 46);
            this.mT_Kunden.Style = MetroFramework.MetroColorStyle.Teal;
            this.mT_Kunden.TabIndex = 2;
            this.mT_Kunden.Text = "Kundenverwaltung";
            this.mT_Kunden.UseSelectable = true;
            this.mT_Kunden.Click += new System.EventHandler(this.bt_Kunden_Click);
            // 
            // mt_Autor
            // 
            this.mt_Autor.ActiveControl = null;
            this.mt_Autor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(173)))));
            this.mt_Autor.Location = new System.Drawing.Point(333, 58);
            this.mt_Autor.Margin = new System.Windows.Forms.Padding(4);
            this.mt_Autor.Name = "mt_Autor";
            this.mt_Autor.Size = new System.Drawing.Size(157, 46);
            this.mt_Autor.TabIndex = 3;
            this.mt_Autor.Text = "Autoren";
            this.mt_Autor.UseCustomBackColor = true;
            this.mt_Autor.UseSelectable = true;
            this.mt_Autor.Click += new System.EventHandler(this.bt_Autoren_Click);
            // 
            // mT_Verlage
            // 
            this.mT_Verlage.ActiveControl = null;
            this.mT_Verlage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(173)))));
            this.mT_Verlage.Location = new System.Drawing.Point(333, 111);
            this.mT_Verlage.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Verlage.Name = "mT_Verlage";
            this.mT_Verlage.Size = new System.Drawing.Size(157, 46);
            this.mT_Verlage.TabIndex = 3;
            this.mT_Verlage.Text = "Verlage";
            this.mT_Verlage.UseCustomBackColor = true;
            this.mT_Verlage.UseSelectable = true;
            this.mT_Verlage.Click += new System.EventHandler(this.bt_Verlage_Click);
            // 
            // mT_Zustand
            // 
            this.mT_Zustand.ActiveControl = null;
            this.mT_Zustand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(173)))));
            this.mT_Zustand.Location = new System.Drawing.Point(498, 111);
            this.mT_Zustand.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Zustand.Name = "mT_Zustand";
            this.mT_Zustand.Size = new System.Drawing.Size(157, 46);
            this.mT_Zustand.TabIndex = 3;
            this.mT_Zustand.Text = "Bücherzustände";
            this.mT_Zustand.UseCustomBackColor = true;
            this.mT_Zustand.UseSelectable = true;
            this.mT_Zustand.Click += new System.EventHandler(this.bt_Zustand_Click);
            // 
            // mT_Sprachen
            // 
            this.mT_Sprachen.ActiveControl = null;
            this.mT_Sprachen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(173)))));
            this.mT_Sprachen.Location = new System.Drawing.Point(333, 165);
            this.mT_Sprachen.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Sprachen.Name = "mT_Sprachen";
            this.mT_Sprachen.Size = new System.Drawing.Size(157, 46);
            this.mT_Sprachen.TabIndex = 3;
            this.mT_Sprachen.Text = "Sprachen";
            this.mT_Sprachen.UseCustomBackColor = true;
            this.mT_Sprachen.UseSelectable = true;
            this.mT_Sprachen.Click += new System.EventHandler(this.bt_Sprachen_Click);
            // 
            // mT_Faecher
            // 
            this.mT_Faecher.ActiveControl = null;
            this.mT_Faecher.BackColor = System.Drawing.Color.CadetBlue;
            this.mT_Faecher.Location = new System.Drawing.Point(663, 111);
            this.mT_Faecher.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Faecher.Name = "mT_Faecher";
            this.mT_Faecher.Size = new System.Drawing.Size(157, 46);
            this.mT_Faecher.Style = MetroFramework.MetroColorStyle.Teal;
            this.mT_Faecher.TabIndex = 3;
            this.mT_Faecher.Text = "Fächer";
            this.mT_Faecher.UseCustomBackColor = true;
            this.mT_Faecher.UseSelectable = true;
            this.mT_Faecher.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // mT_Buecher
            // 
            this.mT_Buecher.ActiveControl = null;
            this.mT_Buecher.Location = new System.Drawing.Point(333, 4);
            this.mT_Buecher.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Buecher.Name = "mT_Buecher";
            this.mT_Buecher.Size = new System.Drawing.Size(322, 46);
            this.mT_Buecher.TabIndex = 3;
            this.mT_Buecher.Text = "Bücherverwaltung";
            this.mT_Buecher.UseSelectable = true;
            this.mT_Buecher.Click += new System.EventHandler(this.bt_Buecher_Click);
            // 
            // mT_Genres
            // 
            this.mT_Genres.ActiveControl = null;
            this.mT_Genres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(173)))));
            this.mT_Genres.Location = new System.Drawing.Point(498, 58);
            this.mT_Genres.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Genres.Name = "mT_Genres";
            this.mT_Genres.Size = new System.Drawing.Size(157, 46);
            this.mT_Genres.TabIndex = 3;
            this.mT_Genres.Text = "Genres";
            this.mT_Genres.UseCustomBackColor = true;
            this.mT_Genres.UseSelectable = true;
            this.mT_Genres.Click += new System.EventHandler(this.bt_Genres_Click);
            // 
            // mT_Klassenstufen
            // 
            this.mT_Klassenstufen.ActiveControl = null;
            this.mT_Klassenstufen.BackColor = System.Drawing.Color.CadetBlue;
            this.mT_Klassenstufen.Location = new System.Drawing.Point(663, 58);
            this.mT_Klassenstufen.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Klassenstufen.Name = "mT_Klassenstufen";
            this.mT_Klassenstufen.Size = new System.Drawing.Size(157, 46);
            this.mT_Klassenstufen.Style = MetroFramework.MetroColorStyle.Teal;
            this.mT_Klassenstufen.TabIndex = 3;
            this.mT_Klassenstufen.Text = "Klassenstufen";
            this.mT_Klassenstufen.UseCustomBackColor = true;
            this.mT_Klassenstufen.UseSelectable = true;
            this.mT_Klassenstufen.Click += new System.EventHandler(this.bt_klassenstufe_Click);
            // 
            // mT_ausleihen
            // 
            this.mT_ausleihen.ActiveControl = null;
            this.mT_ausleihen.Location = new System.Drawing.Point(4, 111);
            this.mT_ausleihen.Margin = new System.Windows.Forms.Padding(4);
            this.mT_ausleihen.Name = "mT_ausleihen";
            this.mT_ausleihen.Size = new System.Drawing.Size(322, 101);
            this.mT_ausleihen.Style = MetroFramework.MetroColorStyle.Lime;
            this.mT_ausleihen.TabIndex = 3;
            this.mT_ausleihen.Text = "Buchübersicht";
            this.mT_ausleihen.UseSelectable = true;
            this.mT_ausleihen.Click += new System.EventHandler(this.bt_Suchen_Ausleihen_Click);
            // 
            // mT_Einstellungen
            // 
            this.mT_Einstellungen.ActiveControl = null;
            this.mT_Einstellungen.Location = new System.Drawing.Point(663, 165);
            this.mT_Einstellungen.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Einstellungen.Name = "mT_Einstellungen";
            this.mT_Einstellungen.Size = new System.Drawing.Size(157, 46);
            this.mT_Einstellungen.Style = MetroFramework.MetroColorStyle.Silver;
            this.mT_Einstellungen.TabIndex = 3;
            this.mT_Einstellungen.Text = "Einstellungen";
            this.mT_Einstellungen.UseSelectable = true;
            this.mT_Einstellungen.Click += new System.EventHandler(this.bt_Einstellungen_Click);
            // 
            // mT_Benutzerverwaltung
            // 
            this.mT_Benutzerverwaltung.ActiveControl = null;
            this.mT_Benutzerverwaltung.Location = new System.Drawing.Point(498, 165);
            this.mT_Benutzerverwaltung.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Benutzerverwaltung.Name = "mT_Benutzerverwaltung";
            this.mT_Benutzerverwaltung.Size = new System.Drawing.Size(157, 46);
            this.mT_Benutzerverwaltung.Style = MetroFramework.MetroColorStyle.Teal;
            this.mT_Benutzerverwaltung.TabIndex = 3;
            this.mT_Benutzerverwaltung.Text = "Benutzerverwaltung";
            this.mT_Benutzerverwaltung.UseSelectable = true;
            this.mT_Benutzerverwaltung.Click += new System.EventHandler(this.bt_Benutzerverwaltung_Click);
            // 
            // mT_Abmelden
            // 
            this.mT_Abmelden.ActiveControl = null;
            this.mT_Abmelden.Location = new System.Drawing.Point(663, 219);
            this.mT_Abmelden.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Abmelden.Name = "mT_Abmelden";
            this.mT_Abmelden.Size = new System.Drawing.Size(157, 46);
            this.mT_Abmelden.Style = MetroFramework.MetroColorStyle.Silver;
            this.mT_Abmelden.TabIndex = 6;
            this.mT_Abmelden.Text = "Abmelden";
            this.mT_Abmelden.UseSelectable = true;
            this.mT_Abmelden.Click += new System.EventHandler(this.mT_Abmelden_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.lb_Ausleihzahl);
            this.metroPanel1.Controls.Add(this.lb_Lagerzahl);
            this.metroPanel1.Controls.Add(this.lb_Ausgeliehen);
            this.metroPanel1.Controls.Add(this.lb_Bestand);
            this.metroPanel1.Controls.Add(this.lb_IstBestand);
            this.metroPanel1.Controls.Add(this.lb_Bestandzahl);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(4, 4);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(322, 100);
            this.metroPanel1.TabIndex = 4;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // mT_Statistik
            // 
            this.mT_Statistik.ActiveControl = null;
            this.mT_Statistik.Location = new System.Drawing.Point(333, 219);
            this.mT_Statistik.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Statistik.Name = "mT_Statistik";
            this.mT_Statistik.Size = new System.Drawing.Size(157, 46);
            this.mT_Statistik.Style = MetroFramework.MetroColorStyle.Green;
            this.mT_Statistik.TabIndex = 7;
            this.mT_Statistik.Text = "Statistik";
            this.mT_Statistik.UseSelectable = true;
            this.mT_Statistik.Click += new System.EventHandler(this.bt_stats_Click);
            // 
            // image
            // 
            this.image.Image = global::Bibo_Verwaltung.Properties.Resources.icon;
            this.image.ImageSize = 32;
            this.image.Location = new System.Drawing.Point(10, 21);
            this.image.Margin = new System.Windows.Forms.Padding(2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(32, 32);
            this.image.TabIndex = 8;
            this.image.UseSelectable = true;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.metroProgressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.Size = new System.Drawing.Size(847, 5);
            this.metroProgressBar1.Step = 1;
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroProgressBar1.TabIndex = 9;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mT_ausgabe
            // 
            this.mT_ausgabe.ActiveControl = null;
            this.mT_ausgabe.BackColor = System.Drawing.Color.OliveDrab;
            this.mT_ausgabe.Location = new System.Drawing.Point(4, 219);
            this.mT_ausgabe.Name = "mT_ausgabe";
            this.mT_ausgabe.Size = new System.Drawing.Size(157, 46);
            this.mT_ausgabe.Style = MetroFramework.MetroColorStyle.Lime;
            this.mT_ausgabe.TabIndex = 10;
            this.mT_ausgabe.Text = "Buchausgabe";
            this.mT_ausgabe.UseCustomBackColor = true;
            this.mT_ausgabe.UseSelectable = true;
            this.mT_ausgabe.Click += new System.EventHandler(this.mT_ausgabe_Click);
            // 
            // mT_rueckgabe
            // 
            this.mT_rueckgabe.ActiveControl = null;
            this.mT_rueckgabe.BackColor = System.Drawing.Color.OliveDrab;
            this.mT_rueckgabe.Location = new System.Drawing.Point(169, 219);
            this.mT_rueckgabe.Name = "mT_rueckgabe";
            this.mT_rueckgabe.Size = new System.Drawing.Size(157, 46);
            this.mT_rueckgabe.Style = MetroFramework.MetroColorStyle.Lime;
            this.mT_rueckgabe.TabIndex = 11;
            this.mT_rueckgabe.Text = "Buchrückgabe";
            this.mT_rueckgabe.UseCustomBackColor = true;
            this.mT_rueckgabe.UseSelectable = true;
            this.mT_rueckgabe.Click += new System.EventHandler(this.mT_rueckgabe_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.bt_zu);
            this.panel.Controls.Add(this.metroPanel1);
            this.panel.Controls.Add(this.mT_Benutzerverwaltung);
            this.panel.Controls.Add(this.mT_Kunden);
            this.panel.Controls.Add(this.mt_Autor);
            this.panel.Controls.Add(this.mT_Verlage);
            this.panel.Controls.Add(this.mT_rueckgabe);
            this.panel.Controls.Add(this.mT_Zustand);
            this.panel.Controls.Add(this.mT_ausgabe);
            this.panel.Controls.Add(this.mT_Sprachen);
            this.panel.Controls.Add(this.mT_Genres);
            this.panel.Controls.Add(this.mT_Statistik);
            this.panel.Controls.Add(this.mT_ausleihen);
            this.panel.Controls.Add(this.mT_Abmelden);
            this.panel.Controls.Add(this.mT_Einstellungen);
            this.panel.Controls.Add(this.mT_Klassenstufen);
            this.panel.Controls.Add(this.mT_Buecher);
            this.panel.Controls.Add(this.mT_Faecher);
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(10, 63);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(830, 274);
            this.panel.TabIndex = 16;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // bt_zu
            // 
            this.bt_zu.ActiveControl = null;
            this.bt_zu.Location = new System.Drawing.Point(498, 219);
            this.bt_zu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_zu.Name = "bt_zu";
            this.bt_zu.Size = new System.Drawing.Size(157, 46);
            this.bt_zu.Style = MetroFramework.MetroColorStyle.Brown;
            this.bt_zu.TabIndex = 17;
            this.bt_zu.Text = "Zuordnungen";
            this.bt_zu.UseSelectable = true;
            this.bt_zu.Click += new System.EventHandler(this.bt_zu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.transparentPanel1);
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 21);
            this.panel1.Name = "panel1";
            this.panel1.Opacity = 25;
            this.panel1.Size = new System.Drawing.Size(847, 325);
            this.panel1.TabIndex = 17;
            this.panel1.Visible = false;
            this.panel1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.BackColor = System.Drawing.Color.DimGray;
            this.transparentPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transparentPanel1.Controls.Add(this.mT_klassenstufebuch);
            this.transparentPanel1.Controls.Add(this.metroTile1);
            this.transparentPanel1.Controls.Add(this.mT_klassenstufefach);
            this.transparentPanel1.Controls.Add(this.mT_fachbuch);
            this.transparentPanel1.ForeColor = System.Drawing.Color.Transparent;
            this.transparentPanel1.Location = new System.Drawing.Point(173, 91);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Size = new System.Drawing.Size(499, 116);
            this.transparentPanel1.TabIndex = 16;
            // 
            // mT_klassenstufebuch
            // 
            this.mT_klassenstufebuch.ActiveControl = null;
            this.mT_klassenstufebuch.Location = new System.Drawing.Point(8, 8);
            this.mT_klassenstufebuch.Margin = new System.Windows.Forms.Padding(8, 8, 3, 3);
            this.mT_klassenstufebuch.Name = "mT_klassenstufebuch";
            this.mT_klassenstufebuch.Size = new System.Drawing.Size(157, 46);
            this.mT_klassenstufebuch.Style = MetroFramework.MetroColorStyle.Orange;
            this.mT_klassenstufebuch.TabIndex = 14;
            this.mT_klassenstufebuch.Text = "Klassenstufe - Bücher";
            this.mT_klassenstufebuch.UseSelectable = true;
            this.mT_klassenstufebuch.Click += new System.EventHandler(this.mT_klassenstufebuch_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(169, 61);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(158, 46);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTile1.TabIndex = 15;
            this.metroTile1.Text = "Zurück";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // mT_klassenstufefach
            // 
            this.mT_klassenstufefach.ActiveControl = null;
            this.mT_klassenstufefach.Location = new System.Drawing.Point(334, 8);
            this.mT_klassenstufefach.Margin = new System.Windows.Forms.Padding(3, 8, 8, 3);
            this.mT_klassenstufefach.Name = "mT_klassenstufefach";
            this.mT_klassenstufefach.Size = new System.Drawing.Size(157, 46);
            this.mT_klassenstufefach.Style = MetroFramework.MetroColorStyle.Orange;
            this.mT_klassenstufefach.TabIndex = 13;
            this.mT_klassenstufefach.Text = "Klassenstufe - Fächer";
            this.mT_klassenstufefach.UseSelectable = true;
            this.mT_klassenstufefach.Click += new System.EventHandler(this.mT_klassenstufefach_Click);
            // 
            // mT_fachbuch
            // 
            this.mT_fachbuch.ActiveControl = null;
            this.mT_fachbuch.Location = new System.Drawing.Point(169, 8);
            this.mT_fachbuch.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.mT_fachbuch.Name = "mT_fachbuch";
            this.mT_fachbuch.Size = new System.Drawing.Size(158, 46);
            this.mT_fachbuch.Style = MetroFramework.MetroColorStyle.Orange;
            this.mT_fachbuch.TabIndex = 12;
            this.mT_fachbuch.Text = "Fächer - Bücher";
            this.mT_fachbuch.UseSelectable = true;
            this.mT_fachbuch.Click += new System.EventHandler(this.mT_fachbuch_Click);
            // 
            // w_s_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(847, 346);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.image);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_main";
            this.Padding = new System.Windows.Forms.Padding(9, 60, 9, 8);
            this.Resizable = false;
            this.Text = "     Bibliotheksverwaltung";
            this.Activated += new System.EventHandler(this.Load_Uebersicht);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.transparentPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lb_Ausleihzahl;
        private MetroFramework.Controls.MetroLabel lb_Ausgeliehen;
        private MetroFramework.Controls.MetroLabel lb_Lagerzahl;
        private MetroFramework.Controls.MetroLabel lb_IstBestand;
        private MetroFramework.Controls.MetroLabel lb_Bestandzahl;
        private MetroFramework.Controls.MetroLabel lb_Bestand;
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroTile mT_Kunden;
        private MetroFramework.Controls.MetroTile mt_Autor;
        private MetroFramework.Controls.MetroTile mT_Verlage;
        private MetroFramework.Controls.MetroTile mT_Zustand;
        private MetroFramework.Controls.MetroTile mT_Sprachen;
        private MetroFramework.Controls.MetroTile mT_Faecher;
        private MetroFramework.Controls.MetroTile mT_Buecher;
        private MetroFramework.Controls.MetroTile mT_Genres;
        private MetroFramework.Controls.MetroTile mT_Klassenstufen;
        private MetroFramework.Controls.MetroTile mT_ausleihen;
        private MetroFramework.Controls.MetroTile mT_Einstellungen;
        private MetroFramework.Controls.MetroTile mT_Benutzerverwaltung;
        private MetroFramework.Controls.MetroTile mT_Abmelden;
        private MetroFramework.Controls.MetroTile mT_Statistik;
        private MetroFramework.Controls.MetroLink image;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroTile mT_ausgabe;
        private MetroFramework.Controls.MetroTile mT_rueckgabe;
        private MetroFramework.Controls.MetroTile mT_fachbuch;
        private MetroFramework.Controls.MetroTile mT_klassenstufefach;
        private MetroFramework.Controls.MetroTile mT_klassenstufebuch;
        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroTile bt_zu;
        private TransparentPanel panel1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private TransparentPanel transparentPanel1;
    }
}
