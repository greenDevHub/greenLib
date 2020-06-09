﻿using MetroFramework;
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
    public partial class w_s_buch_stufe : MetroFramework.Forms.MetroForm
    {
        BuchStufe bs = new BuchStufe();
        private DataTable buecherListe = new DataTable();
        private bool aenderungungen = false;
        string currentUser;
        bool gast = false;
        public w_s_buch_stufe(string userName, MetroStyleManager msm)
        {
            InitializeComponent();
            msm_buch_stufe = msm;
            this.StyleManager = msm;
            this.StyleManager.Style = MetroColorStyle.Orange;
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
            LoadBuecher();
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
        private void LoadBuecher()
        {
            try
            {
                buecherListe.Rows.Clear();
                if (gv_Klassenstufe.CurrentRow != null)
                {
                    bs.Show_StufenBuecher(ref gv_Buecher, (gv_Klassenstufe.CurrentRow.Index + 1).ToString());
                }
                else
                {
                    bs.Show_StufenBuecher(ref gv_Buecher, "1");
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
        private void FillFaecherList()
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

                        buchDetails[0] = row.Cells["ISBN"].Value.ToString().Replace("*","");

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

                gridrow.Cells["ISBN"].Value = gridrow.Cells["ISBN"].Value.ToString().Substring(1);
                gridrow.DefaultCellStyle.BackColor = Color.White;
                gridrow.DefaultCellStyle.ForeColor = Color.DimGray;
            }
            catch
            {
                MetroMessageBox.Show(this,"Beim Entfernen dieses Buches aus der Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Speichert die Zuordnungsdatendaten einer Klassenstufe mit vorhandenen Büchern in der Datenbank 
        /// </summary>
        private void SaveZuordnungen()
        {

            if (!gast && gv_Klassenstufe.CurrentRow != null)
            {
                if (aenderungungen == true)
                {
                    DialogResult dr = MetroMessageBox.Show(this,"Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            bs.Save_Zuordnung(buecherListe, (gv_Klassenstufe.CurrentRow.Index + 1).ToString());
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
                if (gv_Klassenstufe.CurrentRow != null)
                {
                    bt_back.Enabled = true;
                    gv_Buecher.Enabled = true;
                    gv_Klassenstufe.Enabled = false;
                    bs.Show_AllBuecher(ref gv_Buecher, (gv_Klassenstufe.CurrentRow.Index + 1).ToString());                 
                    FillFaecherList();
                    bt_Bearbeiten.Text = "Übernehmen";
                }
            }
            else
            {
                bt_back.Enabled = false;
                gv_Buecher.Enabled = false;
                gv_Klassenstufe.Enabled = true;
                SaveZuordnungen();
                bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
                LoadBuecher();
                gv_Klassenstufe.Select();
            }
        }

        private void gv_Klassenstufe_SelectionChanged(object sender, EventArgs e)
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

        private void w_s_buch_stufe_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveZuordnungen();
        }     

        private void bt_back_Click(object sender, EventArgs e)
        {
            bt_back.Enabled = false;
            gv_Buecher.Enabled = false;
            gv_Klassenstufe.Enabled = true;
            bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
            LoadBuecher();
        }
        
        private void btAbbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mbt_ImEx_Click(object sender, EventArgs e)
        {
            w_s_selfmade_dialog custom = new w_s_selfmade_dialog("Modusauswahl", "Wählen Sie den Import- oder den Export-Modus!", "Daten-Import", "Daten-Export",msm_buch_stufe);
            msm_buch_stufe.Clone(custom);
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
                    string[] source = { "t_s_buch_stufe" };
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

        private void Gv_Klassenstufe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (bt_Bearbeiten.Text == "Zuordnungen bearbeiten")
            {
                if (gv_Klassenstufe.CurrentRow != null)
                {
                    bt_back.Enabled = true;
                    gv_Buecher.Enabled = true;
                    gv_Klassenstufe.Enabled = false;
                    bs.Show_AllBuecher(ref gv_Buecher, (e.RowIndex + 1).ToString());
                    FillFaecherList();
                    bt_Bearbeiten.Text = "Übernehmen";
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

        private void Gv_Klassenstufe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (bt_Bearbeiten.Text == "Zuordnungen bearbeiten")
                {
                    if (gv_Klassenstufe.CurrentRow != null)
                    {
                        bt_back.Enabled = true;
                        gv_Buecher.Enabled = true;
                        gv_Klassenstufe.Enabled = false;
                        bs.Show_AllBuecher(ref gv_Buecher, (gv_Klassenstufe.SelectedRows[0].Index + 1).ToString());
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
    }
}
