namespace Bibo_Verwaltung
{
    partial class w_s_sprache
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
            this.gb_sprache = new System.Windows.Forms.GroupBox();
            this.cb_sprache = new System.Windows.Forms.ComboBox();
            this.bt_add_sprache = new System.Windows.Forms.Button();
            this.bt_del_sprache = new System.Windows.Forms.Button();
            this.gb_sprache.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_sprache
            // 
            this.gb_sprache.Controls.Add(this.cb_sprache);
            this.gb_sprache.Controls.Add(this.bt_add_sprache);
            this.gb_sprache.Controls.Add(this.bt_del_sprache);
            this.gb_sprache.Location = new System.Drawing.Point(26, 32);
            this.gb_sprache.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_sprache.Name = "gb_sprache";
            this.gb_sprache.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_sprache.Size = new System.Drawing.Size(916, 299);
            this.gb_sprache.TabIndex = 44;
            this.gb_sprache.TabStop = false;
            this.gb_sprache.Text = "Sprache";
            // 
            // cb_sprache
            // 
            this.cb_sprache.FormattingEnabled = true;
            this.cb_sprache.Location = new System.Drawing.Point(11, 42);
            this.cb_sprache.Name = "cb_sprache";
            this.cb_sprache.Size = new System.Drawing.Size(664, 39);
            this.cb_sprache.TabIndex = 45;
            // 
            // bt_add_sprache
            // 
            this.bt_add_sprache.Location = new System.Drawing.Point(242, 100);
            this.bt_add_sprache.Name = "bt_add_sprache";
            this.bt_add_sprache.Size = new System.Drawing.Size(202, 67);
            this.bt_add_sprache.TabIndex = 43;
            this.bt_add_sprache.Text = "Hinzufügen";
            this.bt_add_sprache.UseVisualStyleBackColor = true;
            this.bt_add_sprache.Click += new System.EventHandler(this.bt_add_sprache_Click);
            // 
            // bt_del_sprache
            // 
            this.bt_del_sprache.Location = new System.Drawing.Point(473, 100);
            this.bt_del_sprache.Name = "bt_del_sprache";
            this.bt_del_sprache.Size = new System.Drawing.Size(202, 67);
            this.bt_del_sprache.TabIndex = 45;
            this.bt_del_sprache.Text = "Löschen";
            this.bt_del_sprache.UseVisualStyleBackColor = true;
            this.bt_del_sprache.Click += new System.EventHandler(this.bt_del_sprache_Click);
            // 
            // w_s_sprache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 362);
            this.Controls.Add(this.gb_sprache);
            this.Name = "w_s_sprache";
            this.Text = "w_s_sprache";
            this.Activated += new System.EventHandler(this.Laden);
            this.gb_sprache.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_sprache;
        private System.Windows.Forms.ComboBox cb_sprache;
        private System.Windows.Forms.Button bt_add_sprache;
        private System.Windows.Forms.Button bt_del_sprache;
    }
}