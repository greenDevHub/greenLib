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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_buchsuche));
            this.gv_buchsuche = new MetroFramework.Controls.MetroGrid();
            this.cb_KundeAnz = new MetroFramework.Controls.MetroCheckBox();
            this.cb_Verfügbar_Anz = new MetroFramework.Controls.MetroCheckBox();
            this.bt_Ausleihen = new MetroFramework.Controls.MetroButton();
            this.tb_ExemplarID = new MetroFramework.Controls.MetroTextBox();
            this.tb_ISBN = new MetroFramework.Controls.MetroTextBox();
            this.tb_Titel = new MetroFramework.Controls.MetroTextBox();
            this.tb_nachname = new MetroFramework.Controls.MetroTextBox();
            this.tb_vorname = new MetroFramework.Controls.MetroTextBox();
            this.bt_Clear = new MetroFramework.Controls.MetroButton();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.tb_klasse = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.cb_Verlag = new Bibo_Verwaltung.AdvancedComboBox();
            this.cb_Genre = new Bibo_Verwaltung.AdvancedComboBox();
            this.cb_Autor = new Bibo_Verwaltung.AdvancedComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.bt_Schliessen = new MetroFramework.Controls.MetroButton();
            this.lb_ISBN = new MetroFramework.Controls.MetroLabel();
            this.lb_Titel = new MetroFramework.Controls.MetroLabel();
            this.lb_Genre = new MetroFramework.Controls.MetroLabel();
            this.lb_Verlag = new MetroFramework.Controls.MetroLabel();
            this.lb_Autor = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gv_buchsuche)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_buchsuche
            // 
            this.gv_buchsuche.AllowUserToAddRows = false;
            this.gv_buchsuche.AllowUserToDeleteRows = false;
            this.gv_buchsuche.AllowUserToResizeColumns = false;
            this.gv_buchsuche.AllowUserToResizeRows = false;
            this.gv_buchsuche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_buchsuche.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_buchsuche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_buchsuche.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_buchsuche.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_buchsuche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_buchsuche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_buchsuche.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_buchsuche.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_buchsuche.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_buchsuche.EnableHeadersVisualStyles = false;
            this.gv_buchsuche.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_buchsuche.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.gv_buchsuche, "In diesem Feld werden all ihre Bücher und evtl. vorhandene Ausleihvorgänge angeze" +
        "igt.");
            this.gv_buchsuche.Location = new System.Drawing.Point(0, 0);
            this.gv_buchsuche.MultiSelect = false;
            this.gv_buchsuche.Name = "gv_buchsuche";
            this.gv_buchsuche.ReadOnly = true;
            this.gv_buchsuche.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_buchsuche.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_buchsuche.RowHeadersWidth = 35;
            this.gv_buchsuche.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_buchsuche.RowTemplate.DividerHeight = 1;
            this.gv_buchsuche.RowTemplate.Height = 24;
            this.gv_buchsuche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_buchsuche.ShowEditingIcon = false;
            this.helpProvider.SetShowHelp(this.gv_buchsuche, true);
            this.gv_buchsuche.Size = new System.Drawing.Size(704, 484);
            this.gv_buchsuche.Style = MetroFramework.MetroColorStyle.Lime;
            this.gv_buchsuche.TabIndex = 0;
            this.gv_buchsuche.VirtualMode = true;
            this.gv_buchsuche.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_buchsuche_ColumnHeaderMouseClick);
            // 
            // cb_KundeAnz
            // 
            this.cb_KundeAnz.AutoSize = true;
            this.cb_KundeAnz.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cb_KundeAnz.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.cb_KundeAnz, "Setzen sie einen Haken in dieses Feld, werden ihnen im obenliegenden Feld Kundeni" +
        "nformationen bei ausgeliehenen Büchern angezeigt.");
            this.cb_KundeAnz.Location = new System.Drawing.Point(3, 395);
            this.cb_KundeAnz.Name = "cb_KundeAnz";
            this.helpProvider.SetShowHelp(this.cb_KundeAnz, true);
            this.cb_KundeAnz.Size = new System.Drawing.Size(218, 19);
            this.cb_KundeAnz.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_KundeAnz.TabIndex = 1;
            this.cb_KundeAnz.Text = "Kundeninformationen einblenden";
            this.cb_KundeAnz.UseSelectable = true;
            this.cb_KundeAnz.CheckedChanged += new System.EventHandler(this.cb_KundeAnz_CheckedChanged);
            // 
            // cb_Verfügbar_Anz
            // 
            this.cb_Verfügbar_Anz.AutoSize = true;
            this.cb_Verfügbar_Anz.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cb_Verfügbar_Anz.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.cb_Verfügbar_Anz, "Setzen sie einen Haken in dieses Feld, werden ihnen nur Bücher angezeigt, welche " +
        "verliehen werden können.");
            this.cb_Verfügbar_Anz.Location = new System.Drawing.Point(3, 370);
            this.cb_Verfügbar_Anz.Name = "cb_Verfügbar_Anz";
            this.helpProvider.SetShowHelp(this.cb_Verfügbar_Anz, true);
            this.cb_Verfügbar_Anz.Size = new System.Drawing.Size(242, 19);
            this.cb_Verfügbar_Anz.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_Verfügbar_Anz.TabIndex = 2;
            this.cb_Verfügbar_Anz.Text = "Nur verleihbereite Bücher einblenden";
            this.cb_Verfügbar_Anz.UseSelectable = true;
            this.cb_Verfügbar_Anz.CheckedChanged += new System.EventHandler(this.cb_Verfügbar_Anz_CheckedChanged);
            // 
            // bt_Ausleihen
            // 
            this.bt_Ausleihen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Ausleihen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Ausleihen, "Klicken sie auf diesen Button, nachdem sie ein Buch im obenliegenden Feld makiert" +
        " haben, um dieses gewählte Buch auszuleihen.");
            this.bt_Ausleihen.Location = new System.Drawing.Point(3, 420);
            this.bt_Ausleihen.Name = "bt_Ausleihen";
            this.helpProvider.SetShowHelp(this.bt_Ausleihen, true);
            this.bt_Ausleihen.Size = new System.Drawing.Size(216, 24);
            this.bt_Ausleihen.Style = MetroFramework.MetroColorStyle.Lime;
            this.bt_Ausleihen.TabIndex = 11;
            this.bt_Ausleihen.Text = "Ausleihvorgang starten";
            this.bt_Ausleihen.UseSelectable = true;
            this.bt_Ausleihen.Click += new System.EventHandler(this.Ausleihvorgang);
            // 
            // tb_ExemplarID
            // 
            // 
            // 
            // 
            this.tb_ExemplarID.CustomButton.Image = null;
            this.tb_ExemplarID.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.tb_ExemplarID.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ExemplarID.CustomButton.Name = "";
            this.tb_ExemplarID.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_ExemplarID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ExemplarID.CustomButton.TabIndex = 1;
            this.tb_ExemplarID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ExemplarID.CustomButton.UseSelectable = true;
            this.tb_ExemplarID.CustomButton.Visible = false;
            this.tb_ExemplarID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_ExemplarID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_ExemplarID, "Tragen sie hier die Buch-ID ein, um das gewünschte Buch zu laden.");
            this.tb_ExemplarID.Lines = new string[0];
            this.tb_ExemplarID.Location = new System.Drawing.Point(154, 3);
            this.tb_ExemplarID.MaxLength = 32767;
            this.tb_ExemplarID.Name = "tb_ExemplarID";
            this.tb_ExemplarID.PasswordChar = '\0';
            this.tb_ExemplarID.PromptText = "ExemplarID";
            this.tb_ExemplarID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ExemplarID.SelectedText = "";
            this.tb_ExemplarID.SelectionLength = 0;
            this.tb_ExemplarID.SelectionStart = 0;
            this.tb_ExemplarID.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_ExemplarID, true);
            this.tb_ExemplarID.Size = new System.Drawing.Size(281, 24);
            this.tb_ExemplarID.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_ExemplarID.TabIndex = 36;
            this.tb_ExemplarID.UseSelectable = true;
            this.tb_ExemplarID.WaterMark = "ExemplarID";
            this.tb_ExemplarID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ExemplarID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_ExemplarID.TextChanged += new System.EventHandler(this.tb_ExemplarID_TextChanged);
            this.tb_ExemplarID.Click += new System.EventHandler(this.tb_ExemplarID_Click);
            this.tb_ExemplarID.Enter += new System.EventHandler(this.tb_ExemplarID_Enter);
            this.tb_ExemplarID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ExemplarID_KeyPress);
            this.tb_ExemplarID.Leave += new System.EventHandler(this.tb_ExemplarID_Leave);
            // 
            // tb_ISBN
            // 
            // 
            // 
            // 
            this.tb_ISBN.CustomButton.Image = null;
            this.tb_ISBN.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.tb_ISBN.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_ISBN.CustomButton.Name = "";
            this.tb_ISBN.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_ISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ISBN.CustomButton.TabIndex = 1;
            this.tb_ISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ISBN.CustomButton.UseSelectable = true;
            this.tb_ISBN.CustomButton.Visible = false;
            this.tb_ISBN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_ISBN.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpKeyword(this.tb_ISBN, "");
            this.helpProvider.SetHelpString(this.tb_ISBN, "Tragen sie hier die ISBN-13 ein, um das ausgeliehene Buch zu laden.");
            this.tb_ISBN.Lines = new string[0];
            this.tb_ISBN.Location = new System.Drawing.Point(154, 33);
            this.tb_ISBN.MaxLength = 32767;
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.PasswordChar = '\0';
            this.tb_ISBN.PromptText = "ISBN";
            this.tb_ISBN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ISBN.SelectedText = "";
            this.tb_ISBN.SelectionLength = 0;
            this.tb_ISBN.SelectionStart = 0;
            this.tb_ISBN.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_ISBN, true);
            this.tb_ISBN.Size = new System.Drawing.Size(281, 24);
            this.tb_ISBN.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_ISBN.TabIndex = 35;
            this.tb_ISBN.UseSelectable = true;
            this.tb_ISBN.WaterMark = "ISBN";
            this.tb_ISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            this.tb_ISBN.Enter += new System.EventHandler(this.tb_ISBN_Enter);
            this.tb_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            this.tb_ISBN.Leave += new System.EventHandler(this.tb_ISBN_Leave);
            // 
            // tb_Titel
            // 
            // 
            // 
            // 
            this.tb_Titel.CustomButton.Image = null;
            this.tb_Titel.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.tb_Titel.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Titel.CustomButton.Name = "";
            this.tb_Titel.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Titel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Titel.CustomButton.TabIndex = 1;
            this.tb_Titel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Titel.CustomButton.UseSelectable = true;
            this.tb_Titel.CustomButton.Visible = false;
            this.tb_Titel.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_Titel.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_Titel, "Tragen sie hier den Buchtitel ein, um das ausgeliehene Buch zu laden.");
            this.tb_Titel.Lines = new string[0];
            this.tb_Titel.Location = new System.Drawing.Point(154, 63);
            this.tb_Titel.MaxLength = 32767;
            this.tb_Titel.Name = "tb_Titel";
            this.tb_Titel.PasswordChar = '\0';
            this.tb_Titel.PromptText = "Titel";
            this.tb_Titel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Titel.SelectedText = "";
            this.tb_Titel.SelectionLength = 0;
            this.tb_Titel.SelectionStart = 0;
            this.tb_Titel.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Titel, true);
            this.tb_Titel.Size = new System.Drawing.Size(281, 24);
            this.tb_Titel.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_Titel.TabIndex = 17;
            this.tb_Titel.UseSelectable = true;
            this.tb_Titel.WaterMark = "Titel";
            this.tb_Titel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Titel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_Titel.TextChanged += new System.EventHandler(this.tb_Titel_TextChanged);
            this.tb_Titel.Enter += new System.EventHandler(this.tb_Titel_Enter);
            this.tb_Titel.Leave += new System.EventHandler(this.tb_Titel_Leave);
            // 
            // tb_nachname
            // 
            // 
            // 
            // 
            this.tb_nachname.CustomButton.Image = null;
            this.tb_nachname.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.tb_nachname.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_nachname.CustomButton.Name = "";
            this.tb_nachname.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_nachname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_nachname.CustomButton.TabIndex = 1;
            this.tb_nachname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_nachname.CustomButton.UseSelectable = true;
            this.tb_nachname.CustomButton.Visible = false;
            this.tb_nachname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_nachname.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_nachname, "Tragen sie hier den Nachnamen des gesuchten Kunden ein, welcher einen Ausleihvorg" +
        "ang getätigt hat.");
            this.tb_nachname.Lines = new string[0];
            this.tb_nachname.Location = new System.Drawing.Point(154, 34);
            this.tb_nachname.MaxLength = 32767;
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.PasswordChar = '\0';
            this.tb_nachname.PromptText = "Nachname";
            this.tb_nachname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_nachname.SelectedText = "";
            this.tb_nachname.SelectionLength = 0;
            this.tb_nachname.SelectionStart = 0;
            this.tb_nachname.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_nachname, true);
            this.tb_nachname.Size = new System.Drawing.Size(281, 24);
            this.tb_nachname.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_nachname.TabIndex = 31;
            this.tb_nachname.UseSelectable = true;
            this.tb_nachname.WaterMark = "Nachname";
            this.tb_nachname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_nachname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_nachname.TextChanged += new System.EventHandler(this.tb_nachname_TextChanged);
            this.tb_nachname.Enter += new System.EventHandler(this.tb_nachname_Enter);
            this.tb_nachname.Leave += new System.EventHandler(this.tb_nachname_Leave);
            // 
            // tb_vorname
            // 
            // 
            // 
            // 
            this.tb_vorname.CustomButton.Image = null;
            this.tb_vorname.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.tb_vorname.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_vorname.CustomButton.Name = "";
            this.tb_vorname.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_vorname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_vorname.CustomButton.TabIndex = 1;
            this.tb_vorname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_vorname.CustomButton.UseSelectable = true;
            this.tb_vorname.CustomButton.Visible = false;
            this.tb_vorname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_vorname.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_vorname, "Tragen sie hier den Vornamen des gesuchten Kunden ein, welcher einen Ausleihvorga" +
        "ng getätigt hat.");
            this.tb_vorname.Lines = new string[0];
            this.tb_vorname.Location = new System.Drawing.Point(154, 3);
            this.tb_vorname.MaxLength = 32767;
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.PasswordChar = '\0';
            this.tb_vorname.PromptText = "Vorname";
            this.tb_vorname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_vorname.SelectedText = "";
            this.tb_vorname.SelectionLength = 0;
            this.tb_vorname.SelectionStart = 0;
            this.tb_vorname.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_vorname, true);
            this.tb_vorname.Size = new System.Drawing.Size(281, 24);
            this.tb_vorname.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_vorname.TabIndex = 30;
            this.tb_vorname.UseSelectable = true;
            this.tb_vorname.WaterMark = "Vorname";
            this.tb_vorname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_vorname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_vorname.TextChanged += new System.EventHandler(this.tb_vorname_TextChanged);
            this.tb_vorname.Enter += new System.EventHandler(this.tb_vorname_Enter);
            this.tb_vorname.Leave += new System.EventHandler(this.tb_vorname_Leave);
            // 
            // bt_Clear
            // 
            this.bt_Clear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Clear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Clear, "Leeren sie alle linksseitig liegenden Textfelder.");
            this.bt_Clear.Location = new System.Drawing.Point(225, 420);
            this.bt_Clear.Name = "bt_Clear";
            this.helpProvider.SetShowHelp(this.bt_Clear, true);
            this.bt_Clear.Size = new System.Drawing.Size(216, 24);
            this.bt_Clear.Style = MetroFramework.MetroColorStyle.Lime;
            this.bt_Clear.TabIndex = 26;
            this.bt_Clear.Text = "Filter löschen";
            this.bt_Clear.UseSelectable = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // tb_klasse
            // 
            // 
            // 
            // 
            this.tb_klasse.CustomButton.Image = null;
            this.tb_klasse.CustomButton.Location = new System.Drawing.Point(259, 2);
            this.tb_klasse.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_klasse.CustomButton.Name = "";
            this.tb_klasse.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_klasse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_klasse.CustomButton.TabIndex = 1;
            this.tb_klasse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_klasse.CustomButton.UseSelectable = true;
            this.tb_klasse.CustomButton.Visible = false;
            this.tb_klasse.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_klasse.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_klasse, "Tragen sie hier den Vornamen des gesuchten Kunden ein, welcher einen Ausleihvorga" +
        "ng getätigt hat.");
            this.tb_klasse.Lines = new string[0];
            this.tb_klasse.Location = new System.Drawing.Point(154, 65);
            this.tb_klasse.MaxLength = 32767;
            this.tb_klasse.Name = "tb_klasse";
            this.tb_klasse.PasswordChar = '\0';
            this.tb_klasse.PromptText = "Klassenstufe";
            this.tb_klasse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_klasse.SelectedText = "";
            this.tb_klasse.SelectionLength = 0;
            this.tb_klasse.SelectionStart = 0;
            this.tb_klasse.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_klasse, true);
            this.tb_klasse.Size = new System.Drawing.Size(281, 24);
            this.tb_klasse.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_klasse.TabIndex = 32;
            this.tb_klasse.UseSelectable = true;
            this.tb_klasse.WaterMark = "Klassenstufe";
            this.tb_klasse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_klasse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_klasse.TextChanged += new System.EventHandler(this.tb_klasse_TextChanged);
            this.tb_klasse.Enter += new System.EventHandler(this.tb_klasse_Enter);
            this.tb_klasse.Leave += new System.EventHandler(this.tb_klasse_Leave);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.lb_ISBN);
            this.metroPanel1.Controls.Add(this.lb_Titel);
            this.metroPanel1.Controls.Add(this.lb_Genre);
            this.metroPanel1.Controls.Add(this.lb_Verlag);
            this.metroPanel1.Controls.Add(this.lb_Autor);
            this.metroPanel1.Controls.Add(this.cb_Verlag);
            this.metroPanel1.Controls.Add(this.cb_Genre);
            this.metroPanel1.Controls.Add(this.tb_ExemplarID);
            this.metroPanel1.Controls.Add(this.cb_Autor);
            this.metroPanel1.Controls.Add(this.tb_ISBN);
            this.metroPanel1.Controls.Add(this.tb_Titel);
            this.helpProvider.SetHelpString(this.metroPanel1, resources.GetString("metroPanel1.HelpString"));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(2, 25);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.helpProvider.SetShowHelp(this.metroPanel1, true);
            this.metroPanel1.Size = new System.Drawing.Size(440, 185);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPanel1.TabIndex = 37;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // cb_Verlag
            // 
            this.cb_Verlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Verlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Verlag.DataRowView = true;
            this.cb_Verlag.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Verlag.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Verlag.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cb_Verlag.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Verlag, "Tragen sie hier den Verlag ein, um das ausgeliehene Buch zu laden.");
            this.cb_Verlag.HighlightColor = System.Drawing.Color.YellowGreen;
            this.cb_Verlag.ItemHeight = 18;
            this.cb_Verlag.Location = new System.Drawing.Point(154, 123);
            this.cb_Verlag.Name = "cb_Verlag";
            this.helpProvider.SetShowHelp(this.cb_Verlag, true);
            this.cb_Verlag.Size = new System.Drawing.Size(281, 24);
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
            this.cb_Genre.DataRowView = true;
            this.cb_Genre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Genre.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Genre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cb_Genre.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Genre, "Tragen sie hier das Genre ein, um das ausgeliehene Buch zu laden.");
            this.cb_Genre.HighlightColor = System.Drawing.Color.YellowGreen;
            this.cb_Genre.ItemHeight = 18;
            this.cb_Genre.Location = new System.Drawing.Point(154, 153);
            this.cb_Genre.Name = "cb_Genre";
            this.helpProvider.SetShowHelp(this.cb_Genre, true);
            this.cb_Genre.Size = new System.Drawing.Size(281, 24);
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
            this.cb_Autor.DataRowView = true;
            this.cb_Autor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Autor.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Autor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cb_Autor.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Autor, "Tragen sie hier den Buchautor ein, um das ausgeliehene Buch zu laden.");
            this.cb_Autor.HighlightColor = System.Drawing.Color.YellowGreen;
            this.cb_Autor.ItemHeight = 18;
            this.cb_Autor.Location = new System.Drawing.Point(154, 93);
            this.cb_Autor.Name = "cb_Autor";
            this.helpProvider.SetShowHelp(this.cb_Autor, true);
            this.cb_Autor.Size = new System.Drawing.Size(281, 24);
            this.cb_Autor.Sorted = true;
            this.cb_Autor.TabIndex = 27;
            this.cb_Autor.Text = "Autor";
            this.cb_Autor.TextChanged += new System.EventHandler(this.cb_Autor_TextChanged);
            this.cb_Autor.Enter += new System.EventHandler(this.cb_Autor_Enter);
            this.cb_Autor.Leave += new System.EventHandler(this.cb_Autor_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.helpProvider.SetHelpString(this.metroLabel1, resources.GetString("metroLabel1.HelpString"));
            this.metroLabel1.Location = new System.Drawing.Point(2, 3);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.helpProvider.SetShowHelp(this.metroLabel1, true);
            this.metroLabel1.Size = new System.Drawing.Size(207, 19);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "Suchen nach Bucheigenschaften:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroLabel6);
            this.metroPanel2.Controls.Add(this.tb_klasse);
            this.metroPanel2.Controls.Add(this.tb_nachname);
            this.metroPanel2.Controls.Add(this.tb_vorname);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 8;
            this.metroPanel2.Location = new System.Drawing.Point(2, 238);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(440, 126);
            this.metroPanel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPanel2.TabIndex = 39;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 8;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(2, 216);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(224, 19);
            this.metroLabel2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroLabel2.TabIndex = 38;
            this.metroLabel2.Text = "Suchen nach Kundeneigenschaften:";
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this.gv_buchsuche);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(473, 63);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(704, 484);
            this.metroPanel3.TabIndex = 40;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroPanel2);
            this.metroPanel4.Controls.Add(this.bt_Ausleihen);
            this.metroPanel4.Controls.Add(this.bt_Clear);
            this.metroPanel4.Controls.Add(this.metroLabel1);
            this.metroPanel4.Controls.Add(this.cb_KundeAnz);
            this.metroPanel4.Controls.Add(this.cb_Verfügbar_Anz);
            this.metroPanel4.Controls.Add(this.metroLabel2);
            this.metroPanel4.Controls.Add(this.metroPanel1);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(23, 63);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(444, 514);
            this.metroPanel4.TabIndex = 41;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // bt_Schliessen
            // 
            this.bt_Schliessen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Schliessen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Schliessen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Schliessen, "Schließen sie das akuelle Fenster.");
            this.bt_Schliessen.Location = new System.Drawing.Point(828, 553);
            this.bt_Schliessen.MaximumSize = new System.Drawing.Size(375, 24);
            this.bt_Schliessen.MinimumSize = new System.Drawing.Size(262, 24);
            this.bt_Schliessen.Name = "bt_Schliessen";
            this.helpProvider.SetShowHelp(this.bt_Schliessen, true);
            this.bt_Schliessen.Size = new System.Drawing.Size(349, 24);
            this.bt_Schliessen.TabIndex = 43;
            this.bt_Schliessen.Text = "Schließen";
            this.bt_Schliessen.UseSelectable = true;
            // 
            // lb_ISBN
            // 
            this.lb_ISBN.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_ISBN, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.lb_ISBN.Location = new System.Drawing.Point(3, 3);
            this.lb_ISBN.Margin = new System.Windows.Forms.Padding(3);
            this.lb_ISBN.Name = "lb_ISBN";
            this.helpProvider.SetShowHelp(this.lb_ISBN, true);
            this.lb_ISBN.Size = new System.Drawing.Size(84, 19);
            this.lb_ISBN.TabIndex = 37;
            this.lb_ISBN.Text = "Exemplar-ID:";
            // 
            // lb_Titel
            // 
            this.lb_Titel.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Titel, "Tragen sie den Titel ihres Buches hier ein.");
            this.lb_Titel.Location = new System.Drawing.Point(3, 33);
            this.lb_Titel.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Titel.Name = "lb_Titel";
            this.helpProvider.SetShowHelp(this.lb_Titel, true);
            this.lb_Titel.Size = new System.Drawing.Size(40, 19);
            this.lb_Titel.TabIndex = 38;
            this.lb_Titel.Text = "ISBN:";
            // 
            // lb_Genre
            // 
            this.lb_Genre.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Genre, "Tragen sie das Genre ihres Buches hier ein.");
            this.lb_Genre.Location = new System.Drawing.Point(3, 93);
            this.lb_Genre.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Genre.Name = "lb_Genre";
            this.helpProvider.SetShowHelp(this.lb_Genre, true);
            this.lb_Genre.Size = new System.Drawing.Size(42, 19);
            this.lb_Genre.TabIndex = 39;
            this.lb_Genre.Text = "Autor";
            // 
            // lb_Verlag
            // 
            this.lb_Verlag.AutoSize = true;
            this.helpProvider.SetHelpKeyword(this.lb_Verlag, "Tragen sie den Verlag ihres Buches hier ein.");
            this.lb_Verlag.Location = new System.Drawing.Point(3, 123);
            this.lb_Verlag.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Verlag.Name = "lb_Verlag";
            this.helpProvider.SetShowHelp(this.lb_Verlag, true);
            this.lb_Verlag.Size = new System.Drawing.Size(49, 19);
            this.lb_Verlag.TabIndex = 41;
            this.lb_Verlag.Text = "Verlag:";
            // 
            // lb_Autor
            // 
            this.lb_Autor.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Autor, "Tragen sie den Autor ihres Buches hier ein.");
            this.lb_Autor.Location = new System.Drawing.Point(3, 63);
            this.lb_Autor.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Autor.Name = "lb_Autor";
            this.helpProvider.SetShowHelp(this.lb_Autor, true);
            this.lb_Autor.Size = new System.Drawing.Size(36, 19);
            this.lb_Autor.TabIndex = 40;
            this.lb_Autor.Text = "Titel:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.helpProvider.SetHelpKeyword(this.metroLabel3, "Tragen sie den Verlag ihres Buches hier ein.");
            this.metroLabel3.Location = new System.Drawing.Point(3, 153);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.helpProvider.SetShowHelp(this.metroLabel3, true);
            this.metroLabel3.Size = new System.Drawing.Size(47, 19);
            this.metroLabel3.TabIndex = 42;
            this.metroLabel3.Text = "Genre:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.helpProvider.SetHelpString(this.metroLabel4, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.metroLabel4.Location = new System.Drawing.Point(3, 3);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.helpProvider.SetShowHelp(this.metroLabel4, true);
            this.metroLabel4.Size = new System.Drawing.Size(65, 19);
            this.metroLabel4.TabIndex = 41;
            this.metroLabel4.Text = "Vorname:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.helpProvider.SetHelpString(this.metroLabel5, "Tragen sie den Titel ihres Buches hier ein.");
            this.metroLabel5.Location = new System.Drawing.Point(3, 33);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel5.Name = "metroLabel5";
            this.helpProvider.SetShowHelp(this.metroLabel5, true);
            this.metroLabel5.Size = new System.Drawing.Size(75, 19);
            this.metroLabel5.TabIndex = 42;
            this.metroLabel5.Text = "Nachname:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.helpProvider.SetHelpString(this.metroLabel6, "Tragen sie den Autor ihres Buches hier ein.");
            this.metroLabel6.Location = new System.Drawing.Point(3, 63);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel6.Name = "metroLabel6";
            this.helpProvider.SetShowHelp(this.metroLabel6, true);
            this.metroLabel6.Size = new System.Drawing.Size(80, 19);
            this.metroLabel6.TabIndex = 43;
            this.metroLabel6.Text = "Klassenstufe:";
            // 
            // w_s_buchsuche
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.bt_Schliessen);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_buchsuche";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Buchübersicht";
            this.Activated += new System.EventHandler(this.w_s_buchsuche_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gv_buchsuche)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gv_buchsuche;
        private MetroFramework.Controls.MetroCheckBox cb_KundeAnz;
        private MetroFramework.Controls.MetroCheckBox cb_Verfügbar_Anz;
        private MetroFramework.Controls.MetroButton bt_Ausleihen;
        private MetroFramework.Controls.MetroTextBox tb_Titel;
        private MetroFramework.Controls.MetroButton bt_Clear;
        private AdvancedComboBox cb_Genre;
        private AdvancedComboBox cb_Autor;
        private AdvancedComboBox cb_Verlag;
        private MetroFramework.Controls.MetroTextBox tb_nachname;
        private MetroFramework.Controls.MetroTextBox tb_vorname;
        private MetroFramework.Controls.MetroTextBox tb_ISBN;
        private MetroFramework.Controls.MetroTextBox tb_ExemplarID;
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroTextBox tb_klasse;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroButton bt_Schliessen;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel lb_ISBN;
        private MetroFramework.Controls.MetroLabel lb_Titel;
        private MetroFramework.Controls.MetroLabel lb_Genre;
        private MetroFramework.Controls.MetroLabel lb_Verlag;
        private MetroFramework.Controls.MetroLabel lb_Autor;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
    }
}