namespace Bibo_Verwaltung
{
    partial class w_s_login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_login));
            this.tb_User = new MetroFramework.Controls.MetroTextBox();
            this.tb_Password = new MetroFramework.Controls.MetroTextBox();
            this.bt_Login = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.metroToolTip1 = new MetroFramework.Components.MetroToolTip();
            this.msm_login = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.msm_login)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_User
            // 
            // 
            // 
            // 
            this.tb_User.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User.CustomButton.Image = null;
            this.tb_User.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.tb_User.CustomButton.Name = "";
            this.tb_User.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_User.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_User.CustomButton.TabIndex = 1;
            this.tb_User.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_User.CustomButton.UseSelectable = true;
            this.tb_User.CustomButton.Visible = false;
            this.tb_User.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_User.Lines = new string[0];
            this.tb_User.Location = new System.Drawing.Point(23, 60);
            this.tb_User.MaxLength = 32767;
            this.tb_User.Name = "tb_User";
            this.tb_User.PasswordChar = '\0';
            this.tb_User.PromptText = "Benutzername";
            this.tb_User.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_User.SelectedText = "";
            this.tb_User.SelectionLength = 0;
            this.tb_User.SelectionStart = 0;
            this.tb_User.ShortcutsEnabled = true;
            this.tb_User.ShowClearButton = true;
            this.tb_User.Size = new System.Drawing.Size(224, 24);
            this.tb_User.Style = MetroFramework.MetroColorStyle.Black;
            this.tb_User.TabIndex = 2;
            this.metroToolTip1.SetToolTip(this.tb_User, "Geben Sie hier Ihren Benutzernamen ein.");
            this.tb_User.UseSelectable = true;
            this.tb_User.WaterMark = "Benutzername";
            this.tb_User.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_User.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tb_Password
            // 
            // 
            // 
            // 
            this.tb_Password.CustomButton.Image = null;
            this.tb_Password.CustomButton.Location = new System.Drawing.Point(202, 2);
            this.tb_Password.CustomButton.Name = "";
            this.tb_Password.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Password.CustomButton.TabIndex = 1;
            this.tb_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Password.CustomButton.UseSelectable = true;
            this.tb_Password.CustomButton.Visible = false;
            this.tb_Password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_Password.Lines = new string[0];
            this.tb_Password.Location = new System.Drawing.Point(23, 90);
            this.tb_Password.MaxLength = 32767;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '●';
            this.tb_Password.PromptText = "Passwort";
            this.tb_Password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Password.SelectedText = "";
            this.tb_Password.SelectionLength = 0;
            this.tb_Password.SelectionStart = 0;
            this.tb_Password.ShortcutsEnabled = true;
            this.tb_Password.ShowClearButton = true;
            this.tb_Password.Size = new System.Drawing.Size(224, 24);
            this.tb_Password.Style = MetroFramework.MetroColorStyle.Black;
            this.tb_Password.TabIndex = 3;
            this.metroToolTip1.SetToolTip(this.tb_Password, "Geben Sie hier Ihr Passwort ein.");
            this.tb_Password.UseSelectable = true;
            this.tb_Password.UseSystemPasswordChar = true;
            this.tb_Password.WaterMark = "Passwort";
            this.tb_Password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Password_KeyDown);
            // 
            // bt_Login
            // 
            this.bt_Login.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Login.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.bt_Login.Location = new System.Drawing.Point(23, 120);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(224, 24);
            this.bt_Login.Style = MetroFramework.MetroColorStyle.Black;
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "Login";
            this.metroToolTip1.SetToolTip(this.bt_Login, "Loggen Sie sich hier mit Ihren eingegebenen Daten ein.");
            this.bt_Login.UseSelectable = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.metroProgressBar1.Margin = new System.Windows.Forms.Padding(2);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(270, 5);
            this.metroProgressBar1.Step = 1;
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroProgressBar1.TabIndex = 6;
            // 
            // metroToolTip1
            // 
            this.metroToolTip1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip1.StyleManager = null;
            this.metroToolTip1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // msm_login
            // 
            this.msm_login.Owner = this;
            this.msm_login.Style = MetroFramework.MetroColorStyle.Black;
            // 
            // metroLink1
            // 
            this.metroLink1.Image = global::Bibo_Verwaltung.Properties.Resources.Lock32;
            this.metroLink1.ImageSize = 24;
            this.metroLink1.Location = new System.Drawing.Point(23, 25);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(2);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(22, 24);
            this.metroLink1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroLink1.TabIndex = 5;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.MetroLink1_Click);
            // 
            // w_s_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(270, 167);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_User);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_login";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "     Login";
            ((System.ComponentModel.ISupportInitialize)(this.msm_login)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tb_User;
        private MetroFramework.Controls.MetroTextBox tb_Password;
        private MetroFramework.Controls.MetroButton bt_Login;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
        private MetroFramework.Components.MetroToolTip metroToolTip1;
        private MetroFramework.Components.MetroStyleManager msm_login;
    }
}