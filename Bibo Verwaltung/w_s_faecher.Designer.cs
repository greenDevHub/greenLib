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
            this.gv_Faecher = new System.Windows.Forms.DataGridView();
            this.gb_Faecher = new System.Windows.Forms.GroupBox();
            this.bt_verwaltung = new System.Windows.Forms.Button();
            this.tb_Suchen = new System.Windows.Forms.TextBox();
            this.lb_Faecher = new System.Windows.Forms.Label();
            this.tLP_Faecher = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Faecher)).BeginInit();
            this.gb_Faecher.SuspendLayout();
            this.tLP_Faecher.SuspendLayout();
            this.tLP_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Uebernehmen
            // 
            this.bt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Uebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Uebernehmen.Location = new System.Drawing.Point(3, 3);
            this.bt_Uebernehmen.Name = "bt_Uebernehmen";
            this.bt_Uebernehmen.Size = new System.Drawing.Size(76, 37);
            this.bt_Uebernehmen.TabIndex = 51;
            this.bt_Uebernehmen.Text = "Übernehmen";
            this.bt_Uebernehmen.UseVisualStyleBackColor = true;
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Suchen.Location = new System.Drawing.Point(165, 3);
            this.bt_Suchen.Name = "bt_Suchen";
            this.bt_Suchen.Size = new System.Drawing.Size(64, 37);
            this.bt_Suchen.TabIndex = 54;
            this.bt_Suchen.Text = "Suchen AN";
            this.bt_Suchen.UseVisualStyleBackColor = true;
            this.bt_Suchen.Click += new System.EventHandler(this.bt_Suchen_Click);
            // 
            // bt_import
            // 
            this.bt_import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_import.Location = new System.Drawing.Point(85, 3);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(74, 37);
            this.bt_import.TabIndex = 55;
            this.bt_import.Text = "Import";
            this.bt_import.UseVisualStyleBackColor = true;
            this.bt_import.Click += new System.EventHandler(this.bt_import_Click_1);
            // 
            // gv_Faecher
            // 
            this.gv_Faecher.AllowUserToResizeColumns = false;
            this.gv_Faecher.AllowUserToResizeRows = false;
            this.gv_Faecher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Faecher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Faecher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gv_Faecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Faecher.Location = new System.Drawing.Point(3, 44);
            this.gv_Faecher.MultiSelect = false;
            this.gv_Faecher.Name = "gv_Faecher";
            this.gv_Faecher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Faecher.Size = new System.Drawing.Size(228, 496);
            this.gv_Faecher.TabIndex = 50;
            this.gv_Faecher.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_Verlage_CellBeginEdit);
            this.gv_Faecher.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gv_Verlage_UserDeletedRow);
            // 
            // gb_Faecher
            // 
            this.gb_Faecher.Controls.Add(this.tLP_Faecher);
            this.gb_Faecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Faecher.Location = new System.Drawing.Point(0, 0);
            this.gb_Faecher.Margin = new System.Windows.Forms.Padding(1);
            this.gb_Faecher.Name = "gb_Faecher";
            this.gb_Faecher.Padding = new System.Windows.Forms.Padding(1);
            this.gb_Faecher.Size = new System.Drawing.Size(267, 642);
            this.gb_Faecher.TabIndex = 67;
            this.gb_Faecher.TabStop = false;
            // 
            // bt_verwaltung
            // 
            this.bt_verwaltung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_verwaltung.Location = new System.Drawing.Point(3, 591);
            this.bt_verwaltung.Name = "bt_verwaltung";
            this.bt_verwaltung.Size = new System.Drawing.Size(228, 28);
            this.bt_verwaltung.TabIndex = 54;
            this.bt_verwaltung.Text = "Fächer zu Klassenstufen zuordnen";
            this.bt_verwaltung.UseVisualStyleBackColor = true;
            this.bt_verwaltung.Click += new System.EventHandler(this.bt_Verwaltung_Click);
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Suchen.Enabled = false;
            this.tb_Suchen.Location = new System.Drawing.Point(3, 19);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.Size = new System.Drawing.Size(228, 20);
            this.tb_Suchen.TabIndex = 52;
            this.tb_Suchen.Visible = false;
            this.tb_Suchen.TextChanged += new System.EventHandler(this.tb_Suchen_TextChanged);
            // 
            // lb_Faecher
            // 
            this.lb_Faecher.AutoSize = true;
            this.lb_Faecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Faecher.Location = new System.Drawing.Point(3, 0);
            this.lb_Faecher.Name = "lb_Faecher";
            this.lb_Faecher.Size = new System.Drawing.Size(228, 16);
            this.lb_Faecher.TabIndex = 54;
            this.lb_Faecher.Text = "Suchen:";
            // 
            // tLP_Faecher
            // 
            this.tLP_Faecher.ColumnCount = 1;
            this.tLP_Faecher.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Faecher.Controls.Add(this.tLP_Buttons, 0, 3);
            this.tLP_Faecher.Controls.Add(this.bt_verwaltung, 0, 4);
            this.tLP_Faecher.Controls.Add(this.lb_Faecher, 0, 0);
            this.tLP_Faecher.Controls.Add(this.tb_Suchen, 0, 1);
            this.tLP_Faecher.Controls.Add(this.gv_Faecher, 0, 2);
            this.tLP_Faecher.Location = new System.Drawing.Point(10, 15);
            this.tLP_Faecher.Margin = new System.Windows.Forms.Padding(1);
            this.tLP_Faecher.Name = "tLP_Faecher";
            this.tLP_Faecher.RowCount = 5;
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.733119F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.340836F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.42914F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.784431F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP_Faecher.Size = new System.Drawing.Size(234, 622);
            this.tLP_Faecher.TabIndex = 0;
            // 
            // tLP_Buttons
            // 
            this.tLP_Buttons.ColumnCount = 3;
            this.tLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tLP_Buttons.Controls.Add(this.bt_Uebernehmen, 0, 0);
            this.tLP_Buttons.Controls.Add(this.bt_Suchen, 2, 0);
            this.tLP_Buttons.Controls.Add(this.bt_import, 1, 0);
            this.tLP_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Buttons.Location = new System.Drawing.Point(1, 544);
            this.tLP_Buttons.Margin = new System.Windows.Forms.Padding(1);
            this.tLP_Buttons.Name = "tLP_Buttons";
            this.tLP_Buttons.RowCount = 1;
            this.tLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.733119F));
            this.tLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP_Buttons.Size = new System.Drawing.Size(232, 43);
            this.tLP_Buttons.TabIndex = 56;
            // 
            // w_s_faecher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 642);
            this.Controls.Add(this.gb_Faecher);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "w_s_faecher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fächer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_faecher_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Faecher)).EndInit();
            this.gb_Faecher.ResumeLayout(false);
            this.tLP_Faecher.ResumeLayout(false);
            this.tLP_Faecher.PerformLayout();
            this.tLP_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gv_Faecher;
        private System.Windows.Forms.Button bt_Uebernehmen;
        private System.Windows.Forms.Button bt_Suchen;
        private System.Windows.Forms.Button bt_import;
        private System.Windows.Forms.GroupBox gb_Faecher;
        private System.Windows.Forms.Button bt_verwaltung;
        private System.Windows.Forms.TableLayoutPanel tLP_Faecher;
        private System.Windows.Forms.TableLayoutPanel tLP_Buttons;
        private System.Windows.Forms.Label lb_Faecher;
        private System.Windows.Forms.TextBox tb_Suchen;
    }
}