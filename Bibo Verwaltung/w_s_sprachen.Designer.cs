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
            this.cb_Sprachen = new System.Windows.Forms.ComboBox();
            this.tb_Sprache = new System.Windows.Forms.TextBox();
            this.bt_Neu = new System.Windows.Forms.Button();
            this.lb_Sprache = new System.Windows.Forms.Label();
            this.gb_Sprachen2 = new System.Windows.Forms.GroupBox();
            this.lb_Sprachen = new System.Windows.Forms.Label();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Bearbeiten = new System.Windows.Forms.Button();
            this.gb_Sprachen1 = new System.Windows.Forms.GroupBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.gb_Sprachen2.SuspendLayout();
            this.gb_Sprachen1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_Sprachen
            // 
            this.cb_Sprachen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Sprachen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Sprachen.DropDownHeight = 105;
            this.cb_Sprachen.FormattingEnabled = true;
            this.cb_Sprachen.IntegralHeight = false;
            this.cb_Sprachen.Location = new System.Drawing.Point(104, 24);
            this.cb_Sprachen.MaxDropDownItems = 4;
            this.cb_Sprachen.Name = "cb_Sprachen";
            this.cb_Sprachen.Size = new System.Drawing.Size(200, 21);
            this.cb_Sprachen.Sorted = true;
            this.cb_Sprachen.TabIndex = 3;
            // 
            // tb_Sprache
            // 
            this.tb_Sprache.Location = new System.Drawing.Point(104, 24);
            this.tb_Sprache.Name = "tb_Sprache";
            this.tb_Sprache.Size = new System.Drawing.Size(200, 20);
            this.tb_Sprache.TabIndex = 1;
            // 
            // bt_Neu
            // 
            this.bt_Neu.Location = new System.Drawing.Point(310, 22);
            this.bt_Neu.Name = "bt_Neu";
            this.bt_Neu.Size = new System.Drawing.Size(97, 23);
            this.bt_Neu.TabIndex = 2;
            this.bt_Neu.Text = "Speichern";
            this.bt_Neu.UseVisualStyleBackColor = true;
            this.bt_Neu.Click += new System.EventHandler(this.bt_Neu_Click);
            // 
            // lb_Sprache
            // 
            this.lb_Sprache.AutoSize = true;
            this.lb_Sprache.Location = new System.Drawing.Point(48, 27);
            this.lb_Sprache.Name = "lb_Sprache";
            this.lb_Sprache.Size = new System.Drawing.Size(50, 13);
            this.lb_Sprache.TabIndex = 31;
            this.lb_Sprache.Text = "Sprache:";
            // 
            // gb_Sprachen2
            // 
            this.gb_Sprachen2.Controls.Add(this.lb_Sprachen);
            this.gb_Sprachen2.Controls.Add(this.bt_Delete);
            this.gb_Sprachen2.Controls.Add(this.bt_Bearbeiten);
            this.gb_Sprachen2.Controls.Add(this.cb_Sprachen);
            this.gb_Sprachen2.Location = new System.Drawing.Point(17, 85);
            this.gb_Sprachen2.Name = "gb_Sprachen2";
            this.gb_Sprachen2.Size = new System.Drawing.Size(414, 89);
            this.gb_Sprachen2.TabIndex = 45;
            this.gb_Sprachen2.TabStop = false;
            this.gb_Sprachen2.Text = "Sprachen Verwalten: ";
            // 
            // lb_Sprachen
            // 
            this.lb_Sprachen.AutoSize = true;
            this.lb_Sprachen.Location = new System.Drawing.Point(42, 27);
            this.lb_Sprachen.Name = "lb_Sprachen";
            this.lb_Sprachen.Size = new System.Drawing.Size(56, 13);
            this.lb_Sprachen.TabIndex = 45;
            this.lb_Sprachen.Text = "Sprachen:";
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(310, 51);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(97, 23);
            this.bt_Delete.TabIndex = 5;
            this.bt_Delete.Text = "Löschen";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Bearbeiten
            // 
            this.bt_Bearbeiten.Location = new System.Drawing.Point(310, 22);
            this.bt_Bearbeiten.Name = "bt_Bearbeiten";
            this.bt_Bearbeiten.Size = new System.Drawing.Size(97, 23);
            this.bt_Bearbeiten.TabIndex = 4;
            this.bt_Bearbeiten.Text = "Umbenennen";
            this.bt_Bearbeiten.UseVisualStyleBackColor = true;
            this.bt_Bearbeiten.Click += new System.EventHandler(this.bt_Bearbeiten_Click);
            // 
            // gb_Sprachen1
            // 
            this.gb_Sprachen1.Controls.Add(this.tb_Sprache);
            this.gb_Sprachen1.Controls.Add(this.bt_Neu);
            this.gb_Sprachen1.Controls.Add(this.lb_Sprache);
            this.gb_Sprachen1.Location = new System.Drawing.Point(17, 19);
            this.gb_Sprachen1.Name = "gb_Sprachen1";
            this.gb_Sprachen1.Size = new System.Drawing.Size(414, 60);
            this.gb_Sprachen1.TabIndex = 46;
            this.gb_Sprachen1.TabStop = false;
            this.gb_Sprachen1.Text = "Sprache hinzufügen:";
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(334, 180);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(97, 23);
            this.bt_OK.TabIndex = 47;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gb_Sprachen1);
            this.groupBox1.Controls.Add(this.gb_Sprachen2);
            this.groupBox1.Controls.Add(this.bt_OK);
            this.groupBox1.Location = new System.Drawing.Point(23, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(82, 45);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alter Aufbau";
            this.groupBox1.Visible = false;
            // 
            // grid
            // 
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(12, 12);
            this.grid.Name = "grid";
            this.grid.Size = new System.Drawing.Size(207, 347);
            this.grid.TabIndex = 50;
            // 
            // w_s_sprachen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 402);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "w_s_sprachen";
            this.Text = "Sprachen";
            this.Activated += new System.EventHandler(this.Fill_All);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.w_s_sprachen_FormClosing);
            this.gb_Sprachen2.ResumeLayout(false);
            this.gb_Sprachen2.PerformLayout();
            this.gb_Sprachen1.ResumeLayout(false);
            this.gb_Sprachen1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_Sprachen;
        private System.Windows.Forms.TextBox tb_Sprache;
        private System.Windows.Forms.Button bt_Neu;
        private System.Windows.Forms.Label lb_Sprache;
        private System.Windows.Forms.GroupBox gb_Sprachen2;
        private System.Windows.Forms.Label lb_Sprachen;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Bearbeiten;
        private System.Windows.Forms.GroupBox gb_Sprachen1;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView grid;
    }
}