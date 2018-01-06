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
            this.grid_buchid = new System.Windows.Forms.DataGridView();
            this.gB_buchid = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_Barcode = new System.Windows.Forms.TextBox();
            this.BarcodeBox = new System.Windows.Forms.PictureBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.tb_number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_buchid)).BeginInit();
            this.gB_buchid.SuspendLayout();
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
            this.helpProvider.SetHelpString(this.grid_buchid, "Hier werden ihnen alle vorhandenen Buchexemplare angezeigt.");
            this.grid_buchid.Location = new System.Drawing.Point(400, 16);
            this.grid_buchid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grid_buchid.MultiSelect = false;
            this.grid_buchid.Name = "grid_buchid";
            this.grid_buchid.ReadOnly = true;
            this.grid_buchid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid_buchid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.grid_buchid, true);
            this.grid_buchid.Size = new System.Drawing.Size(771, 487);
            this.grid_buchid.TabIndex = 0;
            this.grid_buchid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Buch_CellDoubleClick);
            // 
            // gB_buchid
            // 
            this.gB_buchid.Controls.Add(this.tb_number);
            this.gB_buchid.Controls.Add(this.label2);
            this.gB_buchid.Controls.Add(this.button1);
            this.gB_buchid.Controls.Add(this.tb_Barcode);
            this.gB_buchid.Controls.Add(this.BarcodeBox);
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
            this.gB_buchid.Location = new System.Drawing.Point(8, 16);
            this.gB_buchid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gB_buchid.Name = "gB_buchid";
            this.gB_buchid.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gB_buchid.Size = new System.Drawing.Size(379, 524);
            this.gB_buchid.TabIndex = 1;
            this.gB_buchid.TabStop = false;
            this.gB_buchid.Text = "Bücher";
            // 
            // button1
            // 
            this.helpProvider.SetHelpString(this.button1, "Klicken sie hier, um den Barcode auszudrucken.");
            this.button1.Location = new System.Drawing.Point(131, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(1);
            this.button1.Name = "button1";
            this.helpProvider.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(85, 28);
            this.button1.TabIndex = 25;
            this.button1.Text = "Drucken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tb_Barcode
            // 
            this.tb_Barcode.Location = new System.Drawing.Point(132, 267);
            this.tb_Barcode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_Barcode.Name = "tb_Barcode";
            this.tb_Barcode.Size = new System.Drawing.Size(209, 22);
            this.tb_Barcode.TabIndex = 24;
            this.tb_Barcode.Visible = false;
            // 
            // BarcodeBox
            // 
            this.BarcodeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BarcodeBox.Location = new System.Drawing.Point(131, 295);
            this.BarcodeBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BarcodeBox.Name = "BarcodeBox";
            this.BarcodeBox.Size = new System.Drawing.Size(209, 114);
            this.BarcodeBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BarcodeBox.TabIndex = 23;
            this.BarcodeBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.helpProvider.SetHelpString(this.label1, "Wählen sie hier die Anzahl der Bücher, welches sie hinzufügen möchten, ein.");
            this.label1.Location = new System.Drawing.Point(6, 178);
            this.label1.Name = "label1";
            this.helpProvider.SetShowHelp(this.label1, true);
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Anzahl Exemplare:";
            // 
            // tb_anzahl
            // 
            this.tb_anzahl.Enabled = false;
            this.tb_anzahl.Location = new System.Drawing.Point(132, 205);
            this.tb_anzahl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_anzahl.Name = "tb_anzahl";
            this.tb_anzahl.Size = new System.Drawing.Size(209, 22);
            this.tb_anzahl.TabIndex = 20;
            // 
            // bt_clear
            // 
            this.helpProvider.SetHelpString(this.bt_clear, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_clear.Location = new System.Drawing.Point(244, 235);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_clear.Name = "bt_clear";
            this.helpProvider.SetShowHelp(this.bt_clear, true);
            this.bt_clear.Size = new System.Drawing.Size(96, 28);
            this.bt_clear.TabIndex = 19;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseVisualStyleBackColor = true;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            // 
            // bt_zustand_add
            // 
            this.helpProvider.SetHelpString(this.bt_zustand_add, "Klicken sie auf diesen Button, um neue Zustände hinzuzufügen.");
            this.bt_zustand_add.Location = new System.Drawing.Point(348, 113);
            this.bt_zustand_add.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_zustand_add.Name = "bt_zustand_add";
            this.helpProvider.SetShowHelp(this.bt_zustand_add, true);
            this.bt_zustand_add.Size = new System.Drawing.Size(20, 20);
            this.bt_zustand_add.TabIndex = 18;
            this.bt_zustand_add.Text = "+";
            this.bt_zustand_add.UseVisualStyleBackColor = true;
            this.bt_zustand_add.Click += new System.EventHandler(this.bt_zustand_Click);
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Location = new System.Drawing.Point(5, 242);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 17);
            this.lb.TabIndex = 17;
            // 
            // bt_add
            // 
            this.helpProvider.SetHelpString(this.bt_add, "Fügen sie alle oben eingetragen Daten hinzu.");
            this.bt_add.Location = new System.Drawing.Point(132, 235);
            this.bt_add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_add.Name = "bt_add";
            this.helpProvider.SetShowHelp(this.bt_add, true);
            this.bt_add.Size = new System.Drawing.Size(96, 28);
            this.bt_add.TabIndex = 16;
            this.bt_add.Text = "Hinzufügen";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_Click);
            // 
            // rb_delete
            // 
            this.rb_delete.AutoSize = true;
            this.rb_delete.Location = new System.Drawing.Point(275, 23);
            this.rb_delete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_delete.Name = "rb_delete";
            this.rb_delete.Size = new System.Drawing.Size(91, 21);
            this.rb_delete.TabIndex = 14;
            this.rb_delete.Text = "Entfernen";
            this.rb_delete.UseVisualStyleBackColor = true;
            this.rb_delete.CheckedChanged += new System.EventHandler(this.rb_Delete_CheckedChanged);
            // 
            // rb_edit
            // 
            this.rb_edit.AutoSize = true;
            this.rb_edit.Location = new System.Drawing.Point(141, 23);
            this.rb_edit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_edit.Name = "rb_edit";
            this.rb_edit.Size = new System.Drawing.Size(98, 21);
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
            this.rb_neu.Location = new System.Drawing.Point(8, 23);
            this.rb_neu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb_neu.Name = "rb_neu";
            this.rb_neu.Size = new System.Drawing.Size(101, 21);
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
            this.cb_zustand.Location = new System.Drawing.Point(132, 113);
            this.cb_zustand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_zustand.Name = "cb_zustand";
            this.helpProvider.SetShowHelp(this.cb_zustand, true);
            this.cb_zustand.Size = new System.Drawing.Size(209, 24);
            this.cb_zustand.TabIndex = 11;
            this.cb_zustand.TextChanged += new System.EventHandler(this.cb_zustand_TextChanged);
            // 
            // dTP_aufnahme
            // 
            this.helpProvider.SetHelpString(this.dTP_aufnahme, "Wählen sie hier das Aufnahmedatum des Buches, welches sie hinzufügen möchten.");
            this.dTP_aufnahme.Location = new System.Drawing.Point(132, 145);
            this.dTP_aufnahme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTP_aufnahme.Name = "dTP_aufnahme";
            this.helpProvider.SetShowHelp(this.dTP_aufnahme, true);
            this.dTP_aufnahme.Size = new System.Drawing.Size(209, 22);
            this.dTP_aufnahme.TabIndex = 10;
            this.dTP_aufnahme.ValueChanged += new System.EventHandler(this.dTP_aufnahme_ValueChanged);
            // 
            // lb_aufnahme
            // 
            this.lb_aufnahme.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_aufnahme, "Wählen sie hier das Aufnahmedatum des Buches, welches sie hinzufügen möchten.");
            this.lb_aufnahme.Location = new System.Drawing.Point(6, 150);
            this.lb_aufnahme.Name = "lb_aufnahme";
            this.helpProvider.SetShowHelp(this.lb_aufnahme, true);
            this.lb_aufnahme.Size = new System.Drawing.Size(115, 17);
            this.lb_aufnahme.TabIndex = 5;
            this.lb_aufnahme.Text = "Aufnahmedatum:";
            // 
            // lb_zustand
            // 
            this.lb_zustand.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_zustand, "Tragen sie hier den Zustand des Buches, welches sie hinzufügen möchten, ein.");
            this.lb_zustand.Location = new System.Drawing.Point(6, 116);
            this.lb_zustand.Name = "lb_zustand";
            this.helpProvider.SetShowHelp(this.lb_zustand, true);
            this.lb_zustand.Size = new System.Drawing.Size(64, 17);
            this.lb_zustand.TabIndex = 4;
            this.lb_zustand.Text = "Zustand:";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_id, "Tragen sie hier die Buch-ID ein, um das gewünschte Buch zu laden. Buch-IDs werden" +
        " automatisch generiert.");
            this.lb_id.Location = new System.Drawing.Point(5, 86);
            this.lb_id.Name = "lb_id";
            this.helpProvider.SetShowHelp(this.lb_id, true);
            this.lb_id.Size = new System.Drawing.Size(25, 17);
            this.lb_id.TabIndex = 3;
            this.lb_id.Text = "ID:";
            // 
            // lb_isbn
            // 
            this.lb_isbn.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_isbn, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.lb_isbn.Location = new System.Drawing.Point(5, 57);
            this.lb_isbn.Name = "lb_isbn";
            this.helpProvider.SetShowHelp(this.lb_isbn, true);
            this.lb_isbn.Size = new System.Drawing.Size(43, 17);
            this.lb_isbn.TabIndex = 2;
            this.lb_isbn.Text = "ISBN:";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(132, 84);
            this.tb_id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(209, 22);
            this.tb_id.TabIndex = 1;
            this.tb_id.TextChanged += new System.EventHandler(this.tb_id_TextChanged);
            this.tb_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_id_KeyPress);
            // 
            // tb_isbn
            // 
            this.helpProvider.SetHelpString(this.tb_isbn, "Tragen sie hier die ISBN-13 ein, um das gewünschte Buch zu laden.");
            this.tb_isbn.Location = new System.Drawing.Point(132, 53);
            this.tb_isbn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_isbn.Name = "tb_isbn";
            this.helpProvider.SetShowHelp(this.tb_isbn, true);
            this.tb_isbn.Size = new System.Drawing.Size(209, 22);
            this.tb_isbn.TabIndex = 0;
            this.tb_isbn.TextChanged += new System.EventHandler(this.tb_isbn_TextChanged);
            // 
            // bt_close
            // 
            this.helpProvider.SetHelpString(this.bt_close, "Schließen sie das akuelle Fenster.");
            this.bt_close.Location = new System.Drawing.Point(821, 512);
            this.bt_close.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_close.Name = "bt_close";
            this.helpProvider.SetShowHelp(this.bt_close, true);
            this.bt_close.Size = new System.Drawing.Size(349, 28);
            this.bt_close.TabIndex = 21;
            this.bt_close.Text = "Schließen";
            this.bt_close.UseVisualStyleBackColor = true;
            this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
            // 
            // bt_export
            // 
            this.helpProvider.SetHelpString(this.bt_export, "Exportieren sie ihre Buchdaten in eine Exceltabelle.");
            this.bt_export.Location = new System.Drawing.Point(400, 512);
            this.bt_export.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_export.Name = "bt_export";
            this.helpProvider.SetShowHelp(this.bt_export, true);
            this.bt_export.Size = new System.Drawing.Size(349, 28);
            this.bt_export.TabIndex = 22;
            this.bt_export.Text = "Exportieren";
            this.bt_export.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.helpProvider.SetHelpString(this.label2, "Wählen sie hier die Anzahl der Bücher, welches sie hinzufügen möchten, ein.");
            this.label2.Location = new System.Drawing.Point(6, 205);
            this.label2.Name = "label2";
            this.helpProvider.SetShowHelp(this.label2, true);
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Vorhanden:";
            // 
            // tb_number
            // 
            this.tb_number.Location = new System.Drawing.Point(132, 175);
            this.tb_number.Margin = new System.Windows.Forms.Padding(4);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(209, 22);
            this.tb_number.TabIndex = 27;
            this.tb_number.Text = "1";
            this.tb_number.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_number_KeyPress);
            this.tb_number.Leave += new System.EventHandler(this.tb_number_Leave);
            // 
            // w_s_buchid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 546);
            this.Controls.Add(this.bt_export);
            this.Controls.Add(this.bt_close);
            this.Controls.Add(this.gB_buchid);
            this.Controls.Add(this.grid_buchid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_buchid";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exemplare";
            this.Activated += new System.EventHandler(this.w_s_buchid_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_buchid_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.grid_buchid)).EndInit();
            this.gB_buchid.ResumeLayout(false);
            this.gB_buchid.PerformLayout();
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
    }
}