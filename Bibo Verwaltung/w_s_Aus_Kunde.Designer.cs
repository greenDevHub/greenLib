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
            this.gv_Aus_Kunde.Location = new System.Drawing.Point(12, 12);
            this.gv_Aus_Kunde.MultiSelect = false;
            this.gv_Aus_Kunde.Name = "gv_Aus_Kunde";
            this.gv_Aus_Kunde.ReadOnly = true;
            this.gv_Aus_Kunde.RowHeadersVisible = false;
            this.gv_Aus_Kunde.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Aus_Kunde.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Aus_Kunde.ShowEditingIcon = false;
            this.gv_Aus_Kunde.Size = new System.Drawing.Size(637, 283);
            this.gv_Aus_Kunde.TabIndex = 0;
            // 
            // bt_Ausweahlen
            // 
            this.bt_Ausweahlen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Ausweahlen.Location = new System.Drawing.Point(443, 301);
            this.bt_Ausweahlen.Name = "bt_Ausweahlen";
            this.bt_Ausweahlen.Size = new System.Drawing.Size(100, 23);
            this.bt_Ausweahlen.TabIndex = 1;
            this.bt_Ausweahlen.Text = "OK";
            this.bt_Ausweahlen.UseVisualStyleBackColor = true;
            this.bt_Ausweahlen.Click += new System.EventHandler(this.bt_Ausweahlen_Click);
            // 
            // bt_Abbrechen
            // 
            this.bt_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Abbrechen.Location = new System.Drawing.Point(549, 301);
            this.bt_Abbrechen.Name = "bt_Abbrechen";
            this.bt_Abbrechen.Size = new System.Drawing.Size(100, 23);
            this.bt_Abbrechen.TabIndex = 2;
            this.bt_Abbrechen.Text = "Abbrechen";
            this.bt_Abbrechen.UseVisualStyleBackColor = true;
            // 
            // bt_NeuKunde
            // 
            this.bt_NeuKunde.Location = new System.Drawing.Point(12, 301);
            this.bt_NeuKunde.Name = "bt_NeuKunde";
            this.bt_NeuKunde.Size = new System.Drawing.Size(150, 23);
            this.bt_NeuKunde.TabIndex = 4;
            this.bt_NeuKunde.Text = "Neuen Kunden hinzufügen";
            this.bt_NeuKunde.UseVisualStyleBackColor = true;
            this.bt_NeuKunde.Click += new System.EventHandler(this.bt_NeuKunde_Click);
            // 
            // w_s_Aus_Kunde
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.bt_Abbrechen;
            this.ClientSize = new System.Drawing.Size(661, 331);
            this.Controls.Add(this.bt_NeuKunde);
            this.Controls.Add(this.bt_Abbrechen);
            this.Controls.Add(this.bt_Ausweahlen);
            this.Controls.Add(this.gv_Aus_Kunde);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_Aus_Kunde";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kunde auswählen";
            this.Activated += new System.EventHandler(this.Load_Kunden);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Aus_Kunde)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gv_Aus_Kunde;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_Ausweahlen;
        private System.Windows.Forms.Button bt_Abbrechen;
        private System.Windows.Forms.Button bt_NeuKunde;
    }
}