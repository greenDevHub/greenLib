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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_details));
            this.gv_Details = new System.Windows.Forms.DataGridView();
            this.cb_KundeAnz = new System.Windows.Forms.CheckBox();
            this.cb_Ferfügbark_Anz = new System.Windows.Forms.CheckBox();
            this.dateTimePickerAusleihen = new System.Windows.Forms.DateTimePicker();
            this.cb_Ausleihen = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
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
            this.lb_nachname = new System.Windows.Forms.Label();
            this.lb_vorname = new System.Windows.Forms.Label();
            this.lb_verlag = new System.Windows.Forms.Label();
            this.lb_Genre = new System.Windows.Forms.Label();
            this.lb_autor = new System.Windows.Forms.Label();
            this.lb_titel = new System.Windows.Forms.Label();
            this.lb_isbn = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.tb_ID = new System.Windows.Forms.TextBox();
            this.tb_ISBN = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.combo_Verlag = new System.Windows.Forms.ComboBox();
            this.combo_Genre = new System.Windows.Forms.ComboBox();
            this.combo_Autor = new System.Windows.Forms.ComboBox();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.tb_s_Titel = new System.Windows.Forms.TextBox();
            this.bt_Rueckgabe = new System.Windows.Forms.Button();
            this.bt_AbbrechenAusleihen = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Details)).BeginInit();
            this.cb_Ausleihen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.helpProvider.SetHelpString(this.gv_Details, "In diesem Feld werden all ihre Bücher und evtl. vorhandene Ausleihvorgänge angeze" +
        "igt.");
            this.gv_Details.Location = new System.Drawing.Point(16, 110);
            this.gv_Details.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gv_Details.MultiSelect = false;
            this.gv_Details.Name = "gv_Details";
            this.gv_Details.ReadOnly = true;
            this.gv_Details.RowHeadersWidth = 35;
            this.gv_Details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Details.ShowEditingIcon = false;
            this.helpProvider.SetShowHelp(this.gv_Details, true);
            this.gv_Details.Size = new System.Drawing.Size(1333, 336);
            this.gv_Details.TabIndex = 0;
            this.gv_Details.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_Details_ColumnHeaderMouseClick);
            this.gv_Details.Paint += new System.Windows.Forms.PaintEventHandler(this.gv_Details_Paint);
            // 
            // cb_KundeAnz
            // 
            this.cb_KundeAnz.AutoSize = true;
            this.helpProvider.SetHelpString(this.cb_KundeAnz, "Setzen sie einen Haken in dieses Feld, werden ihnen im obenliegenden Feld Kundeni" +
        "nformationen bei ausgeliehenen Büchern angezeigt.");
            this.cb_KundeAnz.Location = new System.Drawing.Point(1108, 453);
            this.cb_KundeAnz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_KundeAnz.Name = "cb_KundeAnz";
            this.helpProvider.SetShowHelp(this.cb_KundeAnz, true);
            this.cb_KundeAnz.Size = new System.Drawing.Size(239, 21);
            this.cb_KundeAnz.TabIndex = 1;
            this.cb_KundeAnz.Text = "Kundeninformationen einblenden";
            this.cb_KundeAnz.UseVisualStyleBackColor = true;
            this.cb_KundeAnz.CheckedChanged += new System.EventHandler(this.cb_KundeAnz_CheckedChanged);
            // 
            // cb_Ferfügbark_Anz
            // 
            this.cb_Ferfügbark_Anz.AutoSize = true;
            this.helpProvider.SetHelpString(this.cb_Ferfügbark_Anz, "Setzen sie einen Haken in dieses Feld, werden ihnen nur Bücher angezeigt, welche " +
        "verliehen werden können.");
            this.cb_Ferfügbark_Anz.Location = new System.Drawing.Point(832, 453);
            this.cb_Ferfügbark_Anz.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Ferfügbark_Anz.Name = "cb_Ferfügbark_Anz";
            this.helpProvider.SetShowHelp(this.cb_Ferfügbark_Anz, true);
            this.cb_Ferfügbark_Anz.Size = new System.Drawing.Size(266, 21);
            this.cb_Ferfügbark_Anz.TabIndex = 2;
            this.cb_Ferfügbark_Anz.Text = "Nur verleihbereite Bücher einblenden";
            this.cb_Ferfügbark_Anz.UseVisualStyleBackColor = true;
            this.cb_Ferfügbark_Anz.CheckedChanged += new System.EventHandler(this.cb_Ferfügbark_Anz_CheckedChanged);
            // 
            // dateTimePickerAusleihen
            // 
            this.dateTimePickerAusleihen.Location = new System.Drawing.Point(172, 155);
            this.dateTimePickerAusleihen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerAusleihen.Name = "dateTimePickerAusleihen";
            this.dateTimePickerAusleihen.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerAusleihen.TabIndex = 3;
            // 
            // cb_Ausleihen
            // 
            this.cb_Ausleihen.Controls.Add(this.pictureBox1);
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
            this.cb_Ausleihen.Location = new System.Drawing.Point(16, 489);
            this.cb_Ausleihen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Ausleihen.Name = "cb_Ausleihen";
            this.cb_Ausleihen.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_Ausleihen.Size = new System.Drawing.Size(1333, 249);
            this.cb_Ausleihen.TabIndex = 5;
            this.cb_Ausleihen.TabStop = false;
            this.cb_Ausleihen.Text = "Buch ausleihen:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(447, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 214);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // lb_verleihfaehig
            // 
            this.lb_verleihfaehig.AutoSize = true;
            this.lb_verleihfaehig.Location = new System.Drawing.Point(8, 95);
            this.lb_verleihfaehig.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_verleihfaehig.Name = "lb_verleihfaehig";
            this.lb_verleihfaehig.Size = new System.Drawing.Size(87, 17);
            this.lb_verleihfaehig.TabIndex = 16;
            this.lb_verleihfaehig.Text = "Verleihfähig:";
            // 
            // tb_verleihfaehigAusleihen
            // 
            this.tb_verleihfaehigAusleihen.Location = new System.Drawing.Point(172, 91);
            this.tb_verleihfaehigAusleihen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_verleihfaehigAusleihen.Name = "tb_verleihfaehigAusleihen";
            this.tb_verleihfaehigAusleihen.ReadOnly = true;
            this.tb_verleihfaehigAusleihen.Size = new System.Drawing.Size(265, 22);
            this.tb_verleihfaehigAusleihen.TabIndex = 15;
            this.tb_verleihfaehigAusleihen.TabStop = false;
            // 
            // lb_Zustand
            // 
            this.lb_Zustand.AutoSize = true;
            this.lb_Zustand.Location = new System.Drawing.Point(8, 63);
            this.lb_Zustand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Zustand.Name = "lb_Zustand";
            this.lb_Zustand.Size = new System.Drawing.Size(64, 17);
            this.lb_Zustand.TabIndex = 14;
            this.lb_Zustand.Text = "Zustand:";
            // 
            // tb_ZustandAusleihen
            // 
            this.tb_ZustandAusleihen.Location = new System.Drawing.Point(172, 59);
            this.tb_ZustandAusleihen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ZustandAusleihen.Name = "tb_ZustandAusleihen";
            this.tb_ZustandAusleihen.ReadOnly = true;
            this.tb_ZustandAusleihen.Size = new System.Drawing.Size(265, 22);
            this.tb_ZustandAusleihen.TabIndex = 13;
            this.tb_ZustandAusleihen.TabStop = false;
            this.tb_ZustandAusleihen.TextChanged += new System.EventHandler(this.tb_ZustandAusleihen_TextChanged);
            // 
            // tb_KundenIDAusleihen
            // 
            this.tb_KundenIDAusleihen.Enabled = false;
            this.tb_KundenIDAusleihen.Location = new System.Drawing.Point(132, 123);
            this.tb_KundenIDAusleihen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_KundenIDAusleihen.Name = "tb_KundenIDAusleihen";
            this.tb_KundenIDAusleihen.ReadOnly = true;
            this.tb_KundenIDAusleihen.Size = new System.Drawing.Size(31, 22);
            this.tb_KundenIDAusleihen.TabIndex = 12;
            this.tb_KundenIDAusleihen.TabStop = false;
            this.tb_KundenIDAusleihen.Visible = false;
            // 
            // bt_Abschliessen
            // 
            this.bt_Abschliessen.Enabled = false;
            this.bt_Abschliessen.Location = new System.Drawing.Point(196, 209);
            this.bt_Abschliessen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Abschliessen.Name = "bt_Abschliessen";
            this.bt_Abschliessen.Size = new System.Drawing.Size(243, 32);
            this.bt_Abschliessen.TabIndex = 11;
            this.bt_Abschliessen.Text = "Ausleihvorgang abschließen";
            this.bt_Abschliessen.UseVisualStyleBackColor = true;
            this.bt_Abschliessen.Click += new System.EventHandler(this.Ausleihen_Bestaetigen);
            // 
            // lb_Kunde
            // 
            this.lb_Kunde.AutoSize = true;
            this.lb_Kunde.Location = new System.Drawing.Point(8, 127);
            this.lb_Kunde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Kunde.Name = "lb_Kunde";
            this.lb_Kunde.Size = new System.Drawing.Size(53, 17);
            this.lb_Kunde.TabIndex = 10;
            this.lb_Kunde.Text = "Kunde:";
            // 
            // tb_KundeAusleihen
            // 
            this.tb_KundeAusleihen.Location = new System.Drawing.Point(172, 123);
            this.tb_KundeAusleihen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_KundeAusleihen.Name = "tb_KundeAusleihen";
            this.tb_KundeAusleihen.ReadOnly = true;
            this.tb_KundeAusleihen.Size = new System.Drawing.Size(265, 22);
            this.tb_KundeAusleihen.TabIndex = 9;
            this.tb_KundeAusleihen.TabStop = false;
            // 
            // lb_Rück
            // 
            this.lb_Rück.AutoSize = true;
            this.lb_Rück.Location = new System.Drawing.Point(9, 159);
            this.lb_Rück.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Rück.Name = "lb_Rück";
            this.lb_Rück.Size = new System.Drawing.Size(115, 17);
            this.lb_Rück.TabIndex = 8;
            this.lb_Rück.Text = "Rückgabedatum:";
            // 
            // lb_Buch
            // 
            this.lb_Buch.AutoSize = true;
            this.lb_Buch.Location = new System.Drawing.Point(8, 31);
            this.lb_Buch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Buch.Name = "lb_Buch";
            this.lb_Buch.Size = new System.Drawing.Size(44, 17);
            this.lb_Buch.TabIndex = 7;
            this.lb_Buch.Text = "Buch:";
            // 
            // tb_BuchAusleihen
            // 
            this.tb_BuchAusleihen.Location = new System.Drawing.Point(172, 27);
            this.tb_BuchAusleihen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_BuchAusleihen.Name = "tb_BuchAusleihen";
            this.tb_BuchAusleihen.ReadOnly = true;
            this.tb_BuchAusleihen.Size = new System.Drawing.Size(265, 22);
            this.tb_BuchAusleihen.TabIndex = 6;
            this.tb_BuchAusleihen.TabStop = false;
            // 
            // tb_BuchIDAusleihen
            // 
            this.tb_BuchIDAusleihen.Enabled = false;
            this.tb_BuchIDAusleihen.Location = new System.Drawing.Point(132, 27);
            this.tb_BuchIDAusleihen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_BuchIDAusleihen.Name = "tb_BuchIDAusleihen";
            this.tb_BuchIDAusleihen.ReadOnly = true;
            this.tb_BuchIDAusleihen.Size = new System.Drawing.Size(31, 22);
            this.tb_BuchIDAusleihen.TabIndex = 4;
            this.tb_BuchIDAusleihen.TabStop = false;
            this.tb_BuchIDAusleihen.Visible = false;
            // 
            // bt_Ausleihen
            // 
            this.helpProvider.SetHelpString(this.bt_Ausleihen, "Klicken sie auf diesen Button, nachdem sie ein Buch im obenliegenden Feld makiert" +
        " haben, um dieses gewählte Buch auszuleihen.");
            this.bt_Ausleihen.Location = new System.Drawing.Point(16, 453);
            this.bt_Ausleihen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Ausleihen.Name = "bt_Ausleihen";
            this.helpProvider.SetShowHelp(this.bt_Ausleihen, true);
            this.bt_Ausleihen.Size = new System.Drawing.Size(200, 28);
            this.bt_Ausleihen.TabIndex = 11;
            this.bt_Ausleihen.Text = "Ausleihvorgang starten";
            this.bt_Ausleihen.UseVisualStyleBackColor = true;
            this.bt_Ausleihen.Click += new System.EventHandler(this.Ausleihvorgang);
            // 
            // gb_Suchen
            // 
            this.gb_Suchen.Controls.Add(this.lb_nachname);
            this.gb_Suchen.Controls.Add(this.lb_vorname);
            this.gb_Suchen.Controls.Add(this.lb_verlag);
            this.gb_Suchen.Controls.Add(this.lb_Genre);
            this.gb_Suchen.Controls.Add(this.lb_autor);
            this.gb_Suchen.Controls.Add(this.lb_titel);
            this.gb_Suchen.Controls.Add(this.lb_isbn);
            this.gb_Suchen.Controls.Add(this.lb_id);
            this.gb_Suchen.Controls.Add(this.tb_ID);
            this.gb_Suchen.Controls.Add(this.tb_ISBN);
            this.gb_Suchen.Controls.Add(this.tb_nachname);
            this.gb_Suchen.Controls.Add(this.tb_vorname);
            this.gb_Suchen.Controls.Add(this.combo_Verlag);
            this.gb_Suchen.Controls.Add(this.combo_Genre);
            this.gb_Suchen.Controls.Add(this.combo_Autor);
            this.gb_Suchen.Controls.Add(this.bt_Clear);
            this.gb_Suchen.Controls.Add(this.tb_s_Titel);
            this.helpProvider.SetHelpString(this.gb_Suchen, resources.GetString("gb_Suchen.HelpString"));
            this.gb_Suchen.Location = new System.Drawing.Point(16, 14);
            this.gb_Suchen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gb_Suchen.Name = "gb_Suchen";
            this.gb_Suchen.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.helpProvider.SetShowHelp(this.gb_Suchen, true);
            this.gb_Suchen.Size = new System.Drawing.Size(1333, 89);
            this.gb_Suchen.TabIndex = 13;
            this.gb_Suchen.TabStop = false;
            this.gb_Suchen.Text = "Suchen nach:";
            // 
            // lb_nachname
            // 
            this.lb_nachname.AutoSize = true;
            this.lb_nachname.BackColor = System.Drawing.SystemColors.Window;
            this.lb_nachname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_nachname.ForeColor = System.Drawing.Color.Gray;
            this.helpProvider.SetHelpString(this.lb_nachname, "Tragen sie hier den Nachnamen des gesuchten Kunden ein, welcher einen Ausleihvorg" +
        "ang getätigt hat.");
            this.lb_nachname.Location = new System.Drawing.Point(869, 59);
            this.lb_nachname.Name = "lb_nachname";
            this.helpProvider.SetShowHelp(this.lb_nachname, true);
            this.lb_nachname.Size = new System.Drawing.Size(76, 17);
            this.lb_nachname.TabIndex = 44;
            this.lb_nachname.Text = "Nachname";
            this.lb_nachname.Click += new System.EventHandler(this.lb_nachname_Click);
            // 
            // lb_vorname
            // 
            this.lb_vorname.AutoSize = true;
            this.lb_vorname.BackColor = System.Drawing.SystemColors.Window;
            this.lb_vorname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_vorname.ForeColor = System.Drawing.Color.Gray;
            this.helpProvider.SetHelpString(this.lb_vorname, "Tragen sie hier den Vornamen des gesuchten Kunden ein, welcher einen Ausleihvorga" +
        "ng getätigt hat.");
            this.lb_vorname.Location = new System.Drawing.Point(869, 27);
            this.lb_vorname.Name = "lb_vorname";
            this.helpProvider.SetShowHelp(this.lb_vorname, true);
            this.lb_vorname.Size = new System.Drawing.Size(65, 17);
            this.lb_vorname.TabIndex = 43;
            this.lb_vorname.Text = "Vorname";
            this.lb_vorname.Click += new System.EventHandler(this.lb_vorname_Click);
            // 
            // lb_verlag
            // 
            this.lb_verlag.AutoSize = true;
            this.lb_verlag.BackColor = System.Drawing.SystemColors.Window;
            this.lb_verlag.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_verlag.ForeColor = System.Drawing.Color.Gray;
            this.helpProvider.SetHelpString(this.lb_verlag, "Tragen sie hier den Verlag ein, um das ausgeliehene Buch zu laden.");
            this.lb_verlag.Location = new System.Drawing.Point(536, 27);
            this.lb_verlag.Name = "lb_verlag";
            this.helpProvider.SetShowHelp(this.lb_verlag, true);
            this.lb_verlag.Size = new System.Drawing.Size(49, 17);
            this.lb_verlag.TabIndex = 42;
            this.lb_verlag.Text = "Verlag";
            this.lb_verlag.Click += new System.EventHandler(this.lb_verlag_Click);
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.lb_Genre.BackColor = System.Drawing.SystemColors.Window;
            this.lb_Genre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_Genre.ForeColor = System.Drawing.Color.Gray;
            this.helpProvider.SetHelpString(this.lb_Genre, "Tragen sie hier das Genre ein, um das ausgeliehene Buch zu laden.");
            this.lb_Genre.Location = new System.Drawing.Point(537, 59);
            this.lb_Genre.Name = "lb_Genre";
            this.helpProvider.SetShowHelp(this.lb_Genre, true);
            this.lb_Genre.Size = new System.Drawing.Size(48, 17);
            this.lb_Genre.TabIndex = 41;
            this.lb_Genre.Text = "Genre";
            this.lb_Genre.Click += new System.EventHandler(this.lb_Genre_Click);
            // 
            // lb_autor
            // 
            this.lb_autor.AutoSize = true;
            this.lb_autor.BackColor = System.Drawing.SystemColors.Window;
            this.lb_autor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_autor.ForeColor = System.Drawing.Color.Gray;
            this.helpProvider.SetHelpString(this.lb_autor, "Tragen sie hier den Buchautor ein, um das ausgeliehene Buch zu laden.");
            this.lb_autor.Location = new System.Drawing.Point(269, 59);
            this.lb_autor.Name = "lb_autor";
            this.helpProvider.SetShowHelp(this.lb_autor, true);
            this.lb_autor.Size = new System.Drawing.Size(42, 17);
            this.lb_autor.TabIndex = 40;
            this.lb_autor.Text = "Autor";
            this.lb_autor.Click += new System.EventHandler(this.lb_autor_Click);
            // 
            // lb_titel
            // 
            this.lb_titel.AutoSize = true;
            this.lb_titel.BackColor = System.Drawing.SystemColors.Window;
            this.lb_titel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_titel.ForeColor = System.Drawing.Color.Gray;
            this.helpProvider.SetHelpString(this.lb_titel, "Tragen sie hier den Buchtitel ein, um das ausgeliehene Buch zu laden.");
            this.lb_titel.Location = new System.Drawing.Point(269, 27);
            this.lb_titel.Name = "lb_titel";
            this.helpProvider.SetShowHelp(this.lb_titel, true);
            this.lb_titel.Size = new System.Drawing.Size(35, 17);
            this.lb_titel.TabIndex = 39;
            this.lb_titel.Text = "Titel";
            this.lb_titel.Click += new System.EventHandler(this.lb_titel_Click);
            // 
            // lb_isbn
            // 
            this.lb_isbn.AutoSize = true;
            this.lb_isbn.BackColor = System.Drawing.SystemColors.Window;
            this.lb_isbn.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_isbn.ForeColor = System.Drawing.Color.Gray;
            this.helpProvider.SetHelpString(this.lb_isbn, "Tragen sie hier die ISBN-13 ein, um das ausgeliehene Buch zu laden.");
            this.lb_isbn.Location = new System.Drawing.Point(12, 59);
            this.lb_isbn.Name = "lb_isbn";
            this.helpProvider.SetShowHelp(this.lb_isbn, true);
            this.lb_isbn.Size = new System.Drawing.Size(39, 17);
            this.lb_isbn.TabIndex = 38;
            this.lb_isbn.Text = "ISBN";
            this.lb_isbn.Click += new System.EventHandler(this.lb_isbn_Click);
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.BackColor = System.Drawing.SystemColors.Window;
            this.lb_id.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_id.ForeColor = System.Drawing.Color.Gray;
            this.helpProvider.SetHelpString(this.lb_id, "Tragen sie hier die Buch-ID ein, um das gewünschte Buch zu laden.");
            this.lb_id.Location = new System.Drawing.Point(12, 27);
            this.lb_id.Name = "lb_id";
            this.helpProvider.SetShowHelp(this.lb_id, true);
            this.lb_id.Size = new System.Drawing.Size(58, 17);
            this.lb_id.TabIndex = 37;
            this.lb_id.Text = "Buch-ID";
            this.lb_id.Click += new System.EventHandler(this.lb_id_Click);
            // 
            // tb_ID
            // 
            this.helpProvider.SetHelpString(this.tb_ID, "Tragen sie hier die Buch-ID ein, um das gewünschte Buch zu laden.");
            this.tb_ID.Location = new System.Drawing.Point(8, 23);
            this.tb_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ID.Name = "tb_ID";
            this.helpProvider.SetShowHelp(this.tb_ID, true);
            this.tb_ID.Size = new System.Drawing.Size(227, 22);
            this.tb_ID.TabIndex = 36;
            this.tb_ID.Click += new System.EventHandler(this.tb_ID_Click);
            this.tb_ID.TextChanged += new System.EventHandler(this.tb_ID_TextChanged);
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ID_KeyPress);
            this.tb_ID.Leave += new System.EventHandler(this.tb_ID_Leave);
            // 
            // tb_ISBN
            // 
            this.helpProvider.SetHelpKeyword(this.tb_ISBN, "");
            this.helpProvider.SetHelpString(this.tb_ISBN, "Tragen sie hier die ISBN-13 ein, um das ausgeliehene Buch zu laden.");
            this.tb_ISBN.Location = new System.Drawing.Point(8, 55);
            this.tb_ISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_ISBN.Name = "tb_ISBN";
            this.helpProvider.SetShowHelp(this.tb_ISBN, true);
            this.tb_ISBN.Size = new System.Drawing.Size(227, 22);
            this.tb_ISBN.TabIndex = 35;
            this.tb_ISBN.Click += new System.EventHandler(this.tb_ISBN_Click);
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            this.tb_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            this.tb_ISBN.Leave += new System.EventHandler(this.tb_ISBN_Leave);
            // 
            // tb_nachname
            // 
            this.tb_nachname.Enabled = false;
            this.helpProvider.SetHelpString(this.tb_nachname, "Tragen sie hier den Nachnamen des gesuchten Kunden ein, welcher einen Ausleihvorg" +
        "ang getätigt hat.");
            this.tb_nachname.Location = new System.Drawing.Point(867, 55);
            this.tb_nachname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_nachname.Name = "tb_nachname";
            this.helpProvider.SetShowHelp(this.tb_nachname, true);
            this.tb_nachname.Size = new System.Drawing.Size(227, 22);
            this.tb_nachname.TabIndex = 31;
            this.tb_nachname.Click += new System.EventHandler(this.tb_nachname_Click);
            this.tb_nachname.TextChanged += new System.EventHandler(this.tb_nachname_TextChanged);
            this.tb_nachname.Leave += new System.EventHandler(this.tb_nachname_Leave);
            // 
            // tb_vorname
            // 
            this.tb_vorname.Enabled = false;
            this.helpProvider.SetHelpString(this.tb_vorname, "Tragen sie hier den Vornamen des gesuchten Kunden ein, welcher einen Ausleihvorga" +
        "ng getätigt hat.");
            this.tb_vorname.Location = new System.Drawing.Point(867, 23);
            this.tb_vorname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_vorname.Name = "tb_vorname";
            this.helpProvider.SetShowHelp(this.tb_vorname, true);
            this.tb_vorname.Size = new System.Drawing.Size(227, 22);
            this.tb_vorname.TabIndex = 30;
            this.tb_vorname.Click += new System.EventHandler(this.tb_vorname_Click);
            this.tb_vorname.TextChanged += new System.EventHandler(this.tb_vorname_TextChanged);
            this.tb_vorname.Leave += new System.EventHandler(this.tb_vorname_Leave);
            // 
            // combo_Verlag
            // 
            this.combo_Verlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Verlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Verlag.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.combo_Verlag, "Tragen sie hier den Verlag ein, um das ausgeliehene Buch zu laden.");
            this.combo_Verlag.Location = new System.Drawing.Point(533, 23);
            this.combo_Verlag.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_Verlag.Name = "combo_Verlag";
            this.helpProvider.SetShowHelp(this.combo_Verlag, true);
            this.combo_Verlag.Size = new System.Drawing.Size(227, 24);
            this.combo_Verlag.Sorted = true;
            this.combo_Verlag.TabIndex = 29;
            this.combo_Verlag.SelectedIndexChanged += new System.EventHandler(this.combo_Verlag_SelectedIndexChanged);
            this.combo_Verlag.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            this.combo_Verlag.Click += new System.EventHandler(this.combo_Verlag_Click);
            this.combo_Verlag.Leave += new System.EventHandler(this.combo_Verlag_Leave);
            // 
            // combo_Genre
            // 
            this.combo_Genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Genre.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.combo_Genre, "Tragen sie hier das Genre ein, um das ausgeliehene Buch zu laden.");
            this.combo_Genre.Location = new System.Drawing.Point(533, 55);
            this.combo_Genre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_Genre.Name = "combo_Genre";
            this.helpProvider.SetShowHelp(this.combo_Genre, true);
            this.combo_Genre.Size = new System.Drawing.Size(227, 24);
            this.combo_Genre.Sorted = true;
            this.combo_Genre.TabIndex = 28;
            this.combo_Genre.SelectedIndexChanged += new System.EventHandler(this.combo_Genre_SelectedIndexChanged);
            this.combo_Genre.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            this.combo_Genre.Click += new System.EventHandler(this.combo_Genre_Click);
            this.combo_Genre.Leave += new System.EventHandler(this.combo_Genre_Leave);
            // 
            // combo_Autor
            // 
            this.combo_Autor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Autor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Autor.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.combo_Autor, "Tragen sie hier den Buchautor ein, um das ausgeliehene Buch zu laden.");
            this.combo_Autor.Location = new System.Drawing.Point(267, 55);
            this.combo_Autor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.combo_Autor.Name = "combo_Autor";
            this.helpProvider.SetShowHelp(this.combo_Autor, true);
            this.combo_Autor.Size = new System.Drawing.Size(227, 24);
            this.combo_Autor.Sorted = true;
            this.combo_Autor.TabIndex = 27;
            this.combo_Autor.SelectedIndexChanged += new System.EventHandler(this.combo_Autor_SelectedIndexChanged);
            this.combo_Autor.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            this.combo_Autor.Click += new System.EventHandler(this.combo_Autor_Click);
            this.combo_Autor.Leave += new System.EventHandler(this.combo_Autor_Leave);
            // 
            // bt_Clear
            // 
            this.helpProvider.SetHelpString(this.bt_Clear, "Leeren sie alle linksseitig liegenden Textfelder.");
            this.bt_Clear.Location = new System.Drawing.Point(1203, 23);
            this.bt_Clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Clear.Name = "bt_Clear";
            this.helpProvider.SetShowHelp(this.bt_Clear, true);
            this.bt_Clear.Size = new System.Drawing.Size(123, 57);
            this.bt_Clear.TabIndex = 26;
            this.bt_Clear.Text = "Leeren";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // tb_s_Titel
            // 
            this.helpProvider.SetHelpString(this.tb_s_Titel, "Tragen sie hier den Buchtitel ein, um das ausgeliehene Buch zu laden.");
            this.tb_s_Titel.Location = new System.Drawing.Point(267, 23);
            this.tb_s_Titel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_s_Titel.Name = "tb_s_Titel";
            this.helpProvider.SetShowHelp(this.tb_s_Titel, true);
            this.tb_s_Titel.Size = new System.Drawing.Size(227, 22);
            this.tb_s_Titel.TabIndex = 17;
            this.tb_s_Titel.Click += new System.EventHandler(this.tb_s_Titel_Click);
            this.tb_s_Titel.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            this.tb_s_Titel.Leave += new System.EventHandler(this.tb_s_Titel_Leave);
            // 
            // bt_Rueckgabe
            // 
            this.bt_Rueckgabe.Location = new System.Drawing.Point(432, 453);
            this.bt_Rueckgabe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Rueckgabe.Name = "bt_Rueckgabe";
            this.bt_Rueckgabe.Size = new System.Drawing.Size(200, 28);
            this.bt_Rueckgabe.TabIndex = 14;
            this.bt_Rueckgabe.Text = "Buchrückgabe";
            this.bt_Rueckgabe.UseVisualStyleBackColor = true;
            this.bt_Rueckgabe.Click += new System.EventHandler(this.bt_Rueckgabe_Click);
            // 
            // bt_AbbrechenAusleihen
            // 
            this.bt_AbbrechenAusleihen.Enabled = false;
            this.bt_AbbrechenAusleihen.Location = new System.Drawing.Point(224, 453);
            this.bt_AbbrechenAusleihen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_AbbrechenAusleihen.Name = "bt_AbbrechenAusleihen";
            this.bt_AbbrechenAusleihen.Size = new System.Drawing.Size(200, 28);
            this.bt_AbbrechenAusleihen.TabIndex = 19;
            this.bt_AbbrechenAusleihen.Text = "Ausleihvorgang abbrechen";
            this.bt_AbbrechenAusleihen.UseVisualStyleBackColor = true;
            this.bt_AbbrechenAusleihen.Click += new System.EventHandler(this.bt_AbbrechenAusleihen_Click);
            // 
            // w_s_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 753);
            this.Controls.Add(this.bt_Rueckgabe);
            this.Controls.Add(this.bt_AbbrechenAusleihen);
            this.Controls.Add(this.gb_Suchen);
            this.Controls.Add(this.bt_Ausleihen);
            this.Controls.Add(this.cb_Ausleihen);
            this.Controls.Add(this.cb_Ferfügbark_Anz);
            this.Controls.Add(this.cb_KundeAnz);
            this.Controls.Add(this.gv_Details);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buch Suchen/Ausleihen";
            this.Activated += new System.EventHandler(this.w_s_details_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Details)).EndInit();
            this.cb_Ausleihen.ResumeLayout(false);
            this.cb_Ausleihen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.TextBox tb_ISBN;
        private System.Windows.Forms.TextBox tb_ID;
        private System.Windows.Forms.Label lb_isbn;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_nachname;
        private System.Windows.Forms.Label lb_vorname;
        private System.Windows.Forms.Label lb_verlag;
        private System.Windows.Forms.Label lb_Genre;
        private System.Windows.Forms.Label lb_autor;
        private System.Windows.Forms.Label lb_titel;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}