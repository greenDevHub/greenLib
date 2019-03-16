﻿using MetroFramework;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_schuelerimport : MetroFramework.Forms.MetroForm
    {
        char seperator = ';';
        char feldquali = '"';
        char dattrenn = '.';
        char zeittrenn = ':';
        char dezsym = ',';
        string target = "";
        string filename = "";
        bool multiselect = false;
        List<string> files = new List<string>();
        List<string> filesShort = new List<string>();

        public w_s_schuelerimport(string target, bool modus)
        {
            this.target = target;
            InitializeComponent();
            tb_lines.Text = "0";
            setModus(modus);
            SetTarget();
            ImportMode();
            CheckSelected();
            SetSlider();
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
        private void getValues()
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
        }
        
        /// <summary>
        /// Erstellt die Vorschau 
        /// </summary>
        /// <param name="file"></param>
        private void createPreview(string file)
        {
            Cursor.Current = Cursors.WaitCursor;
            Schuelerimport im = new Schuelerimport();
            im.Path = file;
            im.Separator = seperator;
            im.Textqualifizierer = feldquali;
            im.Datumstrennzeichen = dattrenn;
            im.Zeittrennzeichen = zeittrenn;
            im.Dezimaltrennzeichen = dezsym;
            im.ColumnHeader = cb_ColHeader.Checked;
            im.LineNum = 0;
            try
            {
                im.LineNum = int.Parse(tb_lines.Text);
            }
            catch
            {
                MetroMessageBox.Show(this,"Bitte geben Sie eine gültige Zahl in das Feld 'Obere Zeilen Entfernen' ein.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            im.FillGridViewRows(ref metroGrid_Vorschau);
            metroGrid_Vorschau.SelectionMode = DataGridViewSelectionMode.CellSelect;

            Cursor.Current = Cursors.Default;
        }

        bool trennError = false;
        bool qualiError = false;

        /// <summary>
        /// Zeigt die Vorschau
        /// </summary>
        /// <param name="file"></param>
        private void showPreview(string file)
        {

            if (File.Exists(file))
            {
                getValues();
                if (trennError && !qualiError)
                {
                    MetroMessageBox.Show(this,"Das Feldtrennzeichen ist ungülig! Wählen Sie eines der gültigen Trennzeichen des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_FeldTrenn.Focus();
                }
                else if(!trennError && qualiError)
                {
                    MetroMessageBox.Show(this,"Der Textqualifizierer ist ungülig! Wählen Sie einen der gültigen Textqualifizierer des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_TxtQuali.Focus();
                }
                else if(trennError && qualiError)
                {
                    MetroMessageBox.Show(this,"Der Textqualifizierer und das Feldtrennzeichen sind ungülig! Wählen Sie einen gültigen Eintrag im Auswahlmenü.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_FeldTrenn.Focus();
                }
                else
                {
                    createPreview(file);
                }
            }
            else
            {
                MetroMessageBox.Show(this,"Der Pfad: " + files[0] + " ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                metroGrid_Vorschau.DataSource = null;
                tb_path.Focus();
            }
        }

        
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
                    for(int i = 0; i < openFileDialog.FileNames.Length;i++)
                    {
                        if(openFileDialog.FileNames[i].Contains(".txt") || openFileDialog.FileNames[i].Contains(".csv"))
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
                        MetroMessageBox.Show(this,"Der angegebene Dateiname ist ungültig. Bitte verwenden sie nur Dateien mit der Endung \'.txt\' oder \'.csv\'!");
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
            if(tb_path.Text != "")
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
            usePreset = false;
            removeAt.Clear();
            indexes.Clear();
            try
            {
                //Vorschau ohne Vorlage
                showPreview(tb_aktuell.Text);
            }
            catch (IOException)
            {
                MetroMessageBox.Show(this,"Der Zugriff auf die Datei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
        private void bt_Import_Click(object sender, EventArgs e)
        {
            try
            {
                loadProfile();
                usePreset = true;
            }
            catch (Exception ex)
            {
                if (ex.Message.Equals("failed preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this,"Der Zugriff auf die Datei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Equals("wrong preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this,"Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt.", "Fehler bei Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (ex.Message.Equals("no preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    MetroMessageBox.Show(this,"Es ist noch keine Vorlage für " + filename + " vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            DialogResult result = MetroMessageBox.Show(this,"Wollen Sie ihre Änderungen an der Datenstruktur für " + filename + " wirklich in einer Vorlagedatei speichern?", "Änderungen speichern?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                createNewDT(dt, false);
                saveProfile();
                usePreset = true;
            }
        }
        #endregion


        DataTable newDT = new DataTable();
        List<int> indexes = new List<int>();
        /// <summary>
        /// Erstellt einen neuen DataTable mit den Vorschaudaten
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="usePreset"></param>
        private void createNewDT(DataTable dt, bool usePreset)
        {
            if (!usePreset)
            {
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
            }
            else
            {
                foreach(int i in indexes)
                {
                    dt.Columns.Add(metroGrid_Vorschau.Columns[i].Name);

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
            newDT = dt;
        }

        /// <summary>
        /// Klick auf Import-Alles-Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_accept_Click(object sender, EventArgs e)
        {
            if (usePreset)
            {
                StartImport(true, false);
            }
            else
            {
                if (metroGrid_Vorschau.Rows.Count == 0)
                {
                    DialogResult result = MetroMessageBox.Show(this,"Soll die Vorlage für '" + filename + "' zum Importieren der Daten genutzt werden? Falls Sie dies nicht wünschen, müssen Sie die zu importierenden Daten manuell anpassen.", "Vorlage verwenden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            StartImport(true, false);
                            usePreset = true;
                        }
                        catch
                        {
                            MetroMessageBox.Show(this,"Es gab einen Fehler bei dem Import. Bitte versuchen Sie es erneut und passen Sie ggf. Ihre Einstellungen an.", "Import fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult result = MetroMessageBox.Show(this,"Soll die von Ihnen angeordnete Datenstruktur für den Import von '" + filename + "' genutzt werden? Falls nicht, ändern Sie bitte diese oder laden Sie die Daten mithilfe der Vorlage.", "Importieren?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            StartImport(false, false);
                        }
                        catch
                        {
                            MetroMessageBox.Show(this,"Es gab einen Fehler bei dem Import. Bitte versuchen Sie es erneut und passen Sie ggf. Ihre Einstellungen an.", "Import fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        usePreset = false;
                    }
                }
            }
            
        }

        /// <summary>
        /// Führt den Import aus
        /// </summary>
        /// <param name="file"></param>
        /// <param name="withPreset"></param>
        private void DoImport(string file)
        {
            tb_aktuell.Text = file;
            if (usePreset)
            {
                try
                {
                    loadProfile();
                }
                catch (Exception ex)
                {
                    if (ex.Message.Equals("failed preset", StringComparison.InvariantCultureIgnoreCase))
                    {
                        MetroMessageBox.Show(this,"Der Zugriff auf die Datei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (ex.Message.Equals("wrong preset", StringComparison.InvariantCultureIgnoreCase))
                    {
                        MetroMessageBox.Show(this,"Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt.", "Fehler bei Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    else if (ex.Message.Equals("no preset", StringComparison.InvariantCultureIgnoreCase))
                    {
                        MetroMessageBox.Show(this,"Es ist noch keine Vorlage für " + filename + " vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            else
            {
                createNewDT(newDT, usePreset);
            }
            foreach (DataRow row in newDT.Rows)
            {
                if (target.Equals("t_s_schueler"))
                {
                    Kunde k = new Kunde();
                    k.Vorname = row[0].ToString();
                    k.Nachname = row[1].ToString();
                    k.Gd = DateTime.Parse(row[2].ToString());
                    k.Klasse = row[3].ToString();
                    k.Hausnummer = "";
                    k.Ort = "";
                    k.Postleitzahl = "";
                    k.Strasse = "";
                    k.Mail = "";
                    k.Telefonnummer = "";
                    if (rb_schueler1.Checked)
                    {
                        //SEK1 Import Schüler
                        FachStufe fs = new FachStufe(k.Klasse.Substring(0,k.Klasse.Length-2));
                        for (int i = 4; i < 7; i++)
                        {
                            string fach = row[i].ToString();
                            k.Faecher.Add(fach);
                        }
                        foreach (string fach in fs.FachListe)
                        {
                            k.Faecher.Add(fach);
                        }
                        for(int i = 0; i < 2; i++)
                        {
                            k.LeistungskursListe.Add("");
                        }
                        if (!k.AlreadyExists())
                        {
                            k.AddKunde();
                        }
                        else
                        {
                            k.Activate();
                            k.UpdateKunde();
                        }

                    }
                    else if (rb_schueler2.Checked)
                    {
                        //SEK2 Import Schüler
                        for (int i = 4; i < newDT.Columns.Count; i++)
                        {
                            string fach = row[i].ToString();
                            if (!fach.Equals(""))
                            {
                                k.Faecher.Add(fach);
                            }
                            if (k.LeistungskursListe.Count < 2)
                            {
                                k.LeistungskursListe.Add(fach);
                            }
                        }
                        if (!k.AlreadyExists())
                        {
                            k.AddKunde();
                        }
                        else
                        {
                            k.Activate();
                            k.LoadKundenID();
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
        }
        /// <summary>
        /// Foreach-Schleife
        /// </summary>
        private void ForeachImport(ref int fileNum)
        {
            foreach(string file in files)
            {
                DoImport(file);
                fileNum++;
            }
            //List<Task> tasks = new List<Task>();
            //foreach (string file in files)
            //{
            //    tasks.Add(Task.Run(()=> DoImport(file)));
            //    fileNum++;
            //}
            //Task.WaitAll(tasks.ToArray());
            //foreach (Task task in tasks) task.Dispose();
            //tasks.Clear();
        }

        /// <summary>
        /// Startet den Importvorgang
        /// </summary>
        /// <param name="withPreset"></param>
        /// <param name="singleImport"></param>
        private void StartImport(bool withPreset, bool singleImport)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            int fileNum = 0;
            usePreset = withPreset;
            if (!singleImport)
            {
                ForeachImport(ref fileNum);
            }
            else
            {
                string file = files[slider_preview.Value - 1];
                tb_aktuell.Text = file;
                if (withPreset)
                {
                    try
                    {
                        loadProfile();
                        fileNum++;
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Equals("failed preset", StringComparison.InvariantCultureIgnoreCase))
                        {
                            MetroMessageBox.Show(this,"Der Zugriff auf die Datei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ex.Message.Equals("wrong preset", StringComparison.InvariantCultureIgnoreCase))
                        {
                            MetroMessageBox.Show(this,"Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt.", "Fehler bei Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (ex.Message.Equals("no preset", StringComparison.InvariantCultureIgnoreCase))
                        {
                            MetroMessageBox.Show(this,"Es ist noch keine Vorlage für " + filename + " vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
                else
                {
                    createNewDT(newDT, withPreset);
                }
                ForeachImport(ref fileNum);
                //foreach (DataRow row in newDT.Rows)
                //{
                //    if (target.Equals("t_s_schueler"))
                //    {
                //        Kunde kunde = new Kunde();
                //        kunde.Vorname = row[0].ToString();
                //        kunde.Nachname = row[1].ToString();
                //        kunde.Gd = DateTime.Parse(row[2].ToString());
                //        kunde.Klasse = row[3].ToString();
                //        kunde.Hausnummer = "";
                //        kunde.Ort = "";
                //        kunde.Postleitzahl = "";
                //        kunde.Strasse = "";
                //        kunde.Mail = "";
                //        kunde.Telefonnummer = "";
                //        if (rb_schueler1.Checked)
                //        {
                //            //SEK1 Import Schüler
                //            FachStufe fs = new FachStufe(kunde.Klasse.Substring(0,kunde.Klasse.Length-2));
                //            for (int i = 4; i < 7; i++)
                //            {
                //                string fach = row[i].ToString();
                //                kunde.Faecher.Add(fach);
                //            }
                //            for(int i = 0; i < 2; i++)
                //            {
                //                kunde.LeistungskursListe.Add("");
                //            }
                //            foreach (string fach in fs.FachListe)
                //            {
                //                kunde.Faecher.Add(fach);
                //            }
                //            if (!kunde.AlreadyExists())
                //            {
                //                kunde.AddKunde();
                //            }
                //            else
                //            {
                //                kunde.UpdateKunde();
                //            }

                //        }
                //        else if (rb_schueler2.Checked)
                //        {
                //            //SEK2 Import Schüler
                //            for (int i = 4; i < newDT.Columns.Count; i++)
                //            {
                //                string fach = row[i].ToString();
                //                if (!fach.Equals(""))
                //                {
                //                    if (kunde.LeistungskursListe.Count < 2)
                //                    {
                //                        kunde.LeistungskursListe.Add(fach);
                //                    }
                //                    kunde.Faecher.Add(fach);
                //                }
                //            }
                //            if (!kunde.AlreadyExists())
                //            {
                //                kunde.AddKunde();
                //            }
                //            else
                //            {
                //                kunde.LoadKundenID();
                //                kunde.UpdateKunde();
                //            }
                //        }
                //    }
                //    else if (target.Equals("t_s_faecher"))
                //    {
                //        Fach fach = new Fach();
                //        fach.FachKurz = row[0].ToString();
                //        fach.FachLang = row[1].ToString();
                //        if (!fach.FachExists())
                //        {
                //            fach.AddFach();
                //        }
                //    }

                //}
                progressBar1.Value = (fileNum * 100) / files.Count;
            }
            
            if(fileNum == 0)
            {
                DialogResult dr = MetroMessageBox.Show(this,"Die Datei wurde nicht importiert. Möchten Sie es erneut versuchen?", "Import fehlerhaft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    clearForm();
                }
                else
                {
                    this.Close();
                }
            }
            else
            {
                DialogResult dr = MetroMessageBox.Show(this,"Die Datei wurde erfolgreich importiert. Möchten Sie weitere Daten importieren?", "Import erfolgreich", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    RemoveFromImportList();
                }
                else
                {
                    this.Close();
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

        //TODO
        /// <summary>
        /// Läd das Profil
        /// </summary>
        private void loadProfile()
        {
            Einstellung set = new Einstellung();
            //sek1
            string path = set.HomePath + "\\profil_" + filename + ".txt";
            if (File.Exists(path))
            {
                
                try
                {
                    Schuelerimport si = new Schuelerimport();
                    removeAt.Clear();
                    indexes.Clear();
                    var lines = File.ReadAllLines(path);
                    //si.Separator = lines[4][0];
                    cb_FeldTrenn.Text = lines[4];
                    //si.Textqualifizierer = lines[7][0];
                    cb_TxtQuali.Text = lines[7];
                    if (lines[10] == "True")
                    {
                        //si.ColumnHeader = true;
                        cb_ColHeader.Checked = true;
                    }
                    else
                    {
                        //si.ColumnHeader = false;
                        cb_ColHeader.Checked = false;
                    }
                    //si.LineNum = int.Parse(lines[13]);
                    tb_lines.Text = lines[13];
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
                    showPreview(tb_aktuell.Text);
                }
                catch (IOException e)
                {
                    throw new Exception("failed preset", e);
                }
                Cursor.Current = Cursors.Default;
                foreach (int i in removeAt)
                {
                    metroGrid_Vorschau.Columns.RemoveAt(i);
                }
                try
                {
                    DataTable dt = new DataTable();
                    createNewDT(dt, true);
                    metroGrid_Vorschau.DataSource = null;
                    metroGrid_Vorschau.DataSource = dt;
                }
                catch(Exception e)
                {
                    throw new Exception("wrong preset", e);
                }
            }
            else
            {
                throw new Exception("no preset");

            }
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
        }
        private void SetTarget()
        {
            if (target.Equals("t_s_schueler"))
            {
                this.Text = "Schülerimport";
                rb_schueler1.Checked = true;
            }
            else if (target.Equals("t_s_faecher"))
            {
                this.Text = "Fächerimport";
                rb_faecher.Checked = true;
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
            else if(rb_multi.Checked)
            {
                multiselect = true;
            }
        }

        /// <summary>
        /// Setzt den Auswahl-Slider anhand der Elemente der Ausleihliste
        /// </summary>
        private void SetSlider()
        {
            if (files.Count == 0)
            {
                slider_preview.Minimum = 0;
                slider_preview.Maximum = 0;
                bt_right.Enabled = false;
                bt_left.Enabled = false;
                tb_min.Text = "-";
                tb_max.Text = "-";
            }
            else if(files.Count == 1)
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
            foreach(string file in filesShort)
            {
                tb_path.Text = tb_path.Text + file + ", ";
            }
            if(tb_path.Text.Length == 0)
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

        //private void slider_preview_ValueChanged(object sender, EventArgs e)
        //{
        //    tb_min.Text = slider_preview.Value.ToString();
        //    tb_max.Text = slider_preview.Maximum.ToString();
        //    tb_aktuell.Text = files[slider_preview.Value - 1];
        //    if (usePreset)
        //    {
        //        try
        //        {
        //            loadProfile();
        //        }
        //        catch
        //        {
        //            MetroMessageBox.Show(this,"Beim Laden der Vorschau ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //}

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void slider_preview_ValueChanged(object sender, int newValue)
        {
            tb_min.Text = slider_preview.Value.ToString();
            tb_max.Text = slider_preview.Maximum.ToString();
            tb_aktuell.Text = files[slider_preview.Value - 1];
            if (usePreset)
            {
                try
                {
                    loadProfile();
                }
                catch
                {
                    MetroMessageBox.Show(this,"Beim Laden der Vorschau ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void bt_right_Click(object sender, EventArgs e)
        {
            if(slider_preview.Value < slider_preview.Maximum)
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

        private void bt_importSingle_Click(object sender, EventArgs e)
        {
            if (usePreset)
            {
                StartImport(true, true);
            }
            else
            {
                if (metroGrid_Vorschau.Rows.Count == 0)
                {
                    DialogResult result = MetroMessageBox.Show(this,"Soll die Vorlage für '" + filename + "' zum Importieren der Daten genutzt werden? Falls Sie dies nicht wünschen, müssen Sie die zu importierenden Daten manuell anpassen.", "Vorlage verwenden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            StartImport(true, true);
                            usePreset = true;
                        }
                        catch
                        {
                            MetroMessageBox.Show(this,"Es gab einen Fehler bei dem Import. Bitte versuchen Sie es erneut und passen Sie ggf. Ihre Einstellungen an.", "Import fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult result = MetroMessageBox.Show(this,"Soll die von Ihnen angeordnete Datenstruktur für den Import von '" + filename + "' genutzt werden? Falls nicht, ändern Sie bitte diese oder laden Sie die Daten mithilfe der Vorlage.", "Importieren?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            StartImport(false, true);
                        }
                        catch
                        {
                            MetroMessageBox.Show(this,"Es gab einen Fehler bei dem Import. Bitte versuchen Sie es erneut und passen Sie ggf. Ihre Einstellungen an.", "Import fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        usePreset = false;
                    }
                }
            }
        }

        private void bt_Schliessen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
