namespace Bibo_Verwaltung
{
    partial class w_s_buch_stufe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_buch_stufe));
            this.gb_Klassenstufe = new System.Windows.Forms.GroupBox();
            this.gv_Klassenstufe = new MetroFramework.Controls.MetroGrid();
            this.gb_Buecher = new System.Windows.Forms.GroupBox();
            this.gv_Buecher = new MetroFramework.Controls.MetroGrid();
            this.btAbbrechen = new System.Windows.Forms.Button();
            this.bt_Bearbeiten = new System.Windows.Forms.Button();
            this.gb_Klassenstufe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).BeginInit();
            this.gb_Buecher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Buecher)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_Klassenstufe
            // 
            this.gb_Klassenstufe.Controls.Add(this.gv_Klassenstufe);
            this.gb_Klassenstufe.Location = new System.Drawing.Point(12, 12);
            this.gb_Klassenstufe.Name = "gb_Klassenstufe";
            this.gb_Klassenstufe.Size = new System.Drawing.Size(198, 308);
            this.gb_Klassenstufe.TabIndex = 2;
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
            // gb_Buecher
            // 
            this.gb_Buecher.Controls.Add(this.gv_Buecher);
            this.gb_Buecher.Location = new System.Drawing.Point(216, 12);
            this.gb_Buecher.Name = "gb_Buecher";
            this.gb_Buecher.Size = new System.Drawing.Size(365, 279);
            this.gb_Buecher.TabIndex = 3;
            this.gb_Buecher.TabStop = false;
            this.gb_Buecher.Text = "zugeordnete Bücher:";
            // 
            // gv_Buecher
            // 
            this.gv_Buecher.AllowUserToAddRows = false;
            this.gv_Buecher.AllowUserToDeleteRows = false;
            this.gv_Buecher.AllowUserToResizeColumns = false;
            this.gv_Buecher.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.gv_Buecher.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Buecher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Buecher.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Buecher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Buecher.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Buecher.DefaultCellStyle = dataGridViewCellStyle4;
            this.gv_Buecher.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gv_Buecher.Enabled = false;
            this.gv_Buecher.EnableHeadersVisualStyles = false;
            this.gv_Buecher.Location = new System.Drawing.Point(3, 16);
            this.gv_Buecher.Name = "gv_Buecher";
            this.gv_Buecher.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Buecher.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.gv_Buecher.RowHeadersWidth = 30;
            this.gv_Buecher.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.gv_Buecher.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_Buecher.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.gv_Buecher.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Gray;
            this.gv_Buecher.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gv_Buecher.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.gv_Buecher.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.gv_Buecher.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gv_Buecher.RowTemplate.ReadOnly = true;
            this.gv_Buecher.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Buecher.ShowCellErrors = false;
            this.gv_Buecher.ShowCellToolTips = false;
            this.gv_Buecher.ShowEditingIcon = false;
            this.gv_Buecher.ShowRowErrors = false;
            this.gv_Buecher.Size = new System.Drawing.Size(359, 260);
            this.gv_Buecher.TabIndex = 1;
            this.gv_Buecher.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Buecher_CellDoubleClick);
            // 
            // btAbbrechen
            // 
            this.btAbbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btAbbrechen.Location = new System.Drawing.Point(478, 294);
            this.btAbbrechen.Name = "btAbbrechen";
            this.btAbbrechen.Size = new System.Drawing.Size(100, 23);
            this.btAbbrechen.TabIndex = 6;
            this.btAbbrechen.Text = "Schließen";
            this.btAbbrechen.UseVisualStyleBackColor = true;
            // 
            // bt_Bearbeiten
            // 
            this.bt_Bearbeiten.Location = new System.Drawing.Point(219, 294);
            this.bt_Bearbeiten.Name = "bt_Bearbeiten";
            this.bt_Bearbeiten.Size = new System.Drawing.Size(149, 23);
            this.bt_Bearbeiten.TabIndex = 5;
            this.bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
            this.bt_Bearbeiten.UseVisualStyleBackColor = true;
            this.bt_Bearbeiten.Click += new System.EventHandler(this.bt_Bearbeiten_Click);
            // 
            // w_s_buch_stufe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btAbbrechen;
            this.ClientSize = new System.Drawing.Size(594, 326);
            this.Controls.Add(this.btAbbrechen);
            this.Controls.Add(this.bt_Bearbeiten);
            this.Controls.Add(this.gb_Buecher);
            this.Controls.Add(this.gb_Klassenstufe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "w_s_buch_stufe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Zuordnung der Bücher zur Klassenstufe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_buch_stufe_FormClosing);
            this.gb_Klassenstufe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).EndInit();
            this.gb_Buecher.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Buecher)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Klassenstufe;
        private MetroFramework.Controls.MetroGrid gv_Klassenstufe;
        private System.Windows.Forms.GroupBox gb_Buecher;
        private MetroFramework.Controls.MetroGrid gv_Buecher;
        private System.Windows.Forms.Button btAbbrechen;
        private System.Windows.Forms.Button bt_Bearbeiten;
    }
}