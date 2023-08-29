using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeScoutMobile.Games.ChargedUp2023.Models
{
    [Table("Rounds")]
    public class Rounds
    {
        //Info
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        [Required]
        public string Event { get; set; }
        [Required]
        public int Round { get; set; }
        [Required]
        public int TeamNumber { get; set; }


        //Auto
        public int Cone_A { get; set; }
        public int Cube_A { get; set; }

        public int Double_A { get; set; }
        public int Single_A { get; set; }
        public int Center_A { get; set; }

        public bool Mobility { get; set; }
        public string ChargeStation_A { get; set; }

        //Teleop
        public int Cone_T { get; set; }
        public int Cube_T { get; set; }

        public int Double_T { get; set; }
        public int Single_T { get; set; }
        public int Center_T { get; set; }


        //End game
        public int Cone_E { get; set; }
        public int Cube_E { get; set; }

        public int Double_E { get; set; }
        public int Single_E { get; set; }
        public int Center_E { get; set; }

        public bool Parked { get; set; }
        public string ChargeStation_E { get; set; }

        public string Grid { get; set; }
    }

    public class RoundData
    { 
        public RoundData(string _Event, int _Round, int _TeamNumber)
        {
            string Event = _Event;
            int Round = _Round;
            int TeamNumber = _TeamNumber;
        }
    }

}
