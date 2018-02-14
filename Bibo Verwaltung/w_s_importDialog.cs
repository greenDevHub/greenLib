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
    public partial class w_s_importDialog : Form
    {
        DataTable data = new DataTable();
        char seperator = ';';
        char feldquali = '"';
        char dattrenn = '.';
        char zeittrenn = ':';
        char dezsym = ',';

        public w_s_importDialog()
        {
            InitializeComponent();
        }

        private void bt_durchsuchen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Wählen Sie eine Datei für den Datenimport";
            openFileDialog.Filter = "Text Files|*.txt; *.csv";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb_path.Text = openFileDialog.FileName;
            }
        }

        private void w_s_importDialog_Shown(object sender, EventArgs e)
        {
            cb_FeldTrenn.SelectedIndex = 1;
            cb_TxtQuali.SelectedIndex = 0;
            cb_DatFolge.SelectedIndex = 0;
            cb_Ziel.SelectedIndex = 0;
        }

        private void getImportValues()
        {
            string feldtrenn = cb_FeldTrenn.Text;
            string txtqualifier = cb_TxtQuali.Text;
            string datumstrenn = tb_DatTrenn.Text;
            string zeittrennchar = tb_ZeitTrenn.Text;
            string deztrenn = tb_DezSym.Text;

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
        }

        private void createPreview()
        {
            Cursor.Current = Cursors.WaitCursor;           
            Import im = new Import(tb_path.Text, seperator, feldquali, cb_DatFolge.Text, dattrenn, zeittrenn, ch_4stelligeJahre.Checked, ch_DatNullen.Checked, dezsym, cb_ColHeader.Checked);
            im.FillGridViewRows(ref gv_Vorschau);
            data = im.table();
            Cursor.Current = Cursors.Default;
        }

        private void executeKundenImport()
        {
            Cursor.Current = Cursors.WaitCursor;
            Import im = new Import(tb_path.Text, seperator, feldquali, cb_DatFolge.Text, dattrenn, zeittrenn, ch_4stelligeJahre.Checked, ch_DatNullen.Checked, dezsym, cb_ColHeader.Checked);
            data = im.table();
            Cursor.Current = Cursors.Default;
        }

        private void bt_Vorschau_Click(object sender, EventArgs e)
        {
            showPreview();
            #region trrdfg
            //if (File.Exists(tb_path.Text))
            //{
            //    getImportValues();

            //    #region auskommentiert
            //    //    string feldtrenn = cb_FeldTrenn.Text;
            //    //    string txtqualifier = cb_TxtQuali.Text;
            //    //    string datumstrenn = tb_DatTrenn.Text;
            //    //    string zeittrennchar = tb_ZeitTrenn.Text;
            //    //    string deztrenn = tb_DezSym.Text;

            //    //    char seperator = ';';
            //    //    char feldquali = '"';
            //    //    char dattrenn = '.';
            //    //    char zeittrenn = ':';
            //    //    char dezsym = ',';

            //    //    //Seperator
            //    //    if (feldtrenn == "," | feldtrenn == ";" | feldtrenn == "{Leerzeichen}")
            //    //    {
            //    //        if (feldtrenn == "{Leerzeichen}")
            //    //        {
            //    //            feldtrenn = " ";
            //    //        }
            //    //        seperator = Convert.ToChar(feldtrenn);
            //    //    }
            //    //    else if (feldtrenn == "{Tabulator}")
            //    //    {
            //    //        seperator = '\t';
            //    //    }
            //    //    else
            //    //    {
            //    //        MessageBox.Show("Das Feldtrennzeichen ist ungülig! Wählen Sie eines der gültigen Trennzeichen des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    }

            //    //    //Textqualifizierer
            //    //    if (txtqualifier == "'" | txtqualifier == "\"")
            //    //    {
            //    //        feldquali = Convert.ToChar(txtqualifier);
            //    //    }
            //    //    else
            //    //    {
            //    //        MessageBox.Show("Der Textqualifizierer ist ungülig! Wählen Sie einen der gültigen Textqualifizierer des Auswahlmenüs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    }

            //    //    //Datumstrennzeichen
            //    //    if (datumstrenn.Length == 1)
            //    //    {
            //    //        dattrenn = Convert.ToChar(datumstrenn);
            //    //    }
            //    //    else
            //    //    {
            //    //        MessageBox.Show("Das Datumstrennzeichen ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    }

            //    //    //Zeittrennzeichen
            //    //    if (zeittrennchar.Length == 1)
            //    //    {
            //    //        zeittrenn = Convert.ToChar(zeittrennchar);
            //    //    }
            //    //    else
            //    //    {
            //    //        MessageBox.Show("Das Zeittrennzeichen ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    }

            //    //    //Dezimalsymbol
            //    //    if (deztrenn.Length == 1)
            //    //    {
            //    //        dezsym = Convert.ToChar(deztrenn);
            //    //    }
            //    //    else
            //    //    {
            //    //        MessageBox.Show("Das Dezimalsymbol ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    //    }


            //    //seperator = feldtrenn.ToCharArray(0, feldtrenn.Length);




            //    //if (feldtrenn == "," | feldtrenn == ";" | feldtrenn == "{Leerzeichen}" | feldtrenn == "{Tabulator}")
            //    //{
            //    //    if (feldtrenn == "{Leerzeichen}")
            //    //    {
            //    //        feldtrenn = " ";
            //    //    }

            //    //    else if (feldtrenn == "{Tabulator}")
            //    //    {
            //    //        char c = '\t';
            //    //    }
            //    //}
            //    //seperator = feldtrenn.ToCharArray(0, feldtrenn.Length);



            //    //seperator = feldtrenn.ToCharArray(0, feldtrenn.Length);
            //    //foreach (char c in seperator)
            //    //    Console.WriteLine(c);

            //    //Console.WriteLine("--------------");

            //    //feldquali = cb_TxtQuali.Text.ToCharArray(0, cb_TxtQuali.Text.Length);
            //    //foreach (char c in feldquali)
            //    //    Console.WriteLine(c);

            //    //Console.WriteLine("--------------");

            //    //datfolge = cb_DatFolge.Text.ToCharArray(0, cb_DatFolge.Text.Length);
            //    //foreach (char c in datfolge)
            //    //    Console.WriteLine(c);

            //    //Console.WriteLine("--------------");

            //    //dattrenn = tb_DatTrenn.Text.ToCharArray(0, tb_DatTrenn.Text.Length);
            //    //foreach (char c in dattrenn)
            //    //    Console.WriteLine(c);

            //    //Console.WriteLine("--------------");

            //    //zeittrenn = tb_ZeitTrenn.Text.ToCharArray(0, tb_ZeitTrenn.Text.Length);
            //    //foreach (char c in zeittrenn)
            //    //    Console.WriteLine(c);

            //    //Console.WriteLine("--------------");

            //    //dezsym = tb_DezSym.Text.ToCharArray(0, tb_DezSym.Text.Length);
            //    //foreach (char c in dezsym)
            //    //    Console.WriteLine(c);


            //    Import im = new Import(tb_path.Text, seperator, feldquali, cb_DatFolge.Text, dattrenn, zeittrenn, ch_4stelligeJahre.Checked, ch_DatNullen.Checked, dezsym, cb_ColHeader.Checked);
            //    im.FillGridViewRows(ref gv_Vorschau);
            //    #endregion

            //    createPreview();
            //}
            //else
            //{
            //    MessageBox.Show("Der Pfad: " + tb_path.Text + " ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    gv_Vorschau.DataSource = null;
            //    tb_path.Focus();
            //}
            #endregion
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

        private void cb_ColHeader_CheckedChanged(object sender, EventArgs e)
        {
            showPreview();
        }

        private void showPreview()
        {
            if (File.Exists(tb_path.Text))
            {
                getImportValues();
                createPreview();
            }
            else
            {
                MessageBox.Show("Der Pfad: " + tb_path.Text + " ist ungülig!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gv_Vorschau.DataSource = null;
                tb_path.Focus();
            }
        }

        private void bt_Import_Click(object sender, EventArgs e)
        {
            executeKundenImport();
            int i = 0;
            foreach (DataRow row in data.Rows)
            {
                
Kunde kunde = new Kunde();
                kunde.Vorname = data.Rows[i][0].ToString();
                kunde.Nachname = data.Rows[i][1].ToString();
                kunde.Strasse = data.Rows[i][2].ToString();
                kunde.Hausnummer = data.Rows[i]["kunde_hausnummer"].ToString();
                kunde.Postleitzahl = data.Rows[i][4].ToString();
                kunde.Ort = data.Rows[i][5].ToString();
                kunde.Vertrauenswuerdigkeit = data.Rows[i][6].ToString();
                kunde.Klasse = data.Rows[i]["kunde_klasse"].ToString();
                kunde.Mail = data.Rows[i]["kunde_mail"].ToString();
                kunde.Telefonnummer = data.Rows[i]["kunde_telefonnummer"].ToString();
                kunde.addKunde();
                i++;
            }
                //kunde.SaveImport(data);
        }
    }
}
