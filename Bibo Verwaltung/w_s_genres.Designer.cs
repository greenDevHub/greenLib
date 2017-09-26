namespace Bibo_Verwaltung
{
    partial class w_s_genres
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
            this.bt_OK = new System.Windows.Forms.Button();
            this.gv_Genres = new System.Windows.Forms.DataGridView();
            this.lb_Genres = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Genres)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(102, 361);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(110, 23);
            this.bt_OK.TabIndex = 44;
            this.bt_OK.Text = "Übernehmen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // gv_Genres
            // 
            this.gv_Genres.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Genres.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Genres.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gv_Genres.Location = new System.Drawing.Point(12, 25);
            this.gv_Genres.MultiSelect = false;
            this.gv_Genres.Name = "gv_Genres";
            this.gv_Genres.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Genres.Size = new System.Drawing.Size(200, 330);
            this.gv_Genres.TabIndex = 45;
            this.gv_Genres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // lb_Genres
            // 
            this.lb_Genres.AutoSize = true;
            this.lb_Genres.Location = new System.Drawing.Point(9, 9);
            this.lb_Genres.Name = "lb_Genres";
            this.lb_Genres.Size = new System.Drawing.Size(134, 13);
            this.lb_Genres.TabIndex = 50;
            this.lb_Genres.Text = "Einträge in der Datenbank:";
            // 
            // w_s_genres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 396);
            this.Controls.Add(this.lb_Genres);
            this.Controls.Add(this.gv_Genres);
            this.Controls.Add(this.bt_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_genres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Genres";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_genres_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Genres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.DataGridView gv_Genres;
        private System.Windows.Forms.Label lb_Genres;
    }
}