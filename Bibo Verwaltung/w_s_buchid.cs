﻿using System;
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

namespace Bibo_Verwaltung
{
    public partial class w_s_buchid : Form
    {
        BuchID b = new BuchID();
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
                tb_id.Text = row.Cells["BuchID"].Value.ToString();
                BuchID b = new BuchID(tb_id.Text);
                tb_id.Text = b.ID;
                tb_isbn.Text = b.ISBN;
                cb_zustand.Text = b.Zustand.Zustandname;
                dTP_aufnahme.Value = b.Aufnahmedatum;
                string code = "";
                code = b.ID;
                for(int i = code.Length; i < 7;)
                {
                    code = "0" + code;
                    i++;
                }
                tb_Barcode.Text = code;
                Zen.Barcode.CodeEan8BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeEan8WithChecksum;
                var barcodeImage = barcode.Draw(tb_Barcode.Text, 50,3);
                resultImage = new Bitmap(barcodeImage.Width, barcodeImage.Height + 20); // 20 is bottom padding, adjust to your text

                using (var graphics = Graphics.FromImage(resultImage))
                using (var font = new Font("Calibri", 10))
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
        }
        #endregion

        #region Save
        private void bt_Click(object sender, EventArgs e)
        {
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
                    b.ID = tb_id.Text;
                    b.ISBN = tb_isbn.Text;
                    b.Zustand.ZustandID = cb_zustand.SelectedValue.ToString();
                    b.Aufnahmedatum = dTP_aufnahme.Value;
                    int number = int.Parse(tb_number.Text);
                    for (int i = 0; i < number; i++)
                    {
                        b.Add();
                    }
                    //Barcode bar = new Barcode("3", BarcodeBox);
                    //bar.FillPictureBox(ref BarcodeBox);
                    Clear();
                    lb.Visible = true;
                    b.ClearDS();
                    b.FillObject();
                    b.FillGrid(ref grid_buchid);
                    tb_anzahl.Text = grid_buchid.RowCount.ToString();
                    t.Start();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Das Buch konnte nicht hinzugefügt werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if(rb_delete.Checked && !tb_id.Text.Equals(""))
            {
                try
                {
                    lb.Visible = false;
                    b.ID = tb_id.Text;
                    b.ISBN = tb_isbn.Text;
                    b.Zustand.ZustandID = cb_zustand.SelectedValue.ToString();
                    b.Aufnahmedatum = dTP_aufnahme.Value;
                    //b.Delete();
                    if (b.IsSpecificAvailable())
                    {
                        b.Deactivate();
                        Clear();
                        lb.Visible = true;
                        b.ClearDS();
                        b.FillObject();
                        b.FillGrid(ref grid_buchid);
                        tb_anzahl.Text = grid_buchid.RowCount.ToString();
                        t.Start();
                    }
                    else
                    {
                        MessageBox.Show("Das Exemplar konnte nicht gelöscht werden, da es sich noch im Verleih befindet. Bitte markieren Sie es zuerst als 'zurückgegeben'!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    
                }
                catch (SqlException)
                {
                    MessageBox.Show("Das Buch konnte nicht gelöscht werden!", "Error",
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
                    b.ID = tb_id.Text;
                    b.ISBN = tb_isbn.Text;
                    b.Zustand.ZustandID = cb_zustand.SelectedValue.ToString();
                    b.Aufnahmedatum = dTP_aufnahme.Value;
                    b.Save();
                    Clear();
                    lb.Visible = true;
                    b.ClearDS();
                    b.FillObject();
                    b.FillGrid(ref grid_buchid);
                    tb_anzahl.Text = grid_buchid.RowCount.ToString();
                    t.Start();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Das Buch konnte nicht bearbeitet werden!", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (rb_edit.Checked)
            {
                MessageBox.Show("Füllen Sie alle Felder aus, um ein Buch zu bearbeiten!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsOK();
            }
            else if (rb_neu.Checked)
            {
                MessageBox.Show("Füllen Sie alle Felder aus, um ein neues Buch hinzuzufügen!", "Achtung",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                IsOK();
            }
            else if (rb_delete.Checked)
            {
                MessageBox.Show("Füllen Sie alle Felder aus, um ein Buch zu löschen!", "Achtung",
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
                if (MessageBox.Show("Sie haben für dieses Buch kein Exemplar hinzugefügt. Wollen Sie das Fenster wirklich schließen?", "Achtung", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
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
            tb_anzahl.Clear();
            tb_id.Clear();
            cb_zustand.Text = "";
            dTP_aufnahme.Text = "";
            BarcodeBox.Image = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BarcodeBox.Image.Save("C:\\Users\\Laurenz\\testbild.png");
            //PrintDialog pd = new PrintDialog();
            //PrintDocument doc = new PrintDocument();
            //doc.PrintPage += Doc_PrintPage;
            //pd.Document = doc;
            PrintDocument doc = new PrintDocument();
            PrintDialog pd = new PrintDialog();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }

            //PrintDocument printDocument = new PrintDocument();
            //printDocument.OriginAtMargins = true;
            //printDocument.DocumentName = "Barcode";
            //printDocument.P = BarcodeBox.Image;
            //PrintDialog printDialog = new PrintDialog();
            //printDialog.Document = printDocument;
            //if (printDialog.ShowDialog() == DialogResult.OK)
            //{
            //    printDocument.Print();
            //}
        }

        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            //System.Drawing.Image bm = System.Drawing.Image.FromFile("C:\\Users\\Laurenz\\testbild.png");
            ////Bitmap bm = new Bitmap(Image.FromFile("C:\\Users\\Laurenz\\testbild.png"));
            Point loc = new Point(0, -20);
            e.Graphics.DrawImage(resultImage, loc);
            ////Bitmap bm = new Bitmap(BarcodeBox.Width, BarcodeBox.Height);
            ////BarcodeBox.DrawToBitmap(bm, new Rectangle(0, 0, BarcodeBox.Width, BarcodeBox.Height));
            ////e.Graphics.DrawImage(bm, 0, 0);
            //////bm.Dispose();
            ////bm.Save("C:\\Users\\Laurenz\\testbild1234.png", ImageFormat.Png);
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
            if (tb_number.Text.Equals("") || tb_number.Text.Equals("0"))
            {
                tb_number.Text = "1";
            }
        }

        private void grid_buchid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                for (int i = 0; i < grid_buchid.SelectedRows.Count; i++)
                {
                    b.ID = grid_buchid.SelectedRows[i].Cells[0].Value.ToString();
                    b.Deactivate();
                }
                b.ClearDS();
                b.FillObject();
                b.FillGrid(ref grid_buchid);
            }
        }
    }
}
