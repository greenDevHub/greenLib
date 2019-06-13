namespace Bibo_Verwaltung
{
    partial class w_s_buchid
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_buchid));
            this.grid_buchid = new MetroFramework.Controls.MetroGrid();
            this.contextMenuStrip1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcodeDruckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BarcodeBox = new System.Windows.Forms.PictureBox();
            this.tb_number = new MetroFramework.Controls.MetroTextBox();
            this.label2 = new MetroFramework.Controls.MetroLabel();
            this.button1 = new MetroFramework.Controls.MetroButton();
            this.tb_Barcode = new MetroFramework.Controls.MetroTextBox();
            this.label1 = new MetroFramework.Controls.MetroLabel();
            this.tb_anzahl = new MetroFramework.Controls.MetroTextBox();
            this.bt_clear = new MetroFramework.Controls.MetroButton();
            this.bt_zustand_add = new MetroFramework.Controls.MetroButton();
            this.lb = new MetroFramework.Controls.MetroTextBox();
            this.bt_add = new MetroFramework.Controls.MetroButton();
            this.rb_delete = new MetroFramework.Controls.MetroRadioButton();
            this.rb_edit = new MetroFramework.Controls.MetroRadioButton();
            this.rb_neu = new MetroFramework.Controls.MetroRadioButton();
            this.dTP_aufnahme = new MetroFramework.Controls.MetroDateTime();
            this.lb_aufnahme = new MetroFramework.Controls.MetroLabel();
            this.lb_zustand = new MetroFramework.Controls.MetroLabel();
            this.lb_id = new MetroFramework.Controls.MetroLabel();
            this.lb_isbn = new MetroFramework.Controls.MetroLabel();
            this.tb_id = new MetroFramework.Controls.MetroTextBox();
            this.tb_isbn = new MetroFramework.Controls.MetroTextBox();
            this.bt_close = new MetroFramework.Controls.MetroButton();
            this.bt_export = new MetroFramework.Controls.MetroButton();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.cb_zustand = new Bibo_Verwaltung.AdvancedComboBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_buchid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBox)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grid_buchid
            // 
            this.grid_buchid.AllowUserToAddRows = false;
            this.grid_buchid.AllowUserToDeleteRows = false;
            this.grid_buchid.AllowUserToResizeColumns = false;
            this.grid_buchid.AllowUserToResizeRows = false;
            this.grid_buchid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_buchid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid_buchid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid_buchid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.grid_buchid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_buchid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_buchid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_buchid.ContextMenuStrip = this.contextMenuStrip1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_buchid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid_buchid.EnableHeadersVisualStyles = false;
            this.grid_buchid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.grid_buchid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.grid_buchid, "Hier werden ihnen alle vorhandenen Buchexemplare angezeigt.");
            this.grid_buchid.Location = new System.Drawing.Point(470, 63);
            this.grid_buchid.Name = "grid_buchid";
            this.grid_buchid.ReadOnly = true;
            this.grid_buchid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid_buchid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid_buchid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_buchid.RowTemplate.DividerHeight = 1;
            this.grid_buchid.RowTemplate.Height = 24;
            this.grid_buchid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.grid_buchid, true);
            this.grid_buchid.Size = new System.Drawing.Size(707, 484);
            this.grid_buchid.TabIndex = 0;
            this.grid_buchid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Buch_CellDoubleClick);
            this.grid_buchid.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grid_buchid_CellMouseDown);
            this.grid_buchid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.grid_buchid_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ladenToolStripMenuItem,
            this.entfernenToolStripMenuItem,
            this.barcodeDruckenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(190, 76);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // barcodeDruckenToolStripMenuItem
            // 
            this.barcodeDruckenToolStripMenuItem.Name = "barcodeDruckenToolStripMenuItem";
            this.barcodeDruckenToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.barcodeDruckenToolStripMenuItem.Text = "Barcode drucken";
            this.barcodeDruckenToolStripMenuItem.Click += new System.EventHandler(this.barcodeDruckenToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BarcodeBox);
            this.groupBox1.Location = new System.Drawing.Point(183, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1);
            this.groupBox1.Size = new System.Drawing.Size(228, 112);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarcodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarcodeBox.Location = new System.Drawing.Point(1, 16);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(226, 95);
            this.BarcodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BarcodeBox.TabIndex = 23;
            this.BarcodeBox.TabStop = false;
            // 
            // tb_number
            // 
            // 
            // 
            // 
            this.tb_number.CustomButton.Image = null;
            this.tb_number.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.tb_number.CustomButton.Name = "";
            this.tb_number.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_number.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_number.CustomButton.TabIndex = 1;
            this.tb_number.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_number.CustomButton.UseSelectable = true;
            this.tb_number.CustomButton.Visible = false;
            this.tb_number.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_number.Lines = new string[] {
        "1"};
            this.tb_number.Location = new System.Drawing.Point(183, 153);
            this.tb_number.MaxLength = 32767;
            this.tb_number.Name = "tb_number";
            this.tb_number.PasswordChar = '\0';
            this.tb_number.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_number.SelectedText = "";
            this.tb_number.SelectionLength = 0;
            this.tb_number.SelectionStart = 0;
            this.tb_number.ShortcutsEnabled = true;
            this.tb_number.Size = new System.Drawing.Size(228, 24);
            this.tb_number.TabIndex = 27;
            this.tb_number.Text = "1";
            this.tb_number.UseSelectable = true;
            this.tb_number.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_number.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_number_KeyPress);
            this.tb_number.Leave += new System.EventHandler(this.tb_number_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.helpProvider.SetHelpString(this.label2, "Wählen sie hier die Anzahl der Bücher, welches sie hinzufügen möchten, ein.");
            this.label2.Location = new System.Drawing.Point(3, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.helpProvider.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 26;
            this.label2.Text = "Vorhanden:";
            // 
            // button1
            // 
            this.button1.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.button1.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.button1, "Klicken sie hier, um den Barcode auszudrucken.");
            this.button1.Location = new System.Drawing.Point(183, 391);
            this.button1.Name = "button1";
            this.helpProvider.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(228, 24);
            this.button1.TabIndex = 25;
            this.button1.Text = "Drucken";
            this.button1.UseSelectable = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_Barcode
            // 
            // 
            // 
            // 
            this.tb_Barcode.CustomButton.Image = null;
            this.tb_Barcode.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.tb_Barcode.CustomButton.Name = "";
            this.tb_Barcode.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Barcode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Barcode.CustomButton.TabIndex = 1;
            this.tb_Barcode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Barcode.CustomButton.UseSelectable = true;
            this.tb_Barcode.CustomButton.Visible = false;
            this.tb_Barcode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_Barcode.Lines = new string[0];
            this.tb_Barcode.Location = new System.Drawing.Point(183, 243);
            this.tb_Barcode.MaxLength = 32767;
            this.tb_Barcode.Name = "tb_Barcode";
            this.tb_Barcode.PasswordChar = '\0';
            this.tb_Barcode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Barcode.SelectedText = "";
            this.tb_Barcode.SelectionLength = 0;
            this.tb_Barcode.SelectionStart = 0;
            this.tb_Barcode.ShortcutsEnabled = true;
            this.tb_Barcode.Size = new System.Drawing.Size(228, 24);
            this.tb_Barcode.TabIndex = 24;
            this.tb_Barcode.UseSelectable = true;
            this.tb_Barcode.Visible = false;
            this.tb_Barcode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Barcode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.helpProvider.SetHelpString(this.label1, "Wählen sie hier die Anzahl der Bücher, welches sie hinzufügen möchten, ein.");
            this.label1.Location = new System.Drawing.Point(3, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(3);
            this.label1.Name = "label1";
            this.helpProvider.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Anzahl Exemplare:";
            // 
            // tb_anzahl
            // 
            // 
            // 
            // 
            this.tb_anzahl.CustomButton.Image = null;
            this.tb_anzahl.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.tb_anzahl.CustomButton.Name = "";
            this.tb_anzahl.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_anzahl.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_anzahl.CustomButton.TabIndex = 1;
            this.tb_anzahl.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_anzahl.CustomButton.UseSelectable = true;
            this.tb_anzahl.CustomButton.Visible = false;
            this.tb_anzahl.Enabled = false;
            this.tb_anzahl.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_anzahl.Lines = new string[0];
            this.tb_anzahl.Location = new System.Drawing.Point(183, 183);
            this.tb_anzahl.MaxLength = 32767;
            this.tb_anzahl.Name = "tb_anzahl";
            this.tb_anzahl.PasswordChar = '\0';
            this.tb_anzahl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_anzahl.SelectedText = "";
            this.tb_anzahl.SelectionLength = 0;
            this.tb_anzahl.SelectionStart = 0;
            this.tb_anzahl.ShortcutsEnabled = true;
            this.tb_anzahl.Size = new System.Drawing.Size(228, 24);
            this.tb_anzahl.TabIndex = 20;
            this.tb_anzahl.UseSelectable = true;
            this.tb_anzahl.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_anzahl.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            // 
            // bt_clear
            // 
            this.bt_clear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_clear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_clear, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_clear.Location = new System.Drawing.Point(300, 213);
            this.bt_clear.Name = "bt_clear";
            this.helpProvider.SetShowHelp(this.bt_clear, true);
            this.bt_clear.Size = new System.Drawing.Size(111, 24);
            this.bt_clear.TabIndex = 19;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseSelectable = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_zustand_add
            // 
            this.bt_zustand_add.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_zustand_add.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_zustand_add, "Klicken sie auf diesen Button, um neue Zustände hinzuzufügen.");
            this.bt_zustand_add.Location = new System.Drawing.Point(417, 88);
            this.bt_zustand_add.Name = "bt_zustand_add";
            this.helpProvider.SetShowHelp(this.bt_zustand_add, true);
            this.bt_zustand_add.Size = new System.Drawing.Size(24, 24);
            this.bt_zustand_add.TabIndex = 18;
            this.bt_zustand_add.Text = "+";
            this.bt_zustand_add.UseSelectable = true;
            this.bt_zustand_add.Click += new System.EventHandler(this.bt_zustand_Click);
            // 
            // lb
            // 
            // 
            // 
            // 
            this.lb.CustomButton.Image = null;
            this.lb.CustomButton.Location = new System.Drawing.Point(115, 2);
            this.lb.CustomButton.Name = "";
            this.lb.CustomButton.Size = new System.Drawing.Size(49, 49);
            this.lb.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.lb.CustomButton.TabIndex = 1;
            this.lb.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lb.CustomButton.UseSelectable = true;
            this.lb.CustomButton.Visible = false;
            this.lb.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.lb.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.lb.Lines = new string[] {
        "Das Buch wurde erfolgreich hinzugefügt!"};
            this.lb.Location = new System.Drawing.Point(3, 361);
            this.lb.MaxLength = 32767;
            this.lb.Multiline = true;
            this.lb.Name = "lb";
            this.lb.PasswordChar = '\0';
            this.lb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.lb.SelectedText = "";
            this.lb.SelectionLength = 0;
            this.lb.SelectionStart = 0;
            this.lb.ShortcutsEnabled = true;
            this.lb.Size = new System.Drawing.Size(167, 54);
            this.lb.TabIndex = 17;
            this.lb.Text = "Das Buch wurde erfolgreich hinzugefügt!";
            this.lb.UseSelectable = true;
            this.lb.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lb.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // bt_add
            // 
            this.bt_add.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_add.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_add, "Fügen sie alle oben eingetragen Daten hinzu.");
            this.bt_add.Location = new System.Drawing.Point(183, 213);
            this.bt_add.Name = "bt_add";
            this.helpProvider.SetShowHelp(this.bt_add, true);
            this.bt_add.Size = new System.Drawing.Size(111, 24);
            this.bt_add.TabIndex = 16;
            this.bt_add.Text = "Hinzufügen";
            this.bt_add.UseSelectable = true;
            this.bt_add.Click += new System.EventHandler(this.bt_Click);
            // 
            // rb_delete
            // 
            this.rb_delete.AutoSize = true;
            this.rb_delete.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_delete.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_delete.Location = new System.Drawing.Point(251, 3);
            this.rb_delete.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.rb_delete.Name = "rb_delete";
            this.rb_delete.Size = new System.Drawing.Size(86, 20);
            this.rb_delete.TabIndex = 14;
            this.rb_delete.Text = "Entfernen";
            this.rb_delete.UseSelectable = true;
            this.rb_delete.CheckedChanged += new System.EventHandler(this.rb_Delete_CheckedChanged);
            // 
            // rb_edit
            // 
            this.rb_edit.AutoSize = true;
            this.rb_edit.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_edit.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_edit.Location = new System.Drawing.Point(128, 3);
            this.rb_edit.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.rb_edit.Name = "rb_edit";
            this.rb_edit.Size = new System.Drawing.Size(92, 20);
            this.rb_edit.TabIndex = 13;
            this.rb_edit.Text = "Bearbeiten";
            this.rb_edit.UseSelectable = true;
            this.rb_edit.CheckedChanged += new System.EventHandler(this.rb_Edit_CheckedChanged);
            // 
            // rb_neu
            // 
            this.rb_neu.AutoSize = true;
            this.rb_neu.Checked = true;
            this.rb_neu.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb_neu.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_neu.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_neu.Location = new System.Drawing.Point(3, 3);
            this.rb_neu.Margin = new System.Windows.Forms.Padding(3, 3, 32, 3);
            this.rb_neu.Name = "rb_neu";
            this.rb_neu.Size = new System.Drawing.Size(97, 20);
            this.rb_neu.TabIndex = 12;
            this.rb_neu.TabStop = true;
            this.rb_neu.Text = "Hinzufügen";
            this.rb_neu.UseSelectable = true;
            this.rb_neu.CheckedChanged += new System.EventHandler(this.rb_Neu_CheckedChanged);
            // 
            // dTP_aufnahme
            // 
            this.helpProvider.SetHelpString(this.dTP_aufnahme, "Wählen sie hier das Aufnahmedatum des Buches, welches sie hinzufügen möchten.");
            this.dTP_aufnahme.Location = new System.Drawing.Point(183, 118);
            this.dTP_aufnahme.MinimumSize = new System.Drawing.Size(0, 30);
            this.dTP_aufnahme.Name = "dTP_aufnahme";
            this.helpProvider.SetShowHelp(this.dTP_aufnahme, true);
            this.dTP_aufnahme.Size = new System.Drawing.Size(228, 30);
            this.dTP_aufnahme.TabIndex = 10;
            this.dTP_aufnahme.ValueChanged += new System.EventHandler(this.dTP_aufnahme_ValueChanged);
            // 
            // lb_aufnahme
            // 
            this.lb_aufnahme.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_aufnahme, "Wählen sie hier das Aufnahmedatum des Buches, welches sie hinzufügen möchten.");
            this.lb_aufnahme.Location = new System.Drawing.Point(3, 118);
            this.lb_aufnahme.Margin = new System.Windows.Forms.Padding(3);
            this.lb_aufnahme.Name = "lb_aufnahme";
            this.helpProvider.SetShowHelp(this.lb_aufnahme, true);
            this.lb_aufnahme.Size = new System.Drawing.Size(115, 20);
            this.lb_aufnahme.TabIndex = 5;
            this.lb_aufnahme.Text = "Aufnahmedatum:";
            // 
            // lb_zustand
            // 
            this.lb_zustand.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_zustand, "Tragen sie hier den Zustand des Buches, welches sie hinzufügen möchten, ein.");
            this.lb_zustand.Location = new System.Drawing.Point(3, 88);
            this.lb_zustand.Margin = new System.Windows.Forms.Padding(3);
            this.lb_zustand.Name = "lb_zustand";
            this.helpProvider.SetShowHelp(this.lb_zustand, true);
            this.lb_zustand.Size = new System.Drawing.Size(62, 20);
            this.lb_zustand.TabIndex = 4;
            this.lb_zustand.Text = "Zustand:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_id, "Tragen sie hier die Buch-ID ein, um das gewünschte Buch zu laden. Buch-IDs werden" +
        " automatisch generiert.");
            this.lb_id.Location = new System.Drawing.Point(3, 58);
            this.lb_id.Margin = new System.Windows.Forms.Padding(3);
            this.lb_id.Name = "lb_id";
            this.helpProvider.SetShowHelp(this.lb_id, true);
            this.lb_id.Size = new System.Drawing.Size(25, 20);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "ID:";
            // 
            // lb_isbn
            // 
            this.lb_isbn.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_isbn, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.lb_isbn.Location = new System.Drawing.Point(3, 28);
            this.lb_isbn.Margin = new System.Windows.Forms.Padding(3);
            this.lb_isbn.Name = "lb_isbn";
            this.helpProvider.SetShowHelp(this.lb_isbn, true);
            this.lb_isbn.Size = new System.Drawing.Size(41, 20);
            this.lb_isbn.TabIndex = 2;
            this.lb_isbn.Text = "ISBN:";
            // 
            // tb_id
            // 
            // 
            // 
            // 
            this.tb_id.CustomButton.Image = null;
            this.tb_id.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.tb_id.CustomButton.Name = "";
            this.tb_id.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_id.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_id.CustomButton.TabIndex = 1;
            this.tb_id.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_id.CustomButton.UseSelectable = true;
            this.tb_id.CustomButton.Visible = false;
            this.tb_id.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_id.Lines = new string[0];
            this.tb_id.Location = new System.Drawing.Point(183, 58);
            this.tb_id.MaxLength = 32767;
            this.tb_id.Name = "tb_id";
            this.tb_id.PasswordChar = '\0';
            this.tb_id.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_id.SelectedText = "";
            this.tb_id.SelectionLength = 0;
            this.tb_id.SelectionStart = 0;
            this.tb_id.ShortcutsEnabled = true;
            this.tb_id.Size = new System.Drawing.Size(228, 24);
            this.tb_id.TabIndex = 1;
            this.tb_id.UseSelectable = true;
            this.tb_id.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_id.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_KeyPress);
            // 
            // tb_isbn
            // 
            // 
            // 
            // 
            this.tb_isbn.CustomButton.Image = null;
            this.tb_isbn.CustomButton.Location = new System.Drawing.Point(206, 2);
            this.tb_isbn.CustomButton.Name = "";
            this.tb_isbn.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_isbn.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_isbn.CustomButton.TabIndex = 1;
            this.tb_isbn.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_isbn.CustomButton.UseSelectable = true;
            this.tb_isbn.CustomButton.Visible = false;
            this.tb_isbn.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.helpProvider.SetHelpString(this.tb_isbn, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.tb_isbn.Lines = new string[0];
            this.tb_isbn.Location = new System.Drawing.Point(183, 28);
            this.tb_isbn.MaxLength = 32767;
            this.tb_isbn.Name = "tb_isbn";
            this.tb_isbn.PasswordChar = '\0';
            this.tb_isbn.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_isbn.SelectedText = "";
            this.tb_isbn.SelectionLength = 0;
            this.tb_isbn.SelectionStart = 0;
            this.tb_isbn.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_isbn, true);
            this.tb_isbn.Size = new System.Drawing.Size(228, 24);
            this.tb_isbn.TabIndex = 0;
            this.tb_isbn.UseSelectable = true;
            this.tb_isbn.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_isbn.WaterMarkFont = new System.Drawing.Font("Segoe UI", 10.5F);
            this.tb_isbn.TextChanged += new System.EventHandler(this.tb_isbn_TextChanged);
            // 
            // bt_close
            // 
            this.bt_close.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_close.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_close, "Schließen sie das akuelle Fenster.");
            this.bt_close.Location = new System.Drawing.Point(828, 553);
            this.bt_close.Name = "bt_close";
            this.helpProvider.SetShowHelp(this.bt_close, true);
            this.bt_close.Size = new System.Drawing.Size(349, 24);
            this.bt_close.TabIndex = 21;
            this.bt_close.Text = "Schließen";
            this.bt_close.UseSelectable = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_export
            // 
            this.bt_export.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_export.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_export, "Exportieren sie ihre Buchdaten in eine Exceltabelle.");
            this.bt_export.Location = new System.Drawing.Point(473, 553);
            this.bt_export.Name = "bt_export";
            this.helpProvider.SetShowHelp(this.bt_export, true);
            this.bt_export.Size = new System.Drawing.Size(349, 24);
            this.bt_export.TabIndex = 22;
            this.bt_export.Text = "Exportieren";
            this.bt_export.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.button2);
            this.metroPanel1.Controls.Add(this.lb);
            this.metroPanel1.Controls.Add(this.button1);
            this.metroPanel1.Controls.Add(this.groupBox1);
            this.metroPanel1.Controls.Add(this.rb_delete);
            this.metroPanel1.Controls.Add(this.rb_edit);
            this.metroPanel1.Controls.Add(this.rb_neu);
            this.metroPanel1.Controls.Add(this.tb_number);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.label2);
            this.metroPanel1.Controls.Add(this.tb_Barcode);
            this.metroPanel1.Controls.Add(this.bt_clear);
            this.metroPanel1.Controls.Add(this.lb_isbn);
            this.metroPanel1.Controls.Add(this.bt_add);
            this.metroPanel1.Controls.Add(this.tb_anzahl);
            this.metroPanel1.Controls.Add(this.label1);
            this.metroPanel1.Controls.Add(this.tb_isbn);
            this.metroPanel1.Controls.Add(this.lb_id);
            this.metroPanel1.Controls.Add(this.tb_id);
            this.metroPanel1.Controls.Add(this.cb_zustand);
            this.metroPanel1.Controls.Add(this.bt_zustand_add);
            this.metroPanel1.Controls.Add(this.lb_zustand);
            this.metroPanel1.Controls.Add(this.dTP_aufnahme);
            this.metroPanel1.Controls.Add(this.lb_aufnahme);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 63);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(444, 514);
            this.metroPanel1.TabIndex = 23;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 287);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(63, 20);
            this.metroLabel1.TabIndex = 26;
            this.metroLabel1.Text = "Barcode:";
            // 
            // cb_zustand
            // 
            this.cb_zustand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_zustand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_zustand.BorderColor = System.Drawing.Color.Gray;
            this.cb_zustand.DataRowView = true;
            this.cb_zustand.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_zustand.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_zustand, "Tragen sie hier den Zustand des Buches, welches sie hinzufügen möchten, ein.");
            this.cb_zustand.HighlightColor = System.Drawing.Color.DeepSkyBlue;
            this.cb_zustand.ItemHeight = 18;
            this.cb_zustand.Location = new System.Drawing.Point(183, 88);
            this.cb_zustand.Name = "cb_zustand";
            this.helpProvider.SetShowHelp(this.cb_zustand, true);
            this.cb_zustand.Size = new System.Drawing.Size(228, 24);
            this.cb_zustand.TabIndex = 11;
            this.cb_zustand.TextChanged += new System.EventHandler(this.cb_zustand_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 431);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // w_s_buchid
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.grid_buchid);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "w_s_buchid";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Exemplare";
            this.Activated += new System.EventHandler(this.w_s_buchid_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_buchid_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grid_buchid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBox)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroGrid grid_buchid;
        private MetroFramework.Controls.MetroLabel lb_aufnahme;
        private MetroFramework.Controls.MetroLabel lb_zustand;
        private MetroFramework.Controls.MetroLabel lb_id;
        private MetroFramework.Controls.MetroLabel lb_isbn;
        private MetroFramework.Controls.MetroTextBox tb_id;
        private MetroFramework.Controls.MetroTextBox tb_isbn;
        private MetroFramework.Controls.MetroDateTime dTP_aufnahme;
        private AdvancedComboBox cb_zustand;
        private MetroFramework.Controls.MetroRadioButton rb_delete;
        private MetroFramework.Controls.MetroRadioButton rb_edit;
        private MetroFramework.Controls.MetroRadioButton rb_neu;
        private MetroFramework.Controls.MetroButton bt_add;
        private MetroFramework.Controls.MetroTextBox lb;
        private MetroFramework.Controls.MetroButton bt_zustand_add;
        private MetroFramework.Controls.MetroButton bt_clear;
        private MetroFramework.Controls.MetroButton bt_close;
        private MetroFramework.Controls.MetroButton bt_export;
        private MetroFramework.Controls.MetroTextBox tb_anzahl;
        private MetroFramework.Controls.MetroLabel label1;
        private System.Windows.Forms.PictureBox BarcodeBox;
        private MetroFramework.Controls.MetroTextBox tb_Barcode;
        private MetroFramework.Controls.MetroButton button1;
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroTextBox tb_number;
        private MetroFramework.Controls.MetroLabel label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroContextMenu contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcodeDruckenToolStripMenuItem;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.Button button2;
    }
}