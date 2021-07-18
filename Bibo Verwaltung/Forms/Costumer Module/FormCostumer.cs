using Bibo_Verwaltung.Helper;
using MetroFramework;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormCostumer : MetroFramework.Forms.MetroForm
    {
        SubjectHelper subjectHelper = new SubjectHelper();
        CostumerHelper costumerHelper = new CostumerHelper();
        SchoolClassHelper classHelper = new SchoolClassHelper();

        #region Constructor
        bool loaded = false;
        bool guest = false;
        int costumerId = -1;
        public FormCostumer(int costumerId)
        {
            InitializeComponent();
            LoadTheme();
            SetPermissions();

            this.Text = Text + AuthInfo.FormInfo();
            this.costumerId = costumerId;
            timer_start.Start();
        }
        public FormCostumer()
        {
            InitializeComponent();
            LoadTheme();
            SetPermissions();

            this.Text = Text + AuthInfo.FormInfo();
            timer_start.Start();
        }
        #endregion
        private void LoadTheme()
        {
            this.StyleManager = styleManagerCostumer;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.CostumerStyle;
            cb_klasse.ForeColor = ThemeInfo.ForeColor;
            cb_klasse.BackColor = ThemeInfo.BackColor;
        }
        private void SetPermissions()
        {
            if (AuthInfo.CurrentUser.PermissionId == 0)
            {
                guest = true;
                GuestMode(guest);
            }
            else if (AuthInfo.CurrentUser.PermissionId == 1)
            {
                guest = false;
                GuestMode(guest);
            }
            else if (AuthInfo.CurrentUser.PermissionId == 2)
            {
                guest = false;
                GuestMode(guest);
            }
        }
        private void GuestMode(bool activate)
        {
            btSubmit.Enabled = !activate;
            mbt_Import.Enabled = !activate;
            mbt_Export.Enabled = !activate;
            bt_cleanup.Enabled = !activate;
            kundeEntfernenToolStripMenuItem.Enabled = !activate;
            if (rbSearch.Checked)
            {
                btSubmit.Enabled = false;
            }
        }

        #region Fenster-Methoden


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
            advancedSubjects.Clear();
            lb_kunde_add.Visible = false;
            tb_Vorname.Text = "";
            tb_Nachname.Text = "";
            mdtp_GebDat.Text = "";
            tb_Strasse.Text = "";
            tb_Hausnummer.Text = "";
            tb_Postleitzahl.Text = "";
            tb_Ort.Text = "";
            cb_klasse.Text = "";
            tb_Mail.Text = "";
            tb_Telefonnummer.Text = "";
            tb_KundenID.Text = "";
            tb_search.Text = "";
            subjectHelper.FillGrid(ref gv_faecher);
            gv_result.Rows.Clear();
            SetBackground_White();
        }

        /// <summary>
        /// Setzt alle Componenten-Hintergrungfarben auf weiß
        /// </summary>
        private void SetBackground_White()
        {
            tb_Vorname.BackColor = ThemeInfo.BackColor;
            tb_Nachname.BackColor = ThemeInfo.BackColor;
            tb_KundenID.BackColor = ThemeInfo.BackColor;
            tb_Hausnummer.BackColor = ThemeInfo.BackColor;
            tb_Strasse.BackColor = ThemeInfo.BackColor;
            tb_Postleitzahl.BackColor = ThemeInfo.BackColor;
            tb_Ort.BackColor = ThemeInfo.BackColor;
            cb_klasse.BackColor = ThemeInfo.BackColor;
            tb_Mail.BackColor = ThemeInfo.BackColor;
            tb_Telefonnummer.BackColor = ThemeInfo.BackColor;
        }

        bool readOnly = false;

        /// <summary>
        /// Setzt die Componenten auf den aktuellen Arbeits-Modus
        /// </summary>
        private void SetModus()
        {

            if (rbUpdate.Checked)
            {
                btSubmit.Text = "Speichern";
                tb_KundenID.Enabled = false;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                mdtp_GebDat.Enabled = true;
                tb_Strasse.Enabled = true;
                tb_Hausnummer.Enabled = true;
                tb_Postleitzahl.Enabled = true;
                tb_Ort.Enabled = true;
                readOnly = false;
                cb_klasse.Enabled = true;
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
            else if (rbAdd.Checked)
            {
                btSubmit.Text = "Hinzufügen";
                tb_KundenID.Text = "";

                tb_KundenID.Enabled = false;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                mdtp_GebDat.Enabled = true;
                tb_Strasse.Enabled = true;
                tb_Hausnummer.Enabled = true;
                tb_Postleitzahl.Enabled = true;
                tb_Ort.Enabled = true;
                readOnly = false;
                cb_klasse.Enabled = true;
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
            else if (rbDelete.Checked)
            {
                btSubmit.Text = "Löschen";
                tb_KundenID.Enabled = true;
                tb_Vorname.Enabled = false;
                tb_Nachname.Enabled = false;
                tb_Strasse.Enabled = false;
                mdtp_GebDat.Enabled = false;
                tb_Hausnummer.Enabled = false;
                tb_Postleitzahl.Enabled = false;
                tb_Ort.Enabled = false;
                readOnly = true;
                //cb_klasse.Enabled = false;
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
            else if (rbSearch.Checked)
            {
                btSubmit.Text = "---";
                tb_KundenID.Enabled = true;
                tb_Vorname.Enabled = true;
                tb_Nachname.Enabled = true;
                mdtp_GebDat.Enabled = true;
                tb_Strasse.Enabled = true;
                tb_Hausnummer.Enabled = true;
                tb_Postleitzahl.Enabled = true;
                tb_Ort.Enabled = true;
                readOnly = false;
                cb_klasse.Enabled = true;
                tb_Mail.Enabled = true;
                tb_Telefonnummer.Enabled = true;
                lb_KundenID.Text = "Kunden-ID:";
                lb_Vorname.Text = "Vorname:";
                lb_Nachname.Text = "Nachname:";
                lb_geburtsdatum.Text = "Geburtsdatum:";
                lb_Strasse.Text = "Strasse:";
                lb_Hausnummer.Text = "Hausnummer:";
                lb_Ort.Text = "Wohnort:";
                lb_Postleitzahl.Text = "Postleitzahl:";
                btSubmit.Enabled = false;
            }
            GuestMode(guest);
            if (readOnly)
            {
                cb_klasse.DataSource = null;
            }
            else if (cb_klasse.DataSource == null)
            {
                classHelper.FillCombobox(ref cb_klasse, 0);
            }

        }

        /// <summary>
        /// Setzt alle Componenten-Hintergrungfarben der Pflichtfelder auf rot
        /// </summary>
        private void SetBackground_Red()
        {
            if (tb_Vorname.Text.Equals(""))
            {
                tb_Vorname.UseCustomBackColor = true;
                tb_Vorname.BackColor = Color.Red;
            }
            else
            {
                tb_Vorname.UseCustomBackColor = false;

                tb_Vorname.BackColor = Color.White;
            }

            if (tb_Nachname.Text.Equals(""))
            {
                tb_Nachname.UseCustomBackColor = true;
                tb_Nachname.BackColor = Color.Red;
            }
            else
            {
                tb_Nachname.UseCustomBackColor = false;

                tb_Nachname.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Sucht nach Kunden in einer GridView
        /// </summary>
        private void KundenFilter()
        {
            try
            {
                if (mdtp_GebDat.Value.Date != DateTime.Now.Date && tb_KundenID.Text != "")
                {
                    (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '%{0}%'AND Nachname LIKE '%{1}%' AND Straße LIKE '%{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Mail LIKE '%{6}%' AND Telefonnummer LIKE '{7}%' AND Convert(Geburtsdatum, System.String) LIKE '{8}%' AND Convert([Kunden-ID], System.String) LIKE '%{9}%' AND Klasse LIKE '{10}%'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, tb_Mail.Text, tb_Telefonnummer.Text, mdtp_GebDat.Value.Date.ToShortDateString(), tb_KundenID.Text, cb_klasse.Text);

                }
                else if (tb_KundenID.Text != "")
                {
                    (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '%{0}%'AND Nachname LIKE '%{1}%' AND Straße LIKE '%{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Mail LIKE '%{6}%' AND Telefonnummer LIKE '{7}%' AND Convert([Kunden-ID], System.String) LIKE '%{8}%' AND Klasse LIKE '{9}%'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, tb_Mail.Text, tb_Telefonnummer.Text, tb_KundenID.Text, cb_klasse.Text);

                }
                else if (mdtp_GebDat.Value.Date != DateTime.Now.Date && tb_KundenID.Text == "")
                {
                    (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '%{0}%'AND Nachname LIKE '%{1}%' AND Straße LIKE '%{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Mail LIKE '%{6}%' AND Telefonnummer LIKE '{7}%' AND Convert(Geburtsdatum, System.String) LIKE '{8}%' AND Klasse LIKE '{6}%'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, tb_Mail.Text, tb_Telefonnummer.Text, mdtp_GebDat.Value.Date.ToShortDateString(), cb_klasse.Text);

                }
                else
                {
                    (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '%{0}%'AND Nachname LIKE '%{1}%' AND Straße LIKE '%{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Mail LIKE '%{6}%' AND Telefonnummer LIKE '{7}%' AND Klasse LIKE '{8}%'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, tb_Mail.Text, tb_Telefonnummer.Text, cb_klasse.Text);

                }
                if (cb_klasse.Text == "" && (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter.Contains(" AND Klasse LIKE '%'"))
                {
                    (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter.Replace(" AND Klasse LIKE '%'", " AND Klasse IS NULL");

                }
                setRadioButton();
            }
            catch
            {

            }

        }

        /// <summary>
        /// Lädt einen Kunden
        /// </summary>
        private void LoadKunde(int costumerId)
        {
            advancedSubjects.Clear();
            Costumer costumer = new Costumer(costumerId);
            tb_KundenID.Text = costumer.CostumerId.ToString();
            tb_Vorname.Text = costumer.CostumerFirstName;
            tb_Nachname.Text = costumer.CostumerSurname;
            mdtp_GebDat.Value = costumer.CostumerBirthDate;
            tb_Strasse.Text = costumer.CostumerStreet;
            tb_Hausnummer.Text = costumer.CostumerHouseNumber;
            tb_Postleitzahl.Text = costumer.CostumerZipcode;
            tb_Ort.Text = costumer.CostumerCity;
            cb_klasse.Text = costumer.CostumerSchoolClass.SchoolClassName;
            tb_Mail.Text = costumer.CostumerEmail;
            tb_Telefonnummer.Text = costumer.CostumerTelephone;
            if (costumer.CostumerSubjects.Count > 0)
            {
                List<int> advancedSubjectIds = new List<int>();
                foreach (Subject advancedSubject in costumer.CostumerAdvancedSubjects)
                {
                    advancedSubjectIds.Add(advancedSubject.SubjectId);
                    advancedSubjects.Add(advancedSubject);
                }
                foreach (Subject subject in costumer.CostumerSubjects)
                {
                    if (advancedSubjectIds.Contains(subject.SubjectId))
                    {
                        gv_result.Rows.Add("*" + subject.SubjectNameShort, subject.SubjectId);
                        gv_result.Rows[gv_result.Rows.Count - 1].DefaultCellStyle.BackColor = Color.Yellow;
                        gv_result.Rows[gv_result.Rows.Count - 1].DefaultCellStyle.SelectionBackColor = Color.Gold;
                    }
                    else
                    {
                        gv_result.Rows.Add(subject.SubjectNameShort, subject.SubjectId);
                    }
                    for (int i = 0; i < gv_faecher.Rows.Count; i++)
                    {
                        DataGridViewRow row = gv_faecher.Rows[i];
                        if (row.Cells["ID"].Value.ToString().Equals(subject.SubjectId.ToString()))
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
        private void btSubmitClicked(object sender, EventArgs e)
        {
            Submit();
        }

        /// <summary>
        /// submits the forms: add / update / delete
        /// </summary>
        private void Submit()
        {
            if (rbAdd.Checked)
            {
                if (InputOkay())
                {
                    try
                    {
                        Add();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Der Kunde konnte nicht hinzugefügt werden!", "Error",
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
            else if (rbUpdate.Checked)
            {
                if (InputOkay())
                {
                    try
                    {
                        UpdateCostumer();
                    }
                    catch(Exception ex)
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
            else if (rbDelete.Checked)
            {
                if (InputOkay())
                {
                    try
                    {
                        Delete();
                    }
                    catch
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
            KundenFilter();
        }

        /// <summary>
        /// checks whether the input is okay
        /// </summary>
        /// <returns></returns>
        private bool InputOkay()
        {
            if (rbAdd.Checked && !tb_Vorname.Text.Equals("") && !tb_Nachname.Text.Equals(""))
            {
                return true;
            }
            else if (rbUpdate.Checked && !tb_Vorname.Text.Equals("") && !tb_Nachname.Text.Equals("") && !tb_KundenID.Text.Equals(""))
            {
                return true;
            }
            else if (rbDelete.Checked && !tb_KundenID.Text.Equals(""))
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// checks whether the form has input errors or not
        /// </summary>
        /// <returns></returns>
        private bool HasInputErrors()
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
            if (!cb_klasse.Text.Equals("") && !CheckSpecialNumbers(cb_klasse.Text))
            {
                errorMessage += "\n - Klasse ist nicht richtig formatiert";
                cb_klasse.BackColor = Color.Red;
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
            }
            return error;
        }

        /// <summary>
        /// fills a costumer object with form data
        /// </summary>
        /// <param name="costumer"></param>
        private void SetValues(ref Costumer costumer)
        {
            if (!tb_KundenID.Text.Equals("")) costumer.CostumerId = int.Parse(tb_KundenID.Text);
            costumer.CostumerFirstName = tb_Vorname.Text;
            costumer.CostumerSurname = tb_Nachname.Text;
            costumer.CostumerBirthDate = mdtp_GebDat.Value.Date;
            costumer.CostumerStreet = tb_Strasse.Text;
            costumer.CostumerHouseNumber = tb_Hausnummer.Text;
            costumer.CostumerZipcode = tb_Postleitzahl.Text;
            costumer.CostumerCity = tb_Ort.Text;

            SchoolClass schoolClass = null;
            if (!cb_klasse.Text.Equals(""))
            {
                int schoolClassId = classHelper.FindIdByName(cb_klasse.Text);
                if (schoolClassId == -1)
                {
                    schoolClass = new SchoolClass();
                    schoolClass.SchoolClassName = cb_klasse.Text;
                    schoolClass.Add();
                    schoolClassId = classHelper.FindIdByName(cb_klasse.Text);
                }
                schoolClass = new SchoolClass(schoolClassId);
            }
            costumer.CostumerSchoolClass = schoolClass;
            costumer.CostumerEmail = tb_Mail.Text;
            costumer.CostumerTelephone = tb_Telefonnummer.Text;
            costumer.CostumerSubjects.Clear();
            costumer.CostumerAdvancedSubjects.Clear();
            foreach (DataGridViewRow row in gv_result.Rows)
            {
                if (row.Cells["Kürzel"].Value != null && row.Cells["Kürzel"].Value.ToString() != "")
                {
                    Subject subject = new Subject(int.Parse(row.Cells["ID"].Value.ToString()));
                    if (row.DefaultCellStyle.BackColor == Color.Yellow)
                    {
                        costumer.CostumerAdvancedSubjects.Add(subject);
                    }
                    costumer.CostumerSubjects.Add(subject);
                }
            }
            for (int i = costumer.CostumerAdvancedSubjects.Count; i < 2; i++)
            {
                costumer.CostumerAdvancedSubjects.Add(new Subject());
            }
        }

        /// <summary>
        /// shows a success message
        /// </summary>
        private void ShowMessage()
        {
            System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, a) =>
            {
                lb_kunde_add.Hide();
                t.Stop();
                t.Dispose();
            };
            lb_kunde_add.Visible = true;
            t.Start();

        }

        /// <summary>
        /// adds the costumer to database
        /// </summary>
        private void Add()
        {
            lb_kunde_add.Text = "Der Kunde wurde hinzugefügt!";
            if (HasInputErrors()) return;
            Costumer costumer = new Costumer();
            SetValues(ref costumer);
            if (costumer.CostumerSubjects.Count > 1 && costumer.CostumerSchoolClass.SchoolClassName.Equals(""))
            {
                MetroMessageBox.Show(this, "Sie haben zwar Fächer ausgewählt, aber keine Klasse. " +
                    "Bitte geben Sie auch die Klasse des Schülers an!", "Klasse fehlt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (costumer.CostumerSubjects.Count.Equals(0) && costumer.CostumerSchoolClass!=null && costumer.CostumerSchoolClass.SchoolClassName != null && !costumer.CostumerSchoolClass.SchoolClassName.Equals(""))
            {
                DialogResult dr = MetroMessageBox.Show(this, "Sie haben zwar eine Klasse ausgewählt, aber keine Fächer. " +
                    "Möchten Sie auch die Fächer angeben?", "Fächer fehlen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    //costumer will be added with a school class but without subjects
                    PerformAddition(ref costumer);
                }
            }
            else
            {
                PerformAddition(ref costumer);
            }

        }

        /// <summary>
        /// performs the last steps to determine whether to add / reactivate and update / to abort the addition
        /// </summary>
        /// <param name="costumer"></param>
        private void PerformAddition(ref Costumer costumer)
        {
            object[] args = new object[] { costumer.CostumerFirstName, costumer.CostumerSurname, costumer.CostumerBirthDate.ToShortDateString() };
            bool alreadyExists = costumer.AlreadyExists(false);
            if (alreadyExists && costumer.CostumerActivated)
            {
                string message = string.Format("Es existiert bereits ein Eintrag zu dem Kunden '{0} {1} ({2})'. Bitte überprüfen Sie ihre Angaben!", args);
                MetroMessageBox.Show(this, message, "Eintrag bereits vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (alreadyExists && !costumer.CostumerActivated)
            {
                costumer.ActivateCostumer();
                costumer.UpdateCostumer();
                string message = String.Format("Es existiert bereits ein deaktivierter Eintrag zu dem Kunden '{0} {1} ({2})'. Der betroffene Eintrag wurde stattdessen reaktiviert und aktualisiert.", args);
                MetroMessageBox.Show(this, message, "Eintrag bereits vorhanden", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                costumer.AddCostumer();
                ClearForm();
                costumerHelper.FillGrid(ref gv_Kunde);
                gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Descending);
                gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Ascending);
                ShowMessage();
            }
        }

        /// <summary>
        /// updates the costumer
        /// </summary>
        private void UpdateCostumer()
        {
            Costumer costumer = new Costumer();
            SetValues(ref costumer);
            if (costumer.AlreadyExists(true))
            {
                DialogResult dr = MetroMessageBox.Show(this, "Ein Kunde mit diesem Vornamen, Nachnamen und Geburtsdatum existiert bereits." +
                    " Die betreffenden Kunden wären dann nur anhand der anderen Felder (ID, Straße, Ort,...) unterscheidbar. " +
                    "Trotzdem hinzufügen?", "Kunde schon vorhanden.", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    PerformUpdate(ref costumer);
                }
                else
                {
                    lb_kunde_add.Text = "Der Kunde wurde nicht bearbeitet!";
                }
            }
            else
            {
                costumer.CostumerId = int.Parse(tb_KundenID.Text);
                PerformUpdate(ref costumer);
            }
            ShowMessage();
        }

        /// <summary>
        /// performs the update
        /// </summary>
        /// <param name="costumer"></param>
        private void PerformUpdate(ref Costumer costumer)
        {
            costumer.UpdateCostumer();
            ClearForm();
            costumerHelper.FillGrid(ref gv_Kunde);
            gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Descending);
            gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Ascending);
            lb_kunde_add.Text = "Der Kunde wurde bearbeitet!";
        }

        /// <summary>
        /// deactivates a costumer (will remain in database, but deactivated)
        /// </summary>
        private void Delete()
        {
            Costumer costumer = new Costumer(int.Parse(tb_KundenID.Text));
            if (!costumer.HasBorrowedSomething())
            {
                costumer.DeactivateCostumer();
                ClearForm();
                costumerHelper.FillGrid(ref gv_Kunde);
                lb_kunde_add.Text = "Der Kunde wurde gelöscht!";
                ShowMessage();
            }
            else
            {
                MetroMessageBox.Show(this, "Der Kunde konnte nicht entfernt werden, da er noch in einem Ausleihvorgang involviert ist. Bitte markieren Sie zuerst alle Bücher als 'zurückgegeben', damit der Datensatz entfernt werden kann.", "Löschen nicht möglich", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btClearClicked(object sender, EventArgs e)
        {
            ClearForm();
        }

        /// <summary>
        /// radio button checked changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCheckedChanged(object sender, EventArgs e)
        {
            SetModus();
            SetBackground_White();
        }
        private void Rb_search_CheckedChanged(object sender, EventArgs e)
        {
            SetModus();
            SetBackground_White();
        }
        private void tb_KundenID_TextChanged(object sender, EventArgs e)
        {
            tb_KundenID.BackColor = ThemeInfo.BackColor;
            KundenFilter();
        }

        private void tb_Vorname_TextChanged(object sender, EventArgs e)
        {
            tb_Vorname.UseCustomBackColor = false;
            tb_Vorname.BackColor = ThemeInfo.BackColor;
            KundenFilter();
        }

        private void tb_Nachname_TextChanged(object sender, EventArgs e)
        {
            tb_Nachname.UseCustomBackColor = false;
            tb_Nachname.BackColor = ThemeInfo.BackColor;
            KundenFilter();
        }

        private void tb_Strasse_TextChanged(object sender, EventArgs e)
        {
            tb_Strasse.BackColor = ThemeInfo.BackColor;
            KundenFilter();
        }

        private void tb_Hausnummer_TextChanged(object sender, EventArgs e)
        {
            tb_Hausnummer.BackColor = ThemeInfo.BackColor;
            KundenFilter();
        }

        private void tb_Postleitzahl_TextChanged(object sender, EventArgs e)
        {
            tb_Postleitzahl.BackColor = ThemeInfo.BackColor;
            KundenFilter();
        }

        private void tb_Ort_TextChanged(object sender, EventArgs e)
        {
            tb_Ort.BackColor = ThemeInfo.BackColor;
            KundenFilter();
        }

        private void cb_klasse_TextChanged(object sender, EventArgs e)
        {
            cb_klasse.BackColor = ThemeInfo.BackColor;
            KundenFilter();
        }

        private void tb_Mail_TextChanged(object sender, EventArgs e)
        {
            tb_Mail.BackColor = ThemeInfo.BackColor;
            KundenFilter();
        }

        private void tb_Telefonnummer_TextChanged(object sender, EventArgs e)
        {
            tb_Telefonnummer.BackColor = ThemeInfo.BackColor;
            KundenFilter();
        }

        private void Grid_Kunde_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_Kunde.Rows[e.RowIndex];
                int index = int.Parse(row.Cells["Kunden-ID"].Value.ToString());
                ClearForm();
                LoadKunde(index);
                rbUpdate.Checked = true;
            }
        }

        private void bt_ImEx_Click(object sender, EventArgs e)
        {
            FormStudentSubjectImport import = new FormStudentSubjectImport("t_s_schueler", true);
            import.ShowDialog(this);
            import.Dispose();
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
                        Subject subject = new Subject(int.Parse(row.Cells["ID"].Value.ToString()));
                        row.DefaultCellStyle.BackColor = Color.Yellow;
                        row.DefaultCellStyle.SelectionBackColor = Color.Gold;
                        gv_result.Rows.Add(subject.SubjectNameShort, subject.SubjectId);
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
                    Subject subject = new Subject(int.Parse(row.Cells["ID"].Value.ToString()));
                    gv_result.Rows.RemoveAt(e.RowIndex);

                    for (int i = 0; i < gv_faecher.Rows.Count; i++)
                    {
                        DataGridViewRow gvRow = gv_faecher.Rows[i];
                        if (int.Parse(gvRow.Cells["ID"].Value.ToString()) == subject.SubjectId)
                        {
                            gvRow.DefaultCellStyle.BackColor = Color.White;
                            gvRow.DefaultCellStyle.SelectionBackColor = gv_result.DefaultCellStyle.SelectionBackColor;
                            i = gv_faecher.Rows.Count;
                        }
                    }
                }
            }
        }

        List<Subject> advancedSubjects = new List<Subject>();
        private void MarkAsAdvancedSubject()
        {
            if (leistungskursAuswählenToolStripMenuItem.Text == "als Leistungskurs markieren")
            {
                if (advancedSubjects.Count >= 2)
                {
                    MetroMessageBox.Show(this, "Sie haben bereits beide Leistungskurse vergeben. Bitte markieren Sie zunächst einen dieser als Grundkurs.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    advancedSubjects.Add(new Subject(subjectHelper.GetIdBySubjectShortName(gv_result.SelectedRows[0].Cells["Kürzel"].Value.ToString())));
                    gv_result.SelectedRows[0].Cells["Kürzel"].Value = "*" + gv_result.SelectedRows[0].Cells["Kürzel"].Value.ToString();
                    gv_result.SelectedRows[0].DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
            else
            {
                for(int i = 0; i< advancedSubjects.Count;i++)
                {
                    Subject subj = advancedSubjects[i];
                    if (subj.SubjectNameShort == gv_result.SelectedRows[0].Cells["Kürzel"].Value.ToString().Substring(1))
                    {
                        advancedSubjects.RemoveAt(i);

                    }
                }
                gv_result.SelectedRows[0].Cells["Kürzel"].Value = gv_result.SelectedRows[0].Cells["Kürzel"].Value.ToString().Substring(1);
                gv_result.SelectedRows[0].DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void leistungskursAuswählenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tb_KundenID.Text != "")
            {
                MarkAsAdvancedSubject();
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

        private void setRadioButton()
        {
            if (rb_FilterAlles.Checked)
            {
                (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter.Replace(" AND Klasse IS NOT NULL", "");
                (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter.Replace(" AND Klasse IS NULL", "");
                //(gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%' AND Straße LIKE '{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Klasse LIKE '{6}%' AND Mail LIKE '{7}%' AND Telefonnummer LIKE '{8}%'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, cb_klasse.Text, tb_Mail.Text, tb_Telefonnummer.Text);
            }
            else if (rb_FilterSchueler.Checked)
            {
                (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter.Replace(" AND Klasse IS NULL", " AND Klasse IS NOT NULL");
                if (!(gv_Kunde.DataSource as DataTable).DefaultView.RowFilter.Contains(" AND Klasse IS NOT NULL")) (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter + " AND Klasse IS NOT NULL";
                //(gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%' AND Straße LIKE '{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Klasse LIKE '{6}%' AND Mail LIKE '{7}%' AND Telefonnummer LIKE '{8}%' AND Klasse NOT LIKE '{9}'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, cb_klasse.Text, tb_Mail.Text, tb_Telefonnummer.Text, "");
            }
            else if (rb_FilterAndere.Checked)
            {
                (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter.Replace(" AND Klasse IS NOT NULL", " AND Klasse IS NULL");
                if (!(gv_Kunde.DataSource as DataTable).DefaultView.RowFilter.Contains(" AND Klasse IS NULL")) (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = (gv_Kunde.DataSource as DataTable).DefaultView.RowFilter + " AND Klasse IS NULL";

                //(gv_Kunde.DataSource as DataTable).DefaultView.RowFilter = string.Format("Vorname LIKE '{0}%'AND Nachname LIKE '{1}%' AND Straße LIKE '{2}%' AND Hausnummer LIKE '{3}%' AND Postleitzahl LIKE '{4}%' AND Wohnort LIKE '{5}%' AND Klasse LIKE '{6}%' AND Mail LIKE '{7}%' AND Telefonnummer LIKE '{8}%' AND Klasse LIKE '{9}'", tb_Vorname.Text, tb_Nachname.Text, tb_Strasse.Text, tb_Hausnummer.Text, tb_Postleitzahl.Text, tb_Ort.Text, cb_klasse.Text, tb_Mail.Text, tb_Telefonnummer.Text, "");
            }
        }
        private void rb_alles_CheckedChanged(object sender, EventArgs e)
        {
            setRadioButton();
        }

        private void kundeBearbeitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rbUpdate.Checked = true;
            LoadKunde(int.Parse(gv_Kunde.SelectedRows[0].Cells["Kunden-ID"].Value.ToString()));
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
                    Costumer costumer = new Costumer(int.Parse(row.Cells["Kunden-ID"].Value.ToString()));
                    if (!costumer.HasBorrowedSomething())
                    {
                        costumer.DeactivateCostumer();
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
            GuestMode(guest);
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
                        costumerHelper.DeactivateAllStudents();
                        if (!backgroundWorker1.IsBusy)
                        {
                            backgroundWorker1.RunWorkerAsync();
                        }
                        DialogResult drFinished = MetroMessageBox.Show(this, "Die Datenbank wurde erfolgreich von allen Schülern bereinigt. Wollen Sie zum Import wechseln?", "Vorgang erfolgreich", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (drFinished == DialogResult.Yes)
                        {
                            FormStudentSubjectImport import = new FormStudentSubjectImport("t_s_schueler", true);
                            this.Hide();
                            import.ShowDialog(this);
                            import.Dispose();
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

                metroProgressSpinner1.Visible = true;
                metroProgressSpinner2.Visible = true;
                gv_faecher.Visible = false;
                gv_Kunde.Visible = false;
            });

            while (loaded == false)
            {

            }
            MetroGrid mgKunde = new MetroGrid();
            costumerHelper.FillGrid(ref mgKunde);
            DataTable subjectTable = subjectHelper.GetDataTable();
            var dtKunde = mgKunde.DataSource;
            try
            {
                BeginInvoke((Action)delegate ()
                {
                    gv_Kunde.DataSource = null;
                    gv_Kunde.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    gv_Kunde.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    gv_Kunde.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    gv_Kunde.AllowUserToResizeColumns = true;
                    gv_Kunde.RowHeadersVisible = false;
                    gv_Kunde.DataSource = dtKunde;
                    //gv_Kunde.Columns["Fächer"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                    gv_faecher.DataSource = null;
                    //gv_faecher.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                    gv_faecher.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
                    gv_faecher.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                    gv_faecher.AllowUserToResizeColumns = true;
                    gv_faecher.RowHeadersVisible = false;
                    gv_faecher.DataSource = subjectTable;
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
                    classHelper.FillCombobox(ref cb_klasse, 0);
                    for (int i = 0; i < gv_faecher.Rows.Count; i++)
                    {
                        DataGridViewRow row = gv_faecher.Rows[i];
                        if (row.DefaultCellStyle.BackColor == Color.Yellow)
                        {
                            selectedFachIDs.Add(row.Cells["ID"].ToString());
                        }
                    }
                });
            }
            catch
            {
                metroProgressSpinner1.Visible = false;
                metroProgressSpinner2.Visible = false;
                gv_faecher.Visible = true;
                gv_Kunde.Visible = true;
            }
        }

        private void BackgroundWorker1_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            try
            {
                gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Descending);
                gv_Kunde.Sort(gv_Kunde.Columns["Nachname"], System.ComponentModel.ListSortDirection.Ascending);
                KundenFilter();
                if (costumerId > -1)
                {
                    LoadKunde(costumerId);
                }
                //SetModus();
            }
            catch
            {

            }

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            loaded = true;
        }

        private void Mbt_Export_Click(object sender, EventArgs e)
        {
            ExcelExport export = new ExcelExport();
            try
            {
                export.ExportDataGridViewAsCSV(gv_Kunde);
                MetroMessageBox.Show(this, "Export erfolgreich abgeschlossen", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Exportvorgang ist ein Fehler aufgetreten!", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void Mdtp_GebDat_ValueChanged(object sender, EventArgs e)
        {
            KundenFilter();
        }

        private void Gv_Kunde_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(gv_Kunde.HitTest(e.X, e.Y).RowIndex >= 0) || !(gv_Kunde.HitTest(e.X, e.Y).ColumnIndex >= 0))
            {
                gv_Kunde.ClearSelection();
                kundeBearbeitenToolStripMenuItem.Visible = false;
                kundeEntfernenToolStripMenuItem.Visible = false;
            }
            else
            {
                kundeBearbeitenToolStripMenuItem.Visible = true;
                kundeEntfernenToolStripMenuItem.Visible = true;
            }
        }

        private void Gv_result_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(gv_result.HitTest(e.X, e.Y).RowIndex >= 0) || !(gv_result.HitTest(e.X, e.Y).ColumnIndex >= 0))
            {
                gv_result.ClearSelection();
                leistungskursAuswählenToolStripMenuItem.Visible = false;
            }
            else
            {
                leistungskursAuswählenToolStripMenuItem.Visible = true;
            }
        }

        private void Bt_klasse_s_Click(object sender, EventArgs e)
        {
            FormAttribute formSchoolClass = new FormAttribute("Klasse");
            formSchoolClass.ShowDialog(this);
            formSchoolClass.Dispose();
            classHelper.FillCombobox(ref cb_klasse, 0);
        }

        private void Gv_faecher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gv_faecher.SelectedRows[0].Index >= 0)
                {
                    DataGridViewRow row = this.gv_faecher.SelectedRows[0];
                    if (gv_faecher.SelectedRows[0].DefaultCellStyle.BackColor != Color.Yellow)
                    {
                        if (row.Cells["Kürzel"].Value.ToString() != "")
                        {
                            Subject subject = new Subject(int.Parse(row.Cells["ID"].Value.ToString()));
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.SelectionBackColor = Color.Gold;
                            gv_result.Rows.Add(subject.SubjectNameShort, subject.SubjectId);
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
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                gv_result.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Gv_result_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gv_result.SelectedRows[0].Index >= 0)
                {
                    DataGridViewRow row = this.gv_result.SelectedRows[0];
                    if (row.Cells["Kürzel"].Value != null && !row.Cells["Kürzel"].Value.Equals(""))
                    {
                        Subject subject = new Subject(int.Parse(row.Cells["ID"].Value.ToString()));
                        gv_result.Rows.RemoveAt(gv_result.SelectedRows[0].Index);

                        for (int i = 0; i < gv_faecher.Rows.Count; i++)
                        {
                            DataGridViewRow gvRow = gv_faecher.Rows[i];
                            if (int.Parse(gvRow.Cells["ID"].Value.ToString()) == subject.SubjectId)
                            {
                                gvRow.DefaultCellStyle.BackColor = Color.White;
                                gvRow.DefaultCellStyle.SelectionBackColor = gv_result.DefaultCellStyle.SelectionBackColor;
                                i = gv_faecher.Rows.Count;
                            }
                        }
                    }
                }
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                btClear.Focus();
                e.SuppressKeyPress = true;
            }
        }

        private void Gv_Kunde_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (gv_Kunde.SelectedRows[0].Index >= 0)
                {
                    DataGridViewRow row = this.gv_Kunde.SelectedRows[0];
                    int index = int.Parse(row.Cells["Kunden-ID"].Value.ToString());
                    ClearForm();
                    LoadKunde(index);
                    rbUpdate.Checked = true;
                }
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                mbt_Import.Focus();
                e.SuppressKeyPress = true;
            }

        }

        private void Cb_klasse_KeyDown(object sender, KeyEventArgs e)
        {
            if (readOnly) e.SuppressKeyPress = true;
        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }
        private void Filter()
        {
            (gv_faecher.DataSource as DataTable).DefaultView.RowFilter = string.Format("Kürzel LIKE '%{0}%'", tb_search.Text);
            SetColor();
        }
        private void SetColor()
        {
            if (tb_KundenID.Text != "")
            {
                Costumer costumer = new Costumer(int.Parse(tb_KundenID.Text));
                foreach (Subject subject in costumer.CostumerSubjects)
                {
                    for (int i = 0; i < gv_faecher.Rows.Count; i++)
                    {
                        DataGridViewRow row = gv_faecher.Rows[i];
                        if (int.Parse(row.Cells["ID"].Value.ToString()) == subject.SubjectId)
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.SelectionBackColor = Color.Gold;
                            i = gv_faecher.Rows.Count;
                        }
                    }
                }
            }
            else
            {
                //Neukunde
                foreach (DataGridViewRow dr in gv_result.Rows)
                {
                    string subjectNameShort = dr.Cells["Kürzel"].Value.ToString();
                    int subjectId = subjectHelper.GetIdBySubjectShortName(subjectNameShort);
                    for (int i = 0; i < gv_faecher.Rows.Count; i++)
                    {
                        DataGridViewRow row = gv_faecher.Rows[i];
                        if (int.Parse(row.Cells["ID"].Value.ToString()) == subjectId)
                        {
                            row.DefaultCellStyle.BackColor = Color.Yellow;
                            row.DefaultCellStyle.SelectionBackColor = Color.Gold;
                            i = gv_faecher.Rows.Count;
                        }
                    }
                }

            }

        }

        private void gv_faecher_Sorted(object sender, EventArgs e)
        {
            SetColor();
        }

        private void timer_start_Tick(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
            timer_start.Stop();
        }
    }
}
