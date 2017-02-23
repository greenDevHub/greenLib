using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bibo_Verwaltung
{
    public partial class Combo_Search : Form
    {
        private string suche = "";

        public string such_auswahl
        {
            get { return suche;}
        }

        public Combo_Search(string[] a)
        {
            InitializeComponent();
            //Elemente zu ListBox hinzufügen
            lb_Ergenisse.Items.AddRange(a);
            tb_Such_nach.Focus();
        }

        private void bt_Such_nach_Click(object sender, EventArgs e)
        { 
            string suchen = tb_Such_nach.Text;
            
            //Elemente zu ListBox auslesen
            string[] strAutor = new string[lb_Ergenisse.Items.Count];
            for (int i = 0; i < lb_Ergenisse.Items.Count; i++)
            {
                strAutor[i] = lb_Ergenisse.Items[i].ToString();
            }
            
            //Elemente aus ListBox und Textbox vergleichen
            for (int i = 0; i < lb_Ergenisse.Items.Count; i++)
            {
                if (lb_Ergenisse.Items[i].Equals(suchen))
                {
                    lb_Ergenisse.SelectedItem = suchen;
                }
            }
        }

        private void bt_Ok_Click(object sender, EventArgs e)
        {
             suche = lb_Ergenisse.GetItemText(lb_Ergenisse.SelectedItem);
        }
    }
}
