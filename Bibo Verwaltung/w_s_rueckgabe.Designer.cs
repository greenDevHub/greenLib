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
            this.tb_listBis = new MetroFramework.Controls.MetroTextBox();
            this.lb_listVon = new MetroFramework.Controls.MetroLabel();
            this.tb_listVon = new MetroFramework.Controls.MetroTextBox();
            this.rueckList_Slider = new MetroFramework.Controls.MetroScrollBar();
            this.bt_AddBuch = new MetroFramework.Controls.MetroButton();
            this.bt_open = new MetroFramework.Controls.MetroButton();
            this.picBox_Buchcover = new System.Windows.Forms.PictureBox();
            this.lb_AusleihEnde = new MetroFramework.Controls.MetroLabel();
            this.lb_AusleihStart = new MetroFramework.Controls.MetroLabel();
            this.llb_BuchTitel = new MetroFramework.Controls.MetroLink();
            this.lb_BuchTitel = new MetroFramework.Controls.MetroLabel();
            this.llb_Kunde = new MetroFramework.Controls.MetroLink();
            this.cb_Zustand = new Bibo_Verwaltung.AdvancedComboBox();
            this.lb_Zustand = new MetroFramework.Controls.MetroLabel();
            this.lb_AusleiheStart = new MetroFramework.Controls.MetroLabel();
            this.lb_Kunde = new MetroFramework.Controls.MetroLabel();
            this.lb_AusleiheEnde = new MetroFramework.Controls.MetroLabel();
            this.lb_Verlauf = new MetroFramework.Controls.MetroLabel();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlauf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Rueckgabe
            // 
            this.bt_Rueckgabe.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Rueckgabe.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Rueckgabe, "Klicken sie auf diesen Button um die Buchrückgabe abzuschließen.");
            this.bt_Rueckgabe.Location = new System.Drawing.Point(23, 475);
            this.bt_Rueckgabe.Name = "bt_Rueckgabe";
            this.helpProvider.SetShowHelp(this.bt_Rueckgabe, true);
            this.bt_Rueckgabe.Size = new System.Drawing.Size(436, 23);
            this.bt_Rueckgabe.TabIndex = 9;
            this.bt_Rueckgabe.Text = "Buchrückgabe abschließen";
            this.bt_Rueckgabe.UseSelectable = true;
            this.bt_Rueckgabe.Click += new System.EventHandler(this.bt_Rueckgabe_Click);
            // 
            // bt_Zu_aendern
            // 
            this.bt_Zu_aendern.Enabled = false;
            this.bt_Zu_aendern.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Zu_aendern.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Zu_aendern, "Hier wird der letzte Zustand des ausgeliehen Buches angezeigt. Ändern sie diesen " +
        "wenn sich der Zustand geändert hat.");
            this.bt_Zu_aendern.Location = new System.Drawing.Point(319, 201);
            this.bt_Zu_aendern.Name = "bt_Zu_aendern";
            this.helpProvider.SetShowHelp(this.bt_Zu_aendern, true);
            this.bt_Zu_aendern.Size = new System.Drawing.Size(140, 24);
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
            this.gv_Verlauf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Verlauf.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Verlauf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Verlauf.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Verlauf.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Verlauf.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Verlauf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Verlauf.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Verlauf.EnableHeadersVisualStyles = false;
            this.gv_Verlauf.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Verlauf.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.gv_Verlauf, "Hier wird ihnen angezeigt, welche Kunden das aktuelle Buch früher ausgeliehen hab" +
        "en.");
            this.gv_Verlauf.Location = new System.Drawing.Point(23, 251);
            this.gv_Verlauf.MultiSelect = false;
            this.gv_Verlauf.Name = "gv_Verlauf";
            this.gv_Verlauf.ReadOnly = true;
            this.gv_Verlauf.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Verlauf.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
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
            // 
            // 
            // 
            this.tb_BuchCode.CustomButton.Image = null;
            this.tb_BuchCode.CustomButton.Location = new System.Drawing.Point(126, 2);
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
            this.tb_BuchCode.Location = new System.Drawing.Point(135, 63);
            this.tb_BuchCode.MaxLength = 32767;
            this.tb_BuchCode.Name = "tb_BuchCode";
            this.tb_BuchCode.PasswordChar = '\0';
            this.tb_BuchCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_BuchCode.SelectedText = "";
            this.tb_BuchCode.SelectionLength = 0;
            this.tb_BuchCode.SelectionStart = 0;
            this.tb_BuchCode.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_BuchCode, true);
            this.tb_BuchCode.Size = new System.Drawing.Size(148, 24);
            this.tb_BuchCode.TabIndex = 1;
            this.tb_BuchCode.UseSelectable = true;
            this.tb_BuchCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_BuchCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_BuchCode.TextChanged += new System.EventHandler(this.tb_BuchCode_TextChanged);
            this.tb_BuchCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_BuchCode_KeyPress);
            // 
            // lb_BuchCode
            // 
            this.lb_BuchCode.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_BuchCode, "Bitte geben sie den Buchlabel-Code ein. Dieser wird bei einem Ausleihvorgang auto" +
        "matisch generiert.");
            this.lb_BuchCode.Location = new System.Drawing.Point(23, 63);
            this.lb_BuchCode.Margin = new System.Windows.Forms.Padding(3);
            this.lb_BuchCode.Name = "lb_BuchCode";
            this.helpProvider.SetShowHelp(this.lb_BuchCode, true);
            this.lb_BuchCode.Size = new System.Drawing.Size(106, 19);
            this.lb_BuchCode.TabIndex = 5;
            this.lb_BuchCode.Text = "Buchlabel-Code:";
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
            this.tb_listBis.Location = new System.Drawing.Point(335, 445);
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
            this.tb_listBis.TabIndex = 29;
            this.tb_listBis.TabStop = false;
            this.tb_listBis.Text = "-";
            this.tb_listBis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_listBis.UseSelectable = true;
            this.tb_listBis.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_listBis.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_listVon
            // 
            this.lb_listVon.Location = new System.Drawing.Point(23, 443);
            this.lb_listVon.Margin = new System.Windows.Forms.Padding(3);
            this.lb_listVon.Name = "lb_listVon";
            this.lb_listVon.Size = new System.Drawing.Size(150, 26);
            this.lb_listVon.TabIndex = 28;
            this.lb_listVon.Text = "Rückgabeliste -Einträge:";
            this.lb_listVon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tb_listVon.Location = new System.Drawing.Point(179, 445);
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
            this.tb_listVon.TabIndex = 27;
            this.tb_listVon.TabStop = false;
            this.tb_listVon.Text = "-";
            this.tb_listVon.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_listVon.UseSelectable = true;
            this.tb_listVon.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_listVon.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // rueckList_Slider
            // 
            this.rueckList_Slider.Enabled = false;
            this.helpProvider.SetHelpString(this.rueckList_Slider, "Hier können Sie die sich in der Buchrückgabeliste befindlichen Bücher ansehen.");
            this.rueckList_Slider.LargeChange = 10;
            this.rueckList_Slider.Location = new System.Drawing.Point(209, 445);
            this.rueckList_Slider.Maximum = 100;
            this.rueckList_Slider.Minimum = 0;
            this.rueckList_Slider.MouseWheelBarPartitions = 10;
            this.rueckList_Slider.Name = "rueckList_Slider";
            this.rueckList_Slider.Orientation = MetroFramework.Controls.MetroScrollOrientation.Horizontal;
            this.rueckList_Slider.ScrollbarSize = 24;
            this.helpProvider.SetShowHelp(this.rueckList_Slider, true);
            this.rueckList_Slider.Size = new System.Drawing.Size(120, 24);
            this.rueckList_Slider.TabIndex = 8;
            this.rueckList_Slider.UseSelectable = true;
            this.rueckList_Slider.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar);
            // 
            // bt_AddBuch
            // 
            this.bt_AddBuch.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_AddBuch.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_AddBuch, "Fügt einen Eintrag zur Buchrückgabeliste hinzu. Ist das Buch bereits in der Liste" +
        " enthalten wird es wieder entfernt.");
            this.bt_AddBuch.Location = new System.Drawing.Point(289, 63);
            this.bt_AddBuch.Name = "bt_AddBuch";
            this.helpProvider.SetShowHelp(this.bt_AddBuch, true);
            this.bt_AddBuch.Size = new System.Drawing.Size(24, 24);
            this.bt_AddBuch.TabIndex = 2;
            this.bt_AddBuch.Text = "+";
            this.bt_AddBuch.UseSelectable = true;
            this.bt_AddBuch.Click += new System.EventHandler(this.bt_AddBuch_Click);
            // 
            // bt_open
            // 
            this.bt_open.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_open.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_open, "Hier gelangen Sie zur Zustands-Verwaltung.");
            this.bt_open.Location = new System.Drawing.Point(289, 201);
            this.bt_open.Name = "bt_open";
            this.helpProvider.SetShowHelp(this.bt_open, true);
            this.bt_open.Size = new System.Drawing.Size(24, 24);
            this.bt_open.TabIndex = 6;
            this.bt_open.Text = "*";
            this.bt_open.UseSelectable = true;
            this.bt_open.Click += new System.EventHandler(this.bt_open_Click);
            // 
            // picBox_Buchcover
            // 
            this.helpProvider.SetHelpString(this.picBox_Buchcover, "Hier sehen sie eine kleine Vorschau des ausgeliehenen Buches.");
            this.picBox_Buchcover.Location = new System.Drawing.Point(319, 63);
            this.picBox_Buchcover.Name = "picBox_Buchcover";
            this.helpProvider.SetShowHelp(this.picBox_Buchcover, true);
            this.picBox_Buchcover.Size = new System.Drawing.Size(140, 132);
            this.picBox_Buchcover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Buchcover.TabIndex = 23;
            this.picBox_Buchcover.TabStop = false;
            // 
            // lb_AusleihEnde
            // 
            this.lb_AusleihEnde.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_AusleihEnde, "Hier wird ihnen das Rückgabedatum angezeigt.");
            this.lb_AusleihEnde.Location = new System.Drawing.Point(135, 176);
            this.lb_AusleihEnde.Margin = new System.Windows.Forms.Padding(3);
            this.lb_AusleihEnde.Name = "lb_AusleihEnde";
            this.helpProvider.SetShowHelp(this.lb_AusleihEnde, true);
            this.lb_AusleihEnde.Size = new System.Drawing.Size(97, 19);
            this.lb_AusleihEnde.TabIndex = 22;
            this.lb_AusleihEnde.Text = "nicht verfügbar";
            // 
            // lb_AusleihStart
            // 
            this.lb_AusleihStart.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_AusleihStart, "Hier wird ihnen angezeigt, wie lange das aktuelle Buch schon ausgeliehen ist.");
            this.lb_AusleihStart.Location = new System.Drawing.Point(135, 151);
            this.lb_AusleihStart.Margin = new System.Windows.Forms.Padding(3);
            this.lb_AusleihStart.Name = "lb_AusleihStart";
            this.helpProvider.SetShowHelp(this.lb_AusleihStart, true);
            this.lb_AusleihStart.Size = new System.Drawing.Size(97, 19);
            this.lb_AusleihStart.TabIndex = 21;
            this.lb_AusleihStart.Text = "nicht verfügbar";
            // 
            // llb_BuchTitel
            // 
            this.llb_BuchTitel.AutoSize = true;
            this.llb_BuchTitel.Enabled = false;
            this.helpProvider.SetHelpString(this.llb_BuchTitel, "Hier wird ihnen angezeigt, welches Buch ausgeliehen wurde.");
            this.llb_BuchTitel.Location = new System.Drawing.Point(135, 93);
            this.llb_BuchTitel.Name = "llb_BuchTitel";
            this.helpProvider.SetShowHelp(this.llb_BuchTitel, true);
            this.llb_BuchTitel.Size = new System.Drawing.Size(77, 23);
            this.llb_BuchTitel.TabIndex = 3;
            this.llb_BuchTitel.Text = "keine Treffer";
            this.llb_BuchTitel.UseSelectable = true;
            this.llb_BuchTitel.Click += new System.EventHandler(this.llb_Buch_LinkClicked);
            // 
            // lb_BuchTitel
            // 
            this.lb_BuchTitel.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_BuchTitel, "Hier wird ihnen angezeigt, welches Buch ausgeliehen wurde.");
            this.lb_BuchTitel.Location = new System.Drawing.Point(23, 93);
            this.lb_BuchTitel.Margin = new System.Windows.Forms.Padding(3);
            this.lb_BuchTitel.Name = "lb_BuchTitel";
            this.helpProvider.SetShowHelp(this.lb_BuchTitel, true);
            this.lb_BuchTitel.Size = new System.Drawing.Size(99, 19);
            this.lb_BuchTitel.TabIndex = 19;
            this.lb_BuchTitel.Text = "Buch gefunden:";
            // 
            // llb_Kunde
            // 
            this.llb_Kunde.AutoSize = true;
            this.llb_Kunde.Enabled = false;
            this.helpProvider.SetHelpString(this.llb_Kunde, "Hier wird ihnen angezeigt, wer das aktuelle Buch ausgeliehen hat.");
            this.llb_Kunde.Location = new System.Drawing.Point(135, 122);
            this.llb_Kunde.Name = "llb_Kunde";
            this.helpProvider.SetShowHelp(this.llb_Kunde, true);
            this.llb_Kunde.Size = new System.Drawing.Size(86, 23);
            this.llb_Kunde.TabIndex = 4;
            this.llb_Kunde.Text = "nicht verliehen";
            this.llb_Kunde.UseSelectable = true;
            this.llb_Kunde.Click += new System.EventHandler(this.llb_Kunde_LinkClicked);
            // 
            // cb_Zustand
            // 
            this.cb_Zustand.Enabled = false;
            this.cb_Zustand.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Zustand, "Hier wird der letzte Zustand des ausgeliehen Buches angezeigt. Ändern sie diesen " +
        "wenn sich der Zustand geändert hat.");
            this.cb_Zustand.HighlightColor = System.Drawing.Color.Gray;
            this.cb_Zustand.ItemHeight = 18;
            this.cb_Zustand.Location = new System.Drawing.Point(135, 201);
            this.cb_Zustand.Name = "cb_Zustand";
            this.helpProvider.SetShowHelp(this.cb_Zustand, true);
            this.cb_Zustand.Size = new System.Drawing.Size(148, 24);
            this.cb_Zustand.TabIndex = 5;
            // 
            // lb_Zustand
            // 
            this.lb_Zustand.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Zustand, "Hier wird der letzte Zustand des ausgeliehen Buches angezeigt. Ändern sie diesen " +
        "wenn sich der Zustand geändert hat.");
            this.lb_Zustand.Location = new System.Drawing.Point(23, 201);
            this.lb_Zustand.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Zustand.Name = "lb_Zustand";
            this.helpProvider.SetShowHelp(this.lb_Zustand, true);
            this.lb_Zustand.Size = new System.Drawing.Size(98, 19);
            this.lb_Zustand.TabIndex = 15;
            this.lb_Zustand.Text = "letzter Zustand:";
            // 
            // lb_AusleiheStart
            // 
            this.lb_AusleiheStart.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_AusleiheStart, "Hier wird ihnen angezeigt, wie lange das aktuelle Buch schon ausgeliehen ist.");
            this.lb_AusleiheStart.Location = new System.Drawing.Point(23, 151);
            this.lb_AusleiheStart.Margin = new System.Windows.Forms.Padding(3);
            this.lb_AusleiheStart.Name = "lb_AusleiheStart";
            this.helpProvider.SetShowHelp(this.lb_AusleiheStart, true);
            this.lb_AusleiheStart.Size = new System.Drawing.Size(103, 19);
            this.lb_AusleiheStart.TabIndex = 10;
            this.lb_AusleiheStart.Text = "ausgeliehen seit:";
            // 
            // lb_Kunde
            // 
            this.lb_Kunde.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Kunde, "Hier wird ihnen angezeigt, wer das aktuelle Buch ausgeliehen hat.");
            this.lb_Kunde.Location = new System.Drawing.Point(23, 122);
            this.lb_Kunde.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Kunde.Name = "lb_Kunde";
            this.helpProvider.SetShowHelp(this.lb_Kunde, true);
            this.lb_Kunde.Size = new System.Drawing.Size(105, 19);
            this.lb_Kunde.TabIndex = 8;
            this.lb_Kunde.Text = "ausgeliehen von:";
            // 
            // lb_AusleiheEnde
            // 
            this.lb_AusleiheEnde.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_AusleiheEnde, "Hier wird ihnen das Rückgabedatum angezeigt.");
            this.lb_AusleiheEnde.Location = new System.Drawing.Point(23, 176);
            this.lb_AusleiheEnde.Margin = new System.Windows.Forms.Padding(3);
            this.lb_AusleiheEnde.Name = "lb_AusleiheEnde";
            this.helpProvider.SetShowHelp(this.lb_AusleiheEnde, true);
            this.lb_AusleiheEnde.Size = new System.Drawing.Size(101, 19);
            this.lb_AusleiheEnde.TabIndex = 7;
            this.lb_AusleiheEnde.Text = "Rückgabe fällig:";
            // 
            // lb_Verlauf
            // 
            this.lb_Verlauf.AutoSize = true;
            this.lb_Verlauf.Location = new System.Drawing.Point(23, 226);
            this.lb_Verlauf.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Verlauf.Name = "lb_Verlauf";
            this.lb_Verlauf.Size = new System.Drawing.Size(93, 19);
            this.lb_Verlauf.TabIndex = 6;
            this.lb_Verlauf.Text = "Ausleihverlauf:";
            // 
            // w_s_rueckgabe
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(472, 512);
            this.Controls.Add(this.bt_Rueckgabe);
            this.Controls.Add(this.tb_listBis);
            this.Controls.Add(this.rueckList_Slider);
            this.Controls.Add(this.tb_listVon);
            this.Controls.Add(this.lb_listVon);
            this.Controls.Add(this.lb_BuchCode);
            this.Controls.Add(this.lb_BuchTitel);
            this.Controls.Add(this.tb_BuchCode);
            this.Controls.Add(this.picBox_Buchcover);
            this.Controls.Add(this.gv_Verlauf);
            this.Controls.Add(this.lb_Verlauf);
            this.Controls.Add(this.bt_open);
            this.Controls.Add(this.bt_Zu_aendern);
            this.Controls.Add(this.bt_AddBuch);
            this.Controls.Add(this.llb_BuchTitel);
            this.Controls.Add(this.lb_AusleihEnde);
            this.Controls.Add(this.lb_Zustand);
            this.Controls.Add(this.cb_Zustand);
            this.Controls.Add(this.lb_Kunde);
            this.Controls.Add(this.llb_Kunde);
            this.Controls.Add(this.lb_AusleiheEnde);
            this.Controls.Add(this.lb_AusleihStart);
            this.Controls.Add(this.lb_AusleiheStart);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_rueckgabe";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buchrückgabe";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlauf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Buchcover)).EndInit();
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
        private MetroFramework.Controls.MetroLabel lb_Verlauf;
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
        private MetroFramework.Controls.MetroScrollBar rueckList_Slider;
        private MetroFramework.Controls.MetroTextBox tb_listBis;
        private MetroFramework.Controls.MetroLabel lb_listVon;
        private MetroFramework.Controls.MetroTextBox tb_listVon;
    }
}

