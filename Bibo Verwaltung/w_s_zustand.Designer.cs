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
            this.bt_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Zustand)).BeginInit();
            this.SuspendLayout();
            // 
            // Grid_Zustand
            // 
            this.Grid_Zustand.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Zustand.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Zustand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Grid_Zustand.Location = new System.Drawing.Point(6, 6);
            this.Grid_Zustand.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Grid_Zustand.MultiSelect = false;
            this.Grid_Zustand.Name = "Grid_Zustand";
            this.Grid_Zustand.RowTemplate.Height = 24;
            this.Grid_Zustand.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Grid_Zustand.Size = new System.Drawing.Size(694, 885);
            this.Grid_Zustand.TabIndex = 0;
            this.Grid_Zustand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Grid_Zustand_KeyPress);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(6, 903);
            this.bt_save.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(232, 66);
            this.bt_save.TabIndex = 1;
            this.bt_save.Text = "Übernehmen";
            this.bt_save.UseVisualStyleBackColor = true;
            // 
            // w_s_zustand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 992);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.Grid_Zustand);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "w_s_zustand";
            this.Text = "w_s_zustand";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_zustand_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Zustand)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Grid_Zustand;
        private System.Windows.Forms.Button bt_save;
    }
}