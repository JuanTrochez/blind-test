using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlindTest.userController
{
    public partial class HighScore : UserControl
    {
        List<Score> scoreList = new List<Score>();

        public HighScore()
        {
            InitializeComponent();
            Score score = new Score();
            scoreList = score.getAll();
            fillArrayScore();
        }

        private void Score_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        public void fillArrayScore()
        {
            foreach (Score score in scoreList)
            {
                listBox1.Items.Add(score.Pseudo + " \t" + score.Sscore);
            }
        }
    }
}
