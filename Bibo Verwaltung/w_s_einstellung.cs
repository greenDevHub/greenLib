using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;


namespace Bibo_Verwaltung
{
    public partial class w_s_einstellung : Form
    {
        public w_s_einstellung()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:/Users/Anwender/Documents/GitHub/GameDev/Bibo Verwaltung/SQLDaten.xml");

            XmlNode node1 = doc.SelectSingleNode("/Settings/Nutzername");
            textBox1.Text = node1.InnerText;
           
            XmlNode node2 = doc.SelectSingleNode("/Settings/Passwort");
            textBox2.Text = node2.InnerText;
            XmlNode node3 = doc.SelectSingleNode("/Settings/Server");
            comboBox1.Text = node3.InnerText;
            XmlNode node4 = doc.SelectSingleNode("/Settings/Datenbank");
            comboBox2.Text = node4.InnerText;
            XmlNode node5 = doc.SelectSingleNode("/Settings/Verifizierung");
            comboBox3.Text = node5.InnerText;


        }
    }
    }

