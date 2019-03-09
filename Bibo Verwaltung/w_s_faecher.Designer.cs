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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_faecher));
            this.bt_Uebernehmen = new MetroFramework.Controls.MetroButton();
            this.bt_Suchen = new MetroFramework.Controls.MetroButton();
            this.bt_import = new MetroFramework.Controls.MetroButton();
            this.gv_Faecher = new MetroFramework.Controls.MetroGrid();
            this.tLP_Faecher = new System.Windows.Forms.TableLayoutPanel();
            this.tLP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.bt_verwaltung = new MetroFramework.Controls.MetroButton();
            this.lb_Faecher = new MetroFramework.Controls.MetroLabel();
            this.tb_Suchen = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Faecher)).BeginInit();
            this.tLP_Faecher.SuspendLayout();
            this.tLP_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Uebernehmen
            // 
            this.bt_Uebernehmen.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_Uebernehmen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Uebernehmen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Uebernehmen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_Uebernehmen.Location = new System.Drawing.Point(3, 3);
            this.bt_Uebernehmen.MaximumSize = new System.Drawing.Size(200, 24);
            this.bt_Uebernehmen.MinimumSize = new System.Drawing.Size(50, 24);
            this.bt_Uebernehmen.Name = "bt_Uebernehmen";
            this.bt_Uebernehmen.Size = new System.Drawing.Size(108, 24);
            this.bt_Uebernehmen.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_Uebernehmen.TabIndex = 51;
            this.bt_Uebernehmen.Text = "Übernehmen";
            this.bt_Uebernehmen.UseSelectable = true;
            // 
            // bt_Suchen
            // 
            this.bt_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_Suchen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Suchen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_Suchen.Location = new System.Drawing.Point(202, 3);
            this.bt_Suchen.MaximumSize = new System.Drawing.Size(200, 24);
            this.bt_Suchen.MinimumSize = new System.Drawing.Size(50, 24);
            this.bt_Suchen.Name = "bt_Suchen";
            this.bt_Suchen.Size = new System.Drawing.Size(81, 24);
            this.bt_Suchen.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_Suchen.TabIndex = 54;
            this.bt_Suchen.Text = "Suchen AN";
            this.bt_Suchen.UseSelectable = true;
            this.bt_Suchen.Click += new System.EventHandler(this.bt_Suchen_Click);
            // 
            // bt_import
            // 
            this.bt_import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_import.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_import.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_import.Location = new System.Drawing.Point(117, 3);
            this.bt_import.MaximumSize = new System.Drawing.Size(200, 24);
            this.bt_import.MinimumSize = new System.Drawing.Size(50, 24);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(79, 24);
            this.bt_import.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_import.TabIndex = 55;
            this.bt_import.Text = "Import";
            this.bt_import.UseSelectable = true;
            this.bt_import.Click += new System.EventHandler(this.bt_import_Click_1);
            // 
            // gv_Faecher
            // 
            this.gv_Faecher.AllowUserToResizeColumns = false;
            this.gv_Faecher.AllowUserToResizeRows = false;
            this.gv_Faecher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Faecher.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Faecher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Faecher.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Faecher.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Faecher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Faecher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Faecher.Cursor = System.Windows.Forms.Cursors.IBeam;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Faecher.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Faecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Faecher.EnableHeadersVisualStyles = false;
            this.gv_Faecher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Faecher.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Faecher.Location = new System.Drawing.Point(3, 63);
            this.gv_Faecher.MultiSelect = false;
            this.gv_Faecher.Name = "gv_Faecher";
            this.gv_Faecher.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(201)))), ((int)(((byte)(206)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Faecher.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Faecher.RowHeadersVisible = false;
            this.gv_Faecher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Faecher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Faecher.Size = new System.Drawing.Size(282, 496);
            this.gv_Faecher.Style = MetroFramework.MetroColorStyle.Teal;
            this.gv_Faecher.TabIndex = 50;
            this.gv_Faecher.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.gv_Verlage_CellBeginEdit);
            this.gv_Faecher.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.gv_Verlage_UserDeletedRow);
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
            this.tLP_Faecher.Location = new System.Drawing.Point(21, 61);
            this.tLP_Faecher.Margin = new System.Windows.Forms.Padding(1);
            this.tLP_Faecher.Name = "tLP_Faecher";
            this.tLP_Faecher.RowCount = 5;
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLP_Faecher.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tLP_Faecher.Size = new System.Drawing.Size(288, 622);
            this.tLP_Faecher.TabIndex = 0;
            // 
            // tLP_Buttons
            // 
            this.tLP_Buttons.ColumnCount = 3;
            this.tLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tLP_Buttons.Controls.Add(this.bt_Uebernehmen, 0, 0);
            this.tLP_Buttons.Controls.Add(this.bt_Suchen, 2, 0);
            this.tLP_Buttons.Controls.Add(this.bt_import, 1, 0);
            this.tLP_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLP_Buttons.Location = new System.Drawing.Point(1, 563);
            this.tLP_Buttons.Margin = new System.Windows.Forms.Padding(1);
            this.tLP_Buttons.Name = "tLP_Buttons";
            this.tLP_Buttons.RowCount = 1;
            this.tLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 2.733119F));
            this.tLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tLP_Buttons.Size = new System.Drawing.Size(286, 28);
            this.tLP_Buttons.TabIndex = 56;
            // 
            // bt_verwaltung
            // 
            this.bt_verwaltung.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt_verwaltung.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_verwaltung.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_verwaltung.Location = new System.Drawing.Point(3, 595);
            this.bt_verwaltung.MaximumSize = new System.Drawing.Size(400, 24);
            this.bt_verwaltung.MinimumSize = new System.Drawing.Size(100, 24);
            this.bt_verwaltung.Name = "bt_verwaltung";
            this.bt_verwaltung.Size = new System.Drawing.Size(282, 24);
            this.bt_verwaltung.Style = MetroFramework.MetroColorStyle.Teal;
            this.bt_verwaltung.TabIndex = 54;
            this.bt_verwaltung.Text = "Fächer zu Klassenstufen zuordnen";
            this.bt_verwaltung.UseSelectable = true;
            this.bt_verwaltung.Click += new System.EventHandler(this.bt_Verwaltung_Click);
            // 
            // lb_Faecher
            // 
            this.lb_Faecher.AutoSize = true;
            this.lb_Faecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_Faecher.Location = new System.Drawing.Point(3, 0);
            this.lb_Faecher.MaximumSize = new System.Drawing.Size(400, 24);
            this.lb_Faecher.MinimumSize = new System.Drawing.Size(280, 24);
            this.lb_Faecher.Name = "lb_Faecher";
            this.lb_Faecher.Size = new System.Drawing.Size(282, 24);
            this.lb_Faecher.Style = MetroFramework.MetroColorStyle.Teal;
            this.lb_Faecher.TabIndex = 54;
            this.lb_Faecher.Text = "Suchen:";
            this.lb_Faecher.Visible = false;
            // 
            // tb_Suchen
            // 
            // 
            // 
            // 
            this.tb_Suchen.CustomButton.Image = null;
            this.tb_Suchen.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.tb_Suchen.CustomButton.Name = "";
            this.tb_Suchen.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.tb_Suchen.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_Suchen.CustomButton.TabIndex = 1;
            this.tb_Suchen.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_Suchen.CustomButton.UseSelectable = true;
            this.tb_Suchen.CustomButton.Visible = false;
            this.tb_Suchen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_Suchen.Enabled = false;
            this.tb_Suchen.Lines = new string[0];
            this.tb_Suchen.Location = new System.Drawing.Point(3, 33);
            this.tb_Suchen.MaximumSize = new System.Drawing.Size(400, 24);
            this.tb_Suchen.MaxLength = 32767;
            this.tb_Suchen.MinimumSize = new System.Drawing.Size(200, 24);
            this.tb_Suchen.Name = "tb_Suchen";
            this.tb_Suchen.PasswordChar = '\0';
            this.tb_Suchen.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_Suchen.SelectedText = "";
            this.tb_Suchen.SelectionLength = 0;
            this.tb_Suchen.SelectionStart = 0;
            this.tb_Suchen.ShortcutsEnabled = true;
            this.tb_Suchen.Size = new System.Drawing.Size(282, 24);
            this.tb_Suchen.Style = MetroFramework.MetroColorStyle.Teal;
            this.tb_Suchen.TabIndex = 52;
            this.tb_Suchen.UseSelectable = true;
            this.tb_Suchen.Visible = false;
            this.tb_Suchen.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_Suchen.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_Suchen.TextChanged += new System.EventHandler(this.tb_Suchen_TextChanged);
            // 
            // w_s_faecher
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(327, 694);
            this.Controls.Add(this.tLP_Faecher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "w_s_faecher";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Fächer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_faecher_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Faecher)).EndInit();
            this.tLP_Faecher.ResumeLayout(false);
            this.tLP_Faecher.PerformLayout();
            this.tLP_Buttons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroGrid gv_Faecher;
        private MetroFramework.Controls.MetroButton bt_Uebernehmen;
        private MetroFramework.Controls.MetroButton bt_Suchen;
        private MetroFramework.Controls.MetroButton bt_import;
        private MetroFramework.Controls.MetroButton bt_verwaltung;
        private System.Windows.Forms.TableLayoutPanel tLP_Faecher;
        private System.Windows.Forms.TableLayoutPanel tLP_Buttons;
        private MetroFramework.Controls.MetroLabel lb_Faecher;
        private MetroFramework.Controls.MetroTextBox tb_Suchen;
    }
}