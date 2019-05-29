using MetroFramework;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
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
            this.currentUser = userName;
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
                this.Hide();
                Form Kunden = new w_s_Kunden(currentUser);
                Kunden.ShowDialog(this);
                this.Show();
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
                this.Hide();
                Form Genres = new w_s_genres();
                Genres.ShowDialog(this);
                this.Show();
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
                this.Hide();
                Form Sprachen = new w_s_sprachen();
                Sprachen.ShowDialog(this);
                this.Show();
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
                this.Hide();
                Form Autoren = new w_s_autoren();
                Autoren.ShowDialog(this);
                this.Show();
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
                this.Hide();
                Form Verlage = new w_s_verlage();
                Verlage.ShowDialog(this);
                this.Show();
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
                this.Hide();
                Form Buecher = new w_s_buecher(true);
                Buecher.ShowDialog(this);
                this.Show();
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Einstellungen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Einstellungen = new w_s_einstellungen();
            Einstellungen.ShowDialog(this);
            this.Show();
        }

        private void bt_Zustand_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                this.Hide();
                Form Zustand = new w_s_zustand();
                Zustand.ShowDialog(this);
                this.Show();
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
                this.Hide();
                Form Details = new w_s_buchsuche(currentUser);
                Details.ShowDialog(this);
                this.Show();
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
                this.Hide();
                Form users = new w_s_user(currentUser);
                users.ShowDialog(this);
                this.Show();
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
                this.Hide();
                Form faecher = new w_s_faecher(currentUser);
                faecher.ShowDialog(this);
                this.Show();
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
            MetroMessageBox.Show(this, "Derzeit nicht verfügbar!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //this.Hide();
            //Form analytics = new w_s_analytics();
            //analytics.ShowDialog(this);
            //this.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void bt_Klassenstufe_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                this.Hide();
                Form stufe = new w_s_klassenstufe();
                stufe.ShowDialog(this);
                this.Show();
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
                this.Hide();
                Form buchFach = new w_s_buch_fach(currentUser);
                buchFach.ShowDialog(this);
                this.Show();
                HidePanel();
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
                this.Hide();
                Form buchStufe = new w_s_buch_stufe(currentUser);
                buchStufe.ShowDialog(this);
                this.Show();
                HidePanel();
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
                this.Hide();
                Form fachStufe = new w_s_fach_stufe(currentUser);
                fachStufe.ShowDialog(this);
                this.Show();
                HidePanel();
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
                this.Hide();
                Form ausleihe = new w_s_ausleihe(currentUser);
                ausleihe.ShowDialog(this);
                this.Show();
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
                this.Hide();
                Form rueckgabe = new w_s_rueckgabe(currentUser);
                rueckgabe.ShowDialog(this);
                this.Show();
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
    }
    #endregion
}