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
        //DataTable selectedBuecher = new DataTable();
        bool inRueckAction;

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
            //selectedBuecher.Rows.Clear();
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
                //selectedBuecher.Rows.Clear();
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
                //selectedBuecher.Rows.Clear();
                gv_selected.Refresh();
            }
        }

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
                            autorueckgabe.Execute_Rueckgabe(row[0].ToString(), autorueckgabe.KID, row[1].ToString(), zustand.GetID(row[2].ToString()), row[2].ToString(), autorueckgabe.Leihdatum.ToShortDateString(), DateTime.Now.Date.ToShortDateString());
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
    }
}
