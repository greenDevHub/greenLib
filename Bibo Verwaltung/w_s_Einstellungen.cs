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

namespace Bibo_Verwaltung
{
    public partial class w_s_Einstellungen : Form
    {
        public w_s_Einstellungen()
        {
            InitializeComponent();
            System.IO.File.AppendAllText("C:/Users/Anwender/Documents/Einstellungen.txt", "\r\na\r\na\r\na");
            System.IO.File.AppendAllText("C:/Users/Anwender/Documents/Geheim.txt", "Name\r\nPW");
            w_s_Einstellungen_Load();
        }

        #region Server
        private void w_s_Server()
        {
            System.IO.File.WriteAllText("C:/Users/Anwender/Documents/Einstellungen.txt", "Data Source=.\\SQLEXPRESS\r\n");
        }
        #endregion
        #region Database
        private void w_s_Database()
        {
            System.IO.File.AppendAllText("C:/Users/Anwender/Documents/Einstellungen.txt", "Initial Catalog=Bibo_Verwaltung\r\n");
        }
        #endregion
        #region Security

        private void Security_true()
        {
            System.IO.File.AppendAllText("C:/Users/Anwender/Documents/Einstellungen.txt", "Integrated Security=true\r\n");
        }
        private void Security_false()
        {
            System.IO.File.AppendAllText("C:/Users/Anwender/Documents/Einstellungen.txt", "Integrated Security=false\r\n");
            Benutzer_Passwort();
        }
        #endregion
        #region Save
        private void w_s_Einstellungen_Save(object sender, EventArgs e)
        {
            comboBox1.Select();
            w_s_Server();
            comboBox2.Select();
            w_s_Database();
            comboBox3.Select();
            if (comboBox3.Text == "Windows Authentifizierung")
            {
                Security_true();
            }
            else if (comboBox3.Text == "SQL Authentifizierung")
            {
                Security_false();
            }
            Fehlerbehandlung();

        }
        #endregion
        #region Load
        private void w_s_Einstellungen_Load()
        {
            var zeilen = System.IO.File.ReadLines("C:/Users/Anwender/Documents/Einstellungen.txt");

            if (zeilen.First() == "Data Source=.\\SQLEXPRESS")
            {
                comboBox1.SelectedItem = ".\\SQLEXPRESS";
            }
            if (zeilen.Skip(1).First() == "Initial Catalog=Bibo_Verwaltung")
            {
                comboBox2.SelectedItem = "BiboVerwaltung";
            }
            if (zeilen.Skip(2).First() == "Integrated Security=true")
            {
                comboBox3.SelectedItem = "Windows Authentifizierung";
            }
            else if (zeilen.Skip(2).First() == "Integrated Security=false")
            {
                comboBox3.SelectedItem = "SQL Authentifizierung";
            }
        }
        #endregion
        #region Benutzername+Passwort
        private void Benutzer_Passwort()
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            var zeilen = System.IO.File.ReadLines("C:/Users/Anwender/Documents/Geheim.txt");
            if (zeilen.First() == a && zeilen.Skip(1).First() == b)
            {
            }
            else
            {
                MessageBox.Show("Überprüfen Sie Ihre Eingabe");
                System.IO.File.Delete("C:/Users/Anwender/Documents/Einstellungen.txt");

            }
        }
        #endregion
        private void Reset(object sender, EventArgs e)
        {
            System.IO.File.Delete("C:/Users/Anwender/Documents/Einstellungen.txt");
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }
        private void Combobox_White(object sender, EventArgs e)
        {
            comboBox1.BackColor = Color.White;
            comboBox2.BackColor = Color.White;
            comboBox3.BackColor = Color.White;
        }
        private void Fehlerbehandlung()
        {
            if(comboBox1.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
            {
                MessageBox.Show("Bitte füllen Sie alle Felder aus");
                comboBox1.BackColor = Color.Red;
                comboBox2.BackColor = Color.Red;
                comboBox3.BackColor = Color.Red;
                System.IO.File.Delete("C:/Users/Anwender/Documents/Einstellungen.txt");
            }
        }
        #region Fenster
        private void InitializeComponent()
        {
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cb_Server = new System.Windows.Forms.Label();
            this.bt_save = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.cb_Database = new System.Windows.Forms.Label();
            this.cb_Security = new System.Windows.Forms.Label();
            this.b_Schließen = new System.Windows.Forms.Button();
            this.tb_Benutzername = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tb_Passwort = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            ".\\SQLEXPRESS"});
            this.comboBox1.Location = new System.Drawing.Point(93, 30);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.TextChanged += new System.EventHandler(this.Combobox_White);
            // 
            // cb_Server
            // 
            this.cb_Server.AutoSize = true;
            this.cb_Server.Location = new System.Drawing.Point(44, 33);
            this.cb_Server.Name = "cb_Server";
            this.cb_Server.Size = new System.Drawing.Size(38, 13);
            this.cb_Server.TabIndex = 3;
            this.cb_Server.Text = "Server";
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(162, 226);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(75, 23);
            this.bt_save.TabIndex = 6;
            this.bt_save.Text = "Speichern";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.w_s_Einstellungen_Save);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "BiboVerwaltung"});
            this.comboBox2.Location = new System.Drawing.Point(93, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 2;
            this.comboBox2.TextChanged += new System.EventHandler(this.Combobox_White);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Windows Authentifizierung",
            "SQL Authentifizierung"});
            this.comboBox3.Location = new System.Drawing.Point(93, 112);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 3;
            this.comboBox3.TextChanged += new System.EventHandler(this.Combobox_White);
            // 
            // cb_Database
            // 
            this.cb_Database.AutoSize = true;
            this.cb_Database.Location = new System.Drawing.Point(34, 74);
            this.cb_Database.Name = "cb_Database";
            this.cb_Database.Size = new System.Drawing.Size(53, 13);
            this.cb_Database.TabIndex = 7;
            this.cb_Database.Text = "Database";
            // 
            // cb_Security
            // 
            this.cb_Security.AutoSize = true;
            this.cb_Security.Location = new System.Drawing.Point(41, 115);
            this.cb_Security.Name = "cb_Security";
            this.cb_Security.Size = new System.Drawing.Size(45, 13);
            this.cb_Security.TabIndex = 8;
            this.cb_Security.Text = "Security";
            // 
            // b_Schließen
            // 
            this.b_Schließen.Location = new System.Drawing.Point(12, 226);
            this.b_Schließen.Name = "b_Schließen";
            this.b_Schließen.Size = new System.Drawing.Size(75, 23);
            this.b_Schließen.TabIndex = 7;
            this.b_Schließen.Text = "Reset";
            this.b_Schließen.UseVisualStyleBackColor = true;
            this.b_Schließen.Click += new System.EventHandler(this.Reset);
            // 
            // tb_Benutzername
            // 
            this.tb_Benutzername.AutoSize = true;
            this.tb_Benutzername.Location = new System.Drawing.Point(9, 164);
            this.tb_Benutzername.Name = "tb_Benutzername";
            this.tb_Benutzername.Size = new System.Drawing.Size(75, 13);
            this.tb_Benutzername.TabIndex = 10;
            this.tb_Benutzername.Text = "Benutzername";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(93, 161);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(93, 187);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 20);
            this.textBox2.TabIndex = 5;
            // 
            // tb_Passwort
            // 
            this.tb_Passwort.AutoSize = true;
            this.tb_Passwort.Location = new System.Drawing.Point(32, 190);
            this.tb_Passwort.Name = "tb_Passwort";
            this.tb_Passwort.Size = new System.Drawing.Size(50, 13);
            this.tb_Passwort.TabIndex = 13;
            this.tb_Passwort.Text = "Passwort";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "nur bei SQL Authentifizierung benötigt:";
            // 
            // w_s_Einstellungen
            // 
            this.ClientSize = new System.Drawing.Size(249, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_Passwort);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tb_Benutzername);
            this.Controls.Add(this.b_Schließen);
            this.Controls.Add(this.cb_Security);
            this.Controls.Add(this.cb_Database);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.cb_Server);
            this.Controls.Add(this.comboBox1);
            this.Name = "w_s_Einstellungen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
    }
}

