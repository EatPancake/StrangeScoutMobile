using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeScoutMobile.Games
{
    //Class that definds a round
    public class Round
    {
        private string roundState = "tele";

        private int points;
        private double cycleTime;
        private List<double> cycleTimes = new List<double>();

        List<ScoringPositions> scoringPositions;
        List<ObjectLocations> objectLocations;
        List<ScoringPositions> History = new List<ScoringPositions>();
        List<ObjectLocations> LocationHistory = new List<ObjectLocations>();


        private DateTime startTime;


        public void setScoringPositions(List<ScoringPositions> scorePos)
        {
            scoringPositions = scorePos;
        }
        public void setObjectLocations(List<ObjectLocations> objLoc)
        {
            objectLocations = objLoc;
        }

        //adds a set amount of points to the score
        public void addPoints(int point)
        {
            points += point;
        }
        //sets a set amount of poins
        public void setPoints(int point)
        {
            points = point;
        }
        // get the current score
        public int getPoints()
        {
            return points;
        }
        // get when to start the cycle
        public void startCycle()
        {
            startTime = DateTime.Now;
        }
        // get the final time of the cycle and find the time in seconds
        public double stopCycle()
        {
            double FinalTime = DateTime.Now.Subtract(startTime).TotalSeconds;
            cycleTimes.Add(FinalTime);
            return FinalTime;
        }
        // take an avg of the cycle times
        public double avgCycle()
        {
            double avg = 0;
            for(int i = 0; i < cycleTimes.Count; i++)
            {
                avg += cycleTimes[i];
            }
            return avg / cycleTimes.Count;
        }


        public void SetHistory(ScoringPositions p)
        {
            History.Add(p);
        }
        public void SetLocationHistory(ObjectLocations l)
        {
            LocationHistory.Add(l);
        }

        public List<ScoringPositions >GetHistory()
        {
            return History;
        }
        public List<ObjectLocations> GetLocationHistory()
        {
            return LocationHistory; 
        }


        public void Undo()
        {
            var last = History.First();
            setPoints(getPoints() - last.getValue());
            var lastLoc = LocationHistory.First();
            LocationHistory.Remove(lastLoc);
            History.Remove(last);
            LocationHistory.Remove(lastLoc);
            cycleTimes.Remove(cycleTimes.First());
        }

        public void Scored(ScoringPositions SP)
        {
            addPoints(SP.getValue());
            SetHistory(SP);
        }

        public string getState()
        {
            return roundState;
        }
        
    }
}
