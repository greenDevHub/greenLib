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
            this.bt_confirm = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.bt_clear = new System.Windows.Forms.Button();
            this.tb_klasse = new System.Windows.Forms.TextBox();
            this.tb_klassenstufe = new System.Windows.Forms.TextBox();
            this.lb_KundenID = new System.Windows.Forms.Label();
            this.gv_Kunde = new System.Windows.Forms.DataGridView();
            this.bt_ImEx = new System.Windows.Forms.Button();
            this.dtp_gd = new System.Windows.Forms.DateTimePicker();
            this.cLB_faecher = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_kunde_add
            // 
            this.lb_kunde_add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_kunde_add.Location = new System.Drawing.Point(3, 410);
            this.lb_kunde_add.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_kunde_add.Name = "lb_kunde_add";
            this.lb_kunde_add.Size = new System.Drawing.Size(81, 32);
            this.lb_kunde_add.TabIndex = 40;
            this.lb_kunde_add.Text = "Der Kunde wurde erfolgreich hinzugefügt!";
            this.lb_kunde_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_kunde_add.Visible = false;
            // 
            // rb_KundeLoeschen
            // 
            this.rb_KundeLoeschen.AutoSize = true;
            this.rb_KundeLoeschen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.rb_KundeLoeschen, "Klicken sie hier, um einen vorhandenen Kunden zu löschen.");
            this.rb_KundeLoeschen.Location = new System.Drawing.Point(177, 3);
            this.rb_KundeLoeschen.Name = "rb_KundeLoeschen";
            this.helpProvider.SetShowHelp(this.rb_KundeLoeschen, true);
            this.rb_KundeLoeschen.Size = new System.Drawing.Size(81, 31);
            this.rb_KundeLoeschen.TabIndex = 0;
            this.rb_KundeLoeschen.Text = "Entfernen";
            this.rb_KundeLoeschen.UseVisualStyleBackColor = true;
            this.rb_KundeLoeschen.CheckedChanged += new System.EventHandler(this.rb_KundeLoeschen_CheckedChanged);
            // 
            // rb_KundeBearbeiten
            // 
            this.rb_KundeBearbeiten.AutoSize = true;
            this.rb_KundeBearbeiten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.rb_KundeBearbeiten, "Klicken sie hier, um einen vorhandenen Kunden zu bearbeiten.");
            this.rb_KundeBearbeiten.Location = new System.Drawing.Point(90, 3);
            this.rb_KundeBearbeiten.Name = "rb_KundeBearbeiten";
            this.helpProvider.SetShowHelp(this.rb_KundeBearbeiten, true);
            this.rb_KundeBearbeiten.Size = new System.Drawing.Size(81, 31);
            this.rb_KundeBearbeiten.TabIndex = 0;
            this.rb_KundeBearbeiten.Text = "Bearbeiten";
            this.rb_KundeBearbeiten.UseVisualStyleBackColor = true;
            this.rb_KundeBearbeiten.CheckedChanged += new System.EventHandler(this.rb_KundeBearbeiten_CheckedChanged);
            // 
            // rb_Neukunde
            // 
            this.rb_Neukunde.AutoSize = true;
            this.rb_Neukunde.Checked = true;
            this.rb_Neukunde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.rb_Neukunde, "Klicken sie hier, um einen neuen Kunden hinzuzufügen.");
            this.rb_Neukunde.Location = new System.Drawing.Point(3, 3);
            this.rb_Neukunde.Name = "rb_Neukunde";
            this.helpProvider.SetShowHelp(this.rb_Neukunde, true);
            this.rb_Neukunde.Size = new System.Drawing.Size(81, 31);
            this.rb_Neukunde.TabIndex = 0;
            this.rb_Neukunde.TabStop = true;
            this.rb_Neukunde.Text = "Hinzufügen";
            this.rb_Neukunde.UseVisualStyleBackColor = true;
            this.rb_Neukunde.CheckedChanged += new System.EventHandler(this.rb_Neukunde_CheckedChanged);
            // 
            // lb_Vorname
            // 
            this.lb_Vorname.AutoSize = true;
            this.lb_Vorname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.lb_Vorname, "Tragen sie den Vornamen ihres Kunden hier ein.");
            this.lb_Vorname.Location = new System.Drawing.Point(3, 77);
            this.lb_Vorname.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_Vorname.Name = "lb_Vorname";
            this.helpProvider.SetShowHelp(this.lb_Vorname, true);
            this.lb_Vorname.Size = new System.Drawing.Size(81, 31);
            this.lb_Vorname.TabIndex = 21;
            this.lb_Vorname.Text = "Vorname:";
            // 
            // lb_Nachname
            // 
            this.lb_Nachname.AutoSize = true;
            this.lb_Nachname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.lb_Nachname, "Tragen sie den Nachnamen ihres Kunden hier ein.");
            this.lb_Nachname.Location = new System.Drawing.Point(3, 114);
            this.lb_Nachname.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_Nachname.Name = "lb_Nachname";
            this.helpProvider.SetShowHelp(this.lb_Nachname, true);
            this.lb_Nachname.Size = new System.Drawing.Size(81, 31);
            this.lb_Nachname.TabIndex = 23;
            this.lb_Nachname.Text = "Nachname:";
            // 
            // tb_KundenID
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tb_KundenID, 2);
            this.tb_KundenID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.tb_KundenID, resources.GetString("tb_KundenID.HelpString"));
            this.tb_KundenID.Location = new System.Drawing.Point(90, 40);
            this.tb_KundenID.Name = "tb_KundenID";
            this.helpProvider.SetShowHelp(this.tb_KundenID, true);
            this.tb_KundenID.Size = new System.Drawing.Size(168, 20);
            this.tb_KundenID.TabIndex = 3;
            this.tb_KundenID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_KundenID_KeyPress);
            // 
            // lb_Gd
            // 
            this.lb_Gd.AutoSize = true;
            this.lb_Gd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.lb_Gd, "Tragen sie die Straße ihres Kunden hier ein.");
            this.lb_Gd.Location = new System.Drawing.Point(3, 151);
            this.lb_Gd.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_Gd.Name = "lb_Gd";
            this.helpProvider.SetShowHelp(this.lb_Gd, true);
            this.lb_Gd.Size = new System.Drawing.Size(81, 31);
            this.lb_Gd.TabIndex = 7;
            this.lb_Gd.Text = "Geburtsdatum:";
            // 
            // lb_Klasse
            // 
            this.lb_Klasse.AutoSize = true;
            this.lb_Klasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.lb_Klasse, "Tragen sie die Hausnummer  ihres Kunden hier ein.");
            this.lb_Klasse.Location = new System.Drawing.Point(3, 188);
            this.lb_Klasse.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_Klasse.Name = "lb_Klasse";
            this.helpProvider.SetShowHelp(this.lb_Klasse, true);
            this.lb_Klasse.Size = new System.Drawing.Size(81, 31);
            this.lb_Klasse.TabIndex = 27;
            this.lb_Klasse.Text = "Klasse:";
            // 
            // lb_Klassenstufe
            // 
            this.lb_Klassenstufe.AutoSize = true;
            this.lb_Klassenstufe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.lb_Klassenstufe, "Tragen sie die Postleitzahl ihres Kunden hier ein.");
            this.lb_Klassenstufe.Location = new System.Drawing.Point(3, 225);
            this.lb_Klassenstufe.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_Klassenstufe.Name = "lb_Klassenstufe";
            this.helpProvider.SetShowHelp(this.lb_Klassenstufe, true);
            this.lb_Klassenstufe.Size = new System.Drawing.Size(81, 31);
            this.lb_Klassenstufe.TabIndex = 29;
            this.lb_Klassenstufe.Text = "Klassenstufe:";
            // 
            // tb_Nachname
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tb_Nachname, 2);
            this.tb_Nachname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.tb_Nachname, "Tragen sie den Nachnamen ihres Kunden hier ein.");
            this.tb_Nachname.Location = new System.Drawing.Point(90, 114);
            this.tb_Nachname.Name = "tb_Nachname";
            this.helpProvider.SetShowHelp(this.tb_Nachname, true);
            this.tb_Nachname.Size = new System.Drawing.Size(168, 20);
            this.tb_Nachname.TabIndex = 2;
            // 
            // lb_1
            // 
            this.lb_1.AutoSize = true;
            this.lb_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.lb_1, "Tragen sie den  Wohnort ihres Kunden hier ein.");
            this.lb_1.Location = new System.Drawing.Point(3, 262);
            this.lb_1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_1.Name = "lb_1";
            this.helpProvider.SetShowHelp(this.lb_1, true);
            this.lb_1.Size = new System.Drawing.Size(81, 68);
            this.lb_1.TabIndex = 31;
            this.lb_1.Text = "Fächer:";
            // 
            // tb_Vorname
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tb_Vorname, 2);
            this.tb_Vorname.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.tb_Vorname, "Tragen sie den Vornamen ihres Kunden hier ein.");
            this.tb_Vorname.Location = new System.Drawing.Point(90, 77);
            this.tb_Vorname.Name = "tb_Vorname";
            this.helpProvider.SetShowHelp(this.tb_Vorname, true);
            this.tb_Vorname.Size = new System.Drawing.Size(168, 20);
            this.tb_Vorname.TabIndex = 1;
            // 
            // bt_confirm
            // 
            this.bt_confirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.bt_confirm, "Speichern sie alle oben eingetragenen Daten.");
            this.bt_confirm.Location = new System.Drawing.Point(177, 410);
            this.bt_confirm.Name = "bt_confirm";
            this.helpProvider.SetShowHelp(this.bt_confirm, true);
            this.bt_confirm.Size = new System.Drawing.Size(81, 32);
            this.bt_confirm.TabIndex = 13;
            this.bt_confirm.Text = "Speichern";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.bt_OK, "Schließen sie das akuelle Fenster.");
            this.bt_OK.Location = new System.Drawing.Point(493, 410);
            this.bt_OK.Name = "bt_OK";
            this.helpProvider.SetShowHelp(this.bt_OK, true);
            this.bt_OK.Size = new System.Drawing.Size(226, 32);
            this.bt_OK.TabIndex = 46;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // bt_clear
            // 
            this.bt_clear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.bt_clear, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_clear.Location = new System.Drawing.Point(90, 410);
            this.bt_clear.Name = "bt_clear";
            this.helpProvider.SetShowHelp(this.bt_clear, true);
            this.bt_clear.Size = new System.Drawing.Size(81, 32);
            this.bt_clear.TabIndex = 14;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // tb_klasse
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tb_klasse, 2);
            this.tb_klasse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.tb_klasse, "Tragen sie die Hausnummer  ihres Kunden hier ein.");
            this.tb_klasse.Location = new System.Drawing.Point(90, 188);
            this.tb_klasse.Name = "tb_klasse";
            this.helpProvider.SetShowHelp(this.tb_klasse, true);
            this.tb_klasse.Size = new System.Drawing.Size(168, 20);
            this.tb_klasse.TabIndex = 5;
            // 
            // tb_klassenstufe
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.tb_klassenstufe, 2);
            this.tb_klassenstufe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.tb_klassenstufe, "Tragen sie die Postleitzahl ihres Kunden hier ein.");
            this.tb_klassenstufe.Location = new System.Drawing.Point(90, 225);
            this.tb_klassenstufe.Name = "tb_klassenstufe";
            this.helpProvider.SetShowHelp(this.tb_klassenstufe, true);
            this.tb_klassenstufe.Size = new System.Drawing.Size(168, 20);
            this.tb_klassenstufe.TabIndex = 6;
            this.tb_klassenstufe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_klassenstufe_KeyPress);
            // 
            // lb_KundenID
            // 
            this.lb_KundenID.AutoSize = true;
            this.lb_KundenID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.lb_KundenID, resources.GetString("lb_KundenID.HelpString"));
            this.lb_KundenID.Location = new System.Drawing.Point(3, 40);
            this.lb_KundenID.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_KundenID.Name = "lb_KundenID";
            this.helpProvider.SetShowHelp(this.lb_KundenID, true);
            this.lb_KundenID.Size = new System.Drawing.Size(81, 31);
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
            this.tableLayoutPanel2.SetColumnSpan(this.gv_Kunde, 2);
            this.gv_Kunde.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.gv_Kunde, "Hier werden all ihre Kunden angezeigt.");
            this.gv_Kunde.Location = new System.Drawing.Point(264, 40);
            this.gv_Kunde.MultiSelect = false;
            this.gv_Kunde.Name = "gv_Kunde";
            this.gv_Kunde.ReadOnly = true;
            this.gv_Kunde.RowHeadersVisible = false;
            this.gv_Kunde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tableLayoutPanel2.SetRowSpan(this.gv_Kunde, 8);
            this.gv_Kunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.gv_Kunde, true);
            this.gv_Kunde.Size = new System.Drawing.Size(455, 364);
            this.gv_Kunde.TabIndex = 45;
            this.gv_Kunde.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Kunde_CellDoubleClick);
            // 
            // bt_ImEx
            // 
            this.bt_ImEx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_ImEx.Location = new System.Drawing.Point(264, 410);
            this.bt_ImEx.Name = "bt_ImEx";
            this.bt_ImEx.Size = new System.Drawing.Size(223, 32);
            this.bt_ImEx.TabIndex = 47;
            this.bt_ImEx.Text = "Importieren/Exportieren";
            this.bt_ImEx.UseVisualStyleBackColor = true;
            this.bt_ImEx.Click += new System.EventHandler(this.bt_ImEx_Click);
            // 
            // dtp_gd
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.dtp_gd, 2);
            this.dtp_gd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtp_gd.Location = new System.Drawing.Point(90, 151);
            this.dtp_gd.Name = "dtp_gd";
            this.dtp_gd.Size = new System.Drawing.Size(168, 20);
            this.dtp_gd.TabIndex = 48;
            // 
            // cLB_faecher
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.cLB_faecher, 2);
            this.cLB_faecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cLB_faecher.FormattingEnabled = true;
            this.cLB_faecher.Location = new System.Drawing.Point(90, 262);
            this.cLB_faecher.Name = "cLB_faecher";
            this.tableLayoutPanel2.SetRowSpan(this.cLB_faecher, 2);
            this.cLB_faecher.Size = new System.Drawing.Size(168, 142);
            this.cLB_faecher.TabIndex = 32;
            this.cLB_faecher.SelectedIndexChanged += new System.EventHandler(this.cLB_faecher_SelectedIndexChanged);
            this.cLB_faecher.MouseHover += new System.EventHandler(this.cLB_faecher_MouseHover);
            this.cLB_faecher.MouseMove += new System.Windows.Forms.MouseEventHandler(this.cLB_faecher_MouseMove);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.10191F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.10191F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.10191F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.84713F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.84713F));
            this.tableLayoutPanel2.Controls.Add(this.bt_OK, 4, 9);
            this.tableLayoutPanel2.Controls.Add(this.bt_ImEx, 3, 9);
            this.tableLayoutPanel2.Controls.Add(this.lb_1, 0, 7);
            this.tableLayoutPanel2.Controls.Add(this.lb_kunde_add, 0, 9);
            this.tableLayoutPanel2.Controls.Add(this.lb_Klassenstufe, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.bt_clear, 1, 9);
            this.tableLayoutPanel2.Controls.Add(this.gv_Kunde, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtp_gd, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.rb_Neukunde, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_confirm, 2, 9);
            this.tableLayoutPanel2.Controls.Add(this.lb_Klasse, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_klassenstufe, 1, 6);
            this.tableLayoutPanel2.Controls.Add(this.cLB_faecher, 1, 7);
            this.tableLayoutPanel2.Controls.Add(this.tb_klasse, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tb_KundenID, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tb_Nachname, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Nachname, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.lb_Gd, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.tb_Vorname, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.lb_Vorname, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.rb_KundeBearbeiten, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.rb_KundeLoeschen, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_KundenID, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 10;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333541F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333542F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333542F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333541F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333542F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333542F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.333542F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66708F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.331042F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(722, 445);
            this.tableLayoutPanel2.TabIndex = 48;
            // 
            // w_s_schueler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 445);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.MinimumSize = new System.Drawing.Size(715, 447);
            this.Name = "w_s_schueler";
            this.Text = "Schüler";
            this.Activated += new System.EventHandler(this.w_s_schueler_Activated);
            this.Load += new System.EventHandler(this.w_s_schueler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.TextBox tb_klasse;
        private System.Windows.Forms.TextBox tb_klassenstufe;
        private System.Windows.Forms.Label lb_KundenID;
        private System.Windows.Forms.DataGridView gv_Kunde;
        private System.Windows.Forms.Button bt_ImEx;
        private System.Windows.Forms.CheckedListBox cLB_faecher;
        private System.Windows.Forms.DateTimePicker dtp_gd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}