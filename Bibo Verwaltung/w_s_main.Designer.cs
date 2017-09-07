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
            this.bt_Einstellungen = new System.Windows.Forms.Button();
            this.bt_Buecher = new System.Windows.Forms.Button();
            this.gb_Uebersicht = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lb_Ausleihzahl = new System.Windows.Forms.Label();
            this.lb_Ausgeliehen = new System.Windows.Forms.Label();
            this.lb_Lagerzahl = new System.Windows.Forms.Label();
            this.lb_IstBestand = new System.Windows.Forms.Label();
            this.lb_Bestandzahl = new System.Windows.Forms.Label();
            this.lb_Bestand = new System.Windows.Forms.Label();
            this.bt_Suchen_Ausleihen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_Uebersicht.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Sprachen
            // 
            this.bt_Sprachen.Location = new System.Drawing.Point(565, 312);
            this.bt_Sprachen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Sprachen.Name = "bt_Sprachen";
            this.bt_Sprachen.Size = new System.Drawing.Size(533, 119);
            this.bt_Sprachen.TabIndex = 5;
            this.bt_Sprachen.Text = "Sprachen";
            this.bt_Sprachen.UseVisualStyleBackColor = true;
            this.bt_Sprachen.Click += new System.EventHandler(this.bt_Sprachen_Click);
            // 
            // bt_Verlage
            // 
            this.bt_Verlage.Location = new System.Drawing.Point(16, 312);
            this.bt_Verlage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Verlage.Name = "bt_Verlage";
            this.bt_Verlage.Size = new System.Drawing.Size(533, 119);
            this.bt_Verlage.TabIndex = 4;
            this.bt_Verlage.Text = "Verlage";
            this.bt_Verlage.UseVisualStyleBackColor = true;
            this.bt_Verlage.Click += new System.EventHandler(this.bt_Verlage_Click);
            // 
            // bt_Genres
            // 
            this.bt_Genres.Location = new System.Drawing.Point(565, 179);
            this.bt_Genres.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Genres.Name = "bt_Genres";
            this.bt_Genres.Size = new System.Drawing.Size(533, 119);
            this.bt_Genres.TabIndex = 3;
            this.bt_Genres.Text = "Genres";
            this.bt_Genres.UseVisualStyleBackColor = true;
            this.bt_Genres.Click += new System.EventHandler(this.bt_Genres_Click);
            // 
            // bt_Autoren
            // 
            this.bt_Autoren.Location = new System.Drawing.Point(16, 179);
            this.bt_Autoren.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Autoren.Name = "bt_Autoren";
            this.bt_Autoren.Size = new System.Drawing.Size(533, 119);
            this.bt_Autoren.TabIndex = 2;
            this.bt_Autoren.Text = "Autoren";
            this.bt_Autoren.UseVisualStyleBackColor = true;
            this.bt_Autoren.Click += new System.EventHandler(this.bt_Autoren_Click);
            // 
            // bt_Kunden
            // 
            this.bt_Kunden.Location = new System.Drawing.Point(16, 45);
            this.bt_Kunden.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Kunden.Name = "bt_Kunden";
            this.bt_Kunden.Size = new System.Drawing.Size(533, 119);
            this.bt_Kunden.TabIndex = 0;
            this.bt_Kunden.Text = "Kunden";
            this.bt_Kunden.UseVisualStyleBackColor = true;
            this.bt_Kunden.Click += new System.EventHandler(this.bt_Kunden_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Einstellungen);
            this.groupBox1.Controls.Add(this.bt_Buecher);
            this.groupBox1.Controls.Add(this.bt_Sprachen);
            this.groupBox1.Controls.Add(this.bt_Verlage);
            this.groupBox1.Controls.Add(this.bt_Genres);
            this.groupBox1.Controls.Add(this.bt_Autoren);
            this.groupBox1.Controls.Add(this.bt_Kunden);
            this.groupBox1.Location = new System.Drawing.Point(409, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.groupBox1.Size = new System.Drawing.Size(1115, 677);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verwaltung von:";
            // 
            // bt_Einstellungen
            // 
            this.bt_Einstellungen.Location = new System.Drawing.Point(891, 608);
            this.bt_Einstellungen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Einstellungen.Name = "bt_Einstellungen";
            this.bt_Einstellungen.Size = new System.Drawing.Size(208, 55);
            this.bt_Einstellungen.TabIndex = 6;
            this.bt_Einstellungen.Text = "Einstellungen";
            this.bt_Einstellungen.UseVisualStyleBackColor = true;
            this.bt_Einstellungen.Click += new System.EventHandler(this.bt_Einstellungen_Click);
            // 
            // bt_Buecher
            // 
            this.bt_Buecher.Location = new System.Drawing.Point(565, 45);
            this.bt_Buecher.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Buecher.Name = "bt_Buecher";
            this.bt_Buecher.Size = new System.Drawing.Size(533, 119);
            this.bt_Buecher.TabIndex = 1;
            this.bt_Buecher.Text = "Bücher";
            this.bt_Buecher.UseVisualStyleBackColor = true;
            this.bt_Buecher.Click += new System.EventHandler(this.bt_Buecher_Click);
            // 
            // gb_Uebersicht
            // 
            this.gb_Uebersicht.Controls.Add(this.linkLabel1);
            this.gb_Uebersicht.Controls.Add(this.lb_Ausleihzahl);
            this.gb_Uebersicht.Controls.Add(this.lb_Ausgeliehen);
            this.gb_Uebersicht.Controls.Add(this.lb_Lagerzahl);
            this.gb_Uebersicht.Controls.Add(this.lb_IstBestand);
            this.gb_Uebersicht.Controls.Add(this.lb_Bestandzahl);
            this.gb_Uebersicht.Controls.Add(this.lb_Bestand);
            this.gb_Uebersicht.Location = new System.Drawing.Point(32, 29);
            this.gb_Uebersicht.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_Uebersicht.Name = "gb_Uebersicht";
            this.gb_Uebersicht.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_Uebersicht.Size = new System.Drawing.Size(1043, 405);
            this.gb_Uebersicht.TabIndex = 1;
            this.gb_Uebersicht.TabStop = false;
            this.gb_Uebersicht.Text = "Gesamtübersicht:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(429, 60);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(146, 32);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lb_Ausleihzahl
            // 
            this.lb_Ausleihzahl.AutoSize = true;
            this.lb_Ausleihzahl.Location = new System.Drawing.Point(309, 179);
            this.lb_Ausleihzahl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Ausleihzahl.Name = "lb_Ausleihzahl";
            this.lb_Ausleihzahl.Size = new System.Drawing.Size(24, 32);
            this.lb_Ausleihzahl.TabIndex = 4;
            this.lb_Ausleihzahl.Text = "-";
            // 
            // lb_Ausgeliehen
            // 
            this.lb_Ausgeliehen.AutoSize = true;
            this.lb_Ausgeliehen.Location = new System.Drawing.Point(16, 179);
            this.lb_Ausgeliehen.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Ausgeliehen.Name = "lb_Ausgeliehen";
            this.lb_Ausgeliehen.Size = new System.Drawing.Size(276, 32);
            this.lb_Ausgeliehen.TabIndex = 2;
            this.lb_Ausgeliehen.Text = "Bücher ausgeliehen:";
            // 
            // lb_Lagerzahl
            // 
            this.lb_Lagerzahl.AutoSize = true;
            this.lb_Lagerzahl.Location = new System.Drawing.Point(309, 119);
            this.lb_Lagerzahl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Lagerzahl.Name = "lb_Lagerzahl";
            this.lb_Lagerzahl.Size = new System.Drawing.Size(24, 32);
            this.lb_Lagerzahl.TabIndex = 3;
            this.lb_Lagerzahl.Text = "-";
            // 
            // lb_IstBestand
            // 
            this.lb_IstBestand.AutoSize = true;
            this.lb_IstBestand.Location = new System.Drawing.Point(16, 119);
            this.lb_IstBestand.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_IstBestand.Name = "lb_IstBestand";
            this.lb_IstBestand.Size = new System.Drawing.Size(230, 32);
            this.lb_IstBestand.TabIndex = 1;
            this.lb_IstBestand.Text = "Bücher im Lager:";
            // 
            // lb_Bestandzahl
            // 
            this.lb_Bestandzahl.AutoSize = true;
            this.lb_Bestandzahl.Location = new System.Drawing.Point(309, 60);
            this.lb_Bestandzahl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Bestandzahl.Name = "lb_Bestandzahl";
            this.lb_Bestandzahl.Size = new System.Drawing.Size(24, 32);
            this.lb_Bestandzahl.TabIndex = 2;
            this.lb_Bestandzahl.Text = "-";
            // 
            // lb_Bestand
            // 
            this.lb_Bestand.AutoSize = true;
            this.lb_Bestand.Location = new System.Drawing.Point(16, 60);
            this.lb_Bestand.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Bestand.Name = "lb_Bestand";
            this.lb_Bestand.Size = new System.Drawing.Size(262, 32);
            this.lb_Bestand.TabIndex = 0;
            this.lb_Bestand.Text = "Bücher im Bestand:";
            // 
            // bt_Suchen_Ausleihen
            // 
            this.bt_Suchen_Ausleihen.Location = new System.Drawing.Point(21, 188);
            this.bt_Suchen_Ausleihen.Name = "bt_Suchen_Ausleihen";
            this.bt_Suchen_Ausleihen.Size = new System.Drawing.Size(200, 50);
            this.bt_Suchen_Ausleihen.TabIndex = 11;
            this.bt_Suchen_Ausleihen.Text = "Bücher Suchen/Ausleihen";
            this.bt_Suchen_Ausleihen.UseVisualStyleBackColor = true;
            this.bt_Suchen_Ausleihen.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // w_s_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 305);
            this.Controls.Add(this.bt_Suchen_Ausleihen);
            this.Controls.Add(this.gb_Uebersicht);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "w_s_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bibliotheksverwaltung";
            this.Activated += new System.EventHandler(this.Load_All);
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
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button bt_Einstellungen;
        private System.Windows.Forms.Button bt_Suchen_Ausleihen;
    }
}