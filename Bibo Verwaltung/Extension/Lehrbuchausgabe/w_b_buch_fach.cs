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
    public partial class w_s_buch_fach : MetroFramework.Forms.MetroForm
    {
        BuchFach bf = new BuchFach();
        Fach faecher = new Fach();
        private DataTable buecherListe = new DataTable();
        private bool aenderungungen = false;
        string currentUser;

        public w_s_buch_fach(string userName)
        {
            InitializeComponent();
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;
            faecher.FillGrid(ref gv_Faecher);


            //bf.FillGrid(ref gv_bf);
            //bf.Fach.FillCombobox(ref cb_fach, 0);

            //foreach (var pb in tLP_1.Controls.OfType<ComboBox>())
            //{
            //    ComboBoxes.Add(pb);
            //}
            //foreach(var bt in tLP_1.Controls.OfType<Button>())
            //{
            //    Buttons.Add(bt);
            //}
            //for (int i = 1; i < 8;)
            //{
            //    ComboBoxes[i].Visible = false;
            //    Buttons[i].Visible = false;
            //    i++;
            //}
            //ctr1 = tLP_1.GetControlFromPosition(0, 8);
            //tLP_1.SetRow(ctr1, 1);
            //FillComboboxes(false);
            //Clear();


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
                    bf.Show_FachBuecher(ref gv_Buecher, gv_Faecher.Rows[gv_Faecher.CurrentRow.Index].Cells["ID"].Value.ToString());
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
            if (gv_Faecher.CurrentRow != null)
            {
                if (aenderungungen == true)
                {
                    DialogResult dr = MetroMessageBox.Show(this,"Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        try
                        {
                            bf.Save_Zuordnung(buecherListe, gv_Faecher.Rows[gv_Faecher.CurrentRow.Index].Cells["ID"].Value.ToString());
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
                    bf.Show_AllBuecher(ref gv_Buecher, gv_Faecher.Rows[gv_Faecher.CurrentRow.Index].Cells["ID"].Value.ToString());
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
        #endregion


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
        }
    }
}
