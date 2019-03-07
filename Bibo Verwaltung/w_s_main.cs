﻿using System;
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
    public partial class w_s_main : MetroFramework.Forms.MetroForm
    {
        string currentUser;
        public w_s_main(string userName)
        {
            this.currentUser = userName;
            InitializeComponent();
            Benutzer user = new Benutzer(userName);
            this.Text = "     Bibliotheksverwaltung - Angemeldet als: " + userName + " (" + user.Rechte + ")";
            if (user.Rechteid.Equals("0") || user.Rechteid.Equals("1"))
            {
                mT_Benutzerverwaltung.Enabled = false;
                mT_Einstellungen.Enabled = false;
            }
            else if (user.Rechteid == "2")
            {
                mT_Benutzerverwaltung.Enabled = true;
                mT_Einstellungen.Enabled = true;
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            System.IO.Directory.CreateDirectory(path + "\\Bibliothek");
            System.IO.Directory.CreateDirectory(path + "\\Bibliothek\\Bilder");
            System.IO.Directory.CreateDirectory(path + "\\Bibliothek\\Einstellungen");
            System.IO.Directory.CreateDirectory(path + "\\Bibliothek\\Downloads");

        }

        #region Load Uerbersicht
        bool error = false;
        private void Load_Uebersicht(object sender, EventArgs e)
        {
            if (!error)
            {
                UpdateForm();
            }
            
        }
        #endregion

        #region Formulare aufrufen
        private void bt_Kunden_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                Form Kunden = new w_s_Kunden(currentUser);
                Kunden.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Genres_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                Form Genres = new w_s_genres();
                Genres.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bt_Sprachen_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                Form Sprachen = new w_s_sprachen();
                Sprachen.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bt_Autoren_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                Form Autoren = new w_s_autoren();
                Autoren.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bt_Verlage_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                Form Verlage = new w_s_verlage();
                Verlage.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Buecher_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                Form Buecher = new w_s_buecher(true);
                Buecher.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Einstellungen_Click(object sender, EventArgs e)
        {
            Form Einstellungen = new w_s_einstellungen();
            Einstellungen.ShowDialog(this);
            UpdateForm();
            //error = false;

        }

        private void bt_Zustand_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                Form Zustand = new w_s_zustand();
                Zustand.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Suchen_Ausleihen_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                Form Details = new w_s_buchsuche(currentUser);
                Details.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateForm()
        {
            metroProgressBar1.Value = 0;
            timer1.Start();
            //SQL-Verbindung pruefen
            SQL_Verbindung con = new SQL_Verbindung();
            string test = con.ConnectionString;
            if (con.ConnectError())
            {
                error = true;
                lb_Bestandzahl.Text = "-";
                lb_Lagerzahl.Text = "-";
                lb_Ausleihzahl.Text = "-";
                return;
            }
            else
            {
                error = false;
            }
            string bestandSQL = "SELECT * FROM t_s_buchid WHERE bu_activated = 1";
            string ausgeliehenSQL = "SELECT * FROM t_bd_ausgeliehen";

            //zaehlt den Buecher-Bestand
            SqlDataAdapter adapter_bestand = new SqlDataAdapter(bestandSQL, con.Con);
            DataTable tbl_bastand = new DataTable();
            adapter_bestand.Fill(tbl_bastand);

            int bestand = 0;
            for (int i = 0; i < tbl_bastand.Rows.Count; i++)
            {
                bestand = bestand + 1;
            }
            tbl_bastand.Reset();
            lb_Bestandzahl.Text = bestand.ToString();

            //zaehlt ausgeliehene Buecher
            SqlDataAdapter adapter_ausgeliehen = new SqlDataAdapter(ausgeliehenSQL, con.Con);
            DataTable tbl_ausgeliehen = new DataTable();
            adapter_ausgeliehen.Fill(tbl_ausgeliehen);

            int ausgeliehen = 0;
            for (int i = 0; i < tbl_ausgeliehen.Rows.Count; i++)
            {
                ausgeliehen = ausgeliehen + 1;
            }
            lb_Ausleihzahl.Text = ausgeliehen.ToString();
            tbl_ausgeliehen.Reset();

            //zaehlt den Lagerbestand
            lb_Lagerzahl.Text = (bestand - ausgeliehen).ToString();

            con.Close();

        }

        private void bt_Benutzerverwaltung_Click(object sender, EventArgs e)
        {
            Form users = new w_s_user(currentUser);
            users.ShowDialog(this);
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            Form faecher = new w_s_faecher(currentUser);
            faecher.ShowDialog(this);
        }

        private void bt_schueler_Click(object sender, EventArgs e)
        {
            Form schueler = new w_s_schueler();
            schueler.ShowDialog(this);
        }

        private void bt_bf_Click(object sender, EventArgs e)
        {
            Form buchfach = new w_s_buch_fach(currentUser);
            buchfach.ShowDialog(this);
        }

        private void bt_stats_Click(object sender, EventArgs e)
        {
            Form analytics = new w_s_analytics();
            analytics.ShowDialog(this);
        }

        private void bt_klassenstufe_Click(object sender, EventArgs e)
        {
            Form stufe = new w_s_klassenstufe();
            stufe.ShowDialog(this);
        }

        private void mT_Abmelden_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroProgressBar1.Value == 100)
            {
                timer1.Stop();
            }
            metroProgressBar1.Invoke((Action)delegate ()
            {
                metroProgressBar1.PerformStep();
            });
        }

        private void mT_fachbuch_Click(object sender, EventArgs e)
        {
            Form buchFach = new w_s_buch_fach(currentUser);
            buchFach.ShowDialog(this);
        }

        private void mT_klassenstufebuch_Click(object sender, EventArgs e)
        {
            Form buchStufe = new w_s_buch_stufe(currentUser);
            buchStufe.ShowDialog(this);
        }

        private void mT_klassenstufefach_Click(object sender, EventArgs e)
        {
            Form fachStufe = new w_s_fach_stufe(currentUser);
            fachStufe.ShowDialog(this);
        }

        private void mT_ausgabe_Click(object sender, EventArgs e)
        {
            Form ausleihe = new w_s_ausleihe(currentUser);
            ausleihe.ShowDialog(this);
        }

        private void mT_rueckgabe_Click(object sender, EventArgs e)
        {
            Form rueckgabe = new w_s_rueckgabe(currentUser);
            rueckgabe.ShowDialog(this);
        }
        int counter = 0;
        private void image_Click(object sender, EventArgs e)
        {
            counter++;
            if(counter >= 10)
            {
                MessageBox.Show("Herzlichen GLückwunsch! Sie haben Langeweile!");
            }
        }
    }
    #endregion
}
