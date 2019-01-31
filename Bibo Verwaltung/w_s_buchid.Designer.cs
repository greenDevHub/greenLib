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
            this.grid_buchid = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ladenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.entfernenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barcodeDruckenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gB_buchid = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BarcodeBox = new System.Windows.Forms.PictureBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Barcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_anzahl = new System.Windows.Forms.TextBox();
            this.bt_clear = new System.Windows.Forms.Button();
            this.bt_zustand_add = new System.Windows.Forms.Button();
            this.lb = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.rb_delete = new System.Windows.Forms.RadioButton();
            this.rb_edit = new System.Windows.Forms.RadioButton();
            this.rb_neu = new System.Windows.Forms.RadioButton();
            this.cb_zustand = new System.Windows.Forms.ComboBox();
            this.dTP_aufnahme = new System.Windows.Forms.DateTimePicker();
            this.lb_aufnahme = new System.Windows.Forms.Label();
            this.lb_zustand = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.lb_isbn = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_isbn = new System.Windows.Forms.TextBox();
            this.bt_close = new System.Windows.Forms.Button();
            this.bt_export = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.grid_buchid)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.gB_buchid.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBox)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_buchid
            // 
            this.grid_buchid.AllowUserToAddRows = false;
            this.grid_buchid.AllowUserToDeleteRows = false;
            this.grid_buchid.AllowUserToResizeColumns = false;
            this.grid_buchid.AllowUserToResizeRows = false;
            this.grid_buchid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid_buchid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_buchid.ContextMenuStrip = this.contextMenuStrip1;
            this.helpProvider.SetHelpString(this.grid_buchid, "Hier werden ihnen alle vorhandenen Buchexemplare angezeigt.");
            this.grid_buchid.Location = new System.Drawing.Point(800, 31);
            this.grid_buchid.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.grid_buchid.Name = "grid_buchid";
            this.grid_buchid.ReadOnly = true;
            this.grid_buchid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_buchid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.grid_buchid, true);
            this.grid_buchid.Size = new System.Drawing.Size(1542, 944);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(320, 142);
            // 
            // ladenToolStripMenuItem
            // 
            this.ladenToolStripMenuItem.Name = "ladenToolStripMenuItem";
            this.ladenToolStripMenuItem.Size = new System.Drawing.Size(319, 46);
            this.ladenToolStripMenuItem.Text = "Laden";
            this.ladenToolStripMenuItem.Click += new System.EventHandler(this.ladenToolStripMenuItem_Click);
            // 
            // entfernenToolStripMenuItem
            // 
            this.entfernenToolStripMenuItem.Name = "entfernenToolStripMenuItem";
            this.entfernenToolStripMenuItem.Size = new System.Drawing.Size(319, 46);
            this.entfernenToolStripMenuItem.Text = "Entfernen";
            this.entfernenToolStripMenuItem.Click += new System.EventHandler(this.entfernenToolStripMenuItem_Click);
            // 
            // barcodeDruckenToolStripMenuItem
            // 
            this.barcodeDruckenToolStripMenuItem.Name = "barcodeDruckenToolStripMenuItem";
            this.barcodeDruckenToolStripMenuItem.Size = new System.Drawing.Size(319, 46);
            this.barcodeDruckenToolStripMenuItem.Text = "Barcode drucken";
            this.barcodeDruckenToolStripMenuItem.Click += new System.EventHandler(this.barcodeDruckenToolStripMenuItem_Click);
            // 
            // gB_buchid
            // 
            this.gB_buchid.Controls.Add(this.groupBox1);
            this.gB_buchid.Controls.Add(this.tb_number);
            this.gB_buchid.Controls.Add(this.label2);
            this.gB_buchid.Controls.Add(this.button1);
            this.gB_buchid.Controls.Add(this.tb_Barcode);
            this.gB_buchid.Controls.Add(this.label1);
            this.gB_buchid.Controls.Add(this.tb_anzahl);
            this.gB_buchid.Controls.Add(this.bt_clear);
            this.gB_buchid.Controls.Add(this.bt_zustand_add);
            this.gB_buchid.Controls.Add(this.lb);
            this.gB_buchid.Controls.Add(this.bt_add);
            this.gB_buchid.Controls.Add(this.rb_delete);
            this.gB_buchid.Controls.Add(this.rb_edit);
            this.gB_buchid.Controls.Add(this.rb_neu);
            this.gB_buchid.Controls.Add(this.cb_zustand);
            this.gB_buchid.Controls.Add(this.dTP_aufnahme);
            this.gB_buchid.Controls.Add(this.lb_aufnahme);
            this.gB_buchid.Controls.Add(this.lb_zustand);
            this.gB_buchid.Controls.Add(this.lb_id);
            this.gB_buchid.Controls.Add(this.lb_isbn);
            this.gB_buchid.Controls.Add(this.tb_id);
            this.gB_buchid.Controls.Add(this.tb_isbn);
            this.gB_buchid.Location = new System.Drawing.Point(16, 31);
            this.gB_buchid.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gB_buchid.Name = "gB_buchid";
            this.gB_buchid.Padding = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.gB_buchid.Size = new System.Drawing.Size(758, 1015);
            this.gB_buchid.TabIndex = 1;
            this.gB_buchid.TabStop = false;
            this.gB_buchid.Text = "Bücher";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BarcodeBox);
            this.groupBox1.Location = new System.Drawing.Point(256, 562);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(422, 266);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarcodeBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BarcodeBox.Location = new System.Drawing.Point(3, 34);
            this.BarcodeBox.Margin = new System.Windows.Forms.Padding(8);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(416, 229);
            this.BarcodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BarcodeBox.TabIndex = 23;
            this.BarcodeBox.TabStop = false;
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(264, 339);
            this.tb_number.Margin = new System.Windows.Forms.Padding(8);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(414, 38);
            this.tb_number.TabIndex = 27;
            this.tb_number.Text = "1";
            this.tb_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_number_KeyPress);
            this.tb_number.Leave += new System.EventHandler(this.tb_number_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.helpProvider.SetHelpString(this.label2, "Wählen sie hier die Anzahl der Bücher, welches sie hinzufügen möchten, ein.");
            this.label2.Location = new System.Drawing.Point(12, 397);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.helpProvider.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(163, 32);
            this.label2.TabIndex = 26;
            this.label2.Text = "Vorhanden:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.button1, "Klicken sie hier, um den Barcode auszudrucken.");
            this.button1.Location = new System.Drawing.Point(264, 833);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.helpProvider.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(170, 54);
            this.button1.TabIndex = 25;
            this.button1.Text = "Drucken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_Barcode
            // 
            this.tb_Barcode.Location = new System.Drawing.Point(264, 517);
            this.tb_Barcode.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.tb_Barcode.Name = "tb_Barcode";
            this.tb_Barcode.Size = new System.Drawing.Size(414, 38);
            this.tb_Barcode.TabIndex = 24;
            this.tb_Barcode.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.helpProvider.SetHelpString(this.label1, "Wählen sie hier die Anzahl der Bücher, welches sie hinzufügen möchten, ein.");
            this.label1.Location = new System.Drawing.Point(12, 345);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.helpProvider.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(254, 32);
            this.label1.TabIndex = 21;
            this.label1.Text = "Anzahl Exemplare:";
            // 
            // tb_anzahl
            // 
            this.tb_anzahl.Enabled = false;
            this.tb_anzahl.Location = new System.Drawing.Point(264, 397);
            this.tb_anzahl.Margin = new System.Windows.Forms.Padding(8);
            this.tb_anzahl.Name = "tb_anzahl";
            this.tb_anzahl.Size = new System.Drawing.Size(414, 38);
            this.tb_anzahl.TabIndex = 20;
            // 
            // bt_clear
            // 
            this.helpProvider.SetHelpString(this.bt_clear, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_clear.Location = new System.Drawing.Point(488, 455);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(8);
            this.bt_clear.Name = "bt_clear";
            this.helpProvider.SetShowHelp(this.bt_clear, true);
            this.bt_clear.Size = new System.Drawing.Size(192, 54);
            this.bt_clear.TabIndex = 19;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_zustand_add
            // 
            this.helpProvider.SetHelpString(this.bt_zustand_add, "Klicken sie auf diesen Button, um neue Zustände hinzuzufügen.");
            this.bt_zustand_add.Location = new System.Drawing.Point(696, 219);
            this.bt_zustand_add.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.bt_zustand_add.Name = "bt_zustand_add";
            this.helpProvider.SetShowHelp(this.bt_zustand_add, true);
            this.bt_zustand_add.Size = new System.Drawing.Size(40, 39);
            this.bt_zustand_add.TabIndex = 18;
            this.bt_zustand_add.Text = "+";
            this.bt_zustand_add.UseVisualStyleBackColor = true;
            this.bt_zustand_add.Click += new System.EventHandler(this.bt_zustand_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(10, 469);
            this.lb.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 32);
            this.lb.TabIndex = 17;
            // 
            // bt_add
            // 
            this.helpProvider.SetHelpString(this.bt_add, "Fügen sie alle oben eingetragen Daten hinzu.");
            this.bt_add.Location = new System.Drawing.Point(264, 455);
            this.bt_add.Margin = new System.Windows.Forms.Padding(8);
            this.bt_add.Name = "bt_add";
            this.helpProvider.SetShowHelp(this.bt_add, true);
            this.bt_add.Size = new System.Drawing.Size(192, 54);
            this.bt_add.TabIndex = 16;
            this.bt_add.Text = "Hinzufügen";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_Click);
            // 
            // rb_delete
            // 
            this.rb_delete.AutoSize = true;
            this.rb_delete.Location = new System.Drawing.Point(550, 45);
            this.rb_delete.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rb_delete.Name = "rb_delete";
            this.rb_delete.Size = new System.Drawing.Size(176, 36);
            this.rb_delete.TabIndex = 14;
            this.rb_delete.Text = "Entfernen";
            this.rb_delete.UseVisualStyleBackColor = true;
            this.rb_delete.CheckedChanged += new System.EventHandler(this.rb_Delete_CheckedChanged);
            // 
            // rb_edit
            // 
            this.rb_edit.AutoSize = true;
            this.rb_edit.Location = new System.Drawing.Point(282, 45);
            this.rb_edit.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rb_edit.Name = "rb_edit";
            this.rb_edit.Size = new System.Drawing.Size(191, 36);
            this.rb_edit.TabIndex = 13;
            this.rb_edit.Text = "Bearbeiten";
            this.rb_edit.UseVisualStyleBackColor = true;
            this.rb_edit.CheckedChanged += new System.EventHandler(this.rb_Edit_CheckedChanged);
            // 
            // rb_neu
            // 
            this.rb_neu.AutoSize = true;
            this.rb_neu.Checked = true;
            this.rb_neu.Cursor = System.Windows.Forms.Cursors.Default;
            this.rb_neu.Location = new System.Drawing.Point(16, 45);
            this.rb_neu.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.rb_neu.Name = "rb_neu";
            this.rb_neu.Size = new System.Drawing.Size(197, 36);
            this.rb_neu.TabIndex = 12;
            this.rb_neu.TabStop = true;
            this.rb_neu.Text = "Hinzufügen";
            this.rb_neu.UseVisualStyleBackColor = true;
            this.rb_neu.CheckedChanged += new System.EventHandler(this.rb_Neu_CheckedChanged);
            // 
            // cb_zustand
            // 
            this.cb_zustand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_zustand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_zustand.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_zustand, "Tragen sie hier den Zustand des Buches, welches sie hinzufügen möchten, ein.");
            this.cb_zustand.Location = new System.Drawing.Point(264, 219);
            this.cb_zustand.Margin = new System.Windows.Forms.Padding(8);
            this.cb_zustand.Name = "cb_zustand";
            this.helpProvider.SetShowHelp(this.cb_zustand, true);
            this.cb_zustand.Size = new System.Drawing.Size(414, 39);
            this.cb_zustand.TabIndex = 11;
            this.cb_zustand.TextChanged += new System.EventHandler(this.cb_zustand_TextChanged);
            // 
            // dTP_aufnahme
            // 
            this.helpProvider.SetHelpString(this.dTP_aufnahme, "Wählen sie hier das Aufnahmedatum des Buches, welches sie hinzufügen möchten.");
            this.dTP_aufnahme.Location = new System.Drawing.Point(264, 281);
            this.dTP_aufnahme.Margin = new System.Windows.Forms.Padding(8);
            this.dTP_aufnahme.Name = "dTP_aufnahme";
            this.helpProvider.SetShowHelp(this.dTP_aufnahme, true);
            this.dTP_aufnahme.Size = new System.Drawing.Size(414, 38);
            this.dTP_aufnahme.TabIndex = 10;
            this.dTP_aufnahme.ValueChanged += new System.EventHandler(this.dTP_aufnahme_ValueChanged);
            // 
            // lb_aufnahme
            // 
            this.lb_aufnahme.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_aufnahme, "Wählen sie hier das Aufnahmedatum des Buches, welches sie hinzufügen möchten.");
            this.lb_aufnahme.Location = new System.Drawing.Point(12, 291);
            this.lb_aufnahme.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_aufnahme.Name = "lb_aufnahme";
            this.helpProvider.SetShowHelp(this.lb_aufnahme, true);
            this.lb_aufnahme.Size = new System.Drawing.Size(232, 32);
            this.lb_aufnahme.TabIndex = 5;
            this.lb_aufnahme.Text = "Aufnahmedatum:";
            // 
            // lb_zustand
            // 
            this.lb_zustand.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_zustand, "Tragen sie hier den Zustand des Buches, welches sie hinzufügen möchten, ein.");
            this.lb_zustand.Location = new System.Drawing.Point(12, 225);
            this.lb_zustand.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_zustand.Name = "lb_zustand";
            this.helpProvider.SetShowHelp(this.lb_zustand, true);
            this.lb_zustand.Size = new System.Drawing.Size(126, 32);
            this.lb_zustand.TabIndex = 4;
            this.lb_zustand.Text = "Zustand:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_id, "Tragen sie hier die Buch-ID ein, um das gewünschte Buch zu laden. Buch-IDs werden" +
        " automatisch generiert.");
            this.lb_id.Location = new System.Drawing.Point(10, 167);
            this.lb_id.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_id.Name = "lb_id";
            this.helpProvider.SetShowHelp(this.lb_id, true);
            this.lb_id.Size = new System.Drawing.Size(50, 32);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "ID:";
            // 
            // lb_isbn
            // 
            this.lb_isbn.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_isbn, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.lb_isbn.Location = new System.Drawing.Point(10, 110);
            this.lb_isbn.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lb_isbn.Name = "lb_isbn";
            this.helpProvider.SetShowHelp(this.lb_isbn, true);
            this.lb_isbn.Size = new System.Drawing.Size(88, 32);
            this.lb_isbn.TabIndex = 2;
            this.lb_isbn.Text = "ISBN:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(264, 163);
            this.tb_id.Margin = new System.Windows.Forms.Padding(8);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(414, 38);
            this.tb_id.TabIndex = 1;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_KeyPress);
            // 
            // tb_isbn
            // 
            this.helpProvider.SetHelpString(this.tb_isbn, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.tb_isbn.Location = new System.Drawing.Point(264, 103);
            this.tb_isbn.Margin = new System.Windows.Forms.Padding(8);
            this.tb_isbn.Name = "tb_isbn";
            this.helpProvider.SetShowHelp(this.tb_isbn, true);
            this.tb_isbn.Size = new System.Drawing.Size(414, 38);
            this.tb_isbn.TabIndex = 0;
            this.tb_isbn.TextChanged += new System.EventHandler(this.tb_isbn_TextChanged);
            // 
            // bt_close
            // 
            this.bt_close.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.bt_close, "Schließen sie das akuelle Fenster.");
            this.bt_close.Location = new System.Drawing.Point(1642, 992);
            this.bt_close.Margin = new System.Windows.Forms.Padding(8);
            this.bt_close.Name = "bt_close";
            this.helpProvider.SetShowHelp(this.bt_close, true);
            this.bt_close.Size = new System.Drawing.Size(698, 54);
            this.bt_close.TabIndex = 21;
            this.bt_close.Text = "Schließen";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_export
            // 
            this.bt_export.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.bt_export, "Exportieren sie ihre Buchdaten in eine Exceltabelle.");
            this.bt_export.Location = new System.Drawing.Point(800, 992);
            this.bt_export.Margin = new System.Windows.Forms.Padding(8);
            this.bt_export.Name = "bt_export";
            this.helpProvider.SetShowHelp(this.bt_export, true);
            this.bt_export.Size = new System.Drawing.Size(698, 54);
            this.bt_export.TabIndex = 22;
            this.bt_export.Text = "Exportieren";
            this.bt_export.UseVisualStyleBackColor = true;
            // 
            // w_s_buchid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2372, 1065);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.gB_buchid);
            this.Controls.Add(this.grid_buchid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_buchid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplare";
            this.Activated += new System.EventHandler(this.w_s_buchid_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_buchid_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grid_buchid)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.gB_buchid.ResumeLayout(false);
            this.gB_buchid.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarcodeBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_buchid;
        private System.Windows.Forms.GroupBox gB_buchid;
        private System.Windows.Forms.Label lb_aufnahme;
        private System.Windows.Forms.Label lb_zustand;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Label lb_isbn;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_isbn;
        private System.Windows.Forms.DateTimePicker dTP_aufnahme;
        private System.Windows.Forms.ComboBox cb_zustand;
        private System.Windows.Forms.RadioButton rb_delete;
        private System.Windows.Forms.RadioButton rb_edit;
        private System.Windows.Forms.RadioButton rb_neu;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Button bt_zustand_add;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.Button bt_close;
        private System.Windows.Forms.Button bt_export;
        private System.Windows.Forms.TextBox tb_anzahl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox BarcodeBox;
        private System.Windows.Forms.TextBox tb_Barcode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ladenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem entfernenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barcodeDruckenToolStripMenuItem;
    }
}