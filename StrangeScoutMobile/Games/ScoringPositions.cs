using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeScoutMobile.Games
{
    public class ScoringPositions
    {
        string name;
        ObjectLocations location;
        int points;
        private int timesScored;

        public ScoringPositions(string _name, ObjectLocations _location, int _points) 
        {
            name = _name;
            location = _location;
            points = _points;
        }

        public int getTimesScored()
        {
            return timesScored;
        }
        public void addTimesScored()
        {
            timesScored++;
        }
        public void setTimesScored(int num)
        {
            timesScored= num;
        }
        public int getValue()
        {
            return points;
        }
        public string getName()
        {
            return name;
        }
    }
}
