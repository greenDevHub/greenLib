namespace Bibo_Verwaltung
{
    partial class w_s_fach_stufe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_fach_stufe));
            this.gb_Klassenstufe = new System.Windows.Forms.GroupBox();
            this.gv_Klassenstufe = new MetroFramework.Controls.MetroGrid();
            this.gb_Faecher = new System.Windows.Forms.GroupBox();
            this.gv_Faecher = new MetroFramework.Controls.MetroGrid();
            this.bt_Bearbeiten = new System.Windows.Forms.Button();
            this.btAbbrechen = new System.Windows.Forms.Button();
            this.gb_Klassenstufe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).BeginInit();
            this.gb_Faecher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Faecher)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Klassenstufe
            // 
            this.gb_Klassenstufe.Controls.Add(this.gv_Klassenstufe);
            this.gb_Klassenstufe.Location = new System.Drawing.Point(12, 12);
            this.gb_Klassenstufe.Name = "gb_Klassenstufe";
            this.gb_Klassenstufe.Size = new System.Drawing.Size(198, 308);
            this.gb_Klassenstufe.TabIndex = 1;
            this.gb_Klassenstufe.TabStop = false;
            this.gb_Klassenstufe.Text = "Klassenstufen:";
            // 
            // gv_Klassenstufe
            // 
            this.gv_Klassenstufe.AllowUserToAddRows = false;
            this.gv_Klassenstufe.AllowUserToDeleteRows = false;
            this.gv_Klassenstufe.AllowUserToResizeColumns = false;
            this.gv_Klassenstufe.AllowUserToResizeRows = false;
            this.gv_Klassenstufe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Klassenstufe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Klassenstufe.ColumnHeadersVisible = false;
            this.gv_Klassenstufe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gv_Klassenstufe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Klassenstufe.Location = new System.Drawing.Point(3, 16);
            this.gv_Klassenstufe.MultiSelect = false;
            this.gv_Klassenstufe.Name = "gv_Klassenstufe";
            this.gv_Klassenstufe.ReadOnly = true;
            this.gv_Klassenstufe.RowHeadersVisible = false;
            this.gv_Klassenstufe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.gv_Klassenstufe.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Klassenstufe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Klassenstufe.ShowCellErrors = false;
            this.gv_Klassenstufe.ShowCellToolTips = false;
            this.gv_Klassenstufe.ShowEditingIcon = false;
            this.gv_Klassenstufe.ShowRowErrors = false;
            this.gv_Klassenstufe.Size = new System.Drawing.Size(192, 289);
            this.gv_Klassenstufe.TabIndex = 0;
            this.gv_Klassenstufe.SelectionChanged += new System.EventHandler(this.gv_Klassenstufe_SelectionChanged);
            // 
            // gb_Faecher
            // 
            this.gb_Faecher.Controls.Add(this.gv_Faecher);
            this.gb_Faecher.Location = new System.Drawing.Point(216, 12);
            this.gb_Faecher.Name = "gb_Faecher";
            this.gb_Faecher.Size = new System.Drawing.Size(365, 279);
            this.gb_Faecher.TabIndex = 2;
            this.gb_Faecher.TabStop = false;
            this.gb_Faecher.Text = "zugeordnete Fächer:";
            // 
            // gv_Faecher
            // 
            this.gv_Faecher.AllowUserToAddRows = false;
            this.gv_Faecher.AllowUserToDeleteRows = false;
            this.gv_Faecher.AllowUserToResizeColumns = false;
            this.gv_Faecher.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gv_Faecher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Faecher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Faecher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Faecher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Faecher.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Faecher.DefaultCellStyle = dataGridViewCellStyle4;
            this.gv_Faecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Faecher.Enabled = false;
            this.gv_Faecher.EnableHeadersVisualStyles = false;
            this.gv_Faecher.Location = new System.Drawing.Point(3, 16);
            this.gv_Faecher.Name = "gv_Faecher";
            this.gv_Faecher.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Faecher.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_Faecher.RowHeadersWidth = 30;
            this.gv_Faecher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.gv_Faecher.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_Faecher.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gv_Faecher.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.gv_Faecher.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_Faecher.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gv_Faecher.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.gv_Faecher.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gv_Faecher.RowTemplate.ReadOnly = true;
            this.gv_Faecher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Faecher.ShowCellErrors = false;
            this.gv_Faecher.ShowCellToolTips = false;
            this.gv_Faecher.ShowEditingIcon = false;
            this.gv_Faecher.ShowRowErrors = false;
            this.gv_Faecher.Size = new System.Drawing.Size(359, 260);
            this.gv_Faecher.TabIndex = 1;
            this.gv_Faecher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Faecher_CellDoubleClick);
            // 
            // bt_Bearbeiten
            // 
            this.bt_Bearbeiten.Location = new System.Drawing.Point(219, 294);
            this.bt_Bearbeiten.Name = "bt_Bearbeiten";
            this.bt_Bearbeiten.Size = new System.Drawing.Size(149, 23);
            this.bt_Bearbeiten.TabIndex = 3;
            this.bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
            this.bt_Bearbeiten.UseVisualStyleBackColor = true;
            this.bt_Bearbeiten.Click += new System.EventHandler(this.bt_Bearbeiten_Click);
            // 
            // btAbbrechen
            // 
            this.btAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAbbrechen.Location = new System.Drawing.Point(478, 294);
            this.btAbbrechen.Name = "btAbbrechen";
            this.btAbbrechen.Size = new System.Drawing.Size(100, 23);
            this.btAbbrechen.TabIndex = 4;
            this.btAbbrechen.Text = "Schließen";
            this.btAbbrechen.UseVisualStyleBackColor = true;
            // 
            // w_s_fach_stufe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAbbrechen;
            this.ClientSize = new System.Drawing.Size(594, 326);
            this.Controls.Add(this.btAbbrechen);
            this.Controls.Add(this.bt_Bearbeiten);
            this.Controls.Add(this.gb_Faecher);
            this.Controls.Add(this.gb_Klassenstufe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximizeBox = false;
            this.Name = "w_s_fach_stufe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zuordnung der Fächer zur Klassenstufe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_fach_stufe_FormClosing);
            this.gb_Klassenstufe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).EndInit();
            this.gb_Faecher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Faecher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Klassenstufe;
        private MetroFramework.Controls.MetroGrid gv_Klassenstufe;
        private System.Windows.Forms.GroupBox gb_Faecher;
        private MetroFramework.Controls.MetroGrid gv_Faecher;
        private System.Windows.Forms.Button bt_Bearbeiten;
        private System.Windows.Forms.Button btAbbrechen;
    }
}