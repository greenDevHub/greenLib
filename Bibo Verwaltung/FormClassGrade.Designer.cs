namespace Bibo_Verwaltung
{
    partial class FormClassGrade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClassGrade));
            this.gv_Klassen = new MetroFramework.Controls.MetroGrid();
            this.gv_Klassenstufe = new MetroFramework.Controls.MetroGrid();
            this.bt_back = new MetroFramework.Controls.MetroButton();
            this.lb_Klassen = new MetroFramework.Controls.MetroLabel();
            this.lb_Klassenstufe = new MetroFramework.Controls.MetroLabel();
            this.bt_Abbrechen = new MetroFramework.Controls.MetroButton();
            this.bt_Bearbeiten = new MetroFramework.Controls.MetroButton();
            this.mbt_ImEx = new MetroFramework.Controls.MetroButton();
            this.styleManagerClassGrade = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tb_klasse = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerClassGrade)).BeginInit();
            this.SuspendLayout();
            // 
            // gv_Klassen
            // 
            this.gv_Klassen.AllowUserToAddRows = false;
            this.gv_Klassen.AllowUserToDeleteRows = false;
            this.gv_Klassen.AllowUserToResizeColumns = false;
            this.gv_Klassen.AllowUserToResizeRows = false;
            this.gv_Klassen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv_Klassen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gv_Klassen.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Klassen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Klassen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Klassen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Klassen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gv_Klassen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Klassen.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Klassen.DefaultCellStyle = dataGridViewCellStyle2;
            this.gv_Klassen.Enabled = false;
            this.gv_Klassen.EnableHeadersVisualStyles = false;
            this.gv_Klassen.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Klassen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Klassen.Location = new System.Drawing.Point(302, 82);
            this.gv_Klassen.MultiSelect = false;
            this.gv_Klassen.Name = "gv_Klassen";
            this.gv_Klassen.ReadOnly = true;
            this.gv_Klassen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Klassen.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gv_Klassen.RowHeadersWidth = 5;
            this.gv_Klassen.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Klassen.RowTemplate.DividerHeight = 1;
            this.gv_Klassen.RowTemplate.ReadOnly = true;
            this.gv_Klassen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Klassen.ShowCellErrors = false;
            this.gv_Klassen.ShowCellToolTips = false;
            this.gv_Klassen.ShowEditingIcon = false;
            this.gv_Klassen.ShowRowErrors = false;
            this.gv_Klassen.Size = new System.Drawing.Size(595, 360);
            this.gv_Klassen.Style = MetroFramework.MetroColorStyle.Orange;
            this.gv_Klassen.TabIndex = 1;
            this.gv_Klassen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Klassen_CellClick);
            this.gv_Klassen.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gv_Klassen_CellDoubleClick);
            this.gv_Klassen.Sorted += new System.EventHandler(this.Gv_Klassen_Sorted);
            this.gv_Klassen.EnabledChanged += new System.EventHandler(this.Gv_Klassen_EnabledChanged);
            this.gv_Klassen.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gv_Klassen_KeyDown);
            // 
            // gv_Klassenstufe
            // 
            this.gv_Klassenstufe.AllowUserToAddRows = false;
            this.gv_Klassenstufe.AllowUserToDeleteRows = false;
            this.gv_Klassenstufe.AllowUserToResizeColumns = false;
            this.gv_Klassenstufe.AllowUserToResizeRows = false;
            this.gv_Klassenstufe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gv_Klassenstufe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gv_Klassenstufe.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Klassenstufe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gv_Klassenstufe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gv_Klassenstufe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Klassenstufe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gv_Klassenstufe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv_Klassenstufe.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gv_Klassenstufe.DefaultCellStyle = dataGridViewCellStyle5;
            this.gv_Klassenstufe.EnableHeadersVisualStyles = false;
            this.gv_Klassenstufe.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gv_Klassenstufe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gv_Klassenstufe.Location = new System.Drawing.Point(26, 82);
            this.gv_Klassenstufe.MultiSelect = false;
            this.gv_Klassenstufe.Name = "gv_Klassenstufe";
            this.gv_Klassenstufe.ReadOnly = true;
            this.gv_Klassenstufe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(119)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(133)))), ((int)(((byte)(72)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gv_Klassenstufe.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gv_Klassenstufe.RowHeadersWidth = 5;
            this.gv_Klassenstufe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gv_Klassenstufe.RowTemplate.DividerHeight = 1;
            this.gv_Klassenstufe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv_Klassenstufe.ShowCellErrors = false;
            this.gv_Klassenstufe.ShowCellToolTips = false;
            this.gv_Klassenstufe.ShowEditingIcon = false;
            this.gv_Klassenstufe.ShowRowErrors = false;
            this.gv_Klassenstufe.Size = new System.Drawing.Size(270, 360);
            this.gv_Klassenstufe.Style = MetroFramework.MetroColorStyle.Orange;
            this.gv_Klassenstufe.TabIndex = 0;
            this.gv_Klassenstufe.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gv_Klassenstufe_CellDoubleClick);
            this.gv_Klassenstufe.SelectionChanged += new System.EventHandler(this.gv_Klassenstufe_SelectionChanged);
            this.gv_Klassenstufe.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Gv_Klassenstufe_KeyDown);
            // 
            // bt_back
            // 
            this.bt_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_back.Enabled = false;
            this.bt_back.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_back.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_back.Location = new System.Drawing.Point(302, 453);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(175, 24);
            this.bt_back.Style = MetroFramework.MetroColorStyle.Orange;
            this.bt_back.TabIndex = 3;
            this.bt_back.Text = "Zurück";
            this.bt_back.UseSelectable = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // lb_Klassen
            // 
            this.lb_Klassen.AutoSize = true;
            this.lb_Klassen.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_Klassen.Location = new System.Drawing.Point(307, 60);
            this.lb_Klassen.Name = "lb_Klassen";
            this.lb_Klassen.Size = new System.Drawing.Size(138, 19);
            this.lb_Klassen.Style = MetroFramework.MetroColorStyle.Orange;
            this.lb_Klassen.TabIndex = 81;
            this.lb_Klassen.Text = "zugeordnete Klassen:";
            // 
            // lb_Klassenstufe
            // 
            this.lb_Klassenstufe.AutoSize = true;
            this.lb_Klassenstufe.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lb_Klassenstufe.Location = new System.Drawing.Point(28, 60);
            this.lb_Klassenstufe.Name = "lb_Klassenstufe";
            this.lb_Klassenstufe.Size = new System.Drawing.Size(95, 19);
            this.lb_Klassenstufe.Style = MetroFramework.MetroColorStyle.Orange;
            this.lb_Klassenstufe.TabIndex = 80;
            this.lb_Klassenstufe.Text = "Klassenstufen:";
            // 
            // bt_Abbrechen
            // 
            this.bt_Abbrechen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Abbrechen.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bt_Abbrechen.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Abbrechen.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_Abbrechen.Location = new System.Drawing.Point(722, 453);
            this.bt_Abbrechen.Name = "bt_Abbrechen";
            this.bt_Abbrechen.Size = new System.Drawing.Size(175, 24);
            this.bt_Abbrechen.Style = MetroFramework.MetroColorStyle.Orange;
            this.bt_Abbrechen.TabIndex = 5;
            this.bt_Abbrechen.Text = "Schließen";
            this.bt_Abbrechen.UseSelectable = true;
            this.bt_Abbrechen.Click += new System.EventHandler(this.bt_Abbrechen_Click);
            // 
            // bt_Bearbeiten
            // 
            this.bt_Bearbeiten.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bt_Bearbeiten.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.bt_Bearbeiten.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bt_Bearbeiten.Location = new System.Drawing.Point(483, 453);
            this.bt_Bearbeiten.Name = "bt_Bearbeiten";
            this.bt_Bearbeiten.Size = new System.Drawing.Size(175, 24);
            this.bt_Bearbeiten.Style = MetroFramework.MetroColorStyle.Orange;
            this.bt_Bearbeiten.TabIndex = 4;
            this.bt_Bearbeiten.Text = "Zuordnungen bearbeiten";
            this.bt_Bearbeiten.UseSelectable = true;
            this.bt_Bearbeiten.Click += new System.EventHandler(this.bt_Bearbeiten_Click);
            // 
            // mbt_ImEx
            // 
            this.mbt_ImEx.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mbt_ImEx.Enabled = false;
            this.mbt_ImEx.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.mbt_ImEx.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.mbt_ImEx.Location = new System.Drawing.Point(26, 453);
            this.mbt_ImEx.Name = "mbt_ImEx";
            this.mbt_ImEx.Size = new System.Drawing.Size(175, 24);
            this.mbt_ImEx.Style = MetroFramework.MetroColorStyle.Orange;
            this.mbt_ImEx.TabIndex = 6;
            this.mbt_ImEx.Text = "Daten Import/Export";
            this.mbt_ImEx.UseSelectable = true;
            this.mbt_ImEx.Click += new System.EventHandler(this.mbt_ImEx_Click);
            // 
            // msm_klasse_stufe
            // 
            this.styleManagerClassGrade.Owner = this;
            this.styleManagerClassGrade.Style = MetroFramework.MetroColorStyle.Orange;
            // 
            // tb_klasse
            // 
            // 
            // 
            // 
            this.tb_klasse.CustomButton.Image = null;
            this.tb_klasse.CustomButton.Location = new System.Drawing.Point(178, 1);
            this.tb_klasse.CustomButton.Name = "";
            this.tb_klasse.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tb_klasse.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tb_klasse.CustomButton.TabIndex = 1;
            this.tb_klasse.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tb_klasse.CustomButton.UseSelectable = true;
            this.tb_klasse.CustomButton.Visible = false;
            this.tb_klasse.Enabled = false;
            this.tb_klasse.Lines = new string[0];
            this.tb_klasse.Location = new System.Drawing.Point(697, 56);
            this.tb_klasse.MaxLength = 32767;
            this.tb_klasse.Name = "tb_klasse";
            this.tb_klasse.PasswordChar = '\0';
            this.tb_klasse.PromptText = "Suche nach Klasse";
            this.tb_klasse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_klasse.SelectedText = "";
            this.tb_klasse.SelectionLength = 0;
            this.tb_klasse.SelectionStart = 0;
            this.tb_klasse.ShortcutsEnabled = true;
            this.tb_klasse.Size = new System.Drawing.Size(200, 23);
            this.tb_klasse.TabIndex = 2;
            this.tb_klasse.UseSelectable = true;
            this.tb_klasse.WaterMark = "Suche nach Klasse";
            this.tb_klasse.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_klasse.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.tb_klasse.TextChanged += new System.EventHandler(this.Tb_kurz_TextChanged);
            // 
            // w_s_klasse_stufe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(920, 500);
            this.Controls.Add(this.tb_klasse);
            this.Controls.Add(this.mbt_ImEx);
            this.Controls.Add(this.gv_Klassen);
            this.Controls.Add(this.gv_Klassenstufe);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.lb_Klassen);
            this.Controls.Add(this.lb_Klassenstufe);
            this.Controls.Add(this.bt_Abbrechen);
            this.Controls.Add(this.bt_Bearbeiten);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(862, 500);
            this.Name = "w_s_klasse_stufe";
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "Zuordnung der Klassen zu einer Klassenstufe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_klassenstufe_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_Klassenstufe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.styleManagerClassGrade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid gv_Klassen;
        private MetroFramework.Controls.MetroGrid gv_Klassenstufe;
        private MetroFramework.Controls.MetroButton bt_back;
        private MetroFramework.Controls.MetroLabel lb_Klassen;
        private MetroFramework.Controls.MetroLabel lb_Klassenstufe;
        private MetroFramework.Controls.MetroButton bt_Abbrechen;
        private MetroFramework.Controls.MetroButton bt_Bearbeiten;
        private MetroFramework.Controls.MetroButton mbt_ImEx;
        private MetroFramework.Components.MetroStyleManager styleManagerClassGrade;
        private MetroFramework.Controls.MetroTextBox tb_klasse;
    }
}