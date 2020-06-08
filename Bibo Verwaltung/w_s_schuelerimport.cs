using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_schuelerimport : MetroFramework.Forms.MetroForm
    {
        string currentUser;
        char seperator = ';';
        char feldquali = '"';
        char dattrenn = '.';
        char zeittrenn = ':';
        char dezsym = ',';
        string target = "";
        string filename = "";
        bool multiselect = false;
        /// <summary>
        /// Anzahl der Dateien insgesamt
        /// </summary>
        int filesTotal = 0;
        /// <summary>
        /// Anzahl der fertigen Dateien
        /// </summary>
        int filesDone = 0;
        /// <summary>
        /// Nummer der aktuellen Datei
        /// </summary>
        int fileNum = 0;
        Schuelerimport schuelerImport = new Schuelerimport();
        List<string> files = new List<string>();
        List<string> filesShort = new List<string>();
        int errors = 0;
        public w_s_schuelerimport(string target, bool modus, string userName)
        {
            this.currentUser = userName;
            this.target = target;
            InitializeComponent();
            tb_lines.Text = "0";
            setModus(modus);
            SetTarget();
            ImportMode();
            CheckSelected();
            SetSlider();
            this.Text = Text + " - Angemeldet als: " + userName;
            timer1.Start();
        }
        /// <summary>
        /// Umschaltung zwischen Importieren und Exportieren
        /// </summary>
        /// <param name="modus"></param>
        private void setModus(bool modus)
        {
            if (modus == true)
            {
                //lb_anweissung.Text = "Geben Sie die Quelle der zu importierenden Daten an.";
                bt_usepreset.Text = "Vorlage anwenden";
            }
            else
            {
                //lb_anweissung.Text = "Geben Sie das Ziel der zu exportierenden Daten an.";
                bt_usepreset.Text = "Exportieren";
            }
        }

        #region Main-Functions
        /// <summary>
        /// läd die entsprechenden Werte, die für das Importformat wichtig sind
        /// </summary>
        private void getValuesFromControls()
        {

            trennError = false;
            qualiError = false;
            string feldtrenn = cb_FeldTrenn.Text;
            string txtqualifier = cb_TxtQuali.Text;
            //string zieltabelle = cb_Ziel.Text;

            //Seperator
            if (feldtrenn == "," | feldtrenn == ";" | feldtrenn == "{Leerzeichen}")
            {
                if (feldtrenn == "{Leerzeichen}")
                {
                    feldtrenn = " ";
                }
                seperator = Convert.ToChar(feldtrenn);
            }
            else if (feldtrenn == "{Tabulator}")
            {
                seperator = '\t';
            }
            else
            {
                trennError = true;
                //MetroMessageBox.Show(this,"Das Feldtrennzeichen ist ungülig! Wählen Sie eines der gültigen Trennzeichen des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Textqualifizierer
            if (txtqualifier == "'" | txtqualifier == "\"")
            {
                feldquali = Convert.ToChar(txtqualifier);
            }
            else
            {
                qualiError = true;
                //MetroMessageBox.Show(this,"Der Textqualifizierer ist ungülig! Wählen Sie einen der gültigen Textqualifizierer des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            schuelerImport.Separator = seperator;
            schuelerImport.Textqualifizierer = feldquali;
            schuelerImport.ColumnHeader = cb_ColHeader.Checked;
            schuelerImport.LineNum = int.Parse(tb_lines.Text);
            schuelerImport.Path = tb_aktuell.Text;
        }
        private void getValuesFromPreset()
        {
            Einstellung set = new Einstellung();
            //sek1
            string path = set.HomePath + "\\profil_" + filename + ".txt";
            if (File.Exists(path))
            {
                try
                {
                    removeAt.Clear();
                    indexes.Clear();
                    var lines = File.ReadAllLines(path);
                    schuelerImport.Separator = lines[4][0];
                    //cb_FeldTrenn.Text = lines[4];
                    schuelerImport.Textqualifizierer = lines[7][0];
                    //cb_TxtQuali.Text = lines[7];
                    if (lines[10] == "True")
                    {
                        schuelerImport.ColumnHeader = true;
                        //cb_ColHeader.Checked = true;
                    }
                    else
                    {
                        schuelerImport.ColumnHeader = false;
                        //cb_ColHeader.Checked = false;
                    }
                    schuelerImport.LineNum = int.Parse(lines[13]);
                    //tb_lines.Text = lines[13];
                    bool first = true;
                    for (int i = 16; i < lines.Length;)
                    {
                        if (!lines[i].Contains("--") && first)
                        {
                            removeAt.Add(int.Parse(lines[i]));
                            i++;
                        }
                        else if (lines[i].Contains("--") && first)
                        {
                            first = false;
                            i = i + 2;
                        }
                        if (!lines[i].Contains("--") && !first)
                        {
                            indexes.Add(int.Parse(lines[i]));
                            i++;
                        }
                        else if (lines[i].Contains("--") && !first)
                        {
                            i = lines.Length;
                        }
                    }
                    usePreset = true;
                }
                catch (IOException e)
                {
                    throw new Exception("failed preset", e);
                }
            }
            else
            {
                throw new Exception("no preset");

            }
        }

        /// <summary>
        /// Dieser DataTable wird mit den Vorschaudaten gefüllt, ohne Controls zu beeinträchtigen
        /// </summary>
        ////////////////////////////DataTable previewDT = new DataTable();

        /// <summary>
        /// Lädt DataTable (ohne Zugriff auf Controls) 
        /// </summary>
        /// <param name="file"></param>
        private void fillPreviewDT(string file, ref DataTable privateDataTable, ref DataTable sortedDataTable)
        {
            Schuelerimport si = new Schuelerimport();
            privateDataTable.Reset();
            si.Path = file;
            si.Textqualifizierer = schuelerImport.Textqualifizierer;
            si.Separator = schuelerImport.Separator;
            si.LineNum = schuelerImport.LineNum;
            si.ColumnHeader = schuelerImport.ColumnHeader;
            //try
            //{
            si.FillDataTable(ref privateDataTable);

            //}
            //catch(Exception ex)
            //{
            //    if (ex.Message.Contains("Problem bei Zeile"))
            //    {
            //        int errorcount = int.Parse(ex.Message.Substring(18));
            //        MetroMessageBox.Show(this, String.Format("Es konnten '{0}' Zeilen aufgrund eines Formatierungsproblems nicht gelesen werden. Eventuell liegen Probleme in der Struktur der Quelldatei vor.", errorcount), "Fehler beim Einlesen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //    else if (ex.Message.Equals("Keine Daten", StringComparison.InvariantCultureIgnoreCase))
            //    {
            //        MetroMessageBox.Show(this, "Diese Datei enthält keine Daten!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            foreach (int i in removeAt)
            {
                privateDataTable.Columns.RemoveAt(i);
            }
            try
            {
                sortedDataTable.Reset();
                if (usePreset)
                {
                    createDataTable(ref sortedDataTable, privateDataTable);
                }
                else
                {
                    createDataTableWithControls(ref sortedDataTable);
                }
            }
            catch
            {
                throw new Exception("wrong preset");
            }
        }

        /// <summary>
        /// Zeigt Vorschau mit Zugriff auf Controls
        /// </summary>
        /// <param name="file"></param>
        private void showPreviewControls(string file)
        {
            if (File.Exists(file))
            {
                getValuesFromControls();
                if (trennError && !qualiError)
                {
                    MetroMessageBox.Show(this, "Das Feldtrennzeichen ist ungülig! Wählen Sie eines der gültigen Trennzeichen des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_FeldTrenn.Focus();
                }
                else if (!trennError && qualiError)
                {
                    MetroMessageBox.Show(this, "Der Textqualifizierer ist ungülig! Wählen Sie einen der gültigen Textqualifizierer des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_TxtQuali.Focus();
                }
                else if (trennError && qualiError)
                {
                    MetroMessageBox.Show(this, "Der Textqualifizierer und das Feldtrennzeichen sind ungülig! Wählen Sie einen gültigen Eintrag im Auswahlmenü.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_FeldTrenn.Focus();
                }
                else
                {
                    Schuelerimport im = new Schuelerimport();
                    im.Path = schuelerImport.Path;
                    im.Separator = schuelerImport.Separator;
                    im.Textqualifizierer = schuelerImport.Textqualifizierer;
                    im.ColumnHeader = schuelerImport.ColumnHeader;
                    im.LineNum = schuelerImport.LineNum;
                    im.FillGridViewRows(ref metroGrid_Vorschau);
                    metroGrid_Vorschau.SelectionMode = DataGridViewSelectionMode.CellSelect;
                    //fillPreviewDT(file);
                    //metroGrid_Vorschau.DataSource = null;
                    //metroGrid_Vorschau.DataSource = newDT;
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Der Pfad: " + files[0] + " ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroGrid_Vorschau.DataSource = null;
                tb_path.Focus();
            }
        }

        bool trennError = false;
        bool qualiError = false;


        #endregion

        #region Object-Functions
        /// <summary>
        /// Öffnet FileDialog
        /// </summary>
        private void FileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (multiselect)
            {
                openFileDialog.Title = "Wählen Sie mehrere Dateien für den Datenimport";
            }
            else
            {
                openFileDialog.Title = "Wählen Sie eine Datei für den Datenimport";
            }
            openFileDialog.Filter = "Text Files|*.txt; *.csv";
            openFileDialog.Multiselect = multiselect;
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (multiselect)
                {
                    for (int i = 0; i < openFileDialog.FileNames.Length; i++)
                    {
                        if (openFileDialog.FileNames[i].Contains(".txt") || openFileDialog.FileNames[i].Contains(".csv"))
                        {
                            files.Add(openFileDialog.FileNames[i]);
                            filesShort.Add(openFileDialog.SafeFileNames[i]);
                            tb_path.Text = tb_path.Text + openFileDialog.SafeFileNames[i] + ", ";
                        }
                    }
                    tb_path.Text = tb_path.Text.Substring(0, tb_path.Text.Length - 2);
                }
                else
                {
                    if (openFileDialog.FileName.Contains(".txt") || openFileDialog.FileName.Contains(".csv"))
                    {
                        tb_path.Text = openFileDialog.SafeFileName;
                        files.Add(openFileDialog.FileName);
                        filesShort.Add(openFileDialog.SafeFileName);
                    }
                    else
                    {
                        tb_path.Text = "";
                        MetroMessageBox.Show(this, "Der angegebene Dateiname ist ungültig. Bitte verwenden sie nur Dateien mit der Endung \'.txt\' oder \'.csv\'!");
                        FileDialog();
                    }
                }

            }
            SetSlider();

        }

        /// <summary>
        /// Klick auf den FileDialog-Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_durchsuchen_Click(object sender, EventArgs e)
        {
            tb_path.Text = "";
            files.Clear();
            filesShort.Clear();
            FileDialog();
            if (tb_path.Text != "")
            {
                tb_aktuell.Text = files[slider_preview.Value - 1];

            }
        }

        private void w_s_importDialog_Shown(object sender, EventArgs e)
        {
            cb_FeldTrenn.SelectedIndex = 1;
            cb_TxtQuali.SelectedIndex = 0;
        }

        /// <summary>
        /// Klick auf Vorschau-Button (Vorschau ohne Vorlage)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_Vorschau_Click(object sender, EventArgs e)
        {
            noPreset();

        }

        private void noPreset()
        {
            usePreset = false;
            removeAt.Clear();
            indexes.Clear();
            try
            {
                //Vorschau ohne Vorlage
                showPreviewControls(tb_aktuell.Text);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("failed preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this, "Der Zugriff auf die Datei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Equals("no preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this, "Es ist noch keine Vorlage für " + filename + " vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.Message.Contains("Problem bei Zeile"))
                {
                    int errorcount = int.Parse(ex.Message.Substring(18));
                    MetroMessageBox.Show(this, String.Format("Es konnten '{0}' Zeilen aufgrund eines Formatierungsproblems nicht gelesen werden. Eventuell liegen Probleme in der Struktur der Quelldatei vor.", errorcount), "Fehler beim Einlesen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Equals("Keine Daten", StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this, "Diese Datei enthält keine Daten!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Equals("Fehler bei Datei", StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this, "Fehler beim Lesen der Datei. Eventuell haben Sie eine zu große Zeilenanzahl zum überspringen angegeben.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroMessageBox.Show(this, "Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        /// <summary>
        /// Leert das Formular
        /// </summary>
        private void clearForm()
        {
            progressBar1.Value = 0;
            tb_path.Text = "";
            tb_lines.Text = "0";
            cb_FeldTrenn.SelectedIndex = 1;
            cb_TxtQuali.SelectedIndex = 0;
            metroGrid_Vorschau.DataSource = null;
            bt_usepreset.Enabled = true;
            bt_Vorschau.Enabled = false;
            metroGrid_Vorschau.Enabled = false;
            metroGrid_Vorschau.DataSource = null;
            lb_Vorschau.Enabled = false;
            lb_Vorschau1.Enabled = false;
            bt_right.Enabled = false;
            bt_left.Enabled = false;
            bt_importSingle.Enabled = false;
        }

        /// <summary>
        /// Prüft, ob der Pfad geändert wurde und handelt dementsprechend
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (tb_path.Text != "")
            {
                bt_importSingle.Enabled = true;
                bt_saveProfile.Enabled = true;
                usePreset = false;
                bt_saveProfile.Enabled = true;
                bt_removefile.Enabled = true;
                bt_accept.Enabled = true;
                if (rb_single.Checked) bt_accept.Enabled = false;
                bt_usepreset.Enabled = true;
                bt_Vorschau.Enabled = true;
                metroGrid_Vorschau.Enabled = true;
                lb_Vorschau.Enabled = true;
                lb_Vorschau1.Enabled = true;
                bt_right.Enabled = true;
                bt_left.Enabled = true;
                bt_importSingle.Enabled = true;
            }
            else
            {
                bt_importSingle.Enabled = false;
                bt_saveProfile.Enabled = false;
                tb_aktuell.Text = "";
                bt_saveProfile.Enabled = false;
                usePreset = false;
                bt_removefile.Enabled = false;
                bt_accept.Enabled = false;
                bt_usepreset.Enabled = false;
                bt_Vorschau.Enabled = false;
                metroGrid_Vorschau.Enabled = false;
                metroGrid_Vorschau.DataSource = null;
                lb_Vorschau.Enabled = false;
                lb_Vorschau1.Enabled = false;
                bt_right.Enabled = false;
                bt_left.Enabled = false;
                bt_importSingle.Enabled = false;
            }
        }

        bool usePreset = false;

        //TODO
        /// <summary>
        /// Klick auf den Button, der das Preset aktiviert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_usePreset_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable privateDT = new DataTable();
                DataTable sortedDT = new DataTable();
                getValuesFromPreset();
                Schuelerimport im = new Schuelerimport();
                im.Path = tb_aktuell.Text;
                im.Separator = schuelerImport.Separator;
                cb_FeldTrenn.Text = schuelerImport.Separator.ToString();
                im.Textqualifizierer = schuelerImport.Textqualifizierer;
                cb_TxtQuali.Text = schuelerImport.Textqualifizierer.ToString();
                im.ColumnHeader = schuelerImport.ColumnHeader;
                cb_ColHeader.Checked = schuelerImport.ColumnHeader;
                im.LineNum = schuelerImport.LineNum;
                tb_lines.Text = schuelerImport.LineNum.ToString();
                //im.FillGridViewRows(ref metroGrid_Vorschau);
                //metroGrid_Vorschau.SelectionMode = DataGridViewSelectionMode.CellSelect;
                fillPreviewDT(tb_aktuell.Text, ref privateDT, ref sortedDT);
                metroGrid_Vorschau.DataSource = null;
                metroGrid_Vorschau.DataSource = sortedDT;
                metroGrid_Vorschau.Sort(metroGrid_Vorschau.Columns[0], ListSortDirection.Descending);
                metroGrid_Vorschau.Sort(metroGrid_Vorschau.Columns[0], ListSortDirection.Ascending);
                int test = metroGrid_Vorschau.Rows.Count;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("failed preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this, "Der Zugriff auf die Datei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Equals("no preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this, "Es ist noch keine Vorlage für " + filename + " vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (ex.Message.Contains("Problem bei Zeile"))
                {
                    int errorcount = int.Parse(ex.Message.Substring(18));
                    MetroMessageBox.Show(this, String.Format("Es konnten '{0}' Zeilen aufgrund eines Formatierungsproblems nicht gelesen werden. Eventuell liegen Probleme in der Struktur der Quelldatei vor.", errorcount), "Fehler beim Einlesen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Equals("Keine Daten", StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this, "Diese Datei enthält keine Daten!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Equals("Fehler bei Datei", StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this, "Fehler beim Lesen der Datei. Eventuell haben Sie eine zu große Zeilenanzahl zum überspringen angegeben.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MetroMessageBox.Show(this, "Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        //TODO
        /// <summary>
        /// Klick auf den Button, der ein neues Preset speichert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_saveProfile_Click(object sender, EventArgs e)
        {
            DataTable newDT = new DataTable();
            DialogResult result = MetroMessageBox.Show(this, "Wollen Sie ihre Änderungen an der Datenstruktur für " + filename + " wirklich in einer Vorlagedatei speichern?", "Änderungen speichern?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //DataTable dt = new DataTable();
                newDT.Reset();
                //createNewDT(dt, false);
                createDataTableWithControls(ref newDT);
                saveProfile();
                MetroMessageBox.Show(this, "Die Vorlage wurde erfolgreich gespeichert!", "Speichern erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usePreset = true;
            }
        }
        #endregion

        List<int> indexes = new List<int>();
        /// <summary>
        /// Erstellt DataTable nach Preset ohne Zugriff auf Controls
        /// </summary>
        /// <param name="dt"></param>
        private void createDataTable(ref DataTable dt, DataTable previewDataTable)
        {
            foreach (int i in indexes)
            {
                dt.Columns.Add(previewDataTable.Columns[i].ColumnName);
            }
            foreach (DataRow row in previewDataTable.Rows)
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < previewDataTable.Columns.Count; i++)
                {
                    dr[i] = row[indexes[i]];
                }
                dt.Rows.Add(dr);
            }
        }

        /// <summary>
        /// Erstellt DataTable mit Zugriff auf Controls, ohne Preset
        /// </summary>
        /// <param name="dt"></param>
        private void createDataTableWithControls(ref DataTable dt)
        {
            indexes.Clear();
            dt.Reset();
            int y = 0;
            for (int i = 0; i < metroGrid_Vorschau.Columns.Count;)
            {
                int test = metroGrid_Vorschau.Columns[i].DisplayIndex;
                if (test == y)
                {
                    dt.Columns.Add(metroGrid_Vorschau.Columns[i].Name);
                    indexes.Add(i);
                    y++;
                    i = 0;
                }
                else
                {
                    i++;
                }
            }
            foreach (DataGridViewRow row in metroGrid_Vorschau.Rows)
            {
                DataRow dr = dt.NewRow();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    DataGridViewCell cell = row.Cells[indexes[i]];
                    dr[i] = cell.Value;
                }
                dt.Rows.Add(dr);
            }
        }

        /// <summary>
        /// Erstellt einen neuen DataTable mit den Vorschaudaten
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="usePreset"></param>
        //private void createNewDT(DataTable dt, bool usePreset)
        //{
        //    if (!usePreset)
        //    {
        //        int y = 0;
        //        for (int i = 0; i < metroGrid_Vorschau.Columns.Count;)
        //        {
        //            int test = metroGrid_Vorschau.Columns[i].DisplayIndex;
        //            if (test == y)
        //            {
        //                dt.Columns.Add(metroGrid_Vorschau.Columns[i].Name);
        //                indexes.Add(i);
        //                y++;
        //                i = 0;
        //            }
        //            else
        //            {
        //                i++;
        //            }

        //        }
        //    }
        //    else
        //    {
        //        foreach(int i in indexes)
        //        {
        //            dt.Columns.Add(metroGrid_Vorschau.Columns[i].Name);

        //        }
        //    }

        //    foreach (DataGridViewRow row in metroGrid_Vorschau.Rows)
        //    {
        //        DataRow dr = dt.NewRow();
        //        for (int i = 0; i < row.Cells.Count; i++)
        //        {
        //            DataGridViewCell cell = row.Cells[indexes[i]];
        //            dr[i] = cell.Value;
        //        }
        //        dt.Rows.Add(dr);
        //    }
        //    newDT = dt;
        //}


        /// <summary>
        /// Inhalt der Error-Nachricht
        /// </summary>
        string errorMessage = "";

        /// <summary>
        /// Alle aufgetretene Errors
        /// </summary>
        List<string> errorMessages = new List<string>();

        /// <summary>
        /// Führt den Import aus
        /// </summary>
        /// <param name="file"></param>
        /// <param name="withPreset"></param>
        private void DoImport(string file)
        {
            DataTable privateDT = new DataTable();
            DataTable sortedDT = new DataTable();
            bool errorHappened = false;
            try
            {
                sortedDT.Reset();
                privateDT.Reset();
                fillPreviewDT(file, ref privateDT, ref sortedDT);
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("wrong preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    errorHappened = true;
                    errors++;
                    errorMessage = String.Format("Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt. \n(Datei '{0}' von '{1}', Bezeichnung: '{2}').\n", fileNum, filesTotal, file);
                }
                else if (ex.Message.Contains("Problem bei Zeile"))
                {
                    errorHappened = true;
                    errors++;
                    int errorcount = int.Parse(ex.Message.Substring(18));
                    errorMessage = String.Format("Es konnten '{0}' Zeilen aufgrund eines Formatierungsproblems nicht gelesen werden. Eventuell liegen Probleme in der Struktur der Quelldatei vor. \n(Datei '{1}' von '{2}', Bezeichnung: '{3}').\n", errorcount, fileNum, filesTotal, file);
                }
                else if (ex.Message.Equals("Keine Daten", StringComparison.InvariantCultureIgnoreCase))
                {
                    errorHappened = true;
                    errors++;
                    errorMessage = String.Format("Die Datei enthält keine Daten! \n(Datei '{0}' von '{1}', Bezeichnung: '{2}').\n", fileNum, filesTotal, file);
                }
                else if (ex.Message.Equals("Fehler bei Datei", StringComparison.InvariantCultureIgnoreCase))
                {
                    errorHappened = true;
                    errors++;
                    MetroMessageBox.Show(this, "Fehler beim Lesen der Datei. Eventuell haben Sie eine zu große Zeilenanzahl zum überspringen angegeben.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    errorHappened = true;
                    errors++;
                    errorMessage = String.Format("Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt. \n(Datei '{0}' von '{1}', Bezeichnung: '{2}').\n", fileNum, filesTotal, file);
                }
                errorMessages.Add(errorMessage);
            }
            if (errorHappened == false)
            {
                foreach (DataRow row in sortedDT.Rows)
                {
                    if (target.Equals("t_s_schueler"))
                    {
                        Kunde k = new Kunde();
                        k.Vorname = row[0].ToString();
                        k.Nachname = row[1].ToString();
                        //k.Gd = DateTime.Now; //nur HotFix
                        k.Gd = DateTime.Parse(row[2].ToString()); //funktioniert 
                        k.Klasse.Klassename = row[3].ToString();
                        k.Hausnummer = "";
                        k.Ort = "";
                        k.Postleitzahl = "";
                        k.Strasse = "";
                        k.Mail = "";
                        k.Telefonnummer = "";
                        if (rb_schueler1.Checked)
                        {
                            //SEK1 Import Schüler
                            string klassenstufe = k.Klasse.Klassename.Substring(0, k.Klasse.Klassename.Length - 2);
                            FachStufe fs = new FachStufe(klassenstufe);
                            for (int i = 4; i < 7; i++)
                            {
                                string fach = row[i].ToString();
                                if(!fach.Equals(""))
                                {
                                    k.Fach.FachKurz = fach;
                                    k.Fach.FachLang = "";
                                    if (!k.Fach.AlreadyExists())
                                    {
                                        k.Fach.AddFach();
                                    }
                                    k.Faecher.Add(fach);
                                }

                            }
                            foreach (string fach in fs.FachListe)
                            {
                                k.Faecher.Add(fach);
                            }
                            for (int i = 0; i < 2; i++)
                            {
                                k.LeistungskursListe.Add("");
                            }
                            if (!k.AlreadyExists(false))
                            {
                                k.AddKunde();
                            }
                            else
                            {
                                k.ActivateKunde();
                                k.UpdateKunde();
                            }
                        }
                        else if (rb_schueler2.Checked)
                        {
                            //SEK2 Import Schüler
                            for (int i = 4; i < sortedDT.Columns.Count; i++)
                            {
                                string fach = row[i].ToString();
                                if (!fach.Equals(""))
                                {
                                    k.Fach.FachKurz = fach;
                                    k.Fach.FachLang = "";
                                    if (!k.Fach.AlreadyExists())
                                    {
                                        k.Fach.AddFach();
                                    }
                                    k.Faecher.Add(fach);
                                }
                                if (k.LeistungskursListe.Count < 2)
                                {
                                    k.LeistungskursListe.Add(fach);
                                }
                            }
                            if (!k.AlreadyExists(false))
                            {
                                k.AddKunde();
                            }
                            else
                            {
                                k.ActivateKunde();
                                k.GetKundenID();
                                k.UpdateKunde();
                            }
                        }
                    }
                    else if (target.Equals("t_s_faecher"))
                    {
                        Fach fach = new Fach();
                        fach.FachKurz = row[0].ToString();
                        fach.FachLang = row[1].ToString();
                        if (!fach.AlreadyExists())
                        {
                            fach.AddFach();
                        }
                    }
                }
                filesDone++;
            }
        }

        /// <summary>
        /// Foreach-Schleife
        /// </summary>
        private void ForeachImport()
        {
            fileNum = 1;
            //List<Task> tasks = new List<Task>();
            //System.Timers.Timer timer = new System.Timers.Timer();
            //timer.Interval = 10;
            //timer.Elapsed += timer_Elapsed;
            //timer.Start();

            progressBar1.Value = 0;
            foreach (string file in files)
            {
                DoImport(file);
                fileNum++;
                progressBar1.Value = filesDone;

                //Console.WriteLine($"Processing {fileNum} on thread {Thread.CurrentThread.ManagedThreadId}");
                //metroLabel6.Invoke((Action)delegate ()
                //{
                //    metroLabel6.Text = fileNum.ToString();
                //});
            };
            //foreach (string file in files)
            //{
            //    tasks.Add(Task.Run(() =>
            //    {
            //        DoImport(file);
            //        fileNum++;
            //    }));

            //}
            //Task.WaitAll(tasks.ToArray());
            //foreach (Task task in tasks) task.Dispose();
            //tasks.Clear();
            //timer.Stop();
        }

        /// <summary>
        /// Startet den Importvorgang
        /// </summary>
        /// <param name="withPreset"></param>
        /// <param name="singleImport"></param>
        private void StartImport(bool withPreset, bool singleImport)
        {
            string file = "";
            errors = 0;
            errorMessage = "";
            errorMessages.Clear();
            errors = 0;
            filesTotal = files.Count;
            filesDone = 0;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = filesTotal;
            progressBar1.Value = 0;
            progressBar1.Step = 1;
            if (singleImport)
            {
                file = files[slider_preview.Value - 1];
            }
            try
            {
                if (usePreset)
                {
                    try
                    {
                        getValuesFromPreset();
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Equals("failed preset", StringComparison.InvariantCultureIgnoreCase))
                        {
                            throw new Exception("failed preset");
                        }
                        else if (ex.Message.Equals("no preset", StringComparison.InvariantCultureIgnoreCase))
                        {
                            throw new Exception("no preset");
                        }
                        else
                        {
                            throw new Exception("else");
                        }
                    }
                }
                else
                {
                    getValuesFromControls();
                }
                fileNum = 0;
                if (!singleImport)
                {
                    ForeachImport();
                }
                else
                {
                    fileNum++;
                    DoImport(file);
                }
                //progressBar1.Value = (filesDone * 100) / files.Count;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("no preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    errorMessage = "Es ist noch keine entsprechende Vorlage vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.\n";
                    errors++;
                }
                else if (ex.Message.Equals("failed preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    errorMessage = "Der Zugriff auf die Datei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.\n";
                    errors++;
                }
                else
                {
                    errorMessage = "Es ist ein Fehler beim Laden der Vorlagedatei aufgetreten.\n";
                    errors++;
                }
                errorMessages.Add(errorMessage);
            }
            if (errorMessages.Count > 0)
            {
                usePreset = false;
                DialogResult result = MetroMessageBox.Show(this, String.Format("Es wurden '{0}' von '{1}' Dateien importiert und es sind '{2}' Fehler aufgetreten. Möchten Sie diese einsehen?", filesDone, filesTotal, errors), "Fehler beim Importvorgang.", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                if (result == DialogResult.Yes)
                {
                    for (int i = 0; i < errorMessages.Count; i++)
                    {
                        DialogResult dr = MetroMessageBox.Show(this, errorMessages[i] + "Wählen Sie 'Ja' für den nächsten Fehler oder 'Nein' zum Beenden.", String.Format("Fehler '{0}' von '{1}'", i + 1, errorMessages.Count.ToString()), MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        if (dr == DialogResult.Yes)
                        {

                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                if (filesDone == 1)
                {
                    DialogResult dr = MetroMessageBox.Show(this, "Die Datei wurde erfolgreich importiert. Möchten Sie weitere Daten importieren?", "Import erfolgreich", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        RemoveFromImportList();
                    }
                    else
                    {
                        this.Close();
                    }
                }
                else if (filesDone > 1)
                {
                    DialogResult dr = MetroMessageBox.Show(this, "Die Dateien wurden erfolgreich importiert. Möchten Sie weitere Daten importieren?", "Import erfolgreich", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dr == DialogResult.Yes)
                    {
                        clearForm();
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
        }
        List<int> removeAt = new List<int>();

        /// <summary>
        /// Klick im Vorschau-Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Vorschau_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Delete)
                {
                    int i = metroGrid_Vorschau.SelectedCells[0].ColumnIndex;
                    metroGrid_Vorschau.Columns.RemoveAt(i);
                    removeAt.Add(i);
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Es konnte keine Spalte entfernt werden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Läd das Profil
        /// </summary>
        private void testestest()
        {

        }

        /// <summary>
        /// Speichert das Profil
        /// </summary>
        private void saveProfile()
        {
            Einstellung set = new Einstellung();
            string path = set.HomePath + "\\profil_";
            if (File.Exists(path + filename + ".txt"))
            {
                File.Delete(path + filename + ".txt");
            }
            TextWriter tw = new StreamWriter(path + filename + ".txt");
            tw.WriteLine("----------------------------------------------------");
            tw.WriteLine(filename + " PROFIL");
            tw.WriteLine("----------------------------------------------------");
            tw.WriteLine("FELDTRENNZEICHEN:");
            tw.WriteLine(cb_FeldTrenn.Text);
            tw.WriteLine("----------------------------------------------------");
            tw.WriteLine("TEXTQUALIFIZIERER:");
            tw.WriteLine(cb_TxtQuali.Text);
            tw.WriteLine("----------------------------------------------------");
            tw.WriteLine("FELDNAMEN:");
            if (cb_ColHeader.Checked)
            {
                tw.WriteLine("True");
            }
            else
            {
                tw.WriteLine("False");
            }
            tw.WriteLine("----------------------------------------------------");
            tw.WriteLine("ZEILEN ENTFERNEN:");
            tw.WriteLine(tb_lines.Text);
            tw.WriteLine("----------------------------------------------------");

            tw.WriteLine("REMOVE AT:");
            foreach (int i in removeAt)
            {
                tw.WriteLine(i.ToString());
            }
            tw.WriteLine("----------------------------------------------------");
            tw.WriteLine("SORTED COLUMNS:");
            foreach (int i in indexes)
            {
                tw.WriteLine(i.ToString());
            }
            tw.WriteLine("----------------------------------------------------");
            tw.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CheckSelected();
            usePreset = false;
        }

        private void SetTarget()
        {
            if (target.Equals("t_s_schueler"))
            {
                this.Text = "Import von Schülern";
                rb_schueler1.Checked = true;
                rb_faecher.Enabled = false;
                rb_schueler1.Enabled = true;
                rb_schueler2.Enabled = true;
            }
            else if (target.Equals("t_s_faecher"))
            {
                this.Text = "Import von Fächern";
                rb_faecher.Checked = true;
                rb_faecher.Enabled = true;
                rb_schueler1.Enabled = false;
                rb_schueler2.Enabled = false;
            }
        }

        /// <summary>
        /// Prüft, welches Importziel ausgewählt ist
        /// </summary>
        private void CheckSelected()
        {
            Schuelerimport si = new Schuelerimport();
            if (rb_schueler1.Checked)
            {
                //Sek1
                filename = "SEK1";
                si.FillColGrid(ref gv_columns, filename);
            }
            if (rb_schueler2.Checked)
            {
                //Sek2
                filename = "SEK2";
                si.FillColGrid(ref gv_columns, filename);
            }
            if (rb_faecher.Checked)
            {
                //Fächer
                filename = "FAECHER";
                si.FillColGrid(ref gv_columns, filename);
            }
        }

        /// <summary>
        /// Verhindert eine Eingabe von Buchstaben usw --> nur Zahlen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tb_lines_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        /// <summary>
        /// Prüft den Modus (Multiselect oder Single)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rb_single_CheckedChanged(object sender, EventArgs e)
        {
            tb_path.Text = "";
            ImportMode();
        }

        /// <summary>
        /// Multiselect/Single-select
        /// </summary>
        private void ImportMode()
        {
            if (rb_single.Checked)
            {
                multiselect = false;
            }
            else if (rb_multi.Checked)
            {
                multiselect = true;
            }
        }

        /// <summary>
        /// Setzt den Auswahl-Slider anhand der Elemente der Ausleihliste
        /// </summary>
        private void SetSlider()
        {
            slider_preview.SmallChange = 1;
            slider_preview.LargeChange = 1;
            if (files.Count == 0)
            {
                slider_preview.Minimum = 0;
                slider_preview.Maximum = 0;
                slider_preview.Value = 0;
                bt_right.Enabled = false;
                bt_left.Enabled = false;
                tb_min.Text = "-";
                tb_max.Text = "-";
            }
            else if (files.Count == 1)
            {
                slider_preview.Minimum = 1;
                slider_preview.Maximum = 1;
                bt_right.Enabled = false;
                bt_left.Enabled = false;
                tb_min.Text = "1";
                tb_max.Text = "1";
            }
            else
            {
                slider_preview.Minimum = 1;
                slider_preview.Maximum = files.Count;
                slider_preview.Value = 1;
                bt_right.Enabled = true;
                bt_left.Enabled = true;
                tb_min.Text = slider_preview.Value.ToString();
                tb_max.Text = slider_preview.Maximum.ToString();
            }
        }

        /// <summary>
        /// Entfernt eine Datei aus der Importliste
        /// </summary>
        private void RemoveFromImportList()
        {
            files.RemoveAt(slider_preview.Value - 1);
            filesShort.RemoveAt(slider_preview.Value - 1);
            tb_path.Text = "";
            foreach (string file in filesShort)
            {
                tb_path.Text = tb_path.Text + file + ", ";
            }
            if (tb_path.Text.Length == 0)
            {
                SetSlider();
                tb_aktuell.Text = "";
                tb_path.Text = "";
            }
            else
            {
                tb_path.Text = tb_path.Text.Substring(0, tb_path.Text.Length - 2);
                SetSlider();
                tb_aktuell.Text = files[slider_preview.Value - 1];
            }
        }

        /// <summary>
        /// Entfernt ausgewählte Datei aus Liste
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_removefile_Click(object sender, EventArgs e)
        {
            RemoveFromImportList();
        }

        private void scrollbar_ValueChanged(object sender, EventArgs e)
        {
            if (slider_preview.Value != 0)
            {

                slider_preview_ValueChanged();
            }
        }

        private void slider_preview_ValueChanged()
        {
            DataTable previewDT = new DataTable();
            DataTable sortedDT = new DataTable();
            tb_min.Text = slider_preview.Value.ToString();
            tb_max.Text = slider_preview.Maximum.ToString();
            tb_aktuell.Text = files[slider_preview.Value - 1];
            if (usePreset)
            {
                try
                {
                    fillPreviewDT(tb_aktuell.Text, ref previewDT, ref sortedDT);
                    metroGrid_Vorschau.DataSource = sortedDT;
                    metroGrid_Vorschau.Sort(metroGrid_Vorschau.Columns[0], ListSortDirection.Descending);
                    metroGrid_Vorschau.Sort(metroGrid_Vorschau.Columns[0], ListSortDirection.Ascending);
                }
                catch (Exception ex)
                {
                    if (ex.Message.Equals("failed preset", StringComparison.InvariantCultureIgnoreCase))
                    {
                        MetroMessageBox.Show(this, "Der Zugriff auf die Datei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Message.Equals("no preset", StringComparison.InvariantCultureIgnoreCase))
                    {
                        MetroMessageBox.Show(this, "Es ist noch keine Vorlage für " + filename + " vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (ex.Message.Contains("Problem bei Zeile"))
                    {
                        int errorcount = int.Parse(ex.Message.Substring(18));
                        MetroMessageBox.Show(this, String.Format("Es konnten '{0}' Zeilen aufgrund eines Formatierungsproblems nicht gelesen werden. Eventuell liegen Probleme in der Struktur der Quelldatei vor.", errorcount), "Fehler beim Einlesen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Message.Equals("Keine Daten", StringComparison.InvariantCultureIgnoreCase))
                    {
                        MetroMessageBox.Show(this, "Diese Datei enthält keine Daten!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Message.Equals("Fehler bei Datei", StringComparison.InvariantCultureIgnoreCase))
                    {
                        MetroMessageBox.Show(this, "Fehler beim Lesen der Datei. Eventuell haben Sie eine zu große Zeilenanzahl zum überspringen angegeben.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                noPreset();
            }
        }

        private void bt_right_Click(object sender, EventArgs e)
        {
            if (slider_preview.Value < slider_preview.Maximum)
            {
                slider_preview.Value = slider_preview.Value + 1;
            }
        }

        private void bt_left_Click(object sender, EventArgs e)
        {
            if (slider_preview.Value > slider_preview.Minimum)
            {
                slider_preview.Value = slider_preview.Value - 1;
            }
        }

        private void bt_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
            }
            progressBar1.Invoke((Action)delegate ()
            {
                progressBar1.PerformStep();
            });
        }

        /// <summary>
        /// Startet Importvorgang, fragt nach Verwendung der Vorlage
        /// </summary>
        /// <param name="singleimport"></param>
        private void ImportButtonClick(bool singleimport)
        {
            if (usePreset)
            {
                StartImport(usePreset, singleimport);
            }
            else
            {
                if (metroGrid_Vorschau.Rows.Count == 0)
                {
                    DialogResult result = MetroMessageBox.Show(this, "Soll die Vorlage für '" + filename + "' zum Importieren der Daten genutzt werden? Falls Sie dies nicht wünschen, müssen Sie die zu importierenden Daten manuell anpassen.", "Vorlage verwenden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            usePreset = true;
                            StartImport(usePreset, singleimport);
                        }
                        catch
                        {
                            MetroMessageBox.Show(this, "Es gab einen Fehler bei dem Import. Bitte versuchen Sie es erneut und passen Sie ggf. Ihre Einstellungen an.", "Import fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult result = MetroMessageBox.Show(this, "Soll die von Ihnen angeordnete Datenstruktur für den Import von '" + filename + "' genutzt werden? Falls nicht, ändern Sie bitte diese oder laden Sie die Daten mithilfe der Vorlage.", "Importieren?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            usePreset = false;
                            StartImport(usePreset, singleimport);
                        }
                        catch
                        {
                            MetroMessageBox.Show(this, "Es gab einen Fehler bei dem Import. Bitte versuchen Sie es erneut und passen Sie ggf. Ihre Einstellungen an.", "Import fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Klick auf Single-Import Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_importSingle_Click(object sender, EventArgs e)
        {
            ImportButtonClick(true);
        }

        /// <summary>
        /// Klick auf Import-Alles-Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_accept_Click(object sender, EventArgs e)
        {
            ImportButtonClick(false);
        }

        private void bt_Schliessen_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            this.Close();
        }

        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            progressBar1.Invoke((Action)delegate ()
            {
                progressBar1.Value = filesDone;
            });
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_aktuell.Text = "";
            tb_path.Text = "";
            tb_lines.Text = "0";
            cb_ColHeader.Checked = false;
            cb_FeldTrenn.Text = "";
            cb_TxtQuali.Text = "";
            metroGrid_Vorschau.DataSource = null;
        }

        private void SpalteEntfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                    int i = metroGrid_Vorschau.SelectedCells[0].ColumnIndex;
                    metroGrid_Vorschau.Columns.RemoveAt(columnIndex);
                    removeAt.Add(columnIndex);
            }
            catch
            {
                MetroMessageBox.Show(this, "Es konnte keine Spalte entfernt werden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        int columnIndex = 0;
        private void MetroGrid_Vorschau_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                metroGrid_Vorschau.ClearSelection();
                metroGrid_Vorschau.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                columnIndex = e.ColumnIndex;
            }
        }

        private void MetroGrid_Vorschau_MouseDown(object sender, MouseEventArgs e)
        {
                if (!(metroGrid_Vorschau.HitTest(e.X, e.Y).RowIndex >= 0)||!(metroGrid_Vorschau.HitTest(e.X,e.Y).ColumnIndex>=0))
                {
                spalteEntfernenToolStripMenuItem.Visible = false;
                }
                else
                {
                spalteEntfernenToolStripMenuItem.Visible = true;
                }
        }

        private void MetroToolTip1_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(e.ToolTipSize.Width + 32, e.ToolTipSize.Height);
        }
    }
}
