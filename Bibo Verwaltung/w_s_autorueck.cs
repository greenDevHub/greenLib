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
    public partial class w_s_autorueck : MetroFramework.Forms.MetroForm
    {
        #region Constructor
        string currentUser;
        public w_s_autorueck(string userName)
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
            inRueckAction = false;
        }
        #endregion

        Rueckgabe autorueckgabe = new Rueckgabe();
        Zustand zustand = new Zustand();
        Kunde kunden = new Kunde();
        //DataTable schulBuecher = new DataTable();
        DataTable selectedBuecher = new DataTable();
        bool inRueckAction;

        #region Fenster-Methoden
        /// <summary>
        /// Exemplar-Code-Parser
        /// </summary>
        static int ParseBuchcode(String data)
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
        /// Setzt die Form auf den Ausgangszustang zurück
        /// </summary>
        private void EndAusgabe()
        {
            inRueckAction = false;
            tb_ExemplarID.Enabled = false;
            a_cb_Modus.SelectedIndex = -1;
            a_cb_Modus.Text = "Modus";
            a_cb_Klasse.SelectedIndex = -1;
            a_cb_Klasse.Text = "Klasse";
            bt_bestaetigen.Text = "Schüler laden";
            tb_ExemplarID.Text = "";
            a_cb_Modus.Enabled = true;
            bt_back.Enabled = false;
            bt_next.Enabled = false;
            gv_suggested.Enabled = false;
            gv_selected.Enabled = false;
            bt_abschließen.Enabled = false;
            gv_suggested.DataSource = null;
            gv_Schueler.DataSource = null;
            gv_selected.DataSource = null;
            autorueckgabe.ClearRueckList();
            selectedBuecher.Rows.Clear();
        }

        /// <summary>
        /// Wählt den vorherigen Schüler in der Schüler-Gridview aus
        /// </summary>
        private void LastSchueler()
        {
            IsComplete(ref gv_Schueler);
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
                autorueckgabe.ClearRueckList();
                selectedBuecher.Rows.Clear();
                gv_selected.Refresh();
            }
        }

        /// <summary>
        /// Prüft ob alle Schüler der aktuellen Auswahl ihnre Schulbücher erfolgreich erhalten haben
        /// </summary>
        private bool IsComplete(ref MetroFramework.Controls.MetroGrid grid)
        {
            bool result = true;
            for (int i = 0; i < grid.Rows.Count; i++)
            {
                if (grid.Rows[i].DefaultCellStyle.BackColor != Color.LimeGreen)
                {
                    result = false;
                    return result;
                }
            }
            return result;
        }

        /// <summary>
        /// Wählt den nächsten Schüler in der Schüler-Gridview aus
        /// </summary>
        private void NextSchueler()
        {
            if (IsComplete(ref gv_Schueler))
            {
                DialogResult dialogResult = MetroMessageBox.Show(this, "Sie sind am Ende der Schülerliste angekommen. Möchten Sie die Lehrbuch-Rückgabe abschließen?", "Warnung",
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
            if (gv_Schueler.CurrentRow.Index < gv_Schueler.Rows.Count - 1)
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
                autorueckgabe.ClearRueckList();
                selectedBuecher.Rows.Clear();
                gv_selected.Refresh();
            }
        }

        /// <summary>
        /// Lädt die Schulbücher für den gewählte Schüler
        /// </summary>
        private void LoadRueckBuecher()
        {
            try
            {
                if (gv_Schueler.CurrentRow != null)
                {
                    DataGridViewRow row = gv_Schueler.Rows[gv_Schueler.CurrentRow.Index];
                    autorueckgabe.KID = row.Cells["kunde_ID"].Value.ToString();
                    autorueckgabe.FillGrid(ref gv_suggested);
                    gv_suggested.ClearSelection();
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Laden der Zuordnungsliste ist ein Fehler aufgetreten.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Gibt den Row-Index der ExemplarID in der Buchausleihliste wieder
        /// </summary>
        public int GetIndexInLeihBuecher()
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
            try
            {
                for (int i = 0; i < selectedBuecher.Rows.Count; i++)
                {
                    if (selectedBuecher.Rows[i]["Titel"].ToString() == new Exemplar().GetTitel(autorueckgabe.RueckListe.Rows[autorueckgabe.GetIndexInRueckliste()][0].ToString()))
                    {
                        i = 0;
                        UnSelectExemplar();
                    }
                }
                autorueckgabe.AddToRueckgabeList();
                DataRow relation;
                string[] exemlarDetails = new string[2];
                exemlarDetails[0] = autorueckgabe.ExemplarID;
                exemlarDetails[1] = new Exemplar().GetTitel(autorueckgabe.RueckListe.Rows[autorueckgabe.GetIndexInRueckliste()][0].ToString());
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
            autorueckgabe.RemoveFromRueckgabeList();
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

        private void A_cb_Modus_SelectedIndexChanged(object sender, EventArgs e)
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

        private void Bt_bestaetigen_Click(object sender, EventArgs e)
        {
            if (!inRueckAction)
            {
                if (a_cb_Modus.SelectedIndex != -1)
                {
                    inRueckAction = true;
                    bt_bestaetigen.Text = "Rückgabe beenden";
                    a_cb_Modus.Enabled = false;
                    a_cb_Klasse.Enabled = false;
                    bt_back.Enabled = true;
                    bt_next.Enabled = true;
                    gv_suggested.Enabled = true;
                    gv_selected.Enabled = true;
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
                    MetroMessageBox.Show(this, "Wählen Sie den Rückgabe-Modus und ggf. eine Klasse aus!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                EndAusgabe();
            }
        }

        private void Bt_back_Click(object sender, EventArgs e)
        {
            LastSchueler();
        }

        private void Bt_next_Click(object sender, EventArgs e)
        {
            NextSchueler();
        }

        private void Bt_abschließen_Click(object sender, EventArgs e)
        {
            if (autorueckgabe.RueckListe.Rows.Count != 0)
            {
                autorueckgabe.KID = gv_Schueler.CurrentRow.Cells["kunde_ID"].Value.ToString();
                kunden = new Kunde(autorueckgabe.KID);
                DialogResult dialogResult = MetroMessageBox.Show(this, autorueckgabe.GetRueckgabeList() + "an: '" + autorueckgabe.TrimText(kunden.Vorname + " " + kunden.Nachname, 30) + "' wirklich zurücknehmen?", "Achtung",
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.OK)
                {
                    DataGridViewRow Kundenrow = gv_Schueler.CurrentRow;
                    try
                    {
                        foreach (DataRow row in autorueckgabe.RueckListe.Rows)
                        {
                            autorueckgabe.Load_Info(row[0].ToString());
                            autorueckgabe.Execute_Rueckgabe(row[0].ToString(), autorueckgabe.KID, row[1].ToString(), zustand.GetZustandsID(row[2].ToString()), row[2].ToString(), autorueckgabe.Leihdatum.ToShortDateString(), DateTime.Now.Date.ToShortDateString());
                        }
                        MetroMessageBox.Show(this, "Die Buchrückgabe wurde erfolgreich abgeschlossen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (IsComplete(ref gv_suggested))
                        {
                            Kundenrow.DefaultCellStyle.BackColor = Color.LimeGreen;
                            Kundenrow.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Die Buchrückgabe konnte nicht abgeschlossen werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        if (IsComplete(ref gv_suggested))
                        {
                            Kundenrow.DefaultCellStyle.BackColor = Color.Red;
                            Kundenrow.DefaultCellStyle.ForeColor = Color.Black;
                        }
                    }
                    NextSchueler();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Es befinden sich keine Bücher in der Rückgabeliste!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Gv_Schueler_CurrentCellChanged(object sender, EventArgs e)
        {
            LoadRueckBuecher();
        }

        private void Tb_ExemplarID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                #region Buchcode parsen
                if (tb_ExemplarID.Text.Length == 8)
                {
                    string seven = tb_ExemplarID.Text.Substring(0, 7);
                    string eight = tb_ExemplarID.Text.Substring(7, 1);
                    if (ParseBuchcode(seven).ToString().Equals(eight))
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
                            autorueckgabe.ExemplarID = buch_exemplar.ExemplarID;
                            if (selectedBuecher.Columns.Count < 2)
                            {
                                selectedBuecher.Columns.Add("exemplarID");
                                selectedBuecher.Columns.Add("Titel");
                            }
                            if (!buch_exemplar.IsSpecificAvailable())
                            {
                                DataGridViewRow Buchrow = new DataGridViewRow();
                                if (GetIndexInLeihBuecher() != -1)
                                {
                                    Buchrow = gv_suggested.Rows[GetIndexInLeihBuecher()];
                                }
                                else
                                {
                                    DialogResult dialogResult = MetroMessageBox.Show(this, "Dieses Buch wurde nicht von diesem Kunden ausgeliehen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                                if (!autorueckgabe.CheckRueckList())
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
                                MetroMessageBox.Show(this, "Dieses Buch wurde nicht verliehen. Es kann nicht zur Buchrückgabeliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void MetroButton1_Click(object sender, EventArgs e)
        {
            //ataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            gv_selected.Columns.Add(zustand.FillDataGridViewComboBox());
            gv_selected.Refresh();
            //DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
            //cmb.HeaderText = "Select Data";
            //cmb.Name = "cmb";
            //cmb.MaxDropDownItems = 4;
            ////zustand.FillCombobox(ref cmb);
            //cmb.Items.Add("True");
            //cmb.Items.Add("False");
            //cmb.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
            //gv_selected.Columns.Add(cmb);

            //var list11 = new List<string>() { "10", "30", "80", "100" };
            //money.DataSource = list11;
            //money.DisplayMember = "";
            //money.HeaderText = "Money";
            //money.DataPropertyName = "Money";

            //gv_selected.DataSource = selectedBuecher;
            //gv_selected.Columns.Add(cbo1);
        }
    }
}
