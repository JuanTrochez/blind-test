using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindTest
{
    class Player
    {
        private String pseudo;
        private int score;

        public Player()
        {
            this.pseudo = "AAA";
            this.score = 0;
        }

        public string Pseudo
        {
            get
            {
                return pseudo;
            }

            set
            {
                pseudo = value;
            }
        }

        public int Score
        {
            get
            {
                return score;
            }

            set
            {
                score = value;
            }
        }

        public void incrementScore() {
            this.score++;
        }       

    }
}
