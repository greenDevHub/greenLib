namespace Bibo_Verwaltung
{
    partial class w_s_sprachen
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
            this.gv_Sprachen = new System.Windows.Forms.DataGridView();
            this.lb_Sprachen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sprachen)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(102, 361);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(110, 23);
            this.bt_OK.TabIndex = 47;
            this.bt_OK.Text = "Übernehmen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // gv_Sprachen
            // 
            this.gv_Sprachen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Sprachen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Sprachen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gv_Sprachen.Location = new System.Drawing.Point(12, 25);
            this.gv_Sprachen.MultiSelect = false;
            this.gv_Sprachen.Name = "gv_Sprachen";
            this.gv_Sprachen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Sprachen.Size = new System.Drawing.Size(200, 330);
            this.gv_Sprachen.TabIndex = 50;
            this.gv_Sprachen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // lb_Sprachen
            // 
            this.lb_Sprachen.AutoSize = true;
            this.lb_Sprachen.Location = new System.Drawing.Point(9, 9);
            this.lb_Sprachen.Name = "lb_Sprachen";
            this.lb_Sprachen.Size = new System.Drawing.Size(134, 13);
            this.lb_Sprachen.TabIndex = 51;
            this.lb_Sprachen.Text = "Einträge in der Datenbank:";
            // 
            // w_s_sprachen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 396);
            this.Controls.Add(this.lb_Sprachen);
            this.Controls.Add(this.gv_Sprachen);
            this.Controls.Add(this.bt_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "w_s_sprachen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sprachen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_sprachen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sprachen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.DataGridView gv_Sprachen;
        private System.Windows.Forms.Label lb_Sprachen;
    }
}