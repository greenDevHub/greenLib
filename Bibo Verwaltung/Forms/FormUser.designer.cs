namespace Bibo_Verwaltung
{
    partial class FormUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUser));
            this.lbPermissions = new MetroFramework.Controls.MetroLabel();
            this.lbUserPassword = new MetroFramework.Controls.MetroLabel();
            this.btClear = new MetroFramework.Controls.MetroButton();
            this.tbUsername = new MetroFramework.Controls.MetroTextBox();
            this.tbUserPassword = new MetroFramework.Controls.MetroTextBox();
            this.lbUsername = new MetroFramework.Controls.MetroLabel();
            this.btConfirm = new MetroFramework.Controls.MetroButton();
            this.lbSuccessMessage = new MetroFramework.Controls.MetroLabel();
            this.radioDelete = new MetroFramework.Controls.MetroRadioButton();
            this.radioUpdate = new MetroFramework.Controls.MetroRadioButton();
            this.radioAdd = new MetroFramework.Controls.MetroRadioButton();
            this.gridUser = new MetroFramework.Controls.MetroGrid();
            this.btClose = new MetroFramework.Controls.MetroButton();
            this.groupInputs = new MetroFramework.Controls.MetroPanel();
            this.btPasswordShow = new MetroFramework.Controls.MetroLink();
            this.lbUserPasswordRepeat = new MetroFramework.Controls.MetroLabel();
            this.tbUserPasswordRepeat = new MetroFramework.Controls.MetroTextBox();
            this.cbPermissions = new Bibo_Verwaltung.AdvancedComboBox();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).BeginInit();
            this.groupInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPermissions
            // 
            this.lbPermissions.Location = new System.Drawing.Point(3, 118);
            this.lbPermissions.Margin = new System.Windows.Forms.Padding(3);
            this.lbPermissions.Name = "lbPermissions";
            this.lbPermissions.Size = new System.Drawing.Size(96, 24);
            this.lbPermissions.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbPermissions.TabIndex = 43;
            this.lbPermissions.Text = "Rechte:";
            this.lbPermissions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbUserPassword
            // 
            this.lbUserPassword.Location = new System.Drawing.Point(3, 58);
            this.lbUserPassword.Margin = new System.Windows.Forms.Padding(3);
            this.lbUserPassword.Name = "lbUserPassword";
            this.lbUserPassword.Size = new System.Drawing.Size(96, 24);
            this.lbUserPassword.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbUserPassword.TabIndex = 21;
            this.lbUserPassword.Text = "Passwort:";
            this.lbUserPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btClear
            // 
            this.btClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btClear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btClear.Location = new System.Drawing.Point(3, 193);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(176, 24);
            this.btClear.Style = MetroFramework.MetroColorStyle.Teal;
            this.btClear.TabIndex = 7;
            this.btClear.Text = "Leeren";
            this.metroToolTip1.SetToolTip(this.btClear, " Hier können Sie alle oben liegenden Textfelder leeren.");
            this.btClear.UseSelectable = true;
            this.btClear.Click += new System.EventHandler(this.ClearForm);
            // 
            // tbUsername
            // 
            // 
            // 
            // 
            this.tbUsername.CustomButton.Image = null;
            this.tbUsername.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tbUsername.CustomButton.Name = "";
            this.tbUsername.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUsername.CustomButton.TabIndex = 1;
            this.tbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUsername.CustomButton.UseSelectable = true;
            this.tbUsername.CustomButton.Visible = false;
            this.tbUsername.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbUsername.Lines = new string[0];
            this.tbUsername.Location = new System.Drawing.Point(156, 28);
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PromptText = "Benutzername";
            this.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.ShortcutsEnabled = true;
            this.tbUsername.Size = new System.Drawing.Size(175, 24);
            this.tbUsername.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbUsername.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.tbUsername, "Geben Sie hier den Namen des Benutzers ein.");
            this.tbUsername.UseSelectable = true;
            this.tbUsername.WaterMark = "Benutzername";
            this.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbUserPassword
            // 
            // 
            // 
            // 
            this.tbUserPassword.CustomButton.Image = null;
            this.tbUserPassword.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tbUserPassword.CustomButton.Name = "";
            this.tbUserPassword.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbUserPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUserPassword.CustomButton.TabIndex = 1;
            this.tbUserPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUserPassword.CustomButton.UseSelectable = true;
            this.tbUserPassword.CustomButton.Visible = false;
            this.tbUserPassword.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbUserPassword.Lines = new string[0];
            this.tbUserPassword.Location = new System.Drawing.Point(156, 58);
            this.tbUserPassword.MaxLength = 32767;
            this.tbUserPassword.Name = "tbUserPassword";
            this.tbUserPassword.PasswordChar = '●';
            this.tbUserPassword.PromptText = "Passwort";
            this.tbUserPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUserPassword.SelectedText = "";
            this.tbUserPassword.SelectionLength = 0;
            this.tbUserPassword.SelectionStart = 0;
            this.tbUserPassword.ShortcutsEnabled = true;
            this.tbUserPassword.Size = new System.Drawing.Size(175, 24);
            this.tbUserPassword.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbUserPassword.TabIndex = 4;
            this.metroToolTip1.SetToolTip(this.tbUserPassword, "Geben Sie hier das Passwort des dazugehörigen Benutzers ein.");
            this.tbUserPassword.UseSelectable = true;
            this.tbUserPassword.UseSystemPasswordChar = true;
            this.tbUserPassword.WaterMark = "Passwort";
            this.tbUserPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUserPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbUserPassword.Enter += new System.EventHandler(this.Tb_pw_Enter);
            // 
            // lbUsername
            // 
            this.lbUsername.Location = new System.Drawing.Point(3, 28);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(3);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(96, 24);
            this.lbUsername.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "Benutzername:";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btConfirm
            // 
            this.btConfirm.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btConfirm.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btConfirm.Location = new System.Drawing.Point(185, 193);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(176, 24);
            this.btConfirm.Style = MetroFramework.MetroColorStyle.Teal;
            this.btConfirm.TabIndex = 8;
            this.btConfirm.Text = "Hinzufügen";
            this.metroToolTip1.SetToolTip(this.btConfirm, "Hier können Sie einen bestimmten Benutzer hinzufügen/bearbeiten/entfernen.");
            this.btConfirm.UseSelectable = true;
            this.btConfirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // lbSuccessMessage
            // 
            this.lbSuccessMessage.Location = new System.Drawing.Point(3, 148);
            this.lbSuccessMessage.Margin = new System.Windows.Forms.Padding(3);
            this.lbSuccessMessage.Name = "lbSuccessMessage";
            this.lbSuccessMessage.Size = new System.Drawing.Size(328, 24);
            this.lbSuccessMessage.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbSuccessMessage.TabIndex = 40;
            this.lbSuccessMessage.Text = "Der Benutzer wurde erfolgreich hinzugefügt!";
            this.lbSuccessMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbSuccessMessage.Visible = false;
            // 
            // radioDelete
            // 
            this.radioDelete.AutoSize = true;
            this.radioDelete.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioDelete.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.radioDelete.Location = new System.Drawing.Point(251, 3);
            this.radioDelete.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioDelete.Name = "radioDelete";
            this.radioDelete.Size = new System.Drawing.Size(80, 19);
            this.radioDelete.Style = MetroFramework.MetroColorStyle.Teal;
            this.radioDelete.TabIndex = 2;
            this.radioDelete.Text = "Entfernen";
            this.radioDelete.UseSelectable = true;
            this.radioDelete.CheckedChanged += new System.EventHandler(this.rb_KundeLoeschen_CheckedChanged);
            // 
            // radioUpdate
            // 
            this.radioUpdate.AutoSize = true;
            this.radioUpdate.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioUpdate.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.radioUpdate.Location = new System.Drawing.Point(121, 3);
            this.radioUpdate.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioUpdate.Name = "radioUpdate";
            this.radioUpdate.Size = new System.Drawing.Size(88, 19);
            this.radioUpdate.Style = MetroFramework.MetroColorStyle.Teal;
            this.radioUpdate.TabIndex = 1;
            this.radioUpdate.Text = "Bearbeiten";
            this.radioUpdate.UseSelectable = true;
            this.radioUpdate.CheckedChanged += new System.EventHandler(this.rb_KundeBearbeiten_CheckedChanged);
            // 
            // radioAdd
            // 
            this.radioAdd.AutoSize = true;
            this.radioAdd.Checked = true;
            this.radioAdd.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.radioAdd.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.radioAdd.Location = new System.Drawing.Point(3, 3);
            this.radioAdd.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.radioAdd.Name = "radioAdd";
            this.radioAdd.Size = new System.Drawing.Size(90, 19);
            this.radioAdd.Style = MetroFramework.MetroColorStyle.Teal;
            this.radioAdd.TabIndex = 0;
            this.radioAdd.TabStop = true;
            this.radioAdd.Text = "Hinzufügen";
            this.radioAdd.UseSelectable = true;
            this.radioAdd.CheckedChanged += new System.EventHandler(this.rb_Neukunde_CheckedChanged);
            // 
            // gridUser
            // 
            this.gridUser.AllowUserToAddRows = false;
            this.gridUser.AllowUserToDeleteRows = false;
            this.gridUser.AllowUserToResizeColumns = false;
            this.gridUser.AllowUserToResizeRows = false;
            this.gridUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridUser.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridUser.EnableHeadersVisualStyles = false;
            this.gridUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridUser.Location = new System.Drawing.Point(393, 63);
            this.gridUser.MultiSelect = false;
            this.gridUser.Name = "gridUser";
            this.gridUser.ReadOnly = true;
            this.gridUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridUser.RowHeadersVisible = false;
            this.gridUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUser.Size = new System.Drawing.Size(283, 190);
            this.gridUser.Style = MetroFramework.MetroColorStyle.Teal;
            this.gridUser.TabIndex = 9;
            this.gridUser.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Benutzer_CellDoubleClick);
            // 
            // btClose
            // 
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btClose.Location = new System.Drawing.Point(576, 259);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 24);
            this.btClose.Style = MetroFramework.MetroColorStyle.Teal;
            this.btClose.TabIndex = 10;
            this.btClose.Text = "Schließen";
            this.btClose.UseSelectable = true;
            // 
            // groupInputs
            // 
            this.groupInputs.Controls.Add(this.btPasswordShow);
            this.groupInputs.Controls.Add(this.lbSuccessMessage);
            this.groupInputs.Controls.Add(this.btConfirm);
            this.groupInputs.Controls.Add(this.radioAdd);
            this.groupInputs.Controls.Add(this.btClear);
            this.groupInputs.Controls.Add(this.lbUsername);
            this.groupInputs.Controls.Add(this.lbPermissions);
            this.groupInputs.Controls.Add(this.radioUpdate);
            this.groupInputs.Controls.Add(this.lbUserPasswordRepeat);
            this.groupInputs.Controls.Add(this.lbUserPassword);
            this.groupInputs.Controls.Add(this.tbUsername);
            this.groupInputs.Controls.Add(this.tbUserPasswordRepeat);
            this.groupInputs.Controls.Add(this.tbUserPassword);
            this.groupInputs.Controls.Add(this.radioDelete);
            this.groupInputs.Controls.Add(this.cbPermissions);
            this.groupInputs.HorizontalScrollbarBarColor = true;
            this.groupInputs.HorizontalScrollbarHighlightOnWheel = false;
            this.groupInputs.HorizontalScrollbarSize = 10;
            this.groupInputs.Location = new System.Drawing.Point(23, 63);
            this.groupInputs.Name = "groupInputs";
            this.groupInputs.Size = new System.Drawing.Size(364, 220);
            this.groupInputs.Style = MetroFramework.MetroColorStyle.Teal;
            this.groupInputs.TabIndex = 45;
            this.groupInputs.VerticalScrollbarBarColor = true;
            this.groupInputs.VerticalScrollbarHighlightOnWheel = false;
            this.groupInputs.VerticalScrollbarSize = 10;
            // 
            // btPasswordShow
            // 
            this.btPasswordShow.Image = global::Bibo_Verwaltung.Properties.Resources.Eye16;
            this.btPasswordShow.Location = new System.Drawing.Point(337, 88);
            this.btPasswordShow.Name = "btPasswordShow";
            this.btPasswordShow.Size = new System.Drawing.Size(24, 24);
            this.btPasswordShow.TabIndex = 44;
            this.btPasswordShow.TabStop = false;
            this.btPasswordShow.UseSelectable = true;
            this.btPasswordShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.bt_show_MouseDown);
            this.btPasswordShow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.bt_show_MouseUp);
            // 
            // lbUserPasswordRepeat
            // 
            this.lbUserPasswordRepeat.Location = new System.Drawing.Point(3, 88);
            this.lbUserPasswordRepeat.Margin = new System.Windows.Forms.Padding(3);
            this.lbUserPasswordRepeat.Name = "lbUserPasswordRepeat";
            this.lbUserPasswordRepeat.Size = new System.Drawing.Size(147, 24);
            this.lbUserPasswordRepeat.Style = MetroFramework.MetroColorStyle.Teal;
            this.lbUserPasswordRepeat.TabIndex = 21;
            this.lbUserPasswordRepeat.Text = "Passwort wiederholen:";
            this.lbUserPasswordRepeat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbUserPasswordRepeat
            // 
            // 
            // 
            // 
            this.tbUserPasswordRepeat.CustomButton.Image = null;
            this.tbUserPasswordRepeat.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tbUserPasswordRepeat.CustomButton.Name = "";
            this.tbUserPasswordRepeat.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tbUserPasswordRepeat.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUserPasswordRepeat.CustomButton.TabIndex = 1;
            this.tbUserPasswordRepeat.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUserPasswordRepeat.CustomButton.UseSelectable = true;
            this.tbUserPasswordRepeat.CustomButton.Visible = false;
            this.tbUserPasswordRepeat.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tbUserPasswordRepeat.Lines = new string[0];
            this.tbUserPasswordRepeat.Location = new System.Drawing.Point(156, 88);
            this.tbUserPasswordRepeat.MaxLength = 32767;
            this.tbUserPasswordRepeat.Name = "tbUserPasswordRepeat";
            this.tbUserPasswordRepeat.PasswordChar = '●';
            this.tbUserPasswordRepeat.PromptText = "Passwort wiederholen";
            this.tbUserPasswordRepeat.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUserPasswordRepeat.SelectedText = "";
            this.tbUserPasswordRepeat.SelectionLength = 0;
            this.tbUserPasswordRepeat.SelectionStart = 0;
            this.tbUserPasswordRepeat.ShortcutsEnabled = true;
            this.tbUserPasswordRepeat.Size = new System.Drawing.Size(175, 24);
            this.tbUserPasswordRepeat.Style = MetroFramework.MetroColorStyle.Teal;
            this.tbUserPasswordRepeat.TabIndex = 5;
            this.tbUserPasswordRepeat.UseSelectable = true;
            this.tbUserPasswordRepeat.UseSystemPasswordChar = true;
            this.tbUserPasswordRepeat.WaterMark = "Passwort wiederholen";
            this.tbUserPasswordRepeat.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUserPasswordRepeat.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tbUserPasswordRepeat.Enter += new System.EventHandler(this.Tb_pw_Enter);
            // 
            // cbPermissions
            // 
            this.cbPermissions.BorderColor = System.Drawing.Color.Gray;
            this.cbPermissions.DataRowView = false;
            this.cbPermissions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPermissions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPermissions.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cbPermissions.FormattingEnabled = true;
            this.cbPermissions.HighlightColor = System.Drawing.Color.LightSeaGreen;
            this.cbPermissions.ItemHeight = 18;
            this.cbPermissions.Items.AddRange(new object[] {
            "Gast",
            "Benutzer",
            "Admin"});
            this.cbPermissions.Location = new System.Drawing.Point(156, 118);
            this.cbPermissions.Name = "cbPermissions";
            this.cbPermissions.Size = new System.Drawing.Size(175, 24);
            this.cbPermissions.TabIndex = 6;
            this.metroToolTip1.SetToolTip(this.cbPermissions, "Hier können Sie die Rechte des Benutzers auswählen/ansehen.");
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // FormUser
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(691, 296);
            this.Controls.Add(this.groupInputs);
            this.Controls.Add(this.gridUser);
            this.Controls.Add(this.btClose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormUser";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Benutzerverwaltung";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.gridUser)).EndInit();
            this.groupInputs.ResumeLayout(false);
            this.groupInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lbUserPassword;
        private MetroFramework.Controls.MetroTextBox tbUsername;
        private MetroFramework.Controls.MetroTextBox tbUserPassword;
        private MetroFramework.Controls.MetroLabel lbUsername;
        private MetroFramework.Controls.MetroLabel lbSuccessMessage;
        private MetroFramework.Controls.MetroButton btClear;
        private MetroFramework.Controls.MetroRadioButton radioDelete;
        private MetroFramework.Controls.MetroRadioButton radioUpdate;
        private MetroFramework.Controls.MetroRadioButton radioAdd;
        private MetroFramework.Controls.MetroButton btConfirm;
        private MetroFramework.Controls.MetroGrid gridUser;
        private MetroFramework.Controls.MetroButton btClose;
        private MetroFramework.Controls.MetroLabel lbPermissions;
        private AdvancedComboBox cbPermissions;
        private MetroFramework.Controls.MetroPanel groupInputs;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Controls.MetroLabel lbUserPasswordRepeat;
        private MetroFramework.Controls.MetroTextBox tbUserPasswordRepeat;
        private MetroFramework.Controls.MetroLink btPasswordShow;
    }
}