using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeScoutMobile.Games
{
    internal class Constants
    {
        public const string DataBaseFilename = "ChargedUpLocal.db";

        public const SQLite.SQLiteOpenFlags Flags =
            //open read write
            SQLite.SQLiteOpenFlags.ReadWrite |
            // create db
            SQLite.SQLiteOpenFlags.Create |
            // mutithread acc
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DataBaseFilename);
    }
}
