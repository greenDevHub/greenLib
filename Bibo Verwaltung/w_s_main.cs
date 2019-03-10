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
        private PictureBox pb;
        //private Panel panel2;
        public w_s_main(string userName)
        {
            this.currentUser = userName;
            InitializeComponent();
            //panel2 = new Panel();
            //this.Controls.Add(panel2);
            //panel2.Size = this.Size;
            //panel2.Location = this.Location;
            pb = new PictureBox();
            this.Controls.Add(pb);
            //panel2.Controls.Add(pb);
            pb.Location = new Point(0,22);
            pb.Size = this.Size;
            pb.Visible = false;
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
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
        private void Blur(int size)
        {
            //var currentDPI = (int)Registry.GetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LogPixels", 96);
            //double scale = 96 / (float)currentDPI+1;
            Bitmap bmp = Screenshot.TakeSnapshot(this);
            //Rectangle oldBounds = this.Bounds;
            //Rectangle bounds = new Rectangle((int)((float)oldBounds.Left * scale), (int)((float)oldBounds.Top * scale), (int)((float)oldBounds.Width * scale), (int)((float)oldBounds.Height * scale));


            //using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            //{
            //    using (Graphics g = Graphics.FromImage(bitmap))
            //    {
            //        g.CopyFromScreen(new Point(bounds.Left, bounds.Top), Point.Empty, bounds.Size);
            //    }
            //    bitmap.Save("C:\\Users\\Laurenz\\Documents\\Bibliothek\\test.jpg", ImageFormat.Jpeg);
            //}
            //Bitmap bmp = new Bitmap("C:\\Users\\Laurenz\\Documents\\Bibliothek\\test.jpg");
            pb.Visible = true;
            Rectangle section = new Rectangle(new Point(0, 22), new Size(bmp.Width, bmp.Height));

            Bitmap CroppedImage = CropImage(bmp, section);
            for(int i = 0; i < size; i++)
            {
                BitmapFilter.GaussianBlur(CroppedImage, 1);
            }
            pb.Image = CroppedImage;
            pb.BringToFront();

        }

        private void UnBlur()
        {
            pb.Image = null;
            pb.Visible = false;
            pb.SendToBack();
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
        #region Load Uerbersicht
        bool error = false;
        private void Load_Uebersicht(object sender, EventArgs e)
        {
            if (!error)
            {
                UpdateForm();
            }
            
        }
        #endregion

        #region Formulare aufrufen
        private void bt_Kunden_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                this.Hide();
                Form Kunden = new w_s_Kunden(currentUser);
                Kunden.ShowDialog(this);
                this.Show();
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Genres_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                this.Hide();
                Form Genres = new w_s_genres();
                Genres.ShowDialog(this);
                this.Show();
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bt_Sprachen_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                this.Hide();
                Form Sprachen = new w_s_sprachen();
                Sprachen.ShowDialog(this);
                this.Show();
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bt_Autoren_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                this.Hide();
                Form Autoren = new w_s_autoren();
                Autoren.ShowDialog(this);
                this.Show();
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void bt_Verlage_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                this.Hide();
                Form Verlage = new w_s_verlage();
                Verlage.ShowDialog(this);
                this.Show();
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Buecher_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                this.Hide();
                Form Buecher = new w_s_buecher(true);
                Buecher.ShowDialog(this);
                this.Show();
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Einstellungen_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Einstellungen = new w_s_einstellungen();
            Einstellungen.ShowDialog(this);
            this.Show();
            UpdateForm();
            //error = false;

        }

        private void bt_Zustand_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                this.Hide();
                Form Zustand = new w_s_zustand();
                Zustand.ShowDialog(this);
                this.Show();
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Suchen_Ausleihen_Click(object sender, EventArgs e)
        {
            if (!error)
            {
                this.Hide();
                Form Details = new w_s_buchsuche(currentUser);
                Details.ShowDialog(this);
                this.Show();
            }
            else
            {
                MessageBox.Show("Sie müssen eine Verbindung zu einem SQL-Server herstellen, bevor Sie auf weitere Funktionen der Software zugreifen können!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void UpdateForm()
        {
            metroProgressBar1.Value = 0;
            timer1.Start();
            //SQL-Verbindung pruefen
            SQL_Verbindung con = new SQL_Verbindung();
            string test = con.ConnectionString;
            if (con.ConnectError())
            {
                error = true;
                lb_Bestandzahl.Text = "-";
                lb_Lagerzahl.Text = "-";
                lb_Ausleihzahl.Text = "-";
                return;
            }
            else
            {
                error = false;
            }
            string bestandSQL = "SELECT * FROM t_s_buchid WHERE bu_activated = 1";
            string ausgeliehenSQL = "SELECT * FROM t_bd_ausgeliehen";

            //zaehlt den Buecher-Bestand
            SqlDataAdapter adapter_bestand = new SqlDataAdapter(bestandSQL, con.Con);
            DataTable tbl_bastand = new DataTable();
            adapter_bestand.Fill(tbl_bastand);

            int bestand = 0;
            for (int i = 0; i < tbl_bastand.Rows.Count; i++)
            {
                bestand = bestand + 1;
            }
            tbl_bastand.Reset();
            lb_Bestandzahl.Text = bestand.ToString();

            //zaehlt ausgeliehene Buecher
            SqlDataAdapter adapter_ausgeliehen = new SqlDataAdapter(ausgeliehenSQL, con.Con);
            DataTable tbl_ausgeliehen = new DataTable();
            adapter_ausgeliehen.Fill(tbl_ausgeliehen);

            int ausgeliehen = 0;
            for (int i = 0; i < tbl_ausgeliehen.Rows.Count; i++)
            {
                ausgeliehen = ausgeliehen + 1;
            }
            lb_Ausleihzahl.Text = ausgeliehen.ToString();
            tbl_ausgeliehen.Reset();

            //zaehlt den Lagerbestand
            lb_Lagerzahl.Text = (bestand - ausgeliehen).ToString();

            con.Close();

        }

        private void bt_Benutzerverwaltung_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form users = new w_s_user(currentUser);
            users.ShowDialog(this);
            this.Show();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form faecher = new w_s_faecher(currentUser);
            faecher.ShowDialog(this);
            this.Show();
        }

        private void bt_schueler_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form schueler = new w_s_schueler();
            schueler.ShowDialog(this);
            this.Show();
        }

        private void bt_bf_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form buchfach = new w_s_buch_fach(currentUser);
            buchfach.ShowDialog(this);
            this.Show();
        }

        private void bt_stats_Click(object sender, EventArgs e)
        {
            Form analytics = new w_s_analytics();
            analytics.ShowDialog(this);
        }

        private void bt_klassenstufe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form stufe = new w_s_klassenstufe();
            stufe.ShowDialog(this);
            this.Show();
        }

        private void mT_Abmelden_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (metroProgressBar1.Value == 100)
            {
                timer1.Stop();
            }
            metroProgressBar1.Invoke((Action)delegate ()
            {
                metroProgressBar1.PerformStep();
            });
        }

        private void mT_fachbuch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form buchFach = new w_s_buch_fach(currentUser);
            buchFach.ShowDialog(this);
            this.Show();
            HidePanel();
            
        }

        private void mT_klassenstufebuch_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form buchStufe = new w_s_buch_stufe(currentUser);
            buchStufe.ShowDialog(this);
            this.Show();
            HidePanel();
        }

        private void mT_klassenstufefach_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form fachStufe = new w_s_fach_stufe(currentUser);
            fachStufe.ShowDialog(this);
            this.Show();
            HidePanel();
        }

        private void mT_ausgabe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ausleihe = new w_s_ausleihe(currentUser);
            ausleihe.ShowDialog(this);
            this.Show();
        }

        private void mT_rueckgabe_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form rueckgabe = new w_s_rueckgabe(currentUser);
            rueckgabe.ShowDialog(this);
            this.Show();
        }
        int counter = 0;
        private void image_Click(object sender, EventArgs e)
        {
            counter++;
            if(counter >= 10)
            {
                MessageBox.Show("Herzlichen GLückwunsch! Sie haben Langeweile!");
            }
        }

        private void bt_zu_Click(object sender, EventArgs e)
        {
            Blur(10);
            panel1.BringToFront();
            panel1.BackColor = Color.Transparent;
            panel1.Visible = true;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            HidePanel();
        }

        private void HidePanel()
        {
            UnBlur();
            panel1.Visible = false;
        }
    }
    #endregion
}
