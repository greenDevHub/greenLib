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
            this.gb_Verlage = new System.Windows.Forms.GroupBox();
            this.tLP_Sprachen = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Verlage = new System.Windows.Forms.Label();
            this.tb_Suchen = new System.Windows.Forms.TextBox();
            this.gv_Verlage = new System.Windows.Forms.DataGridView();
            this.tLP_Button = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Uebernehmen = new System.Windows.Forms.Button();
            this.bt_Suchen = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.gb_Verlage.SuspendLayout();
            this.tLP_Sprachen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlage)).BeginInit();
            this.tLP_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Verlage
            // 
            this.gb_Verlage.Controls.Add(this.tLP_Sprachen);
            this.gb_Verlage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Verlage.Location = new System.Drawing.Point(0, 0);
            this.gb_Verlage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.gb_Verlage.Name = "gb_Verlage";
            this.gb_Verlage.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.gb_Verlage.Size = new System.Drawing.Size(235, 482);
            this.gb_Verlage.TabIndex = 65;
            this.gb_Verlage.TabStop = false;
            // 
            // tLP_Sprachen
            // 
            this.tLP_Sprachen.AutoSize = true;
            this.tLP_Sprachen.ColumnCount = 1;
            this.tLP_Sprachen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLP_Sprachen.Controls.Add(this.lb_Verlage, 0, 0);
            this.tLP_Sprachen.Controls.Add(this.tb_Suchen, 0, 1);
            this.tLP_Sprachen.Controls.Add(this.gv_Verlage, 0, 2);
            this.tLP_Sprachen.Controls.Add(this.tLP_Button, 0, 3);
            this.tLP_Sprachen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Sprachen.Location = new System.Drawing.Point(1, 14);
            this.tLP_Sprachen.Name = "tLP_Sprachen";
            this.tLP_Sprachen.RowCount = 4;
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tLP_Sprachen.Size = new System.Drawing.Size(233, 467);
            this.tLP_Sprachen.TabIndex = 61;
            // 
            // lb_Verlage
            // 
            this.lb_Verlage.AutoSize = true;
            this.lb_Verlage.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpProvider.SetHelpString(this.lb_Verlage, "Suchen sie nach gespeicherten Verlage.");
            this.lb_Verlage.Location = new System.Drawing.Point(3, 0);
            this.lb_Verlage.Name = "lb_Verlage";
            this.helpProvider.SetShowHelp(this.lb_Verlage, true);
            this.lb_Verlage.Size = new System.Drawing.Size(227, 13);
            this.lb_Verlage.TabIndex = 53;
            this.lb_Verlage.Text = "Suchen:";
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Suchen.Enabled = false;
            this.helpProvider.SetHelpString(this.tb_Suchen, "Suchen sie nach gespeicherten Verlage.");
            this.tb_Suchen.Location = new System.Drawing.Point(3, 17);
            this.tb_Suchen.Name = "tb_Suchen";
            this.helpProvider.SetShowHelp(this.tb_Suchen, true);
            this.tb_Suchen.Size = new System.Drawing.Size(227, 20);
            this.tb_Suchen.TabIndex = 52;
            this.tb_Suchen.Visible = false;
            this.tb_Suchen.TextChanged += new System.EventHandler(this.tb_Suchen_TextChanged);
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
            this.helpProvider.SetHelpString(this.gv_Verlage, "Hier werden all ihre gespeicherten Verlage angezeigt.");
            this.gv_Verlage.Location = new System.Drawing.Point(3, 40);
            this.gv_Verlage.MultiSelect = false;
            this.gv_Verlage.Name = "gv_Verlage";
            this.gv_Verlage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.gv_Verlage, true);
            this.gv_Verlage.Size = new System.Drawing.Size(227, 395);
            this.gv_Verlage.TabIndex = 50;
            this.gv_Verlage.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_verlage_CellBeginEdit);
            this.gv_Verlage.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Verlage_CellEndEdit);
            this.gv_Verlage.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gv_verlage_UserDeletedRow);
            this.gv_Verlage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // tLP_Button
            // 
            this.tLP_Button.AutoSize = true;
            this.tLP_Button.ColumnCount = 2;
            this.tLP_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tLP_Button.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tLP_Button.Controls.Add(this.bt_Uebernehmen, 0, 0);
            this.tLP_Button.Controls.Add(this.bt_Suchen, 1, 0);
            this.tLP_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Button.Location = new System.Drawing.Point(1, 438);
            this.tLP_Button.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.tLP_Button.Name = "tLP_Button";
            this.tLP_Button.RowCount = 1;
            this.tLP_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Button.Size = new System.Drawing.Size(231, 28);
            this.tLP_Button.TabIndex = 54;
            // 
            // bt_Uebernehmen
            // 
            this.bt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Uebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.bt_Uebernehmen, "Klicken sie auf diesen Button, um alle Änderungen zu übernehmen.");
            this.bt_Uebernehmen.Location = new System.Drawing.Point(3, 3);
            this.bt_Uebernehmen.Name = "bt_Uebernehmen";
            this.helpProvider.SetShowHelp(this.bt_Uebernehmen, true);
            this.bt_Uebernehmen.Size = new System.Drawing.Size(132, 22);
            this.bt_Uebernehmen.TabIndex = 51;
            this.bt_Uebernehmen.Text = "Übernehmen";
            this.bt_Uebernehmen.UseVisualStyleBackColor = true;
            this.bt_Uebernehmen.Click += new System.EventHandler(this.bt_Uebernehmen_Click);
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider.SetHelpString(this.bt_Suchen, "Klicken sie auf diesen Button, um die Suchfunktion an- bzw. auszuschalten.");
            this.bt_Suchen.Location = new System.Drawing.Point(141, 3);
            this.bt_Suchen.Name = "bt_Suchen";
            this.helpProvider.SetShowHelp(this.bt_Suchen, true);
            this.bt_Suchen.Size = new System.Drawing.Size(87, 22);
            this.bt_Suchen.TabIndex = 54;
            this.bt_Suchen.Text = "Suchen AN";
            this.bt_Suchen.UseVisualStyleBackColor = true;
            this.bt_Suchen.Click += new System.EventHandler(this.bt_Suchen_Click);
            // 
            // w_s_verlage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 482);
            this.Controls.Add(this.gb_Verlage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_verlage";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Verlage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_verlage_FormClosing);
            this.gb_Verlage.ResumeLayout(false);
            this.gb_Verlage.PerformLayout();
            this.tLP_Sprachen.ResumeLayout(false);
            this.tLP_Sprachen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Verlage)).EndInit();
            this.tLP_Button.ResumeLayout(false);
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
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}