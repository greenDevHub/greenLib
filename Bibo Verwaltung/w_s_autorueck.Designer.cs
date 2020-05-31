namespace Bibo_Verwaltung
{
    partial class w_s_autorueck
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_autorueck));
            this.lb_Klasse = new MetroFramework.Controls.MetroLabel();
            this.tb_ExemplarID = new MetroFramework.Controls.MetroTextBox();
            this.bt_back = new MetroFramework.Controls.MetroButton();
            this.bt_abschließen = new MetroFramework.Controls.MetroButton();
            this.bt_bestaetigen = new MetroFramework.Controls.MetroButton();
            this.bt_next = new MetroFramework.Controls.MetroButton();
            this.lb_selected = new MetroFramework.Controls.MetroLabel();
            this.lb_suggested = new MetroFramework.Controls.MetroLabel();
            this.lb_Schueler = new MetroFramework.Controls.MetroLabel();
            this.lb_Anweisung1 = new MetroFramework.Controls.MetroLabel();
            this.gv_selected = new MetroFramework.Controls.MetroGrid();
            this.gv_suggested = new MetroFramework.Controls.MetroGrid();
            this.gv_Schueler = new MetroFramework.Controls.MetroGrid();
            this.a_cb_Klasse = new Bibo_Verwaltung.AdvancedComboBox();
            this.a_cb_Modus = new Bibo_Verwaltung.AdvancedComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_suggested)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Schueler)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Klasse
            // 
            this.lb_Klasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Klasse.Location = new System.Drawing.Point(239, 82);
            this.lb_Klasse.Name = "lb_Klasse";
            this.lb_Klasse.Size = new System.Drawing.Size(50, 24);
            this.lb_Klasse.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lb_Klasse.TabIndex = 41;
            this.lb_Klasse.Text = "-";
            this.lb_Klasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_Klasse.Visible = false;
            // 
            // tb_ExemplarID
            // 
            this.tb_ExemplarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_ExemplarID.CustomButton.Image = null;
            this.tb_ExemplarID.CustomButton.Location = new System.Drawing.Point(373, 2);
            this.tb_ExemplarID.CustomButton.Name = "";
            this.tb_ExemplarID.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_ExemplarID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_ExemplarID.CustomButton.TabIndex = 1;
            this.tb_ExemplarID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_ExemplarID.CustomButton.UseSelectable = true;
            this.tb_ExemplarID.CustomButton.Visible = false;
            this.tb_ExemplarID.Enabled = false;
            this.tb_ExemplarID.ForeColor = System.Drawing.SystemColors.GrayText;
            this.tb_ExemplarID.Lines = new string[0];
            this.tb_ExemplarID.Location = new System.Drawing.Point(582, 137);
            this.tb_ExemplarID.MaxLength = 32767;
            this.tb_ExemplarID.Name = "tb_ExemplarID";
            this.tb_ExemplarID.PasswordChar = '\0';
            this.tb_ExemplarID.PromptText = "Exemplar ID";
            this.tb_ExemplarID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_ExemplarID.SelectedText = "";
            this.tb_ExemplarID.SelectionLength = 0;
            this.tb_ExemplarID.SelectionStart = 0;
            this.tb_ExemplarID.ShortcutsEnabled = true;
            this.tb_ExemplarID.Size = new System.Drawing.Size(395, 24);
            this.tb_ExemplarID.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tb_ExemplarID.TabIndex = 29;
            this.tb_ExemplarID.UseSelectable = true;
            this.tb_ExemplarID.WaterMark = "Exemplar ID";
            this.tb_ExemplarID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ExemplarID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ExemplarID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Tb_ExemplarID_KeyPress);
            // 
            // bt_back
            // 
            this.bt_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_back.DisplayFocus = true;
            this.bt_back.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_back.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_back.Location = new System.Drawing.Point(23, 453);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(120, 24);
            this.bt_back.Style = MetroFramework.MetroColorStyle.Yellow;
            this.bt_back.TabIndex = 31;
            this.bt_back.Text = "vorheriger Schüler";
            this.bt_back.UseSelectable = true;
            this.bt_back.Click += new System.EventHandler(this.Bt_back_Click);
            // 
            // bt_abschließen
            // 
            this.bt_abschließen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_abschließen.DisplayFocus = true;
            this.bt_abschließen.Enabled = false;
            this.bt_abschließen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_abschließen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_abschließen.Location = new System.Drawing.Point(777, 453);
            this.bt_abschließen.Name = "bt_abschließen";
            this.bt_abschließen.Size = new System.Drawing.Size(200, 24);
            this.bt_abschließen.Style = MetroFramework.MetroColorStyle.Yellow;
            this.bt_abschließen.TabIndex = 35;
            this.bt_abschließen.Text = "Rückgabevorgang ausführen";
            this.bt_abschließen.UseSelectable = true;
            this.bt_abschließen.Click += new System.EventHandler(this.Bt_abschließen_Click);
            // 
            // bt_bestaetigen
            // 
            this.bt_bestaetigen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_bestaetigen.DisplayFocus = true;
            this.bt_bestaetigen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_bestaetigen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_bestaetigen.Location = new System.Drawing.Point(833, 82);
            this.bt_bestaetigen.Name = "bt_bestaetigen";
            this.bt_bestaetigen.Size = new System.Drawing.Size(144, 24);
            this.bt_bestaetigen.Style = MetroFramework.MetroColorStyle.Yellow;
            this.bt_bestaetigen.TabIndex = 28;
            this.bt_bestaetigen.Text = "Schüler laden";
            this.bt_bestaetigen.UseSelectable = true;
            this.bt_bestaetigen.Click += new System.EventHandler(this.Bt_bestaetigen_Click);
            // 
            // bt_next
            // 
            this.bt_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_next.DisplayFocus = true;
            this.bt_next.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_next.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_next.Location = new System.Drawing.Point(149, 453);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(120, 24);
            this.bt_next.Style = MetroFramework.MetroColorStyle.Yellow;
            this.bt_next.TabIndex = 34;
            this.bt_next.Text = "nächster Schüler";
            this.bt_next.UseSelectable = true;
            this.bt_next.Click += new System.EventHandler(this.Bt_next_Click);
            // 
            // lb_selected
            // 
            this.lb_selected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_selected.AutoSize = true;
            this.lb_selected.Location = new System.Drawing.Point(582, 173);
            this.lb_selected.Name = "lb_selected";
            this.lb_selected.Size = new System.Drawing.Size(128, 19);
            this.lb_selected.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lb_selected.TabIndex = 39;
            this.lb_selected.Text = "ausgewählte Bücher:";
            // 
            // lb_suggested
            // 
            this.lb_suggested.AutoSize = true;
            this.lb_suggested.Location = new System.Drawing.Point(275, 115);
            this.lb_suggested.Name = "lb_suggested";
            this.lb_suggested.Size = new System.Drawing.Size(132, 19);
            this.lb_suggested.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lb_suggested.TabIndex = 38;
            this.lb_suggested.Text = "ausgeliehene Bücher:";
            // 
            // lb_Schueler
            // 
            this.lb_Schueler.AutoSize = true;
            this.lb_Schueler.Location = new System.Drawing.Point(23, 115);
            this.lb_Schueler.Name = "lb_Schueler";
            this.lb_Schueler.Size = new System.Drawing.Size(76, 19);
            this.lb_Schueler.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lb_Schueler.TabIndex = 37;
            this.lb_Schueler.Text = "Schülerliste:";
            // 
            // lb_Anweisung1
            // 
            this.lb_Anweisung1.AutoSize = true;
            this.lb_Anweisung1.Location = new System.Drawing.Point(23, 57);
            this.lb_Anweisung1.Name = "lb_Anweisung1";
            this.lb_Anweisung1.Size = new System.Drawing.Size(444, 19);
            this.lb_Anweisung1.TabIndex = 36;
            this.lb_Anweisung1.Text = "Wählen Sie den Rückgabemodus für die automatisierte Lehrbuchrückgabe:";
            this.lb_Anweisung1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gv_selected
            // 
            this.gv_selected.AllowUserToAddRows = false;
            this.gv_selected.AllowUserToDeleteRows = false;
            this.gv_selected.AllowUserToResizeColumns = false;
            this.gv_selected.AllowUserToResizeRows = false;
            this.gv_selected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_selected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_selected.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_selected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_selected.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_selected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_selected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_selected.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_selected.Enabled = false;
            this.gv_selected.EnableHeadersVisualStyles = false;
            this.gv_selected.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_selected.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_selected.Location = new System.Drawing.Point(582, 195);
            this.gv_selected.MultiSelect = false;
            this.gv_selected.Name = "gv_selected";
            this.gv_selected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_selected.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_selected.RowHeadersWidth = 5;
            this.gv_selected.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_selected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_selected.ShowCellErrors = false;
            this.gv_selected.ShowCellToolTips = false;
            this.gv_selected.ShowEditingIcon = false;
            this.gv_selected.ShowRowErrors = false;
            this.gv_selected.Size = new System.Drawing.Size(395, 252);
            this.gv_selected.Style = MetroFramework.MetroColorStyle.Yellow;
            this.gv_selected.TabIndex = 33;
            // 
            // gv_suggested
            // 
            this.gv_suggested.AllowUserToAddRows = false;
            this.gv_suggested.AllowUserToDeleteRows = false;
            this.gv_suggested.AllowUserToResizeRows = false;
            this.gv_suggested.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_suggested.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_suggested.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_suggested.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_suggested.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_suggested.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_suggested.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_suggested.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_suggested.DefaultCellStyle = dataGridViewCellStyle5;
            this.gv_suggested.Enabled = false;
            this.gv_suggested.EnableHeadersVisualStyles = false;
            this.gv_suggested.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_suggested.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_suggested.Location = new System.Drawing.Point(275, 137);
            this.gv_suggested.MultiSelect = false;
            this.gv_suggested.Name = "gv_suggested";
            this.gv_suggested.ReadOnly = true;
            this.gv_suggested.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_suggested.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_suggested.RowHeadersWidth = 5;
            this.gv_suggested.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_suggested.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_suggested.ShowCellErrors = false;
            this.gv_suggested.ShowCellToolTips = false;
            this.gv_suggested.ShowEditingIcon = false;
            this.gv_suggested.ShowRowErrors = false;
            this.gv_suggested.Size = new System.Drawing.Size(301, 310);
            this.gv_suggested.Style = MetroFramework.MetroColorStyle.Yellow;
            this.gv_suggested.TabIndex = 32;
            // 
            // gv_Schueler
            // 
            this.gv_Schueler.AllowUserToAddRows = false;
            this.gv_Schueler.AllowUserToDeleteRows = false;
            this.gv_Schueler.AllowUserToResizeColumns = false;
            this.gv_Schueler.AllowUserToResizeRows = false;
            this.gv_Schueler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gv_Schueler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_Schueler.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Schueler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Schueler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Schueler.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Schueler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gv_Schueler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Schueler.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Schueler.DefaultCellStyle = dataGridViewCellStyle8;
            this.gv_Schueler.Enabled = false;
            this.gv_Schueler.EnableHeadersVisualStyles = false;
            this.gv_Schueler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Schueler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Schueler.Location = new System.Drawing.Point(23, 137);
            this.gv_Schueler.MultiSelect = false;
            this.gv_Schueler.Name = "gv_Schueler";
            this.gv_Schueler.ReadOnly = true;
            this.gv_Schueler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Schueler.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gv_Schueler.RowHeadersWidth = 5;
            this.gv_Schueler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Schueler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Schueler.ShowCellErrors = false;
            this.gv_Schueler.ShowCellToolTips = false;
            this.gv_Schueler.ShowEditingIcon = false;
            this.gv_Schueler.ShowRowErrors = false;
            this.gv_Schueler.Size = new System.Drawing.Size(246, 310);
            this.gv_Schueler.Style = MetroFramework.MetroColorStyle.Yellow;
            this.gv_Schueler.TabIndex = 30;
            this.gv_Schueler.CurrentCellChanged += new System.EventHandler(this.Gv_Schueler_CurrentCellChanged);
            // 
            // a_cb_Klasse
            // 
            this.a_cb_Klasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.a_cb_Klasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.a_cb_Klasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.a_cb_Klasse.BorderColor = System.Drawing.Color.Gray;
            this.a_cb_Klasse.DataRowView = true;
            this.a_cb_Klasse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.a_cb_Klasse.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.a_cb_Klasse.ForeColor = System.Drawing.SystemColors.GrayText;
            this.a_cb_Klasse.FormattingEnabled = true;
            this.a_cb_Klasse.HighlightColor = System.Drawing.Color.Gold;
            this.a_cb_Klasse.ItemHeight = 18;
            this.a_cb_Klasse.Location = new System.Drawing.Point(295, 82);
            this.a_cb_Klasse.Name = "a_cb_Klasse";
            this.a_cb_Klasse.Size = new System.Drawing.Size(210, 24);
            this.a_cb_Klasse.Sorted = true;
            this.a_cb_Klasse.TabIndex = 27;
            this.a_cb_Klasse.Visible = false;
            // 
            // a_cb_Modus
            // 
            this.a_cb_Modus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.a_cb_Modus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.a_cb_Modus.BorderColor = System.Drawing.Color.Gray;
            this.a_cb_Modus.DataRowView = false;
            this.a_cb_Modus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.a_cb_Modus.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.a_cb_Modus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.a_cb_Modus.FormattingEnabled = true;
            this.a_cb_Modus.HighlightColor = System.Drawing.Color.Gold;
            this.a_cb_Modus.ItemHeight = 18;
            this.a_cb_Modus.Items.AddRange(new object[] {
            "Rückgabe nach Klasse",
            "Rückgabe nach Klassenstufe"});
            this.a_cb_Modus.Location = new System.Drawing.Point(23, 82);
            this.a_cb_Modus.Name = "a_cb_Modus";
            this.a_cb_Modus.Size = new System.Drawing.Size(210, 24);
            this.a_cb_Modus.Sorted = true;
            this.a_cb_Modus.TabIndex = 25;
            this.a_cb_Modus.SelectedIndexChanged += new System.EventHandler(this.A_cb_Modus_SelectedIndexChanged);
            // 
            // w_s_autorueck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.a_cb_Klasse);
            this.Controls.Add(this.lb_Klasse);
            this.Controls.Add(this.tb_ExemplarID);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_abschließen);
            this.Controls.Add(this.bt_bestaetigen);
            this.Controls.Add(this.bt_next);
            this.Controls.Add(this.lb_selected);
            this.Controls.Add(this.lb_suggested);
            this.Controls.Add(this.lb_Schueler);
            this.Controls.Add(this.a_cb_Modus);
            this.Controls.Add(this.lb_Anweisung1);
            this.Controls.Add(this.gv_selected);
            this.Controls.Add(this.gv_suggested);
            this.Controls.Add(this.gv_Schueler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "w_s_autorueck";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Lehrbuchrückgabe";
            ((System.ComponentModel.ISupportInitialize)(this.gv_selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_suggested)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Schueler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdvancedComboBox a_cb_Klasse;
        private MetroFramework.Controls.MetroLabel lb_Klasse;
        private MetroFramework.Controls.MetroTextBox tb_ExemplarID;
        private MetroFramework.Controls.MetroButton bt_back;
        private MetroFramework.Controls.MetroButton bt_abschließen;
        private MetroFramework.Controls.MetroButton bt_bestaetigen;
        private MetroFramework.Controls.MetroButton bt_next;
        private MetroFramework.Controls.MetroLabel lb_selected;
        private MetroFramework.Controls.MetroLabel lb_suggested;
        private MetroFramework.Controls.MetroLabel lb_Schueler;
        private AdvancedComboBox a_cb_Modus;
        private MetroFramework.Controls.MetroLabel lb_Anweisung1;
        private MetroFramework.Controls.MetroGrid gv_selected;
        private MetroFramework.Controls.MetroGrid gv_suggested;
        private MetroFramework.Controls.MetroGrid gv_Schueler;
    }
}