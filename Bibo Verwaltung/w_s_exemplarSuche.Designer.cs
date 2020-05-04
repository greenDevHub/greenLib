namespace Bibo_Verwaltung
{
    partial class w_s_exemplarSuche
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_exemplarSuche));
            this.a_cb_Buecher = new Bibo_Verwaltung.AdvancedComboBox();
            this.gv_Exemplare = new MetroFramework.Controls.MetroGrid();
            this.mbt_OK = new MetroFramework.Controls.MetroButton();
            this.mlb_Suche = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Exemplare)).BeginInit();
            this.SuspendLayout();
            // 
            // a_cb_Buecher
            // 
            this.a_cb_Buecher.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.a_cb_Buecher.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.a_cb_Buecher.BorderColor = System.Drawing.Color.Gray;
            this.a_cb_Buecher.DataRowView = true;
            this.a_cb_Buecher.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.a_cb_Buecher.FormattingEnabled = true;
            this.a_cb_Buecher.HighlightColor = System.Drawing.Color.Gray;
            this.a_cb_Buecher.Location = new System.Drawing.Point(23, 63);
            this.a_cb_Buecher.Name = "a_cb_Buecher";
            this.a_cb_Buecher.Size = new System.Drawing.Size(554, 27);
            this.a_cb_Buecher.TabIndex = 0;
            this.a_cb_Buecher.SelectedIndexChanged += new System.EventHandler(this.AdvancedComboBox1_SelectedIndexChanged);
            // 
            // gv_Exemplare
            // 
            this.gv_Exemplare.AllowUserToAddRows = false;
            this.gv_Exemplare.AllowUserToDeleteRows = false;
            this.gv_Exemplare.AllowUserToOrderColumns = true;
            this.gv_Exemplare.AllowUserToResizeColumns = false;
            this.gv_Exemplare.AllowUserToResizeRows = false;
            this.gv_Exemplare.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gv_Exemplare.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Exemplare.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Exemplare.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Exemplare.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Exemplare.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Exemplare.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Exemplare.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Exemplare.EnableHeadersVisualStyles = false;
            this.gv_Exemplare.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Exemplare.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Exemplare.Location = new System.Drawing.Point(23, 115);
            this.gv_Exemplare.MultiSelect = false;
            this.gv_Exemplare.Name = "gv_Exemplare";
            this.gv_Exemplare.ReadOnly = true;
            this.gv_Exemplare.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(196)))), ((int)(((byte)(37)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(57)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Exemplare.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Exemplare.RowHeadersWidth = 30;
            this.gv_Exemplare.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Exemplare.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Exemplare.ShowCellErrors = false;
            this.gv_Exemplare.ShowEditingIcon = false;
            this.gv_Exemplare.ShowRowErrors = false;
            this.gv_Exemplare.Size = new System.Drawing.Size(554, 283);
            this.gv_Exemplare.Style = MetroFramework.MetroColorStyle.Yellow;
            this.gv_Exemplare.TabIndex = 1;
            this.gv_Exemplare.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Exemplare_CellDoubleClick);
            // 
            // mbt_OK
            // 
            this.mbt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.mbt_OK.DisplayFocus = true;
            this.mbt_OK.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbt_OK.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbt_OK.Location = new System.Drawing.Point(477, 404);
            this.mbt_OK.Name = "mbt_OK";
            this.mbt_OK.Size = new System.Drawing.Size(100, 23);
            this.mbt_OK.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mbt_OK.TabIndex = 2;
            this.mbt_OK.Text = "OK";
            this.mbt_OK.UseSelectable = true;
            this.mbt_OK.Click += new System.EventHandler(this.Mbt_OK_Click);
            // 
            // mlb_Suche
            // 
            this.mlb_Suche.AutoSize = true;
            this.mlb_Suche.Location = new System.Drawing.Point(23, 93);
            this.mlb_Suche.Name = "mlb_Suche";
            this.mlb_Suche.Size = new System.Drawing.Size(101, 19);
            this.mlb_Suche.TabIndex = 3;
            this.mlb_Suche.Text = "Suchergebnisse:";
            // 
            // w_s_exemplarSuche
            // 
            this.AcceptButton = this.mbt_OK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.mlb_Suche);
            this.Controls.Add(this.mbt_OK);
            this.Controls.Add(this.gv_Exemplare);
            this.Controls.Add(this.a_cb_Buecher);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_exemplarSuche";
            this.Resizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Style = MetroFramework.MetroColorStyle.Yellow;
            this.Text = "Exemplar-Suche";
            ((System.ComponentModel.ISupportInitialize)(this.gv_Exemplare)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdvancedComboBox a_cb_Buecher;
        private MetroFramework.Controls.MetroGrid gv_Exemplare;
        private MetroFramework.Controls.MetroButton mbt_OK;
        private MetroFramework.Controls.MetroLabel mlb_Suche;
    }
}