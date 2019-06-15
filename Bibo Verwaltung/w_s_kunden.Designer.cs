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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_Kunden));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_Telefonnummer = new MetroFramework.Controls.MetroLabel();
            this.tb_Telefonnummer = new MetroFramework.Controls.MetroTextBox();
            this.lb_Vorname = new MetroFramework.Controls.MetroLabel();
            this.lb_Nachname = new MetroFramework.Controls.MetroLabel();
            this.tb_KundenID = new MetroFramework.Controls.MetroTextBox();
            this.lb_Strasse = new MetroFramework.Controls.MetroLabel();
            this.lb_Hausnummer = new MetroFramework.Controls.MetroLabel();
            this.lb_Postleitzahl = new MetroFramework.Controls.MetroLabel();
            this.tb_Nachname = new MetroFramework.Controls.MetroTextBox();
            this.lb_Ort = new MetroFramework.Controls.MetroLabel();
            this.tb_Vorname = new MetroFramework.Controls.MetroTextBox();
            this.tb_Strasse = new MetroFramework.Controls.MetroTextBox();
            this.lb_Klasse = new MetroFramework.Controls.MetroLabel();
            this.tb_Mail = new MetroFramework.Controls.MetroTextBox();
            this.lb_Mail = new MetroFramework.Controls.MetroLabel();
            this.tb_Hausnummer = new MetroFramework.Controls.MetroTextBox();
            this.tb_Klasse = new MetroFramework.Controls.MetroTextBox();
            this.tb_Postleitzahl = new MetroFramework.Controls.MetroTextBox();
            this.tb_Ort = new MetroFramework.Controls.MetroTextBox();
            this.lb_KundenID = new MetroFramework.Controls.MetroLabel();
            this.lb_kunde_add = new MetroFramework.Controls.MetroTextBox();
            this.bt_clear = new MetroFramework.Controls.MetroButton();
            this.rb_KundeLoeschen = new MetroFramework.Controls.MetroRadioButton();
            this.rb_KundeBearbeiten = new MetroFramework.Controls.MetroRadioButton();
            this.rb_Neukunde = new MetroFramework.Controls.MetroRadioButton();
            this.bt_confirm = new MetroFramework.Controls.MetroButton();
            this.bt_OK = new MetroFramework.Controls.MetroButton();
            this.gv_Kunde = new MetroFramework.Controls.MetroGrid();
            this.cm_kunde = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.kundeBearbeitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundeEntfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.lb_geburtsdatum = new MetroFramework.Controls.MetroLabel();
            this.lb_faecher = new MetroFramework.Controls.MetroLabel();
            this.bt_ImEx = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dTP_gd = new MetroFramework.Controls.MetroDateTime();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.gv_result = new MetroFramework.Controls.MetroGrid();
            this.Kurzbezeichnung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cm_result = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.leistungskursAuswählenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gv_faecher = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.rb_alles = new MetroFramework.Controls.MetroRadioButton();
            this.rb_schueler = new MetroFramework.Controls.MetroRadioButton();
            this.rb_andere = new MetroFramework.Controls.MetroRadioButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.bt_cleanup = new MetroFramework.Controls.MetroButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).BeginInit();
            this.cm_kunde.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_result)).BeginInit();
            this.cm_result.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_faecher)).BeginInit();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Telefonnummer
            // 
            this.helpProvider.SetHelpString(this.lb_Telefonnummer, "Tragen sie die Telefonnummer ihres Kunden hier ein.");
            this.lb_Telefonnummer.Location = new System.Drawing.Point(3, 308);
            this.lb_Telefonnummer.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Telefonnummer.Name = "lb_Telefonnummer";
            this.helpProvider.SetShowHelp(this.lb_Telefonnummer, true);
            this.lb_Telefonnummer.Size = new System.Drawing.Size(104, 24);
            this.lb_Telefonnummer.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Telefonnummer.TabIndex = 16;
            this.lb_Telefonnummer.Text = "Telefonnummer:";
            this.lb_Telefonnummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Telefonnummer
            // 
            // 
            // 
            // 
            this.tb_Telefonnummer.CustomButton.Image = null;
            this.tb_Telefonnummer.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_Telefonnummer.CustomButton.Name = "";
            this.tb_Telefonnummer.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Telefonnummer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Telefonnummer.CustomButton.TabIndex = 1;
            this.tb_Telefonnummer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Telefonnummer.CustomButton.UseSelectable = true;
            this.tb_Telefonnummer.CustomButton.Visible = false;
            this.helpProvider.SetHelpString(this.tb_Telefonnummer, "Tragen sie die Telefonnummer ihres Kunden hier ein.");
            this.tb_Telefonnummer.Lines = new string[0];
            this.tb_Telefonnummer.Location = new System.Drawing.Point(113, 308);
            this.tb_Telefonnummer.MaxLength = 32767;
            this.tb_Telefonnummer.Name = "tb_Telefonnummer";
            this.tb_Telefonnummer.PasswordChar = '\0';
            this.tb_Telefonnummer.PromptText = "Telefonnummer";
            this.tb_Telefonnummer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Telefonnummer.SelectedText = "";
            this.tb_Telefonnummer.SelectionLength = 0;
            this.tb_Telefonnummer.SelectionStart = 0;
            this.tb_Telefonnummer.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Telefonnummer, true);
            this.tb_Telefonnummer.Size = new System.Drawing.Size(175, 24);
            this.tb_Telefonnummer.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_Telefonnummer.TabIndex = 13;
            this.tb_Telefonnummer.UseSelectable = true;
            this.tb_Telefonnummer.WaterMark = "Telefonnummer";
            this.tb_Telefonnummer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Telefonnummer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Telefonnummer.TextChanged += new System.EventHandler(this.tb_Telefonnummer_TextChanged);
            // 
            // lb_Vorname
            // 
            this.helpProvider.SetHelpString(this.lb_Vorname, "Tragen sie den Vornamen ihres Kunden hier ein.");
            this.lb_Vorname.Location = new System.Drawing.Point(3, 33);
            this.lb_Vorname.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Vorname.Name = "lb_Vorname";
            this.helpProvider.SetShowHelp(this.lb_Vorname, true);
            this.lb_Vorname.Size = new System.Drawing.Size(104, 24);
            this.lb_Vorname.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Vorname.TabIndex = 21;
            this.lb_Vorname.Text = "Vorname:";
            this.lb_Vorname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Nachname
            // 
            this.helpProvider.SetHelpString(this.lb_Nachname, "Tragen sie den Nachnamen ihres Kunden hier ein.");
            this.lb_Nachname.Location = new System.Drawing.Point(3, 63);
            this.lb_Nachname.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Nachname.Name = "lb_Nachname";
            this.helpProvider.SetShowHelp(this.lb_Nachname, true);
            this.lb_Nachname.Size = new System.Drawing.Size(104, 24);
            this.lb_Nachname.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Nachname.TabIndex = 23;
            this.lb_Nachname.Text = "Nachname:";
            this.lb_Nachname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_KundenID
            // 
            // 
            // 
            // 
            this.tb_KundenID.CustomButton.Image = null;
            this.tb_KundenID.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_KundenID.CustomButton.Name = "";
            this.tb_KundenID.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_KundenID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_KundenID.CustomButton.TabIndex = 1;
            this.tb_KundenID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_KundenID.CustomButton.UseSelectable = true;
            this.tb_KundenID.CustomButton.Visible = false;
            this.helpProvider.SetHelpString(this.tb_KundenID, resources.GetString("tb_KundenID.HelpString"));
            this.tb_KundenID.Lines = new string[0];
            this.tb_KundenID.Location = new System.Drawing.Point(113, 3);
            this.tb_KundenID.MaxLength = 32767;
            this.tb_KundenID.Name = "tb_KundenID";
            this.tb_KundenID.PasswordChar = '\0';
            this.tb_KundenID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_KundenID.SelectedText = "";
            this.tb_KundenID.SelectionLength = 0;
            this.tb_KundenID.SelectionStart = 0;
            this.tb_KundenID.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_KundenID, true);
            this.tb_KundenID.Size = new System.Drawing.Size(175, 24);
            this.tb_KundenID.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_KundenID.TabIndex = 3;
            this.tb_KundenID.UseSelectable = true;
            this.tb_KundenID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_KundenID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_KundenID.TextChanged += new System.EventHandler(this.tb_KundenID_TextChanged);
            // 
            // lb_Strasse
            // 
            this.helpProvider.SetHelpString(this.lb_Strasse, "Tragen sie die Straße ihres Kunden hier ein.");
            this.lb_Strasse.Location = new System.Drawing.Point(3, 128);
            this.lb_Strasse.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Strasse.Name = "lb_Strasse";
            this.helpProvider.SetShowHelp(this.lb_Strasse, true);
            this.lb_Strasse.Size = new System.Drawing.Size(104, 24);
            this.lb_Strasse.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Strasse.TabIndex = 7;
            this.lb_Strasse.Text = "Strasse:";
            this.lb_Strasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Hausnummer
            // 
            this.helpProvider.SetHelpString(this.lb_Hausnummer, "Tragen sie die Hausnummer  ihres Kunden hier ein.");
            this.lb_Hausnummer.Location = new System.Drawing.Point(3, 158);
            this.lb_Hausnummer.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Hausnummer.Name = "lb_Hausnummer";
            this.helpProvider.SetShowHelp(this.lb_Hausnummer, true);
            this.lb_Hausnummer.Size = new System.Drawing.Size(104, 24);
            this.lb_Hausnummer.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Hausnummer.TabIndex = 27;
            this.lb_Hausnummer.Text = "Hausnummer:";
            this.lb_Hausnummer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Postleitzahl
            // 
            this.helpProvider.SetHelpString(this.lb_Postleitzahl, "Tragen sie die Postleitzahl ihres Kunden hier ein.");
            this.lb_Postleitzahl.Location = new System.Drawing.Point(3, 188);
            this.lb_Postleitzahl.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Postleitzahl.Name = "lb_Postleitzahl";
            this.helpProvider.SetShowHelp(this.lb_Postleitzahl, true);
            this.lb_Postleitzahl.Size = new System.Drawing.Size(104, 24);
            this.lb_Postleitzahl.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Postleitzahl.TabIndex = 29;
            this.lb_Postleitzahl.Text = "Postleitzahl:";
            this.lb_Postleitzahl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Nachname
            // 
            // 
            // 
            // 
            this.tb_Nachname.CustomButton.Image = null;
            this.tb_Nachname.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_Nachname.CustomButton.Name = "";
            this.tb_Nachname.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Nachname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Nachname.CustomButton.TabIndex = 1;
            this.tb_Nachname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Nachname.CustomButton.UseSelectable = true;
            this.tb_Nachname.CustomButton.Visible = false;
            this.helpProvider.SetHelpString(this.tb_Nachname, "Tragen sie den Nachnamen ihres Kunden hier ein.");
            this.tb_Nachname.Lines = new string[0];
            this.tb_Nachname.Location = new System.Drawing.Point(113, 63);
            this.tb_Nachname.MaxLength = 32767;
            this.tb_Nachname.Name = "tb_Nachname";
            this.tb_Nachname.PasswordChar = '\0';
            this.tb_Nachname.PromptText = "Nachname";
            this.tb_Nachname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Nachname.SelectedText = "";
            this.tb_Nachname.SelectionLength = 0;
            this.tb_Nachname.SelectionStart = 0;
            this.tb_Nachname.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Nachname, true);
            this.tb_Nachname.Size = new System.Drawing.Size(175, 24);
            this.tb_Nachname.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_Nachname.TabIndex = 5;
            this.tb_Nachname.UseSelectable = true;
            this.tb_Nachname.WaterMark = "Nachname";
            this.tb_Nachname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Nachname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Nachname.TextChanged += new System.EventHandler(this.tb_Nachname_TextChanged);
            // 
            // lb_Ort
            // 
            this.helpProvider.SetHelpString(this.lb_Ort, "Tragen sie den  Wohnort ihres Kunden hier ein.");
            this.lb_Ort.Location = new System.Drawing.Point(3, 218);
            this.lb_Ort.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Ort.Name = "lb_Ort";
            this.helpProvider.SetShowHelp(this.lb_Ort, true);
            this.lb_Ort.Size = new System.Drawing.Size(104, 24);
            this.lb_Ort.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Ort.TabIndex = 31;
            this.lb_Ort.Text = "Wohnort:";
            this.lb_Ort.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Vorname
            // 
            // 
            // 
            // 
            this.tb_Vorname.CustomButton.Image = null;
            this.tb_Vorname.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_Vorname.CustomButton.Name = "";
            this.tb_Vorname.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Vorname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Vorname.CustomButton.TabIndex = 1;
            this.tb_Vorname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Vorname.CustomButton.UseSelectable = true;
            this.tb_Vorname.CustomButton.Visible = false;
            this.helpProvider.SetHelpString(this.tb_Vorname, "Tragen sie den Vornamen ihres Kunden hier ein.");
            this.tb_Vorname.Lines = new string[0];
            this.tb_Vorname.Location = new System.Drawing.Point(113, 33);
            this.tb_Vorname.MaxLength = 32767;
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.PasswordChar = '\0';
            this.tb_Vorname.PromptText = "Vorname";
            this.tb_Vorname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Vorname.SelectedText = "";
            this.tb_Vorname.SelectionLength = 0;
            this.tb_Vorname.SelectionStart = 0;
            this.tb_Vorname.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Vorname, true);
            this.tb_Vorname.Size = new System.Drawing.Size(175, 24);
            this.tb_Vorname.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_Vorname.TabIndex = 4;
            this.tb_Vorname.UseSelectable = true;
            this.tb_Vorname.WaterMark = "Vorname";
            this.tb_Vorname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Vorname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Vorname.TextChanged += new System.EventHandler(this.tb_Vorname_TextChanged);
            // 
            // tb_Strasse
            // 
            // 
            // 
            // 
            this.tb_Strasse.CustomButton.Image = null;
            this.tb_Strasse.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_Strasse.CustomButton.Name = "";
            this.tb_Strasse.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Strasse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Strasse.CustomButton.TabIndex = 1;
            this.tb_Strasse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Strasse.CustomButton.UseSelectable = true;
            this.tb_Strasse.CustomButton.Visible = false;
            this.helpProvider.SetHelpString(this.tb_Strasse, "Tragen sie die Straße ihres Kunden hier ein.");
            this.tb_Strasse.Lines = new string[0];
            this.tb_Strasse.Location = new System.Drawing.Point(113, 128);
            this.tb_Strasse.MaxLength = 32767;
            this.tb_Strasse.Name = "tb_Strasse";
            this.tb_Strasse.PasswordChar = '\0';
            this.tb_Strasse.PromptText = "Strasse";
            this.tb_Strasse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Strasse.SelectedText = "";
            this.tb_Strasse.SelectionLength = 0;
            this.tb_Strasse.SelectionStart = 0;
            this.tb_Strasse.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Strasse, true);
            this.tb_Strasse.Size = new System.Drawing.Size(175, 24);
            this.tb_Strasse.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_Strasse.TabIndex = 7;
            this.tb_Strasse.UseSelectable = true;
            this.tb_Strasse.WaterMark = "Strasse";
            this.tb_Strasse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Strasse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Strasse.TextChanged += new System.EventHandler(this.tb_Strasse_TextChanged);
            // 
            // lb_Klasse
            // 
            this.helpProvider.SetHelpString(this.lb_Klasse, "Tragen sie die Klasse ihres Kunden hier ein.");
            this.lb_Klasse.Location = new System.Drawing.Point(3, 248);
            this.lb_Klasse.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Klasse.Name = "lb_Klasse";
            this.helpProvider.SetShowHelp(this.lb_Klasse, true);
            this.lb_Klasse.Size = new System.Drawing.Size(104, 24);
            this.lb_Klasse.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Klasse.TabIndex = 34;
            this.lb_Klasse.Text = "Klasse:";
            this.lb_Klasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Mail
            // 
            // 
            // 
            // 
            this.tb_Mail.CustomButton.Image = null;
            this.tb_Mail.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_Mail.CustomButton.Name = "";
            this.tb_Mail.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Mail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Mail.CustomButton.TabIndex = 1;
            this.tb_Mail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Mail.CustomButton.UseSelectable = true;
            this.tb_Mail.CustomButton.Visible = false;
            this.helpProvider.SetHelpString(this.tb_Mail, "Tragen sie die E-Mail Adresse ihres Kunden hier ein.");
            this.tb_Mail.Lines = new string[0];
            this.tb_Mail.Location = new System.Drawing.Point(113, 278);
            this.tb_Mail.MaxLength = 32767;
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.PasswordChar = '\0';
            this.tb_Mail.PromptText = "Mail";
            this.tb_Mail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Mail.SelectedText = "";
            this.tb_Mail.SelectionLength = 0;
            this.tb_Mail.SelectionStart = 0;
            this.tb_Mail.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Mail, true);
            this.tb_Mail.Size = new System.Drawing.Size(175, 24);
            this.tb_Mail.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_Mail.TabIndex = 12;
            this.tb_Mail.UseSelectable = true;
            this.tb_Mail.WaterMark = "Mail";
            this.tb_Mail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Mail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Mail.TextChanged += new System.EventHandler(this.tb_Mail_TextChanged);
            // 
            // lb_Mail
            // 
            this.helpProvider.SetHelpString(this.lb_Mail, "Tragen sie die E-Mail Adresse ihres Kunden hier ein.");
            this.lb_Mail.Location = new System.Drawing.Point(3, 278);
            this.lb_Mail.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Mail.Name = "lb_Mail";
            this.helpProvider.SetShowHelp(this.lb_Mail, true);
            this.lb_Mail.Size = new System.Drawing.Size(104, 24);
            this.lb_Mail.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Mail.TabIndex = 37;
            this.lb_Mail.Text = "Mail:";
            this.lb_Mail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Hausnummer
            // 
            // 
            // 
            // 
            this.tb_Hausnummer.CustomButton.Image = null;
            this.tb_Hausnummer.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_Hausnummer.CustomButton.Name = "";
            this.tb_Hausnummer.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Hausnummer.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Hausnummer.CustomButton.TabIndex = 1;
            this.tb_Hausnummer.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Hausnummer.CustomButton.UseSelectable = true;
            this.tb_Hausnummer.CustomButton.Visible = false;
            this.helpProvider.SetHelpString(this.tb_Hausnummer, "Tragen sie die Hausnummer  ihres Kunden hier ein.");
            this.tb_Hausnummer.Lines = new string[0];
            this.tb_Hausnummer.Location = new System.Drawing.Point(113, 158);
            this.tb_Hausnummer.MaxLength = 32767;
            this.tb_Hausnummer.Name = "tb_Hausnummer";
            this.tb_Hausnummer.PasswordChar = '\0';
            this.tb_Hausnummer.PromptText = "Hausnummer";
            this.tb_Hausnummer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Hausnummer.SelectedText = "";
            this.tb_Hausnummer.SelectionLength = 0;
            this.tb_Hausnummer.SelectionStart = 0;
            this.tb_Hausnummer.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Hausnummer, true);
            this.tb_Hausnummer.Size = new System.Drawing.Size(175, 24);
            this.tb_Hausnummer.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_Hausnummer.TabIndex = 8;
            this.tb_Hausnummer.UseSelectable = true;
            this.tb_Hausnummer.WaterMark = "Hausnummer";
            this.tb_Hausnummer.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Hausnummer.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Hausnummer.TextChanged += new System.EventHandler(this.tb_Hausnummer_TextChanged);
            // 
            // tb_Klasse
            // 
            // 
            // 
            // 
            this.tb_Klasse.CustomButton.Image = null;
            this.tb_Klasse.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_Klasse.CustomButton.Name = "";
            this.tb_Klasse.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Klasse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Klasse.CustomButton.TabIndex = 1;
            this.tb_Klasse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Klasse.CustomButton.UseSelectable = true;
            this.tb_Klasse.CustomButton.Visible = false;
            this.helpProvider.SetHelpString(this.tb_Klasse, "Tragen sie die Klasse ihres Kunden hier ein.");
            this.tb_Klasse.Lines = new string[0];
            this.tb_Klasse.Location = new System.Drawing.Point(113, 248);
            this.tb_Klasse.MaxLength = 32767;
            this.tb_Klasse.Name = "tb_Klasse";
            this.tb_Klasse.PasswordChar = '\0';
            this.tb_Klasse.PromptText = "Klasse";
            this.tb_Klasse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Klasse.SelectedText = "";
            this.tb_Klasse.SelectionLength = 0;
            this.tb_Klasse.SelectionStart = 0;
            this.tb_Klasse.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Klasse, true);
            this.tb_Klasse.Size = new System.Drawing.Size(175, 24);
            this.tb_Klasse.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_Klasse.TabIndex = 11;
            this.tb_Klasse.UseSelectable = true;
            this.tb_Klasse.WaterMark = "Klasse";
            this.tb_Klasse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Klasse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Klasse.TextChanged += new System.EventHandler(this.tb_Klasse_TextChanged);
            // 
            // tb_Postleitzahl
            // 
            // 
            // 
            // 
            this.tb_Postleitzahl.CustomButton.Image = null;
            this.tb_Postleitzahl.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_Postleitzahl.CustomButton.Name = "";
            this.tb_Postleitzahl.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Postleitzahl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Postleitzahl.CustomButton.TabIndex = 1;
            this.tb_Postleitzahl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Postleitzahl.CustomButton.UseSelectable = true;
            this.tb_Postleitzahl.CustomButton.Visible = false;
            this.helpProvider.SetHelpString(this.tb_Postleitzahl, "Tragen sie die Postleitzahl ihres Kunden hier ein.");
            this.tb_Postleitzahl.Lines = new string[0];
            this.tb_Postleitzahl.Location = new System.Drawing.Point(113, 188);
            this.tb_Postleitzahl.MaxLength = 32767;
            this.tb_Postleitzahl.Name = "tb_Postleitzahl";
            this.tb_Postleitzahl.PasswordChar = '\0';
            this.tb_Postleitzahl.PromptText = "Postleitzahl";
            this.tb_Postleitzahl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Postleitzahl.SelectedText = "";
            this.tb_Postleitzahl.SelectionLength = 0;
            this.tb_Postleitzahl.SelectionStart = 0;
            this.tb_Postleitzahl.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Postleitzahl, true);
            this.tb_Postleitzahl.Size = new System.Drawing.Size(175, 24);
            this.tb_Postleitzahl.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_Postleitzahl.TabIndex = 9;
            this.tb_Postleitzahl.UseSelectable = true;
            this.tb_Postleitzahl.WaterMark = "Postleitzahl";
            this.tb_Postleitzahl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Postleitzahl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Postleitzahl.TextChanged += new System.EventHandler(this.tb_Postleitzahl_TextChanged);
            // 
            // tb_Ort
            // 
            // 
            // 
            // 
            this.tb_Ort.CustomButton.Image = null;
            this.tb_Ort.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_Ort.CustomButton.Name = "";
            this.tb_Ort.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Ort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Ort.CustomButton.TabIndex = 1;
            this.tb_Ort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Ort.CustomButton.UseSelectable = true;
            this.tb_Ort.CustomButton.Visible = false;
            this.helpProvider.SetHelpString(this.tb_Ort, "Tragen sie den  Wohnort ihres Kunden hier ein.");
            this.tb_Ort.Lines = new string[0];
            this.tb_Ort.Location = new System.Drawing.Point(113, 218);
            this.tb_Ort.MaxLength = 32767;
            this.tb_Ort.Name = "tb_Ort";
            this.tb_Ort.PasswordChar = '\0';
            this.tb_Ort.PromptText = "Wohnort";
            this.tb_Ort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Ort.SelectedText = "";
            this.tb_Ort.SelectionLength = 0;
            this.tb_Ort.SelectionStart = 0;
            this.tb_Ort.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Ort, true);
            this.tb_Ort.Size = new System.Drawing.Size(175, 24);
            this.tb_Ort.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_Ort.TabIndex = 10;
            this.tb_Ort.UseSelectable = true;
            this.tb_Ort.WaterMark = "Wohnort";
            this.tb_Ort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Ort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Ort.TextChanged += new System.EventHandler(this.tb_Ort_TextChanged);
            // 
            // lb_KundenID
            // 
            this.helpProvider.SetHelpString(this.lb_KundenID, resources.GetString("lb_KundenID.HelpString"));
            this.lb_KundenID.Location = new System.Drawing.Point(3, 3);
            this.lb_KundenID.Margin = new System.Windows.Forms.Padding(3);
            this.lb_KundenID.Name = "lb_KundenID";
            this.helpProvider.SetShowHelp(this.lb_KundenID, true);
            this.lb_KundenID.Size = new System.Drawing.Size(104, 24);
            this.lb_KundenID.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_KundenID.TabIndex = 0;
            this.lb_KundenID.Text = "Kunden-ID:";
            this.lb_KundenID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_kunde_add
            // 
            // 
            // 
            // 
            this.lb_kunde_add.CustomButton.Image = null;
            this.lb_kunde_add.CustomButton.Location = new System.Drawing.Point(263, 2);
            this.lb_kunde_add.CustomButton.Name = "";
            this.lb_kunde_add.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.lb_kunde_add.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lb_kunde_add.CustomButton.TabIndex = 1;
            this.lb_kunde_add.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lb_kunde_add.CustomButton.UseSelectable = true;
            this.lb_kunde_add.CustomButton.Visible = false;
            this.lb_kunde_add.Enabled = false;
            this.lb_kunde_add.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lb_kunde_add.Lines = new string[] {
        "Der Kunde wurde erfolgreich hinzugefügt!"};
            this.lb_kunde_add.Location = new System.Drawing.Point(3, 612);
            this.lb_kunde_add.MaxLength = 32767;
            this.lb_kunde_add.Multiline = true;
            this.lb_kunde_add.Name = "lb_kunde_add";
            this.lb_kunde_add.PasswordChar = '\0';
            this.lb_kunde_add.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lb_kunde_add.SelectedText = "";
            this.lb_kunde_add.SelectionLength = 0;
            this.lb_kunde_add.SelectionStart = 0;
            this.lb_kunde_add.ShortcutsEnabled = true;
            this.lb_kunde_add.Size = new System.Drawing.Size(285, 24);
            this.lb_kunde_add.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_kunde_add.TabIndex = 40;
            this.lb_kunde_add.Text = "Der Kunde wurde erfolgreich hinzugefügt!";
            this.lb_kunde_add.UseSelectable = true;
            this.lb_kunde_add.Visible = false;
            this.lb_kunde_add.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lb_kunde_add.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bt_clear
            // 
            this.bt_clear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_clear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_clear, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_clear.Location = new System.Drawing.Point(3, 582);
            this.bt_clear.Name = "bt_clear";
            this.helpProvider.SetShowHelp(this.bt_clear, true);
            this.bt_clear.Size = new System.Drawing.Size(135, 24);
            this.bt_clear.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_clear.TabIndex = 16;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseSelectable = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // rb_KundeLoeschen
            // 
            this.rb_KundeLoeschen.AutoSize = true;
            this.rb_KundeLoeschen.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_KundeLoeschen.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.rb_KundeLoeschen, "Klicken sie hier, um einen vorhandenen Kunden zu löschen.");
            this.rb_KundeLoeschen.Location = new System.Drawing.Point(213, 63);
            this.rb_KundeLoeschen.Name = "rb_KundeLoeschen";
            this.helpProvider.SetShowHelp(this.rb_KundeLoeschen, true);
            this.rb_KundeLoeschen.Size = new System.Drawing.Size(86, 20);
            this.rb_KundeLoeschen.Style = MetroFramework.MetroColorStyle.Teal;
            this.rb_KundeLoeschen.TabIndex = 2;
            this.rb_KundeLoeschen.Text = "Entfernen";
            this.rb_KundeLoeschen.UseSelectable = true;
            this.rb_KundeLoeschen.CheckedChanged += new System.EventHandler(this.rb_KundeLoeschen_CheckedChanged);
            // 
            // rb_KundeBearbeiten
            // 
            this.rb_KundeBearbeiten.AutoSize = true;
            this.rb_KundeBearbeiten.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_KundeBearbeiten.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.rb_KundeBearbeiten, "Klicken sie hier, um einen vorhandenen Kunden zu bearbeiten.");
            this.rb_KundeBearbeiten.Location = new System.Drawing.Point(119, 63);
            this.rb_KundeBearbeiten.Name = "rb_KundeBearbeiten";
            this.helpProvider.SetShowHelp(this.rb_KundeBearbeiten, true);
            this.rb_KundeBearbeiten.Size = new System.Drawing.Size(92, 20);
            this.rb_KundeBearbeiten.Style = MetroFramework.MetroColorStyle.Teal;
            this.rb_KundeBearbeiten.TabIndex = 1;
            this.rb_KundeBearbeiten.Text = "Bearbeiten";
            this.rb_KundeBearbeiten.UseSelectable = true;
            this.rb_KundeBearbeiten.CheckedChanged += new System.EventHandler(this.rb_KundeBearbeiten_CheckedChanged);
            // 
            // rb_Neukunde
            // 
            this.rb_Neukunde.AutoSize = true;
            this.rb_Neukunde.Checked = true;
            this.rb_Neukunde.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_Neukunde.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.rb_Neukunde, "Klicken sie hier, um einen neuen Kunden hinzuzufügen.");
            this.rb_Neukunde.Location = new System.Drawing.Point(23, 63);
            this.rb_Neukunde.Name = "rb_Neukunde";
            this.helpProvider.SetShowHelp(this.rb_Neukunde, true);
            this.rb_Neukunde.Size = new System.Drawing.Size(97, 20);
            this.rb_Neukunde.Style = MetroFramework.MetroColorStyle.Teal;
            this.rb_Neukunde.TabIndex = 0;
            this.rb_Neukunde.TabStop = true;
            this.rb_Neukunde.Text = "Hinzufügen";
            this.rb_Neukunde.UseSelectable = true;
            this.rb_Neukunde.CheckedChanged += new System.EventHandler(this.rb_Neukunde_CheckedChanged);
            // 
            // bt_confirm
            // 
            this.bt_confirm.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_confirm.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_confirm, "Speichern sie alle oben eingetragenen Daten.");
            this.bt_confirm.Location = new System.Drawing.Point(153, 582);
            this.bt_confirm.Name = "bt_confirm";
            this.helpProvider.SetShowHelp(this.bt_confirm, true);
            this.bt_confirm.Size = new System.Drawing.Size(135, 24);
            this.bt_confirm.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_confirm.TabIndex = 17;
            this.bt_confirm.Text = "Speichern";
            this.bt_confirm.UseSelectable = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_click);
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_OK.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_OK, "Schließen sie das akuelle Fenster.");
            this.bt_OK.Location = new System.Drawing.Point(1002, 703);
            this.bt_OK.Name = "bt_OK";
            this.helpProvider.SetShowHelp(this.bt_OK, true);
            this.bt_OK.Size = new System.Drawing.Size(175, 24);
            this.bt_OK.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_OK.TabIndex = 21;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseSelectable = true;
            // 
            // gv_Kunde
            // 
            this.gv_Kunde.AllowUserToAddRows = false;
            this.gv_Kunde.AllowUserToDeleteRows = false;
            this.gv_Kunde.AllowUserToResizeColumns = false;
            this.gv_Kunde.AllowUserToResizeRows = false;
            this.gv_Kunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_Kunde.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Kunde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Kunde.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Kunde.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Kunde.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.gv_Kunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Kunde.ContextMenuStrip = this.cm_kunde;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Kunde.DefaultCellStyle = dataGridViewCellStyle11;
            this.gv_Kunde.EnableHeadersVisualStyles = false;
            this.gv_Kunde.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Kunde.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.gv_Kunde, "Hier werden all ihre Kunden angezeigt.");
            this.gv_Kunde.Location = new System.Drawing.Point(319, 125);
            this.gv_Kunde.Name = "gv_Kunde";
            this.gv_Kunde.ReadOnly = true;
            this.gv_Kunde.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Kunde.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gv_Kunde.RowHeadersVisible = false;
            this.gv_Kunde.RowHeadersWidth = 51;
            this.gv_Kunde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Kunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.gv_Kunde, true);
            this.gv_Kunde.Size = new System.Drawing.Size(858, 572);
            this.gv_Kunde.Style = MetroFramework.MetroColorStyle.Teal;
            this.gv_Kunde.TabIndex = 18;
            this.gv_Kunde.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Kunde_CellDoubleClick);
            this.gv_Kunde.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_Kunde_CellMouseDown);
            // 
            // cm_kunde
            // 
            this.cm_kunde.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cm_kunde.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kundeBearbeitenToolStripMenuItem,
            this.kundeEntfernenToolStripMenuItem});
            this.cm_kunde.Name = "cm_kunde";
            this.cm_kunde.Size = new System.Drawing.Size(197, 52);
            // 
            // kundeBearbeitenToolStripMenuItem
            // 
            this.kundeBearbeitenToolStripMenuItem.Name = "kundeBearbeitenToolStripMenuItem";
            this.kundeBearbeitenToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.kundeBearbeitenToolStripMenuItem.Text = "Kunde bearbeiten";
            this.kundeBearbeitenToolStripMenuItem.Click += new System.EventHandler(this.kundeBearbeitenToolStripMenuItem_Click);
            // 
            // kundeEntfernenToolStripMenuItem
            // 
            this.kundeEntfernenToolStripMenuItem.Name = "kundeEntfernenToolStripMenuItem";
            this.kundeEntfernenToolStripMenuItem.Size = new System.Drawing.Size(196, 24);
            this.kundeEntfernenToolStripMenuItem.Text = "Kunde entfernen";
            this.kundeEntfernenToolStripMenuItem.Click += new System.EventHandler(this.kundeEntfernenToolStripMenuItem_Click);
            // 
            // lb_geburtsdatum
            // 
            this.helpProvider.SetHelpString(this.lb_geburtsdatum, "Tragen sie den Nachnamen ihres Kunden hier ein.");
            this.lb_geburtsdatum.Location = new System.Drawing.Point(3, 93);
            this.lb_geburtsdatum.Margin = new System.Windows.Forms.Padding(3);
            this.lb_geburtsdatum.Name = "lb_geburtsdatum";
            this.helpProvider.SetShowHelp(this.lb_geburtsdatum, true);
            this.lb_geburtsdatum.Size = new System.Drawing.Size(104, 24);
            this.lb_geburtsdatum.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_geburtsdatum.TabIndex = 41;
            this.lb_geburtsdatum.Text = "Geburtsdatum:";
            this.lb_geburtsdatum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_faecher
            // 
            this.lb_faecher.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_faecher, "Tragen sie die Telefonnummer ihres Kunden hier ein.");
            this.lb_faecher.Location = new System.Drawing.Point(3, 338);
            this.lb_faecher.Margin = new System.Windows.Forms.Padding(3);
            this.lb_faecher.Name = "lb_faecher";
            this.helpProvider.SetShowHelp(this.lb_faecher, true);
            this.lb_faecher.Size = new System.Drawing.Size(55, 20);
            this.lb_faecher.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_faecher.TabIndex = 48;
            this.lb_faecher.Text = "Fächer:";
            // 
            // bt_ImEx
            // 
            this.bt_ImEx.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_ImEx.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_ImEx.Location = new System.Drawing.Point(504, 703);
            this.bt_ImEx.Name = "bt_ImEx";
            this.bt_ImEx.Size = new System.Drawing.Size(175, 24);
            this.bt_ImEx.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_ImEx.TabIndex = 20;
            this.bt_ImEx.Text = "Kundendaten-Import";
            this.bt_ImEx.UseSelectable = true;
            this.bt_ImEx.Click += new System.EventHandler(this.bt_ImEx_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dTP_gd);
            this.metroPanel1.Controls.Add(this.metroProgressSpinner2);
            this.metroPanel1.Controls.Add(this.lb_faecher);
            this.metroPanel1.Controls.Add(this.gv_result);
            this.metroPanel1.Controls.Add(this.gv_faecher);
            this.metroPanel1.Controls.Add(this.lb_geburtsdatum);
            this.metroPanel1.Controls.Add(this.lb_kunde_add);
            this.metroPanel1.Controls.Add(this.lb_Telefonnummer);
            this.metroPanel1.Controls.Add(this.bt_confirm);
            this.metroPanel1.Controls.Add(this.bt_clear);
            this.metroPanel1.Controls.Add(this.tb_Telefonnummer);
            this.metroPanel1.Controls.Add(this.lb_Klasse);
            this.metroPanel1.Controls.Add(this.tb_Mail);
            this.metroPanel1.Controls.Add(this.lb_Mail);
            this.metroPanel1.Controls.Add(this.lb_Hausnummer);
            this.metroPanel1.Controls.Add(this.tb_Klasse);
            this.metroPanel1.Controls.Add(this.lb_Ort);
            this.metroPanel1.Controls.Add(this.lb_Postleitzahl);
            this.metroPanel1.Controls.Add(this.lb_Strasse);
            this.metroPanel1.Controls.Add(this.lb_Nachname);
            this.metroPanel1.Controls.Add(this.lb_Vorname);
            this.metroPanel1.Controls.Add(this.tb_KundenID);
            this.metroPanel1.Controls.Add(this.lb_KundenID);
            this.metroPanel1.Controls.Add(this.tb_Vorname);
            this.metroPanel1.Controls.Add(this.tb_Nachname);
            this.metroPanel1.Controls.Add(this.tb_Strasse);
            this.metroPanel1.Controls.Add(this.tb_Hausnummer);
            this.metroPanel1.Controls.Add(this.tb_Postleitzahl);
            this.metroPanel1.Controls.Add(this.tb_Ort);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 88);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(290, 639);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroPanel1.TabIndex = 43;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // dTP_gd
            // 
            this.dTP_gd.CustomFormat = " dd : MMMM : yyyy";
            this.dTP_gd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_gd.Location = new System.Drawing.Point(113, 93);
            this.dTP_gd.MinimumSize = new System.Drawing.Size(0, 30);
            this.dTP_gd.Name = "dTP_gd";
            this.dTP_gd.Size = new System.Drawing.Size(174, 30);
            this.dTP_gd.TabIndex = 49;
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.BackColor = System.Drawing.Color.Lavender;
            this.metroProgressSpinner2.Location = new System.Drawing.Point(3, 397);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(160, 150);
            this.metroProgressSpinner2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroProgressSpinner2.TabIndex = 49;
            this.metroProgressSpinner2.UseSelectable = true;
            // 
            // gv_result
            // 
            this.gv_result.AllowUserToAddRows = false;
            this.gv_result.AllowUserToDeleteRows = false;
            this.gv_result.AllowUserToResizeColumns = false;
            this.gv_result.AllowUserToResizeRows = false;
            this.gv_result.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_result.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_result.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_result.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_result.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_result.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_result.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kurzbezeichnung,
            this.ID});
            this.gv_result.ContextMenuStrip = this.cm_result;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_result.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_result.EnableHeadersVisualStyles = false;
            this.gv_result.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_result.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_result.Location = new System.Drawing.Point(169, 360);
            this.gv_result.MultiSelect = false;
            this.gv_result.Name = "gv_result";
            this.gv_result.ReadOnly = true;
            this.gv_result.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_result.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_result.RowHeadersVisible = false;
            this.gv_result.RowHeadersWidth = 51;
            this.gv_result.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_result.RowTemplate.DividerHeight = 1;
            this.gv_result.RowTemplate.Height = 24;
            this.gv_result.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gv_result.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_result.Size = new System.Drawing.Size(119, 216);
            this.gv_result.Style = MetroFramework.MetroColorStyle.Teal;
            this.gv_result.TabIndex = 15;
            this.gv_result.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_result_CellDoubleClick);
            this.gv_result.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_result_CellMouseDown);
            // 
            // Kurzbezeichnung
            // 
            this.Kurzbezeichnung.HeaderText = "Kurzbezeichnung";
            this.Kurzbezeichnung.MinimumWidth = 6;
            this.Kurzbezeichnung.Name = "Kurzbezeichnung";
            this.Kurzbezeichnung.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // cm_result
            // 
            this.cm_result.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cm_result.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leistungskursAuswählenToolStripMenuItem});
            this.cm_result.Name = "metroContextMenu1";
            this.cm_result.Size = new System.Drawing.Size(239, 28);
            // 
            // leistungskursAuswählenToolStripMenuItem
            // 
            this.leistungskursAuswählenToolStripMenuItem.Name = "leistungskursAuswählenToolStripMenuItem";
            this.leistungskursAuswählenToolStripMenuItem.Size = new System.Drawing.Size(238, 24);
            this.leistungskursAuswählenToolStripMenuItem.Text = "Leistungskurs auswählen";
            this.leistungskursAuswählenToolStripMenuItem.Click += new System.EventHandler(this.leistungskursAuswählenToolStripMenuItem_Click);
            // 
            // gv_faecher
            // 
            this.gv_faecher.AllowUserToAddRows = false;
            this.gv_faecher.AllowUserToDeleteRows = false;
            this.gv_faecher.AllowUserToResizeRows = false;
            this.gv_faecher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_faecher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_faecher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_faecher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_faecher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_faecher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_faecher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_faecher.DefaultCellStyle = dataGridViewCellStyle5;
            this.gv_faecher.EnableHeadersVisualStyles = false;
            this.gv_faecher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_faecher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_faecher.Location = new System.Drawing.Point(3, 360);
            this.gv_faecher.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.gv_faecher.MultiSelect = false;
            this.gv_faecher.Name = "gv_faecher";
            this.gv_faecher.ReadOnly = true;
            this.gv_faecher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_faecher.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_faecher.RowHeadersVisible = false;
            this.gv_faecher.RowHeadersWidth = 51;
            this.gv_faecher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_faecher.RowTemplate.DividerHeight = 1;
            this.gv_faecher.RowTemplate.Height = 24;
            this.gv_faecher.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.gv_faecher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_faecher.Size = new System.Drawing.Size(160, 216);
            this.gv_faecher.Style = MetroFramework.MetroColorStyle.Teal;
            this.gv_faecher.TabIndex = 14;
            this.gv_faecher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_faecher_CellDoubleClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(323, 63);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(43, 20);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Filter:";
            // 
            // rb_alles
            // 
            this.rb_alles.AutoSize = true;
            this.rb_alles.Checked = true;
            this.rb_alles.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_alles.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_alles.Location = new System.Drawing.Point(3, 3);
            this.rb_alles.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.rb_alles.Name = "rb_alles";
            this.rb_alles.Size = new System.Drawing.Size(115, 20);
            this.rb_alles.Style = MetroFramework.MetroColorStyle.Teal;
            this.rb_alles.TabIndex = 45;
            this.rb_alles.TabStop = true;
            this.rb_alles.Text = "Alles anzeigen";
            this.rb_alles.UseSelectable = true;
            this.rb_alles.CheckedChanged += new System.EventHandler(this.rb_alles_CheckedChanged);
            // 
            // rb_schueler
            // 
            this.rb_schueler.AutoSize = true;
            this.rb_schueler.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_schueler.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_schueler.Location = new System.Drawing.Point(146, 3);
            this.rb_schueler.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.rb_schueler.Name = "rb_schueler";
            this.rb_schueler.Size = new System.Drawing.Size(157, 20);
            this.rb_schueler.Style = MetroFramework.MetroColorStyle.Teal;
            this.rb_schueler.TabIndex = 45;
            this.rb_schueler.Text = "nur Schüler anzeigen";
            this.rb_schueler.UseSelectable = true;
            this.rb_schueler.CheckedChanged += new System.EventHandler(this.rb_alles_CheckedChanged);
            // 
            // rb_andere
            // 
            this.rb_andere.AutoSize = true;
            this.rb_andere.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_andere.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_andere.Location = new System.Drawing.Point(327, 3);
            this.rb_andere.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.rb_andere.Name = "rb_andere";
            this.rb_andere.Size = new System.Drawing.Size(172, 20);
            this.rb_andere.Style = MetroFramework.MetroColorStyle.Teal;
            this.rb_andere.TabIndex = 45;
            this.rb_andere.Text = "alle Schüler ausblenden";
            this.rb_andere.UseSelectable = true;
            this.rb_andere.CheckedChanged += new System.EventHandler(this.rb_alles_CheckedChanged);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.rb_schueler);
            this.metroPanel2.Controls.Add(this.rb_andere);
            this.metroPanel2.Controls.Add(this.rb_alles);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(319, 88);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(858, 31);
            this.metroPanel2.TabIndex = 46;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // bt_cleanup
            // 
            this.bt_cleanup.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_cleanup.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_cleanup.Location = new System.Drawing.Point(323, 703);
            this.bt_cleanup.Name = "bt_cleanup";
            this.bt_cleanup.Size = new System.Drawing.Size(175, 24);
            this.bt_cleanup.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_cleanup.TabIndex = 19;
            this.bt_cleanup.Text = "Schülerdaten-Cleanup";
            this.bt_cleanup.UseSelectable = true;
            this.bt_cleanup.Click += new System.EventHandler(this.bt_cleanup_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker1_RunWorkerCompleted);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.BackColor = System.Drawing.Color.White;
            this.metroProgressSpinner1.Location = new System.Drawing.Point(469, 125);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(572, 572);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroProgressSpinner1.TabIndex = 48;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // w_s_Kunden
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Controls.Add(this.metroProgressSpinner1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.bt_cleanup);
            this.Controls.Add(this.bt_ImEx);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.rb_KundeLoeschen);
            this.Controls.Add(this.gv_Kunde);
            this.Controls.Add(this.rb_KundeBearbeiten);
            this.Controls.Add(this.rb_Neukunde);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_Kunden";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Kundenverwaltung";
            this.Activated += new System.EventHandler(this.w_s_kunden_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).EndInit();
            this.cm_kunde.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_result)).EndInit();
            this.cm_result.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_faecher)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lb_Telefonnummer;
        private MetroFramework.Controls.MetroTextBox tb_Telefonnummer;
        private MetroFramework.Controls.MetroButton bt_OK;
        private MetroFramework.Controls.MetroButton bt_confirm;
        private MetroFramework.Controls.MetroRadioButton rb_KundeLoeschen;
        private MetroFramework.Controls.MetroRadioButton rb_KundeBearbeiten;
        private MetroFramework.Controls.MetroButton bt_clear;
        private MetroFramework.Controls.MetroTextBox lb_kunde_add;
        private MetroFramework.Controls.MetroGrid gv_Kunde;
        private MetroFramework.Controls.MetroRadioButton rb_Neukunde;
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroLabel lb_Vorname;
        private MetroFramework.Controls.MetroLabel lb_Nachname;
        private MetroFramework.Controls.MetroTextBox tb_KundenID;
        private MetroFramework.Controls.MetroLabel lb_Strasse;
        private MetroFramework.Controls.MetroLabel lb_Hausnummer;
        private MetroFramework.Controls.MetroLabel lb_Postleitzahl;
        private MetroFramework.Controls.MetroTextBox tb_Nachname;
        private MetroFramework.Controls.MetroLabel lb_Ort;
        private MetroFramework.Controls.MetroTextBox tb_Vorname;
        private MetroFramework.Controls.MetroTextBox tb_Strasse;
        private MetroFramework.Controls.MetroLabel lb_Klasse;
        private MetroFramework.Controls.MetroTextBox tb_Mail;
        private MetroFramework.Controls.MetroLabel lb_Mail;
        private MetroFramework.Controls.MetroTextBox tb_Hausnummer;
        private MetroFramework.Controls.MetroTextBox tb_Klasse;
        private MetroFramework.Controls.MetroTextBox tb_Postleitzahl;
        private MetroFramework.Controls.MetroTextBox tb_Ort;
        private MetroFramework.Controls.MetroLabel lb_KundenID;
        private MetroFramework.Controls.MetroButton bt_ImEx;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lb_geburtsdatum;
        private MetroFramework.Controls.MetroGrid gv_faecher;
        private MetroFramework.Controls.MetroGrid gv_result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kurzbezeichnung;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private MetroFramework.Controls.MetroContextMenu cm_result;
        private System.Windows.Forms.ToolStripMenuItem leistungskursAuswählenToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lb_faecher;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroRadioButton rb_alles;
        private MetroFramework.Controls.MetroRadioButton rb_schueler;
        private MetroFramework.Controls.MetroRadioButton rb_andere;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroContextMenu cm_kunde;
        private System.Windows.Forms.ToolStripMenuItem kundeBearbeitenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kundeEntfernenToolStripMenuItem;
        private MetroFramework.Controls.MetroButton bt_cleanup;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
        private MetroFramework.Controls.MetroDateTime dTP_gd;
        private System.Windows.Forms.Timer timer1;
    }
}