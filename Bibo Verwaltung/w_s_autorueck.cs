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
    public partial class w_s_autorueck : MetroFramework.Forms.MetroForm
    {
        #region Constructor
        string currentUser;
        Color fc = Color.Black;
        Color bc = Color.White;
        public w_s_autorueck(string userName, MetroStyleManager msm)
        {
            InitializeComponent();
            msm_autorueck = msm;
            this.StyleManager = msm;
            this.StyleManager.Style = MetroColorStyle.Yellow;
            if (this.StyleManager.Theme == MetroThemeStyle.Dark)
            {
                fc = Color.White;
                bc = System.Drawing.ColorTranslator.FromHtml("#111111");
                a_cb_Klasse.ForeColor = fc;
                a_cb_Klasse.BackColor = bc;
                a_cb_Modus.ForeColor = fc;
                a_cb_Modus.BackColor = bc;
            }
            Benutzer user = new Benutzer(userName);
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName + " (" + user.Rechte + ")";

            a_cb_Modus.SelectedIndex = 0;
            bt_bestaetigen.Text = "Schüler laden";
            inRueckAction = false;
            bool b = !user.Rechteid.Equals("0");
            a_cb_Modus.TabStop = b;
            p_modus.Visible = !b;
            a_cb_Klasse.TabStop = b;
            p_klasse.Visible = !b;
            bt_bestaetigen.Enabled = b;
        }
        #endregion

        Rueckgabe autorueckgabe = new Rueckgabe();
        Zustand zustand = new Zustand();
        Kunde kunden = new Kunde();
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

        private void MarkSchueler()
        {
            for (int i = 0; i < gv_Schueler.RowCount; i++)
            {
                DataGridViewRow Kundenrow = gv_Schueler.Rows[i];
                kunden.KundenID = gv_Schueler.Rows[i].Cells["kunde_ID"].Value.ToString();
                if (kunden.Ausgeliehen())
                {
                    Kundenrow.DefaultCellStyle.SelectionBackColor = default;
                    Kundenrow.DefaultCellStyle.SelectionForeColor = default;
                    Kundenrow.DefaultCellStyle.BackColor = default;
                    Kundenrow.DefaultCellStyle.ForeColor = default;
                }
                else
                {
                    Kundenrow.DefaultCellStyle.SelectionBackColor = Color.GreenYellow;
                    Kundenrow.DefaultCellStyle.SelectionForeColor = Color.Black;
                    Kundenrow.DefaultCellStyle.BackColor = Color.LimeGreen;
                    Kundenrow.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        /// <summary>
        /// Setzt die Form auf den Ausgangszustang zurück
        /// </summary>
        private void EndAusgabe()
        {
            inRueckAction = false;
            tb_ExemplarID.Enabled = false;
            a_cb_Modus.SelectedIndex = 0;
            bt_bestaetigen.Text = "Schüler laden";
            tb_ExemplarID.Text = "";
            a_cb_Modus.TabStop = true;
            p_modus.Visible = false;
            a_cb_Klasse.TabStop = true;
            p_klasse.Visible = false;
            bt_back.Enabled = false;
            bt_next.Enabled = false;
            gv_suggested.Enabled = false;
            gv_selected.Enabled = false;
            bt_abschließen.Enabled = false;
            gv_suggested.DataSource = null;
            gv_Schueler.DataSource = null;
            gv_selected.DataSource = null;
            gv_selected.Columns.Clear();
            autorueckgabe.ClearRueckList();
            selectedBuecher.Rows.Clear();
        }

        /// <summary>
        /// Wählt den vorherigen Schüler in der Schüler-Gridview aus
        /// </summary>
        private void LastSchueler()
        {
            try
            {
                if (inRueckAction)
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
                        //if (gv_Schueler.Rows[gv_Schueler.CurrentRow.Index].DefaultCellStyle.BackColor == Color.LimeGreen || gv_Schueler.Rows[gv_Schueler.CurrentRow.Index].DefaultCellStyle.BackColor == Color.Red)
                        //{
                        //    gv_Schueler.ClearSelection();
                        //}
                        tb_ExemplarID.Text = "";
                        tb_ExemplarID.Focus();
                        autorueckgabe.ClearRueckList();
                        selectedBuecher.Rows.Clear();
                        gv_selected.Refresh();
                    }
                }
            }
            catch { }
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
        /// Prüft die aktuelle Auswahl auf Vorhandensein einiger Einträge (Anhand der BackColor)
        /// </summary>
        private bool IsNotEmpty(ref MetroFramework.Controls.MetroGrid grid)
        {
            if (grid.RowCount != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Wählt den nächsten Schüler in der Schüler-Gridview aus
        /// </summary>
        private void NextSchueler()
        {
            try
            {
                if (IsComplete(ref gv_Schueler) || gv_Schueler.CurrentCell.RowIndex == gv_Schueler.RowCount - 1)
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
                if (inRueckAction)
                {
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
                        //if (gv_Schueler.Rows[gv_Schueler.CurrentRow.Index].DefaultCellStyle.BackColor == Color.LimeGreen || gv_Schueler.Rows[gv_Schueler.CurrentRow.Index].DefaultCellStyle.BackColor == Color.Red)
                        //{
                        //    gv_Schueler.ClearSelection();
                        //}
                        tb_ExemplarID.Text = "";
                        tb_ExemplarID.Focus();
                        autorueckgabe.ClearRueckList();
                        selectedBuecher.Rows.Clear();
                    }
                }
                gv_selected.Refresh();
            }
            catch { }
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
                if (gv_suggested.Rows[i].Cells["ID"].Value.ToString() == tb_ExemplarID.Text)
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
                autorueckgabe.AddToRueckgabeList();
                for (int i = 0; i < selectedBuecher.Rows.Count; i++)
                {
                    if (selectedBuecher.Rows[i]["ID"].ToString() == autorueckgabe.RueckListe.Rows[autorueckgabe.GetIndexInRueckliste()][0].ToString())
                    {
                        i = 0;
                        UnSelectExemplar();
                    }
                }
                DataRow relation;
                string[] exemlarDetails = new string[3];
                exemlarDetails[0] = autorueckgabe.ExemplarID;
                exemlarDetails[1] = autorueckgabe.RueckListe.Rows[autorueckgabe.GetIndexInRueckliste()][1].ToString();
                exemlarDetails[2] = new Exemplar().GetTitel(autorueckgabe.RueckListe.Rows[autorueckgabe.GetIndexInRueckliste()][0].ToString());
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

        /// <summary>
        /// Prüft ob bei allen Exemplaren in der DataGridView der IstZustands-ComboBox-Wert gestetz wurde (False bei Default-Wert ausgewählt)
        /// </summary>
        private bool CheckIstZustaende()
        {
            bool result = true;
            for (int i = 0; i < selectedBuecher.Rows.Count; i++)
            {
                DataGridViewRow row = gv_selected.Rows[i];
                string istzustand = row.Cells["cbzustand"].Value.ToString();
                if ((istzustand == null) || (istzustand == "0"))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        #endregion

        #region Componenten-Aktionen
        private void A_cb_Modus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (a_cb_Modus.SelectedIndex == 0)
            {
                a_cb_Klasse.DataSource = null;
                a_cb_Klasse.Sorted = true;
                lb_Klasse.Text = "Klasse:";
                lb_Klasse.Visible = true;
                new Klasse().FillCombobox(ref a_cb_Klasse, 1);
                a_cb_Klasse.Visible = true;
                a_cb_Klasse.TabStop = true;
                p_klasse.Visible = false;
            }
            else
            {
                a_cb_Klasse.Sorted = false;
                lb_Klasse.Text = "Stufe:";
                lb_Klasse.Visible = true;
                DataTable stufen = new DataTable();
                stufen.Columns.Add("Index");
                stufen.Columns.Add("Klassenstufe");
                for (int i = 1; i <= 13; i++)
                {
                    stufen.Rows.Add();
                    stufen.Rows[i - 1][0] = i.ToString();
                    stufen.Rows[i - 1][1] = "Klassenstufe " + i.ToString();
                }
                a_cb_Klasse.DataSource = stufen;
                a_cb_Klasse.ValueMember = "Index";
                a_cb_Klasse.DisplayMember = "Klassenstufe";
                a_cb_Klasse.SelectedItem = 0;
                a_cb_Klasse.Visible = true;
                a_cb_Klasse.TabStop = true;
                p_klasse.Visible = false;
            }
        }

        private void Bt_bestaetigen_Click(object sender, EventArgs e)
        {
            if (!inRueckAction)
            {
                if (a_cb_Modus.SelectedIndex != -1 && a_cb_Klasse.SelectedIndex != -1)
                {
                    inRueckAction = true;
                    bt_bestaetigen.Text = "Rückgabe beenden";
                    a_cb_Modus.TabStop = false;
                    p_modus.Visible = true;
                    a_cb_Klasse.TabStop = false;
                    p_klasse.Visible = true;
                    bt_back.Enabled = true;
                    bt_next.Enabled = true;
                    //gv_suggested.Enabled = true;
                    gv_selected.Enabled = true;
                    bt_abschließen.Enabled = true;
                    if (a_cb_Modus.SelectedIndex == 0)
                    {
                        kunden.GetKundenList(ref gv_Schueler, false, new Klasse().GetID(a_cb_Klasse.Text));
                    }
                    else
                    {
                        kunden.GetKundenList(ref gv_Schueler, true, Convert.ToInt32(a_cb_Klasse.Text.Substring(13)));
                    }
                    if (gv_Schueler.Rows.Count != 0)
                    {
                        gv_Schueler.CurrentCell = gv_Schueler.Rows[0].Cells[1];
                        gv_Schueler.Rows[0].Selected = true;
                        MarkSchueler();
                        tb_ExemplarID.Enabled = true;
                        tb_ExemplarID.Focus();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Es gibt keine Schüler in dieser Klasse bzw. Klassenstufe. Die Rückgabe wird beendet!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EndAusgabe();
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Wählen Sie den Rückgabe-Modus und eine Klasse bzw. eine Klassenstufe aus!", "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                                MessageBoxButtons.OKCancel, MessageBoxIcon.Question,211 + autorueckgabe.RueckListe.Rows.Count * 17);
                if (dialogResult == DialogResult.OK)
                {
                    DataGridViewRow Kundenrow = gv_Schueler.CurrentRow;
                    if (CheckIstZustaende())
                    {
                        try
                        {
                            for (int i = 0; i < selectedBuecher.Rows.Count; i++)
                            {
                                autorueckgabe.ExemplarID = selectedBuecher.Rows[i]["ID"].ToString();
                                autorueckgabe.RueckListe.Rows[autorueckgabe.GetIndexInRueckliste()][2] = gv_selected.Rows[i].Cells["cbzustand"].Value.ToString();
                            }
                            foreach (DataRow row in autorueckgabe.RueckListe.Rows)
                            {
                                autorueckgabe.Load_Info(row[0].ToString());
                                autorueckgabe.Execute_Rueckgabe(row[0].ToString(), autorueckgabe.KID, row[1].ToString(), row[2].ToString(), zustand.GetZustandsName(row[2].ToString()), autorueckgabe.Leihdatum.ToShortDateString(), DateTime.Now.Date.ToShortDateString()); //Später einbauen (das ist der fertig-funktionsfähige Befehl)
                            }
                            MetroMessageBox.Show(this, "Die Buchrückgabe wurde erfolgreich abgeschlossen!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (IsComplete(ref gv_suggested))
                            {
                                Kundenrow.DefaultCellStyle.BackColor = Color.LimeGreen;
                                Kundenrow.DefaultCellStyle.ForeColor = Color.Black;
                            }
                            else if (IsNotEmpty(ref gv_suggested))
                            {
                                Kundenrow.DefaultCellStyle.SelectionBackColor = Color.LightGray;
                                Kundenrow.DefaultCellStyle.SelectionForeColor = Color.Black;
                                Kundenrow.DefaultCellStyle.BackColor = Color.Gray;
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
                    else
                    {
                        MetroMessageBox.Show(this, "Prüfen Sie die Auswahl in der 'Ist-Zustand'-Spalte!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Es befinden sich keine Bücher in der Rückgabeliste!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_ExemplarID.Focus();
                tb_ExemplarID.SelectAll();
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
                            lb_selected.Text = "ausgewählte Bücher:";
                            autorueckgabe.ExemplarID = buch_exemplar.ExemplarID;
                            autorueckgabe.ZustandStart = buch_exemplar.GetZustandLang(autorueckgabe.ExemplarID);
                            if (selectedBuecher.Columns.Count < 2)
                            {
                                selectedBuecher.Columns.Add("ID");
                                selectedBuecher.Columns.Add("Vorheriger Zustand");
                                selectedBuecher.Columns.Add("Titel");
                            }
                            if (!buch_exemplar.IsSpecificAvailable())
                            {
                                DataGridViewRow Buchrow = new DataGridViewRow();
                                if (GetIndexInLeihBuecher() != -1)
                                {
                                    Buchrow = gv_suggested.Rows[GetIndexInLeihBuecher()];
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
                                    DialogResult dialogResult = MetroMessageBox.Show(this, "Dieses Buch wurde nicht von diesem Kunden ausgeliehen!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "Dieses Buch wurde nicht verliehen. Es kann nicht zur Buchrückgabeliste hinzugefügt werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            gv_selected.DataSource = selectedBuecher;
                            gv_selected.Refresh();
                            if (gv_selected.Columns.Contains("cbzustand"))
                            {
                                gv_selected.Columns.Remove("cbzustand");
                            }
                            DataGridViewComboBoxColumn combobox = new DataGridViewComboBoxColumn();
                            combobox = zustand.FillDataGridViewComboBox();
                            gv_selected.Columns.Add(combobox);
                            gv_selected.Columns["cbzustand"].DisplayIndex = 2;
                            gv_selected.Columns["cbzustand"].HeaderText = "aktueller Ist-Zustand";
                            for (int i = 0; i < gv_selected.RowCount; i++)
                            {
                                DataGridViewComboBoxCell comboValue = (DataGridViewComboBoxCell)(gv_selected.Rows[i].Cells["cbzustand"]);
                                comboValue.Value = 0;
                                string valueMember = gv_selected.Rows[i].Cells[1].Value.ToString();
                                valueMember = zustand.GetZustandsID(valueMember);
                                gv_selected.Rows[i].Cells[3].Value = int.Parse(valueMember);

                            }
                            gv_selected.ClearSelection();
                            tb_ExemplarID.Focus();
                            tb_ExemplarID.SelectAll();
                            combobox.DisplayStyle = DataGridViewComboBoxDisplayStyle.ComboBox;
                        }
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Dieser Buchcode existiert nicht.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        #endregion

        private void MetroToolTip1_Popup(object sender, PopupEventArgs e)
        {
            e.ToolTipSize = new Size(e.ToolTipSize.Width + 32, e.ToolTipSize.Height);
        }
    }
}
