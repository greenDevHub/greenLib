﻿using System;
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


        private void setModus(bool modus)
        {
            if (modus == true)
            {
                lb_anweissung.Text = "Geben Sie die Quelle der zu importierenden Daten an.";
                bt_Import.Text = "Vorlage anwenden";
            }
            else
            {
                lb_anweissung.Text = "Geben Sie das Ziel der zu exportierenden Daten an.";
                bt_Import.Text = "Exportieren";
            }
        }

        #region Main-Functions (Methods: getValues(), createPreview(), showPreview(), startImport())      
        private void getValues()
        {
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
                MessageBox.Show("Das Feldtrennzeichen ist ungülig! Wählen Sie eines der gültigen Trennzeichen des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Textqualifizierer
            if (txtqualifier == "'" | txtqualifier == "\"")
            {
                feldquali = Convert.ToChar(txtqualifier);
            }
            else
            {
                MessageBox.Show("Der Textqualifizierer ist ungülig! Wählen Sie einen der gültigen Textqualifizierer des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
            im.LineNum = int.Parse(tb_lines.Text);
            im.FillGridViewRows(ref gv_Vorschau);

            Cursor.Current = Cursors.Default;
        }

        private void showPreview(string file)
        {

            if (File.Exists(file))
            {
                getValues();
                createPreview(file);
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
        private void bt_durchsuchen_Click(object sender, EventArgs e)
        {
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

        private void bt_Vorschau_Click(object sender, EventArgs e)
        {
            try
            {
                showPreview(tb_aktuell.Text);
            }
            catch (IOException)
            {
                MessageBox.Show("Der Zugriff auf die Vorlagendatei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void clearForm()
        {
            tb_path.Text = "";
            tb_lines.Text = "0";
            cb_FeldTrenn.SelectedIndex = 1;
            cb_TxtQuali.SelectedIndex = 0;
            gv_Vorschau.DataSource = null;
            lb_Anweissung2.Enabled = false;
            bt_Import.Enabled = true;
            bt_Vorschau.Enabled = false;
            gv_Vorschau.Enabled = false;
            gv_Vorschau.DataSource = null;
            lb_Vorschau.Enabled = false;
            lb_Vorschau1.Enabled = false;
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (tb_path.Text != "")
            {
                lb_Anweissung2.Enabled = true;
                bt_Import.Enabled = true;
                bt_Vorschau.Enabled = true;
                gv_Vorschau.Enabled = true;
                lb_Vorschau.Enabled = true;
                lb_Vorschau1.Enabled = true;
            }
            else
            {
                lb_Anweissung2.Enabled = false;
                bt_Import.Enabled = false;
                bt_Vorschau.Enabled = false;
                gv_Vorschau.Enabled = false;
                gv_Vorschau.DataSource = null;
                lb_Vorschau.Enabled = false;
                lb_Vorschau1.Enabled = false;
            }
        }
        bool usePreset = false;
        private void bt_Import_Click(object sender, EventArgs e)
        {
            loadProfile();
            usePreset = true;
        }

        private void bt_saveProfile_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            createNewDT(dt, false);
            saveProfile();
        }
        #endregion


        DataTable newDT = new DataTable();
        List<int> indexes = new List<int>();
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
        private void bt_accept_Click(object sender, EventArgs e)
        {
            foreach(string file in files)
            {
                tb_aktuell.Text = file;
                loadProfile();
                foreach (DataRow row in newDT.Rows)
                {
                    if (target.Equals("t_s_schueler"))
                    {
                        Schueler schueler = new Schueler(true);
                        schueler.Vorname = row[0].ToString();
                        schueler.Nachname = row[1].ToString();
                        schueler.Gd = row[2].ToString();
                        schueler.Klasse = row[3].ToString();
                        if (rb_schueler1.Checked)
                        {
                            //SEK1 Import Schüler
                            schueler.Klassenstufe = row[4].ToString();
                            for (int i = 5; i < 8; i++)
                            {
                                string fach = row[i].ToString();
                                schueler.Faecher.Add(fach);
                            }
                            schueler.Faecher.Add("DE");
                            schueler.Faecher.Add("MA");
                            schueler.Faecher.Add("EN");
                            schueler.Faecher.Add("MU");
                            schueler.Faecher.Add("KU");
                            schueler.Faecher.Add("GEO");
                            schueler.Faecher.Add("GE");
                            if (int.Parse(schueler.Klassenstufe) > 6)
                            {
                                schueler.Faecher.Add("CH");
                            }
                            if (int.Parse(schueler.Klassenstufe) > 5)
                            {
                                schueler.Faecher.Add("PH");
                            }
                            if (int.Parse(schueler.Klassenstufe) < 7)
                            {
                                schueler.Faecher.Add("TC");
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
            }
            
            DialogResult result = MessageBox.Show("Die Daten wurden erfolgreich importiert. Möchten Sie weitere Daten importieren?", "Import erfolgreich", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                clearForm();
            }
            else
            {
                this.Close();
            }

        }
        List<int> removeAt = new List<int>();
        private void gv_Vorschau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                int i = gv_Vorschau.SelectedCells[0].ColumnIndex;
                gv_Vorschau.Columns.RemoveAt(i);
                removeAt.Add(i);
            }
            
        }
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
                catch (IOException)
                {
                    MessageBox.Show("Der Zugriff auf die Vorlagendatei wurde behindert. Bitte schließen Sie Anwendungen, in denen Sie diese ggf. geöffnet haben oder wenden Sie sich an den Administrator.", "Zugriff verweigert", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
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
                catch
                {
                    MessageBox.Show("Die Vorlage konnte nicht auf die Daten angewendet werden. Eventuell haben Sie die falsche Vorlage gewählt.", "Fehler bei Vorlage", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Es ist noch keine Vorlage für "+ filename +" vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
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

        private void tb_lines_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void rb_single_CheckedChanged(object sender, EventArgs e)
        {
            ImportMode();
        }
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

        private void slider_preview_Scroll(object sender, ScrollEventArgs e)
        {
            tb_min.Text = slider_preview.Value.ToString();
            tb_max.Text = slider_preview.Maximum.ToString();
            tb_aktuell.Text = files[slider_preview.Value-1];
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

        private void bt_removefile_Click(object sender, EventArgs e)
        {
            RemoveFromImportList();
        }
    }
}
