﻿namespace Bibo_Verwaltung
{
    partial class w_s_automatic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_automatic));
            this.lb_Jahr = new MetroFramework.Controls.MetroLabel();
            this.gv_Schueler = new MetroFramework.Controls.MetroGrid();
            this.gv_suggested = new MetroFramework.Controls.MetroGrid();
            this.gv_selected = new MetroFramework.Controls.MetroGrid();
            this.lb_Anweisung1 = new MetroFramework.Controls.MetroLabel();
            this.lb_Schueler = new MetroFramework.Controls.MetroLabel();
            this.lb_suggested = new MetroFramework.Controls.MetroLabel();
            this.lb_selected = new MetroFramework.Controls.MetroLabel();
            this.bt_next = new MetroFramework.Controls.MetroButton();
            this.bt_bestaetigen = new MetroFramework.Controls.MetroButton();
            this.bt_abschließen = new MetroFramework.Controls.MetroButton();
            this.bt_back = new MetroFramework.Controls.MetroButton();
            this.tb_ExemplarID = new MetroFramework.Controls.MetroTextBox();
            this.lb_Klasse = new MetroFramework.Controls.MetroLabel();
            this.dp_RueckDatum = new MetroFramework.Controls.MetroDateTime();
            this.mbt_Suche = new MetroFramework.Controls.MetroButton();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.msm_automatic = new MetroFramework.Components.MetroStyleManager(this.components);
            this.p_klasse = new Bibo_Verwaltung.TransparentPanel();
            this.a_cb_Klasse = new Bibo_Verwaltung.AdvancedComboBox();
            this.a_cb_Modus = new Bibo_Verwaltung.AdvancedComboBox();
            this.p_modus = new Bibo_Verwaltung.TransparentPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Schueler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_suggested)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_selected)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msm_automatic)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_Jahr
            // 
            this.lb_Jahr.Location = new System.Drawing.Point(239, 82);
            this.lb_Jahr.Name = "lb_Jahr";
            this.lb_Jahr.Size = new System.Drawing.Size(109, 24);
            this.lb_Jahr.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lb_Jahr.TabIndex = 1;
            this.lb_Jahr.Text = "Rückgabedatum:";
            this.lb_Jahr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Schueler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Schueler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Schueler.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Schueler.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Schueler.Enabled = false;
            this.gv_Schueler.EnableHeadersVisualStyles = false;
            this.gv_Schueler.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Schueler.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Schueler.Location = new System.Drawing.Point(23, 137);
            this.gv_Schueler.MultiSelect = false;
            this.gv_Schueler.Name = "gv_Schueler";
            this.gv_Schueler.ReadOnly = true;
            this.gv_Schueler.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Schueler.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Schueler.RowHeadersWidth = 5;
            this.gv_Schueler.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Schueler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Schueler.ShowCellErrors = false;
            this.gv_Schueler.ShowCellToolTips = false;
            this.gv_Schueler.ShowEditingIcon = false;
            this.gv_Schueler.ShowRowErrors = false;
            this.gv_Schueler.Size = new System.Drawing.Size(246, 310);
            this.gv_Schueler.Style = MetroFramework.MetroColorStyle.Yellow;
            this.gv_Schueler.TabIndex = 5;
            this.gv_Schueler.TabStop = false;
            this.gv_Schueler.CurrentCellChanged += new System.EventHandler(this.gv_Schueler_SelectionChanged);
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
            this.gv_suggested.TabIndex = 6;
            this.gv_suggested.TabStop = false;
            this.metroToolTip1.SetToolTip(this.gv_suggested, "Dies sind die für den Schüler vorgeschlagenen Bücher, welche anhand seiner Fächer" +
        " und Klassenstufe ermittelt werden.");
            // 
            // gv_selected
            // 
            this.gv_selected.AllowUserToAddRows = false;
            this.gv_selected.AllowUserToDeleteRows = false;
            this.gv_selected.AllowUserToResizeColumns = false;
            this.gv_selected.AllowUserToResizeRows = false;
            this.gv_selected.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_selected.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_selected.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_selected.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_selected.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_selected.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_selected.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gv_selected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_selected.DefaultCellStyle = dataGridViewCellStyle8;
            this.gv_selected.Enabled = false;
            this.gv_selected.EnableHeadersVisualStyles = false;
            this.gv_selected.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_selected.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_selected.Location = new System.Drawing.Point(582, 195);
            this.gv_selected.MultiSelect = false;
            this.gv_selected.Name = "gv_selected";
            this.gv_selected.ReadOnly = true;
            this.gv_selected.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_selected.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.gv_selected.RowHeadersWidth = 5;
            this.gv_selected.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_selected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_selected.ShowCellErrors = false;
            this.gv_selected.ShowCellToolTips = false;
            this.gv_selected.ShowEditingIcon = false;
            this.gv_selected.ShowRowErrors = false;
            this.gv_selected.Size = new System.Drawing.Size(395, 252);
            this.gv_selected.Style = MetroFramework.MetroColorStyle.Yellow;
            this.gv_selected.TabIndex = 7;
            this.gv_selected.TabStop = false;
            this.metroToolTip1.SetToolTip(this.gv_selected, "Dies sind Ihre ausgewählten Exemplare.");
            // 
            // lb_Anweisung1
            // 
            this.lb_Anweisung1.AutoSize = true;
            this.lb_Anweisung1.Location = new System.Drawing.Point(23, 57);
            this.lb_Anweisung1.Name = "lb_Anweisung1";
            this.lb_Anweisung1.Size = new System.Drawing.Size(784, 19);
            this.lb_Anweisung1.TabIndex = 8;
            this.lb_Anweisung1.Text = "Wählen Sie den Ausgabemodus und das Datum der Buchrückgabe am Ende des Schuljahre" +
    "s für die automatisierte Lehrbuchausgabe:";
            this.lb_Anweisung1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_Schueler
            // 
            this.lb_Schueler.AutoSize = true;
            this.lb_Schueler.Location = new System.Drawing.Point(23, 115);
            this.lb_Schueler.Name = "lb_Schueler";
            this.lb_Schueler.Size = new System.Drawing.Size(76, 19);
            this.lb_Schueler.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lb_Schueler.TabIndex = 12;
            this.lb_Schueler.Text = "Schülerliste:";
            // 
            // lb_suggested
            // 
            this.lb_suggested.AutoSize = true;
            this.lb_suggested.Location = new System.Drawing.Point(275, 115);
            this.lb_suggested.Name = "lb_suggested";
            this.lb_suggested.Size = new System.Drawing.Size(148, 19);
            this.lb_suggested.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lb_suggested.TabIndex = 13;
            this.lb_suggested.Text = "vorgeschlagene Bücher:";
            // 
            // lb_selected
            // 
            this.lb_selected.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_selected.AutoSize = true;
            this.lb_selected.Location = new System.Drawing.Point(582, 173);
            this.lb_selected.Name = "lb_selected";
            this.lb_selected.Size = new System.Drawing.Size(128, 19);
            this.lb_selected.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lb_selected.TabIndex = 14;
            this.lb_selected.Text = "ausgewählte Bücher:";
            // 
            // bt_next
            // 
            this.bt_next.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_next.DisplayFocus = true;
            this.bt_next.Enabled = false;
            this.bt_next.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_next.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_next.Location = new System.Drawing.Point(149, 453);
            this.bt_next.Name = "bt_next";
            this.bt_next.Size = new System.Drawing.Size(120, 24);
            this.bt_next.Style = MetroFramework.MetroColorStyle.Yellow;
            this.bt_next.TabIndex = 8;
            this.bt_next.Text = "nächster Schüler";
            this.metroToolTip1.SetToolTip(this.bt_next, "Gehen Sie zum nächsten Schüler.");
            this.bt_next.UseSelectable = true;
            this.bt_next.Click += new System.EventHandler(this.bt_next_Click);
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
            this.bt_bestaetigen.TabIndex = 3;
            this.bt_bestaetigen.Text = "Schüler laden";
            this.metroToolTip1.SetToolTip(this.bt_bestaetigen, "Laden Sie die Schüler der ausgewählten Klasse bzw. Klassenstufe.");
            this.bt_bestaetigen.UseSelectable = true;
            this.bt_bestaetigen.Click += new System.EventHandler(this.bt_bestaetigen_Click);
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
            this.bt_abschließen.TabIndex = 6;
            this.bt_abschließen.Text = "Ausleihvorgang ausführen";
            this.metroToolTip1.SetToolTip(this.bt_abschließen, "Führen Sie den Ausleihvorgang aus.");
            this.bt_abschließen.UseSelectable = true;
            this.bt_abschließen.Click += new System.EventHandler(this.bt_abschließen_Click);
            // 
            // bt_back
            // 
            this.bt_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_back.DisplayFocus = true;
            this.bt_back.Enabled = false;
            this.bt_back.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_back.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_back.Location = new System.Drawing.Point(23, 453);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(120, 24);
            this.bt_back.Style = MetroFramework.MetroColorStyle.Yellow;
            this.bt_back.TabIndex = 7;
            this.bt_back.Text = "vorheriger Schüler";
            this.metroToolTip1.SetToolTip(this.bt_back, "Gehen Sie zum vorherigen Schüler.");
            this.bt_back.UseSelectable = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // tb_ExemplarID
            // 
            this.tb_ExemplarID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_ExemplarID.CustomButton.Image = null;
            this.tb_ExemplarID.CustomButton.Location = new System.Drawing.Point(343, 2);
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
            this.tb_ExemplarID.Size = new System.Drawing.Size(365, 24);
            this.tb_ExemplarID.Style = MetroFramework.MetroColorStyle.Yellow;
            this.tb_ExemplarID.TabIndex = 4;
            this.metroToolTip1.SetToolTip(this.tb_ExemplarID, "Wählen Sie die Exemplar-Nummer des zu verleihenden Exemplares oder Scannen Sie di" +
        "ese ein.");
            this.tb_ExemplarID.UseSelectable = true;
            this.tb_ExemplarID.WaterMark = "Exemplar ID";
            this.tb_ExemplarID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_ExemplarID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_ExemplarID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ExemplarID_KeyPress);
            // 
            // lb_Klasse
            // 
            this.lb_Klasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Klasse.Location = new System.Drawing.Point(526, 82);
            this.lb_Klasse.Name = "lb_Klasse";
            this.lb_Klasse.Size = new System.Drawing.Size(50, 24);
            this.lb_Klasse.Style = MetroFramework.MetroColorStyle.Yellow;
            this.lb_Klasse.TabIndex = 23;
            this.lb_Klasse.Text = "-";
            this.lb_Klasse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_Klasse.Visible = false;
            // 
            // dp_RueckDatum
            // 
            this.dp_RueckDatum.CustomFormat = " dd.MM.yyyy";
            this.dp_RueckDatum.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dp_RueckDatum.Location = new System.Drawing.Point(354, 79);
            this.dp_RueckDatum.MinimumSize = new System.Drawing.Size(0, 29);
            this.dp_RueckDatum.Name = "dp_RueckDatum";
            this.dp_RueckDatum.Size = new System.Drawing.Size(165, 29);
            this.dp_RueckDatum.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.dp_RueckDatum, "Wählen Sie das Rückgabedatum für den Buchverleih.");
            // 
            // mbt_Suche
            // 
            this.mbt_Suche.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.mbt_Suche.DisplayFocus = true;
            this.mbt_Suche.Enabled = false;
            this.mbt_Suche.Location = new System.Drawing.Point(953, 137);
            this.mbt_Suche.Name = "mbt_Suche";
            this.mbt_Suche.Size = new System.Drawing.Size(24, 24);
            this.mbt_Suche.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mbt_Suche.TabIndex = 5;
            this.mbt_Suche.Text = "🔍";
            this.metroToolTip1.SetToolTip(this.mbt_Suche, "Suchen Sie nach Exemplaren.");
            this.mbt_Suche.UseSelectable = true;
            this.mbt_Suche.Click += new System.EventHandler(this.Mbt_Suche_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroToolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.MetroToolTip1_Popup);
            // 
            // msm_automatic
            // 
            this.msm_automatic.Owner = this;
            this.msm_automatic.Style = MetroFramework.MetroColorStyle.Yellow;
            // 
            // p_klasse
            // 
            this.p_klasse.Location = new System.Drawing.Point(582, 82);
            this.p_klasse.Name = "p_klasse";
            this.p_klasse.Size = new System.Drawing.Size(245, 24);
            this.p_klasse.TabIndex = 24;
            this.p_klasse.Visible = false;
            // 
            // a_cb_Klasse
            // 
            this.a_cb_Klasse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.a_cb_Klasse.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.a_cb_Klasse.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.a_cb_Klasse.BorderColor = System.Drawing.Color.Gray;
            this.a_cb_Klasse.DataRowView = true;
            this.a_cb_Klasse.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.a_cb_Klasse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_cb_Klasse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_cb_Klasse.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.a_cb_Klasse.ForeColor = System.Drawing.SystemColors.GrayText;
            this.a_cb_Klasse.FormattingEnabled = true;
            this.a_cb_Klasse.HighlightColor = System.Drawing.Color.Gold;
            this.a_cb_Klasse.ItemHeight = 18;
            this.a_cb_Klasse.Location = new System.Drawing.Point(582, 82);
            this.a_cb_Klasse.Name = "a_cb_Klasse";
            this.a_cb_Klasse.Size = new System.Drawing.Size(245, 24);
            this.a_cb_Klasse.Sorted = true;
            this.a_cb_Klasse.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.a_cb_Klasse, "Wählen Sie die Klasse bzw. Klassenstufe.");
            this.a_cb_Klasse.Visible = false;
            // 
            // a_cb_Modus
            // 
            this.a_cb_Modus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.a_cb_Modus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.a_cb_Modus.BorderColor = System.Drawing.Color.Gray;
            this.a_cb_Modus.DataRowView = false;
            this.a_cb_Modus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.a_cb_Modus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.a_cb_Modus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.a_cb_Modus.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.a_cb_Modus.ForeColor = System.Drawing.SystemColors.GrayText;
            this.a_cb_Modus.FormattingEnabled = true;
            this.a_cb_Modus.HighlightColor = System.Drawing.Color.Gold;
            this.a_cb_Modus.ItemHeight = 18;
            this.a_cb_Modus.Items.AddRange(new object[] {
            "Ausgabe nach Klasse",
            "Ausgabe nach Klassenstufe"});
            this.a_cb_Modus.Location = new System.Drawing.Point(23, 82);
            this.a_cb_Modus.Name = "a_cb_Modus";
            this.a_cb_Modus.Size = new System.Drawing.Size(210, 24);
            this.a_cb_Modus.Sorted = true;
            this.a_cb_Modus.TabIndex = 0;
            this.metroToolTip1.SetToolTip(this.a_cb_Modus, "Wählen Sie den Ausgabemodus.");
            this.a_cb_Modus.SelectedIndexChanged += new System.EventHandler(this.a_cb_Modus_SelectedIndexChanged);
            // 
            // p_modus
            // 
            this.p_modus.Location = new System.Drawing.Point(23, 82);
            this.p_modus.Name = "p_modus";
            this.p_modus.Size = new System.Drawing.Size(210, 24);
            this.p_modus.TabIndex = 25;
            this.p_modus.Visible = false;
            // 
            // w_s_automatic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.p_modus);
            this.Controls.Add(this.p_klasse);
            this.Controls.Add(this.mbt_Suche);
            this.Controls.Add(this.a_cb_Klasse);
            this.Controls.Add(this.dp_RueckDatum);
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
            this.Controls.Add(this.lb_Jahr);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "w_s_automatic";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Lehrbuchausgabe";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Schueler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_suggested)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_selected)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msm_automatic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lb_Jahr;
        private MetroFramework.Controls.MetroGrid gv_Schueler;
        private MetroFramework.Controls.MetroGrid gv_suggested;
        private MetroFramework.Controls.MetroGrid gv_selected;
        private MetroFramework.Controls.MetroLabel lb_Anweisung1;
        private AdvancedComboBox a_cb_Modus;
        private MetroFramework.Controls.MetroLabel lb_Schueler;
        private MetroFramework.Controls.MetroLabel lb_suggested;
        private MetroFramework.Controls.MetroLabel lb_selected;
        private MetroFramework.Controls.MetroButton bt_next;
        private MetroFramework.Controls.MetroButton bt_bestaetigen;
        private MetroFramework.Controls.MetroButton bt_abschließen;
        private MetroFramework.Controls.MetroButton bt_back;
        private MetroFramework.Controls.MetroTextBox tb_ExemplarID;
        private MetroFramework.Controls.MetroLabel lb_Klasse;
        private MetroFramework.Controls.MetroDateTime dp_RueckDatum;
        private AdvancedComboBox a_cb_Klasse;
        private MetroFramework.Controls.MetroButton mbt_Suche;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Components.MetroStyleManager msm_automatic;
        private TransparentPanel p_klasse;
        private TransparentPanel p_modus;
    }
}