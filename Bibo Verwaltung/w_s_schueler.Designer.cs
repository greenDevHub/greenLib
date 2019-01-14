namespace Bibo_Verwaltung
{
    partial class w_s_schueler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_schueler));
            this.lb_kunde_add = new System.Windows.Forms.Label();
            this.rb_KundeLoeschen = new System.Windows.Forms.RadioButton();
            this.rb_KundeBearbeiten = new System.Windows.Forms.RadioButton();
            this.rb_Neukunde = new System.Windows.Forms.RadioButton();
            this.lb_Vorname = new System.Windows.Forms.Label();
            this.lb_Nachname = new System.Windows.Forms.Label();
            this.tb_KundenID = new System.Windows.Forms.TextBox();
            this.lb_Gd = new System.Windows.Forms.Label();
            this.lb_Klasse = new System.Windows.Forms.Label();
            this.lb_Klassenstufe = new System.Windows.Forms.Label();
            this.tb_Nachname = new System.Windows.Forms.TextBox();
            this.lb_1 = new System.Windows.Forms.Label();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.tb_Gd = new System.Windows.Forms.TextBox();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.bt_clear = new System.Windows.Forms.Button();
            this.tb_klasse = new System.Windows.Forms.TextBox();
            this.tb_klassenstufe = new System.Windows.Forms.TextBox();
            this.lb_KundenID = new System.Windows.Forms.Label();
            this.gv_Kunde = new System.Windows.Forms.DataGridView();
            this.bt_ImEx = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cLB_faecher = new System.Windows.Forms.CheckedListBox();
            this.gb_kunde = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_kunde.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_kunde_add
            // 
            this.lb_kunde_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_kunde_add.Location = new System.Drawing.Point(19, 975);
            this.lb_kunde_add.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_kunde_add.Name = "lb_kunde_add";
            this.lb_kunde_add.Size = new System.Drawing.Size(720, 31);
            this.lb_kunde_add.TabIndex = 40;
            this.lb_kunde_add.Text = "Der Kunde wurde erfolgreich hinzugefügt!";
            this.lb_kunde_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_kunde_add.Visible = false;
            // 
            // rb_KundeLoeschen
            // 
            this.rb_KundeLoeschen.AutoSize = true;
            this.helpProvider.SetHelpString(this.rb_KundeLoeschen, "Klicken sie hier, um einen vorhandenen Kunden zu löschen.");
            this.rb_KundeLoeschen.Location = new System.Drawing.Point(563, 45);
            this.rb_KundeLoeschen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rb_KundeLoeschen.Name = "rb_KundeLoeschen";
            this.helpProvider.SetShowHelp(this.rb_KundeLoeschen, true);
            this.rb_KundeLoeschen.Size = new System.Drawing.Size(176, 36);
            this.rb_KundeLoeschen.TabIndex = 0;
            this.rb_KundeLoeschen.Text = "Entfernen";
            this.rb_KundeLoeschen.UseVisualStyleBackColor = true;
            this.rb_KundeLoeschen.CheckedChanged += new System.EventHandler(this.rb_KundeLoeschen_CheckedChanged);
            // 
            // rb_KundeBearbeiten
            // 
            this.rb_KundeBearbeiten.AutoSize = true;
            this.helpProvider.SetHelpString(this.rb_KundeBearbeiten, "Klicken sie hier, um einen vorhandenen Kunden zu bearbeiten.");
            this.rb_KundeBearbeiten.Location = new System.Drawing.Point(304, 45);
            this.rb_KundeBearbeiten.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rb_KundeBearbeiten.Name = "rb_KundeBearbeiten";
            this.helpProvider.SetShowHelp(this.rb_KundeBearbeiten, true);
            this.rb_KundeBearbeiten.Size = new System.Drawing.Size(191, 36);
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
            this.rb_Neukunde.Location = new System.Drawing.Point(35, 45);
            this.rb_Neukunde.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rb_Neukunde.Name = "rb_Neukunde";
            this.helpProvider.SetShowHelp(this.rb_Neukunde, true);
            this.rb_Neukunde.Size = new System.Drawing.Size(197, 36);
            this.rb_Neukunde.TabIndex = 0;
            this.rb_Neukunde.TabStop = true;
            this.rb_Neukunde.Text = "Hinzufügen";
            this.rb_Neukunde.UseVisualStyleBackColor = true;
            this.rb_Neukunde.CheckedChanged += new System.EventHandler(this.rb_Neukunde_CheckedChanged);
            // 
            // lb_Vorname
            // 
            this.lb_Vorname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Vorname.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Vorname, "Tragen sie den Vornamen ihres Kunden hier ein.");
            this.lb_Vorname.Location = new System.Drawing.Point(8, 92);
            this.lb_Vorname.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Vorname.Name = "lb_Vorname";
            this.helpProvider.SetShowHelp(this.lb_Vorname, true);
            this.lb_Vorname.Size = new System.Drawing.Size(303, 32);
            this.lb_Vorname.TabIndex = 21;
            this.lb_Vorname.Text = "Vorname:";
            // 
            // lb_Nachname
            // 
            this.lb_Nachname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Nachname.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Nachname, "Tragen sie den Nachnamen ihres Kunden hier ein.");
            this.lb_Nachname.Location = new System.Drawing.Point(8, 164);
            this.lb_Nachname.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Nachname.Name = "lb_Nachname";
            this.helpProvider.SetShowHelp(this.lb_Nachname, true);
            this.lb_Nachname.Size = new System.Drawing.Size(303, 32);
            this.lb_Nachname.TabIndex = 23;
            this.lb_Nachname.Text = "Nachname:";
            // 
            // tb_KundenID
            // 
            this.helpProvider.SetHelpString(this.tb_KundenID, resources.GetString("tb_KundenID.HelpString"));
            this.tb_KundenID.Location = new System.Drawing.Point(330, 12);
            this.tb_KundenID.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tb_KundenID.Name = "tb_KundenID";
            this.helpProvider.SetShowHelp(this.tb_KundenID, true);
            this.tb_KundenID.Size = new System.Drawing.Size(375, 38);
            this.tb_KundenID.TabIndex = 3;
            // 
            // lb_Gd
            // 
            this.lb_Gd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Gd.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Gd, "Tragen sie die Straße ihres Kunden hier ein.");
            this.lb_Gd.Location = new System.Drawing.Point(8, 236);
            this.lb_Gd.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Gd.Name = "lb_Gd";
            this.helpProvider.SetShowHelp(this.lb_Gd, true);
            this.lb_Gd.Size = new System.Drawing.Size(303, 32);
            this.lb_Gd.TabIndex = 7;
            this.lb_Gd.Text = "Geburtsdatum:";
            // 
            // lb_Klasse
            // 
            this.lb_Klasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Klasse.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Klasse, "Tragen sie die Hausnummer  ihres Kunden hier ein.");
            this.lb_Klasse.Location = new System.Drawing.Point(8, 308);
            this.lb_Klasse.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Klasse.Name = "lb_Klasse";
            this.helpProvider.SetShowHelp(this.lb_Klasse, true);
            this.lb_Klasse.Size = new System.Drawing.Size(303, 32);
            this.lb_Klasse.TabIndex = 27;
            this.lb_Klasse.Text = "Klasse:";
            // 
            // lb_Klassenstufe
            // 
            this.lb_Klassenstufe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Klassenstufe.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Klassenstufe, "Tragen sie die Postleitzahl ihres Kunden hier ein.");
            this.lb_Klassenstufe.Location = new System.Drawing.Point(8, 380);
            this.lb_Klassenstufe.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Klassenstufe.Name = "lb_Klassenstufe";
            this.helpProvider.SetShowHelp(this.lb_Klassenstufe, true);
            this.lb_Klassenstufe.Size = new System.Drawing.Size(303, 32);
            this.lb_Klassenstufe.TabIndex = 29;
            this.lb_Klassenstufe.Text = "Klassenstufe:";
            // 
            // tb_Nachname
            // 
            this.tb_Nachname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.tb_Nachname, "Tragen sie den Nachnamen ihres Kunden hier ein.");
            this.tb_Nachname.Location = new System.Drawing.Point(330, 161);
            this.tb_Nachname.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tb_Nachname.Name = "tb_Nachname";
            this.helpProvider.SetShowHelp(this.tb_Nachname, true);
            this.tb_Nachname.Size = new System.Drawing.Size(379, 38);
            this.tb_Nachname.TabIndex = 2;
            // 
            // lb_1
            // 
            this.lb_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_1.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_1, "Tragen sie den  Wohnort ihres Kunden hier ein.");
            this.lb_1.Location = new System.Drawing.Point(8, 594);
            this.lb_1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_1.Name = "lb_1";
            this.helpProvider.SetShowHelp(this.lb_1, true);
            this.lb_1.Size = new System.Drawing.Size(303, 32);
            this.lb_1.TabIndex = 31;
            this.lb_1.Text = "Fächer:";
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.tb_Vorname, "Tragen sie den Vornamen ihres Kunden hier ein.");
            this.tb_Vorname.Location = new System.Drawing.Point(330, 89);
            this.tb_Vorname.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tb_Vorname.Name = "tb_Vorname";
            this.helpProvider.SetShowHelp(this.tb_Vorname, true);
            this.tb_Vorname.Size = new System.Drawing.Size(379, 38);
            this.tb_Vorname.TabIndex = 1;
            // 
            // tb_Gd
            // 
            this.tb_Gd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.tb_Gd, "Tragen sie die Straße ihres Kunden hier ein.");
            this.tb_Gd.Location = new System.Drawing.Point(330, 233);
            this.tb_Gd.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tb_Gd.Name = "tb_Gd";
            this.helpProvider.SetShowHelp(this.tb_Gd, true);
            this.tb_Gd.Size = new System.Drawing.Size(379, 38);
            this.tb_Gd.TabIndex = 4;
            // 
            // bt_confirm
            // 
            this.helpProvider.SetHelpString(this.bt_confirm, "Speichern sie alle oben eingetragenen Daten.");
            this.bt_confirm.Location = new System.Drawing.Point(365, 906);
            this.bt_confirm.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.bt_confirm.Name = "bt_confirm";
            this.helpProvider.SetShowHelp(this.bt_confirm, true);
            this.bt_confirm.Size = new System.Drawing.Size(373, 57);
            this.bt_confirm.TabIndex = 13;
            this.bt_confirm.Text = "Speichern";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.helpProvider.SetHelpString(this.bt_OK, "Schließen sie das akuelle Fenster.");
            this.bt_OK.Location = new System.Drawing.Point(2024, 994);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_OK.Name = "bt_OK";
            this.helpProvider.SetShowHelp(this.bt_OK, true);
            this.bt_OK.Size = new System.Drawing.Size(320, 55);
            this.bt_OK.TabIndex = 46;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // bt_clear
            // 
            this.helpProvider.SetHelpString(this.bt_clear, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_clear.Location = new System.Drawing.Point(104, 906);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.bt_clear.Name = "bt_clear";
            this.helpProvider.SetShowHelp(this.bt_clear, true);
            this.bt_clear.Size = new System.Drawing.Size(240, 57);
            this.bt_clear.TabIndex = 14;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // tb_klasse
            // 
            this.tb_klasse.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.helpProvider.SetHelpString(this.tb_klasse, "Tragen sie die Hausnummer  ihres Kunden hier ein.");
            this.tb_klasse.Location = new System.Drawing.Point(330, 305);
            this.tb_klasse.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tb_klasse.Name = "tb_klasse";
            this.helpProvider.SetShowHelp(this.tb_klasse, true);
            this.tb_klasse.Size = new System.Drawing.Size(379, 38);
            this.tb_klasse.TabIndex = 5;
            // 
            // tb_klassenstufe
            // 
            this.tb_klassenstufe.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.helpProvider.SetHelpString(this.tb_klassenstufe, "Tragen sie die Postleitzahl ihres Kunden hier ein.");
            this.tb_klassenstufe.Location = new System.Drawing.Point(330, 377);
            this.tb_klassenstufe.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tb_klassenstufe.Name = "tb_klassenstufe";
            this.helpProvider.SetShowHelp(this.tb_klassenstufe, true);
            this.tb_klassenstufe.Size = new System.Drawing.Size(379, 38);
            this.tb_klassenstufe.TabIndex = 6;
            // 
            // lb_KundenID
            // 
            this.lb_KundenID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_KundenID.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_KundenID, resources.GetString("lb_KundenID.HelpString"));
            this.lb_KundenID.Location = new System.Drawing.Point(8, 20);
            this.lb_KundenID.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_KundenID.Name = "lb_KundenID";
            this.helpProvider.SetShowHelp(this.lb_KundenID, true);
            this.lb_KundenID.Size = new System.Drawing.Size(303, 32);
            this.lb_KundenID.TabIndex = 0;
            this.lb_KundenID.Text = "Kunden-ID:";
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
            this.gv_Kunde.Location = new System.Drawing.Point(803, 33);
            this.gv_Kunde.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.gv_Kunde.MultiSelect = false;
            this.gv_Kunde.Name = "gv_Kunde";
            this.gv_Kunde.ReadOnly = true;
            this.gv_Kunde.RowHeadersVisible = false;
            this.gv_Kunde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Kunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.gv_Kunde, true);
            this.gv_Kunde.Size = new System.Drawing.Size(1541, 947);
            this.gv_Kunde.TabIndex = 45;
            this.gv_Kunde.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Kunde_CellDoubleClick);
            // 
            // bt_ImEx
            // 
            this.bt_ImEx.Location = new System.Drawing.Point(803, 994);
            this.bt_ImEx.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_ImEx.Name = "bt_ImEx";
            this.bt_ImEx.Size = new System.Drawing.Size(480, 55);
            this.bt_ImEx.TabIndex = 47;
            this.bt_ImEx.Text = "Importieren/Exportieren";
            this.bt_ImEx.UseVisualStyleBackColor = true;
            this.bt_ImEx.Click += new System.EventHandler(this.bt_ImEx_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanel1.Controls.Add(this.lb_Vorname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_Nachname, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_KundenID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Gd, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lb_Klassenstufe, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_Nachname, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.tb_Vorname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_Gd, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_klasse, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_klassenstufe, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lb_KundenID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lb_Klasse, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.cLB_faecher, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 100);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 789);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // cLB_faecher
            // 
            this.cLB_faecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLB_faecher.FormattingEnabled = true;
            this.cLB_faecher.Location = new System.Drawing.Point(322, 435);
            this.cLB_faecher.Name = "cLB_faecher";
            this.cLB_faecher.Size = new System.Drawing.Size(395, 351);
            this.cLB_faecher.TabIndex = 32;
            this.cLB_faecher.SelectedIndexChanged += new System.EventHandler(this.cLB_faecher_SelectedIndexChanged);
            this.cLB_faecher.MouseHover += new System.EventHandler(this.cLB_faecher_MouseHover);
            this.cLB_faecher.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cLB_faecher_MouseMove);
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
            this.gb_kunde.Location = new System.Drawing.Point(19, 18);
            this.gb_kunde.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_kunde.Name = "gb_kunde";
            this.gb_kunde.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_kunde.Size = new System.Drawing.Size(768, 1035);
            this.gb_kunde.TabIndex = 44;
            this.gb_kunde.TabStop = false;
            this.gb_kunde.Text = "Kunden";
            // 
            // w_s_schueler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2363, 1071);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.bt_ImEx);
            this.Controls.Add(this.gb_kunde);
            this.Controls.Add(this.gv_Kunde);
            this.Name = "w_s_schueler";
            this.Text = "Schüler";
            this.Activated += new System.EventHandler(this.w_s_schueler_Activated);
            this.Load += new System.EventHandler(this.w_s_schueler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.gb_kunde.ResumeLayout(false);
            this.gb_kunde.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_kunde_add;
        private System.Windows.Forms.RadioButton rb_KundeLoeschen;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.RadioButton rb_KundeBearbeiten;
        private System.Windows.Forms.RadioButton rb_Neukunde;
        private System.Windows.Forms.Label lb_Vorname;
        private System.Windows.Forms.Label lb_Nachname;
        private System.Windows.Forms.TextBox tb_KundenID;
        private System.Windows.Forms.Label lb_Gd;
        private System.Windows.Forms.Label lb_Klasse;
        private System.Windows.Forms.Label lb_Klassenstufe;
        private System.Windows.Forms.TextBox tb_Nachname;
        private System.Windows.Forms.Label lb_1;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.TextBox tb_Gd;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.TextBox tb_klasse;
        private System.Windows.Forms.TextBox tb_klassenstufe;
        private System.Windows.Forms.Label lb_KundenID;
        private System.Windows.Forms.DataGridView gv_Kunde;
        private System.Windows.Forms.Button bt_ImEx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gb_kunde;
        private System.Windows.Forms.CheckedListBox cLB_faecher;
    }
}