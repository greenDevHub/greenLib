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
            this.bt_OK = new System.Windows.Forms.Button();
            this.gv_Verlage = new System.Windows.Forms.DataGridView();
            this.lb_Verlage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlage)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(102, 361);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(110, 23);
            this.bt_OK.TabIndex = 46;
            this.bt_OK.Text = "Übernehmen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // gv_Verlage
            // 
            this.gv_Verlage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Verlage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Verlage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gv_Verlage.Location = new System.Drawing.Point(12, 25);
            this.gv_Verlage.MultiSelect = false;
            this.gv_Verlage.Name = "gv_Verlage";
            this.gv_Verlage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gv_Verlage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Verlage.Size = new System.Drawing.Size(200, 330);
            this.gv_Verlage.TabIndex = 47;
            this.gv_Verlage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // lb_Verlage
            // 
            this.lb_Verlage.AutoSize = true;
            this.lb_Verlage.Location = new System.Drawing.Point(9, 9);
            this.lb_Verlage.Name = "lb_Verlage";
            this.lb_Verlage.Size = new System.Drawing.Size(134, 13);
            this.lb_Verlage.TabIndex = 51;
            this.lb_Verlage.Text = "Einträge in der Datenbank:";
            // 
            // w_s_verlage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 396);
            this.Controls.Add(this.lb_Verlage);
            this.Controls.Add(this.gv_Verlage);
            this.Controls.Add(this.bt_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "w_s_verlage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verlage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_verlage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.DataGridView gv_Verlage;
        private System.Windows.Forms.Label lb_Verlage;
    }
}