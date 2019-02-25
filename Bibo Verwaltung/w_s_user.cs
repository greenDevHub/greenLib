using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_user : Form
    {
        string currentUser;

        public w_s_user(string userName)
        {
            InitializeComponent();
            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;
            Benutzer user = new Benutzer();
            user.FillGrid(ref gv_Benutzer);
        }

        private void bt_confirm_Click(object sender, EventArgs e)
        {
            string name = tb_user.Text;
            string pw = tb_pw.Text;
            string rechte = cb_Rechte.SelectedIndex.ToString();
            Benutzer user = new Benutzer(true);
            if (bt_confirm.Text.Equals("Hinzufügen"))
            {
                if (rechte.Equals("-1"))
                {
                    MessageBox.Show("Du darfst bei den Rechten nur eine der auswählbaren Gruppen angeben!", "Falsche Rechte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_Rechte.Text = "";
                    return;
                }
                try
                {
                    user.Add(name, pw, rechte);
                    user.FillGrid(ref gv_Benutzer);
                }
                catch
                {
                    MessageBox.Show("Der angegebene Name ist bereits vorhanden. Bitte wählen Sie einen anderen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (bt_confirm.Text.Equals("Löschen"))
            {
                try
                {
                    user.Delete(name);
                    user.FillGrid(ref gv_Benutzer);
                }
                catch
                {
                    MessageBox.Show("Beim Löschen des gewählten Nutzers ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (bt_confirm.Text.Equals("Speichern"))
            {
                if (rechte.Equals("-1"))
                {
                    MessageBox.Show("Du darfst bei den Rechten nur eine der auswählbaren Gruppen angeben!", "Falsche Rechte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_Rechte.Text = "";
                    return;
                }
                try
                {
                    user.Update(name, pw, rechte);
                    user.FillGrid(ref gv_Benutzer);
                }
                catch
                {
                    MessageBox.Show("Beim Übernehmen der Änderungen ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }

        private void Modus()
        {
            if (rb_Neukunde.Checked)
            {
                lb_user.Enabled = !false;
                tb_user.Enabled = !false;
                tb_pw.Enabled = !false;
                cb_Rechte.Enabled = !false;
                lb_rechte.Enabled = !false;
                lb_pw.Enabled = !false;
                lb_Benutzer_add.Text = "Der Benutzer wurde erfolgreich hinzugefügt!";
                bt_confirm.Text = "Hinzufügen";
            }
            if (rb_KundeBearbeiten.Checked)
            {
                tb_user.Enabled = false;
                lb_user.Enabled = false;
                tb_pw.Enabled = !false;
                cb_Rechte.Enabled = !false;
                lb_rechte.Enabled = !false;
                lb_pw.Enabled = !false;
                lb_Benutzer_add.Text = "Der Benutzer wurde erfolgreich bearbeitet!";
                bt_confirm.Text = "Speichern";
            }
            if (rb_KundeLoeschen.Checked)
            {
                lb_user.Enabled = !false;
                tb_user.Enabled = !false;
                tb_pw.Enabled = false;
                cb_Rechte.Enabled = false;
                lb_rechte.Enabled = false;
                lb_pw.Enabled = false;
                lb_Benutzer_add.Text = "Der Benutzer wurde erfolgreich gelöscht!";
                bt_confirm.Text = "Löschen";
            }
        }

        private void rb_Neukunde_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void rb_KundeLoeschen_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void rb_KundeBearbeiten_CheckedChanged(object sender, EventArgs e)
        {
            Modus();
        }

        private void gv_Benutzer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_Benutzer.Rows[e.RowIndex];
                tb_user.Text = row.Cells["Name"].Value.ToString();
                Benutzer user = new Benutzer(tb_user.Text);
                tb_pw.Text = "Passwort123456";
                cb_Rechte.SelectedIndex = int.Parse(user.Rechteid);
            }

        }

        private void Reset(object sender, EventArgs e)
        {
            tb_user.Text = "";
            tb_pw.Text = "";
            cb_Rechte.Text = "";
        }
    }
}
