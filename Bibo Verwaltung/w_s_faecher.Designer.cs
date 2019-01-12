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
            this.gb_Verlage = new System.Windows.Forms.GroupBox();
            this.tLP_Sprachen = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_Button = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Uebernehmen = new System.Windows.Forms.Button();
            this.bt_Suchen = new System.Windows.Forms.Button();
            this.bt_import = new System.Windows.Forms.Button();
            this.lb_Verlage = new System.Windows.Forms.Label();
            this.tb_Suchen = new System.Windows.Forms.TextBox();
            this.gv_Verlage = new System.Windows.Forms.DataGridView();
            this.gb_Verlage.SuspendLayout();
            this.tLP_Sprachen.SuspendLayout();
            this.tLP_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlage)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Verlage
            // 
            this.gb_Verlage.Controls.Add(this.tLP_Sprachen);
            this.gb_Verlage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Verlage.Location = new System.Drawing.Point(0, 0);
            this.gb_Verlage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.gb_Verlage.Name = "gb_Verlage";
            this.gb_Verlage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gb_Verlage.Size = new System.Drawing.Size(1208, 1474);
            this.gb_Verlage.TabIndex = 66;
            this.gb_Verlage.TabStop = false;
            // 
            // tLP_Sprachen
            // 
            this.tLP_Sprachen.AutoSize = true;
            this.tLP_Sprachen.ColumnCount = 1;
            this.tLP_Sprachen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLP_Sprachen.Controls.Add(this.tLP_Button, 0, 3);
            this.tLP_Sprachen.Controls.Add(this.lb_Verlage, 0, 0);
            this.tLP_Sprachen.Controls.Add(this.tb_Suchen, 0, 1);
            this.tLP_Sprachen.Controls.Add(this.gv_Verlage, 0, 2);
            this.tLP_Sprachen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Sprachen.Location = new System.Drawing.Point(3, 33);
            this.tLP_Sprachen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tLP_Sprachen.Name = "tLP_Sprachen";
            this.tLP_Sprachen.RowCount = 4;
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tLP_Sprachen.Size = new System.Drawing.Size(1202, 1439);
            this.tLP_Sprachen.TabIndex = 61;
            // 
            // tLP_Button
            // 
            this.tLP_Button.ColumnCount = 3;
            this.tLP_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLP_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tLP_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLP_Button.Controls.Add(this.bt_Uebernehmen, 0, 0);
            this.tLP_Button.Controls.Add(this.bt_Suchen, 1, 0);
            this.tLP_Button.Controls.Add(this.bt_import, 2, 0);
            this.tLP_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Button.Location = new System.Drawing.Point(3, 1351);
            this.tLP_Button.Margin = new System.Windows.Forms.Padding(3, 0, 3, 2);
            this.tLP_Button.Name = "tLP_Button";
            this.tLP_Button.RowCount = 1;
            this.tLP_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Button.Size = new System.Drawing.Size(1198, 86);
            this.tLP_Button.TabIndex = 55;
            // 
            // bt_Uebernehmen
            // 
            this.bt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Uebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Uebernehmen.Location = new System.Drawing.Point(8, 7);
            this.bt_Uebernehmen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Uebernehmen.Name = "bt_Uebernehmen";
            this.bt_Uebernehmen.Size = new System.Drawing.Size(383, 72);
            this.bt_Uebernehmen.TabIndex = 51;
            this.bt_Uebernehmen.Text = "Übernehmen";
            this.bt_Uebernehmen.UseVisualStyleBackColor = true;
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Suchen.Location = new System.Drawing.Point(407, 7);
            this.bt_Suchen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Suchen.Name = "bt_Suchen";
            this.bt_Suchen.Size = new System.Drawing.Size(383, 72);
            this.bt_Suchen.TabIndex = 54;
            this.bt_Suchen.Text = "Suchen AN";
            this.bt_Suchen.UseVisualStyleBackColor = true;
            // 
            // bt_import
            // 
            this.bt_import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_import.Location = new System.Drawing.Point(801, 3);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(394, 80);
            this.bt_import.TabIndex = 55;
            this.bt_import.Text = "Import";
            this.bt_import.UseVisualStyleBackColor = true;
            this.bt_import.Click += new System.EventHandler(this.bt_import_Click_1);
            // 
            // lb_Verlage
            // 
            this.lb_Verlage.AutoSize = true;
            this.lb_Verlage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Verlage.Location = new System.Drawing.Point(8, 0);
            this.lb_Verlage.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Verlage.Name = "lb_Verlage";
            this.lb_Verlage.Size = new System.Drawing.Size(1188, 32);
            this.lb_Verlage.TabIndex = 53;
            this.lb_Verlage.Text = "Suchen:";
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Suchen.Enabled = false;
            this.tb_Suchen.Location = new System.Drawing.Point(8, 50);
            this.tb_Suchen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.Size = new System.Drawing.Size(1188, 38);
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
            this.gv_Verlage.Location = new System.Drawing.Point(8, 121);
            this.gv_Verlage.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gv_Verlage.MultiSelect = false;
            this.gv_Verlage.Name = "gv_Verlage";
            this.gv_Verlage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Verlage.Size = new System.Drawing.Size(1188, 1223);
            this.gv_Verlage.TabIndex = 50;
            this.gv_Verlage.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_Verlage_CellBeginEdit);
            this.gv_Verlage.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gv_Verlage_UserDeletedRow);
            // 
            // w_s_faecher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 1474);
            this.Controls.Add(this.gb_Verlage);
            this.Name = "w_s_faecher";
            this.Text = "Fächer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_faecher_FormClosing);
            this.gb_Verlage.ResumeLayout(false);
            this.gb_Verlage.PerformLayout();
            this.tLP_Sprachen.ResumeLayout(false);
            this.tLP_Sprachen.PerformLayout();
            this.tLP_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Verlage;
        private System.Windows.Forms.TableLayoutPanel tLP_Sprachen;
        private System.Windows.Forms.Label lb_Verlage;
        private System.Windows.Forms.TextBox tb_Suchen;
        private System.Windows.Forms.DataGridView gv_Verlage;
        private System.Windows.Forms.TableLayoutPanel tLP_Button;
        private System.Windows.Forms.Button bt_Uebernehmen;
        private System.Windows.Forms.Button bt_Suchen;
        private System.Windows.Forms.Button bt_import;
    }
}