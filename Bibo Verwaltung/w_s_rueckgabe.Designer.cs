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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_rueckgabe));
            this.bt_Rueckgabe = new MetroFramework.Controls.MetroButton();
            this.bt_Zu_aendern = new MetroFramework.Controls.MetroButton();
            this.gv_Verlauf = new MetroFramework.Controls.MetroGrid();
            this.tb_BuchCode = new MetroFramework.Controls.MetroTextBox();
            this.lb_BuchCode = new MetroFramework.Controls.MetroLabel();
            this.bt_AddBuch = new MetroFramework.Controls.MetroButton();
            this.bt_open = new MetroFramework.Controls.MetroButton();
            this.picBox_Buchcover = new System.Windows.Forms.PictureBox();
            this.lb_AusleihEnde = new MetroFramework.Controls.MetroLabel();
            this.lb_AusleihStart = new MetroFramework.Controls.MetroLabel();
            this.llb_BuchTitel = new MetroFramework.Controls.MetroLink();
            this.lb_BuchTitel = new MetroFramework.Controls.MetroLabel();
            this.llb_Kunde = new MetroFramework.Controls.MetroLink();
            this.lb_Zustand = new MetroFramework.Controls.MetroLabel();
            this.lb_AusleiheStart = new MetroFramework.Controls.MetroLabel();
            this.lb_Kunde = new MetroFramework.Controls.MetroLabel();
            this.lb_AusleiheEnde = new MetroFramework.Controls.MetroLabel();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.llb_gesListe = new MetroFramework.Controls.MetroLink();
            this.rueckList_Slider = new System.Windows.Forms.HScrollBar();
            this.tb_listBis = new MetroFramework.Controls.MetroTextBox();
            this.tb_listVon = new MetroFramework.Controls.MetroTextBox();
            this.lb_EintragList = new MetroFramework.Controls.MetroLabel();
            this.lb_Exemplar = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bt_Abbrechen = new MetroFramework.Controls.MetroButton();
            this.cb_Zustand = new Bibo_Verwaltung.AdvancedComboBox();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlauf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Rueckgabe
            // 
            this.bt_Rueckgabe.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Rueckgabe.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Rueckgabe.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Rueckgabe, "Klicken sie auf diesen Button um die Buchrückgabe abzuschließen.");
            this.bt_Rueckgabe.Location = new System.Drawing.Point(23, 553);
            this.bt_Rueckgabe.Name = "bt_Rueckgabe";
            this.helpProvider.SetShowHelp(this.bt_Rueckgabe, true);
            this.bt_Rueckgabe.Size = new System.Drawing.Size(175, 24);
            this.bt_Rueckgabe.Style = MetroFramework.MetroColorStyle.Green;
            this.bt_Rueckgabe.TabIndex = 9;
            this.bt_Rueckgabe.Text = "Buchrückgabe abschließen";
            this.bt_Rueckgabe.UseSelectable = true;
            this.bt_Rueckgabe.Click += new System.EventHandler(this.bt_Rueckgabe_Click);
            // 
            // bt_Zu_aendern
            // 
            this.bt_Zu_aendern.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Zu_aendern.Enabled = false;
            this.bt_Zu_aendern.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Zu_aendern.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Zu_aendern, "Hier wird der letzte Zustand des ausgeliehen Buches angezeigt. Ändern sie diesen " +
        "wenn sich der Zustand geändert hat.");
            this.bt_Zu_aendern.Location = new System.Drawing.Point(317, 213);
            this.bt_Zu_aendern.Name = "bt_Zu_aendern";
            this.helpProvider.SetShowHelp(this.bt_Zu_aendern, true);
            this.bt_Zu_aendern.Size = new System.Drawing.Size(234, 24);
            this.bt_Zu_aendern.Style = MetroFramework.MetroColorStyle.Green;
            this.bt_Zu_aendern.TabIndex = 7;
            this.bt_Zu_aendern.Text = "Buchzustand ändern";
            this.bt_Zu_aendern.UseSelectable = true;
            this.bt_Zu_aendern.Click += new System.EventHandler(this.bt_Zu_aendern_Click);
            // 
            // gv_Verlauf
            // 
            this.gv_Verlauf.AllowUserToAddRows = false;
            this.gv_Verlauf.AllowUserToDeleteRows = false;
            this.gv_Verlauf.AllowUserToResizeColumns = false;
            this.gv_Verlauf.AllowUserToResizeRows = false;
            this.gv_Verlauf.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Verlauf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Verlauf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Verlauf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Verlauf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Verlauf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Verlauf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Verlauf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Verlauf.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Verlauf.EnableHeadersVisualStyles = false;
            this.gv_Verlauf.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Verlauf.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.gv_Verlauf, "Hier wird ihnen angezeigt, welche Kunden das aktuelle Buch früher ausgeliehen hab" +
        "en.");
            this.gv_Verlauf.Location = new System.Drawing.Point(3, 3);
            this.gv_Verlauf.MultiSelect = false;
            this.gv_Verlauf.Name = "gv_Verlauf";
            this.gv_Verlauf.ReadOnly = true;
            this.gv_Verlauf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(177)))), ((int)(((byte)(89)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(208)))), ((int)(((byte)(104)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Verlauf.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Verlauf.RowHeadersVisible = false;
            this.gv_Verlauf.RowHeadersWidth = 51;
            this.gv_Verlauf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Verlauf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Verlauf.ShowEditingIcon = false;
            this.helpProvider.SetShowHelp(this.gv_Verlauf, true);
            this.gv_Verlauf.Size = new System.Drawing.Size(548, 192);
            this.gv_Verlauf.Style = MetroFramework.MetroColorStyle.Green;
            this.gv_Verlauf.TabIndex = 2;
            this.gv_Verlauf.TabStop = false;
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
            this.helpProvider.SetHelpString(this.tb_BuchCode, "Bitte geben sie den Buchlabel-Code ein. Dieser wird bei einem Ausleihvorgang auto" +
        "matisch generiert.");
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
            this.helpProvider.SetShowHelp(this.tb_BuchCode, true);
            this.tb_BuchCode.Size = new System.Drawing.Size(165, 24);
            this.tb_BuchCode.Style = MetroFramework.MetroColorStyle.Green;
            this.tb_BuchCode.TabIndex = 1;
            this.tb_BuchCode.UseSelectable = true;
            this.tb_BuchCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_BuchCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_BuchCode.TextChanged += new System.EventHandler(this.tb_BuchCode_TextChanged);
            this.tb_BuchCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_BuchCode_KeyPress);
            // 
            // lb_BuchCode
            // 
            this.helpProvider.SetHelpString(this.lb_BuchCode, "Bitte geben sie den Buchlabel-Code ein. Dieser wird bei einem Ausleihvorgang auto" +
        "matisch generiert.");
            this.lb_BuchCode.Location = new System.Drawing.Point(3, 3);
            this.lb_BuchCode.Margin = new System.Windows.Forms.Padding(3);
            this.lb_BuchCode.Name = "lb_BuchCode";
            this.helpProvider.SetShowHelp(this.lb_BuchCode, true);
            this.lb_BuchCode.Size = new System.Drawing.Size(106, 24);
            this.lb_BuchCode.TabIndex = 5;
            this.lb_BuchCode.Text = "Buchlabel-Code:";
            this.lb_BuchCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_AddBuch
            // 
            this.bt_AddBuch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_AddBuch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_AddBuch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_AddBuch, "Fügt einen Eintrag zur Buchrückgabeliste hinzu. Ist das Buch bereits in der Liste" +
        " enthalten wird es wieder entfernt.");
            this.bt_AddBuch.Location = new System.Drawing.Point(286, 3);
            this.bt_AddBuch.Name = "bt_AddBuch";
            this.helpProvider.SetShowHelp(this.bt_AddBuch, true);
            this.bt_AddBuch.Size = new System.Drawing.Size(24, 24);
            this.bt_AddBuch.Style = MetroFramework.MetroColorStyle.Green;
            this.bt_AddBuch.TabIndex = 2;
            this.bt_AddBuch.Text = "+";
            this.bt_AddBuch.UseSelectable = true;
            this.bt_AddBuch.Click += new System.EventHandler(this.bt_AddBuch_Click);
            // 
            // bt_open
            // 
            this.bt_open.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_open.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_open.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_open, "Hier gelangen Sie zur Zustands-Verwaltung.");
            this.bt_open.Location = new System.Drawing.Point(286, 153);
            this.bt_open.Name = "bt_open";
            this.helpProvider.SetShowHelp(this.bt_open, true);
            this.bt_open.Size = new System.Drawing.Size(24, 24);
            this.bt_open.Style = MetroFramework.MetroColorStyle.Green;
            this.bt_open.TabIndex = 6;
            this.bt_open.Text = "*";
            this.bt_open.UseSelectable = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // picBox_Buchcover
            // 
            this.picBox_Buchcover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.picBox_Buchcover, "Hier sehen sie eine kleine Vorschau des ausgeliehenen Buches.");
            this.picBox_Buchcover.Location = new System.Drawing.Point(316, 3);
            this.picBox_Buchcover.Name = "picBox_Buchcover";
            this.helpProvider.SetShowHelp(this.picBox_Buchcover, true);
            this.picBox_Buchcover.Size = new System.Drawing.Size(235, 204);
            this.picBox_Buchcover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Buchcover.TabIndex = 23;
            this.picBox_Buchcover.TabStop = false;
            // 
            // lb_AusleihEnde
            // 
            this.lb_AusleihEnde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.lb_AusleihEnde, "Hier wird ihnen das Rückgabedatum angezeigt.");
            this.lb_AusleihEnde.Location = new System.Drawing.Point(115, 123);
            this.lb_AusleihEnde.Margin = new System.Windows.Forms.Padding(3);
            this.lb_AusleihEnde.Name = "lb_AusleihEnde";
            this.helpProvider.SetShowHelp(this.lb_AusleihEnde, true);
            this.lb_AusleihEnde.Size = new System.Drawing.Size(165, 24);
            this.lb_AusleihEnde.TabIndex = 22;
            this.lb_AusleihEnde.Text = "nicht verfügbar";
            this.lb_AusleihEnde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_AusleihEnde.UseCustomForeColor = true;
            // 
            // lb_AusleihStart
            // 
            this.lb_AusleihStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.lb_AusleihStart, "Hier wird ihnen angezeigt, wie lange das aktuelle Buch schon ausgeliehen ist.");
            this.lb_AusleihStart.Location = new System.Drawing.Point(115, 93);
            this.lb_AusleihStart.Margin = new System.Windows.Forms.Padding(3);
            this.lb_AusleihStart.Name = "lb_AusleihStart";
            this.helpProvider.SetShowHelp(this.lb_AusleihStart, true);
            this.lb_AusleihStart.Size = new System.Drawing.Size(165, 24);
            this.lb_AusleihStart.TabIndex = 21;
            this.lb_AusleihStart.Text = "nicht verfügbar";
            this.lb_AusleihStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_AusleihStart.UseCustomForeColor = true;
            // 
            // llb_BuchTitel
            // 
            this.llb_BuchTitel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_BuchTitel.Enabled = false;
            this.helpProvider.SetHelpString(this.llb_BuchTitel, "Hier wird ihnen angezeigt, welches Buch ausgeliehen wurde.");
            this.llb_BuchTitel.Location = new System.Drawing.Point(115, 33);
            this.llb_BuchTitel.Name = "llb_BuchTitel";
            this.helpProvider.SetShowHelp(this.llb_BuchTitel, true);
            this.llb_BuchTitel.Size = new System.Drawing.Size(165, 24);
            this.llb_BuchTitel.TabIndex = 3;
            this.llb_BuchTitel.Text = "keine Treffer";
            this.llb_BuchTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llb_BuchTitel.UseSelectable = true;
            this.llb_BuchTitel.Click += new System.EventHandler(this.llb_Buch_LinkClicked);
            // 
            // lb_BuchTitel
            // 
            this.helpProvider.SetHelpString(this.lb_BuchTitel, "Hier wird ihnen angezeigt, welches Buch ausgeliehen wurde.");
            this.lb_BuchTitel.Location = new System.Drawing.Point(3, 33);
            this.lb_BuchTitel.Margin = new System.Windows.Forms.Padding(3);
            this.lb_BuchTitel.Name = "lb_BuchTitel";
            this.helpProvider.SetShowHelp(this.lb_BuchTitel, true);
            this.lb_BuchTitel.Size = new System.Drawing.Size(106, 24);
            this.lb_BuchTitel.TabIndex = 19;
            this.lb_BuchTitel.Text = "Buch gefunden:";
            this.lb_BuchTitel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // llb_Kunde
            // 
            this.llb_Kunde.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_Kunde.Enabled = false;
            this.helpProvider.SetHelpString(this.llb_Kunde, "Hier wird ihnen angezeigt, wer das aktuelle Buch ausgeliehen hat.");
            this.llb_Kunde.Location = new System.Drawing.Point(115, 63);
            this.llb_Kunde.Name = "llb_Kunde";
            this.helpProvider.SetShowHelp(this.llb_Kunde, true);
            this.llb_Kunde.Size = new System.Drawing.Size(165, 24);
            this.llb_Kunde.TabIndex = 4;
            this.llb_Kunde.Text = "nicht verliehen";
            this.llb_Kunde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llb_Kunde.UseSelectable = true;
            this.llb_Kunde.Click += new System.EventHandler(this.llb_Kunde_LinkClicked);
            // 
            // lb_Zustand
            // 
            this.helpProvider.SetHelpString(this.lb_Zustand, "Hier wird der letzte Zustand des ausgeliehen Buches angezeigt. Ändern sie diesen " +
        "wenn sich der Zustand geändert hat.");
            this.lb_Zustand.Location = new System.Drawing.Point(3, 153);
            this.lb_Zustand.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Zustand.Name = "lb_Zustand";
            this.helpProvider.SetShowHelp(this.lb_Zustand, true);
            this.lb_Zustand.Size = new System.Drawing.Size(106, 24);
            this.lb_Zustand.TabIndex = 15;
            this.lb_Zustand.Text = "letzter Zustand:";
            this.lb_Zustand.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_AusleiheStart
            // 
            this.helpProvider.SetHelpString(this.lb_AusleiheStart, "Hier wird ihnen angezeigt, wie lange das aktuelle Buch schon ausgeliehen ist.");
            this.lb_AusleiheStart.Location = new System.Drawing.Point(3, 93);
            this.lb_AusleiheStart.Margin = new System.Windows.Forms.Padding(3);
            this.lb_AusleiheStart.Name = "lb_AusleiheStart";
            this.helpProvider.SetShowHelp(this.lb_AusleiheStart, true);
            this.lb_AusleiheStart.Size = new System.Drawing.Size(106, 24);
            this.lb_AusleiheStart.TabIndex = 10;
            this.lb_AusleiheStart.Text = "ausgeliehen seit:";
            this.lb_AusleiheStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Kunde
            // 
            this.helpProvider.SetHelpString(this.lb_Kunde, "Hier wird ihnen angezeigt, wer das aktuelle Buch ausgeliehen hat.");
            this.lb_Kunde.Location = new System.Drawing.Point(3, 63);
            this.lb_Kunde.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Kunde.Name = "lb_Kunde";
            this.helpProvider.SetShowHelp(this.lb_Kunde, true);
            this.lb_Kunde.Size = new System.Drawing.Size(106, 24);
            this.lb_Kunde.TabIndex = 8;
            this.lb_Kunde.Text = "ausgeliehen von:";
            this.lb_Kunde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_AusleiheEnde
            // 
            this.helpProvider.SetHelpString(this.lb_AusleiheEnde, "Hier wird ihnen das Rückgabedatum angezeigt.");
            this.lb_AusleiheEnde.Location = new System.Drawing.Point(3, 123);
            this.lb_AusleiheEnde.Margin = new System.Windows.Forms.Padding(3);
            this.lb_AusleiheEnde.Name = "lb_AusleiheEnde";
            this.helpProvider.SetShowHelp(this.lb_AusleiheEnde, true);
            this.lb_AusleiheEnde.Size = new System.Drawing.Size(106, 24);
            this.lb_AusleiheEnde.TabIndex = 7;
            this.lb_AusleiheEnde.Text = "Rückgabe fällig:";
            this.lb_AusleiheEnde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.llb_gesListe);
            this.metroPanel1.Controls.Add(this.rueckList_Slider);
            this.metroPanel1.Controls.Add(this.tb_listBis);
            this.metroPanel1.Controls.Add(this.tb_listVon);
            this.metroPanel1.Controls.Add(this.lb_EintragList);
            this.metroPanel1.Controls.Add(this.tb_BuchCode);
            this.metroPanel1.Controls.Add(this.bt_AddBuch);
            this.metroPanel1.Controls.Add(this.llb_BuchTitel);
            this.metroPanel1.Controls.Add(this.llb_Kunde);
            this.metroPanel1.Controls.Add(this.lb_BuchCode);
            this.metroPanel1.Controls.Add(this.picBox_Buchcover);
            this.metroPanel1.Controls.Add(this.bt_Zu_aendern);
            this.metroPanel1.Controls.Add(this.bt_open);
            this.metroPanel1.Controls.Add(this.lb_BuchTitel);
            this.metroPanel1.Controls.Add(this.lb_Kunde);
            this.metroPanel1.Controls.Add(this.lb_AusleihStart);
            this.metroPanel1.Controls.Add(this.lb_Zustand);
            this.metroPanel1.Controls.Add(this.lb_AusleihEnde);
            this.metroPanel1.Controls.Add(this.cb_Zustand);
            this.metroPanel1.Controls.Add(this.lb_AusleiheStart);
            this.metroPanel1.Controls.Add(this.lb_AusleiheEnde);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(23, 82);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(554, 242);
            this.metroPanel1.TabIndex = 30;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // llb_gesListe
            // 
            this.llb_gesListe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.llb_gesListe.Location = new System.Drawing.Point(116, 213);
            this.llb_gesListe.Name = "llb_gesListe";
            this.llb_gesListe.Size = new System.Drawing.Size(164, 24);
            this.llb_gesListe.TabIndex = 48;
            this.llb_gesListe.Text = "gesamte Ausleihliste anzeigen";
            this.llb_gesListe.UseSelectable = true;
            this.llb_gesListe.Click += new System.EventHandler(this.Llb_gesListe_Click);
            // 
            // rueckList_Slider
            // 
            this.rueckList_Slider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rueckList_Slider.Enabled = false;
            this.rueckList_Slider.LargeChange = 1;
            this.rueckList_Slider.Location = new System.Drawing.Point(142, 183);
            this.rueckList_Slider.Maximum = 0;
            this.rueckList_Slider.Name = "rueckList_Slider";
            this.rueckList_Slider.Size = new System.Drawing.Size(110, 24);
            this.rueckList_Slider.TabIndex = 44;
            this.rueckList_Slider.TabStop = true;
            this.rueckList_Slider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.RueckList_Slider_Scroll);
            this.rueckList_Slider.ValueChanged += new System.EventHandler(this.RueckList_Slider_ValueChanged);
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
            this.tb_listBis.Location = new System.Drawing.Point(256, 183);
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
            this.tb_listBis.TabIndex = 46;
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
            this.tb_listVon.Location = new System.Drawing.Point(115, 183);
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
            this.tb_listVon.TabIndex = 45;
            this.tb_listVon.TabStop = false;
            this.tb_listVon.Text = "-";
            this.tb_listVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_listVon.UseSelectable = true;
            this.tb_listVon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_listVon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_EintragList
            // 
            this.lb_EintragList.Location = new System.Drawing.Point(3, 183);
            this.lb_EintragList.Margin = new System.Windows.Forms.Padding(3);
            this.lb_EintragList.Name = "lb_EintragList";
            this.lb_EintragList.Size = new System.Drawing.Size(106, 24);
            this.lb_EintragList.TabIndex = 47;
            this.lb_EintragList.Text = "zeige Eintrag:";
            this.lb_EintragList.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Exemplar
            // 
            this.lb_Exemplar.AutoSize = true;
            this.lb_Exemplar.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_Exemplar.Location = new System.Drawing.Point(23, 60);
            this.lb_Exemplar.Name = "lb_Exemplar";
            this.lb_Exemplar.Size = new System.Drawing.Size(160, 19);
            this.lb_Exemplar.TabIndex = 51;
            this.lb_Exemplar.Text = "Exemplar-Informationen:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(23, 327);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(97, 19);
            this.metroLabel1.TabIndex = 52;
            this.metroLabel1.Text = "Ausleihverlauf:";
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
            this.bt_Abbrechen.TabIndex = 53;
            this.bt_Abbrechen.Text = "Schließen";
            this.bt_Abbrechen.UseSelectable = true;
            // 
            // cb_Zustand
            // 
            this.cb_Zustand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Zustand.BorderColor = System.Drawing.Color.Green;
            this.cb_Zustand.DataRowView = true;
            this.cb_Zustand.Enabled = false;
            this.cb_Zustand.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Zustand.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Zustand, "Hier wird der letzte Zustand des ausgeliehen Buches angezeigt. Ändern sie diesen " +
        "wenn sich der Zustand geändert hat.");
            this.cb_Zustand.HighlightColor = System.Drawing.Color.Green;
            this.cb_Zustand.ItemHeight = 18;
            this.cb_Zustand.Location = new System.Drawing.Point(115, 153);
            this.cb_Zustand.Name = "cb_Zustand";
            this.helpProvider.SetShowHelp(this.cb_Zustand, true);
            this.cb_Zustand.Size = new System.Drawing.Size(135, 24);
            this.cb_Zustand.TabIndex = 5;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel2.Controls.Add(this.gv_Verlauf);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(23, 349);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(554, 198);
            this.metroPanel2.TabIndex = 54;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // w_s_rueckgabe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.bt_Abbrechen);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.lb_Exemplar);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.bt_Rueckgabe);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "w_s_rueckgabe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "Buchrückgabe";
            this.Shown += new System.EventHandler(this.W_s_rueckgabe_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlauf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton bt_Rueckgabe;
        private MetroFramework.Controls.MetroButton bt_Zu_aendern;
        private MetroFramework.Controls.MetroGrid gv_Verlauf;
        private MetroFramework.Controls.MetroTextBox tb_BuchCode;
        private MetroFramework.Controls.MetroLabel lb_BuchCode;
        private MetroFramework.Controls.MetroLabel lb_AusleiheStart;
        private MetroFramework.Controls.MetroLabel lb_Kunde;
        private MetroFramework.Controls.MetroLabel lb_AusleiheEnde;
        private MetroFramework.Controls.MetroLabel lb_Zustand;
        private AdvancedComboBox cb_Zustand;
        private MetroFramework.Controls.MetroLink llb_Kunde;
        private MetroFramework.Controls.MetroLink llb_BuchTitel;
        private MetroFramework.Controls.MetroLabel lb_BuchTitel;
        private MetroFramework.Controls.MetroLabel lb_AusleihEnde;
        private MetroFramework.Controls.MetroLabel lb_AusleihStart;
        private System.Windows.Forms.PictureBox picBox_Buchcover;
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroButton bt_open;
        private MetroFramework.Controls.MetroButton bt_AddBuch;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lb_Exemplar;
        private MetroFramework.Controls.MetroLink llb_gesListe;
        private System.Windows.Forms.HScrollBar rueckList_Slider;
        private MetroFramework.Controls.MetroTextBox tb_listBis;
        private MetroFramework.Controls.MetroTextBox tb_listVon;
        private MetroFramework.Controls.MetroLabel lb_EintragList;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton bt_Abbrechen;
        private MetroFramework.Controls.MetroPanel metroPanel2;
    }
}

