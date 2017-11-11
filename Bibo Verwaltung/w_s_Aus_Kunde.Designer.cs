namespace Bibo_Verwaltung
{
    partial class w_s_Aus_Kunde
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
            this.gv_Aus_Kunde = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bt_Ausweahlen = new System.Windows.Forms.Button();
            this.bt_Abbrechen = new System.Windows.Forms.Button();
            this.bt_NeuKunde = new System.Windows.Forms.Button();
            this.tb_vorname = new System.Windows.Forms.TextBox();
            this.tb_nachname = new System.Windows.Forms.TextBox();
            this.lb_Vorname = new System.Windows.Forms.Label();
            this.lb_nachname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Aus_Kunde)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Aus_Kunde
            // 
            this.gv_Aus_Kunde.AllowUserToAddRows = false;
            this.gv_Aus_Kunde.AllowUserToDeleteRows = false;
            this.gv_Aus_Kunde.AllowUserToResizeColumns = false;
            this.gv_Aus_Kunde.AllowUserToResizeRows = false;
            this.gv_Aus_Kunde.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_Aus_Kunde.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Aus_Kunde.Cursor = System.Windows.Forms.Cursors.Default;
            this.gv_Aus_Kunde.Location = new System.Drawing.Point(32, 99);
            this.gv_Aus_Kunde.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gv_Aus_Kunde.MultiSelect = false;
            this.gv_Aus_Kunde.Name = "gv_Aus_Kunde";
            this.gv_Aus_Kunde.ReadOnly = true;
            this.gv_Aus_Kunde.RowHeadersVisible = false;
            this.gv_Aus_Kunde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Aus_Kunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Aus_Kunde.ShowEditingIcon = false;
            this.gv_Aus_Kunde.Size = new System.Drawing.Size(1699, 605);
            this.gv_Aus_Kunde.TabIndex = 0;
            // 
            // bt_Ausweahlen
            // 
            this.bt_Ausweahlen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Ausweahlen.Location = new System.Drawing.Point(1181, 718);
            this.bt_Ausweahlen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Ausweahlen.Name = "bt_Ausweahlen";
            this.bt_Ausweahlen.Size = new System.Drawing.Size(267, 55);
            this.bt_Ausweahlen.TabIndex = 1;
            this.bt_Ausweahlen.Text = "OK";
            this.bt_Ausweahlen.UseVisualStyleBackColor = true;
            this.bt_Ausweahlen.Click += new System.EventHandler(this.bt_Ausweahlen_Click);
            // 
            // bt_Abbrechen
            // 
            this.bt_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Abbrechen.Location = new System.Drawing.Point(1464, 718);
            this.bt_Abbrechen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Abbrechen.Name = "bt_Abbrechen";
            this.bt_Abbrechen.Size = new System.Drawing.Size(267, 55);
            this.bt_Abbrechen.TabIndex = 2;
            this.bt_Abbrechen.Text = "Abbrechen";
            this.bt_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // bt_NeuKunde
            // 
            this.bt_NeuKunde.Location = new System.Drawing.Point(32, 718);
            this.bt_NeuKunde.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_NeuKunde.Name = "bt_NeuKunde";
            this.bt_NeuKunde.Size = new System.Drawing.Size(400, 55);
            this.bt_NeuKunde.TabIndex = 4;
            this.bt_NeuKunde.Text = "Neuen Kunden hinzufügen";
            this.bt_NeuKunde.UseVisualStyleBackColor = true;
            this.bt_NeuKunde.Click += new System.EventHandler(this.bt_NeuKunde_Click);
            // 
            // tb_vorname
            // 
            this.tb_vorname.ForeColor = System.Drawing.Color.Black;
            this.tb_vorname.Location = new System.Drawing.Point(230, 39);
            this.tb_vorname.Name = "tb_vorname";
            this.tb_vorname.Size = new System.Drawing.Size(267, 38);
            this.tb_vorname.TabIndex = 5;
            this.tb_vorname.Click += new System.EventHandler(this.tb_vorname_Click);
            this.tb_vorname.TextChanged += new System.EventHandler(this.tb_vorname_TextChanged);
            this.tb_vorname.Leave += new System.EventHandler(this.tb_vorname_Leave);
            // 
            // tb_nachname
            // 
            this.tb_nachname.ForeColor = System.Drawing.Color.Black;
            this.tb_nachname.Location = new System.Drawing.Point(508, 39);
            this.tb_nachname.Margin = new System.Windows.Forms.Padding(8);
            this.tb_nachname.Name = "tb_nachname";
            this.tb_nachname.Size = new System.Drawing.Size(267, 38);
            this.tb_nachname.TabIndex = 6;
            this.tb_nachname.Click += new System.EventHandler(this.tb_nachname_Click);
            this.tb_nachname.TextChanged += new System.EventHandler(this.tb_nachname_TextChanged);
            this.tb_nachname.Leave += new System.EventHandler(this.tb_nachname_Leave);
            // 
            // lb_Vorname
            // 
            this.lb_Vorname.AutoSize = true;
            this.lb_Vorname.BackColor = System.Drawing.Color.White;
            this.lb_Vorname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_Vorname.ForeColor = System.Drawing.Color.Gray;
            this.lb_Vorname.Location = new System.Drawing.Point(233, 42);
            this.lb_Vorname.Name = "lb_Vorname";
            this.lb_Vorname.Size = new System.Drawing.Size(130, 32);
            this.lb_Vorname.TabIndex = 7;
            this.lb_Vorname.Text = "Vorname";
            this.lb_Vorname.Click += new System.EventHandler(this.lb_Vorname_Click);
            // 
            // lb_nachname
            // 
            this.lb_nachname.AutoSize = true;
            this.lb_nachname.BackColor = System.Drawing.SystemColors.Window;
            this.lb_nachname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lb_nachname.ForeColor = System.Drawing.Color.Gray;
            this.lb_nachname.Location = new System.Drawing.Point(510, 41);
            this.lb_nachname.Name = "lb_nachname";
            this.lb_nachname.Size = new System.Drawing.Size(152, 32);
            this.lb_nachname.TabIndex = 8;
            this.lb_nachname.Text = "Nachname";
            this.lb_nachname.Click += new System.EventHandler(this.lb_nachname_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Suche nach:";
            // 
            // w_s_Aus_Kunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Abbrechen;
            this.ClientSize = new System.Drawing.Size(1763, 789);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_nachname);
            this.Controls.Add(this.lb_Vorname);
            this.Controls.Add(this.tb_nachname);
            this.Controls.Add(this.tb_vorname);
            this.Controls.Add(this.bt_NeuKunde);
            this.Controls.Add(this.bt_Abbrechen);
            this.Controls.Add(this.bt_Ausweahlen);
            this.Controls.Add(this.gv_Aus_Kunde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_Aus_Kunde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kunde auswählen";
            this.Activated += new System.EventHandler(this.Load_Kunden);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Aus_Kunde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Aus_Kunde;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_Ausweahlen;
        private System.Windows.Forms.Button bt_Abbrechen;
        private System.Windows.Forms.Button bt_NeuKunde;
        private System.Windows.Forms.TextBox tb_vorname;
        private System.Windows.Forms.TextBox tb_nachname;
        private System.Windows.Forms.Label lb_Vorname;
        private System.Windows.Forms.Label lb_nachname;
        private System.Windows.Forms.Label label1;
    }
}