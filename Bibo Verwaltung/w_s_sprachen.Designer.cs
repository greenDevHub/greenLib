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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_sprachen));
            this.tLP_Sprachen = new System.Windows.Forms.TableLayoutPanel();
            this.lb_Sprachen = new MetroFramework.Controls.MetroLabel();
            this.gv_Sprachen = new MetroFramework.Controls.MetroGrid();
            this.bt_Uebernehmen = new MetroFramework.Controls.MetroButton();
            this.bt_Suchen = new MetroFramework.Controls.MetroButton();
            this.tb_Suchen = new MetroFramework.Controls.MetroTextBox();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.tLP_Sprachen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sprachen)).BeginInit();
            this.SuspendLayout();
            // 
            // tLP_Sprachen
            // 
            this.tLP_Sprachen.ColumnCount = 2;
            this.tLP_Sprachen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Sprachen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tLP_Sprachen.Controls.Add(this.bt_Uebernehmen, 0, 3);
            this.tLP_Sprachen.Controls.Add(this.lb_Sprachen, 0, 0);
            this.tLP_Sprachen.Controls.Add(this.bt_Suchen, 1, 3);
            this.tLP_Sprachen.Controls.Add(this.gv_Sprachen, 0, 2);
            this.tLP_Sprachen.Controls.Add(this.tb_Suchen, 0, 1);
            this.tLP_Sprachen.Location = new System.Drawing.Point(23, 63);
            this.tLP_Sprachen.Name = "tLP_Sprachen";
            this.tLP_Sprachen.RowCount = 4;
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Sprachen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLP_Sprachen.Size = new System.Drawing.Size(304, 614);
            this.tLP_Sprachen.TabIndex = 61;
            // 
            // lb_Sprachen
            // 
            this.lb_Sprachen.AutoSize = true;
            this.tLP_Sprachen.SetColumnSpan(this.lb_Sprachen, 2);
            this.lb_Sprachen.Dock = System.Windows.Forms.DockStyle.Top;
            this.helpProvider.SetHelpString(this.lb_Sprachen, "Suchen sie nach gespeicherten Sprachen.");
            this.lb_Sprachen.Location = new System.Drawing.Point(3, 0);
            this.lb_Sprachen.Name = "lb_Sprachen";
            this.helpProvider.SetShowHelp(this.lb_Sprachen, true);
            this.lb_Sprachen.Size = new System.Drawing.Size(298, 19);
            this.lb_Sprachen.TabIndex = 53;
            this.lb_Sprachen.Text = "Suchen:";
            // 
            // gv_Sprachen
            // 
            this.gv_Sprachen.AllowUserToResizeColumns = false;
            this.gv_Sprachen.AllowUserToResizeRows = false;
            this.gv_Sprachen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Sprachen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Sprachen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Sprachen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Sprachen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Sprachen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Sprachen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tLP_Sprachen.SetColumnSpan(this.gv_Sprachen, 2);
            this.gv_Sprachen.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Sprachen.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Sprachen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Sprachen.EnableHeadersVisualStyles = false;
            this.gv_Sprachen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Sprachen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.helpProvider.SetHelpString(this.gv_Sprachen, "Hier werden all ihre gespeicherten Sprachen angezeigt.");
            this.gv_Sprachen.Location = new System.Drawing.Point(3, 63);
            this.gv_Sprachen.MultiSelect = false;
            this.gv_Sprachen.Name = "gv_Sprachen";
            this.gv_Sprachen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Sprachen.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Sprachen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Sprachen.RowTemplate.DividerHeight = 1;
            this.gv_Sprachen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.helpProvider.SetShowHelp(this.gv_Sprachen, true);
            this.gv_Sprachen.Size = new System.Drawing.Size(298, 518);
            this.gv_Sprachen.TabIndex = 50;
            this.gv_Sprachen.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_Sprachen_CellBeginEdit);
            this.gv_Sprachen.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Sprachen_CellEndEdit);
            this.gv_Sprachen.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gv_Sprachen_UserDeletedRow);
            this.gv_Sprachen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dataGridView_KeyPress);
            // 
            // bt_Uebernehmen
            // 
            this.bt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Uebernehmen.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Uebernehmen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Uebernehmen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Uebernehmen, "Klicken sie auf diesen Button, um alle Änderungen zu übernehmen.");
            this.bt_Uebernehmen.Location = new System.Drawing.Point(3, 587);
            this.bt_Uebernehmen.MaximumSize = new System.Drawing.Size(200, 24);
            this.bt_Uebernehmen.MinimumSize = new System.Drawing.Size(50, 24);
            this.bt_Uebernehmen.Name = "bt_Uebernehmen";
            this.helpProvider.SetShowHelp(this.bt_Uebernehmen, true);
            this.bt_Uebernehmen.Size = new System.Drawing.Size(146, 24);
            this.bt_Uebernehmen.TabIndex = 51;
            this.bt_Uebernehmen.Text = "Übernehmen";
            this.bt_Uebernehmen.UseSelectable = true;
            this.bt_Uebernehmen.Click += new System.EventHandler(this.bt_Uebernehmen_Click);
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Dock = System.Windows.Forms.DockStyle.Top;
            this.bt_Suchen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Suchen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.helpProvider.SetHelpString(this.bt_Suchen, "Klicken sie auf diesen Button, um die Suchfunktion an- bzw. auszuschalten.");
            this.bt_Suchen.Location = new System.Drawing.Point(155, 587);
            this.bt_Suchen.MaximumSize = new System.Drawing.Size(200, 24);
            this.bt_Suchen.MinimumSize = new System.Drawing.Size(50, 24);
            this.bt_Suchen.Name = "bt_Suchen";
            this.helpProvider.SetShowHelp(this.bt_Suchen, true);
            this.bt_Suchen.Size = new System.Drawing.Size(146, 24);
            this.bt_Suchen.TabIndex = 54;
            this.bt_Suchen.Text = "Suchen AN";
            this.bt_Suchen.UseSelectable = true;
            this.bt_Suchen.Click += new System.EventHandler(this.bt_Suchen_Click);
            // 
            // tb_Suchen
            // 
            this.tLP_Sprachen.SetColumnSpan(this.tb_Suchen, 2);
            // 
            // 
            // 
            this.tb_Suchen.CustomButton.Image = null;
            this.tb_Suchen.CustomButton.Location = new System.Drawing.Point(276, 2);
            this.tb_Suchen.CustomButton.Name = "";
            this.tb_Suchen.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Suchen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Suchen.CustomButton.TabIndex = 1;
            this.tb_Suchen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Suchen.CustomButton.UseSelectable = true;
            this.tb_Suchen.CustomButton.Visible = false;
            this.tb_Suchen.Dock = System.Windows.Forms.DockStyle.Top;
            this.tb_Suchen.Enabled = false;
            this.helpProvider.SetHelpString(this.tb_Suchen, "Suchen sie nach gespeicherten Sprachen.");
            this.tb_Suchen.Lines = new string[0];
            this.tb_Suchen.Location = new System.Drawing.Point(3, 33);
            this.tb_Suchen.MaximumSize = new System.Drawing.Size(500, 24);
            this.tb_Suchen.MaxLength = 32767;
            this.tb_Suchen.MinimumSize = new System.Drawing.Size(50, 24);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.PasswordChar = '\0';
            this.tb_Suchen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Suchen.SelectedText = "";
            this.tb_Suchen.SelectionLength = 0;
            this.tb_Suchen.SelectionStart = 0;
            this.tb_Suchen.ShortcutsEnabled = true;
            this.helpProvider.SetShowHelp(this.tb_Suchen, true);
            this.tb_Suchen.Size = new System.Drawing.Size(298, 24);
            this.tb_Suchen.TabIndex = 52;
            this.tb_Suchen.UseSelectable = true;
            this.tb_Suchen.Visible = false;
            this.tb_Suchen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Suchen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Suchen.TextChanged += new System.EventHandler(this.tb_Suchen_TextChanged);
            // 
            // w_s_sprachen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(350, 700);
            this.Controls.Add(this.tLP_Sprachen);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_sprachen";
            this.Resizable = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sprachen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_sprachen_FormClosing);
            this.tLP_Sprachen.ResumeLayout(false);
            this.tLP_Sprachen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Sprachen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tLP_Sprachen;
        private MetroFramework.Controls.MetroLabel lb_Sprachen;
        private MetroFramework.Controls.MetroTextBox tb_Suchen;
        private MetroFramework.Controls.MetroGrid gv_Sprachen;
        private MetroFramework.Controls.MetroButton bt_Uebernehmen;
        private MetroFramework.Controls.MetroButton bt_Suchen;
        private System.Windows.Forms.HelpProvider helpProvider;
    }
}