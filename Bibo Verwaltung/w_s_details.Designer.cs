namespace Bibo_Verwaltung
{
    partial class w_s_details
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
            this.gv_Details = new System.Windows.Forms.DataGridView();
            this.cb_KundeAnz = new System.Windows.Forms.CheckBox();
            this.cb_Ferfügbark_Anz = new System.Windows.Forms.CheckBox();
            this.dateTimePickerAusleihen = new System.Windows.Forms.DateTimePicker();
            this.cb_Ausleihen = new System.Windows.Forms.GroupBox();
            this.lb_verleihfaehig = new System.Windows.Forms.Label();
            this.tb_verleihfaehig = new System.Windows.Forms.TextBox();
            this.lb_Zustand = new System.Windows.Forms.Label();
            this.tb_Zustand = new System.Windows.Forms.TextBox();
            this.tb_KID = new System.Windows.Forms.TextBox();
            this.bt_Abschliessen = new System.Windows.Forms.Button();
            this.lb_Kunde = new System.Windows.Forms.Label();
            this.tb_Kunde = new System.Windows.Forms.TextBox();
            this.lb_Rück = new System.Windows.Forms.Label();
            this.lb_Buch = new System.Windows.Forms.Label();
            this.tb_Buch = new System.Windows.Forms.TextBox();
            this.tb_BuchID = new System.Windows.Forms.TextBox();
            this.bt_Ausleihen = new System.Windows.Forms.Button();
            this.gb_Suchen = new System.Windows.Forms.GroupBox();
            this.combo_Verlag = new System.Windows.Forms.ComboBox();
            this.combo_Genre = new System.Windows.Forms.ComboBox();
            this.combo_Autor = new System.Windows.Forms.ComboBox();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.cb_s_Autor = new System.Windows.Forms.CheckBox();
            this.cb_s_Genre = new System.Windows.Forms.CheckBox();
            this.cb_s_Verlag = new System.Windows.Forms.CheckBox();
            this.cb_s_Titel = new System.Windows.Forms.CheckBox();
            this.tb_s_Titel = new System.Windows.Forms.TextBox();
            this.bt_Rueckgabe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Details)).BeginInit();
            this.cb_Ausleihen.SuspendLayout();
            this.gb_Suchen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_Details
            // 
            this.gv_Details.AllowUserToAddRows = false;
            this.gv_Details.AllowUserToDeleteRows = false;
            this.gv_Details.AllowUserToResizeColumns = false;
            this.gv_Details.AllowUserToResizeRows = false;
            this.gv_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Details.Cursor = System.Windows.Forms.Cursors.Default;
            this.gv_Details.Location = new System.Drawing.Point(12, 100);
            this.gv_Details.MultiSelect = false;
            this.gv_Details.Name = "gv_Details";
            this.gv_Details.ReadOnly = true;
            this.gv_Details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Details.ShowEditingIcon = false;
            this.gv_Details.Size = new System.Drawing.Size(1035, 262);
            this.gv_Details.TabIndex = 0;
            this.gv_Details.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Buecher_CellDoubleClick);
            // 
            // cb_KundeAnz
            // 
            this.cb_KundeAnz.AutoSize = true;
            this.cb_KundeAnz.Location = new System.Drawing.Point(866, 368);
            this.cb_KundeAnz.Name = "cb_KundeAnz";
            this.cb_KundeAnz.Size = new System.Drawing.Size(181, 17);
            this.cb_KundeAnz.TabIndex = 1;
            this.cb_KundeAnz.Text = "Kundeninformationen einblenden";
            this.cb_KundeAnz.UseVisualStyleBackColor = true;
            this.cb_KundeAnz.CheckedChanged += new System.EventHandler(this.cb_KundeAnz_CheckedChanged);
            // 
            // cb_Ferfügbark_Anz
            // 
            this.cb_Ferfügbark_Anz.AutoSize = true;
            this.cb_Ferfügbark_Anz.Location = new System.Drawing.Point(659, 368);
            this.cb_Ferfügbark_Anz.Name = "cb_Ferfügbark_Anz";
            this.cb_Ferfügbark_Anz.Size = new System.Drawing.Size(201, 17);
            this.cb_Ferfügbark_Anz.TabIndex = 2;
            this.cb_Ferfügbark_Anz.Text = "Nur verleihbereite Bücher einblenden";
            this.cb_Ferfügbark_Anz.UseVisualStyleBackColor = true;
            this.cb_Ferfügbark_Anz.CheckedChanged += new System.EventHandler(this.cb_Ferfügbark_Anz_CheckedChanged);
            // 
            // dateTimePickerAusleihen
            // 
            this.dateTimePickerAusleihen.Location = new System.Drawing.Point(101, 126);
            this.dateTimePickerAusleihen.Name = "dateTimePickerAusleihen";
            this.dateTimePickerAusleihen.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAusleihen.TabIndex = 3;
            // 
            // cb_Ausleihen
            // 
            this.cb_Ausleihen.Controls.Add(this.lb_verleihfaehig);
            this.cb_Ausleihen.Controls.Add(this.tb_verleihfaehig);
            this.cb_Ausleihen.Controls.Add(this.lb_Zustand);
            this.cb_Ausleihen.Controls.Add(this.tb_Zustand);
            this.cb_Ausleihen.Controls.Add(this.tb_KID);
            this.cb_Ausleihen.Controls.Add(this.bt_Abschliessen);
            this.cb_Ausleihen.Controls.Add(this.lb_Kunde);
            this.cb_Ausleihen.Controls.Add(this.tb_Kunde);
            this.cb_Ausleihen.Controls.Add(this.lb_Rück);
            this.cb_Ausleihen.Controls.Add(this.lb_Buch);
            this.cb_Ausleihen.Controls.Add(this.tb_Buch);
            this.cb_Ausleihen.Controls.Add(this.tb_BuchID);
            this.cb_Ausleihen.Controls.Add(this.dateTimePickerAusleihen);
            this.cb_Ausleihen.Location = new System.Drawing.Point(12, 397);
            this.cb_Ausleihen.Name = "cb_Ausleihen";
            this.cb_Ausleihen.Size = new System.Drawing.Size(1035, 202);
            this.cb_Ausleihen.TabIndex = 5;
            this.cb_Ausleihen.TabStop = false;
            this.cb_Ausleihen.Text = "Buch ausleihen:";
            // 
            // lb_verleihfaehig
            // 
            this.lb_verleihfaehig.AutoSize = true;
            this.lb_verleihfaehig.Location = new System.Drawing.Point(6, 51);
            this.lb_verleihfaehig.Name = "lb_verleihfaehig";
            this.lb_verleihfaehig.Size = new System.Drawing.Size(65, 13);
            this.lb_verleihfaehig.TabIndex = 16;
            this.lb_verleihfaehig.Text = "Verleihfähig:";
            // 
            // tb_verleihfaehig
            // 
            this.tb_verleihfaehig.Location = new System.Drawing.Point(101, 48);
            this.tb_verleihfaehig.Name = "tb_verleihfaehig";
            this.tb_verleihfaehig.ReadOnly = true;
            this.tb_verleihfaehig.Size = new System.Drawing.Size(200, 20);
            this.tb_verleihfaehig.TabIndex = 15;
            this.tb_verleihfaehig.TabStop = false;
            // 
            // lb_Zustand
            // 
            this.lb_Zustand.AutoSize = true;
            this.lb_Zustand.Location = new System.Drawing.Point(6, 77);
            this.lb_Zustand.Name = "lb_Zustand";
            this.lb_Zustand.Size = new System.Drawing.Size(49, 13);
            this.lb_Zustand.TabIndex = 14;
            this.lb_Zustand.Text = "Zustand:";
            // 
            // tb_Zustand
            // 
            this.tb_Zustand.Location = new System.Drawing.Point(101, 74);
            this.tb_Zustand.Name = "tb_Zustand";
            this.tb_Zustand.ReadOnly = true;
            this.tb_Zustand.Size = new System.Drawing.Size(200, 20);
            this.tb_Zustand.TabIndex = 13;
            this.tb_Zustand.TabStop = false;
            // 
            // tb_KID
            // 
            this.tb_KID.Enabled = false;
            this.tb_KID.Location = new System.Drawing.Point(307, 100);
            this.tb_KID.Name = "tb_KID";
            this.tb_KID.ReadOnly = true;
            this.tb_KID.Size = new System.Drawing.Size(24, 20);
            this.tb_KID.TabIndex = 12;
            this.tb_KID.TabStop = false;
            // 
            // bt_Abschliessen
            // 
            this.bt_Abschliessen.Enabled = false;
            this.bt_Abschliessen.Location = new System.Drawing.Point(171, 152);
            this.bt_Abschliessen.Name = "bt_Abschliessen";
            this.bt_Abschliessen.Size = new System.Drawing.Size(130, 23);
            this.bt_Abschliessen.TabIndex = 11;
            this.bt_Abschliessen.Text = "Buch jetzt ausleihen";
            this.bt_Abschliessen.UseVisualStyleBackColor = true;
            this.bt_Abschliessen.Click += new System.EventHandler(this.Ausleihen_Bestaetigen);
            // 
            // lb_Kunde
            // 
            this.lb_Kunde.AutoSize = true;
            this.lb_Kunde.Location = new System.Drawing.Point(6, 103);
            this.lb_Kunde.Name = "lb_Kunde";
            this.lb_Kunde.Size = new System.Drawing.Size(41, 13);
            this.lb_Kunde.TabIndex = 10;
            this.lb_Kunde.Text = "Kunde:";
            // 
            // tb_Kunde
            // 
            this.tb_Kunde.Location = new System.Drawing.Point(101, 100);
            this.tb_Kunde.Name = "tb_Kunde";
            this.tb_Kunde.ReadOnly = true;
            this.tb_Kunde.Size = new System.Drawing.Size(200, 20);
            this.tb_Kunde.TabIndex = 9;
            this.tb_Kunde.TabStop = false;
            // 
            // lb_Rück
            // 
            this.lb_Rück.AutoSize = true;
            this.lb_Rück.Location = new System.Drawing.Point(6, 132);
            this.lb_Rück.Name = "lb_Rück";
            this.lb_Rück.Size = new System.Drawing.Size(89, 13);
            this.lb_Rück.TabIndex = 8;
            this.lb_Rück.Text = "Rückgabedatum:";
            // 
            // lb_Buch
            // 
            this.lb_Buch.AutoSize = true;
            this.lb_Buch.Location = new System.Drawing.Point(6, 25);
            this.lb_Buch.Name = "lb_Buch";
            this.lb_Buch.Size = new System.Drawing.Size(35, 13);
            this.lb_Buch.TabIndex = 7;
            this.lb_Buch.Text = "Buch:";
            // 
            // tb_Buch
            // 
            this.tb_Buch.Location = new System.Drawing.Point(101, 22);
            this.tb_Buch.Name = "tb_Buch";
            this.tb_Buch.ReadOnly = true;
            this.tb_Buch.Size = new System.Drawing.Size(200, 20);
            this.tb_Buch.TabIndex = 6;
            this.tb_Buch.TabStop = false;
            // 
            // tb_BuchID
            // 
            this.tb_BuchID.Enabled = false;
            this.tb_BuchID.Location = new System.Drawing.Point(307, 22);
            this.tb_BuchID.Name = "tb_BuchID";
            this.tb_BuchID.ReadOnly = true;
            this.tb_BuchID.Size = new System.Drawing.Size(24, 20);
            this.tb_BuchID.TabIndex = 4;
            this.tb_BuchID.TabStop = false;
            // 
            // bt_Ausleihen
            // 
            this.bt_Ausleihen.Location = new System.Drawing.Point(12, 368);
            this.bt_Ausleihen.Name = "bt_Ausleihen";
            this.bt_Ausleihen.Size = new System.Drawing.Size(125, 23);
            this.bt_Ausleihen.TabIndex = 11;
            this.bt_Ausleihen.Text = "Ausleihvorgang starten";
            this.bt_Ausleihen.UseVisualStyleBackColor = true;
            this.bt_Ausleihen.Click += new System.EventHandler(this.Ausleihvorgang);
            // 
            // gb_Suchen
            // 
            this.gb_Suchen.Controls.Add(this.combo_Verlag);
            this.gb_Suchen.Controls.Add(this.combo_Genre);
            this.gb_Suchen.Controls.Add(this.combo_Autor);
            this.gb_Suchen.Controls.Add(this.bt_Clear);
            this.gb_Suchen.Controls.Add(this.cb_s_Autor);
            this.gb_Suchen.Controls.Add(this.cb_s_Genre);
            this.gb_Suchen.Controls.Add(this.cb_s_Verlag);
            this.gb_Suchen.Controls.Add(this.cb_s_Titel);
            this.gb_Suchen.Controls.Add(this.tb_s_Titel);
            this.gb_Suchen.Location = new System.Drawing.Point(12, 12);
            this.gb_Suchen.Name = "gb_Suchen";
            this.gb_Suchen.Size = new System.Drawing.Size(1035, 82);
            this.gb_Suchen.TabIndex = 13;
            this.gb_Suchen.TabStop = false;
            this.gb_Suchen.Text = "Suchen nach:";
            // 
            // combo_Verlag
            // 
            this.combo_Verlag.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Verlag.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Verlag.Enabled = false;
            this.combo_Verlag.FormattingEnabled = true;
            this.combo_Verlag.Location = new System.Drawing.Point(841, 19);
            this.combo_Verlag.Name = "combo_Verlag";
            this.combo_Verlag.Size = new System.Drawing.Size(180, 21);
            this.combo_Verlag.Sorted = true;
            this.combo_Verlag.TabIndex = 29;
            this.combo_Verlag.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            // 
            // combo_Genre
            // 
            this.combo_Genre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Genre.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Genre.Enabled = false;
            this.combo_Genre.FormattingEnabled = true;
            this.combo_Genre.Location = new System.Drawing.Point(580, 19);
            this.combo_Genre.Name = "combo_Genre";
            this.combo_Genre.Size = new System.Drawing.Size(180, 21);
            this.combo_Genre.Sorted = true;
            this.combo_Genre.TabIndex = 28;
            this.combo_Genre.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            // 
            // combo_Autor
            // 
            this.combo_Autor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.combo_Autor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_Autor.Enabled = false;
            this.combo_Autor.FormattingEnabled = true;
            this.combo_Autor.Location = new System.Drawing.Point(320, 19);
            this.combo_Autor.Name = "combo_Autor";
            this.combo_Autor.Size = new System.Drawing.Size(180, 21);
            this.combo_Autor.Sorted = true;
            this.combo_Autor.TabIndex = 27;
            this.combo_Autor.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(947, 46);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(74, 23);
            this.bt_Clear.TabIndex = 26;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // cb_s_Autor
            // 
            this.cb_s_Autor.AutoSize = true;
            this.cb_s_Autor.Location = new System.Drawing.Point(260, 21);
            this.cb_s_Autor.Name = "cb_s_Autor";
            this.cb_s_Autor.Size = new System.Drawing.Size(54, 17);
            this.cb_s_Autor.TabIndex = 24;
            this.cb_s_Autor.Text = "Autor:";
            this.cb_s_Autor.UseVisualStyleBackColor = true;
            this.cb_s_Autor.CheckedChanged += new System.EventHandler(this.cb_s_Autor_CheckedChanged);
            // 
            // cb_s_Genre
            // 
            this.cb_s_Genre.AutoSize = true;
            this.cb_s_Genre.Location = new System.Drawing.Point(516, 21);
            this.cb_s_Genre.Name = "cb_s_Genre";
            this.cb_s_Genre.Size = new System.Drawing.Size(58, 17);
            this.cb_s_Genre.TabIndex = 23;
            this.cb_s_Genre.Text = "Genre:";
            this.cb_s_Genre.UseVisualStyleBackColor = true;
            this.cb_s_Genre.CheckedChanged += new System.EventHandler(this.cb_s_Genre_CheckedChanged);
            // 
            // cb_s_Verlag
            // 
            this.cb_s_Verlag.AutoSize = true;
            this.cb_s_Verlag.Location = new System.Drawing.Point(776, 21);
            this.cb_s_Verlag.Name = "cb_s_Verlag";
            this.cb_s_Verlag.Size = new System.Drawing.Size(59, 17);
            this.cb_s_Verlag.TabIndex = 22;
            this.cb_s_Verlag.Text = "Verlag:";
            this.cb_s_Verlag.UseVisualStyleBackColor = true;
            this.cb_s_Verlag.CheckedChanged += new System.EventHandler(this.cb_s_Verlag_CheckedChanged);
            // 
            // cb_s_Titel
            // 
            this.cb_s_Titel.AutoSize = true;
            this.cb_s_Titel.Location = new System.Drawing.Point(9, 21);
            this.cb_s_Titel.Name = "cb_s_Titel";
            this.cb_s_Titel.Size = new System.Drawing.Size(49, 17);
            this.cb_s_Titel.TabIndex = 21;
            this.cb_s_Titel.Text = "Titel:";
            this.cb_s_Titel.UseVisualStyleBackColor = true;
            this.cb_s_Titel.CheckedChanged += new System.EventHandler(this.cb_s_Titel_CheckedChanged);
            // 
            // tb_s_Titel
            // 
            this.tb_s_Titel.Enabled = false;
            this.tb_s_Titel.Location = new System.Drawing.Point(64, 19);
            this.tb_s_Titel.Name = "tb_s_Titel";
            this.tb_s_Titel.Size = new System.Drawing.Size(180, 20);
            this.tb_s_Titel.TabIndex = 17;
            this.tb_s_Titel.TextChanged += new System.EventHandler(this.Buchsuche_ausfuehren);
            // 
            // bt_Rueckgabe
            // 
            this.bt_Rueckgabe.Location = new System.Drawing.Point(143, 368);
            this.bt_Rueckgabe.Name = "bt_Rueckgabe";
            this.bt_Rueckgabe.Size = new System.Drawing.Size(113, 23);
            this.bt_Rueckgabe.TabIndex = 14;
            this.bt_Rueckgabe.Text = "Buchrückgabe";
            this.bt_Rueckgabe.UseVisualStyleBackColor = true;
            this.bt_Rueckgabe.Click += new System.EventHandler(this.bt_Rueckgabe_Click);
            // 
            // w_s_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 611);
            this.Controls.Add(this.bt_Rueckgabe);
            this.Controls.Add(this.gb_Suchen);
            this.Controls.Add(this.bt_Ausleihen);
            this.Controls.Add(this.cb_Ausleihen);
            this.Controls.Add(this.cb_Ferfügbark_Anz);
            this.Controls.Add(this.cb_KundeAnz);
            this.Controls.Add(this.gv_Details);
            this.Name = "w_s_details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buch Suchen/Ausleihen";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Details)).EndInit();
            this.cb_Ausleihen.ResumeLayout(false);
            this.cb_Ausleihen.PerformLayout();
            this.gb_Suchen.ResumeLayout(false);
            this.gb_Suchen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Details;
        private System.Windows.Forms.CheckBox cb_KundeAnz;
        private System.Windows.Forms.CheckBox cb_Ferfügbark_Anz;
        private System.Windows.Forms.DateTimePicker dateTimePickerAusleihen;
        private System.Windows.Forms.GroupBox cb_Ausleihen;
        private System.Windows.Forms.Label lb_Buch;
        private System.Windows.Forms.TextBox tb_Buch;
        private System.Windows.Forms.TextBox tb_BuchID;
        private System.Windows.Forms.Label lb_Kunde;
        private System.Windows.Forms.TextBox tb_Kunde;
        private System.Windows.Forms.Label lb_Rück;
        private System.Windows.Forms.Button bt_Ausleihen;
        private System.Windows.Forms.Button bt_Abschliessen;
        private System.Windows.Forms.GroupBox gb_Suchen;
        private System.Windows.Forms.CheckBox cb_s_Autor;
        private System.Windows.Forms.CheckBox cb_s_Genre;
        private System.Windows.Forms.CheckBox cb_s_Verlag;
        private System.Windows.Forms.CheckBox cb_s_Titel;
        private System.Windows.Forms.TextBox tb_s_Titel;
        private System.Windows.Forms.TextBox tb_KID;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Rueckgabe;
        private System.Windows.Forms.ComboBox combo_Genre;
        private System.Windows.Forms.ComboBox combo_Autor;
        private System.Windows.Forms.ComboBox combo_Verlag;
        private System.Windows.Forms.Label lb_verleihfaehig;
        private System.Windows.Forms.TextBox tb_verleihfaehig;
        private System.Windows.Forms.Label lb_Zustand;
        private System.Windows.Forms.TextBox tb_Zustand;
    }
}