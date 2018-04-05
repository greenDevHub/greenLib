namespace Bibo_Verwaltung
{
    partial class w_s_import_export
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
            this.bibo_VerwaltungDataSet1 = new Bibo_Verwaltung.Bibo_VerwaltungDataSet();
            this.bt_durchsuchen = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.lb_anweissung = new System.Windows.Forms.Label();
            this.lb_path = new System.Windows.Forms.Label();
            this.gb_Formatierung = new System.Windows.Forms.GroupBox();
            this.tb_DezSym = new System.Windows.Forms.TextBox();
            this.lb_DezSym = new System.Windows.Forms.Label();
            this.tb_ZeitTrenn = new System.Windows.Forms.TextBox();
            this.tb_DatTrenn = new System.Windows.Forms.TextBox();
            this.cb_DatFolge = new System.Windows.Forms.ComboBox();
            this.ch_DatNullen = new System.Windows.Forms.CheckBox();
            this.ch_4stelligeJahre = new System.Windows.Forms.CheckBox();
            this.lb_ZeitTrenn = new System.Windows.Forms.Label();
            this.lb_DatTrenn = new System.Windows.Forms.Label();
            this.lb_Datum = new System.Windows.Forms.Label();
            this.gb_Dateiformat = new System.Windows.Forms.GroupBox();
            this.cb_ColHeader = new System.Windows.Forms.CheckBox();
            this.cb_TxtQuali = new System.Windows.Forms.ComboBox();
            this.cb_FeldTrenn = new System.Windows.Forms.ComboBox();
            this.lb_TxtQuali = new System.Windows.Forms.Label();
            this.lb_FeldTrenn = new System.Windows.Forms.Label();
            this.gv_Vorschau = new System.Windows.Forms.DataGridView();
            this.lb_Vorschau = new System.Windows.Forms.Label();
            this.bt_Abbrechen = new System.Windows.Forms.Button();
            this.bt_Import = new System.Windows.Forms.Button();
            this.lb_Anweissung2 = new System.Windows.Forms.Label();
            this.division = new System.Windows.Forms.Panel();
            this.bt_Vorschau = new System.Windows.Forms.Button();
            this.gb_Ziel = new System.Windows.Forms.GroupBox();
            this.cb_Ziel = new System.Windows.Forms.ComboBox();
            this.lb_Ziel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet1)).BeginInit();
            this.gb_Formatierung.SuspendLayout();
            this.gb_Dateiformat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Vorschau)).BeginInit();
            this.gb_Ziel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bibo_VerwaltungDataSet1
            // 
            this.bibo_VerwaltungDataSet1.DataSetName = "Bibo_VerwaltungDataSet";
            this.bibo_VerwaltungDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bt_durchsuchen
            // 
            this.bt_durchsuchen.Location = new System.Drawing.Point(542, 45);
            this.bt_durchsuchen.Name = "bt_durchsuchen";
            this.bt_durchsuchen.Size = new System.Drawing.Size(100, 23);
            this.bt_durchsuchen.TabIndex = 1;
            this.bt_durchsuchen.Text = "Durchsuchen...";
            this.bt_durchsuchen.UseVisualStyleBackColor = true;
            this.bt_durchsuchen.Click += new System.EventHandler(this.bt_durchsuchen_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(112, 47);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(424, 20);
            this.tb_path.TabIndex = 0;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // lb_anweissung
            // 
            this.lb_anweissung.AutoSize = true;
            this.lb_anweissung.Location = new System.Drawing.Point(12, 20);
            this.lb_anweissung.Name = "lb_anweissung";
            this.lb_anweissung.Size = new System.Drawing.Size(261, 13);
            this.lb_anweissung.TabIndex = 2;
            this.lb_anweissung.Text = "Geben Sie die Quelle der zu importierenden Daten an.";
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Location = new System.Drawing.Point(45, 50);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(61, 13);
            this.lb_path.TabIndex = 3;
            this.lb_path.Text = "Dateiname:";
            // 
            // gb_Formatierung
            // 
            this.gb_Formatierung.Controls.Add(this.tb_DezSym);
            this.gb_Formatierung.Controls.Add(this.lb_DezSym);
            this.gb_Formatierung.Controls.Add(this.tb_ZeitTrenn);
            this.gb_Formatierung.Controls.Add(this.tb_DatTrenn);
            this.gb_Formatierung.Controls.Add(this.cb_DatFolge);
            this.gb_Formatierung.Controls.Add(this.ch_DatNullen);
            this.gb_Formatierung.Controls.Add(this.ch_4stelligeJahre);
            this.gb_Formatierung.Controls.Add(this.lb_ZeitTrenn);
            this.gb_Formatierung.Controls.Add(this.lb_DatTrenn);
            this.gb_Formatierung.Controls.Add(this.lb_Datum);
            this.gb_Formatierung.Enabled = false;
            this.gb_Formatierung.Location = new System.Drawing.Point(212, 125);
            this.gb_Formatierung.Name = "gb_Formatierung";
            this.gb_Formatierung.Size = new System.Drawing.Size(430, 106);
            this.gb_Formatierung.TabIndex = 5;
            this.gb_Formatierung.TabStop = false;
            this.gb_Formatierung.Text = "Daten, Zeiten und Zahlen";
            // 
            // tb_DezSym
            // 
            this.tb_DezSym.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DezSym.Location = new System.Drawing.Point(320, 78);
            this.tb_DezSym.Name = "tb_DezSym";
            this.tb_DezSym.Size = new System.Drawing.Size(35, 21);
            this.tb_DezSym.TabIndex = 11;
            this.tb_DezSym.Text = ",";
            // 
            // lb_DezSym
            // 
            this.lb_DezSym.AutoSize = true;
            this.lb_DezSym.Location = new System.Drawing.Point(235, 81);
            this.lb_DezSym.Name = "lb_DezSym";
            this.lb_DezSym.Size = new System.Drawing.Size(79, 13);
            this.lb_DezSym.TabIndex = 8;
            this.lb_DezSym.Text = "Dezimalsymbol:";
            // 
            // tb_ZeitTrenn
            // 
            this.tb_ZeitTrenn.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ZeitTrenn.Location = new System.Drawing.Point(119, 78);
            this.tb_ZeitTrenn.Name = "tb_ZeitTrenn";
            this.tb_ZeitTrenn.Size = new System.Drawing.Size(35, 21);
            this.tb_ZeitTrenn.TabIndex = 8;
            this.tb_ZeitTrenn.Text = ":";
            // 
            // tb_DatTrenn
            // 
            this.tb_DatTrenn.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_DatTrenn.Location = new System.Drawing.Point(119, 52);
            this.tb_DatTrenn.Name = "tb_DatTrenn";
            this.tb_DatTrenn.Size = new System.Drawing.Size(35, 21);
            this.tb_DatTrenn.TabIndex = 7;
            this.tb_DatTrenn.Text = ".";
            // 
            // cb_DatFolge
            // 
            this.cb_DatFolge.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cb_DatFolge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_DatFolge.FormattingEnabled = true;
            this.cb_DatFolge.Items.AddRange(new object[] {
            "TMJ",
            "TJM",
            "MTJ",
            "MJT",
            "JTM",
            "JMT"});
            this.cb_DatFolge.Location = new System.Drawing.Point(119, 25);
            this.cb_DatFolge.Name = "cb_DatFolge";
            this.cb_DatFolge.Size = new System.Drawing.Size(70, 21);
            this.cb_DatFolge.TabIndex = 6;
            // 
            // ch_DatNullen
            // 
            this.ch_DatNullen.AutoSize = true;
            this.ch_DatNullen.Location = new System.Drawing.Point(238, 53);
            this.ch_DatNullen.Name = "ch_DatNullen";
            this.ch_DatNullen.Size = new System.Drawing.Size(186, 17);
            this.ch_DatNullen.TabIndex = 10;
            this.ch_DatNullen.Text = "Führende Nullen in Datumswerten";
            this.ch_DatNullen.UseVisualStyleBackColor = true;
            // 
            // ch_4stelligeJahre
            // 
            this.ch_4stelligeJahre.AutoSize = true;
            this.ch_4stelligeJahre.Location = new System.Drawing.Point(238, 26);
            this.ch_4stelligeJahre.Name = "ch_4stelligeJahre";
            this.ch_4stelligeJahre.Size = new System.Drawing.Size(141, 17);
            this.ch_4stelligeJahre.TabIndex = 9;
            this.ch_4stelligeJahre.Text = "Vierstellige Jahreszahlen";
            this.ch_4stelligeJahre.UseVisualStyleBackColor = true;
            // 
            // lb_ZeitTrenn
            // 
            this.lb_ZeitTrenn.AutoSize = true;
            this.lb_ZeitTrenn.Location = new System.Drawing.Point(6, 81);
            this.lb_ZeitTrenn.Name = "lb_ZeitTrenn";
            this.lb_ZeitTrenn.Size = new System.Drawing.Size(89, 13);
            this.lb_ZeitTrenn.TabIndex = 2;
            this.lb_ZeitTrenn.Text = "Zeittrennzeichen:";
            // 
            // lb_DatTrenn
            // 
            this.lb_DatTrenn.AutoSize = true;
            this.lb_DatTrenn.Location = new System.Drawing.Point(6, 55);
            this.lb_DatTrenn.Name = "lb_DatTrenn";
            this.lb_DatTrenn.Size = new System.Drawing.Size(107, 13);
            this.lb_DatTrenn.TabIndex = 1;
            this.lb_DatTrenn.Text = "Datumstrennzeichen:";
            // 
            // lb_Datum
            // 
            this.lb_Datum.AutoSize = true;
            this.lb_Datum.Location = new System.Drawing.Point(6, 28);
            this.lb_Datum.Name = "lb_Datum";
            this.lb_Datum.Size = new System.Drawing.Size(98, 13);
            this.lb_Datum.TabIndex = 0;
            this.lb_Datum.Text = "Datumsreihenfolge:";
            // 
            // gb_Dateiformat
            // 
            this.gb_Dateiformat.Controls.Add(this.cb_ColHeader);
            this.gb_Dateiformat.Controls.Add(this.cb_TxtQuali);
            this.gb_Dateiformat.Controls.Add(this.cb_FeldTrenn);
            this.gb_Dateiformat.Controls.Add(this.lb_TxtQuali);
            this.gb_Dateiformat.Controls.Add(this.lb_FeldTrenn);
            this.gb_Dateiformat.Enabled = false;
            this.gb_Dateiformat.Location = new System.Drawing.Point(12, 125);
            this.gb_Dateiformat.Name = "gb_Dateiformat";
            this.gb_Dateiformat.Size = new System.Drawing.Size(194, 106);
            this.gb_Dateiformat.TabIndex = 2;
            this.gb_Dateiformat.TabStop = false;
            this.gb_Dateiformat.Text = "Dateiformat";
            // 
            // cb_ColHeader
            // 
            this.cb_ColHeader.AutoSize = true;
            this.cb_ColHeader.Location = new System.Drawing.Point(9, 80);
            this.cb_ColHeader.Name = "cb_ColHeader";
            this.cb_ColHeader.Size = new System.Drawing.Size(166, 17);
            this.cb_ColHeader.TabIndex = 5;
            this.cb_ColHeader.Text = "Erste Zeile enthält Feldnamen";
            this.cb_ColHeader.UseVisualStyleBackColor = true;
            // 
            // cb_TxtQuali
            // 
            this.cb_TxtQuali.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_TxtQuali.FormattingEnabled = true;
            this.cb_TxtQuali.Items.AddRange(new object[] {
            "\"",
            "\'"});
            this.cb_TxtQuali.Location = new System.Drawing.Point(103, 52);
            this.cb_TxtQuali.Name = "cb_TxtQuali";
            this.cb_TxtQuali.Size = new System.Drawing.Size(85, 21);
            this.cb_TxtQuali.TabIndex = 4;
            // 
            // cb_FeldTrenn
            // 
            this.cb_FeldTrenn.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_FeldTrenn.FormattingEnabled = true;
            this.cb_FeldTrenn.Items.AddRange(new object[] {
            ",",
            ";",
            "{Tabulator}",
            "{Leerzeichen}"});
            this.cb_FeldTrenn.Location = new System.Drawing.Point(103, 25);
            this.cb_FeldTrenn.Name = "cb_FeldTrenn";
            this.cb_FeldTrenn.Size = new System.Drawing.Size(85, 21);
            this.cb_FeldTrenn.TabIndex = 3;
            // 
            // lb_TxtQuali
            // 
            this.lb_TxtQuali.AutoSize = true;
            this.lb_TxtQuali.Location = new System.Drawing.Point(6, 55);
            this.lb_TxtQuali.Name = "lb_TxtQuali";
            this.lb_TxtQuali.Size = new System.Drawing.Size(83, 13);
            this.lb_TxtQuali.TabIndex = 1;
            this.lb_TxtQuali.Text = "Textqualifizierer:";
            // 
            // lb_FeldTrenn
            // 
            this.lb_FeldTrenn.AutoSize = true;
            this.lb_FeldTrenn.Location = new System.Drawing.Point(6, 28);
            this.lb_FeldTrenn.Name = "lb_FeldTrenn";
            this.lb_FeldTrenn.Size = new System.Drawing.Size(91, 13);
            this.lb_FeldTrenn.TabIndex = 0;
            this.lb_FeldTrenn.Text = "Feldtrennzeichen:";
            // 
            // gv_Vorschau
            // 
            this.gv_Vorschau.AllowUserToAddRows = false;
            this.gv_Vorschau.AllowUserToDeleteRows = false;
            this.gv_Vorschau.AllowUserToResizeColumns = false;
            this.gv_Vorschau.AllowUserToResizeRows = false;
            this.gv_Vorschau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_Vorschau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Vorschau.Enabled = false;
            this.gv_Vorschau.Location = new System.Drawing.Point(12, 315);
            this.gv_Vorschau.MultiSelect = false;
            this.gv_Vorschau.Name = "gv_Vorschau";
            this.gv_Vorschau.ReadOnly = true;
            this.gv_Vorschau.RowHeadersVisible = false;
            this.gv_Vorschau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Vorschau.ShowEditingIcon = false;
            this.gv_Vorschau.Size = new System.Drawing.Size(630, 150);
            this.gv_Vorschau.TabIndex = 6;
            this.gv_Vorschau.TabStop = false;
            // 
            // lb_Vorschau
            // 
            this.lb_Vorschau.AutoSize = true;
            this.lb_Vorschau.Enabled = false;
            this.lb_Vorschau.Location = new System.Drawing.Point(12, 299);
            this.lb_Vorschau.Name = "lb_Vorschau";
            this.lb_Vorschau.Size = new System.Drawing.Size(55, 13);
            this.lb_Vorschau.TabIndex = 8;
            this.lb_Vorschau.Text = "Vorschau:";
            // 
            // bt_Abbrechen
            // 
            this.bt_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Abbrechen.Location = new System.Drawing.Point(542, 471);
            this.bt_Abbrechen.Name = "bt_Abbrechen";
            this.bt_Abbrechen.Size = new System.Drawing.Size(100, 23);
            this.bt_Abbrechen.TabIndex = 14;
            this.bt_Abbrechen.Text = "Abbrechen";
            this.bt_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // bt_Import
            // 
            this.bt_Import.Enabled = false;
            this.bt_Import.Location = new System.Drawing.Point(436, 471);
            this.bt_Import.Name = "bt_Import";
            this.bt_Import.Size = new System.Drawing.Size(100, 23);
            this.bt_Import.TabIndex = 13;
            this.bt_Import.Text = "Importieren";
            this.bt_Import.UseVisualStyleBackColor = true;
            this.bt_Import.Click += new System.EventHandler(this.bt_Import_Click);
            // 
            // lb_Anweissung2
            // 
            this.lb_Anweissung2.AutoSize = true;
            this.lb_Anweissung2.Location = new System.Drawing.Point(12, 95);
            this.lb_Anweissung2.Name = "lb_Anweissung2";
            this.lb_Anweissung2.Size = new System.Drawing.Size(263, 13);
            this.lb_Anweissung2.TabIndex = 11;
            this.lb_Anweissung2.Text = "Stellen Sie die Definitionen der Datei-Formatierung ein.";
            // 
            // division
            // 
            this.division.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.division.Location = new System.Drawing.Point(12, 75);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(630, 1);
            this.division.TabIndex = 12;
            // 
            // bt_Vorschau
            // 
            this.bt_Vorschau.Enabled = false;
            this.bt_Vorschau.Location = new System.Drawing.Point(542, 90);
            this.bt_Vorschau.Name = "bt_Vorschau";
            this.bt_Vorschau.Size = new System.Drawing.Size(100, 23);
            this.bt_Vorschau.TabIndex = 10;
            this.bt_Vorschau.Text = "Vorschau";
            this.bt_Vorschau.UseVisualStyleBackColor = true;
            this.bt_Vorschau.Click += new System.EventHandler(this.bt_Vorschau_Click);
            // 
            // gb_Ziel
            // 
            this.gb_Ziel.Controls.Add(this.cb_Ziel);
            this.gb_Ziel.Controls.Add(this.lb_Ziel);
            this.gb_Ziel.Enabled = false;
            this.gb_Ziel.Location = new System.Drawing.Point(15, 237);
            this.gb_Ziel.Name = "gb_Ziel";
            this.gb_Ziel.Size = new System.Drawing.Size(627, 54);
            this.gb_Ziel.TabIndex = 15;
            this.gb_Ziel.TabStop = false;
            this.gb_Ziel.Text = "Importziel";
            // 
            // cb_Ziel
            // 
            this.cb_Ziel.FormattingEnabled = true;
            this.cb_Ziel.Items.AddRange(new object[] {
            "Kundentabelle",
            "Büchertabelle",
            "Exemplartabelle"});
            this.cb_Ziel.Location = new System.Drawing.Point(70, 25);
            this.cb_Ziel.Name = "cb_Ziel";
            this.cb_Ziel.Size = new System.Drawing.Size(115, 21);
            this.cb_Ziel.TabIndex = 1;
            // 
            // lb_Ziel
            // 
            this.lb_Ziel.AutoSize = true;
            this.lb_Ziel.Location = new System.Drawing.Point(6, 28);
            this.lb_Ziel.Name = "lb_Ziel";
            this.lb_Ziel.Size = new System.Drawing.Size(58, 13);
            this.lb_Ziel.TabIndex = 0;
            this.lb_Ziel.Text = "Zieltabelle:";
            // 
            // w_s_import_export
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 506);
            this.Controls.Add(this.gb_Ziel);
            this.Controls.Add(this.bt_Vorschau);
            this.Controls.Add(this.division);
            this.Controls.Add(this.lb_Anweissung2);
            this.Controls.Add(this.bt_Import);
            this.Controls.Add(this.bt_Abbrechen);
            this.Controls.Add(this.lb_Vorschau);
            this.Controls.Add(this.gv_Vorschau);
            this.Controls.Add(this.gb_Dateiformat);
            this.Controls.Add(this.gb_Formatierung);
            this.Controls.Add(this.lb_path);
            this.Controls.Add(this.bt_durchsuchen);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.lb_anweissung);
            this.Name = "w_s_import_export";
            this.Text = "w_s_importDialog";
            this.Shown += new System.EventHandler(this.w_s_importDialog_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet1)).EndInit();
            this.gb_Formatierung.ResumeLayout(false);
            this.gb_Formatierung.PerformLayout();
            this.gb_Dateiformat.ResumeLayout(false);
            this.gb_Dateiformat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Vorschau)).EndInit();
            this.gb_Ziel.ResumeLayout(false);
            this.gb_Ziel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bibo_VerwaltungDataSet bibo_VerwaltungDataSet1;
        private System.Windows.Forms.Button bt_durchsuchen;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label lb_anweissung;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.GroupBox gb_Formatierung;
        private System.Windows.Forms.TextBox tb_DezSym;
        private System.Windows.Forms.Label lb_DezSym;
        private System.Windows.Forms.TextBox tb_ZeitTrenn;
        private System.Windows.Forms.TextBox tb_DatTrenn;
        private System.Windows.Forms.ComboBox cb_DatFolge;
        private System.Windows.Forms.CheckBox ch_DatNullen;
        private System.Windows.Forms.CheckBox ch_4stelligeJahre;
        private System.Windows.Forms.Label lb_ZeitTrenn;
        private System.Windows.Forms.Label lb_DatTrenn;
        private System.Windows.Forms.Label lb_Datum;
        private System.Windows.Forms.GroupBox gb_Dateiformat;
        private System.Windows.Forms.ComboBox cb_TxtQuali;
        private System.Windows.Forms.ComboBox cb_FeldTrenn;
        private System.Windows.Forms.Label lb_TxtQuali;
        private System.Windows.Forms.Label lb_FeldTrenn;
        private System.Windows.Forms.DataGridView gv_Vorschau;
        private System.Windows.Forms.Label lb_Vorschau;
        private System.Windows.Forms.Button bt_Abbrechen;
        private System.Windows.Forms.Button bt_Import;
        private System.Windows.Forms.Label lb_Anweissung2;
        private System.Windows.Forms.Panel division;
        private System.Windows.Forms.Button bt_Vorschau;
        private System.Windows.Forms.CheckBox cb_ColHeader;
        private System.Windows.Forms.GroupBox gb_Ziel;
        private System.Windows.Forms.ComboBox cb_Ziel;
        private System.Windows.Forms.Label lb_Ziel;
    }
}