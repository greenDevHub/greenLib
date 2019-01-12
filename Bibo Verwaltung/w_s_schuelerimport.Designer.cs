namespace Bibo_Verwaltung
{
    partial class w_s_schuelerimport
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
            this.lb_TxtQuali = new System.Windows.Forms.Label();
            this.lb_Vorschau = new System.Windows.Forms.Label();
            this.gv_Vorschau = new System.Windows.Forms.DataGridView();
            this.lb_FeldTrenn = new System.Windows.Forms.Label();
            this.bt_Vorschau = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Panel();
            this.bt_Import = new System.Windows.Forms.Button();
            this.gb_Ziel = new System.Windows.Forms.GroupBox();
            this.rb_schueler2 = new System.Windows.Forms.RadioButton();
            this.rb_schueler1 = new System.Windows.Forms.RadioButton();
            this.gv_columns = new System.Windows.Forms.DataGridView();
            this.bt_Abbrechen = new System.Windows.Forms.Button();
            this.cb_ColHeader = new System.Windows.Forms.CheckBox();
            this.cb_TxtQuali = new System.Windows.Forms.ComboBox();
            this.gb_Dateiformat = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_lines = new System.Windows.Forms.TextBox();
            this.cb_FeldTrenn = new System.Windows.Forms.ComboBox();
            this.lb_path = new System.Windows.Forms.Label();
            this.bt_durchsuchen = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.lb_anweissung = new System.Windows.Forms.Label();
            this.bibo_VerwaltungDataSet1 = new Bibo_Verwaltung.Bibo_VerwaltungDataSet();
            this.lb_Anweissung2 = new System.Windows.Forms.Label();
            this.bt_accept = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_saveProfile = new System.Windows.Forms.Button();
            this.rb_faecher = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Vorschau)).BeginInit();
            this.gb_Ziel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_columns)).BeginInit();
            this.gb_Dateiformat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_TxtQuali
            // 
            this.lb_TxtQuali.AutoSize = true;
            this.lb_TxtQuali.Location = new System.Drawing.Point(16, 131);
            this.lb_TxtQuali.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_TxtQuali.Name = "lb_TxtQuali";
            this.lb_TxtQuali.Size = new System.Drawing.Size(226, 32);
            this.lb_TxtQuali.TabIndex = 1;
            this.lb_TxtQuali.Text = "Textqualifizierer:";
            // 
            // lb_Vorschau
            // 
            this.lb_Vorschau.AutoSize = true;
            this.lb_Vorschau.Enabled = false;
            this.lb_Vorschau.Location = new System.Drawing.Point(45, 644);
            this.lb_Vorschau.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Vorschau.Name = "lb_Vorschau";
            this.lb_Vorschau.Size = new System.Drawing.Size(143, 32);
            this.lb_Vorschau.TabIndex = 24;
            this.lb_Vorschau.Text = "Vorschau:";
            // 
            // gv_Vorschau
            // 
            this.gv_Vorschau.AllowUserToAddRows = false;
            this.gv_Vorschau.AllowUserToDeleteRows = false;
            this.gv_Vorschau.AllowUserToOrderColumns = true;
            this.gv_Vorschau.AllowUserToResizeColumns = false;
            this.gv_Vorschau.AllowUserToResizeRows = false;
            this.gv_Vorschau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gv_Vorschau.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Vorschau.Enabled = false;
            this.gv_Vorschau.Location = new System.Drawing.Point(51, 750);
            this.gv_Vorschau.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gv_Vorschau.MultiSelect = false;
            this.gv_Vorschau.Name = "gv_Vorschau";
            this.gv_Vorschau.ReadOnly = true;
            this.gv_Vorschau.RowHeadersVisible = false;
            this.gv_Vorschau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gv_Vorschau.ShowEditingIcon = false;
            this.gv_Vorschau.Size = new System.Drawing.Size(1680, 149);
            this.gv_Vorschau.TabIndex = 23;
            this.gv_Vorschau.TabStop = false;
            this.gv_Vorschau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_Vorschau_KeyDown);
            // 
            // lb_FeldTrenn
            // 
            this.lb_FeldTrenn.AutoSize = true;
            this.lb_FeldTrenn.Location = new System.Drawing.Point(16, 67);
            this.lb_FeldTrenn.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_FeldTrenn.Name = "lb_FeldTrenn";
            this.lb_FeldTrenn.Size = new System.Drawing.Size(243, 32);
            this.lb_FeldTrenn.TabIndex = 0;
            this.lb_FeldTrenn.Text = "Feldtrennzeichen:";
            // 
            // bt_Vorschau
            // 
            this.bt_Vorschau.Enabled = false;
            this.bt_Vorschau.Location = new System.Drawing.Point(1029, 486);
            this.bt_Vorschau.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Vorschau.Name = "bt_Vorschau";
            this.bt_Vorschau.Size = new System.Drawing.Size(267, 55);
            this.bt_Vorschau.TabIndex = 25;
            this.bt_Vorschau.Text = "Vorschau";
            this.bt_Vorschau.UseVisualStyleBackColor = true;
            this.bt_Vorschau.Click += new System.EventHandler(this.bt_Vorschau_Click);
            // 
            // division
            // 
            this.division.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.division.Location = new System.Drawing.Point(51, 177);
            this.division.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(1677, 0);
            this.division.TabIndex = 27;
            // 
            // bt_Import
            // 
            this.bt_Import.Enabled = false;
            this.bt_Import.Location = new System.Drawing.Point(957, 913);
            this.bt_Import.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Import.Name = "bt_Import";
            this.bt_Import.Size = new System.Drawing.Size(267, 59);
            this.bt_Import.TabIndex = 28;
            this.bt_Import.Text = "Vorlage anwenden";
            this.bt_Import.UseVisualStyleBackColor = true;
            this.bt_Import.Click += new System.EventHandler(this.bt_Import_Click);
            // 
            // gb_Ziel
            // 
            this.gb_Ziel.Controls.Add(this.rb_faecher);
            this.gb_Ziel.Controls.Add(this.rb_schueler2);
            this.gb_Ziel.Controls.Add(this.rb_schueler1);
            this.gb_Ziel.Enabled = false;
            this.gb_Ziel.Location = new System.Drawing.Point(584, 296);
            this.gb_Ziel.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_Ziel.Name = "gb_Ziel";
            this.gb_Ziel.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_Ziel.Size = new System.Drawing.Size(712, 129);
            this.gb_Ziel.TabIndex = 30;
            this.gb_Ziel.TabStop = false;
            this.gb_Ziel.Text = "Importziel";
            // 
            // rb_schueler2
            // 
            this.rb_schueler2.AutoSize = true;
            this.rb_schueler2.Location = new System.Drawing.Point(309, 51);
            this.rb_schueler2.Name = "rb_schueler2";
            this.rb_schueler2.Size = new System.Drawing.Size(117, 36);
            this.rb_schueler2.TabIndex = 2;
            this.rb_schueler2.Text = "Sek2";
            this.rb_schueler2.UseVisualStyleBackColor = true;
            this.rb_schueler2.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rb_schueler1
            // 
            this.rb_schueler1.AutoSize = true;
            this.rb_schueler1.Checked = true;
            this.rb_schueler1.Location = new System.Drawing.Point(148, 51);
            this.rb_schueler1.Name = "rb_schueler1";
            this.rb_schueler1.Size = new System.Drawing.Size(117, 36);
            this.rb_schueler1.TabIndex = 1;
            this.rb_schueler1.TabStop = true;
            this.rb_schueler1.Text = "Sek1";
            this.rb_schueler1.UseVisualStyleBackColor = true;
            this.rb_schueler1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // gv_columns
            // 
            this.gv_columns.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gv_columns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_columns.Location = new System.Drawing.Point(51, 679);
            this.gv_columns.Name = "gv_columns";
            this.gv_columns.RowTemplate.Height = 40;
            this.gv_columns.Size = new System.Drawing.Size(1680, 61);
            this.gv_columns.TabIndex = 31;
            // 
            // bt_Abbrechen
            // 
            this.bt_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Abbrechen.Location = new System.Drawing.Point(1464, 913);
            this.bt_Abbrechen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Abbrechen.Name = "bt_Abbrechen";
            this.bt_Abbrechen.Size = new System.Drawing.Size(267, 55);
            this.bt_Abbrechen.TabIndex = 29;
            this.bt_Abbrechen.Text = "Abbrechen";
            this.bt_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // cb_ColHeader
            // 
            this.cb_ColHeader.AutoSize = true;
            this.cb_ColHeader.Location = new System.Drawing.Point(22, 193);
            this.cb_ColHeader.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cb_ColHeader.Name = "cb_ColHeader";
            this.cb_ColHeader.Size = new System.Drawing.Size(433, 36);
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
            this.cb_TxtQuali.Location = new System.Drawing.Point(275, 124);
            this.cb_TxtQuali.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cb_TxtQuali.Name = "cb_TxtQuali";
            this.cb_TxtQuali.Size = new System.Drawing.Size(220, 41);
            this.cb_TxtQuali.TabIndex = 4;
            // 
            // gb_Dateiformat
            // 
            this.gb_Dateiformat.Controls.Add(this.label1);
            this.gb_Dateiformat.Controls.Add(this.tb_lines);
            this.gb_Dateiformat.Controls.Add(this.cb_ColHeader);
            this.gb_Dateiformat.Controls.Add(this.cb_TxtQuali);
            this.gb_Dateiformat.Controls.Add(this.cb_FeldTrenn);
            this.gb_Dateiformat.Controls.Add(this.lb_TxtQuali);
            this.gb_Dateiformat.Controls.Add(this.lb_FeldTrenn);
            this.gb_Dateiformat.Enabled = false;
            this.gb_Dateiformat.Location = new System.Drawing.Point(51, 296);
            this.gb_Dateiformat.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_Dateiformat.Name = "gb_Dateiformat";
            this.gb_Dateiformat.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_Dateiformat.Size = new System.Drawing.Size(517, 314);
            this.gb_Dateiformat.TabIndex = 19;
            this.gb_Dateiformat.TabStop = false;
            this.gb_Dateiformat.Text = "Dateiformat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(311, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Obere Zeilen Entfernen";
            // 
            // tb_lines
            // 
            this.tb_lines.Location = new System.Drawing.Point(339, 240);
            this.tb_lines.Name = "tb_lines";
            this.tb_lines.Size = new System.Drawing.Size(153, 38);
            this.tb_lines.TabIndex = 6;
            this.tb_lines.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_lines_KeyPress);
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
            this.cb_FeldTrenn.Location = new System.Drawing.Point(275, 60);
            this.cb_FeldTrenn.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cb_FeldTrenn.Name = "cb_FeldTrenn";
            this.cb_FeldTrenn.Size = new System.Drawing.Size(220, 41);
            this.cb_FeldTrenn.TabIndex = 3;
            // 
            // lb_path
            // 
            this.lb_path.AutoSize = true;
            this.lb_path.Location = new System.Drawing.Point(139, 117);
            this.lb_path.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_path.Name = "lb_path";
            this.lb_path.Size = new System.Drawing.Size(161, 32);
            this.lb_path.TabIndex = 21;
            this.lb_path.Text = "Dateiname:";
            // 
            // bt_durchsuchen
            // 
            this.bt_durchsuchen.Location = new System.Drawing.Point(1464, 105);
            this.bt_durchsuchen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_durchsuchen.Name = "bt_durchsuchen";
            this.bt_durchsuchen.Size = new System.Drawing.Size(267, 55);
            this.bt_durchsuchen.TabIndex = 18;
            this.bt_durchsuchen.Text = "Durchsuchen...";
            this.bt_durchsuchen.UseVisualStyleBackColor = true;
            this.bt_durchsuchen.Click += new System.EventHandler(this.bt_durchsuchen_Click);
            // 
            // tb_path
            // 
            this.tb_path.Location = new System.Drawing.Point(318, 110);
            this.tb_path.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_path.Name = "tb_path";
            this.tb_path.Size = new System.Drawing.Size(1124, 38);
            this.tb_path.TabIndex = 17;
            this.tb_path.TextChanged += new System.EventHandler(this.tb_path_TextChanged);
            // 
            // lb_anweissung
            // 
            this.lb_anweissung.AutoSize = true;
            this.lb_anweissung.Location = new System.Drawing.Point(51, 46);
            this.lb_anweissung.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_anweissung.Name = "lb_anweissung";
            this.lb_anweissung.Size = new System.Drawing.Size(700, 32);
            this.lb_anweissung.TabIndex = 20;
            this.lb_anweissung.Text = "Geben Sie die Quelle der zu importierenden Daten an.";
            // 
            // bibo_VerwaltungDataSet1
            // 
            this.bibo_VerwaltungDataSet1.DataSetName = "Bibo_VerwaltungDataSet";
            this.bibo_VerwaltungDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lb_Anweissung2
            // 
            this.lb_Anweissung2.AutoSize = true;
            this.lb_Anweissung2.Location = new System.Drawing.Point(51, 225);
            this.lb_Anweissung2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Anweissung2.Name = "lb_Anweissung2";
            this.lb_Anweissung2.Size = new System.Drawing.Size(713, 32);
            this.lb_Anweissung2.TabIndex = 26;
            this.lb_Anweissung2.Text = "Stellen Sie die Definitionen der Datei-Formatierung ein.";
            // 
            // bt_accept
            // 
            this.bt_accept.Location = new System.Drawing.Point(1235, 913);
            this.bt_accept.Name = "bt_accept";
            this.bt_accept.Size = new System.Drawing.Size(207, 59);
            this.bt_accept.TabIndex = 32;
            this.bt_accept.Text = "Importieren";
            this.bt_accept.UseVisualStyleBackColor = true;
            this.bt_accept.Click += new System.EventHandler(this.bt_accept_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(1774, 242);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(916, 454);
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gv_Vorschau_KeyDown);
            // 
            // bt_saveProfile
            // 
            this.bt_saveProfile.Location = new System.Drawing.Point(1029, 555);
            this.bt_saveProfile.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_saveProfile.Name = "bt_saveProfile";
            this.bt_saveProfile.Size = new System.Drawing.Size(267, 55);
            this.bt_saveProfile.TabIndex = 28;
            this.bt_saveProfile.Text = "Profil Speichern";
            this.bt_saveProfile.UseVisualStyleBackColor = true;
            this.bt_saveProfile.Click += new System.EventHandler(this.bt_saveProfile_Click);
            // 
            // rb_faecher
            // 
            this.rb_faecher.AutoSize = true;
            this.rb_faecher.Location = new System.Drawing.Point(448, 51);
            this.rb_faecher.Name = "rb_faecher";
            this.rb_faecher.Size = new System.Drawing.Size(140, 36);
            this.rb_faecher.TabIndex = 2;
            this.rb_faecher.Text = "Fächer";
            this.rb_faecher.UseVisualStyleBackColor = true;
            this.rb_faecher.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // w_s_schuelerimport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 996);
            this.Controls.Add(this.bt_accept);
            this.Controls.Add(this.lb_Vorschau);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gv_Vorschau);
            this.Controls.Add(this.bt_Vorschau);
            this.Controls.Add(this.division);
            this.Controls.Add(this.bt_saveProfile);
            this.Controls.Add(this.bt_Import);
            this.Controls.Add(this.gb_Ziel);
            this.Controls.Add(this.gv_columns);
            this.Controls.Add(this.bt_Abbrechen);
            this.Controls.Add(this.gb_Dateiformat);
            this.Controls.Add(this.lb_path);
            this.Controls.Add(this.bt_durchsuchen);
            this.Controls.Add(this.tb_path);
            this.Controls.Add(this.lb_anweissung);
            this.Controls.Add(this.lb_Anweissung2);
            this.Name = "w_s_schuelerimport";
            this.Text = "Import von Schülern";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Vorschau)).EndInit();
            this.gb_Ziel.ResumeLayout(false);
            this.gb_Ziel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_columns)).EndInit();
            this.gb_Dateiformat.ResumeLayout(false);
            this.gb_Dateiformat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bibo_VerwaltungDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_TxtQuali;
        private System.Windows.Forms.Label lb_Vorschau;
        private System.Windows.Forms.DataGridView gv_Vorschau;
        private System.Windows.Forms.Label lb_FeldTrenn;
        private System.Windows.Forms.Button bt_Vorschau;
        private System.Windows.Forms.Panel division;
        private System.Windows.Forms.Button bt_Import;
        private System.Windows.Forms.GroupBox gb_Ziel;
        private System.Windows.Forms.DataGridView gv_columns;
        private System.Windows.Forms.Button bt_Abbrechen;
        private System.Windows.Forms.CheckBox cb_ColHeader;
        private System.Windows.Forms.ComboBox cb_TxtQuali;
        private System.Windows.Forms.GroupBox gb_Dateiformat;
        private System.Windows.Forms.ComboBox cb_FeldTrenn;
        private System.Windows.Forms.Label lb_path;
        private System.Windows.Forms.Button bt_durchsuchen;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.Label lb_anweissung;
        private Bibo_VerwaltungDataSet bibo_VerwaltungDataSet1;
        private System.Windows.Forms.Label lb_Anweissung2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_lines;
        private System.Windows.Forms.Button bt_accept;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton rb_schueler2;
        private System.Windows.Forms.RadioButton rb_schueler1;
        private System.Windows.Forms.Button bt_saveProfile;
        private System.Windows.Forms.RadioButton rb_faecher;
    }
}