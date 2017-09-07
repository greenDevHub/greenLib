namespace Bibo_Verwaltung
{
    partial class w_s_vertrauen
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
            this.gb_vertrauen = new System.Windows.Forms.GroupBox();
            this.cb_vertrauen = new System.Windows.Forms.ComboBox();
            this.bt_add_ver = new System.Windows.Forms.Button();
            this.bt_del_ver = new System.Windows.Forms.Button();
            this.gb_vertrauen.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_vertrauen
            // 
            this.gb_vertrauen.Controls.Add(this.cb_vertrauen);
            this.gb_vertrauen.Controls.Add(this.bt_add_ver);
            this.gb_vertrauen.Controls.Add(this.bt_del_ver);
            this.gb_vertrauen.Location = new System.Drawing.Point(11, 41);
            this.gb_vertrauen.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_vertrauen.Name = "gb_vertrauen";
            this.gb_vertrauen.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_vertrauen.Size = new System.Drawing.Size(916, 299);
            this.gb_vertrauen.TabIndex = 45;
            this.gb_vertrauen.TabStop = false;
            this.gb_vertrauen.Text = "Vertrauenswürdigkeit";
            // 
            // cb_vertrauen
            // 
            this.cb_vertrauen.FormattingEnabled = true;
            this.cb_vertrauen.Location = new System.Drawing.Point(11, 42);
            this.cb_vertrauen.Name = "cb_vertrauen";
            this.cb_vertrauen.Size = new System.Drawing.Size(664, 39);
            this.cb_vertrauen.TabIndex = 45;
            // 
            // bt_add_ver
            // 
            this.bt_add_ver.Location = new System.Drawing.Point(242, 100);
            this.bt_add_ver.Name = "bt_add_ver";
            this.bt_add_ver.Size = new System.Drawing.Size(202, 67);
            this.bt_add_ver.TabIndex = 43;
            this.bt_add_ver.Text = "Hinzufügen";
            this.bt_add_ver.UseVisualStyleBackColor = true;
            this.bt_add_ver.Click += new System.EventHandler(this.bt_add_ver_Click);
            // 
            // bt_del_ver
            // 
            this.bt_del_ver.Location = new System.Drawing.Point(473, 100);
            this.bt_del_ver.Name = "bt_del_ver";
            this.bt_del_ver.Size = new System.Drawing.Size(202, 67);
            this.bt_del_ver.TabIndex = 45;
            this.bt_del_ver.Text = "Löschen";
            this.bt_del_ver.UseVisualStyleBackColor = true;
            this.bt_del_ver.Click += new System.EventHandler(this.bt_del_ver_Click);
            // 
            // w_s_vertrauen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 362);
            this.Controls.Add(this.gb_vertrauen);
            this.Name = "w_s_vertrauen";
            this.Text = "w_s_vertrauen";
            this.Activated += new System.EventHandler(this.Laden);
            this.gb_vertrauen.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_vertrauen;
        private System.Windows.Forms.ComboBox cb_vertrauen;
        private System.Windows.Forms.Button bt_add_ver;
        private System.Windows.Forms.Button bt_del_ver;
    }
}