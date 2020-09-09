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
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.mT_Kunden = new MetroFramework.Controls.MetroTile();
            this.mt_Autor = new MetroFramework.Controls.MetroTile();
            this.mT_Verlage = new MetroFramework.Controls.MetroTile();
            this.mT_Zustand = new MetroFramework.Controls.MetroTile();
            this.mT_Sprachen = new MetroFramework.Controls.MetroTile();
            this.mT_Faecher = new MetroFramework.Controls.MetroTile();
            this.mT_Buecher = new MetroFramework.Controls.MetroTile();
            this.mT_Genres = new MetroFramework.Controls.MetroTile();
            this.mT_ausleihen = new MetroFramework.Controls.MetroTile();
            this.mT_Einstellungen = new MetroFramework.Controls.MetroTile();
            this.mT_Benutzerverwaltung = new MetroFramework.Controls.MetroTile();
            this.metroProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.mT_ausgabe = new MetroFramework.Controls.MetroTile();
            this.mT_rueckgabe = new MetroFramework.Controls.MetroTile();
            this.panel = new MetroFramework.Controls.MetroPanel();
            this.bt_AutoAusgabe = new MetroFramework.Controls.MetroTile();
            this.bt_zu = new MetroFramework.Controls.MetroTile();
            this.mT_Klassen = new MetroFramework.Controls.MetroTile();
            this.mainStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.bt_help = new MetroFramework.Controls.MetroLink();
            this.bt_darkmode = new MetroFramework.Controls.MetroLink();
            this.bt_logout = new MetroFramework.Controls.MetroLink();
            this.image = new MetroFramework.Controls.MetroLink();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // mT_Kunden
            // 
            this.mT_Kunden.ActiveControl = null;
            this.mT_Kunden.Location = new System.Drawing.Point(498, 5);
            this.mT_Kunden.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Kunden.Name = "mT_Kunden";
            this.mT_Kunden.Size = new System.Drawing.Size(157, 99);
            this.mT_Kunden.Style = MetroFramework.MetroColorStyle.Teal;
            this.mT_Kunden.TabIndex = 6;
            this.mT_Kunden.Text = "Kundenverwaltung";
            this.mT_Kunden.UseSelectable = true;
            this.mT_Kunden.Click += new System.EventHandler(this.bt_Kunden_Click);
            // 
            // mt_Autor
            // 
            this.mt_Autor.ActiveControl = null;
            this.mt_Autor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(173)))));
            this.mt_Autor.Location = new System.Drawing.Point(333, 112);
            this.mt_Autor.Margin = new System.Windows.Forms.Padding(4);
            this.mt_Autor.Name = "mt_Autor";
            this.mt_Autor.Size = new System.Drawing.Size(157, 46);
            this.mt_Autor.TabIndex = 8;
            this.mt_Autor.Text = "Autoren";
            this.mt_Autor.UseCustomBackColor = true;
            this.mt_Autor.UseSelectable = true;
            this.mt_Autor.Click += new System.EventHandler(this.bt_Autoren_Click);
            // 
            // mT_Verlage
            // 
            this.mT_Verlage.ActiveControl = null;
            this.mT_Verlage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(173)))));
            this.mT_Verlage.Location = new System.Drawing.Point(498, 167);
            this.mT_Verlage.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Verlage.Name = "mT_Verlage";
            this.mT_Verlage.Size = new System.Drawing.Size(157, 46);
            this.mT_Verlage.TabIndex = 12;
            this.mT_Verlage.Text = "Verlage";
            this.mT_Verlage.UseCustomBackColor = true;
            this.mT_Verlage.UseSelectable = true;
            this.mT_Verlage.Click += new System.EventHandler(this.bt_Verlage_Click);
            // 
            // mT_Zustand
            // 
            this.mT_Zustand.ActiveControl = null;
            this.mT_Zustand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(173)))));
            this.mT_Zustand.Location = new System.Drawing.Point(498, 221);
            this.mT_Zustand.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Zustand.Name = "mT_Zustand";
            this.mT_Zustand.Size = new System.Drawing.Size(157, 46);
            this.mT_Zustand.TabIndex = 20;
            this.mT_Zustand.Text = "Bücherzustände";
            this.mT_Zustand.UseCustomBackColor = true;
            this.mT_Zustand.UseSelectable = true;
            this.mT_Zustand.Click += new System.EventHandler(this.bt_Zustand_Click);
            // 
            // mT_Sprachen
            // 
            this.mT_Sprachen.ActiveControl = null;
            this.mT_Sprachen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(173)))));
            this.mT_Sprachen.Location = new System.Drawing.Point(333, 167);
            this.mT_Sprachen.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Sprachen.Name = "mT_Sprachen";
            this.mT_Sprachen.Size = new System.Drawing.Size(157, 46);
            this.mT_Sprachen.TabIndex = 11;
            this.mT_Sprachen.Text = "Sprachen";
            this.mT_Sprachen.UseCustomBackColor = true;
            this.mT_Sprachen.UseSelectable = true;
            this.mT_Sprachen.Click += new System.EventHandler(this.bt_Sprachen_Click);
            // 
            // mT_Faecher
            // 
            this.mT_Faecher.ActiveControl = null;
            this.mT_Faecher.BackColor = System.Drawing.Color.CadetBlue;
            this.mT_Faecher.Location = new System.Drawing.Point(498, 112);
            this.mT_Faecher.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Faecher.Name = "mT_Faecher";
            this.mT_Faecher.Size = new System.Drawing.Size(157, 46);
            this.mT_Faecher.Style = MetroFramework.MetroColorStyle.Teal;
            this.mT_Faecher.TabIndex = 9;
            this.mT_Faecher.Text = "Fächer";
            this.mT_Faecher.UseCustomBackColor = true;
            this.mT_Faecher.UseSelectable = true;
            this.mT_Faecher.Click += new System.EventHandler(this.bt_Faecher_Click);
            // 
            // mT_Buecher
            // 
            this.mT_Buecher.ActiveControl = null;
            this.mT_Buecher.Location = new System.Drawing.Point(333, 5);
            this.mT_Buecher.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Buecher.Name = "mT_Buecher";
            this.mT_Buecher.Size = new System.Drawing.Size(157, 99);
            this.mT_Buecher.Style = MetroFramework.MetroColorStyle.Blue;
            this.mT_Buecher.TabIndex = 5;
            this.mT_Buecher.Text = "Bücherverwaltung";
            this.mT_Buecher.UseSelectable = true;
            this.mT_Buecher.Click += new System.EventHandler(this.bt_Buecher_Click);
            // 
            // mT_Genres
            // 
            this.mT_Genres.ActiveControl = null;
            this.mT_Genres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(173)))));
            this.mT_Genres.Location = new System.Drawing.Point(333, 221);
            this.mT_Genres.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Genres.Name = "mT_Genres";
            this.mT_Genres.Size = new System.Drawing.Size(157, 46);
            this.mT_Genres.TabIndex = 19;
            this.mT_Genres.Text = "Genres";
            this.mT_Genres.UseCustomBackColor = true;
            this.mT_Genres.UseSelectable = true;
            this.mT_Genres.Click += new System.EventHandler(this.bt_Genres_Click);
            // 
            // mT_ausleihen
            // 
            this.mT_ausleihen.ActiveControl = null;
            this.mT_ausleihen.Location = new System.Drawing.Point(6, 5);
            this.mT_ausleihen.Margin = new System.Windows.Forms.Padding(4);
            this.mT_ausleihen.Name = "mT_ausleihen";
            this.mT_ausleihen.Size = new System.Drawing.Size(319, 99);
            this.mT_ausleihen.Style = MetroFramework.MetroColorStyle.Lime;
            this.mT_ausleihen.TabIndex = 1;
            this.mT_ausleihen.Text = "Buchübersicht";
            this.mT_ausleihen.UseSelectable = true;
            this.mT_ausleihen.Click += new System.EventHandler(this.bt_Uebersicht_Click);
            // 
            // mT_Einstellungen
            // 
            this.mT_Einstellungen.ActiveControl = null;
            this.mT_Einstellungen.Location = new System.Drawing.Point(663, 221);
            this.mT_Einstellungen.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Einstellungen.Name = "mT_Einstellungen";
            this.mT_Einstellungen.Size = new System.Drawing.Size(157, 46);
            this.mT_Einstellungen.Style = MetroFramework.MetroColorStyle.Silver;
            this.mT_Einstellungen.TabIndex = 21;
            this.mT_Einstellungen.Text = "Einstellungen";
            this.mT_Einstellungen.UseSelectable = true;
            this.mT_Einstellungen.Click += new System.EventHandler(this.bt_Einstellungen_Click);
            // 
            // mT_Benutzerverwaltung
            // 
            this.mT_Benutzerverwaltung.ActiveControl = null;
            this.mT_Benutzerverwaltung.Location = new System.Drawing.Point(663, 5);
            this.mT_Benutzerverwaltung.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Benutzerverwaltung.Name = "mT_Benutzerverwaltung";
            this.mT_Benutzerverwaltung.Size = new System.Drawing.Size(157, 99);
            this.mT_Benutzerverwaltung.Style = MetroFramework.MetroColorStyle.Teal;
            this.mT_Benutzerverwaltung.TabIndex = 7;
            this.mT_Benutzerverwaltung.Text = "Benutzerverwaltung";
            this.mT_Benutzerverwaltung.UseSelectable = true;
            this.mT_Benutzerverwaltung.Click += new System.EventHandler(this.bt_Benutzerverwaltung_Click);
            // 
            // metroProgressBar
            // 
            this.metroProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar.Location = new System.Drawing.Point(0, 0);
            this.metroProgressBar.Margin = new System.Windows.Forms.Padding(2);
            this.metroProgressBar.Name = "metroProgressBar";
            this.metroProgressBar.Size = new System.Drawing.Size(847, 5);
            this.metroProgressBar.Step = 1;
            this.metroProgressBar.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroProgressBar.TabIndex = 9;
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // mT_ausgabe
            // 
            this.mT_ausgabe.ActiveControl = null;
            this.mT_ausgabe.BackColor = System.Drawing.Color.OliveDrab;
            this.mT_ausgabe.Location = new System.Drawing.Point(6, 112);
            this.mT_ausgabe.Name = "mT_ausgabe";
            this.mT_ausgabe.Size = new System.Drawing.Size(157, 101);
            this.mT_ausgabe.Style = MetroFramework.MetroColorStyle.Green;
            this.mT_ausgabe.TabIndex = 2;
            this.mT_ausgabe.Text = "Buchausgabe";
            this.mT_ausgabe.UseSelectable = true;
            this.mT_ausgabe.Click += new System.EventHandler(this.mT_Ausgabe_Click);
            // 
            // mT_rueckgabe
            // 
            this.mT_rueckgabe.ActiveControl = null;
            this.mT_rueckgabe.BackColor = System.Drawing.Color.OliveDrab;
            this.mT_rueckgabe.Location = new System.Drawing.Point(169, 112);
            this.mT_rueckgabe.Name = "mT_rueckgabe";
            this.mT_rueckgabe.Size = new System.Drawing.Size(157, 101);
            this.mT_rueckgabe.Style = MetroFramework.MetroColorStyle.Green;
            this.mT_rueckgabe.TabIndex = 3;
            this.mT_rueckgabe.Text = "Buchrückgabe";
            this.mT_rueckgabe.UseSelectable = true;
            this.mT_rueckgabe.Click += new System.EventHandler(this.mT_Rueckgabe_Click);
            // 
            // panel
            // 
            this.panel.Controls.Add(this.bt_AutoAusgabe);
            this.panel.Controls.Add(this.bt_zu);
            this.panel.Controls.Add(this.mT_Benutzerverwaltung);
            this.panel.Controls.Add(this.mT_Kunden);
            this.panel.Controls.Add(this.mt_Autor);
            this.panel.Controls.Add(this.mT_Verlage);
            this.panel.Controls.Add(this.mT_rueckgabe);
            this.panel.Controls.Add(this.mT_Zustand);
            this.panel.Controls.Add(this.mT_ausgabe);
            this.panel.Controls.Add(this.mT_Sprachen);
            this.panel.Controls.Add(this.mT_Genres);
            this.panel.Controls.Add(this.mT_ausleihen);
            this.panel.Controls.Add(this.mT_Einstellungen);
            this.panel.Controls.Add(this.mT_Buecher);
            this.panel.Controls.Add(this.mT_Klassen);
            this.panel.Controls.Add(this.mT_Faecher);
            this.panel.HorizontalScrollbarBarColor = true;
            this.panel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel.HorizontalScrollbarSize = 10;
            this.panel.Location = new System.Drawing.Point(10, 63);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(830, 274);
            this.panel.TabIndex = 0;
            this.panel.TabStop = true;
            this.panel.VerticalScrollbarBarColor = true;
            this.panel.VerticalScrollbarHighlightOnWheel = false;
            this.panel.VerticalScrollbarSize = 10;
            // 
            // bt_AutoAusgabe
            // 
            this.bt_AutoAusgabe.ActiveControl = null;
            this.bt_AutoAusgabe.BackColor = System.Drawing.Color.Gold;
            this.bt_AutoAusgabe.Location = new System.Drawing.Point(6, 221);
            this.bt_AutoAusgabe.Name = "bt_AutoAusgabe";
            this.bt_AutoAusgabe.Size = new System.Drawing.Size(319, 46);
            this.bt_AutoAusgabe.Style = MetroFramework.MetroColorStyle.Yellow;
            this.bt_AutoAusgabe.TabIndex = 4;
            this.bt_AutoAusgabe.Text = "Automatische Lehrbuchverwaltung";
            this.bt_AutoAusgabe.UseSelectable = true;
            this.bt_AutoAusgabe.Click += new System.EventHandler(this.bt_AutoAusgabe_Click);
            // 
            // bt_zu
            // 
            this.bt_zu.ActiveControl = null;
            this.bt_zu.Location = new System.Drawing.Point(663, 167);
            this.bt_zu.Margin = new System.Windows.Forms.Padding(4);
            this.bt_zu.Name = "bt_zu";
            this.bt_zu.Size = new System.Drawing.Size(157, 46);
            this.bt_zu.Style = MetroFramework.MetroColorStyle.Brown;
            this.bt_zu.TabIndex = 13;
            this.bt_zu.Text = "Zuordnungen";
            this.bt_zu.UseSelectable = true;
            this.bt_zu.Click += new System.EventHandler(this.bt_zu_Click);
            // 
            // mT_Klassen
            // 
            this.mT_Klassen.ActiveControl = null;
            this.mT_Klassen.BackColor = System.Drawing.Color.CadetBlue;
            this.mT_Klassen.Location = new System.Drawing.Point(663, 112);
            this.mT_Klassen.Margin = new System.Windows.Forms.Padding(4);
            this.mT_Klassen.Name = "mT_Klassen";
            this.mT_Klassen.Size = new System.Drawing.Size(157, 46);
            this.mT_Klassen.Style = MetroFramework.MetroColorStyle.Teal;
            this.mT_Klassen.TabIndex = 10;
            this.mT_Klassen.Text = "Klassen";
            this.mT_Klassen.UseCustomBackColor = true;
            this.mT_Klassen.UseSelectable = true;
            this.mT_Klassen.Click += new System.EventHandler(this.MT_Klassen_Click);
            // 
            // mainStyleManager
            // 
            this.mainStyleManager.Owner = this;
            // 
            // bt_help
            // 
            this.bt_help.DisplayFocus = true;
            this.bt_help.Image = global::Bibo_Verwaltung.Properties.Resources.QuestionMark;
            this.bt_help.ImageSize = 24;
            this.bt_help.Location = new System.Drawing.Point(671, 25);
            this.bt_help.Name = "bt_help";
            this.bt_help.Size = new System.Drawing.Size(37, 32);
            this.bt_help.TabIndex = 24;
            this.bt_help.UseSelectable = true;
            this.bt_help.Click += new System.EventHandler(this.bt_help_Click);
            // 
            // bt_darkmode
            // 
            this.bt_darkmode.DisplayFocus = true;
            this.bt_darkmode.Image = global::Bibo_Verwaltung.Properties.Resources.DarkMode;
            this.bt_darkmode.ImageSize = 24;
            this.bt_darkmode.Location = new System.Drawing.Point(714, 25);
            this.bt_darkmode.Name = "bt_darkmode";
            this.bt_darkmode.Size = new System.Drawing.Size(37, 32);
            this.bt_darkmode.TabIndex = 23;
            this.bt_darkmode.UseSelectable = true;
            this.bt_darkmode.Click += new System.EventHandler(this.MetroLink1_Click);
            // 
            // bt_logout
            // 
            this.bt_logout.DisplayFocus = true;
            this.bt_logout.FontWeight = MetroFramework.MetroLinkWeight.Light;
            this.bt_logout.Image = global::Bibo_Verwaltung.Properties.Resources.Exit;
            this.bt_logout.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bt_logout.ImageSize = 24;
            this.bt_logout.Location = new System.Drawing.Point(757, 26);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(83, 31);
            this.bt_logout.TabIndex = 22;
            this.bt_logout.Text = "Abmelden";
            this.bt_logout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bt_logout.UseSelectable = true;
            this.bt_logout.Click += new System.EventHandler(this.mT_Abmelden_Click);
            // 
            // image
            // 
            this.image.Image = global::Bibo_Verwaltung.Properties.Resources.greenLib;
            this.image.ImageSize = 32;
            this.image.Location = new System.Drawing.Point(10, 21);
            this.image.Margin = new System.Windows.Forms.Padding(2);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(32, 32);
            this.image.TabIndex = 25;
            this.image.TabStop = false;
            this.image.UseSelectable = true;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // w_s_main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(847, 346);
            this.Controls.Add(this.bt_help);
            this.Controls.Add(this.bt_darkmode);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.metroProgressBar);
            this.Controls.Add(this.image);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_main";
            this.Padding = new System.Windows.Forms.Padding(9, 60, 9, 8);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Text = "     greenLib";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Activated += new System.EventHandler(this.w_s_main_Activated);
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroTile mT_Kunden;
        private MetroFramework.Controls.MetroTile mt_Autor;
        private MetroFramework.Controls.MetroTile mT_Verlage;
        private MetroFramework.Controls.MetroTile mT_Zustand;
        private MetroFramework.Controls.MetroTile mT_Sprachen;
        private MetroFramework.Controls.MetroTile mT_Faecher;
        private MetroFramework.Controls.MetroTile mT_Buecher;
        private MetroFramework.Controls.MetroTile mT_Genres;
        private MetroFramework.Controls.MetroTile mT_ausleihen;
        private MetroFramework.Controls.MetroTile mT_Einstellungen;
        private MetroFramework.Controls.MetroTile mT_Benutzerverwaltung;
        private MetroFramework.Controls.MetroLink image;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroTile mT_ausgabe;
        private MetroFramework.Controls.MetroTile mT_rueckgabe;
        private MetroFramework.Controls.MetroPanel panel;
        private MetroFramework.Controls.MetroTile bt_zu;
        private MetroFramework.Controls.MetroTile bt_AutoAusgabe;
        private MetroFramework.Controls.MetroTile mT_Klassen;
        private MetroFramework.Controls.MetroLink bt_logout;
        private MetroFramework.Components.MetroStyleManager mainStyleManager;
        private MetroFramework.Controls.MetroLink bt_darkmode;
        private MetroFramework.Controls.MetroLink bt_help;
    }
}
