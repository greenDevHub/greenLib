using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class AdvancedComboBox : ComboBox
    {
        new public System.Windows.Forms.DrawMode DrawMode { get; set; }
        public Color HighlightColor { get; set; }
        private Color BorderColorPrivate { get; set; }
        public Color BorderColor { get; set; }
        public bool DataRowView { get; set; }
        private const int WM_PAINT = 0xF;
        private int buttonWidth = SystemInformation.HorizontalScrollBarArrowWidth;

        public AdvancedComboBox()
        {
            base.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HighlightColor = Color.Gray;
            this.BorderColor = Color.Gray;
            this.BorderColorPrivate = BorderColor;
            this.DrawItem += new DrawItemEventHandler(AdvancedComboBox_DrawItem);
            this.Enter += new EventHandler(AdvancedCombobox_Enter);
            this.Leave += new EventHandler(AdvancedCombobox_Leave);
            this.DataRowView = true;
            this.Font = new Font("Segoe UI", 10.5f);
        }
        void AdvancedCombobox_Enter(object sender, EventArgs e)
        {
            BorderColorPrivate = HighlightColor;
        }
        void AdvancedCombobox_Leave(object sender, EventArgs e)
        {
            BorderColorPrivate = BorderColor;
        }
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_PAINT)
            {
                using (var g = Graphics.FromHwnd(Handle))
                {
                    using (var p = new Pen(BorderColorPrivate))
                    {
                        g.DrawRectangle(p, 0, 0, Width - 1, Height - 1);
                        g.DrawLine(p, Width - buttonWidth, 0, Width - buttonWidth, Height);
                    }
                }
            }
        }
        void AdvancedComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            ComboBox combo = sender as ComboBox;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(HighlightColor),
                                         e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(combo.BackColor),
                                         e.Bounds);

            if (DataRowView == true)
            {
                e.Graphics.DrawString(((DataRowView)combo.Items[e.Index])[1].ToString(), e.Font,
                      new SolidBrush(combo.ForeColor),
                      new Point(e.Bounds.X, e.Bounds.Y));
            }
            else
            {
                e.Graphics.DrawString((combo.Items[e.Index]).ToString(), e.Font,
                      new SolidBrush(combo.ForeColor),
                      new Point(e.Bounds.X, e.Bounds.Y));
            }


            e.DrawFocusRectangle();
        }
    }
}
