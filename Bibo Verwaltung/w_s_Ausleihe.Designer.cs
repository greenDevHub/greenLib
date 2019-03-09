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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_ausleihe));
            this.dp_RueckDatum = new MetroFramework.Controls.MetroDateTime();
            this.lb_BuchStatus = new MetroFramework.Controls.MetroLabel();
            this.lb_BuchZustand = new MetroFramework.Controls.MetroLabel();
            this.llb_BuchTitel = new MetroFramework.Controls.MetroLink();
            this.bt_AddBuch = new MetroFramework.Controls.MetroButton();
            this.picBox_Buchcover = new System.Windows.Forms.PictureBox();
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dp_RueckDatum
            // 
            this.dp_RueckDatum.CustomFormat = " dd :MMMM: yyyy";
            this.dp_RueckDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_RueckDatum.Location = new System.Drawing.Point(139, 112);
            this.dp_RueckDatum.MinimumSize = new System.Drawing.Size(0, 29);
            this.dp_RueckDatum.Name = "dp_RueckDatum";
            this.dp_RueckDatum.Size = new System.Drawing.Size(210, 29);
            this.dp_RueckDatum.TabIndex = 42;
            // 
            // lb_BuchStatus
            // 
            this.lb_BuchStatus.AutoSize = true;
            this.lb_BuchStatus.Enabled = false;
            this.lb_BuchStatus.Location = new System.Drawing.Point(139, 87);
            this.lb_BuchStatus.Margin = new System.Windows.Forms.Padding(3);
            this.lb_BuchStatus.Name = "lb_BuchStatus";
            this.lb_BuchStatus.Size = new System.Drawing.Size(97, 19);
            this.lb_BuchStatus.TabIndex = 40;
            this.lb_BuchStatus.Text = "nicht verfügbar";
            // 
            // lb_BuchZustand
            // 
            this.lb_BuchZustand.AutoSize = true;
            this.lb_BuchZustand.Enabled = false;
            this.lb_BuchZustand.Location = new System.Drawing.Point(139, 62);
            this.lb_BuchZustand.Margin = new System.Windows.Forms.Padding(3);
            this.lb_BuchZustand.Name = "lb_BuchZustand";
            this.lb_BuchZustand.Size = new System.Drawing.Size(97, 19);
            this.lb_BuchZustand.TabIndex = 38;
            this.lb_BuchZustand.Text = "nicht verfügbar";
            // 
            // llb_BuchTitel
            // 
            this.llb_BuchTitel.AutoSize = true;
            this.llb_BuchTitel.Enabled = false;
            this.llb_BuchTitel.Location = new System.Drawing.Point(139, 33);
            this.llb_BuchTitel.Name = "llb_BuchTitel";
            this.llb_BuchTitel.Size = new System.Drawing.Size(77, 23);
            this.llb_BuchTitel.TabIndex = 36;
            this.llb_BuchTitel.Text = "keine Treffer";
            this.llb_BuchTitel.UseSelectable = true;
            // 
            // bt_AddBuch
            // 
            this.bt_AddBuch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_AddBuch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_AddBuch.Location = new System.Drawing.Point(325, 3);
            this.bt_AddBuch.Name = "bt_AddBuch";
            this.bt_AddBuch.Size = new System.Drawing.Size(24, 24);
            this.bt_AddBuch.TabIndex = 30;
            this.bt_AddBuch.Text = "+";
            this.bt_AddBuch.UseSelectable = true;
            this.bt_AddBuch.Click += new System.EventHandler(this.bt_AddBuch_Click);
            // 
            // picBox_Buchcover
            // 
            this.picBox_Buchcover.Location = new System.Drawing.Point(355, 3);
            this.picBox_Buchcover.Name = "picBox_Buchcover";
            this.picBox_Buchcover.Size = new System.Drawing.Size(211, 168);
            this.picBox_Buchcover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Buchcover.TabIndex = 31;
            this.picBox_Buchcover.TabStop = false;
            // 
            // leihList_Slider
            // 
            this.leihList_Slider.Location = new System.Drawing.Point(166, 147);
            this.leihList_Slider.Name = "leihList_Slider";
            this.leihList_Slider.Size = new System.Drawing.Size(156, 24);
            this.leihList_Slider.TabIndex = 8;
            this.leihList_Slider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.leihList_Slider_Scroll);
            // 
            // tb_listBis
            // 
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
            this.tb_listBis.Location = new System.Drawing.Point(325, 147);
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
            this.tb_listBis.TabIndex = 7;
            this.tb_listBis.Text = "-";
            this.tb_listBis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_listBis.UseSelectable = true;
            this.tb_listBis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_listBis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.tb_listVon.Location = new System.Drawing.Point(139, 147);
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
            this.tb_listVon.TabIndex = 6;
            this.tb_listVon.Text = "-";
            this.tb_listVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_listVon.UseSelectable = true;
            this.tb_listVon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_listVon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_BuchCode
            // 
            // 
            // 
            // 
            this.tb_BuchCode.CustomButton.Image = null;
            this.tb_BuchCode.CustomButton.Location = new System.Drawing.Point(158, 2);
            this.tb_BuchCode.CustomButton.Name = "";
            this.tb_BuchCode.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_BuchCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_BuchCode.CustomButton.TabIndex = 1;
            this.tb_BuchCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_BuchCode.CustomButton.UseSelectable = true;
            this.tb_BuchCode.CustomButton.Visible = false;
            this.tb_BuchCode.Lines = new string[0];
            this.tb_BuchCode.Location = new System.Drawing.Point(139, 3);
            this.tb_BuchCode.MaxLength = 32767;
            this.tb_BuchCode.Name = "tb_BuchCode";
            this.tb_BuchCode.PasswordChar = '\0';
            this.tb_BuchCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_BuchCode.SelectedText = "";
            this.tb_BuchCode.SelectionLength = 0;
            this.tb_BuchCode.SelectionStart = 0;
            this.tb_BuchCode.ShortcutsEnabled = true;
            this.tb_BuchCode.Size = new System.Drawing.Size(180, 24);
            this.tb_BuchCode.TabIndex = 0;
            this.tb_BuchCode.UseSelectable = true;
            this.tb_BuchCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_BuchCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_BuchCode.TextChanged += new System.EventHandler(this.tb_BuchCode_TextChanged);
            this.tb_BuchCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_BuchCode_KeyPress);
            // 
            // lb_RueckDatum
            // 
            this.lb_RueckDatum.AutoSize = true;
            this.lb_RueckDatum.Location = new System.Drawing.Point(3, 112);
            this.lb_RueckDatum.Margin = new System.Windows.Forms.Padding(3);
            this.lb_RueckDatum.Name = "lb_RueckDatum";
            this.lb_RueckDatum.Size = new System.Drawing.Size(107, 19);
            this.lb_RueckDatum.TabIndex = 41;
            this.lb_RueckDatum.Text = "Rückgabedatum:";
            // 
            // lb_Status
            // 
            this.lb_Status.AutoSize = true;
            this.lb_Status.Location = new System.Drawing.Point(3, 87);
            this.lb_Status.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(46, 19);
            this.lb_Status.TabIndex = 39;
            this.lb_Status.Text = "Status:";
            // 
            // lb_BuchTitel
            // 
            this.lb_BuchTitel.AutoSize = true;
            this.lb_BuchTitel.Location = new System.Drawing.Point(3, 33);
            this.lb_BuchTitel.Margin = new System.Windows.Forms.Padding(3);
            this.lb_BuchTitel.Name = "lb_BuchTitel";
            this.lb_BuchTitel.Size = new System.Drawing.Size(99, 19);
            this.lb_BuchTitel.TabIndex = 37;
            this.lb_BuchTitel.Text = "Buch gefunden:";
            // 
            // lb_Zustand
            // 
            this.lb_Zustand.AutoSize = true;
            this.lb_Zustand.Location = new System.Drawing.Point(3, 62);
            this.lb_Zustand.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Zustand.Name = "lb_Zustand";
            this.lb_Zustand.Size = new System.Drawing.Size(58, 19);
            this.lb_Zustand.TabIndex = 33;
            this.lb_Zustand.Text = "Zustand:";
            // 
            // lb_EintragList
            // 
            this.lb_EintragList.Location = new System.Drawing.Point(3, 147);
            this.lb_EintragList.Margin = new System.Windows.Forms.Padding(3);
            this.lb_EintragList.Name = "lb_EintragList";
            this.lb_EintragList.Size = new System.Drawing.Size(83, 26);
            this.lb_EintragList.TabIndex = 29;
            this.lb_EintragList.Text = "Ausleihliste -Einträge:";
            this.lb_EintragList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bt_NeuKunde.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_NeuKunde.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_NeuKunde.Location = new System.Drawing.Point(372, 3);
            this.bt_NeuKunde.Name = "bt_NeuKunde";
            this.bt_NeuKunde.Size = new System.Drawing.Size(194, 24);
            this.bt_NeuKunde.TabIndex = 5;
            this.bt_NeuKunde.Text = "Neuen Kunden hinzufügen";
            this.bt_NeuKunde.UseSelectable = true;
            this.bt_NeuKunde.Click += new System.EventHandler(this.bt_NeuKunde_Click);
            // 
            // gv_Kunde
            // 
            this.gv_Kunde.AllowUserToAddRows = false;
            this.gv_Kunde.AllowUserToDeleteRows = false;
            this.gv_Kunde.AllowUserToResizeColumns = false;
            this.gv_Kunde.AllowUserToResizeRows = false;
            this.gv_Kunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_Kunde.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Kunde.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Kunde.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Kunde.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Kunde.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Kunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Kunde.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
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
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Kunde.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Kunde.RowHeadersVisible = false;
            this.gv_Kunde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Kunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Kunde.ShowEditingIcon = false;
            this.gv_Kunde.Size = new System.Drawing.Size(563, 143);
            this.gv_Kunde.TabIndex = 41;
            // 
            // tb_NName
            // 
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
            this.tb_NName.Lines = new string[] {
        "Nachname"};
            this.tb_NName.Location = new System.Drawing.Point(242, 182);
            this.tb_NName.MaxLength = 32767;
            this.tb_NName.Name = "tb_NName";
            this.tb_NName.PasswordChar = '\0';
            this.tb_NName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_NName.SelectedText = "";
            this.tb_NName.SelectionLength = 0;
            this.tb_NName.SelectionStart = 0;
            this.tb_NName.ShortcutsEnabled = true;
            this.tb_NName.Size = new System.Drawing.Size(152, 24);
            this.tb_NName.TabIndex = 46;
            this.tb_NName.Text = "Nachname";
            this.tb_NName.UseSelectable = true;
            this.tb_NName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_NName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_NName.TextChanged += new System.EventHandler(this.tb_NName_TextChanged);
            this.tb_NName.Enter += new System.EventHandler(this.tb_NName_Enter);
            this.tb_NName.Leave += new System.EventHandler(this.tb_NName_Leave);
            // 
            // tb_VName
            // 
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
            this.tb_VName.Lines = new string[] {
        "Vorname"};
            this.tb_VName.Location = new System.Drawing.Point(86, 182);
            this.tb_VName.MaxLength = 32767;
            this.tb_VName.Name = "tb_VName";
            this.tb_VName.PasswordChar = '\0';
            this.tb_VName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_VName.SelectedText = "";
            this.tb_VName.SelectionLength = 0;
            this.tb_VName.SelectionStart = 0;
            this.tb_VName.ShortcutsEnabled = true;
            this.tb_VName.Size = new System.Drawing.Size(150, 24);
            this.tb_VName.TabIndex = 45;
            this.tb_VName.Text = "Vorname";
            this.tb_VName.UseSelectable = true;
            this.tb_VName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_VName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_VName.TextChanged += new System.EventHandler(this.tb_VName_TextChanged);
            this.tb_VName.Enter += new System.EventHandler(this.tb_VName_Enter);
            this.tb_VName.Leave += new System.EventHandler(this.tb_VName_Leave);
            // 
            // lb_Suche
            // 
            this.lb_Suche.AutoSize = true;
            this.lb_Suche.Location = new System.Drawing.Point(3, 182);
            this.lb_Suche.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Suche.Name = "lb_Suche";
            this.lb_Suche.Size = new System.Drawing.Size(77, 19);
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
            this.bt_Submit.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Submit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_Submit.Location = new System.Drawing.Point(23, 513);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(173, 24);
            this.bt_Submit.TabIndex = 47;
            this.bt_Submit.Text = "Ausleihvorgang abschließen";
            this.bt_Submit.UseSelectable = true;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // bt_Abbrechen
            // 
            this.bt_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Abbrechen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Abbrechen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_Abbrechen.Location = new System.Drawing.Point(492, 513);
            this.bt_Abbrechen.Name = "bt_Abbrechen";
            this.bt_Abbrechen.Size = new System.Drawing.Size(100, 24);
            this.bt_Abbrechen.TabIndex = 48;
            this.bt_Abbrechen.Text = "Abbrechen";
            this.bt_Abbrechen.UseSelectable = true;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.picBox_Buchcover);
            this.metroPanel1.Controls.Add(this.dp_RueckDatum);
            this.metroPanel1.Controls.Add(this.leihList_Slider);
            this.metroPanel1.Controls.Add(this.lb_BuchZustand);
            this.metroPanel1.Controls.Add(this.tb_listBis);
            this.metroPanel1.Controls.Add(this.lb_BuchStatus);
            this.metroPanel1.Controls.Add(this.tb_listVon);
            this.metroPanel1.Controls.Add(this.lb_RueckDatum);
            this.metroPanel1.Controls.Add(this.llb_BuchTitel);
            this.metroPanel1.Controls.Add(this.lb_BuchID);
            this.metroPanel1.Controls.Add(this.bt_AddBuch);
            this.metroPanel1.Controls.Add(this.lb_Status);
            this.metroPanel1.Controls.Add(this.lb_BuchTitel);
            this.metroPanel1.Controls.Add(this.lb_EintragList);
            this.metroPanel1.Controls.Add(this.lb_Zustand);
            this.metroPanel1.Controls.Add(this.tb_BuchCode);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 82);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(569, 176);
            this.metroPanel1.TabIndex = 49;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 60);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(121, 19);
            this.metroLabel1.TabIndex = 50;
            this.metroLabel1.Text = "Exemplar-Ausleihe";
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.tb_NName);
            this.metroPanel2.Controls.Add(this.lb_Suche);
            this.metroPanel2.Controls.Add(this.tb_VName);
            this.metroPanel2.Controls.Add(this.lb_Anweisung);
            this.metroPanel2.Controls.Add(this.bt_NeuKunde);
            this.metroPanel2.Controls.Add(this.gv_Kunde);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 286);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(569, 221);
            this.metroPanel2.TabIndex = 51;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(23, 264);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(149, 19);
            this.metroLabel2.TabIndex = 52;
            this.metroLabel2.Text = "Kunden-Informationen";
            // 
            // w_s_ausleihe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(615, 554);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.bt_Abbrechen);
            this.Controls.Add(this.bt_Submit);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_ausleihe";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buchausleihe";
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Kunde)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
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
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}