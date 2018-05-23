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
            this.gb_user = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lb_rechte = new System.Windows.Forms.Label();
            this.lb_pw = new System.Windows.Forms.Label();
            this.bt_clear = new System.Windows.Forms.Button();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.lb_user = new System.Windows.Forms.Label();
            this.cb_Rechte = new System.Windows.Forms.ComboBox();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.lb_Benutzer_add = new System.Windows.Forms.Label();
            this.rb_KundeLoeschen = new System.Windows.Forms.RadioButton();
            this.rb_KundeBearbeiten = new System.Windows.Forms.RadioButton();
            this.rb_Neukunde = new System.Windows.Forms.RadioButton();
            this.gv_Benutzer = new System.Windows.Forms.DataGridView();
            this.bt_OK = new System.Windows.Forms.Button();
            this.gb_user.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Benutzer)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_user
            // 
            this.gb_user.Controls.Add(this.tableLayoutPanel1);
            this.gb_user.Controls.Add(this.lb_Benutzer_add);
            this.gb_user.Controls.Add(this.rb_KundeLoeschen);
            this.gb_user.Controls.Add(this.rb_KundeBearbeiten);
            this.gb_user.Controls.Add(this.rb_Neukunde);
            this.gb_user.Location = new System.Drawing.Point(32, 29);
            this.gb_user.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_user.Name = "gb_user";
            this.gb_user.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_user.Size = new System.Drawing.Size(768, 594);
            this.gb_user.TabIndex = 16;
            this.gb_user.TabStop = false;
            this.gb_user.Text = "Benutzer";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanel1.Controls.Add(this.lb_rechte, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lb_pw, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_clear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_user, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_pw, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_user, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Rechte, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_confirm, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(19, 100);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(720, 405);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // lb_rechte
            // 
            this.lb_rechte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_rechte.AutoSize = true;
            this.lb_rechte.Location = new System.Drawing.Point(8, 236);
            this.lb_rechte.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_rechte.Name = "lb_rechte";
            this.lb_rechte.Size = new System.Drawing.Size(236, 32);
            this.lb_rechte.TabIndex = 43;
            this.lb_rechte.Text = "Rechte:";
            // 
            // lb_pw
            // 
            this.lb_pw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_pw.AutoSize = true;
            this.lb_pw.Location = new System.Drawing.Point(8, 135);
            this.lb_pw.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_pw.Name = "lb_pw";
            this.lb_pw.Size = new System.Drawing.Size(236, 32);
            this.lb_pw.TabIndex = 21;
            this.lb_pw.Text = "Passwort:";
            // 
            // bt_clear
            // 
            this.bt_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_clear.Location = new System.Drawing.Point(11, 325);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(230, 57);
            this.bt_clear.TabIndex = 14;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // tb_user
            // 
            this.tb_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_user.Location = new System.Drawing.Point(263, 31);
            this.tb_user.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(446, 38);
            this.tb_user.TabIndex = 3;
            // 
            // tb_pw
            // 
            this.tb_pw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_pw.Location = new System.Drawing.Point(263, 132);
            this.tb_pw.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(446, 38);
            this.tb_pw.TabIndex = 1;
            this.tb_pw.UseSystemPasswordChar = true;
            // 
            // lb_user
            // 
            this.lb_user.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_user.AutoSize = true;
            this.lb_user.Location = new System.Drawing.Point(8, 34);
            this.lb_user.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_user.Name = "lb_user";
            this.lb_user.Size = new System.Drawing.Size(236, 32);
            this.lb_user.TabIndex = 0;
            this.lb_user.Text = "Benutzername:";
            // 
            // cb_Rechte
            // 
            this.cb_Rechte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Rechte.FormattingEnabled = true;
            this.cb_Rechte.Items.AddRange(new object[] {
            "Gast",
            "Benutzer",
            "Admin"});
            this.cb_Rechte.Location = new System.Drawing.Point(260, 233);
            this.cb_Rechte.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.cb_Rechte.Name = "cb_Rechte";
            this.cb_Rechte.Size = new System.Drawing.Size(452, 39);
            this.cb_Rechte.TabIndex = 44;
            // 
            // bt_confirm
            // 
            this.bt_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_confirm.Location = new System.Drawing.Point(263, 325);
            this.bt_confirm.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(446, 57);
            this.bt_confirm.TabIndex = 13;
            this.bt_confirm.Text = "Speichern";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.bt_confirm_Click);
            // 
            // lb_Benutzer_add
            // 
            this.lb_Benutzer_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Benutzer_add.Location = new System.Drawing.Point(11, 534);
            this.lb_Benutzer_add.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Benutzer_add.Name = "lb_Benutzer_add";
            this.lb_Benutzer_add.Size = new System.Drawing.Size(720, 31);
            this.lb_Benutzer_add.TabIndex = 40;
            this.lb_Benutzer_add.Text = "Der Benutzer wurde erfolgreich hinzugefügt!";
            this.lb_Benutzer_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Benutzer_add.Visible = false;
            // 
            // rb_KundeLoeschen
            // 
            this.rb_KundeLoeschen.AutoSize = true;
            this.rb_KundeLoeschen.Location = new System.Drawing.Point(563, 45);
            this.rb_KundeLoeschen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rb_KundeLoeschen.Name = "rb_KundeLoeschen";
            this.rb_KundeLoeschen.Size = new System.Drawing.Size(176, 36);
            this.rb_KundeLoeschen.TabIndex = 0;
            this.rb_KundeLoeschen.Text = "Entfernen";
            this.rb_KundeLoeschen.UseVisualStyleBackColor = true;
            this.rb_KundeLoeschen.CheckedChanged += new System.EventHandler(this.rb_KundeLoeschen_CheckedChanged);
            // 
            // rb_KundeBearbeiten
            // 
            this.rb_KundeBearbeiten.AutoSize = true;
            this.rb_KundeBearbeiten.Location = new System.Drawing.Point(304, 45);
            this.rb_KundeBearbeiten.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rb_KundeBearbeiten.Name = "rb_KundeBearbeiten";
            this.rb_KundeBearbeiten.Size = new System.Drawing.Size(191, 36);
            this.rb_KundeBearbeiten.TabIndex = 0;
            this.rb_KundeBearbeiten.Text = "Bearbeiten";
            this.rb_KundeBearbeiten.UseVisualStyleBackColor = true;
            this.rb_KundeBearbeiten.CheckedChanged += new System.EventHandler(this.rb_KundeBearbeiten_CheckedChanged);
            // 
            // rb_Neukunde
            // 
            this.rb_Neukunde.AutoSize = true;
            this.rb_Neukunde.Checked = true;
            this.rb_Neukunde.Location = new System.Drawing.Point(35, 45);
            this.rb_Neukunde.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.rb_Neukunde.Name = "rb_Neukunde";
            this.rb_Neukunde.Size = new System.Drawing.Size(197, 36);
            this.rb_Neukunde.TabIndex = 0;
            this.rb_Neukunde.TabStop = true;
            this.rb_Neukunde.Text = "Hinzufügen";
            this.rb_Neukunde.UseVisualStyleBackColor = true;
            this.rb_Neukunde.CheckedChanged += new System.EventHandler(this.rb_Neukunde_CheckedChanged);
            // 
            // gv_Benutzer
            // 
            this.gv_Benutzer.AllowUserToAddRows = false;
            this.gv_Benutzer.AllowUserToDeleteRows = false;
            this.gv_Benutzer.AllowUserToResizeColumns = false;
            this.gv_Benutzer.AllowUserToResizeRows = false;
            this.gv_Benutzer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_Benutzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Benutzer.Location = new System.Drawing.Point(827, 45);
            this.gv_Benutzer.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.gv_Benutzer.MultiSelect = false;
            this.gv_Benutzer.Name = "gv_Benutzer";
            this.gv_Benutzer.ReadOnly = true;
            this.gv_Benutzer.RowHeadersVisible = false;
            this.gv_Benutzer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Benutzer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Benutzer.Size = new System.Drawing.Size(1400, 501);
            this.gv_Benutzer.TabIndex = 17;
            this.gv_Benutzer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Benutzer_CellDoubleClick);
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(1907, 568);
            this.bt_OK.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(320, 55);
            this.bt_OK.TabIndex = 18;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // w_s_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2259, 641);
            this.Controls.Add(this.gb_user);
            this.Controls.Add(this.gv_Benutzer);
            this.Controls.Add(this.bt_OK);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "w_s_user";
            this.Text = "Benutzerverwaltung";
            this.gb_user.ResumeLayout(false);
            this.gb_user.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Benutzer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_user;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lb_pw;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.Label lb_user;
        private System.Windows.Forms.Label lb_Benutzer_add;
        private System.Windows.Forms.Button bt_clear;
        private System.Windows.Forms.RadioButton rb_KundeLoeschen;
        private System.Windows.Forms.RadioButton rb_KundeBearbeiten;
        private System.Windows.Forms.RadioButton rb_Neukunde;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.DataGridView gv_Benutzer;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.Label lb_rechte;
        private System.Windows.Forms.ComboBox cb_Rechte;
    }
}