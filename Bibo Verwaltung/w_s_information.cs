using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_information : Form
    {
        string currentUser;
        public w_s_information(int modus, string id, string userName)
        {           
            InitializeComponent();
            this.currentUser = userName;

            if (modus == 1)
            {
                Text = "Buch-Details";
                bt_Verwaltung.Text = "Bücherverwaltung";
                tLP_Information.RowStyles[8].Height = 0;
                Buch buch = new Buch();
                buch.Load_ID(id);
                lb_1.Text = "Buch-ISBN:";
                lb_2.Text = "Buchtitel:";
                lb_3.Text = "Autor:";
                lb_4.Text = "Genre:";
                lb_5.Text = "Verlag:";
                lb_6.Text = "Auflage:";
                lb_7.Text = "Neupreis:";
                lb_8.Text = "Erscheinungsdatum:";
                lb_9.Text = "";
                lb_2_1.Text = buch.ISBN;
                lb_2_2.Text = buch.Titel;
                lb_2_3.Text = buch.AutorNames(); ;
                lb_2_4.Text = buch.Genre.Genrename;
                lb_2_5.Text = buch.Verlag.Verlagname;
                lb_2_6.Text = buch.Auflage;
                lb_2_7.Text = buch.Neupreis.ToString() + " €";
                lb_2_8.Text = buch.Er_datum.ToShortDateString();
                lb_2_9.Text = "";
            }
            else if (modus == 2)
            {
                Text = "Kunden-Details";
                bt_Verwaltung.Text = "Kundenverwaltung";
                Kunde kunde = new Kunde(id);
                lb_1.Text = "Vorname:";
                lb_2.Text = "Nachname:";
                lb_3.Text = "Straße, Hausnummer";
                lb_4.Text = "PLZ:";
                lb_5.Text = "Ort:";
                lb_6.Text = "Vertrauenswürdigkeit:";
                lb_7.Text = "Klasse:";
                lb_8.Text = "E-Mail:";
                lb_9.Text = "Telefonnummer:";
                lb_2_1.Text = kunde.Vorname;
                lb_2_2.Text = kunde.Nachname;
                lb_2_3.Text = kunde.Strasse + kunde.Hausnummer;
                lb_2_4.Text = kunde.Postleitzahl;
                lb_2_5.Text = kunde.Ort;
                lb_2_6.Text = kunde.Vertrauenswuerdigkeit;
                lb_2_7.Text = kunde.Klasse;
                lb_2_8.Text = kunde.Mail;
                lb_2_9.Text = kunde.Telefonnummer;
            }
        }

        private void bt_kunde_Click(object sender, EventArgs e)
        {
            if (Text == "Buch-Details")
            {
                Form Buecher = new w_s_buecher(true);
                Buecher.ShowDialog(this);
            }
            else if (Text == "Kunden-Details")
            {
                Form Kunden = new w_s_Kunden(currentUser);
                Kunden.ShowDialog(this);
            }
        }
    }
}
