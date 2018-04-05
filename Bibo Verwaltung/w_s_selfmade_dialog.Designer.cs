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
            this.bt_Choice1 = new System.Windows.Forms.Button();
            this.bt_Choice2 = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.lb_Message = new System.Windows.Forms.Label();
            this.tLP = new System.Windows.Forms.TableLayoutPanel();
            this.tLP.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_Choice1
            // 
            this.bt_Choice1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.bt_Choice1.Location = new System.Drawing.Point(35, 76);
            this.bt_Choice1.Name = "bt_Choice1";
            this.bt_Choice1.Size = new System.Drawing.Size(100, 23);
            this.bt_Choice1.TabIndex = 0;
            this.bt_Choice1.Text = "-";
            this.bt_Choice1.UseVisualStyleBackColor = true;
            // 
            // bt_Choice2
            // 
            this.bt_Choice2.DialogResult = System.Windows.Forms.DialogResult.No;
            this.bt_Choice2.Location = new System.Drawing.Point(141, 76);
            this.bt_Choice2.Name = "bt_Choice2";
            this.bt_Choice2.Size = new System.Drawing.Size(100, 23);
            this.bt_Choice2.TabIndex = 1;
            this.bt_Choice2.Text = "-";
            this.bt_Choice2.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(247, 76);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 2;
            this.Cancel.Text = "Abbrechen";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // lb_Message
            // 
            this.lb_Message.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_Message.AutoEllipsis = true;
            this.lb_Message.AutoSize = true;
            this.lb_Message.Location = new System.Drawing.Point(3, 0);
            this.lb_Message.Name = "lb_Message";
            this.lb_Message.Size = new System.Drawing.Size(304, 58);
            this.lb_Message.TabIndex = 3;
            this.lb_Message.Text = "-";
            this.lb_Message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tLP
            // 
            this.tLP.AutoScroll = true;
            this.tLP.ColumnCount = 1;
            this.tLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP.Controls.Add(this.lb_Message, 0, 0);
            this.tLP.Location = new System.Drawing.Point(12, 12);
            this.tLP.Name = "tLP";
            this.tLP.RowCount = 1;
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tLP.Size = new System.Drawing.Size(310, 58);
            this.tLP.TabIndex = 4;
            // 
            // w_s_selfmade_dialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 111);
            this.Controls.Add(this.tLP);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.bt_Choice2);
            this.Controls.Add(this.bt_Choice1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "w_s_selfmade_dialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "-";
            this.TopMost = true;
            this.tLP.ResumeLayout(false);
            this.tLP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_Choice1;
        private System.Windows.Forms.Button bt_Choice2;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label lb_Message;
        private System.Windows.Forms.TableLayoutPanel tLP;
    }
}