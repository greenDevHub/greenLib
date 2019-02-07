using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework.Components;
using MetroFramework.Drawing;
using MetroFramework.Interfaces;

namespace Bibo_Verwaltung
{
    public partial class NewComboBox : ComboBox, IMetroControl
    {
        public NewComboBox();

        [Browsable(false)]
        [DefaultValue(DrawMode.OwnerDrawFixed)]
        public DrawMode DrawMode { get; set; }
        [Category("Metro Appearance")]
        [DefaultValue(MetroThemeStyle.Default)]
        public MetroThemeStyle Theme { get; set; }
        [Browsable(false)]
        public override Font Font { get; set; }
        [Browsable(true)]
        [Category("Metro Appearance")]
        [DefaultValue("")]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public string PromptText { get; set; }
        [Category("Metro Appearance")]
        [DefaultValue(MetroComboBoxWeight.Regular)]
        public MetroComboBoxWeight FontWeight { get; set; }
        [Category("Metro Appearance")]
        [DefaultValue(MetroComboBoxSize.Medium)]
        public MetroComboBoxSize FontSize { get; set; }
        [Browsable(false)]
        [DefaultValue(ComboBoxStyle.DropDownList)]
        public ComboBoxStyle DropDownStyle { get; set; }
        [Category("Metro Appearance")]
        [DefaultValue(MetroColorStyle.Default)]
        public MetroColorStyle Style { get; set; }
        [Category("Metro Appearance")]
        [DefaultValue(false)]
        public bool DisplayFocus { get; set; }
        [Browsable(false)]
        [Category("Metro Behaviour")]
        [DefaultValue(false)]
        public bool UseSelectable { get; set; }
        [Category("Metro Appearance")]
        [DefaultValue(false)]
        public bool UseStyleColors { get; set; }
        [Category("Metro Appearance")]
        [DefaultValue(false)]
        public bool UseCustomForeColor { get; set; }
        [Category("Metro Appearance")]
        [DefaultValue(false)]
        public bool UseCustomBackColor { get; set; }
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public MetroStyleManager StyleManager { get; set; }

        [Category("Metro Appearance")]
        public event EventHandler<MetroPaintEventArgs> CustomPaintForeground;
        [Category("Metro Appearance")]
        public event EventHandler<MetroPaintEventArgs> CustomPaintBackground;
        [Category("Metro Appearance")]
        public event EventHandler<MetroPaintEventArgs> CustomPaint;

        public override Size GetPreferredSize(Size proposedSize);
        protected virtual void OnCustomPaint(MetroPaintEventArgs e);
        protected virtual void OnCustomPaintBackground(MetroPaintEventArgs e);
        protected virtual void OnCustomPaintForeground(MetroPaintEventArgs e);
        protected override void OnDrawItem(DrawItemEventArgs e);
        protected override void OnEnter(EventArgs e);
        protected override void OnGotFocus(EventArgs e);
        protected override void OnKeyDown(KeyEventArgs e);
        protected override void OnKeyUp(KeyEventArgs e);
        protected override void OnLeave(EventArgs e);
        protected override void OnLostFocus(EventArgs e);
        protected override void OnMouseDown(MouseEventArgs e);
        protected override void OnMouseEnter(EventArgs e);
        protected override void OnMouseLeave(EventArgs e);
        protected override void OnMouseUp(MouseEventArgs e);
        protected override void OnPaint(PaintEventArgs e);
        protected override void OnPaintBackground(PaintEventArgs e);
        protected virtual void OnPaintForeground(PaintEventArgs e);
        protected override void OnSelectedIndexChanged(EventArgs e);
        protected override void WndProc(ref Message m);
}
}
