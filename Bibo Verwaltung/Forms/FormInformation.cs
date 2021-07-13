using Bibo_Verwaltung.Helper;
using System;

namespace Bibo_Verwaltung
{
    public partial class FormInformation : MetroFramework.Forms.MetroForm
    {
        public FormInformation(int modus, int id)
        {
            InitializeComponent();
            LoadTheme();
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
                    foreach (Author author in book.BookAuthors)
                    {
                        lb_2_3.Text = lb_2_3.Text + author.AuthorName + ", ";
                    }
                    lb_2_3.Text = lb_2_3.Text.Substring(0, lb_2_3.Text.Length - 2);
                }
                else if (book.BookAuthors.Count == 0)
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
                lb_2_6.Text = kunde.CostumerSchoolClass.SchoolClassName;
                lb_2_7.Text = kunde.CostumerEmail;
                lb_2_8.Text = kunde.CostumerTelephone;
            }
        }

        private void LoadTheme()
        {
            this.StyleManager = styleManagerInformation;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.MainStyle;

        }

        private void bt_kunde_Click(object sender, EventArgs e)
        {
            if (Text == "Buch-Details")
            {
                Form_Books formBooks = new Form_Books(true);
                formBooks.ShowDialog(this);
                formBooks.Dispose();
            }
            else if (Text == "Kunden-Details")
            {
                FormCostumer formCostumer = new FormCostumer();
                formCostumer.ShowDialog(this);
                formCostumer.Dispose();
            }
        }
    }
}
