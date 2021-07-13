namespace Bibo_Verwaltung
{
    partial class Form_Copy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Copy));
            this.gv_Exemplare = new MetroFramework.Controls.MetroGrid();
            this.contextMenuStrip = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcodeDruckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gb_BarcodeBox = new System.Windows.Forms.GroupBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.BarcodeBox = new System.Windows.Forms.PictureBox();
            this.mtb_Barcode = new MetroFramework.Controls.MetroTextBox();
            this.mlb_barcode = new MetroFramework.Controls.MetroLabel();
            this.bt_Print = new MetroFramework.Controls.MetroButton();
            this.tb_ExempCount = new MetroFramework.Controls.MetroTextBox();
            this.mlb_Vorhanden = new MetroFramework.Controls.MetroLabel();
            this.mlb_ExempCount = new MetroFramework.Controls.MetroLabel();
            this.tb_Vorhanden = new MetroFramework.Controls.MetroTextBox();
            this.bt_Clear = new MetroFramework.Controls.MetroButton();
            this.bt_zustand_add = new MetroFramework.Controls.MetroButton();
            this.lb_Message = new MetroFramework.Controls.MetroTextBox();
            this.bt_Add = new MetroFramework.Controls.MetroButton();
            this.rb_delete = new MetroFramework.Controls.MetroRadioButton();
            this.rb_edit = new MetroFramework.Controls.MetroRadioButton();
            this.rb_neu = new MetroFramework.Controls.MetroRadioButton();
            this.mlb_AufDat = new MetroFramework.Controls.MetroLabel();
            this.mlb_Zustand = new MetroFramework.Controls.MetroLabel();
            this.mlb_ID = new MetroFramework.Controls.MetroLabel();
            this.mlb_ISBN = new MetroFramework.Controls.MetroLabel();
            this.tb_ID = new MetroFramework.Controls.MetroTextBox();
            this.tb_ISBN = new MetroFramework.Controls.MetroTextBox();
            this.bt_Close = new MetroFramework.Controls.MetroButton();
            this.mbt_Export = new MetroFramework.Controls.MetroButton();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.acb_Zustand = new Bibo_Verwaltung.AdvancedComboBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.tpanel = new Bibo_Verwaltung.TransparentPanel();
            this.dTP_AufDat = new MetroFramework.Controls.MetroDateTime();
            this.rb_search = new MetroFramework.Controls.MetroRadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.metroProgressSpinner1 = new MetroFramework.Controls.MetroProgressSpinner();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.mbt_Import = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.styleManagerCopy = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Exemplare)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            this.gb_BarcodeBox.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBox)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Exemplare
            // 
            this.gv_Exemplare.AllowUserToAddRows = false;
            this.gv_Exemplare.AllowUserToDeleteRows = false;
            this.gv_Exemplare.AllowUserToResizeColumns = false;
            this.gv_Exemplare.AllowUserToResizeRows = false;
            this.gv_Exemplare.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Exemplare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_Exemplare.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Exemplare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Exemplare.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Exemplare.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Exemplare.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Exemplare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Exemplare.ContextMenuStrip = this.contextMenuStrip;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Exemplare.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Exemplare.EnableHeadersVisualStyles = false;
            this.gv_Exemplare.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Exemplare.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.gv_Exemplare, "Hier werden ihnen alle vorhandenen Buchexemplare angezeigt.");
            this.gv_Exemplare.Location = new System.Drawing.Point(3, 3);
            this.gv_Exemplare.Name = "gv_Exemplare";
            this.gv_Exemplare.ReadOnly = true;
            this.gv_Exemplare.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Exemplare.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Exemplare.RowHeadersVisible = false;
            this.gv_Exemplare.RowHeadersWidth = 51;
            this.gv_Exemplare.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Exemplare.RowTemplate.DividerHeight = 1;
            this.gv_Exemplare.RowTemplate.Height = 24;
            this.gv_Exemplare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.gv_Exemplare, true);
            this.gv_Exemplare.Size = new System.Drawing.Size(807, 481);
            this.gv_Exemplare.TabIndex = 17;
            this.metroToolTip1.SetToolTip(this.gv_Exemplare, "    Hier werden Ihnen alle in der Datenbank vorhandenen Exemplare angezeigt.    ");
            this.gv_Exemplare.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Buch_CellDoubleClick);
            this.gv_Exemplare.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_buchid_CellMouseDown);
            this.gv_Exemplare.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gv_Exemplare_KeyDown);
            this.gv_Exemplare.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grid_buchid_MouseDown);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.contextMenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ladenToolStripMenuItem,
            this.entfernenToolStripMenuItem,
            this.barcodeDruckenToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(181, 92);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // barcodeDruckenToolStripMenuItem
            // 
            this.barcodeDruckenToolStripMenuItem.Name = "barcodeDruckenToolStripMenuItem";
            this.barcodeDruckenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.barcodeDruckenToolStripMenuItem.Text = "Barcode drucken";
            this.barcodeDruckenToolStripMenuItem.Click += new System.EventHandler(this.barcodeDruckenToolStripMenuItem_Click);
            // 
            // gb_BarcodeBox
            // 
            this.gb_BarcodeBox.Controls.Add(this.metroPanel4);
            this.gb_BarcodeBox.Controls.Add(this.mtb_Barcode);
            this.gb_BarcodeBox.Controls.Add(this.mlb_barcode);
            this.gb_BarcodeBox.Controls.Add(this.bt_Print);
            this.gb_BarcodeBox.Location = new System.Drawing.Point(3, 213);
            this.gb_BarcodeBox.Name = "gb_BarcodeBox";
            this.gb_BarcodeBox.Padding = new System.Windows.Forms.Padding(1);
            this.gb_BarcodeBox.Size = new System.Drawing.Size(328, 243);
            this.gb_BarcodeBox.TabIndex = 12;
            this.gb_BarcodeBox.TabStop = false;
            // 
            // metroPanel4
            // 
            this.metroPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel4.Controls.Add(this.BarcodeBox);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(5, 48);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(319, 161);
            this.metroPanel4.TabIndex = 27;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarcodeBox.Location = new System.Drawing.Point(0, 0);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(317, 159);
            this.BarcodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BarcodeBox.TabIndex = 23;
            this.BarcodeBox.TabStop = false;
            this.metroToolTip1.SetToolTip(this.BarcodeBox, "    Dies ist der Barcode des entsprechenden Exemplars.    ");
            // 
            // mtb_Barcode
            // 
            // 
            // 
            // 
            this.mtb_Barcode.CustomButton.Image = null;
            this.mtb_Barcode.CustomButton.Location = new System.Drawing.Point(137, 2);
            this.mtb_Barcode.CustomButton.Name = "";
            this.mtb_Barcode.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.mtb_Barcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtb_Barcode.CustomButton.TabIndex = 1;
            this.mtb_Barcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtb_Barcode.CustomButton.UseSelectable = true;
            this.mtb_Barcode.CustomButton.Visible = false;
            this.mtb_Barcode.Enabled = false;
            this.mtb_Barcode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtb_Barcode.Lines = new string[0];
            this.mtb_Barcode.Location = new System.Drawing.Point(135, 17);
            this.mtb_Barcode.MaxLength = 32767;
            this.mtb_Barcode.Name = "mtb_Barcode";
            this.mtb_Barcode.PasswordChar = '\0';
            this.mtb_Barcode.ReadOnly = true;
            this.mtb_Barcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtb_Barcode.SelectedText = "";
            this.mtb_Barcode.SelectionLength = 0;
            this.mtb_Barcode.SelectionStart = 0;
            this.mtb_Barcode.ShortcutsEnabled = true;
            this.mtb_Barcode.Size = new System.Drawing.Size(159, 24);
            this.mtb_Barcode.TabIndex = 12;
            this.mtb_Barcode.TabStop = false;
            this.metroToolTip1.SetToolTip(this.mtb_Barcode, "    Dies ist der Zahlwert für den Barcode.    ");
            this.mtb_Barcode.UseSelectable = true;
            this.mtb_Barcode.WaterMark = "Code";
            this.mtb_Barcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtb_Barcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mlb_barcode
            // 
            this.mlb_barcode.Location = new System.Drawing.Point(4, 17);
            this.mlb_barcode.Margin = new System.Windows.Forms.Padding(3);
            this.mlb_barcode.Name = "mlb_barcode";
            this.mlb_barcode.Size = new System.Drawing.Size(113, 24);
            this.mlb_barcode.TabIndex = 26;
            this.mlb_barcode.Text = "Barcode:";
            this.mlb_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_Print
            // 
            this.bt_Print.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Print.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Print, "Klicken sie hier, um den Barcode auszudrucken.");
            this.bt_Print.Location = new System.Drawing.Point(202, 215);
            this.bt_Print.Name = "bt_Print";
            this.helpProvider.SetShowHelp(this.bt_Print, true);
            this.bt_Print.Size = new System.Drawing.Size(122, 24);
            this.bt_Print.TabIndex = 13;
            this.bt_Print.Text = "Drucken";
            this.metroToolTip1.SetToolTip(this.bt_Print, "    Klicken sie hier, um den Barcode auszudrucken.    ");
            this.bt_Print.UseSelectable = true;
            this.bt_Print.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_ExempCount
            // 
            // 
            // 
            // 
            this.tb_ExempCount.CustomButton.Image = null;
            this.tb_ExempCount.CustomButton.Location = new System.Drawing.Point(51, 2);
            this.tb_ExempCount.CustomButton.Name = "";
            this.tb_ExempCount.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_ExempCount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ExempCount.CustomButton.TabIndex = 1;
            this.tb_ExempCount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ExempCount.CustomButton.UseSelectable = true;
            this.tb_ExempCount.CustomButton.Visible = false;
            this.tb_ExempCount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_ExempCount.Lines = new string[0];
            this.tb_ExempCount.Location = new System.Drawing.Point(138, 153);
            this.tb_ExempCount.MaxLength = 32767;
            this.tb_ExempCount.Name = "tb_ExempCount";
            this.tb_ExempCount.PasswordChar = '\0';
            this.tb_ExempCount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ExempCount.SelectedText = "";
            this.tb_ExempCount.SelectionLength = 0;
            this.tb_ExempCount.SelectionStart = 0;
            this.tb_ExempCount.ShortcutsEnabled = true;
            this.tb_ExempCount.Size = new System.Drawing.Size(73, 24);
            this.tb_ExempCount.TabIndex = 10;
            this.metroToolTip1.SetToolTip(this.tb_ExempCount, "    Geben Sie hier die Anzahl der Exemplare an, die neu hinzugefügt werden soll. " +
        "   ");
            this.tb_ExempCount.UseSelectable = true;
            this.tb_ExempCount.WaterMark = "Anzahl";
            this.tb_ExempCount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ExempCount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ExempCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_number_KeyPress);
            this.tb_ExempCount.Leave += new System.EventHandler(this.tb_number_Leave);
            // 
            // mlb_Vorhanden
            // 
            this.helpProvider.SetHelpString(this.mlb_Vorhanden, "Wählen sie hier die Anzahl der Bücher, welches sie hinzufügen möchten, ein.");
            this.mlb_Vorhanden.Location = new System.Drawing.Point(3, 183);
            this.mlb_Vorhanden.Margin = new System.Windows.Forms.Padding(3);
            this.mlb_Vorhanden.Name = "mlb_Vorhanden";
            this.helpProvider.SetShowHelp(this.mlb_Vorhanden, true);
            this.mlb_Vorhanden.Size = new System.Drawing.Size(117, 24);
            this.mlb_Vorhanden.TabIndex = 26;
            this.mlb_Vorhanden.Text = "Vorhanden:";
            this.mlb_Vorhanden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlb_ExempCount
            // 
            this.helpProvider.SetHelpString(this.mlb_ExempCount, "Wählen sie hier die Anzahl der Bücher, welches sie hinzufügen möchten, ein.");
            this.mlb_ExempCount.Location = new System.Drawing.Point(3, 153);
            this.mlb_ExempCount.Margin = new System.Windows.Forms.Padding(3);
            this.mlb_ExempCount.Name = "mlb_ExempCount";
            this.helpProvider.SetShowHelp(this.mlb_ExempCount, true);
            this.mlb_ExempCount.Size = new System.Drawing.Size(117, 24);
            this.mlb_ExempCount.TabIndex = 21;
            this.mlb_ExempCount.Text = "Anzahl Exemplare:";
            this.mlb_ExempCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_Vorhanden
            // 
            // 
            // 
            // 
            this.tb_Vorhanden.CustomButton.Image = null;
            this.tb_Vorhanden.CustomButton.Location = new System.Drawing.Point(51, 2);
            this.tb_Vorhanden.CustomButton.Name = "";
            this.tb_Vorhanden.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Vorhanden.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Vorhanden.CustomButton.TabIndex = 1;
            this.tb_Vorhanden.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Vorhanden.CustomButton.UseSelectable = true;
            this.tb_Vorhanden.CustomButton.Visible = false;
            this.tb_Vorhanden.Enabled = false;
            this.tb_Vorhanden.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_Vorhanden.Lines = new string[0];
            this.tb_Vorhanden.Location = new System.Drawing.Point(138, 183);
            this.tb_Vorhanden.MaxLength = 32767;
            this.tb_Vorhanden.Name = "tb_Vorhanden";
            this.tb_Vorhanden.PasswordChar = '\0';
            this.tb_Vorhanden.ReadOnly = true;
            this.tb_Vorhanden.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Vorhanden.SelectedText = "";
            this.tb_Vorhanden.SelectionLength = 0;
            this.tb_Vorhanden.SelectionStart = 0;
            this.tb_Vorhanden.ShortcutsEnabled = true;
            this.tb_Vorhanden.Size = new System.Drawing.Size(73, 24);
            this.tb_Vorhanden.TabIndex = 11;
            this.tb_Vorhanden.TabStop = false;
            this.metroToolTip1.SetToolTip(this.tb_Vorhanden, "    So viele Exemplare sind bereits in der Datenbank registriert.    ");
            this.tb_Vorhanden.UseSelectable = true;
            this.tb_Vorhanden.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Vorhanden.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Clear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Clear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Clear, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_Clear.Location = new System.Drawing.Point(3, 493);
            this.bt_Clear.Name = "bt_Clear";
            this.helpProvider.SetShowHelp(this.bt_Clear, true);
            this.bt_Clear.Size = new System.Drawing.Size(122, 24);
            this.bt_Clear.TabIndex = 14;
            this.bt_Clear.Text = "Leeren";
            this.metroToolTip1.SetToolTip(this.bt_Clear, "    Leeren sie alle oben liegenden Textfelder.    ");
            this.bt_Clear.UseSelectable = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_zustand_add
            // 
            this.bt_zustand_add.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_zustand_add.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_zustand_add, "Klicken sie auf diesen Button, um neue Zustände hinzuzufügen.");
            this.bt_zustand_add.Location = new System.Drawing.Point(303, 88);
            this.bt_zustand_add.Name = "bt_zustand_add";
            this.helpProvider.SetShowHelp(this.bt_zustand_add, true);
            this.bt_zustand_add.Size = new System.Drawing.Size(24, 24);
            this.bt_zustand_add.TabIndex = 8;
            this.bt_zustand_add.Text = "+";
            this.metroToolTip1.SetToolTip(this.bt_zustand_add, "    Klicken sie auf diesen Button, um neue Zustände hinzuzufügen.    ");
            this.bt_zustand_add.UseSelectable = true;
            this.bt_zustand_add.Click += new System.EventHandler(this.bt_zustand_Click);
            // 
            // lb_Message
            // 
            // 
            // 
            // 
            this.lb_Message.CustomButton.Image = null;
            this.lb_Message.CustomButton.Location = new System.Drawing.Point(300, 1);
            this.lb_Message.CustomButton.Name = "";
            this.lb_Message.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.lb_Message.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lb_Message.CustomButton.TabIndex = 1;
            this.lb_Message.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lb_Message.CustomButton.UseSelectable = true;
            this.lb_Message.CustomButton.Visible = false;
            this.lb_Message.Enabled = false;
            this.lb_Message.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lb_Message.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.lb_Message.Lines = new string[] {
        "Das Buch wurde erfolgreich hinzugefügt!"};
            this.lb_Message.Location = new System.Drawing.Point(3, 462);
            this.lb_Message.MaxLength = 32767;
            this.lb_Message.Multiline = true;
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.PasswordChar = '\0';
            this.lb_Message.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lb_Message.SelectedText = "";
            this.lb_Message.SelectionLength = 0;
            this.lb_Message.SelectionStart = 0;
            this.lb_Message.ShortcutsEnabled = true;
            this.lb_Message.Size = new System.Drawing.Size(324, 25);
            this.lb_Message.TabIndex = 17;
            this.lb_Message.TabStop = false;
            this.lb_Message.Text = "Das Buch wurde erfolgreich hinzugefügt!";
            this.lb_Message.UseSelectable = true;
            this.lb_Message.Visible = false;
            this.lb_Message.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lb_Message.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bt_Add
            // 
            this.bt_Add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Add.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Add.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Add, "Fügen sie alle oben eingetragen Daten hinzu.");
            this.bt_Add.Location = new System.Drawing.Point(205, 493);
            this.bt_Add.Name = "bt_Add";
            this.helpProvider.SetShowHelp(this.bt_Add, true);
            this.bt_Add.Size = new System.Drawing.Size(122, 24);
            this.bt_Add.TabIndex = 15;
            this.bt_Add.Text = "Hinzufügen";
            this.metroToolTip1.SetToolTip(this.bt_Add, "    Fügen sie alle oben eingetragen Daten hinzu.    ");
            this.bt_Add.UseSelectable = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // rb_delete
            // 
            this.rb_delete.AutoSize = true;
            this.rb_delete.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_delete.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_delete.Location = new System.Drawing.Point(252, 3);
            this.rb_delete.Name = "rb_delete";
            this.rb_delete.Size = new System.Drawing.Size(80, 19);
            this.rb_delete.TabIndex = 4;
            this.rb_delete.Text = "Entfernen";
            this.metroToolTip1.SetToolTip(this.rb_delete, "    Klicken sie hier, um ein vorhandenes Exemplar zu löschen.    ");
            this.rb_delete.UseSelectable = true;
            this.rb_delete.CheckedChanged += new System.EventHandler(this.rb_Delete_CheckedChanged);
            // 
            // rb_edit
            // 
            this.rb_edit.AutoSize = true;
            this.rb_edit.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_edit.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_edit.Location = new System.Drawing.Point(163, 3);
            this.rb_edit.Name = "rb_edit";
            this.rb_edit.Size = new System.Drawing.Size(88, 19);
            this.rb_edit.TabIndex = 3;
            this.rb_edit.Text = "Bearbeiten";
            this.metroToolTip1.SetToolTip(this.rb_edit, "    Klicken sie hier, um ein vorhandenes Exemplar zu bearbeiten.    ");
            this.rb_edit.UseSelectable = true;
            this.rb_edit.CheckedChanged += new System.EventHandler(this.rb_Edit_CheckedChanged);
            // 
            // rb_neu
            // 
            this.rb_neu.AutoSize = true;
            this.rb_neu.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb_neu.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_neu.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_neu.Location = new System.Drawing.Point(70, 3);
            this.rb_neu.Name = "rb_neu";
            this.rb_neu.Size = new System.Drawing.Size(90, 19);
            this.rb_neu.TabIndex = 2;
            this.rb_neu.Text = "Hinzufügen";
            this.metroToolTip1.SetToolTip(this.rb_neu, "    Klicken sie hier, um ein neues Exemplar hinzuzufügen.    ");
            this.rb_neu.UseSelectable = true;
            this.rb_neu.CheckedChanged += new System.EventHandler(this.rb_Neu_CheckedChanged);
            // 
            // mlb_AufDat
            // 
            this.helpProvider.SetHelpString(this.mlb_AufDat, "Wählen sie hier das Aufnahmedatum des Buches, welches sie hinzufügen möchten.");
            this.mlb_AufDat.Location = new System.Drawing.Point(3, 118);
            this.mlb_AufDat.Margin = new System.Windows.Forms.Padding(3);
            this.mlb_AufDat.Name = "mlb_AufDat";
            this.helpProvider.SetShowHelp(this.mlb_AufDat, true);
            this.mlb_AufDat.Size = new System.Drawing.Size(117, 29);
            this.mlb_AufDat.TabIndex = 5;
            this.mlb_AufDat.Text = "Aufnahmedatum:";
            this.mlb_AufDat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlb_Zustand
            // 
            this.helpProvider.SetHelpString(this.mlb_Zustand, "Tragen sie hier den Zustand des Buches, welches sie hinzufügen möchten, ein.");
            this.mlb_Zustand.Location = new System.Drawing.Point(3, 88);
            this.mlb_Zustand.Margin = new System.Windows.Forms.Padding(3);
            this.mlb_Zustand.Name = "mlb_Zustand";
            this.helpProvider.SetShowHelp(this.mlb_Zustand, true);
            this.mlb_Zustand.Size = new System.Drawing.Size(117, 24);
            this.mlb_Zustand.TabIndex = 4;
            this.mlb_Zustand.Text = "Zustand:";
            this.mlb_Zustand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlb_ID
            // 
            this.helpProvider.SetHelpString(this.mlb_ID, "Tragen sie hier die Buch-ID ein, um das gewünschte Buch zu laden. Buch-IDs werden" +
        " automatisch generiert.");
            this.mlb_ID.Location = new System.Drawing.Point(3, 58);
            this.mlb_ID.Margin = new System.Windows.Forms.Padding(3);
            this.mlb_ID.Name = "mlb_ID";
            this.helpProvider.SetShowHelp(this.mlb_ID, true);
            this.mlb_ID.Size = new System.Drawing.Size(117, 24);
            this.mlb_ID.TabIndex = 3;
            this.mlb_ID.Text = "Exemplar-ID:";
            this.mlb_ID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // mlb_ISBN
            // 
            this.helpProvider.SetHelpString(this.mlb_ISBN, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.mlb_ISBN.Location = new System.Drawing.Point(3, 28);
            this.mlb_ISBN.Margin = new System.Windows.Forms.Padding(3);
            this.mlb_ISBN.Name = "mlb_ISBN";
            this.helpProvider.SetShowHelp(this.mlb_ISBN, true);
            this.mlb_ISBN.Size = new System.Drawing.Size(117, 24);
            this.mlb_ISBN.TabIndex = 2;
            this.mlb_ISBN.Text = "ISBN:";
            this.mlb_ISBN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tb_ID
            // 
            // 
            // 
            // 
            this.tb_ID.CustomButton.Image = null;
            this.tb_ID.CustomButton.Location = new System.Drawing.Point(137, 2);
            this.tb_ID.CustomButton.Name = "";
            this.tb_ID.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_ID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ID.CustomButton.TabIndex = 1;
            this.tb_ID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ID.CustomButton.UseSelectable = true;
            this.tb_ID.CustomButton.Visible = false;
            this.tb_ID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_ID.Lines = new string[0];
            this.tb_ID.Location = new System.Drawing.Point(138, 58);
            this.tb_ID.MaxLength = 32767;
            this.tb_ID.Name = "tb_ID";
            this.tb_ID.PasswordChar = '\0';
            this.tb_ID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ID.SelectedText = "";
            this.tb_ID.SelectionLength = 0;
            this.tb_ID.SelectionStart = 0;
            this.tb_ID.ShortcutsEnabled = true;
            this.tb_ID.Size = new System.Drawing.Size(159, 24);
            this.tb_ID.TabIndex = 6;
            this.metroToolTip1.SetToolTip(this.tb_ID, "    Tragen Sie hier die Buch-ID ein (sichtbar auf dem Barcode).    ");
            this.tb_ID.UseSelectable = true;
            this.tb_ID.WaterMark = "ID";
            this.tb_ID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ID.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            this.tb_ID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_KeyPress);
            // 
            // tb_ISBN
            // 
            // 
            // 
            // 
            this.tb_ISBN.CustomButton.Image = null;
            this.tb_ISBN.CustomButton.Location = new System.Drawing.Point(137, 2);
            this.tb_ISBN.CustomButton.Name = "";
            this.tb_ISBN.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_ISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ISBN.CustomButton.TabIndex = 1;
            this.tb_ISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ISBN.CustomButton.UseSelectable = true;
            this.tb_ISBN.CustomButton.Visible = false;
            this.tb_ISBN.Enabled = false;
            this.tb_ISBN.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.helpProvider.SetHelpString(this.tb_ISBN, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.tb_ISBN.Lines = new string[0];
            this.tb_ISBN.Location = new System.Drawing.Point(138, 28);
            this.tb_ISBN.MaxLength = 32767;
            this.tb_ISBN.Name = "tb_ISBN";
            this.tb_ISBN.PasswordChar = '\0';
            this.tb_ISBN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ISBN.SelectedText = "";
            this.tb_ISBN.SelectionLength = 0;
            this.tb_ISBN.SelectionStart = 0;
            this.tb_ISBN.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_ISBN, true);
            this.tb_ISBN.Size = new System.Drawing.Size(159, 24);
            this.tb_ISBN.TabIndex = 5;
            this.metroToolTip1.SetToolTip(this.tb_ISBN, "    Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.    ");
            this.tb_ISBN.UseSelectable = true;
            this.tb_ISBN.WaterMark = "ISBN";
            this.tb_ISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ISBN.TextChanged += new System.EventHandler(this.tb_isbn_TextChanged);
            // 
            // bt_Close
            // 
            this.bt_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Close.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Close.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Close, "Schließen sie das akuelle Fenster.");
            this.bt_Close.Location = new System.Drawing.Point(688, 3);
            this.bt_Close.Name = "bt_Close";
            this.helpProvider.SetShowHelp(this.bt_Close, true);
            this.bt_Close.Size = new System.Drawing.Size(122, 24);
            this.bt_Close.TabIndex = 21;
            this.bt_Close.Text = "Schließen";
            this.metroToolTip1.SetToolTip(this.bt_Close, "    Schließen sie das akuelle Fenster.    ");
            this.bt_Close.UseSelectable = true;
            this.bt_Close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // mbt_Export
            // 
            this.mbt_Export.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbt_Export.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.mbt_Export, "Exportieren sie ihre Buchdaten in eine Exceltabelle.");
            this.mbt_Export.Location = new System.Drawing.Point(131, 3);
            this.mbt_Export.Name = "mbt_Export";
            this.helpProvider.SetShowHelp(this.mbt_Export, true);
            this.mbt_Export.Size = new System.Drawing.Size(122, 24);
            this.mbt_Export.TabIndex = 20;
            this.mbt_Export.Text = "Daten-Export";
            this.metroToolTip1.SetToolTip(this.mbt_Export, "    Exportieren sie ihre Exemplardaten in eine Exceltabelle.    ");
            this.mbt_Export.UseSelectable = true;
            this.mbt_Export.Click += new System.EventHandler(this.mbt_Export_Click);
            // 
            // acb_Zustand
            // 
            this.acb_Zustand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.acb_Zustand.BorderColor = System.Drawing.Color.Gray;
            this.acb_Zustand.DataRowView = true;
            this.acb_Zustand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.acb_Zustand.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.acb_Zustand.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.acb_Zustand, "Tragen sie hier den Zustand des Buches, welches sie hinzufügen möchten, ein.");
            this.acb_Zustand.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.acb_Zustand.ItemHeight = 18;
            this.acb_Zustand.Location = new System.Drawing.Point(138, 88);
            this.acb_Zustand.Name = "acb_Zustand";
            this.helpProvider.SetShowHelp(this.acb_Zustand, true);
            this.acb_Zustand.Size = new System.Drawing.Size(159, 24);
            this.acb_Zustand.TabIndex = 7;
            this.metroToolTip1.SetToolTip(this.acb_Zustand, "    Tragen sie hier den Zustand des Buches, welches sie hinzufügen möchten, ein. " +
        "   ");
            this.acb_Zustand.TextChanged += new System.EventHandler(this.cb_zustand_TextChanged);
            this.acb_Zustand.Enter += new System.EventHandler(this.acb_Zustand_Enter);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.metroPanel1.Controls.Add(this.tpanel);
            this.metroPanel1.Controls.Add(this.gb_BarcodeBox);
            this.metroPanel1.Controls.Add(this.dTP_AufDat);
            this.metroPanel1.Controls.Add(this.rb_delete);
            this.metroPanel1.Controls.Add(this.lb_Message);
            this.metroPanel1.Controls.Add(this.tb_ExempCount);
            this.metroPanel1.Controls.Add(this.rb_search);
            this.metroPanel1.Controls.Add(this.rb_neu);
            this.metroPanel1.Controls.Add(this.rb_edit);
            this.metroPanel1.Controls.Add(this.mlb_Vorhanden);
            this.metroPanel1.Controls.Add(this.bt_Clear);
            this.metroPanel1.Controls.Add(this.mlb_ISBN);
            this.metroPanel1.Controls.Add(this.bt_Add);
            this.metroPanel1.Controls.Add(this.tb_Vorhanden);
            this.metroPanel1.Controls.Add(this.mlb_ExempCount);
            this.metroPanel1.Controls.Add(this.tb_ISBN);
            this.metroPanel1.Controls.Add(this.mlb_ID);
            this.metroPanel1.Controls.Add(this.tb_ID);
            this.metroPanel1.Controls.Add(this.acb_Zustand);
            this.metroPanel1.Controls.Add(this.bt_zustand_add);
            this.metroPanel1.Controls.Add(this.mlb_Zustand);
            this.metroPanel1.Controls.Add(this.mlb_AufDat);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(335, 522);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // tpanel
            // 
            this.tpanel.Location = new System.Drawing.Point(138, 88);
            this.tpanel.Name = "tpanel";
            this.tpanel.Size = new System.Drawing.Size(159, 24);
            this.tpanel.TabIndex = 27;
            this.tpanel.Visible = false;
            // 
            // dTP_AufDat
            // 
            this.dTP_AufDat.CustomFormat = " dd.MM.yyyy";
            this.dTP_AufDat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTP_AufDat.Location = new System.Drawing.Point(138, 118);
            this.dTP_AufDat.MinimumSize = new System.Drawing.Size(0, 29);
            this.dTP_AufDat.Name = "dTP_AufDat";
            this.dTP_AufDat.Size = new System.Drawing.Size(159, 29);
            this.dTP_AufDat.TabIndex = 9;
            this.metroToolTip1.SetToolTip(this.dTP_AufDat, "    Wählen Sie hier das Aufnahmedatum des Exemplares aus.    ");
            this.dTP_AufDat.ValueChanged += new System.EventHandler(this.DTP_AufDat_ValueChanged);
            // 
            // rb_search
            // 
            this.rb_search.AutoSize = true;
            this.rb_search.Checked = true;
            this.rb_search.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb_search.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_search.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_search.Location = new System.Drawing.Point(3, 3);
            this.rb_search.Name = "rb_search";
            this.rb_search.Size = new System.Drawing.Size(66, 19);
            this.rb_search.TabIndex = 1;
            this.rb_search.TabStop = true;
            this.rb_search.Text = "Suchen";
            this.rb_search.UseSelectable = true;
            this.rb_search.CheckedChanged += new System.EventHandler(this.Bt_search_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // metroProgressSpinner1
            // 
            this.metroProgressSpinner1.Location = new System.Drawing.Point(163, 3);
            this.metroProgressSpinner1.Maximum = 100;
            this.metroProgressSpinner1.Name = "metroProgressSpinner1";
            this.metroProgressSpinner1.Size = new System.Drawing.Size(481, 481);
            this.metroProgressSpinner1.TabIndex = 24;
            this.metroProgressSpinner1.UseSelectable = true;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BackgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            // 
            // mbt_Import
            // 
            this.mbt_Import.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbt_Import.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbt_Import.Location = new System.Drawing.Point(3, 3);
            this.mbt_Import.Name = "mbt_Import";
            this.mbt_Import.Size = new System.Drawing.Size(122, 24);
            this.mbt_Import.Style = MetroFramework.MetroColorStyle.Teal;
            this.mbt_Import.TabIndex = 19;
            this.mbt_Import.Text = "Daten-Import";
            this.metroToolTip1.SetToolTip(this.mbt_Import, "    Importieren Sie Daten von einer externen Quelle.    ");
            this.mbt_Import.UseSelectable = true;
            this.mbt_Import.Click += new System.EventHandler(this.mbt_Import_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.mbt_Import);
            this.metroPanel2.Controls.Add(this.mbt_Export);
            this.metroPanel2.Controls.Add(this.bt_Close);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(364, 553);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(813, 32);
            this.metroPanel2.TabIndex = 18;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel3.Controls.Add(this.metroProgressSpinner1);
            this.metroPanel3.Controls.Add(this.gv_Exemplare);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(364, 63);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(813, 487);
            this.metroPanel3.TabIndex = 16;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // msm_exemplare
            // 
            this.styleManagerCopy.Owner = this;
            // 
            // w_s_exemplare
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "w_s_exemplare";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exemplarverwaltung";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Activated += new System.EventHandler(this.w_s_buchid_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_buchid_FormClosing);
            this.Shown += new System.EventHandler(this.W_s_exemplare_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Exemplare)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            this.gb_BarcodeBox.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBox)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerCopy)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gv_Exemplare;
        private MetroFramework.Controls.MetroLabel mlb_AufDat;
        private MetroFramework.Controls.MetroLabel mlb_Zustand;
        private MetroFramework.Controls.MetroLabel mlb_ID;
        private MetroFramework.Controls.MetroLabel mlb_ISBN;
        private MetroFramework.Controls.MetroTextBox tb_ID;
        private MetroFramework.Controls.MetroTextBox tb_ISBN;
        private AdvancedComboBox acb_Zustand;
        private MetroFramework.Controls.MetroRadioButton rb_delete;
        private MetroFramework.Controls.MetroRadioButton rb_edit;
        private MetroFramework.Controls.MetroRadioButton rb_neu;
        private MetroFramework.Controls.MetroButton bt_Add;
        private MetroFramework.Controls.MetroTextBox lb_Message;
        private MetroFramework.Controls.MetroButton bt_zustand_add;
        private MetroFramework.Controls.MetroButton bt_Clear;
        private MetroFramework.Controls.MetroButton bt_Close;
        private MetroFramework.Controls.MetroButton mbt_Export;
        private MetroFramework.Controls.MetroTextBox tb_Vorhanden;
        private MetroFramework.Controls.MetroLabel mlb_ExempCount;
        private System.Windows.Forms.PictureBox BarcodeBox;
        private MetroFramework.Controls.MetroTextBox mtb_Barcode;
        private MetroFramework.Controls.MetroButton bt_Print;
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroTextBox tb_ExempCount;
        private MetroFramework.Controls.MetroLabel mlb_Vorhanden;
        private System.Windows.Forms.GroupBox gb_BarcodeBox;
        private MetroFramework.Controls.MetroContextMenu contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcodeDruckenToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel mlb_barcode;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinner1;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private MetroFramework.Controls.MetroDateTime dTP_AufDat;
        private MetroFramework.Controls.MetroButton mbt_Import;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroRadioButton rb_search;
        private MetroFramework.Components.MetroStyleManager styleManagerCopy;
        private TransparentPanel tpanel;
    }
}