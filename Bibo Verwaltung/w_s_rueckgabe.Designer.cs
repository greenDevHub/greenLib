namespace Bibo_Verwaltung
{
    partial class w_s_rueckgabe
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Rueckgabe = new System.Windows.Forms.Button();
            this.bt_Zu_aendern = new System.Windows.Forms.Button();
            this.gv_Verlauf = new System.Windows.Forms.DataGridView();
            this.tb_BuchCode = new System.Windows.Forms.TextBox();
            this.lb_BuchCode = new System.Windows.Forms.Label();
            this.gb_Rueck = new System.Windows.Forms.GroupBox();
            this.tb_listBis = new System.Windows.Forms.TextBox();
            this.lb_listVon = new System.Windows.Forms.Label();
            this.tb_listVon = new System.Windows.Forms.TextBox();
            this.rueckList_Slider = new System.Windows.Forms.HScrollBar();
            this.bt_AddBuch = new System.Windows.Forms.Button();
            this.bt_open = new System.Windows.Forms.Button();
            this.picBox_Buchcover = new System.Windows.Forms.PictureBox();
            this.lb_AusleihEnde = new System.Windows.Forms.Label();
            this.lb_AusleihStart = new System.Windows.Forms.Label();
            this.llb_BuchTitel = new System.Windows.Forms.LinkLabel();
            this.lb_BuchTitel = new System.Windows.Forms.Label();
            this.llb_Kunde = new System.Windows.Forms.LinkLabel();
            this.cb_Zustand = new System.Windows.Forms.ComboBox();
            this.lb_Zustand = new System.Windows.Forms.Label();
            this.lb_AusleiheStart = new System.Windows.Forms.Label();
            this.lb_Kunde = new System.Windows.Forms.Label();
            this.lb_AusleiheEnde = new System.Windows.Forms.Label();
            this.lb_Verlauf = new System.Windows.Forms.Label();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlauf)).BeginInit();
            this.gb_Rueck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Rueckgabe
            // 
            this.helpProvider.SetHelpString(this.bt_Rueckgabe, "Klicken sie auf diesen Button um die Buchrückgabe abzuschließen.");
            this.bt_Rueckgabe.Location = new System.Drawing.Point(288, 397);
            this.bt_Rueckgabe.Name = "bt_Rueckgabe";
            this.helpProvider.SetShowHelp(this.bt_Rueckgabe, true);
            this.bt_Rueckgabe.Size = new System.Drawing.Size(175, 23);
            this.bt_Rueckgabe.TabIndex = 9;
            this.bt_Rueckgabe.Text = "Buchrückgabe abschließen";
            this.bt_Rueckgabe.UseVisualStyleBackColor = true;
            this.bt_Rueckgabe.Click += new System.EventHandler(this.bt_Rueckgabe_Click);
            // 
            // bt_Zu_aendern
            // 
            this.bt_Zu_aendern.Enabled = false;
            this.helpProvider.SetHelpString(this.bt_Zu_aendern, "Hier wird der letzte Zustand des ausgeliehen Buches angezeigt. Ändern sie diesen " +
        "wenn sich der Zustand geändert hat.");
            this.bt_Zu_aendern.Location = new System.Drawing.Point(284, 150);
            this.bt_Zu_aendern.Name = "bt_Zu_aendern";
            this.helpProvider.SetShowHelp(this.bt_Zu_aendern, true);
            this.bt_Zu_aendern.Size = new System.Drawing.Size(140, 21);
            this.bt_Zu_aendern.TabIndex = 7;
            this.bt_Zu_aendern.Text = "Buchzustand ändern";
            this.bt_Zu_aendern.UseVisualStyleBackColor = true;
            this.bt_Zu_aendern.Click += new System.EventHandler(this.bt_Zu_aendern_Click);
            // 
            // gv_Verlauf
            // 
            this.gv_Verlauf.AllowUserToAddRows = false;
            this.gv_Verlauf.AllowUserToDeleteRows = false;
            this.gv_Verlauf.AllowUserToResizeColumns = false;
            this.gv_Verlauf.AllowUserToResizeRows = false;
            this.gv_Verlauf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Verlauf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.helpProvider.SetHelpString(this.gv_Verlauf, "Hier wird ihnen angezeigt, welche Kunden das aktuelle Buch früher ausgeliehen hab" +
        "en.");
            this.gv_Verlauf.Location = new System.Drawing.Point(6, 198);
            this.gv_Verlauf.MultiSelect = false;
            this.gv_Verlauf.Name = "gv_Verlauf";
            this.gv_Verlauf.ReadOnly = true;
            this.gv_Verlauf.RowHeadersVisible = false;
            this.gv_Verlauf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Verlauf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Verlauf.ShowEditingIcon = false;
            this.helpProvider.SetShowHelp(this.gv_Verlauf, true);
            this.gv_Verlauf.Size = new System.Drawing.Size(457, 186);
            this.gv_Verlauf.TabIndex = 2;
            this.gv_Verlauf.TabStop = false;
            // 
            // tb_BuchCode
            // 
            this.helpProvider.SetHelpString(this.tb_BuchCode, "Bitte geben sie den Buchlabel-Code ein. Dieser wird bei einem Ausleihvorgang auto" +
        "matisch generiert.");
            this.tb_BuchCode.Location = new System.Drawing.Point(103, 22);
            this.tb_BuchCode.Name = "tb_BuchCode";
            this.helpProvider.SetShowHelp(this.tb_BuchCode, true);
            this.tb_BuchCode.Size = new System.Drawing.Size(148, 20);
            this.tb_BuchCode.TabIndex = 1;
            this.tb_BuchCode.TextChanged += new System.EventHandler(this.tb_BuchCode_TextChanged);
            this.tb_BuchCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_BuchCode_KeyPress);
            // 
            // lb_BuchCode
            // 
            this.lb_BuchCode.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_BuchCode, "Bitte geben sie den Buchlabel-Code ein. Dieser wird bei einem Ausleihvorgang auto" +
        "matisch generiert.");
            this.lb_BuchCode.Location = new System.Drawing.Point(6, 25);
            this.lb_BuchCode.Name = "lb_BuchCode";
            this.helpProvider.SetShowHelp(this.lb_BuchCode, true);
            this.lb_BuchCode.Size = new System.Drawing.Size(85, 13);
            this.lb_BuchCode.TabIndex = 5;
            this.lb_BuchCode.Text = "Buchlabel-Code:";
            // 
            // gb_Rueck
            // 
            this.gb_Rueck.Controls.Add(this.tb_listBis);
            this.gb_Rueck.Controls.Add(this.lb_listVon);
            this.gb_Rueck.Controls.Add(this.tb_listVon);
            this.gb_Rueck.Controls.Add(this.rueckList_Slider);
            this.gb_Rueck.Controls.Add(this.bt_AddBuch);
            this.gb_Rueck.Controls.Add(this.bt_open);
            this.gb_Rueck.Controls.Add(this.picBox_Buchcover);
            this.gb_Rueck.Controls.Add(this.lb_AusleihEnde);
            this.gb_Rueck.Controls.Add(this.bt_Rueckgabe);
            this.gb_Rueck.Controls.Add(this.lb_AusleihStart);
            this.gb_Rueck.Controls.Add(this.llb_BuchTitel);
            this.gb_Rueck.Controls.Add(this.lb_BuchTitel);
            this.gb_Rueck.Controls.Add(this.llb_Kunde);
            this.gb_Rueck.Controls.Add(this.cb_Zustand);
            this.gb_Rueck.Controls.Add(this.lb_Zustand);
            this.gb_Rueck.Controls.Add(this.lb_AusleiheStart);
            this.gb_Rueck.Controls.Add(this.lb_Kunde);
            this.gb_Rueck.Controls.Add(this.lb_AusleiheEnde);
            this.gb_Rueck.Controls.Add(this.lb_Verlauf);
            this.gb_Rueck.Controls.Add(this.tb_BuchCode);
            this.gb_Rueck.Controls.Add(this.bt_Zu_aendern);
            this.gb_Rueck.Controls.Add(this.gv_Verlauf);
            this.gb_Rueck.Controls.Add(this.lb_BuchCode);
            this.gb_Rueck.Location = new System.Drawing.Point(12, 12);
            this.gb_Rueck.Name = "gb_Rueck";
            this.gb_Rueck.Size = new System.Drawing.Size(469, 428);
            this.gb_Rueck.TabIndex = 6;
            this.gb_Rueck.TabStop = false;
            this.gb_Rueck.Text = "Buchrückgabe:";
            // 
            // tb_listBis
            // 
            this.tb_listBis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_listBis.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_listBis.Location = new System.Drawing.Point(243, 399);
            this.tb_listBis.Name = "tb_listBis";
            this.tb_listBis.ReadOnly = true;
            this.tb_listBis.Size = new System.Drawing.Size(25, 20);
            this.tb_listBis.TabIndex = 29;
            this.tb_listBis.TabStop = false;
            this.tb_listBis.Text = "-";
            this.tb_listBis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lb_listVon
            // 
            this.lb_listVon.AutoEllipsis = true;
            this.lb_listVon.Location = new System.Drawing.Point(6, 395);
            this.lb_listVon.Name = "lb_listVon";
            this.lb_listVon.Size = new System.Drawing.Size(83, 26);
            this.lb_listVon.TabIndex = 28;
            this.lb_listVon.Text = "Rückgabeliste -Einträge:";
            this.lb_listVon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_listVon
            // 
            this.tb_listVon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_listVon.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_listVon.Location = new System.Drawing.Point(95, 399);
            this.tb_listVon.Name = "tb_listVon";
            this.tb_listVon.ReadOnly = true;
            this.tb_listVon.Size = new System.Drawing.Size(25, 20);
            this.tb_listVon.TabIndex = 27;
            this.tb_listVon.TabStop = false;
            this.tb_listVon.Text = "-";
            this.tb_listVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rueckList_Slider
            // 
            this.rueckList_Slider.Enabled = false;
            this.helpProvider.SetHelpString(this.rueckList_Slider, "Hier können Sie die sich in der Buchrückgabeliste befindlichen Bücher ansehen.");
            this.rueckList_Slider.LargeChange = 1;
            this.rueckList_Slider.Location = new System.Drawing.Point(123, 399);
            this.rueckList_Slider.Maximum = 0;
            this.rueckList_Slider.Name = "rueckList_Slider";
            this.helpProvider.SetShowHelp(this.rueckList_Slider, true);
            this.rueckList_Slider.Size = new System.Drawing.Size(117, 20);
            this.rueckList_Slider.TabIndex = 8;
            this.rueckList_Slider.TabStop = true;
            this.rueckList_Slider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar);
            // 
            // bt_AddBuch
            // 
            this.bt_AddBuch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_AddBuch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpString(this.bt_AddBuch, "Fügt einen Eintrag zur Buchrückgabeliste hinzu. Ist das Buch bereits in der Liste" +
        " enthalten wird es wieder entfernt.");
            this.bt_AddBuch.Location = new System.Drawing.Point(256, 22);
            this.bt_AddBuch.Margin = new System.Windows.Forms.Padding(2);
            this.bt_AddBuch.Name = "bt_AddBuch";
            this.helpProvider.SetShowHelp(this.bt_AddBuch, true);
            this.bt_AddBuch.Size = new System.Drawing.Size(22, 20);
            this.bt_AddBuch.TabIndex = 2;
            this.bt_AddBuch.Text = "+";
            this.bt_AddBuch.UseVisualStyleBackColor = true;
            this.bt_AddBuch.Click += new System.EventHandler(this.bt_AddBuch_Click);
            // 
            // bt_open
            // 
            this.bt_open.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_open.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider.SetHelpString(this.bt_open, "Hier gelangen Sie zur Zustands-Verwaltung.");
            this.bt_open.Location = new System.Drawing.Point(257, 150);
            this.bt_open.Margin = new System.Windows.Forms.Padding(2);
            this.bt_open.Name = "bt_open";
            this.helpProvider.SetShowHelp(this.bt_open, true);
            this.bt_open.Size = new System.Drawing.Size(22, 21);
            this.bt_open.TabIndex = 6;
            this.bt_open.Text = "*";
            this.bt_open.UseVisualStyleBackColor = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // picBox_Buchcover
            // 
            this.helpProvider.SetHelpString(this.picBox_Buchcover, "Hier sehen sie eine kleine Vorschau des ausgeliehenen Buches.");
            this.picBox_Buchcover.Location = new System.Drawing.Point(284, 22);
            this.picBox_Buchcover.Name = "picBox_Buchcover";
            this.helpProvider.SetShowHelp(this.picBox_Buchcover, true);
            this.picBox_Buchcover.Size = new System.Drawing.Size(140, 116);
            this.picBox_Buchcover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Buchcover.TabIndex = 23;
            this.picBox_Buchcover.TabStop = false;
            // 
            // lb_AusleihEnde
            // 
            this.lb_AusleihEnde.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_AusleihEnde, "Hier wird ihnen das Rückgabedatum angezeigt.");
            this.lb_AusleihEnde.Location = new System.Drawing.Point(100, 125);
            this.lb_AusleihEnde.Name = "lb_AusleihEnde";
            this.helpProvider.SetShowHelp(this.lb_AusleihEnde, true);
            this.lb_AusleihEnde.Size = new System.Drawing.Size(78, 13);
            this.lb_AusleihEnde.TabIndex = 22;
            this.lb_AusleihEnde.Text = "nicht verfügbar";
            // 
            // lb_AusleihStart
            // 
            this.lb_AusleihStart.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_AusleihStart, "Hier wird ihnen angezeigt, wie lange das aktuelle Buch schon ausgeliehen ist.");
            this.lb_AusleihStart.Location = new System.Drawing.Point(100, 100);
            this.lb_AusleihStart.Name = "lb_AusleihStart";
            this.helpProvider.SetShowHelp(this.lb_AusleihStart, true);
            this.lb_AusleihStart.Size = new System.Drawing.Size(78, 13);
            this.lb_AusleihStart.TabIndex = 21;
            this.lb_AusleihStart.Text = "nicht verfügbar";
            // 
            // llb_BuchTitel
            // 
            this.llb_BuchTitel.AutoSize = true;
            this.llb_BuchTitel.Enabled = false;
            this.helpProvider.SetHelpString(this.llb_BuchTitel, "Hier wird ihnen angezeigt, welches Buch ausgeliehen wurde.");
            this.llb_BuchTitel.Location = new System.Drawing.Point(100, 50);
            this.llb_BuchTitel.Name = "llb_BuchTitel";
            this.helpProvider.SetShowHelp(this.llb_BuchTitel, true);
            this.llb_BuchTitel.Size = new System.Drawing.Size(67, 13);
            this.llb_BuchTitel.TabIndex = 3;
            this.llb_BuchTitel.TabStop = true;
            this.llb_BuchTitel.Text = "keine Treffer";
            this.llb_BuchTitel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Buch_LinkClicked);
            // 
            // lb_BuchTitel
            // 
            this.lb_BuchTitel.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_BuchTitel, "Hier wird ihnen angezeigt, welches Buch ausgeliehen wurde.");
            this.lb_BuchTitel.Location = new System.Drawing.Point(6, 50);
            this.lb_BuchTitel.Name = "lb_BuchTitel";
            this.helpProvider.SetShowHelp(this.lb_BuchTitel, true);
            this.lb_BuchTitel.Size = new System.Drawing.Size(83, 13);
            this.lb_BuchTitel.TabIndex = 19;
            this.lb_BuchTitel.Text = "Buch gefunden:";
            // 
            // llb_Kunde
            // 
            this.llb_Kunde.AutoSize = true;
            this.llb_Kunde.Enabled = false;
            this.helpProvider.SetHelpString(this.llb_Kunde, "Hier wird ihnen angezeigt, wer das aktuelle Buch ausgeliehen hat.");
            this.llb_Kunde.Location = new System.Drawing.Point(100, 75);
            this.llb_Kunde.Name = "llb_Kunde";
            this.helpProvider.SetShowHelp(this.llb_Kunde, true);
            this.llb_Kunde.Size = new System.Drawing.Size(76, 13);
            this.llb_Kunde.TabIndex = 4;
            this.llb_Kunde.TabStop = true;
            this.llb_Kunde.Text = "nicht verliehen";
            this.llb_Kunde.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Kunde_LinkClicked);
            // 
            // cb_Zustand
            // 
            this.cb_Zustand.Enabled = false;
            this.cb_Zustand.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Zustand, "Hier wird der letzte Zustand des ausgeliehen Buches angezeigt. Ändern sie diesen " +
        "wenn sich der Zustand geändert hat.");
            this.cb_Zustand.Location = new System.Drawing.Point(103, 150);
            this.cb_Zustand.Name = "cb_Zustand";
            this.helpProvider.SetShowHelp(this.cb_Zustand, true);
            this.cb_Zustand.Size = new System.Drawing.Size(148, 21);
            this.cb_Zustand.TabIndex = 5;
            // 
            // lb_Zustand
            // 
            this.lb_Zustand.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Zustand, "Hier wird der letzte Zustand des ausgeliehen Buches angezeigt. Ändern sie diesen " +
        "wenn sich der Zustand geändert hat.");
            this.lb_Zustand.Location = new System.Drawing.Point(6, 153);
            this.lb_Zustand.Name = "lb_Zustand";
            this.helpProvider.SetShowHelp(this.lb_Zustand, true);
            this.lb_Zustand.Size = new System.Drawing.Size(80, 13);
            this.lb_Zustand.TabIndex = 15;
            this.lb_Zustand.Text = "letzter Zustand:";
            // 
            // lb_AusleiheStart
            // 
            this.lb_AusleiheStart.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_AusleiheStart, "Hier wird ihnen angezeigt, wie lange das aktuelle Buch schon ausgeliehen ist.");
            this.lb_AusleiheStart.Location = new System.Drawing.Point(6, 100);
            this.lb_AusleiheStart.Name = "lb_AusleiheStart";
            this.helpProvider.SetShowHelp(this.lb_AusleiheStart, true);
            this.lb_AusleiheStart.Size = new System.Drawing.Size(86, 13);
            this.lb_AusleiheStart.TabIndex = 10;
            this.lb_AusleiheStart.Text = "ausgeliehen seit:";
            // 
            // lb_Kunde
            // 
            this.lb_Kunde.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Kunde, "Hier wird ihnen angezeigt, wer das aktuelle Buch ausgeliehen hat.");
            this.lb_Kunde.Location = new System.Drawing.Point(6, 75);
            this.lb_Kunde.Name = "lb_Kunde";
            this.helpProvider.SetShowHelp(this.lb_Kunde, true);
            this.lb_Kunde.Size = new System.Drawing.Size(88, 13);
            this.lb_Kunde.TabIndex = 8;
            this.lb_Kunde.Text = "ausgeliehen von:";
            // 
            // lb_AusleiheEnde
            // 
            this.lb_AusleiheEnde.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_AusleiheEnde, "Hier wird ihnen das Rückgabedatum angezeigt.");
            this.lb_AusleiheEnde.Location = new System.Drawing.Point(6, 125);
            this.lb_AusleiheEnde.Name = "lb_AusleiheEnde";
            this.helpProvider.SetShowHelp(this.lb_AusleiheEnde, true);
            this.lb_AusleiheEnde.Size = new System.Drawing.Size(84, 13);
            this.lb_AusleiheEnde.TabIndex = 7;
            this.lb_AusleiheEnde.Text = "Rückgabe fällig:";
            // 
            // lb_Verlauf
            // 
            this.lb_Verlauf.AutoSize = true;
            this.lb_Verlauf.Location = new System.Drawing.Point(6, 182);
            this.lb_Verlauf.Name = "lb_Verlauf";
            this.lb_Verlauf.Size = new System.Drawing.Size(76, 13);
            this.lb_Verlauf.TabIndex = 6;
            this.lb_Verlauf.Text = "Ausleihverlauf:";
            // 
            // w_s_rueckgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 446);
            this.Controls.Add(this.gb_Rueck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_rueckgabe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buchrückgabe";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlauf)).EndInit();
            this.gb_Rueck.ResumeLayout(false);
            this.gb_Rueck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Rueckgabe;
        private System.Windows.Forms.Button bt_Zu_aendern;
        private System.Windows.Forms.DataGridView gv_Verlauf;
        private System.Windows.Forms.TextBox tb_BuchCode;
        private System.Windows.Forms.Label lb_BuchCode;
        private System.Windows.Forms.GroupBox gb_Rueck;
        private System.Windows.Forms.Label lb_AusleiheStart;
        private System.Windows.Forms.Label lb_Kunde;
        private System.Windows.Forms.Label lb_AusleiheEnde;
        private System.Windows.Forms.Label lb_Verlauf;
        private System.Windows.Forms.Label lb_Zustand;
        private System.Windows.Forms.ComboBox cb_Zustand;
        private System.Windows.Forms.LinkLabel llb_Kunde;
        private System.Windows.Forms.LinkLabel llb_BuchTitel;
        private System.Windows.Forms.Label lb_BuchTitel;
        private System.Windows.Forms.Label lb_AusleihEnde;
        private System.Windows.Forms.Label lb_AusleihStart;
        private System.Windows.Forms.PictureBox picBox_Buchcover;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.Button bt_open;
        private System.Windows.Forms.Button bt_AddBuch;
        private System.Windows.Forms.HScrollBar rueckList_Slider;
        private System.Windows.Forms.TextBox tb_listBis;
        private System.Windows.Forms.Label lb_listVon;
        private System.Windows.Forms.TextBox tb_listVon;
    }
}

