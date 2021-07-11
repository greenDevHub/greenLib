namespace Bibo_Verwaltung
{
    partial class FormOverview
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOverview));
            this.gridOverview = new MetroFramework.Controls.MetroGrid();
            this.contextMenuBorrow = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ausleihen = new System.Windows.Forms.ToolStripMenuItem();
            this.exemplarZurückgebenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausleihlisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ausleihenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rueckgabelisteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hinzufügenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zurueckgebenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kundenAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buchAnzeigenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkShowCostumer = new MetroFramework.Controls.MetroCheckBox();
            this.checkShowAvailable = new MetroFramework.Controls.MetroCheckBox();
            this.btBorrow = new MetroFramework.Controls.MetroButton();
            this.tbCopyId = new MetroFramework.Controls.MetroTextBox();
            this.tbCopyIsbn = new MetroFramework.Controls.MetroTextBox();
            this.tbTitle = new MetroFramework.Controls.MetroTextBox();
            this.tbSurname = new MetroFramework.Controls.MetroTextBox();
            this.tbFirstName = new MetroFramework.Controls.MetroTextBox();
            this.btClearFilter = new MetroFramework.Controls.MetroButton();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.tbClass = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.spinnerAttributes = new MetroFramework.Controls.MetroProgressSpinner();
            this.lbGenre = new MetroFramework.Controls.MetroLabel();
            this.lbCopyId = new MetroFramework.Controls.MetroLabel();
            this.lbCopyIsbn = new MetroFramework.Controls.MetroLabel();
            this.lbAuthor = new MetroFramework.Controls.MetroLabel();
            this.lbPublisher = new MetroFramework.Controls.MetroLabel();
            this.lbTitle = new MetroFramework.Controls.MetroLabel();
            this.cbPublisher = new Bibo_Verwaltung.AdvancedComboBox();
            this.cbGenre = new Bibo_Verwaltung.AdvancedComboBox();
            this.cbAuthor = new Bibo_Verwaltung.AdvancedComboBox();
            this.lbInformationFirst = new MetroFramework.Controls.MetroLabel();
            this.btClose = new MetroFramework.Controls.MetroButton();
            this.lbFirstName = new MetroFramework.Controls.MetroLabel();
            this.lbSurname = new MetroFramework.Controls.MetroLabel();
            this.lbClass = new MetroFramework.Controls.MetroLabel();
            this.btReturn = new MetroFramework.Controls.MetroButton();
            this.gb_Kunden = new MetroFramework.Controls.MetroPanel();
            this.lbInformationSecond = new MetroFramework.Controls.MetroLabel();
            this.groupGridView = new MetroFramework.Controls.MetroPanel();
            this.spinnerGridView = new MetroFramework.Controls.MetroProgressSpinner();
            this.groupMain = new MetroFramework.Controls.MetroPanel();
            this.panelLegend = new MetroFramework.Controls.MetroPanel();
            this.lbLegendGreen = new MetroFramework.Controls.MetroLabel();
            this.lbLegendYellow = new MetroFramework.Controls.MetroLabel();
            this.lbLegendRed = new MetroFramework.Controls.MetroLabel();
            this.lbLegendDivider = new MetroFramework.Controls.MetroLabel();
            this.lb_legende = new MetroFramework.Controls.MetroLabel();
            this.radioShowAll = new MetroFramework.Controls.MetroRadioButton();
            this.radioShowGreen = new MetroFramework.Controls.MetroRadioButton();
            this.radioShowYellow = new MetroFramework.Controls.MetroRadioButton();
            this.radioShowBorrowed = new MetroFramework.Controls.MetroRadioButton();
            this.radioShowRed = new MetroFramework.Controls.MetroRadioButton();
            this.workerMain = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbListElements = new MetroFramework.Controls.MetroLabel();
            this.lbListInfo = new MetroFramework.Controls.MetroLabel();
            this.btResetList = new MetroFramework.Controls.MetroButton();
            this.groupList = new MetroFramework.Controls.MetroPanel();
            this.toolTipMain = new MetroFramework.Components.MetroToolTip();
            this.styleManagerOverview = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timerKeyInput = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridOverview)).BeginInit();
            this.contextMenuBorrow.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.gb_Kunden.SuspendLayout();
            this.groupGridView.SuspendLayout();
            this.groupMain.SuspendLayout();
            this.panelLegend.SuspendLayout();
            this.groupList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // gridOverview
            // 
            this.gridOverview.AllowUserToAddRows = false;
            this.gridOverview.AllowUserToDeleteRows = false;
            this.gridOverview.AllowUserToResizeRows = false;
            this.gridOverview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridOverview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridOverview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOverview.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridOverview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOverview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridOverview.ContextMenuStrip = this.contextMenuBorrow;
            this.gridOverview.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridOverview.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridOverview.EnableHeadersVisualStyles = false;
            this.gridOverview.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridOverview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.gridOverview, "In diesem Feld werden all ihre Bücher und evtl. vorhandene Ausleihvorgänge angeze" +
        "igt.");
            this.gridOverview.Location = new System.Drawing.Point(3, 3);
            this.gridOverview.MultiSelect = false;
            this.gridOverview.Name = "gridOverview";
            this.gridOverview.ReadOnly = true;
            this.gridOverview.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(188)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(219)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridOverview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridOverview.RowHeadersWidth = 35;
            this.gridOverview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridOverview.RowTemplate.DividerHeight = 1;
            this.gridOverview.RowTemplate.Height = 24;
            this.gridOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOverview.ShowEditingIcon = false;
            this.helpProvider.SetShowHelp(this.gridOverview, true);
            this.gridOverview.Size = new System.Drawing.Size(757, 482);
            this.gridOverview.Style = MetroFramework.MetroColorStyle.Lime;
            this.gridOverview.TabIndex = 19;
            this.toolTipMain.SetToolTip(this.gridOverview, "In diesem Feld werden all ihre Bücher und evtl. vorhandene Ausleihvorgänge angeze" +
        "igt.");
            this.gridOverview.VirtualMode = true;
            this.gridOverview.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gv_buchsuche_CellFormatting);
            this.gridOverview.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_buchsuche_CellMouseDown);
            this.gridOverview.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.gv_buchsuche_CellPainting);
            this.gridOverview.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gv_buchsuche_ColumnHeaderMouseClick);
            this.gridOverview.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gv_buchsuche_KeyDown);
            this.gridOverview.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gv_buchsuche_MouseDown);
            // 
            // contextMenuBorrow
            // 
            this.contextMenuBorrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contextMenuBorrow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contextMenuBorrow.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuBorrow.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ausleihen,
            this.exemplarZurückgebenToolStripMenuItem,
            this.ausleihlisteToolStripMenuItem,
            this.rueckgabelisteToolStripMenuItem,
            this.kundenAnzeigenToolStripMenuItem,
            this.buchAnzeigenToolStripMenuItem});
            this.contextMenuBorrow.Name = "ContextMenu";
            this.contextMenuBorrow.Size = new System.Drawing.Size(195, 136);
            this.contextMenuBorrow.Style = MetroFramework.MetroColorStyle.Lime;
            // 
            // ausleihen
            // 
            this.ausleihen.Name = "ausleihen";
            this.ausleihen.Size = new System.Drawing.Size(194, 22);
            this.ausleihen.Text = "Exemplar ausleihen";
            this.ausleihen.Click += new System.EventHandler(this.ausleihen_Click);
            // 
            // exemplarZurückgebenToolStripMenuItem
            // 
            this.exemplarZurückgebenToolStripMenuItem.Name = "exemplarZurückgebenToolStripMenuItem";
            this.exemplarZurückgebenToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.exemplarZurückgebenToolStripMenuItem.Text = "Exemplar zurückgeben";
            this.exemplarZurückgebenToolStripMenuItem.Click += new System.EventHandler(this.ExemplarZurückgebenToolStripMenuItem_Click);
            // 
            // ausleihlisteToolStripMenuItem
            // 
            this.ausleihlisteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem,
            this.entfernenToolStripMenuItem,
            this.ausleihenToolStripMenuItem});
            this.ausleihlisteToolStripMenuItem.Name = "ausleihlisteToolStripMenuItem";
            this.ausleihlisteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.ausleihlisteToolStripMenuItem.Text = "Ausleihliste";
            // 
            // hinzufügenToolStripMenuItem
            // 
            this.hinzufügenToolStripMenuItem.Name = "hinzufügenToolStripMenuItem";
            this.hinzufügenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.hinzufügenToolStripMenuItem.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem.Click += new System.EventHandler(this.addToLeihList_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.removeFromLeihList_Click);
            // 
            // ausleihenToolStripMenuItem
            // 
            this.ausleihenToolStripMenuItem.Name = "ausleihenToolStripMenuItem";
            this.ausleihenToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.ausleihenToolStripMenuItem.Text = "Ausleihen";
            this.ausleihenToolStripMenuItem.Click += new System.EventHandler(this.LeihlisteAusleihenToolStripMenuItem_Click);
            // 
            // rueckgabelisteToolStripMenuItem
            // 
            this.rueckgabelisteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hinzufügenToolStripMenuItem1,
            this.entfernenToolStripMenuItem1,
            this.zurueckgebenToolStripMenuItem});
            this.rueckgabelisteToolStripMenuItem.Name = "rueckgabelisteToolStripMenuItem";
            this.rueckgabelisteToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.rueckgabelisteToolStripMenuItem.Text = "Rückgabeliste";
            // 
            // hinzufügenToolStripMenuItem1
            // 
            this.hinzufügenToolStripMenuItem1.Name = "hinzufügenToolStripMenuItem1";
            this.hinzufügenToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.hinzufügenToolStripMenuItem1.Text = "Hinzufügen";
            this.hinzufügenToolStripMenuItem1.Click += new System.EventHandler(this.HinzufügenToolStripMenuItem1_Click);
            // 
            // entfernenToolStripMenuItem1
            // 
            this.entfernenToolStripMenuItem1.Name = "entfernenToolStripMenuItem1";
            this.entfernenToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.entfernenToolStripMenuItem1.Text = "Entfernen";
            this.entfernenToolStripMenuItem1.Click += new System.EventHandler(this.EntfernenToolStripMenuItem1_Click);
            // 
            // zurueckgebenToolStripMenuItem
            // 
            this.zurueckgebenToolStripMenuItem.Name = "zurueckgebenToolStripMenuItem";
            this.zurueckgebenToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.zurueckgebenToolStripMenuItem.Text = "Zurückgeben";
            this.zurueckgebenToolStripMenuItem.Click += new System.EventHandler(this.ZurueckgebenToolStripMenuItem_Click);
            // 
            // kundenAnzeigenToolStripMenuItem
            // 
            this.kundenAnzeigenToolStripMenuItem.Name = "kundenAnzeigenToolStripMenuItem";
            this.kundenAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.kundenAnzeigenToolStripMenuItem.Text = "Kunden anzeigen";
            this.kundenAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.KundenAnzeigenToolStripMenuItem_Click);
            // 
            // buchAnzeigenToolStripMenuItem
            // 
            this.buchAnzeigenToolStripMenuItem.Name = "buchAnzeigenToolStripMenuItem";
            this.buchAnzeigenToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.buchAnzeigenToolStripMenuItem.Text = "Buch anzeigen";
            this.buchAnzeigenToolStripMenuItem.Click += new System.EventHandler(this.BuchAnzeigenToolStripMenuItem_Click);
            // 
            // checkShowCostumer
            // 
            this.checkShowCostumer.AutoSize = true;
            this.checkShowCostumer.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkShowCostumer.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.checkShowCostumer, "Setzen sie einen Haken in dieses Feld, werden ihnen im obenliegenden Feld Kundeni" +
        "nformationen bei ausgeliehenen Büchern angezeigt.");
            this.checkShowCostumer.Location = new System.Drawing.Point(3, 361);
            this.checkShowCostumer.Name = "checkShowCostumer";
            this.helpProvider.SetShowHelp(this.checkShowCostumer, true);
            this.checkShowCostumer.Size = new System.Drawing.Size(218, 19);
            this.checkShowCostumer.Style = MetroFramework.MetroColorStyle.Lime;
            this.checkShowCostumer.TabIndex = 11;
            this.checkShowCostumer.Text = "Kundeninformationen einblenden";
            this.toolTipMain.SetToolTip(this.checkShowCostumer, "Setzen sie einen Haken in dieses Feld, werden ihnen die Kundeninformationen bei a" +
        "usgeliehenen Büchern angezeigt.");
            this.checkShowCostumer.UseSelectable = true;
            this.checkShowCostumer.CheckedChanged += new System.EventHandler(this.cb_KundeAnz_CheckedChanged);
            // 
            // checkShowAvailable
            // 
            this.checkShowAvailable.AutoSize = true;
            this.checkShowAvailable.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.checkShowAvailable.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.helpProvider.SetHelpString(this.checkShowAvailable, "Setzen sie einen Haken in dieses Feld, werden ihnen nur Bücher angezeigt, welche " +
        "verliehen werden können.");
            this.checkShowAvailable.Location = new System.Drawing.Point(3, 336);
            this.checkShowAvailable.Name = "checkShowAvailable";
            this.helpProvider.SetShowHelp(this.checkShowAvailable, false);
            this.checkShowAvailable.Size = new System.Drawing.Size(242, 19);
            this.checkShowAvailable.Style = MetroFramework.MetroColorStyle.Lime;
            this.checkShowAvailable.TabIndex = 10;
            this.checkShowAvailable.Text = "Nur verleihbereite Bücher einblenden";
            this.toolTipMain.SetToolTip(this.checkShowAvailable, "Setzen sie einen Haken in dieses Feld, werden ihnen nur Bücher angezeigt, welche " +
        "verliehen werden können.");
            this.checkShowAvailable.UseSelectable = true;
            this.checkShowAvailable.CheckedChanged += new System.EventHandler(this.cb_Verfügbar_Anz_CheckedChanged);
            // 
            // btBorrow
            // 
            this.btBorrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btBorrow.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btBorrow.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.btBorrow, "Klicken sie auf diesen Button, nachdem sie ein Buch im obenliegenden Feld makiert" +
        " haben, um dieses gewählte Buch auszuleihen.");
            this.btBorrow.Location = new System.Drawing.Point(2, 497);
            this.btBorrow.Name = "btBorrow";
            this.helpProvider.SetShowHelp(this.btBorrow, true);
            this.btBorrow.Size = new System.Drawing.Size(122, 24);
            this.btBorrow.Style = MetroFramework.MetroColorStyle.Lime;
            this.btBorrow.TabIndex = 16;
            this.btBorrow.Text = "Buchausleihe";
            this.toolTipMain.SetToolTip(this.btBorrow, "Klicken Sie hier, nachdem Sie ein Buch ausgewählt haben, um dieses Buch auszuleih" +
        "en.");
            this.btBorrow.UseSelectable = true;
            this.btBorrow.Click += new System.EventHandler(this.Ausleihvorgang);
            // 
            // tbCopyId
            // 
            // 
            // 
            // 
            this.tbCopyId.CustomButton.Image = null;
            this.tbCopyId.CustomButton.Location = new System.Drawing.Point(261, 2);
            this.tbCopyId.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbCopyId.CustomButton.Name = "";
            this.tbCopyId.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbCopyId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCopyId.CustomButton.TabIndex = 1;
            this.tbCopyId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCopyId.CustomButton.UseSelectable = true;
            this.tbCopyId.CustomButton.Visible = false;
            this.tbCopyId.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbCopyId.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tbCopyId, "Tragen sie hier die Buch-ID ein, um das gewünschte Buch zu laden.");
            this.tbCopyId.Lines = new string[0];
            this.tbCopyId.Location = new System.Drawing.Point(93, 3);
            this.tbCopyId.MaxLength = 32767;
            this.tbCopyId.Name = "tbCopyId";
            this.tbCopyId.PasswordChar = '\0';
            this.tbCopyId.PromptText = "Exemplar ID";
            this.tbCopyId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCopyId.SelectedText = "";
            this.tbCopyId.SelectionLength = 0;
            this.tbCopyId.SelectionStart = 0;
            this.tbCopyId.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tbCopyId, true);
            this.tbCopyId.Size = new System.Drawing.Size(283, 24);
            this.tbCopyId.Style = MetroFramework.MetroColorStyle.Lime;
            this.tbCopyId.TabIndex = 0;
            this.toolTipMain.SetToolTip(this.tbCopyId, "Geben Sie hier die Buch-ID ein.");
            this.tbCopyId.UseSelectable = true;
            this.tbCopyId.WaterMark = "Exemplar ID";
            this.tbCopyId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCopyId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tbCopyId.TextChanged += new System.EventHandler(this.tb_ExemplarID_TextChanged);
            this.tbCopyId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ExemplarID_KeyPress);
            // 
            // tbCopyIsbn
            // 
            // 
            // 
            // 
            this.tbCopyIsbn.CustomButton.Image = null;
            this.tbCopyIsbn.CustomButton.Location = new System.Drawing.Point(261, 2);
            this.tbCopyIsbn.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbCopyIsbn.CustomButton.Name = "";
            this.tbCopyIsbn.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbCopyIsbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbCopyIsbn.CustomButton.TabIndex = 1;
            this.tbCopyIsbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbCopyIsbn.CustomButton.UseSelectable = true;
            this.tbCopyIsbn.CustomButton.Visible = false;
            this.tbCopyIsbn.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbCopyIsbn.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpKeyword(this.tbCopyIsbn, "");
            this.helpProvider.SetHelpString(this.tbCopyIsbn, "Tragen sie hier die ISBN-13 ein, um das ausgeliehene Buch zu laden.");
            this.tbCopyIsbn.Lines = new string[0];
            this.tbCopyIsbn.Location = new System.Drawing.Point(93, 33);
            this.tbCopyIsbn.MaxLength = 32767;
            this.tbCopyIsbn.Name = "tbCopyIsbn";
            this.tbCopyIsbn.PasswordChar = '\0';
            this.tbCopyIsbn.PromptText = "ISBN";
            this.tbCopyIsbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbCopyIsbn.SelectedText = "";
            this.tbCopyIsbn.SelectionLength = 0;
            this.tbCopyIsbn.SelectionStart = 0;
            this.tbCopyIsbn.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tbCopyIsbn, true);
            this.tbCopyIsbn.Size = new System.Drawing.Size(283, 24);
            this.tbCopyIsbn.Style = MetroFramework.MetroColorStyle.Lime;
            this.tbCopyIsbn.TabIndex = 1;
            this.toolTipMain.SetToolTip(this.tbCopyIsbn, "Geben Sie hier die ISBN-13 des Buches ein.");
            this.tbCopyIsbn.UseSelectable = true;
            this.tbCopyIsbn.WaterMark = "ISBN";
            this.tbCopyIsbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbCopyIsbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tbCopyIsbn.TextChanged += new System.EventHandler(this.tb_ISBN_TextChanged);
            this.tbCopyIsbn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ISBN_KeyPress);
            // 
            // tbTitle
            // 
            // 
            // 
            // 
            this.tbTitle.CustomButton.Image = null;
            this.tbTitle.CustomButton.Location = new System.Drawing.Point(261, 2);
            this.tbTitle.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbTitle.CustomButton.Name = "";
            this.tbTitle.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbTitle.CustomButton.TabIndex = 1;
            this.tbTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbTitle.CustomButton.UseSelectable = true;
            this.tbTitle.CustomButton.Visible = false;
            this.tbTitle.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbTitle.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tbTitle, "Tragen sie hier den Buchtitel ein, um das ausgeliehene Buch zu laden.");
            this.tbTitle.Lines = new string[0];
            this.tbTitle.Location = new System.Drawing.Point(93, 63);
            this.tbTitle.MaxLength = 32767;
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.PasswordChar = '\0';
            this.tbTitle.PromptText = "Titel";
            this.tbTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbTitle.SelectedText = "";
            this.tbTitle.SelectionLength = 0;
            this.tbTitle.SelectionStart = 0;
            this.tbTitle.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tbTitle, true);
            this.tbTitle.Size = new System.Drawing.Size(283, 24);
            this.tbTitle.Style = MetroFramework.MetroColorStyle.Lime;
            this.tbTitle.TabIndex = 2;
            this.toolTipMain.SetToolTip(this.tbTitle, "Geben Sie hier den Titel des Buches ein.");
            this.tbTitle.UseSelectable = true;
            this.tbTitle.WaterMark = "Titel";
            this.tbTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tbTitle.TextChanged += new System.EventHandler(this.tb_Titel_TextChanged);
            // 
            // tbSurname
            // 
            // 
            // 
            // 
            this.tbSurname.CustomButton.Image = null;
            this.tbSurname.CustomButton.Location = new System.Drawing.Point(261, 2);
            this.tbSurname.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbSurname.CustomButton.Name = "";
            this.tbSurname.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbSurname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbSurname.CustomButton.TabIndex = 1;
            this.tbSurname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbSurname.CustomButton.UseSelectable = true;
            this.tbSurname.CustomButton.Visible = false;
            this.tbSurname.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbSurname.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tbSurname, "Tragen sie hier den Nachnamen des gesuchten Kunden ein, welcher einen Ausleihvorg" +
        "ang getätigt hat.");
            this.tbSurname.Lines = new string[0];
            this.tbSurname.Location = new System.Drawing.Point(93, 33);
            this.tbSurname.MaxLength = 32767;
            this.tbSurname.Name = "tbSurname";
            this.tbSurname.PasswordChar = '\0';
            this.tbSurname.PromptText = "Nachname";
            this.tbSurname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSurname.SelectedText = "";
            this.tbSurname.SelectionLength = 0;
            this.tbSurname.SelectionStart = 0;
            this.tbSurname.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tbSurname, true);
            this.tbSurname.Size = new System.Drawing.Size(283, 24);
            this.tbSurname.Style = MetroFramework.MetroColorStyle.Lime;
            this.tbSurname.TabIndex = 8;
            this.toolTipMain.SetToolTip(this.tbSurname, "Geben Sie hier den Nachnamen des Kunden ein.");
            this.tbSurname.UseSelectable = true;
            this.tbSurname.WaterMark = "Nachname";
            this.tbSurname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbSurname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tbSurname.TextChanged += new System.EventHandler(this.tb_nachname_TextChanged);
            // 
            // tbFirstName
            // 
            // 
            // 
            // 
            this.tbFirstName.CustomButton.Image = null;
            this.tbFirstName.CustomButton.Location = new System.Drawing.Point(261, 2);
            this.tbFirstName.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbFirstName.CustomButton.Name = "";
            this.tbFirstName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbFirstName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbFirstName.CustomButton.TabIndex = 1;
            this.tbFirstName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbFirstName.CustomButton.UseSelectable = true;
            this.tbFirstName.CustomButton.Visible = false;
            this.tbFirstName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbFirstName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tbFirstName, "Tragen sie hier den Vornamen des gesuchten Kunden ein, welcher einen Ausleihvorga" +
        "ng getätigt hat.");
            this.tbFirstName.Lines = new string[0];
            this.tbFirstName.Location = new System.Drawing.Point(93, 3);
            this.tbFirstName.MaxLength = 32767;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.PasswordChar = '\0';
            this.tbFirstName.PromptText = "Vorname";
            this.tbFirstName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbFirstName.SelectedText = "";
            this.tbFirstName.SelectionLength = 0;
            this.tbFirstName.SelectionStart = 0;
            this.tbFirstName.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tbFirstName, true);
            this.tbFirstName.Size = new System.Drawing.Size(283, 24);
            this.tbFirstName.Style = MetroFramework.MetroColorStyle.Lime;
            this.tbFirstName.TabIndex = 7;
            this.toolTipMain.SetToolTip(this.tbFirstName, "Geben Sie hier den Vornamen des Kunden ein.");
            this.tbFirstName.UseSelectable = true;
            this.tbFirstName.WaterMark = "Vorname";
            this.tbFirstName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbFirstName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tbFirstName.TextChanged += new System.EventHandler(this.tb_vorname_TextChanged);
            // 
            // btClearFilter
            // 
            this.btClearFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClearFilter.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btClearFilter.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.btClearFilter, "Leeren sie alle linksseitig liegenden Textfelder.");
            this.btClearFilter.Location = new System.Drawing.Point(259, 497);
            this.btClearFilter.Name = "btClearFilter";
            this.helpProvider.SetShowHelp(this.btClearFilter, true);
            this.btClearFilter.Size = new System.Drawing.Size(122, 24);
            this.btClearFilter.Style = MetroFramework.MetroColorStyle.Lime;
            this.btClearFilter.TabIndex = 18;
            this.btClearFilter.Text = "Filter löschen";
            this.toolTipMain.SetToolTip(this.btClearFilter, "Klicken Sie hier, um alle eingegebenen Suchkriterien zurückzusetzen.");
            this.btClearFilter.UseSelectable = true;
            this.btClearFilter.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // tbClass
            // 
            // 
            // 
            // 
            this.tbClass.CustomButton.Image = null;
            this.tbClass.CustomButton.Location = new System.Drawing.Point(261, 2);
            this.tbClass.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tbClass.CustomButton.Name = "";
            this.tbClass.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbClass.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbClass.CustomButton.TabIndex = 1;
            this.tbClass.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbClass.CustomButton.UseSelectable = true;
            this.tbClass.CustomButton.Visible = false;
            this.tbClass.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbClass.ForeColor = System.Drawing.SystemColors.GrayText;
            this.helpProvider.SetHelpString(this.tbClass, "Tragen sie hier den Vornamen des gesuchten Kunden ein, welcher einen Ausleihvorga" +
        "ng getätigt hat.");
            this.tbClass.Lines = new string[0];
            this.tbClass.Location = new System.Drawing.Point(93, 63);
            this.tbClass.MaxLength = 32767;
            this.tbClass.Name = "tbClass";
            this.tbClass.PasswordChar = '\0';
            this.tbClass.PromptText = "Klasse";
            this.tbClass.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbClass.SelectedText = "";
            this.tbClass.SelectionLength = 0;
            this.tbClass.SelectionStart = 0;
            this.tbClass.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tbClass, true);
            this.tbClass.Size = new System.Drawing.Size(283, 24);
            this.tbClass.Style = MetroFramework.MetroColorStyle.Lime;
            this.tbClass.TabIndex = 9;
            this.toolTipMain.SetToolTip(this.tbClass, "Geben Sie hier die Klassenstufe des Kunden ein.");
            this.tbClass.UseSelectable = true;
            this.tbClass.WaterMark = "Klasse";
            this.tbClass.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbClass.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Italic);
            this.tbClass.TextChanged += new System.EventHandler(this.tb_klasse_TextChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.spinnerAttributes);
            this.metroPanel1.Controls.Add(this.lbGenre);
            this.metroPanel1.Controls.Add(this.lbCopyId);
            this.metroPanel1.Controls.Add(this.lbCopyIsbn);
            this.metroPanel1.Controls.Add(this.lbAuthor);
            this.metroPanel1.Controls.Add(this.lbPublisher);
            this.metroPanel1.Controls.Add(this.lbTitle);
            this.metroPanel1.Controls.Add(this.cbPublisher);
            this.metroPanel1.Controls.Add(this.cbGenre);
            this.metroPanel1.Controls.Add(this.tbCopyId);
            this.metroPanel1.Controls.Add(this.cbAuthor);
            this.metroPanel1.Controls.Add(this.tbCopyIsbn);
            this.metroPanel1.Controls.Add(this.tbTitle);
            this.helpProvider.SetHelpString(this.metroPanel1, resources.GetString("metroPanel1.HelpString"));
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(2, 25);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.helpProvider.SetShowHelp(this.metroPanel1, true);
            this.metroPanel1.Size = new System.Drawing.Size(379, 185);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 8;
            // 
            // spinnerAttributes
            // 
            this.spinnerAttributes.Location = new System.Drawing.Point(184, 93);
            this.spinnerAttributes.Margin = new System.Windows.Forms.Padding(2);
            this.spinnerAttributes.Maximum = 100;
            this.spinnerAttributes.MaximumSize = new System.Drawing.Size(447, 484);
            this.spinnerAttributes.Name = "spinnerAttributes";
            this.spinnerAttributes.Size = new System.Drawing.Size(84, 84);
            this.spinnerAttributes.Style = MetroFramework.MetroColorStyle.Lime;
            this.spinnerAttributes.TabIndex = 2;
            this.spinnerAttributes.UseSelectable = true;
            // 
            // lbGenre
            // 
            this.helpProvider.SetHelpKeyword(this.lbGenre, "Tragen sie den Verlag ihres Buches hier ein.");
            this.lbGenre.Location = new System.Drawing.Point(3, 153);
            this.lbGenre.Margin = new System.Windows.Forms.Padding(3);
            this.lbGenre.Name = "lbGenre";
            this.helpProvider.SetShowHelp(this.lbGenre, true);
            this.lbGenre.Size = new System.Drawing.Size(84, 24);
            this.lbGenre.TabIndex = 42;
            this.lbGenre.Text = "Genre:";
            this.lbGenre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCopyId
            // 
            this.helpProvider.SetHelpString(this.lbCopyId, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.lbCopyId.Location = new System.Drawing.Point(3, 3);
            this.lbCopyId.Margin = new System.Windows.Forms.Padding(3);
            this.lbCopyId.Name = "lbCopyId";
            this.helpProvider.SetShowHelp(this.lbCopyId, true);
            this.lbCopyId.Size = new System.Drawing.Size(84, 24);
            this.lbCopyId.TabIndex = 37;
            this.lbCopyId.Text = "Exemplar-ID:";
            this.lbCopyId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCopyIsbn
            // 
            this.helpProvider.SetHelpString(this.lbCopyIsbn, "Tragen sie den Titel ihres Buches hier ein.");
            this.lbCopyIsbn.Location = new System.Drawing.Point(3, 33);
            this.lbCopyIsbn.Margin = new System.Windows.Forms.Padding(3);
            this.lbCopyIsbn.Name = "lbCopyIsbn";
            this.helpProvider.SetShowHelp(this.lbCopyIsbn, true);
            this.lbCopyIsbn.Size = new System.Drawing.Size(84, 24);
            this.lbCopyIsbn.TabIndex = 38;
            this.lbCopyIsbn.Text = "ISBN:";
            this.lbCopyIsbn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbAuthor
            // 
            this.helpProvider.SetHelpString(this.lbAuthor, "Tragen sie das Genre ihres Buches hier ein.");
            this.lbAuthor.Location = new System.Drawing.Point(3, 93);
            this.lbAuthor.Margin = new System.Windows.Forms.Padding(3);
            this.lbAuthor.Name = "lbAuthor";
            this.helpProvider.SetShowHelp(this.lbAuthor, true);
            this.lbAuthor.Size = new System.Drawing.Size(84, 24);
            this.lbAuthor.TabIndex = 39;
            this.lbAuthor.Text = "Autor:";
            this.lbAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbPublisher
            // 
            this.helpProvider.SetHelpKeyword(this.lbPublisher, "Tragen sie den Verlag ihres Buches hier ein.");
            this.lbPublisher.Location = new System.Drawing.Point(3, 123);
            this.lbPublisher.Margin = new System.Windows.Forms.Padding(3);
            this.lbPublisher.Name = "lbPublisher";
            this.helpProvider.SetShowHelp(this.lbPublisher, true);
            this.lbPublisher.Size = new System.Drawing.Size(84, 24);
            this.lbPublisher.TabIndex = 41;
            this.lbPublisher.Text = "Verlag:";
            this.lbPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbTitle
            // 
            this.helpProvider.SetHelpString(this.lbTitle, "Tragen sie den Autor ihres Buches hier ein.");
            this.lbTitle.Location = new System.Drawing.Point(3, 63);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(3);
            this.lbTitle.Name = "lbTitle";
            this.helpProvider.SetShowHelp(this.lbTitle, true);
            this.lbTitle.Size = new System.Drawing.Size(84, 24);
            this.lbTitle.TabIndex = 40;
            this.lbTitle.Text = "Titel:";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbPublisher
            // 
            this.cbPublisher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbPublisher.BorderColor = System.Drawing.Color.Gray;
            this.cbPublisher.DataRowView = true;
            this.cbPublisher.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPublisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPublisher.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cbPublisher.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbPublisher.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cbPublisher, "Tragen sie hier den Verlag ein, um das ausgeliehene Buch zu laden.");
            this.cbPublisher.HighlightColor = System.Drawing.Color.YellowGreen;
            this.cbPublisher.ItemHeight = 18;
            this.cbPublisher.Location = new System.Drawing.Point(93, 123);
            this.cbPublisher.Name = "cbPublisher";
            this.helpProvider.SetShowHelp(this.cbPublisher, true);
            this.cbPublisher.Size = new System.Drawing.Size(283, 24);
            this.cbPublisher.Sorted = true;
            this.cbPublisher.TabIndex = 4;
            this.cbPublisher.Text = "Verlag";
            this.toolTipMain.SetToolTip(this.cbPublisher, "Tragen sie hier den Verlag ein.");
            this.cbPublisher.SelectionChangeCommitted += new System.EventHandler(this.Cb_Verlag_SelectionChangeCommitted);
            this.cbPublisher.TextChanged += new System.EventHandler(this.cb_Verlag_TextChanged);
            this.cbPublisher.Enter += new System.EventHandler(this.cb_Verlag_Enter);
            this.cbPublisher.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_Verlag_KeyDown);
            this.cbPublisher.Leave += new System.EventHandler(this.cb_Verlag_Leave);
            this.cbPublisher.MouseEnter += new System.EventHandler(this.cb_Verlag_MouseEnter);
            // 
            // cbGenre
            // 
            this.cbGenre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbGenre.BorderColor = System.Drawing.Color.Gray;
            this.cbGenre.DataRowView = true;
            this.cbGenre.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbGenre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbGenre.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cbGenre.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbGenre.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cbGenre, "Tragen sie hier das Genre ein, um das ausgeliehene Buch zu laden.");
            this.cbGenre.HighlightColor = System.Drawing.Color.YellowGreen;
            this.cbGenre.ItemHeight = 18;
            this.cbGenre.Location = new System.Drawing.Point(93, 153);
            this.cbGenre.Name = "cbGenre";
            this.helpProvider.SetShowHelp(this.cbGenre, true);
            this.cbGenre.Size = new System.Drawing.Size(283, 24);
            this.cbGenre.Sorted = true;
            this.cbGenre.TabIndex = 5;
            this.cbGenre.Text = "Genre";
            this.toolTipMain.SetToolTip(this.cbGenre, "Tragen sie hier das Genre ein.");
            this.cbGenre.SelectionChangeCommitted += new System.EventHandler(this.Cb_Genre_SelectionChangeCommitted);
            this.cbGenre.TextChanged += new System.EventHandler(this.cb_Genre_TextChanged);
            this.cbGenre.Enter += new System.EventHandler(this.cb_Genre_Enter);
            this.cbGenre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_Genre_KeyDown);
            this.cbGenre.Leave += new System.EventHandler(this.cb_Genre_Leave);
            this.cbGenre.MouseEnter += new System.EventHandler(this.cb_Genre_MouseEnter);
            // 
            // cbAuthor
            // 
            this.cbAuthor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbAuthor.BorderColor = System.Drawing.Color.Gray;
            this.cbAuthor.DataRowView = true;
            this.cbAuthor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbAuthor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbAuthor.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cbAuthor.ForeColor = System.Drawing.SystemColors.GrayText;
            this.cbAuthor.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cbAuthor, "Tragen sie hier den Buchautor ein, um das ausgeliehene Buch zu laden.");
            this.cbAuthor.HighlightColor = System.Drawing.Color.YellowGreen;
            this.cbAuthor.ItemHeight = 18;
            this.cbAuthor.Location = new System.Drawing.Point(93, 93);
            this.cbAuthor.Name = "cbAuthor";
            this.helpProvider.SetShowHelp(this.cbAuthor, true);
            this.cbAuthor.Size = new System.Drawing.Size(283, 24);
            this.cbAuthor.Sorted = true;
            this.cbAuthor.TabIndex = 3;
            this.cbAuthor.Text = "Autor";
            this.toolTipMain.SetToolTip(this.cbAuthor, "Tragen sie hier den Buchautor ein.");
            this.cbAuthor.SelectionChangeCommitted += new System.EventHandler(this.Cb_Autor_SelectionChangeCommitted);
            this.cbAuthor.TextChanged += new System.EventHandler(this.cb_Autor_TextChanged);
            this.cbAuthor.Enter += new System.EventHandler(this.cb_Autor_Enter);
            this.cbAuthor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_Autor_KeyDown);
            this.cbAuthor.Leave += new System.EventHandler(this.cb_Autor_Leave);
            this.cbAuthor.MouseEnter += new System.EventHandler(this.cb_Autor_MouseEnter);
            // 
            // lbInformationFirst
            // 
            this.lbInformationFirst.AutoSize = true;
            this.lbInformationFirst.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.helpProvider.SetHelpString(this.lbInformationFirst, resources.GetString("lbInformationFirst.HelpString"));
            this.lbInformationFirst.Location = new System.Drawing.Point(2, 3);
            this.lbInformationFirst.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.lbInformationFirst.Name = "lbInformationFirst";
            this.helpProvider.SetShowHelp(this.lbInformationFirst, true);
            this.lbInformationFirst.Size = new System.Drawing.Size(207, 19);
            this.lbInformationFirst.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbInformationFirst.TabIndex = 38;
            this.lbInformationFirst.Text = "Suchen nach Bucheigenschaften:";
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.btClose, "Schließen sie das akuelle Fenster.");
            this.btClose.Location = new System.Drawing.Point(1056, 560);
            this.btClose.MaximumSize = new System.Drawing.Size(375, 24);
            this.btClose.MinimumSize = new System.Drawing.Size(100, 24);
            this.btClose.Name = "btClose";
            this.helpProvider.SetShowHelp(this.btClose, true);
            this.btClose.Size = new System.Drawing.Size(122, 24);
            this.btClose.TabIndex = 22;
            this.btClose.Text = "Schließen";
            this.btClose.UseSelectable = true;
            // 
            // lbFirstName
            // 
            this.helpProvider.SetHelpString(this.lbFirstName, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.lbFirstName.Location = new System.Drawing.Point(3, 3);
            this.lbFirstName.Margin = new System.Windows.Forms.Padding(3);
            this.lbFirstName.Name = "lbFirstName";
            this.helpProvider.SetShowHelp(this.lbFirstName, true);
            this.lbFirstName.Size = new System.Drawing.Size(65, 24);
            this.lbFirstName.TabIndex = 41;
            this.lbFirstName.Text = "Vorname:";
            this.lbFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbSurname
            // 
            this.helpProvider.SetHelpString(this.lbSurname, "Tragen sie den Titel ihres Buches hier ein.");
            this.lbSurname.Location = new System.Drawing.Point(3, 33);
            this.lbSurname.Margin = new System.Windows.Forms.Padding(3);
            this.lbSurname.Name = "lbSurname";
            this.helpProvider.SetShowHelp(this.lbSurname, true);
            this.lbSurname.Size = new System.Drawing.Size(75, 24);
            this.lbSurname.TabIndex = 42;
            this.lbSurname.Text = "Nachname:";
            this.lbSurname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbClass
            // 
            this.helpProvider.SetHelpString(this.lbClass, "Tragen sie den Autor ihres Buches hier ein.");
            this.lbClass.Location = new System.Drawing.Point(3, 63);
            this.lbClass.Margin = new System.Windows.Forms.Padding(3);
            this.lbClass.Name = "lbClass";
            this.helpProvider.SetShowHelp(this.lbClass, true);
            this.lbClass.Size = new System.Drawing.Size(80, 24);
            this.lbClass.TabIndex = 43;
            this.lbClass.Text = "Klasse:";
            this.lbClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btReturn
            // 
            this.btReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btReturn.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btReturn.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.btReturn, "Klicken sie auf diesen Button, nachdem sie ein Buch im obenliegenden Feld makiert" +
        " haben, um dieses gewählte Buch auszuleihen.");
            this.btReturn.Location = new System.Drawing.Point(131, 497);
            this.btReturn.Name = "btReturn";
            this.helpProvider.SetShowHelp(this.btReturn, true);
            this.btReturn.Size = new System.Drawing.Size(122, 24);
            this.btReturn.Style = MetroFramework.MetroColorStyle.Lime;
            this.btReturn.TabIndex = 17;
            this.btReturn.Text = "Buchrückgabe";
            this.toolTipMain.SetToolTip(this.btReturn, "Klicken Sie hier, nachdem Sie ein Buch ausgewählt haben, um dieses Buch zurückzug" +
        "eben.");
            this.btReturn.UseSelectable = true;
            this.btReturn.Click += new System.EventHandler(this.Bt_rueckgabe_Click);
            // 
            // gb_Kunden
            // 
            this.gb_Kunden.Controls.Add(this.lbFirstName);
            this.gb_Kunden.Controls.Add(this.lbSurname);
            this.gb_Kunden.Controls.Add(this.lbClass);
            this.gb_Kunden.Controls.Add(this.tbClass);
            this.gb_Kunden.Controls.Add(this.tbSurname);
            this.gb_Kunden.Controls.Add(this.tbFirstName);
            this.gb_Kunden.HorizontalScrollbarBarColor = true;
            this.gb_Kunden.HorizontalScrollbarHighlightOnWheel = false;
            this.gb_Kunden.HorizontalScrollbarSize = 8;
            this.gb_Kunden.Location = new System.Drawing.Point(2, 238);
            this.gb_Kunden.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gb_Kunden.Name = "gb_Kunden";
            this.gb_Kunden.Size = new System.Drawing.Size(379, 92);
            this.gb_Kunden.Style = MetroFramework.MetroColorStyle.Lime;
            this.gb_Kunden.TabIndex = 6;
            this.gb_Kunden.VerticalScrollbarBarColor = true;
            this.gb_Kunden.VerticalScrollbarHighlightOnWheel = false;
            this.gb_Kunden.VerticalScrollbarSize = 8;
            // 
            // lbInformationSecond
            // 
            this.lbInformationSecond.AutoSize = true;
            this.lbInformationSecond.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbInformationSecond.Location = new System.Drawing.Point(2, 216);
            this.lbInformationSecond.Margin = new System.Windows.Forms.Padding(2, 3, 2, 0);
            this.lbInformationSecond.Name = "lbInformationSecond";
            this.lbInformationSecond.Size = new System.Drawing.Size(224, 19);
            this.lbInformationSecond.Style = MetroFramework.MetroColorStyle.Lime;
            this.lbInformationSecond.TabIndex = 38;
            this.lbInformationSecond.Text = "Suchen nach Kundeneigenschaften:";
            // 
            // groupGridView
            // 
            this.groupGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupGridView.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupGridView.Controls.Add(this.spinnerGridView);
            this.groupGridView.Controls.Add(this.gridOverview);
            this.groupGridView.HorizontalScrollbarBarColor = true;
            this.groupGridView.HorizontalScrollbarHighlightOnWheel = false;
            this.groupGridView.HorizontalScrollbarSize = 10;
            this.groupGridView.Location = new System.Drawing.Point(414, 63);
            this.groupGridView.Name = "groupGridView";
            this.groupGridView.Size = new System.Drawing.Size(764, 488);
            this.groupGridView.TabIndex = 19;
            this.groupGridView.VerticalScrollbarBarColor = true;
            this.groupGridView.VerticalScrollbarHighlightOnWheel = false;
            this.groupGridView.VerticalScrollbarSize = 10;
            // 
            // spinnerGridView
            // 
            this.spinnerGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spinnerGridView.Location = new System.Drawing.Point(142, 3);
            this.spinnerGridView.Maximum = 100;
            this.spinnerGridView.MaximumSize = new System.Drawing.Size(500, 500);
            this.spinnerGridView.Name = "spinnerGridView";
            this.spinnerGridView.Size = new System.Drawing.Size(482, 482);
            this.spinnerGridView.Style = MetroFramework.MetroColorStyle.Lime;
            this.spinnerGridView.TabIndex = 2;
            this.spinnerGridView.UseSelectable = true;
            // 
            // groupMain
            // 
            this.groupMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupMain.Controls.Add(this.panelLegend);
            this.groupMain.Controls.Add(this.btReturn);
            this.groupMain.Controls.Add(this.radioShowAll);
            this.groupMain.Controls.Add(this.radioShowGreen);
            this.groupMain.Controls.Add(this.radioShowYellow);
            this.groupMain.Controls.Add(this.radioShowBorrowed);
            this.groupMain.Controls.Add(this.radioShowRed);
            this.groupMain.Controls.Add(this.gb_Kunden);
            this.groupMain.Controls.Add(this.btBorrow);
            this.groupMain.Controls.Add(this.btClearFilter);
            this.groupMain.Controls.Add(this.lbInformationFirst);
            this.groupMain.Controls.Add(this.checkShowCostumer);
            this.groupMain.Controls.Add(this.checkShowAvailable);
            this.groupMain.Controls.Add(this.lbInformationSecond);
            this.groupMain.Controls.Add(this.metroPanel1);
            this.groupMain.HorizontalScrollbarBarColor = true;
            this.groupMain.HorizontalScrollbarHighlightOnWheel = false;
            this.groupMain.HorizontalScrollbarSize = 10;
            this.groupMain.Location = new System.Drawing.Point(23, 63);
            this.groupMain.Name = "groupMain";
            this.groupMain.Size = new System.Drawing.Size(385, 524);
            this.groupMain.TabIndex = 0;
            this.groupMain.VerticalScrollbarBarColor = true;
            this.groupMain.VerticalScrollbarHighlightOnWheel = false;
            this.groupMain.VerticalScrollbarSize = 10;
            // 
            // panelLegend
            // 
            this.panelLegend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLegend.Controls.Add(this.lbLegendGreen);
            this.panelLegend.Controls.Add(this.lbLegendYellow);
            this.panelLegend.Controls.Add(this.lbLegendRed);
            this.panelLegend.Controls.Add(this.lbLegendDivider);
            this.panelLegend.Controls.Add(this.lb_legende);
            this.panelLegend.HorizontalScrollbarBarColor = true;
            this.panelLegend.HorizontalScrollbarHighlightOnWheel = false;
            this.panelLegend.HorizontalScrollbarSize = 10;
            this.panelLegend.Location = new System.Drawing.Point(259, 336);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(123, 152);
            this.panelLegend.Style = MetroFramework.MetroColorStyle.Green;
            this.panelLegend.TabIndex = 41;
            this.panelLegend.VerticalScrollbarBarColor = true;
            this.panelLegend.VerticalScrollbarHighlightOnWheel = false;
            this.panelLegend.VerticalScrollbarSize = 10;
            // 
            // lbLegendGreen
            // 
            this.lbLegendGreen.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbLegendGreen.Location = new System.Drawing.Point(14, 107);
            this.lbLegendGreen.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.lbLegendGreen.Name = "lbLegendGreen";
            this.lbLegendGreen.Size = new System.Drawing.Size(95, 34);
            this.lbLegendGreen.Style = MetroFramework.MetroColorStyle.Green;
            this.lbLegendGreen.TabIndex = 38;
            this.lbLegendGreen.Text = "Rückgabestatus: im Zeitplan";
            this.lbLegendGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLegendGreen.UseCustomForeColor = true;
            this.lbLegendGreen.WrapToLine = true;
            // 
            // lbLegendYellow
            // 
            this.lbLegendYellow.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbLegendYellow.Location = new System.Drawing.Point(14, 70);
            this.lbLegendYellow.Margin = new System.Windows.Forms.Padding(3, 3, 0, 0);
            this.lbLegendYellow.Name = "lbLegendYellow";
            this.lbLegendYellow.Size = new System.Drawing.Size(95, 34);
            this.lbLegendYellow.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lbLegendYellow.TabIndex = 38;
            this.lbLegendYellow.Text = "Rückgabestatus: heute";
            this.lbLegendYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLegendYellow.UseCustomForeColor = true;
            this.lbLegendYellow.WrapToLine = true;
            // 
            // lbLegendRed
            // 
            this.lbLegendRed.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbLegendRed.Location = new System.Drawing.Point(14, 33);
            this.lbLegendRed.Name = "lbLegendRed";
            this.lbLegendRed.Size = new System.Drawing.Size(95, 34);
            this.lbLegendRed.Style = MetroFramework.MetroColorStyle.Red;
            this.lbLegendRed.TabIndex = 38;
            this.lbLegendRed.Text = "Rückgabestatus: überfällig";
            this.lbLegendRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbLegendRed.UseCustomForeColor = true;
            this.lbLegendRed.WrapToLine = true;
            // 
            // lbLegendDivider
            // 
            this.lbLegendDivider.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lbLegendDivider.Location = new System.Drawing.Point(3, 18);
            this.lbLegendDivider.Name = "lbLegendDivider";
            this.lbLegendDivider.Size = new System.Drawing.Size(115, 15);
            this.lbLegendDivider.Style = MetroFramework.MetroColorStyle.Red;
            this.lbLegendDivider.TabIndex = 38;
            this.lbLegendDivider.Text = "----------------";
            this.lbLegendDivider.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_legende
            // 
            this.lb_legende.Location = new System.Drawing.Point(3, 3);
            this.lb_legende.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lb_legende.Name = "lb_legende";
            this.lb_legende.Size = new System.Drawing.Size(115, 15);
            this.lb_legende.TabIndex = 38;
            this.lb_legende.Text = "Farblegende";
            this.lb_legende.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // radioShowAll
            // 
            this.radioShowAll.Checked = true;
            this.radioShowAll.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioShowAll.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.radioShowAll.Location = new System.Drawing.Point(3, 472);
            this.radioShowAll.Name = "radioShowAll";
            this.radioShowAll.Size = new System.Drawing.Size(267, 19);
            this.radioShowAll.Style = MetroFramework.MetroColorStyle.Lime;
            this.radioShowAll.TabIndex = 15;
            this.radioShowAll.TabStop = true;
            this.radioShowAll.Text = "Alle Bücher filtern";
            this.toolTipMain.SetToolTip(this.radioShowAll, "Anzeigen von allen Exemplaren.");
            this.radioShowAll.UseSelectable = true;
            this.radioShowAll.CheckedChanged += new System.EventHandler(this.Rb_Default_CheckedChanged);
            // 
            // radioShowGreen
            // 
            this.radioShowGreen.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioShowGreen.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.radioShowGreen.Location = new System.Drawing.Point(3, 450);
            this.radioShowGreen.Name = "radioShowGreen";
            this.radioShowGreen.Size = new System.Drawing.Size(267, 19);
            this.radioShowGreen.Style = MetroFramework.MetroColorStyle.Lime;
            this.radioShowGreen.TabIndex = 14;
            this.radioShowGreen.Text = "Nur nicht überfällige Bücher einblenden\r\n";
            this.toolTipMain.SetToolTip(this.radioShowGreen, "Anzeige von allen ausgeliehenen Exemplaren, welche nicht überfällig sind.");
            this.radioShowGreen.UseSelectable = true;
            this.radioShowGreen.CheckedChanged += new System.EventHandler(this.Rb_GREENonly_CheckedChanged);
            // 
            // radioShowYellow
            // 
            this.radioShowYellow.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioShowYellow.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.radioShowYellow.Location = new System.Drawing.Point(3, 428);
            this.radioShowYellow.Name = "radioShowYellow";
            this.radioShowYellow.Size = new System.Drawing.Size(267, 19);
            this.radioShowYellow.Style = MetroFramework.MetroColorStyle.Lime;
            this.radioShowYellow.TabIndex = 13;
            this.radioShowYellow.Text = "Nur heute fällige Bücher einblenden\r\n";
            this.toolTipMain.SetToolTip(this.radioShowYellow, "Anzeigen von allen Exemplaren, die am heutigen Tag abzugeben sind.");
            this.radioShowYellow.UseSelectable = true;
            this.radioShowYellow.CheckedChanged += new System.EventHandler(this.Rb_YELLOWonly_CheckedChanged);
            // 
            // radioShowBorrowed
            // 
            this.radioShowBorrowed.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioShowBorrowed.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.radioShowBorrowed.Location = new System.Drawing.Point(3, 384);
            this.radioShowBorrowed.Name = "radioShowBorrowed";
            this.radioShowBorrowed.Size = new System.Drawing.Size(267, 19);
            this.radioShowBorrowed.Style = MetroFramework.MetroColorStyle.Lime;
            this.radioShowBorrowed.TabIndex = 12;
            this.radioShowBorrowed.Text = "Alle verliehenen Bücher einblenden";
            this.radioShowBorrowed.UseSelectable = true;
            this.radioShowBorrowed.CheckedChanged += new System.EventHandler(this.rb_allColors_CheckedChanged);
            // 
            // radioShowRed
            // 
            this.radioShowRed.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioShowRed.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.radioShowRed.Location = new System.Drawing.Point(3, 406);
            this.radioShowRed.Name = "radioShowRed";
            this.radioShowRed.Size = new System.Drawing.Size(267, 19);
            this.radioShowRed.Style = MetroFramework.MetroColorStyle.Lime;
            this.radioShowRed.TabIndex = 12;
            this.radioShowRed.Text = "Nur überfällige Bücher einblenden\r\n";
            this.toolTipMain.SetToolTip(this.radioShowRed, "Anzeigen von allen Exemplaren, die bereits hätten abgegeben werden müssen.");
            this.radioShowRed.UseSelectable = true;
            this.radioShowRed.CheckedChanged += new System.EventHandler(this.Rb_REDonly_CheckedChanged);
            // 
            // workerMain
            // 
            this.workerMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker1_DoWork);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // lbListElements
            // 
            this.lbListElements.AutoSize = true;
            this.lbListElements.Location = new System.Drawing.Point(260, 3);
            this.lbListElements.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbListElements.Name = "lbListElements";
            this.lbListElements.Size = new System.Drawing.Size(0, 0);
            this.lbListElements.TabIndex = 42;
            // 
            // lbListInfo
            // 
            this.lbListInfo.AutoSize = true;
            this.lbListInfo.Location = new System.Drawing.Point(130, 3);
            this.lbListInfo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbListInfo.Name = "lbListInfo";
            this.lbListInfo.Size = new System.Drawing.Size(117, 19);
            this.lbListInfo.TabIndex = 43;
            this.lbListInfo.Text = "Exemplare in Liste:";
            // 
            // btResetList
            // 
            this.btResetList.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btResetList.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btResetList.Location = new System.Drawing.Point(3, 3);
            this.btResetList.Name = "btResetList";
            this.btResetList.Size = new System.Drawing.Size(122, 24);
            this.btResetList.TabIndex = 21;
            this.btResetList.Text = "Liste zurücksetzen";
            this.toolTipMain.SetToolTip(this.btResetList, "Klicken Sie hier, um die Liste zurückzusetzen.");
            this.btResetList.UseSelectable = true;
            this.btResetList.Click += new System.EventHandler(this.Bt_reset_Click);
            // 
            // groupList
            // 
            this.groupList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupList.Controls.Add(this.lbListInfo);
            this.groupList.Controls.Add(this.lbListElements);
            this.groupList.Controls.Add(this.btResetList);
            this.groupList.HorizontalScrollbarBarColor = true;
            this.groupList.HorizontalScrollbarHighlightOnWheel = false;
            this.groupList.HorizontalScrollbarSize = 10;
            this.groupList.Location = new System.Drawing.Point(414, 557);
            this.groupList.Name = "groupList";
            this.groupList.Size = new System.Drawing.Size(636, 30);
            this.groupList.TabIndex = 20;
            this.groupList.VerticalScrollbarBarColor = true;
            this.groupList.VerticalScrollbarHighlightOnWheel = false;
            this.groupList.VerticalScrollbarSize = 10;
            // 
            // toolTipMain
            // 
            this.toolTipMain.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolTipMain.StyleManager = null;
            this.toolTipMain.Theme = MetroFramework.MetroThemeStyle.Light;
            this.toolTipMain.Popup += new System.Windows.Forms.PopupEventHandler(this.MetroToolTip1_Popup);
            // 
            // styleManagerOverview
            // 
            this.styleManagerOverview.Owner = this;
            this.styleManagerOverview.Style = MetroFramework.MetroColorStyle.Lime;
            // 
            // timerKeyInput
            // 
            this.timerKeyInput.Interval = 500;
            this.timerKeyInput.Tick += new System.EventHandler(this.timer_input_Tick);
            // 
            // FormOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.groupList);
            this.Controls.Add(this.groupMain);
            this.Controls.Add(this.groupGridView);
            this.Controls.Add(this.btClose);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "FormOverview";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.helpProvider.SetShowHelp(this, false);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Lime;
            this.Text = "Buchübersicht";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Deactivate += new System.EventHandler(this.w_s_buchsuche_Deactivate);
            this.Shown += new System.EventHandler(this.w_s_buchsuche_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.gridOverview)).EndInit();
            this.contextMenuBorrow.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.gb_Kunden.ResumeLayout(false);
            this.groupGridView.ResumeLayout(false);
            this.groupMain.ResumeLayout(false);
            this.groupMain.PerformLayout();
            this.panelLegend.ResumeLayout(false);
            this.groupList.ResumeLayout(false);
            this.groupList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerOverview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gridOverview;
        private MetroFramework.Controls.MetroCheckBox checkShowCostumer;
        private MetroFramework.Controls.MetroCheckBox checkShowAvailable;
        private MetroFramework.Controls.MetroButton btBorrow;
        private MetroFramework.Controls.MetroTextBox tbTitle;
        private MetroFramework.Controls.MetroButton btClearFilter;
        private AdvancedComboBox cbGenre;
        private AdvancedComboBox cbAuthor;
        private AdvancedComboBox cbPublisher;
        private MetroFramework.Controls.MetroTextBox tbSurname;
        private MetroFramework.Controls.MetroTextBox tbFirstName;
        private MetroFramework.Controls.MetroTextBox tbCopyIsbn;
        private MetroFramework.Controls.MetroTextBox tbCopyId;
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroTextBox tbClass;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lbInformationFirst;
        private MetroFramework.Controls.MetroPanel gb_Kunden;
        private MetroFramework.Controls.MetroLabel lbInformationSecond;
        private MetroFramework.Controls.MetroPanel groupGridView;
        private MetroFramework.Controls.MetroPanel groupMain;
        private MetroFramework.Controls.MetroButton btClose;
        private MetroFramework.Controls.MetroLabel lbGenre;
        private MetroFramework.Controls.MetroLabel lbCopyId;
        private MetroFramework.Controls.MetroLabel lbCopyIsbn;
        private MetroFramework.Controls.MetroLabel lbAuthor;
        private MetroFramework.Controls.MetroLabel lbPublisher;
        private MetroFramework.Controls.MetroLabel lbTitle;
        private MetroFramework.Controls.MetroLabel lbFirstName;
        private MetroFramework.Controls.MetroLabel lbSurname;
        private MetroFramework.Controls.MetroLabel lbClass;
        private MetroFramework.Controls.MetroContextMenu contextMenuBorrow;
        private System.Windows.Forms.ToolStripMenuItem ausleihen;
        private MetroFramework.Controls.MetroRadioButton radioShowAll;
        private MetroFramework.Controls.MetroRadioButton radioShowGreen;
        private MetroFramework.Controls.MetroRadioButton radioShowYellow;
        private MetroFramework.Controls.MetroRadioButton radioShowRed;
        private MetroFramework.Controls.MetroProgressSpinner spinnerGridView;
        private System.ComponentModel.BackgroundWorker workerMain;
        private MetroFramework.Controls.MetroProgressSpinner spinnerAttributes;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem exemplarZurückgebenToolStripMenuItem;
        private MetroFramework.Controls.MetroButton btReturn;
        private System.Windows.Forms.ToolStripMenuItem ausleihlisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ausleihenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rueckgabelisteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hinzufügenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zurueckgebenToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lbListElements;
        private MetroFramework.Controls.MetroLabel lbListInfo;
        private MetroFramework.Controls.MetroButton btResetList;
        private MetroFramework.Controls.MetroPanel groupList;
        private MetroFramework.Controls.MetroPanel panelLegend;
        private MetroFramework.Controls.MetroLabel lbLegendGreen;
        private MetroFramework.Controls.MetroLabel lbLegendYellow;
        private MetroFramework.Controls.MetroLabel lbLegendRed;
        private MetroFramework.Controls.MetroLabel lbLegendDivider;
        private MetroFramework.Controls.MetroLabel lb_legende;
        private System.Windows.Forms.ToolStripMenuItem kundenAnzeigenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buchAnzeigenToolStripMenuItem;
        private MetroFramework.Components.MetroToolTip toolTipMain;
        private MetroFramework.Components.MetroStyleManager styleManagerOverview;
        private System.Windows.Forms.Timer timerKeyInput;
        private MetroFramework.Controls.MetroRadioButton radioShowBorrowed;
    }
}
