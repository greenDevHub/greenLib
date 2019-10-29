namespace Bibo_Verwaltung
{
    partial class w_s_bild_bearbeiten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_bild_bearbeiten));
            this.bt_save_bild = new System.Windows.Forms.Button();
            this.bt_Schliessen = new System.Windows.Forms.Button();
            this.lb_buch_bild = new System.Windows.Forms.Label();
            this.bt_browse = new System.Windows.Forms.Button();
            this.cb_buch_bild = new System.Windows.Forms.ComboBox();
            this.bt_view_bild = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_save_bild
            // 
            this.bt_save_bild.Location = new System.Drawing.Point(30, 98);
            this.bt_save_bild.Name = "bt_save_bild";
            this.bt_save_bild.Size = new System.Drawing.Size(96, 43);
            this.bt_save_bild.TabIndex = 2;
            this.bt_save_bild.Text = "Speichern";
            this.bt_save_bild.UseVisualStyleBackColor = true;
            this.bt_save_bild.Click += new System.EventHandler(this.bt_save_bild_Click);
            // 
            // bt_Schliessen
            // 
            this.bt_Schliessen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Schliessen.Location = new System.Drawing.Point(123, 207);
            this.bt_Schliessen.Name = "bt_Schliessen";
            this.bt_Schliessen.Size = new System.Drawing.Size(100, 23);
            this.bt_Schliessen.TabIndex = 3;
            this.bt_Schliessen.Text = "Schließen";
            this.bt_Schliessen.UseVisualStyleBackColor = true;
            // 
            // lb_buch_bild
            // 
            this.lb_buch_bild.AutoSize = true;
            this.lb_buch_bild.Location = new System.Drawing.Point(12, 41);
            this.lb_buch_bild.Name = "lb_buch_bild";
            this.lb_buch_bild.Size = new System.Drawing.Size(38, 13);
            this.lb_buch_bild.TabIndex = 4;
            this.lb_buch_bild.Text = "Buch :";
            // 
            // bt_browse
            // 
            this.bt_browse.Location = new System.Drawing.Point(56, 161);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(136, 27);
            this.bt_browse.TabIndex = 5;
            this.bt_browse.Text = "Browse";
            this.bt_browse.UseVisualStyleBackColor = true;
            this.bt_browse.Click += new System.EventHandler(this.bt_browse_Click);
            // 
            // cb_buch_bild
            // 
            this.cb_buch_bild.FormattingEnabled = true;
            this.cb_buch_bild.Location = new System.Drawing.Point(56, 38);
            this.cb_buch_bild.Name = "cb_buch_bild";
            this.cb_buch_bild.Size = new System.Drawing.Size(218, 21);
            this.cb_buch_bild.TabIndex = 6;
            // 
            // bt_view_bild
            // 
            this.bt_view_bild.Location = new System.Drawing.Point(153, 98);
            this.bt_view_bild.Name = "bt_view_bild";
            this.bt_view_bild.Size = new System.Drawing.Size(99, 43);
            this.bt_view_bild.TabIndex = 7;
            this.bt_view_bild.Text = "Anzeigen";
            this.bt_view_bild.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(281, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 332);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // w_s_bild_bearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 354);
            this.Controls.Add(this.bt_view_bild);
            this.Controls.Add(this.cb_buch_bild);
            this.Controls.Add(this.bt_browse);
            this.Controls.Add(this.lb_buch_bild);
            this.Controls.Add(this.bt_Schliessen);
            this.Controls.Add(this.bt_save_bild);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "w_s_bild_bearbeiten";
            this.Text = "w_s_bild_bearbeiten";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_save_bild;
        private System.Windows.Forms.Button bt_Schliessen;
        private System.Windows.Forms.Label lb_buch_bild;
        private System.Windows.Forms.Button bt_browse;
        private System.Windows.Forms.ComboBox cb_buch_bild;
        private System.Windows.Forms.Button bt_view_bild;
    }
}