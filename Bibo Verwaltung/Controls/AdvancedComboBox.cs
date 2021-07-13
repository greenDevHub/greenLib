using System;
using System.Data;
using System.Drawing;
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

        private Brush ArrowBrush = new SolidBrush(SystemColors.ControlText);
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
        [System.Runtime.ExceptionServices.HandleProcessCorruptedStateExceptions]
        protected override void WndProc(ref Message m)
        {
            try
            {
                base.WndProc(ref m);

            }
            catch { }
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
            switch (m.Msg)
            {
                case 0xf:
                    //Paint the background. Only the borders
                    //will show up because the edit
                    //box will be overlayed
                    Graphics g = this.CreateGraphics();
                    Pen p = new Pen(Color.White, 2);
                    //Draw the background of the dropdown button
                    Rectangle rect = new Rectangle(this.Width - 17, 1, 16, this.Height - 2);
                    g.FillRectangle(new SolidBrush(this.BackColor), rect);

                    //Create the path for the arrow
                    System.Drawing.Drawing2D.GraphicsPath pth = new System.Drawing.Drawing2D.GraphicsPath();
                    PointF TopLeft = new PointF(this.Width - 13, (this.Height - 5) / 2);
                    PointF TopRight = new PointF(this.Width - 6, (this.Height - 5) / 2);
                    PointF Bottom = new PointF(this.Width - 9, (this.Height + 2) / 2);
                    pth.AddLine(TopLeft, TopRight);
                    pth.AddLine(TopRight, Bottom);

                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                    //Determine the arrow's color.
                    if (this.DroppedDown)
                    {
                        ArrowBrush = new SolidBrush(ForeColor);
                    }
                    else
                    {
                        ArrowBrush = new SolidBrush(ForeColor);
                    }

                    //Draw the arrow
                    g.FillPath(ArrowBrush, pth);

                    break;
                default:
                    break; // TODO: might not be correct. Was : Exit Select
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
