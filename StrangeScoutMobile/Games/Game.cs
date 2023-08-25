using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Class to define the FRC game basics*/
namespace StrangeScoutMobile.Games
{
    public class Game
    {
        public Round round = new Round();
        public string matchState = "tele";

        private string name;
        private int year;
        private string imagePath;

        List<ScoringPositions> ScoringPos = new List<ScoringPositions>();
        List<ObjectLocations> Locations = new List<ObjectLocations>();


        public Game(string _name, int _year, string _image, List<ScoringPositions> _ScoringPos, List<ObjectLocations> _Locations)
        {
            name = _name;
            year = _year;
            imagePath = _image;
            Locations = _Locations;
            ScoringPos = _ScoringPos;
        }
        public Game() { }

        // Return full name of game like '2023 FRC Charged Up'
        public string toString()
        {
            return year + " FRC " + name;
        }

        //gets the name of the game
        public string getName()
        {
            return name;
        }
        //gets the year of the game
        public int getYear()
        {
            return year;
        }
        //gets the feild image of the game
        public string getImagePath()
        {
            return imagePath;
        }
        public List<ObjectLocations> GetLocations()
        {
            return Locations;
        }
        public List<ScoringPositions> GetScoringPositions()
        {
            return ScoringPos;
        }

    }
}
