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
            this.gv_Sprachen = new System.Windows.Forms.DataGridView();
            this.bt_Uebernehmen = new System.Windows.Forms.Button();
            this.tb_Suchen = new System.Windows.Forms.TextBox();
            this.lb_Sprache = new System.Windows.Forms.Label();
            this.bt_Suchen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sprachen)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Sprachen
            // 
            this.gv_Sprachen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Sprachen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Sprachen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gv_Sprachen.Location = new System.Drawing.Point(10, 12);
            this.gv_Sprachen.MultiSelect = false;
            this.gv_Sprachen.Name = "gv_Sprachen";
            this.gv_Sprachen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Sprachen.Size = new System.Drawing.Size(192, 396);
            this.gv_Sprachen.TabIndex = 50;
            this.gv_Sprachen.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_Sprachen_CellBeginEdit);
            this.gv_Sprachen.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gv_Sprachen_UserDeletedRow);
            this.gv_Sprachen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // bt_Uebernehmen
            // 
            this.bt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Uebernehmen.Location = new System.Drawing.Point(10, 414);
            this.bt_Uebernehmen.Name = "bt_Uebernehmen";
            this.bt_Uebernehmen.Size = new System.Drawing.Size(111, 23);
            this.bt_Uebernehmen.TabIndex = 51;
            this.bt_Uebernehmen.Text = "Übernehmen";
            this.bt_Uebernehmen.UseVisualStyleBackColor = true;
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Enabled = false;
            this.tb_Suchen.Location = new System.Drawing.Point(60, 12);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.Size = new System.Drawing.Size(142, 20);
            this.tb_Suchen.TabIndex = 52;
            this.tb_Suchen.Visible = false;
            this.tb_Suchen.TextChanged += new System.EventHandler(this.tb_Suchen_TextChanged);
            // 
            // lb_Sprache
            // 
            this.lb_Sprache.AutoSize = true;
            this.lb_Sprache.Location = new System.Drawing.Point(7, 15);
            this.lb_Sprache.Name = "lb_Sprache";
            this.lb_Sprache.Size = new System.Drawing.Size(47, 13);
            this.lb_Sprache.TabIndex = 53;
            this.lb_Sprache.Text = "Suchen:";
            this.lb_Sprache.Visible = false;
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Location = new System.Drawing.Point(127, 414);
            this.bt_Suchen.Name = "bt_Suchen";
            this.bt_Suchen.Size = new System.Drawing.Size(75, 23);
            this.bt_Suchen.TabIndex = 54;
            this.bt_Suchen.Text = "Suchen";
            this.bt_Suchen.UseVisualStyleBackColor = true;
            this.bt_Suchen.Click += new System.EventHandler(this.bt_Suchen_Click);
            // 
            // w_s_sprachen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(214, 446);
            this.Controls.Add(this.bt_Suchen);
            this.Controls.Add(this.lb_Sprache);
            this.Controls.Add(this.tb_Suchen);
            this.Controls.Add(this.bt_Uebernehmen);
            this.Controls.Add(this.gv_Sprachen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_sprachen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sprachen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_sprachen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sprachen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView gv_Sprachen;
        private System.Windows.Forms.Button bt_Uebernehmen;
        private System.Windows.Forms.TextBox tb_Suchen;
        private System.Windows.Forms.Label lb_Sprache;
        private System.Windows.Forms.Button bt_Suchen;
    }
}