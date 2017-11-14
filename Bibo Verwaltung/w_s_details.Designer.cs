namespace Bibo_Verwaltung
{
    partial class w_s_details
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
            this.gv_Details = new System.Windows.Forms.DataGridView();
            this.cb_KundeAnz = new System.Windows.Forms.CheckBox();
            this.cb_Ferfügbark_Anz = new System.Windows.Forms.CheckBox();
            this.dateTimePickerAusleihen = new System.Windows.Forms.DateTimePicker();
            this.cb_Ausleihen = new System.Windows.Forms.GroupBox();
            this.lb_verleihfaehig = new System.Windows.Forms.Label();
            this.tb_verleihfaehigAusleihen = new System.Windows.Forms.TextBox();
            this.lb_Zustand = new System.Windows.Forms.Label();
            this.tb_ZustandAusleihen = new System.Windows.Forms.TextBox();
            this.tb_KundenIDAusleihen = new System.Windows.Forms.TextBox();
            this.bt_Abschliessen = new System.Windows.Forms.Button();
            this.lb_Kunde = new System.Windows.Forms.Label();
            this.tb_KundeAusleihen = new System.Windows.Forms.TextBox();
            this.lb_Rück = new System.Windows.Forms.Label();
            this.lb_Buch = new System.Windows.Forms.Label();
            this.tb_BuchAusleihen = new System.Windows.Forms.TextBox();
            this.tb_BuchIDAusleihen = new System.Windows.Forms.TextBox();
            this.bt_Ausleihen = new System.Windows.Forms.Button();
            this.gb_Suchen = new System.Windows.Forms.GroupBox();
            this.cb_s_ID = new System.Windows.Forms.CheckBox();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.cb_s_ISBN = new System.Windows.Forms.CheckBox();
            this.cb_s_Nachname = new System.Windows.Forms.CheckBox();
            this.cb_s_Vorname = new System.Windows.Forms.CheckBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.combo_Verlag = new System.Windows.Forms.ComboBox();
            this.combo_Genre = new System.Windows.Forms.ComboBox();
            this.combo_Autor = new System.Windows.Forms.ComboBox();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.cb_s_Autor = new System.Windows.Forms.CheckBox();
            this.cb_s_Genre = new System.Windows.Forms.CheckBox();
            this.cb_s_Verlag = new System.Windows.Forms.CheckBox();
            this.cb_s_Titel = new System.Windows.Forms.CheckBox();
            this.tb_s_Titel = new System.Windows.Forms.TextBox();
            this.bt_Rueckgabe = new System.Windows.Forms.Button();
            this.bt_AbbrechenAusleihen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Details)).BeginInit();
            this.cb_Ausleihen.SuspendLayout();
            this.gb_Suchen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_Details
            // 
            this.gv_Details.AllowUserToAddRows = false;
            this.gv_Details.AllowUserToDeleteRows = false;
            this.gv_Details.AllowUserToResizeColumns = false;
            this.gv_Details.AllowUserToResizeRows = false;
            this.gv_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Details.Cursor = System.Windows.Forms.Cursors.Default;
            this.gv_Details.Location = new System.Drawing.Point(32, 204);
            this.gv_Details.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gv_Details.MultiSelect = false;
            this.gv_Details.Name = "gv_Details";
            this.gv_Details.ReadOnly = true;
            this.gv_Details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Details.ShowEditingIcon = false;
            this.gv_Details.Size = new System.Drawing.Size(3107, 660);
            this.gv_Details.TabIndex = 0;
            // 
            // cb_KundeAnz
            // 
            this.cb_KundeAnz.AutoSize = true;
            this.cb_KundeAnz.Location = new System.Drawing.Point(2661, 878);
            this.cb_KundeAnz.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cb_KundeAnz.Name = "cb_KundeAnz";
            this.cb_KundeAnz.Size = new System.Drawing.Size(475, 36);
            this.cb_KundeAnz.TabIndex = 1;
            this.cb_KundeAnz.Text = "Kundeninformationen einblenden";
            this.cb_KundeAnz.UseVisualStyleBackColor = true;
            this.cb_KundeAnz.CheckedChanged += new System.EventHandler(this.cb_KundeAnz_CheckedChanged);
            // 
            // cb_Ferfügbark_Anz
            // 
            this.cb_Ferfügbark_Anz.AutoSize = true;
            this.cb_Ferfügbark_Anz.Location = new System.Drawing.Point(2112, 878);
            this.cb_Ferfügbark_Anz.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cb_Ferfügbark_Anz.Name = "cb_Ferfügbark_Anz";
            this.cb_Ferfügbark_Anz.Size = new System.Drawing.Size(524, 36);
            this.cb_Ferfügbark_Anz.TabIndex = 2;
            this.cb_Ferfügbark_Anz.Text = "Nur verleihbereite Bücher einblenden";
            this.cb_Ferfügbark_Anz.UseVisualStyleBackColor = true;
            this.cb_Ferfügbark_Anz.CheckedChanged += new System.EventHandler(this.cb_Ferfügbark_Anz_CheckedChanged);
            // 
            // dateTimePickerAusleihen
            // 
            this.dateTimePickerAusleihen.Location = new System.Drawing.Point(344, 348);
            this.dateTimePickerAusleihen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dateTimePickerAusleihen.Name = "dateTimePickerAusleihen";
            this.dateTimePickerAusleihen.Size = new System.Drawing.Size(527, 38);
            this.dateTimePickerAusleihen.TabIndex = 3;
            // 
            // cb_Ausleihen
            // 
            this.cb_Ausleihen.Controls.Add(this.lb_verleihfaehig);
            this.cb_Ausleihen.Controls.Add(this.tb_verleihfaehigAusleihen);
            this.cb_Ausleihen.Controls.Add(this.lb_Zustand);
            this.cb_Ausleihen.Controls.Add(this.tb_ZustandAusleihen);
            this.cb_Ausleihen.Controls.Add(this.tb_KundenIDAusleihen);
            this.cb_Ausleihen.Controls.Add(this.bt_Abschliessen);
            this.cb_Ausleihen.Controls.Add(this.lb_Kunde);
            this.cb_Ausleihen.Controls.Add(this.tb_KundeAusleihen);
            this.cb_Ausleihen.Controls.Add(this.lb_Rück);
            this.cb_Ausleihen.Controls.Add(this.lb_Buch);
            this.cb_Ausleihen.Controls.Add(this.tb_BuchAusleihen);
            this.cb_Ausleihen.Controls.Add(this.tb_BuchIDAusleihen);
            this.cb_Ausleihen.Controls.Add(this.dateTimePickerAusleihen);
            this.cb_Ausleihen.Location = new System.Drawing.Point(32, 947);
            this.cb_Ausleihen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cb_Ausleihen.Name = "cb_Ausleihen";
            this.cb_Ausleihen.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cb_Ausleihen.Size = new System.Drawing.Size(3107, 482);
            this.cb_Ausleihen.TabIndex = 5;
            this.cb_Ausleihen.TabStop = false;
            this.cb_Ausleihen.Text = "Buch ausleihen:";
            // 
            // lb_verleihfaehig
            // 
            this.lb_verleihfaehig.AutoSize = true;
            this.lb_verleihfaehig.Location = new System.Drawing.Point(16, 184);
            this.lb_verleihfaehig.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_verleihfaehig.Name = "lb_verleihfaehig";
            this.lb_verleihfaehig.Size = new System.Drawing.Size(176, 32);
            this.lb_verleihfaehig.TabIndex = 16;
            this.lb_verleihfaehig.Text = "Verleihfähig:";
            // 
            // tb_verleihfaehigAusleihen
            // 
            this.tb_verleihfaehigAusleihen.Location = new System.Drawing.Point(344, 176);
            this.tb_verleihfaehigAusleihen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_verleihfaehigAusleihen.Name = "tb_verleihfaehigAusleihen";
            this.tb_verleihfaehigAusleihen.ReadOnly = true;
            this.tb_verleihfaehigAusleihen.Size = new System.Drawing.Size(527, 38);
            this.tb_verleihfaehigAusleihen.TabIndex = 15;
            this.tb_verleihfaehigAusleihen.TabStop = false;
            // 
            // lb_Zustand
            // 
            this.lb_Zustand.AutoSize = true;
            this.lb_Zustand.Location = new System.Drawing.Point(16, 122);
            this.lb_Zustand.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Zustand.Name = "lb_Zustand";
            this.lb_Zustand.Size = new System.Drawing.Size(126, 32);
            this.lb_Zustand.TabIndex = 14;
            this.lb_Zustand.Text = "Zustand:";
            // 
            // tb_ZustandAusleihen
            // 
            this.tb_ZustandAusleihen.Location = new System.Drawing.Point(344, 114);
            this.tb_ZustandAusleihen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_ZustandAusleihen.Name = "tb_ZustandAusleihen";
            this.tb_ZustandAusleihen.ReadOnly = true;
            this.tb_ZustandAusleihen.Size = new System.Drawing.Size(527, 38);
            this.tb_ZustandAusleihen.TabIndex = 13;
            this.tb_ZustandAusleihen.TabStop = false;
            this.tb_ZustandAusleihen.TextChanged += new System.EventHandler(this.tb_ZustandAusleihen_TextChanged);
            // 
            // tb_KundenIDAusleihen
            // 
            this.tb_KundenIDAusleihen.Enabled = false;
            this.tb_KundenIDAusleihen.Location = new System.Drawing.Point(264, 238);
            this.tb_KundenIDAusleihen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_KundenIDAusleihen.Name = "tb_KundenIDAusleihen";
            this.tb_KundenIDAusleihen.ReadOnly = true;
            this.tb_KundenIDAusleihen.Size = new System.Drawing.Size(57, 38);
            this.tb_KundenIDAusleihen.TabIndex = 12;
            this.tb_KundenIDAusleihen.TabStop = false;
            this.tb_KundenIDAusleihen.Visible = false;
            // 
            // bt_Abschliessen
            // 
            this.bt_Abschliessen.Enabled = false;
            this.bt_Abschliessen.Location = new System.Drawing.Point(2691, 331);
            this.bt_Abschliessen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Abschliessen.Name = "bt_Abschliessen";
            this.bt_Abschliessen.Size = new System.Drawing.Size(400, 124);
            this.bt_Abschliessen.TabIndex = 11;
            this.bt_Abschliessen.Text = "Ausleihvorgang abschließen";
            this.bt_Abschliessen.UseVisualStyleBackColor = true;
            this.bt_Abschliessen.Click += new System.EventHandler(this.Ausleihen_Bestaetigen);
            // 
            // lb_Kunde
            // 
            this.lb_Kunde.AutoSize = true;
            this.lb_Kunde.Location = new System.Drawing.Point(16, 246);
            this.lb_Kunde.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Kunde.Name = "lb_Kunde";
            this.lb_Kunde.Size = new System.Drawing.Size(106, 32);
            this.lb_Kunde.TabIndex = 10;
            this.lb_Kunde.Text = "Kunde:";
            // 
            // tb_KundeAusleihen
            // 
            this.tb_KundeAusleihen.Location = new System.Drawing.Point(344, 238);
            this.tb_KundeAusleihen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_KundeAusleihen.Name = "tb_KundeAusleihen";
            this.tb_KundeAusleihen.ReadOnly = true;
            this.tb_KundeAusleihen.Size = new System.Drawing.Size(527, 38);
            this.tb_KundeAusleihen.TabIndex = 9;
            this.tb_KundeAusleihen.TabStop = false;
            // 
            // lb_Rück
            // 
            this.lb_Rück.AutoSize = true;
            this.lb_Rück.Location = new System.Drawing.Point(18, 354);
            this.lb_Rück.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Rück.Name = "lb_Rück";
            this.lb_Rück.Size = new System.Drawing.Size(230, 32);
            this.lb_Rück.TabIndex = 8;
            this.lb_Rück.Text = "Rückgabedatum:";
            // 
            // lb_Buch
            // 
            this.lb_Buch.AutoSize = true;
            this.lb_Buch.Location = new System.Drawing.Point(16, 60);
            this.lb_Buch.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Buch.Name = "lb_Buch";
            this.lb_Buch.Size = new System.Drawing.Size(88, 32);
            this.lb_Buch.TabIndex = 7;
            this.lb_Buch.Text = "Buch:";
            // 
            // tb_BuchAusleihen
            // 
            this.tb_BuchAusleihen.Location = new System.Drawing.Point(344, 52);
            this.tb_BuchAusleihen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_BuchAusleihen.Name = "tb_BuchAusleihen";
            this.tb_BuchAusleihen.ReadOnly = true;
            this.tb_BuchAusleihen.Size = new System.Drawing.Size(527, 38);
            this.tb_BuchAusleihen.TabIndex = 6;
            this.tb_BuchAusleihen.TabStop = false;
            // 
            // tb_BuchIDAusleihen
            // 
            this.tb_BuchIDAusleihen.Enabled = false;
            this.tb_BuchIDAusleihen.Location = new System.Drawing.Point(264, 52);
            this.tb_BuchIDAusleihen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_BuchIDAusleihen.Name = "tb_BuchIDAusleihen";
            this.tb_BuchIDAusleihen.ReadOnly = true;
            this.tb_BuchIDAusleihen.Size = new System.Drawing.Size(57, 38);
            this.tb_BuchIDAusleihen.TabIndex = 4;
            this.tb_BuchIDAusleihen.TabStop = false;
            this.tb_BuchIDAusleihen.Visible = false;
            // 
            // bt_Ausleihen
            // 
            this.bt_Ausleihen.Location = new System.Drawing.Point(32, 878);
            this.bt_Ausleihen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Ausleihen.Name = "bt_Ausleihen";
            this.bt_Ausleihen.Size = new System.Drawing.Size(400, 55);
            this.bt_Ausleihen.TabIndex = 11;
            this.bt_Ausleihen.Text = "Ausleihvorgang starten";
            this.bt_Ausleihen.UseVisualStyleBackColor = true;
            this.bt_Ausleihen.Click += new System.EventHandler(this.Ausleihvorgang);
            // 
            // gb_Suchen
            // 
            this.gb_Suchen.Controls.Add(this.cb_s_ID);
            this.gb_Suchen.Controls.Add(this.tb_ID);
            this.gb_Suchen.Controls.Add(this.tb_ISBN);
            this.gb_Suchen.Controls.Add(this.cb_s_ISBN);
            this.gb_Suchen.Controls.Add(this.cb_s_Nachname);
            this.gb_Suchen.Controls.Add(this.cb_s_Vorname);
            this.gb_Suchen.Controls.Add(this.tb_nachname);
            this.gb_Suchen.Controls.Add(this.tb_vorname);
            this.gb_Suchen.Controls.Add(this.combo_Verlag);
            this.gb_Suchen.Controls.Add(this.combo_Genre);
            this.gb_Suchen.Controls.Add(this.combo_Autor);
            this.gb_Suchen.Controls.Add(this.bt_Clear);
            this.gb_Suchen.Controls.Add(this.cb_s_Autor);
            this.gb_Suchen.Controls.Add(this.cb_s_Genre);
            this.gb_Suchen.Controls.Add(this.cb_s_Verlag);
            this.gb_Suchen.Controls.Add(this.cb_s_Titel);
            this.gb_Suchen.Controls.Add(this.tb_s_Titel);
            this.gb_Suchen.Location = new System.Drawing.Point(32, 26);
            this.gb_Suchen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_Suchen.Name = "gb_Suchen";
            this.gb_Suchen.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_Suchen.Size = new System.Drawing.Size(3107, 164);
            this.gb_Suchen.TabIndex = 13;
            this.gb_Suchen.TabStop = false;
            this.gb_Suchen.Text = "Suchen nach:";
            // 
            // cb_s_ID
            // 
            this.cb_s_ID.AutoSize = true;
            this.cb_s_ID.Location = new System.Drawing.Point(16, 46);
            this.cb_s_ID.Margin = new System.Windows.Forms.Padding(8);
            this.cb_s_ID.Name = "cb_s_ID";
            this.cb_s_ID.Size = new System.Drawing.Size(160, 36);
            this.cb_s_ID.TabIndex = 37;
            this.cb_s_ID.Text = "Buch ID:";
            this.cb_s_ID.UseVisualStyleBackColor = true;
            this.cb_s_ID.CheckedChanged += new System.EventHandler(this.cb_s_ID_CheckedChanged);
            // 
            // tb_ID
            // 
            this.tb_ID.Enabled = false;
            this.tb_ID.Location = new System.Drawing.Point(191, 45);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(8);
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.Size = new System.Drawing.Size(450, 38);
            this.tb_ID.TabIndex = 36;
            this.tb_ID.TextChanged += new System.EventHandler(this.tb_ID_TextChanged);
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            // 
            // tb_ISBN
            // 
            this.tb_ISBN.Enabled = false;
            this.tb_ISBN.Location = new System.Drawing.Point(191, 99);
            this.tb_ISBN.Margin = new System.Windows.Forms.Padding(8);
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.Size = new System.Drawing.Size(450, 38);
            this.tb_ISBN.TabIndex = 35;
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            this.tb_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            // 
            // cb_s_ISBN
            // 
            this.cb_s_ISBN.AutoSize = true;
            this.cb_s_ISBN.Location = new System.Drawing.Point(16, 100);
            this.cb_s_ISBN.Margin = new System.Windows.Forms.Padding(8);
            this.cb_s_ISBN.Name = "cb_s_ISBN";
            this.cb_s_ISBN.Size = new System.Drawing.Size(126, 36);
            this.cb_s_ISBN.TabIndex = 34;
            this.cb_s_ISBN.Text = "ISBN:";
            this.cb_s_ISBN.UseVisualStyleBackColor = true;
            this.cb_s_ISBN.CheckedChanged += new System.EventHandler(this.cb_s_ISBN_CheckedChanged);
            // 
            // cb_s_Nachname
            // 
            this.cb_s_Nachname.AutoSize = true;
            this.cb_s_Nachname.Location = new System.Drawing.Point(1894, 100);
            this.cb_s_Nachname.Margin = new System.Windows.Forms.Padding(8);
            this.cb_s_Nachname.Name = "cb_s_Nachname";
            this.cb_s_Nachname.Size = new System.Drawing.Size(198, 36);
            this.cb_s_Nachname.TabIndex = 33;
            this.cb_s_Nachname.Text = "Nachname:";
            this.cb_s_Nachname.UseVisualStyleBackColor = true;
            this.cb_s_Nachname.CheckedChanged += new System.EventHandler(this.checkBox_Nachname_CheckedChanged);
            // 
            // cb_s_Vorname
            // 
            this.cb_s_Vorname.AutoSize = true;
            this.cb_s_Vorname.Location = new System.Drawing.Point(1894, 46);
            this.cb_s_Vorname.Margin = new System.Windows.Forms.Padding(8);
            this.cb_s_Vorname.Name = "cb_s_Vorname";
            this.cb_s_Vorname.Size = new System.Drawing.Size(176, 36);
            this.cb_s_Vorname.TabIndex = 32;
            this.cb_s_Vorname.Text = "Vorname:";
            this.cb_s_Vorname.UseVisualStyleBackColor = true;
            this.cb_s_Vorname.CheckedChanged += new System.EventHandler(this.checkBox_Vorname_CheckedChanged);
            // 
            // tb_nachname
            // 
            this.tb_nachname.Enabled = false;
            this.tb_nachname.Location = new System.Drawing.Point(2108, 99);
            this.tb_nachname.Margin = new System.Windows.Forms.Padding(8);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(450, 38);
            this.tb_nachname.TabIndex = 31;
            this.tb_nachname.TextChanged += new System.EventHandler(this.tb_nachname_TextChanged);
            // 
            // tb_vorname
            // 
            this.tb_vorname.Enabled = false;
            this.tb_vorname.Location = new System.Drawing.Point(2108, 45);
            this.tb_vorname.Margin = new System.Windows.Forms.Padding(8);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(450, 38);
            this.tb_vorname.TabIndex = 30;
            this.tb_vorname.TextChanged += new System.EventHandler(this.tb_vorname_TextChanged);
            // 
            // combo_Verlag
            // 
            this.combo_Verlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Verlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Verlag.Enabled = false;
            this.combo_Verlag.FormattingEnabled = true;
            this.combo_Verlag.Location = new System.Drawing.Point(1428, 45);
            this.combo_Verlag.Margin = new System.Windows.Forms.Padding(8);
            this.combo_Verlag.Name = "combo_Verlag";
            this.combo_Verlag.Size = new System.Drawing.Size(450, 39);
            this.combo_Verlag.Sorted = true;
            this.combo_Verlag.TabIndex = 29;
            this.combo_Verlag.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            // 
            // combo_Genre
            // 
            this.combo_Genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Genre.Enabled = false;
            this.combo_Genre.FormattingEnabled = true;
            this.combo_Genre.Location = new System.Drawing.Point(1428, 99);
            this.combo_Genre.Margin = new System.Windows.Forms.Padding(8);
            this.combo_Genre.Name = "combo_Genre";
            this.combo_Genre.Size = new System.Drawing.Size(450, 39);
            this.combo_Genre.Sorted = true;
            this.combo_Genre.TabIndex = 28;
            this.combo_Genre.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            // 
            // combo_Autor
            // 
            this.combo_Autor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Autor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Autor.Enabled = false;
            this.combo_Autor.FormattingEnabled = true;
            this.combo_Autor.Location = new System.Drawing.Point(802, 99);
            this.combo_Autor.Margin = new System.Windows.Forms.Padding(8);
            this.combo_Autor.Name = "combo_Autor";
            this.combo_Autor.Size = new System.Drawing.Size(450, 39);
            this.combo_Autor.Sorted = true;
            this.combo_Autor.TabIndex = 27;
            this.combo_Autor.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(2800, 45);
            this.bt_Clear.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(291, 55);
            this.bt_Clear.TabIndex = 26;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // cb_s_Autor
            // 
            this.cb_s_Autor.AutoSize = true;
            this.cb_s_Autor.Location = new System.Drawing.Point(657, 100);
            this.cb_s_Autor.Margin = new System.Windows.Forms.Padding(8);
            this.cb_s_Autor.Name = "cb_s_Autor";
            this.cb_s_Autor.Size = new System.Drawing.Size(129, 36);
            this.cb_s_Autor.TabIndex = 24;
            this.cb_s_Autor.Text = "Autor:";
            this.cb_s_Autor.UseVisualStyleBackColor = true;
            this.cb_s_Autor.CheckedChanged += new System.EventHandler(this.cb_s_Autor_CheckedChanged);
            // 
            // cb_s_Genre
            // 
            this.cb_s_Genre.AutoSize = true;
            this.cb_s_Genre.Location = new System.Drawing.Point(1268, 100);
            this.cb_s_Genre.Margin = new System.Windows.Forms.Padding(8);
            this.cb_s_Genre.Name = "cb_s_Genre";
            this.cb_s_Genre.Size = new System.Drawing.Size(140, 36);
            this.cb_s_Genre.TabIndex = 23;
            this.cb_s_Genre.Text = "Genre:";
            this.cb_s_Genre.UseVisualStyleBackColor = true;
            this.cb_s_Genre.CheckedChanged += new System.EventHandler(this.cb_s_Genre_CheckedChanged);
            // 
            // cb_s_Verlag
            // 
            this.cb_s_Verlag.AutoSize = true;
            this.cb_s_Verlag.Location = new System.Drawing.Point(1268, 46);
            this.cb_s_Verlag.Margin = new System.Windows.Forms.Padding(8);
            this.cb_s_Verlag.Name = "cb_s_Verlag";
            this.cb_s_Verlag.Size = new System.Drawing.Size(144, 36);
            this.cb_s_Verlag.TabIndex = 22;
            this.cb_s_Verlag.Text = "Verlag:";
            this.cb_s_Verlag.UseVisualStyleBackColor = true;
            this.cb_s_Verlag.CheckedChanged += new System.EventHandler(this.cb_s_Verlag_CheckedChanged);
            // 
            // cb_s_Titel
            // 
            this.cb_s_Titel.AutoSize = true;
            this.cb_s_Titel.Location = new System.Drawing.Point(657, 46);
            this.cb_s_Titel.Margin = new System.Windows.Forms.Padding(8);
            this.cb_s_Titel.Name = "cb_s_Titel";
            this.cb_s_Titel.Size = new System.Drawing.Size(116, 36);
            this.cb_s_Titel.TabIndex = 21;
            this.cb_s_Titel.Text = "Titel:";
            this.cb_s_Titel.UseVisualStyleBackColor = true;
            this.cb_s_Titel.CheckedChanged += new System.EventHandler(this.cb_s_Titel_CheckedChanged);
            // 
            // tb_s_Titel
            // 
            this.tb_s_Titel.Enabled = false;
            this.tb_s_Titel.Location = new System.Drawing.Point(802, 45);
            this.tb_s_Titel.Margin = new System.Windows.Forms.Padding(8);
            this.tb_s_Titel.Name = "tb_s_Titel";
            this.tb_s_Titel.Size = new System.Drawing.Size(450, 38);
            this.tb_s_Titel.TabIndex = 17;
            this.tb_s_Titel.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            // 
            // bt_Rueckgabe
            // 
            this.bt_Rueckgabe.Location = new System.Drawing.Point(864, 878);
            this.bt_Rueckgabe.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Rueckgabe.Name = "bt_Rueckgabe";
            this.bt_Rueckgabe.Size = new System.Drawing.Size(400, 55);
            this.bt_Rueckgabe.TabIndex = 14;
            this.bt_Rueckgabe.Text = "Buchrückgabe";
            this.bt_Rueckgabe.UseVisualStyleBackColor = true;
            this.bt_Rueckgabe.Click += new System.EventHandler(this.bt_Rueckgabe_Click);
            // 
            // bt_AbbrechenAusleihen
            // 
            this.bt_AbbrechenAusleihen.Enabled = false;
            this.bt_AbbrechenAusleihen.Location = new System.Drawing.Point(448, 878);
            this.bt_AbbrechenAusleihen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_AbbrechenAusleihen.Name = "bt_AbbrechenAusleihen";
            this.bt_AbbrechenAusleihen.Size = new System.Drawing.Size(400, 55);
            this.bt_AbbrechenAusleihen.TabIndex = 19;
            this.bt_AbbrechenAusleihen.Text = "Ausleihvorgang abbrechen";
            this.bt_AbbrechenAusleihen.UseVisualStyleBackColor = true;
            this.bt_AbbrechenAusleihen.Click += new System.EventHandler(this.bt_AbbrechenAusleihen_Click);
            // 
            // w_s_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3163, 1459);
            this.Controls.Add(this.bt_Rueckgabe);
            this.Controls.Add(this.bt_AbbrechenAusleihen);
            this.Controls.Add(this.gb_Suchen);
            this.Controls.Add(this.bt_Ausleihen);
            this.Controls.Add(this.cb_Ausleihen);
            this.Controls.Add(this.cb_Ferfügbark_Anz);
            this.Controls.Add(this.cb_KundeAnz);
            this.Controls.Add(this.gv_Details);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "w_s_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buch Suchen/Ausleihen";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Details)).EndInit();
            this.cb_Ausleihen.ResumeLayout(false);
            this.cb_Ausleihen.PerformLayout();
            this.gb_Suchen.ResumeLayout(false);
            this.gb_Suchen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Details;
        private System.Windows.Forms.CheckBox cb_KundeAnz;
        private System.Windows.Forms.CheckBox cb_Ferfügbark_Anz;
        private System.Windows.Forms.DateTimePicker dateTimePickerAusleihen;
        private System.Windows.Forms.GroupBox cb_Ausleihen;
        private System.Windows.Forms.Label lb_Buch;
        private System.Windows.Forms.TextBox tb_BuchAusleihen;
        private System.Windows.Forms.TextBox tb_BuchIDAusleihen;
        private System.Windows.Forms.Label lb_Kunde;
        private System.Windows.Forms.TextBox tb_KundeAusleihen;
        private System.Windows.Forms.Label lb_Rück;
        private System.Windows.Forms.Button bt_Ausleihen;
        private System.Windows.Forms.Button bt_Abschliessen;
        private System.Windows.Forms.GroupBox gb_Suchen;
        private System.Windows.Forms.CheckBox cb_s_Autor;
        private System.Windows.Forms.CheckBox cb_s_Genre;
        private System.Windows.Forms.CheckBox cb_s_Verlag;
        private System.Windows.Forms.CheckBox cb_s_Titel;
        private System.Windows.Forms.TextBox tb_s_Titel;
        private System.Windows.Forms.TextBox tb_KundenIDAusleihen;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Rueckgabe;
        private System.Windows.Forms.ComboBox combo_Genre;
        private System.Windows.Forms.ComboBox combo_Autor;
        private System.Windows.Forms.ComboBox combo_Verlag;
        private System.Windows.Forms.Label lb_verleihfaehig;
        private System.Windows.Forms.TextBox tb_verleihfaehigAusleihen;
        private System.Windows.Forms.Label lb_Zustand;
        private System.Windows.Forms.TextBox tb_ZustandAusleihen;
        private System.Windows.Forms.Button bt_AbbrechenAusleihen;
        private System.Windows.Forms.CheckBox cb_s_Nachname;
        private System.Windows.Forms.CheckBox cb_s_Vorname;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.CheckBox cb_s_ISBN;
        private System.Windows.Forms.CheckBox cb_s_ID;
        private System.Windows.Forms.TextBox tb_ID;
    }
}