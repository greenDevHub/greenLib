﻿namespace Bibo_Verwaltung
{
    partial class w_s_Kunden
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
            this.lb_Telefonnummer = new System.Windows.Forms.Label();
            this.tb_Telefonnummer = new System.Windows.Forms.TextBox();
            this.lb_Mail = new System.Windows.Forms.Label();
            this.tb_Mail = new System.Windows.Forms.TextBox();
            this.tb_Klasse = new System.Windows.Forms.TextBox();
            this.lb_Klasse = new System.Windows.Forms.Label();
            this.cb_Vertrauenswuerdigkeit = new System.Windows.Forms.ComboBox();
            this.lb_Vertrauenswuerdigkeit = new System.Windows.Forms.Label();
            this.tb_Ort = new System.Windows.Forms.TextBox();
            this.lb_Ort = new System.Windows.Forms.Label();
            this.tb_Postleitzahl = new System.Windows.Forms.TextBox();
            this.lb_Postleitzahl = new System.Windows.Forms.Label();
            this.tb_Hausnummer = new System.Windows.Forms.TextBox();
            this.lb_Hausnummer = new System.Windows.Forms.Label();
            this.tb_Strasse = new System.Windows.Forms.TextBox();
            this.lb_Strasse = new System.Windows.Forms.Label();
            this.tb_Nachname = new System.Windows.Forms.TextBox();
            this.lb_Nachname = new System.Windows.Forms.Label();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.lb_Vorname = new System.Windows.Forms.Label();
            this.tb_KundenID = new System.Windows.Forms.TextBox();
            this.gb_kunde = new System.Windows.Forms.GroupBox();
            this.lb_kunde_add = new System.Windows.Forms.Label();
            this.bt_clear_kunden = new System.Windows.Forms.Button();
            this.rb_KundeLoeschen = new System.Windows.Forms.RadioButton();
            this.rb_KundeBearbeiten = new System.Windows.Forms.RadioButton();
            this.rb_Neukunde = new System.Windows.Forms.RadioButton();
            this.bt_save_kunde = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grid_Kunde = new System.Windows.Forms.DataGridView();
            this.gb_kunde.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Kunde)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Telefonnummer
            // 
            this.lb_Telefonnummer.AutoSize = true;
            this.lb_Telefonnummer.Location = new System.Drawing.Point(41, 288);
            this.lb_Telefonnummer.Name = "lb_Telefonnummer";
            this.lb_Telefonnummer.Size = new System.Drawing.Size(83, 13);
            this.lb_Telefonnummer.TabIndex = 16;
            this.lb_Telefonnummer.Text = "Telefonnummer:";
            // 
            // tb_Telefonnummer
            // 
            this.tb_Telefonnummer.Location = new System.Drawing.Point(156, 285);
            this.tb_Telefonnummer.Name = "tb_Telefonnummer";
            this.tb_Telefonnummer.Size = new System.Drawing.Size(205, 20);
            this.tb_Telefonnummer.TabIndex = 11;
            this.tb_Telefonnummer.TextChanged += new System.EventHandler(this.tb_Telefonnummer_TextChanged);
            // 
            // lb_Mail
            // 
            this.lb_Mail.AutoSize = true;
            this.lb_Mail.Location = new System.Drawing.Point(41, 262);
            this.lb_Mail.Name = "lb_Mail";
            this.lb_Mail.Size = new System.Drawing.Size(29, 13);
            this.lb_Mail.TabIndex = 37;
            this.lb_Mail.Text = "Mail:";
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(156, 259);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(205, 20);
            this.tb_Mail.TabIndex = 10;
            this.tb_Mail.TextChanged += new System.EventHandler(this.tb_Mail_TextChanged);
            // 
            // tb_Klasse
            // 
            this.tb_Klasse.Location = new System.Drawing.Point(156, 233);
            this.tb_Klasse.Name = "tb_Klasse";
            this.tb_Klasse.Size = new System.Drawing.Size(79, 20);
            this.tb_Klasse.TabIndex = 9;
            this.tb_Klasse.TextChanged += new System.EventHandler(this.tb_Klasse_TextChanged);
            // 
            // lb_Klasse
            // 
            this.lb_Klasse.AutoSize = true;
            this.lb_Klasse.Location = new System.Drawing.Point(41, 236);
            this.lb_Klasse.Name = "lb_Klasse";
            this.lb_Klasse.Size = new System.Drawing.Size(41, 13);
            this.lb_Klasse.TabIndex = 34;
            this.lb_Klasse.Text = "Klasse:";
            // 
            // cb_Vertrauenswuerdigkeit
            // 
            this.cb_Vertrauenswuerdigkeit.FormattingEnabled = true;
            this.cb_Vertrauenswuerdigkeit.Items.AddRange(new object[] {
            "vertrauenswürdig",
            "nicht vertrauenswürdig",
            "noch nicht bestimmt"});
            this.cb_Vertrauenswuerdigkeit.Location = new System.Drawing.Point(156, 206);
            this.cb_Vertrauenswuerdigkeit.Name = "cb_Vertrauenswuerdigkeit";
            this.cb_Vertrauenswuerdigkeit.Size = new System.Drawing.Size(205, 21);
            this.cb_Vertrauenswuerdigkeit.TabIndex = 8;
            this.cb_Vertrauenswuerdigkeit.TextChanged += new System.EventHandler(this.cb_Vertrauenswuerdigkeit_TextChanged_1);
            // 
            // lb_Vertrauenswuerdigkeit
            // 
            this.lb_Vertrauenswuerdigkeit.AutoSize = true;
            this.lb_Vertrauenswuerdigkeit.Location = new System.Drawing.Point(41, 211);
            this.lb_Vertrauenswuerdigkeit.Name = "lb_Vertrauenswuerdigkeit";
            this.lb_Vertrauenswuerdigkeit.Size = new System.Drawing.Size(109, 13);
            this.lb_Vertrauenswuerdigkeit.TabIndex = 33;
            this.lb_Vertrauenswuerdigkeit.Text = "Vertrauenswürdigkeit:";
            // 
            // tb_Ort
            // 
            this.tb_Ort.Location = new System.Drawing.Point(156, 180);
            this.tb_Ort.Name = "tb_Ort";
            this.tb_Ort.Size = new System.Drawing.Size(205, 20);
            this.tb_Ort.TabIndex = 7;
            this.tb_Ort.TextChanged += new System.EventHandler(this.tb_Ort_TextChanged);
            // 
            // lb_Ort
            // 
            this.lb_Ort.AutoSize = true;
            this.lb_Ort.Location = new System.Drawing.Point(41, 183);
            this.lb_Ort.Name = "lb_Ort";
            this.lb_Ort.Size = new System.Drawing.Size(51, 13);
            this.lb_Ort.TabIndex = 31;
            this.lb_Ort.Text = "Wohnort:";
            // 
            // tb_Postleitzahl
            // 
            this.tb_Postleitzahl.Location = new System.Drawing.Point(156, 154);
            this.tb_Postleitzahl.Name = "tb_Postleitzahl";
            this.tb_Postleitzahl.Size = new System.Drawing.Size(79, 20);
            this.tb_Postleitzahl.TabIndex = 6;
            this.tb_Postleitzahl.TextChanged += new System.EventHandler(this.tb_Postleitzahl_TextChanged);
            // 
            // lb_Postleitzahl
            // 
            this.lb_Postleitzahl.AutoSize = true;
            this.lb_Postleitzahl.Location = new System.Drawing.Point(41, 157);
            this.lb_Postleitzahl.Name = "lb_Postleitzahl";
            this.lb_Postleitzahl.Size = new System.Drawing.Size(63, 13);
            this.lb_Postleitzahl.TabIndex = 29;
            this.lb_Postleitzahl.Text = "Postleitzahl:";
            // 
            // tb_Hausnummer
            // 
            this.tb_Hausnummer.Location = new System.Drawing.Point(156, 128);
            this.tb_Hausnummer.Name = "tb_Hausnummer";
            this.tb_Hausnummer.Size = new System.Drawing.Size(79, 20);
            this.tb_Hausnummer.TabIndex = 5;
            this.tb_Hausnummer.TextChanged += new System.EventHandler(this.tb_Hausnummer_TextChanged);
            // 
            // lb_Hausnummer
            // 
            this.lb_Hausnummer.AutoSize = true;
            this.lb_Hausnummer.Location = new System.Drawing.Point(41, 131);
            this.lb_Hausnummer.Name = "lb_Hausnummer";
            this.lb_Hausnummer.Size = new System.Drawing.Size(72, 13);
            this.lb_Hausnummer.TabIndex = 27;
            this.lb_Hausnummer.Text = "Hausnummer:";
            // 
            // tb_Strasse
            // 
            this.tb_Strasse.Location = new System.Drawing.Point(156, 102);
            this.tb_Strasse.Name = "tb_Strasse";
            this.tb_Strasse.Size = new System.Drawing.Size(205, 20);
            this.tb_Strasse.TabIndex = 4;
            this.tb_Strasse.TextChanged += new System.EventHandler(this.tb_Strasse_TextChanged);
            // 
            // lb_Strasse
            // 
            this.lb_Strasse.AutoSize = true;
            this.lb_Strasse.Location = new System.Drawing.Point(41, 105);
            this.lb_Strasse.Name = "lb_Strasse";
            this.lb_Strasse.Size = new System.Drawing.Size(45, 13);
            this.lb_Strasse.TabIndex = 7;
            this.lb_Strasse.Text = "Strasse:";
            // 
            // tb_Nachname
            // 
            this.tb_Nachname.Location = new System.Drawing.Point(156, 76);
            this.tb_Nachname.Name = "tb_Nachname";
            this.tb_Nachname.Size = new System.Drawing.Size(205, 20);
            this.tb_Nachname.TabIndex = 2;
            this.tb_Nachname.TextChanged += new System.EventHandler(this.tb_Nachname_TextChanged);
            // 
            // lb_Nachname
            // 
            this.lb_Nachname.AutoSize = true;
            this.lb_Nachname.Location = new System.Drawing.Point(41, 79);
            this.lb_Nachname.Name = "lb_Nachname";
            this.lb_Nachname.Size = new System.Drawing.Size(62, 13);
            this.lb_Nachname.TabIndex = 23;
            this.lb_Nachname.Text = "Nachname:";
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Location = new System.Drawing.Point(156, 50);
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.Size = new System.Drawing.Size(205, 20);
            this.tb_Vorname.TabIndex = 1;
            this.tb_Vorname.TextChanged += new System.EventHandler(this.tb_Vorname_TextChanged);
            // 
            // lb_Vorname
            // 
            this.lb_Vorname.AutoSize = true;
            this.lb_Vorname.Location = new System.Drawing.Point(41, 53);
            this.lb_Vorname.Name = "lb_Vorname";
            this.lb_Vorname.Size = new System.Drawing.Size(52, 13);
            this.lb_Vorname.TabIndex = 21;
            this.lb_Vorname.Text = "Vorname:";
            // 
            // tb_KundenID
            // 
            this.tb_KundenID.Enabled = false;
            this.tb_KundenID.Location = new System.Drawing.Point(367, 50);
            this.tb_KundenID.Name = "tb_KundenID";
            this.tb_KundenID.ReadOnly = true;
            this.tb_KundenID.Size = new System.Drawing.Size(20, 20);
            this.tb_KundenID.TabIndex = 3;
            this.tb_KundenID.Visible = false;
            this.tb_KundenID.TextChanged += new System.EventHandler(this.tb_KundenID_TextChanged);
            // 
            // gb_kunde
            // 
            this.gb_kunde.Controls.Add(this.lb_kunde_add);
            this.gb_kunde.Controls.Add(this.bt_clear_kunden);
            this.gb_kunde.Controls.Add(this.rb_KundeLoeschen);
            this.gb_kunde.Controls.Add(this.rb_KundeBearbeiten);
            this.gb_kunde.Controls.Add(this.rb_Neukunde);
            this.gb_kunde.Controls.Add(this.bt_save_kunde);
            this.gb_kunde.Controls.Add(this.lb_Telefonnummer);
            this.gb_kunde.Controls.Add(this.tb_Telefonnummer);
            this.gb_kunde.Controls.Add(this.lb_Mail);
            this.gb_kunde.Controls.Add(this.tb_Mail);
            this.gb_kunde.Controls.Add(this.tb_Klasse);
            this.gb_kunde.Controls.Add(this.lb_Klasse);
            this.gb_kunde.Controls.Add(this.cb_Vertrauenswuerdigkeit);
            this.gb_kunde.Controls.Add(this.lb_Vertrauenswuerdigkeit);
            this.gb_kunde.Controls.Add(this.tb_Ort);
            this.gb_kunde.Controls.Add(this.lb_Ort);
            this.gb_kunde.Controls.Add(this.tb_Postleitzahl);
            this.gb_kunde.Controls.Add(this.lb_Postleitzahl);
            this.gb_kunde.Controls.Add(this.tb_Hausnummer);
            this.gb_kunde.Controls.Add(this.lb_Hausnummer);
            this.gb_kunde.Controls.Add(this.tb_Strasse);
            this.gb_kunde.Controls.Add(this.lb_Strasse);
            this.gb_kunde.Controls.Add(this.tb_Nachname);
            this.gb_kunde.Controls.Add(this.lb_Nachname);
            this.gb_kunde.Controls.Add(this.tb_Vorname);
            this.gb_kunde.Controls.Add(this.lb_Vorname);
            this.gb_kunde.Controls.Add(this.tb_KundenID);
            this.gb_kunde.Location = new System.Drawing.Point(372, 11);
            this.gb_kunde.Name = "gb_kunde";
            this.gb_kunde.Size = new System.Drawing.Size(400, 378);
            this.gb_kunde.TabIndex = 0;
            this.gb_kunde.TabStop = false;
            this.gb_kunde.Text = "Kunden verwalten";
            // 
            // lb_kunde_add
            // 
            this.lb_kunde_add.AutoSize = true;
            this.lb_kunde_add.Location = new System.Drawing.Point(100, 350);
            this.lb_kunde_add.Name = "lb_kunde_add";
            this.lb_kunde_add.Size = new System.Drawing.Size(203, 13);
            this.lb_kunde_add.TabIndex = 40;
            this.lb_kunde_add.Text = "Der Kunde wurde erfolgreich hinzugefügt!";
            this.lb_kunde_add.Visible = false;
            // 
            // bt_clear_kunden
            // 
            this.bt_clear_kunden.Location = new System.Drawing.Point(261, 311);
            this.bt_clear_kunden.Name = "bt_clear_kunden";
            this.bt_clear_kunden.Size = new System.Drawing.Size(100, 23);
            this.bt_clear_kunden.TabIndex = 14;
            this.bt_clear_kunden.Text = "Clear";
            this.bt_clear_kunden.UseVisualStyleBackColor = true;
            this.bt_clear_kunden.Click += new System.EventHandler(this.Clear_Kunde);
            // 
            // rb_KundeLoeschen
            // 
            this.rb_KundeLoeschen.AutoSize = true;
            this.rb_KundeLoeschen.Location = new System.Drawing.Point(289, 19);
            this.rb_KundeLoeschen.Name = "rb_KundeLoeschen";
            this.rb_KundeLoeschen.Size = new System.Drawing.Size(105, 17);
            this.rb_KundeLoeschen.TabIndex = 0;
            this.rb_KundeLoeschen.Text = "Kunde Entfernen";
            this.rb_KundeLoeschen.UseVisualStyleBackColor = true;
            this.rb_KundeLoeschen.CheckedChanged += new System.EventHandler(this.rb_KundeLoeschen_CheckedChanged);
            // 
            // rb_KundeBearbeiten
            // 
            this.rb_KundeBearbeiten.AutoSize = true;
            this.rb_KundeBearbeiten.Location = new System.Drawing.Point(173, 19);
            this.rb_KundeBearbeiten.Name = "rb_KundeBearbeiten";
            this.rb_KundeBearbeiten.Size = new System.Drawing.Size(110, 17);
            this.rb_KundeBearbeiten.TabIndex = 0;
            this.rb_KundeBearbeiten.Text = "Kunde Bearbeiten";
            this.rb_KundeBearbeiten.UseVisualStyleBackColor = true;
            this.rb_KundeBearbeiten.CheckedChanged += new System.EventHandler(this.rb_KundeBearbeiten_CheckedChanged);
            // 
            // rb_Neukunde
            // 
            this.rb_Neukunde.AutoSize = true;
            this.rb_Neukunde.Checked = true;
            this.rb_Neukunde.Location = new System.Drawing.Point(15, 19);
            this.rb_Neukunde.Name = "rb_Neukunde";
            this.rb_Neukunde.Size = new System.Drawing.Size(152, 17);
            this.rb_Neukunde.TabIndex = 0;
            this.rb_Neukunde.TabStop = true;
            this.rb_Neukunde.Text = "Neuen Kunden hinzufügen";
            this.rb_Neukunde.UseVisualStyleBackColor = true;
            this.rb_Neukunde.CheckedChanged += new System.EventHandler(this.rb_Neukunde_CheckedChanged);
            // 
            // bt_save_kunde
            // 
            this.bt_save_kunde.Location = new System.Drawing.Point(156, 311);
            this.bt_save_kunde.Name = "bt_save_kunde";
            this.bt_save_kunde.Size = new System.Drawing.Size(100, 23);
            this.bt_save_kunde.TabIndex = 13;
            this.bt_save_kunde.Text = "Speichern";
            this.bt_save_kunde.UseVisualStyleBackColor = true;
            this.bt_save_kunde.Click += new System.EventHandler(this.Save_Kunde);
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(675, 395);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(97, 23);
            this.bt_OK.TabIndex = 15;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Grid_Kunde);
            this.groupBox1.Location = new System.Drawing.Point(11, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.groupBox1.Size = new System.Drawing.Size(356, 378);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kunden anzeigen";
            // 
            // Grid_Kunde
            // 
            this.Grid_Kunde.AllowUserToAddRows = false;
            this.Grid_Kunde.AllowUserToDeleteRows = false;
            this.Grid_Kunde.AllowUserToResizeColumns = false;
            this.Grid_Kunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.Grid_Kunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Kunde.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Grid_Kunde.Location = new System.Drawing.Point(4, 19);
            this.Grid_Kunde.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Grid_Kunde.MultiSelect = false;
            this.Grid_Kunde.Name = "Grid_Kunde";
            this.Grid_Kunde.ReadOnly = true;
            this.Grid_Kunde.RowTemplate.Height = 24;
            this.Grid_Kunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Kunde.Size = new System.Drawing.Size(348, 353);
            this.Grid_Kunde.TabIndex = 0;
            this.Grid_Kunde.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Kunde_CellDoubleClick);
            // 
            // w_s_Kunden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 430);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.gb_kunde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "w_s_Kunden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kundenverwaltung";
            this.Activated += new System.EventHandler(this.w_s_kunden_Activated);
            this.gb_kunde.ResumeLayout(false);
            this.gb_kunde.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Kunde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_Telefonnummer;
        private System.Windows.Forms.TextBox tb_Telefonnummer;
        private System.Windows.Forms.Label lb_Mail;
        private System.Windows.Forms.TextBox tb_Mail;
        private System.Windows.Forms.TextBox tb_Klasse;
        private System.Windows.Forms.Label lb_Klasse;
        private System.Windows.Forms.ComboBox cb_Vertrauenswuerdigkeit;
        private System.Windows.Forms.Label lb_Vertrauenswuerdigkeit;
        private System.Windows.Forms.TextBox tb_Ort;
        private System.Windows.Forms.Label lb_Ort;
        private System.Windows.Forms.TextBox tb_Postleitzahl;
        private System.Windows.Forms.Label lb_Postleitzahl;
        private System.Windows.Forms.TextBox tb_Hausnummer;
        private System.Windows.Forms.Label lb_Hausnummer;
        private System.Windows.Forms.TextBox tb_Strasse;
        private System.Windows.Forms.Label lb_Strasse;
        private System.Windows.Forms.TextBox tb_Nachname;
        private System.Windows.Forms.Label lb_Nachname;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.Label lb_Vorname;
        private System.Windows.Forms.TextBox tb_KundenID;
        private System.Windows.Forms.GroupBox gb_kunde;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_save_kunde;
        private System.Windows.Forms.RadioButton rb_KundeLoeschen;
        private System.Windows.Forms.RadioButton rb_KundeBearbeiten;
        private System.Windows.Forms.Button bt_clear_kunden;
        private System.Windows.Forms.Label lb_kunde_add;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Grid_Kunde;
        private System.Windows.Forms.RadioButton rb_Neukunde;
    }
}