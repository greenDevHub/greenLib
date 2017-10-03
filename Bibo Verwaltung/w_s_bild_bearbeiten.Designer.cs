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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_save_bild = new System.Windows.Forms.Button();
            this.bt_Schliessen = new System.Windows.Forms.Button();
            this.lb_buch_bild = new System.Windows.Forms.Label();
            this.bt_browse = new System.Windows.Forms.Button();
            this.cb_buch_bild = new System.Windows.Forms.ComboBox();
            this.bt_view_bild = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(375, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bt_save_bild
            // 
            this.bt_save_bild.Location = new System.Drawing.Point(40, 121);
            this.bt_save_bild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_save_bild.Name = "bt_save_bild";
            this.bt_save_bild.Size = new System.Drawing.Size(128, 53);
            this.bt_save_bild.TabIndex = 2;
            this.bt_save_bild.Text = "Speichern";
            this.bt_save_bild.UseVisualStyleBackColor = true;
            this.bt_save_bild.Click += new System.EventHandler(this.bt_save_bild_Click);
            // 
            // bt_Schliessen
            // 
            this.bt_Schliessen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Schliessen.Location = new System.Drawing.Point(164, 255);
            this.bt_Schliessen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_Schliessen.Name = "bt_Schliessen";
            this.bt_Schliessen.Size = new System.Drawing.Size(133, 28);
            this.bt_Schliessen.TabIndex = 3;
            this.bt_Schliessen.Text = "Schließen";
            this.bt_Schliessen.UseVisualStyleBackColor = true;
            // 
            // lb_buch_bild
            // 
            this.lb_buch_bild.AutoSize = true;
            this.lb_buch_bild.Location = new System.Drawing.Point(16, 50);
            this.lb_buch_bild.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_buch_bild.Name = "lb_buch_bild";
            this.lb_buch_bild.Size = new System.Drawing.Size(48, 17);
            this.lb_buch_bild.TabIndex = 4;
            this.lb_buch_bild.Text = "Buch :";
            // 
            // bt_browse
            // 
            this.bt_browse.Location = new System.Drawing.Point(75, 198);
            this.bt_browse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_browse.Name = "bt_browse";
            this.bt_browse.Size = new System.Drawing.Size(181, 33);
            this.bt_browse.TabIndex = 5;
            this.bt_browse.Text = "Browse";
            this.bt_browse.UseVisualStyleBackColor = true;
            this.bt_browse.Click += new System.EventHandler(this.bt_browse_Click);
            // 
            // cb_buch_bild
            // 
            this.cb_buch_bild.FormattingEnabled = true;
            this.cb_buch_bild.Location = new System.Drawing.Point(75, 47);
            this.cb_buch_bild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_buch_bild.Name = "cb_buch_bild";
            this.cb_buch_bild.Size = new System.Drawing.Size(289, 24);
            this.cb_buch_bild.TabIndex = 6;
            // 
            // bt_view_bild
            // 
            this.bt_view_bild.Location = new System.Drawing.Point(204, 121);
            this.bt_view_bild.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bt_view_bild.Name = "bt_view_bild";
            this.bt_view_bild.Size = new System.Drawing.Size(132, 53);
            this.bt_view_bild.TabIndex = 7;
            this.bt_view_bild.Text = "Anzeigen";
            this.bt_view_bild.UseVisualStyleBackColor = true;
            // 
            // w_s_bild_bearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 436);
            this.Controls.Add(this.bt_view_bild);
            this.Controls.Add(this.cb_buch_bild);
            this.Controls.Add(this.bt_browse);
            this.Controls.Add(this.lb_buch_bild);
            this.Controls.Add(this.bt_Schliessen);
            this.Controls.Add(this.bt_save_bild);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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