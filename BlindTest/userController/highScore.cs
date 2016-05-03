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

        }

        private void Score_Load(object sender, EventArgs e)
        {

        }

        
    }
}
