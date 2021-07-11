namespace Bibo_Verwaltung
{
    partial class FormAttribute
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAttribute));
            this.mbt_Uebernehmen = new MetroFramework.Controls.MetroButton();
            this.mbt_Suchen = new MetroFramework.Controls.MetroButton();
            this.lb_Suche = new MetroFramework.Controls.MetroLabel();
            this.gv_manage = new MetroFramework.Controls.MetroGrid();
            this.mbt_Import = new MetroFramework.Controls.MetroButton();
            this.tLP_Faecher = new System.Windows.Forms.TableLayoutPanel();
            this.tb_Suchen = new MetroFramework.Controls.MetroTextBox();
            this.mtb_Export = new MetroFramework.Controls.MetroButton();
            this.mbt_Cancel = new MetroFramework.Controls.MetroButton();
            this.bt_sort_on_off = new MetroFramework.Controls.MetroButton();
            this.styleManagerAttribute = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gv_manage)).BeginInit();
            this.tLP_Faecher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerAttribute)).BeginInit();
            this.SuspendLayout();
            // 
            // mbt_Uebernehmen
            // 
            this.mbt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mbt_Uebernehmen.DisplayFocus = true;
            this.mbt_Uebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbt_Uebernehmen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbt_Uebernehmen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbt_Uebernehmen.Location = new System.Drawing.Point(116, 586);
            this.mbt_Uebernehmen.MaximumSize = new System.Drawing.Size(0, 24);
            this.mbt_Uebernehmen.MinimumSize = new System.Drawing.Size(50, 24);
            this.mbt_Uebernehmen.Name = "mbt_Uebernehmen";
            this.mbt_Uebernehmen.Size = new System.Drawing.Size(108, 24);
            this.mbt_Uebernehmen.Style = MetroFramework.MetroColorStyle.Teal;
            this.mbt_Uebernehmen.TabIndex = 7;
            this.mbt_Uebernehmen.Text = "Übernehmen";
            this.mbt_Uebernehmen.UseSelectable = true;
            // 
            // mbt_Suchen
            // 
            this.mbt_Suchen.DisplayFocus = true;
            this.mbt_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbt_Suchen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbt_Suchen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbt_Suchen.Location = new System.Drawing.Point(3, 551);
            this.mbt_Suchen.MaximumSize = new System.Drawing.Size(0, 24);
            this.mbt_Suchen.MinimumSize = new System.Drawing.Size(50, 24);
            this.mbt_Suchen.Name = "mbt_Suchen";
            this.mbt_Suchen.Size = new System.Drawing.Size(107, 24);
            this.mbt_Suchen.Style = MetroFramework.MetroColorStyle.Teal;
            this.mbt_Suchen.TabIndex = 3;
            this.mbt_Suchen.Text = "Suchen AN";
            this.mbt_Suchen.UseSelectable = true;
            this.mbt_Suchen.Click += new System.EventHandler(this.Mbt_Suchen_Click);
            // 
            // lb_Suche
            // 
            this.lb_Suche.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Suche.AutoSize = true;
            this.tLP_Faecher.SetColumnSpan(this.lb_Suche, 3);
            this.lb_Suche.Location = new System.Drawing.Point(3, 0);
            this.lb_Suche.MinimumSize = new System.Drawing.Size(280, 24);
            this.lb_Suche.Name = "lb_Suche";
            this.lb_Suche.Size = new System.Drawing.Size(336, 24);
            this.lb_Suche.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Suche.TabIndex = 54;
            this.lb_Suche.Text = "Suchen:";
            this.lb_Suche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lb_Suche.Visible = false;
            // 
            // gv_manage
            // 
            this.gv_manage.AllowUserToResizeColumns = false;
            this.gv_manage.AllowUserToResizeRows = false;
            this.gv_manage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_manage.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_manage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_manage.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_manage.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_manage.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_manage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tLP_Faecher.SetColumnSpan(this.gv_manage, 3);
            this.gv_manage.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_manage.DefaultCellStyle = dataGridViewCellStyle5;
            this.gv_manage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_manage.EnableHeadersVisualStyles = false;
            this.gv_manage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_manage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_manage.Location = new System.Drawing.Point(3, 54);
            this.gv_manage.MultiSelect = false;
            this.gv_manage.Name = "gv_manage";
            this.gv_manage.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_manage.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_manage.RowHeadersWidth = 30;
            this.gv_manage.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_manage.RowTemplate.DividerHeight = 1;
            this.gv_manage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_manage.Size = new System.Drawing.Size(336, 491);
            this.gv_manage.TabIndex = 2;
            this.gv_manage.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gv_manage_KeyDown);
            this.gv_manage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Gv_manage_KeyPress);
            // 
            // mbt_Import
            // 
            this.mbt_Import.DisplayFocus = true;
            this.mbt_Import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbt_Import.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbt_Import.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbt_Import.Location = new System.Drawing.Point(116, 551);
            this.mbt_Import.MaximumSize = new System.Drawing.Size(0, 24);
            this.mbt_Import.MinimumSize = new System.Drawing.Size(50, 24);
            this.mbt_Import.Name = "mbt_Import";
            this.mbt_Import.Size = new System.Drawing.Size(108, 24);
            this.mbt_Import.Style = MetroFramework.MetroColorStyle.Teal;
            this.mbt_Import.TabIndex = 4;
            this.mbt_Import.Text = "Import";
            this.mbt_Import.UseSelectable = true;
            this.mbt_Import.Click += new System.EventHandler(this.Mbt_Import_Click);
            // 
            // tLP_Faecher
            // 
            this.tLP_Faecher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLP_Faecher.ColumnCount = 3;
            this.tLP_Faecher.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tLP_Faecher.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tLP_Faecher.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tLP_Faecher.Controls.Add(this.lb_Suche, 0, 0);
            this.tLP_Faecher.Controls.Add(this.tb_Suchen, 0, 1);
            this.tLP_Faecher.Controls.Add(this.gv_manage, 0, 2);
            this.tLP_Faecher.Controls.Add(this.mbt_Import, 1, 3);
            this.tLP_Faecher.Controls.Add(this.mbt_Suchen, 0, 3);
            this.tLP_Faecher.Controls.Add(this.mtb_Export, 2, 3);
            this.tLP_Faecher.Controls.Add(this.mbt_Cancel, 2, 4);
            this.tLP_Faecher.Controls.Add(this.mbt_Uebernehmen, 1, 4);
            this.tLP_Faecher.Controls.Add(this.bt_sort_on_off, 0, 4);
            this.tLP_Faecher.Location = new System.Drawing.Point(21, 61);
            this.tLP_Faecher.Margin = new System.Windows.Forms.Padding(1);
            this.tLP_Faecher.Name = "tLP_Faecher";
            this.tLP_Faecher.RowCount = 5;
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tLP_Faecher.Size = new System.Drawing.Size(342, 618);
            this.tLP_Faecher.TabIndex = 0;
            // 
            // tb_Suchen
            // 
            this.tb_Suchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tLP_Faecher.SetColumnSpan(this.tb_Suchen, 3);
            // 
            // 
            // 
            this.tb_Suchen.CustomButton.Image = null;
            this.tb_Suchen.CustomButton.Location = new System.Drawing.Point(314, 2);
            this.tb_Suchen.CustomButton.Name = "";
            this.tb_Suchen.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Suchen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Suchen.CustomButton.TabIndex = 1;
            this.tb_Suchen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Suchen.CustomButton.UseSelectable = true;
            this.tb_Suchen.CustomButton.Visible = false;
            this.tb_Suchen.Enabled = false;
            this.tb_Suchen.Lines = new string[0];
            this.tb_Suchen.Location = new System.Drawing.Point(3, 24);
            this.tb_Suchen.MaxLength = 32767;
            this.tb_Suchen.MinimumSize = new System.Drawing.Size(200, 24);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.PasswordChar = '\0';
            this.tb_Suchen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Suchen.SelectedText = "";
            this.tb_Suchen.SelectionLength = 0;
            this.tb_Suchen.SelectionStart = 0;
            this.tb_Suchen.ShortcutsEnabled = true;
            this.tb_Suchen.Size = new System.Drawing.Size(336, 24);
            this.tb_Suchen.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_Suchen.TabIndex = 1;
            this.tb_Suchen.UseSelectable = true;
            this.tb_Suchen.Visible = false;
            this.tb_Suchen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Suchen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Suchen.TextChanged += new System.EventHandler(this.Tb_Suchen_TextChanged);
            // 
            // mtb_Export
            // 
            this.mtb_Export.DisplayFocus = true;
            this.mtb_Export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mtb_Export.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mtb_Export.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mtb_Export.Location = new System.Drawing.Point(230, 551);
            this.mtb_Export.MaximumSize = new System.Drawing.Size(0, 24);
            this.mtb_Export.MinimumSize = new System.Drawing.Size(50, 24);
            this.mtb_Export.Name = "mtb_Export";
            this.mtb_Export.Size = new System.Drawing.Size(109, 24);
            this.mtb_Export.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtb_Export.TabIndex = 5;
            this.mtb_Export.Text = "Export";
            this.mtb_Export.UseSelectable = true;
            this.mtb_Export.Click += new System.EventHandler(this.Mtb_Export_Click);
            // 
            // mbt_Cancel
            // 
            this.mbt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbt_Cancel.DisplayFocus = true;
            this.mbt_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mbt_Cancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbt_Cancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbt_Cancel.Location = new System.Drawing.Point(230, 586);
            this.mbt_Cancel.MaximumSize = new System.Drawing.Size(0, 24);
            this.mbt_Cancel.Name = "mbt_Cancel";
            this.mbt_Cancel.Size = new System.Drawing.Size(109, 24);
            this.mbt_Cancel.TabIndex = 8;
            this.mbt_Cancel.Text = "Abbrechen";
            this.mbt_Cancel.UseSelectable = true;
            // 
            // bt_sort_on_off
            // 
            this.bt_sort_on_off.DisplayFocus = true;
            this.bt_sort_on_off.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_sort_on_off.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_sort_on_off.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_sort_on_off.Location = new System.Drawing.Point(3, 586);
            this.bt_sort_on_off.MaximumSize = new System.Drawing.Size(0, 24);
            this.bt_sort_on_off.MinimumSize = new System.Drawing.Size(50, 24);
            this.bt_sort_on_off.Name = "bt_sort_on_off";
            this.bt_sort_on_off.Size = new System.Drawing.Size(107, 24);
            this.bt_sort_on_off.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_sort_on_off.TabIndex = 6;
            this.bt_sort_on_off.Text = "unsortiert";
            this.bt_sort_on_off.UseSelectable = true;
            this.bt_sort_on_off.Click += new System.EventHandler(this.Bt_sort_on_off_Click);
            // 
            // styleManagerAttribute
            // 
            this.styleManagerAttribute.Owner = this;
            this.styleManagerAttribute.Style = MetroFramework.MetroColorStyle.Teal;
            // 
            // w_s_manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 700);
            this.Controls.Add(this.tLP_Faecher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(384, 700);
            this.Name = "w_s_manage";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "-";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.W_s_manage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_manage)).EndInit();
            this.tLP_Faecher.ResumeLayout(false);
            this.tLP_Faecher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerAttribute)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton mbt_Uebernehmen;
        private MetroFramework.Controls.MetroButton mbt_Suchen;
        private MetroFramework.Controls.MetroLabel lb_Suche;
        private System.Windows.Forms.TableLayoutPanel tLP_Faecher;
        private MetroFramework.Controls.MetroTextBox tb_Suchen;
        private MetroFramework.Controls.MetroGrid gv_manage;
        private MetroFramework.Controls.MetroButton mbt_Import;
        private MetroFramework.Controls.MetroButton mtb_Export;
        private MetroFramework.Controls.MetroButton mbt_Cancel;
        private MetroFramework.Controls.MetroButton bt_sort_on_off;
        private MetroFramework.Components.MetroStyleManager styleManagerAttribute;
    }
}