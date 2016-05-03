using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlindTest
{
    class Score
    {
        int id;
        String pseudo;
        String m_score;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
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

        public string Sscore
        {
            get
            {
                return m_score;
            }

            set
            {
                m_score = value;
            }
        }

        public List<Score> getAll() {
            List<Score> scoreList = new List<Score>();
            using (SqlConnection conn = new SqlConnection()) {
                conn.ConnectionString = "Server=(localdb)\\ProjectsV13;Database=blind_test;Trusted_Connection=true";
                conn.Open();
                if (conn.State == ConnectionState.Open) {
                    String req = "SELECT * FROM Score ORDER BY score DESC LIMIT 10";
                    SqlCommand cmd = new SqlCommand(req, conn);
                    using (SqlDataReader oReader = cmd.ExecuteReader()) {
                        while (oReader.Read()) {
                            Score score = new Score();
                            score.Pseudo = oReader["pseudo"].ToString();
                            score.Sscore = oReader["score"].ToString();
                            scoreList.Add(score);
                        }
                    }
                }
                conn.Close();
                conn.Dispose();
            }
            return scoreList;
        }

        public void insertScore(Player player)
        {
            using (SqlConnection conn = new SqlConnection())
            {
                conn.ConnectionString = "Server=(localdb)\\ProjectsV13;Database=blind_test;Trusted_Connection=true";
                conn.Open();
                String req = "INSERT INTO Score (pseudo, score) VALUES ('" + player.Pseudo + "', '" + player.Score + "')";
                SqlCommand cmd = new SqlCommand(req);
                cmd.Connection = conn;
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Dispose();
            }
        }
    }
}
