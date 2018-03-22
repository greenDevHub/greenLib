namespace Bibo_Verwaltung
{
    partial class w_s_Kunden
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_Kunden));
            this.lb_Telefonnummer = new System.Windows.Forms.Label();
            this.tb_Telefonnummer = new System.Windows.Forms.TextBox();
            this.gb_kunde = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Vorname = new System.Windows.Forms.Label();
            this.lb_Nachname = new System.Windows.Forms.Label();
            this.tb_KundenID = new System.Windows.Forms.TextBox();
            this.lb_Strasse = new System.Windows.Forms.Label();
            this.lb_Hausnummer = new System.Windows.Forms.Label();
            this.lb_Postleitzahl = new System.Windows.Forms.Label();
            this.tb_Nachname = new System.Windows.Forms.TextBox();
            this.lb_Ort = new System.Windows.Forms.Label();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.lb_Vertrauenswuerdigkeit = new System.Windows.Forms.Label();
            this.tb_Strasse = new System.Windows.Forms.TextBox();
            this.lb_Klasse = new System.Windows.Forms.Label();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.lb_Mail = new System.Windows.Forms.Label();
            this.tb_Hausnummer = new System.Windows.Forms.TextBox();
            this.tb_Klasse = new System.Windows.Forms.TextBox();
            this.tb_Postleitzahl = new System.Windows.Forms.TextBox();
            this.tb_Ort = new System.Windows.Forms.TextBox();
            this.cb_Vertrauenswuerdigkeit = new System.Windows.Forms.ComboBox();
            this.lb_KundenID = new System.Windows.Forms.Label();
            this.lb_kunde_add = new System.Windows.Forms.Label();
            this.bt_clear = new System.Windows.Forms.Button();
            this.rb_KundeLoeschen = new System.Windows.Forms.RadioButton();
            this.rb_KundeBearbeiten = new System.Windows.Forms.RadioButton();
            this.rb_Neukunde = new System.Windows.Forms.RadioButton();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.gv_Kunde = new System.Windows.Forms.DataGridView();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.bt_ImEx = new System.Windows.Forms.Button();
            this.cb_showAll = new System.Windows.Forms.CheckBox();
            this.gb_kunde.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Telefonnummer
            // 
            this.lb_Telefonnummer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Telefonnummer.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Telefonnummer, "Tragen sie die Telefonnummer ihres Kunden hier ein.");
            this.lb_Telefonnummer.Location = new System.Drawing.Point(3, 309);
            this.lb_Telefonnummer.Name = "lb_Telefonnummer";
            this.helpProvider.SetShowHelp(this.lb_Telefonnummer, true);
            this.lb_Telefonnummer.Size = new System.Drawing.Size(113, 13);
            this.lb_Telefonnummer.TabIndex = 16;
            this.lb_Telefonnummer.Text = "Telefonnummer:";
            // 
            // tb_Telefonnummer
            // 
            this.tb_Telefonnummer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.tb_Telefonnummer, "Tragen sie die Telefonnummer ihres Kunden hier ein.");
            this.tb_Telefonnummer.Location = new System.Drawing.Point(123, 305);
            this.tb_Telefonnummer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Telefonnummer.Name = "tb_Telefonnummer";
            this.helpProvider.SetShowHelp(this.tb_Telefonnummer, true);
            this.tb_Telefonnummer.Size = new System.Drawing.Size(143, 20);
            this.tb_Telefonnummer.TabIndex = 11;
            this.tb_Telefonnummer.TextChanged += new System.EventHandler(this.tb_Telefonnummer_TextChanged);
            // 
            // gb_kunde
            // 
            this.gb_kunde.Controls.Add(this.tableLayoutPanel1);
            this.gb_kunde.Controls.Add(this.lb_kunde_add);
            this.gb_kunde.Controls.Add(this.bt_clear);
            this.gb_kunde.Controls.Add(this.rb_KundeLoeschen);
            this.gb_kunde.Controls.Add(this.rb_KundeBearbeiten);
            this.gb_kunde.Controls.Add(this.rb_Neukunde);
            this.gb_kunde.Controls.Add(this.bt_confirm);
            this.gb_kunde.Location = new System.Drawing.Point(6, 6);
            this.gb_kunde.Name = "gb_kunde";
            this.gb_kunde.Size = new System.Drawing.Size(288, 434);
            this.gb_kunde.TabIndex = 0;
            this.gb_kunde.TabStop = false;
            this.gb_kunde.Text = "Kunden";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Vorname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Nachname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_KundenID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Strasse, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Hausnummer, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_Telefonnummer, 1, 10);
            this.tableLayoutPanel1.Controls.Add(this.lb_Postleitzahl, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Nachname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_Ort, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Vorname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Vertrauenswuerdigkeit, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.tb_Strasse, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Klasse, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.tb_Mail, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.lb_Mail, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.tb_Hausnummer, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lb_Telefonnummer, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.tb_Klasse, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.tb_Postleitzahl, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Ort, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.cb_Vertrauenswuerdigkeit, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.lb_KundenID, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 331);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // lb_Vorname
            // 
            this.lb_Vorname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Vorname.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Vorname, "Tragen sie den Vornamen ihres Kunden hier ein.");
            this.lb_Vorname.Location = new System.Drawing.Point(3, 38);
            this.lb_Vorname.Name = "lb_Vorname";
            this.helpProvider.SetShowHelp(this.lb_Vorname, true);
            this.lb_Vorname.Size = new System.Drawing.Size(113, 13);
            this.lb_Vorname.TabIndex = 21;
            this.lb_Vorname.Text = "Vorname:";
            // 
            // lb_Nachname
            // 
            this.lb_Nachname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Nachname.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Nachname, "Tragen sie den Nachnamen ihres Kunden hier ein.");
            this.lb_Nachname.Location = new System.Drawing.Point(3, 68);
            this.lb_Nachname.Name = "lb_Nachname";
            this.helpProvider.SetShowHelp(this.lb_Nachname, true);
            this.lb_Nachname.Size = new System.Drawing.Size(113, 13);
            this.lb_Nachname.TabIndex = 23;
            this.lb_Nachname.Text = "Nachname:";
            // 
            // tb_KundenID
            // 
            this.helpProvider.SetHelpString(this.tb_KundenID, resources.GetString("tb_KundenID.HelpString"));
            this.tb_KundenID.Location = new System.Drawing.Point(123, 5);
            this.tb_KundenID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_KundenID.Name = "tb_KundenID";
            this.helpProvider.SetShowHelp(this.tb_KundenID, true);
            this.tb_KundenID.Size = new System.Drawing.Size(143, 20);
            this.tb_KundenID.TabIndex = 3;
            this.tb_KundenID.TextChanged += new System.EventHandler(this.tb_KundenID_TextChanged);
            // 
            // lb_Strasse
            // 
            this.lb_Strasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Strasse.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Strasse, "Tragen sie die Straße ihres Kunden hier ein.");
            this.lb_Strasse.Location = new System.Drawing.Point(3, 98);
            this.lb_Strasse.Name = "lb_Strasse";
            this.helpProvider.SetShowHelp(this.lb_Strasse, true);
            this.lb_Strasse.Size = new System.Drawing.Size(113, 13);
            this.lb_Strasse.TabIndex = 7;
            this.lb_Strasse.Text = "Strasse:";
            // 
            // lb_Hausnummer
            // 
            this.lb_Hausnummer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Hausnummer.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Hausnummer, "Tragen sie die Hausnummer  ihres Kunden hier ein.");
            this.lb_Hausnummer.Location = new System.Drawing.Point(3, 128);
            this.lb_Hausnummer.Name = "lb_Hausnummer";
            this.helpProvider.SetShowHelp(this.lb_Hausnummer, true);
            this.lb_Hausnummer.Size = new System.Drawing.Size(113, 13);
            this.lb_Hausnummer.TabIndex = 27;
            this.lb_Hausnummer.Text = "Hausnummer:";
            // 
            // lb_Postleitzahl
            // 
            this.lb_Postleitzahl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Postleitzahl.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Postleitzahl, "Tragen sie die Postleitzahl ihres Kunden hier ein.");
            this.lb_Postleitzahl.Location = new System.Drawing.Point(3, 158);
            this.lb_Postleitzahl.Name = "lb_Postleitzahl";
            this.helpProvider.SetShowHelp(this.lb_Postleitzahl, true);
            this.lb_Postleitzahl.Size = new System.Drawing.Size(113, 13);
            this.lb_Postleitzahl.TabIndex = 29;
            this.lb_Postleitzahl.Text = "Postleitzahl:";
            // 
            // tb_Nachname
            // 
            this.tb_Nachname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.tb_Nachname, "Tragen sie den Nachnamen ihres Kunden hier ein.");
            this.tb_Nachname.Location = new System.Drawing.Point(123, 65);
            this.tb_Nachname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Nachname.Name = "tb_Nachname";
            this.helpProvider.SetShowHelp(this.tb_Nachname, true);
            this.tb_Nachname.Size = new System.Drawing.Size(143, 20);
            this.tb_Nachname.TabIndex = 2;
            this.tb_Nachname.TextChanged += new System.EventHandler(this.tb_Nachname_TextChanged);
            // 
            // lb_Ort
            // 
            this.lb_Ort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Ort.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Ort, "Tragen sie den  Wohnort ihres Kunden hier ein.");
            this.lb_Ort.Location = new System.Drawing.Point(3, 188);
            this.lb_Ort.Name = "lb_Ort";
            this.helpProvider.SetShowHelp(this.lb_Ort, true);
            this.lb_Ort.Size = new System.Drawing.Size(113, 13);
            this.lb_Ort.TabIndex = 31;
            this.lb_Ort.Text = "Wohnort:";
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.tb_Vorname, "Tragen sie den Vornamen ihres Kunden hier ein.");
            this.tb_Vorname.Location = new System.Drawing.Point(123, 35);
            this.tb_Vorname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Vorname.Name = "tb_Vorname";
            this.helpProvider.SetShowHelp(this.tb_Vorname, true);
            this.tb_Vorname.Size = new System.Drawing.Size(143, 20);
            this.tb_Vorname.TabIndex = 1;
            this.tb_Vorname.TextChanged += new System.EventHandler(this.tb_Vorname_TextChanged);
            // 
            // lb_Vertrauenswuerdigkeit
            // 
            this.lb_Vertrauenswuerdigkeit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Vertrauenswuerdigkeit.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Vertrauenswuerdigkeit, "Legen sie fest, wie vertrauenswürdig ein Kunde im Bezug auf die Buchrückgabe ist." +
        "");
            this.lb_Vertrauenswuerdigkeit.Location = new System.Drawing.Point(3, 218);
            this.lb_Vertrauenswuerdigkeit.Name = "lb_Vertrauenswuerdigkeit";
            this.helpProvider.SetShowHelp(this.lb_Vertrauenswuerdigkeit, true);
            this.lb_Vertrauenswuerdigkeit.Size = new System.Drawing.Size(113, 13);
            this.lb_Vertrauenswuerdigkeit.TabIndex = 33;
            this.lb_Vertrauenswuerdigkeit.Text = "Vertrauenswürdigkeit:";
            // 
            // tb_Strasse
            // 
            this.tb_Strasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.tb_Strasse, "Tragen sie die Straße ihres Kunden hier ein.");
            this.tb_Strasse.Location = new System.Drawing.Point(123, 95);
            this.tb_Strasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Strasse.Name = "tb_Strasse";
            this.helpProvider.SetShowHelp(this.tb_Strasse, true);
            this.tb_Strasse.Size = new System.Drawing.Size(143, 20);
            this.tb_Strasse.TabIndex = 4;
            this.tb_Strasse.TextChanged += new System.EventHandler(this.tb_Strasse_TextChanged);
            // 
            // lb_Klasse
            // 
            this.lb_Klasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Klasse.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Klasse, "Tragen sie die Klasse ihres Kunden hier ein.");
            this.lb_Klasse.Location = new System.Drawing.Point(3, 248);
            this.lb_Klasse.Name = "lb_Klasse";
            this.helpProvider.SetShowHelp(this.lb_Klasse, true);
            this.lb_Klasse.Size = new System.Drawing.Size(113, 13);
            this.lb_Klasse.TabIndex = 34;
            this.lb_Klasse.Text = "Klasse:";
            // 
            // tb_Mail
            // 
            this.tb_Mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.tb_Mail, "Tragen sie die E-Mail Adresse ihres Kunden hier ein.");
            this.tb_Mail.Location = new System.Drawing.Point(123, 275);
            this.tb_Mail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Mail.Name = "tb_Mail";
            this.helpProvider.SetShowHelp(this.tb_Mail, true);
            this.tb_Mail.Size = new System.Drawing.Size(143, 20);
            this.tb_Mail.TabIndex = 10;
            this.tb_Mail.TextChanged += new System.EventHandler(this.tb_Mail_TextChanged);
            // 
            // lb_Mail
            // 
            this.lb_Mail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Mail.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Mail, "Tragen sie die E-Mail Adresse ihres Kunden hier ein.");
            this.lb_Mail.Location = new System.Drawing.Point(3, 278);
            this.lb_Mail.Name = "lb_Mail";
            this.helpProvider.SetShowHelp(this.lb_Mail, true);
            this.lb_Mail.Size = new System.Drawing.Size(113, 13);
            this.lb_Mail.TabIndex = 37;
            this.lb_Mail.Text = "Mail:";
            // 
            // tb_Hausnummer
            // 
            this.tb_Hausnummer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.helpProvider.SetHelpString(this.tb_Hausnummer, "Tragen sie die Hausnummer  ihres Kunden hier ein.");
            this.tb_Hausnummer.Location = new System.Drawing.Point(123, 125);
            this.tb_Hausnummer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Hausnummer.Name = "tb_Hausnummer";
            this.helpProvider.SetShowHelp(this.tb_Hausnummer, true);
            this.tb_Hausnummer.Size = new System.Drawing.Size(79, 20);
            this.tb_Hausnummer.TabIndex = 5;
            this.tb_Hausnummer.TextChanged += new System.EventHandler(this.tb_Hausnummer_TextChanged);
            // 
            // tb_Klasse
            // 
            this.tb_Klasse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.helpProvider.SetHelpString(this.tb_Klasse, "Tragen sie die Klasse ihres Kunden hier ein.");
            this.tb_Klasse.Location = new System.Drawing.Point(123, 245);
            this.tb_Klasse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Klasse.Name = "tb_Klasse";
            this.helpProvider.SetShowHelp(this.tb_Klasse, true);
            this.tb_Klasse.Size = new System.Drawing.Size(79, 20);
            this.tb_Klasse.TabIndex = 9;
            this.tb_Klasse.TextChanged += new System.EventHandler(this.tb_Klasse_TextChanged);
            // 
            // tb_Postleitzahl
            // 
            this.tb_Postleitzahl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.helpProvider.SetHelpString(this.tb_Postleitzahl, "Tragen sie die Postleitzahl ihres Kunden hier ein.");
            this.tb_Postleitzahl.Location = new System.Drawing.Point(123, 155);
            this.tb_Postleitzahl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Postleitzahl.Name = "tb_Postleitzahl";
            this.helpProvider.SetShowHelp(this.tb_Postleitzahl, true);
            this.tb_Postleitzahl.Size = new System.Drawing.Size(79, 20);
            this.tb_Postleitzahl.TabIndex = 6;
            this.tb_Postleitzahl.TextChanged += new System.EventHandler(this.tb_Postleitzahl_TextChanged);
            // 
            // tb_Ort
            // 
            this.tb_Ort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.tb_Ort, "Tragen sie den  Wohnort ihres Kunden hier ein.");
            this.tb_Ort.Location = new System.Drawing.Point(123, 185);
            this.tb_Ort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Ort.Name = "tb_Ort";
            this.helpProvider.SetShowHelp(this.tb_Ort, true);
            this.tb_Ort.Size = new System.Drawing.Size(143, 20);
            this.tb_Ort.TabIndex = 7;
            this.tb_Ort.TextChanged += new System.EventHandler(this.tb_Ort_TextChanged);
            // 
            // cb_Vertrauenswuerdigkeit
            // 
            this.cb_Vertrauenswuerdigkeit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Vertrauenswuerdigkeit.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Vertrauenswuerdigkeit, "Legen sie fest, wie vertrauenswürdig ein Kunde im Bezug auf die Buchrückgabe ist." +
        "");
            this.cb_Vertrauenswuerdigkeit.Items.AddRange(new object[] {
            "vertrauenswürdig",
            "nicht vertrauenswürdig",
            "noch nicht bestimmt"});
            this.cb_Vertrauenswuerdigkeit.Location = new System.Drawing.Point(123, 215);
            this.cb_Vertrauenswuerdigkeit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb_Vertrauenswuerdigkeit.Name = "cb_Vertrauenswuerdigkeit";
            this.helpProvider.SetShowHelp(this.cb_Vertrauenswuerdigkeit, true);
            this.cb_Vertrauenswuerdigkeit.Size = new System.Drawing.Size(143, 21);
            this.cb_Vertrauenswuerdigkeit.TabIndex = 8;
            this.cb_Vertrauenswuerdigkeit.TextChanged += new System.EventHandler(this.cb_Vertrauenswuerdigkeit_TextChanged_1);
            // 
            // lb_KundenID
            // 
            this.lb_KundenID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_KundenID.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_KundenID, resources.GetString("lb_KundenID.HelpString"));
            this.lb_KundenID.Location = new System.Drawing.Point(3, 8);
            this.lb_KundenID.Name = "lb_KundenID";
            this.helpProvider.SetShowHelp(this.lb_KundenID, true);
            this.lb_KundenID.Size = new System.Drawing.Size(113, 13);
            this.lb_KundenID.TabIndex = 0;
            this.lb_KundenID.Text = "Kunden-ID:";
            // 
            // lb_kunde_add
            // 
            this.lb_kunde_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_kunde_add.Location = new System.Drawing.Point(7, 409);
            this.lb_kunde_add.Name = "lb_kunde_add";
            this.lb_kunde_add.Size = new System.Drawing.Size(270, 13);
            this.lb_kunde_add.TabIndex = 40;
            this.lb_kunde_add.Text = "Der Kunde wurde erfolgreich hinzugefügt!";
            this.lb_kunde_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_kunde_add.Visible = false;
            // 
            // bt_clear
            // 
            this.helpProvider.SetHelpString(this.bt_clear, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_clear.Location = new System.Drawing.Point(39, 380);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_clear.Name = "bt_clear";
            this.helpProvider.SetShowHelp(this.bt_clear, true);
            this.bt_clear.Size = new System.Drawing.Size(90, 24);
            this.bt_clear.TabIndex = 14;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // rb_KundeLoeschen
            // 
            this.rb_KundeLoeschen.AutoSize = true;
            this.helpProvider.SetHelpString(this.rb_KundeLoeschen, "Klicken sie hier, um einen vorhandenen Kunden zu löschen.");
            this.rb_KundeLoeschen.Location = new System.Drawing.Point(211, 19);
            this.rb_KundeLoeschen.Name = "rb_KundeLoeschen";
            this.helpProvider.SetShowHelp(this.rb_KundeLoeschen, true);
            this.rb_KundeLoeschen.Size = new System.Drawing.Size(71, 17);
            this.rb_KundeLoeschen.TabIndex = 0;
            this.rb_KundeLoeschen.Text = "Entfernen";
            this.rb_KundeLoeschen.UseVisualStyleBackColor = true;
            this.rb_KundeLoeschen.CheckedChanged += new System.EventHandler(this.rb_KundeLoeschen_CheckedChanged);
            // 
            // rb_KundeBearbeiten
            // 
            this.rb_KundeBearbeiten.AutoSize = true;
            this.helpProvider.SetHelpString(this.rb_KundeBearbeiten, "Klicken sie hier, um einen vorhandenen Kunden zu bearbeiten.");
            this.rb_KundeBearbeiten.Location = new System.Drawing.Point(114, 19);
            this.rb_KundeBearbeiten.Name = "rb_KundeBearbeiten";
            this.helpProvider.SetShowHelp(this.rb_KundeBearbeiten, true);
            this.rb_KundeBearbeiten.Size = new System.Drawing.Size(76, 17);
            this.rb_KundeBearbeiten.TabIndex = 0;
            this.rb_KundeBearbeiten.Text = "Bearbeiten";
            this.rb_KundeBearbeiten.UseVisualStyleBackColor = true;
            this.rb_KundeBearbeiten.CheckedChanged += new System.EventHandler(this.rb_KundeBearbeiten_CheckedChanged);
            // 
            // rb_Neukunde
            // 
            this.rb_Neukunde.AutoSize = true;
            this.rb_Neukunde.Checked = true;
            this.helpProvider.SetHelpString(this.rb_Neukunde, "Klicken sie hier, um einen neuen Kunden hinzuzufügen.");
            this.rb_Neukunde.Location = new System.Drawing.Point(13, 19);
            this.rb_Neukunde.Name = "rb_Neukunde";
            this.helpProvider.SetShowHelp(this.rb_Neukunde, true);
            this.rb_Neukunde.Size = new System.Drawing.Size(79, 17);
            this.rb_Neukunde.TabIndex = 0;
            this.rb_Neukunde.TabStop = true;
            this.rb_Neukunde.Text = "Hinzufügen";
            this.rb_Neukunde.UseVisualStyleBackColor = true;
            this.rb_Neukunde.CheckedChanged += new System.EventHandler(this.rb_Neukunde_CheckedChanged);
            // 
            // bt_confirm
            // 
            this.helpProvider.SetHelpString(this.bt_confirm, "Speichern sie alle oben eingetragenen Daten.");
            this.bt_confirm.Location = new System.Drawing.Point(137, 380);
            this.bt_confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_confirm.Name = "bt_confirm";
            this.helpProvider.SetShowHelp(this.bt_confirm, true);
            this.bt_confirm.Size = new System.Drawing.Size(140, 24);
            this.bt_confirm.TabIndex = 13;
            this.bt_confirm.Text = "Speichern";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_click);
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.helpProvider.SetHelpString(this.bt_OK, "Schließen sie das akuelle Fenster.");
            this.bt_OK.Location = new System.Drawing.Point(758, 415);
            this.bt_OK.Name = "bt_OK";
            this.helpProvider.SetShowHelp(this.bt_OK, true);
            this.bt_OK.Size = new System.Drawing.Size(120, 23);
            this.bt_OK.TabIndex = 15;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // gv_Kunde
            // 
            this.gv_Kunde.AllowUserToAddRows = false;
            this.gv_Kunde.AllowUserToDeleteRows = false;
            this.gv_Kunde.AllowUserToResizeColumns = false;
            this.gv_Kunde.AllowUserToResizeRows = false;
            this.gv_Kunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_Kunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.helpProvider.SetHelpString(this.gv_Kunde, "Hier werden all ihre Kunden angezeigt.");
            this.gv_Kunde.Location = new System.Drawing.Point(300, 12);
            this.gv_Kunde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gv_Kunde.MultiSelect = false;
            this.gv_Kunde.Name = "gv_Kunde";
            this.gv_Kunde.ReadOnly = true;
            this.gv_Kunde.RowHeadersVisible = false;
            this.gv_Kunde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Kunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.gv_Kunde, true);
            this.gv_Kunde.Size = new System.Drawing.Size(578, 397);
            this.gv_Kunde.TabIndex = 0;
            this.gv_Kunde.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Kunde_CellDoubleClick);
            // 
            // bt_ImEx
            // 
            this.bt_ImEx.Location = new System.Drawing.Point(300, 415);
            this.bt_ImEx.Name = "bt_ImEx";
            this.bt_ImEx.Size = new System.Drawing.Size(180, 23);
            this.bt_ImEx.TabIndex = 42;
            this.bt_ImEx.Text = "Importieren/Exportieren";
            this.bt_ImEx.UseVisualStyleBackColor = true;
            this.bt_ImEx.Click += new System.EventHandler(this.bt_ImEx_Click);
            // 
            // cb_showAll
            // 
            this.cb_showAll.AutoSize = true;
            this.cb_showAll.Location = new System.Drawing.Point(640, 419);
            this.cb_showAll.Name = "cb_showAll";
            this.cb_showAll.Size = new System.Drawing.Size(112, 17);
            this.cb_showAll.TabIndex = 43;
            this.cb_showAll.Text = "Zeige alle Kunden";
            this.cb_showAll.UseVisualStyleBackColor = true;
            this.cb_showAll.CheckedChanged += new System.EventHandler(this.cb_showAll_CheckedChanged);
            // 
            // w_s_Kunden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 449);
            this.Controls.Add(this.cb_showAll);
            this.Controls.Add(this.bt_ImEx);
            this.Controls.Add(this.gb_kunde);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.gv_Kunde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_Kunden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kunden";
            this.Activated += new System.EventHandler(this.w_s_kunden_Activated);
            this.gb_kunde.ResumeLayout(false);
            this.gb_kunde.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_Telefonnummer;
        private System.Windows.Forms.TextBox tb_Telefonnummer;
        private System.Windows.Forms.GroupBox gb_kunde;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.RadioButton rb_KundeLoeschen;
        private System.Windows.Forms.RadioButton rb_KundeBearbeiten;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Label lb_kunde_add;
        private System.Windows.Forms.DataGridView gv_Kunde;
        private System.Windows.Forms.RadioButton rb_Neukunde;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_Vorname;
        private System.Windows.Forms.Label lb_Nachname;
        private System.Windows.Forms.TextBox tb_KundenID;
        private System.Windows.Forms.Label lb_Strasse;
        private System.Windows.Forms.Label lb_Hausnummer;
        private System.Windows.Forms.Label lb_Postleitzahl;
        private System.Windows.Forms.TextBox tb_Nachname;
        private System.Windows.Forms.Label lb_Ort;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.Label lb_Vertrauenswuerdigkeit;
        private System.Windows.Forms.TextBox tb_Strasse;
        private System.Windows.Forms.Label lb_Klasse;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.Label lb_Mail;
        private System.Windows.Forms.TextBox tb_Hausnummer;
        private System.Windows.Forms.TextBox tb_Klasse;
        private System.Windows.Forms.TextBox tb_Postleitzahl;
        private System.Windows.Forms.TextBox tb_Ort;
        private System.Windows.Forms.ComboBox cb_Vertrauenswuerdigkeit;
        private System.Windows.Forms.Label lb_KundenID;
        private System.Windows.Forms.Button bt_ImEx;
        private System.Windows.Forms.CheckBox cb_showAll;
    }
}