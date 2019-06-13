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
    public partial class w_s_automatic : MetroFramework.Forms.MetroForm
    {
        #region Constructor
        string currentUser;
        public w_s_automatic(string userName)
        {
            InitializeComponent();
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;

            a_cb_Modus.SelectedIndex = -1;
            a_cb_Modus.Text = "Modus";
            new Klasse().FillCombobox(ref a_cb_Klasse, -1);
            a_cb_Klasse.SelectedIndex = -1;
            a_cb_Klasse.Text = "Klasse";
            bt_bestaetigen.Text = "Schüler laden";
            inAusleihAction = false;
        }
        #endregion

        Ausleihe autoausleihe = new Ausleihe();
        Kunde kunden = new Kunde();
        DataTable schulBuecher = new DataTable();
        DataTable selectedBuecher = new DataTable();
        bool inAusleihAction;

        #region Fenster-Methoden
        /// <summary>
        /// Exemplar-Code-Parser
        /// </summary>
        static int _checksum_ean8(String data)
        {
            // Test string for correct length
            if (data.Length != 7 && data.Length != 8)
                return -1;
            // Test string for being numeric
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 0x30 || data[i] > 0x39)
                    return -1;
            }
            int sum = 0;
            for (int i = 6; i >= 0; i--)
            {
                int digit = data[i] - 0x30;
                if ((i & 0x01) == 1)
                    sum += digit;
                else
                    sum += digit * 3;
            }
            int mod = sum % 10;
            return mod == 0 ? 0 : 10 - mod;
        }

        /// <summary>
        /// Lädt die Schulbücher für den gewählte Schüler
        /// </summary>
        private void LoadSchulBuecher()
        {
            try
            {
                schulBuecher.Rows.Clear();

                if (gv_Schueler.CurrentRow != null)
                {
                    DataGridViewRow row = gv_Schueler.Rows[gv_Schueler.CurrentRow.Index];
                    autoausleihe.FillSuggestGrid(ref gv_suggested, row.Cells["kunde_ID"].Value.ToString());
                    gv_suggested.ClearSelection();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Laden der Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Setzt die Form auf den Ausgangszustang zurück
        /// </summary>
        private void EndAusgabe()
        {
            inAusleihAction = false;
            tb_ExemplarID.Enabled = false;
            a_cb_Modus.SelectedIndex = -1;
            a_cb_Modus.Text = "Modus";
            a_cb_Klasse.SelectedIndex = -1;
            a_cb_Klasse.Text = "Klasse";
            bt_bestaetigen.Text = "Schüler laden";
            tb_ExemplarID.Text = "";
            a_cb_Modus.Enabled = true;
            dp_RueckDatum.Enabled = true;
            bt_back.Enabled = false;
            bt_next.Enabled = false;
            bt_abschließen.Enabled = false;
            gv_suggested.DataSource = null;
            gv_Schueler.DataSource = null;
            gv_selected.DataSource = null;
            autoausleihe.ClearLeihList();
            selectedBuecher.Rows.Clear();
        }

        /// <summary>
        /// Wählt den vorherigen Schüler in der Schüler-Gridview aus
        /// </summary>
        private void LastSchueler()
        {
            if (gv_Schueler.CurrentRow.Index >= 1)
            {
                gv_Schueler.CurrentCell = gv_Schueler.Rows[gv_Schueler.CurrentRow.Index - 1].Cells[1];
                if (gv_Schueler.Rows.Count > 1)
                {
                    bt_next.Enabled = true;
                }
                if (gv_Schueler.CurrentRow.Index == 0)
                {
                    bt_back.Enabled = false;
                }
                tb_ExemplarID.Text = "";
                tb_ExemplarID.Focus();
                autoausleihe.ClearLeihList();
                selectedBuecher.Rows.Clear();
                gv_selected.Refresh();
            }
        }

        /// <summary>
        /// Wählt den nächsten Schüler in der Schüler-Gridview aus
        /// </summary>
        private void NextSchueler()
        {
            if (gv_Schueler.CurrentRow.Index == gv_Schueler.Rows.Count - 1)
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Sie sind am Ende der Schülerliste angekommen. Möchten Sie die Lehrbuch-Ausgabe abschließen?", "Warnung",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dialogResult == DialogResult.OK)
                {
                    EndAusgabe();
                }
                else
                {
                    gv_Schueler.ClearSelection();
                }
            }
            else if (gv_Schueler.CurrentRow.Index < gv_Schueler.Rows.Count - 1)
            {
                if (gv_Schueler.Rows.Count > 1)
                {
                    bt_back.Enabled = true;

                }
                gv_Schueler.CurrentCell = gv_Schueler.Rows[gv_Schueler.CurrentRow.Index + 1].Cells[1];
                if (gv_Schueler.CurrentRow.Index == gv_Schueler.Rows.Count - 1)
                {
                    bt_next.Enabled = false;
                }
                if (gv_Schueler.Rows[gv_Schueler.CurrentRow.Index].DefaultCellStyle.BackColor == Color.LimeGreen || gv_Schueler.Rows[gv_Schueler.CurrentRow.Index].DefaultCellStyle.BackColor == Color.Red)
                {
                    gv_Schueler.ClearSelection();
                }
                tb_ExemplarID.Text = "";
                tb_ExemplarID.Focus();
                autoausleihe.ClearLeihList();
                selectedBuecher.Rows.Clear();
                gv_selected.Refresh();
            }
        }

        /// <summary>
        /// Gibt den Row-Index der ExemplarID in der Buchausleihliste wieder
        /// </summary>
        public int GetIndexInSuggestedBuecher()
        {
            int result = -1;
            for (int i = 0; i <= gv_suggested.Rows.Count - 1; i++)
            {
                if (gv_suggested.Rows[i].Cells["Titel"].Value.ToString() == new Exemplar().GetTitel(tb_ExemplarID.Text))
                {
                    result = i;
                }
            }
            return result;
        }

        /// <summary>
        /// Nimmt ein Exemplar in die Ausleihliste auf
        /// </summary>
        private void SelectExemplar()
        {
            autoausleihe.AddToAusleihList();
            try
            {
                DataRow relation;
                string[] exemlarDetails = new string[2];
                exemlarDetails[0] = autoausleihe.ExemplarID;
                exemlarDetails[1] = new Exemplar().GetTitel(autoausleihe.LeihListe.Rows[autoausleihe.GetIndexInLeihliste()][0].ToString());
                relation = selectedBuecher.NewRow();
                relation.ItemArray = exemlarDetails;
                selectedBuecher.Rows.Add(relation);
            }
            catch { }
        }

        /// <summary>
        /// Entfernt ein Exemplar aus der Ausleihliste
        /// </summary>
        private void UnSelectExemplar()
        {
            autoausleihe.RemoveFromAusleihList();
            try
            {
                for (int i = selectedBuecher.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = selectedBuecher.Rows[i];
                    if (row[0].ToString() == tb_ExemplarID.Text)
                        row.Delete();
                }
                selectedBuecher.AcceptChanges();
            }
            catch { }
        }
        #endregion

        #region Componenten-Aktionen
        private void bt_bestaetigen_Click(object sender, EventArgs e)
        {
            if (!inAusleihAction)
            {
                if (a_cb_Modus.SelectedIndex != -1)
                {
                    inAusleihAction = true;
                    bt_bestaetigen.Text = "Ausgabe abbrechen";
                    a_cb_Modus.Enabled = false;
                    dp_RueckDatum.Enabled = false;
                    a_cb_Klasse.Enabled = false;
                    bt_back.Enabled = true;
                    bt_next.Enabled = true;
                    bt_abschließen.Enabled = true;
                    if (a_cb_Modus.SelectedIndex == 0)
                    {
                        kunden.GetKundenList(ref gv_Schueler, false, new Klasse().GetID(a_cb_Klasse.Text));
                    }
                    else
                    {
                        kunden.GetKundenList(ref gv_Schueler, true, 0);
                    }
                    if (gv_Schueler.Rows.Count != 0)
                    {
                        gv_Schueler.CurrentCell = gv_Schueler.Rows[0].Cells[1];
                        gv_Schueler.Rows[0].Selected = true;
                    }
                    tb_ExemplarID.Enabled = true;
                    tb_ExemplarID.Focus();
                }
                else
                {
                    MetroMessageBox.Show(this, "Wählen Sie den Ausgabe-Modus, ein Rückgabedatum und ggf. eine Klasse aus!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                EndAusgabe();
            }
        }

        private void gv_Schueler_SelectionChanged(object sender, EventArgs e)
        {
            LoadSchulBuecher();
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            LastSchueler();
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            NextSchueler();
        }

        private void bt_abschließen_Click(object sender, EventArgs e)
        {
            autoausleihe.KID = gv_Schueler.CurrentRow.Cells["kunde_ID"].Value.ToString();
            kunden = new Kunde(autoausleihe.KID);
            DialogResult dialogResult = MetroMessageBox.Show(this, autoausleihe.GetAusleihList() + "an: '" + autoausleihe.TrimText(kunden.Vorname + " " + kunden.Nachname, 30) + "' wirklich ausleihen?", "Achtung",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.OK)
            {
                DataGridViewRow Kundenrow = gv_Schueler.CurrentRow;
                try
                {
                    foreach (DataRow row in autoausleihe.LeihListe.Rows)
                    {
                        autoausleihe.Execute_Ausleihe(Convert.ToInt32(row[0].ToString()), DateTime.Now.Date.ToShortDateString(), row[1].ToString(), Convert.ToInt32(kunden.KundenID));
                    }
                    MetroMessageBox.Show(this, "Die Buchausgabe wurde erfolgreich abgeschlossen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Kundenrow.DefaultCellStyle.BackColor = Color.LimeGreen;
                    Kundenrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                catch
                {
                    MetroMessageBox.Show(this, "Die Buchausgabe konnte nicht abgeschlossen werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Kundenrow.DefaultCellStyle.BackColor = Color.Red;
                    Kundenrow.DefaultCellStyle.ForeColor = Color.Black;
                }
                NextSchueler();
            }
        }

        private void tb_ExemplarID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                #region Buchcode parsen
                if (tb_ExemplarID.Text.Length == 8)
                {
                    string seven = tb_ExemplarID.Text.Substring(0, 7);
                    string eight = tb_ExemplarID.Text.Substring(7, 1);
                    if (_checksum_ean8(seven).ToString().Equals(eight))
                    {
                        tb_ExemplarID.Text = int.Parse(seven).ToString();
                    }
                }
                #endregion

                if (tb_ExemplarID.Text != "")
                {
                    try
                    {
                        Exemplar buch_exemplar = new Exemplar(tb_ExemplarID.Text);
                        if (buch_exemplar.IsActivated())
                        {
                            autoausleihe.ExemplarID = buch_exemplar.ExemplarID;
                            if (selectedBuecher.Columns.Count < 2)
                            {
                                selectedBuecher.Columns.Add("exemplarID");
                                selectedBuecher.Columns.Add("Titel");
                            }
                            if (buch_exemplar.IsSpecificAvailable())
                            {
                                DataGridViewRow Buchrow = new DataGridViewRow();
                                if (GetIndexInSuggestedBuecher() != -1)
                                {
                                    Buchrow = gv_suggested.Rows[GetIndexInSuggestedBuecher()];
                                }
                                else
                                {
                                    DialogResult dialogResult = MetroMessageBox.Show(this, "Dieses Buch ist als nicht notwendig eingestuft!", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                if (!autoausleihe.CheckLeihList())
                                {
                                    SelectExemplar();
                                    Buchrow.DefaultCellStyle.BackColor = Color.LimeGreen;
                                    Buchrow.DefaultCellStyle.ForeColor = Color.Black;
                                }
                                else
                                {
                                    UnSelectExemplar();
                                    Buchrow.DefaultCellStyle.BackColor = default;
                                    Buchrow.DefaultCellStyle.ForeColor = default;
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Dieses Buch wurde verliehen. Es kann nicht zur Buchausleihliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            gv_selected.DataSource = selectedBuecher;
                            gv_selected.Columns["exemplarID"].Visible = false;
                            gv_selected.Refresh();
                            gv_selected.ClearSelection();
                            tb_ExemplarID.Focus();
                            tb_ExemplarID.SelectAll();
                        }
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Dieser Buchcode existiert nicht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void a_cb_Modus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a_cb_Modus.SelectedIndex != 0)
            {
                lb_Klasse.Visible = false;
                a_cb_Klasse.Enabled = false;
                a_cb_Klasse.Visible = false;
            }
            else
            {
                lb_Klasse.Visible = true;
                a_cb_Klasse.Enabled = true;
                a_cb_Klasse.Visible = true;
            }
        }

        private void dp_RueckDatum_ValueChanged(object sender, EventArgs e)
        {
            autoausleihe.Rueckgabedatum = dp_RueckDatum.Value;
        }
        #endregion
    }
}