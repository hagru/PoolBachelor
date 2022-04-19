using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolDesktopApp
{
    public class Game
    {

        public string[] balls = new string[20];
        int[] balltype = new int[2];

        public string player1Name;
        public string player2Name;
        Player player1;
        Player player2;
        Player[] players1 = new Player[2];

        public string p1BallType;
        public string p2BallType;
        public bool playerTurn;
        public bool p1Turn = false;
        public bool p2Turn = true;

        static Random rand = new Random();
        public bool balltypesChosen;
        int b;
        bool gameOpend = true;
        bool c;
        bool gameStart = true;
        //string smartConfig = ConfigurationManager.ConnectionStrings["Smart_1"].ConnectionString;
        BallDetection ball_det = new BallDetection();
        int numberOFSolid;
        int numberOfHalf;
        bool help = false;
        int gameID;
        public BallDetection ball_det1;


        public Game()
        {
            b = rand.Next(0, 2);
            ball_det1 = new BallDetection();
          

        }

        public Player[] InitPLayers()
        {
            player1Name = Startpage.p1Name;
            player2Name = Startpage.p2Name;
            p1BallType = Startpage.ballTypeP1;
            p2BallType = Startpage.ballTypeP2;
            p1Turn = false;
            p2Turn = true;

            if (p1BallType == "Solid")
            {
                player1 = new Player(GameInfo.PlayerID1, p1BallType, player1Name, p1Turn, true, false);
                player2 = new Player(GameInfo.PlayerID2, p2BallType, player2Name, p2Turn, false, true);
            }

            else if (p1BallType == "Half")
            {
                player1 = new Player(GameInfo.PlayerID1, p1BallType, player1Name, p1Turn, false, true);
                player2 = new Player(GameInfo.PlayerID2, p2BallType, player2Name, p2Turn, true, false);
            }

            players1[0] = player1;
            players1[1] = player2;

            return players1;

        }



        Player[] players = new Player[2];
        public Player[] PlayerTurn1(BallDetection ballDetection)
        {
            ball_det1 = ballDetection;
            int solid = NumberOfBallsOfEachtype(ballDetection.balls)[1];
            int half = NumberOfBallsOfEachtype(ballDetection.balls)[0];

            if (player1.PlayerTurn == true && CheckWhite() == true)
            {
                player1.PlayerTurn = false;
                player2.PlayerTurn = true;
            }
            else if (player2.PlayerTurn == true && CheckWhite() == true)
            {
                player1.PlayerTurn = true;
                player2.PlayerTurn = false;
            }
            else if (player1.PlayerTurn == true && player1.Solidball == true)
            {
                if (solid < numberOFSolid)
                {
                    player1.PlayerTurn = true;
                }
                else
                {
                    player1.PlayerTurn = false;
                    player2.PlayerTurn = true;
                }

                numberOfHalf = half;
                numberOFSolid = solid;
            }
            else if (player1.PlayerTurn == true && player1.Halfball == true)
            {
                if (half < numberOfHalf)
                {
                    player1.PlayerTurn = true;
                }
                else
                {
                    player1.PlayerTurn = false;
                    player2.PlayerTurn = true;
                }
                numberOfHalf = half;
                numberOFSolid = solid;
            }
            else if (player2.PlayerTurn == true && player2.Solidball == true)
            {
                if (solid < numberOFSolid)
                {
                    player2.PlayerTurn = true;
                }
                else
                {
                    player1.PlayerTurn = true;
                    player2.PlayerTurn = false;
                }
                numberOfHalf = half;
                numberOFSolid = solid;
            }
            else if (player2.PlayerTurn == true && player2.Halfball == true)
            {
                if (half < numberOfHalf)
                {
                    player2.PlayerTurn = true;
                }
                else
                {
                    player1.PlayerTurn = true;
                    player2.PlayerTurn = false;
                }
                numberOfHalf = half;
                numberOFSolid = solid;
            }

            players[0] = player1;
            players[1] = player2;
            return players;
        }
        void Scoreboard()
        {


        }
        int[] NumberOfBallsOfEachtype(String[] ball)
        {
            int solidColorBall = 0;
            int halfColorBall = 0;

            for (int i = 0; i < ball.GetUpperBound(0); i++)
            {
                if (ball[i] == "orange-whole")
                {
                    solidColorBall++; 
                }
                if (ball[i] == "green-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "red-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "blue-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "purple-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "yellow-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "brown-whole")
                {
                    solidColorBall++;
                }
                if (ball[i] == "orange-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "yellow-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "brown-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "blue-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "purple-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "red-half")
                {
                    halfColorBall++;
                }
                if (ball[i] == "green-half")
                {
                    halfColorBall++;
                }
            }
            balltype[0] = halfColorBall;
            balltype[1] = solidColorBall;

            return balltype;
        }

        public int SetBallColor(string ballColor)
        {
            int ballId = 0;

           
                if (ballColor == "orange-whole")
                {
                    ballId = 5;
                }
                if (ballColor == "green-whole")
                {
                    ballId = 6;
                }
                if (ballColor == "red-whole")
                {
                    ballId = 3;
                }
                if (ballColor == "blue-whole")
                {
                    ballId = 2;
                }
                if (ballColor == "purple-whole")
                {
                    ballId = 4;
                }
                if (ballColor == "yellow-whole")
                {
                    ballId = 1;
                }
                if (ballColor == "brown-whole")
                {
                    ballId = 7;
                }
                if (ballColor == "orange-half")
                {
                    ballId = 13;
                }
                if (ballColor == "yellow-half")
                {
                    ballId = 9;
                }
                if (ballColor == "brown-half")
                {
                    ballId = 15;
                }
                if (ballColor == "blue-half")
                {
                    ballId = 10;
                }
                if (ballColor == "purple-half")
                {
                    ballId = 12;
                }
                if (ballColor == "red-half")
                {
                    ballId = 11;
                }
                if (ballColor == "green-half")
                {
                    ballId = 14;
                }
                if (ballColor == "black")
                {
                    ballId = 8;
                }
                if (ballColor == "white")
                {
                    ballId = 0;
                }

            return ballId;
        }

        string[] ballNames = { "yellow-whole", "blue-whole", "red-whole", "purple-whole", "orange-whole", "green-whole", "brown-whole", "black", "yellow-half",
                "blue-half", "red-half", "purple-half", "orange-half", "green-half", "brown-half"};

        string CONNECTION_STRING = "Server=134.209.89.125;" + "User Id=vision;" + "Password=8FxLL6Ur6Yk!3H7acTKf^pJ$$o9DYipWfYVS;" + "Database=smartpool";
       public static int count = 0;
        double xpos = 0;
        double ypos = 0;
        public void BilliardBall()
        {
            
            if (players[0].PlayerTurn == true && players[1].PlayerTurn == false)
            {
                for (int i = 0; i < ball_det1.balls.GetUpperBound(0); i++)
                {
                    if (ball_det1.balls[i] != null)
                    {
                        try
                        {

                            using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
                            {
                                connection.Open();
                                NpgsqlCommand cmd = new NpgsqlCommand();
                                cmd.Connection = connection;
                                cmd.CommandText = "INSERT INTO billiardball values(@gameID, @x_pos, @y_pos, @playerID, @timeStamp, @playCount, @ballCoulor)";
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.Add(new NpgsqlParameter("@gameID",GameInfo.GameID));
                                cmd.Parameters.Add(new NpgsqlParameter("@x_pos", ball_det1.balls_x[i]));
                                cmd.Parameters.Add(new NpgsqlParameter("@y_pos", ball_det1.ball_y[i]));
                                cmd.Parameters.Add(new NpgsqlParameter("@playerID", 5));
                                cmd.Parameters.Add(new NpgsqlParameter("@timeStamp", DateTime.Now));
                                cmd.Parameters.Add(new NpgsqlParameter("@playCount", count));
                                cmd.Parameters.Add(new NpgsqlParameter("@ballCoulor", SetBallColor(ball_det1.balls[i])));

                                cmd.ExecuteNonQuery();
                                cmd.Dispose();
                                connection.Close();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                }

            }
            else if (players[1].PlayerTurn == true)
            {
                for (int i = 0; i < ball_det1.balls.GetUpperBound(0); i++)
                {
                    if (ball_det1.balls[i] != null)
                    {
                        try
                        {

                            using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
                            {
                                connection.Open();
                                NpgsqlCommand cmd = new NpgsqlCommand();
                                cmd.Connection = connection;
                                cmd.CommandText = "INSERT INTO billiardball values(@gameID, @x_pos, @y_pos, @playerID, @timeStamp, @playCount, @ballCoulor)";
                                cmd.CommandType = CommandType.Text;
                                cmd.Parameters.Add(new NpgsqlParameter("@gameID", GameInfo.GameID));
                                cmd.Parameters.Add(new NpgsqlParameter("@x_pos", ball_det1.balls_x[i]));
                                cmd.Parameters.Add(new NpgsqlParameter("@y_pos", ball_det1.ball_y[i]));
                                cmd.Parameters.Add(new NpgsqlParameter("@playerID", 4));
                                cmd.Parameters.Add(new NpgsqlParameter("@timeStamp", DateTime.Now));
                                cmd.Parameters.Add(new NpgsqlParameter("@playCount", count));
                                cmd.Parameters.Add(new NpgsqlParameter("@ballCoulor", SetBallColor(ball_det1.balls[i])));

                                cmd.ExecuteNonQuery();
                                cmd.Dispose();
                                connection.Close();
                            }

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);

                        }
                    }
                }

                
            }
            count++;
        }

        public bool CheckWhite()
        {
            bool whiteDown = false;


            if (ball_det1.balls.Contains("white"))
            {
                whiteDown = false;
            }
            else if (ball_det1.balls.Contains("white") == false)
            {
                whiteDown = true;
            }


            return whiteDown;

        }

        public void Update(Player[] player)
        {
            if (player[0].win == true)
            {
                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
                    {
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE player SET wins = (Select(wins + 1) from player where playerid =" + player[0].PlayerId + ") WHERE playerid =" + player[0].PlayerId;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                    }
                    using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
                    {
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE game SET winner ="+player[0].PlayerId+" WHERE gameid =" + GameInfo.GameID;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                    }
                }
                catch (Exception w)
                {

                    MessageBox.Show(w.Message);
                }
            }
            else if (player[0].win == false)
            {
                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
                    {
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE player SET losses = (Select(losses + 1) from player where playerid =" + player[0].PlayerId + ") WHERE playerid =" + player[0].PlayerId;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                    }
                    using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
                    {
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE game SET loser =" + player[0].PlayerId + " WHERE gameid =" + GameInfo.GameID;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                    }
                }
                catch (Exception w)
                {

                    MessageBox.Show(w.Message);
                }
            }
            if (player[1].win == true)
            {
                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
                    {
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE player SET wins = (Select(wins + 1) from player where playerid =" + player[1].PlayerId + ") WHERE playerid =" + player[1].PlayerId;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                    }
                    using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
                    {
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE game SET winner =" + player[1].PlayerId + " WHERE gameid =" + GameInfo.GameID;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                    }
                }

                catch (Exception w)
                {

                    MessageBox.Show(w.Message);
                }
            }
            else if (player[1].win == false)
            {
                try
                {
                    using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
                    {
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE player SET losses = (Select(losses + 1) from player where playerid =" + player[1].PlayerId + ") WHERE playerid =" + player[1].PlayerId;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                    }
                    using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
                    {
                        connection.Open();
                        NpgsqlCommand cmd = new NpgsqlCommand();
                        cmd.Connection = connection;
                        cmd.CommandText = "UPDATE game SET loser =" + player[1].PlayerId + " WHERE gameid =" + GameInfo.GameID;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        connection.Close();
                    }
                }
                catch (Exception w)
                {

                    MessageBox.Show(w.Message);
                }
            }

        }
        public void UpdateTimeStamp()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
                {
                    connection.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = connection;
                    cmd.CommandText = "UPDATE game SET endtime =" + "'" + (DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ssZ")) + "'" + " where gameid = " + GameInfo.GameID;
                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connection.Close();
                }
            }
            catch (Exception w)
            {

                MessageBox.Show(w.Message);
            }

        }
        public void Getplaycount()
        { 
            using (NpgsqlConnection connection = new NpgsqlConnection(CONNECTION_STRING))
            {
                 
                string quary = "SELECT MAX(playcount) as bn FROM billiardball where gameid = (select MAX(gameid) from game)";
                NpgsqlCommand cmd = connection.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = quary;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                connection.Open();
                cmd.ExecuteNonQuery();
                NpgsqlDataReader reader = cmd.ExecuteReader();
                try
                {
                    while (reader.Read())
                    {
                        count = Int32.Parse(reader["bn"].ToString());
                    }

                }
                catch (Exception)
                {
                    count = 0;
                }
                cmd.Dispose();
                connection.Close();
            }

        }

    }
   
}

