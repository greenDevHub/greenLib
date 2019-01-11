using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_schuelerimport : Form
    {
        DataTable dataoftable = new DataTable();
        char seperator = ';';
        char feldquali = '"';
        char dattrenn = '.';
        char zeittrenn = ':';
        char dezsym = ',';
        string target = "t_s_schueler";

        public w_s_schuelerimport(DataTable table, bool modus)
        {
            InitializeComponent();
            this.dataoftable = table;
            setModus(modus);
        }
        public w_s_schuelerimport(bool modus)
        {
            InitializeComponent();
            setModus(modus);
        }

        private void setModus(bool modus)
        {
            if (modus == true)
            {
                lb_anweissung.Text = "Geben Sie die Quelle der zu importierenden Daten an.";
                gb_Ziel.Visible = true;
                bt_Import.Text = "Vorlage anwenden";
            }
            else
            {
                lb_anweissung.Text = "Geben Sie das Ziel der zu exportierenden Daten an.";
                gb_Ziel.Visible = false;
                bt_Import.Text = "Exportieren";
            }
        }

        #region Main-Functions (Methods: getValues(), createPreview(), showPreview(), startImport())      
        private void getValues()
        {
            string feldtrenn = cb_FeldTrenn.Text;
            string txtqualifier = cb_TxtQuali.Text;
            string datumstrenn = tb_DatTrenn.Text;
            string zeittrennchar = tb_ZeitTrenn.Text;
            string deztrenn = tb_DezSym.Text;
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

            //Datumstrennzeichen
            if (datumstrenn.Length == 1)
            {
                dattrenn = Convert.ToChar(datumstrenn);
            }
            else
            {
                MessageBox.Show("Das Datumstrennzeichen ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Zeittrennzeichen
            if (zeittrennchar.Length == 1)
            {
                zeittrenn = Convert.ToChar(zeittrennchar);
            }
            else
            {
                MessageBox.Show("Das Zeittrennzeichen ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Dezimalsymbol
            if (deztrenn.Length == 1)
            {
                dezsym = Convert.ToChar(deztrenn);
            }
            else
            {
                MessageBox.Show("Das Dezimalsymbol ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Zieltabelle
            //if (zieltabelle == "Kundentabelle")
            //{
            //    target = "t_s_kunden";
            //}
            //else if (zieltabelle == "Büchertabelle")
            //{
            //    target = "t_s_buecher";
            //}
            //else if (zieltabelle == "Exemplartabelle")
            //{
            //    target = "t_s_buchid";
            //}
            //else if(zieltabelle == "Fächertabelle")
            //{
            //    target = "t_s_faecher";
            //}
            //else if(zieltabelle == "Schülertabelle")
            //{
            //    target = "t_s_schueler";
            //}
        }

        private void createPreview()
        {
            Cursor.Current = Cursors.WaitCursor;
            Schuelerimport im = new Schuelerimport();
            im.Path = tb_path.Text;
            im.Separator = seperator;
            im.Textqualifizierer = feldquali;
            im.Datumsfolge = cb_DatFolge.Text;
            im.Datumstrennzeichen = dattrenn;
            im.Zeittrennzeichen = zeittrenn;
            im.Vierstelligejahre = ch_4stelligeJahre.Checked;
            im.FuehrendeDatumsnull = ch_DatNullen.Checked;
            im.Dezimaltrennzeichen = dezsym;
            im.ColumnHeader = cb_ColHeader.Checked;
            im.LineNum = 0;
            im.LineNum = int.Parse(tb_lines.Text);
            im.FillGridViewRows(ref gv_Vorschau);
            Cursor.Current = Cursors.Default;
        }

        private void showPreview()
        {
            if (File.Exists(tb_path.Text))
            {
                getValues();
                createPreview();
            }
            else
            {
                MessageBox.Show("Der Pfad: " + tb_path.Text + " ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gv_Vorschau.DataSource = null;
                tb_path.Focus();
            }
        }

        
        #endregion

        #region Object-Functions
        private void FileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wählen Sie eine Datei für den Datenimport";
            openFileDialog.Filter = "Text Files|*.txt; *.csv";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog.FileName.Contains(".txt") || openFileDialog.FileName.Contains(".csv"))
                {
                    tb_path.Text = openFileDialog.FileName;
                }
                else
                {
                    tb_path.Text = "";
                    MessageBox.Show("Der angegebene Dateiname ist ungültig. Bitte verwenden sie nur Dateien mit der Endung \'.txt\' oder \'.csv\'!");
                    FileDialog();
                }
            }

        }
        private void bt_durchsuchen_Click(object sender, EventArgs e)
        {
            FileDialog();
        }

        private void w_s_importDialog_Shown(object sender, EventArgs e)
        {
            cb_FeldTrenn.SelectedIndex = 1;
            cb_TxtQuali.SelectedIndex = 0;
            cb_DatFolge.SelectedIndex = 0;
            cb_Ziel.SelectedIndex = 0;
        }

        private void bt_Vorschau_Click(object sender, EventArgs e)
        {
            showPreview();
        }

        private void clearForm()
        {
            tb_path.Text = "";
            tb_DatTrenn.Text = ".";
            tb_ZeitTrenn.Text = ":";
            tb_DezSym.Text = ",";
            cb_DatFolge.SelectedIndex = 0;
            cb_FeldTrenn.SelectedIndex = 1;
            cb_TxtQuali.SelectedIndex = 0;
            cb_Ziel.SelectedIndex = 0;
            gv_Vorschau.DataSource = null;
            gb_Formatierung.Enabled = false;
            gb_Dateiformat.Enabled = false;
            lb_Anweissung2.Enabled = false;
            gb_Ziel.Enabled = false;
            bt_Import.Enabled = true;
            bt_Vorschau.Enabled = false;
            gv_Vorschau.Enabled = false;
            gv_Vorschau.DataSource = null;
            lb_Vorschau.Enabled = false;
        }

        private void tb_path_TextChanged(object sender, EventArgs e)
        {
            if (tb_path.Text != "")
            {
                gb_Formatierung.Enabled = true;
                gb_Dateiformat.Enabled = true;
                lb_Anweissung2.Enabled = true;
                gb_Ziel.Enabled = true;
                bt_Import.Enabled = true;
                bt_Vorschau.Enabled = true;
                gv_Vorschau.Enabled = true;
                lb_Vorschau.Enabled = true;
            }
            else
            {
                gb_Formatierung.Enabled = false;
                gb_Dateiformat.Enabled = false;
                lb_Anweissung2.Enabled = false;
                gb_Ziel.Enabled = false;
                bt_Import.Enabled = false;
                bt_Vorschau.Enabled = false;
                gv_Vorschau.Enabled = false;
                gv_Vorschau.DataSource = null;
                lb_Vorschau.Enabled = false;
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

        private void startImport()
        {
            Cursor.Current = Cursors.WaitCursor;
            Schuelerimport im = new Schuelerimport();
            im.Path = tb_path.Text;
            im.Separator = seperator;
            im.Textqualifizierer = feldquali;
            im.Datumsfolge = cb_DatFolge.Text;
            im.Datumstrennzeichen = dattrenn;
            im.Zeittrennzeichen = zeittrenn;
            im.Vierstelligejahre = ch_4stelligeJahre.Checked;
            im.FuehrendeDatumsnull = ch_DatNullen.Checked;
            im.Dezimaltrennzeichen = dezsym;
            im.LineNum = int.Parse(tb_lines.Text);
            im.ColumnHeader = cb_ColHeader.Checked;
            im.Zieltabelle = "t_s_schueler";
            im.executeImport();
            Cursor.Current = Cursors.Default;
        }
        #endregion

        private void cb_Ziel_SelectedIndexChanged(object sender, EventArgs e)
        {
            string zieltabelle = cb_Ziel.Text;
            if (zieltabelle == "Kundentabelle")
            {
                target = "t_s_kunden";
            }
            else if (zieltabelle == "Büchertabelle")
            {
                target = "t_s_buecher";
            }
            else if (zieltabelle == "Exemplartabelle")
            {
                target = "t_s_buchid";
            }
            else if (zieltabelle == "Fächertabelle")
            {
                target = "t_s_faecher";
            }
            else if (zieltabelle == "Schülertabelle")
            {
                target = "t_s_schueler";
            }
            Schuelerimport ie = new Schuelerimport();
            //ie.FillColGrid(ref gv_columns, ie.GetSQLColumns(target));
        }
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
                //for (int i = 0;i< indexes.Count;i++)
                //{
                //}
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
            dataGridView1.DataSource = dt;
            newDT = dt;
        }
        private void bt_accept_Click(object sender, EventArgs e)
        {

            //DataTable dt = new DataTable();
            //createNewDT(dt, usePreset);
            foreach (DataRow row in newDT.Rows)
            {
                Schueler schueler = new Schueler(true);
                schueler.Vorname = row[0].ToString();
                schueler.Nachname = row[1].ToString();
                schueler.Gd = row[2].ToString();
                schueler.Klasse = row[3].ToString();
                if (radioButton1.Checked)
                {
                    //SEK1
                    schueler.Klassenstufe = row[4].ToString();
                    for (int i = 5; i < 8; i++)
                    {
                        //string test = row[i].ToString();
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
                        //MessageBox.Show("Der Schüler " + schueler.Vorname + " existiert bereits.");
                    }

                }
                //////////else if (radioButton2.Checked)
                //////////{
                //////////    //SEK2
                //////////    schueler.Klassenstufe = schueler.Klasse.Substring(0, schueler.Klasse.IndexOf("_"));
                //////////    for (int i = 4; i < newDT.Columns.Count; i++)
                //////////    {
                //////////        string fachid = schueler.FachListe.Fach.GetID(row[i].ToString());
                //////////        schueler.FachListe.FachIDs.Add(fachid);
                //////////    }
                //////////    for (int i = schueler.FachListe.FachIDs.Count; i < 17; i++)
                //////////    {
                //////////        schueler.FachListe.FachIDs.Add(null);
                //////////    }
                //////////    if (!schueler.AlreadyExists())
                //////////    {

                //////////        schueler.FachListe.Add();
                //////////        schueler.addKunde();
                //////////    }
                //////////    else
                //////////    {
                //////////        schueler.FachListe.FachListeID = schueler.GetFachID(schueler.SchuelerID);
                //////////        schueler.Update();
                //////////    }
                //////////}

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
            if (radioButton1.Checked)
            {
                //sek1
                string path = set.HomePath + "\\profile_SEK1.txt";
                if (File.Exists(path))
                {
                    removeAt.Clear();
                    indexes.Clear();
                    var lines = File.ReadAllLines(path);
                    cb_FeldTrenn.Text = lines[4];
                    cb_TxtQuali.Text = lines[7];
                    if(lines[10] == "True")
                    {
                        cb_ColHeader.Checked = true;
                    }
                    else
                    {
                        cb_ColHeader.Checked = false;
                    }
                    tb_lines.Text = lines[13];
                    bool first = true;
                    for(int i = 16; i < lines.Length;)
                    {
                        if (!lines[i].Contains("--") && first)
                        {
                            removeAt.Add(int.Parse(lines[i]));
                            i++;
                        }
                        else if(lines[i].Contains("--")&&first)
                        {
                            first = false;
                            i = i + 2;
                        }
                        if(!lines[i].Contains("--") && !first)
                        {
                            indexes.Add(int.Parse(lines[i]));
                            i++;
                        }
                        else if(lines[i].Contains("--") && !first)
                        {
                            i = lines.Length;
                        }
                    }
                    showPreview();
                    foreach(int i in removeAt)
                    {
                        gv_Vorschau.Columns.RemoveAt(i);
                    }
                    DataTable dt = new DataTable();
                    createNewDT(dt, true);
                    gv_Vorschau.DataSource = null;
                    gv_Vorschau.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Es ist noch keine Vorlage für SEK1 vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            else
            {
                //sek2
                string path = set.HomePath + "\\profile_SEK2.txt";
                if (File.Exists(path))
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
                    showPreview();
                    foreach (int i in removeAt)
                    {
                        gv_Vorschau.Columns.RemoveAt(i);
                    }
                    DataTable dt = new DataTable();
                    createNewDT(dt, true);
                    gv_Vorschau.DataSource = null;
                    gv_Vorschau.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("Es ist noch keine Vorlage für SEK2 vorhanden. Führen Sie bitte einen entsprechenden Import manuell aus, um eine Vorlage zu erstellen.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void saveProfile()
        {
            Einstellung set = new Einstellung();
            string path = set.HomePath + "\\profile";
            if (radioButton1.Checked)
            {
                if(File.Exists(path + "_SEK1.txt"))
                {
                    File.Delete(path + "_SEK1.txt");
                }
                TextWriter tw = new StreamWriter(path + "_SEK1.txt");
                tw.WriteLine("----------------------------------------------------");
                tw.WriteLine("SEK1 PROFIL");
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
            else
            {
                if (File.Exists(path + "_SEK2.txt"))
                {
                    File.Delete(path + "_SEK2.txt");
                }
                TextWriter tw = new StreamWriter(path + "_SEK2.txt");
                tw.WriteLine("----------------------------------------------------");
                tw.WriteLine("SEK2 PROFIL");
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
                tw.WriteLine("SORTED COLUMNS");
                foreach (int i in indexes)
                {
                    tw.WriteLine(i.ToString());
                }
                tw.WriteLine("----------------------------------------------------");
                tw.Close();
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Schuelerimport si = new Schuelerimport();
            if (radioButton1.Checked)
            {
                //Sek1
                si.FillColGrid(ref gv_columns, true);
            }
            if (radioButton2.Checked)
            {
                //Sek2
                si.FillColGrid(ref gv_columns, false);
            }
        }
    }
}
