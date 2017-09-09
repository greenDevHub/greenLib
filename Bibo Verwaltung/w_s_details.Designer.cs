﻿namespace Bibo_Verwaltung
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
            this.tb_KID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Kunde = new System.Windows.Forms.Label();
            this.tb_Kunde = new System.Windows.Forms.TextBox();
            this.lb_Rück = new System.Windows.Forms.Label();
            this.lb_Buch = new System.Windows.Forms.Label();
            this.tb_Titel = new System.Windows.Forms.TextBox();
            this.tb_BuchID = new System.Windows.Forms.TextBox();
            this.bt_Ausleihen = new System.Windows.Forms.Button();
            this.gb_Suchen = new System.Windows.Forms.GroupBox();
            this.bt_Suchen = new System.Windows.Forms.Button();
            this.cb_s_Autor = new System.Windows.Forms.CheckBox();
            this.cb_s_Genre = new System.Windows.Forms.CheckBox();
            this.cb_s_Verlag = new System.Windows.Forms.CheckBox();
            this.cb_s_Titel = new System.Windows.Forms.CheckBox();
            this.tb_s_Verlag = new System.Windows.Forms.TextBox();
            this.tb_s_Autor = new System.Windows.Forms.TextBox();
            this.tb_s_Genre = new System.Windows.Forms.TextBox();
            this.tb_s_Titel = new System.Windows.Forms.TextBox();
            this.bt_Rueckgabe = new System.Windows.Forms.Button();
            this.bt_Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Details)).BeginInit();
            this.cb_Ausleihen.SuspendLayout();
            this.gb_Suchen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_Details
            // 
            this.gv_Details.AllowUserToAddRows = false;
            this.gv_Details.AllowUserToDeleteRows = false;
            this.gv_Details.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gv_Details.Location = new System.Drawing.Point(12, 100);
            this.gv_Details.MultiSelect = false;
            this.gv_Details.Name = "gv_Details";
            this.gv_Details.ReadOnly = true;
            this.gv_Details.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Details.ShowEditingIcon = false;
            this.gv_Details.Size = new System.Drawing.Size(1035, 262);
            this.gv_Details.TabIndex = 0;
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
            this.dateTimePickerAusleihen.Location = new System.Drawing.Point(101, 74);
            this.dateTimePickerAusleihen.Name = "dateTimePickerAusleihen";
            this.dateTimePickerAusleihen.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAusleihen.TabIndex = 3;
            // 
            // cb_Ausleihen
            // 
            this.cb_Ausleihen.Controls.Add(this.tb_KID);
            this.cb_Ausleihen.Controls.Add(this.button1);
            this.cb_Ausleihen.Controls.Add(this.lb_Kunde);
            this.cb_Ausleihen.Controls.Add(this.tb_Kunde);
            this.cb_Ausleihen.Controls.Add(this.lb_Rück);
            this.cb_Ausleihen.Controls.Add(this.lb_Buch);
            this.cb_Ausleihen.Controls.Add(this.tb_Titel);
            this.cb_Ausleihen.Controls.Add(this.tb_BuchID);
            this.cb_Ausleihen.Controls.Add(this.dateTimePickerAusleihen);
            this.cb_Ausleihen.Location = new System.Drawing.Point(12, 407);
            this.cb_Ausleihen.Name = "cb_Ausleihen";
            this.cb_Ausleihen.Size = new System.Drawing.Size(703, 166);
            this.cb_Ausleihen.TabIndex = 5;
            this.cb_Ausleihen.TabStop = false;
            this.cb_Ausleihen.Text = "Buch ausleihen:";
            // 
            // tb_KID
            // 
            this.tb_KID.Enabled = false;
            this.tb_KID.Location = new System.Drawing.Point(307, 48);
            this.tb_KID.Name = "tb_KID";
            this.tb_KID.ReadOnly = true;
            this.tb_KID.Size = new System.Drawing.Size(24, 20);
            this.tb_KID.TabIndex = 12;
            this.tb_KID.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(206, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ausleihen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ausleihen);
            // 
            // lb_Kunde
            // 
            this.lb_Kunde.AutoSize = true;
            this.lb_Kunde.Location = new System.Drawing.Point(6, 51);
            this.lb_Kunde.Name = "lb_Kunde";
            this.lb_Kunde.Size = new System.Drawing.Size(41, 13);
            this.lb_Kunde.TabIndex = 10;
            this.lb_Kunde.Text = "Kunde:";
            // 
            // tb_Kunde
            // 
            this.tb_Kunde.Location = new System.Drawing.Point(101, 48);
            this.tb_Kunde.Name = "tb_Kunde";
            this.tb_Kunde.ReadOnly = true;
            this.tb_Kunde.Size = new System.Drawing.Size(200, 20);
            this.tb_Kunde.TabIndex = 9;
            // 
            // lb_Rück
            // 
            this.lb_Rück.AutoSize = true;
            this.lb_Rück.Location = new System.Drawing.Point(6, 80);
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
            // tb_Titel
            // 
            this.tb_Titel.Location = new System.Drawing.Point(101, 22);
            this.tb_Titel.Name = "tb_Titel";
            this.tb_Titel.ReadOnly = true;
            this.tb_Titel.Size = new System.Drawing.Size(200, 20);
            this.tb_Titel.TabIndex = 6;
            // 
            // tb_BuchID
            // 
            this.tb_BuchID.Enabled = false;
            this.tb_BuchID.Location = new System.Drawing.Point(307, 22);
            this.tb_BuchID.Name = "tb_BuchID";
            this.tb_BuchID.ReadOnly = true;
            this.tb_BuchID.Size = new System.Drawing.Size(24, 20);
            this.tb_BuchID.TabIndex = 4;
            this.tb_BuchID.Visible = false;
            // 
            // bt_Ausleihen
            // 
            this.bt_Ausleihen.Location = new System.Drawing.Point(12, 368);
            this.bt_Ausleihen.Name = "bt_Ausleihen";
            this.bt_Ausleihen.Size = new System.Drawing.Size(125, 23);
            this.bt_Ausleihen.TabIndex = 11;
            this.bt_Ausleihen.Text = "Ausleihvorgang starten";
            this.bt_Ausleihen.UseVisualStyleBackColor = true;
            this.bt_Ausleihen.Click += new System.EventHandler(this.ausleihvorgang);
            // 
            // gb_Suchen
            // 
            this.gb_Suchen.Controls.Add(this.bt_Clear);
            this.gb_Suchen.Controls.Add(this.bt_Suchen);
            this.gb_Suchen.Controls.Add(this.cb_s_Autor);
            this.gb_Suchen.Controls.Add(this.cb_s_Genre);
            this.gb_Suchen.Controls.Add(this.cb_s_Verlag);
            this.gb_Suchen.Controls.Add(this.cb_s_Titel);
            this.gb_Suchen.Controls.Add(this.tb_s_Verlag);
            this.gb_Suchen.Controls.Add(this.tb_s_Autor);
            this.gb_Suchen.Controls.Add(this.tb_s_Genre);
            this.gb_Suchen.Controls.Add(this.tb_s_Titel);
            this.gb_Suchen.Location = new System.Drawing.Point(12, 12);
            this.gb_Suchen.Name = "gb_Suchen";
            this.gb_Suchen.Size = new System.Drawing.Size(1035, 82);
            this.gb_Suchen.TabIndex = 13;
            this.gb_Suchen.TabStop = false;
            this.gb_Suchen.Text = "Suchen nach:";
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Location = new System.Drawing.Point(921, 45);
            this.bt_Suchen.Name = "bt_Suchen";
            this.bt_Suchen.Size = new System.Drawing.Size(100, 23);
            this.bt_Suchen.TabIndex = 25;
            this.bt_Suchen.Text = "Suchen";
            this.bt_Suchen.UseVisualStyleBackColor = true;
            this.bt_Suchen.Click += new System.EventHandler(this.bt_Suchen_Click);
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
            // tb_s_Verlag
            // 
            this.tb_s_Verlag.Enabled = false;
            this.tb_s_Verlag.Location = new System.Drawing.Point(841, 19);
            this.tb_s_Verlag.Name = "tb_s_Verlag";
            this.tb_s_Verlag.Size = new System.Drawing.Size(180, 20);
            this.tb_s_Verlag.TabIndex = 20;
            // 
            // tb_s_Autor
            // 
            this.tb_s_Autor.Enabled = false;
            this.tb_s_Autor.Location = new System.Drawing.Point(320, 19);
            this.tb_s_Autor.Name = "tb_s_Autor";
            this.tb_s_Autor.Size = new System.Drawing.Size(180, 20);
            this.tb_s_Autor.TabIndex = 19;
            // 
            // tb_s_Genre
            // 
            this.tb_s_Genre.Enabled = false;
            this.tb_s_Genre.Location = new System.Drawing.Point(580, 19);
            this.tb_s_Genre.Name = "tb_s_Genre";
            this.tb_s_Genre.Size = new System.Drawing.Size(180, 20);
            this.tb_s_Genre.TabIndex = 18;
            // 
            // tb_s_Titel
            // 
            this.tb_s_Titel.Enabled = false;
            this.tb_s_Titel.Location = new System.Drawing.Point(64, 19);
            this.tb_s_Titel.Name = "tb_s_Titel";
            this.tb_s_Titel.Size = new System.Drawing.Size(180, 20);
            this.tb_s_Titel.TabIndex = 17;
            // 
            // bt_Rueckgabe
            // 
            this.bt_Rueckgabe.Location = new System.Drawing.Point(143, 368);
            this.bt_Rueckgabe.Name = "bt_Rueckgabe";
            this.bt_Rueckgabe.Size = new System.Drawing.Size(113, 23);
            this.bt_Rueckgabe.TabIndex = 14;
            this.bt_Rueckgabe.Text = "Buchrückgabe";
            this.bt_Rueckgabe.UseVisualStyleBackColor = true;
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(841, 45);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(74, 23);
            this.bt_Clear.TabIndex = 26;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
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
        private System.Windows.Forms.TextBox tb_Titel;
        private System.Windows.Forms.TextBox tb_BuchID;
        private System.Windows.Forms.Label lb_Kunde;
        private System.Windows.Forms.TextBox tb_Kunde;
        private System.Windows.Forms.Label lb_Rück;
        private System.Windows.Forms.Button bt_Ausleihen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gb_Suchen;
        private System.Windows.Forms.Button bt_Suchen;
        private System.Windows.Forms.CheckBox cb_s_Autor;
        private System.Windows.Forms.CheckBox cb_s_Genre;
        private System.Windows.Forms.CheckBox cb_s_Verlag;
        private System.Windows.Forms.CheckBox cb_s_Titel;
        private System.Windows.Forms.TextBox tb_s_Verlag;
        private System.Windows.Forms.TextBox tb_s_Autor;
        private System.Windows.Forms.TextBox tb_s_Genre;
        private System.Windows.Forms.TextBox tb_s_Titel;
        private System.Windows.Forms.TextBox tb_KID;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Rueckgabe;
    }
}