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
            this.bt_Sprachen = new System.Windows.Forms.Button();
            this.bt_Verlage = new System.Windows.Forms.Button();
            this.bt_Genres = new System.Windows.Forms.Button();
            this.bt_Autoren = new System.Windows.Forms.Button();
            this.bt_Kunden = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bt_Zustand = new System.Windows.Forms.Button();
            this.bt_Einstellungen = new System.Windows.Forms.Button();
            this.bt_Buecher = new System.Windows.Forms.Button();
            this.gb_Uebersicht = new System.Windows.Forms.GroupBox();
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_Benutzerverwaltung = new System.Windows.Forms.Button();
            this.bt_Suchen_Ausleihen = new System.Windows.Forms.Button();
            this.lb_Ausleihzahl = new System.Windows.Forms.Label();
            this.lb_Ausgeliehen = new System.Windows.Forms.Label();
            this.lb_Lagerzahl = new System.Windows.Forms.Label();
            this.lb_IstBestand = new System.Windows.Forms.Label();
            this.lb_Bestandzahl = new System.Windows.Forms.Label();
            this.lb_Bestand = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.groupBox1.SuspendLayout();
            this.gb_Uebersicht.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Sprachen
            // 
            this.helpProvider.SetHelpString(this.bt_Sprachen, "Klicken sie auf \"Sprachen\", um ihre gespeicherten Sprachen anzuzeigen, neue hinzu" +
        "zufügen, bestehende zu bearbeiten oder zu löschen. ");
            this.bt_Sprachen.Location = new System.Drawing.Point(256, 137);
            this.bt_Sprachen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Sprachen.Name = "bt_Sprachen";
            this.helpProvider.SetShowHelp(this.bt_Sprachen, true);
            this.bt_Sprachen.Size = new System.Drawing.Size(240, 49);
            this.bt_Sprachen.TabIndex = 5;
            this.bt_Sprachen.Text = "Sprachen";
            this.bt_Sprachen.UseVisualStyleBackColor = true;
            this.bt_Sprachen.Click += new System.EventHandler(this.bt_Sprachen_Click);
            // 
            // bt_Verlage
            // 
            this.helpProvider.SetHelpString(this.bt_Verlage, "Klicken sie auf \"Verlage\", um ihre gespeicherten Verlage anzuzeigen, neue hinzuzu" +
        "fügen, bestehende zu bearbeiten oder zu löschen. ");
            this.bt_Verlage.Location = new System.Drawing.Point(8, 137);
            this.bt_Verlage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Verlage.Name = "bt_Verlage";
            this.helpProvider.SetShowHelp(this.bt_Verlage, true);
            this.bt_Verlage.Size = new System.Drawing.Size(240, 49);
            this.bt_Verlage.TabIndex = 4;
            this.bt_Verlage.Text = "Verlage";
            this.bt_Verlage.UseVisualStyleBackColor = true;
            this.bt_Verlage.Click += new System.EventHandler(this.bt_Verlage_Click);
            // 
            // bt_Genres
            // 
            this.helpProvider.SetHelpString(this.bt_Genres, "Klicken sie auf \"Genres\", um ihre gespeicherten Genres anzuzeigen, neue hinzuzufü" +
        "gen, bestehende zu bearbeiten oder zu löschen. ");
            this.bt_Genres.Location = new System.Drawing.Point(256, 80);
            this.bt_Genres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Genres.Name = "bt_Genres";
            this.helpProvider.SetShowHelp(this.bt_Genres, true);
            this.bt_Genres.Size = new System.Drawing.Size(240, 49);
            this.bt_Genres.TabIndex = 3;
            this.bt_Genres.Text = "Genres";
            this.bt_Genres.UseVisualStyleBackColor = true;
            this.bt_Genres.Click += new System.EventHandler(this.bt_Genres_Click);
            // 
            // bt_Autoren
            // 
            this.helpProvider.SetHelpString(this.bt_Autoren, "Klicken sie auf \"Autoren\", um ihre gespeicherten Autoren anzuzeigen, neue hinzuzu" +
        "fügen, bestehende zu bearbeiten oder zu löschen. ");
            this.bt_Autoren.Location = new System.Drawing.Point(8, 80);
            this.bt_Autoren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Autoren.Name = "bt_Autoren";
            this.helpProvider.SetShowHelp(this.bt_Autoren, true);
            this.bt_Autoren.Size = new System.Drawing.Size(240, 49);
            this.bt_Autoren.TabIndex = 2;
            this.bt_Autoren.Text = "Autoren";
            this.bt_Autoren.UseVisualStyleBackColor = true;
            this.bt_Autoren.Click += new System.EventHandler(this.bt_Autoren_Click);
            // 
            // bt_Kunden
            // 
            this.helpProvider.SetHelpString(this.bt_Kunden, "Klicken sie auf \"Kunden\", um ihre gespeicherten Kunden anzuzeigen, neue hinzuzufü" +
        "gen, bestehende zu bearbeiten oder zu löschen. ");
            this.bt_Kunden.Location = new System.Drawing.Point(8, 23);
            this.bt_Kunden.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Kunden.Name = "bt_Kunden";
            this.helpProvider.SetShowHelp(this.bt_Kunden, true);
            this.bt_Kunden.Size = new System.Drawing.Size(240, 49);
            this.bt_Kunden.TabIndex = 0;
            this.bt_Kunden.Text = "Kunden";
            this.bt_Kunden.UseVisualStyleBackColor = true;
            this.bt_Kunden.Click += new System.EventHandler(this.bt_Kunden_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Zustand);
            this.groupBox1.Controls.Add(this.bt_Einstellungen);
            this.groupBox1.Controls.Add(this.bt_Buecher);
            this.groupBox1.Controls.Add(this.bt_Sprachen);
            this.groupBox1.Controls.Add(this.bt_Verlage);
            this.groupBox1.Controls.Add(this.bt_Genres);
            this.groupBox1.Controls.Add(this.bt_Autoren);
            this.groupBox1.Controls.Add(this.bt_Kunden);
            this.groupBox1.Location = new System.Drawing.Point(272, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(500, 253);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verwaltung von:";
            // 
            // bt_Zustand
            // 
            this.helpProvider.SetHelpString(this.bt_Zustand, "Klicken sie auf \"Zustand\", um ihre gespeicherten Zustände anzuzeigen, neue hinzuz" +
        "ufügen, bestehende zu bearbeiten oder zu löschen. ");
            this.bt_Zustand.Location = new System.Drawing.Point(8, 193);
            this.bt_Zustand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Zustand.Name = "bt_Zustand";
            this.helpProvider.SetShowHelp(this.bt_Zustand, true);
            this.bt_Zustand.Size = new System.Drawing.Size(240, 49);
            this.bt_Zustand.TabIndex = 7;
            this.bt_Zustand.Text = "Zustand";
            this.bt_Zustand.UseVisualStyleBackColor = true;
            this.bt_Zustand.Click += new System.EventHandler(this.bt_Zustand_Click);
            // 
            // bt_Einstellungen
            // 
            this.helpProvider.SetHelpString(this.bt_Einstellungen, "Klicken sie auf \"Einstellungen\", um Änderungen an ihrer Datenbankverbindung vorzu" +
        "nehmen.");
            this.bt_Einstellungen.Location = new System.Drawing.Point(256, 193);
            this.bt_Einstellungen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Einstellungen.Name = "bt_Einstellungen";
            this.helpProvider.SetShowHelp(this.bt_Einstellungen, true);
            this.bt_Einstellungen.Size = new System.Drawing.Size(240, 49);
            this.bt_Einstellungen.TabIndex = 6;
            this.bt_Einstellungen.Text = "Einstellungen";
            this.bt_Einstellungen.UseVisualStyleBackColor = true;
            this.bt_Einstellungen.Click += new System.EventHandler(this.bt_Einstellungen_Click);
            // 
            // bt_Buecher
            // 
            this.helpProvider.SetHelpString(this.bt_Buecher, "Klicken sie auf \"Bücher\", um ihre gespeicherten Bücher anzuzeigen, neue hinzuzufü" +
        "gen, bestehende zu bearbeiten oder zu löschen. ");
            this.bt_Buecher.Location = new System.Drawing.Point(256, 23);
            this.bt_Buecher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Buecher.Name = "bt_Buecher";
            this.helpProvider.SetShowHelp(this.bt_Buecher, true);
            this.bt_Buecher.Size = new System.Drawing.Size(240, 49);
            this.bt_Buecher.TabIndex = 1;
            this.bt_Buecher.Text = "Bücher";
            this.bt_Buecher.UseVisualStyleBackColor = true;
            this.bt_Buecher.Click += new System.EventHandler(this.bt_Buecher_Click);
            // 
            // gb_Uebersicht
            // 
            this.gb_Uebersicht.Controls.Add(this.bt_logout);
            this.gb_Uebersicht.Controls.Add(this.bt_Benutzerverwaltung);
            this.gb_Uebersicht.Controls.Add(this.bt_Suchen_Ausleihen);
            this.gb_Uebersicht.Controls.Add(this.lb_Ausleihzahl);
            this.gb_Uebersicht.Controls.Add(this.lb_Ausgeliehen);
            this.gb_Uebersicht.Controls.Add(this.lb_Lagerzahl);
            this.gb_Uebersicht.Controls.Add(this.lb_IstBestand);
            this.gb_Uebersicht.Controls.Add(this.lb_Bestandzahl);
            this.gb_Uebersicht.Controls.Add(this.lb_Bestand);
            this.helpProvider.SetHelpString(this.gb_Uebersicht, "In der Gesamtübersicht sehen sie auf einem Blick, wie viele Bücher sich in ihrem " +
        "Bestand bzw. Lager befindet, sowie wie viele Bücher momentan ausgeliehen sind.");
            this.gb_Uebersicht.Location = new System.Drawing.Point(14, 13);
            this.gb_Uebersicht.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Uebersicht.Name = "gb_Uebersicht";
            this.gb_Uebersicht.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.helpProvider.SetShowHelp(this.gb_Uebersicht, true);
            this.gb_Uebersicht.Size = new System.Drawing.Size(254, 253);
            this.gb_Uebersicht.TabIndex = 1;
            this.gb_Uebersicht.TabStop = false;
            this.gb_Uebersicht.Text = "Gesamtübersicht:";
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(11, 199);
            this.bt_logout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(82, 43);
            this.bt_logout.TabIndex = 12;
            this.bt_logout.Text = "Abmelden";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_Benutzerverwaltung
            // 
            this.bt_Benutzerverwaltung.Location = new System.Drawing.Point(97, 199);
            this.bt_Benutzerverwaltung.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Benutzerverwaltung.Name = "bt_Benutzerverwaltung";
            this.bt_Benutzerverwaltung.Size = new System.Drawing.Size(151, 43);
            this.bt_Benutzerverwaltung.TabIndex = 2;
            this.bt_Benutzerverwaltung.Text = "Benutzerverwaltung";
            this.bt_Benutzerverwaltung.UseVisualStyleBackColor = true;
            this.bt_Benutzerverwaltung.Click += new System.EventHandler(this.bt_Benutzerverwaltung_Click);
            // 
            // bt_Suchen_Ausleihen
            // 
            this.helpProvider.SetHelpString(this.bt_Suchen_Ausleihen, "Starten sie Ausleihvorgänge, Buchrückgaben oder sehen sie, von wem bestimmte Büch" +
        "er ausgeliehen wurden.");
            this.bt_Suchen_Ausleihen.Location = new System.Drawing.Point(10, 137);
            this.bt_Suchen_Ausleihen.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.bt_Suchen_Ausleihen.Name = "bt_Suchen_Ausleihen";
            this.helpProvider.SetShowHelp(this.bt_Suchen_Ausleihen, true);
            this.bt_Suchen_Ausleihen.Size = new System.Drawing.Size(240, 49);
            this.bt_Suchen_Ausleihen.TabIndex = 11;
            this.bt_Suchen_Ausleihen.Text = "Bücher Suchen/Ausleihen";
            this.bt_Suchen_Ausleihen.UseVisualStyleBackColor = true;
            this.bt_Suchen_Ausleihen.Click += new System.EventHandler(this.bt_Suchen_Ausleihen_Click);
            // 
            // lb_Ausleihzahl
            // 
            this.lb_Ausleihzahl.AutoSize = true;
            this.lb_Ausleihzahl.Location = new System.Drawing.Point(154, 92);
            this.lb_Ausleihzahl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Ausleihzahl.Name = "lb_Ausleihzahl";
            this.lb_Ausleihzahl.Size = new System.Drawing.Size(13, 17);
            this.lb_Ausleihzahl.TabIndex = 4;
            this.lb_Ausleihzahl.Text = "-";
            // 
            // lb_Ausgeliehen
            // 
            this.lb_Ausgeliehen.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Ausgeliehen, "In diesem Feld wird ihnen die aktuelle Anzahl von Bücheren angezeigt, welche mome" +
        "ntan ausgeliehen sind.");
            this.lb_Ausgeliehen.Location = new System.Drawing.Point(8, 92);
            this.lb_Ausgeliehen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Ausgeliehen.Name = "lb_Ausgeliehen";
            this.helpProvider.SetShowHelp(this.lb_Ausgeliehen, true);
            this.lb_Ausgeliehen.Size = new System.Drawing.Size(138, 17);
            this.lb_Ausgeliehen.TabIndex = 2;
            this.lb_Ausgeliehen.Text = "Bücher ausgeliehen:";
            // 
            // lb_Lagerzahl
            // 
            this.lb_Lagerzahl.AutoSize = true;
            this.lb_Lagerzahl.Location = new System.Drawing.Point(154, 61);
            this.lb_Lagerzahl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Lagerzahl.Name = "lb_Lagerzahl";
            this.lb_Lagerzahl.Size = new System.Drawing.Size(13, 17);
            this.lb_Lagerzahl.TabIndex = 3;
            this.lb_Lagerzahl.Text = "-";
            // 
            // lb_IstBestand
            // 
            this.lb_IstBestand.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_IstBestand, "In diesem Feld wird ihnen die aktuelle Anzahl von Bücheren angezeigt, welche sich" +
        " im Lager befinden.");
            this.lb_IstBestand.Location = new System.Drawing.Point(8, 61);
            this.lb_IstBestand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_IstBestand.Name = "lb_IstBestand";
            this.helpProvider.SetShowHelp(this.lb_IstBestand, true);
            this.lb_IstBestand.Size = new System.Drawing.Size(116, 17);
            this.lb_IstBestand.TabIndex = 1;
            this.lb_IstBestand.Text = "Bücher im Lager:";
            // 
            // lb_Bestandzahl
            // 
            this.lb_Bestandzahl.AutoSize = true;
            this.lb_Bestandzahl.Location = new System.Drawing.Point(154, 31);
            this.lb_Bestandzahl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Bestandzahl.Name = "lb_Bestandzahl";
            this.lb_Bestandzahl.Size = new System.Drawing.Size(13, 17);
            this.lb_Bestandzahl.TabIndex = 2;
            this.lb_Bestandzahl.Text = "-";
            // 
            // lb_Bestand
            // 
            this.lb_Bestand.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Bestand, "In diesem Feld wird ihnen die aktuelle Anzahl von Bücheren angezeigt, welche sich" +
        " im Bestand befinden.");
            this.lb_Bestand.Location = new System.Drawing.Point(8, 31);
            this.lb_Bestand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Bestand.Name = "lb_Bestand";
            this.helpProvider.SetShowHelp(this.lb_Bestand, true);
            this.lb_Bestand.Size = new System.Drawing.Size(131, 17);
            this.lb_Bestand.TabIndex = 0;
            this.lb_Bestand.Text = "Bücher im Bestand:";
            // 
            // w_s_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 278);
            this.Controls.Add(this.gb_Uebersicht);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotheksverwaltung";
            this.Activated += new System.EventHandler(this.Load_Uebersicht);
            this.groupBox1.ResumeLayout(false);
            this.gb_Uebersicht.ResumeLayout(false);
            this.gb_Uebersicht.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Sprachen;
        private System.Windows.Forms.Button bt_Verlage;
        private System.Windows.Forms.Button bt_Genres;
        private System.Windows.Forms.Button bt_Autoren;
        private System.Windows.Forms.Button bt_Kunden;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bt_Buecher;
        private System.Windows.Forms.GroupBox gb_Uebersicht;
        private System.Windows.Forms.Label lb_Ausleihzahl;
        private System.Windows.Forms.Label lb_Ausgeliehen;
        private System.Windows.Forms.Label lb_Lagerzahl;
        private System.Windows.Forms.Label lb_IstBestand;
        private System.Windows.Forms.Label lb_Bestandzahl;
        private System.Windows.Forms.Label lb_Bestand;
        private System.Windows.Forms.Button bt_Einstellungen;
        private System.Windows.Forms.Button bt_Suchen_Ausleihen;
        private System.Windows.Forms.Button bt_Zustand;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Button bt_Benutzerverwaltung;
        private System.Windows.Forms.Button bt_logout;
    }
}