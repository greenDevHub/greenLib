namespace Bibo_Verwaltung
{
    partial class w_s_verlage
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
            this.gv_Verlage = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlage)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Verlage
            // 
            this.gv_Verlage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Verlage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Verlage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gv_Verlage.Location = new System.Drawing.Point(13, 13);
            this.gv_Verlage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gv_Verlage.MultiSelect = false;
            this.gv_Verlage.Name = "gv_Verlage";
            this.gv_Verlage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gv_Verlage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Verlage.Size = new System.Drawing.Size(256, 527);
            this.gv_Verlage.TabIndex = 47;
            this.gv_Verlage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // w_s_verlage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 553);
            this.Controls.Add(this.gv_Verlage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_verlage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verlage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_verlage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gv_Verlage;
    }
}