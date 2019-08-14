using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeopardAirr
{
    public class Flight
    {
        private string code;
        public string Code
        {
            get { return code; }
        }

        private string date;
        public string Date
        {
            get { return date; }
        }

        private string departureAirport;
        public string DepartureAirport
        {
            get { return departureAirport; }
        }

        private string arrivalAirport;

        public string ArrivalAirport
        {
            get { return arrivalAirport; }
        }

        private int numberOfAirports;
        public int NumberOfAirports
        {
            get { return numberOfAirports; }
        }

        private string departuretime;
        public string DepartureTime
        { get { return departuretime; } }
        
        private Airport[] departairport;
        public Airport[] DepartAirport
        {
            get { return departairport; }
        }
        private Airport[] arriveairport;
        public Airport[] ArriveAirport
        {
            get { return arriveairport; }
        }

        private int numberOfPassengers;
        public int NumberOfPassengers
        {
            get { return numberOfPassengers; }
        }

        private Passenger[] passengerList;
        public Passenger[] PassengerList
        {
            get { return passengerList; }
        }

        private static readonly int MAX_NUMBER_OF_PASSENGERS = 180;

        private Seat flightseating;
        public Seat FlightSeating
        {
            get { return flightseating; }
        }

        public Flight(string zCode, string zDate, string zTime, string zOrigin, string zDestination)
        {
            code = zCode;
            date = zDate;
            departuretime = zTime;
            departureAirport = zOrigin;
            arrivalAirport = zDestination;
            numberOfAirports = 0;
            departairport = new Airport[99];
            arriveairport = new Airport[99];
            numberOfPassengers = 0;
            passengerList = new Passenger[MAX_NUMBER_OF_PASSENGERS];
            flightseating = new Seat();
        }

        public void AddAirport(Airport zDepartAirport, Airport zArriveAirport)
        {
            if (numberOfAirports < 99)
            {
                departairport[numberOfAirports] = zDepartAirport;
                arriveairport[numberOfAirports] = zArriveAirport;
                numberOfAirports++;
            }
        }

        public void AddPassenger(Passenger passenger)
        {
            if (numberOfPassengers < MAX_NUMBER_OF_PASSENGERS)
            {
                passengerList[numberOfPassengers] = passenger;
                numberOfPassengers++;
            }
        }

 /*       public bool CheckFlightFull()
        {
            if (numberOfPassengers < MAX_NUMBER_OF_PASSENGERS)
            { return false; }
            else
            { return true; }
        }*/

        public void ShowSeating()
        {
            flightseating.DisplaySeat();
        }

        public double BuySeating(int theRow, string theColumn)
        {
            double seatcharges = flightseating.PickSeat(theRow, theColumn);
            passengerList[(numberOfPassengers)-1].PassengerSeat(theRow, theColumn);
            return seatcharges;
        }

        public bool CheckSeat(int thatRow, string thatColumn)
        {
            return flightseating.SeatTaken(thatRow, thatColumn);
        }

        public double CancelSeat(int CSrow, string CScolumn)
        {
            numberOfPassengers--;
            return flightseating.RemoveSeat(CSrow, CScolumn);
        }

        public void PrintTicket(string byName, string byICNum, string byCode, string byDestination, string byDate, string byTime, int byRow, string byColumn, double byPrice, double byPoints)
        {
            Console.WriteLine("...............................................................................................................................");
            Console.WriteLine("..  |||         ||||||||||   ||||||||   |||||||||    ||||||||   |||||||||   |||||||||    ||||||||   ||||||||||  |||||||||    ..");
            Console.WriteLine("..  |||         ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||   ..");
            Console.WriteLine("..  |||         |||         |||    |||  |||    |||  |||    |||  |||    |||  |||    |||  |||    |||     ||||     |||    |||   ..");
            Console.WriteLine("..  |||         ||||||||||  |||    |||  ||||||||||  ||||||||||  ||||||||||  |||    |||  ||||||||||     ||||     ||||||||||   ..");
            Console.WriteLine("..  |||         ||||||||||  |||    |||  |||||||||   ||||||||||  |||||||||   |||    |||  ||||||||||     ||||     |||||||||    ..");
            Console.WriteLine("..  |||         |||         |||    |||  |||         |||    |||  ||| |||     |||    |||  |||    |||     ||||     ||| ||||     ..");
            Console.WriteLine("..  ||||||||||  ||||||||||  ||||||||||  |||         |||    |||  |||   |||   ||||||||||  |||    |||  ||||||||||  |||   |||    ..");
            Console.WriteLine("..  ||||||||||  ||||||||||   ||||||||   |||         |||    |||  |||     ||| |||||||||   |||    |||  ||||||||||  |||     |||  ..");
            Console.WriteLine("...............................................................................................................................");
            Console.WriteLine();
            Console.WriteLine("\t\t\t FLIGHT TICKET");
            Console.WriteLine();
            Console.WriteLine("\tName:                      {0}", byName);
            Console.WriteLine("\tIC Number:                 {0}", byICNum);
            Console.WriteLine();
            Console.WriteLine("\tFlight Code:               {0}", byCode);
            Console.WriteLine("\tDestination:               {0}", byDestination);
            Console.WriteLine("\tDate of Departure:         {0}", byDate);
            Console.WriteLine("\tTime of Departure:         {0}", byTime);
            Console.WriteLine("\tSeat Number:               {0}{1}", byRow, byColumn.ToUpper());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tTicket Price:              {0}", byPrice);
            Console.WriteLine("\tCurrent Points:            {0}", byPoints);
            Console.WriteLine();
            Console.WriteLine();
        }

        public void PrintBill(string PBName, string PBCode, int PBRow, string PBColumn, double PBPrice)
        {
            Console.WriteLine("...............................................................................................................................");
            Console.WriteLine("..  |||         ||||||||||   ||||||||   |||||||||    ||||||||   |||||||||   |||||||||    ||||||||   ||||||||||  |||||||||    ..");
            Console.WriteLine("..  |||         ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||  ||||||||||   ..");
            Console.WriteLine("..  |||         |||         |||    |||  |||    |||  |||    |||  |||    |||  |||    |||  |||    |||     ||||     |||    |||   ..");
            Console.WriteLine("..  |||         ||||||||||  |||    |||  ||||||||||  ||||||||||  ||||||||||  |||    |||  ||||||||||     ||||     ||||||||||   ..");
            Console.WriteLine("..  |||         ||||||||||  |||    |||  |||||||||   ||||||||||  |||||||||   |||    |||  ||||||||||     ||||     |||||||||    ..");
            Console.WriteLine("..  |||         |||         |||    |||  |||         |||    |||  ||| |||     |||    |||  |||    |||     ||||     ||| ||||     ..");
            Console.WriteLine("..  ||||||||||  ||||||||||  ||||||||||  |||         |||    |||  |||   |||   ||||||||||  |||    |||  ||||||||||  |||   |||    ..");
            Console.WriteLine("..  ||||||||||  ||||||||||   ||||||||   |||         |||    |||  |||     ||| |||||||||   |||    |||  ||||||||||  |||     |||  ..");
            Console.WriteLine("...............................................................................................................................");
            Console.WriteLine();
            Console.WriteLine("\t\t\t FLIGHT CANCELLATION BILL");
            Console.WriteLine();
            Console.WriteLine("\tName:                      {0}", PBName);
            Console.WriteLine();
            Console.WriteLine("\tFlight Code:               {0}", PBCode);
            Console.WriteLine("\tSeat Number:               {0}{1}", PBRow, PBColumn.ToUpper());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\tCancellation Fee:          {0}", PBPrice);
            Console.WriteLine();
            Console.WriteLine();
        }

        public int FindName(string FNName)
        {
            for(int FN = 0; FN < passengerList.Length; FN++)
            {
                if (passengerList[FN].Name == FNName)
                { return FN; }
            }
            return -5;
        }
    }
}
