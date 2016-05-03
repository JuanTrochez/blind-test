using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BlindTest.userController;

namespace BlindTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void play_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Dock = DockStyle.Fill;
            this.Controls.Add(game);
            game.BringToFront();

        }

        private void option_Click(object sender, EventArgs e)
        {
            OptionCtrl opt = new OptionCtrl();
            opt.Dock = DockStyle.Fill;
            this.Controls.Add(opt);
            opt.BringToFront();
        }

        private void scores_Click(object sender, EventArgs e)
        {
            HighScore hs = new HighScore();
            hs.Dock = DockStyle.Fill;
            this.Controls.Add(hs);
            hs.BringToFront();
        }
    }
}
