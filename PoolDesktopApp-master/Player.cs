using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolDesktopApp
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string BallType { get; set; }
        public string Name { get; set; }
        public bool Solidball { get; set; }
        public bool Halfball { get; set; }
        public bool PlayerTurn { get; set; }
        public bool Player_result { get; set; }
        public int NumberOfSolidball { get; set; }
        public int NumberOfHalfball { get; set; }


        public Player(int playerId, string ballType, string name, bool playerTurn, bool solidBall, bool halfBall)
        {
            PlayerId = playerId;
            BallType = ballType;
            Name = name;
            PlayerTurn = playerTurn;
            Solidball = solidBall;
            Halfball = halfBall;
        }

        string BilliardConfig = ConfigurationManager.ConnectionStrings["Billiard_1"].ConnectionString;

        public void GetPlayerNames(int userId)
        {
            using (SqlConnection con = new SqlConnection(BilliardConfig))
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT Users.firstName FROM users,player WHERE player.playerID =" + "'" + userId + "'" + "AND player.userID = Users.userID ";
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Name = Convert.ToString(dr["Users.firstName"]);
                    }
                    dr.Close();
                }
                con.Close();
            }
        }
    }
}
