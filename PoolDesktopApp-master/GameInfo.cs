using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolDesktopApp
{
    public static class GameInfo
    {
       
            public static bool GameStart { get; set; }
        public static bool GameStop { get; set; }
        public static int GameID { get; set; }
        public static string Username1 { get; set; }
        public static string Username2 { get; set; }
        public static int PlayerID1 { get; set; }
        public static int PlayerID2 { get; set; }
        public static DateTime Timestamp { get; set; }
        public static bool ConnectedToDatabase { get; set; }
        public static string CameraName { get; set; }

    }
}
