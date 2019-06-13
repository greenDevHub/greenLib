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

namespace Bibo_Verwaltung
{
    public partial class w_s_buchid : MetroFramework.Forms.MetroForm
    {
        Exemplar b = new Exemplar();
        public w_s_buchid()
        {
            InitializeComponent();
            b.FillGrid(ref grid_buchid);
            tb_isbn.Text = b.ISBN;
            b.Zustand.FillCombobox(ref cb_zustand, 0);
            tb_anzahl.Text = grid_buchid.RowCount.ToString();
        }


        #region Grid_Laden
        Image resultImage = null;
        private void Grid_Buch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grid_buchid.Rows[e.RowIndex];
                tb_id.Text = row.Cells["Exemplar"].Value.ToString();
                LoadForm();
            }
        }
        #endregion

        private void LoadForm()
        {
            Exemplar b = new Exemplar(tb_id.Text);
            tb_id.Text = b.ExemplarID;
            tb_isbn.Text = b.ISBN;
            cb_zustand.Text = b.Zustand.Zustandname;
            dTP_aufnahme.Value = b.Aufnahmedatum;
            string code = "";
            code = b.ExemplarID;
            for (int i = code.Length; i < 7;)
            {
                code = "0" + code;
                i++;
            }
            tb_Barcode.Text = code;
            Zen.Barcode.CodeEan8BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeEan8WithChecksum;
            var barcodeImage = barcode.Draw(tb_Barcode.Text, 70, 5);
            resultImage = new Bitmap(barcodeImage.Width, barcodeImage.Height + 30); // 20 is bottom padding, adjust to your text

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
                graphics.DrawString(tb_Barcode.Text, font, brush, resultImage.Width / 2, resultImage.Height, format);
            }
            BarcodeBox.Height = resultImage.Height;
            BarcodeBox.Width = resultImage.Width;
            BarcodeBox.Image = resultImage;
            rb_edit.Checked = true;

            b.Zustand.FillCombobox(ref cb_zustand, b.Zustand.ZustandID);
        }
        List<Image> images = new List<Image>();
        #region Save
        private void bt_Click(object sender, EventArgs e)
        {
            List<string> idList = new List<string>();
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Tick += (s, a) =>
            {
                lb.Hide();
                t.Stop();
            };
            if(rb_neu.Checked && !cb_zustand.Text.Equals(""))
            {
                try
                {
                    if (!b.Zustand.IfContains(cb_zustand.Text))
                    {
                        b.Zustand.Add(cb_zustand.Text);
                        b.Zustand.FillCombobox(ref cb_zustand, b.Zustand.GetID(cb_zustand.Text));
                    }
                    lb.Visible = false;
                    b.ExemplarID = tb_id.Text;
                    b.ISBN = tb_isbn.Text;
                    b.Zustand.ZustandID = cb_zustand.SelectedValue.ToString();
                    b.Aufnahmedatum = dTP_aufnahme.Value;
                    int number = int.Parse(tb_number.Text);
                    idList.Clear();
                    for (int i = 0; i < number; i++)
                    {
                        b.Add_Exemplar();
                        b.SelectLastRow(tb_isbn.Text);
                        idList.Add(b.ExemplarID);
                    }
                    //Barcode bar = new Barcode("3", BarcodeBox);
                    //bar.FillPictureBox(ref BarcodeBox);
                    Clear();
                    lb.Visible = true;
                    b.FillGrid(ref grid_buchid);
                    tb_anzahl.Text = grid_buchid.RowCount.ToString();
                    t.Start();
                    DialogResult result = MetroMessageBox.Show(this,"Möchten Sie alle eben hinzugefügten Exemplare die entsprechenden Labels drucken?", "Buchlabel drucken?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        List<string> barcodes = new List<string>();
                        //images.Clear();
                        foreach(string id in idList)
                        {
                            tb_id.Text = id;
                            LoadForm();
                            barcodes.Add(tb_Barcode.Text);
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
                    MetroMessageBox.Show(this,"Das Buch konnte nicht hinzugefügt werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rb_delete.Checked && !tb_id.Text.Equals(""))
            {
                try
                {
                    lb.Visible = false;
                    b.ExemplarID = tb_id.Text;
                    b.ISBN = tb_isbn.Text;
                    b.Zustand.ZustandID = cb_zustand.SelectedValue.ToString();
                    b.Aufnahmedatum = dTP_aufnahme.Value;
                    //b.Delete();
                    if (b.IsSpecificAvailable())
                    {
                        b.Deactivate_Exemplar();
                        Clear();
                        lb.Visible = true;
                        b.FillGrid(ref grid_buchid);
                        tb_anzahl.Text = grid_buchid.RowCount.ToString();
                        t.Start();
                    }
                    else
                    {
                        MetroMessageBox.Show(this,"Das Exemplar konnte nicht gelöscht werden, da es sich noch im Verleih befindet. Bitte markieren Sie es zuerst als 'zurückgegeben'!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    
                }
                catch (SqlException)
                {
                    MetroMessageBox.Show(this,"Das Buch konnte nicht gelöscht werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rb_edit.Checked && !cb_zustand.Text.Equals(""))
            {
                try
                {
                    if (!b.Zustand.IfContains(cb_zustand.Text))
                    {
                        b.Zustand.Add(cb_zustand.Text);
                        b.Zustand.FillCombobox(ref cb_zustand, b.Zustand.GetID(cb_zustand.Text));
                    }
                    lb.Visible = false;
                    b.ExemplarID = tb_id.Text;
                    b.ISBN = tb_isbn.Text;
                    b.Zustand.ZustandID = cb_zustand.SelectedValue.ToString();
                    b.Aufnahmedatum = dTP_aufnahme.Value;
                    b.Update_Exemplar();
                    Clear();
                    lb.Visible = true;
                    b.FillGrid(ref grid_buchid);
                    tb_anzahl.Text = grid_buchid.RowCount.ToString();
                    t.Start();
                }
                catch (SqlException)
                {
                    MetroMessageBox.Show(this,"Das Buch konnte nicht bearbeitet werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_edit.Checked)
            {
                MetroMessageBox.Show(this,"Füllen Sie alle Felder aus, um ein Buch zu bearbeiten!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsOK();
            }
            else if (rb_neu.Checked)
            {
                MetroMessageBox.Show(this,"Füllen Sie alle Felder aus, um ein neues Buch hinzuzufügen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsOK();
            }
            else if (rb_delete.Checked)
            {
                MetroMessageBox.Show(this,"Füllen Sie alle Felder aus, um ein Buch zu löschen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (tb_id.Text.Equals(""))
                {
                    tb_id.BackColor = Color.Red;
                }
            }
        }
        #endregion

        #region Clear
        private void Clear()
        {
            lb.Visible = false;
            tb_id.Text = "";
            cb_zustand.Text = "";
            BarcodeBox.Image = null;
            tb_number.Text = "1";
        }
        #endregion

        #region Modus
        private void Modus()
        {
            if (rb_neu.Checked)
            {
                Clear();
                lb.Text = "Das Buch wurde hinzugefügt!";
                bt_add.Text = "Hinzufügen";
                tb_id.Enabled = false;
                tb_isbn.Enabled = false;
                cb_zustand.Enabled = true;
                dTP_aufnahme.Enabled = true;
                tb_number.Enabled = true;
            }
            else if (rb_delete.Checked)
            {
                lb.Text = "Das Buch wurde gelöscht!";
                bt_add.Text = "Löschen";
                tb_id.Enabled = true;
                tb_isbn.Enabled = false;
                cb_zustand.Enabled = false;
                dTP_aufnahme.Enabled = false;
                tb_number.Enabled = false;
            }
            else if (rb_edit.Checked)
            {
                lb.Text = "Das Buch wurde gespeichert!";
                bt_add.Text = "Speichern";
                tb_id.Enabled = false;
                tb_isbn.Enabled = false;
                cb_zustand.Enabled = true;
                dTP_aufnahme.Enabled = true;
                tb_number.Enabled = false;
            }
        }
        #endregion

        #region Farbe

        private void tb_isbn_TextChanged(object sender, EventArgs e)
        {
            tb_isbn.BackColor = Color.White;
        }

        private void tb_id_TextChanged(object sender, EventArgs e)
        {
            tb_id.BackColor = Color.White;
        }

        private void cb_zustand_TextChanged(object sender, EventArgs e)
        {
            cb_zustand.BackColor = Color.White;
        }

        private void dTP_aufnahme_ValueChanged(object sender, EventArgs e)
        {
            dTP_aufnahme.BackColor = Color.White;
        }

        #endregion

        #region Bearbeitung
        private void rb_Neu_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            White();
        }

        private void rb_Edit_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            White();
        }

        private void rb_Delete_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
            White();
        }
        private void w_s_buchid_Activated(object sender, EventArgs e)
        {
            b.Zustand.FillCombobox(ref cb_zustand, 1);
            cb_zustand.Text = "";
            Modus();

        }
        #endregion

        #region IsOK
        private void IsOK()
        {
            if (cb_zustand.Text.Equals(""))
            {
                cb_zustand.BackColor = Color.Red;
            }
            if (dTP_aufnahme.Text.Equals(""))
            {
                dTP_aufnahme.CalendarTitleBackColor = Color.Red;
            }
        }
        #endregion


        private void White()
        {
            tb_id.BackColor = Color.White;
            tb_isbn.BackColor = Color.White;
            cb_zustand.BackColor = Color.White;
            dTP_aufnahme.BackColor = Color.White;
        }

        private void bt_zustand_Click(object sender, EventArgs e)
        {
            Form Zustand = new w_s_zustand();
            Zustand.ShowDialog(this);
            b.Zustand.FillCombobox(ref cb_zustand, 0);
        }

        private void w_s_buchid_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(grid_buchid.RowCount == 0)
            {
                if (MetroMessageBox.Show(this,"Sie haben für dieses Buch kein Exemplar hinzugefügt. Wollen Sie das Fenster wirklich schließen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
            tb_number.Clear();
            tb_id.Clear();
            cb_zustand.Text = "";
            dTP_aufnahme.Text = "";
            BarcodeBox.Image = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            List<string> barcodes = new List<string>();
            barcodes.Add(tb_Barcode.Text);
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
            e.Graphics.DrawImage(resultImage, loc);        }

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
            if (tb_number.Text.Equals("") || tb_number.Text.Equals("0"))
            {
                tb_number.Text = "1";
            }
        }

        private void ladenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clear();
            tb_id.Text = grid_buchid.SelectedRows[0].Cells["Exemplar"].Value.ToString();
            LoadForm();
        }

        private void entfernenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < grid_buchid.SelectedRows.Count; i++)
            {
                b.ExemplarID = grid_buchid.SelectedRows[i].Cells[0].Value.ToString();
                b.Deactivate_Exemplar();
            }
            b.FillGrid(ref grid_buchid);
            tb_anzahl.Text = grid_buchid.RowCount.ToString();
            Clear();
        }

        private void barcodeDruckenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> barcodes = new List<string>();
            //images.Clear();
            foreach (DataGridViewRow row in grid_buchid.SelectedRows)
            {
                tb_id.Text = row.Cells["Exemplar"].Value.ToString();
                LoadForm();
                barcodes.Add(tb_Barcode.Text);
                //images.Add(BarcodeBox.Image);

            }
            Clear();
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
                if (!grid_buchid.Rows[e.RowIndex].Selected)
                {
                    grid_buchid.ClearSelection();
                    grid_buchid.Rows[e.RowIndex].Selected = true;
                }
                if(grid_buchid.SelectedRows.Count > 1)
                {
                    ladenToolStripMenuItem.Text = "Laden";
                    ladenToolStripMenuItem.Enabled = false;
                    entfernenToolStripMenuItem.Text = "Ausgewählte Exemplare entfernen (" + grid_buchid.SelectedRows.Count + ")";
                    entfernenToolStripMenuItem.Enabled = true;
                    barcodeDruckenToolStripMenuItem.Text = "Barcodes für ausgewählte Exemplare drucken (" + grid_buchid.SelectedRows.Count + ")";
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
            if (!(grid_buchid.HitTest(e.X, e.Y).RowIndex >= 0))
            {
                grid_buchid.ClearSelection();
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

        private void button2_Click(object sender, EventArgs e)
        {
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
                    string strFilePath = @"BarcodePreset.lbx";
                    File.WriteAllBytes(strFilePath, Properties.Resources.BarcodePreset);
                    IDocument doc = new Document();
                    doc.Open(strFilePath);
                    int barcodeIndex = doc.GetBarcodeIndex("Barcode");
                    doc.SetPrinter(printer.Name, true);
                    doc.StartPrint("", PrintOptionConstants.bpoDefault);
                    foreach (string barcodeData in barcodeList)
                    {
                        doc.SetBarcodeData(barcodeIndex, barcodeData);
                        doc.PrintOut(1, PrintOptionConstants.bpoDefault);

                    }
                    doc.EndPrint();
                    doc.Close();
                    File.Delete(strFilePath);
                    MetroMessageBox.Show(this, String.Format("Es wurden erfolgreich '{0}' Barcodes gedruckt.", barcodeList.Count),"Drucken erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
