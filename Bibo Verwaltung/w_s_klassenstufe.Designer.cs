namespace Bibo_Verwaltung
{
    partial class w_s_klassenstufe
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
            this.gb_Klassenstufe = new System.Windows.Forms.GroupBox();
            this.tLP_Klassenstufe = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Klassenstufe = new System.Windows.Forms.Label();
            this.tb_Suchen = new System.Windows.Forms.TextBox();
            this.gv_Klassenstufe = new System.Windows.Forms.DataGridView();
            this.tLP_Button = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Uebernehmen = new System.Windows.Forms.Button();
            this.bt_Suchen = new System.Windows.Forms.Button();
            this.gb_Klassenstufe.SuspendLayout();
            this.tLP_Klassenstufe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).BeginInit();
            this.tLP_Button.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Klassenstufe
            // 
            this.gb_Klassenstufe.Controls.Add(this.tLP_Klassenstufe);
            this.gb_Klassenstufe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_Klassenstufe.Location = new System.Drawing.Point(0, 0);
            this.gb_Klassenstufe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.gb_Klassenstufe.Name = "gb_Klassenstufe";
            this.gb_Klassenstufe.Padding = new System.Windows.Forms.Padding(1);
            this.gb_Klassenstufe.Size = new System.Drawing.Size(234, 482);
            this.gb_Klassenstufe.TabIndex = 65;
            this.gb_Klassenstufe.TabStop = false;
            // 
            // tLP_Klassenstufe
            // 
            this.tLP_Klassenstufe.AutoSize = true;
            this.tLP_Klassenstufe.ColumnCount = 1;
            this.tLP_Klassenstufe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLP_Klassenstufe.Controls.Add(this.lb_Klassenstufe, 0, 0);
            this.tLP_Klassenstufe.Controls.Add(this.tb_Suchen, 0, 1);
            this.tLP_Klassenstufe.Controls.Add(this.gv_Klassenstufe, 0, 2);
            this.tLP_Klassenstufe.Controls.Add(this.tLP_Button, 0, 3);
            this.tLP_Klassenstufe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Klassenstufe.Location = new System.Drawing.Point(1, 14);
            this.tLP_Klassenstufe.Name = "tLP_Klassenstufe";
            this.tLP_Klassenstufe.RowCount = 4;
            this.tLP_Klassenstufe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3F));
            this.tLP_Klassenstufe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tLP_Klassenstufe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86F));
            this.tLP_Klassenstufe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tLP_Klassenstufe.Size = new System.Drawing.Size(232, 467);
            this.tLP_Klassenstufe.TabIndex = 61;
            // 
            // lb_Klassenstufe
            // 
            this.lb_Klassenstufe.AutoSize = true;
            this.lb_Klassenstufe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Klassenstufe.Location = new System.Drawing.Point(3, 0);
            this.lb_Klassenstufe.Name = "lb_Klassenstufe";
            this.lb_Klassenstufe.Size = new System.Drawing.Size(231, 13);
            this.lb_Klassenstufe.TabIndex = 53;
            this.lb_Klassenstufe.Text = "Suchen:";
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Suchen.Enabled = false;
            this.tb_Suchen.Location = new System.Drawing.Point(3, 17);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.Size = new System.Drawing.Size(231, 20);
            this.tb_Suchen.TabIndex = 52;
            this.tb_Suchen.Visible = false;
            this.tb_Suchen.TextChanged += new System.EventHandler(this.tb_Suchen_TextChanged);
            // 
            // gv_Klassenstufe
            // 
            this.gv_Klassenstufe.AllowUserToResizeColumns = false;
            this.gv_Klassenstufe.AllowUserToResizeRows = false;
            this.gv_Klassenstufe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Klassenstufe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Klassenstufe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Klassenstufe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gv_Klassenstufe.Location = new System.Drawing.Point(3, 40);
            this.gv_Klassenstufe.MultiSelect = false;
            this.gv_Klassenstufe.Name = "gv_Klassenstufe";
            this.gv_Klassenstufe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Klassenstufe.Size = new System.Drawing.Size(231, 395);
            this.gv_Klassenstufe.TabIndex = 50;
            this.gv_Klassenstufe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
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
            this.tLP_Button.Size = new System.Drawing.Size(235, 28);
            this.tLP_Button.TabIndex = 54;
            // 
            // bt_Uebernehmen
            // 
            this.bt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Uebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Uebernehmen.Location = new System.Drawing.Point(3, 3);
            this.bt_Uebernehmen.Name = "bt_Uebernehmen";
            this.bt_Uebernehmen.Size = new System.Drawing.Size(135, 22);
            this.bt_Uebernehmen.TabIndex = 51;
            this.bt_Uebernehmen.Text = "Übernehmen";
            this.bt_Uebernehmen.UseVisualStyleBackColor = true;
            this.bt_Uebernehmen.Click += new System.EventHandler(this.bt_Uebernehmen_Click_1);
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Suchen.Location = new System.Drawing.Point(144, 3);
            this.bt_Suchen.Name = "bt_Suchen";
            this.bt_Suchen.Size = new System.Drawing.Size(88, 22);
            this.bt_Suchen.TabIndex = 54;
            this.bt_Suchen.Text = "Suchen AN";
            this.bt_Suchen.UseVisualStyleBackColor = true;
            this.bt_Suchen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_Suchen_Click);
            // 
            // w_s_klassenstufe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 482);
            this.Controls.Add(this.gb_Klassenstufe);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(235, 475);
            this.Name = "w_s_klassenstufe";
            this.Text = "w_s_klassenstufe";
            this.gb_Klassenstufe.ResumeLayout(false);
            this.gb_Klassenstufe.PerformLayout();
            this.tLP_Klassenstufe.ResumeLayout(false);
            this.tLP_Klassenstufe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).EndInit();
            this.tLP_Button.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Klassenstufe;
        private System.Windows.Forms.TableLayoutPanel tLP_Klassenstufe;
        private System.Windows.Forms.Label lb_Klassenstufe;
        private System.Windows.Forms.TextBox tb_Suchen;
        private System.Windows.Forms.DataGridView gv_Klassenstufe;
        private System.Windows.Forms.TableLayoutPanel tLP_Button;
        private System.Windows.Forms.Button bt_Uebernehmen;
        private System.Windows.Forms.Button bt_Suchen;
    }
}