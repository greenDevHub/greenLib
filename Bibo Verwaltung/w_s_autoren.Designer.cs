namespace Bibo_Verwaltung
{
    partial class w_s_autoren
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
            this.lb_Autoren = new System.Windows.Forms.Label();
            this.tb_Autorname = new System.Windows.Forms.TextBox();
            this.bt_Neu = new System.Windows.Forms.Button();
            this.lb_Autorname = new System.Windows.Forms.Label();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Bearbeiten = new System.Windows.Forms.Button();
            this.cb_Autoren = new System.Windows.Forms.ComboBox();
            this.bt_OK = new System.Windows.Forms.Button();
            this.gb_Autoren1 = new System.Windows.Forms.GroupBox();
            this.gb_Autoren2 = new System.Windows.Forms.GroupBox();
            this.gb_Autoren1.SuspendLayout();
            this.gb_Autoren2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_Autoren
            // 
            this.lb_Autoren.AutoSize = true;
            this.lb_Autoren.Location = new System.Drawing.Point(51, 27);
            this.lb_Autoren.Name = "lb_Autoren";
            this.lb_Autoren.Size = new System.Drawing.Size(47, 13);
            this.lb_Autoren.TabIndex = 45;
            this.lb_Autoren.Text = "Autoren:";
            // 
            // tb_Autorname
            // 
            this.tb_Autorname.Location = new System.Drawing.Point(104, 24);
            this.tb_Autorname.Name = "tb_Autorname";
            this.tb_Autorname.Size = new System.Drawing.Size(200, 20);
            this.tb_Autorname.TabIndex = 1;
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
            // lb_Autorname
            // 
            this.lb_Autorname.AutoSize = true;
            this.lb_Autorname.Location = new System.Drawing.Point(63, 27);
            this.lb_Autorname.Name = "lb_Autorname";
            this.lb_Autorname.Size = new System.Drawing.Size(35, 13);
            this.lb_Autorname.TabIndex = 31;
            this.lb_Autorname.Text = "Autor:";
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
            // cb_Autoren
            // 
            this.cb_Autoren.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cb_Autoren.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cb_Autoren.DropDownHeight = 105;
            this.cb_Autoren.FormattingEnabled = true;
            this.cb_Autoren.IntegralHeight = false;
            this.cb_Autoren.Location = new System.Drawing.Point(104, 24);
            this.cb_Autoren.MaxDropDownItems = 4;
            this.cb_Autoren.Name = "cb_Autoren";
            this.cb_Autoren.Size = new System.Drawing.Size(200, 21);
            this.cb_Autoren.Sorted = true;
            this.cb_Autoren.TabIndex = 3;
            // 
            // bt_OK
            // 
            this.bt_OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_OK.Location = new System.Drawing.Point(329, 173);
            this.bt_OK.Name = "bt_OK";
            this.bt_OK.Size = new System.Drawing.Size(97, 23);
            this.bt_OK.TabIndex = 47;
            this.bt_OK.Text = "Schließen";
            this.bt_OK.UseVisualStyleBackColor = true;
            // 
            // gb_Autoren1
            // 
            this.gb_Autoren1.Controls.Add(this.tb_Autorname);
            this.gb_Autoren1.Controls.Add(this.bt_Neu);
            this.gb_Autoren1.Controls.Add(this.lb_Autorname);
            this.gb_Autoren1.Location = new System.Drawing.Point(12, 12);
            this.gb_Autoren1.Name = "gb_Autoren1";
            this.gb_Autoren1.Size = new System.Drawing.Size(414, 60);
            this.gb_Autoren1.TabIndex = 46;
            this.gb_Autoren1.TabStop = false;
            this.gb_Autoren1.Text = "Autor hinzufügen:";
            // 
            // gb_Autoren2
            // 
            this.gb_Autoren2.Controls.Add(this.lb_Autoren);
            this.gb_Autoren2.Controls.Add(this.bt_Delete);
            this.gb_Autoren2.Controls.Add(this.bt_Bearbeiten);
            this.gb_Autoren2.Controls.Add(this.cb_Autoren);
            this.gb_Autoren2.Location = new System.Drawing.Point(12, 78);
            this.gb_Autoren2.Name = "gb_Autoren2";
            this.gb_Autoren2.Size = new System.Drawing.Size(414, 89);
            this.gb_Autoren2.TabIndex = 45;
            this.gb_Autoren2.TabStop = false;
            this.gb_Autoren2.Text = "Autoren Verwalten: ";
            // 
            // Autoren
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 208);
            this.Controls.Add(this.bt_OK);
            this.Controls.Add(this.gb_Autoren1);
            this.Controls.Add(this.gb_Autoren2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Autoren";
            this.Text = "Autoren";
            this.Activated += new System.EventHandler(this.Fill_All);
            this.gb_Autoren1.ResumeLayout(false);
            this.gb_Autoren1.PerformLayout();
            this.gb_Autoren2.ResumeLayout(false);
            this.gb_Autoren2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_Autoren;
        private System.Windows.Forms.TextBox tb_Autorname;
        private System.Windows.Forms.Button bt_Neu;
        private System.Windows.Forms.Label lb_Autorname;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Bearbeiten;
        private System.Windows.Forms.ComboBox cb_Autoren;
        private System.Windows.Forms.Button bt_OK;
        private System.Windows.Forms.GroupBox gb_Autoren1;
        private System.Windows.Forms.GroupBox gb_Autoren2;
    }
}