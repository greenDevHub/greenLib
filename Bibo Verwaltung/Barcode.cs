using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bibo_Verwaltung
{
    class Barcode
    {
        #region Barcode Eigenschaften
        string buch_ident;
        /// <summary>
        /// ID des Buches
        /// </summary>
        public string Buch_Ident { get { return buch_ident; } set { buch_ident = value; } }

        string kunden_ident;
        /// <summary>
        /// ID des Kunden
        /// </summary>
        public string Kunden_Ident { get { return kunden_ident; } set { kunden_ident = value; } }

        string rueck_dat;
        /// <summary>
        /// Ruechgabe Datum
        /// </summary>
        public string Rueck_Dat { get { return rueck_dat; } set { rueck_dat = value; } }
        #endregion

        #region Objekt Constructor
        /// <summary>
        /// Erschaft das Objekt Barcode
        /// </summary>
        public Barcode(string buch_ident, string kunden_ident, string rueck_dat)
        {
            this.buch_ident = buch_ident;
            this.kunden_ident = kunden_ident;
            this.rueck_dat = rueck_dat;
            Barcode_generiren();
        }

        #endregion

        #region Barcode generieren
        Bitmap bitmap;
        MemoryStream ms = new MemoryStream();
        private void Barcode_generiren()
        {
            string barcode = buch_ident + kunden_ident + rueck_dat;
            bitmap = new Bitmap(barcode.Length * 40, 150);
            using (Graphics graf = Graphics.FromImage(bitmap))
            {
                Font ofont = new System.Drawing.Font("IDAutomationHC39M", 20);
                PointF point = new PointF(2f, 2f);
                SolidBrush black = new SolidBrush(Color.Black);
                SolidBrush white = new SolidBrush(Color.White);
                graf.FillRectangle(white, 0, 0, bitmap.Width, bitmap.Height);
                graf.DrawString(barcode, ofont, black, point);
            }
            using (ms)
            {
                bitmap.Save(ms, ImageFormat.Png);
            }
        }
        #endregion

        #region PictureBox füllen
        public void FillPictureBox(ref PictureBox picBox, object value = null)
        {
            picBox.Image = bitmap;
            picBox.Height = bitmap.Height;
            picBox.Width = bitmap.Width;
        }
        #endregion
    }
}
