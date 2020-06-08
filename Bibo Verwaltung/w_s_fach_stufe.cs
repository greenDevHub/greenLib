using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_fach_stufe : MetroFramework.Forms.MetroForm
    {
        FachStufe fs = new FachStufe();
        private DataTable faecherListe = new DataTable();
        private bool aenderungungen = false;
        string currentUser;
        bool gast = false;
        public w_s_fach_stufe(string userName)
        {
            InitializeComponent();
            Benutzer user = new Benutzer(userName);
            this.currentUser = userName;
            if (user.Rechteid.Equals("0"))
            {
                gast = true;
                bt_Bearbeiten.Enabled = false;
            }
            else if (user.Rechteid == "1")
            {
                gast = false;
                bt_Bearbeiten.Enabled = true;
            }
            else if (user.Rechteid == "2")
            {
                gast = false;
                bt_Bearbeiten.Enabled = true;
                mbt_ImEx.Enabled = true;
            }
            this.Text = Text + " - Angemeldet als: " + userName;
            IniKlassenstufen();
            //LoadFaecher();
        }

        #region Fenster-Methoden
        /// <summary>
        /// Initialisiert die Klassenstufen-GridView
        /// </summary>
        private void IniKlassenstufen()
        {
            try
            {
                gv_Klassenstufe.Columns.Add("Klassenstufe", "Klassenstufen");
                gv_Klassenstufe.Columns["Klassenstufe"].SortMode = DataGridViewColumnSortMode.NotSortable;
                for (int i = 1; i <= 13; i++)
                {
                    gv_Klassenstufe.Rows.Add("Klassenstufe " + i.ToString());
                }
                gv_Klassenstufe.Focus();
            }
            catch { }
        }

        /// <summary>
        /// Lädt die Zuordnungsübersicht für die gewählte Klassenstufe
        /// </summary>
        private void LoadFaecher()
        {
            try
            {
                faecherListe.Rows.Clear();
                if (gv_Klassenstufe.CurrentRow != null)
                {
                    fs.Show_StufenFaecher(ref gv_Faecher, (gv_Klassenstufe.CurrentRow.Index + 1).ToString());
                }
                else
                {
                    fs.Show_StufenFaecher(ref gv_Faecher, "1");
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Laden der Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fügt alle vorhandenen Zuordnungen zur Zuornungs-Liste hinzu
        /// </summary>
        private void FillFaecherList()
        {
            try
            {
                faecherListe.Rows.Clear();
                for (int i = 0; i <= gv_Faecher.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = gv_Faecher.Rows[i];
                    string fach = row.Cells["Kürzel"].Value.ToString();

                    if (fach.Contains("*"))
                    {
                        DataRow relation;
                        string[] fachDetails = new string[1];

                        fachDetails[0] = row.Cells["ID"].Value.ToString();

                        if (faecherListe.Columns.Count != 1)
                        {
                            faecherListe.Columns.Add();
                        }
                        relation = faecherListe.NewRow();
                        relation.ItemArray = fachDetails;
                        faecherListe.Rows.Add(relation);
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Anzeigen der bisher zugeordneten Fächer ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fügt einen Eintrag zur Zuornungs-Liste hinzu
        /// </summary>
        private void AddToFaecherList()
        {
            try
            {
                DataGridViewRow row = gv_Faecher.CurrentRow;
                DataRow relation;
                string[] exemlarDetails = new string[1];

                exemlarDetails[0] = row.Cells["ID"].Value.ToString();

                if (faecherListe.Columns.Count != 1)
                {
                    faecherListe.Columns.Add();
                }
                relation = faecherListe.NewRow();
                relation.ItemArray = exemlarDetails;
                faecherListe.Rows.Add(relation);

                row.Cells["Kürzel"].Value = "*" + row.Cells["Kürzel"].Value.ToString();
                row.DefaultCellStyle.BackColor = Color.Yellow;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Hinzufügen dieses Faches zur Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Entfernt einen Eintrag aus der Zuornungs-Liste
        /// </summary>
        private void RemoveFromFaecherList()
        {
            try
            {
                DataGridViewRow gridrow = gv_Faecher.CurrentRow;
                for (int i = faecherListe.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = faecherListe.Rows[i];
                    if (row[0].ToString() == gridrow.Cells["ID"].Value.ToString())
                    {
                        row.Delete();
                    }
                }
                faecherListe.AcceptChanges();

                gridrow.Cells["Kürzel"].Value = gridrow.Cells["Kürzel"].Value.ToString().Substring(1);
                gridrow.DefaultCellStyle.BackColor = Color.White;
                gridrow.DefaultCellStyle.ForeColor = Color.DimGray;
            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Entfernen dieses Faches aus der Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Speichert die Zuordnungsdatendaten einer Klassenstufe mit vorhandenen Fächern in der Datenbank 
        /// </summary>
        private void SaveZuordnungen()
        {
            if (!gast && gv_Klassenstufe.CurrentRow != null)
            {
                if (aenderungungen == true)
                {
                    DialogResult dr = MetroMessageBox.Show(this, "Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            fs.Save_Zuordnung(faecherListe, (gv_Klassenstufe.CurrentRow.Index + 1).ToString());
                            aenderungungen = false;
                        }
                        catch
                        {
                            MetroMessageBox.Show(this, "Die Änderungen konnten nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
        #endregion

        #region Componenten-Aktionen
        private void bt_Bearbeiten_Click(object sender, EventArgs e)
        {
            if (bt_Bearbeiten.Text == "Zuordnungen bearbeiten")
            {
                if (gv_Klassenstufe.CurrentRow != null)
                {
                    bt_back.Enabled = true;
                    gv_Faecher.Enabled = true;
                    gv_Klassenstufe.Enabled = false;
                    fs.Show_AllFaecher(ref gv_Faecher, (gv_Klassenstufe.CurrentRow.Index + 1).ToString());
                    FillFaecherList();
                    bt_Bearbeiten.Text = "Übernehmen";
                }
            }
            else
            {
                bt_back.Enabled = false;
                gv_Faecher.Enabled = false;
                gv_Klassenstufe.Enabled = true;
                SaveZuordnungen();
                bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
                LoadFaecher();
                gv_Klassenstufe.Select();
            }
        }

        private void gv_Klassenstufe_SelectionChanged(object sender, EventArgs e)
        {
            LoadFaecher();
        }

        private void gv_Faecher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gv_Faecher.CurrentRow;
            string fach = row.Cells["Kürzel"].Value.ToString();
            if (!fach.Contains("*"))
            {
                AddToFaecherList();
                aenderungungen = true;
            }
            else
            {
                RemoveFromFaecherList();
                aenderungungen = true;
            }
        }

        private void w_s_fach_stufe_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveZuordnungen();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            bt_back.Enabled = false;
            gv_Faecher.Enabled = false;
            gv_Klassenstufe.Enabled = true;
            bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
            LoadFaecher();
        }

        private void btAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private void mbt_ImEx_Click(object sender, EventArgs e)
        {
            Form custom = new w_s_selfmade_dialog("Modusauswahl", "Wählen Sie den Import- oder den Export-Modus!", "Daten-Import", "Daten-Export");
            custom.ShowDialog(this);
            if (custom.DialogResult == DialogResult.Yes)
            {
                //Form autoausleihe = new w_s_automatic(currentUser);
                //autoausleihe.ShowDialog(this);
            }
            else if (custom.DialogResult == DialogResult.No)
            {
                try
                {
                    ExcelExport export = new ExcelExport();
                    string[] source = { "t_s_fach_stufe" };
                    export.ExportAsCSV(source);
                    MetroMessageBox.Show(this, "Export erfolgreich abgeschlossen", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch
                {
                    MetroMessageBox.Show(this, "Beim Exportvorgang ist ein Fehler aufgetreten!", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else { }
        }
        private void Gv_Klassenstufe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bt_Bearbeiten.Text == "Zuordnungen bearbeiten")
            {
                if (gv_Klassenstufe.CurrentRow != null)
                {
                    bt_back.Enabled = true;
                    gv_Faecher.Enabled = true;
                    gv_Klassenstufe.Enabled = false;
                    fs.Show_AllFaecher(ref gv_Faecher, (e.RowIndex + 1).ToString());
                    FillFaecherList();
                    bt_Bearbeiten.Text = "Übernehmen";
                }
            }
            
        }
        private void SetColor()
        {
            for (int i = 0; i < gv_Faecher.Rows.Count; i++)
            {
                string klassename = gv_Faecher.Rows[i].Cells[1].Value.ToString();
                if (klassename.Contains("*"))
                {
                    gv_Faecher.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    gv_Faecher.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    gv_Faecher.Rows[i].DefaultCellStyle.BackColor = default;
                    gv_Faecher.Rows[i].DefaultCellStyle.ForeColor = default;
                }
            }
        }
        private void Gv_Faecher_Sorted(object sender, EventArgs e)
        {
            SetColor();
        }

        private void Gv_Faecher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetColor();
        }

        private void Gv_Klassenstufe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (bt_Bearbeiten.Text == "Zuordnungen bearbeiten")
                {
                    if (gv_Klassenstufe.CurrentRow != null)
                    {
                        bt_back.Enabled = true;
                        gv_Faecher.Enabled = true;
                        gv_Klassenstufe.Enabled = false;
                        fs.Show_AllFaecher(ref gv_Faecher, (gv_Klassenstufe.SelectedRows[0].Index+1).ToString());
                        FillFaecherList();
                        bt_Bearbeiten.Text = "Übernehmen";
                    }
                }
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                bt_Bearbeiten.Select();
                e.SuppressKeyPress = true;
            }

        }

        private void Gv_Faecher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow row = gv_Faecher.CurrentRow;
                string fach = row.Cells["Kürzel"].Value.ToString();
                if (!fach.Contains("*"))
                {
                    AddToFaecherList();
                    aenderungungen = true;
                }
                else
                {
                    RemoveFromFaecherList();
                    aenderungungen = true;
                }
                e.SuppressKeyPress = true;
            }
            else if(e.KeyCode == Keys.Tab)
            {
                bt_back.Select();
                e.SuppressKeyPress = true;
            }
            
        }
    }
}