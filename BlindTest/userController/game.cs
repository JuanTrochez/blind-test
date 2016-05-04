using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Data.SqlClient;

namespace BlindTest.userController
{
    public partial class Game : UserControl
    {
        private WMPLib.WindowsMediaPlayer wplayer;
        private Musique music;
        private Player player;
        private string reponse = "";
        private Random getrandom = new Random();
        private List<String> choiceList = new List<string>();
        private List<RadioButton> listRadio = new List<RadioButton>();
        private Boolean finished = false;
        private CancellationTokenSource cts;

        public Game()
        {
            InitializeComponent();

            Game.updatePath();
            player = new Player();
            music = new Musique();
            choiceList = new List<String>(music.ListMusic);

            cts = new CancellationTokenSource();

            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);

            onStartMusic();
        }

        public async void onStartMusic()
        {
            isGameFinished();
            if (!finished)
            {
                progressTimer.Maximum = 14;

                music.OnPlay = getrandom.Next(0, music.ListMusic.Count - 1);
                setRadioText();
                reponse = "";
                wplayer = new WMPLib.WindowsMediaPlayer();

                wplayer.URL = music.Path + "\\" + music.ListMusic[music.OnPlay];
                wplayer.controls.play();

                await playForSomeSeconds();
                if (progressTimer.Value == 0 && !finished && !timer1.Enabled)
                {
                    button2_Click(this, EventArgs.Empty);
                }
            }
        }

        async Task playForSomeSeconds()
        {
            cts.Token.ThrowIfCancellationRequested();
            timer1.Start();
            await Task.Delay(15000);
        }

        private void setRadioText()
        {
            int position = getrandom.Next(0, 3);
            getRadioChoices();
            listRadio[position].Text = music.ListMusic[music.OnPlay];
            listRadio.RemoveAt(position);
            addOtherChoices();
            resetRadioChecked();
        }

        private void resetRadioChecked()
        {
            getRadioChoices();
            foreach (RadioButton button in listRadio)
            {
                if (button.Checked)
                {
                    button.Checked = false;
                }
            }
        }

        private void getRadioChoices()
        {
            listRadio.Clear();
            listRadio.Add(musiqueChoice1);
            listRadio.Add(musiqueChoice2);
            listRadio.Add(musiqueChoice3);
            listRadio.Add(musiqueChoice4);
        }

        private void addOtherChoices()
        {
            List<String> alreadyTaken = new List<string>();
            while (listRadio.Count > 0)
            {
                String randChoice = choiceList[getrandom.Next(0, choiceList.Count)];
                if (!alreadyTaken.Contains(randChoice) && randChoice != music.ListMusic[music.OnPlay])
                {
                    alreadyTaken.Add(randChoice);
                    listRadio[0].Text = randChoice;
                    listRadio.RemoveAt(0);
                }
            }
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            if (progressTimer.Value != 14)
            {
                progressTimer.Value++;
            }
            else
            {
                //timer1.Stop();
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
            resetRadioColors();
            onStartMusic();
        }

        private void musiqueChoice1_CheckedChanged(object sender, EventArgs e)
        {
            reponse = musiqueChoice1.Text;
        }

        private void musiqueChoice2_CheckedChanged(object sender, EventArgs e)
        {
            reponse = musiqueChoice2.Text;
        }

        private void musiqueChoice3_CheckedChanged(object sender, EventArgs e)
        {
            reponse = musiqueChoice3.Text;
        }

        private void musiqueChoice4_CheckedChanged(object sender, EventArgs e)
        {
            reponse = musiqueChoice4.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            isGameFinished();
            Boolean isWrong = true;

            //MessageBox.Show("reponse = " + reponse);

            if (reponse == music.ListMusic[music.OnPlay])
            {
                goodResponse.Show();
                isWrong = false;
                player.incrementScore((15 - progressTimer.Value) / 3);
                txtScore.Text = "Score : " + player.Score;
            }
            else
            {
                wrongAnswer.Show();
            }
            setRadioColors(isWrong, reponse);


            music.ListMusic.RemoveAt(music.OnPlay);
            wplayer.controls.stop();
            timer1.Stop();
            timer1.Enabled = false;
            progressTimer.Value = 0;
            button1.Show();
        }

        private void isGameFinished()
        {
            if (music.ListMusic.Count <= 0)
            {
                finished = true;
                DialogResult dialogResult = MessageBox.Show("Il n'y a plus de chansons, la partie est finie \r Score : " + player.Score + "", "Terminé", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK)
                {
                    string pseudo = "AAA";
                    DialogResult inputRes = Form1.InputBox("Score", "Enregistrer le score ? (" + player.Score + ")", ref pseudo);
                    if (inputRes == DialogResult.OK)
                    {
                        player.Pseudo = pseudo;
                        Score score = new Score();
                        score.insertScore(player);
                    }
                }

                this.Parent.Controls.Remove(this);
                cts.Cancel();
            }
        }

        private void setRadioColors(Boolean wrong, string wronganswer)
        {
            getRadioChoices();
            foreach (RadioButton button in listRadio)
            {
                if (wrong && button.Text == wronganswer)
                {
                    button.BackColor = System.Drawing.Color.FromArgb(255, 255, 68, 68);
                }
                if (button.Text == music.ListMusic[music.OnPlay])
                {
                    button.BackColor = System.Drawing.Color.FromArgb(255, 93, 210, 17);
                }
            }
        }
        private void resetRadioColors()
        {
            getRadioChoices();
            foreach (RadioButton button in listRadio)
            {
                button.BackColor = System.Drawing.Color.FromArgb(255, 60, 60, 60);
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
            cts.Cancel();
            wplayer.controls.stop();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public static void updatePath() {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=(localdb)\\ProjectsV13;Database=blind_test;Trusted_Connection=true";
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    String req = "SELECT * FROM Path";
                    SqlCommand cmd = new SqlCommand(req, conn);
                    using (SqlDataReader oReader = cmd.ExecuteReader())
                    {
                        while (oReader.Read())
                        {
                            Musique.path = oReader["path"].ToString();
                        }
                    }
                }
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
