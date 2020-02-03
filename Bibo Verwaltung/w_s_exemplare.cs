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

namespace Bibo_Verwaltung
{
    public partial class w_s_exemplare : MetroFramework.Forms.MetroForm
    {
        Exemplar exemplar = new Exemplar();
        Image resultImage = null;
        List<Image> images = new List<Image>();
        bool loaded = false;

        #region Constructor
        string currentUser;
        public w_s_exemplare(string userName, string isbn)
        {
            InitializeComponent();
            Benutzer user = new Benutzer(userName);
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;
            if (user.Rechteid.Equals("0"))
            {

            }
            else if (user.Rechteid.Equals("1"))
            {

            }
            else if (user.Rechteid == "2")
            {

            }
            exemplar.ISBN = isbn;
            tb_ISBN.Text = exemplar.ISBN;
            exemplar.Zustand.FillCombobox(ref acb_Zustand, 0);
            tb_ExempCount.Text = gv_Exemplare.RowCount.ToString();
        }
        #endregion

        private void Grid_Buch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_Exemplare.Rows[e.RowIndex];
                exemplar.ExemplarID = row.Cells["Exemplar"].Value.ToString();
                LoadForm();
            }
        }

        /// <summary>
        /// Lädt ein Exemplar
        /// </summary>
        private void LoadForm()
        {
            Exemplar ex = new Exemplar(exemplar.ExemplarID);
            tb_ID.Text = ex.ExemplarID;
            tb_ISBN.Text = ex.ISBN;
            acb_Zustand.Text = ex.Zustand.Zustandname;
            dTP_AufDat.Value = ex.Aufnahmedatum;
            
            #region Barcode generieren
            string code = "";
            code = ex.ExemplarID;
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

            rb_edit.Checked = true;
            ex.Zustand.FillCombobox(ref acb_Zustand, ex.Zustand.ZustandID);
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
                lb_Message.Text = "Das Buch wurde hinzugefügt!";
                bt_Add.Text = "Hinzufügen";
                tb_ID.Enabled = false;
                tb_ISBN.Enabled = false;
                acb_Zustand.Enabled = true;
                dTP_AufDat.Enabled = true;
                tb_ExempCount.Enabled = true;
            }
            else if (rb_delete.Checked)
            {
                lb_Message.Text = "Das Buch wurde gelöscht!";
                bt_Add.Text = "Löschen";
                tb_ID.Enabled = true;
                tb_ISBN.Enabled = false;
                acb_Zustand.Enabled = false;
                dTP_AufDat.Enabled = false;
                tb_ExempCount.Enabled = false;
            }
            else if (rb_edit.Checked)
            {
                lb_Message.Text = "Das Buch wurde gespeichert!";
                bt_Add.Text = "Speichern";
                tb_ID.Enabled = false;
                tb_ISBN.Enabled = false;
                acb_Zustand.Enabled = true;
                dTP_AufDat.Enabled = true;
                tb_ExempCount.Enabled = false;
            }
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
            tb_ID.BackColor = Color.White;
            tb_ISBN.BackColor = Color.White;
            acb_Zustand.BackColor = Color.White;
            dTP_AufDat.BackColor = Color.White;
        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            List<string> idList = new List<string>();
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, a) =>
            {
                lb_Message.Hide();
                t.Stop();
            };
            if (rb_neu.Checked && !acb_Zustand.Text.Equals(""))
            {
                try
                {
                    if (!exemplar.Zustand.IfContains(acb_Zustand.Text))
                    {
                        exemplar.Zustand.AddZustand(acb_Zustand.Text);
                        exemplar.Zustand.FillCombobox(ref acb_Zustand, exemplar.Zustand.GetZustandsID(acb_Zustand.Text));
                    }
                    lb_Message.Visible = false;
                    exemplar.ExemplarID = tb_ID.Text;
                    exemplar.ISBN = tb_ISBN.Text;
                    exemplar.Zustand.ZustandID = acb_Zustand.SelectedValue.ToString();
                    exemplar.Aufnahmedatum = dTP_AufDat.Value;
                    int number = int.Parse(tb_ExempCount.Text);
                    idList.Clear();
                    for (int i = 0; i < number; i++)
                    {
                        exemplar.Add_Exemplar();
                        exemplar.SelectLastRow(tb_ISBN.Text);
                        idList.Add(exemplar.ExemplarID);
                    }
                    //Barcode bar = new Barcode("3", BarcodeBox);
                    //bar.FillPictureBox(ref BarcodeBox);
                    Clear_Form();
                    lb_Message.Visible = true;
                    exemplar.FillGrid(ref gv_Exemplare);
                    tb_Vorhanden.Text = gv_Exemplare.RowCount.ToString();
                    t.Start();
                    DialogResult result = MetroMessageBox.Show(this, "Möchten Sie alle eben hinzugefügten Exemplare die entsprechenden Labels drucken?", "Buchlabel drucken?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        List<string> barcodes = new List<string>();
                        //images.Clear();
                        foreach (string id in idList)
                        {
                            tb_ID.Text = id;
                            LoadForm();
                            barcodes.Add(mtb_Barcode.Text);
                            //images.Add(BarcodeBox.Image);
                        }
                        PrintMultipleBarcodes(barcodes);
                        //PrintDocument doc = new PrintDocument();
                        //PrintDialog pd = new PrintDialog();
                        //doc.PrintPage += Doc_PrintMultiplePages;
                        //pd.Document = doc;
                        //if (pd.ShowDialog() == DialogResult.OK)
                        //{
                        //    doc.Print();
                        //}

                    }
                }
                catch (SqlException)
                {
                    MetroMessageBox.Show(this, "Das Exemplar konnte nicht hinzugefügt werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_delete.Checked && !tb_ID.Text.Equals(""))
            {
                try
                {
                    lb_Message.Visible = false;
                    exemplar.ExemplarID = tb_ID.Text;
                    exemplar.ISBN = tb_ISBN.Text;
                    exemplar.Zustand.ZustandID = acb_Zustand.SelectedValue.ToString();
                    exemplar.Aufnahmedatum = dTP_AufDat.Value;
                    //b.Delete();
                    if (exemplar.IsSpecificAvailable())
                    {
                        exemplar.Deactivate_Exemplar();
                        Clear_Form();
                        lb_Message.Visible = true;
                        exemplar.FillGrid(ref gv_Exemplare);
                        tb_Vorhanden.Text = gv_Exemplare.RowCount.ToString();
                        t.Start();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Das Exemplar konnte nicht gelöscht werden, da es sich noch im Verleih befindet. Bitte markieren Sie es zuerst als 'zurückgegeben'!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                catch (SqlException)
                {
                    MetroMessageBox.Show(this, "Das Buch konnte nicht gelöscht werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_edit.Checked && !acb_Zustand.Text.Equals(""))
            {
                try
                {
                    if (!exemplar.Zustand.IfContains(acb_Zustand.Text))
                    {
                        exemplar.Zustand.AddZustand(acb_Zustand.Text);
                        exemplar.Zustand.FillCombobox(ref acb_Zustand, exemplar.Zustand.GetZustandsID(acb_Zustand.Text));
                    }
                    lb_Message.Visible = false;
                    exemplar.ExemplarID = tb_ID.Text;
                    exemplar.ISBN = tb_ISBN.Text;
                    exemplar.Zustand.ZustandID = acb_Zustand.SelectedValue.ToString();
                    exemplar.Aufnahmedatum = dTP_AufDat.Value;
                    exemplar.Update_Exemplar();
                    Clear_Form();
                    lb_Message.Visible = true;
                    exemplar.FillGrid(ref gv_Exemplare);
                    tb_Vorhanden.Text = gv_Exemplare.RowCount.ToString();
                    t.Start();
                }
                catch (SqlException)
                {
                    MetroMessageBox.Show(this, "Das Buch konnte nicht bearbeitet werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_edit.Checked)
            {
                MetroMessageBox.Show(this, "Füllen Sie alle Felder aus, um ein Buch zu bearbeiten!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsOK();
            }
            else if (rb_neu.Checked)
            {
                MetroMessageBox.Show(this, "Füllen Sie alle Felder aus, um ein neues Buch hinzuzufügen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsOK();
            }
            else if (rb_delete.Checked)
            {
                MetroMessageBox.Show(this, "Füllen Sie alle Felder aus, um ein Buch zu löschen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb_ID.Text.Equals(""))
                {
                    tb_ID.BackColor = Color.Red;
                }
            }
        }

        private void tb_isbn_TextChanged(object sender, EventArgs e)
        {
            tb_ISBN.BackColor = Color.White;
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            tb_ID.BackColor = Color.White;
        }

        private void cb_zustand_TextChanged(object sender, EventArgs e)
        {
            acb_Zustand.BackColor = Color.White;
        }

        private void dTP_aufnahme_ValueChanged(object sender, EventArgs e)
        {
            dTP_AufDat.BackColor = Color.White;
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

        private void w_s_buchid_Activated(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
            try
            {

                //exemplar.Zustand.FillCombobox(ref acb_Zustand, -1);
                //if (tb_ID.Text != "")
                //{
                //    LoadForm();
                //}
                //if (gv_Exemplare.SelectedRows.Count > 0)
                //{
                //    string s = gv_Exemplare.SelectedRows[0].Cells["Zustand"].Value.ToString();
                //    //exemplar.Zustand.LoadZustand();
                //    int i = acb_Zustand.FindStringExact(s);
                //    acb_Zustand.SelectedIndex = i;//!!!!!!!!!!!!

                //}
            }
            catch
            {

            }

            SetModus();
        }

        private void bt_zustand_Click(object sender, EventArgs e)
        {
            Form Zustand = new w_s_manage(currentUser, "Zustand");
            Zustand.ShowDialog(this);
            exemplar.Zustand.FillCombobox(ref acb_Zustand, 0);
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
            LoadForm();
        }

        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < gv_Exemplare.SelectedRows.Count; i++)
            {
                exemplar.ExemplarID = gv_Exemplare.SelectedRows[i].Cells[0].Value.ToString();
                exemplar.Deactivate_Exemplar();
            }
            exemplar.FillGrid(ref gv_Exemplare);
            tb_Vorhanden.Text = gv_Exemplare.RowCount.ToString();
            Clear_Form();
        }

        private void barcodeDruckenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> barcodes = new List<string>();
            //images.Clear();
            foreach (DataGridViewRow row in gv_Exemplare.SelectedRows)
            {
                tb_ID.Text = row.Cells["Exemplar"].Value.ToString();
                LoadForm();
                barcodes.Add(mtb_Barcode.Text);
                //images.Add(BarcodeBox.Image);

            }
            Clear_Form();
            PrintMultipleBarcodes(barcodes);
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
        }

        private void grid_buchid_MouseDown(object sender, MouseEventArgs e)
        {
            if (!(gv_Exemplare.HitTest(e.X, e.Y).RowIndex >= 0))
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
                    string strFilePath = path + "\\Bibliothek\\Einstellungen\\BarcodePreset.lbx";
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
                        doc.Objects[textIndex].Text = exemplar.GetTitel(barcodeData.TrimStart('0'));
                        doc.PrintOut(1, PrintOptionConstants.bpoDefault);
                        exemplar.Print(barcodeData.TrimStart('0'));
                    }
                    doc.EndPrint();
                    doc.Close();
                    MetroMessageBox.Show(this, String.Format("Es wurden erfolgreich '{0}' Barcodes gedruckt.", barcodeList.Count), "Drucken erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(this, "Es gab einen Fehler bei der Kommunikation mit dem Drucker!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MetroMessageBox.Show(this, "Es gab einen Fehler bei der Kommunikation mit dem Drucker!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            loaded = true;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BeginInvoke((Action)delegate ()
            {
                metroProgressSpinner1.Visible = true;
                gv_Exemplare.Visible = false;
            });
            MetroGrid mgExemplar = new MetroGrid();
            exemplar.FillGrid(ref mgExemplar);
            var dtExemplar = mgExemplar.DataSource;
            while (loaded == false)
            {

            }
            BeginInvoke((Action)delegate ()
            {
                gv_Exemplare.DataSource = dtExemplar;
                tb_Vorhanden.Text = gv_Exemplare.RowCount.ToString();
                metroProgressSpinner1.Visible = false;
                gv_Exemplare.Visible = true;
            });
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            exemplar.Zustand.FillCombobox(ref acb_Zustand, -1);
            if (tb_ID.Text != "")
            {
                LoadForm();
            }
            gv_Exemplare.Sort(gv_Exemplare.Columns[0], ListSortDirection.Descending);
            gv_Exemplare.Sort(gv_Exemplare.Columns[0],ListSortDirection.Ascending);

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
