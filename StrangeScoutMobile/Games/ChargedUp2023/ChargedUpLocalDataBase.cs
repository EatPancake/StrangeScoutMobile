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
        private static string filename = "ChargedUpData.db";
        SQLiteConnection conn = new SQLiteConnection(filename);
        private RoundData test = new RoundData("week 1", "2", "1533");

        public void setup()
        {
            conn.CreateTable<Rounds>();
        }
        public int testAdd()
        {
            int result = conn.Insert(test);
            return result;
        }
    }
}
