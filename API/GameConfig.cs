using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Class
{
    public class GameConfig
    {
        public bool GameStart { get; set; }
        public bool GameStop { get; set; }
        public int GameID { get; set; }
        public string Username1 { get; set; }
        public string Username2 { get; set; }
        public int PlayerID1 { get; set; }
        public int PlayerID2 { get; set; }
        public DateTime Timestamp { get; set; }
        public string IP { get; set; }

    }

}
