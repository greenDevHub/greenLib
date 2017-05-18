namespace Bibo_Verwaltung
{
    partial class w_s_verlage
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
            this.gb_Verlage1 = new System.Windows.Forms.GroupBox();
            this.tb_Verlagsname = new System.Windows.Forms.TextBox();
            this.bt_Neu = new System.Windows.Forms.Button();
            this.lb_Verlagsname = new System.Windows.Forms.Label();
            this.gb_Verlage2 = new System.Windows.Forms.GroupBox();
            this.lb_Verlage = new System.Windows.Forms.Label();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Bearbeiten = new System.Windows.Forms.Button();
            this.cb_Verlage = new System.Windows.Forms.ComboBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.gb_Verlage1.SuspendLayout();
            this.gb_Verlage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Verlage1
            // 
            this.gb_Verlage1.Controls.Add(this.tb_Verlagsname);
            this.gb_Verlage1.Controls.Add(this.bt_Neu);
            this.gb_Verlage1.Controls.Add(this.lb_Verlagsname);
            this.gb_Verlage1.Location = new System.Drawing.Point(12, 12);
            this.gb_Verlage1.Name = "gb_Verlage1";
            this.gb_Verlage1.Size = new System.Drawing.Size(414, 60);
            this.gb_Verlage1.TabIndex = 45;
            this.gb_Verlage1.TabStop = false;
            this.gb_Verlage1.Text = "Verlag hinzufügen:";
            // 
            // tb_Verlagsname
            // 
            this.tb_Verlagsname.Location = new System.Drawing.Point(104, 24);
            this.tb_Verlagsname.Name = "tb_Verlagsname";
            this.tb_Verlagsname.Size = new System.Drawing.Size(200, 20);
            this.tb_Verlagsname.TabIndex = 1;
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
            // lb_Verlagsname
            // 
            this.lb_Verlagsname.AutoSize = true;
            this.lb_Verlagsname.Location = new System.Drawing.Point(59, 27);
            this.lb_Verlagsname.Name = "lb_Verlagsname";
            this.lb_Verlagsname.Size = new System.Drawing.Size(40, 13);
            this.lb_Verlagsname.TabIndex = 31;
            this.lb_Verlagsname.Text = "Verlag:";
            // 
            // gb_Verlage2
            // 
            this.gb_Verlage2.Controls.Add(this.lb_Verlage);
            this.gb_Verlage2.Controls.Add(this.bt_Delete);
            this.gb_Verlage2.Controls.Add(this.bt_Bearbeiten);
            this.gb_Verlage2.Controls.Add(this.cb_Verlage);
            this.gb_Verlage2.Location = new System.Drawing.Point(12, 78);
            this.gb_Verlage2.Name = "gb_Verlage2";
            this.gb_Verlage2.Size = new System.Drawing.Size(414, 89);
            this.gb_Verlage2.TabIndex = 44;
            this.gb_Verlage2.TabStop = false;
            this.gb_Verlage2.Text = "Verlage Verwalten: ";
            // 
            // lb_Verlage
            // 
            this.lb_Verlage.AutoSize = true;
            this.lb_Verlage.Location = new System.Drawing.Point(54, 27);
            this.lb_Verlage.Name = "lb_Verlage";
            this.lb_Verlage.Size = new System.Drawing.Size(46, 13);
            this.lb_Verlage.TabIndex = 45;
            this.lb_Verlage.Text = "Verlage:";
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
            // cb_Verlage
            // 
            this.cb_Verlage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Verlage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Verlage.DropDownHeight = 105;
            this.cb_Verlage.FormattingEnabled = true;
            this.cb_Verlage.IntegralHeight = false;
            this.cb_Verlage.Location = new System.Drawing.Point(104, 24);
            this.cb_Verlage.MaxDropDownItems = 4;
            this.cb_Verlage.Name = "cb_Verlage";
            this.cb_Verlage.Size = new System.Drawing.Size(200, 21);
            this.cb_Verlage.Sorted = true;
            this.cb_Verlage.TabIndex = 3;
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(329, 173);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(97, 23);
            this.bt_OK.TabIndex = 46;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // Verlage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 208);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.gb_Verlage1);
            this.Controls.Add(this.gb_Verlage2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Verlage";
            this.Text = "Verlage";
            this.Activated += new System.EventHandler(this.Fill_All);
            this.gb_Verlage1.ResumeLayout(false);
            this.gb_Verlage1.PerformLayout();
            this.gb_Verlage2.ResumeLayout(false);
            this.gb_Verlage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gb_Verlage1;
        private System.Windows.Forms.TextBox tb_Verlagsname;
        private System.Windows.Forms.Button bt_Neu;
        private System.Windows.Forms.Label lb_Verlagsname;
        private System.Windows.Forms.GroupBox gb_Verlage2;
        private System.Windows.Forms.Label lb_Verlage;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Bearbeiten;
        private System.Windows.Forms.ComboBox cb_Verlage;
        private System.Windows.Forms.Button bt_OK;
    }
}