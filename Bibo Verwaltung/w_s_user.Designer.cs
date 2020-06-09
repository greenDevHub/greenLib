namespace Bibo_Verwaltung
{
    partial class w_s_user
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_user));
            this.lb_rechte = new MetroFramework.Controls.MetroLabel();
            this.lb_pw = new MetroFramework.Controls.MetroLabel();
            this.bt_clear = new MetroFramework.Controls.MetroButton();
            this.tb_user = new MetroFramework.Controls.MetroTextBox();
            this.tb_pw = new MetroFramework.Controls.MetroTextBox();
            this.lb_user = new MetroFramework.Controls.MetroLabel();
            this.bt_confirm = new MetroFramework.Controls.MetroButton();
            this.lb_Benutzer_add = new MetroFramework.Controls.MetroLabel();
            this.rb_KundeLoeschen = new MetroFramework.Controls.MetroRadioButton();
            this.rb_KundeBearbeiten = new MetroFramework.Controls.MetroRadioButton();
            this.rb_Neukunde = new MetroFramework.Controls.MetroRadioButton();
            this.gv_Benutzer = new MetroFramework.Controls.MetroGrid();
            this.bt_OK = new MetroFramework.Controls.MetroButton();
            this.mP_Eingaben = new MetroFramework.Controls.MetroPanel();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.cb_Rechte = new Bibo_Verwaltung.AdvancedComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Benutzer)).BeginInit();
            this.mP_Eingaben.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_rechte
            // 
            this.lb_rechte.Location = new System.Drawing.Point(3, 88);
            this.lb_rechte.Margin = new System.Windows.Forms.Padding(3);
            this.lb_rechte.Name = "lb_rechte";
            this.lb_rechte.Size = new System.Drawing.Size(96, 24);
            this.lb_rechte.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_rechte.TabIndex = 43;
            this.lb_rechte.Text = "Rechte:";
            this.lb_rechte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lb_pw
            // 
            this.lb_pw.Location = new System.Drawing.Point(3, 58);
            this.lb_pw.Margin = new System.Windows.Forms.Padding(3);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(96, 24);
            this.lb_pw.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_pw.TabIndex = 21;
            this.lb_pw.Text = "Passwort:";
            this.lb_pw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_clear
            // 
            this.bt_clear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_clear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_clear.Location = new System.Drawing.Point(3, 148);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(96, 24);
            this.bt_clear.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_clear.TabIndex = 6;
            this.bt_clear.Text = "Leeren";
            this.metroToolTip1.SetToolTip(this.bt_clear, " Hier können Sie alle oben liegenden Textfelder leeren.");
            this.bt_clear.UseSelectable = true;
            this.bt_clear.Click += new System.EventHandler(this.ClearForm);
            // 
            // tb_user
            // 
            // 
            // 
            // 
            this.tb_user.CustomButton.Image = null;
            this.tb_user.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_user.CustomButton.Name = "";
            this.tb_user.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_user.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_user.CustomButton.TabIndex = 1;
            this.tb_user.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_user.CustomButton.UseSelectable = true;
            this.tb_user.CustomButton.Visible = false;
            this.tb_user.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_user.Lines = new string[0];
            this.tb_user.Location = new System.Drawing.Point(105, 28);
            this.tb_user.MaxLength = 32767;
            this.tb_user.Name = "tb_user";
            this.tb_user.PasswordChar = '\0';
            this.tb_user.PromptText = "Benutzername";
            this.tb_user.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_user.SelectedText = "";
            this.tb_user.SelectionLength = 0;
            this.tb_user.SelectionStart = 0;
            this.tb_user.ShortcutsEnabled = true;
            this.tb_user.Size = new System.Drawing.Size(175, 24);
            this.tb_user.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_user.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.tb_user, "Geben Sie hier den Namen des Benutzers ein.");
            this.tb_user.UseSelectable = true;
            this.tb_user.WaterMark = "Benutzername";
            this.tb_user.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_user.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_pw
            // 
            // 
            // 
            // 
            this.tb_pw.CustomButton.Image = null;
            this.tb_pw.CustomButton.Location = new System.Drawing.Point(153, 2);
            this.tb_pw.CustomButton.Name = "";
            this.tb_pw.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_pw.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_pw.CustomButton.TabIndex = 1;
            this.tb_pw.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_pw.CustomButton.UseSelectable = true;
            this.tb_pw.CustomButton.Visible = false;
            this.tb_pw.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_pw.Lines = new string[0];
            this.tb_pw.Location = new System.Drawing.Point(105, 58);
            this.tb_pw.MaxLength = 32767;
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '●';
            this.tb_pw.PromptText = "Passwort";
            this.tb_pw.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_pw.SelectedText = "";
            this.tb_pw.SelectionLength = 0;
            this.tb_pw.SelectionStart = 0;
            this.tb_pw.ShortcutsEnabled = true;
            this.tb_pw.Size = new System.Drawing.Size(175, 24);
            this.tb_pw.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_pw.TabIndex = 4;
            this.metroToolTip1.SetToolTip(this.tb_pw, "Geben Sie hier das Passwort des dazugehörigen Benutzers ein.");
            this.tb_pw.UseSelectable = true;
            this.tb_pw.UseSystemPasswordChar = true;
            this.tb_pw.WaterMark = "Passwort";
            this.tb_pw.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_pw.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lb_user
            // 
            this.lb_user.Location = new System.Drawing.Point(3, 28);
            this.lb_user.Margin = new System.Windows.Forms.Padding(3);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(96, 24);
            this.lb_user.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_user.TabIndex = 0;
            this.lb_user.Text = "Benutzername:";
            this.lb_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bt_confirm
            // 
            this.bt_confirm.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_confirm.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_confirm.Location = new System.Drawing.Point(105, 148);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(175, 24);
            this.bt_confirm.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_confirm.TabIndex = 7;
            this.bt_confirm.Text = "Hinzufügen";
            this.metroToolTip1.SetToolTip(this.bt_confirm, "Hier können Sie einen bestimmten Benutzer hinzufügen/bearbeiten/entfernen.");
            this.bt_confirm.UseSelectable = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // lb_Benutzer_add
            // 
            this.lb_Benutzer_add.Location = new System.Drawing.Point(3, 118);
            this.lb_Benutzer_add.Margin = new System.Windows.Forms.Padding(3);
            this.lb_Benutzer_add.Name = "lb_Benutzer_add";
            this.lb_Benutzer_add.Size = new System.Drawing.Size(276, 24);
            this.lb_Benutzer_add.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Benutzer_add.TabIndex = 40;
            this.lb_Benutzer_add.Text = "Der Benutzer wurde erfolgreich hinzugefügt!";
            this.lb_Benutzer_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Benutzer_add.Visible = false;
            // 
            // rb_KundeLoeschen
            // 
            this.rb_KundeLoeschen.AutoSize = true;
            this.rb_KundeLoeschen.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_KundeLoeschen.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_KundeLoeschen.Location = new System.Drawing.Point(203, 3);
            this.rb_KundeLoeschen.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.rb_KundeLoeschen.Name = "rb_KundeLoeschen";
            this.rb_KundeLoeschen.Size = new System.Drawing.Size(80, 19);
            this.rb_KundeLoeschen.Style = MetroFramework.MetroColorStyle.Teal;
            this.rb_KundeLoeschen.TabIndex = 2;
            this.rb_KundeLoeschen.Text = "Entfernen";
            this.rb_KundeLoeschen.UseSelectable = true;
            this.rb_KundeLoeschen.CheckedChanged += new System.EventHandler(this.rb_KundeLoeschen_CheckedChanged);
            // 
            // rb_KundeBearbeiten
            // 
            this.rb_KundeBearbeiten.AutoSize = true;
            this.rb_KundeBearbeiten.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_KundeBearbeiten.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_KundeBearbeiten.Location = new System.Drawing.Point(104, 3);
            this.rb_KundeBearbeiten.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.rb_KundeBearbeiten.Name = "rb_KundeBearbeiten";
            this.rb_KundeBearbeiten.Size = new System.Drawing.Size(88, 19);
            this.rb_KundeBearbeiten.Style = MetroFramework.MetroColorStyle.Teal;
            this.rb_KundeBearbeiten.TabIndex = 1;
            this.rb_KundeBearbeiten.Text = "Bearbeiten";
            this.rb_KundeBearbeiten.UseSelectable = true;
            this.rb_KundeBearbeiten.CheckedChanged += new System.EventHandler(this.rb_KundeBearbeiten_CheckedChanged);
            // 
            // rb_Neukunde
            // 
            this.rb_Neukunde.AutoSize = true;
            this.rb_Neukunde.Checked = true;
            this.rb_Neukunde.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.rb_Neukunde.FontWeight = MetroFramework.MetroCheckBoxWeight.Light;
            this.rb_Neukunde.Location = new System.Drawing.Point(3, 3);
            this.rb_Neukunde.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.rb_Neukunde.Name = "rb_Neukunde";
            this.rb_Neukunde.Size = new System.Drawing.Size(90, 19);
            this.rb_Neukunde.Style = MetroFramework.MetroColorStyle.Teal;
            this.rb_Neukunde.TabIndex = 0;
            this.rb_Neukunde.TabStop = true;
            this.rb_Neukunde.Text = "Hinzufügen";
            this.rb_Neukunde.UseSelectable = true;
            this.rb_Neukunde.CheckedChanged += new System.EventHandler(this.rb_Neukunde_CheckedChanged);
            // 
            // gv_Benutzer
            // 
            this.gv_Benutzer.AllowUserToAddRows = false;
            this.gv_Benutzer.AllowUserToDeleteRows = false;
            this.gv_Benutzer.AllowUserToResizeColumns = false;
            this.gv_Benutzer.AllowUserToResizeRows = false;
            this.gv_Benutzer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Benutzer.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Benutzer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Benutzer.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Benutzer.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Benutzer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Benutzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Benutzer.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Benutzer.EnableHeadersVisualStyles = false;
            this.gv_Benutzer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Benutzer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Benutzer.Location = new System.Drawing.Point(317, 63);
            this.gv_Benutzer.MultiSelect = false;
            this.gv_Benutzer.Name = "gv_Benutzer";
            this.gv_Benutzer.ReadOnly = true;
            this.gv_Benutzer.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Benutzer.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Benutzer.RowHeadersVisible = false;
            this.gv_Benutzer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Benutzer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Benutzer.Size = new System.Drawing.Size(272, 142);
            this.gv_Benutzer.Style = MetroFramework.MetroColorStyle.Teal;
            this.gv_Benutzer.TabIndex = 17;
            this.gv_Benutzer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Benutzer_CellDoubleClick);
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_OK.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_OK.Location = new System.Drawing.Point(489, 211);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(100, 24);
            this.bt_OK.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_OK.TabIndex = 8;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseSelectable = true;
            // 
            // mP_Eingaben
            // 
            this.mP_Eingaben.Controls.Add(this.lb_Benutzer_add);
            this.mP_Eingaben.Controls.Add(this.bt_confirm);
            this.mP_Eingaben.Controls.Add(this.rb_Neukunde);
            this.mP_Eingaben.Controls.Add(this.bt_clear);
            this.mP_Eingaben.Controls.Add(this.lb_user);
            this.mP_Eingaben.Controls.Add(this.lb_rechte);
            this.mP_Eingaben.Controls.Add(this.rb_KundeBearbeiten);
            this.mP_Eingaben.Controls.Add(this.lb_pw);
            this.mP_Eingaben.Controls.Add(this.tb_user);
            this.mP_Eingaben.Controls.Add(this.tb_pw);
            this.mP_Eingaben.Controls.Add(this.rb_KundeLoeschen);
            this.mP_Eingaben.Controls.Add(this.cb_Rechte);
            this.mP_Eingaben.HorizontalScrollbarBarColor = true;
            this.mP_Eingaben.HorizontalScrollbarHighlightOnWheel = false;
            this.mP_Eingaben.HorizontalScrollbarSize = 10;
            this.mP_Eingaben.Location = new System.Drawing.Point(23, 63);
            this.mP_Eingaben.Name = "mP_Eingaben";
            this.mP_Eingaben.Size = new System.Drawing.Size(282, 182);
            this.mP_Eingaben.Style = MetroFramework.MetroColorStyle.Teal;
            this.mP_Eingaben.TabIndex = 45;
            this.mP_Eingaben.VerticalScrollbarBarColor = true;
            this.mP_Eingaben.VerticalScrollbarHighlightOnWheel = false;
            this.mP_Eingaben.VerticalScrollbarSize = 10;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cb_Rechte
            // 
            this.cb_Rechte.BorderColor = System.Drawing.Color.Gray;
            this.cb_Rechte.DataRowView = false;
            this.cb_Rechte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Rechte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_Rechte.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cb_Rechte.FormattingEnabled = true;
            this.cb_Rechte.HighlightColor = System.Drawing.Color.Teal;
            this.cb_Rechte.ItemHeight = 18;
            this.cb_Rechte.Items.AddRange(new object[] {
            "Gast",
            "Benutzer",
            "Admin"});
            this.cb_Rechte.Location = new System.Drawing.Point(105, 88);
            this.cb_Rechte.Name = "cb_Rechte";
            this.cb_Rechte.Size = new System.Drawing.Size(175, 24);
            this.cb_Rechte.TabIndex = 5;
            this.metroToolTip1.SetToolTip(this.cb_Rechte, "Hier können Sie die Rechte des Benutzers auswählen/ansehen.");
            // 
            // w_s_user
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(612, 253);
            this.Controls.Add(this.mP_Eingaben);
            this.Controls.Add(this.gv_Benutzer);
            this.Controls.Add(this.bt_OK);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_user";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Benutzerverwaltung";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            ((System.ComponentModel.ISupportInitialize)(this.gv_Benutzer)).EndInit();
            this.mP_Eingaben.ResumeLayout(false);
            this.mP_Eingaben.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lb_pw;
        private MetroFramework.Controls.MetroTextBox tb_user;
        private MetroFramework.Controls.MetroTextBox tb_pw;
        private MetroFramework.Controls.MetroLabel lb_user;
        private MetroFramework.Controls.MetroLabel lb_Benutzer_add;
        private MetroFramework.Controls.MetroButton bt_clear;
        private MetroFramework.Controls.MetroRadioButton rb_KundeLoeschen;
        private MetroFramework.Controls.MetroRadioButton rb_KundeBearbeiten;
        private MetroFramework.Controls.MetroRadioButton rb_Neukunde;
        private MetroFramework.Controls.MetroButton bt_confirm;
        private MetroFramework.Controls.MetroGrid gv_Benutzer;
        private MetroFramework.Controls.MetroButton bt_OK;
        private MetroFramework.Controls.MetroLabel lb_rechte;
        private AdvancedComboBox cb_Rechte;
        private MetroFramework.Controls.MetroPanel mP_Eingaben;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
    }
}