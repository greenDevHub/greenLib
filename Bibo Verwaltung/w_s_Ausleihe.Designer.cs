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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_ausleihe));
            this.dp_RueckDatum = new MetroFramework.Controls.MetroDateTime();
            this.lb_BuchStatus = new MetroFramework.Controls.MetroLabel();
            this.lb_BuchZustand = new MetroFramework.Controls.MetroLabel();
            this.llb_BuchTitel = new MetroFramework.Controls.MetroLink();
            this.bt_AddBuch = new MetroFramework.Controls.MetroButton();
            this.leihList_Slider = new System.Windows.Forms.HScrollBar();
            this.tb_listBis = new MetroFramework.Controls.MetroTextBox();
            this.tb_listVon = new MetroFramework.Controls.MetroTextBox();
            this.tb_BuchCode = new MetroFramework.Controls.MetroTextBox();
            this.lb_RueckDatum = new MetroFramework.Controls.MetroLabel();
            this.lb_Status = new MetroFramework.Controls.MetroLabel();
            this.lb_BuchTitel = new MetroFramework.Controls.MetroLabel();
            this.lb_Zustand = new MetroFramework.Controls.MetroLabel();
            this.lb_EintragList = new MetroFramework.Controls.MetroLabel();
            this.lb_BuchID = new MetroFramework.Controls.MetroLabel();
            this.bt_NeuKunde = new MetroFramework.Controls.MetroButton();
            this.gv_Kunde = new MetroFramework.Controls.MetroGrid();
            this.tb_NName = new MetroFramework.Controls.MetroTextBox();
            this.tb_VName = new MetroFramework.Controls.MetroTextBox();
            this.lb_Suche = new MetroFramework.Controls.MetroLabel();
            this.lb_Anweisung = new MetroFramework.Controls.MetroLabel();
            this.bt_Submit = new MetroFramework.Controls.MetroButton();
            this.bt_Abbrechen = new MetroFramework.Controls.MetroButton();
            this.gb_Exemplar = new MetroFramework.Controls.MetroPanel();
            this.llb_gesListe = new MetroFramework.Controls.MetroLink();
            this.picBox_Buchcover = new System.Windows.Forms.PictureBox();
            this.lb_Exemplar = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.lb_Kunden = new MetroFramework.Controls.MetroLabel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.msm_ausleihe = new MetroFramework.Components.MetroStyleManager(this.components);
            this.timer_input = new System.Windows.Forms.Timer(this.components);
            this.spinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.worker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).BeginInit();
            this.gb_Exemplar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msm_ausleihe)).BeginInit();
            this.SuspendLayout();
            // 
            // dp_RueckDatum
            // 
            this.dp_RueckDatum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dp_RueckDatum.CustomFormat = "dd.MM.yyy";
            this.dp_RueckDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_RueckDatum.Location = new System.Drawing.Point(116, 118);
            this.dp_RueckDatum.MinimumSize = new System.Drawing.Size(0, 29);
            this.dp_RueckDatum.Name = "dp_RueckDatum";
            this.dp_RueckDatum.Size = new System.Drawing.Size(164, 29);
            this.dp_RueckDatum.Style = MetroFramework.MetroColorStyle.Green;
            this.dp_RueckDatum.TabIndex = 4;
            this.metroToolTip1.SetToolTip(this.dp_RueckDatum, "Wählen Sie ein Datum aus, an dem das Buch bzw. die Bücher zurückgegeben werden so" +
        "llen.");
            // 
            // lb_BuchStatus
            // 
            this.lb_BuchStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_BuchStatus.Enabled = false;
            this.lb_BuchStatus.Location = new System.Drawing.Point(116, 93);
            this.lb_BuchStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lb_BuchStatus.Name = "lb_BuchStatus";
            this.lb_BuchStatus.Size = new System.Drawing.Size(164, 24);
            this.lb_BuchStatus.TabIndex = 40;
            this.lb_BuchStatus.Text = "nicht verfügbar";
            this.lb_BuchStatus.UseCustomForeColor = true;
            // 
            // lb_BuchZustand
            // 
            this.lb_BuchZustand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_BuchZustand.Enabled = false;
            this.lb_BuchZustand.Location = new System.Drawing.Point(115, 63);
            this.lb_BuchZustand.Margin = new System.Windows.Forms.Padding(3);
            this.lb_BuchZustand.Name = "lb_BuchZustand";
            this.lb_BuchZustand.Size = new System.Drawing.Size(165, 24);
            this.lb_BuchZustand.TabIndex = 38;
            this.lb_BuchZustand.Text = "nicht verfügbar";
            // 
            // llb_BuchTitel
            // 
            this.llb_BuchTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_BuchTitel.AutoSize = true;
            this.llb_BuchTitel.DisplayFocus = true;
            this.llb_BuchTitel.Enabled = false;
            this.llb_BuchTitel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.llb_BuchTitel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llb_BuchTitel.Location = new System.Drawing.Point(115, 33);
            this.llb_BuchTitel.Name = "llb_BuchTitel";
            this.llb_BuchTitel.Size = new System.Drawing.Size(180, 27);
            this.llb_BuchTitel.TabIndex = 3;
            this.llb_BuchTitel.Text = "keine Treffer";
            this.llb_BuchTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llb_BuchTitel.UseSelectable = true;
            this.llb_BuchTitel.Click += new System.EventHandler(this.llb_BuchTitel_Click);
            // 
            // bt_AddBuch
            // 
            this.bt_AddBuch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_AddBuch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_AddBuch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_AddBuch.Location = new System.Drawing.Point(286, 3);
            this.bt_AddBuch.Name = "bt_AddBuch";
            this.bt_AddBuch.Size = new System.Drawing.Size(24, 24);
            this.bt_AddBuch.Style = MetroFramework.MetroColorStyle.Green;
            this.bt_AddBuch.TabIndex = 2;
            this.bt_AddBuch.Text = "+";
            this.metroToolTip1.SetToolTip(this.bt_AddBuch, "Fügt einen Eintrag zur Buchrückgabeliste hinzu. Ist das Buch bereits in der Liste" +
        " enthalten wird es wieder entfernt.");
            this.bt_AddBuch.UseSelectable = true;
            this.bt_AddBuch.Click += new System.EventHandler(this.bt_AddBuch_Click);
            // 
            // leihList_Slider
            // 
            this.leihList_Slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leihList_Slider.Enabled = false;
            this.leihList_Slider.LargeChange = 1;
            this.leihList_Slider.Location = new System.Drawing.Point(143, 153);
            this.leihList_Slider.Maximum = 0;
            this.leihList_Slider.Name = "leihList_Slider";
            this.leihList_Slider.Size = new System.Drawing.Size(110, 24);
            this.leihList_Slider.TabIndex = 5;
            this.leihList_Slider.TabStop = true;
            this.metroToolTip1.SetToolTip(this.leihList_Slider, "Blättern Sie durch die verschiedenen Einträge der Ausleihliste.");
            this.leihList_Slider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.leihList_Slider_Scroll);
            this.leihList_Slider.ValueChanged += new System.EventHandler(this.leihList_Slider_ValueChanged);
            // 
            // tb_listBis
            // 
            this.tb_listBis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_listBis.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            this.tb_listBis.CustomButton.Image = null;
            this.tb_listBis.CustomButton.Location = new System.Drawing.Point(2, 2);
            this.tb_listBis.CustomButton.Name = "";
            this.tb_listBis.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_listBis.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_listBis.CustomButton.TabIndex = 1;
            this.tb_listBis.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_listBis.CustomButton.UseSelectable = true;
            this.tb_listBis.CustomButton.Visible = false;
            this.tb_listBis.Lines = new string[] {
        "-"};
            this.tb_listBis.Location = new System.Drawing.Point(256, 153);
            this.tb_listBis.MaxLength = 32767;
            this.tb_listBis.Name = "tb_listBis";
            this.tb_listBis.PasswordChar = '\0';
            this.tb_listBis.ReadOnly = true;
            this.tb_listBis.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_listBis.SelectedText = "";
            this.tb_listBis.SelectionLength = 0;
            this.tb_listBis.SelectionStart = 0;
            this.tb_listBis.ShortcutsEnabled = true;
            this.tb_listBis.Size = new System.Drawing.Size(24, 24);
            this.tb_listBis.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_listBis.TabIndex = 7;
            this.tb_listBis.TabStop = false;
            this.tb_listBis.Text = "-";
            this.tb_listBis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_listBis.UseSelectable = true;
            this.tb_listBis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_listBis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_listBis.TextChanged += new System.EventHandler(this.Tb_listBis_TextChanged);
            // 
            // tb_listVon
            // 
            this.tb_listVon.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // 
            // 
            this.tb_listVon.CustomButton.Image = null;
            this.tb_listVon.CustomButton.Location = new System.Drawing.Point(2, 2);
            this.tb_listVon.CustomButton.Name = "";
            this.tb_listVon.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_listVon.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_listVon.CustomButton.TabIndex = 1;
            this.tb_listVon.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_listVon.CustomButton.UseSelectable = true;
            this.tb_listVon.CustomButton.Visible = false;
            this.tb_listVon.Lines = new string[] {
        "-"};
            this.tb_listVon.Location = new System.Drawing.Point(116, 153);
            this.tb_listVon.MaxLength = 32767;
            this.tb_listVon.Name = "tb_listVon";
            this.tb_listVon.PasswordChar = '\0';
            this.tb_listVon.ReadOnly = true;
            this.tb_listVon.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_listVon.SelectedText = "";
            this.tb_listVon.SelectionLength = 0;
            this.tb_listVon.SelectionStart = 0;
            this.tb_listVon.ShortcutsEnabled = true;
            this.tb_listVon.Size = new System.Drawing.Size(24, 24);
            this.tb_listVon.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_listVon.TabIndex = 6;
            this.tb_listVon.TabStop = false;
            this.tb_listVon.Text = "-";
            this.tb_listVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_listVon.UseSelectable = true;
            this.tb_listVon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_listVon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_BuchCode
            // 
            this.tb_BuchCode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_BuchCode.CustomButton.Image = null;
            this.tb_BuchCode.CustomButton.Location = new System.Drawing.Point(143, 2);
            this.tb_BuchCode.CustomButton.Name = "";
            this.tb_BuchCode.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_BuchCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_BuchCode.CustomButton.TabIndex = 1;
            this.tb_BuchCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_BuchCode.CustomButton.UseSelectable = true;
            this.tb_BuchCode.CustomButton.Visible = false;
            this.tb_BuchCode.Lines = new string[0];
            this.tb_BuchCode.Location = new System.Drawing.Point(115, 3);
            this.tb_BuchCode.MaxLength = 32767;
            this.tb_BuchCode.Name = "tb_BuchCode";
            this.tb_BuchCode.PasswordChar = '\0';
            this.tb_BuchCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_BuchCode.SelectedText = "";
            this.tb_BuchCode.SelectionLength = 0;
            this.tb_BuchCode.SelectionStart = 0;
            this.tb_BuchCode.ShortcutsEnabled = true;
            this.tb_BuchCode.Size = new System.Drawing.Size(165, 24);
            this.tb_BuchCode.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_BuchCode.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.tb_BuchCode, "Geben Sie den Code des Exemplares ein oder nutzen Sie einen Barcode-Scanner.");
            this.tb_BuchCode.UseSelectable = true;
            this.tb_BuchCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_BuchCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_BuchCode.TextChanged += new System.EventHandler(this.tb_BuchCode_TextChanged);
            this.tb_BuchCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_BuchCode_KeyPress);
            // 
            // lb_RueckDatum
            // 
            this.lb_RueckDatum.Location = new System.Drawing.Point(3, 123);
            this.lb_RueckDatum.Margin = new System.Windows.Forms.Padding(3);
            this.lb_RueckDatum.Name = "lb_RueckDatum";
            this.lb_RueckDatum.Size = new System.Drawing.Size(107, 24);
            this.lb_RueckDatum.TabIndex = 41;
            this.lb_RueckDatum.Text = "Rückgabedatum:";
            // 
            // lb_Status
            // 
            this.lb_Status.Location = new System.Drawing.Point(3, 93);
            this.lb_Status.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(46, 24);
            this.lb_Status.TabIndex = 39;
            this.lb_Status.Text = "Status:";
            // 
            // lb_BuchTitel
            // 
            this.lb_BuchTitel.Location = new System.Drawing.Point(3, 33);
            this.lb_BuchTitel.Margin = new System.Windows.Forms.Padding(3);
            this.lb_BuchTitel.Name = "lb_BuchTitel";
            this.lb_BuchTitel.Size = new System.Drawing.Size(99, 24);
            this.lb_BuchTitel.TabIndex = 37;
            this.lb_BuchTitel.Text = "Buch gefunden:";
            // 
            // lb_Zustand
            // 
            this.lb_Zustand.Location = new System.Drawing.Point(3, 63);
            this.lb_Zustand.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Zustand.Name = "lb_Zustand";
            this.lb_Zustand.Size = new System.Drawing.Size(58, 24);
            this.lb_Zustand.TabIndex = 33;
            this.lb_Zustand.Text = "Zustand:";
            // 
            // lb_EintragList
            // 
            this.lb_EintragList.Location = new System.Drawing.Point(3, 153);
            this.lb_EintragList.Margin = new System.Windows.Forms.Padding(3);
            this.lb_EintragList.Name = "lb_EintragList";
            this.lb_EintragList.Size = new System.Drawing.Size(107, 24);
            this.lb_EintragList.TabIndex = 29;
            this.lb_EintragList.Text = "zeige Eintrag:";
            this.lb_EintragList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_BuchID
            // 
            this.lb_BuchID.AutoSize = true;
            this.lb_BuchID.Location = new System.Drawing.Point(3, 3);
            this.lb_BuchID.Margin = new System.Windows.Forms.Padding(3);
            this.lb_BuchID.Name = "lb_BuchID";
            this.lb_BuchID.Size = new System.Drawing.Size(106, 19);
            this.lb_BuchID.TabIndex = 2;
            this.lb_BuchID.Text = "Buchlable-Code:";
            // 
            // bt_NeuKunde
            // 
            this.bt_NeuKunde.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_NeuKunde.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_NeuKunde.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_NeuKunde.Location = new System.Drawing.Point(316, 3);
            this.bt_NeuKunde.Name = "bt_NeuKunde";
            this.bt_NeuKunde.Size = new System.Drawing.Size(235, 24);
            this.bt_NeuKunde.Style = MetroFramework.MetroColorStyle.Green;
            this.bt_NeuKunde.TabIndex = 8;
            this.bt_NeuKunde.Text = "Neuen Kunden hinzufügen";
            this.metroToolTip1.SetToolTip(this.bt_NeuKunde, "Gelangen Sie zur Kunden-Verwaltung.");
            this.bt_NeuKunde.UseSelectable = true;
            this.bt_NeuKunde.Click += new System.EventHandler(this.bt_NeuKunde_Click);
            // 
            // gv_Kunde
            // 
            this.gv_Kunde.AllowUserToAddRows = false;
            this.gv_Kunde.AllowUserToDeleteRows = false;
            this.gv_Kunde.AllowUserToResizeColumns = false;
            this.gv_Kunde.AllowUserToResizeRows = false;
            this.gv_Kunde.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Kunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_Kunde.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Kunde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Kunde.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Kunde.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Kunde.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Kunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Kunde.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Kunde.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Kunde.EnableHeadersVisualStyles = false;
            this.gv_Kunde.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Kunde.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Kunde.Location = new System.Drawing.Point(3, 33);
            this.gv_Kunde.MultiSelect = false;
            this.gv_Kunde.Name = "gv_Kunde";
            this.gv_Kunde.ReadOnly = true;
            this.gv_Kunde.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Kunde.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Kunde.RowHeadersVisible = false;
            this.gv_Kunde.RowHeadersWidth = 51;
            this.gv_Kunde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Kunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Kunde.ShowEditingIcon = false;
            this.gv_Kunde.Size = new System.Drawing.Size(548, 164);
            this.gv_Kunde.Style = MetroFramework.MetroColorStyle.Green;
            this.gv_Kunde.TabIndex = 9;
            this.metroToolTip1.SetToolTip(this.gv_Kunde, "Wählen Sie einen Kunden aus.");
            this.gv_Kunde.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gv_Kunde_KeyDown);
            // 
            // tb_NName
            // 
            this.tb_NName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.tb_NName.CustomButton.Image = null;
            this.tb_NName.CustomButton.Location = new System.Drawing.Point(130, 2);
            this.tb_NName.CustomButton.Name = "";
            this.tb_NName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_NName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_NName.CustomButton.TabIndex = 1;
            this.tb_NName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_NName.CustomButton.UseSelectable = true;
            this.tb_NName.CustomButton.Visible = false;
            this.tb_NName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_NName.Lines = new string[0];
            this.tb_NName.Location = new System.Drawing.Point(242, 203);
            this.tb_NName.MaxLength = 32767;
            this.tb_NName.Name = "tb_NName";
            this.tb_NName.PasswordChar = '\0';
            this.tb_NName.PromptText = "Nachname";
            this.tb_NName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_NName.SelectedText = "";
            this.tb_NName.SelectionLength = 0;
            this.tb_NName.SelectionStart = 0;
            this.tb_NName.ShortcutsEnabled = true;
            this.tb_NName.Size = new System.Drawing.Size(152, 24);
            this.tb_NName.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_NName.TabIndex = 11;
            this.metroToolTip1.SetToolTip(this.tb_NName, "Suchen Sie einen Kunden nach seinem Nachnamen.");
            this.tb_NName.UseSelectable = true;
            this.tb_NName.WaterMark = "Nachname";
            this.tb_NName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_NName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_NName.TextChanged += new System.EventHandler(this.tb_NName_TextChanged);
            // 
            // tb_VName
            // 
            this.tb_VName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.tb_VName.CustomButton.Image = null;
            this.tb_VName.CustomButton.Location = new System.Drawing.Point(128, 2);
            this.tb_VName.CustomButton.Name = "";
            this.tb_VName.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_VName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_VName.CustomButton.TabIndex = 1;
            this.tb_VName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_VName.CustomButton.UseSelectable = true;
            this.tb_VName.CustomButton.Visible = false;
            this.tb_VName.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_VName.Lines = new string[0];
            this.tb_VName.Location = new System.Drawing.Point(86, 203);
            this.tb_VName.MaxLength = 32767;
            this.tb_VName.Name = "tb_VName";
            this.tb_VName.PasswordChar = '\0';
            this.tb_VName.PromptText = "Vorname";
            this.tb_VName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_VName.SelectedText = "";
            this.tb_VName.SelectionLength = 0;
            this.tb_VName.SelectionStart = 0;
            this.tb_VName.ShortcutsEnabled = true;
            this.tb_VName.Size = new System.Drawing.Size(150, 24);
            this.tb_VName.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_VName.TabIndex = 10;
            this.metroToolTip1.SetToolTip(this.tb_VName, "Suchen Sie einen Kunden nach seinem Vornamen.");
            this.tb_VName.UseSelectable = true;
            this.tb_VName.WaterMark = "Vorname";
            this.tb_VName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_VName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_VName.TextChanged += new System.EventHandler(this.tb_VName_TextChanged);
            // 
            // lb_Suche
            // 
            this.lb_Suche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lb_Suche.Location = new System.Drawing.Point(3, 203);
            this.lb_Suche.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Suche.Name = "lb_Suche";
            this.lb_Suche.Size = new System.Drawing.Size(77, 24);
            this.lb_Suche.TabIndex = 43;
            this.lb_Suche.Text = "Suche nach:";
            // 
            // lb_Anweisung
            // 
            this.lb_Anweisung.AutoSize = true;
            this.lb_Anweisung.Location = new System.Drawing.Point(3, 3);
            this.lb_Anweisung.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Anweisung.Name = "lb_Anweisung";
            this.lb_Anweisung.Size = new System.Drawing.Size(181, 19);
            this.lb_Anweisung.TabIndex = 42;
            this.lb_Anweisung.Text = "Wählen Sie einen Kunden aus:";
            // 
            // bt_Submit
            // 
            this.bt_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Submit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_Submit.Location = new System.Drawing.Point(23, 553);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(175, 24);
            this.bt_Submit.Style = MetroFramework.MetroColorStyle.Green;
            this.bt_Submit.TabIndex = 12;
            this.bt_Submit.Text = "Ausleihvorgang abschließen";
            this.metroToolTip1.SetToolTip(this.bt_Submit, "Schließen Sie den Ausleihvorgang ab.");
            this.bt_Submit.UseSelectable = true;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // bt_Abbrechen
            // 
            this.bt_Abbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Abbrechen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Abbrechen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_Abbrechen.Location = new System.Drawing.Point(402, 553);
            this.bt_Abbrechen.Name = "bt_Abbrechen";
            this.bt_Abbrechen.Size = new System.Drawing.Size(175, 24);
            this.bt_Abbrechen.Style = MetroFramework.MetroColorStyle.Green;
            this.bt_Abbrechen.TabIndex = 13;
            this.bt_Abbrechen.Text = "Schließen";
            this.bt_Abbrechen.UseSelectable = true;
            // 
            // gb_Exemplar
            // 
            this.gb_Exemplar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Exemplar.Controls.Add(this.llb_gesListe);
            this.gb_Exemplar.Controls.Add(this.picBox_Buchcover);
            this.gb_Exemplar.Controls.Add(this.dp_RueckDatum);
            this.gb_Exemplar.Controls.Add(this.leihList_Slider);
            this.gb_Exemplar.Controls.Add(this.lb_BuchZustand);
            this.gb_Exemplar.Controls.Add(this.tb_listBis);
            this.gb_Exemplar.Controls.Add(this.lb_BuchStatus);
            this.gb_Exemplar.Controls.Add(this.tb_listVon);
            this.gb_Exemplar.Controls.Add(this.lb_RueckDatum);
            this.gb_Exemplar.Controls.Add(this.llb_BuchTitel);
            this.gb_Exemplar.Controls.Add(this.lb_BuchID);
            this.gb_Exemplar.Controls.Add(this.bt_AddBuch);
            this.gb_Exemplar.Controls.Add(this.lb_Status);
            this.gb_Exemplar.Controls.Add(this.lb_BuchTitel);
            this.gb_Exemplar.Controls.Add(this.lb_EintragList);
            this.gb_Exemplar.Controls.Add(this.lb_Zustand);
            this.gb_Exemplar.Controls.Add(this.tb_BuchCode);
            this.gb_Exemplar.HorizontalScrollbarBarColor = true;
            this.gb_Exemplar.HorizontalScrollbarHighlightOnWheel = false;
            this.gb_Exemplar.HorizontalScrollbarSize = 10;
            this.gb_Exemplar.Location = new System.Drawing.Point(23, 82);
            this.gb_Exemplar.Name = "gb_Exemplar";
            this.gb_Exemplar.Size = new System.Drawing.Size(554, 207);
            this.gb_Exemplar.TabIndex = 0;
            this.gb_Exemplar.VerticalScrollbarBarColor = true;
            this.gb_Exemplar.VerticalScrollbarHighlightOnWheel = false;
            this.gb_Exemplar.VerticalScrollbarSize = 10;
            // 
            // llb_gesListe
            // 
            this.llb_gesListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_gesListe.DisplayFocus = true;
            this.llb_gesListe.Location = new System.Drawing.Point(116, 180);
            this.llb_gesListe.Name = "llb_gesListe";
            this.llb_gesListe.Size = new System.Drawing.Size(164, 24);
            this.llb_gesListe.TabIndex = 6;
            this.llb_gesListe.Text = "gesamte Ausleihliste anzeigen";
            this.llb_gesListe.UseSelectable = true;
            this.llb_gesListe.Click += new System.EventHandler(this.llb_gesListe_Click);
            // 
            // picBox_Buchcover
            // 
            this.picBox_Buchcover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBox_Buchcover.Location = new System.Drawing.Point(316, 3);
            this.picBox_Buchcover.Name = "picBox_Buchcover";
            this.picBox_Buchcover.Size = new System.Drawing.Size(235, 201);
            this.picBox_Buchcover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Buchcover.TabIndex = 31;
            this.picBox_Buchcover.TabStop = false;
            // 
            // lb_Exemplar
            // 
            this.lb_Exemplar.AutoSize = true;
            this.lb_Exemplar.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_Exemplar.Location = new System.Drawing.Point(23, 60);
            this.lb_Exemplar.Name = "lb_Exemplar";
            this.lb_Exemplar.Size = new System.Drawing.Size(160, 19);
            this.lb_Exemplar.TabIndex = 50;
            this.lb_Exemplar.Text = "Exemplar-Informationen:";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.spinner);
            this.metroPanel2.Controls.Add(this.tb_NName);
            this.metroPanel2.Controls.Add(this.lb_Suche);
            this.metroPanel2.Controls.Add(this.tb_VName);
            this.metroPanel2.Controls.Add(this.lb_Anweisung);
            this.metroPanel2.Controls.Add(this.bt_NeuKunde);
            this.metroPanel2.Controls.Add(this.gv_Kunde);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 317);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(554, 230);
            this.metroPanel2.TabIndex = 7;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // lb_Kunden
            // 
            this.lb_Kunden.AutoSize = true;
            this.lb_Kunden.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_Kunden.Location = new System.Drawing.Point(23, 295);
            this.lb_Kunden.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lb_Kunden.Name = "lb_Kunden";
            this.lb_Kunden.Size = new System.Drawing.Size(152, 19);
            this.lb_Kunden.TabIndex = 52;
            this.lb_Kunden.Text = "Kunden-Informationen:";
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.MetroToolTip1_Popup);
            // 
            // msm_ausleihe
            // 
            this.msm_ausleihe.Owner = this;
            this.msm_ausleihe.Style = MetroFramework.MetroColorStyle.Green;
            // 
            // timer_input
            // 
            this.timer_input.Interval = 1000;
            this.timer_input.Tick += new System.EventHandler(this.timer_input_Tick);
            // 
            // spinner
            // 
            this.spinner.Location = new System.Drawing.Point(183, 33);
            this.spinner.Maximum = 100;
            this.spinner.Name = "spinner";
            this.spinner.Size = new System.Drawing.Size(164, 164);
            this.spinner.TabIndex = 44;
            this.spinner.TabStop = false;
            this.spinner.UseSelectable = true;
            this.spinner.Visible = false;
            // 
            // worker
            // 
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            // 
            // w_s_ausleihe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.bt_Abbrechen;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.lb_Kunden);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.lb_Exemplar);
            this.Controls.Add(this.gb_Exemplar);
            this.Controls.Add(this.bt_Abbrechen);
            this.Controls.Add(this.bt_Submit);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "w_s_ausleihe";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Buchausleihe";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.Shown += new System.EventHandler(this.W_s_ausleihe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).EndInit();
            this.gb_Exemplar.ResumeLayout(false);
            this.gb_Exemplar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msm_ausleihe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.HScrollBar leihList_Slider;
        private MetroFramework.Controls.MetroTextBox tb_listBis;
        private MetroFramework.Controls.MetroTextBox tb_listVon;
        private MetroFramework.Controls.MetroButton bt_NeuKunde;
        private MetroFramework.Controls.MetroLabel lb_BuchID;
        private MetroFramework.Controls.MetroTextBox tb_BuchCode;
        private MetroFramework.Controls.MetroLabel lb_EintragList;
        private MetroFramework.Controls.MetroButton bt_AddBuch;
        private System.Windows.Forms.PictureBox picBox_Buchcover;
        private MetroFramework.Controls.MetroLabel lb_Zustand;
        private MetroFramework.Controls.MetroLabel lb_BuchZustand;
        private MetroFramework.Controls.MetroLink llb_BuchTitel;
        private MetroFramework.Controls.MetroLabel lb_BuchTitel;
        private MetroFramework.Controls.MetroLabel lb_BuchStatus;
        private MetroFramework.Controls.MetroLabel lb_Status;
        private MetroFramework.Controls.MetroGrid gv_Kunde;
        private MetroFramework.Controls.MetroTextBox tb_NName;
        private MetroFramework.Controls.MetroTextBox tb_VName;
        private MetroFramework.Controls.MetroLabel lb_Suche;
        private MetroFramework.Controls.MetroLabel lb_Anweisung;
        private MetroFramework.Controls.MetroButton bt_Submit;
        private MetroFramework.Controls.MetroDateTime dp_RueckDatum;
        private MetroFramework.Controls.MetroLabel lb_RueckDatum;
        private MetroFramework.Controls.MetroButton bt_Abbrechen;
        private MetroFramework.Controls.MetroPanel gb_Exemplar;
        private MetroFramework.Controls.MetroLabel lb_Exemplar;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel lb_Kunden;
        private MetroFramework.Controls.MetroLink llb_gesListe;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Components.MetroStyleManager msm_ausleihe;
        private System.Windows.Forms.Timer timer_input;
        private MetroFramework.Controls.MetroProgressSpinner spinner;
        private System.ComponentModel.BackgroundWorker worker;
    }
}