﻿namespace Bibo_Verwaltung
{
    partial class w_s_kunden
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
            this.bt_laden_kunden = new System.Windows.Forms.Button();
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
            this.lb_KundenID = new System.Windows.Forms.Label();
            this.gb_kunde = new System.Windows.Forms.GroupBox();
            this.rb_KundeLoeschen = new System.Windows.Forms.RadioButton();
            this.rb_KundeBearbeiten = new System.Windows.Forms.RadioButton();
            this.rb_Neukunde = new System.Windows.Forms.RadioButton();
            this.bt_save_kunde = new System.Windows.Forms.Button();
            this.bt_OK = new System.Windows.Forms.Button();
            this.bt_clear_kunden = new System.Windows.Forms.Button();
            this.gb_kunde.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_laden_kunden
            // 
            this.bt_laden_kunden.Location = new System.Drawing.Point(118, 365);
            this.bt_laden_kunden.Name = "bt_laden_kunden";
            this.bt_laden_kunden.Size = new System.Drawing.Size(102, 31);
            this.bt_laden_kunden.TabIndex = 14;
            this.bt_laden_kunden.Text = "Laden";
            this.bt_laden_kunden.UseVisualStyleBackColor = true;
            this.bt_laden_kunden.Click += new System.EventHandler(this.bt_laden_kunden_Click);
            // 
            // lb_Telefonnummer
            // 
            this.lb_Telefonnummer.AutoSize = true;
            this.lb_Telefonnummer.Location = new System.Drawing.Point(6, 342);
            this.lb_Telefonnummer.Name = "lb_Telefonnummer";
            this.lb_Telefonnummer.Size = new System.Drawing.Size(83, 13);
            this.lb_Telefonnummer.TabIndex = 16;
            this.lb_Telefonnummer.Text = "Telefonnummer:";
            // 
            // tb_Telefonnummer
            // 
            this.tb_Telefonnummer.Location = new System.Drawing.Point(118, 339);
            this.tb_Telefonnummer.Name = "tb_Telefonnummer";
            this.tb_Telefonnummer.Size = new System.Drawing.Size(205, 20);
            this.tb_Telefonnummer.TabIndex = 13;
            this.tb_Telefonnummer.TextChanged += new System.EventHandler(this.tb_Telefonnummer_TextChanged);
            // 
            // lb_Mail
            // 
            this.lb_Mail.AutoSize = true;
            this.lb_Mail.Location = new System.Drawing.Point(6, 316);
            this.lb_Mail.Name = "lb_Mail";
            this.lb_Mail.Size = new System.Drawing.Size(29, 13);
            this.lb_Mail.TabIndex = 37;
            this.lb_Mail.Text = "Mail:";
            // 
            // tb_Mail
            // 
            this.tb_Mail.Location = new System.Drawing.Point(118, 313);
            this.tb_Mail.Name = "tb_Mail";
            this.tb_Mail.Size = new System.Drawing.Size(205, 20);
            this.tb_Mail.TabIndex = 12;
            this.tb_Mail.TextChanged += new System.EventHandler(this.tb_Mail_TextChanged);
            // 
            // tb_Klasse
            // 
            this.tb_Klasse.Location = new System.Drawing.Point(118, 287);
            this.tb_Klasse.Name = "tb_Klasse";
            this.tb_Klasse.Size = new System.Drawing.Size(79, 20);
            this.tb_Klasse.TabIndex = 11;
            this.tb_Klasse.TextChanged += new System.EventHandler(this.tb_Klasse_TextChanged);
            // 
            // lb_Klasse
            // 
            this.lb_Klasse.AutoSize = true;
            this.lb_Klasse.Location = new System.Drawing.Point(6, 290);
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
            this.cb_Vertrauenswuerdigkeit.Location = new System.Drawing.Point(118, 260);
            this.cb_Vertrauenswuerdigkeit.Name = "cb_Vertrauenswuerdigkeit";
            this.cb_Vertrauenswuerdigkeit.Size = new System.Drawing.Size(205, 21);
            this.cb_Vertrauenswuerdigkeit.TabIndex = 10;
            // 
            // lb_Vertrauenswuerdigkeit
            // 
            this.lb_Vertrauenswuerdigkeit.AutoSize = true;
            this.lb_Vertrauenswuerdigkeit.Location = new System.Drawing.Point(6, 263);
            this.lb_Vertrauenswuerdigkeit.Name = "lb_Vertrauenswuerdigkeit";
            this.lb_Vertrauenswuerdigkeit.Size = new System.Drawing.Size(109, 13);
            this.lb_Vertrauenswuerdigkeit.TabIndex = 33;
            this.lb_Vertrauenswuerdigkeit.Text = "Vertrauenswürdigkeit:";
            // 
            // tb_Ort
            // 
            this.tb_Ort.Location = new System.Drawing.Point(118, 234);
            this.tb_Ort.Name = "tb_Ort";
            this.tb_Ort.Size = new System.Drawing.Size(205, 20);
            this.tb_Ort.TabIndex = 9;
            this.tb_Ort.TextChanged += new System.EventHandler(this.tb_Ort_TextChanged);
            // 
            // lb_Ort
            // 
            this.lb_Ort.AutoSize = true;
            this.lb_Ort.Location = new System.Drawing.Point(6, 237);
            this.lb_Ort.Name = "lb_Ort";
            this.lb_Ort.Size = new System.Drawing.Size(51, 13);
            this.lb_Ort.TabIndex = 31;
            this.lb_Ort.Text = "Wohnort:";
            // 
            // tb_Postleitzahl
            // 
            this.tb_Postleitzahl.Location = new System.Drawing.Point(118, 208);
            this.tb_Postleitzahl.Name = "tb_Postleitzahl";
            this.tb_Postleitzahl.Size = new System.Drawing.Size(79, 20);
            this.tb_Postleitzahl.TabIndex = 8;
            this.tb_Postleitzahl.TextChanged += new System.EventHandler(this.tb_Postleitzahl_TextChanged);
            // 
            // lb_Postleitzahl
            // 
            this.lb_Postleitzahl.AutoSize = true;
            this.lb_Postleitzahl.Location = new System.Drawing.Point(6, 211);
            this.lb_Postleitzahl.Name = "lb_Postleitzahl";
            this.lb_Postleitzahl.Size = new System.Drawing.Size(63, 13);
            this.lb_Postleitzahl.TabIndex = 29;
            this.lb_Postleitzahl.Text = "Postleitzahl:";
            // 
            // tb_Hausnummer
            // 
            this.tb_Hausnummer.Location = new System.Drawing.Point(118, 182);
            this.tb_Hausnummer.Name = "tb_Hausnummer";
            this.tb_Hausnummer.Size = new System.Drawing.Size(79, 20);
            this.tb_Hausnummer.TabIndex = 7;
            this.tb_Hausnummer.TextChanged += new System.EventHandler(this.tb_Hausnummer_TextChanged);
            // 
            // lb_Hausnummer
            // 
            this.lb_Hausnummer.AutoSize = true;
            this.lb_Hausnummer.Location = new System.Drawing.Point(6, 185);
            this.lb_Hausnummer.Name = "lb_Hausnummer";
            this.lb_Hausnummer.Size = new System.Drawing.Size(72, 13);
            this.lb_Hausnummer.TabIndex = 27;
            this.lb_Hausnummer.Text = "Hausnummer:";
            // 
            // tb_Strasse
            // 
            this.tb_Strasse.Location = new System.Drawing.Point(118, 156);
            this.tb_Strasse.Name = "tb_Strasse";
            this.tb_Strasse.Size = new System.Drawing.Size(205, 20);
            this.tb_Strasse.TabIndex = 6;
            this.tb_Strasse.TextChanged += new System.EventHandler(this.tb_Strasse_TextChanged);
            // 
            // lb_Strasse
            // 
            this.lb_Strasse.AutoSize = true;
            this.lb_Strasse.Location = new System.Drawing.Point(6, 159);
            this.lb_Strasse.Name = "lb_Strasse";
            this.lb_Strasse.Size = new System.Drawing.Size(45, 13);
            this.lb_Strasse.TabIndex = 7;
            this.lb_Strasse.Text = "Strasse:";
            // 
            // tb_Nachname
            // 
            this.tb_Nachname.Location = new System.Drawing.Point(118, 104);
            this.tb_Nachname.Name = "tb_Nachname";
            this.tb_Nachname.Size = new System.Drawing.Size(205, 20);
            this.tb_Nachname.TabIndex = 4;
            this.tb_Nachname.TextChanged += new System.EventHandler(this.tb_Nachname_TextChanged);
            // 
            // lb_Nachname
            // 
            this.lb_Nachname.AutoSize = true;
            this.lb_Nachname.Location = new System.Drawing.Point(6, 107);
            this.lb_Nachname.Name = "lb_Nachname";
            this.lb_Nachname.Size = new System.Drawing.Size(62, 13);
            this.lb_Nachname.TabIndex = 23;
            this.lb_Nachname.Text = "Nachname:";
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Location = new System.Drawing.Point(118, 78);
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.Size = new System.Drawing.Size(205, 20);
            this.tb_Vorname.TabIndex = 3;
            this.tb_Vorname.TextChanged += new System.EventHandler(this.tb_Vorname_TextChanged);
            // 
            // lb_Vorname
            // 
            this.lb_Vorname.AutoSize = true;
            this.lb_Vorname.Location = new System.Drawing.Point(6, 81);
            this.lb_Vorname.Name = "lb_Vorname";
            this.lb_Vorname.Size = new System.Drawing.Size(52, 13);
            this.lb_Vorname.TabIndex = 21;
            this.lb_Vorname.Text = "Vorname:";
            // 
            // tb_KundenID
            // 
            this.tb_KundenID.Location = new System.Drawing.Point(118, 130);
            this.tb_KundenID.Name = "tb_KundenID";
            this.tb_KundenID.Size = new System.Drawing.Size(205, 20);
            this.tb_KundenID.TabIndex = 5;
            this.tb_KundenID.TextChanged += new System.EventHandler(this.tb_KundenID_TextChanged);
            // 
            // lb_KundenID
            // 
            this.lb_KundenID.AutoSize = true;
            this.lb_KundenID.Location = new System.Drawing.Point(6, 133);
            this.lb_KundenID.Name = "lb_KundenID";
            this.lb_KundenID.Size = new System.Drawing.Size(61, 13);
            this.lb_KundenID.TabIndex = 0;
            this.lb_KundenID.Text = "Kunden-ID:";
            // 
            // gb_kunde
            // 
            this.gb_kunde.Controls.Add(this.rb_KundeLoeschen);
            this.gb_kunde.Controls.Add(this.rb_KundeBearbeiten);
            this.gb_kunde.Controls.Add(this.rb_Neukunde);
            this.gb_kunde.Controls.Add(this.bt_save_kunde);
            this.gb_kunde.Controls.Add(this.bt_laden_kunden);
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
            this.gb_kunde.Controls.Add(this.lb_KundenID);
            this.gb_kunde.Location = new System.Drawing.Point(12, 12);
            this.gb_kunde.Name = "gb_kunde";
            this.gb_kunde.Size = new System.Drawing.Size(419, 429);
            this.gb_kunde.TabIndex = 0;
            this.gb_kunde.TabStop = false;
            this.gb_kunde.Text = "Kunden verwalten";
            // 
            // rb_KundeLoeschen
            // 
            this.rb_KundeLoeschen.AutoSize = true;
            this.rb_KundeLoeschen.Location = new System.Drawing.Point(286, 19);
            this.rb_KundeLoeschen.Name = "rb_KundeLoeschen";
            this.rb_KundeLoeschen.Size = new System.Drawing.Size(105, 17);
            this.rb_KundeLoeschen.TabIndex = 2;
            this.rb_KundeLoeschen.Text = "Kunde Entfernen";
            this.rb_KundeLoeschen.UseVisualStyleBackColor = true;
            this.rb_KundeLoeschen.CheckedChanged += new System.EventHandler(this.rb_KundeLoeschen_CheckedChanged);
            // 
            // rb_KundeBearbeiten
            // 
            this.rb_KundeBearbeiten.AutoSize = true;
            this.rb_KundeBearbeiten.Checked = true;
            this.rb_KundeBearbeiten.Location = new System.Drawing.Point(167, 19);
            this.rb_KundeBearbeiten.Name = "rb_KundeBearbeiten";
            this.rb_KundeBearbeiten.Size = new System.Drawing.Size(110, 17);
            this.rb_KundeBearbeiten.TabIndex = 1;
            this.rb_KundeBearbeiten.TabStop = true;
            this.rb_KundeBearbeiten.Text = "Kunde Bearbeiten";
            this.rb_KundeBearbeiten.UseVisualStyleBackColor = true;
            this.rb_KundeBearbeiten.CheckedChanged += new System.EventHandler(this.rb_KundeBearbeiten_CheckedChanged);
            // 
            // rb_Neukunde
            // 
            this.rb_Neukunde.AutoSize = true;
            this.rb_Neukunde.Location = new System.Drawing.Point(9, 19);
            this.rb_Neukunde.Name = "rb_Neukunde";
            this.rb_Neukunde.Size = new System.Drawing.Size(152, 17);
            this.rb_Neukunde.TabIndex = 0;
            this.rb_Neukunde.Text = "Neuen Kunden hinzufügen";
            this.rb_Neukunde.UseVisualStyleBackColor = true;
            this.rb_Neukunde.CheckedChanged += new System.EventHandler(this.rb_Neukunde_CheckedChanged);
            // 
            // bt_save_kunde
            // 
            this.bt_save_kunde.Location = new System.Drawing.Point(221, 365);
            this.bt_save_kunde.Name = "bt_save_kunde";
            this.bt_save_kunde.Size = new System.Drawing.Size(102, 31);
            this.bt_save_kunde.TabIndex = 15;
            this.bt_save_kunde.Text = "Speichern";
            this.bt_save_kunde.UseVisualStyleBackColor = true;
            this.bt_save_kunde.Click += new System.EventHandler(this.bt_save_kunde_Click);
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(334, 447);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(97, 23);
            this.bt_OK.TabIndex = 2;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // bt_clear_kunden
            // 
            this.bt_clear_kunden.Location = new System.Drawing.Point(21, 447);
            this.bt_clear_kunden.Name = "bt_clear_kunden";
            this.bt_clear_kunden.Size = new System.Drawing.Size(97, 23);
            this.bt_clear_kunden.TabIndex = 1;
            this.bt_clear_kunden.Text = "Clear";
            this.bt_clear_kunden.UseVisualStyleBackColor = true;
            this.bt_clear_kunden.Click += new System.EventHandler(this.bt_clear_kunden_Click);
            // 
            // w_s_kunden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 482);
            this.Controls.Add(this.bt_clear_kunden);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.gb_kunde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "w_s_kunden";
            this.Activated += new System.EventHandler(this.w_s_kunden_Activated);
            this.gb_kunde.ResumeLayout(false);
            this.gb_kunde.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_laden_kunden;
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
        private System.Windows.Forms.Label lb_KundenID;
        private System.Windows.Forms.GroupBox gb_kunde;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Button bt_save_kunde;
        private System.Windows.Forms.RadioButton rb_KundeLoeschen;
        private System.Windows.Forms.RadioButton rb_KundeBearbeiten;
        private System.Windows.Forms.RadioButton rb_Neukunde;
        private System.Windows.Forms.Button bt_clear_kunden;
    }
}