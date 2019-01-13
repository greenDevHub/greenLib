namespace Bibo_Verwaltung
{
    partial class w_s_faecher
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
            this.bt_Uebernehmen = new System.Windows.Forms.Button();
            this.bt_Suchen = new System.Windows.Forms.Button();
            this.bt_import = new System.Windows.Forms.Button();
            this.tb_Suchen = new System.Windows.Forms.TextBox();
            this.gv_Verlage = new System.Windows.Forms.DataGridView();
            this.gb = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.bt_verwaltung = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlage)).BeginInit();
            this.gb.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Uebernehmen
            // 
            this.bt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Uebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Uebernehmen.Location = new System.Drawing.Point(8, 7);
            this.bt_Uebernehmen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Uebernehmen.Name = "bt_Uebernehmen";
            this.bt_Uebernehmen.Size = new System.Drawing.Size(189, 58);
            this.bt_Uebernehmen.TabIndex = 51;
            this.bt_Uebernehmen.Text = "Übernehmen";
            this.bt_Uebernehmen.UseVisualStyleBackColor = true;
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Suchen.Location = new System.Drawing.Point(213, 7);
            this.bt_Suchen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Suchen.Name = "bt_Suchen";
            this.bt_Suchen.Size = new System.Drawing.Size(190, 58);
            this.bt_Suchen.TabIndex = 54;
            this.bt_Suchen.Text = "Suchen AN";
            this.bt_Suchen.UseVisualStyleBackColor = true;
            this.bt_Suchen.Click += new System.EventHandler(this.bt_Suchen_Click);
            // 
            // bt_import
            // 
            this.bt_import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_import.Location = new System.Drawing.Point(419, 7);
            this.bt_import.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(191, 58);
            this.bt_import.TabIndex = 55;
            this.bt_import.Text = "Import";
            this.bt_import.UseVisualStyleBackColor = true;
            this.bt_import.Click += new System.EventHandler(this.bt_import_Click_1);
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Suchen.Enabled = false;
            this.tb_Suchen.Location = new System.Drawing.Point(8, 7);
            this.tb_Suchen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.Size = new System.Drawing.Size(608, 38);
            this.tb_Suchen.TabIndex = 52;
            this.tb_Suchen.Visible = false;
            // 
            // gv_Verlage
            // 
            this.gv_Verlage.AllowUserToResizeColumns = false;
            this.gv_Verlage.AllowUserToResizeRows = false;
            this.gv_Verlage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Verlage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Verlage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Verlage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gv_Verlage.Location = new System.Drawing.Point(8, 78);
            this.gv_Verlage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gv_Verlage.MultiSelect = false;
            this.gv_Verlage.Name = "gv_Verlage";
            this.gv_Verlage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Verlage.Size = new System.Drawing.Size(608, 1195);
            this.gv_Verlage.TabIndex = 50;
            this.gv_Verlage.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_Verlage_CellBeginEdit);
            this.gv_Verlage.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gv_Verlage_UserDeletedRow);
            // 
            // gb
            // 
            this.gb.Controls.Add(this.tableLayoutPanel1);
            this.gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb.Location = new System.Drawing.Point(0, 0);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(630, 1474);
            this.gb.TabIndex = 67;
            this.gb.TabStop = false;
            this.gb.Text = "Suchen:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tb_Suchen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gv_Verlage, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bt_verwaltung, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.950495F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.15842F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.445544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.445544F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(624, 1437);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00062F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.00063F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.99813F));
            this.tableLayoutPanel2.Controls.Add(this.bt_import, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_Suchen, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.bt_Uebernehmen, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 1283);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(618, 72);
            this.tableLayoutPanel2.TabIndex = 53;
            // 
            // bt_verwaltung
            // 
            this.bt_verwaltung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_verwaltung.Location = new System.Drawing.Point(8, 1365);
            this.bt_verwaltung.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_verwaltung.Name = "bt_verwaltung";
            this.bt_verwaltung.Size = new System.Drawing.Size(608, 65);
            this.bt_verwaltung.TabIndex = 54;
            this.bt_verwaltung.Text = "Fächer zu Klassenstufen zuordnen";
            this.bt_verwaltung.UseVisualStyleBackColor = true;
            this.bt_verwaltung.Click += new System.EventHandler(this.bt_Verwaltung_Click);
            // 
            // w_s_faecher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 1474);
            this.Controls.Add(this.gb);
            this.Name = "w_s_faecher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fächer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_faecher_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlage)).EndInit();
            this.gb.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Suchen;
        private System.Windows.Forms.DataGridView gv_Verlage;
        private System.Windows.Forms.Button bt_Uebernehmen;
        private System.Windows.Forms.Button bt_Suchen;
        private System.Windows.Forms.Button bt_import;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button bt_verwaltung;
    }
}