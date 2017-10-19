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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Security = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_Server = new System.Windows.Forms.Label();
            this.bt_Laden = new System.Windows.Forms.Button();
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_Security);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lb_Server);
            this.groupBox1.Controls.Add(this.bt_Laden);
            this.groupBox1.Controls.Add(this.bt_save);
            this.groupBox1.Controls.Add(this.tb_Database);
            this.groupBox1.Controls.Add(this.lb_Database);
            this.groupBox1.Controls.Add(this.tb_Server);
            this.groupBox1.Controls.Add(this.lb_Security);
            this.groupBox1.Controls.Add(this.lb_Passwort);
            this.groupBox1.Controls.Add(this.bt_Schließen);
            this.groupBox1.Controls.Add(this.tb_Passwort);
            this.groupBox1.Controls.Add(this.lb_Benutzername);
            this.groupBox1.Controls.Add(this.tb_Benutzername);
            this.groupBox1.Location = new System.Drawing.Point(14, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.groupBox1.Size = new System.Drawing.Size(715, 637);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // cb_Security
            // 
            this.cb_Security.FormattingEnabled = true;
            this.cb_Security.Items.AddRange(new object[] {
            "Windows Authentifizierung",
            "SQL Authentifizierung"});
            this.cb_Security.Location = new System.Drawing.Point(259, 160);
            this.cb_Security.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cb_Security.Name = "cb_Security";
            this.cb_Security.Size = new System.Drawing.Size(415, 39);
            this.cb_Security.TabIndex = 3;
            this.cb_Security.TextChanged += new System.EventHandler(this.Visibility);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(437, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 57);
            this.button1.TabIndex = 15;
            this.button1.Text = "Verbindungstest";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_Server
            // 
            this.lb_Server.AutoSize = true;
            this.lb_Server.Location = new System.Drawing.Point(13, 48);
            this.lb_Server.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lb_Server.Name = "lb_Server";
            this.lb_Server.Size = new System.Drawing.Size(106, 32);
            this.lb_Server.TabIndex = 3;
            this.lb_Server.Text = "Server:";
            // 
            // bt_Laden
            // 
            this.bt_Laden.Location = new System.Drawing.Point(485, 336);
            this.bt_Laden.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Laden.Name = "bt_Laden";
            this.bt_Laden.Size = new System.Drawing.Size(192, 57);
            this.bt_Laden.TabIndex = 14;
            this.bt_Laden.Text = "Laden";
            this.bt_Laden.UseVisualStyleBackColor = true;
            this.bt_Laden.Click += new System.EventHandler(this.bt_Load);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(259, 336);
            this.bt_save.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(192, 57);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Speichern";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.Save);
            // 
            // tb_Database
            // 
            this.tb_Database.Location = new System.Drawing.Point(259, 100);
            this.tb_Database.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Database.Name = "tb_Database";
            this.tb_Database.Size = new System.Drawing.Size(415, 38);
            this.tb_Database.TabIndex = 2;
            // 
            // lb_Database
            // 
            this.lb_Database.AutoSize = true;
            this.lb_Database.Location = new System.Drawing.Point(13, 107);
            this.lb_Database.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lb_Database.Name = "lb_Database";
            this.lb_Database.Size = new System.Drawing.Size(161, 32);
            this.lb_Database.TabIndex = 7;
            this.lb_Database.Text = "Datenbank:";
            // 
            // tb_Server
            // 
            this.tb_Server.Location = new System.Drawing.Point(259, 43);
            this.tb_Server.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Server.Name = "tb_Server";
            this.tb_Server.Size = new System.Drawing.Size(415, 38);
            this.tb_Server.TabIndex = 1;
            // 
            // lb_Security
            // 
            this.lb_Security.AutoSize = true;
            this.lb_Security.Location = new System.Drawing.Point(13, 165);
            this.lb_Security.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lb_Security.Name = "lb_Security";
            this.lb_Security.Size = new System.Drawing.Size(151, 32);
            this.lb_Security.TabIndex = 8;
            this.lb_Security.Text = "Sicherheit:";
            // 
            // lb_Passwort
            // 
            this.lb_Passwort.AutoSize = true;
            this.lb_Passwort.Location = new System.Drawing.Point(13, 286);
            this.lb_Passwort.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lb_Passwort.Name = "lb_Passwort";
            this.lb_Passwort.Size = new System.Drawing.Size(139, 32);
            this.lb_Passwort.TabIndex = 13;
            this.lb_Passwort.Text = "Passwort:";
            // 
            // bt_Schließen
            // 
            this.bt_Schließen.Location = new System.Drawing.Point(259, 410);
            this.bt_Schließen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Schließen.Name = "bt_Schließen";
            this.bt_Schließen.Size = new System.Drawing.Size(163, 57);
            this.bt_Schließen.TabIndex = 7;
            this.bt_Schließen.Text = "Leeren";
            this.bt_Schließen.UseVisualStyleBackColor = true;
            this.bt_Schließen.Click += new System.EventHandler(this.Reset);
            // 
            // tb_Passwort
            // 
            this.tb_Passwort.Location = new System.Drawing.Point(259, 279);
            this.tb_Passwort.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Passwort.Name = "tb_Passwort";
            this.tb_Passwort.Size = new System.Drawing.Size(415, 38);
            this.tb_Passwort.TabIndex = 5;
            this.tb_Passwort.UseSystemPasswordChar = true;
            // 
            // lb_Benutzername
            // 
            this.lb_Benutzername.AutoSize = true;
            this.lb_Benutzername.Location = new System.Drawing.Point(13, 227);
            this.lb_Benutzername.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.lb_Benutzername.Name = "lb_Benutzername";
            this.lb_Benutzername.Size = new System.Drawing.Size(208, 32);
            this.lb_Benutzername.TabIndex = 10;
            this.lb_Benutzername.Text = "Benutzername:";
            // 
            // tb_Benutzername
            // 
            this.tb_Benutzername.Location = new System.Drawing.Point(259, 222);
            this.tb_Benutzername.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Benutzername.Name = "tb_Benutzername";
            this.tb_Benutzername.Size = new System.Drawing.Size(415, 38);
            this.tb_Benutzername.TabIndex = 4;
            // 
            // w_s_einstellungen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 663);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_einstellungen";
            this.Text = "Einstellungen";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_Security;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_Server;
        private System.Windows.Forms.Button bt_Laden;
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
    }
}