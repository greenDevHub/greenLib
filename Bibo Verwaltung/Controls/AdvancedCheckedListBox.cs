using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    class AdvancedCheckedListBox : CheckedListBox
    {
        new public System.Windows.Forms.DrawMode DrawMode { get; set; }
        public Color HighlightColor { get; set; }
        public AdvancedCheckedListBox()
        {
            base.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.HighlightColor = Color.Green;
            this.DrawItem += new DrawItemEventHandler(AdvancedCheckedListBox_DrawItem);
        }


        void AdvancedCheckedListBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            CheckedListBox cLB = sender as CheckedListBox;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(HighlightColor),
                                         e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(cLB.BackColor),
                                         e.Bounds);

            e.Graphics.DrawString(((DataRowView)cLB.Items[e.Index])[1].ToString(), e.Font,
                                  new SolidBrush(cLB.ForeColor),
                                  new Point(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }
    }
}
