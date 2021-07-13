using Bibo_Verwaltung.Helper;
using MetroFramework;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormAttribute : MetroFramework.Forms.MetroForm
    {
        string currentModus;
        float originalHeightLabel = 0;
        float originalHeightText = 0;
        bool suchmodus = false;

        SubjectHelper subjectHelper;
        LanguageHelper languageHelper;
        GenreHelper genreHelper;
        ConditionHelper conditionHelper;
        AuthorHelper authorHelper;
        PublisherHelper publisherHelper;
        SchoolClassHelper schoolClassHelper;
        public FormAttribute(string modus)
        {
            InitializeComponent();
            LoadTheme();

            this.currentModus = modus;

            if (currentModus == "Fach")
            {
                this.StyleManager.Style = MetroColorStyle.Teal;
                subjectHelper = new SubjectHelper();
                subjectHelper.FillGrid(ref gv_manage);
                Text = "Fächer" + AuthInfo.FormInfo();
            }
            else if (currentModus == "Sprache")
            {
                this.StyleManager.Style = MetroColorStyle.Blue;

                Text = "Sprachen" + AuthInfo.FormInfo();
                languageHelper = new LanguageHelper();
                languageHelper.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Autor")
            {
                this.StyleManager.Style = MetroColorStyle.Blue;

                Text = "Autoren" + AuthInfo.FormInfo();
                authorHelper = new AuthorHelper();
                authorHelper.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Genre")
            {
                this.StyleManager.Style = MetroColorStyle.Blue;

                Text = "Genres" + AuthInfo.FormInfo();
                genreHelper = new GenreHelper();
                genreHelper.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Zustand")
            {
                this.StyleManager.Style = MetroColorStyle.Blue;

                Text = "Buchzustände" + AuthInfo.FormInfo();
                conditionHelper = new ConditionHelper();
                conditionHelper.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Verlag")
            {
                this.StyleManager.Style = MetroColorStyle.Blue;
                Text = "Verlage" + AuthInfo.FormInfo();
                publisherHelper = new PublisherHelper();
                publisherHelper.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Klasse")
            {
                this.StyleManager.Style = MetroColorStyle.Teal;
                Text = "Klasse" + AuthInfo.FormInfo();
                schoolClassHelper = new SchoolClassHelper();
                schoolClassHelper.FillGrid(ref gv_manage);
            }
            originalHeightLabel = tLP_Faecher.RowStyles[0].Height;
            originalHeightText = tLP_Faecher.RowStyles[1].Height;
            tLP_Faecher.RowStyles[0].Height = 0;
            tLP_Faecher.RowStyles[1].Height = 0;
        }

        private void LoadTheme()
        {
            this.StyleManager = styleManagerAttribute;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.SettingsStyle;
        }
        private void SetPermissions()
        {
            if (AuthInfo.CurrentUser.PermissionId == 0)
            {
                mbt_Import.Enabled = false;
                mtb_Export.Enabled = false;
                mbt_Uebernehmen.Enabled = false;
                gv_manage.ReadOnly = true;
                gv_manage.AllowUserToDeleteRows = false;
            }
            else if (AuthInfo.CurrentUser.PermissionId == 1)
            {
                mbt_Import.Enabled = true;
                mtb_Export.Enabled = false;
                mbt_Uebernehmen.Enabled = true;
                gv_manage.ReadOnly = false;
                gv_manage.AllowUserToDeleteRows = true;
            }
            else if (AuthInfo.CurrentUser.PermissionId == 2)
            {
                mbt_Import.Enabled = true;
                mtb_Export.Enabled = true;
                mbt_Uebernehmen.Enabled = true;
                gv_manage.ReadOnly = false;
                gv_manage.AllowUserToDeleteRows = true;
            }
        }

        /// <summary>
        /// Lädt Daten in das aktuelle DataGridView-Objekt
        /// </summary>
        private void LoadContent()
        {
            if (currentModus == "Fach")
            {
                subjectHelper.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Sprache")
            {
                languageHelper.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Autor")
            {
                authorHelper.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Genre")
            {
                genreHelper.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Zustand")
            {
                conditionHelper.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Verlag")
            {
                publisherHelper.FillGrid(ref gv_manage);
            }
            else if (currentModus == "Klasse")
            {
                schoolClassHelper.FillGrid(ref gv_manage);
            }
        }

        /// <summary>
        /// Speichert das aktuelle DataGridView-Objekt in die Datenbank
        /// </summary>
        private void SaveContent()
        {
            if (currentModus == "Fach")
            {
                subjectHelper.SaveGridChangesToDatabase(ref gv_manage);
            }
            else if (currentModus == "Sprache")
            {
                languageHelper.SaveChangesToDatabase(ref gv_manage);
            }
            else if (currentModus == "Autor")
            {
                authorHelper.SaveChangesToDatabase(ref gv_manage);
            }
            else if (currentModus == "Genre")
            {
                genreHelper.SaveChangesToDatabase(ref gv_manage);
            }
            else if (currentModus == "Zustand")
            {
                conditionHelper.SaveChangesToDatabase(ref gv_manage);
            }
            else if (currentModus == "Verlag")
            {
                publisherHelper.SaveChangesToDatabase(ref gv_manage);
            }
            else if (currentModus == "Klasse")
            {
                schoolClassHelper.SaveChangesToDatabase(ref gv_manage);
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
                result = subjectHelper.GridViewHasChanges(ref gv_manage);
            }
            else if (currentModus == "Sprache")
            {
                result = languageHelper.GridViewHasChanges(ref gv_manage);
            }
            else if (currentModus == "Autor")
            {
                result = authorHelper.GridViewHasChanges(ref gv_manage);
            }
            else if (currentModus == "Genre")
            {
                result = genreHelper.GridViewHasChanges(ref gv_manage);
            }
            else if (currentModus == "Zustand")
            {
                result = conditionHelper.GridViewHasChanges(ref gv_manage);
            }
            else if (currentModus == "Verlag")
            {
                result = publisherHelper.GridViewHasChanges(ref gv_manage);
            }
            else if (currentModus == "Klasse")
            {
                result = schoolClassHelper.GridViewHasChanges(ref gv_manage);
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
            //Form import;
            if (currentModus == "Fach")
            {
                FormStudentSubjectImport Import = new FormStudentSubjectImport("t_s_faecher", true);
                Import.ShowDialog(this);
                Import.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "Diese Funktion ist in der aktuellen Version noch nicht verfügbar.", "Noch nicht verfügbar.", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Mtb_Export_Click(object sender, EventArgs e)
        {
            try
            {
                ExcelExport export = new ExcelExport();
                export.ExportDataGridViewAsCSV(gv_manage);
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
                    catch (Exception ex)
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
            else if (currentModus == "Klasse")
            {
                (gv_manage.DataSource as DataTable).DefaultView.RowFilter = string.Format("Klasse LIKE '{0}%'", tb_Suchen.Text);
            }
        }

        private void Gv_manage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
            {
                SendKeys.Send("{DELETE}");
            }
        }

        private void Bt_sort_on_off_Click(object sender, EventArgs e)
        {
            if (bt_sort_on_off.Text == "unsortiert")
            {
                bt_sort_on_off.Text = "aufsteigend";
                gv_manage.Sort(gv_manage.Columns[1], ListSortDirection.Ascending);

            }
            else if (bt_sort_on_off.Text == "aufsteigend")
            {
                bt_sort_on_off.Text = "absteigend";
                gv_manage.Sort(gv_manage.Columns[1], ListSortDirection.Descending);

            }
            else if (bt_sort_on_off.Text == "absteigend")
            {
                bt_sort_on_off.Text = "unsortiert";
                gv_manage.Sort(gv_manage.Columns[0], ListSortDirection.Ascending);

            }
        }

        private void Gv_manage_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //gv_manage.CurrentCell = gv_manage.SelectedCells[0];
                gv_manage.BeginEdit(true);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode == Keys.Tab)
            {
                mbt_Suchen.Focus();
                e.SuppressKeyPress = true;
            }
        }
    }
}
