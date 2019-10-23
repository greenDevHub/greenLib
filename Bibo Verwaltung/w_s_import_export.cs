using MetroFramework;
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
    public partial class w_s_import_export : Form
    {
        DataTable dataoftable = new DataTable();
        char seperator = ';';
        char feldquali = '"';
        char dattrenn = '.';
        char zeittrenn = ':';
        char dezsym = ',';
        string target = "t_s_kunden";

        public w_s_import_export(DataTable table, bool modus)
        {
            InitializeComponent();
            this.dataoftable = table;
            setModus(modus);
        }
        public w_s_import_export()
        {
            InitializeComponent();
        }

        private void setModus(bool modus)
        {
            if (modus == true)
            {
                lb_anweissung.Text = "Geben Sie die Quelle der zu importierenden Daten an.";
                gb_Ziel.Visible = true;
                bt_Import.Text = "Importieren";
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
            string zieltabelle = cb_Ziel.Text;

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

                MetroMessageBox.Show(this,"Das Feldtrennzeichen ist ungülig! Wählen Sie eines der gültigen Trennzeichen des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Textqualifizierer
            if (txtqualifier == "'" | txtqualifier == "\"")
            {
                feldquali = Convert.ToChar(txtqualifier);
            }
            else
            {
                MetroMessageBox.Show(this,"Der Textqualifizierer ist ungülig! Wählen Sie einen der gültigen Textqualifizierer des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Datumstrennzeichen
            if (datumstrenn.Length == 1)
            {
                dattrenn = Convert.ToChar(datumstrenn);
            }
            else
            {
                MetroMessageBox.Show(this,"Das Datumstrennzeichen ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Zeittrennzeichen
            if (zeittrennchar.Length == 1)
            {
                zeittrenn = Convert.ToChar(zeittrennchar);
            }
            else
            {
                MetroMessageBox.Show(this,"Das Zeittrennzeichen ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Dezimalsymbol
            if (deztrenn.Length == 1)
            {
                dezsym = Convert.ToChar(deztrenn);
            }
            else
            {
                MetroMessageBox.Show(this,"Das Dezimalsymbol ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            ImportExport im = new ImportExport();
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
                MetroMessageBox.Show(this,"Der Pfad: " + tb_path.Text + " ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gv_Vorschau.DataSource = null;
                tb_path.Focus();
            }
        }

        private void startImport()
        {
            Cursor.Current = Cursors.WaitCursor;
            ImportExport im = new ImportExport();
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
            im.Zieltabelle = target;
            im.executeImport();
            Cursor.Current = Cursors.Default;
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
                    MetroMessageBox.Show(this,"Der angegebene Dateiname ist ungültig. Bitte verwenden sie nur Dateien mit der Endung \'.txt\' oder \'.csv\'!");
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
            bt_Import.Enabled = false;
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

        private void bt_Import_Click(object sender, EventArgs e)
        {
            //try
            //{
            getValues();
            startImport();
            //  MetroMessageBox.Show(this,"Der Daten-Importvorgang wurde beendet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch
            //{
            //    MetroMessageBox.Show(this,"Der Daten-Import ist fehlgeschlagen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //clearForm();
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
            ImportExport ie = new ImportExport();
            ie.FillColGrid(ref gv_columns, ie.GetSQLColumns(target));
        }
    }
}
