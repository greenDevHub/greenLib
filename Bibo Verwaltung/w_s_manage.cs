using MetroFramework;
using MetroFramework.Controls;
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
    public partial class w_s_manage : MetroFramework.Forms.MetroForm
    {
        string currentUser;
        string currentModus;
        float originalHeightLabel = 0;
        float originalHeightText = 0;
        bool suchmodus = false;
        
        Fach fach;
        Sprache sprache;
        Genre genre;
        Zustand zustand;
        Autor autor;
        Verlag verlag;

        public w_s_manage(string userName, string modus)
        {
            InitializeComponent();
            Benutzer user = new Benutzer(userName);
            this.currentUser = userName + " (" + user.Rechte + ")";
            this.currentModus = modus;
            if (user.Rechteid.Equals("0"))
            {
                mbt_Import.Enabled = false;
                mtb_Export.Enabled = false;
                mbt_Uebernehmen.Enabled = false;
                gv_manage.ReadOnly = true;
                gv_manage.AllowUserToDeleteRows = false;
            }
            else if (user.Rechteid.Equals("1"))
            {
                mbt_Import.Enabled = true;
                mtb_Export.Enabled = false;
                mbt_Uebernehmen.Enabled = true;
                gv_manage.ReadOnly = false;
                gv_manage.AllowUserToDeleteRows = true;
            }
            else if (user.Rechteid == "2")
            {
                mbt_Import.Enabled = true;
                mtb_Export.Enabled = true;
                mbt_Uebernehmen.Enabled = true;
                gv_manage.ReadOnly = false;
                gv_manage.AllowUserToDeleteRows = true;
            }
            if (currentModus == "Fach")
            {
                fach = new Fach();
                fach.FillGrid(ref gv_manage);
                Text = "Fächer" + " - Angemeldet als: " + userName;
            }
            else if (currentModus == "Sprache")
            {
                Text = "Sprachen" + " - Angemeldet als: " + userName;
                sprache = new Sprache();
                sprache.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Autor")
            {
                Text = "Autoren" + " - Angemeldet als: " + userName;
                autor = new Autor();
                autor.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Genre")
            {
                Text = "Genres" + " - Angemeldet als: " + userName;
                genre = new Genre();
                genre.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Zustand")
            {
                Text = "Buchzustände" + " - Angemeldet als: " + userName;
                zustand = new Zustand();
                zustand.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Verlag")
            {
                Text = "Verlage" + " - Angemeldet als: " + userName;
                verlag = new Verlag();
                verlag.FillGrid(ref gv_manage);
            }
            originalHeightLabel = tLP_Faecher.RowStyles[0].Height;
            originalHeightText = tLP_Faecher.RowStyles[1].Height;
            tLP_Faecher.RowStyles[0].Height = 0;
            tLP_Faecher.RowStyles[1].Height = 0;
        }

        /// <summary>
        /// Lädt Daten in das aktuelle DataGridView-Objekt
        /// </summary>
        private void LoadContent()
        {
            if (currentModus == "Fach")
            {
                fach.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Sprache")
            {
                sprache.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Autor")
            {
                autor.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Genre")
            {
                genre.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Zustand")
            {
                zustand.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Verlag")
            {
                verlag.FillGrid(ref gv_manage);
            }
        }

        /// <summary>
        /// Speichert das aktuelle DataGridView-Objekt in die Datenbank
        /// </summary>
        private void SaveContent()
        {
            if (currentModus == "Fach")
            {
                fach.SaveGrid(ref gv_manage);
            }
            else if (currentModus == "Sprache")
            {
                sprache.SaveGrid(ref gv_manage);
            }
            else if (currentModus == "Autor")
            {
                autor.SaveGrid();
            }
            else if (currentModus == "Genre")
            {
                genre.SaveGrid(ref gv_manage);
            }
            else if (currentModus == "Zustand")
            {
                zustand.SaveGrid(ref gv_manage);
            }
            else if (currentModus == "Verlag")
            {
                verlag.SaveGrid(ref gv_manage);
            }
        }

        /// <summary>
        /// Prüft das aktuelle DataGridView-Ojekt auf Veränderungen gegenüber des DataSets
        /// </summary>
        private bool ChangesInGrid()
        {
            bool result = false;
            if (currentModus == "Fach")
            {
                result = fach.GetChangesGrid(ref gv_manage);
            }
            else if (currentModus == "Sprache")
            {
                result = sprache.GetChangesGrid(ref gv_manage);
            }
            else if (currentModus == "Autor")
            {
                result = autor.GetChangesGrid(ref gv_manage);
            }
            else if (currentModus == "Genre") 
            {
                result = genre.GetChangesGrid(ref gv_manage);
            }
            else if (currentModus == "Zustand")
            {
                result = zustand.GetChangesGrid(ref gv_manage);
            }
            else if (currentModus == "Verlag")
            {
                result = verlag.GetChangesGrid(ref gv_manage);
            }
            return result;
        }

        private void Mbt_Suchen_Click(object sender, EventArgs e)
        {
            if (suchmodus == false)
            {
                lb_Suche.Visible = true;
                suchmodus = true;
                mbt_Suchen.Text = "Suchen AUS";
                tLP_Faecher.RowStyles[0].Height = originalHeightLabel;
                tLP_Faecher.RowStyles[1].Height = originalHeightText;
                tb_Suchen.Visible = true;
                tb_Suchen.Enabled = true;
                tb_Suchen.Focus();
            }
            else
            {
                lb_Suche.Visible = false;
                suchmodus = false;
                mbt_Suchen.Text = "Suchen AN";
                tb_Suchen.Visible = false;
                tb_Suchen.Enabled = false;
                tb_Suchen.Text = "";
                tLP_Faecher.RowStyles[0].Height = 0;
                tLP_Faecher.RowStyles[1].Height = 0;
            }
        }

        private void Mbt_Import_Click(object sender, EventArgs e)
        {
            Form Import = new w_s_schuelerimport("t_s_faecher", true, currentUser);
            Import.ShowDialog(this);
            LoadContent();
        }

        private void Mtb_Export_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelExport export = new ExcelExport();
                export.ExportAsCSV(gv_manage);                
                MetroMessageBox.Show(this, "Export erfolgreich abgeschlossen", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Exportvorgang ist ein Fehler aufgetreten!", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void W_s_manage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ChangesInGrid() == true)
            {
                gv_manage.EndEdit();
                DialogResult dr = MetroMessageBox.Show(this, "Sollen die Änderungen gespeichert werden?", "Warnung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    try
                    {
                        mbt_Uebernehmen.Focus();
                        SaveContent();
                    }
                    catch
                    {
                        MetroMessageBox.Show(this, "Die Änderungen konnten nicht gespeichert werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }

        private void Tb_Suchen_TextChanged(object sender, EventArgs e)
        {
            if (currentModus == "Fach")
            {
                (gv_manage.DataSource as DataTable).DefaultView.RowFilter = string.Format("Kürzel LIKE '{0}%' OR Langbezeichnung LIKE '{1}%'", tb_Suchen.Text, tb_Suchen.Text);
            }
            else if (currentModus == "Sprache")
            {
                (gv_manage.DataSource as DataTable).DefaultView.RowFilter = string.Format("sprach_name LIKE '{0}%'", tb_Suchen.Text);
            }
            else if (currentModus == "Autor")
            {
                (gv_manage.DataSource as DataTable).DefaultView.RowFilter = string.Format("au_autor LIKE '{0}%'", tb_Suchen.Text);
            }
            else if (currentModus == "Genre")
            {
                (gv_manage.DataSource as DataTable).DefaultView.RowFilter = string.Format("ger_name LIKE '{0}%'", tb_Suchen.Text);
            }
            else if (currentModus == "Zustand")
            {
                (gv_manage.DataSource as DataTable).DefaultView.RowFilter = string.Format("zu_zustand LIKE '{0}%'", tb_Suchen.Text);
            }
            else if (currentModus == "Verlag")
            {
                (gv_manage.DataSource as DataTable).DefaultView.RowFilter = string.Format("ver_name LIKE '{0}%'", tb_Suchen.Text);
            }
        }

        private void Gv_manage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                SendKeys.Send("{DELETE}");
            }
        }
    }
}
