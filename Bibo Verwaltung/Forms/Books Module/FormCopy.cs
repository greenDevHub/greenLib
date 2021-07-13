using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bpac;
using System.IO;
using MetroFramework.Controls;
using System.Threading;
using Bibo_Verwaltung.Helper;

namespace Bibo_Verwaltung
{
    public partial class Form_Copy : MetroFramework.Forms.MetroForm
    {
        #region variables
        AuthorHelper authorHelper = new AuthorHelper();
        GenreHelper genreHelper = new GenreHelper();
        ConditionHelper conditionHelper = new ConditionHelper();
        CopyHelper copyHelper = new CopyHelper();
        enum SaveOption
        {
            add,
            update,
            delete
        }
        #endregion

        Image resultImage = null;
        List<Image> images = new List<Image>();
        bool loaded = false;
        bool guest = false;

        #region Constructor
        public Form_Copy(string isbn)
        {
            InitializeComponent();
            LoadTheme();
            SetPermissions();
            this.Text = Text + AuthInfo.FormInfo();
            tb_ISBN.Text = isbn;
            conditionHelper.FillCombobox(ref acb_Zustand, 0);
            tb_ExempCount.Text = gv_Exemplare.RowCount.ToString();
        }
        #endregion

        private void LoadTheme()
        {
            this.StyleManager = styleManagerCopy;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.BookStyle;
            acb_Zustand.ForeColor = ThemeInfo.ForeColor;
            acb_Zustand.BackColor = ThemeInfo.BackColor;

        }

        private void SetPermissions()
        {
            if (AuthInfo.CurrentUser.PermissionId == 0)
            {
                guest = true;
                guestMode(guest);
            }
            else if (AuthInfo.CurrentUser.PermissionId == 1)
            {
                guest = false;
                guestMode(guest);
            }
            else if (AuthInfo.CurrentUser.PermissionId == 2)
            {
                guest = false;
                guestMode(guest);
            }
        }

        private void guestMode(bool activate)
        {
            bt_Add.Enabled = !activate;
            bt_Print.Enabled = !activate;
            mbt_Export.Enabled = !activate;
            mbt_Import.Enabled = !activate;
            entfernenToolStripMenuItem.Enabled = !activate;
            barcodeDruckenToolStripMenuItem.Enabled = !activate;
            if (rb_search.Checked)
            {
                bt_Add.Enabled = false;
            }
        }
        private void Grid_Buch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_Exemplare.Rows[e.RowIndex];
                string copyId = row.Cells["Exemplar"].Value.ToString();
                Copy copy = new Copy(int.Parse(copyId));
                LoadForm(copy);
            }
        }

        /// <summary>
        /// Lädt ein Exemplar
        /// </summary>
        private void LoadForm(Copy copy)
        {
            tb_ID.Text = copy.CopyId.ToString();
            tb_ISBN.Text = copy.CopyIsbn;
            acb_Zustand.Text = copy.Condition.ConditionName;
            dTP_AufDat.Value = copy.DateRegistration;
            GenerateBarcode(copy.CopyId);


            rb_edit.Checked = true;

            if (acb_Zustand.DataSource == null)
            {
                conditionHelper.FillCombobox(ref acb_Zustand, -1);

            }
        }
        private string GetCode(string id)
        {
            string code = "";
            code = id;
            for (int i = code.Length; i < 7;)
            {
                code = "0" + code;
                i++;
            }
            return code;
        }

        private void GenerateBarcode(int id)
        {
            #region Barcode generieren
            string code = "";
            code = id.ToString();
            for (int i = code.Length; i < 7;)
            {
                code = "0" + code;
                i++;
            }
            mtb_Barcode.Text = code;
            Zen.Barcode.CodeEan8BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeEan8WithChecksum;
            var barcodeImage = barcode.Draw(mtb_Barcode.Text, 70, 5);
            resultImage = new Bitmap(barcodeImage.Width, barcodeImage.Height + 30); // 20 is bottom padding, adjust to your text
            #endregion

            #region Barcode darstellen
            using (var graphics = Graphics.FromImage(resultImage))
            using (var font = new Font("Calibri", 20))
            using (var brush = new SolidBrush(Color.Black))
            using (var format = new StringFormat()
            {
                Alignment = StringAlignment.Center, // Also, horizontally centered text, as in your example of the expected output
                LineAlignment = StringAlignment.Far
            })
            {
                graphics.Clear(Color.White);
                graphics.DrawImage(barcodeImage, 0, 0);
                graphics.DrawString(mtb_Barcode.Text, font, brush, resultImage.Width / 2, resultImage.Height, format);
            }
            BarcodeBox.Height = resultImage.Height;
            BarcodeBox.Width = resultImage.Width;
            BarcodeBox.Image = resultImage;
            #endregion
        }

        /// <summary>
        /// Setzt die Form zurück 
        /// </summary>
        private void Clear_Form()
        {
            tb_ID.Text = "";
            acb_Zustand.Text = "";
            acb_Zustand.SelectedIndex = -1;
            dTP_AufDat.Value = DateTime.Now;
            tb_ExempCount.Text = "1";
            mtb_Barcode.Text = "";
            BarcodeBox.Image = null;
            lb_Message.Visible = false;
        }

        /// <summary>
        /// Setzt den aktuellen Bearbeitungs-Modus (Hinzufügen/Bearbeiten oder Löschewn)
        /// </summary>
        private void SetModus()
        {
            if (rb_neu.Checked)
            {
                Clear_Form();
                lb_Message.Text = "Das Exemplar wurde hinzugefügt!";
                bt_Add.Text = "Hinzufügen";
                tb_ID.Enabled = false;
                tb_ISBN.Enabled = false;
                acb_Zustand.TabStop = true;
                tpanel.Visible = false;
                dTP_AufDat.Enabled = true;
                tb_ExempCount.Enabled = true;
                mlb_ISBN.Text = "ISBN:";
                mlb_ID.Text = "Exemplar-ID:";
                mlb_Zustand.Text = "Zustand:*";
                mlb_AufDat.Text = "Aufnahmedatum:*";
                mlb_ExempCount.Text = "Anzahl Exemplare:*";
                mlb_Vorhanden.Text = "Vorhanden:";
            }
            if (rb_delete.Checked)
            {
                lb_Message.Text = "Das Exemplar wurde gelöscht!";
                bt_Add.Text = "Löschen";
                tb_ID.Enabled = true;
                tb_ISBN.Enabled = false;
                acb_Zustand.TabStop = false;
                tpanel.Visible = true;
                dTP_AufDat.Enabled = false;
                tb_ExempCount.Enabled = false;
                mlb_ISBN.Text = "ISBN:";
                mlb_ID.Text = "Exemplar-ID:*";
                mlb_Zustand.Text = "Zustand:";
                mlb_AufDat.Text = "Aufnahmedatum:";
                mlb_ExempCount.Text = "Anzahl Exemplare:";
                mlb_Vorhanden.Text = "Vorhanden:";
            }
            if (rb_edit.Checked)
            {
                lb_Message.Text = "Das Exemplar wurde gespeichert!";
                bt_Add.Text = "Speichern";
                tb_ID.Enabled = false;
                tb_ISBN.Enabled = false;
                acb_Zustand.TabStop = true;
                tpanel.Visible = false;
                dTP_AufDat.Enabled = true;
                tb_ExempCount.Enabled = false;
                mlb_ISBN.Text = "ISBN:";
                mlb_ID.Text = "Exemplar-ID:*";
                mlb_Zustand.Text = "Zustand:*";
                mlb_AufDat.Text = "Aufnahmedatum:*";
                mlb_ExempCount.Text = "Anzahl Exemplare:";
                mlb_Vorhanden.Text = "Vorhanden:";
            }
            if (rb_search.Checked)
            {
                bt_Add.Text = "---";
                tb_ID.Enabled = true;
                tb_ISBN.Enabled = false;
                acb_Zustand.TabStop = true;
                tpanel.Visible = false;
                dTP_AufDat.Enabled = true;
                tb_ExempCount.Enabled = false;
                bt_Add.Enabled = false;
                mlb_ISBN.Text = "ISBN:";
                mlb_ID.Text = "Exemplar-ID:";
                mlb_Zustand.Text = "Zustand:";
                mlb_AufDat.Text = "Aufnahmedatum:";
                mlb_ExempCount.Text = "Anzahl Exemplare:";
                mlb_Vorhanden.Text = "Vorhanden:";
            }
            guestMode(guest);
        }

        /// <summary>
        /// Prüft ob ein Zustand und ein Aufnahmedatum gesetzt wurden
        /// </summary>
        private void IsOK()
        {
            if (acb_Zustand.Text.Equals(""))
            {
                acb_Zustand.BackColor = Color.Red;
            }
            if (dTP_AufDat.Text.Equals(""))
            {
                dTP_AufDat.CalendarTitleBackColor = Color.Red;
            }
        }

        /// <summary>
        /// Setzt die BackColor der Textboxen auf weiß
        /// </summary>
        private void White()
        {
            tb_ID.BackColor = ThemeInfo.BackColor;
            tb_ISBN.BackColor = ThemeInfo.BackColor;
            acb_Zustand.BackColor = ThemeInfo.BackColor;
            dTP_AufDat.BackColor = ThemeInfo.BackColor;
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            Submit();
        }

        private void Submit()
        {
            if (rb_neu.Checked)
            {
                if (IsInputOkay(SaveOption.add))
                {
                    try
                    {
                        AddCopy();
                    }
                    catch (SqlException)
                    {
                        MetroMessageBox.Show(this, "Das Exemplar konnte hinzugefügt werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MetroMessageBox.Show(this, "Füllen Sie alle Felder aus, um ein neues Exemplar hinzuzufügen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsOK();

                }
            }
            else if (rb_edit.Checked)
            {
                if (IsInputOkay(SaveOption.update))
                {
                    try
                    {
                        UpdateCopy();
                    }
                    catch (SqlException)
                    {
                        MetroMessageBox.Show(this, "Das Exemplar konnte bearbeitet werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Füllen Sie alle Felder aus, um ein Exemplar zu bearbeiten!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    IsOK();
                }
            }
            else if (rb_delete.Checked)
            {
                if (IsInputOkay(SaveOption.delete))
                {
                    try
                    {
                        DeleteCopy();
                    }
                    catch (SqlException)
                    {
                        MetroMessageBox.Show(this, "Das Exemplar konnte entfernt werden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Füllen Sie alle Felder aus, um ein Exemplar zu löschen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (tb_ID.Text.Equals(""))
                    {
                        tb_ID.BackColor = Color.Red;
                    }
                }
            }
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }
        private bool IsInputOkay(SaveOption opt)
        {
            bool inputOkay = false;
            switch (opt)
            {
                case SaveOption.add:
                    if (!acb_Zustand.Text.Equals("")) inputOkay = true;
                    break;
                case SaveOption.update:
                    if (!tb_ID.Text.Equals("") && !acb_Zustand.Text.Equals("")) inputOkay = true;
                    break;
                case SaveOption.delete:
                    if (!tb_ID.Text.Equals("")) inputOkay = true;
                    break;
            }
            return inputOkay;
        }

        private void AddCopy()
        {
            Copy copy = new Copy();

            Condition condition = new Condition();
            if (!conditionHelper.AlreadyContains(acb_Zustand.Text))
            {
                condition.ConditionName = acb_Zustand.Text;
                condition.Add();
                conditionHelper.FillCombobox(ref acb_Zustand, conditionHelper.FindIdByName(acb_Zustand.Text));
            }
            condition = new Condition(conditionHelper.FindIdByName(acb_Zustand.Text));
            copy.Condition = condition;
            copy.CopyIsbn = tb_ISBN.Text;
            copy.DateRegistration = dTP_AufDat.Value;
            List<Copy> copies = new List<Copy>();
            int copyCount = int.Parse(tb_ExempCount.Text);
            for (int i = 0; i < copyCount; i++)
            {
                copy.Add();
                copy.SelectLastRow();
                copies.Add(copy);
            }
            Clear_Form();
            ShowMessage(SaveOption.add);

            DialogResult result = MetroMessageBox.Show(this, "Möchten Sie alle eben hinzugefügten Exemplare die entsprechenden Labels drucken?",
                "Buchlabel drucken?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                List<string> barcodes = new List<string>();
                foreach (Copy c in copies)
                {
                    string code = GetCode(c.CopyId.ToString());
                    barcodes.Add(code);
                }
                PrintMultipleBarcodes(barcodes);
            }
        }

        private void UpdateCopy()
        {
            Copy copy = new Copy(int.Parse(tb_ID.Text));
            Condition condition = new Condition();
            if (!conditionHelper.AlreadyContains(acb_Zustand.Text))
            {
                condition.ConditionName = acb_Zustand.Text;
                condition.Add();
                conditionHelper.FillCombobox(ref acb_Zustand, conditionHelper.FindIdByName(acb_Zustand.Text));
            }
            condition = new Condition(conditionHelper.FindIdByName(acb_Zustand.Text));
            copy.Condition = condition;
            copy.CopyIsbn = tb_ISBN.Text;
            copy.DateRegistration = dTP_AufDat.Value;
            copy.Update();
            Clear_Form();
            ShowMessage(SaveOption.update);
        }

        private void DeleteCopy()
        {
            Copy copy = new Copy(int.Parse(tb_ID.Text));
            if (copy.IsAvailable())
            {
                copy.Delete();
                Clear_Form();
                ShowMessage(SaveOption.delete);
            }
            else
            {
                MetroMessageBox.Show(this, "Das Exemplar konnte nicht gelöscht werden, da es sich noch im Verleih befindet. " +
                    "Bitte markieren Sie es zuerst als 'zurückgegeben'!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// shows a message to tell the user that the action was successful
        /// </summary>
        /// <param name="opt"></param>
        private void ShowMessage(SaveOption opt)
        {
            lb_Message.Text = "";
            var t = new System.Windows.Forms.Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, a) =>
            {
                lb_Message.Hide();
                t.Stop();
            };
            string message = "";
            switch (opt)
            {
                case SaveOption.add:
                    message = "Das Exemplar wurde erfolgreich hinzugefügt.";
                    break;
                case SaveOption.update:
                    message = "Das Exemplar wurde erfolgreich aktualisiert.";
                    break;
                case SaveOption.delete:
                    message = "Das Exemplar mit seinen Exemplaren wurde erfolgreich gelöscht.";
                    break;
            }
            lb_Message.Text = message;
            lb_Message.Visible = true;
            t.Start();
        }














        private void Filter()
        {
            if (gv_Exemplare.DataSource == null) return;
            try
            {
                string s = dTP_AufDat.Value.Date.ToString();
                if (dTP_AufDat.Value.Date != DateTime.Now.Date)
                {
                    s = dTP_AufDat.Value.Date.ToString();
                    (gv_Exemplare.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert([Exemplar], System.String) LIKE '%{0}%' AND Zustand LIKE '%{1}%' AND Convert([Aufnahmedatum],System.String) LIKE '%{2}%'", tb_ID.Text, acb_Zustand.Text, s);

                }
                else
                {
                    (gv_Exemplare.DataSource as DataTable).DefaultView.RowFilter = string.Format("Convert([Exemplar], System.String) LIKE '%{0}%' AND Zustand LIKE '%{1}%'", tb_ID.Text, acb_Zustand.Text);
                }
            }
            catch (Exception ex)
            {

            }
        }
        private void tb_isbn_TextChanged(object sender, EventArgs e)
        {
            tb_ISBN.BackColor = Color.White;

        }
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
        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            #region Buchcode parsen
            if (tb_ID.Text.Length == 8)
            {
                string seven = tb_ID.Text.Substring(0, 7);
                string eight = tb_ID.Text.Substring(7, 1);
                if (_checksum_ean8(seven).ToString().Equals(eight))
                {
                    tb_ID.Text = int.Parse(seven).ToString();
                }
            }
            #endregion
            Filter();
            tb_ID.BackColor = Color.White;
        }

        private void cb_zustand_TextChanged(object sender, EventArgs e)
        {
            Filter();
            acb_Zustand.BackColor = ThemeInfo.BackColor;
        }

        private void rb_Neu_CheckedChanged(object sender, EventArgs e)
        {
            SetModus();
            White();
        }

        private void rb_Edit_CheckedChanged(object sender, EventArgs e)
        {
            SetModus();
            White();
        }

        private void rb_Delete_CheckedChanged(object sender, EventArgs e)
        {
            SetModus();
            White();
        }
        private void Bt_search_CheckedChanged(object sender, EventArgs e)
        {
            SetModus();
            White();
        }
        private void DTP_AufDat_ValueChanged(object sender, EventArgs e)
        {
            Filter();
            dTP_AufDat.BackColor = Color.White;
        }
        private void w_s_buchid_Activated(object sender, EventArgs e)
        {
            //if (!backgroundWorker.IsBusy)
            //{
            //    backgroundWorker.RunWorkerAsync();
            //}

            //SetModus();
        }

        private void bt_zustand_Click(object sender, EventArgs e)
        {
            FormAttribute Zustand = new FormAttribute("Zustand");
            Zustand.ShowDialog(this);
            Zustand.Dispose();
            conditionHelper.FillCombobox(ref acb_Zustand, 0);
        }

        private void w_s_buchid_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (gv_Exemplare.RowCount == 0)
            {
                if (MetroMessageBox.Show(this, "Sie haben für dieses Buch kein Exemplar hinzugefügt. Wollen Sie das Fenster wirklich schließen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            Clear_Form();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> barcodes = new List<string>();
            barcodes.Add(mtb_Barcode.Text);

            PrintMultipleBarcodes(barcodes);
            //PrintDocument doc = new PrintDocument();
            //PrintDialog pd = new PrintDialog();
            //doc.PrintPage += Doc_PrintPage;
            //pd.Document = doc;
            //if (pd.ShowDialog() == DialogResult.OK)
            //{
            //    doc.Print();
            //}
        }

        int pageCount = 0;
        private void Doc_PrintMultiplePages(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(images[pageCount], 0, 0);
            pageCount++;
            e.HasMorePages = (pageCount != images.Count);
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            e.HasMorePages = false;
            Point loc = new Point(0, -20);
            e.Graphics.DrawImage(resultImage, loc);
        }

        private void bt_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void tb_number_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                SystemSounds.Beep.Play();
                e.Handled = true;
            }
        }

        private void tb_number_Leave(object sender, EventArgs e)
        {
            if (tb_ExempCount.Text.Equals("") || tb_ExempCount.Text.Equals("0"))
            {
                tb_ExempCount.Text = "1";
            }
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear_Form();
            tb_ID.Text = gv_Exemplare.SelectedRows[0].Cells["Exemplar"].Value.ToString();
            int copyId = int.Parse(tb_ID.Text);
            LoadForm(new Copy(copyId));
        }

        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int errorCount = 0;
            for (int i = 0; i < gv_Exemplare.SelectedRows.Count; i++)
            {
                int copyId = int.Parse(gv_Exemplare.SelectedRows[i].Cells[0].Value.ToString());
                Copy copy = new Copy(copyId);
                if (copy.IsAvailable())
                {
                    copy.Deactivate();
                }
                else
                {
                    errorCount++;
                }
            }
            //exemplar.FillGrid(ref gv_Exemplare);
            //tb_Vorhanden.Text = gv_Exemplare.RowCount.ToString();
            Clear_Form();
            if (errorCount > 0)
            {
                MetroMessageBox.Show(this, "Nicht alle Exemplare konnten gelöscht werden, da sie sich noch im Verleih befinden. Bitte markieren Sie diese zuerst als 'zurückgegeben'!", "Achtung",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void barcodeDruckenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> barcodes = new List<string>();
                //images.Clear();
                foreach (DataGridViewRow row in gv_Exemplare.SelectedRows)
                {
                    int copyId = int.Parse(row.Cells["Exemplar"].Value.ToString());
                    GenerateBarcode(copyId);
                    //LoadForm();
                    barcodes.Add(mtb_Barcode.Text);
                    //images.Add(BarcodeBox.Image);

                }
                Clear_Form();
                PrintMultipleBarcodes(barcodes);
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message + "Es gab einen Fehler bei dem Druckvorgang!", "Fehler",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //PrintDocument doc = new PrintDocument();
            //PrintDialog pd = new PrintDialog();
            //doc.PrintPage += Doc_PrintMultiplePages;
            //pd.Document = doc;
            //if (pd.ShowDialog() == DialogResult.OK)
            //{
            //    doc.Print();
            //}
        }

        private void grid_buchid_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex != -1 && e.RowIndex != -1 && e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (!gv_Exemplare.Rows[e.RowIndex].Selected)
                {
                    gv_Exemplare.ClearSelection();
                    gv_Exemplare.Rows[e.RowIndex].Selected = true;
                }
                if (gv_Exemplare.SelectedRows.Count > 1)
                {
                    ladenToolStripMenuItem.Text = "Laden";
                    ladenToolStripMenuItem.Enabled = false;
                    entfernenToolStripMenuItem.Text = "Ausgewählte Exemplare entfernen (" + gv_Exemplare.SelectedRows.Count + ")";
                    entfernenToolStripMenuItem.Enabled = true;
                    barcodeDruckenToolStripMenuItem.Text = "Barcodes für ausgewählte Exemplare drucken (" + gv_Exemplare.SelectedRows.Count + ")";
                    barcodeDruckenToolStripMenuItem.Enabled = true;
                }
                else
                {
                    ladenToolStripMenuItem.Text = "Laden";
                    ladenToolStripMenuItem.Enabled = true;
                    entfernenToolStripMenuItem.Text = "Ausgewähltes Exemplare entfernen";
                    entfernenToolStripMenuItem.Enabled = true;
                    barcodeDruckenToolStripMenuItem.Text = "Barcode für ausgewähltes Exemplare drucken";
                    barcodeDruckenToolStripMenuItem.Enabled = true;
                }
            }
            guestMode(guest);
        }

        private void grid_buchid_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(gv_Exemplare.HitTest(e.X, e.Y).RowIndex >= 0) || !(gv_Exemplare.HitTest(e.X, e.Y).ColumnIndex >= 0))
            {
                gv_Exemplare.ClearSelection();
                ladenToolStripMenuItem.Visible = false;
                entfernenToolStripMenuItem.Visible = false;
                barcodeDruckenToolStripMenuItem.Visible = false;
            }
            else
            {
                ladenToolStripMenuItem.Visible = true;
                entfernenToolStripMenuItem.Visible = true;
                barcodeDruckenToolStripMenuItem.Visible = true;
            }
        }
        void HandlePrinted(int status, object value)
        {
            Console.WriteLine("Printed event called");
        }

        private void PrintMultipleBarcodes(List<string> barcodeList)
        {
            try
            {
                IPrinter printer = new Printer();
                object[] x = printer.GetInstalledPrinters();
                string name = x[0].ToString();
                bool test = printer.IsPrinterOnline(name);
                if (test)
                {
                    string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string strFilePath = path + "\\greenLib\\Einstellungen\\BarcodePreset.lbx";
                    IDocument doc = new Document();
                    doc.Open(strFilePath);
                    int barcodeIndex = doc.GetBarcodeIndex("Barcode");
                    IObjects ob = doc.Objects;
                    int anzahlObs = ob.Count;
                    int textInd = doc.GetTextIndex("Titel");
                    int textIndex = barcodeIndex + 1;
                    doc.SetPrinter(printer.Name, true);
                    doc.StartPrint("", PrintOptionConstants.bpoDefault);
                    foreach (string barcodeData in barcodeList)
                    {
                        doc.SetBarcodeData(barcodeIndex, barcodeData);
                        int copyId = int.Parse(barcodeData.TrimStart('0'));
                        Copy copy = new Copy(copyId);
                        doc.Objects[textIndex].Text = copy.CopyTitle;
                        doc.PrintOut(1, PrintOptionConstants.bpoDefault);
                        copy.Print();
                    }
                    doc.EndPrint();
                    doc.Close();
                    MetroMessageBox.Show(this, String.Format("Es wurden erfolgreich '{0}' Barcodes gedruckt.", barcodeList.Count), "Drucken erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tb_ID.ResetText();
                    MetroMessageBox.Show(this, "Der Drucker ist nicht online!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                tb_ID.ResetText();
                MetroMessageBox.Show(this, "Es gab einen Fehler bei der Kommunikation mit dem Drucker!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            loaded = true;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                BeginInvoke((Action)delegate ()
                {
                    try
                    {
                        if (acb_Zustand.AutoCompleteSource != AutoCompleteSource.None)
                        {
                            acb_Zustand.AutoCompleteSource = AutoCompleteSource.None;
                        }
                    }
                    catch
                    {

                    }

                    metroProgressSpinner1.Visible = true;
                    gv_Exemplare.Visible = false;
                });
                MetroGrid mgExemplar = new MetroGrid();
                copyHelper.FillGrid(ref mgExemplar, tb_ISBN.Text);
                var dtExemplar = mgExemplar.DataSource;
                while (loaded == false)
                {

                }
                loaded = false;
                BeginInvoke((Action)delegate ()
                {
                    gv_Exemplare.DataSource = null;
                    gv_Exemplare.DataSource = dtExemplar;
                    gv_Exemplare.Refresh();
                    metroProgressSpinner1.Visible = false;
                    gv_Exemplare.Visible = true;
                    tb_Vorhanden.Text = gv_Exemplare.RowCount.ToString();

                });
            }
            catch (Exception ex)
            {
                BeginInvoke((Action)delegate ()
                {
                    tb_Vorhanden.Text = gv_Exemplare.RowCount.ToString();
                    metroProgressSpinner1.Visible = false;
                    gv_Exemplare.Visible = true;
                });

            }
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            if (acb_Zustand.DataSource == null)
            {
                conditionHelper.FillCombobox(ref acb_Zustand, -1);

            }
            if (tb_ID.Text != "")
            {
                LoadForm(new Copy(int.Parse(tb_ID.Text)));
            }
            ////gv_Exemplare.Sort(gv_Exemplare.Columns[0], ListSortDirection.Descending);
            //gv_Exemplare.Sort(gv_Exemplare.Columns[0],ListSortDirection.Ascending);

        }

        private void W_s_exemplare_Shown(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void Gv_Exemplare_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                mbt_Import.Select();
            }
        }

        private void acb_Zustand_Enter(object sender, EventArgs e)
        {
            if (acb_Zustand.AutoCompleteSource == AutoCompleteSource.None) acb_Zustand.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void mbt_Import_Click(object sender, EventArgs e)
        {
            MetroMessageBox.Show(this, "Diese Funktion ist in der aktuellen Version noch nicht verfügbar.", "Noch nicht verfügbar.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mbt_Export_Click(object sender, EventArgs e)
        {
            ExcelExport export = new ExcelExport();
            try
            {
                export.ExportDataGridViewAsCSV(gv_Exemplare);
                MetroMessageBox.Show(this, "Export erfolgreich abgeschlossen", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MetroMessageBox.Show(this, "Beim Exportvorgang ist ein Fehler aufgetreten!", "Datenbank Export", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        //private void PrintBarcode(string barcodeData)
        //{
        //    //try
        //    //{
        //    //    IPrinter printer = new Printer();
        //    //    object[] x = printer.GetInstalledPrinters();
        //    //    string name = x[0].ToString();
        //    //    bool test = printer.IsPrinterOnline(name);
        //    //    if (test)
        //    //    {
        //    //        string strFilePath = @"C:\Users\Laurenz\Documents\Eigene Etiketten\BarcodeData.lbx";
        //    //        IDocument doc = new Document();
        //    //        doc.Open(strFilePath);
        //    //        int barcodeIndex = doc.GetBarcodeIndex("Barcode");
        //    //        doc.SetBarcodeData(barcodeIndex, barcodeData);
        //    //        doc.SetPrinter(printer.Name, true);
        //    //        doc.StartPrint("", PrintOptionConstants.bpoDefault);
        //    //        doc.PrintOut(1, PrintOptionConstants.bpoDefault);
        //    //        doc.EndPrint();
        //    //        doc.Close();
        //    //    }
        //    //    else
        //    //    {
        //    //        MetroMessageBox.Show(this, "Es gab einen Fehler bei der Kommunikation mit dem Drucker!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    }
        //    //}
        //    //catch
        //    //{
        //    //    MetroMessageBox.Show(this, "Es gab einen Fehler bei der Kommunikation mit dem Drucker!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //}


        //}
    }
}
