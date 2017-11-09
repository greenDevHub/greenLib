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
            this.tLP_Sprachen = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sprachen)).BeginInit();
            this.tLP_Sprachen.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_Sprachen
            // 
            this.gv_Sprachen.AllowUserToResizeColumns = false;
            this.gv_Sprachen.AllowUserToResizeRows = false;
            this.gv_Sprachen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Sprachen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Sprachen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Sprachen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gv_Sprachen.Location = new System.Drawing.Point(8, 106);
            this.gv_Sprachen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gv_Sprachen.MultiSelect = false;
            this.gv_Sprachen.Name = "gv_Sprachen";
            this.gv_Sprachen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Sprachen.Size = new System.Drawing.Size(520, 1033);
            this.gv_Sprachen.TabIndex = 50;
            this.gv_Sprachen.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_Sprachen_CellBeginEdit);
            this.gv_Sprachen.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gv_Sprachen_UserDeletedRow);
            this.gv_Sprachen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // bt_Uebernehmen
            // 
            this.bt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Uebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Uebernehmen.Location = new System.Drawing.Point(8, 7);
            this.bt_Uebernehmen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Uebernehmen.Name = "bt_Uebernehmen";
            this.bt_Uebernehmen.Size = new System.Drawing.Size(249, 87);
            this.bt_Uebernehmen.TabIndex = 51;
            this.bt_Uebernehmen.Text = "Übernehmen";
            this.bt_Uebernehmen.UseVisualStyleBackColor = true;
            this.bt_Uebernehmen.Click += new System.EventHandler(this.bt_Uebernehmen_Click);
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Suchen.Enabled = false;
            this.tb_Suchen.Location = new System.Drawing.Point(8, 44);
            this.tb_Suchen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.Size = new System.Drawing.Size(520, 38);
            this.tb_Suchen.TabIndex = 52;
            this.tb_Suchen.Visible = false;
            this.tb_Suchen.TextChanged += new System.EventHandler(this.tb_Suchen_TextChanged);
            // 
            // lb_Sprache
            // 
            this.lb_Sprache.AutoSize = true;
            this.lb_Sprache.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Sprache.Location = new System.Drawing.Point(8, 0);
            this.lb_Sprache.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lb_Sprache.Name = "lb_Sprache";
            this.lb_Sprache.Size = new System.Drawing.Size(520, 32);
            this.lb_Sprache.TabIndex = 53;
            this.lb_Sprache.Text = "Suchen:";
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Suchen.Location = new System.Drawing.Point(273, 7);
            this.bt_Suchen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.bt_Suchen.Name = "bt_Suchen";
            this.bt_Suchen.Size = new System.Drawing.Size(249, 87);
            this.bt_Suchen.TabIndex = 54;
            this.bt_Suchen.Text = "Suchen AN";
            this.bt_Suchen.UseVisualStyleBackColor = true;
            this.bt_Suchen.Click += new System.EventHandler(this.bt_Suchen_Click);
            // 
            // tLP_Sprachen
            // 
            this.tLP_Sprachen.AutoSize = true;
            this.tLP_Sprachen.ColumnCount = 1;
            this.tLP_Sprachen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLP_Sprachen.Controls.Add(this.lb_Sprache, 0, 0);
            this.tLP_Sprachen.Controls.Add(this.tb_Suchen, 0, 1);
            this.tLP_Sprachen.Controls.Add(this.gv_Sprachen, 0, 2);
            this.tLP_Sprachen.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tLP_Sprachen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Sprachen.Location = new System.Drawing.Point(3, 34);
            this.tLP_Sprachen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.tLP_Sprachen.Name = "tLP_Sprachen";
            this.tLP_Sprachen.RowCount = 4;
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 3.004001F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.006669F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.62667F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.362667F));
            this.tLP_Sprachen.Size = new System.Drawing.Size(536, 1253);
            this.tLP_Sprachen.TabIndex = 61;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.bt_Uebernehmen, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.bt_Suchen, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 1149);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 101);
            this.tableLayoutPanel1.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tLP_Sprachen);
            this.groupBox1.Location = new System.Drawing.Point(13, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 1290);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // w_s_sprachen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 1312);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_sprachen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sprachen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_sprachen_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sprachen)).EndInit();
            this.tLP_Sprachen.ResumeLayout(false);
            this.tLP_Sprachen.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView gv_Sprachen;
        private System.Windows.Forms.Button bt_Uebernehmen;
        private System.Windows.Forms.TextBox tb_Suchen;
        private System.Windows.Forms.Label lb_Sprache;
        private System.Windows.Forms.Button bt_Suchen;
        private System.Windows.Forms.TableLayoutPanel tLP_Sprachen;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}