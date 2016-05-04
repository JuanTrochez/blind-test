using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BlindTest.userController
{
    public partial class OptionCtrl : UserControl
    {
        public OptionCtrl()
        {
            InitializeComponent();
        }

        private void browse_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = folderBrowserDialog1.SelectedPath;
                Musique.path = textBox1.Text;
                insertPath(Musique.path);
                DialogResult dialogResult = MessageBox.Show("Le fichier à bien été modifié", "Validation", MessageBoxButtons.OK);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        public void insertPath(string path)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=(localdb)\\ProjectsV13;Database=blind_test;Trusted_Connection=true";
                conn.Open();
                String req = "UPDATE Path SET path = '" + path + "' WHERE 1=1";
                SqlCommand cmd = new SqlCommand(req);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
