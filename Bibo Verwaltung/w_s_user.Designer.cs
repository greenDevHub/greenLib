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
            this.lb_Vorname = new System.Windows.Forms.Label();
            this.tb_KundenID = new System.Windows.Forms.TextBox();
            this.tb_Vorname = new System.Windows.Forms.TextBox();
            this.lb_BenutzerID = new System.Windows.Forms.Label();
            this.lb_Benutzer_add = new System.Windows.Forms.Label();
            this.bt_clear = new System.Windows.Forms.Button();
            this.rb_KundeLoeschen = new System.Windows.Forms.RadioButton();
            this.rb_KundeBearbeiten = new System.Windows.Forms.RadioButton();
            this.rb_Neukunde = new System.Windows.Forms.RadioButton();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.gv_Benutzer = new System.Windows.Forms.DataGridView();
            this.bt_OK = new System.Windows.Forms.Button();
            this.lb_rechte = new System.Windows.Forms.Label();
            this.cb_Rechte = new System.Windows.Forms.ComboBox();
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
            this.gb_user.Location = new System.Drawing.Point(12, 12);
            this.gb_user.Name = "gb_user";
            this.gb_user.Size = new System.Drawing.Size(288, 249);
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
            this.tableLayoutPanel1.Controls.Add(this.lb_Vorname, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.bt_clear, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_KundenID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_Vorname, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lb_BenutzerID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cb_Rechte, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_confirm, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 42);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(270, 170);
            this.tableLayoutPanel1.TabIndex = 42;
            // 
            // lb_Vorname
            // 
            this.lb_Vorname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Vorname.AutoSize = true;
            this.lb_Vorname.Location = new System.Drawing.Point(3, 56);
            this.lb_Vorname.Name = "lb_Vorname";
            this.lb_Vorname.Size = new System.Drawing.Size(88, 13);
            this.lb_Vorname.TabIndex = 21;
            this.lb_Vorname.Text = "Passwort:";
            // 
            // tb_KundenID
            // 
            this.tb_KundenID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_KundenID.Location = new System.Drawing.Point(98, 11);
            this.tb_KundenID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_KundenID.Name = "tb_KundenID";
            this.tb_KundenID.Size = new System.Drawing.Size(168, 20);
            this.tb_KundenID.TabIndex = 3;
            // 
            // tb_Vorname
            // 
            this.tb_Vorname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Vorname.Location = new System.Drawing.Point(98, 53);
            this.tb_Vorname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tb_Vorname.Name = "tb_Vorname";
            this.tb_Vorname.Size = new System.Drawing.Size(168, 20);
            this.tb_Vorname.TabIndex = 1;
            // 
            // lb_BenutzerID
            // 
            this.lb_BenutzerID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_BenutzerID.AutoSize = true;
            this.lb_BenutzerID.Location = new System.Drawing.Point(3, 14);
            this.lb_BenutzerID.Name = "lb_BenutzerID";
            this.lb_BenutzerID.Size = new System.Drawing.Size(88, 13);
            this.lb_BenutzerID.TabIndex = 0;
            this.lb_BenutzerID.Text = "Benutzername:";
            // 
            // lb_Benutzer_add
            // 
            this.lb_Benutzer_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Benutzer_add.Location = new System.Drawing.Point(4, 224);
            this.lb_Benutzer_add.Name = "lb_Benutzer_add";
            this.lb_Benutzer_add.Size = new System.Drawing.Size(270, 13);
            this.lb_Benutzer_add.TabIndex = 40;
            this.lb_Benutzer_add.Text = "Der Benutzer wurde erfolgreich hinzugefügt!";
            this.lb_Benutzer_add.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_Benutzer_add.Visible = false;
            // 
            // bt_clear
            // 
            this.bt_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_clear.Location = new System.Drawing.Point(4, 136);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(86, 24);
            this.bt_clear.TabIndex = 14;
            this.bt_clear.Text = "Leeren";
            this.bt_clear.UseVisualStyleBackColor = true;
            // 
            // rb_KundeLoeschen
            // 
            this.rb_KundeLoeschen.AutoSize = true;
            this.rb_KundeLoeschen.Location = new System.Drawing.Point(211, 19);
            this.rb_KundeLoeschen.Name = "rb_KundeLoeschen";
            this.rb_KundeLoeschen.Size = new System.Drawing.Size(71, 17);
            this.rb_KundeLoeschen.TabIndex = 0;
            this.rb_KundeLoeschen.Text = "Entfernen";
            this.rb_KundeLoeschen.UseVisualStyleBackColor = true;
            // 
            // rb_KundeBearbeiten
            // 
            this.rb_KundeBearbeiten.AutoSize = true;
            this.rb_KundeBearbeiten.Location = new System.Drawing.Point(114, 19);
            this.rb_KundeBearbeiten.Name = "rb_KundeBearbeiten";
            this.rb_KundeBearbeiten.Size = new System.Drawing.Size(76, 17);
            this.rb_KundeBearbeiten.TabIndex = 0;
            this.rb_KundeBearbeiten.Text = "Bearbeiten";
            this.rb_KundeBearbeiten.UseVisualStyleBackColor = true;
            // 
            // rb_Neukunde
            // 
            this.rb_Neukunde.AutoSize = true;
            this.rb_Neukunde.Checked = true;
            this.rb_Neukunde.Location = new System.Drawing.Point(13, 19);
            this.rb_Neukunde.Name = "rb_Neukunde";
            this.rb_Neukunde.Size = new System.Drawing.Size(79, 17);
            this.rb_Neukunde.TabIndex = 0;
            this.rb_Neukunde.TabStop = true;
            this.rb_Neukunde.Text = "Hinzufügen";
            this.rb_Neukunde.UseVisualStyleBackColor = true;
            // 
            // bt_confirm
            // 
            this.bt_confirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_confirm.Location = new System.Drawing.Point(98, 136);
            this.bt_confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(168, 24);
            this.bt_confirm.TabIndex = 13;
            this.bt_confirm.Text = "Speichern";
            this.bt_confirm.UseVisualStyleBackColor = true;
            // 
            // gv_Benutzer
            // 
            this.gv_Benutzer.AllowUserToAddRows = false;
            this.gv_Benutzer.AllowUserToDeleteRows = false;
            this.gv_Benutzer.AllowUserToResizeColumns = false;
            this.gv_Benutzer.AllowUserToResizeRows = false;
            this.gv_Benutzer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_Benutzer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Benutzer.Location = new System.Drawing.Point(310, 19);
            this.gv_Benutzer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.gv_Benutzer.MultiSelect = false;
            this.gv_Benutzer.Name = "gv_Benutzer";
            this.gv_Benutzer.ReadOnly = true;
            this.gv_Benutzer.RowHeadersVisible = false;
            this.gv_Benutzer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Benutzer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Benutzer.Size = new System.Drawing.Size(525, 210);
            this.gv_Benutzer.TabIndex = 17;
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(715, 238);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(120, 23);
            this.bt_OK.TabIndex = 18;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // lb_rechte
            // 
            this.lb_rechte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_rechte.AutoSize = true;
            this.lb_rechte.Location = new System.Drawing.Point(3, 98);
            this.lb_rechte.Name = "lb_rechte";
            this.lb_rechte.Size = new System.Drawing.Size(88, 13);
            this.lb_rechte.TabIndex = 43;
            this.lb_rechte.Text = "Rechte:";
            // 
            // cb_Rechte
            // 
            this.cb_Rechte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_Rechte.FormattingEnabled = true;
            this.cb_Rechte.Location = new System.Drawing.Point(97, 94);
            this.cb_Rechte.Name = "cb_Rechte";
            this.cb_Rechte.Size = new System.Drawing.Size(170, 21);
            this.cb_Rechte.TabIndex = 44;
            // 
            // w_s_user
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 269);
            this.Controls.Add(this.gb_user);
            this.Controls.Add(this.gv_Benutzer);
            this.Controls.Add(this.bt_OK);
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
        private System.Windows.Forms.Label lb_Vorname;
        private System.Windows.Forms.TextBox tb_KundenID;
        private System.Windows.Forms.TextBox tb_Vorname;
        private System.Windows.Forms.Label lb_BenutzerID;
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