using Bibo_Verwaltung.Helper;
using MetroFramework;
using System;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class FormUser : MetroFramework.Forms.MetroForm
    {
        UserHelper userHelper = new UserHelper();

        #region Constructor
        public FormUser()
        {
            InitializeComponent();
            LoadTheme();

            this.Text = Text + AuthInfo.FormInfo();
            userHelper.FillGrid(ref gridUser);
            radioAdd.Select();
        }
        #endregion

        private void LoadTheme()
        {
            this.StyleManager = styleManagerUser;
            this.StyleManager.Theme = ThemeInfo.StyleManager.Theme;
            this.StyleManager.Style = ThemeInfo.UserStyle;
            cbPermissions.ForeColor = ThemeInfo.ForeColor;
            cbPermissions.BackColor = ThemeInfo.BackColor;

        }

        User user = new User();

        #region Fenster-Methoden
        /// <summary>
        /// Setzt den aktuellen Modus anhand der RadioButton-Auswahl
        /// </summary>
        private void SetModus()
        {
            if (radioAdd.Checked)
            {
                lbUsername.Enabled = !false;
                tbUsername.Enabled = !false;
                tbUserPassword.Enabled = !false;
                cbPermissions.Enabled = !false;
                lbPermissions.Enabled = !false;
                lbUserPassword.Enabled = !false;
                lbSuccessMessage.Text = "Der Benutzer wurde erfolgreich hinzugefügt!";
                btConfirm.Text = "Hinzufügen";
            }
            if (radioUpdate.Checked)
            {
                tbUsername.Enabled = false;
                lbUsername.Enabled = false;
                tbUserPassword.Enabled = !false;
                cbPermissions.Enabled = !false;
                lbPermissions.Enabled = !false;
                lbUserPassword.Enabled = !false;
                lbSuccessMessage.Text = "Der Benutzer wurde erfolgreich bearbeitet!";
                btConfirm.Text = "Speichern";
            }
            if (radioDelete.Checked)
            {
                lbUsername.Enabled = !false;
                tbUsername.Enabled = !false;
                tbUserPassword.Enabled = false;
                cbPermissions.Enabled = false;
                lbPermissions.Enabled = false;
                lbUserPassword.Enabled = false;
                lbSuccessMessage.Text = "Der Benutzer wurde erfolgreich gelöscht!";
                btConfirm.Text = "Löschen";
            }
        }

        private void Clear()
        {
            tbUsername.Text = "";
            tbUserPassword.Text = "";
            tbUserPasswordRepeat.Text = "";
            cbPermissions.Text = "";
            cbPermissions.SelectedIndex = -1;
            userHelper.FillGrid(ref gridUser);
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
            string name = tbUsername.Text;
            string pw = tbUserPassword.Text;
            string rechte = cbPermissions.SelectedIndex.ToString();
            User aUser = new User();
            if (btConfirm.Text.Equals("Hinzufügen"))
            {
                if (rechte.Equals("-1"))
                {
                    MetroMessageBox.Show(this, "Sie dürfen bei den Rechten nur eine der auswählbaren Gruppen angeben!", "Falsche Rechte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbPermissions.Text = "";
                    return;
                }
                try
                {
                    if (tbUserPassword.Text == "Passwort123456" || tbUserPassword.Text == "" || tbUsername.Text == "" || tbUserPasswordRepeat.Text == "")
                    {
                        MetroMessageBox.Show(this, "Bitte geben Sie alle nötigen Informationen an!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (PasswordCorrect())
                        {
                            aUser.UserName = name;
                            aUser.UserPassword = HashPassword(pw);
                            aUser.PermissionId = int.Parse(rechte);
                            aUser.AddUser();
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
            else if (btConfirm.Text.Equals("Löschen"))
            {
                try
                {
                    User userDelete = new User(tbUsername.Text);
                    if (AuthInfo.CurrentUser.UserName != userDelete.UserName)
                    {
                        //aUser.DeleteUser();
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
            else if (btConfirm.Text.Equals("Speichern"))
            {
                if (rechte.Equals("-1"))
                {
                    MetroMessageBox.Show(this, "Sie dürfen bei den Rechten nur eine der auswählbaren Gruppen angeben!", "Falsche Rechte!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cbPermissions.Text = "";
                    return;
                }
                try
                {
                    if (tbUserPassword.Text == "Passwort123456" || tbUserPassword.Text == "" || tbUsername.Text == "" || tbUserPasswordRepeat.Text == "")
                    {
                        MetroMessageBox.Show(this, "Bitte geben Sie alle nötigen Informationen an!", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbUserPassword.Clear();
                    }
                    else
                    {
                        if (PasswordCorrect())
                        {
                            //aUser.UpdateUser(name, HashPassword(pw), rechte);
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
            if (tbUserPassword.Text == tbUserPasswordRepeat.Text && tbUserPassword.Text != "")
            {
                correct = true;
            }
            else
            {
                correct = false;
            }
            return correct;
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
                DataGridViewRow row = this.gridUser.Rows[e.RowIndex];
                tbUsername.Text = row.Cells["Name"].Value.ToString();
                User user = new User(tbUsername.Text);
                tbUserPassword.Text = "Passwort123456";
                tbUserPasswordRepeat.Text = "";
                cbPermissions.SelectedIndex = user.PermissionId;
                radioUpdate.Checked = true;
            }
        }
        #endregion

        private void Tb_pw_Enter(object sender, EventArgs e)
        {
            //if (rb_KundeBearbeiten.Checked)
            //{
            //    tb_pw.Clear();
            //}
            if (tbUserPassword.Text == "Passwort123456")
            {
                tbUserPassword.Text = "";
            }
        }

        private void bt_show_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tbUserPassword.UseSystemPasswordChar = false;
                tbUserPasswordRepeat.UseSystemPasswordChar = false;
                tbUserPassword.PasswordChar = '\0';
                tbUserPasswordRepeat.PasswordChar = '\0';
            }
        }

        private void bt_show_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                tbUserPassword.UseSystemPasswordChar = true;
                tbUserPasswordRepeat.UseSystemPasswordChar = true;
            }
        }

        private string HashPassword(string clearPassword)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var pbkdf2 = new Rfc2898DeriveBytes(clearPassword, salt, 100000);
            byte[] hash = pbkdf2.GetBytes(20);

            byte[] hashBytes = new byte[36];
            Array.Copy(salt, 0, hashBytes, 0, 16);
            Array.Copy(hash, 0, hashBytes, 16, 20);

            return Convert.ToBase64String(hashBytes);

        }

    }
}
