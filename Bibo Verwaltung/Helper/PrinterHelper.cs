using bpac;
using MetroFramework;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung.Helper
{
    class PrinterHelper
    {
        public Image BarcodeImage { get; set; }
        public string GenerateBarcode(int id)
        {
            #region Barcode generieren
            string code = "";
            code = id.ToString();
            for (int i = code.Length; i < 7;)
            {
                code = "0" + code;
                i++;
            }
            Zen.Barcode.CodeEan8BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.CodeEan8WithChecksum;
            var barcodeImage = barcode.Draw(code, 70, 5);
            var resultImage = new Bitmap(barcodeImage.Width, barcodeImage.Height + 30); // 20 is bottom padding, adjust to your text
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
                graphics.DrawString(code, font, brush, resultImage.Width / 2, resultImage.Height, format);
            }
            BarcodeImage = resultImage;
            return code;
            #endregion
        }

        public void PrintMultipleBarcodes(List<string> barcodeList, IWin32Window owner)
        {
            try
            {
                IPrinter printer = new Printer();
                object[] x = printer.GetInstalledPrinters();
                if (x == null || x.Length == 0)
                {
                    MetroMessageBox.Show(owner, "Es wurde kein verfügbarer Drucker gefunden.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string name = x[0].ToString();
                if (printer.IsPrinterOnline(name))
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
                    MetroMessageBox.Show(owner, String.Format("Es wurden erfolgreich '{0}' Barcodes gedruckt.", barcodeList.Count), "Drucken erfolgreich!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MetroMessageBox.Show(owner, "Der Drucker ist nicht online!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(owner, "Es gab einen Fehler bei der Kommunikation mit dem Drucker!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
