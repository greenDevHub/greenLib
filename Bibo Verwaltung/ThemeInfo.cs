using MetroFramework;
using MetroFramework.Components;
using System.Drawing;

namespace Bibo_Verwaltung.Helper
{
    static class ThemeInfo
    {
        public static MetroStyleManager StyleManager { get; set; } = new MetroStyleManager();
        public static Color ForeColor { get; set; }
        public static Color BackColor { get; set; }
        public static MetroColorStyle MainStyle { get; } = MetroColorStyle.Blue;
        public static MetroColorStyle SettingsStyle { get; } = MetroColorStyle.Silver;
        public static MetroColorStyle CostumerStyle { get; } = MetroColorStyle.Teal;
        public static MetroColorStyle BookStyle { get; } = MetroColorStyle.Blue;
        public static MetroColorStyle AssignmentStyle { get; } = MetroColorStyle.Orange;
        public static MetroColorStyle BorrowingStyle { get; } = MetroColorStyle.Green;
        public static MetroColorStyle ReturnStyle { get; } = MetroColorStyle.Green;
        public static MetroColorStyle DialogStyle { get; } = MetroColorStyle.Silver;
        public static MetroColorStyle AutoBorrowStyle { get; } = MetroColorStyle.Yellow;
        public static MetroColorStyle AutoReturnStyle { get; } = MetroColorStyle.Yellow;
        public static MetroColorStyle OverviewStyle { get; } = MetroColorStyle.Lime;
        public static MetroColorStyle SnakeStyle { get; } = MetroColorStyle.Red;




        public static void Init()
        {
            if (Properties.Settings.Default.darkmode == "true")
            {
                //use dark mode
                StyleManager.Theme = MetroThemeStyle.Dark;

                ForeColor = Color.White;
                BackColor = ColorTranslator.FromHtml("#111111");
            }
            else
            {
                //use light mode
                StyleManager.Theme = MetroThemeStyle.Light;

                ForeColor = Color.Black;
                BackColor = Color.White;
            }
        }

        public static void Change()
        {
            if (StyleManager.Theme == MetroThemeStyle.Light)
            {
                Properties.Settings.Default.darkmode = "true";
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.darkmode = "false";
                Properties.Settings.Default.Save();
            }
            Init();
        }
    }
}
