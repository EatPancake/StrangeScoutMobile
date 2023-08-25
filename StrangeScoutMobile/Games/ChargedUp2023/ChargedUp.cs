using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeScoutMobile.Games.ChargedUp2023
{
    public class ChargedUp
    {
        private Game game;

        //Object Locations
        static ObjectLocations Center_Field = new ObjectLocations("Center_Field");
        static ObjectLocations DoubleSubStation = new ObjectLocations("DoubleSubStation");
        static ObjectLocations SingleSubStation = new ObjectLocations("SingleSubStation");
        static ObjectLocations ChargeStation = new ObjectLocations("ChargeStation");
        static ObjectLocations Grid = new ObjectLocations("Grid");
        static ObjectLocations Community = new ObjectLocations("Community");

        //Scoring Positions
        ScoringPositions Mobility = new ScoringPositions("Mobility", Center_Field, 3);
        ScoringPositions Top_Node_Auto = new ScoringPositions("Top_Node_Auto", Grid, 6);
        ScoringPositions Mid_Node_Auto = new ScoringPositions("Mid_Node_Auto", Grid, 4);
        ScoringPositions Bot_Node_Auto = new ScoringPositions("Bot_Node_Auto", Grid, 3);
        ScoringPositions CSDocked_Auto = new ScoringPositions("ChargeStation_Docked_Auto", ChargeStation, 8);
        ScoringPositions CSEngaged_Auto = new ScoringPositions("ChargeStation_Engaged_Auto", ChargeStation, 12);

        ScoringPositions Top_Node_Tele = new ScoringPositions("Top_Node_Tele", Grid, 5);
        ScoringPositions Mid_Node_Tele = new ScoringPositions("Mid_Node_Tele", Grid, 3);
        ScoringPositions Bot_Node_Tele = new ScoringPositions("Bot_Node_Tele", Grid, 2);

        ScoringPositions Top_Node_EndGame = new ScoringPositions("Top_Node_EndGame", Grid, 5);
        ScoringPositions Mid_Node_EndGame = new ScoringPositions("Mid_Node_EndGame", Grid, 3);
        ScoringPositions Bot_Node_EndGame = new ScoringPositions("Bot_Node_EndGame", Grid, 2);
        ScoringPositions Parked_EndGame = new ScoringPositions("Parked_EndGame", Community, 5);
        ScoringPositions CSDocked_EndGame = new ScoringPositions("ChargeStation_Docked_EndGame", ChargeStation, 6);
        ScoringPositions CSEngaged_EndGame = new ScoringPositions("ChargeStation_Engaged_EndGame", ChargeStation, 10);

        //Make lists
        public void MakeGame()
        {
            List<ObjectLocations> Locations_List = new List<ObjectLocations>();
            Locations_List.Add(Center_Field);
            Locations_List.Add(DoubleSubStation);
            Locations_List.Add(SingleSubStation);
            Locations_List.Add(ChargeStation);
            Locations_List.Add(Grid);

            List<ScoringPositions> Scoring_List = new List<ScoringPositions>();
            Scoring_List.Add(Top_Node_Auto);    //0
            Scoring_List.Add(Mid_Node_Auto);    //1
            Scoring_List.Add(Bot_Node_Auto);    //2
            Scoring_List.Add(Mobility);         //3
            Scoring_List.Add(CSDocked_EndGame); //4
            Scoring_List.Add(CSEngaged_EndGame);//5

            Scoring_List.Add(Top_Node_Tele);    //6
            Scoring_List.Add(Mid_Node_Tele);    //7
            Scoring_List.Add(Bot_Node_Tele);    //8

            Scoring_List.Add(Top_Node_EndGame); //9
            Scoring_List.Add(Mid_Node_EndGame); //10
            Scoring_List.Add(Bot_Node_EndGame); //11
            Scoring_List.Add(Parked_EndGame);   //12
            Scoring_List.Add(CSDocked_EndGame); //13
            Scoring_List.Add(CSEngaged_EndGame);//14


            game = new Game("Charged Up", 2023, "$PATH", Scoring_List, Locations_List);
        }

        public Game getGameObj()
        {
            return game;
        }



    }
}
