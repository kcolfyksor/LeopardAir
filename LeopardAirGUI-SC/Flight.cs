using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leopardair_wfa
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

        private string departurecity;
        public string DepartureCity
        {
            get { return departurecity; }
        }

        private string arrivalcity;

        public string ArrivalCity
        {
            get { return arrivalcity; }
        }

        private int numberOfAirports;
        public int NumberOfAirports
        {
            get { return numberOfAirports; }
        }

        private string departuretime;
        public string DepartureTime
        { get { return departuretime; } }

        private string arrivaltime;
        public string ArrivalTime
        { get { return arrivaltime; } }

        private double flightprice;
        public double FlightPrice
        { get { return flightprice; } }

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

        public Flight(string zCode, string zDate, string zDTime, string zATime, string zDCity, string zACity, double zPrice)
        {
            this.code = zCode;
            this.date = zDate;
            this.departuretime = zDTime;
            this.arrivaltime = zATime;
            this.departurecity = zDCity;
            this.arrivalcity = zACity;
            this.flightprice = zPrice;
            this.numberOfAirports = 0;
            this.departairport = new Airport[10];
            this.arriveairport = new Airport[10];
            this.numberOfPassengers = 0;
            this.passengerList = new Passenger[MAX_NUMBER_OF_PASSENGERS];
            this.flightseating = new Seat();
        }

        public void AddAirport(Airport yDepartAirport, Airport yArriveAirport)
        {
            if (this.numberOfAirports < 10)
            {
                this.departairport[this.numberOfAirports] = yDepartAirport;
                this.arriveairport[this.numberOfAirports] = yArriveAirport;
                this.numberOfAirports++;
            }
        }

        public void AddPassenger(Passenger passenger)
        {
            if (this.numberOfPassengers < MAX_NUMBER_OF_PASSENGERS)
            {
                this.passengerList[this.numberOfPassengers] = passenger;
                this.numberOfPassengers++;
            }
        }
/*       
        public void ShowSeating()
        {
            this.flightseating.DisplaySeat();
        }
*/
        public double BuySeating(int xRow, string xColumn)
        {
            double seatcharges = this.flightseating.PickSeat(xRow, xColumn);
            this.passengerList[(this.numberOfPassengers) - 1].PassengerSeat(xRow, xColumn);
            return seatcharges;
        }

        public bool CheckSeat(int wRow, string wColumn)
        {
            return this.flightseating.SeatTaken(wRow, wColumn);
        }

        public double CancelSeat(int vRow, string vColumn)
        {
            this.numberOfPassengers--;
            return this.flightseating.RemoveSeat(vRow, vColumn);
        }

        public Passenger FindPassenger(string uName, string uICNum)
        {
            for (int n = 0; n < this.passengerList.Length; n++)
            {
                if (passengerList[n].Name == uName && passengerList[n].ICNumber == uICNum)
                {
                    return passengerList[n];
                }
                else
                {
                    break;
                }
            }
            return null;
        }

        public Passenger AllPassenger(int pcount)
        {
                return this.passengerList[pcount];
        }

        public int PassengerListCount()
        {
            return this.passengerList.Length;
        }
    }
}
