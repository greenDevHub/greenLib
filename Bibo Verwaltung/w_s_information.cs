using MetroFramework.Components;
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
    public partial class w_s_information : MetroFramework.Forms.MetroForm
    {
        string currentUser;
        public w_s_information(int modus, string id, string userName, MetroStyleManager msm)
        {           
            InitializeComponent();
            msm_info = msm;
            this.StyleManager = msm;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Blue;
            this.currentUser = userName;
            if (modus == 1)
            {
                Text = "Buch-Details";
                bt_Verwaltung.Text = "Bücherverwaltung";
                tLP_Information.RowStyles[8].Height = 0;
                Buch buch = new Buch();
                buch.LoadBuchByID(id);
                lb_1.Text = "Buch-ISBN:";
                lb_2.Text = "Buchtitel:";
                lb_3.Text = "Autor:";
                lb_4.Text = "Genre:";
                lb_5.Text = "Verlag:";
                lb_6.Text = "Auflage:";
                lb_7.Text = "Neupreis:";
                lb_8.Text = "Erscheinungsdatum:";
                lb_2_1.Text = buch.ISBN;
                lb_2_2.Text = buch.Titel;
                if (buch.Autoren.Count > 1)
                {
                    lb_2_3.Text = "";
                    foreach(string s in buch.Autoren)
                    {
                        lb_2_3.Text = lb_2_3.Text + s + ", ";
                    }
                    lb_2_3.Text = lb_2_3.Text.Substring(0, lb_2_3.Text.Length - 2);
                }
                else if(buch.Autoren.Count == 0)
                {
                    lb_2_3.Text = "-";
                }
                lb_2_4.Text = buch.Genre.Genrename;
                lb_2_5.Text = buch.Verlag.Verlagname;
                lb_2_6.Text = buch.Auflage;
                lb_2_7.Text = buch.Neupreis.ToString() + " €";
                lb_2_8.Text = buch.Er_datum.ToShortDateString();
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
                lb_6.Text = "Klasse:";
                lb_7.Text = "E-Mail:";
                lb_8.Text = "Telefonnummer:";
                lb_2_1.Text = kunde.Vorname;
                lb_2_2.Text = kunde.Nachname;
                lb_2_3.Text = kunde.Strasse + kunde.Hausnummer;
                lb_2_4.Text = kunde.Postleitzahl;
                lb_2_5.Text = kunde.Ort;
                lb_2_6.Text=kunde.Klasse.Klassename;
                lb_2_7.Text = kunde.Mail;
                lb_2_8.Text = kunde.Telefonnummer;
            }
        }

        private void bt_kunde_Click(object sender, EventArgs e)
        {
            if (Text == "Buch-Details")
            {
                w_s_buecher Buecher = new w_s_buecher(currentUser, true, msm_info);
                msm_info.Clone(Buecher);
                Buecher.ShowDialog(this);
                Buecher.Dispose();
            }
            else if (Text == "Kunden-Details")
            {
                w_s_Kunden Kunden = new w_s_Kunden(currentUser,msm_info);
                msm_info.Clone(Kunden);
                Kunden.ShowDialog(this);
                Kunden.Dispose();
            }
        }
    }
}
