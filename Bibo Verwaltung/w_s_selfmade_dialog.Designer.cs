namespace Bibo_Verwaltung
{
    partial class w_s_selfmade_dialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(w_s_selfmade_dialog));
            this.mbt_Choice1 = new MetroFramework.Controls.MetroButton();
            this.mbt_Choice2 = new MetroFramework.Controls.MetroButton();
            this.mbt_Cancel = new MetroFramework.Controls.MetroButton();
            this.mlb_Message = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // mbt_Choice1
            // 
            this.mbt_Choice1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.mbt_Choice1.DisplayFocus = true;
            this.mbt_Choice1.Location = new System.Drawing.Point(23, 76);
            this.mbt_Choice1.Name = "mbt_Choice1";
            this.mbt_Choice1.Size = new System.Drawing.Size(100, 23);
            this.mbt_Choice1.TabIndex = 5;
            this.mbt_Choice1.Text = "-";
            this.mbt_Choice1.UseSelectable = true;
            // 
            // mbt_Choice2
            // 
            this.mbt_Choice2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.mbt_Choice2.DisplayFocus = true;
            this.mbt_Choice2.Location = new System.Drawing.Point(129, 76);
            this.mbt_Choice2.Name = "mbt_Choice2";
            this.mbt_Choice2.Size = new System.Drawing.Size(100, 23);
            this.mbt_Choice2.TabIndex = 6;
            this.mbt_Choice2.Text = "-";
            this.mbt_Choice2.UseSelectable = true;
            // 
            // mbt_Cancel
            // 
            this.mbt_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.mbt_Cancel.DisplayFocus = true;
            this.mbt_Cancel.Location = new System.Drawing.Point(236, 76);
            this.mbt_Cancel.Name = "mbt_Cancel";
            this.mbt_Cancel.Size = new System.Drawing.Size(75, 23);
            this.mbt_Cancel.TabIndex = 7;
            this.mbt_Cancel.Text = "Abbrechen";
            this.mbt_Cancel.UseSelectable = true;
            // 
            // mlb_Message
            // 
            this.mlb_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mlb_Message.Location = new System.Drawing.Point(0, 12);
            this.mlb_Message.Name = "mlb_Message";
            this.mlb_Message.Size = new System.Drawing.Size(334, 58);
            this.mlb_Message.TabIndex = 8;
            this.mlb_Message.Text = "-";
            this.mlb_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mlb_Message.WrapToLine = true;
            // 
            // w_s_selfmade_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 107);
            this.ControlBox = false;
            this.Controls.Add(this.mlb_Message);
            this.Controls.Add(this.mbt_Cancel);
            this.Controls.Add(this.mbt_Choice2);
            this.Controls.Add(this.mbt_Choice1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Movable = false;
            this.Name = "w_s_selfmade_dialog";
            this.Resizable = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Style = MetroFramework.MetroColorStyle.Silver;
            this.Text = "-";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroButton mbt_Choice1;
        private MetroFramework.Controls.MetroButton mbt_Choice2;
        private MetroFramework.Controls.MetroButton mbt_Cancel;
        private MetroFramework.Controls.MetroLabel mlb_Message;
    }
}