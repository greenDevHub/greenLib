using MetroFramework;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_main : MetroFramework.Forms.MetroForm
    {
        string currentUser;
        bool connected = false;
        private PictureBox picBox;
        SQL_Verbindung connection = new SQL_Verbindung();

        #region Constructor
        public w_s_main(string userName)
        {
            InitializeComponent();
            timer.Start();
            picBox = new PictureBox();
            this.Controls.Add(picBox);
            picBox.Location = new Point(0, 22);
            picBox.Size = this.Size;
            picBox.Visible = false;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Benutzer user = new Benutzer(userName);
            this.Text = "     Bibliotheksverwaltung - Angemeldet als: " + userName + " (" + user.Rechte + ")";
            this.currentUser = userName;
            if (user.Rechteid.Equals("0") || user.Rechteid.Equals("1"))
            {
                mT_Benutzerverwaltung.Enabled = false;
                mT_Einstellungen.Enabled = false;
            }
            else if (user.Rechteid == "2")
            {
                mT_Benutzerverwaltung.Enabled = true;
                mT_Einstellungen.Enabled = true;
            }
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            System.IO.Directory.CreateDirectory(path + "\\Bibliothek");
            System.IO.Directory.CreateDirectory(path + "\\Bibliothek\\Bilder");
            System.IO.Directory.CreateDirectory(path + "\\Bibliothek\\Einstellungen");
            System.IO.Directory.CreateDirectory(path + "\\Bibliothek\\Downloads");
            string strFilePath = path+"\\Bibliothek\\Einstellungen\\BarcodePreset.lbx";
            if (!File.Exists(strFilePath))
            {
                File.WriteAllBytes(strFilePath, Properties.Resources.BarcodePreset);
            }
        }
        #endregion

        /// <summary>
        /// Schaltet den Unschärfe-Effekt ein 
        /// </summary>
        private void Blur(int size)
        {
            Einstellung set = new Einstellung();
            double scale = set.Scale;
            Rectangle oldBounds = this.Bounds;
            Rectangle bounds = new Rectangle((int)((float)oldBounds.Left * scale), (int)((float)oldBounds.Top * scale), (int)((float)oldBounds.Width * scale), (int)((float)oldBounds.Height * scale));
            Bitmap bmp = new Bitmap(bounds.Width, bounds.Height, PixelFormat.Format32bppArgb);
            Graphics g = Graphics.FromImage(bmp);
            g.CopyFromScreen(bounds.Left, bounds.Top + ((int)((float)22 * scale)), 0, 0, bmp.Size, CopyPixelOperation.SourceCopy);
            g.Dispose();
            picBox.Visible = true;
            for (int i = 0; i < size; i++)
            {
                BitmapFilter.GaussianBlur(bmp, 1);
            }
            picBox.Image = bmp;
            picBox.SizeMode = PictureBoxSizeMode.Zoom;
            picBox.BringToFront();
            //int curDPI = 0;

            //using (Graphics g = this.CreateGraphics())
            //{
            //    curDPI = (int)g.DpiX;
            //}
            //double scale = 1 + (curDPI / 96);
            //Bitmap bmp = Screenshot.TakeSnapshot(this);
            //Rectangle oldBounds = this.Bounds;
            //Rectangle bounds = new Rectangle((int)((float)oldBounds.Left * scale), (int)((float)oldBounds.Top * scale), (int)((float)oldBounds.Width * scale), (int)((float)oldBounds.Height * scale));
            //picBox.Visible = true;
            //Rectangle section = new Rectangle(new Point(0, 22), new Size(bmp.Width, bmp.Height));
            //Bitmap CroppedImage = CropImage(bmp, section);
            //for (int i = 0; i < size; i++)
            //{
            //    BitmapFilter.GaussianBlur(CroppedImage, 1);
            //}
            //picBox.Image = CroppedImage;
            //picBox.BringToFront();
        }

        /// <summary>
        /// Schaltet den Unschärfe-Effekt aus 
        /// </summary>
        private void UnBlur()
        {
            picBox.Image = null;
            picBox.Visible = false;
            picBox.SendToBack();
        }

        public Bitmap CropImage(Bitmap source, Rectangle section)
        {
            // An empty bitmap which will hold the cropped image
            Bitmap bmp = new Bitmap(section.Width, section.Height);

            Graphics g = Graphics.FromImage(bmp);

            // Draw the given area (section) of the source image
            // at location 0,0 on the empty bitmap (bmp)
            g.DrawImage(source, 0, 0, section, GraphicsUnit.Pixel);

            return bmp;
        }

        private void HidePanel()
        {
            UnBlur();
            pl_unschaerfe.Visible = false;
        }

        #region Formulare aufrufen
        private void bt_Kunden_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form Kunden = new w_s_Kunden(currentUser);
                Kunden.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Genres_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form manage = new w_s_manage(currentUser, "Genre");
                manage.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Sprachen_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form manage = new w_s_manage(currentUser, "Sprache");
                manage.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Autoren_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form manage = new w_s_manage(currentUser, "Autor");
                manage.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Verlage_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form manage = new w_s_manage(currentUser, "Verlag");
                manage.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Buecher_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form Buecher = new w_s_buecher(currentUser, true);
                Buecher.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Einstellungen_Click(object sender, EventArgs e)
        {
            Form Einstellungen = new w_s_einstellungen();
            Einstellungen.ShowDialog(this);
        }

        private void bt_Zustand_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form manage = new w_s_manage(currentUser, "Zustand");
                manage.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Uebersicht_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form Details = new w_s_buchsuche(currentUser);
                Details.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Benutzerverwaltung_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form users = new w_s_user(currentUser);
                users.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Faecher_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form manage = new w_s_manage(currentUser, "Fach");
                manage.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Stats_Click(object sender, EventArgs e)
        {
            //if (!error)
            //{
            MetroMessageBox.Show(this, "In dieser Version nicht verfügbar!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Form analytics = new w_s_analytics();
            //analytics.ShowDialog(this);
            //}
            //else
            //{
            //    MetroMessageBox.Show(this,"Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void bt_Klassenstufe_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form stufe = new w_s_klasse_stufe(currentUser);
                stufe.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mT_Abmelden_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (metroProgressBar.Value == 100)
            {
                timer.Stop();
            }
            metroProgressBar.Invoke((Action)delegate ()
            {
                metroProgressBar.PerformStep();
            });
        }

        private void mT_FachBuch_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form buchFach = new w_s_buch_fach(currentUser);
                buchFach.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mT_KlassenstufeBuch_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form buchStufe = new w_s_buch_stufe(currentUser);
                buchStufe.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mT_KlassenstufeFach_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form fachStufe = new w_s_fach_stufe(currentUser);
                fachStufe.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mT_Ausgabe_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form ausleihe = new w_s_ausleihe(currentUser);
                ausleihe.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void mT_Rueckgabe_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form rueckgabe = new w_s_rueckgabe(currentUser);
                rueckgabe.ShowDialog(this);
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region EasterEgg
        int counter = 0;
        private void image_Click(object sender, EventArgs e)
        {
            counter++;
            if (counter >= 10)
            {
                MetroMessageBox.Show(this, "Herzlichen GLückwunsch! Sie haben Langeweile!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                counter = 0;
            }
        }
        #endregion

        private void bt_zu_Click(object sender, EventArgs e)
        {
            Blur(10);
            pl_unschaerfe.BringToFront();
            pl_unschaerfe.BackColor = Color.Transparent;
            pl_unschaerfe.Visible = true;
        }

        private void metroTile_Click(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void w_s_main_Activated(object sender, EventArgs e)
        {
            //try
            //{
            //    connected = connection.ConnectError();
            //}
            //catch { }
        }

        private void bt_AutoAusgabe_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                Form custom = new w_s_selfmade_dialog("Modusauswahl", "Wählen Sie den Ausleih- oder den Rückgabe-Modus!", "Ausleih-Modus", "Rückgabe-Modus");
                custom.ShowDialog(this);
                if (custom.DialogResult == DialogResult.Yes)
                {
                    Form autoausleihe = new w_s_automatic(currentUser);
                    autoausleihe.ShowDialog(this);
                }
                else if (custom.DialogResult == DialogResult.No)
                {
                    Form autoruechgabe = new w_s_autorueck(currentUser);
                    autoruechgabe.ShowDialog(this);
                }
                else { }
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
    #endregion
}