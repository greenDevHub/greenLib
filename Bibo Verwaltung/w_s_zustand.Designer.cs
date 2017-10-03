namespace Bibo_Verwaltung
{
    partial class w_s_zustand
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
            this.Grid_Zustand = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Zustand)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Zustand
            // 
            this.Grid_Zustand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Zustand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Zustand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Grid_Zustand.Location = new System.Drawing.Point(13, 13);
            this.Grid_Zustand.Margin = new System.Windows.Forms.Padding(4);
            this.Grid_Zustand.MultiSelect = false;
            this.Grid_Zustand.Name = "Grid_Zustand";
            this.Grid_Zustand.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Grid_Zustand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Zustand.Size = new System.Drawing.Size(256, 527);
            this.Grid_Zustand.TabIndex = 0;
            this.Grid_Zustand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Grid_Zustand_KeyPress);
            // 
            // w_s_zustand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 553);
            this.Controls.Add(this.Grid_Zustand);
            this.Name = "w_s_zustand";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zustände";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_zustand_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Zustand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Zustand;
    }
}