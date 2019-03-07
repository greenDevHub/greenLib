using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_Kunden : Form
    {
        Kunde kunde = new Kunde();

        string currentUser;
        public w_s_Kunden(string userName)
        {
            InitializeComponent();
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;
            kunde.FillGrid(ref gv_Kunde);
        }

        #region Fenster-Methoden
        /// <summary>
        /// Setzt die Kundendaten in ein Kunden-Objekt 
        /// </summary>
        private void SetKundenValues()
        {
            kunde.KundenID = tb_KundenID.Text;
            kunde.Vorname = tb_Vorname.Text;
            kunde.Nachname = tb_Nachname.Text;
            kunde.Strasse = tb_Strasse.Text;
            kunde.Hausnummer = tb_Hausnummer.Text;
            kunde.Postleitzahl = tb_Postleitzahl.Text;
            kunde.Ort = tb_Ort.Text;
            kunde.Klassenstufe = tb_Klasse.Text;
            kunde.Mail = tb_Mail.Text;
            kunde.Telefonnummer = tb_Telefonnummer.Text;
        }

        /// <summary>
        /// Prüft einen String - liefert TRUE wenn keine Zahl enthalten ist
        /// </summary>
        private bool IsStringOnly(string inputString)
        {
            foreach (char c in inputString)
                if (Char.IsNumber(c))
                    return false;
            return true;
        }

        /// <summary>
        /// Prüft einen String - liefert TRUE wenn nur Zahlen enthalten sind
        /// </summary>
        private bool IsNumericOnly(string inputString)
        {
            foreach (char c in inputString)
                if (!Char.IsNumber(c))
                    return false;
            return true;
        }

        private bool checkSpecialNumbers(string number)
        {
            foreach (char c in number)
                if (!Char.IsNumber(c) && c.Equals("/"))
                    return false;
            return true;
        }

        /// <summary>
        /// Setzt die Form zurück 
        /// </summary>
        private void ClearForm()
        {
            lb_kunde_add.Visible = false;
            tb_Vorname.Text = "";
            tb_Nachname.Text = "";
            tb_Strasse.Text = "";
            tb_Hausnummer.Text = "";
            tb_Postleitzahl.Text = "";
            tb_Ort.Text = "";
            tb_Klasse.Text = "";
            tb_Mail.Text = "";
            tb_Telefonnummer.Text = "";
            tb_KundenID.Text = "";
            SetBackground_White();
        }

        /// <summary>
        /// Setzt alle Componenten-Hintergrungfarben auf weiß
        /// </summary>
        private void SetBackground_White()
        {
            tb_Vorname.BackColor = Color.White;
            tb_Nachname.BackColor = Color.White;
            tb_KundenID.BackColor = Color.White;
            tb_Hausnummer.BackColor = Color.White;
            tb_Strasse.BackColor = Color.White;
            tb_Postleitzahl.BackColor = Color.White;
            tb_Ort.BackColor = Color.White;
            tb_Klasse.BackColor = Color.White;
            tb_Mail.BackColor = Color.White;
            tb_Telefonnummer.BackColor = Color.White;
        }

        /// <summary>
        /// Setzt die Componenten auf den aktuellen Arbeits-Modus
        /// </summary>
        private void SetModus()
        {
            if (rb_KundeBearbeiten.Checked)
            {
                bt_confirm.Enabled = true;
                bt_confirm.Text = "Speichern";
                tb_KundenID.Enabled = false;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                tb_Strasse.Enabled = true;
                tb_Hausnummer.Enabled = true;
                tb_Postleitzahl.Enabled = true;
                tb_Ort.Enabled = true;
                tb_Klasse.Enabled = true;
                tb_Mail.Enabled = true;
                tb_Telefonnummer.Enabled = true;
                lb_KundenID.Text = "Kunden-ID:*";
                lb_Vorname.Text = "Vorname:*";
                lb_Nachname.Text = "Nachname:*";
                lb_Strasse.Text = "Strasse:*";
                lb_Hausnummer.Text = "Hausnummer:*";
                lb_Ort.Text = "Wohnort:*";
                lb_Postleitzahl.Text = "Postleitzahl:*";
            }
            else if (rb_Neukunde.Checked)
            {
                bt_confirm.Text = "Hinzufügen";
                bt_confirm.Enabled = true;
                tb_KundenID.Enabled = false;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                tb_Strasse.Enabled = true;
                tb_Hausnummer.Enabled = true;
                tb_Postleitzahl.Enabled = true;
                tb_Ort.Enabled = true;
                tb_Klasse.Enabled = true;
                tb_Mail.Enabled = true;
                tb_Telefonnummer.Enabled = true;
                lb_KundenID.Text = "Kunden-ID:";
                lb_Vorname.Text = "Vorname:*";
                lb_Nachname.Text = "Nachname:*";
                lb_Strasse.Text = "Strasse:*";
                lb_Hausnummer.Text = "Hausnummer:*";
                lb_Ort.Text = "Wohnort:*";
                lb_Postleitzahl.Text = "Postleitzahl:*";
            }
            else if (rb_KundeLoeschen.Checked)
            {
                bt_confirm.Enabled = true;
                bt_confirm.Text = "Löschen";
                tb_KundenID.Enabled = true;
                tb_Vorname.Enabled = false;
                tb_Nachname.Enabled = false;
                tb_Strasse.Enabled = false;
                tb_Hausnummer.Enabled = false;
                tb_Postleitzahl.Enabled = false;
                tb_Ort.Enabled = false;
                tb_Klasse.Enabled = false;
                tb_Mail.Enabled = false;
                tb_Telefonnummer.Enabled = false;
                lb_KundenID.Text = "Kunden-ID:*";
                lb_Vorname.Text = "Vorname:";
                lb_Nachname.Text = "Nachname:";
                lb_Strasse.Text = "Strasse:";
                lb_Ort.Text = "Wohnort:";
                lb_Hausnummer.Text = "Hausnummer:";
                lb_Postleitzahl.Text = "Postleitzahl:";
            }
        }

        /// <summary>
        /// Setzt alle Componenten-Hintergrungfarben der Pflichtfelder auf rot
        /// </summary>
        private void SetBackground_Red()
        {
            if (tb_Vorname.Text.Equals(""))
            {
                tb_Vorname.BackColor = Color.Red;
            }
            else
            {
                tb_Vorname.BackColor = Color.White;
            }

            if (tb_Nachname.Text.Equals(""))
            {
                tb_Nachname.BackColor = Color.Red;
            }
            else
            {
                tb_Nachname.BackColor = Color.White;
            }

            if (tb_Strasse.Text.Equals(""))
            {
                tb_Strasse.BackColor = Color.Red;
            }
            else
            {
                tb_Strasse.BackColor = Color.White;
            }

            if (tb_Hausnummer.Text.Equals(""))
            {
                tb_Hausnummer.BackColor = Color.Red;
            }
            else
            {
                tb_Hausnummer.BackColor = Color.White;
            }

            if (tb_Postleitzahl.Text.Equals(""))
            {
                tb_Postleitzahl.BackColor = Color.Red;
            }
            else
            {
                tb_Postleitzahl.BackColor = Color.White;
            }

            if (tb_Ort.Text.Equals(""))
            {
                tb_Ort.BackColor = Color.Red;
            }
            else
            {
                tb_Ort.BackColor = Color.White;
            }
        }
        
        /// <summary>
        /// Sucht nach Kunden in einer GridView
        /// </summary>
        private void KundenFilter()
        {
            (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%' AND Straße LIKE '{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Klassenstufe LIKE '{6}%' AND Mail LIKE '{7}%' AND Telefonnummer LIKE '{8}%'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, tb_Klasse.Text, tb_Mail.Text, tb_Telefonnummer.Text);
        }
        #endregion

        #region Componenten-Aktionen
        private void bt_confirm_click(object sender, EventArgs e)
        {
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, a) =>
            {
                lb_kunde_add.Hide();
                t.Stop();
            };

            if (rb_KundeBearbeiten.Checked)
            {
                if (!tb_Vorname.Text.Equals("")
                && !tb_Nachname.Text.Equals("")
                && !tb_Strasse.Text.Equals("")
                && !tb_Hausnummer.Text.Equals("")
                && !tb_Postleitzahl.Text.Equals("")
                && !tb_Ort.Text.Equals(""))
                {
                    try
                    {
                        SetKundenValues();
                        kunde.UpdateKunde();
                        ClearForm();
                        kunde.FillGrid(ref gv_Kunde);
                        lb_kunde_add.Visible = false;
                        lb_kunde_add.Text = "Der Kunde wurde bearbeitet!";
                        lb_kunde_add.Visible = true;
                        t.Start();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Der Kunde konnte nicht gespeichert werden!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Füllen Sie die markierten Felder aus, um einen Kunden zu speichern!", "Achtung",
                         MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SetBackground_Red();
                }
            }

            if (rb_KundeLoeschen.Checked)
            {
                if (!tb_KundenID.Text.Equals(""))
                {
                    try
                    {
                        SetKundenValues();
                        kunde.Deactivate();
                        ClearForm();
                        kunde.FillGrid(ref gv_Kunde);
                        lb_kunde_add.Visible = false;
                        lb_kunde_add.Text = "Der Kunde wurde gelöscht!";
                        lb_kunde_add.Visible = true;
                        t.Start();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Der Kunde konnte nicht gelöscht werden!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Füllen Sie das markierte Felder aus, um einen Kunden zu löschen!", "Achtung",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (tb_KundenID.Text.Equals(""))
                    {
                        tb_KundenID.BackColor = Color.Red;
                    }
                    else
                    {
                        tb_KundenID.BackColor = Color.White;
                    }
                }
            }

            if (rb_Neukunde.Checked)
            {
                if (!tb_Vorname.Text.Equals("")
                && !tb_Nachname.Text.Equals("")
                && !tb_Strasse.Text.Equals("")
                && !tb_Hausnummer.Text.Equals("")
                && !tb_Postleitzahl.Text.Equals("")
                && !tb_Ort.Text.Equals(""))
                {
                    string errorMessage = "Folgende Felder haben unzulässige Werte: ";
                    bool error = false;
                    if (!IsStringOnly(tb_Vorname.Text))
                    {
                        errorMessage += "\n - Vorname enthält Zahlen";
                        tb_Vorname.BackColor = Color.Red;
                        error = true;
                    }
                    if (!IsStringOnly(tb_Nachname.Text))
                    {
                        errorMessage += "\n - Nachname enthält Zahlen";
                        tb_Nachname.BackColor = Color.Red;
                        error = true;
                    }
                    if (!IsStringOnly(tb_Strasse.Text))
                    {
                        errorMessage += "\n - Straßenname enthält Zahlen";
                        tb_Strasse.BackColor = Color.Red;
                        error = true;
                    }
                    if (!IsNumericOnly(tb_Postleitzahl.Text))
                    {
                        errorMessage += "\n - Postleitzahl enthält nicht nur Zahlen";
                        tb_Postleitzahl.BackColor = Color.Red;
                        error = true;
                    }
                    if (!IsStringOnly(tb_Ort.Text))
                    {
                        errorMessage += "\n - Ort enhält Zahlen";
                        tb_Ort.BackColor = Color.Red;
                        error = true;
                    }
                    if (!tb_Klasse.Text.Equals("") && !checkSpecialNumbers(tb_Klasse.Text))
                    {
                        errorMessage += "\n - Klasse ist nicht richtig formatiert";
                        tb_Telefonnummer.BackColor = Color.Red;
                        error = true;
                    }
                    if (!tb_Telefonnummer.Text.Equals("") && !checkSpecialNumbers(tb_Telefonnummer.Text))
                    {
                        errorMessage += "\n - Telefonnummer ist nicht richtig formatiert";
                        tb_Telefonnummer.BackColor = Color.Red;
                        error = true;
                    }
                    if (error)
                    {
                        MessageBox.Show(errorMessage, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        SetKundenValues();
                        kunde.AddKunde();
                        ClearForm();
                        kunde.FillGrid(ref gv_Kunde);
                        lb_kunde_add.Visible = false;
                        lb_kunde_add.Text = "Der Kunde wurde hinzugefügt!";
                        lb_kunde_add.Visible = true;
                        t.Start();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Der Kunde konnte nicht hinzugefügt werden!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Füllen Sie alle Felder aus, um einen neuen Kunden hinzuzufügen!", "Achtung",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SetBackground_Red();
                }
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void rb_KundeBearbeiten_CheckedChanged(object sender, EventArgs e)
        {
            SetModus();
            SetBackground_White();
        }

        private void rb_KundeLoeschen_CheckedChanged(object sender, EventArgs e)
        {
            SetModus();
            SetBackground_White();
        }

        private void rb_Neukunde_CheckedChanged(object sender, EventArgs e)
        {
            SetModus();
            SetBackground_White();
        }

        private void w_s_kunden_Activated(object sender, EventArgs e)
        {
            SetModus();
            kunde.FillGrid(ref gv_Kunde);
        }
   
        private void tb_KundenID_TextChanged(object sender, EventArgs e)
        {
            tb_KundenID.BackColor = Color.White;
        }

        private void tb_Vorname_TextChanged(object sender, EventArgs e)
        {
            tb_Vorname.BackColor = Color.White;
            KundenFilter();
        }

        private void tb_Nachname_TextChanged(object sender, EventArgs e)
        {
            tb_Nachname.BackColor = Color.White;
            KundenFilter();
        }

        private void tb_Strasse_TextChanged(object sender, EventArgs e)
        {
            tb_Strasse.BackColor = Color.White;
            KundenFilter();
        }

        private void tb_Hausnummer_TextChanged(object sender, EventArgs e)
        {
            tb_Hausnummer.BackColor = Color.White;
            KundenFilter();
        }

        private void tb_Postleitzahl_TextChanged(object sender, EventArgs e)
        {
            tb_Postleitzahl.BackColor = Color.White;
            KundenFilter();
        }

        private void tb_Ort_TextChanged(object sender, EventArgs e)
        {
            tb_Ort.BackColor = Color.White;
            KundenFilter();
        }

        private void tb_Klasse_TextChanged(object sender, EventArgs e)
        {
            tb_Klasse.BackColor = Color.White;
            KundenFilter();
        }

        private void tb_Mail_TextChanged(object sender, EventArgs e)
        {
            tb_Mail.BackColor = Color.White;
            KundenFilter();
        }

        private void tb_Telefonnummer_TextChanged(object sender, EventArgs e)
        {
            tb_Telefonnummer.BackColor = Color.White;
            KundenFilter();
        }
        
        private void Grid_Kunde_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_Kunde.Rows[e.RowIndex];
                rb_KundeBearbeiten.Checked = true;
                //tb_KundenID.Text = row.Cells["Kunden-ID"].Value.ToString();

                kunde = new Kunde(row.Cells["Kunden-ID"].Value.ToString());
                tb_Vorname.Text = kunde.Vorname;
                tb_Nachname.Text = kunde.Nachname;
                tb_Strasse.Text = kunde.Strasse;
                tb_Hausnummer.Text = kunde.Hausnummer;
                tb_Postleitzahl.Text = kunde.Postleitzahl;
                tb_Ort.Text = kunde.Ort;
                tb_Klasse.Text = kunde.Klassenstufe;
                tb_Mail.Text = kunde.Mail;
                tb_Telefonnummer.Text = kunde.Telefonnummer;

                //Kunde clickedkunde = new Kunde(tb_KundenID.Text);
                //tb_Vorname.Text = clickedkunde.Vorname;
                //tb_Nachname.Text = clickedkunde.Nachname;
                //tb_Strasse.Text = clickedkunde.Strasse;
                //tb_Hausnummer.Text = clickedkunde.Hausnummer;
                //tb_Postleitzahl.Text = clickedkunde.Postleitzahl;
                //tb_Ort.Text = clickedkunde.Ort;
                //tb_Klasse.Text = clickedkunde.Klassenstufe;
                //tb_Mail.Text = clickedkunde.Mail;
                //tb_Telefonnummer.Text = clickedkunde.Telefonnummer;
            }
        }
 
        private void bt_ImEx_Click(object sender, EventArgs e)
        {
            Form import = new w_s_schuelerimport("t_s_schueler", true);
            import.ShowDialog(this);
            kunde.FillGrid(ref gv_Kunde);
            //Form modus = new w_s_selfmade_dialog("Modus", "Was möchten sie mit der Kundentabelle machen? Wählen Sie den Import- oder den Exportmodus.", "Importmodus", "Exportmodus");
            //modus.ShowDialog();
            //DialogResult ds = modus.DialogResult;
            //if (ds == DialogResult.Yes)
            //{
            //    Form Import = new w_s_import_export((DataTable)gv_Kunde.DataSource, true);
            //    Import.ShowDialog(this);
            //}
            //else if (ds == DialogResult.No)
            //{
            //    Form Import = new w_s_import_export((DataTable)gv_Kunde.DataSource, false);
            //    Import.ShowDialog(this);
            //}
            //else { }
        }
        #endregion

    }
}
