using Bibo_Verwaltung.Helper;
using MetroFramework;
using MetroFramework.Components;
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
    public partial class FormBookSubject : MetroFramework.Forms.MetroForm
    {
        SubjectHelper subjectHelper = new SubjectHelper();


        BuchFach bf = new BuchFach();
        private DataTable buecherListe = new DataTable();
        private bool aenderungungen = false;
        string currentUser;
        bool gast = false;
        public FormBookSubject()
        {
            InitializeComponent();
            LoadTheme();
            SetPermissions();
            this.Text = Text + AuthInfo.FormInfo();
            subjectHelper.FillGrid(ref gv_Faecher);
            foreach (DataGridViewColumn column in gv_Faecher.Columns) 
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void LoadTheme()
        {
            this.StyleManager = styleManagerBookSubject;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.AssignmentStyle;
        }
        private void SetPermissions()
        {
            if (AuthInfo.CurrentUser.PermissionId == 0)
            {
                gast = true;
                bt_Bearbeiten.Enabled = false;
            }
            else if (AuthInfo.CurrentUser.PermissionId == 1)
            {
                gast = false;
                bt_Bearbeiten.Enabled = true;
            }
            else if (AuthInfo.CurrentUser.PermissionId == 2)
            {
                gast = false;
                bt_Bearbeiten.Enabled = true;
                mbt_ImEx.Enabled = true;
            }
        }

        #region Fenster-Methoden
        /// <summary>
        /// Lädt die Zuordnungsübersicht für das gewählte Fach
        /// </summary>
        private void LoadBuecher()
        {
            try
            {
                buecherListe.Rows.Clear();
                if (gv_Faecher.CurrentRow != null)
                {
                    bf.Show_FachBuecher(ref gv_Buecher, gv_Faecher.Rows[gv_Faecher.CurrentRow.Index].Cells["ID"].Value.ToString(), lk);
                }
            }
            catch
            {
                MetroMessageBox.Show(this,"Beim Laden der Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fügt alle vorhandenen Zuordnungen zur Zuornungs-Liste hinzu
        /// </summary>
        private void FillBuecherList()
        {
            try
            {
                buecherListe.Rows.Clear();
                for (int i = 0; i <= gv_Buecher.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = gv_Buecher.Rows[i];
                    string fach = row.Cells["ISBN"].Value.ToString();

                    if (fach.Contains("*"))
                    {
                        DataRow relation;
                        string[] buchDetails = new string[1];

                        buchDetails[0] = row.Cells["ISBN"].Value.ToString().Replace("*", "");

                        if (buecherListe.Columns.Count != 1)
                        {
                            buecherListe.Columns.Add();
                        }
                        relation = buecherListe.NewRow();
                        relation.ItemArray = buchDetails;
                        buecherListe.Rows.Add(relation);
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this,"Beim Anzeigen der bisher zugeordneten Bücher ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fügt einen Eintrag zur Zuornungs-Liste hinzu
        /// </summary>
        private void AddToBuecherList()
        {
            try
            {
                DataGridViewRow row = gv_Buecher.CurrentRow;
                DataRow relation;
                string[] buchDetails = new string[1];

                buchDetails[0] = row.Cells["ISBN"].Value.ToString();

                if (buecherListe.Columns.Count != 1)
                {
                    buecherListe.Columns.Add();
                }
                relation = buecherListe.NewRow();
                relation.ItemArray = buchDetails;
                buecherListe.Rows.Add(relation);

                row.Cells["ISBN"].Value = "*" + row.Cells["ISBN"].Value.ToString();
                row.DefaultCellStyle.BackColor = Color.Yellow;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch
            {
                MetroMessageBox.Show(this,"Beim Hinzufügen dieses Buches zur Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Entfernt einen Eintrag aus der Zuornungs-Liste
        /// </summary>
        private void RemoveFromBuecherList()
        {
            try
            {
                DataGridViewRow gridrow = gv_Buecher.CurrentRow;
                for (int i = buecherListe.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = buecherListe.Rows[i];
                    if (row[0].ToString() == gridrow.Cells["ISBN"].Value.ToString().Replace("*", ""))
                    {
                        row.Delete();
                    }
                }
                buecherListe.AcceptChanges();

                gridrow.Cells["ISBN"].Value = gridrow.Cells["ISBN"].Value.ToString().Replace("*", "");
                gridrow.DefaultCellStyle.BackColor = Color.White;
                gridrow.DefaultCellStyle.ForeColor = Color.DimGray;
            }
            catch
            {
                MetroMessageBox.Show(this,"Beim Entfernen dieses Buches aus der Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Speichert die Zuordnungsdatendaten eines Faches mit vorhandenen Büchern in der Datenbank 
        /// </summary>
        private void SaveZuordnungen()
        {
            if (!gast && gv_Faecher.CurrentRow != null)
            {
                if (aenderungungen == true)
                {
                    DialogResult dr = MetroMessageBox.Show(this,"Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            bf.Save_Zuordnung(buecherListe, gv_Faecher.Rows[gv_Faecher.CurrentRow.Index].Cells["ID"].Value.ToString(),lk);
                            aenderungungen = false;
                        }
                        catch
                        {
                            MetroMessageBox.Show(this,"Die Änderungen konnten nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (gv_Faecher.CurrentRow != null)
                {
                    bt_back.Enabled = true;
                    gv_Buecher.Enabled = true;
                    gv_Faecher.Enabled = false;
                    bf.Show_AllBuecher(ref gv_Buecher, gv_Faecher.Rows[gv_Faecher.CurrentRow.Index].Cells["ID"].Value.ToString(),lk);
                    FillBuecherList();
                    bt_Bearbeiten.Text = "Übernehmen";
                }
            }
            else
            {
                bt_back.Enabled = false;
                gv_Buecher.Enabled = false;
                gv_Faecher.Enabled = true;
                SaveZuordnungen();
                bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
                LoadBuecher();
                gv_Faecher.Select();
                tb_fach.Clear();

            }
        }

        private void gv_Faecher_SelectionChanged(object sender, EventArgs e)
        {
            LoadBuecher();
        }

        private void gv_Buecher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gv_Buecher.CurrentRow;
            string fach = row.Cells["ISBN"].Value.ToString();
            if (!fach.Contains("*"))
            {
                AddToBuecherList();
                aenderungungen = true;
            }
            else
            {
                RemoveFromBuecherList();
                aenderungungen = true;
            }
        }

        private void w_s_buch_fach_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveZuordnungen();
        }
        
        private void bt_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            bt_back.Enabled = false;
            gv_Buecher.Enabled = false;
            gv_Faecher.Enabled = true;
            bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
            LoadBuecher();
            tb_fach.Clear();
        }
        
        private void mbt_ImEx_Click(object sender, EventArgs e)
        {
            w_s_selfmade_dialog custom = new w_s_selfmade_dialog("Modusauswahl", "Wählen Sie den Import- oder den Export-Modus!", "Daten-Import", "Daten-Export");
            custom.ShowDialog(this);
            if (custom.DialogResult == DialogResult.Yes)
            {
                //Import
                MetroMessageBox.Show(this, "Diese Funktion ist in der aktuellen Version noch nicht verfügbar.", "Noch nicht verfügbar.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else if (custom.DialogResult == DialogResult.No)
            {
                try
                {
                    ExcelExport export = new ExcelExport();
                    string[] source = { "t_s_buch_fach" };
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
        #endregion

        private void Gv_Faecher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bt_Bearbeiten.Text == "Zuordnungen bearbeiten")
            {
                if (gv_Faecher.CurrentRow != null)
                {
                    try
                    {
                        bt_back.Enabled = true;
                        gv_Buecher.Enabled = true;
                        gv_Faecher.Enabled = false;
                        bf.Show_AllBuecher(ref gv_Buecher, gv_Faecher.Rows[e.RowIndex].Cells["ID"].Value.ToString(), lk);
                        FillBuecherList();
                        bt_Bearbeiten.Text = "Übernehmen";
                    }
                    catch
                    {
                        bt_back.Enabled = false;
                        gv_Buecher.Enabled = false;
                        gv_Faecher.Enabled = true;
                        bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
                        LoadBuecher();
                        tb_fach.Clear();
                    }

                }
            }
        }
        private void SetColor()
        {
            for (int i = 0; i < gv_Buecher.Rows.Count; i++)
            {
                string klassename = gv_Buecher.Rows[i].Cells[0].Value.ToString();
                if (klassename.Contains("*"))
                {
                    gv_Buecher.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    gv_Buecher.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    gv_Buecher.Rows[i].DefaultCellStyle.BackColor = default;
                    gv_Buecher.Rows[i].DefaultCellStyle.ForeColor = default;
                }
            }
        }
        private void Gv_Buecher_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SetColor();
        }

        private void Gv_Buecher_Sorted(object sender, EventArgs e)
        {
            SetColor();
        }

        private void Gv_Faecher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (bt_Bearbeiten.Text == "Zuordnungen bearbeiten")
                {
                    if (gv_Faecher.CurrentRow != null)
                    {
                        bt_back.Enabled = true;
                        gv_Buecher.Enabled = true;
                        gv_Faecher.Enabled = false;
                        bf.Show_AllBuecher(ref gv_Buecher, gv_Faecher.Rows[gv_Faecher.SelectedRows[0].Index].Cells["ID"].Value.ToString(),lk);
                        FillBuecherList();
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

        private void Gv_Buecher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataGridViewRow row = gv_Buecher.CurrentRow;
                string fach = row.Cells["ISBN"].Value.ToString();
                if (!fach.Contains("*"))
                {
                    AddToBuecherList();
                    aenderungungen = true;
                }
                else
                {
                    RemoveFromBuecherList();
                    aenderungungen = true;
                }
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                bt_back.Select();
                e.SuppressKeyPress = true;
            }
        }

        private void Tb_isbn_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Tb_titel_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void Filter()
        {
            try
            {
                (gv_Buecher.DataSource as DataTable).DefaultView.RowFilter = string.Format("Titel LIKE '%{0}%' and ISBN LIKE '%{1}%'", tb_titel.Text, tb_isbn.Text);
                SetColor();
            }
            catch
            {

            }
        }
        private void FilterFach()
        {
            try
            {
                (gv_Faecher.DataSource as DataTable).DefaultView.RowFilter = string.Format("Langbezeichnung LIKE '%{0}%'", tb_fach.Text);
            }
            catch
            {

            }
        }

        private void Gv_Buecher_EnabledChanged(object sender, EventArgs e)
        {
            tb_titel.Enabled = gv_Buecher.Enabled;
            tb_isbn.Enabled = gv_Buecher.Enabled;
            tb_titel.Text = "";
            tb_isbn.Text = "";
            (gv_Buecher.DataSource as DataTable).DefaultView.RowFilter = null;
        }

        private void Tb_fach_TextChanged(object sender, EventArgs e)
        {
            FilterFach();
        }

        private void Gv_Faecher_EnabledChanged(object sender, EventArgs e)
        {
            tb_fach.Enabled = gv_Faecher.Enabled;


            bt_lk.Enabled = gv_Faecher.Enabled;

        }
        bool lk = false;
        private void Bt_lk_Click(object sender, EventArgs e)
        {
            if(bt_lk.Text.Equals("Zu Leistungskurs wechseln",StringComparison.InvariantCultureIgnoreCase))
            {
                //ALLE FÄCHER LEISTUNGSKURS
                bt_lk.Text = "Zu Grundkurs wechseln";
                lb_titel.Text = "Fächer (LK):";
                lk = true;
            }
            else
            {
                //ALLE FÄCHER GRUNDKURS
                //STANDARD FALL
                bt_lk.Text = "Zu Leistungskurs wechseln";
                lb_titel.Text = "Fächer (GK):";
                lk = false;
            }
            LoadBuecher();
        }
    }
}
