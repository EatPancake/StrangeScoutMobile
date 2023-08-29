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
        private static string filename = "C:\\Users\\arche\\Documents\\C#Programs\\StrangeScoutMobile\\StrangeScoutMobile\\Games\\ChargedUp2023\\ChargedUpData.db";
        SQLiteConnection conn = new SQLiteConnection(filename);

        public void setup()
        {
            
            conn.CreateTable<Rounds>();
        }
    }
}
