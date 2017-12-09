namespace Bibo_Verwaltung
{
    partial class w_s_rueckgabe
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_Rueckgabe = new System.Windows.Forms.Button();
            this.bt_Zu_aendern = new System.Windows.Forms.Button();
            this.gv_Verlauf = new System.Windows.Forms.DataGridView();
            this.tb_BuchCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_Rueck = new System.Windows.Forms.GroupBox();
            this.lb_rueckgabe = new System.Windows.Forms.Label();
            this.lb_ausgeliehen = new System.Windows.Forms.Label();
            this.llb_Buch = new System.Windows.Forms.LinkLabel();
            this.lb_Buch = new System.Windows.Forms.Label();
            this.llb_Kunde = new System.Windows.Forms.LinkLabel();
            this.cb_Zustand = new System.Windows.Forms.ComboBox();
            this.lb_l_Zustand = new System.Windows.Forms.Label();
            this.lb_AusgeliehenAm = new System.Windows.Forms.Label();
            this.lb_Kunde = new System.Windows.Forms.Label();
            this.lb_RueckFällig = new System.Windows.Forms.Label();
            this.lb_Verlauf = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlauf)).BeginInit();
            this.gb_Rueck.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_Rueckgabe
            // 
            this.bt_Rueckgabe.Location = new System.Drawing.Point(288, 390);
            this.bt_Rueckgabe.Name = "bt_Rueckgabe";
            this.bt_Rueckgabe.Size = new System.Drawing.Size(175, 23);
            this.bt_Rueckgabe.TabIndex = 0;
            this.bt_Rueckgabe.Text = "Buchrückgabe abschließen";
            this.bt_Rueckgabe.UseVisualStyleBackColor = true;
            this.bt_Rueckgabe.Click += new System.EventHandler(this.bt_Rueckgabe_Click);
            // 
            // bt_Zu_aendern
            // 
            this.bt_Zu_aendern.Location = new System.Drawing.Point(257, 148);
            this.bt_Zu_aendern.Name = "bt_Zu_aendern";
            this.bt_Zu_aendern.Size = new System.Drawing.Size(167, 23);
            this.bt_Zu_aendern.TabIndex = 1;
            this.bt_Zu_aendern.Text = "Buchzustand ändern";
            this.bt_Zu_aendern.UseVisualStyleBackColor = true;
            this.bt_Zu_aendern.Click += new System.EventHandler(this.bt_Zu_aendern_Click);
            // 
            // gv_Verlauf
            // 
            this.gv_Verlauf.AllowUserToAddRows = false;
            this.gv_Verlauf.AllowUserToDeleteRows = false;
            this.gv_Verlauf.AllowUserToResizeColumns = false;
            this.gv_Verlauf.AllowUserToResizeRows = false;
            this.gv_Verlauf.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Verlauf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Verlauf.Location = new System.Drawing.Point(6, 198);
            this.gv_Verlauf.MultiSelect = false;
            this.gv_Verlauf.Name = "gv_Verlauf";
            this.gv_Verlauf.ReadOnly = true;
            this.gv_Verlauf.RowHeadersVisible = false;
            this.gv_Verlauf.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Verlauf.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Verlauf.ShowEditingIcon = false;
            this.gv_Verlauf.Size = new System.Drawing.Size(457, 186);
            this.gv_Verlauf.TabIndex = 2;
            // 
            // tb_BuchCode
            // 
            this.tb_BuchCode.Location = new System.Drawing.Point(103, 22);
            this.tb_BuchCode.Name = "tb_BuchCode";
            this.tb_BuchCode.Size = new System.Drawing.Size(148, 20);
            this.tb_BuchCode.TabIndex = 4;
            this.tb_BuchCode.TextChanged += new System.EventHandler(this.tb_BuchCode_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buchlabel-Code:";
            // 
            // gb_Rueck
            // 
            this.gb_Rueck.Controls.Add(this.pictureBox1);
            this.gb_Rueck.Controls.Add(this.lb_rueckgabe);
            this.gb_Rueck.Controls.Add(this.bt_Rueckgabe);
            this.gb_Rueck.Controls.Add(this.lb_ausgeliehen);
            this.gb_Rueck.Controls.Add(this.llb_Buch);
            this.gb_Rueck.Controls.Add(this.lb_Buch);
            this.gb_Rueck.Controls.Add(this.llb_Kunde);
            this.gb_Rueck.Controls.Add(this.cb_Zustand);
            this.gb_Rueck.Controls.Add(this.lb_l_Zustand);
            this.gb_Rueck.Controls.Add(this.lb_AusgeliehenAm);
            this.gb_Rueck.Controls.Add(this.lb_Kunde);
            this.gb_Rueck.Controls.Add(this.lb_RueckFällig);
            this.gb_Rueck.Controls.Add(this.lb_Verlauf);
            this.gb_Rueck.Controls.Add(this.tb_BuchCode);
            this.gb_Rueck.Controls.Add(this.bt_Zu_aendern);
            this.gb_Rueck.Controls.Add(this.gv_Verlauf);
            this.gb_Rueck.Controls.Add(this.label1);
            this.gb_Rueck.Location = new System.Drawing.Point(12, 12);
            this.gb_Rueck.Name = "gb_Rueck";
            this.gb_Rueck.Size = new System.Drawing.Size(469, 419);
            this.gb_Rueck.TabIndex = 6;
            this.gb_Rueck.TabStop = false;
            this.gb_Rueck.Text = "Buchrückgabe:";
            // 
            // lb_rueckgabe
            // 
            this.lb_rueckgabe.AutoSize = true;
            this.lb_rueckgabe.Location = new System.Drawing.Point(100, 125);
            this.lb_rueckgabe.Name = "lb_rueckgabe";
            this.lb_rueckgabe.Size = new System.Drawing.Size(78, 13);
            this.lb_rueckgabe.TabIndex = 22;
            this.lb_rueckgabe.Text = "nicht verfügbar";
            // 
            // lb_ausgeliehen
            // 
            this.lb_ausgeliehen.AutoSize = true;
            this.lb_ausgeliehen.Location = new System.Drawing.Point(100, 100);
            this.lb_ausgeliehen.Name = "lb_ausgeliehen";
            this.lb_ausgeliehen.Size = new System.Drawing.Size(78, 13);
            this.lb_ausgeliehen.TabIndex = 21;
            this.lb_ausgeliehen.Text = "nicht verfügbar";
            // 
            // llb_Buch
            // 
            this.llb_Buch.AutoSize = true;
            this.llb_Buch.Enabled = false;
            this.llb_Buch.Location = new System.Drawing.Point(100, 50);
            this.llb_Buch.Name = "llb_Buch";
            this.llb_Buch.Size = new System.Drawing.Size(67, 13);
            this.llb_Buch.TabIndex = 20;
            this.llb_Buch.TabStop = true;
            this.llb_Buch.Text = "keine Treffer";
            this.llb_Buch.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Buch_LinkClicked);
            // 
            // lb_Buch
            // 
            this.lb_Buch.AutoSize = true;
            this.lb_Buch.Location = new System.Drawing.Point(6, 50);
            this.lb_Buch.Name = "lb_Buch";
            this.lb_Buch.Size = new System.Drawing.Size(83, 13);
            this.lb_Buch.TabIndex = 19;
            this.lb_Buch.Text = "Buch gefunden:";
            // 
            // llb_Kunde
            // 
            this.llb_Kunde.AutoSize = true;
            this.llb_Kunde.Enabled = false;
            this.llb_Kunde.Location = new System.Drawing.Point(100, 75);
            this.llb_Kunde.Name = "llb_Kunde";
            this.llb_Kunde.Size = new System.Drawing.Size(76, 13);
            this.llb_Kunde.TabIndex = 18;
            this.llb_Kunde.TabStop = true;
            this.llb_Kunde.Text = "nicht verleihen";
            this.llb_Kunde.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_Kunde_LinkClicked);
            // 
            // cb_Zustand
            // 
            this.cb_Zustand.Enabled = false;
            this.cb_Zustand.FormattingEnabled = true;
            this.cb_Zustand.Location = new System.Drawing.Point(103, 150);
            this.cb_Zustand.Name = "cb_Zustand";
            this.cb_Zustand.Size = new System.Drawing.Size(148, 21);
            this.cb_Zustand.TabIndex = 17;
            // 
            // lb_l_Zustand
            // 
            this.lb_l_Zustand.AutoSize = true;
            this.lb_l_Zustand.Location = new System.Drawing.Point(6, 153);
            this.lb_l_Zustand.Name = "lb_l_Zustand";
            this.lb_l_Zustand.Size = new System.Drawing.Size(80, 13);
            this.lb_l_Zustand.TabIndex = 15;
            this.lb_l_Zustand.Text = "letzter Zustand:";
            // 
            // lb_AusgeliehenAm
            // 
            this.lb_AusgeliehenAm.AutoSize = true;
            this.lb_AusgeliehenAm.Location = new System.Drawing.Point(6, 100);
            this.lb_AusgeliehenAm.Name = "lb_AusgeliehenAm";
            this.lb_AusgeliehenAm.Size = new System.Drawing.Size(86, 13);
            this.lb_AusgeliehenAm.TabIndex = 10;
            this.lb_AusgeliehenAm.Text = "ausgeliehen seit:";
            // 
            // lb_Kunde
            // 
            this.lb_Kunde.AutoSize = true;
            this.lb_Kunde.Location = new System.Drawing.Point(6, 75);
            this.lb_Kunde.Name = "lb_Kunde";
            this.lb_Kunde.Size = new System.Drawing.Size(88, 13);
            this.lb_Kunde.TabIndex = 8;
            this.lb_Kunde.Text = "ausgeliehen von:";
            // 
            // lb_RueckFällig
            // 
            this.lb_RueckFällig.AutoSize = true;
            this.lb_RueckFällig.Location = new System.Drawing.Point(6, 125);
            this.lb_RueckFällig.Name = "lb_RueckFällig";
            this.lb_RueckFällig.Size = new System.Drawing.Size(84, 13);
            this.lb_RueckFällig.TabIndex = 7;
            this.lb_RueckFällig.Text = "Rückgabe fällig:";
            // 
            // lb_Verlauf
            // 
            this.lb_Verlauf.AutoSize = true;
            this.lb_Verlauf.Location = new System.Drawing.Point(6, 182);
            this.lb_Verlauf.Name = "lb_Verlauf";
            this.lb_Verlauf.Size = new System.Drawing.Size(76, 13);
            this.lb_Verlauf.TabIndex = 6;
            this.lb_Verlauf.Text = "Ausleihverlauf:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(257, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // w_s_rueckgabe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 443);
            this.Controls.Add(this.gb_Rueck);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_rueckgabe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Buchrückgabe";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlauf)).EndInit();
            this.gb_Rueck.ResumeLayout(false);
            this.gb_Rueck.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Rueckgabe;
        private System.Windows.Forms.Button bt_Zu_aendern;
        private System.Windows.Forms.DataGridView gv_Verlauf;
        private System.Windows.Forms.TextBox tb_BuchCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gb_Rueck;
        private System.Windows.Forms.Label lb_AusgeliehenAm;
        private System.Windows.Forms.Label lb_Kunde;
        private System.Windows.Forms.Label lb_RueckFällig;
        private System.Windows.Forms.Label lb_Verlauf;
        private System.Windows.Forms.Label lb_l_Zustand;
        private System.Windows.Forms.ComboBox cb_Zustand;
        private System.Windows.Forms.LinkLabel llb_Kunde;
        private System.Windows.Forms.LinkLabel llb_Buch;
        private System.Windows.Forms.Label lb_Buch;
        private System.Windows.Forms.Label lb_rueckgabe;
        private System.Windows.Forms.Label lb_ausgeliehen;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

