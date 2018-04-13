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

        static int _checksum_ean8(String data)
        {
            // Test string for correct length
            if (data.Length != 7 && data.Length != 8)
                return -1;
            // Test string for being numeric
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < 0x30 || data[i] > 0x39)
                    return -1;
            }
            int sum = 0;
            for (int i = 6; i >= 0; i--)
            {
                int digit = data[i] - 0x30;
                if ((i & 0x01) == 1)
                    sum += digit;
                else
                    sum += digit * 3;
            }
            int mod = sum % 10;
            return mod == 0 ? 0 : 10 - mod;
        }
        private void tb_BuchCode_TextChanged(object sender, EventArgs e)
        {
            if (tb_BuchCode.Text.Length == 8)
            {
                string seven = tb_BuchCode.Text.Substring(0, 7);
                string eight = tb_BuchCode.Text.Substring(7, 1);
                if (_checksum_ean8(seven).ToString().Equals(eight))
                {
                    tb_BuchCode.Text = int.Parse(seven).ToString();
                }
            }
            if (tb_BuchCode.Text != "")
            {
                cb_Zustand.Text = "";
                bt_Zu_aendern.Text = "Buchzustand ändern";
                try
                {
                    BuchID buchid = new BuchID(tb_BuchCode.Text);
                    if (buchid.IsActivated())
                    {
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
                                picBox.Image = Image.FromStream(mem);
                                string filePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bibliothek\\Bilder\\" + buch.ISBN + ".png";
                                if (!File.Exists(filePath))
                                {
                                    picBox.Image.Save(filePath, ImageFormat.Png);
                                    picBox.ImageLocation = filePath;
                                }
                                else
                                {
                                    Delete_picture(filePath);
                                    picBox.Image.Save(filePath, ImageFormat.Png);
                                    picBox.ImageLocation = filePath;
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
                                    picBox.ImageLocation = buch.BildPfad;
                                }
                                catch
                                {
                                    MessageBox.Show("Das Bild wurde nicht gefunden!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                picBox.Image = null;
                                picBox.ImageLocation = null;
                            }
                        }
                        cb_Zustand.SelectedValue = buchid.Zustand.ZustandID;
                        zu_vor_global = buchid.Zustand.Zustandname;
                        zu_nach_global = buchid.Zustand.Zustandname;
                        Verlauf verlauf = new Verlauf(buch_id_global);
                        verlauf.FillGrid(ref gv_Verlauf);
                    }
                    else
                    {
                        Clear_All();
                    }
                    
                }
                catch
                {
                    Clear_All();
                }

                try
                {
                    if (!llb_Buch.Text.Equals("keine Treffer"))
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
                        bt_Zu_aendern.Enabled = true;
                        bt_Rueckgabe.Enabled = true;
                    }
                    else
                    {
                        bt_Zu_aendern.Enabled = false;
                        llb_Kunde.Enabled = false;
                        bt_Rueckgabe.Enabled = false;
                        llb_Kunde.Text = "nicht verliehen";
                        lb_ausgeliehen.Text = "nicht verfügbar";
                        lb_rueckgabe.Text = "nicht verfügbar";
                        lb_rueckgabe.ForeColor = Color.Black;
                    }
                }
                catch
                {
                    bt_Zu_aendern.Enabled = false;
                    llb_Kunde.Enabled = false;
                    bt_Rueckgabe.Enabled = false;
                    llb_Kunde.Text = "nicht verliehen";
                    lb_ausgeliehen.Text = "nicht verfügbar";
                    lb_rueckgabe.Text = "nicht verfügbar";
                    lb_rueckgabe.ForeColor = Color.Black;
                }
            }
            else
            {
                Clear_All();
                bt_Rueckgabe.Enabled = false;
                bt_Zu_aendern.Enabled = false;
            }
        }

        private void Clear_All()
        {
            llb_Buch.Enabled = false;
            llb_Buch.Text = "keine Treffer";
            llb_Kunde.Enabled = false;
            llb_Kunde.Text = "nicht verliehen";
            lb_ausgeliehen.Text = "nicht verfügbar";
            lb_rueckgabe.Text = "nicht verfügbar";
            bt_Zu_aendern.Text = "Buchzustand ändern";
            cb_Zustand.Enabled = false;
            cb_Zustand.SelectedValue = -1;
            lb_rueckgabe.ForeColor = Color.Black;
            picBox.Image = null;
            gv_Verlauf.DataSource = null;
            gv_Verlauf.Update();
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
            if (llb_Kunde.Text != "nicht verliehen" && llb_Buch.Text != "keine Treffer")
            {
                DialogResult dialogResult = MessageBox.Show("Möchten Sie das Buch: '" + llb_Buch.Text + "', ausgeliehen von: '" + llb_Kunde.Text + "' wirklich als zurückgegeben markieren?", "Achtung",
                            MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (dialogResult == DialogResult.OK)
                {
                    if (bt_Zu_aendern.Text == "Übernehmen")
                    {
                        DialogResult dr = MessageBox.Show("Möchten Sie die Zustandsänderung übernehmen?", "Achtung", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (dr == DialogResult.Yes)
                        {
                            zu_nach_global = cb_Zustand.Text;
                            cb_Zustand.Enabled = false;
                            bt_Zu_aendern.Text = "Buchzustand ändern";
                        }
                        else
                        {
                            zu_nach_global = zu_vor_global;
                            cb_Zustand.Enabled = false;
                            bt_Zu_aendern.Text = "Buchzustand ändern";
                        }
                    }
                    Rueckgabe ruck = new Rueckgabe();
                    Zustand zust = new Zustand();
                    zust.GetID(zu_nach_global);
                    string zu_nach_id_global = zust.ZustandID;
                    ruck.Buch_Rueckgabe(buch_id_global, k_id_global, zu_vor_global, zu_nach_id_global, zu_nach_global, ausgeliehen_global, ruckgabe_global);
                    MessageBox.Show("Dieses Buch wurde erfolgreich zurückgegeben!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_All();
                    tb_BuchCode.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Dieses Buch wurde nicht verliehen. Es kann nicht zurückgegeben werden.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                bt_Zu_aendern.Text = "Buchzustand ändern";
            }
        }

        private void bt_open_Click(object sender, EventArgs e)
        {
            Form Zustand = new w_s_zustand();
            Zustand.ShowDialog(this);
            zustand.FillCombobox(ref cb_Zustand, -1);
        }
    }
}
