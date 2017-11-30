namespace Bibo_Verwaltung
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
            this.cb_Security = new System.Windows.Forms.ComboBox();
            this.lb_Server = new System.Windows.Forms.Label();
            this.tb_Database = new System.Windows.Forms.TextBox();
            this.lb_Database = new System.Windows.Forms.Label();
            this.tb_Server = new System.Windows.Forms.TextBox();
            this.lb_Security = new System.Windows.Forms.Label();
            this.lb_Passwort = new System.Windows.Forms.Label();
            this.tb_Passwort = new System.Windows.Forms.TextBox();
            this.lb_Benutzername = new System.Windows.Forms.Label();
            this.tb_Benutzername = new System.Windows.Forms.TextBox();
            this.tLP_Top = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.bt_Schließen = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.tLP_Top.SuspendLayout();
            this.tLP_2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Security
            // 
            this.cb_Security.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Security.FormattingEnabled = true;
            this.helpProvider.SetHelpString(this.cb_Security, "Authentifizierungsvariante");
            this.cb_Security.Items.AddRange(new object[] {
            "Windows Authentifizierung",
            "SQL Authentifizierung"});
            this.cb_Security.Location = new System.Drawing.Point(121, 86);
            this.cb_Security.Name = "cb_Security";
            this.helpProvider.SetShowHelp(this.cb_Security, true);
            this.cb_Security.Size = new System.Drawing.Size(260, 21);
            this.cb_Security.TabIndex = 3;
            this.cb_Security.TextChanged += new System.EventHandler(this.Visibility);
            // 
            // lb_Server
            // 
            this.lb_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Server.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Server, "Servername ihrer Datenbank");
            this.lb_Server.Location = new System.Drawing.Point(3, 12);
            this.lb_Server.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Server.Name = "lb_Server";
            this.helpProvider.SetShowHelp(this.lb_Server, true);
            this.lb_Server.Size = new System.Drawing.Size(112, 15);
            this.lb_Server.TabIndex = 3;
            this.lb_Server.Text = "Server:";
            // 
            // tb_Database
            // 
            this.tb_Database.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.tb_Database, "Name ihrer Datenbank");
            this.tb_Database.Location = new System.Drawing.Point(121, 48);
            this.tb_Database.Name = "tb_Database";
            this.helpProvider.SetShowHelp(this.tb_Database, true);
            this.tb_Database.Size = new System.Drawing.Size(260, 20);
            this.tb_Database.TabIndex = 2;
            // 
            // lb_Database
            // 
            this.lb_Database.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Database.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Database, "Name ihrer Datenbank");
            this.lb_Database.Location = new System.Drawing.Point(3, 51);
            this.lb_Database.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Database.Name = "lb_Database";
            this.helpProvider.SetShowHelp(this.lb_Database, true);
            this.lb_Database.Size = new System.Drawing.Size(112, 15);
            this.lb_Database.TabIndex = 7;
            this.lb_Database.Text = "Datenbank:";
            // 
            // tb_Server
            // 
            this.tb_Server.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.tb_Server, "Servername ihrer Datenbank");
            this.tb_Server.Location = new System.Drawing.Point(121, 9);
            this.tb_Server.Name = "tb_Server";
            this.helpProvider.SetShowHelp(this.tb_Server, true);
            this.tb_Server.Size = new System.Drawing.Size(260, 20);
            this.tb_Server.TabIndex = 1;
            // 
            // lb_Security
            // 
            this.lb_Security.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Security.AutoSize = true;
            this.helpProvider.SetHelpString(this.lb_Security, "Authentifizierungsvariante");
            this.lb_Security.Location = new System.Drawing.Point(3, 90);
            this.lb_Security.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Security.Name = "lb_Security";
            this.helpProvider.SetShowHelp(this.lb_Security, true);
            this.lb_Security.Size = new System.Drawing.Size(112, 15);
            this.lb_Security.TabIndex = 8;
            this.lb_Security.Text = "Sicherheit:";
            // 
            // lb_Passwort
            // 
            this.lb_Passwort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Passwort.AutoSize = true;
            this.lb_Passwort.Location = new System.Drawing.Point(3, 168);
            this.lb_Passwort.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Passwort.Name = "lb_Passwort";
            this.lb_Passwort.Size = new System.Drawing.Size(112, 15);
            this.lb_Passwort.TabIndex = 13;
            this.lb_Passwort.Text = "Passwort:";
            // 
            // tb_Passwort
            // 
            this.tb_Passwort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Passwort.Location = new System.Drawing.Point(121, 165);
            this.tb_Passwort.Name = "tb_Passwort";
            this.tb_Passwort.Size = new System.Drawing.Size(260, 20);
            this.tb_Passwort.TabIndex = 5;
            this.tb_Passwort.UseSystemPasswordChar = true;
            // 
            // lb_Benutzername
            // 
            this.lb_Benutzername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Benutzername.AutoSize = true;
            this.lb_Benutzername.Location = new System.Drawing.Point(3, 129);
            this.lb_Benutzername.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Benutzername.Name = "lb_Benutzername";
            this.lb_Benutzername.Size = new System.Drawing.Size(112, 15);
            this.lb_Benutzername.TabIndex = 10;
            this.lb_Benutzername.Text = "Benutzername:";
            // 
            // tb_Benutzername
            // 
            this.tb_Benutzername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Benutzername.Location = new System.Drawing.Point(121, 126);
            this.tb_Benutzername.Name = "tb_Benutzername";
            this.tb_Benutzername.Size = new System.Drawing.Size(260, 20);
            this.tb_Benutzername.TabIndex = 4;
            // 
            // tLP_Top
            // 
            this.tLP_Top.ColumnCount = 2;
            this.tLP_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.72917F));
            this.tLP_Top.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.27083F));
            this.tLP_Top.Controls.Add(this.tb_Server, 1, 0);
            this.tLP_Top.Controls.Add(this.cb_Security, 1, 2);
            this.tLP_Top.Controls.Add(this.lb_Server, 0, 0);
            this.tLP_Top.Controls.Add(this.tb_Database, 1, 1);
            this.tLP_Top.Controls.Add(this.lb_Database, 0, 1);
            this.tLP_Top.Controls.Add(this.lb_Security, 0, 2);
            this.tLP_Top.Controls.Add(this.tb_Benutzername, 1, 3);
            this.tLP_Top.Controls.Add(this.lb_Benutzername, 0, 3);
            this.tLP_Top.Controls.Add(this.tb_Passwort, 1, 4);
            this.tLP_Top.Controls.Add(this.lb_Passwort, 0, 4);
            this.tLP_Top.Controls.Add(this.tLP_2, 1, 5);
            this.tLP_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Top.Location = new System.Drawing.Point(0, 0);
            this.tLP_Top.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tLP_Top.Name = "tLP_Top";
            this.tLP_Top.RowCount = 6;
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tLP_Top.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP_Top.Size = new System.Drawing.Size(384, 236);
            this.tLP_Top.TabIndex = 18;
            // 
            // tLP_2
            // 
            this.tLP_2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLP_2.AutoSize = true;
            this.tLP_2.ColumnCount = 3;
            this.tLP_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tLP_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tLP_2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tLP_2.Controls.Add(this.button1, 0, 0);
            this.tLP_2.Controls.Add(this.bt_save, 2, 0);
            this.tLP_2.Controls.Add(this.bt_Schließen, 1, 0);
            this.tLP_2.Location = new System.Drawing.Point(121, 198);
            this.tLP_2.Name = "tLP_2";
            this.tLP_2.RowCount = 1;
            this.tLP_2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_2.Size = new System.Drawing.Size(260, 35);
            this.tLP_2.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.button1, "Testen sie ihre Verbindung zu ihrer Datenbank.");
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.helpProvider.SetShowHelp(this.button1, true);
            this.button1.Size = new System.Drawing.Size(98, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Verbindungstest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt_save
            // 
            this.bt_save.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.bt_save, "Speichern sie alle oben eingetragenen Daten.");
            this.bt_save.Location = new System.Drawing.Point(185, 3);
            this.bt_save.Name = "bt_save";
            this.helpProvider.SetShowHelp(this.bt_save, true);
            this.bt_save.Size = new System.Drawing.Size(72, 29);
            this.bt_save.TabIndex = 7;
            this.bt_save.Text = "Speichern";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.Save);
            // 
            // bt_Schließen
            // 
            this.bt_Schließen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.helpProvider.SetHelpString(this.bt_Schließen, "Leeren sie alle oben liegenden Textfelder.");
            this.bt_Schließen.Location = new System.Drawing.Point(107, 3);
            this.bt_Schließen.Name = "bt_Schließen";
            this.helpProvider.SetShowHelp(this.bt_Schließen, true);
            this.bt_Schließen.Size = new System.Drawing.Size(72, 29);
            this.bt_Schließen.TabIndex = 7;
            this.bt_Schließen.Text = "Leeren";
            this.bt_Schließen.UseVisualStyleBackColor = true;
            this.bt_Schließen.Click += new System.EventHandler(this.Reset);
            // 
            // w_s_einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 236);
            this.Controls.Add(this.tLP_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_einstellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
            this.tLP_Top.ResumeLayout(false);
            this.tLP_Top.PerformLayout();
            this.tLP_2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_Security;
        private System.Windows.Forms.Label lb_Server;
        private System.Windows.Forms.TextBox tb_Database;
        private System.Windows.Forms.Label lb_Database;
        private System.Windows.Forms.TextBox tb_Server;
        private System.Windows.Forms.Label lb_Security;
        private System.Windows.Forms.Label lb_Passwort;
        private System.Windows.Forms.TextBox tb_Passwort;
        private System.Windows.Forms.Label lb_Benutzername;
        private System.Windows.Forms.TextBox tb_Benutzername;
        private System.Windows.Forms.TableLayoutPanel tLP_Top;
        private System.Windows.Forms.TableLayoutPanel tLP_2;
        private System.Windows.Forms.Button bt_Schließen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}