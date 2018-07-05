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
            this.lb_User = new System.Windows.Forms.Label();
            this.lb_Passw = new System.Windows.Forms.Label();
            this.tb_User = new System.Windows.Forms.TextBox();
            this.tb_Passw = new System.Windows.Forms.TextBox();
            this.gb_Login = new System.Windows.Forms.GroupBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.gb_Login.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_User
            // 
            this.lb_User.AutoSize = true;
            this.lb_User.Location = new System.Drawing.Point(6, 40);
            this.lb_User.Name = "lb_User";
            this.lb_User.Size = new System.Drawing.Size(78, 13);
            this.lb_User.TabIndex = 0;
            this.lb_User.Text = "Benutzername:";
            // 
            // lb_Passw
            // 
            this.lb_Passw.AutoSize = true;
            this.lb_Passw.Location = new System.Drawing.Point(6, 80);
            this.lb_Passw.Name = "lb_Passw";
            this.lb_Passw.Size = new System.Drawing.Size(53, 13);
            this.lb_Passw.TabIndex = 1;
            this.lb_Passw.Text = "Passwort:";
            // 
            // tb_User
            // 
            this.tb_User.Location = new System.Drawing.Point(90, 37);
            this.tb_User.Name = "tb_User";
            this.tb_User.Size = new System.Drawing.Size(200, 20);
            this.tb_User.TabIndex = 2;
            // 
            // tb_Passw
            // 
            this.tb_Passw.Location = new System.Drawing.Point(90, 77);
            this.tb_Passw.Name = "tb_Passw";
            this.tb_Passw.Size = new System.Drawing.Size(200, 20);
            this.tb_Passw.TabIndex = 3;
            this.tb_Passw.UseSystemPasswordChar = true;
            this.tb_Passw.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Passw_KeyDown);
            // 
            // gb_Login
            // 
            this.gb_Login.Controls.Add(this.bt_Login);
            this.gb_Login.Controls.Add(this.lb_User);
            this.gb_Login.Controls.Add(this.tb_Passw);
            this.gb_Login.Controls.Add(this.lb_Passw);
            this.gb_Login.Controls.Add(this.tb_User);
            this.gb_Login.Location = new System.Drawing.Point(12, 12);
            this.gb_Login.Name = "gb_Login";
            this.gb_Login.Size = new System.Drawing.Size(300, 132);
            this.gb_Login.TabIndex = 4;
            this.gb_Login.TabStop = false;
            this.gb_Login.Text = "Bitte geben Sie ihre Login-Daten ein:";
            // 
            // bt_Login
            // 
            this.bt_Login.Location = new System.Drawing.Point(190, 103);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(100, 23);
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = true;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // w_s_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 156);
            this.Controls.Add(this.gb_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "w_s_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.gb_Login.ResumeLayout(false);
            this.gb_Login.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_User;
        private System.Windows.Forms.Label lb_Passw;
        private System.Windows.Forms.TextBox tb_User;
        private System.Windows.Forms.TextBox tb_Passw;
        private System.Windows.Forms.GroupBox gb_Login;
        private System.Windows.Forms.Button bt_Login;
    }
}