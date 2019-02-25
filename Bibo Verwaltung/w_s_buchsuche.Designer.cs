namespace Bibo_Verwaltung
{
    partial class w_s_buchsuche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_buchsuche));
            this.gv_buchsuche = new System.Windows.Forms.DataGridView();
            this.cb_KundeAnz = new System.Windows.Forms.CheckBox();
            this.cb_Verfügbar_Anz = new System.Windows.Forms.CheckBox();
            this.bt_Ausleihen = new System.Windows.Forms.Button();
            this.gb_BSuchen = new System.Windows.Forms.GroupBox();
            this.tb_ExemplarID = new System.Windows.Forms.TextBox();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.cb_Verlag = new System.Windows.Forms.ComboBox();
            this.cb_Genre = new System.Windows.Forms.ComboBox();
            this.cb_Autor = new System.Windows.Forms.ComboBox();
            this.tb_Titel = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.tb_klasse = new System.Windows.Forms.TextBox();
            this.gb_KSuchen = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_buchsuche)).BeginInit();
            this.gb_BSuchen.SuspendLayout();
            this.gb_KSuchen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_buchsuche
            // 
            this.gv_buchsuche.AllowUserToAddRows = false;
            this.gv_buchsuche.AllowUserToDeleteRows = false;
            this.gv_buchsuche.AllowUserToResizeColumns = false;
            this.gv_buchsuche.AllowUserToResizeRows = false;
            this.gv_buchsuche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_buchsuche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_buchsuche.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpProvider.SetHelpString(this.gv_buchsuche, "In diesem Feld werden all ihre Bücher und evtl. vorhandene Ausleihvorgänge angeze" +
        "igt.");
            this.gv_buchsuche.Location = new System.Drawing.Point(218, 12);
            this.gv_buchsuche.Name = "gv_buchsuche";
            this.gv_buchsuche.ReadOnly = true;
            this.gv_buchsuche.RowHeadersWidth = 35;
            this.gv_buchsuche.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_buchsuche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_buchsuche.ShowEditingIcon = false;
            this.helpProvider.SetShowHelp(this.gv_buchsuche, true);
            this.gv_buchsuche.Size = new System.Drawing.Size(748, 450);
            this.gv_buchsuche.TabIndex = 0;
            this.gv_buchsuche.VirtualMode = true;
            this.gv_buchsuche.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_buchsuche_ColumnHeaderMouseClick);
            // 
            // cb_KundeAnz
            // 
            this.cb_KundeAnz.AutoSize = true;
            this.helpProvider.SetHelpString(this.cb_KundeAnz, "Setzen sie einen Haken in dieses Feld, werden ihnen im obenliegenden Feld Kundeni" +
        "nformationen bei ausgeliehenen Büchern angezeigt.");
            this.cb_KundeAnz.Location = new System.Drawing.Point(12, 327);
            this.cb_KundeAnz.Name = "cb_KundeAnz";
            this.helpProvider.SetShowHelp(this.cb_KundeAnz, true);
            this.cb_KundeAnz.Size = new System.Drawing.Size(181, 17);
            this.cb_KundeAnz.TabIndex = 1;
            this.cb_KundeAnz.Text = "Kundeninformationen einblenden";
            this.cb_KundeAnz.UseVisualStyleBackColor = true;
            this.cb_KundeAnz.CheckedChanged += new System.EventHandler(this.cb_KundeAnz_CheckedChanged);
            // 
            // cb_Verfügbar_Anz
            // 
            this.cb_Verfügbar_Anz.AutoSize = true;
            this.helpProvider.SetHelpString(this.cb_Verfügbar_Anz, "Setzen sie einen Haken in dieses Feld, werden ihnen nur Bücher angezeigt, welche " +
        "verliehen werden können.");
            this.cb_Verfügbar_Anz.Location = new System.Drawing.Point(12, 304);
            this.cb_Verfügbar_Anz.Name = "cb_Verfügbar_Anz";
            this.helpProvider.SetShowHelp(this.cb_Verfügbar_Anz, true);
            this.cb_Verfügbar_Anz.Size = new System.Drawing.Size(201, 17);
            this.cb_Verfügbar_Anz.TabIndex = 2;
            this.cb_Verfügbar_Anz.Text = "Nur verleihbereite Bücher einblenden";
            this.cb_Verfügbar_Anz.UseVisualStyleBackColor = true;
            this.cb_Verfügbar_Anz.CheckedChanged += new System.EventHandler(this.cb_Verfügbar_Anz_CheckedChanged);
            // 
            // bt_Ausleihen
            // 
            this.helpProvider.SetHelpString(this.bt_Ausleihen, "Klicken sie auf diesen Button, nachdem sie ein Buch im obenliegenden Feld makiert" +
        " haben, um dieses gewählte Buch auszuleihen.");
            this.bt_Ausleihen.Location = new System.Drawing.Point(12, 439);
            this.bt_Ausleihen.Name = "bt_Ausleihen";
            this.helpProvider.SetShowHelp(this.bt_Ausleihen, true);
            this.bt_Ausleihen.Size = new System.Drawing.Size(150, 23);
            this.bt_Ausleihen.TabIndex = 11;
            this.bt_Ausleihen.Text = "Ausleihvorgang starten";
            this.bt_Ausleihen.UseVisualStyleBackColor = true;
            this.bt_Ausleihen.Click += new System.EventHandler(this.Ausleihvorgang);
            // 
            // gb_BSuchen
            // 
            this.gb_BSuchen.Controls.Add(this.tb_ExemplarID);
            this.gb_BSuchen.Controls.Add(this.tb_ISBN);
            this.gb_BSuchen.Controls.Add(this.cb_Verlag);
            this.gb_BSuchen.Controls.Add(this.cb_Genre);
            this.gb_BSuchen.Controls.Add(this.cb_Autor);
            this.gb_BSuchen.Controls.Add(this.tb_Titel);
            this.helpProvider.SetHelpString(this.gb_BSuchen, resources.GetString("gb_BSuchen.HelpString"));
            this.gb_BSuchen.Location = new System.Drawing.Point(12, 12);
            this.gb_BSuchen.Name = "gb_BSuchen";
            this.helpProvider.SetShowHelp(this.gb_BSuchen, true);
            this.gb_BSuchen.Size = new System.Drawing.Size(200, 180);
            this.gb_BSuchen.TabIndex = 13;
            this.gb_BSuchen.TabStop = false;
            this.gb_BSuchen.Text = "Suchen nach Bucheigenschaften:";
            // 
            // tb_ExemplarID
            // 
            this.tb_ExemplarID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_ExemplarID, "Tragen sie hier die Buch-ID ein, um das gewünschte Buch zu laden.");
            this.tb_ExemplarID.Location = new System.Drawing.Point(6, 19);
            this.tb_ExemplarID.Name = "tb_ExemplarID";
            this.helpProvider.SetShowHelp(this.tb_ExemplarID, true);
            this.tb_ExemplarID.Size = new System.Drawing.Size(188, 20);
            this.tb_ExemplarID.TabIndex = 36;
            this.tb_ExemplarID.Text = "ExemplarID";
            this.tb_ExemplarID.Click += new System.EventHandler(this.tb_ExemplarID_Click);
            this.tb_ExemplarID.TextChanged += new System.EventHandler(this.tb_ExemplarID_TextChanged);
            this.tb_ExemplarID.Enter += new System.EventHandler(this.tb_ExemplarID_Enter);
            this.tb_ExemplarID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ExemplarID_KeyPress);
            this.tb_ExemplarID.Leave += new System.EventHandler(this.tb_ExemplarID_Leave);
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpKeyword(this.tb_ISBN, "");
            this.helpProvider.SetHelpString(this.tb_ISBN, "Tragen sie hier die ISBN-13 ein, um das ausgeliehene Buch zu laden.");
            this.tb_ISBN.Location = new System.Drawing.Point(6, 45);
            this.tb_ISBN.Name = "tb_ISBN";
            this.helpProvider.SetShowHelp(this.tb_ISBN, true);
            this.tb_ISBN.Size = new System.Drawing.Size(188, 20);
            this.tb_ISBN.TabIndex = 35;
            this.tb_ISBN.Text = "ISBN";
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            this.tb_ISBN.Enter += new System.EventHandler(this.tb_ISBN_Enter);
            this.tb_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            this.tb_ISBN.Leave += new System.EventHandler(this.tb_ISBN_Leave);
            // 
            // cb_Verlag
            // 
            this.cb_Verlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Verlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Verlag.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cb_Verlag.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Verlag, "Tragen sie hier den Verlag ein, um das ausgeliehene Buch zu laden.");
            this.cb_Verlag.Location = new System.Drawing.Point(6, 124);
            this.cb_Verlag.Name = "cb_Verlag";
            this.helpProvider.SetShowHelp(this.cb_Verlag, true);
            this.cb_Verlag.Size = new System.Drawing.Size(188, 21);
            this.cb_Verlag.Sorted = true;
            this.cb_Verlag.TabIndex = 29;
            this.cb_Verlag.Text = "Verlag";
            this.cb_Verlag.TextChanged += new System.EventHandler(this.cb_Verlag_TextChanged);
            this.cb_Verlag.Enter += new System.EventHandler(this.cb_Verlag_Enter);
            this.cb_Verlag.Leave += new System.EventHandler(this.cb_Verlag_Leave);
            // 
            // cb_Genre
            // 
            this.cb_Genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Genre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cb_Genre.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Genre, "Tragen sie hier das Genre ein, um das ausgeliehene Buch zu laden.");
            this.cb_Genre.Location = new System.Drawing.Point(6, 150);
            this.cb_Genre.Name = "cb_Genre";
            this.helpProvider.SetShowHelp(this.cb_Genre, true);
            this.cb_Genre.Size = new System.Drawing.Size(188, 21);
            this.cb_Genre.Sorted = true;
            this.cb_Genre.TabIndex = 28;
            this.cb_Genre.Text = "Genre";
            this.cb_Genre.TextChanged += new System.EventHandler(this.cb_Genre_TextChanged);
            this.cb_Genre.Enter += new System.EventHandler(this.cb_Genre_Enter);
            this.cb_Genre.Leave += new System.EventHandler(this.cb_Genre_Leave);
            // 
            // cb_Autor
            // 
            this.cb_Autor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Autor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Autor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cb_Autor.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Autor, "Tragen sie hier den Buchautor ein, um das ausgeliehene Buch zu laden.");
            this.cb_Autor.Location = new System.Drawing.Point(6, 97);
            this.cb_Autor.Name = "cb_Autor";
            this.helpProvider.SetShowHelp(this.cb_Autor, true);
            this.cb_Autor.Size = new System.Drawing.Size(188, 21);
            this.cb_Autor.Sorted = true;
            this.cb_Autor.TabIndex = 27;
            this.cb_Autor.Text = "Autor";
            this.cb_Autor.TextChanged += new System.EventHandler(this.cb_Autor_TextChanged);
            this.cb_Autor.Enter += new System.EventHandler(this.cb_Autor_Enter);
            this.cb_Autor.Leave += new System.EventHandler(this.cb_Autor_Leave);
            // 
            // tb_Titel
            // 
            this.tb_Titel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_Titel, "Tragen sie hier den Buchtitel ein, um das ausgeliehene Buch zu laden.");
            this.tb_Titel.Location = new System.Drawing.Point(6, 71);
            this.tb_Titel.Name = "tb_Titel";
            this.helpProvider.SetShowHelp(this.tb_Titel, true);
            this.tb_Titel.Size = new System.Drawing.Size(188, 20);
            this.tb_Titel.TabIndex = 17;
            this.tb_Titel.Text = "Titel";
            this.tb_Titel.TextChanged += new System.EventHandler(this.tb_Titel_TextChanged);
            this.tb_Titel.Enter += new System.EventHandler(this.tb_Titel_Enter);
            this.tb_Titel.Leave += new System.EventHandler(this.tb_Titel_Leave);
            // 
            // tb_nachname
            // 
            this.tb_nachname.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_nachname, "Tragen sie hier den Nachnamen des gesuchten Kunden ein, welcher einen Ausleihvorg" +
        "ang getätigt hat.");
            this.tb_nachname.Location = new System.Drawing.Point(6, 45);
            this.tb_nachname.Name = "tb_nachname";
            this.helpProvider.SetShowHelp(this.tb_nachname, true);
            this.tb_nachname.Size = new System.Drawing.Size(188, 20);
            this.tb_nachname.TabIndex = 31;
            this.tb_nachname.Text = "Nachname";
            this.tb_nachname.TextChanged += new System.EventHandler(this.tb_nachname_TextChanged);
            this.tb_nachname.Enter += new System.EventHandler(this.tb_nachname_Enter);
            this.tb_nachname.Leave += new System.EventHandler(this.tb_nachname_Leave);
            // 
            // tb_vorname
            // 
            this.tb_vorname.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_vorname, "Tragen sie hier den Vornamen des gesuchten Kunden ein, welcher einen Ausleihvorga" +
        "ng getätigt hat.");
            this.tb_vorname.Location = new System.Drawing.Point(6, 19);
            this.tb_vorname.Name = "tb_vorname";
            this.helpProvider.SetShowHelp(this.tb_vorname, true);
            this.tb_vorname.Size = new System.Drawing.Size(188, 20);
            this.tb_vorname.TabIndex = 30;
            this.tb_vorname.Text = "Vorname";
            this.tb_vorname.TextChanged += new System.EventHandler(this.tb_vorname_TextChanged);
            this.tb_vorname.Enter += new System.EventHandler(this.tb_vorname_Enter);
            this.tb_vorname.Leave += new System.EventHandler(this.tb_vorname_Leave);
            // 
            // bt_Clear
            // 
            this.helpProvider.SetHelpString(this.bt_Clear, "Leeren sie alle linksseitig liegenden Textfelder.");
            this.bt_Clear.Location = new System.Drawing.Point(12, 350);
            this.bt_Clear.Name = "bt_Clear";
            this.helpProvider.SetShowHelp(this.bt_Clear, true);
            this.bt_Clear.Size = new System.Drawing.Size(100, 21);
            this.bt_Clear.TabIndex = 26;
            this.bt_Clear.Text = "Filter löschen";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // tb_klasse
            // 
            this.tb_klasse.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_klasse, "Tragen sie hier den Vornamen des gesuchten Kunden ein, welcher einen Ausleihvorga" +
        "ng getätigt hat.");
            this.tb_klasse.Location = new System.Drawing.Point(6, 71);
            this.tb_klasse.Name = "tb_klasse";
            this.helpProvider.SetShowHelp(this.tb_klasse, true);
            this.tb_klasse.Size = new System.Drawing.Size(188, 20);
            this.tb_klasse.TabIndex = 32;
            this.tb_klasse.Text = "Klassenstufe";
            this.tb_klasse.TextChanged += new System.EventHandler(this.tb_klasse_TextChanged);
            this.tb_klasse.Enter += new System.EventHandler(this.tb_klasse_Enter);
            this.tb_klasse.Leave += new System.EventHandler(this.tb_klasse_Leave);
            // 
            // gb_KSuchen
            // 
            this.gb_KSuchen.Controls.Add(this.tb_klasse);
            this.gb_KSuchen.Controls.Add(this.tb_vorname);
            this.gb_KSuchen.Controls.Add(this.tb_nachname);
            this.gb_KSuchen.Location = new System.Drawing.Point(12, 198);
            this.gb_KSuchen.Name = "gb_KSuchen";
            this.gb_KSuchen.Size = new System.Drawing.Size(200, 100);
            this.gb_KSuchen.TabIndex = 32;
            this.gb_KSuchen.TabStop = false;
            this.gb_KSuchen.Text = "Suchen nach Kundeneigenschaften:";
            // 
            // w_s_buchsuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 471);
            this.Controls.Add(this.gb_KSuchen);
            this.Controls.Add(this.gb_BSuchen);
            this.Controls.Add(this.bt_Clear);
            this.Controls.Add(this.bt_Ausleihen);
            this.Controls.Add(this.cb_Verfügbar_Anz);
            this.Controls.Add(this.cb_KundeAnz);
            this.Controls.Add(this.gv_buchsuche);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_buchsuche";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buchübersicht";
            this.Activated += new System.EventHandler(this.w_s_buchsuche_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gv_buchsuche)).EndInit();
            this.gb_BSuchen.ResumeLayout(false);
            this.gb_BSuchen.PerformLayout();
            this.gb_KSuchen.ResumeLayout(false);
            this.gb_KSuchen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_buchsuche;
        private System.Windows.Forms.CheckBox cb_KundeAnz;
        private System.Windows.Forms.CheckBox cb_Verfügbar_Anz;
        private System.Windows.Forms.Button bt_Ausleihen;
        private System.Windows.Forms.GroupBox gb_BSuchen;
        private System.Windows.Forms.TextBox tb_Titel;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.ComboBox cb_Genre;
        private System.Windows.Forms.ComboBox cb_Autor;
        private System.Windows.Forms.ComboBox cb_Verlag;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.TextBox tb_ExemplarID;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.GroupBox gb_KSuchen;
        private System.Windows.Forms.TextBox tb_klasse;
    }
}