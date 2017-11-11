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
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Server = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.tb_Database = new System.Windows.Forms.TextBox();
            this.lb_Database = new System.Windows.Forms.Label();
            this.tb_Server = new System.Windows.Forms.TextBox();
            this.lb_Security = new System.Windows.Forms.Label();
            this.lb_Passwort = new System.Windows.Forms.Label();
            this.bt_Schließen = new System.Windows.Forms.Button();
            this.tb_Passwort = new System.Windows.Forms.TextBox();
            this.lb_Benutzername = new System.Windows.Forms.Label();
            this.tb_Benutzername = new System.Windows.Forms.TextBox();
            this.tLP = new System.Windows.Forms.TableLayoutPanel();
            this.tLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // cb_Security
            // 
            this.cb_Security.FormattingEnabled = true;
            this.cb_Security.Items.AddRange(new object[] {
            "Windows Authentifizierung",
            "SQL Authentifizierung"});
            this.cb_Security.Location = new System.Drawing.Point(435, 140);
            this.cb_Security.Margin = new System.Windows.Forms.Padding(8);
            this.cb_Security.Name = "cb_Security";
            this.cb_Security.Size = new System.Drawing.Size(408, 39);
            this.cb_Security.TabIndex = 3;
            this.cb_Security.TextChanged += new System.EventHandler(this.Visibility);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 51);
            this.button1.TabIndex = 15;
            this.button1.Text = "Verbindungstest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Server
            // 
            this.lb_Server.AutoSize = true;
            this.lb_Server.Location = new System.Drawing.Point(8, 8);
            this.lb_Server.Margin = new System.Windows.Forms.Padding(8);
            this.lb_Server.Name = "lb_Server";
            this.lb_Server.Size = new System.Drawing.Size(106, 32);
            this.lb_Server.TabIndex = 3;
            this.lb_Server.Text = "Server:";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(8, 338);
            this.bt_save.Margin = new System.Windows.Forms.Padding(8);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(410, 50);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Speichern";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.Save);
            // 
            // tb_Database
            // 
            this.tb_Database.Location = new System.Drawing.Point(435, 74);
            this.tb_Database.Margin = new System.Windows.Forms.Padding(8);
            this.tb_Database.Name = "tb_Database";
            this.tb_Database.Size = new System.Drawing.Size(408, 38);
            this.tb_Database.TabIndex = 2;
            // 
            // lb_Database
            // 
            this.lb_Database.AutoSize = true;
            this.lb_Database.Location = new System.Drawing.Point(8, 74);
            this.lb_Database.Margin = new System.Windows.Forms.Padding(8);
            this.lb_Database.Name = "lb_Database";
            this.lb_Database.Size = new System.Drawing.Size(161, 32);
            this.lb_Database.TabIndex = 7;
            this.lb_Database.Text = "Datenbank:";
            // 
            // tb_Server
            // 
            this.tb_Server.Location = new System.Drawing.Point(435, 8);
            this.tb_Server.Margin = new System.Windows.Forms.Padding(8);
            this.tb_Server.Name = "tb_Server";
            this.tb_Server.Size = new System.Drawing.Size(408, 38);
            this.tb_Server.TabIndex = 1;
            // 
            // lb_Security
            // 
            this.lb_Security.AutoSize = true;
            this.lb_Security.Location = new System.Drawing.Point(8, 140);
            this.lb_Security.Margin = new System.Windows.Forms.Padding(8);
            this.lb_Security.Name = "lb_Security";
            this.lb_Security.Size = new System.Drawing.Size(151, 32);
            this.lb_Security.TabIndex = 8;
            this.lb_Security.Text = "Sicherheit:";
            // 
            // lb_Passwort
            // 
            this.lb_Passwort.AutoSize = true;
            this.lb_Passwort.Location = new System.Drawing.Point(8, 272);
            this.lb_Passwort.Margin = new System.Windows.Forms.Padding(8);
            this.lb_Passwort.Name = "lb_Passwort";
            this.lb_Passwort.Size = new System.Drawing.Size(139, 32);
            this.lb_Passwort.TabIndex = 13;
            this.lb_Passwort.Text = "Passwort:";
            // 
            // bt_Schließen
            // 
            this.bt_Schließen.Location = new System.Drawing.Point(435, 404);
            this.bt_Schließen.Margin = new System.Windows.Forms.Padding(8);
            this.bt_Schließen.Name = "bt_Schließen";
            this.bt_Schließen.Size = new System.Drawing.Size(411, 51);
            this.bt_Schließen.TabIndex = 7;
            this.bt_Schließen.Text = "Leeren";
            this.bt_Schließen.UseVisualStyleBackColor = true;
            this.bt_Schließen.Click += new System.EventHandler(this.Reset);
            // 
            // tb_Passwort
            // 
            this.tb_Passwort.Location = new System.Drawing.Point(435, 272);
            this.tb_Passwort.Margin = new System.Windows.Forms.Padding(8);
            this.tb_Passwort.Name = "tb_Passwort";
            this.tb_Passwort.Size = new System.Drawing.Size(408, 38);
            this.tb_Passwort.TabIndex = 5;
            this.tb_Passwort.UseSystemPasswordChar = true;
            // 
            // lb_Benutzername
            // 
            this.lb_Benutzername.AutoSize = true;
            this.lb_Benutzername.Location = new System.Drawing.Point(8, 206);
            this.lb_Benutzername.Margin = new System.Windows.Forms.Padding(8);
            this.lb_Benutzername.Name = "lb_Benutzername";
            this.lb_Benutzername.Size = new System.Drawing.Size(208, 32);
            this.lb_Benutzername.TabIndex = 10;
            this.lb_Benutzername.Text = "Benutzername:";
            // 
            // tb_Benutzername
            // 
            this.tb_Benutzername.Location = new System.Drawing.Point(435, 206);
            this.tb_Benutzername.Margin = new System.Windows.Forms.Padding(8);
            this.tb_Benutzername.Name = "tb_Benutzername";
            this.tb_Benutzername.Size = new System.Drawing.Size(408, 38);
            this.tb_Benutzername.TabIndex = 4;
            // 
            // tLP
            // 
            this.tLP.ColumnCount = 2;
            this.tLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP.Controls.Add(this.tb_Server, 1, 0);
            this.tLP.Controls.Add(this.cb_Security, 1, 2);
            this.tLP.Controls.Add(this.lb_Server, 0, 0);
            this.tLP.Controls.Add(this.button1, 0, 6);
            this.tLP.Controls.Add(this.tb_Database, 1, 1);
            this.tLP.Controls.Add(this.lb_Database, 0, 1);
            this.tLP.Controls.Add(this.bt_save, 0, 5);
            this.tLP.Controls.Add(this.lb_Security, 0, 2);
            this.tLP.Controls.Add(this.tb_Benutzername, 1, 3);
            this.tLP.Controls.Add(this.lb_Benutzername, 0, 3);
            this.tLP.Controls.Add(this.bt_Schließen, 1, 6);
            this.tLP.Controls.Add(this.tb_Passwort, 1, 4);
            this.tLP.Controls.Add(this.lb_Passwort, 0, 4);
            this.tLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP.Location = new System.Drawing.Point(0, 0);
            this.tLP.Margin = new System.Windows.Forms.Padding(6);
            this.tLP.Name = "tLP";
            this.tLP.RowCount = 7;
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tLP.Size = new System.Drawing.Size(854, 463);
            this.tLP.TabIndex = 18;
            // 
            // w_s_einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 463);
            this.Controls.Add(this.tLP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_einstellungen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
            this.tLP.ResumeLayout(false);
            this.tLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_Security;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_Server;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.TextBox tb_Database;
        private System.Windows.Forms.Label lb_Database;
        private System.Windows.Forms.TextBox tb_Server;
        private System.Windows.Forms.Label lb_Security;
        private System.Windows.Forms.Label lb_Passwort;
        private System.Windows.Forms.Button bt_Schließen;
        private System.Windows.Forms.TextBox tb_Passwort;
        private System.Windows.Forms.Label lb_Benutzername;
        private System.Windows.Forms.TextBox tb_Benutzername;
        private System.Windows.Forms.TableLayoutPanel tLP;
    }
}