using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeopardAirr
{   
    public class Passenger
    {
        private string name;
        public string Name
        { get { return name; } }

        private string icnumber;
        public string ICNumber
        { get { return icnumber; } }

        private int passengseatrow;
        public int PassengSeatRow
        { get { return passengseatrow; } }

        private string passengseatcolumn;
        public string PassengSeatColumn
        { get { return passengseatcolumn; } }

        public Passenger(string aName, string aICNumber)
        {
            name = aName;
            icnumber = aICNumber;
        }

        public void PassengerSeat(int PSeatRow, string PSeatColumn)
        {
            passengseatrow = PSeatRow;
            passengseatcolumn = PSeatColumn;
        }
    }
}
