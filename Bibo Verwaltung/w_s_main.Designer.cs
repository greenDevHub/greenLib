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
            this.bt_Buecher = new System.Windows.Forms.Button();
            this.gb_Uebersicht = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lb_Ausleihzahl = new System.Windows.Forms.Label();
            this.lb_Ausgeliehen = new System.Windows.Forms.Label();
            this.lb_Lagerzahl = new System.Windows.Forms.Label();
            this.lb_IstBestand = new System.Windows.Forms.Label();
            this.lb_Bestandzahl = new System.Windows.Forms.Label();
            this.lb_Bestand = new System.Windows.Forms.Label();
            this.gb_Leihen = new System.Windows.Forms.GroupBox();
            this.bt_Suchen_Buecher = new System.Windows.Forms.Button();
            this.Grid_Buch = new System.Windows.Forms.DataGridView();
            this.gb_IstVorhanden = new System.Windows.Forms.GroupBox();
            this.lb_SuchErgebnisse = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.ch_Buch_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Titel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_Verlag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rb_SuchVerlag = new System.Windows.Forms.RadioButton();
            this.rb_SuchAutor = new System.Windows.Forms.RadioButton();
            this.rb_SuchGenre = new System.Windows.Forms.RadioButton();
            this.rb_SuchTitel = new System.Windows.Forms.RadioButton();
            this.cb_Verlag = new System.Windows.Forms.ComboBox();
            this.lb_Verlag = new System.Windows.Forms.Label();
            this.cb_Autor = new System.Windows.Forms.ComboBox();
            this.tb_Titel = new System.Windows.Forms.TextBox();
            this.lb_Autor = new System.Windows.Forms.Label();
            this.lb_Titel = new System.Windows.Forms.Label();
            this.lb_Genre = new System.Windows.Forms.Label();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            this.bt_Suchen = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gb_Uebersicht.SuspendLayout();
            this.gb_Leihen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Buch)).BeginInit();
            this.gb_IstVorhanden.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Sprachen
            // 
            this.bt_Sprachen.Location = new System.Drawing.Point(212, 131);
            this.bt_Sprachen.Name = "bt_Sprachen";
            this.bt_Sprachen.Size = new System.Drawing.Size(200, 50);
            this.bt_Sprachen.TabIndex = 5;
            this.bt_Sprachen.Text = "Sprachen";
            this.bt_Sprachen.UseVisualStyleBackColor = true;
            this.bt_Sprachen.Click += new System.EventHandler(this.bt_Sprachen_Click);
            // 
            // bt_Verlage
            // 
            this.bt_Verlage.Location = new System.Drawing.Point(6, 131);
            this.bt_Verlage.Name = "bt_Verlage";
            this.bt_Verlage.Size = new System.Drawing.Size(200, 50);
            this.bt_Verlage.TabIndex = 4;
            this.bt_Verlage.Text = "Verlage";
            this.bt_Verlage.UseVisualStyleBackColor = true;
            this.bt_Verlage.Click += new System.EventHandler(this.bt_Verlage_Click);
            // 
            // bt_Genres
            // 
            this.bt_Genres.Location = new System.Drawing.Point(212, 75);
            this.bt_Genres.Name = "bt_Genres";
            this.bt_Genres.Size = new System.Drawing.Size(200, 50);
            this.bt_Genres.TabIndex = 3;
            this.bt_Genres.Text = "Genres";
            this.bt_Genres.UseVisualStyleBackColor = true;
            this.bt_Genres.Click += new System.EventHandler(this.bt_Genres_Click);
            // 
            // bt_Autoren
            // 
            this.bt_Autoren.Location = new System.Drawing.Point(6, 75);
            this.bt_Autoren.Name = "bt_Autoren";
            this.bt_Autoren.Size = new System.Drawing.Size(200, 50);
            this.bt_Autoren.TabIndex = 2;
            this.bt_Autoren.Text = "Autoren";
            this.bt_Autoren.UseVisualStyleBackColor = true;
            this.bt_Autoren.Click += new System.EventHandler(this.bt_Autoren_Click);
            // 
            // bt_Kunden
            // 
            this.bt_Kunden.Location = new System.Drawing.Point(6, 19);
            this.bt_Kunden.Name = "bt_Kunden";
            this.bt_Kunden.Size = new System.Drawing.Size(200, 50);
            this.bt_Kunden.TabIndex = 0;
            this.bt_Kunden.Text = "Kunden";
            this.bt_Kunden.UseVisualStyleBackColor = true;
            this.bt_Kunden.Click += new System.EventHandler(this.bt_Kunden_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bt_Buecher);
            this.groupBox1.Controls.Add(this.bt_Sprachen);
            this.groupBox1.Controls.Add(this.bt_Verlage);
            this.groupBox1.Controls.Add(this.bt_Genres);
            this.groupBox1.Controls.Add(this.bt_Autoren);
            this.groupBox1.Controls.Add(this.bt_Kunden);
            this.groupBox1.Location = new System.Drawing.Point(409, 338);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(418, 284);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verwaltung von:";
            // 
            // bt_Buecher
            // 
            this.bt_Buecher.Location = new System.Drawing.Point(212, 19);
            this.bt_Buecher.Name = "bt_Buecher";
            this.bt_Buecher.Size = new System.Drawing.Size(200, 50);
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
            this.gb_Uebersicht.Location = new System.Drawing.Point(12, 12);
            this.gb_Uebersicht.Name = "gb_Uebersicht";
            this.gb_Uebersicht.Size = new System.Drawing.Size(391, 170);
            this.gb_Uebersicht.TabIndex = 1;
            this.gb_Uebersicht.TabStop = false;
            this.gb_Uebersicht.Text = "Gesamtübersicht:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(161, 25);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lb_Ausleihzahl
            // 
            this.lb_Ausleihzahl.AutoSize = true;
            this.lb_Ausleihzahl.Location = new System.Drawing.Point(116, 75);
            this.lb_Ausleihzahl.Name = "lb_Ausleihzahl";
            this.lb_Ausleihzahl.Size = new System.Drawing.Size(10, 13);
            this.lb_Ausleihzahl.TabIndex = 4;
            this.lb_Ausleihzahl.Text = "-";
            // 
            // lb_Ausgeliehen
            // 
            this.lb_Ausgeliehen.AutoSize = true;
            this.lb_Ausgeliehen.Location = new System.Drawing.Point(6, 75);
            this.lb_Ausgeliehen.Name = "lb_Ausgeliehen";
            this.lb_Ausgeliehen.Size = new System.Drawing.Size(104, 13);
            this.lb_Ausgeliehen.TabIndex = 2;
            this.lb_Ausgeliehen.Text = "Bücher ausgeliehen:";
            // 
            // lb_Lagerzahl
            // 
            this.lb_Lagerzahl.AutoSize = true;
            this.lb_Lagerzahl.Location = new System.Drawing.Point(116, 50);
            this.lb_Lagerzahl.Name = "lb_Lagerzahl";
            this.lb_Lagerzahl.Size = new System.Drawing.Size(10, 13);
            this.lb_Lagerzahl.TabIndex = 3;
            this.lb_Lagerzahl.Text = "-";
            // 
            // lb_IstBestand
            // 
            this.lb_IstBestand.AutoSize = true;
            this.lb_IstBestand.Location = new System.Drawing.Point(6, 50);
            this.lb_IstBestand.Name = "lb_IstBestand";
            this.lb_IstBestand.Size = new System.Drawing.Size(87, 13);
            this.lb_IstBestand.TabIndex = 1;
            this.lb_IstBestand.Text = "Bücher im Lager:";
            // 
            // lb_Bestandzahl
            // 
            this.lb_Bestandzahl.AutoSize = true;
            this.lb_Bestandzahl.Location = new System.Drawing.Point(116, 25);
            this.lb_Bestandzahl.Name = "lb_Bestandzahl";
            this.lb_Bestandzahl.Size = new System.Drawing.Size(10, 13);
            this.lb_Bestandzahl.TabIndex = 2;
            this.lb_Bestandzahl.Text = "-";
            // 
            // lb_Bestand
            // 
            this.lb_Bestand.AutoSize = true;
            this.lb_Bestand.Location = new System.Drawing.Point(6, 25);
            this.lb_Bestand.Name = "lb_Bestand";
            this.lb_Bestand.Size = new System.Drawing.Size(99, 13);
            this.lb_Bestand.TabIndex = 0;
            this.lb_Bestand.Text = "Bücher im Bestand:";
            // 
            // gb_Leihen
            // 
            this.gb_Leihen.Controls.Add(this.bt_Suchen_Buecher);
            this.gb_Leihen.Controls.Add(this.Grid_Buch);
            this.gb_Leihen.Location = new System.Drawing.Point(409, 12);
            this.gb_Leihen.Name = "gb_Leihen";
            this.gb_Leihen.Size = new System.Drawing.Size(418, 318);
            this.gb_Leihen.TabIndex = 2;
            this.gb_Leihen.TabStop = false;
            this.gb_Leihen.Text = "Buch ausleihen:";
            // 
            // bt_Suchen_Buecher
            // 
            this.bt_Suchen_Buecher.Location = new System.Drawing.Point(111, 261);
            this.bt_Suchen_Buecher.Name = "bt_Suchen_Buecher";
            this.bt_Suchen_Buecher.Size = new System.Drawing.Size(204, 28);
            this.bt_Suchen_Buecher.TabIndex = 10;
            this.bt_Suchen_Buecher.Text = "Suchen";
            this.bt_Suchen_Buecher.UseVisualStyleBackColor = true;
            this.bt_Suchen_Buecher.Click += new System.EventHandler(this.bt_Suchen_Buecher_Click);
            // 
            // Grid_Buch
            // 
            this.Grid_Buch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Buch.Location = new System.Drawing.Point(18, 25);
            this.Grid_Buch.Name = "Grid_Buch";
            this.Grid_Buch.Size = new System.Drawing.Size(394, 218);
            this.Grid_Buch.TabIndex = 0;
            // 
            // gb_IstVorhanden
            // 
            this.gb_IstVorhanden.Controls.Add(this.lb_SuchErgebnisse);
            this.gb_IstVorhanden.Controls.Add(this.listView1);
            this.gb_IstVorhanden.Controls.Add(this.rb_SuchVerlag);
            this.gb_IstVorhanden.Controls.Add(this.rb_SuchAutor);
            this.gb_IstVorhanden.Controls.Add(this.rb_SuchGenre);
            this.gb_IstVorhanden.Controls.Add(this.rb_SuchTitel);
            this.gb_IstVorhanden.Controls.Add(this.cb_Verlag);
            this.gb_IstVorhanden.Controls.Add(this.lb_Verlag);
            this.gb_IstVorhanden.Controls.Add(this.cb_Autor);
            this.gb_IstVorhanden.Controls.Add(this.tb_Titel);
            this.gb_IstVorhanden.Controls.Add(this.lb_Autor);
            this.gb_IstVorhanden.Controls.Add(this.lb_Titel);
            this.gb_IstVorhanden.Controls.Add(this.lb_Genre);
            this.gb_IstVorhanden.Controls.Add(this.cb_Genre);
            this.gb_IstVorhanden.Controls.Add(this.bt_Suchen);
            this.gb_IstVorhanden.Location = new System.Drawing.Point(12, 188);
            this.gb_IstVorhanden.Name = "gb_IstVorhanden";
            this.gb_IstVorhanden.Size = new System.Drawing.Size(391, 434);
            this.gb_IstVorhanden.TabIndex = 1;
            this.gb_IstVorhanden.TabStop = false;
            this.gb_IstVorhanden.Text = "Buchverfügbarkeitsprüfung:";
            // 
            // lb_SuchErgebnisse
            // 
            this.lb_SuchErgebnisse.AutoSize = true;
            this.lb_SuchErgebnisse.Location = new System.Drawing.Point(6, 245);
            this.lb_SuchErgebnisse.Name = "lb_SuchErgebnisse";
            this.lb_SuchErgebnisse.Size = new System.Drawing.Size(86, 13);
            this.lb_SuchErgebnisse.TabIndex = 9;
            this.lb_SuchErgebnisse.Text = "Suchergebnisse:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_Buch_ID,
            this.ch_Titel,
            this.ch_Autor,
            this.ch_Genre,
            this.ch_Verlag});
            this.listView1.Location = new System.Drawing.Point(6, 268);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(379, 160);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // ch_Buch_ID
            // 
            this.ch_Buch_ID.Text = "Buch-ID:";
            this.ch_Buch_ID.Width = 55;
            // 
            // ch_Titel
            // 
            this.ch_Titel.Text = "Titel:";
            this.ch_Titel.Width = 100;
            // 
            // ch_Autor
            // 
            this.ch_Autor.Text = "Autor:";
            this.ch_Autor.Width = 80;
            // 
            // ch_Genre
            // 
            this.ch_Genre.Text = "Genre:";
            // 
            // ch_Verlag
            // 
            this.ch_Verlag.Text = "Verlag:";
            // 
            // rb_SuchVerlag
            // 
            this.rb_SuchVerlag.AutoSize = true;
            this.rb_SuchVerlag.Location = new System.Drawing.Point(6, 175);
            this.rb_SuchVerlag.Name = "rb_SuchVerlag";
            this.rb_SuchVerlag.Size = new System.Drawing.Size(125, 17);
            this.rb_SuchVerlag.TabIndex = 6;
            this.rb_SuchVerlag.Text = "Nach Verlag suchen:";
            this.rb_SuchVerlag.UseVisualStyleBackColor = true;
            this.rb_SuchVerlag.CheckedChanged += new System.EventHandler(this.Suchtyp);
            // 
            // rb_SuchAutor
            // 
            this.rb_SuchAutor.AutoSize = true;
            this.rb_SuchAutor.Location = new System.Drawing.Point(6, 125);
            this.rb_SuchAutor.Name = "rb_SuchAutor";
            this.rb_SuchAutor.Size = new System.Drawing.Size(120, 17);
            this.rb_SuchAutor.TabIndex = 6;
            this.rb_SuchAutor.Text = "Nach Autor suchen:";
            this.rb_SuchAutor.UseVisualStyleBackColor = true;
            this.rb_SuchAutor.CheckedChanged += new System.EventHandler(this.Suchtyp);
            // 
            // rb_SuchGenre
            // 
            this.rb_SuchGenre.AutoSize = true;
            this.rb_SuchGenre.Location = new System.Drawing.Point(6, 75);
            this.rb_SuchGenre.Name = "rb_SuchGenre";
            this.rb_SuchGenre.Size = new System.Drawing.Size(124, 17);
            this.rb_SuchGenre.TabIndex = 6;
            this.rb_SuchGenre.Text = "Nach Genre suchen:";
            this.rb_SuchGenre.UseVisualStyleBackColor = true;
            this.rb_SuchGenre.CheckedChanged += new System.EventHandler(this.Suchtyp);
            // 
            // rb_SuchTitel
            // 
            this.rb_SuchTitel.AutoSize = true;
            this.rb_SuchTitel.Checked = true;
            this.rb_SuchTitel.Location = new System.Drawing.Point(6, 25);
            this.rb_SuchTitel.Name = "rb_SuchTitel";
            this.rb_SuchTitel.Size = new System.Drawing.Size(115, 17);
            this.rb_SuchTitel.TabIndex = 6;
            this.rb_SuchTitel.TabStop = true;
            this.rb_SuchTitel.Text = "Nach Titel suchen:";
            this.rb_SuchTitel.UseVisualStyleBackColor = true;
            this.rb_SuchTitel.CheckedChanged += new System.EventHandler(this.Suchtyp);
            // 
            // cb_Verlag
            // 
            this.cb_Verlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Verlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Verlag.Enabled = false;
            this.cb_Verlag.FormattingEnabled = true;
            this.cb_Verlag.Location = new System.Drawing.Point(127, 198);
            this.cb_Verlag.Name = "cb_Verlag";
            this.cb_Verlag.Size = new System.Drawing.Size(120, 21);
            this.cb_Verlag.TabIndex = 7;
            // 
            // lb_Verlag
            // 
            this.lb_Verlag.AutoSize = true;
            this.lb_Verlag.Location = new System.Drawing.Point(81, 200);
            this.lb_Verlag.Name = "lb_Verlag";
            this.lb_Verlag.Size = new System.Drawing.Size(40, 13);
            this.lb_Verlag.TabIndex = 7;
            this.lb_Verlag.Text = "Verlag:";
            // 
            // cb_Autor
            // 
            this.cb_Autor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Autor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Autor.Enabled = false;
            this.cb_Autor.FormattingEnabled = true;
            this.cb_Autor.Location = new System.Drawing.Point(127, 147);
            this.cb_Autor.Name = "cb_Autor";
            this.cb_Autor.Size = new System.Drawing.Size(120, 21);
            this.cb_Autor.TabIndex = 7;
            // 
            // tb_Titel
            // 
            this.tb_Titel.Location = new System.Drawing.Point(127, 47);
            this.tb_Titel.Name = "tb_Titel";
            this.tb_Titel.Size = new System.Drawing.Size(120, 20);
            this.tb_Titel.TabIndex = 7;
            // 
            // lb_Autor
            // 
            this.lb_Autor.AutoSize = true;
            this.lb_Autor.Location = new System.Drawing.Point(86, 150);
            this.lb_Autor.Name = "lb_Autor";
            this.lb_Autor.Size = new System.Drawing.Size(35, 13);
            this.lb_Autor.TabIndex = 4;
            this.lb_Autor.Text = "Autor:";
            // 
            // lb_Titel
            // 
            this.lb_Titel.AutoSize = true;
            this.lb_Titel.Location = new System.Drawing.Point(91, 50);
            this.lb_Titel.Name = "lb_Titel";
            this.lb_Titel.Size = new System.Drawing.Size(30, 13);
            this.lb_Titel.TabIndex = 3;
            this.lb_Titel.Text = "Titel:";
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.lb_Genre.Location = new System.Drawing.Point(82, 100);
            this.lb_Genre.Name = "lb_Genre";
            this.lb_Genre.Size = new System.Drawing.Size(39, 13);
            this.lb_Genre.TabIndex = 2;
            this.lb_Genre.Text = "Genre:";
            // 
            // cb_Genre
            // 
            this.cb_Genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Genre.Enabled = false;
            this.cb_Genre.FormattingEnabled = true;
            this.cb_Genre.Location = new System.Drawing.Point(127, 97);
            this.cb_Genre.Name = "cb_Genre";
            this.cb_Genre.Size = new System.Drawing.Size(120, 21);
            this.cb_Genre.Sorted = true;
            this.cb_Genre.TabIndex = 7;
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Location = new System.Drawing.Point(267, 193);
            this.bt_Suchen.Name = "bt_Suchen";
            this.bt_Suchen.Size = new System.Drawing.Size(105, 28);
            this.bt_Suchen.TabIndex = 8;
            this.bt_Suchen.Text = "Suchen";
            this.bt_Suchen.UseVisualStyleBackColor = true;
            this.bt_Suchen.Click += new System.EventHandler(this.Suchen);
            // 
            // w_s_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 634);
            this.Controls.Add(this.gb_IstVorhanden);
            this.Controls.Add(this.gb_Leihen);
            this.Controls.Add(this.gb_Uebersicht);
            this.Controls.Add(this.groupBox1);
            this.Name = "w_s_main";
            this.Text = "Bibliotheksverwaltung";
            this.Activated += new System.EventHandler(this.Load_All);
            this.groupBox1.ResumeLayout(false);
            this.gb_Uebersicht.ResumeLayout(false);
            this.gb_Uebersicht.PerformLayout();
            this.gb_Leihen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Buch)).EndInit();
            this.gb_IstVorhanden.ResumeLayout(false);
            this.gb_IstVorhanden.PerformLayout();
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
        private System.Windows.Forms.GroupBox gb_Leihen;
        private System.Windows.Forms.GroupBox gb_IstVorhanden;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ComboBox cb_Autor;
        private System.Windows.Forms.TextBox tb_Titel;
        private System.Windows.Forms.Label lb_Autor;
        private System.Windows.Forms.Label lb_Titel;
        private System.Windows.Forms.Label lb_Genre;
        private System.Windows.Forms.ComboBox cb_Genre;
        private System.Windows.Forms.Button bt_Suchen;
        private System.Windows.Forms.ComboBox cb_Verlag;
        private System.Windows.Forms.Label lb_Verlag;
        private System.Windows.Forms.RadioButton rb_SuchVerlag;
        private System.Windows.Forms.RadioButton rb_SuchAutor;
        private System.Windows.Forms.RadioButton rb_SuchGenre;
        private System.Windows.Forms.RadioButton rb_SuchTitel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader ch_Buch_ID;
        private System.Windows.Forms.ColumnHeader ch_Titel;
        private System.Windows.Forms.ColumnHeader ch_Autor;
        private System.Windows.Forms.ColumnHeader ch_Genre;
        private System.Windows.Forms.ColumnHeader ch_Verlag;
        private System.Windows.Forms.Label lb_SuchErgebnisse;
        private System.Windows.Forms.DataGridView Grid_Buch;
        private System.Windows.Forms.Button bt_Suchen_Buecher;
    }
}