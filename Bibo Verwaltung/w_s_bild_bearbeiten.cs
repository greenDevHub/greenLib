using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Bibo_Verwaltung
{
    public partial class w_s_bild_bearbeiten : Form
    {
        public w_s_bild_bearbeiten()
        {
            InitializeComponent();
        }

        private void bt_browse_Click(object sender, EventArgs e)
        {
            string imgLocation = "";

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }
        private void bt_save_bild_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=.\\SQLEXPRESS; Initial Catalog=Bibo_Verwaltung; Integrated Security=sspi";
            string strSQL = "SELECT * FROM t_s_buecher WHERE buch_isbn = @b_isbn";

            string imgLocation = "";

            SqlCommand cmd = new SqlCommand(strSQL, con);

            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            string sqlQuery = "Insert into t_s_buecher(buch_isbn,buch_bild)Values('" + cb_buch_bild.Text + "','" + "',@images)";
            cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            con.Close();
            MessageBox.Show("Bild erfolgreich gespeichert");
        }
    }
}
