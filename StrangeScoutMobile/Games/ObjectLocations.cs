using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrangeScoutMobile.Games
{
    public class ObjectLocations
    {
        string name;

        public ObjectLocations(string _name)
        {
            name = _name;
        }
        public ObjectLocations(string _name,string state) { }

        public string getName()
        {
            return name;
        }
    }
}
