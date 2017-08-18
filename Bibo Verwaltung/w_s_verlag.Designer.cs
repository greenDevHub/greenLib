namespace Bibo_Verwaltung
{
    partial class w_s_verlag
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
            this.gb_verlag = new System.Windows.Forms.GroupBox();
            this.cb_verlag = new System.Windows.Forms.ComboBox();
            this.bt_add_verlag = new System.Windows.Forms.Button();
            this.bt_del_verlag = new System.Windows.Forms.Button();
            this.gb_verlag.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_verlag
            // 
            this.gb_verlag.Controls.Add(this.cb_verlag);
            this.gb_verlag.Controls.Add(this.bt_add_verlag);
            this.gb_verlag.Controls.Add(this.bt_del_verlag);
            this.gb_verlag.Location = new System.Drawing.Point(26, 32);
            this.gb_verlag.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_verlag.Name = "gb_verlag";
            this.gb_verlag.Padding = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.gb_verlag.Size = new System.Drawing.Size(916, 299);
            this.gb_verlag.TabIndex = 45;
            this.gb_verlag.TabStop = false;
            this.gb_verlag.Text = "Verlag";
            // 
            // cb_verlag
            // 
            this.cb_verlag.FormattingEnabled = true;
            this.cb_verlag.Location = new System.Drawing.Point(11, 42);
            this.cb_verlag.Name = "cb_verlag";
            this.cb_verlag.Size = new System.Drawing.Size(664, 39);
            this.cb_verlag.TabIndex = 45;
            // 
            // bt_add_verlag
            // 
            this.bt_add_verlag.Location = new System.Drawing.Point(242, 100);
            this.bt_add_verlag.Name = "bt_add_verlag";
            this.bt_add_verlag.Size = new System.Drawing.Size(202, 67);
            this.bt_add_verlag.TabIndex = 43;
            this.bt_add_verlag.Text = "Hinzufügen";
            this.bt_add_verlag.UseVisualStyleBackColor = true;
            this.bt_add_verlag.Click += new System.EventHandler(this.bt_add_verlag_Click);
            // 
            // bt_del_verlag
            // 
            this.bt_del_verlag.Location = new System.Drawing.Point(473, 100);
            this.bt_del_verlag.Name = "bt_del_verlag";
            this.bt_del_verlag.Size = new System.Drawing.Size(202, 67);
            this.bt_del_verlag.TabIndex = 45;
            this.bt_del_verlag.Text = "Löschen";
            this.bt_del_verlag.UseVisualStyleBackColor = true;
            this.bt_del_verlag.Click += new System.EventHandler(this.bt_del_verlag_Click);
            // 
            // w_s_verlag
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 362);
            this.Controls.Add(this.gb_verlag);
            this.Name = "w_s_verlag";
            this.Text = "w_s_verlag";
            this.Activated += new System.EventHandler(this.Laden);
            this.gb_verlag.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_verlag;
        private System.Windows.Forms.ComboBox cb_verlag;
        private System.Windows.Forms.Button bt_add_verlag;
        private System.Windows.Forms.Button bt_del_verlag;
    }
}