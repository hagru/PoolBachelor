using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Class
{
    public class GameConfig
    {
        static public bool GameStart;
        static public bool GameStop { get; set; }
        static public int GameID { get; set; }
        static public string Username1 { get; set; }
        static public string Username2 { get; set; }
        static public int PlayerID1 { get; set; }
        static public int PlayerID2 { get; set; }
        static public DateTime Timestamp { get; set; }
        //static public bool DataReceived;
        //djjdjdjdj


        public static bool DataReceived()
        {
            
            if (GameID == null)
            {
                return false;
            }
            else
            {
                return true;
            }
           
        }
    }

}
