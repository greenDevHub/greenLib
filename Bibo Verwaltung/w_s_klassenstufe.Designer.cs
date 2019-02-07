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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_klassenstufe));
            this.tLP_Button = new System.Windows.Forms.TableLayoutPanel();
            this.bt_Uebernehmen = new MetroFramework.Controls.MetroButton();
            this.bt_Suchen = new MetroFramework.Controls.MetroButton();
            this.gv_Klassenstufe = new MetroFramework.Controls.MetroGrid();
            this.tb_Suchen = new System.Windows.Forms.TextBox();
            this.lb_Klassenstufe = new MetroFramework.Controls.MetroLabel();
            this.tLP_Klassenstufe = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_Button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).BeginInit();
            this.tLP_Klassenstufe.SuspendLayout();
            this.SuspendLayout();
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
            this.tLP_Button.Location = new System.Drawing.Point(1, 611);
            this.tLP_Button.Margin = new System.Windows.Forms.Padding(1, 0, 1, 1);
            this.tLP_Button.Name = "tLP_Button";
            this.tLP_Button.RowCount = 1;
            this.tLP_Button.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Button.Size = new System.Drawing.Size(360, 40);
            this.tLP_Button.TabIndex = 54;
            // 
            // bt_Uebernehmen
            // 
            this.bt_Uebernehmen.Cursor = System.Windows.Forms.Cursors.Default;
            this.bt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Uebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Uebernehmen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Uebernehmen.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.bt_Uebernehmen.Location = new System.Drawing.Point(4, 4);
            this.bt_Uebernehmen.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Uebernehmen.Name = "bt_Uebernehmen";
            this.bt_Uebernehmen.Size = new System.Drawing.Size(208, 32);
            this.bt_Uebernehmen.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_Uebernehmen.TabIndex = 51;
            this.bt_Uebernehmen.Text = "Übernehmen";
            this.bt_Uebernehmen.UseSelectable = true;
            this.bt_Uebernehmen.Click += new System.EventHandler(this.bt_Uebernehmen_Click_1);
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.BackColor = System.Drawing.Color.White;
            this.bt_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Suchen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Suchen.FontWeight = MetroFramework.MetroButtonWeight.Light;
            this.bt_Suchen.Location = new System.Drawing.Point(220, 4);
            this.bt_Suchen.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Suchen.Name = "bt_Suchen";
            this.bt_Suchen.Size = new System.Drawing.Size(136, 32);
            this.bt_Suchen.Style = MetroFramework.MetroColorStyle.Silver;
            this.bt_Suchen.TabIndex = 54;
            this.bt_Suchen.Text = "Suchen AN";
            this.bt_Suchen.UseSelectable = true;
            this.bt_Suchen.Click += new System.EventHandler(this.bt_Suchen_Click);
            this.bt_Suchen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bt_Suchen_Click);
            // 
            // gv_Klassenstufe
            // 
            this.gv_Klassenstufe.AllowUserToResizeColumns = false;
            this.gv_Klassenstufe.AllowUserToResizeRows = false;
            this.gv_Klassenstufe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Klassenstufe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Klassenstufe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Klassenstufe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Klassenstufe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Klassenstufe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Klassenstufe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Klassenstufe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Klassenstufe.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Klassenstufe.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Klassenstufe.EnableHeadersVisualStyles = false;
            this.gv_Klassenstufe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Klassenstufe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Klassenstufe.Location = new System.Drawing.Point(4, 66);
            this.gv_Klassenstufe.Margin = new System.Windows.Forms.Padding(4);
            this.gv_Klassenstufe.MultiSelect = false;
            this.gv_Klassenstufe.Name = "gv_Klassenstufe";
            this.gv_Klassenstufe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Klassenstufe.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Klassenstufe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Klassenstufe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Klassenstufe.Size = new System.Drawing.Size(354, 541);
            this.gv_Klassenstufe.Style = MetroFramework.MetroColorStyle.Teal;
            this.gv_Klassenstufe.TabIndex = 50;
            this.gv_Klassenstufe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Suchen.Enabled = false;
            this.tb_Suchen.Location = new System.Drawing.Point(4, 35);
            this.tb_Suchen.Margin = new System.Windows.Forms.Padding(4);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.Size = new System.Drawing.Size(354, 22);
            this.tb_Suchen.TabIndex = 52;
            this.tb_Suchen.Visible = false;
            this.tb_Suchen.Click += new System.EventHandler(this.tb_Suchen_TextChanged);
            this.tb_Suchen.TextChanged += new System.EventHandler(this.tb_Suchen_TextChanged);
            // 
            // lb_Klassenstufe
            // 
            this.lb_Klassenstufe.AutoSize = true;
            this.lb_Klassenstufe.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_Klassenstufe.Location = new System.Drawing.Point(4, 0);
            this.lb_Klassenstufe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Klassenstufe.Name = "lb_Klassenstufe";
            this.lb_Klassenstufe.Size = new System.Drawing.Size(354, 20);
            this.lb_Klassenstufe.TabIndex = 53;
            this.lb_Klassenstufe.Text = "Suchen:";
            // 
            // tLP_Klassenstufe
            // 
            this.tLP_Klassenstufe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLP_Klassenstufe.AutoSize = true;
            this.tLP_Klassenstufe.ColumnCount = 1;
            this.tLP_Klassenstufe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLP_Klassenstufe.Controls.Add(this.lb_Klassenstufe, 0, 0);
            this.tLP_Klassenstufe.Controls.Add(this.tb_Suchen, 0, 1);
            this.tLP_Klassenstufe.Controls.Add(this.gv_Klassenstufe, 0, 2);
            this.tLP_Klassenstufe.Controls.Add(this.tLP_Button, 0, 3);
            this.tLP_Klassenstufe.Location = new System.Drawing.Point(24, 64);
            this.tLP_Klassenstufe.Margin = new System.Windows.Forms.Padding(4);
            this.tLP_Klassenstufe.Name = "tLP_Klassenstufe";
            this.tLP_Klassenstufe.RowCount = 4;
            this.tLP_Klassenstufe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.901961F));
            this.tLP_Klassenstufe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.901961F));
            this.tLP_Klassenstufe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.31373F));
            this.tLP_Klassenstufe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.882353F));
            this.tLP_Klassenstufe.Size = new System.Drawing.Size(362, 652);
            this.tLP_Klassenstufe.TabIndex = 61;
            // 
            // w_s_klassenstufe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 727);
            this.Controls.Add(this.tLP_Klassenstufe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(307, 574);
            this.Name = "w_s_klassenstufe";
            this.Padding = new System.Windows.Forms.Padding(20, 74, 20, 20);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Klassenstufen verwalten";
            this.tLP_Button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).EndInit();
            this.tLP_Klassenstufe.ResumeLayout(false);
            this.tLP_Klassenstufe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tLP_Button;
        private MetroFramework.Controls.MetroButton bt_Uebernehmen;
        private MetroFramework.Controls.MetroButton bt_Suchen;
        private MetroFramework.Controls.MetroGrid gv_Klassenstufe;
        private System.Windows.Forms.TextBox tb_Suchen;
        private MetroFramework.Controls.MetroLabel lb_Klassenstufe;
        private System.Windows.Forms.TableLayoutPanel tLP_Klassenstufe;
    }
}