using MetroFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class w_s_user : MetroFramework.Forms.MetroForm
    {
        #region Constructor
        string currentUser;
        Color fc = Color.Black;
        Color bc = Color.White;
        public w_s_user(string userName, MetroFramework.Components.MetroStyleManager msm)
        {
            InitializeComponent();
            this.StyleManager = msm;
            this.StyleManager.Style = MetroColorStyle.Teal;
            if (this.StyleManager.Theme == MetroThemeStyle.Dark)
            {
                fc = Color.White;
                bc = System.Drawing.ColorTranslator.FromHtml("#111111");
                cb_Rechte.ForeColor = fc;
                cb_Rechte.BackColor = bc;
            }

            this.currentUser = userName;
            this.Text = Text + " - Angemeldet als: " + userName;
            user.FillGrid(ref gv_Benutzer);
            rb_Neukunde.Select();
        }
        #endregion

        Benutzer user = new Benutzer();

        #region Fenster-Methoden
        /// <summary>
        /// Setzt den aktuellen Modus anhand der RadioButton-Auswahl
        /// </summary>
        private void SetModus()
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

        private void Clear()
        {
            tb_user.Text = "";
            tb_pw.Text = "";
            tb_pw2.Text = "";
            cb_Rechte.Text = "";
            cb_Rechte.SelectedIndex = -1;
            user.FillGrid(ref gv_Benutzer);
        }

        /// <summary>
        /// Setzt die Form auf den Ausgangszustand zurück
        /// </summary>
        private void ClearForm(object sender, EventArgs e)
        {
            Clear();
        }
        #endregion

        #region Componenten-Aktionen
        private void bt_confirm_Click(object sender, EventArgs e)
        {
            string name = tb_user.Text;
            string pw = tb_pw.Text;
            string rechte = cb_Rechte.SelectedIndex.ToString();
            Benutzer aUser = new Benutzer(true);
            if (bt_confirm.Text.Equals("Hinzufügen"))
            {
                if (rechte.Equals("-1"))
                {
                    MetroMessageBox.Show(this, "Sie dürfen bei den Rechten nur eine der auswählbaren Gruppen angeben!", "Falsche Rechte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_Rechte.Text = "";
                    return;
                }
                try
                {
                    if (tb_pw.Text == "Passwort123456" || tb_pw.Text == "" || tb_user.Text == "" || tb_pw2.Text == "")
                    {
                        MetroMessageBox.Show(this, "Bitte geben Sie alle nötigen Informationen an!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (PasswordCorrect())
                        {
                            aUser.AddUser(name, SetPassword(pw), rechte);
                            Clear();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Die beiden Passwörter stimmen nicht überein!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }

                }
                catch
                {
                    MetroMessageBox.Show(this, "Der angegebene Name ist bereits vorhanden. Bitte wählen Sie einen anderen.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (bt_confirm.Text.Equals("Löschen"))
            {
                try
                {
                    Benutzer userLoggedIn = new Benutzer(currentUser);
                    Benutzer userDelete = new Benutzer(tb_user.Text);
                    if (userLoggedIn.BenutzerName != userDelete.BenutzerName)
                    {
                        aUser.DeleteUser(name);
                        Clear();
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Sie versuchen Ihren eigenen Nutzer zu löschen. Dies ist allerdings nicht möglich.", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch
                {

                    MetroMessageBox.Show(this, "Beim Löschen des gewählten Nutzers ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }


            }
            else if (bt_confirm.Text.Equals("Speichern"))
            {
                if (rechte.Equals("-1"))
                {
                    MetroMessageBox.Show(this, "Sie dürfen bei den Rechten nur eine der auswählbaren Gruppen angeben!", "Falsche Rechte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cb_Rechte.Text = "";
                    return;
                }
                try
                {
                    if(tb_pw.Text == "Passwort123456" || tb_pw.Text == "" || tb_user.Text == "" || tb_pw2.Text == "")
                    {
                        MetroMessageBox.Show(this, "Bitte geben Sie alle nötigen Informationen an!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tb_pw.Clear();
                    }
                    else
                    {
                        if (PasswordCorrect())
                        {
                            aUser.UpdateUser(name, SetPassword(pw), rechte);
                            Clear();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Die beiden Passwörter stimmen nicht überein!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                    
                }
                catch
                {
                    MetroMessageBox.Show(this, "Beim Übernehmen der Änderungen ist ein Fehler aufgetreten.", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool PasswordCorrect()
        {
            bool correct = false;
            if(tb_pw.Text == tb_pw2.Text && tb_pw.Text != "")
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
            return correct;
        }
        private string SetPassword(string password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);

        }
        private void rb_Neukunde_CheckedChanged(object sender, EventArgs e)
        {
            SetModus();
        }

        private void rb_KundeLoeschen_CheckedChanged(object sender, EventArgs e)
        {
            SetModus();
        }

        private void rb_KundeBearbeiten_CheckedChanged(object sender, EventArgs e)
        {
            SetModus();
        }

        private void gv_Benutzer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.gv_Benutzer.Rows[e.RowIndex];
                tb_user.Text = row.Cells["Name"].Value.ToString();
                Benutzer user = new Benutzer(tb_user.Text);
                tb_pw.Text = "Passwort123456";
                tb_pw2.Text = "";
                cb_Rechte.SelectedIndex = int.Parse(user.Rechteid);
                rb_KundeBearbeiten.Checked = true;
            }
        }
        #endregion

        private void Tb_pw_Enter(object sender, EventArgs e)
        {
            //if (rb_KundeBearbeiten.Checked)
            //{
            //    tb_pw.Clear();
            //}
            if(tb_pw.Text == "Passwort123456")
            {
                tb_pw.Text = "";
            }
        }

        private void bt_show_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                tb_pw.UseSystemPasswordChar = false;
                tb_pw2.UseSystemPasswordChar = false;
                tb_pw.PasswordChar = '\0';
                tb_pw2.PasswordChar = '\0';
            }
        }

        private void bt_show_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tb_pw.UseSystemPasswordChar = true;
                tb_pw2.UseSystemPasswordChar = true;
            }
        }
    }
}
