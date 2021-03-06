﻿namespace Bibo_Verwaltung
{
    partial class w_s_einstellungen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_einstellungen));
            this.lb_Server = new MetroFramework.Controls.MetroLabel();
            this.tb_Database = new MetroFramework.Controls.MetroTextBox();
            this.lb_Database = new MetroFramework.Controls.MetroLabel();
            this.tb_Server = new MetroFramework.Controls.MetroTextBox();
            this.lb_Security = new MetroFramework.Controls.MetroLabel();
            this.lb_Passwort = new MetroFramework.Controls.MetroLabel();
            this.tb_Passwort = new MetroFramework.Controls.MetroTextBox();
            this.lb_Benutzername = new MetroFramework.Controls.MetroLabel();
            this.tb_Benutzername = new MetroFramework.Controls.MetroTextBox();
            this.tLP_Top = new System.Windows.Forms.TableLayoutPanel();
            this.cb_Security = new Bibo_Verwaltung.AdvancedComboBox();
            this.tLP_2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Test = new MetroFramework.Controls.MetroButton();
            this.bt_Save = new MetroFramework.Controls.MetroButton();
            this.bt_Clear = new MetroFramework.Controls.MetroButton();
            this.bt_close = new MetroFramework.Controls.MetroButton();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.tLP_Top.SuspendLayout();
            this.tLP_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Server
            // 
            this.lb_Server.AutoSize = true;
            this.lb_Server.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpProvider.SetHelpString(this.lb_Server, "Servername ihrer Datenbank");
            this.lb_Server.Location = new System.Drawing.Point(3, 3);
            this.lb_Server.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Server.Name = "lb_Server";
            this.helpProvider.SetShowHelp(this.lb_Server, true);
            this.lb_Server.Size = new System.Drawing.Size(146, 19);
            this.lb_Server.TabIndex = 3;
            this.lb_Server.Text = "Server:";
            // 
            // tb_Database
            // 
            // 
            // 
            // 
            this.tb_Database.CustomButton.Image = null;
            this.tb_Database.CustomButton.Location = new System.Drawing.Point(317, 2);
            this.tb_Database.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Database.CustomButton.Name = "";
            this.tb_Database.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Database.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Database.CustomButton.TabIndex = 1;
            this.tb_Database.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Database.CustomButton.UseSelectable = true;
            this.tb_Database.CustomButton.Visible = false;
            this.tb_Database.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Database.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.helpProvider.SetHelpString(this.tb_Database, "Name ihrer Datenbank");
            this.tb_Database.Lines = new string[0];
            this.tb_Database.Location = new System.Drawing.Point(155, 33);
            this.tb_Database.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_Database.MaxLength = 32767;
            this.tb_Database.MinimumSize = new System.Drawing.Size(75, 24);
            this.tb_Database.Name = "tb_Database";
            this.tb_Database.PasswordChar = '\0';
            this.tb_Database.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Database.SelectedText = "";
            this.tb_Database.SelectionLength = 0;
            this.tb_Database.SelectionStart = 0;
            this.tb_Database.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Database, true);
            this.tb_Database.Size = new System.Drawing.Size(339, 24);
            this.tb_Database.Style = MetroFramework.MetroColorStyle.Silver;
            this.tb_Database.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.tb_Database, "Geben Sie hier den Namen Ihrer Datenbank ein.");
            this.tb_Database.UseSelectable = true;
            this.tb_Database.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Database.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_Database
            // 
            this.lb_Database.AutoSize = true;
            this.lb_Database.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpProvider.SetHelpString(this.lb_Database, "Name ihrer Datenbank");
            this.lb_Database.Location = new System.Drawing.Point(3, 33);
            this.lb_Database.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Database.Name = "lb_Database";
            this.helpProvider.SetShowHelp(this.lb_Database, true);
            this.lb_Database.Size = new System.Drawing.Size(146, 19);
            this.lb_Database.TabIndex = 7;
            this.lb_Database.Text = "Datenbank:";
            // 
            // tb_Server
            // 
            this.tb_Server.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_Server.CustomButton.Image = null;
            this.tb_Server.CustomButton.Location = new System.Drawing.Point(317, 2);
            this.tb_Server.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Server.CustomButton.Name = "";
            this.tb_Server.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Server.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Server.CustomButton.TabIndex = 1;
            this.tb_Server.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Server.CustomButton.UseSelectable = true;
            this.tb_Server.CustomButton.Visible = false;
            this.tb_Server.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.helpProvider.SetHelpString(this.tb_Server, "Servername ihrer Datenbank");
            this.tb_Server.Lines = new string[0];
            this.tb_Server.Location = new System.Drawing.Point(155, 3);
            this.tb_Server.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_Server.MaxLength = 32767;
            this.tb_Server.MinimumSize = new System.Drawing.Size(75, 24);
            this.tb_Server.Name = "tb_Server";
            this.tb_Server.PasswordChar = '\0';
            this.tb_Server.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Server.SelectedText = "";
            this.tb_Server.SelectionLength = 0;
            this.tb_Server.SelectionStart = 0;
            this.tb_Server.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Server, true);
            this.tb_Server.Size = new System.Drawing.Size(339, 24);
            this.tb_Server.Style = MetroFramework.MetroColorStyle.Silver;
            this.tb_Server.TabIndex = 1;
            this.metroToolTip1.SetToolTip(this.tb_Server, "  Geben Sie hier den Namen des Servers Ihrer Datenbank ein.");
            this.tb_Server.UseSelectable = true;
            this.tb_Server.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Server.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_Security
            // 
            this.lb_Security.AutoSize = true;
            this.lb_Security.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpProvider.SetHelpString(this.lb_Security, "Authentifizierungsvariante");
            this.lb_Security.Location = new System.Drawing.Point(3, 63);
            this.lb_Security.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Security.Name = "lb_Security";
            this.helpProvider.SetShowHelp(this.lb_Security, true);
            this.lb_Security.Size = new System.Drawing.Size(146, 19);
            this.lb_Security.TabIndex = 8;
            this.lb_Security.Text = "Sicherheit:";
            // 
            // lb_Passwort
            // 
            this.lb_Passwort.AutoSize = true;
            this.lb_Passwort.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Passwort.Location = new System.Drawing.Point(3, 123);
            this.lb_Passwort.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Passwort.Name = "lb_Passwort";
            this.lb_Passwort.Size = new System.Drawing.Size(146, 19);
            this.lb_Passwort.TabIndex = 13;
            this.lb_Passwort.Text = "Passwort:";
            // 
            // tb_Passwort
            // 
            this.tb_Passwort.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_Passwort.CustomButton.Image = null;
            this.tb_Passwort.CustomButton.Location = new System.Drawing.Point(317, 2);
            this.tb_Passwort.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Passwort.CustomButton.Name = "";
            this.tb_Passwort.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Passwort.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Passwort.CustomButton.TabIndex = 1;
            this.tb_Passwort.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Passwort.CustomButton.UseSelectable = true;
            this.tb_Passwort.CustomButton.Visible = false;
            this.tb_Passwort.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_Passwort.Lines = new string[0];
            this.tb_Passwort.Location = new System.Drawing.Point(155, 123);
            this.tb_Passwort.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_Passwort.MaxLength = 32767;
            this.tb_Passwort.MinimumSize = new System.Drawing.Size(75, 24);
            this.tb_Passwort.Name = "tb_Passwort";
            this.tb_Passwort.PasswordChar = '●';
            this.tb_Passwort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Passwort.SelectedText = "";
            this.tb_Passwort.SelectionLength = 0;
            this.tb_Passwort.SelectionStart = 0;
            this.tb_Passwort.ShortcutsEnabled = true;
            this.tb_Passwort.Size = new System.Drawing.Size(339, 24);
            this.tb_Passwort.Style = MetroFramework.MetroColorStyle.Silver;
            this.tb_Passwort.TabIndex = 5;
            this.metroToolTip1.SetToolTip(this.tb_Passwort, "Geben Sie hier Ihren SQL-Passwort ein.");
            this.tb_Passwort.UseSelectable = true;
            this.tb_Passwort.UseSystemPasswordChar = true;
            this.tb_Passwort.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Passwort.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_Benutzername
            // 
            this.lb_Benutzername.AutoSize = true;
            this.lb_Benutzername.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Benutzername.Location = new System.Drawing.Point(3, 93);
            this.lb_Benutzername.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Benutzername.Name = "lb_Benutzername";
            this.lb_Benutzername.Size = new System.Drawing.Size(146, 19);
            this.lb_Benutzername.TabIndex = 10;
            this.lb_Benutzername.Text = "Benutzername:";
            // 
            // tb_Benutzername
            // 
            this.tb_Benutzername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.tb_Benutzername.CustomButton.Image = null;
            this.tb_Benutzername.CustomButton.Location = new System.Drawing.Point(317, 2);
            this.tb_Benutzername.CustomButton.Margin = new System.Windows.Forms.Padding(2);
            this.tb_Benutzername.CustomButton.Name = "";
            this.tb_Benutzername.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Benutzername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Benutzername.CustomButton.TabIndex = 1;
            this.tb_Benutzername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Benutzername.CustomButton.UseSelectable = true;
            this.tb_Benutzername.CustomButton.Visible = false;
            this.tb_Benutzername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_Benutzername.Lines = new string[0];
            this.tb_Benutzername.Location = new System.Drawing.Point(155, 93);
            this.tb_Benutzername.MaximumSize = new System.Drawing.Size(375, 24);
            this.tb_Benutzername.MaxLength = 32767;
            this.tb_Benutzername.MinimumSize = new System.Drawing.Size(75, 24);
            this.tb_Benutzername.Name = "tb_Benutzername";
            this.tb_Benutzername.PasswordChar = '\0';
            this.tb_Benutzername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Benutzername.SelectedText = "";
            this.tb_Benutzername.SelectionLength = 0;
            this.tb_Benutzername.SelectionStart = 0;
            this.tb_Benutzername.ShortcutsEnabled = true;
            this.tb_Benutzername.Size = new System.Drawing.Size(339, 24);
            this.tb_Benutzername.Style = MetroFramework.MetroColorStyle.Silver;
            this.tb_Benutzername.TabIndex = 4;
            this.metroToolTip1.SetToolTip(this.tb_Benutzername, "Geben Sie hier Ihren SQL-Benutzernamen ein.");
            this.tb_Benutzername.UseSelectable = true;
            this.tb_Benutzername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Benutzername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tLP_Top
            // 
            this.tLP_Top.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLP_Top.ColumnCount = 2;
            this.tLP_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.72917F));
            this.tLP_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.27083F));
            this.tLP_Top.Controls.Add(this.tb_Server, 1, 0);
            this.tLP_Top.Controls.Add(this.cb_Security, 1, 2);
            this.tLP_Top.Controls.Add(this.tb_Database, 1, 1);
            this.tLP_Top.Controls.Add(this.lb_Server, 0, 0);
            this.tLP_Top.Controls.Add(this.lb_Database, 0, 1);
            this.tLP_Top.Controls.Add(this.lb_Security, 0, 2);
            this.tLP_Top.Controls.Add(this.tb_Benutzername, 1, 3);
            this.tLP_Top.Controls.Add(this.lb_Benutzername, 0, 3);
            this.tLP_Top.Controls.Add(this.tb_Passwort, 1, 4);
            this.tLP_Top.Controls.Add(this.lb_Passwort, 0, 4);
            this.tLP_Top.Controls.Add(this.tLP_2, 1, 5);
            this.tLP_Top.Controls.Add(this.bt_close, 1, 6);
            this.tLP_Top.Location = new System.Drawing.Point(22, 63);
            this.tLP_Top.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tLP_Top.Name = "tLP_Top";
            this.tLP_Top.RowCount = 7;
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28582F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28582F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28274F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28581F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28582F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28582F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tLP_Top.Size = new System.Drawing.Size(497, 213);
            this.tLP_Top.TabIndex = 0;
            this.tLP_Top.TabStop = true;
            // 
            // cb_Security
            // 
            this.cb_Security.BorderColor = System.Drawing.Color.Gray;
            this.cb_Security.DataRowView = false;
            this.cb_Security.DisplayMember = "1";
            this.cb_Security.Dock = System.Windows.Forms.DockStyle.Top;
            this.cb_Security.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Security.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Security.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Security.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Security, "Authentifizierungsvariante");
            this.cb_Security.HighlightColor = System.Drawing.Color.Gray;
            this.cb_Security.ItemHeight = 18;
            this.cb_Security.Items.AddRange(new object[] {
            "Windows Authentifizierung",
            "SQL Authentifizierung"});
            this.cb_Security.Location = new System.Drawing.Point(155, 63);
            this.cb_Security.Name = "cb_Security";
            this.helpProvider.SetShowHelp(this.cb_Security, true);
            this.cb_Security.Size = new System.Drawing.Size(339, 24);
            this.cb_Security.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.cb_Security, "Wählen Sie hier Ihre gewünschte Authentifizierungsvariante.");
            this.cb_Security.TextChanged += new System.EventHandler(this.Visibility);
            // 
            // tLP_2
            // 
            this.tLP_2.AutoSize = true;
            this.tLP_2.ColumnCount = 3;
            this.tLP_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLP_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLP_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLP_2.Controls.Add(this.bt_Test, 0, 0);
            this.tLP_2.Controls.Add(this.bt_Save, 2, 0);
            this.tLP_2.Controls.Add(this.bt_Clear, 1, 0);
            this.tLP_2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_2.Location = new System.Drawing.Point(152, 150);
            this.tLP_2.Margin = new System.Windows.Forms.Padding(0);
            this.tLP_2.Name = "tLP_2";
            this.tLP_2.RowCount = 1;
            this.tLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_2.Size = new System.Drawing.Size(345, 30);
            this.tLP_2.TabIndex = 6;
            // 
            // bt_Test
            // 
            this.bt_Test.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Test.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Test.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.helpProvider.SetHelpString(this.bt_Test, "Test der Verbindung zu Ihrer Datenbank");
            this.bt_Test.Location = new System.Drawing.Point(3, 3);
            this.bt_Test.MaximumSize = new System.Drawing.Size(225, 24);
            this.bt_Test.MinimumSize = new System.Drawing.Size(38, 24);
            this.bt_Test.Name = "bt_Test";
            this.helpProvider.SetShowHelp(this.bt_Test, true);
            this.bt_Test.Size = new System.Drawing.Size(109, 24);
            this.bt_Test.TabIndex = 6;
            this.bt_Test.Text = "Verbindungstest";
            this.metroToolTip1.SetToolTip(this.bt_Test, " Testen Sie hier die Verbindung zu Ihrer Datenbank.");
            this.bt_Test.UseSelectable = true;
            this.bt_Test.Click += new System.EventHandler(this.TestConnect);
            // 
            // bt_Save
            // 
            this.bt_Save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Save.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Save.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.helpProvider.SetHelpString(this.bt_Save, "Speichern sie alle oben eingetragenen Daten.");
            this.bt_Save.Location = new System.Drawing.Point(233, 3);
            this.bt_Save.MaximumSize = new System.Drawing.Size(150, 24);
            this.bt_Save.MinimumSize = new System.Drawing.Size(38, 24);
            this.bt_Save.Name = "bt_Save";
            this.helpProvider.SetShowHelp(this.bt_Save, true);
            this.bt_Save.Size = new System.Drawing.Size(109, 24);
            this.bt_Save.TabIndex = 8;
            this.bt_Save.Text = "Speichern";
            this.metroToolTip1.SetToolTip(this.bt_Save, " Hier können Sie alle oben eingetragenen Daten speichern.");
            this.bt_Save.UseSelectable = true;
            this.bt_Save.Click += new System.EventHandler(this.SetSettings);
            // 
            // bt_Clear
            // 
            this.bt_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Clear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Clear.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.helpProvider.SetHelpString(this.bt_Clear, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_Clear.Location = new System.Drawing.Point(118, 3);
            this.bt_Clear.MaximumSize = new System.Drawing.Size(150, 24);
            this.bt_Clear.MinimumSize = new System.Drawing.Size(38, 24);
            this.bt_Clear.Name = "bt_Clear";
            this.helpProvider.SetShowHelp(this.bt_Clear, true);
            this.bt_Clear.Size = new System.Drawing.Size(109, 24);
            this.bt_Clear.TabIndex = 7;
            this.bt_Clear.Text = "Leeren";
            this.metroToolTip1.SetToolTip(this.bt_Clear, " Hier können Sie alle oben liegenden Textfelder leeren.");
            this.bt_Clear.UseSelectable = true;
            this.bt_Clear.Click += new System.EventHandler(this.ClearAll);
            // 
            // bt_close
            // 
            this.bt_close.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_close.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_close.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.bt_close.Location = new System.Drawing.Point(155, 183);
            this.bt_close.MaximumSize = new System.Drawing.Size(500, 24);
            this.bt_close.Name = "bt_close";
            this.bt_close.Size = new System.Drawing.Size(339, 24);
            this.bt_close.TabIndex = 9;
            this.bt_close.Text = "Schließen";
            this.bt_close.UseSelectable = true;
            this.bt_close.Click += new System.EventHandler(this.Bt_close_Click);
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // metroLink1
            // 
            this.metroLink1.Image = global::Bibo_Verwaltung.Properties.Resources.Settings;
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(23, 19);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(32, 34);
            this.metroLink1.TabIndex = 19;
            this.metroLink1.TabStop = false;
            this.metroLink1.UseSelectable = true;
            // 
            // w_s_einstellungen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(538, 284);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.tLP_Top);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "w_s_einstellungen";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "      Einstellungen";
            this.tLP_Top.ResumeLayout(false);
            this.tLP_Top.PerformLayout();
            this.tLP_2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private AdvancedComboBox cb_Security;
        private MetroFramework.Controls.MetroLabel lb_Server;
        private MetroFramework.Controls.MetroTextBox tb_Database;
        private MetroFramework.Controls.MetroLabel lb_Database;
        private MetroFramework.Controls.MetroTextBox tb_Server;
        private MetroFramework.Controls.MetroLabel lb_Security;
        private MetroFramework.Controls.MetroLabel lb_Passwort;
        private MetroFramework.Controls.MetroTextBox tb_Passwort;
        private MetroFramework.Controls.MetroLabel lb_Benutzername;
        private MetroFramework.Controls.MetroTextBox tb_Benutzername;
        private System.Windows.Forms.TableLayoutPanel tLP_Top;
        private System.Windows.Forms.TableLayoutPanel tLP_2;
        private MetroFramework.Controls.MetroButton bt_Clear;
        private MetroFramework.Controls.MetroButton bt_Test;
        private MetroFramework.Controls.MetroButton bt_Save;
        private System.Windows.Forms.HelpProvider helpProvider;
        private MetroFramework.Controls.MetroLink metroLink1;
        private MetroFramework.Controls.MetroButton bt_close;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}
