namespace Bibo_Verwaltung
{
    partial class w_s_ausleihe
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
            this.gb_ExemplarAusleihe = new System.Windows.Forms.GroupBox();
            this.tb_BuchCode = new System.Windows.Forms.TextBox();
            this.lb_BuchID = new System.Windows.Forms.Label();
            this.bt_NeuKunde = new System.Windows.Forms.Button();
            this.tb_listVon = new System.Windows.Forms.TextBox();
            this.tb_listBis = new System.Windows.Forms.TextBox();
            this.leihList_Slider = new System.Windows.Forms.HScrollBar();
            this.lb_EintragList = new System.Windows.Forms.Label();
            this.bt_AddBuch = new System.Windows.Forms.Button();
            this.picBox_Buchcover = new System.Windows.Forms.PictureBox();
            this.lb_Zustand = new System.Windows.Forms.Label();
            this.llb_BuchTitel = new System.Windows.Forms.LinkLabel();
            this.lb_BuchTitel = new System.Windows.Forms.Label();
            this.lb_BuchZustand = new System.Windows.Forms.Label();
            this.lb_BuchStatus = new System.Windows.Forms.Label();
            this.lb_Status = new System.Windows.Forms.Label();
            this.gv_Kunde = new System.Windows.Forms.DataGridView();
            this.gb_Kunde = new System.Windows.Forms.GroupBox();
            this.lb_Anweisung = new System.Windows.Forms.Label();
            this.lb_Suche = new System.Windows.Forms.Label();
            this.tb_VName = new System.Windows.Forms.TextBox();
            this.tb_NName = new System.Windows.Forms.TextBox();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.lb_RueckDatum = new System.Windows.Forms.Label();
            this.dp_RueckDatum = new System.Windows.Forms.DateTimePicker();
            this.bt_Abbrechen = new System.Windows.Forms.Button();
            this.gb_ExemplarAusleihe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).BeginInit();
            this.gb_Kunde.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_ExemplarAusleihe
            // 
            this.gb_ExemplarAusleihe.Controls.Add(this.dp_RueckDatum);
            this.gb_ExemplarAusleihe.Controls.Add(this.lb_RueckDatum);
            this.gb_ExemplarAusleihe.Controls.Add(this.lb_BuchStatus);
            this.gb_ExemplarAusleihe.Controls.Add(this.lb_Status);
            this.gb_ExemplarAusleihe.Controls.Add(this.lb_BuchZustand);
            this.gb_ExemplarAusleihe.Controls.Add(this.llb_BuchTitel);
            this.gb_ExemplarAusleihe.Controls.Add(this.lb_BuchTitel);
            this.gb_ExemplarAusleihe.Controls.Add(this.lb_Zustand);
            this.gb_ExemplarAusleihe.Controls.Add(this.bt_AddBuch);
            this.gb_ExemplarAusleihe.Controls.Add(this.picBox_Buchcover);
            this.gb_ExemplarAusleihe.Controls.Add(this.lb_EintragList);
            this.gb_ExemplarAusleihe.Controls.Add(this.leihList_Slider);
            this.gb_ExemplarAusleihe.Controls.Add(this.tb_listBis);
            this.gb_ExemplarAusleihe.Controls.Add(this.tb_listVon);
            this.gb_ExemplarAusleihe.Controls.Add(this.lb_BuchID);
            this.gb_ExemplarAusleihe.Controls.Add(this.tb_BuchCode);
            this.gb_ExemplarAusleihe.Location = new System.Drawing.Point(12, 12);
            this.gb_ExemplarAusleihe.Name = "gb_ExemplarAusleihe";
            this.gb_ExemplarAusleihe.Size = new System.Drawing.Size(469, 190);
            this.gb_ExemplarAusleihe.TabIndex = 0;
            this.gb_ExemplarAusleihe.TabStop = false;
            this.gb_ExemplarAusleihe.Text = "Exemplar-Ausleihe";
            // 
            // tb_BuchCode
            // 
            this.tb_BuchCode.Location = new System.Drawing.Point(103, 22);
            this.tb_BuchCode.Name = "tb_BuchCode";
            this.tb_BuchCode.Size = new System.Drawing.Size(148, 20);
            this.tb_BuchCode.TabIndex = 0;
            this.tb_BuchCode.TextChanged += new System.EventHandler(this.tb_BuchCode_TextChanged);
            // 
            // lb_BuchID
            // 
            this.lb_BuchID.AutoSize = true;
            this.lb_BuchID.Location = new System.Drawing.Point(12, 24);
            this.lb_BuchID.Name = "lb_BuchID";
            this.lb_BuchID.Size = new System.Drawing.Size(85, 13);
            this.lb_BuchID.TabIndex = 2;
            this.lb_BuchID.Text = "Buchlable-Code:";
            // 
            // bt_NeuKunde
            // 
            this.bt_NeuKunde.Location = new System.Drawing.Point(313, 12);
            this.bt_NeuKunde.Name = "bt_NeuKunde";
            this.bt_NeuKunde.Size = new System.Drawing.Size(150, 23);
            this.bt_NeuKunde.TabIndex = 5;
            this.bt_NeuKunde.Text = "Neuen Kunden hinzufügen";
            this.bt_NeuKunde.UseVisualStyleBackColor = true;
            this.bt_NeuKunde.Click += new System.EventHandler(this.bt_NeuKunde_Click);
            // 
            // tb_listVon
            // 
            this.tb_listVon.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_listVon.Location = new System.Drawing.Point(103, 155);
            this.tb_listVon.Name = "tb_listVon";
            this.tb_listVon.ReadOnly = true;
            this.tb_listVon.Size = new System.Drawing.Size(25, 20);
            this.tb_listVon.TabIndex = 6;
            this.tb_listVon.Text = "-";
            this.tb_listVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_listBis
            // 
            this.tb_listBis.Cursor = System.Windows.Forms.Cursors.Default;
            this.tb_listBis.Location = new System.Drawing.Point(253, 155);
            this.tb_listBis.Name = "tb_listBis";
            this.tb_listBis.ReadOnly = true;
            this.tb_listBis.Size = new System.Drawing.Size(25, 20);
            this.tb_listBis.TabIndex = 7;
            this.tb_listBis.Text = "-";
            this.tb_listBis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // leihList_Slider
            // 
            this.leihList_Slider.LargeChange = 1;
            this.leihList_Slider.Location = new System.Drawing.Point(131, 155);
            this.leihList_Slider.Maximum = 0;
            this.leihList_Slider.Name = "leihList_Slider";
            this.leihList_Slider.Size = new System.Drawing.Size(119, 20);
            this.leihList_Slider.TabIndex = 8;
            this.leihList_Slider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.leihList_Slider_Scroll);
            // 
            // lb_EintragList
            // 
            this.lb_EintragList.AutoEllipsis = true;
            this.lb_EintragList.Location = new System.Drawing.Point(12, 152);
            this.lb_EintragList.Name = "lb_EintragList";
            this.lb_EintragList.Size = new System.Drawing.Size(83, 26);
            this.lb_EintragList.TabIndex = 29;
            this.lb_EintragList.Text = "Ausleihliste -Einträge:";
            this.lb_EintragList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_AddBuch
            // 
            this.bt_AddBuch.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.bt_AddBuch.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_AddBuch.Location = new System.Drawing.Point(256, 22);
            this.bt_AddBuch.Margin = new System.Windows.Forms.Padding(2);
            this.bt_AddBuch.Name = "bt_AddBuch";
            this.bt_AddBuch.Size = new System.Drawing.Size(22, 20);
            this.bt_AddBuch.TabIndex = 30;
            this.bt_AddBuch.Text = "+";
            this.bt_AddBuch.UseVisualStyleBackColor = true;
            this.bt_AddBuch.Click += new System.EventHandler(this.bt_AddBuch_Click);
            // 
            // picBox_Buchcover
            // 
            this.picBox_Buchcover.Location = new System.Drawing.Point(284, 22);
            this.picBox_Buchcover.Name = "picBox_Buchcover";
            this.picBox_Buchcover.Size = new System.Drawing.Size(179, 127);
            this.picBox_Buchcover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Buchcover.TabIndex = 31;
            this.picBox_Buchcover.TabStop = false;
            // 
            // lb_Zustand
            // 
            this.lb_Zustand.AutoSize = true;
            this.lb_Zustand.Location = new System.Drawing.Point(12, 75);
            this.lb_Zustand.Name = "lb_Zustand";
            this.lb_Zustand.Size = new System.Drawing.Size(49, 13);
            this.lb_Zustand.TabIndex = 33;
            this.lb_Zustand.Text = "Zustand:";
            // 
            // llb_BuchTitel
            // 
            this.llb_BuchTitel.AutoSize = true;
            this.llb_BuchTitel.Enabled = false;
            this.llb_BuchTitel.Location = new System.Drawing.Point(100, 50);
            this.llb_BuchTitel.Name = "llb_BuchTitel";
            this.llb_BuchTitel.Size = new System.Drawing.Size(67, 13);
            this.llb_BuchTitel.TabIndex = 36;
            this.llb_BuchTitel.TabStop = true;
            this.llb_BuchTitel.Text = "keine Treffer";
            this.llb_BuchTitel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_BuchTitel_LinkClicked);
            // 
            // lb_BuchTitel
            // 
            this.lb_BuchTitel.AutoSize = true;
            this.lb_BuchTitel.Location = new System.Drawing.Point(12, 50);
            this.lb_BuchTitel.Name = "lb_BuchTitel";
            this.lb_BuchTitel.Size = new System.Drawing.Size(83, 13);
            this.lb_BuchTitel.TabIndex = 37;
            this.lb_BuchTitel.Text = "Buch gefunden:";
            // 
            // lb_BuchZustand
            // 
            this.lb_BuchZustand.AutoSize = true;
            this.lb_BuchZustand.Enabled = false;
            this.lb_BuchZustand.Location = new System.Drawing.Point(100, 75);
            this.lb_BuchZustand.Name = "lb_BuchZustand";
            this.lb_BuchZustand.Size = new System.Drawing.Size(78, 13);
            this.lb_BuchZustand.TabIndex = 38;
            this.lb_BuchZustand.Text = "nicht verfügbar";
            // 
            // lb_BuchStatus
            // 
            this.lb_BuchStatus.AutoSize = true;
            this.lb_BuchStatus.Enabled = false;
            this.lb_BuchStatus.Location = new System.Drawing.Point(100, 100);
            this.lb_BuchStatus.Name = "lb_BuchStatus";
            this.lb_BuchStatus.Size = new System.Drawing.Size(78, 13);
            this.lb_BuchStatus.TabIndex = 40;
            this.lb_BuchStatus.Text = "nicht verfügbar";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(12, 100);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(40, 13);
            this.lb_Status.TabIndex = 39;
            this.lb_Status.Text = "Status:";
            // 
            // gv_Kunde
            // 
            this.gv_Kunde.AllowUserToAddRows = false;
            this.gv_Kunde.AllowUserToDeleteRows = false;
            this.gv_Kunde.AllowUserToResizeColumns = false;
            this.gv_Kunde.AllowUserToResizeRows = false;
            this.gv_Kunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_Kunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Kunde.Cursor = System.Windows.Forms.Cursors.Default;
            this.gv_Kunde.Location = new System.Drawing.Point(6, 38);
            this.gv_Kunde.MultiSelect = false;
            this.gv_Kunde.Name = "gv_Kunde";
            this.gv_Kunde.ReadOnly = true;
            this.gv_Kunde.RowHeadersVisible = false;
            this.gv_Kunde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Kunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Kunde.ShowEditingIcon = false;
            this.gv_Kunde.Size = new System.Drawing.Size(457, 170);
            this.gv_Kunde.TabIndex = 41;
            // 
            // gb_Kunde
            // 
            this.gb_Kunde.Controls.Add(this.tb_NName);
            this.gb_Kunde.Controls.Add(this.tb_VName);
            this.gb_Kunde.Controls.Add(this.lb_Suche);
            this.gb_Kunde.Controls.Add(this.lb_Anweisung);
            this.gb_Kunde.Controls.Add(this.gv_Kunde);
            this.gb_Kunde.Controls.Add(this.bt_NeuKunde);
            this.gb_Kunde.Location = new System.Drawing.Point(12, 208);
            this.gb_Kunde.Name = "gb_Kunde";
            this.gb_Kunde.Size = new System.Drawing.Size(469, 245);
            this.gb_Kunde.TabIndex = 42;
            this.gb_Kunde.TabStop = false;
            this.gb_Kunde.Text = "Kunden-Informationen";
            // 
            // lb_Anweisung
            // 
            this.lb_Anweisung.AutoSize = true;
            this.lb_Anweisung.Location = new System.Drawing.Point(12, 22);
            this.lb_Anweisung.Name = "lb_Anweisung";
            this.lb_Anweisung.Size = new System.Drawing.Size(154, 13);
            this.lb_Anweisung.TabIndex = 42;
            this.lb_Anweisung.Text = "Wählen Sie einen Kunden aus:";
            // 
            // lb_Suche
            // 
            this.lb_Suche.AutoSize = true;
            this.lb_Suche.Location = new System.Drawing.Point(12, 217);
            this.lb_Suche.Name = "lb_Suche";
            this.lb_Suche.Size = new System.Drawing.Size(68, 13);
            this.lb_Suche.TabIndex = 43;
            this.lb_Suche.Text = "Suche nach:";
            // 
            // tb_VName
            // 
            this.tb_VName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_VName.Location = new System.Drawing.Point(86, 214);
            this.tb_VName.Name = "tb_VName";
            this.tb_VName.Size = new System.Drawing.Size(100, 20);
            this.tb_VName.TabIndex = 45;
            this.tb_VName.Text = "Vorname";
            this.tb_VName.TextChanged += new System.EventHandler(this.tb_VName_TextChanged);
            this.tb_VName.Enter += new System.EventHandler(this.tb_VName_Enter);
            this.tb_VName.Leave += new System.EventHandler(this.tb_VName_Leave);
            // 
            // tb_NName
            // 
            this.tb_NName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_NName.Location = new System.Drawing.Point(192, 214);
            this.tb_NName.Name = "tb_NName";
            this.tb_NName.Size = new System.Drawing.Size(100, 20);
            this.tb_NName.TabIndex = 46;
            this.tb_NName.Text = "Nachname";
            this.tb_NName.TextChanged += new System.EventHandler(this.tb_NName_TextChanged);
            this.tb_NName.Enter += new System.EventHandler(this.tb_NName_Enter);
            this.tb_NName.Leave += new System.EventHandler(this.tb_NName_Leave);
            // 
            // bt_Submit
            // 
            this.bt_Submit.Location = new System.Drawing.Point(227, 459);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(150, 23);
            this.bt_Submit.TabIndex = 47;
            this.bt_Submit.Text = "Ausleihvorgang abschließen";
            this.bt_Submit.UseVisualStyleBackColor = true;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // lb_RueckDatum
            // 
            this.lb_RueckDatum.AutoSize = true;
            this.lb_RueckDatum.Location = new System.Drawing.Point(12, 125);
            this.lb_RueckDatum.Name = "lb_RueckDatum";
            this.lb_RueckDatum.Size = new System.Drawing.Size(89, 13);
            this.lb_RueckDatum.TabIndex = 41;
            this.lb_RueckDatum.Text = "Rückgabedatum:";
            // 
            // dp_RueckDatum
            // 
            this.dp_RueckDatum.CustomFormat = " dd :MMMM: yyyy";
            this.dp_RueckDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_RueckDatum.Location = new System.Drawing.Point(103, 122);
            this.dp_RueckDatum.Name = "dp_RueckDatum";
            this.dp_RueckDatum.Size = new System.Drawing.Size(148, 20);
            this.dp_RueckDatum.TabIndex = 42;
            // 
            // bt_Abbrechen
            // 
            this.bt_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Abbrechen.Location = new System.Drawing.Point(383, 459);
            this.bt_Abbrechen.Name = "bt_Abbrechen";
            this.bt_Abbrechen.Size = new System.Drawing.Size(100, 23);
            this.bt_Abbrechen.TabIndex = 48;
            this.bt_Abbrechen.Text = "Abbrechen";
            this.bt_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // w_s_ausleihe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 491);
            this.Controls.Add(this.bt_Abbrechen);
            this.Controls.Add(this.bt_Submit);
            this.Controls.Add(this.gb_Kunde);
            this.Controls.Add(this.gb_ExemplarAusleihe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_ausleihe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buchausleihe";
            this.gb_ExemplarAusleihe.ResumeLayout(false);
            this.gb_ExemplarAusleihe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).EndInit();
            this.gb_Kunde.ResumeLayout(false);
            this.gb_Kunde.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_ExemplarAusleihe;
        private System.Windows.Forms.HScrollBar leihList_Slider;
        private System.Windows.Forms.TextBox tb_listBis;
        private System.Windows.Forms.TextBox tb_listVon;
        private System.Windows.Forms.Button bt_NeuKunde;
        private System.Windows.Forms.Label lb_BuchID;
        private System.Windows.Forms.TextBox tb_BuchCode;
        private System.Windows.Forms.Label lb_EintragList;
        private System.Windows.Forms.Button bt_AddBuch;
        private System.Windows.Forms.PictureBox picBox_Buchcover;
        private System.Windows.Forms.Label lb_Zustand;
        private System.Windows.Forms.Label lb_BuchZustand;
        private System.Windows.Forms.LinkLabel llb_BuchTitel;
        private System.Windows.Forms.Label lb_BuchTitel;
        private System.Windows.Forms.Label lb_BuchStatus;
        private System.Windows.Forms.Label lb_Status;
        private System.Windows.Forms.DataGridView gv_Kunde;
        private System.Windows.Forms.GroupBox gb_Kunde;
        private System.Windows.Forms.TextBox tb_NName;
        private System.Windows.Forms.TextBox tb_VName;
        private System.Windows.Forms.Label lb_Suche;
        private System.Windows.Forms.Label lb_Anweisung;
        private System.Windows.Forms.Button bt_Submit;
        private System.Windows.Forms.DateTimePicker dp_RueckDatum;
        private System.Windows.Forms.Label lb_RueckDatum;
        private System.Windows.Forms.Button bt_Abbrechen;
    }
}