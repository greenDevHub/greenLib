namespace Bibo_Verwaltung
{
    partial class w_s_autoren
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
            this.gv_Autoren = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Autoren)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Autoren
            // 
            this.gv_Autoren.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Autoren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Autoren.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gv_Autoren.Location = new System.Drawing.Point(13, 13);
            this.gv_Autoren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gv_Autoren.MultiSelect = false;
            this.gv_Autoren.Name = "gv_Autoren";
            this.gv_Autoren.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gv_Autoren.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Autoren.Size = new System.Drawing.Size(256, 527);
            this.gv_Autoren.TabIndex = 48;
            this.gv_Autoren.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // w_s_autoren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 553);
            this.Controls.Add(this.gv_Autoren);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_autoren";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Autoren";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_autoren_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Autoren)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gv_Autoren;
    }
}