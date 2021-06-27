using MetroFramework;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
        public w_s_main(string userName, MetroFramework.Components.MetroStyleManager msm)
        {
            InitializeComponent();

            this.StyleManager = msm;
            this.StyleManager.Style = MetroColorStyle.Blue;
            timer.Start();
            picBox = new PictureBox();
            this.Controls.Add(picBox);
            picBox.Location = new Point(0, 22);
            picBox.Size = this.Size;
            picBox.Visible = false;
            picBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Benutzer user = new Benutzer(userName);
            this.Text = "     greenLib - Angemeldet als: " + userName + " (" + user.Rechte + ")";
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
            System.IO.Directory.CreateDirectory(path + "\\greenLib");
            System.IO.Directory.CreateDirectory(path + "\\greenLib\\Bilder");
            System.IO.Directory.CreateDirectory(path + "\\greenLib\\Einstellungen");
            System.IO.Directory.CreateDirectory(path + "\\greenLib\\Downloads");
            string strFilePath = path+"\\greenLib\\Einstellungen\\BarcodePreset.lbx";
            try
            {
                if (!File.Exists(strFilePath)) File.Delete(strFilePath);
                File.WriteAllBytes(strFilePath, Properties.Resources.BarcodePreset);

            }
            catch
            {

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

        #region Formulare aufrufen
        private void bt_Kunden_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                w_s_Kunden Kunden = new w_s_Kunden(currentUser,this.StyleManager);
                this.StyleManager.Clone(Kunden);
                Kunden.ShowDialog(this);
                Kunden.Dispose();
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
                w_s_manage manage = new w_s_manage(currentUser, "Genre", this.StyleManager);
                this.StyleManager.Clone(manage);

                manage.ShowDialog(this);
                manage.Dispose();
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
                w_s_manage manage = new w_s_manage(currentUser, "Sprache", this.StyleManager);
                this.StyleManager.Clone(manage);

                manage.ShowDialog(this);
                manage.Dispose();
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
                w_s_manage manage = new w_s_manage(currentUser, "Autor", this.StyleManager);
                this.StyleManager.Clone(manage);

                manage.ShowDialog(this);
                manage.Dispose();
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
                w_s_manage manage = new w_s_manage(currentUser, "Verlag", this.StyleManager);
                this.StyleManager.Clone(manage);

                manage.ShowDialog(this);
                manage.Dispose();
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
                Form_Books Buecher = new Form_Books(currentUser, true, this.StyleManager);
                this.StyleManager.Clone(Buecher);
                Buecher.ShowDialog();

                Buecher.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Einstellungen_Click(object sender, EventArgs e)
        {
            w_s_einstellungen Einstellungen = new w_s_einstellungen(this.StyleManager);
            this.StyleManager.Clone(Einstellungen);
            Einstellungen.ShowDialog(this);
            Einstellungen.Dispose();
            connection = new SQL_Verbindung();
            connected = connection.ConnectError();
        }

        private void bt_Zustand_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                w_s_manage manage = new w_s_manage(currentUser, "Zustand",this.StyleManager);
                this.StyleManager.Clone(manage);

                manage.ShowDialog(this);
                manage.Dispose();
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
                w_s_buchsuche Details = new w_s_buchsuche(currentUser, this.StyleManager);
                this.StyleManager.Clone(Details);
                Details.ShowDialog(this);
                Details.Dispose();
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
                w_s_user users = new w_s_user(currentUser, this.StyleManager);
                this.StyleManager.Clone(users);
                users.ShowDialog(this);
                users.Dispose();
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
                w_s_manage manage = new w_s_manage(currentUser, "Fach", this.StyleManager);
                this.StyleManager.Clone(manage);

                manage.ShowDialog(this);
                manage.Dispose();
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
                w_s_klasse_stufe stufe = new w_s_klasse_stufe(currentUser, this.StyleManager);
                this.StyleManager.Clone(stufe);
                stufe.ShowDialog(this);
                stufe.Dispose();
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
                w_s_buch_fach buchFach = new w_s_buch_fach(currentUser,this.StyleManager);
                this.StyleManager.Clone(buchFach);
                buchFach.ShowDialog(this);
                buchFach.Dispose();
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
                w_s_buch_stufe buchStufe = new w_s_buch_stufe(currentUser, this.StyleManager);
                this.StyleManager.Clone(buchStufe);
                buchStufe.ShowDialog(this);
                buchStufe.Dispose();
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
                w_s_fach_stufe fachStufe = new w_s_fach_stufe(currentUser, this.StyleManager);
                this.StyleManager.Clone(fachStufe);
                fachStufe.ShowDialog(this);
                fachStufe.Dispose();
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
                w_s_ausleihe ausleihe = new w_s_ausleihe(currentUser, this.StyleManager);
                this.StyleManager.Clone(ausleihe);
                ausleihe.ShowDialog(this);
                ausleihe.Dispose();
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
                w_s_rueckgabe rueckgabe = new w_s_rueckgabe(currentUser, this.StyleManager);
                this.StyleManager.Clone(rueckgabe);
                rueckgabe.ShowDialog(this);
                rueckgabe.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #region EasterEgg
        int counter = 0;
        int secondCounter = 0;
        private void image_Click(object sender, EventArgs e)
        {
            counter++;

            if (counter == 5)
            {
                secondCounter++;
                if (secondCounter == 3)
                {
                    MetroMessageBox.Show(this, "Geben Sie im Login-Fenster als Benutzername 'Snake' ein und klicken Sie auf das Schloss-Symbol!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    secondCounter = 0;
                    counter = 0;
                }
                else
                {
                    MetroMessageBox.Show(this, "Herzlichen Glückwunsch! Sie haben Langeweile!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    counter = 0;
                }

            }

        }
        #endregion

        private void bt_zu_Click(object sender, EventArgs e)
        {
            //Blur(10);
            //pl_unschaerfe.BringToFront();
            //pl_unschaerfe.BackColor = Color.Transparent;
            //pl_unschaerfe.Visible = true;
            //mT_klassenstufebuch.Select();
            w_s_zuordnungen zuordnung = new w_s_zuordnungen(this.StyleManager, currentUser);
            this.StyleManager.Clone(zuordnung);
            zuordnung.ShowDialog(this);
            zuordnung.Dispose();
        }

        private void metroTile_Click(object sender, EventArgs e)
        {
            bt_zu.Select();
        }

        private void w_s_main_Activated(object sender, EventArgs e)
        {
            try
            {
                connected = connection.ConnectError();
            }
            catch { }
        }

        private void bt_AutoAusgabe_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                w_s_selfmade_dialog custom = new w_s_selfmade_dialog("Modusauswahl", "Wählen Sie den Ausleih- oder den Rückgabe-Modus!", "Ausleih-Modus", "Rückgabe-Modus", this.StyleManager);
                this.StyleManager.Clone(custom);
                custom.ShowDialog(this);
                if (custom.DialogResult == DialogResult.Yes)
                {
                    w_s_automatic autoausleihe = new w_s_automatic(currentUser, this.StyleManager);
                    this.StyleManager.Clone(autoausleihe);
                    autoausleihe.ShowDialog(this);
                    autoausleihe.Dispose();
                }
                else if (custom.DialogResult == DialogResult.No)
                {
                    w_s_autorueck autoruechgabe = new w_s_autorueck(currentUser, this.StyleManager);
                    this.StyleManager.Clone(autoruechgabe);
                    autoruechgabe.ShowDialog(this);
                    autoruechgabe.Dispose();
                }
                else { }
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MT_Klassen_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                w_s_manage manage = new w_s_manage(currentUser, "Klasse", this.StyleManager);
                this.StyleManager.Clone(manage);

                manage.ShowDialog(this);
                manage.Dispose();
            }
            else
            {
                MetroMessageBox.Show(this, "Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MetroLink1_Click(object sender, EventArgs e)
        {
            if(this.StyleManager.Theme == MetroThemeStyle.Light)
            {
                Properties.Settings.Default.darkmode = "true";
                Properties.Settings.Default.Save();
                //System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //config.AppSettings.Settings["darkmode"].Value = "true";
                //config.Save(ConfigurationSaveMode.Full,true);
                //ConfigurationManager.RefreshSection("appSettings");
                this.StyleManager.Theme = MetroThemeStyle.Dark;
            }
            else
            {
                Properties.Settings.Default.darkmode = "false";
                Properties.Settings.Default.Save();
                //System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                //config.AppSettings.Settings["darkmode"].Value = "false";
                //config.Save(ConfigurationSaveMode.Full, true);
                //ConfigurationManager.RefreshSection("appSettings");
                this.StyleManager.Theme = MetroThemeStyle.Light;
            }
        }

        private void bt_help_Click(object sender, EventArgs e)
        {
            try
            {
                String openPDFFile = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\greenLib\greenLib Handbuch.pdf";//PDF DOc name
                System.IO.File.WriteAllBytes(openPDFFile, global::Bibo_Verwaltung.Properties.Resources.Handbuch);//the resource automatically creates            
                System.Diagnostics.Process.Start(openPDFFile);

            }
            catch
            {
                MetroMessageBox.Show(this, "Es ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    #endregion
}