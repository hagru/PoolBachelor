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
        public bool SolidBall { get; set; }
        public bool HalfBall { get; set; }
        public bool PlayerTurn { get; set; }
        public bool PlayerResult { get; set; }
        public int NumberOfSolidball { get; set; }
        public int NumberOfHalfball { get; set; }
        public bool Win { get; set; }
        public bool Lose{ get; set; }



        public Player(int playerId, string ballType, string name, bool playerTurn, bool solidBall, bool halfBall)
        {
            PlayerId = playerId;
            BallType = ballType;
            Name = name;
            PlayerTurn = playerTurn;
            SolidBall = solidBall;
            HalfBall = halfBall;
        }
        
    }
}
