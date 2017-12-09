using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_rueckgabe : Form
    {
        public w_s_rueckgabe()
        {
            InitializeComponent();
            zustand.FillCombobox(ref cb_Zustand, -1);
        }
        Zustand zustand = new Zustand();
        string buch_id_global = "";
        string k_id_global = "";
        string zu_vor_global = "";
        string zu_nach_global = "";
        string ausgeliehen_global = "";
        string ruckgabe_global = "";


        private void tb_BuchCode_TextChanged(object sender, EventArgs e)
        {
            if (tb_BuchCode.Text != "")
            {
                try
                {
                    BuchID buchid = new BuchID(tb_BuchCode.Text);
                    Buch buch = new Buch(buchid.ISBN);
                    llb_Buch.Enabled = true;
                    if (buch.Titel.Length > 30)
                    {
                        llb_Buch.Text = buch.Titel.Substring(0, 30) + "...";

                    }
                    else
                    {
                        llb_Buch.Text = buch.Titel;
                    }
                    buch_id_global = buchid.ID;













                    if (buch.Image != null)
                    {
                        try
                        {
                            MemoryStream mem = new MemoryStream(buch.Image);
                            pictureBox1.Image = Image.FromStream(mem);
                            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bibliothek\\Bilder\\" + buch.ISBN + ".png";
                            if (!File.Exists(filePath))
                            {
                                pictureBox1.Image.Save(filePath, ImageFormat.Png);
                                pictureBox1.ImageLocation = filePath;
                            }
                            else
                            {
                                Delete_picture(filePath);
                                pictureBox1.Image.Save(filePath, ImageFormat.Png);
                                pictureBox1.ImageLocation = filePath;
                            }
                        }
                        catch
                        {
                        }
                    }
                    else
                    {
                        if (!buch.BildPfad.Equals(""))
                        {
                            try
                            {
                                pictureBox1.ImageLocation = buch.BildPfad;
                            }
                            catch
                            {
                                MessageBox.Show("Das Bild wurde nicht gefunden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            pictureBox1.Image = null;
                            pictureBox1.ImageLocation = null;
                        }
                    }













                    cb_Zustand.SelectedValue = buchid.Zustand.ZustandID;
                    zu_vor_global = buchid.Zustand.Zustandname;
                    zu_nach_global = buchid.Zustand.Zustandname;
                    Verlauf verlauf = new Verlauf(buch_id_global);
                    verlauf.FillGrid(ref gv_Verlauf);
                }
                catch
                {
                    Clear_All();
                }

                try
                {
                    Rueckgabe rueck = new Rueckgabe();
                    rueck.Load_Info(tb_BuchCode.Text);
                    Kunde kunde = new Kunde(rueck.KID);
                    k_id_global = kunde.KundenID;
                    llb_Kunde.Enabled = true;
                    string kundenname = kunde.Vorname + ", " + kunde.Nachname;
                    if (kundenname.Length > 30)
                    {
                        llb_Kunde.Text = kundenname.Substring(0, 30) + "...";
                    }
                    else
                    {
                        llb_Kunde.Text = kundenname;
                    }
                    lb_ausgeliehen.Text = rueck.Leihdatum.Date.ToShortDateString();
                    lb_rueckgabe.Text = rueck.Rueckgabedatum.Date.ToShortDateString();
                    ausgeliehen_global = rueck.Leihdatum.Date.ToShortDateString();
                    ruckgabe_global = DateTime.Now.Date.ToShortDateString();
                    if (rueck.Rueckgabedatum.Date < DateTime.Now.Date)
                    {
                        lb_rueckgabe.ForeColor = Color.Red;
                        lb_rueckgabe.Text = lb_rueckgabe.Text + " (überfällig)";
                    }
                }
                catch
                {
                    llb_Kunde.Enabled = false;
                    llb_Kunde.Text = "keine Treffer";
                    lb_ausgeliehen.Text = "nicht verfügbar";
                    lb_rueckgabe.Text = "nicht verfügbar";
                    lb_rueckgabe.ForeColor = Color.Black;
                }
            }
            else
            {
                Clear_All();
            }
        }

        private void Clear_All()
        {
            llb_Buch.Enabled = false;
            llb_Buch.Text = "keine Treffer";
            llb_Kunde.Enabled = false;
            llb_Kunde.Text = "keine Treffer";
            lb_ausgeliehen.Text = "nicht verfügbar";
            lb_rueckgabe.Text = "nicht verfügbar";
            cb_Zustand.SelectedValue = -1;
            lb_rueckgabe.ForeColor = Color.Black;
        }

        private void Delete_picture(string location)
        {
            if (File.Exists(location))
            {
                File.Delete(location);
            }

        }

        private void llb_Buch_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Info = new w_s_information(1, buch_id_global);
            Info.ShowDialog();
        }

        private void llb_Kunde_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form Info = new w_s_information(2, k_id_global);
            Info.ShowDialog();
        }

        private void bt_Rueckgabe_Click(object sender, EventArgs e)
        {
            if (bt_Zu_aendern.Text == "Übernehmen")
            {
                DialogResult dr = MessageBox.Show("Möchten Sie die Zustandsänderung übernehmen?", "Achtung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    zu_nach_global = cb_Zustand.Text;
                    cb_Zustand.Enabled = false;
                    bt_Zu_aendern.Text = "Ändern";
                }
                else
                {
                    zu_nach_global = zu_vor_global;
                    cb_Zustand.Enabled = false;
                    bt_Zu_aendern.Text = "Ändern";
                }
            }
            Rueckgabe ruck = new Rueckgabe();
            Zustand zust = new Zustand();
            zust.GetID(zu_nach_global);
            string zu_nach_id_global = zust.ZustandID;
            if (llb_Kunde.Text != "keine Treffer")
            {
                ruck.Buch_Rueckgabe(buch_id_global, k_id_global, zu_vor_global, zu_nach_id_global, zu_nach_global, ausgeliehen_global, ruckgabe_global);
            }
            else
            {
                MessageBox.Show("Dieses Buch wurde nicht verliehen. ES kann nicht zurückgegeben werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Zu_aendern_Click(object sender, EventArgs e)
        {
            if (cb_Zustand.Enabled == false)
            {
                cb_Zustand.Enabled = true;
                bt_Zu_aendern.Text = "Übernehmen";
            }
            else
            {
                zu_nach_global = cb_Zustand.Text;
                cb_Zustand.Enabled = false;
                bt_Zu_aendern.Text = "Ändern";
            }
        }
    }
}
