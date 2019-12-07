using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_Kunden : MetroFramework.Forms.MetroForm
    {
        Kunde kunde = new Kunde();

        #region Constructor
        string currentUser;
        bool loaded = false;
        public w_s_Kunden(string userName)
        {
            InitializeComponent();
            Benutzer user = new Benutzer(userName);
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName + " (" + user.Rechte + ")";
            if (user.Rechteid.Equals("0"))
            {
                rb_Neukunde.Enabled = false;
                rb_KundeBearbeiten.Enabled = false;
                rb_KundeLoeschen.Enabled = false;
                mtP_Filter.Enabled = false;
                bt_confirm.Enabled = false;
                gv_faecher.Enabled = false;
                gv_result.Enabled = false;
                bt_cleanup.Enabled = false;
                mbt_Import.Enabled = false;
                mbt_Export.Enabled = false;
                tb_KundenID.Enabled = false;
                tb_Vorname.Enabled = false;
                tb_Nachname.Enabled = false;
                mdtp_GebDat.Enabled = false;
                tb_Strasse.Enabled = false;
                tb_Hausnummer.Enabled = false;
                tb_Postleitzahl.Enabled = false;
                tb_Ort.Enabled = false;
                tb_Klasse.Enabled = false;
                tb_Mail.Enabled = false;
                tb_Telefonnummer.Enabled = false;
                kundeBearbeitenToolStripMenuItem.Enabled = false;
                kundeEntfernenToolStripMenuItem.Enabled = false;
                leistungskursAuswählenToolStripMenuItem.Enabled = false;
            }
            else if (user.Rechteid.Equals("1"))
            {
                rb_Neukunde.Enabled = true;
                rb_KundeBearbeiten.Enabled = true;
                rb_KundeLoeschen.Enabled = true;
                mtP_Filter.Enabled = true;
                bt_confirm.Enabled = true;
                gv_faecher.Enabled = true;
                gv_result.Enabled = true;
                bt_cleanup.Enabled = true;
                mbt_Import.Enabled = true;
                mbt_Export.Enabled = false;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                mdtp_GebDat.Enabled = true;
                tb_Strasse.Enabled = true;
                tb_Hausnummer.Enabled = true;
                tb_Postleitzahl.Enabled = true;
                tb_Ort.Enabled = true;
                tb_Klasse.Enabled = true;
                tb_Mail.Enabled = true;
                tb_Telefonnummer.Enabled = true;
                kundeBearbeitenToolStripMenuItem.Enabled = true;
                kundeEntfernenToolStripMenuItem.Enabled = true;
                leistungskursAuswählenToolStripMenuItem.Enabled = true;
            }
            else if (user.Rechteid == "2")
            {
                rb_Neukunde.Enabled = true;
                rb_KundeBearbeiten.Enabled = true;
                rb_KundeLoeschen.Enabled = true;
                mtP_Filter.Enabled = true;
                bt_confirm.Enabled = true;
                gv_faecher.Enabled = true;
                gv_result.Enabled = true;
                bt_cleanup.Enabled = true;
                mbt_Import.Enabled = true;
                mbt_Export.Enabled = true;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                mdtp_GebDat.Enabled = true;
                tb_Strasse.Enabled = true;
                tb_Hausnummer.Enabled = true;
                tb_Postleitzahl.Enabled = true;
                tb_Ort.Enabled = true;
                tb_Klasse.Enabled = true;
                tb_Mail.Enabled = true;
                tb_Telefonnummer.Enabled = true;
                kundeBearbeitenToolStripMenuItem.Enabled = true;
                kundeEntfernenToolStripMenuItem.Enabled = true;
                leistungskursAuswählenToolStripMenuItem.Enabled = true;
            }

            //bt_confirm.Enabled = false;
            //gv_Kunde.Enabled = false;
            //bt_cleanup.Enabled = false;
            //metroPanel2.Enabled = false;
            //bt_ImEx.Enabled = false;
            //MetroPanel hidePanel = new MetroPanel();
            //this.Controls.Add(hidePanel);
            //Point punkt = gv_Kunde.FindForm().PointToClient(gv_Kunde.Parent.PointToScreen(gv_Kunde.Location));
            //hidePanel.Location = new Point(punkt.X, punkt.Y + 25);
            //hidePanel.Size = gv_Kunde.Size;
            //hidePanel.Height = hidePanel.Height - 25;
            //hidePanel.BringToFront();
            //hidePanel.Enabled = false;      
        }
        #endregion

        #region Fenster-Methoden
        /// <summary>
        /// Setzt die Kundendaten in ein Kunden-Objekt 
        /// </summary>
        private void SetKundenValues()
        {
            kunde.KundenID = tb_KundenID.Text;
            kunde.Vorname = tb_Vorname.Text;
            kunde.Nachname = tb_Nachname.Text;
            kunde.Gd = mdtp_GebDat.Value.Date;
            kunde.Strasse = tb_Strasse.Text;
            kunde.Hausnummer = tb_Hausnummer.Text;
            kunde.Postleitzahl = tb_Postleitzahl.Text;
            kunde.Ort = tb_Ort.Text;
            kunde.Klasse.Klassename = tb_Klasse.Text;
            kunde.Mail = tb_Mail.Text;
            kunde.Telefonnummer = tb_Telefonnummer.Text;
            kunde.Faecher.Clear();
            kunde.LeistungskursListe.Clear();
            for (int i = 0; i < gv_result.Rows.Count; i++)
            {
                DataGridViewRow row = gv_result.Rows[i];
                if (row.Cells["Kürzel"].Value != null)
                {
                    if (row.Cells["Kürzel"].Value.ToString() != "")
                    {
                        if (row.DefaultCellStyle.BackColor == Color.Yellow)
                        {
                            kunde.Faecher.Add(row.Cells["Kürzel"].Value.ToString().Substring(1));
                            kunde.LeistungskursListe.Add(row.Cells["Kürzel"].Value.ToString().Substring(1));
                        }
                        else
                        {
                            kunde.Faecher.Add(row.Cells["Kürzel"].Value.ToString());
                        }
                    }
                }
            }
            for (int i = kunde.LeistungskursListe.Count; i < 2; i++)
            {
                kunde.LeistungskursListe.Add("");
            }
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

        /// <summary>
        /// Prüft einen String - liefert TRUE wenn kein "/" enthalten ist
        /// </summary>
        private bool CheckSpecialNumbers(string number)
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
            mdtp_GebDat.Text = "";
            tb_Strasse.Text = "";
            tb_Hausnummer.Text = "";
            tb_Postleitzahl.Text = "";
            tb_Ort.Text = "";
            tb_Klasse.Text = "";
            tb_Mail.Text = "";
            tb_Telefonnummer.Text = "";
            tb_KundenID.Text = "";
            kunde.Fach.FillGrid(ref gv_faecher);
            gv_result.Rows.Clear();
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
            if (new Benutzer(currentUser).Rechteid != "0")
            {
                if (rb_KundeBearbeiten.Checked)
                {
                    bt_confirm.Text = "Speichern";
                    tb_KundenID.Enabled = false;
                    tb_Vorname.Enabled = false;
                    tb_Nachname.Enabled = false;
                    mdtp_GebDat.Enabled = false;
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
                    lb_geburtsdatum.Text = "Geburtsdatum:*";
                    lb_Strasse.Text = "Strasse:";
                    lb_Hausnummer.Text = "Hausnummer:";
                    lb_Ort.Text = "Wohnort:";
                    lb_Postleitzahl.Text = "Postleitzahl:";
                }
                else if (rb_Neukunde.Checked)
                {
                    bt_confirm.Text = "Hinzufügen";
                    tb_KundenID.Enabled = false;
                    tb_Vorname.Enabled = true;
                    tb_Nachname.Enabled = true;
                    mdtp_GebDat.Enabled = true;
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
                    lb_geburtsdatum.Text = "Geburtsdatum:*";
                    lb_Strasse.Text = "Strasse:";
                    lb_Hausnummer.Text = "Hausnummer:";
                    lb_Ort.Text = "Wohnort:";
                    lb_Postleitzahl.Text = "Postleitzahl:";
                }
                else if (rb_KundeLoeschen.Checked)
                {
                    bt_confirm.Text = "Löschen";
                    tb_KundenID.Enabled = true;
                    tb_Vorname.Enabled = false;
                    tb_Nachname.Enabled = false;
                    tb_Strasse.Enabled = false;
                    mdtp_GebDat.Enabled = false;
                    tb_Hausnummer.Enabled = false;
                    tb_Postleitzahl.Enabled = false;
                    tb_Ort.Enabled = false;
                    tb_Klasse.Enabled = false;
                    tb_Mail.Enabled = false;
                    tb_Telefonnummer.Enabled = false;
                    lb_KundenID.Text = "Kunden-ID:*";
                    lb_Vorname.Text = "Vorname:";
                    lb_Nachname.Text = "Nachname:";
                    lb_geburtsdatum.Text = "Geburtsdatum:";
                    lb_Strasse.Text = "Strasse:";
                    lb_Ort.Text = "Wohnort:";
                    lb_Hausnummer.Text = "Hausnummer:";
                    lb_Postleitzahl.Text = "Postleitzahl:";
                }
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
            (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%' AND Straße LIKE '{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Klasse LIKE '{6}%' AND Mail LIKE '{7}%' AND Telefonnummer LIKE '{8}%'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, tb_Klasse.Text, tb_Mail.Text, tb_Telefonnummer.Text);
        }

        /// <summary>
        /// Lädt einen Kunden
        /// </summary>
        private void LoadKunde(string kundenid)
        {
            kunde = new Kunde(kundenid);
            tb_KundenID.Text = kunde.KundenID;
            tb_Vorname.Text = kunde.Vorname;
            tb_Nachname.Text = kunde.Nachname;
            mdtp_GebDat.Value = kunde.Gd;
            tb_Strasse.Text = kunde.Strasse;
            tb_Hausnummer.Text = kunde.Hausnummer;
            tb_Postleitzahl.Text = kunde.Postleitzahl;
            tb_Ort.Text = kunde.Ort;
            tb_Klasse.Text = kunde.Klasse.Klassename;
            tb_Mail.Text = kunde.Mail;
            tb_Telefonnummer.Text = kunde.Telefonnummer;
            if (kunde.Faecher.Count > 0)
            {
                string fachIndex = "";
                List<int> index = new List<int>();
                foreach (string fach in kunde.Faecher)
                {
                    fachIndex = kunde.Fach.GetIDByShortform(fach);
                    kunde.Fach = new Fach(fachIndex);
                    index.Add(int.Parse(fachIndex));
                    if (fach.Equals(kunde.LeistungskursListe[0]) || fach.Equals(kunde.LeistungskursListe[1]))
                    {
                        gv_result.Rows.Add("*" + kunde.Fach.FachKurz, kunde.Fach.FachID);
                        gv_result.Rows[gv_result.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                        kunde.Leistungskurse++;
                    }
                    else
                    {
                        gv_result.Rows.Add(kunde.Fach.FachKurz, kunde.Fach.FachID);
                    }
                    for (int i = 0; i < gv_faecher.Rows.Count; i++)
                    {
                        DataGridViewRow row = gv_faecher.Rows[i];
                        if (row.Cells["ID"].Value.ToString().Equals(fachIndex))
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.SelectionBackColor = Color.Gold;
                            i = gv_faecher.Rows.Count;
                        }
                    }
                }
            }
        }
        #endregion

        #region Componenten-Aktionen
        private void bt_confirm_click(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, a) =>
            {
                lb_kunde_add.Hide();
                t.Stop();
            };

            if (rb_KundeBearbeiten.Checked)
            {
                if (!tb_Vorname.Text.Equals("")
                && !tb_Nachname.Text.Equals(""))
                {
                    try
                    {
                        SetKundenValues();
                        kunde.UpdateKunde();
                        ClearForm();
                        kunde.FillGrid(ref gv_Kunde);
                        gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Descending);
                        gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Ascending);
                        lb_kunde_add.Visible = false;
                        lb_kunde_add.Text = "Der Kunde wurde bearbeitet!";
                        lb_kunde_add.Visible = true;
                        t.Start();
                    }
                    catch (SqlException)
                    {
                        MetroMessageBox.Show(this, "Der Kunde konnte nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Füllen Sie die markierten Felder aus, um einen Kunden zu speichern!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    SetBackground_Red();
                }
            }

            if (rb_KundeLoeschen.Checked)
            {
                if (!tb_KundenID.Text.Equals(""))
                {
                    try
                    {
                        kunde.KundenID = tb_KundenID.Text;
                        if (!kunde.Ausgeliehen())
                        {
                            kunde.DeactivateKunde();
                            ClearForm();
                            kunde.FillGrid(ref gv_Kunde);
                            lb_kunde_add.Visible = false;
                            lb_kunde_add.Text = "Der Kunde wurde gelöscht!";
                            lb_kunde_add.Visible = true;
                            t.Start();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Der Kunde konnte nicht entfernt werden, da er noch in einem Ausleihvorgang involviert ist. Bitte markieren Sie zuerst alle Bücher als 'zurückgegeben', damit der Datensatz entfernt werden kann.", "Löschen nicht möglich", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (SqlException)
                    {
                        MetroMessageBox.Show(this, "Der Kunde konnte nicht gelöscht werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Füllen Sie das markierte Felder aus, um einen Kunden zu löschen!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                && !tb_Nachname.Text.Equals(""))
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
                    if (!tb_Klasse.Text.Equals("") && !CheckSpecialNumbers(tb_Klasse.Text))
                    {
                        errorMessage += "\n - Klasse ist nicht richtig formatiert";
                        tb_Telefonnummer.BackColor = Color.Red;
                        error = true;
                    }
                    if (!tb_Telefonnummer.Text.Equals("") && !CheckSpecialNumbers(tb_Telefonnummer.Text))
                    {
                        errorMessage += "\n - Telefonnummer ist nicht richtig formatiert";
                        tb_Telefonnummer.BackColor = Color.Red;
                        error = true;
                    }
                    if (error)
                    {
                        MetroMessageBox.Show(this, errorMessage, "Fehler!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        SetKundenValues();
                        if (kunde.Faecher.Count > 1 && kunde.Klasse.Klassename.Equals(""))
                        {
                            MetroMessageBox.Show(this, "Sie haben zwar Fächer ausgewählt, aber keine Klasse. Bitte geben Sie auch die Klasse des Schülers an!", "Klasse fehlt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if (kunde.Faecher.Count.Equals(0) && !kunde.Klasse.Klassename.Equals(""))
                        {
                            DialogResult dr = MetroMessageBox.Show(this, "Sie haben zwar eine Klasse ausgewählt, aber keine Fächer. Möchten Sie auch die Fächer angeben?", "Fächer fehlen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (dr == DialogResult.No)
                            {
                                if (kunde.AlreadyExists() && kunde.Activated)
                                {
                                    object[] args = new object[] { kunde.Vorname, kunde.Nachname, kunde.Gd.ToShortDateString() };
                                    string message = String.Format("Es existiert bereits ein Eintrag zu dem Kunden '{0} {1} ({2})'. Bitte überprüfen Sie ihre Angaben!", args);
                                    MetroMessageBox.Show(this, message, "Eintrag bereits vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else if (kunde.AlreadyExists() && !kunde.Activated)
                                {
                                    kunde.ActivateKunde();
                                    kunde.UpdateKunde();
                                }
                                else
                                {
                                    kunde.AddKunde();
                                    ClearForm();
                                    kunde.FillGrid(ref gv_Kunde);
                                    gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Descending);
                                    gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Ascending);

                                    lb_kunde_add.Visible = false;
                                    lb_kunde_add.Text = "Der Kunde wurde hinzugefügt!";
                                    lb_kunde_add.Visible = true;
                                    t.Start();
                                }
                            }
                        }
                        else
                        {
                            if (kunde.AlreadyExists() && kunde.Activated)
                            {
                                object[] args = new object[] { kunde.Vorname, kunde.Nachname, kunde.Gd.ToShortDateString() };
                                string message = String.Format("Es existiert bereits ein Eintrag zu dem Kunden '{0} {1} ({2})'. Bitte überprüfen Sie ihre Angaben!", args);
                                MetroMessageBox.Show(this, message, "Eintrag bereits vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else if (kunde.AlreadyExists() && !kunde.Activated)
                            {
                                kunde.ActivateKunde();
                                kunde.UpdateKunde();
                            }
                            else
                            {
                                kunde.AddKunde();
                                ClearForm();
                                kunde.FillGrid(ref gv_Kunde);
                                gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Descending);
                                gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Ascending);
                                lb_kunde_add.Visible = false;
                                lb_kunde_add.Text = "Der Kunde wurde hinzugefügt!";
                                lb_kunde_add.Visible = true;
                                t.Start();
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MetroMessageBox.Show(this, ex.Message + "Der Kunde konnte nicht hinzugefügt werden!", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Füllen Sie alle Felder aus, um einen neuen Kunden hinzuzufügen!", "Achtung",
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
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
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
                string index = row.Cells["Kunden-ID"].Value.ToString();
                ClearForm();
                LoadKunde(index);
                rb_KundeBearbeiten.Checked = true;
            }
        }

        private void bt_ImEx_Click(object sender, EventArgs e)
        {
            Form import = new w_s_schuelerimport("t_s_schueler", true, currentUser);
            import.ShowDialog(this);
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
        }

        private void gv_faecher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_faecher.Rows[e.RowIndex];
                if (gv_faecher.Rows[e.RowIndex].DefaultCellStyle.BackColor != Color.Yellow)
                {
                    if (row.Cells["Kürzel"].Value.ToString() != "")
                    {
                        kunde.Fach = new Fach(row.Cells["ID"].Value.ToString());
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.SelectionBackColor = Color.Gold;
                        gv_result.Rows.Add(kunde.Fach.FachKurz, kunde.Fach.FachID);
                    }
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.White;
                    row.DefaultCellStyle.SelectionBackColor = gv_result.DefaultCellStyle.SelectionBackColor;
                    for (int i = 0; i < gv_result.Rows.Count; i++)
                    {
                        DataGridViewRow gvRow = gv_result.Rows[i];
                        if (gvRow.Cells["ID"].Value.ToString() == row.Cells["ID"].Value.ToString())
                        {
                            gv_result.Rows.RemoveAt(i);
                            i = gv_result.Rows.Count;
                        }
                    }
                }
            }
        }

        private void gv_result_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_result.Rows[e.RowIndex];
                if (row.Cells["Kürzel"].Value != null && !row.Cells["Kürzel"].Value.Equals(""))
                {
                    kunde.Fach = new Fach(row.Cells["ID"].Value.ToString());
                    if (row.DefaultCellStyle.BackColor == Color.Yellow)
                    {
                        kunde.Leistungskurse--;
                    }
                    gv_result.Rows.RemoveAt(e.RowIndex);

                    for (int i = 0; i < gv_faecher.Rows.Count; i++)
                    {
                        DataGridViewRow gvRow = gv_faecher.Rows[i];
                        if (gvRow.Cells["ID"].Value.ToString() == kunde.Fach.FachID)
                        {
                            gvRow.DefaultCellStyle.BackColor = Color.White;
                            gvRow.DefaultCellStyle.SelectionBackColor = gv_result.DefaultCellStyle.SelectionBackColor;
                            i = gv_faecher.Rows.Count;
                        }
                    }
                }
            }
        }

        private void leistungskursAuswählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (leistungskursAuswählenToolStripMenuItem.Text == "als Leistungskurs markieren")
            {
                if (kunde.Leistungskurse >= 2)
                {
                    MetroMessageBox.Show(this, "Sie haben bereits beide Leistungskurse vergeben. Bitte markieren Sie zunächst einen dieser als Grundkurs.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    gv_result.SelectedRows[0].Cells["Kürzel"].Value = "*" + gv_result.SelectedRows[0].Cells["Kürzel"].Value.ToString();
                    gv_result.SelectedRows[0].DefaultCellStyle.BackColor = Color.Yellow;
                    kunde.Leistungskurse++;
                }
            }
            else
            {
                gv_result.SelectedRows[0].Cells["Kürzel"].Value = gv_result.SelectedRows[0].Cells["Kürzel"].Value.ToString().Substring(1);
                gv_result.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
                kunde.Leistungskurse--;
            }
        }

        private void gv_result_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (!gv_result.Rows[e.RowIndex].Selected)
                {
                    gv_result.ClearSelection();
                    gv_result.Rows[e.RowIndex].Selected = true;
                }
                if (gv_result.Rows[e.RowIndex].DefaultCellStyle.BackColor == Color.Yellow)
                {
                    leistungskursAuswählenToolStripMenuItem.Text = "als Grundkurs markieren";
                }
                else
                {
                    leistungskursAuswählenToolStripMenuItem.Text = "als Leistungskurs markieren";
                }
            }
        }

        private void rb_alles_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_FilterAlles.Checked)
            {
                (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%' AND Straße LIKE '{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Klasse LIKE '{6}%' AND Mail LIKE '{7}%' AND Telefonnummer LIKE '{8}%'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, tb_Klasse.Text, tb_Mail.Text, tb_Telefonnummer.Text);
            }
            else if (rb_FilterSchueler.Checked)
            {
                (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%' AND Straße LIKE '{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Klasse LIKE '{6}%' AND Mail LIKE '{7}%' AND Telefonnummer LIKE '{8}%' AND Klasse NOT LIKE '{9}'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, tb_Klasse.Text, tb_Mail.Text, tb_Telefonnummer.Text, "");
            }
            else if (rb_FilterAndere.Checked)
            {
                (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%' AND Straße LIKE '{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Klasse LIKE '{6}%' AND Mail LIKE '{7}%' AND Telefonnummer LIKE '{8}%' AND Klasse LIKE '{9}'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, tb_Klasse.Text, tb_Mail.Text, tb_Telefonnummer.Text, "");
            }
        }

        private void kundeBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rb_KundeBearbeiten.Checked = true;
            LoadKunde(gv_Kunde.SelectedRows[0].Cells["Kunden-ID"].Value.ToString());
        }

        private void kundeEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int errors = 0;
            List<string> errorMessages = new List<string>();
            int rows = 0;
            foreach (DataGridViewRow row in gv_Kunde.SelectedRows)
            {
                rows++;
                try
                {
                    kunde.KundenID = row.Cells["Kunden-ID"].Value.ToString();
                    if (!kunde.Ausgeliehen())
                    {
                        kunde.DeactivateKunde();
                    }
                    else
                    {
                        errors++;
                        errorMessages.Add(String.Format("Der Kunde '{0}, {1}' konnte nicht entfernt werden, da er noch in einem Ausleihvorgang involviert ist. Bitte markieren Sie zuerst alle Bücher als 'zurückgegeben', damit der Datensatz entfernt werden kann.", row.Cells["Nachname"].Value, row.Cells["Vorname"].Value));
                    }
                    ClearForm();
                }
                catch (SqlException)
                {
                    errorMessages.Add(String.Format("Der Kunde '{0}, {1}'konnte aufgrund eines Problemes mit der Datenbank nicht entfernt werden.", row.Cells["Nachname"].Value, row.Cells["Vorname"].Value));
                    errors++;
                }
            }
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            if (errors > 0)
            {
                DialogResult dr = MetroMessageBox.Show(this, String.Format("Es wurden '{0}' von '{1}' Kunden gelöscht. \n\nMöchten Sie die Fehler einsehen?", rows - errors, rows), "Fehler beim Löschvorgang", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < errorMessages.Count; i++)
                    {
                        DialogResult result = MetroMessageBox.Show(this, errorMessages[i] + "\n\nWählen Sie 'Ja' für den nächsten Fehler oder 'Nein' zum Beenden.", String.Format("Fehler '{0}' von '{1}'", i + 1, errorMessages.Count), MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (result == DialogResult.No)
                        {
                            i = errorMessages.Count;
                        }
                    }
                }
            }
        }

        private void gv_Kunde_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (new Benutzer(currentUser).Rechteid != "0")
            {
                if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    if (!gv_Kunde.Rows[e.RowIndex].Selected)
                    {
                        gv_Kunde.ClearSelection();
                        gv_Kunde.Rows[e.RowIndex].Selected = true;
                    }
                    if (gv_Kunde.SelectedRows.Count > 1)
                    {
                        kundeBearbeitenToolStripMenuItem.Text = "Ausgewählten Kunden bearbeiten";
                        kundeBearbeitenToolStripMenuItem.Enabled = false;
                        kundeEntfernenToolStripMenuItem.Text = "Ausgewählte Kunden entfernen (" + gv_Kunde.SelectedRows.Count + ")";
                        kundeEntfernenToolStripMenuItem.Enabled = true;
                    }
                    else
                    {
                        kundeBearbeitenToolStripMenuItem.Text = "Ausgewählten Kunden bearbeiten";
                        kundeBearbeitenToolStripMenuItem.Enabled = true;
                        kundeEntfernenToolStripMenuItem.Text = "Ausgewählten Kunden entfernen";
                        kundeEntfernenToolStripMenuItem.Enabled = true;
                    }
                }
            }
        }

        private void bt_cleanup_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(this, "Bitte verwenden Sie diese Funktion nur zu Beginn/Ende des Schuljahres bzw. bevor Sie aktualisierte Schülerdaten für alle Schüler importieren möchten. Dieser Vorgang wird sämtliche Datensätze der Schüler deaktivieren. \n\nSoll fortgefahren werden? \n\nHinweis: Schüler, die in einem aktiven Ausleihvorgang involviert sind, sind davon nicht betroffen.", "Fortfahren?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Dieser Vorgang wird sämtliche Datensätze der Schüler deaktivieren. Dies kann nicht rückgängig gemacht werden. \n\nSoll fortgefahren werden?", "Achtung!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        kunde.DeactivateAllSchueler();
                        if (!backgroundWorker1.IsBusy)
                        {
                            backgroundWorker1.RunWorkerAsync();
                        }
                        DialogResult drFinished = MetroMessageBox.Show(this, "Die Datenbank wurde erfolgreich von allen Schülern bereinigt. Wollen Sie zum Import wechseln?", "Vorgang erfolgreich", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (drFinished == DialogResult.Yes)
                        {
                            Form import = new w_s_schuelerimport("t_s_schueler", true, currentUser);
                            this.Hide();
                            import.ShowDialog(this);
                            this.Show();
                            if (!backgroundWorker1.IsBusy)
                            {
                                backgroundWorker1.RunWorkerAsync();
                            }
                        }
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Bei dem Vorgang ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            List<string> selectedFachIDs = new List<string>();
            BeginInvoke((Action)delegate ()
            {
                for (int i = 0; i < gv_faecher.Rows.Count; i++)
                {
                    DataGridViewRow row = gv_faecher.Rows[i];
                    if (row.DefaultCellStyle.BackColor == Color.Yellow)
                    {
                        selectedFachIDs.Add(row.Cells["ID"].ToString());
                    }
                }
                metroProgressSpinner1.Visible = true;
                metroProgressSpinner2.Visible = true;
                gv_faecher.Visible = false;
                gv_Kunde.Visible = false;
            });
            MetroGrid mgKunde = new MetroGrid();
            kunde.FillGrid(ref mgKunde);
            DataTable dtFach = new DataTable();
            kunde.Fach.FillDT(ref dtFach);
            var dtKunde = mgKunde.DataSource;
            while (loaded == false)
            {

            }
            try
            {
                BeginInvoke((Action)delegate ()
                {
                    gv_Kunde.DataSource = dtKunde;
                    gv_Kunde.Columns["Fächer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    gv_faecher.DataSource = dtFach;
                    gv_faecher.Columns["ID"].Visible = false;
                    foreach (string s in selectedFachIDs)
                    {
                        for (int i = 0; i < gv_faecher.Rows.Count; i++)
                        {
                            DataGridViewRow row = gv_faecher.Rows[i];
                            if (row.Cells["ID"].ToString().Equals(s))
                            {
                                row.DefaultCellStyle.BackColor = Color.Yellow;
                                row.DefaultCellStyle.SelectionBackColor = Color.Gold;
                                i = gv_faecher.Rows.Count;
                            }
                        }
                    }
                    metroProgressSpinner1.Visible = false;
                    metroProgressSpinner2.Visible = false;
                    gv_faecher.Visible = true;
                    gv_Kunde.Visible = true;
                });
            }
            catch { }
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Descending);
            gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Ascending);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            loaded = true;
        }

        private void Mbt_Export_Click(object sender, EventArgs e)
        {
            ExcelExport export = new ExcelExport();
            export.ExportDataGridViewAsCSV(gv_Kunde);
        }
        #endregion
    }
}
