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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_buchsuche));
            this.gv_buchsuche = new MetroFramework.Controls.MetroGrid();
            this.CM_Ausleihen = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.addToLeihList = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromLeihList = new System.Windows.Forms.ToolStripMenuItem();
            this.ausleihen = new System.Windows.Forms.ToolStripMenuItem();
            this.cb_KundeAnz = new MetroFramework.Controls.MetroCheckBox();
            this.cb_Verfügbar_Anz = new MetroFramework.Controls.MetroCheckBox();
            this.bt_Ausleihen = new MetroFramework.Controls.MetroButton();
            this.tb_ExemplarID = new MetroFramework.Controls.MetroTextBox();
            this.tb_ISBN = new MetroFramework.Controls.MetroTextBox();
            this.tb_Titel = new MetroFramework.Controls.MetroTextBox();
            this.tb_NName = new MetroFramework.Controls.MetroTextBox();
            this.tb_VName = new MetroFramework.Controls.MetroTextBox();
            this.bt_Clear = new MetroFramework.Controls.MetroButton();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.tb_Klasse = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lb_Genre = new MetroFramework.Controls.MetroLabel();
            this.lb_Exemplar = new MetroFramework.Controls.MetroLabel();
            this.lb_ISBN = new MetroFramework.Controls.MetroLabel();
            this.lb_Autor = new MetroFramework.Controls.MetroLabel();
            this.lb_Verlag = new MetroFramework.Controls.MetroLabel();
            this.lb_Titel = new MetroFramework.Controls.MetroLabel();
            this.lbBuchProp = new MetroFramework.Controls.MetroLabel();
            this.bt_Schliessen = new MetroFramework.Controls.MetroButton();
            this.lb_VName = new MetroFramework.Controls.MetroLabel();
            this.lb_NName = new MetroFramework.Controls.MetroLabel();
            this.lb_Klasse = new MetroFramework.Controls.MetroLabel();
            this.gb_Kunden = new MetroFramework.Controls.MetroPanel();
            this.lb_KundenProp = new MetroFramework.Controls.MetroLabel();
            this.gb_GridView = new MetroFramework.Controls.MetroPanel();
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.gb_Suche = new MetroFramework.Controls.MetroPanel();
            this.rb_Default = new MetroFramework.Controls.MetroRadioButton();
            this.rb_GREENonly = new MetroFramework.Controls.MetroRadioButton();
            this.rb_YELLOWonly = new MetroFramework.Controls.MetroRadioButton();
            this.rb_REDonly = new MetroFramework.Controls.MetroRadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cb_Verlag = new Bibo_Verwaltung.AdvancedComboBox();
            this.cb_Genre = new Bibo_Verwaltung.AdvancedComboBox();
            this.cb_Autor = new Bibo_Verwaltung.AdvancedComboBox();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            ((System.ComponentModel.ISupportInitialize)(this.gv_buchsuche)).BeginInit();
            this.CM_Ausleihen.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.gb_Kunden.SuspendLayout();
            this.gb_GridView.SuspendLayout();
            this.gb_Suche.SuspendLayout();
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
            this.gv_buchsuche.ContextMenuStrip = this.CM_Ausleihen;
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
            this.gv_buchsuche.Size = new System.Drawing.Size(866, 484);
            this.gv_buchsuche.Style = MetroFramework.MetroColorStyle.Lime;
            this.gv_buchsuche.TabIndex = 0;
            this.gv_buchsuche.VirtualMode = true;
            this.gv_buchsuche.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_buchsuche_CellMouseDown);
            this.gv_buchsuche.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_buchsuche_ColumnHeaderMouseClick);
            this.gv_buchsuche.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gv_buchsuche_MouseDown);
            // 
            // CM_Ausleihen
            // 
            this.CM_Ausleihen.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.CM_Ausleihen.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToLeihList,
            this.removeFromLeihList,
            this.ausleihen});
            this.CM_Ausleihen.Name = "ContextMenu";
            this.CM_Ausleihen.Size = new System.Drawing.Size(281, 70);
            this.CM_Ausleihen.Style = MetroFramework.MetroColorStyle.Lime;
            // 
            // addToLeihList
            // 
            this.addToLeihList.Name = "addToLeihList";
            this.addToLeihList.Size = new System.Drawing.Size(280, 22);
            this.addToLeihList.Text = "Exemplar zur Ausleihliste hinzufügen";
            this.addToLeihList.Click += new System.EventHandler(this.addToLeihList_Click);
            // 
            // removeFromLeihList
            // 
            this.removeFromLeihList.Name = "removeFromLeihList";
            this.removeFromLeihList.Size = new System.Drawing.Size(280, 22);
            this.removeFromLeihList.Text = "Exemplar aus der Ausleihliste entfernen";
            this.removeFromLeihList.Click += new System.EventHandler(this.removeFromLeihList_Click);
            // 
            // ausleihen
            // 
            this.ausleihen.Name = "ausleihen";
            this.ausleihen.Size = new System.Drawing.Size(280, 22);
            this.ausleihen.Text = "Exemplar ausleihen";
            this.ausleihen.Click += new System.EventHandler(this.ausleihen_Click);
            // 
            // cb_KundeAnz
            // 
            this.cb_KundeAnz.AutoSize = true;
            this.cb_KundeAnz.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.cb_KundeAnz.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.cb_KundeAnz, "Setzen sie einen Haken in dieses Feld, werden ihnen im obenliegenden Feld Kundeni" +
        "nformationen bei ausgeliehenen Büchern angezeigt.");
            this.cb_KundeAnz.Location = new System.Drawing.Point(3, 361);
            this.cb_KundeAnz.Name = "cb_KundeAnz";
            this.helpProvider.SetShowHelp(this.cb_KundeAnz, true);
            this.cb_KundeAnz.Size = new System.Drawing.Size(218, 19);
            this.cb_KundeAnz.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_KundeAnz.TabIndex = 10;
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
            this.cb_Verfügbar_Anz.Location = new System.Drawing.Point(3, 336);
            this.cb_Verfügbar_Anz.Name = "cb_Verfügbar_Anz";
            this.helpProvider.SetShowHelp(this.cb_Verfügbar_Anz, true);
            this.cb_Verfügbar_Anz.Size = new System.Drawing.Size(242, 19);
            this.cb_Verfügbar_Anz.Style = MetroFramework.MetroColorStyle.Lime;
            this.cb_Verfügbar_Anz.TabIndex = 9;
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
            this.bt_Ausleihen.Location = new System.Drawing.Point(3, 486);
            this.bt_Ausleihen.Name = "bt_Ausleihen";
            this.helpProvider.SetShowHelp(this.bt_Ausleihen, true);
            this.bt_Ausleihen.Size = new System.Drawing.Size(175, 24);
            this.bt_Ausleihen.Style = MetroFramework.MetroColorStyle.Lime;
            this.bt_Ausleihen.TabIndex = 15;
            this.bt_Ausleihen.Text = "Zum Buchausleihe-Fenster";
            this.bt_Ausleihen.UseSelectable = true;
            this.bt_Ausleihen.Click += new System.EventHandler(this.Ausleihvorgang);
            // 
            // tb_ExemplarID
            // 
            // 
            // 
            // 
            this.tb_ExemplarID.CustomButton.Image = null;
            this.tb_ExemplarID.CustomButton.Location = new System.Drawing.Point(153, 2);
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
            this.tb_ExemplarID.Location = new System.Drawing.Point(93, 3);
            this.tb_ExemplarID.MaxLength = 32767;
            this.tb_ExemplarID.Name = "tb_ExemplarID";
            this.tb_ExemplarID.PasswordChar = '\0';
            this.tb_ExemplarID.PromptText = "Exemplar ID";
            this.tb_ExemplarID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ExemplarID.SelectedText = "";
            this.tb_ExemplarID.SelectionLength = 0;
            this.tb_ExemplarID.SelectionStart = 0;
            this.tb_ExemplarID.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_ExemplarID, true);
            this.tb_ExemplarID.Size = new System.Drawing.Size(175, 24);
            this.tb_ExemplarID.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_ExemplarID.TabIndex = 0;
            this.tb_ExemplarID.UseSelectable = true;
            this.tb_ExemplarID.WaterMark = "Exemplar ID";
            this.tb_ExemplarID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ExemplarID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tb_ExemplarID.TextChanged += new System.EventHandler(this.tb_ExemplarID_TextChanged);
            this.tb_ExemplarID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ExemplarID_KeyPress);
            // 
            // tb_ISBN
            // 
            // 
            // 
            // 
            this.tb_ISBN.CustomButton.Image = null;
            this.tb_ISBN.CustomButton.Location = new System.Drawing.Point(153, 2);
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
            this.tb_ISBN.Location = new System.Drawing.Point(93, 33);
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
            this.tb_ISBN.Size = new System.Drawing.Size(175, 24);
            this.tb_ISBN.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_ISBN.TabIndex = 1;
            this.tb_ISBN.UseSelectable = true;
            this.tb_ISBN.WaterMark = "ISBN";
            this.tb_ISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            this.tb_ISBN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            // 
            // tb_Titel
            // 
            // 
            // 
            // 
            this.tb_Titel.CustomButton.Image = null;
            this.tb_Titel.CustomButton.Location = new System.Drawing.Point(153, 2);
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
            this.tb_Titel.Location = new System.Drawing.Point(93, 63);
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
            this.tb_Titel.Size = new System.Drawing.Size(175, 24);
            this.tb_Titel.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_Titel.TabIndex = 2;
            this.tb_Titel.UseSelectable = true;
            this.tb_Titel.WaterMark = "Titel";
            this.tb_Titel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Titel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tb_Titel.TextChanged += new System.EventHandler(this.tb_Titel_TextChanged);
            // 
            // tb_NName
            // 
            // 
            // 
            // 
            this.tb_NName.CustomButton.Image = null;
            this.tb_NName.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_NName.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_NName.CustomButton.Name = "";
            this.tb_NName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_NName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_NName.CustomButton.TabIndex = 1;
            this.tb_NName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_NName.CustomButton.UseSelectable = true;
            this.tb_NName.CustomButton.Visible = false;
            this.tb_NName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_NName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_NName, "Tragen sie hier den Nachnamen des gesuchten Kunden ein, welcher einen Ausleihvorg" +
        "ang getätigt hat.");
            this.tb_NName.Lines = new string[0];
            this.tb_NName.Location = new System.Drawing.Point(93, 33);
            this.tb_NName.MaxLength = 32767;
            this.tb_NName.Name = "tb_NName";
            this.tb_NName.PasswordChar = '\0';
            this.tb_NName.PromptText = "Nachname";
            this.tb_NName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_NName.SelectedText = "";
            this.tb_NName.SelectionLength = 0;
            this.tb_NName.SelectionStart = 0;
            this.tb_NName.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_NName, true);
            this.tb_NName.Size = new System.Drawing.Size(175, 24);
            this.tb_NName.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_NName.TabIndex = 7;
            this.tb_NName.UseSelectable = true;
            this.tb_NName.WaterMark = "Nachname";
            this.tb_NName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_NName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tb_NName.TextChanged += new System.EventHandler(this.tb_nachname_TextChanged);
            // 
            // tb_VName
            // 
            // 
            // 
            // 
            this.tb_VName.CustomButton.Image = null;
            this.tb_VName.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_VName.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_VName.CustomButton.Name = "";
            this.tb_VName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_VName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_VName.CustomButton.TabIndex = 1;
            this.tb_VName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_VName.CustomButton.UseSelectable = true;
            this.tb_VName.CustomButton.Visible = false;
            this.tb_VName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_VName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_VName, "Tragen sie hier den Vornamen des gesuchten Kunden ein, welcher einen Ausleihvorga" +
        "ng getätigt hat.");
            this.tb_VName.Lines = new string[0];
            this.tb_VName.Location = new System.Drawing.Point(93, 3);
            this.tb_VName.MaxLength = 32767;
            this.tb_VName.Name = "tb_VName";
            this.tb_VName.PasswordChar = '\0';
            this.tb_VName.PromptText = "Vorname";
            this.tb_VName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_VName.SelectedText = "";
            this.tb_VName.SelectionLength = 0;
            this.tb_VName.SelectionStart = 0;
            this.tb_VName.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_VName, true);
            this.tb_VName.Size = new System.Drawing.Size(175, 24);
            this.tb_VName.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_VName.TabIndex = 6;
            this.tb_VName.UseSelectable = true;
            this.tb_VName.WaterMark = "Vorname";
            this.tb_VName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_VName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tb_VName.TextChanged += new System.EventHandler(this.tb_vorname_TextChanged);
            // 
            // bt_Clear
            // 
            this.bt_Clear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Clear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Clear, "Leeren sie alle linksseitig liegenden Textfelder.");
            this.bt_Clear.Location = new System.Drawing.Point(186, 486);
            this.bt_Clear.Name = "bt_Clear";
            this.helpProvider.SetShowHelp(this.bt_Clear, true);
            this.bt_Clear.Size = new System.Drawing.Size(93, 24);
            this.bt_Clear.Style = MetroFramework.MetroColorStyle.Lime;
            this.bt_Clear.TabIndex = 16;
            this.bt_Clear.Text = "Filter löschen";
            this.bt_Clear.UseSelectable = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // tb_Klasse
            // 
            // 
            // 
            // 
            this.tb_Klasse.CustomButton.Image = null;
            this.tb_Klasse.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_Klasse.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Klasse.CustomButton.Name = "";
            this.tb_Klasse.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Klasse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Klasse.CustomButton.TabIndex = 1;
            this.tb_Klasse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Klasse.CustomButton.UseSelectable = true;
            this.tb_Klasse.CustomButton.Visible = false;
            this.tb_Klasse.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_Klasse.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tb_Klasse, "Tragen sie hier den Vornamen des gesuchten Kunden ein, welcher einen Ausleihvorga" +
        "ng getätigt hat.");
            this.tb_Klasse.Lines = new string[0];
            this.tb_Klasse.Location = new System.Drawing.Point(93, 63);
            this.tb_Klasse.MaxLength = 32767;
            this.tb_Klasse.Name = "tb_Klasse";
            this.tb_Klasse.PasswordChar = '\0';
            this.tb_Klasse.PromptText = "Klassenstufe";
            this.tb_Klasse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Klasse.SelectedText = "";
            this.tb_Klasse.SelectionLength = 0;
            this.tb_Klasse.SelectionStart = 0;
            this.tb_Klasse.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Klasse, true);
            this.tb_Klasse.Size = new System.Drawing.Size(175, 24);
            this.tb_Klasse.Style = MetroFramework.MetroColorStyle.Lime;
            this.tb_Klasse.TabIndex = 8;
            this.tb_Klasse.UseSelectable = true;
            this.tb_Klasse.WaterMark = "Klassenstufe";
            this.tb_Klasse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Klasse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tb_Klasse.TextChanged += new System.EventHandler(this.tb_klasse_TextChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.metroProgressSpinner2);
            this.metroPanel1.Controls.Add(this.lb_Genre);
            this.metroPanel1.Controls.Add(this.lb_Exemplar);
            this.metroPanel1.Controls.Add(this.lb_ISBN);
            this.metroPanel1.Controls.Add(this.lb_Autor);
            this.metroPanel1.Controls.Add(this.lb_Verlag);
            this.metroPanel1.Controls.Add(this.lb_Titel);
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
            this.metroPanel1.Size = new System.Drawing.Size(278, 185);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPanel1.TabIndex = 37;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // lb_Genre
            // 
            this.helpProvider.SetHelpKeyword(this.lb_Genre, "Tragen sie den Verlag ihres Buches hier ein.");
            this.lb_Genre.Location = new System.Drawing.Point(3, 153);
            this.lb_Genre.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_Genre.Name = "lb_Genre";
            this.helpProvider.SetShowHelp(this.lb_Genre, true);
            this.lb_Genre.Size = new System.Drawing.Size(84, 24);
            this.lb_Genre.TabIndex = 42;
            this.lb_Genre.Text = "Genre:";
            this.lb_Genre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Exemplar
            // 
            this.helpProvider.SetHelpString(this.lb_Exemplar, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.lb_Exemplar.Location = new System.Drawing.Point(3, 3);
            this.lb_Exemplar.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_Exemplar.Name = "lb_Exemplar";
            this.helpProvider.SetShowHelp(this.lb_Exemplar, true);
            this.lb_Exemplar.Size = new System.Drawing.Size(84, 24);
            this.lb_Exemplar.TabIndex = 37;
            this.lb_Exemplar.Text = "Exemplar-ID:";
            this.lb_Exemplar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_ISBN
            // 
            this.helpProvider.SetHelpString(this.lb_ISBN, "Tragen sie den Titel ihres Buches hier ein.");
            this.lb_ISBN.Location = new System.Drawing.Point(3, 33);
            this.lb_ISBN.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_ISBN.Name = "lb_ISBN";
            this.helpProvider.SetShowHelp(this.lb_ISBN, true);
            this.lb_ISBN.Size = new System.Drawing.Size(84, 24);
            this.lb_ISBN.TabIndex = 38;
            this.lb_ISBN.Text = "ISBN:";
            this.lb_ISBN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Autor
            // 
            this.helpProvider.SetHelpString(this.lb_Autor, "Tragen sie das Genre ihres Buches hier ein.");
            this.lb_Autor.Location = new System.Drawing.Point(3, 93);
            this.lb_Autor.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_Autor.Name = "lb_Autor";
            this.helpProvider.SetShowHelp(this.lb_Autor, true);
            this.lb_Autor.Size = new System.Drawing.Size(84, 24);
            this.lb_Autor.TabIndex = 39;
            this.lb_Autor.Text = "Autor:";
            this.lb_Autor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Verlag
            // 
            this.helpProvider.SetHelpKeyword(this.lb_Verlag, "Tragen sie den Verlag ihres Buches hier ein.");
            this.lb_Verlag.Location = new System.Drawing.Point(3, 123);
            this.lb_Verlag.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_Verlag.Name = "lb_Verlag";
            this.helpProvider.SetShowHelp(this.lb_Verlag, true);
            this.lb_Verlag.Size = new System.Drawing.Size(84, 24);
            this.lb_Verlag.TabIndex = 41;
            this.lb_Verlag.Text = "Verlag:";
            this.lb_Verlag.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Titel
            // 
            this.helpProvider.SetHelpString(this.lb_Titel, "Tragen sie den Autor ihres Buches hier ein.");
            this.lb_Titel.Location = new System.Drawing.Point(3, 63);
            this.lb_Titel.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_Titel.Name = "lb_Titel";
            this.helpProvider.SetShowHelp(this.lb_Titel, true);
            this.lb_Titel.Size = new System.Drawing.Size(84, 24);
            this.lb_Titel.TabIndex = 40;
            this.lb_Titel.Text = "Titel:";
            this.lb_Titel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbBuchProp
            // 
            this.lbBuchProp.AutoSize = true;
            this.lbBuchProp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.helpProvider.SetHelpString(this.lbBuchProp, resources.GetString("lbBuchProp.HelpString"));
            this.lbBuchProp.Location = new System.Drawing.Point(2, 3);
            this.lbBuchProp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.lbBuchProp.Name = "lbBuchProp";
            this.helpProvider.SetShowHelp(this.lbBuchProp, true);
            this.lbBuchProp.Size = new System.Drawing.Size(207, 19);
            this.lbBuchProp.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbBuchProp.TabIndex = 38;
            this.lbBuchProp.Text = "Suchen nach Bucheigenschaften:";
            // 
            // bt_Schliessen
            // 
            this.bt_Schliessen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Schliessen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Schliessen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Schliessen, "Schließen sie das akuelle Fenster.");
            this.bt_Schliessen.Location = new System.Drawing.Point(1002, 553);
            this.bt_Schliessen.MaximumSize = new System.Drawing.Size(375, 24);
            this.bt_Schliessen.MinimumSize = new System.Drawing.Size(100, 24);
            this.bt_Schliessen.Name = "bt_Schliessen";
            this.helpProvider.SetShowHelp(this.bt_Schliessen, true);
            this.bt_Schliessen.Size = new System.Drawing.Size(175, 24);
            this.bt_Schliessen.TabIndex = 17;
            this.bt_Schliessen.Text = "Schließen";
            this.bt_Schliessen.UseSelectable = true;
            // 
            // lb_VName
            // 
            this.helpProvider.SetHelpString(this.lb_VName, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.lb_VName.Location = new System.Drawing.Point(3, 3);
            this.lb_VName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_VName.Name = "lb_VName";
            this.helpProvider.SetShowHelp(this.lb_VName, true);
            this.lb_VName.Size = new System.Drawing.Size(65, 24);
            this.lb_VName.TabIndex = 41;
            this.lb_VName.Text = "Vorname:";
            this.lb_VName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_NName
            // 
            this.helpProvider.SetHelpString(this.lb_NName, "Tragen sie den Titel ihres Buches hier ein.");
            this.lb_NName.Location = new System.Drawing.Point(3, 33);
            this.lb_NName.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_NName.Name = "lb_NName";
            this.helpProvider.SetShowHelp(this.lb_NName, true);
            this.lb_NName.Size = new System.Drawing.Size(75, 24);
            this.lb_NName.TabIndex = 42;
            this.lb_NName.Text = "Nachname:";
            this.lb_NName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Klasse
            // 
            this.helpProvider.SetHelpString(this.lb_Klasse, "Tragen sie den Autor ihres Buches hier ein.");
            this.lb_Klasse.Location = new System.Drawing.Point(3, 63);
            this.lb_Klasse.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.lb_Klasse.Name = "lb_Klasse";
            this.helpProvider.SetShowHelp(this.lb_Klasse, true);
            this.lb_Klasse.Size = new System.Drawing.Size(80, 24);
            this.lb_Klasse.TabIndex = 43;
            this.lb_Klasse.Text = "Klassenstufe:";
            this.lb_Klasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gb_Kunden
            // 
            this.gb_Kunden.Controls.Add(this.lb_VName);
            this.gb_Kunden.Controls.Add(this.lb_NName);
            this.gb_Kunden.Controls.Add(this.lb_Klasse);
            this.gb_Kunden.Controls.Add(this.tb_Klasse);
            this.gb_Kunden.Controls.Add(this.tb_NName);
            this.gb_Kunden.Controls.Add(this.tb_VName);
            this.gb_Kunden.HorizontalScrollbarBarColor = true;
            this.gb_Kunden.HorizontalScrollbarHighlightOnWheel = false;
            this.gb_Kunden.HorizontalScrollbarSize = 8;
            this.gb_Kunden.Location = new System.Drawing.Point(2, 238);
            this.gb_Kunden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gb_Kunden.Name = "gb_Kunden";
            this.gb_Kunden.Size = new System.Drawing.Size(278, 92);
            this.gb_Kunden.Style = MetroFramework.MetroColorStyle.Lime;
            this.gb_Kunden.TabIndex = 39;
            this.gb_Kunden.VerticalScrollbarBarColor = true;
            this.gb_Kunden.VerticalScrollbarHighlightOnWheel = false;
            this.gb_Kunden.VerticalScrollbarSize = 8;
            // 
            // lb_KundenProp
            // 
            this.lb_KundenProp.AutoSize = true;
            this.lb_KundenProp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_KundenProp.Location = new System.Drawing.Point(2, 216);
            this.lb_KundenProp.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.lb_KundenProp.Name = "lb_KundenProp";
            this.lb_KundenProp.Size = new System.Drawing.Size(224, 19);
            this.lb_KundenProp.Style = MetroFramework.MetroColorStyle.Lime;
            this.lb_KundenProp.TabIndex = 38;
            this.lb_KundenProp.Text = "Suchen nach Kundeneigenschaften:";
            // 
            // gb_GridView
            // 
            this.gb_GridView.Controls.Add(this.metroProgressSpinner1);
            this.gb_GridView.Controls.Add(this.gv_buchsuche);
            this.gb_GridView.HorizontalScrollbarBarColor = true;
            this.gb_GridView.HorizontalScrollbarHighlightOnWheel = false;
            this.gb_GridView.HorizontalScrollbarSize = 10;
            this.gb_GridView.Location = new System.Drawing.Point(311, 63);
            this.gb_GridView.Name = "gb_GridView";
            this.gb_GridView.Size = new System.Drawing.Size(866, 484);
            this.gb_GridView.TabIndex = 40;
            this.gb_GridView.VerticalScrollbarBarColor = true;
            this.gb_GridView.VerticalScrollbarHighlightOnWheel = false;
            this.gb_GridView.VerticalScrollbarSize = 10;
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(209, 0);
            this.metroProgressSpinner1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.MaximumSize = new System.Drawing.Size(447, 484);
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(447, 484);
            this.metroProgressSpinner1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroProgressSpinner1.TabIndex = 2;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // gb_Suche
            // 
            this.gb_Suche.Controls.Add(this.rb_Default);
            this.gb_Suche.Controls.Add(this.rb_GREENonly);
            this.gb_Suche.Controls.Add(this.rb_YELLOWonly);
            this.gb_Suche.Controls.Add(this.rb_REDonly);
            this.gb_Suche.Controls.Add(this.gb_Kunden);
            this.gb_Suche.Controls.Add(this.bt_Ausleihen);
            this.gb_Suche.Controls.Add(this.bt_Clear);
            this.gb_Suche.Controls.Add(this.lbBuchProp);
            this.gb_Suche.Controls.Add(this.cb_KundeAnz);
            this.gb_Suche.Controls.Add(this.cb_Verfügbar_Anz);
            this.gb_Suche.Controls.Add(this.lb_KundenProp);
            this.gb_Suche.Controls.Add(this.metroPanel1);
            this.gb_Suche.HorizontalScrollbarBarColor = true;
            this.gb_Suche.HorizontalScrollbarHighlightOnWheel = false;
            this.gb_Suche.HorizontalScrollbarSize = 10;
            this.gb_Suche.Location = new System.Drawing.Point(23, 63);
            this.gb_Suche.Name = "gb_Suche";
            this.gb_Suche.Size = new System.Drawing.Size(282, 514);
            this.gb_Suche.TabIndex = 41;
            this.gb_Suche.VerticalScrollbarBarColor = true;
            this.gb_Suche.VerticalScrollbarHighlightOnWheel = false;
            this.gb_Suche.VerticalScrollbarSize = 10;
            // 
            // rb_Default
            // 
            this.rb_Default.Checked = true;
            this.rb_Default.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_Default.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_Default.Location = new System.Drawing.Point(3, 461);
            this.rb_Default.Name = "rb_Default";
            this.rb_Default.Size = new System.Drawing.Size(267, 19);
            this.rb_Default.Style = MetroFramework.MetroColorStyle.Lime;
            this.rb_Default.TabIndex = 14;
            this.rb_Default.TabStop = true;
            this.rb_Default.Text = "Alle Bücher filtern";
            this.rb_Default.UseSelectable = true;
            this.rb_Default.CheckedChanged += new System.EventHandler(this.rb_Default_CheckedChanged);
            // 
            // rb_GREENonly
            // 
            this.rb_GREENonly.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_GREENonly.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_GREENonly.Location = new System.Drawing.Point(3, 436);
            this.rb_GREENonly.Name = "rb_GREENonly";
            this.rb_GREENonly.Size = new System.Drawing.Size(267, 19);
            this.rb_GREENonly.Style = MetroFramework.MetroColorStyle.Lime;
            this.rb_GREENonly.TabIndex = 13;
            this.rb_GREENonly.Text = "Nur nicht überfällige Bücher einblenden\r\n";
            this.rb_GREENonly.UseSelectable = true;
            this.rb_GREENonly.CheckedChanged += new System.EventHandler(this.rb_Default_CheckedChanged);
            // 
            // rb_YELLOWonly
            // 
            this.rb_YELLOWonly.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_YELLOWonly.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_YELLOWonly.Location = new System.Drawing.Point(3, 411);
            this.rb_YELLOWonly.Name = "rb_YELLOWonly";
            this.rb_YELLOWonly.Size = new System.Drawing.Size(267, 19);
            this.rb_YELLOWonly.Style = MetroFramework.MetroColorStyle.Lime;
            this.rb_YELLOWonly.TabIndex = 12;
            this.rb_YELLOWonly.Text = "Nur heute fällige Bücher einblenden\r\n";
            this.rb_YELLOWonly.UseSelectable = true;
            this.rb_YELLOWonly.CheckedChanged += new System.EventHandler(this.rb_Default_CheckedChanged);
            // 
            // rb_REDonly
            // 
            this.rb_REDonly.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_REDonly.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_REDonly.Location = new System.Drawing.Point(3, 386);
            this.rb_REDonly.Name = "rb_REDonly";
            this.rb_REDonly.Size = new System.Drawing.Size(267, 19);
            this.rb_REDonly.Style = MetroFramework.MetroColorStyle.Lime;
            this.rb_REDonly.TabIndex = 11;
            this.rb_REDonly.Text = "Nur überfällige Bücher einblenden\r\n";
            this.rb_REDonly.UseSelectable = true;
            this.rb_REDonly.CheckedChanged += new System.EventHandler(this.rb_Default_CheckedChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // cb_Verlag
            // 
            this.cb_Verlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Verlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Verlag.BorderColor = System.Drawing.Color.Gray;
            this.cb_Verlag.DataRowView = true;
            this.cb_Verlag.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Verlag.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Verlag.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cb_Verlag.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Verlag, "Tragen sie hier den Verlag ein, um das ausgeliehene Buch zu laden.");
            this.cb_Verlag.HighlightColor = System.Drawing.Color.YellowGreen;
            this.cb_Verlag.ItemHeight = 18;
            this.cb_Verlag.Location = new System.Drawing.Point(93, 123);
            this.cb_Verlag.Name = "cb_Verlag";
            this.helpProvider.SetShowHelp(this.cb_Verlag, true);
            this.cb_Verlag.Size = new System.Drawing.Size(175, 24);
            this.cb_Verlag.Sorted = true;
            this.cb_Verlag.TabIndex = 4;
            this.cb_Verlag.Text = "Verlag";
            this.cb_Verlag.TextChanged += new System.EventHandler(this.cb_Verlag_TextChanged);
            this.cb_Verlag.Enter += new System.EventHandler(this.cb_Verlag_Enter);
            this.cb_Verlag.Leave += new System.EventHandler(this.cb_Verlag_Leave);
            // 
            // cb_Genre
            // 
            this.cb_Genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Genre.BorderColor = System.Drawing.Color.Gray;
            this.cb_Genre.DataRowView = true;
            this.cb_Genre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Genre.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Genre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cb_Genre.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Genre, "Tragen sie hier das Genre ein, um das ausgeliehene Buch zu laden.");
            this.cb_Genre.HighlightColor = System.Drawing.Color.YellowGreen;
            this.cb_Genre.ItemHeight = 18;
            this.cb_Genre.Location = new System.Drawing.Point(93, 153);
            this.cb_Genre.Name = "cb_Genre";
            this.helpProvider.SetShowHelp(this.cb_Genre, true);
            this.cb_Genre.Size = new System.Drawing.Size(175, 24);
            this.cb_Genre.Sorted = true;
            this.cb_Genre.TabIndex = 5;
            this.cb_Genre.Text = "Genre";
            this.cb_Genre.TextChanged += new System.EventHandler(this.cb_Genre_TextChanged);
            this.cb_Genre.Enter += new System.EventHandler(this.cb_Genre_Enter);
            this.cb_Genre.Leave += new System.EventHandler(this.cb_Genre_Leave);
            // 
            // cb_Autor
            // 
            this.cb_Autor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Autor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Autor.BorderColor = System.Drawing.Color.Gray;
            this.cb_Autor.DataRowView = true;
            this.cb_Autor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cb_Autor.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Autor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cb_Autor.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Autor, "Tragen sie hier den Buchautor ein, um das ausgeliehene Buch zu laden.");
            this.cb_Autor.HighlightColor = System.Drawing.Color.YellowGreen;
            this.cb_Autor.ItemHeight = 18;
            this.cb_Autor.Location = new System.Drawing.Point(93, 93);
            this.cb_Autor.Name = "cb_Autor";
            this.helpProvider.SetShowHelp(this.cb_Autor, true);
            this.cb_Autor.Size = new System.Drawing.Size(175, 24);
            this.cb_Autor.Sorted = true;
            this.cb_Autor.TabIndex = 3;
            this.cb_Autor.Text = "Autor";
            this.cb_Autor.TextChanged += new System.EventHandler(this.cb_Autor_TextChanged);
            this.cb_Autor.Enter += new System.EventHandler(this.cb_Autor_Enter);
            this.cb_Autor.Leave += new System.EventHandler(this.cb_Autor_Leave);
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Location = new System.Drawing.Point(132, 93);
            this.metroProgressSpinner2.Margin = new System.Windows.Forms.Padding(2);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.MaximumSize = new System.Drawing.Size(447, 484);
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(84, 84);
            this.metroProgressSpinner2.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroProgressSpinner2.TabIndex = 2;
            this.metroProgressSpinner2.UseSelectable = true;
            // 
            // w_s_buchsuche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.CancelButton = this.bt_Schliessen;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.bt_Schliessen);
            this.Controls.Add(this.gb_Suche);
            this.Controls.Add(this.gb_GridView);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_buchsuche";
            this.Resizable = false;
            this.helpProvider.SetShowHelp(this, false);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Buchübersicht";
            this.Activated += new System.EventHandler(this.w_s_buchsuche_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gv_buchsuche)).EndInit();
            this.CM_Ausleihen.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.gb_Kunden.ResumeLayout(false);
            this.gb_GridView.ResumeLayout(false);
            this.gb_Suche.ResumeLayout(false);
            this.gb_Suche.PerformLayout();
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
        private MetroFramework.Controls.MetroTextBox tb_NName;
        private MetroFramework.Controls.MetroTextBox tb_VName;
        private MetroFramework.Controls.MetroTextBox tb_ISBN;
        private MetroFramework.Controls.MetroTextBox tb_ExemplarID;
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroTextBox tb_Klasse;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbBuchProp;
        private MetroFramework.Controls.MetroPanel gb_Kunden;
        private MetroFramework.Controls.MetroLabel lb_KundenProp;
        private MetroFramework.Controls.MetroPanel gb_GridView;
        private MetroFramework.Controls.MetroPanel gb_Suche;
        private MetroFramework.Controls.MetroButton bt_Schliessen;
        private MetroFramework.Controls.MetroLabel lb_Genre;
        private MetroFramework.Controls.MetroLabel lb_Exemplar;
        private MetroFramework.Controls.MetroLabel lb_ISBN;
        private MetroFramework.Controls.MetroLabel lb_Autor;
        private MetroFramework.Controls.MetroLabel lb_Verlag;
        private MetroFramework.Controls.MetroLabel lb_Titel;
        private MetroFramework.Controls.MetroLabel lb_VName;
        private MetroFramework.Controls.MetroLabel lb_NName;
        private MetroFramework.Controls.MetroLabel lb_Klasse;
        private MetroFramework.Controls.MetroContextMenu CM_Ausleihen;
        private System.Windows.Forms.ToolStripMenuItem addToLeihList;
        private System.Windows.Forms.ToolStripMenuItem removeFromLeihList;
        private System.Windows.Forms.ToolStripMenuItem ausleihen;
        private MetroFramework.Controls.MetroRadioButton rb_Default;
        private MetroFramework.Controls.MetroRadioButton rb_GREENonly;
        private MetroFramework.Controls.MetroRadioButton rb_YELLOWonly;
        private MetroFramework.Controls.MetroRadioButton rb_REDonly;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner2;
    }
}