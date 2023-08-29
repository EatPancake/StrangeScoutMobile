using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using SQLite;
using StrangeScoutMobile.Games.ChargedUp2023.Models;

namespace StrangeScoutMobile.Games.ChargedUp2023
{
    public class ChargedUpLocalDataBase
    {
        //private static string filename = Path.Combine(FileSystem.AppDataDirectory, "ChargedUpData.db");
        SQLiteConnection conn = new SQLiteConnection(Constants.DatabasePath);
        RoundData testRound = new RoundData("Worlds", 4, 1232);

        public void setup()
        {
            conn.CreateTable<Rounds>();
        }
        public int test()
        {
            int r = conn.Insert(testRound);
            return r;
        }
    }
}
