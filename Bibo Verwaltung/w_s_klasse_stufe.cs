﻿using MetroFramework;
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
    public partial class w_s_klasse_stufe : MetroFramework.Forms.MetroForm
    {
        Klassenstufe kl_st = new Klassenstufe();
        DataTable klassenListe = new DataTable();
        bool aenderungungen = false;
        string currentUser;

        #region Constructor
        public w_s_klasse_stufe(string userName)
        {
            InitializeComponent();
            Benutzer user = new Benutzer(userName);
            this.currentUser = userName;
            if (user.Rechteid.Equals("0"))
            {
                bt_Bearbeiten.Enabled = false;
            }
            else if (user.Rechteid == "1")
            {
                bt_Bearbeiten.Enabled = true;
            }
            else if (user.Rechteid == "2")
            {
                bt_Bearbeiten.Enabled = true;
                mbt_ImEx.Enabled = true;
            }
            IniKlassenstufen();
        }
        #endregion

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
        private void LoadKlassen()
        {
            try
            {
                klassenListe.Rows.Clear();
                if (gv_Klassenstufe.CurrentRow != null)
                {
                    kl_st.Show_StufenKlassen(ref gv_Klassen, (gv_Klassenstufe.CurrentRow.Index + 1).ToString());
                }
                else
                {
                    kl_st.Show_StufenKlassen(ref gv_Klassen, "1");
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
        private void FillKlassenList()
        {
            try
            {
                klassenListe.Rows.Clear();
                for (int i = 0; i <= gv_Klassen.Rows.Count - 1; i++)
                {
                    DataGridViewRow row = gv_Klassen.Rows[i];
                    string klasse = row.Cells["Klasse"].Value.ToString();

                    if (klasse.Contains("*"))
                    {
                        DataRow relation;
                        string[] klasseDetails = new string[1];

                        klasseDetails[0] = row.Cells["KlassenID"].Value.ToString();
                        row.Cells["Klasse"].Value.ToString().Replace("*", "");

                        if (klassenListe.Columns.Count != 1)
                        {
                            klassenListe.Columns.Add();
                        }
                        relation = klassenListe.NewRow();
                        relation.ItemArray = klasseDetails;
                        klassenListe.Rows.Add(relation);
                    }
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Anzeigen der bisher zugeordneten Klassen ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Fügt einen Eintrag zur Zuornungs-Liste hinzu
        /// </summary>
        private void AddToKlassenList()
        {
            try
            {
                DataGridViewRow row = gv_Klassen.CurrentRow;
                DataRow relation;
                string[] klasseDetails = new string[1];

                klasseDetails[0] = row.Cells["KlassenID"].Value.ToString();

                if (klassenListe.Columns.Count != 1)
                {
                    klassenListe.Columns.Add();
                }
                relation = klassenListe.NewRow();
                relation.ItemArray = klasseDetails;
                klassenListe.Rows.Add(relation);

                row.Cells["Klasse"].Value = "*" + row.Cells["Klasse"].Value.ToString();
                row.DefaultCellStyle.BackColor = Color.Yellow;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Hinzufügen dieser Klasse zur Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Entfernt einen Eintrag aus der Zuornungs-Liste
        /// </summary>
        private void RemoveFromKlassenList()
        {
            try
            {
                DataGridViewRow gridrow = gv_Klassen.CurrentRow;
                for (int i = klassenListe.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = klassenListe.Rows[i];
                    if (row[0].ToString() == gridrow.Cells["KlassenID"].Value.ToString())
                    {
                        row.Delete();
                    }
                }
                klassenListe.AcceptChanges();

                gridrow.Cells["Klasse"].Value = gridrow.Cells["Klasse"].Value.ToString().Substring(1);
                gridrow.DefaultCellStyle.BackColor = default;
                gridrow.DefaultCellStyle.ForeColor = default;
            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Entfernen dieser Klasse aus der Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Speichert die Zuordnungsdatendaten einer Klassenstufe mit vorhandenen Büchern in der Datenbank 
        /// </summary>
        private void SaveZuordnungen()
        {
            if (gv_Klassenstufe.CurrentRow != null)
            {
                if (aenderungungen == true)
                {
                    DialogResult dr = MetroMessageBox.Show(this, "Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            kl_st.Save_Zuordnung(klassenListe, (gv_Klassenstufe.CurrentRow.Index + 1).ToString());
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
                    gv_Klassen.Enabled = true;
                    gv_Klassenstufe.Enabled = false;
                    kl_st.Show_AllKlassen(ref gv_Klassen, (gv_Klassenstufe.CurrentRow.Index + 1).ToString());
                    FillKlassenList();
                    bt_Bearbeiten.Text = "Übernehmen";
                }
            }
            else
            {
                bt_back.Enabled = false;
                gv_Klassen.Enabled = false;
                gv_Klassenstufe.Enabled = true;
                SaveZuordnungen();
                bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
                LoadKlassen();
            }
        }

        private void gv_Klassenstufe_SelectionChanged(object sender, EventArgs e)
        {
            LoadKlassen();
        }

        private void gv_Klassen_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = gv_Klassen.CurrentRow;
            string klasse = row.Cells["Klasse"].Value.ToString();
            if (!klasse.Contains("*"))
            {
                AddToKlassenList();
                aenderungungen = true;
            }
            else
            {
                RemoveFromKlassenList();
                aenderungungen = true;
            }
        }

        private void w_s_klassenstufe_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveZuordnungen();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            bt_back.Enabled = false;
            gv_Klassen.Enabled = false;
            gv_Klassenstufe.Enabled = true;
            bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
            LoadKlassen();
        }

        private void bt_Abbrechen_Click(object sender, EventArgs e)
        {
            Close();
        }

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
                    string[] source = { "t_s_klasse_stufe" };
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
    }
}
