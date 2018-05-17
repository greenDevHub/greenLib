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
    public partial class w_s_main : Form
    {

        #region Datenbank-Verbinding bereitstellen
        #endregion

        public w_s_main(string name)
        {
            InitializeComponent();
            Benutzer user = new Benutzer(name);
            this.Text = "Bibliotheksverwaltung - Angemeldet als: " + name;
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
                Form Kunden = new w_s_Kunden();
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
                Form Buecher = new w_s_buecher();
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
                Form Details = new w_s_details();
                Details.ShowDialog(this);
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateForm()
        {
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
    }
    #endregion
}
