using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolDesktopApp
{
    class Ball
    {

        public string BallId { get; set; }
        public bool IsOnTable { get; set; }
        public string ImageString { get; set; }
        public string BallType { get; set; }
        public double XPos { get; set; }
        public double YPos { get; set; }


        public Ball(string ballId, bool isOnTable, string imageString)
        {
            BallId = ballId;
            IsOnTable = isOnTable;
            ImageString = imageString;
        }

        public Ball(string ballId, bool isOnTable, string imageString, string balltype, double xPos, double yPos)
        {
            BallId = ballId;
            IsOnTable = isOnTable;
            ImageString = imageString;
            BallType = balltype;
            XPos = xPos;
            YPos = yPos;
        }
    }
}
