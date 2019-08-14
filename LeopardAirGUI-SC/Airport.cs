using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leopardair_wfa
{
    public class Airport
    {
        private string name;
        public string Name
        {
            get { return name; }
        }
        private string state;
        public string State
        {
            get { return state; }
        }

        private string city;
        public string City
        {
            get { return city; }
        }
        public Airport(string aName, string aState, string aCity)
        {
            this.name = aName;
            this.state = aState;
            this.city = aCity;
        }
    }
}
