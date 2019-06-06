using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenSize
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GetScale(ref scale);
            File.WriteAllText(homepath + "\\Scale.txt", scale.ToString());
            this.Close();
        }
        double scale = 0;
        string homepath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Bibliothek\\Einstellungen";
        private void GetScale(ref double scale)
        {
            double curDPI = 0;
            Screen screen = Screen.PrimaryScreen;
            using (Graphics g = this.CreateGraphics())
            {
                curDPI = (int)g.DpiX;
            }
            scale = 0;
            scale = curDPI / 96;
        }
    }
}
