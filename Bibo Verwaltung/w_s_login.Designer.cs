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
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroProgressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.SuspendLayout();
            // 
            // tb_User
            // 
            // 
            // 
            // 
            this.tb_User.CustomButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User.CustomButton.Image = null;
            this.tb_User.CustomButton.Location = new System.Drawing.Point(239, 2);
            this.tb_User.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tb_User.CustomButton.Name = "";
            this.tb_User.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tb_User.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_User.CustomButton.TabIndex = 1;
            this.tb_User.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_User.CustomButton.UseSelectable = true;
            this.tb_User.CustomButton.Visible = false;
            this.tb_User.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_User.Lines = new string[0];
            this.tb_User.Location = new System.Drawing.Point(31, 60);
            this.tb_User.Margin = new System.Windows.Forms.Padding(4);
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
            this.tb_User.Size = new System.Drawing.Size(267, 30);
            this.tb_User.TabIndex = 2;
            this.tb_User.Theme = MetroFramework.MetroThemeStyle.Light;
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
            this.tb_Password.CustomButton.Location = new System.Drawing.Point(239, 2);
            this.tb_Password.CustomButton.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Password.CustomButton.Name = "";
            this.tb_Password.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tb_Password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Password.CustomButton.TabIndex = 1;
            this.tb_Password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Password.CustomButton.UseSelectable = true;
            this.tb_Password.CustomButton.Visible = false;
            this.tb_Password.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.tb_Password.Lines = new string[0];
            this.tb_Password.Location = new System.Drawing.Point(31, 98);
            this.tb_Password.Margin = new System.Windows.Forms.Padding(4);
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
            this.tb_Password.Size = new System.Drawing.Size(267, 30);
            this.tb_Password.TabIndex = 3;
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
            this.bt_Login.Location = new System.Drawing.Point(31, 136);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(267, 30);
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseSelectable = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Image = global::Bibo_Verwaltung.Properties.Resources.Login;
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(26, 24);
            this.metroLink1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.Size = new System.Drawing.Size(29, 30);
            this.metroLink1.TabIndex = 5;
            this.metroLink1.UseSelectable = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // metroProgressBar1
            // 
            this.metroProgressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.metroProgressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroProgressBar1.Name = "metroProgressBar1";
            this.metroProgressBar1.ProgressBarStyle = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.metroProgressBar1.Size = new System.Drawing.Size(328, 6);
            this.metroProgressBar1.Step = 1;
            this.metroProgressBar1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroProgressBar1.TabIndex = 6;
            // 
            // w_s_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 190);
            this.Controls.Add(this.metroProgressBar1);
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_User);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "w_s_login";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Resizable = false;
            this.Text = "     Login";
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tb_User;
        private MetroFramework.Controls.MetroTextBox tb_Password;
        private MetroFramework.Controls.MetroButton bt_Login;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBar1;
    }
}