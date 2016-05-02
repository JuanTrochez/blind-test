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
    public partial class Game : UserControl
    {
        private WMPLib.WindowsMediaPlayer wplayer;
        private Musique music;
        private string reponse = "";
        private Random getrandom = new Random();
        private List<String> choiceList = new List<string>();

        public Game()
        {
            InitializeComponent();
            music = new Musique();
            choiceList = music.ListMusic;
            onStartMusic();
        }

        public async void onStartMusic()
        {
            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 1000;
            progressTimer.Maximum = 14;

            music.OnPlay = getrandom.Next(0, music.ListMusic.Count);
            setRadioText();
            wplayer = new WMPLib.WindowsMediaPlayer();

            wplayer.URL = music.Path + "\\" + music.ListMusic[music.OnPlay];
            wplayer.controls.play();

            await playForSomeSeconds();
            //validateChoice_Click(this, EventArgs.Empty);
            if (progressTimer.Value == 14)
            {
                button2_Click(this, EventArgs.Empty);
            }
        }

        private void setRadioText()
        {
            String name = music.ListMusic[music.OnPlay];
            List<string> otherChoice = getOtherChoices();
        }

        private List<String> getOtherChoices()
        {
            throw new NotImplementedException();
        }

        async Task playForSomeSeconds()
        {
            timer1.Tick += new EventHandler(timer1_Tick);
            await Task.Delay(15000);
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressTimer.Value != 14)
            {
                progressTimer.Value++;
            }
            else
            {
                timer1.Stop();
                timer1.Tick -= new EventHandler(timer1_Tick);
                progressTimer.Value = 0;
            }
        }
        
        //Bouton suivant
        private void button1_Click(object sender, EventArgs e)
        {
            if(goodResponse.Visible == true) {
                goodResponse.Hide();
            }else{
                wrongAnswer.Hide();
            }

            button1.Hide();
            onStartMusic();
        }

        private void musiqueChoice1_CheckedChanged(object sender, EventArgs e)
        {
            reponse = musiqueChoice1.Text;
        }

        private void musiqueChoice2_CheckedChanged(object sender, EventArgs e)
        {
            reponse = musiqueChoice1.Text;
        }

        private void musiqueChoice3_CheckedChanged(object sender, EventArgs e)
        {
            reponse = musiqueChoice1.Text;
        }

        private void musiqueChoice4_CheckedChanged(object sender, EventArgs e)
        {
            reponse = musiqueChoice1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (reponse == music.ListMusic[music.OnPlay])
            {
                goodResponse.Show();
            }
            else
            {
                wrongAnswer.Show();
            }

            music.ListMusic.RemoveAt(music.OnPlay);
            wplayer.controls.stop();
            timer1.Stop();
            timer1.Tick -= new EventHandler(timer1_Tick);
            progressTimer.Value = 0;
            button1.Show();
        }
        
    }
}
