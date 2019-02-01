using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_schuelerimport : Form
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
                //MessageBox.Show("Das Feldtrennzeichen ist ungülig! Wählen Sie eines der gültigen Trennzeichen des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Textqualifizierer
            if (txtqualifier == "'" | txtqualifier == "\"")
            {
                feldquali = Convert.ToChar(txtqualifier);
            }
            else
            {
                qualiError = true;
                //MessageBox.Show("Der Textqualifizierer ist ungülig! Wählen Sie einen der gültigen Textqualifizierer des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Bitte geben Sie eine gültige Zahl in das Feld 'Obere Zeilen Entfernen' ein.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            im.FillGridViewRows(ref gv_Vorschau);

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
                    MessageBox.Show("Das Feldtrennzeichen ist ungülig! Wählen Sie eines der gültigen Trennzeichen des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_FeldTrenn.Focus();
                }
                else if(!trennError && qualiError)
                {
                    MessageBox.Show("Der Textqualifizierer ist ungülig! Wählen Sie einen der gültigen Textqualifizierer des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_TxtQuali.Focus();
                }
                else if(trennError && qualiError)
                {
                    MessageBox.Show("Der Textqualifizierer und das Feldtrennzeichen sind ungülig! Wählen Sie einen gültigen Eintrag im Auswahlmenü.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_FeldTrenn.Focus();
                }
                else
                {
                    createPreview(file);
                }
            }
            else
            {
                MessageBox.Show("Der Pfad: " + files[0] + " ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gv_Vorschau.DataSource = null;
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
                        MessageBox.Show("Der angegebene Dateiname ist ungültig. Bitte verwenden sie nur Dateien mit der Endung \'.txt\' oder \'.csv\'!");
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
        /// Klick auf Vorschau-Button
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
                showPreview(tb_aktuell.Text);
            }
            catch (IOException)
            {
                MessageBox.Show("Der Zugriff auf die Datei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            gv_Vorschau.DataSource = null;
            bt_usepreset.Enabled = true;
            bt_Vorschau.Enabled = false;
            gv_Vorschau.Enabled = false;
            gv_Vorschau.DataSource = null;
            lb_Vorschau.Enabled = false;
            lb_Vorschau1.Enabled = false;
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
                usePreset = false;
                bt_saveProfile.Enabled = true;
                bt_removefile.Enabled = true;
                bt_accept.Enabled = true;
                bt_usepreset.Enabled = true;
                bt_Vorschau.Enabled = true;
                gv_Vorschau.Enabled = true;
                lb_Vorschau.Enabled = true;
                lb_Vorschau1.Enabled = true;
            }
            else
            {
                bt_saveProfile.Enabled = false;
                usePreset = false;
                bt_removefile.Enabled = false;
                bt_accept.Enabled = false;
                bt_usepreset.Enabled = false;
                bt_Vorschau.Enabled = false;
                gv_Vorschau.Enabled = false;
                gv_Vorschau.DataSource = null;
                lb_Vorschau.Enabled = false;
                lb_Vorschau1.Enabled = false;
            }
        }
        bool usePreset = false;
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
                    MessageBox.Show("Der Zugriff auf die Datei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (ex.Message.Equals("wrong preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt.", "Fehler bei Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (ex.Message.Equals("no preset", StringComparison.InvariantCultureIgnoreCase))
                {
                    MessageBox.Show("Es ist noch keine Vorlage für " + filename + " vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        /// <summary>
        /// Klick auf den Button, der ein neues Preset speichert
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_saveProfile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Wollen Sie ihre Änderungen an der Datenstruktur für " + filename + " wirklich in einer Vorlagedatei speichern?", "Änderungen speichern?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                DataTable dt = new DataTable();
                createNewDT(dt, false);
                saveProfile();
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
                for (int i = 0; i < gv_Vorschau.Columns.Count;)
                {
                    int test = gv_Vorschau.Columns[i].DisplayIndex;
                    if (test == y)
                    {
                        dt.Columns.Add(gv_Vorschau.Columns[i].Name);
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
                    dt.Columns.Add(gv_Vorschau.Columns[i].Name);

                }
            }
            
            foreach (DataGridViewRow row in gv_Vorschau.Rows)
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
        /// Klick auf Import-Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_accept_Click(object sender, EventArgs e)
        {
            if (usePreset)
            {
                StartImport(true);
            }
            else
            {
                if (gv_Vorschau.Rows.Count == 0)
                {
                    DialogResult result = MessageBox.Show("Soll die Vorlage für '" + filename + "' zum Importieren der Daten genutzt werden? Falls Sie dies nicht wünschen, müssen Sie die zu importierenden Daten manuell anpassen.", "Vorlage verwenden?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            StartImport(true);
                            usePreset = true;
                        }
                        catch
                        {
                            MessageBox.Show("Es gab einen Fehler bei dem Import. Bitte versuchen Sie es erneut und passen Sie ggf. Ihre Einstellungen an.", "Import fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    DialogResult result = MessageBox.Show("Soll die von Ihnen angeordnete Datenstruktur für den Import von '" + filename + "' genutzt werden? Falls nicht, ändern Sie bitte diese oder laden Sie die Daten mithilfe der Vorlage.", "Importieren?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            StartImport(false);
                        }
                        catch
                        {
                            MessageBox.Show("Es gab einen Fehler bei dem Import. Bitte versuchen Sie es erneut und passen Sie ggf. Ihre Einstellungen an.", "Import fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        usePreset = false;
                    }
                }
            }
            
        }
        private void StartImport(bool withPreset)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            int fileNum = 0;
            foreach (string file in files)
            {
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
                            MessageBox.Show("Der Zugriff auf die Datei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (ex.Message.Equals("wrong preset", StringComparison.InvariantCultureIgnoreCase))
                        {
                            MessageBox.Show("Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt.", "Fehler bei Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                        else if (ex.Message.Equals("no preset", StringComparison.InvariantCultureIgnoreCase))
                        {
                            MessageBox.Show("Es ist noch keine Vorlage für " + filename + " vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        continue;
                    }

                }
                else
                {
                    createNewDT(newDT, withPreset);
                }
                foreach (DataRow row in newDT.Rows)
                {
                    if (target.Equals("t_s_schueler"))
                    {
                        Schueler schueler = new Schueler(true);
                        schueler.Vorname = row[0].ToString();
                        schueler.Nachname = row[1].ToString();
                        schueler.Gd = DateTime.Parse(row[2].ToString());
                        schueler.Klasse = row[3].ToString();
                        if (rb_schueler1.Checked)
                        {
                            //SEK1 Import Schüler
                            schueler.Klassenstufe = row[4].ToString();
                            FachStufe fs = new FachStufe(schueler.Klassenstufe);
                            for (int i = 5; i < 8; i++)
                            {
                                string fach = row[i].ToString();
                                schueler.Faecher.Add(fach);
                            }
                            foreach(string fach in fs.FachListe)
                            {
                                schueler.Faecher.Add(fach);
                            }
                            if (!schueler.AlreadyExists())
                            {
                                schueler.addSchueler();
                            }
                            else
                            {
                                schueler.Update();
                            }

                        }
                        else if (rb_schueler2.Checked)
                        {
                            //SEK2 Import Schüler
                            schueler.Klassenstufe = schueler.Klasse.Substring(0, schueler.Klasse.IndexOf("_"));
                            for (int i = 4; i < newDT.Columns.Count; i++)
                            {
                                string fach = row[i].ToString();
                                if (!fach.Equals(""))
                                {
                                    schueler.Faecher.Add(fach);
                                }
                            }
                            if (!schueler.AlreadyExists())
                            {
                                schueler.addSchueler();
                            }
                            else
                            {
                                schueler.LoadSchuelerID();
                                schueler.Update();
                            }
                        }
                    }
                    else if (target.Equals("t_s_faecher"))
                    {
                        Faecher fach = new Faecher();
                        fach.FachKurz = row[0].ToString();
                        fach.Fach = row[1].ToString();
                        if (!fach.AlreadyExists())
                        {
                            fach.Add();
                        }
                    }

                }
                progressBar1.Value = (fileNum * 100) / files.Count;
            }
            if(fileNum == 0)
            {
                DialogResult dr = MessageBox.Show("Es wurde keine der [" + files.Count + "] Dateien importiert. Möchten Sie es erneut versuchen?", "Import fehlerhaft", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                DialogResult dr = MessageBox.Show("Es wurden erfolgreich ["+ fileNum +" von "+files.Count +"] Dateien importiert. Möchten Sie weitere Daten importieren?", "Import erfolgreich", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
        List<int> removeAt = new List<int>();

        /// <summary>
        /// Klick im Vorschau-Grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gv_Vorschau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int i = gv_Vorschau.SelectedCells[0].ColumnIndex;
                gv_Vorschau.Columns.RemoveAt(i);
                removeAt.Add(i);
            }
            
        }
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
                    removeAt.Clear();
                    indexes.Clear();
                    var lines = File.ReadAllLines(path);
                    cb_FeldTrenn.Text = lines[4];
                    cb_TxtQuali.Text = lines[7];
                    if (lines[10] == "True")
                    {
                        cb_ColHeader.Checked = true;
                    }
                    else
                    {
                        cb_ColHeader.Checked = false;
                    }
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
                    //MessageBox.Show("Der Zugriff auf die Vorlagendatei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //return;
                }
                Cursor.Current = Cursors.Default;
                foreach (int i in removeAt)
                {
                    gv_Vorschau.Columns.RemoveAt(i);
                }
                try
                {
                    DataTable dt = new DataTable();
                    createNewDT(dt, true);
                    gv_Vorschau.DataSource = null;
                    gv_Vorschau.DataSource = dt;
                }
                catch(Exception e)
                {
                    throw new Exception("wrong preset", e);
                    //MessageBox.Show("Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt.", "Fehler bei Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                throw new Exception("no preset");
                //MessageBox.Show("Es ist noch keine Vorlage für "+ filename +" vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
                slider_preview.Enabled = false;
                slider_preview.Minimum = 0;
                slider_preview.Maximum = 0;
            }
            else
            {
                slider_preview.Enabled = true;
                slider_preview.Minimum = 1;
                slider_preview.Maximum = files.Count;
                slider_preview.Value = slider_preview.Maximum;
            }
            tb_min.Text = slider_preview.Value.ToString();
            tb_max.Text = slider_preview.Maximum.ToString();
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

        private void slider_preview_ValueChanged(object sender, EventArgs e)
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
                    MessageBox.Show("Beim Laden der Vorschau ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
