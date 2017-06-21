using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Bibo_Verwaltung
{
    public partial class w_s_Einstellungen : Form
    {
        string Pfad = "C:/Users/Anwender/Documents/Einstellungen.txt";
        public w_s_Einstellungen()
        {
            InitializeComponent();
            Load();
        }

        private bool File_Exists()
        {
            if (File.Exists(Pfad))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region FileHandling
        private void Save(object sender, EventArgs e)
        {
            // combobox nimmt den ausgewählten Wert an
            cb_Security.Select();
            //Auslesen und Variablen beschreiben
            string server = tb_Server.Text;
            string database = tb_Database.Text;
            string security = cb_Security.Text;
            string name = tb_Benutzername.Text;
            string pw = tb_Passwort.Text;

            if (server != "" && database != "" && security != "")
            {
                File.WriteAllText(Pfad, server + "\r\n" + database + "\r\n" + security + "\r\n" + name + "\r\n" + pw);
                MessageBox.Show("Speichern erfolgreich!");
            }
            else
            {
                Error_Handling();
            }

        }
        
        
        private void Load()
        {
            if (!File_Exists())
            {
                File.WriteAllText(Pfad, "\r\n\r\n\r\n\r\n\r\n");
            }
            //alle Zeilen lesen
            var zeilen = File.ReadLines(Pfad);
            //Zeichen in die Textboxen füllen
            if (zeilen.Count() >= 1) tb_Server.Text = zeilen.First();
            if (zeilen.Count() >= 2) tb_Database.Text = zeilen.Skip(1).First();
            if (zeilen.Count() >= 4) tb_Benutzername.Text = zeilen.Skip(3).First();
            if (zeilen.Count() >= 5) tb_Passwort.Text = zeilen.Skip(4).First();

            
            if(zeilen.Count() >= 3)
            {
                if (zeilen.Skip(2).First() == "Windows Authentifizierung")
                {
                    cb_Security.SelectedItem = "Windows Authentifizierung";
                }
                else if (zeilen.Skip(2).First() == "SQL Authentifizierung")
                {
                    cb_Security.SelectedItem = "SQL Authentifizierung";
                }
                else
                {
                    MessageBox.Show("Unbekannte Authentifizierungsart. Windows Authentifizierung wurde ausgewählt");
                    cb_Security.SelectedItem = "Windows Authentifizierung";
                }
            }
            
        }
        #endregion


        private void Error_Handling()
        {
            if (tb_Server.Text == "" || tb_Database.Text == "" || cb_Security.Text == "")
            {
                tb_Server.BackColor = Color.Red;
                tb_Database.BackColor = Color.Red;
                cb_Security.BackColor = Color.Red;
                tb_Benutzername.BackColor = Color.Red;
                tb_Passwort.BackColor = Color.Red;
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
            }
        }
        
        #region Buttons
        private void Reset(object sender, EventArgs e)
        {
            tb_Server.Text = "";
            tb_Database.Text = "";
            cb_Security.Text = "";
            tb_Benutzername.Text = "";
            tb_Passwort.Text = "";
        }
        private void tb_White(object sender, EventArgs e)
        {
            tb_Database.BackColor = Color.White;
            tb_Server.BackColor = Color.White;
            tb_Benutzername.BackColor = Color.White;
            tb_Passwort.BackColor = Color.White;
            cb_Security.BackColor = Color.White;
        }
        private void Visible(object sender, EventArgs e)
        {
            if(cb_Security.Text == "Windows Authentifizierung")
            {
                tb_Benutzername.Visible = false;
                lb_Benutzername.Visible = false;
                tb_Passwort.Visible = false;
                lb_Passwort.Visible = false;
            }
            else if(cb_Security.Text == "SQL Authentifizierung")
            {
                tb_Benutzername.Visible = true;
                lb_Benutzername.Visible = true;
                tb_Passwort.Visible = true;
                lb_Passwort.Visible = true;
            }
        }
        private void Laden(object sender, EventArgs e)
        {
            Load();
        }
        #endregion


        #region Fenster
        private void InitializeComponent()
        {
            this.lb_Server = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.cb_Security = new System.Windows.Forms.ComboBox();
            this.lb_Database = new System.Windows.Forms.Label();
            this.lb_Security = new System.Windows.Forms.Label();
            this.bt_Schließen = new System.Windows.Forms.Button();
            this.lb_Benutzername = new System.Windows.Forms.Label();
            this.tb_Benutzername = new System.Windows.Forms.TextBox();
            this.tb_Passwort = new System.Windows.Forms.TextBox();
            this.lb_Passwort = new System.Windows.Forms.Label();
            this.tb_Server = new System.Windows.Forms.TextBox();
            this.tb_Database = new System.Windows.Forms.TextBox();
            this.bt_Laden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_Server
            // 
            this.lb_Server.AutoSize = true;
            this.lb_Server.Location = new System.Drawing.Point(44, 33);
            this.lb_Server.Name = "lb_Server";
            this.lb_Server.Size = new System.Drawing.Size(38, 13);
            this.lb_Server.TabIndex = 3;
            this.lb_Server.Text = "Server";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(174, 226);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Speichern";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.Save);
            // 
            // cb_Security
            // 
            this.cb_Security.FormattingEnabled = true;
            this.cb_Security.Items.AddRange(new object[] {
            "Windows Authentifizierung",
            "SQL Authentifizierung"});
            this.cb_Security.Location = new System.Drawing.Point(93, 112);
            this.cb_Security.Name = "cb_Security";
            this.cb_Security.Size = new System.Drawing.Size(121, 21);
            this.cb_Security.TabIndex = 3;
            this.cb_Security.TextChanged += new System.EventHandler(this.Visible);
            this.cb_Security.Click += new System.EventHandler(this.Visible);
            // 
            // lb_Database
            // 
            this.lb_Database.AutoSize = true;
            this.lb_Database.Location = new System.Drawing.Point(34, 74);
            this.lb_Database.Name = "lb_Database";
            this.lb_Database.Size = new System.Drawing.Size(53, 13);
            this.lb_Database.TabIndex = 7;
            this.lb_Database.Text = "Database";
            // 
            // lb_Security
            // 
            this.lb_Security.AutoSize = true;
            this.lb_Security.Location = new System.Drawing.Point(41, 115);
            this.lb_Security.Name = "lb_Security";
            this.lb_Security.Size = new System.Drawing.Size(45, 13);
            this.lb_Security.TabIndex = 8;
            this.lb_Security.Text = "Security";
            // 
            // bt_Schließen
            // 
            this.bt_Schließen.Location = new System.Drawing.Point(12, 226);
            this.bt_Schließen.Name = "bt_Schließen";
            this.bt_Schließen.Size = new System.Drawing.Size(75, 23);
            this.bt_Schließen.TabIndex = 7;
            this.bt_Schließen.Text = "Reset";
            this.bt_Schließen.UseVisualStyleBackColor = true;
            this.bt_Schließen.Click += new System.EventHandler(this.Reset);
            // 
            // lb_Benutzername
            // 
            this.lb_Benutzername.AutoSize = true;
            this.lb_Benutzername.Location = new System.Drawing.Point(9, 164);
            this.lb_Benutzername.Name = "lb_Benutzername";
            this.lb_Benutzername.Size = new System.Drawing.Size(75, 13);
            this.lb_Benutzername.TabIndex = 10;
            this.lb_Benutzername.Text = "Benutzername";
            // 
            // tb_Benutzername
            // 
            this.tb_Benutzername.Location = new System.Drawing.Point(93, 161);
            this.tb_Benutzername.Name = "tb_Benutzername";
            this.tb_Benutzername.Size = new System.Drawing.Size(121, 20);
            this.tb_Benutzername.TabIndex = 4;
            this.tb_Benutzername.Click += new System.EventHandler(this.Visible);
            this.tb_Benutzername.TextChanged += new System.EventHandler(this.tb_White);
            // 
            // tb_Passwort
            // 
            this.tb_Passwort.Location = new System.Drawing.Point(93, 187);
            this.tb_Passwort.Name = "tb_Passwort";
            this.tb_Passwort.Size = new System.Drawing.Size(121, 20);
            this.tb_Passwort.TabIndex = 5;
            this.tb_Passwort.Click += new System.EventHandler(this.Visible);
            this.tb_Passwort.TextChanged += new System.EventHandler(this.tb_White);
            // 
            // lb_Passwort
            // 
            this.lb_Passwort.AutoSize = true;
            this.lb_Passwort.Location = new System.Drawing.Point(32, 190);
            this.lb_Passwort.Name = "lb_Passwort";
            this.lb_Passwort.Size = new System.Drawing.Size(50, 13);
            this.lb_Passwort.TabIndex = 13;
            this.lb_Passwort.Text = "Passwort";
            // 
            // tb_Server
            // 
            this.tb_Server.Location = new System.Drawing.Point(93, 33);
            this.tb_Server.Name = "tb_Server";
            this.tb_Server.Size = new System.Drawing.Size(121, 20);
            this.tb_Server.TabIndex = 1;
            this.tb_Server.Click += new System.EventHandler(this.Visible);
            this.tb_Server.TextChanged += new System.EventHandler(this.tb_White);
            // 
            // tb_Database
            // 
            this.tb_Database.Location = new System.Drawing.Point(93, 71);
            this.tb_Database.Name = "tb_Database";
            this.tb_Database.Size = new System.Drawing.Size(121, 20);
            this.tb_Database.TabIndex = 2;
            this.tb_Database.Click += new System.EventHandler(this.Visible);
            this.tb_Database.TextChanged += new System.EventHandler(this.tb_White);
            // 
            // bt_Laden
            // 
            this.bt_Laden.Location = new System.Drawing.Point(93, 226);
            this.bt_Laden.Name = "bt_Laden";
            this.bt_Laden.Size = new System.Drawing.Size(75, 23);
            this.bt_Laden.TabIndex = 14;
            this.bt_Laden.Text = "Laden";
            this.bt_Laden.UseVisualStyleBackColor = true;
            this.bt_Laden.Click += new System.EventHandler(this.Laden);
            // 
            // w_s_Einstellungen
            // 
            this.ClientSize = new System.Drawing.Size(249, 261);
            this.Controls.Add(this.bt_Laden);
            this.Controls.Add(this.tb_Database);
            this.Controls.Add(this.tb_Server);
            this.Controls.Add(this.lb_Passwort);
            this.Controls.Add(this.tb_Passwort);
            this.Controls.Add(this.tb_Benutzername);
            this.Controls.Add(this.lb_Benutzername);
            this.Controls.Add(this.bt_Schließen);
            this.Controls.Add(this.lb_Security);
            this.Controls.Add(this.lb_Database);
            this.Controls.Add(this.cb_Security);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.lb_Server);
            this.Name = "w_s_Einstellungen";
            this.Click += new System.EventHandler(this.Visible);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        
    }
}

