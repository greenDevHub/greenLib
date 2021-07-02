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
        public w_s_information(int modus, int id, string userName, MetroStyleManager msm)
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
                Book book = new Book();
                book.LoadBookByCopyId(id);
                lb_1.Text = "Buch-ISBN:";
                lb_2.Text = "Buchtitel:";
                lb_3.Text = "Autor:";
                lb_4.Text = "Genre:";
                lb_5.Text = "Verlag:";
                lb_6.Text = "Auflage:";
                lb_7.Text = "Neupreis:";
                lb_8.Text = "Erscheinungsdatum:";
                lb_2_1.Text = book.BookIsbn;
                lb_2_2.Text = book.BookTitle;
                if (book.BookAuthors.Count > 1)
                {
                    lb_2_3.Text = "";
                    foreach(Author author in book.BookAuthors)
                    {
                        lb_2_3.Text = lb_2_3.Text + author.AuthorName + ", ";
                    }
                    lb_2_3.Text = lb_2_3.Text.Substring(0, lb_2_3.Text.Length - 2);
                }
                else if(book.BookAuthors.Count == 0)
                {
                    lb_2_3.Text = "-";
                }
                lb_2_4.Text = book.BookGenre.GenreName;
                lb_2_5.Text = book.BookPublisher.PublisherName;
                lb_2_6.Text = book.BookEdition;
                lb_2_7.Text = book.BookPrice.ToString() + " €";
                lb_2_8.Text = book.BookDatePublication.ToShortDateString();
            }
            else if (modus == 2)
            {
                Text = "Kunden-Details";
                bt_Verwaltung.Text = "Kundenverwaltung";
                Costumer kunde = new Costumer(id);
                lb_1.Text = "Vorname:";
                lb_2.Text = "Nachname:";
                lb_3.Text = "Straße, Hausnummer";
                lb_4.Text = "PLZ:";
                lb_5.Text = "Ort:";
                lb_6.Text = "Klasse:";
                lb_7.Text = "E-Mail:";
                lb_8.Text = "Telefonnummer:";
                lb_2_1.Text = kunde.CostumerFirstName;
                lb_2_2.Text = kunde.CostumerSurname;
                lb_2_3.Text = kunde.CostumerStreet + kunde.CostumerHouseNumber;
                lb_2_4.Text = kunde.CostumerZipcode;
                lb_2_5.Text = kunde.CostumerCity;
                lb_2_6.Text=kunde.CostumerClass.Klassename;
                lb_2_7.Text = kunde.CostumerEmail;
                lb_2_8.Text = kunde.CostumerTelephone;
            }
        }

        private void bt_kunde_Click(object sender, EventArgs e)
        {
            if (Text == "Buch-Details")
            {
                Form_Books Buecher = new Form_Books(currentUser, true, msm_info);
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
