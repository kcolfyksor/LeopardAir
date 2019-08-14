using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeopardAirr
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //          IMPORTANT & FUNCTIONAL VARIABLE & ARRAY INITIALIZATION
            //
            Console.SetWindowSize(130, 50);
            int[] decision = new int[99];
            int[] numbering = new int[99];
            bool[] stopper = new bool[999];
            string[] yesno = new string[99];
            stopper[0] = false;

            Flight[] flightdetail = new Flight[6];
            flightdetail[0] = new Flight("LA2231", "180825", "0800", "Kuala Lumpur", "Langkawi");
            flightdetail[1] = new Flight("LA2235", "180825", "1000", "Kuala Lumpur", "Kuching");
            flightdetail[2] = new Flight("LA2241", "180826", "0600", "Kuala Lumpur", "Kota Kinabalu");
            flightdetail[3] = new Flight("LA2245", "180826", "1400", "Kuala Lumpur", "Langkawi");
            flightdetail[4] = new Flight("LA2251", "180827", "1200", "Kuala Lumpur", "Kuching");
            flightdetail[5] = new Flight("LA2255", "180827", "2100", "Kuala Lumpur", "Kota Kinabalu");

            Membership memberlist = new Membership();
            memberlist.Register("admin", "admin");

            Airport[] theairport = new Airport[4];
            theairport[0] = new Airport("KLIA2", "Wilayah Persekutuan", "Kuala Lumpur");
            theairport[1] = new Airport("LIA", "Kedah", "Langkawi");
            theairport[2] = new Airport("KIA", "Sarawak", "Kuching");
            theairport[3] = new Airport("KKIA", "Sabah", "Kota Kinabalu");

            flightdetail[0].AddAirport(theairport[0], theairport[1]);
            flightdetail[1].AddAirport(theairport[0], theairport[2]);
            flightdetail[2].AddAirport(theairport[0], theairport[3]);
            flightdetail[3].AddAirport(theairport[0], theairport[1]);
            flightdetail[4].AddAirport(theairport[0], theairport[2]);
            flightdetail[5].AddAirport(theairport[0], theairport[3]);

            Passenger[] fakepeople = new Passenger[999];
            fakepeople[0] = new Passenger("Yamamoto", "701230145333");
            fakepeople[1] = new Passenger("William Brown", "850407129421");

            //
            //          COMPANY BANNER
            //
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
            //
            //          MAIN MENU
            //
            do
            {
                Console.WriteLine("\nWelcome to Leopard Air! ");
                Console.WriteLine();
                Console.WriteLine("Existing member");
                Console.WriteLine("1. Login");
                Console.WriteLine("First enter?");
                Console.WriteLine("2. Sign Up");
                Console.WriteLine();
                Console.WriteLine("3. Exit");
                stopper[1] = false;
                do
                {
                    Console.Write("Please select ( 1 / 2 / 3 ):   ");
                    decision[0] = Convert.ToInt32(Console.ReadLine());
                    stopper[1] = true;

                } while (stopper[1] == false);
                //
                //          MAIN MENU OPTION 1: LOGIN
                //
                if (decision[0] == 1)
                {
                    stopper[2] = false;
                    string loginusername, loginpassword;
                    bool existusername;
                    do
                    {
                        Console.Write("Enter your username:   ");
                        loginusername = Console.ReadLine();
                        Console.Write("Enter your password:   ");
                        loginpassword = Console.ReadLine();
                        existusername = memberlist.CheckMembership(loginusername, loginpassword);
                        //
                        //          FAIL LOGIN
                        //
                        if (existusername == false)
                        {
                            Console.WriteLine("\nInvalid username or password. Please try again or Sign Up.");
                            stopper[2] = true;
                        }
                        //
                        //          SUCCESSFUL LOGIN
                        //
                        else if (existusername == true)
                        {
                            stopper[5] = false;
                            do
                            {
                                stopper[4] = false;
                                do
                                {
                                    Console.WriteLine("\nSelect an action you wish to perform:");
                                    Console.WriteLine("1. Purchase air ticket.");
                                    Console.WriteLine("2. View available flights.");
                                    Console.WriteLine("3. View seat status.");
                                    Console.WriteLine("4. Cancel air ticket.");
                                    Console.WriteLine("5. Change seating.");
                                    Console.WriteLine("6. Check membership points.");
                                    Console.WriteLine("7. Return to Main Menu.\n");
                                    Console.Write("Enter (1/2/3/4/5/6/7):   ");
                                    decision[1] = Convert.ToInt32(Console.ReadLine());
                                    //
                                    //          MEMBER ACTION 1 : PURCHASE AIR TICKET
                                    //
                                    if (decision[1] == 1)
                                    {
                                        string inputdestination;
                                        string[] inputname = new string[99];
                                        string[] inputic = new string[99];
                                        int inputquantity;
                                        double destinationfee = 0, totalfee, seatingcharge;
                                        Passenger[] currentpassenger = new Passenger[999];
                                        int[] pickedrow = new int[999];
                                        string[] pickedcolumn = new string[999];
                                        stopper[8] = false;

                                        Console.Write("How many ticket would you like to buy?   ");
                                        inputquantity = Convert.ToInt32(Console.ReadLine());   
                                        for (int x1 = 0; x1 < inputquantity; x1++)
                                        {
                                            stopper[110] = false;
                                            stopper[111] = false;
                                            do
                                            {
                                                Console.Write("Enter your name:   ");
                                                inputname[x1] = Console.ReadLine();
                                                if (inputname[x1] != "" || inputname[x1] != " " || inputname[x1] != "  ")
                                                { stopper[110] = true; }
                                                else
                                                { Console.WriteLine("Invalid input. Please try again."); }
                                            } while (stopper[110] == false);
                                            do
                                            {
                                                Console.Write("Enter your IC-number:   ");
                                                inputic[x1] = Console.ReadLine();
                                                if (inputic[x1] != "" || inputic[x1] != " " || inputic[x1] != "  ")
                                                { stopper[111] = true; }
                                                else
                                                { Console.WriteLine("Invalid input. Please try again."); }
                                            } while (stopper[111] == false);
                                            double claimPoints = memberlist.CurrentPoints(loginusername);
                                            currentpassenger[x1] = new Passenger(inputname[x1], inputic[x1]);
                                            Console.WriteLine();
                                            Console.WriteLine("(1.)  {0}", theairport[1].City);
                                            Console.WriteLine("(2.)  {0}", theairport[2].City);
                                            Console.WriteLine("(3.)  {0}", theairport[3].City);
                                            Console.WriteLine();
                                            do
                                            {
                                                Console.Write("Pick your destination (1/2/3):   ");
                                                decision[2] = Convert.ToInt32(Console.ReadLine());
                                                //
                                                //          LANGKAWI WAS CHOSEN
                                                //
                                                if (decision[2] == 1)
                                                {
                                                    stopper[9] = false;
                                                    inputdestination = theairport[1].City;
                                                    destinationfee = 99;
                                                    Console.WriteLine("\tFlight Code\tDate\tDeparture Time");
                                                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                                                    Console.WriteLine("(1.)\t{0}\t\t{1}\t{2}", flightdetail[0].Code, flightdetail[0].Date, flightdetail[0].DepartureTime);
                                                    Console.WriteLine("(2.)\t{0}\t\t{1}\t{2}", flightdetail[3].Code, flightdetail[3].Date, flightdetail[3].DepartureTime);
                                                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                                                    do
                                                    {
                                                        Console.Write("Choose a flight(1/2):   ");
                                                        decision[3] = Convert.ToInt32(Console.ReadLine());
                                                        if (decision[3] == 1)
                                                        {

                                                            flightdetail[0].AddPassenger(currentpassenger[x1]);
                                                            stopper[51] = false;
                                                            bool seatstatus;
                                                            do
                                                            {
                                                                Console.Write("Would you like to choose your seat (Y/N)?   ");
                                                                yesno[1] = Console.ReadLine();
                                                                if (yesno[1].ToUpper() == "Y")
                                                                {
                                                                    flightdetail[0].ShowSeating();
                                                                    stopper[60] = false;
                                                                    stopper[61] = false;
                                                                    stopper[62] = false;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            Console.Write("Enter row number:   ");
                                                                            pickedrow[x1] = Convert.ToInt32(Console.ReadLine());
                                                                            if (pickedrow[x1] != 13 && pickedrow[x1] <= 31 && pickedrow[x1] >= 1)
                                                                            {
                                                                                stopper[60] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid row. Try again.");
                                                                            }
                                                                        } while (stopper[60] == false);
                                                                        do
                                                                        {
                                                                            Console.Write("Enter column alphabet:   ");
                                                                            pickedcolumn[x1] = Console.ReadLine();
                                                                            if (pickedcolumn[x1].ToUpper() == "A" || pickedcolumn[x1].ToUpper() == "B" || pickedcolumn[x1].ToUpper() == "C" || pickedcolumn[x1].ToUpper() == "D" || pickedcolumn[x1].ToUpper() == "E" || pickedcolumn[x1].ToUpper() == "F")
                                                                            {
                                                                                stopper[61] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid column. Try again.");
                                                                            }
                                                                        } while (stopper[61] == false);
                                                                        seatstatus = flightdetail[0].CheckSeat(pickedrow[x1], pickedcolumn[x1]);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            stopper[62] = true;
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("The seat has already been taken. Please pick another one.");
                                                                        }
                                                                    } while (stopper[62] == false);
                                                                    seatingcharge = flightdetail[0].BuySeating(pickedrow[x1], pickedcolumn[x1]);
                                                                    if (claimPoints > 1000 && seatingcharge == 38)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 1000);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 1000 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 400 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    totalfee = destinationfee + seatingcharge;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[0].PrintTicket(inputname[x1], inputic[x1], flightdetail[0].Code, flightdetail[0].ArrivalAirport, flightdetail[0].Date, flightdetail[0].DepartureTime, pickedrow[x1], pickedcolumn[x1], totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[51] = true;
                                                                }
                                                                else if (yesno[1].ToUpper() == "N")
                                                                {
                                                                    stopper[80] = false;
                                                                    stopper[78] = false;
                                                                    stopper[79] = false;
                                                                    Random rnd1 = new Random();
                                                                    Random rnd2 = new Random();
                                                                    string thiscolumn = null;
                                                                    int thisrow;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            int anyrow = rnd1.Next(6, 32);
                                                                            if (anyrow != 12 && anyrow != 13 && anyrow != 14)
                                                                            {
                                                                                stopper[78] = true;
                                                                            }
                                                                            thisrow = anyrow;
                                                                        } while (stopper[78] == false);
                                                                        do
                                                                        {
                                                                            int anycolumn = rnd2.Next(1, 7);
                                                                            if (anycolumn == 1)
                                                                            { thiscolumn = "A"; }
                                                                            else if (anycolumn == 2)
                                                                            { thiscolumn = "B"; }
                                                                            else if (anycolumn == 3)
                                                                            { thiscolumn = "C"; }
                                                                            else if (anycolumn == 4)
                                                                            { thiscolumn = "D"; }
                                                                            else if (anycolumn == 5)
                                                                            { thiscolumn = "E"; }
                                                                            else if (anycolumn == 6)
                                                                            { thiscolumn = "F"; }

                                                                            stopper[79] = true;
                                                                        } while (stopper[79] == false);
                                                                        seatstatus = flightdetail[0].CheckSeat(thisrow, thiscolumn);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            seatingcharge = flightdetail[0].BuySeating(thisrow, thiscolumn);
                                                                            stopper[18] = true;
                                                                        }
                                                                    } while (stopper[18] == false);
                                                                    seatingcharge = 0;
                                                                    totalfee = destinationfee;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[0].PrintTicket(inputname[x1], inputic[x1], flightdetail[0].Code, flightdetail[0].ArrivalAirport, flightdetail[0].Date, flightdetail[0].DepartureTime, thisrow, thiscolumn, totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[51] = true;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Invalid input. Please try again. (Y/N)");
                                                                }

                                                            } while (stopper[51] == false);
                                                            stopper[9] = true;
                                                        }
                                                        else if (decision[3] == 2)
                                                        {
                                                            flightdetail[3].AddPassenger(currentpassenger[x1]);
                                                            stopper[52] = false;

                                                            bool seatstatus;
                                                            do
                                                            {
                                                                Console.Write("Would you like to choose your seat (Y/N)?   ");
                                                                yesno[1] = Console.ReadLine();
                                                                if (yesno[1].ToUpper() == "Y")
                                                                {
                                                                    flightdetail[3].ShowSeating();
                                                                    stopper[63] = false;
                                                                    stopper[64] = false;
                                                                    stopper[65] = false;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            Console.Write("Enter row number:   ");
                                                                            pickedrow[x1] = Convert.ToInt32(Console.ReadLine());
                                                                            if (pickedrow[x1] != 13 && pickedrow[x1] <= 31 && pickedrow[x1] >= 1)
                                                                            {
                                                                                stopper[63] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid row. Try again.");
                                                                            }
                                                                        } while (stopper[63] == false);
                                                                        do
                                                                        {
                                                                            Console.Write("Enter column alphabet:   ");
                                                                            pickedcolumn[x1] = Console.ReadLine();
                                                                            if (pickedcolumn[x1].ToUpper() == "A" || pickedcolumn[x1].ToUpper() == "B" || pickedcolumn[x1].ToUpper() == "C" || pickedcolumn[x1].ToUpper() == "D" || pickedcolumn[x1].ToUpper() == "E" || pickedcolumn[x1].ToUpper() == "F")
                                                                            {
                                                                                stopper[64] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid column. Try again.");
                                                                            }
                                                                        } while (stopper[64] == false);
                                                                        seatstatus = flightdetail[3].CheckSeat(pickedrow[x1], pickedcolumn[x1]);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            stopper[65] = true;
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("The seat has already been taken. Please pick another one.");
                                                                        }
                                                                    } while (stopper[65] == false);
                                                                    seatingcharge = flightdetail[3].BuySeating(pickedrow[x1], pickedcolumn[x1]);
                                                                    if (claimPoints > 1000 && seatingcharge == 38)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 1000);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 1000 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 400 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    totalfee = destinationfee + seatingcharge;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[0].PrintTicket(inputname[x1], inputic[x1], flightdetail[3].Code, flightdetail[3].ArrivalAirport, flightdetail[3].Date, flightdetail[3].DepartureTime, pickedrow[x1], pickedcolumn[x1], totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[52] = true;
                                                                }
                                                                else if (yesno[1].ToUpper() == "N")
                                                                {
                                                                    stopper[83] = false;
                                                                    stopper[81] = false;
                                                                    stopper[82] = false;
                                                                    Random rnd1 = new Random();
                                                                    Random rnd2 = new Random();
                                                                    string thiscolumn = "A";
                                                                    int thisrow;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            int anyrow = rnd1.Next(6, 32);
                                                                            if (anyrow != 12 && anyrow != 13 && anyrow != 14)
                                                                            {
                                                                                stopper[81] = true;
                                                                            }
                                                                            thisrow = anyrow;
                                                                        } while (stopper[81] == false);
                                                                        do
                                                                        {
                                                                            int anycolumn = rnd2.Next(1, 7);
                                                                            if (anycolumn == 1)
                                                                            { thiscolumn = "A"; }
                                                                            else if (anycolumn == 2)
                                                                            { thiscolumn = "B"; }
                                                                            else if (anycolumn == 3)
                                                                            { thiscolumn = "C"; }
                                                                            else if (anycolumn == 4)
                                                                            { thiscolumn = "D"; }
                                                                            else if (anycolumn == 5)
                                                                            { thiscolumn = "E"; }
                                                                            else if (anycolumn == 6)
                                                                            { thiscolumn = "F"; }

                                                                            stopper[82] = true;
                                                                        } while (stopper[82] == false);
                                                                        seatstatus = flightdetail[3].CheckSeat(thisrow, thiscolumn);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            seatingcharge = flightdetail[3].BuySeating(thisrow, thiscolumn);
                                                                            stopper[83] = true;
                                                                        }
                                                                    } while (stopper[83] == false);
                                                                    seatingcharge = 0;
                                                                    totalfee = destinationfee;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[3].PrintTicket(inputname[x1], inputic[x1], flightdetail[3].Code, flightdetail[3].ArrivalAirport, flightdetail[3].Date, flightdetail[3].DepartureTime, thisrow, thiscolumn, totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[52] = true;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Invalid input. Please try again. (Y/N)");
                                                                }
                                                            } while (stopper[52] == false);
                                                            stopper[9] = true;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Invalid input. Please enter (1/2).");
                                                        }
                                                    } while (stopper[9] == false);
                                                    stopper[8] = true;
                                                }
                                                //
                                                //          KUCHING WAS CHOSEN
                                                //
                                                else if (decision[2] == 2)
                                                {
                                                    stopper[10] = false;
                                                    inputdestination = theairport[2].City;
                                                    destinationfee = 199;
                                                    Console.WriteLine("\tFlight Code\tDate\tDeparture Time");
                                                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                                                    Console.WriteLine("(1.)\t{0}\t\t{1}\t{2}", flightdetail[1].Code, flightdetail[1].Date, flightdetail[1].DepartureTime);
                                                    Console.WriteLine("(2.)\t{0}\t\t{1}\t{2}", flightdetail[4].Code, flightdetail[4].Date, flightdetail[4].DepartureTime);
                                                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                                                    do
                                                    {
                                                        Console.Write("Choose a flight(1/2):   ");
                                                        decision[4] = Convert.ToInt32(Console.ReadLine());
                                                        if (decision[4] == 1)
                                                        {
                                                            flightdetail[1].AddPassenger(currentpassenger[x1]);
                                                            stopper[53] = false;

                                                            bool seatstatus;
                                                            do
                                                            {
                                                                Console.Write("Would you like to choose your seat (Y/N)?   ");
                                                                yesno[1] = Console.ReadLine();
                                                                if (yesno[1].ToUpper() == "Y")
                                                                {
                                                                    flightdetail[1].ShowSeating();
                                                                    stopper[66] = false;
                                                                    stopper[67] = false;
                                                                    stopper[68] = false;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            Console.Write("Enter row number:   ");
                                                                            pickedrow[x1] = Convert.ToInt32(Console.ReadLine());
                                                                            if (pickedrow[x1] != 13 && pickedrow[x1] <= 31 && pickedrow[x1] >= 1)
                                                                            {
                                                                                stopper[66] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid row. Try again.");
                                                                            }
                                                                        } while (stopper[66] == false);
                                                                        do
                                                                        {
                                                                            Console.Write("Enter column alphabet:   ");
                                                                            pickedcolumn[x1] = Console.ReadLine();
                                                                            if (pickedcolumn[x1].ToUpper() == "A" || pickedcolumn[x1].ToUpper() == "B" || pickedcolumn[x1].ToUpper() == "C" || pickedcolumn[x1].ToUpper() == "D" || pickedcolumn[x1].ToUpper() == "E" || pickedcolumn[x1].ToUpper() == "F")
                                                                            {
                                                                                stopper[67] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid column. Try again.");
                                                                            }
                                                                        } while (stopper[67] == false);
                                                                        seatstatus = flightdetail[1].CheckSeat(pickedrow[x1], pickedcolumn[x1]);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            stopper[68] = true;
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("The seat has already been taken. Please pick another one.");
                                                                        }
                                                                    } while (stopper[68] == false);
                                                                    seatingcharge = flightdetail[1].BuySeating(pickedrow[x1], pickedcolumn[x1]);
                                                                    if (claimPoints > 1000 && seatingcharge == 38)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 1000);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 1000 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 400 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    totalfee = destinationfee + seatingcharge;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[1].PrintTicket(inputname[x1], inputic[x1], flightdetail[1].Code, flightdetail[1].ArrivalAirport, flightdetail[1].Date, flightdetail[1].DepartureTime, pickedrow[x1], pickedcolumn[x1], totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[53] = true;
                                                                }
                                                                else if (yesno[1].ToUpper() == "N")
                                                                {
                                                                    stopper[86] = false;
                                                                    stopper[84] = false;
                                                                    stopper[85] = false;
                                                                    Random rnd1 = new Random();
                                                                    Random rnd2 = new Random();
                                                                    string thiscolumn = "A";
                                                                    int thisrow;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            int anyrow = rnd1.Next(6, 32);
                                                                            if (anyrow != 12 && anyrow != 13 && anyrow != 14)
                                                                            {
                                                                                stopper[84] = true;
                                                                            }
                                                                            thisrow = anyrow;
                                                                        } while (stopper[84] == false);
                                                                        do
                                                                        {
                                                                            int anycolumn = rnd2.Next(1, 7);
                                                                            if (anycolumn == 1)
                                                                            { thiscolumn = "A"; }
                                                                            else if (anycolumn == 2)
                                                                            { thiscolumn = "B"; }
                                                                            else if (anycolumn == 3)
                                                                            { thiscolumn = "C"; }
                                                                            else if (anycolumn == 4)
                                                                            { thiscolumn = "D"; }
                                                                            else if (anycolumn == 5)
                                                                            { thiscolumn = "E"; }
                                                                            else if (anycolumn == 6)
                                                                            { thiscolumn = "F"; }

                                                                            stopper[85] = true;
                                                                        } while (stopper[85] == false);
                                                                        seatstatus = flightdetail[1].CheckSeat(thisrow, thiscolumn);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            seatingcharge = flightdetail[1].BuySeating(thisrow, thiscolumn);
                                                                            stopper[86] = true;
                                                                        }
                                                                    } while (stopper[86] == false);
                                                                    seatingcharge = 0;
                                                                    totalfee = destinationfee;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[1].PrintTicket(inputname[x1], inputic[x1], flightdetail[1].Code, flightdetail[1].ArrivalAirport, flightdetail[1].Date, flightdetail[1].DepartureTime, thisrow, thiscolumn, totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[53] = true;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Invalid input. Please try again. (Y/N)");
                                                                }
                                                            } while (stopper[53] == false);
                                                            stopper[10] = true;
                                                        }
                                                        else if (decision[4] == 2)
                                                        {
                                                            flightdetail[4].AddPassenger(currentpassenger[x1]);
                                                            stopper[54] = false;

                                                            bool seatstatus;
                                                            do
                                                            {
                                                                Console.Write("Would you like to choose your seat (Y/N)?   ");
                                                                yesno[1] = Console.ReadLine();
                                                                if (yesno[1].ToUpper() == "Y")
                                                                {
                                                                    flightdetail[4].ShowSeating();
                                                                    stopper[69] = false;
                                                                    stopper[70] = false;
                                                                    stopper[71] = false;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            Console.Write("Enter row number:   ");
                                                                            pickedrow[x1] = Convert.ToInt32(Console.ReadLine());
                                                                            if (pickedrow[x1] != 13 && pickedrow[x1] <= 31 && pickedrow[x1] >= 1)
                                                                            {
                                                                                stopper[69] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid row. Try again.");
                                                                            }
                                                                        } while (stopper[69] == false);
                                                                        do
                                                                        {
                                                                            Console.Write("Enter column alphabet:   ");
                                                                            pickedcolumn[x1] = Console.ReadLine();
                                                                            if (pickedcolumn[x1].ToUpper() == "A" || pickedcolumn[x1].ToUpper() == "B" || pickedcolumn[x1].ToUpper() == "C" || pickedcolumn[x1].ToUpper() == "D" || pickedcolumn[x1].ToUpper() == "E" || pickedcolumn[x1].ToUpper() == "F")
                                                                            {
                                                                                stopper[70] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid column. Try again.");
                                                                            }
                                                                        } while (stopper[70] == false);
                                                                        seatstatus = flightdetail[4].CheckSeat(pickedrow[x1], pickedcolumn[x1]);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            stopper[71] = true;
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("The seat has already been taken. Please pick another one.");
                                                                        }
                                                                    } while (stopper[71] == false);
                                                                    seatingcharge = flightdetail[4].BuySeating(pickedrow[x1], pickedcolumn[x1]);
                                                                    if (claimPoints > 1000 && seatingcharge == 38)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 1000);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 1000 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 400 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    totalfee = destinationfee + seatingcharge;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[4].PrintTicket(inputname[x1], inputic[x1], flightdetail[4].Code, flightdetail[4].ArrivalAirport, flightdetail[4].Date, flightdetail[4].DepartureTime, pickedrow[x1], pickedcolumn[x1], totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[54] = true;
                                                                }
                                                                else if (yesno[1].ToUpper() == "N")
                                                                {
                                                                    stopper[89] = false;
                                                                    stopper[87] = false;
                                                                    stopper[88] = false;
                                                                    Random rnd1 = new Random();
                                                                    Random rnd2 = new Random();
                                                                    string thiscolumn = "A";
                                                                    int thisrow;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            int anyrow = rnd1.Next(6, 32);
                                                                            if (anyrow != 12 && anyrow != 13 && anyrow != 14)
                                                                            {
                                                                                stopper[87] = true;
                                                                            }
                                                                            thisrow = anyrow;
                                                                        } while (stopper[87] == false);
                                                                        do
                                                                        {
                                                                            int anycolumn = rnd2.Next(1, 7);
                                                                            if (anycolumn == 1)
                                                                            { thiscolumn = "A"; }
                                                                            else if (anycolumn == 2)
                                                                            { thiscolumn = "B"; }
                                                                            else if (anycolumn == 3)
                                                                            { thiscolumn = "C"; }
                                                                            else if (anycolumn == 4)
                                                                            { thiscolumn = "D"; }
                                                                            else if (anycolumn == 5)
                                                                            { thiscolumn = "E"; }
                                                                            else if (anycolumn == 6)
                                                                            { thiscolumn = "F"; }

                                                                            stopper[88] = true;
                                                                        } while (stopper[88] == false);
                                                                        seatstatus = flightdetail[4].CheckSeat(thisrow, thiscolumn);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            seatingcharge = flightdetail[4].BuySeating(thisrow, thiscolumn);
                                                                            stopper[89] = true;
                                                                        }
                                                                    } while (stopper[89] == false);
                                                                    seatingcharge = 0;
                                                                    totalfee = destinationfee;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[4].PrintTicket(inputname[x1], inputic[x1], flightdetail[4].Code, flightdetail[4].ArrivalAirport, flightdetail[4].Date, flightdetail[4].DepartureTime, thisrow, thiscolumn, totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[54] = true;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Invalid input. Please try again. (Y/N)");
                                                                }
                                                            } while (stopper[54] == false);
                                                            stopper[10] = true;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Invalid input. Please enter (1/2).");
                                                        }
                                                    } while (stopper[10] == false);
                                                    stopper[8] = true;
                                                }
                                                //
                                                //          KOTA KINABALU WAS CHOSEN
                                                //
                                                else if (decision[2] == 3)
                                                {
                                                    stopper[11] = false;
                                                    inputdestination = theairport[3].City;
                                                    destinationfee = 299;
                                                    Console.WriteLine("\tFlight Code\tDate\tDeparture Time");
                                                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                                                    Console.WriteLine("(1.)\t{0}\t\t{1}\t{2}", flightdetail[2].Code, flightdetail[2].Date, flightdetail[2].DepartureTime);
                                                    Console.WriteLine("(2.)\t{0}\t\t{1}\t{2}", flightdetail[5].Code, flightdetail[5].Date, flightdetail[5].DepartureTime);
                                                    Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                                                    do
                                                    {
                                                        Console.Write("Choose a flight(1/2):   ");
                                                        decision[5] = Convert.ToInt32(Console.ReadLine());
                                                        if (decision[5] == 1)
                                                        {
                                                            flightdetail[2].AddPassenger(currentpassenger[x1]);
                                                            stopper[55] = false;

                                                            bool seatstatus;
                                                            do
                                                            {
                                                                Console.Write("Would you like to choose your seat (Y/N)?   ");
                                                                yesno[1] = Console.ReadLine();
                                                                if (yesno[1].ToUpper() == "Y")
                                                                {
                                                                    flightdetail[2].ShowSeating();
                                                                    stopper[72] = false;
                                                                    stopper[73] = false;
                                                                    stopper[74] = false;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            Console.Write("Enter row number:   ");
                                                                            pickedrow[x1] = Convert.ToInt32(Console.ReadLine());
                                                                            if (pickedrow[x1] != 13 && pickedrow[x1] <= 31 && pickedrow[x1] >= 1)
                                                                            {
                                                                                stopper[72] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid row. Try again.");
                                                                            }
                                                                        } while (stopper[72] == false);
                                                                        do
                                                                        {
                                                                            Console.Write("Enter column alphabet:   ");
                                                                            pickedcolumn[x1] = Console.ReadLine();
                                                                            if (pickedcolumn[x1].ToUpper() == "A" || pickedcolumn[x1].ToUpper() == "B" || pickedcolumn[x1].ToUpper() == "C" || pickedcolumn[x1].ToUpper() == "D" || pickedcolumn[x1].ToUpper() == "E" || pickedcolumn[x1].ToUpper() == "F")
                                                                            {
                                                                                stopper[73] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid column. Try again.");
                                                                            }
                                                                        } while (stopper[73] == false);
                                                                        seatstatus = flightdetail[2].CheckSeat(pickedrow[x1], pickedcolumn[x1]);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            stopper[74] = true;
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("The seat has already been taken. Please pick another one.");
                                                                        }
                                                                    } while (stopper[74] == false);
                                                                    seatingcharge = flightdetail[2].BuySeating(pickedrow[x1], pickedcolumn[x1]);
                                                                    if (claimPoints > 1000 && seatingcharge == 38)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 1000);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 1000 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 400 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    totalfee = destinationfee + seatingcharge;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[2].PrintTicket(inputname[x1], inputic[x1], flightdetail[2].Code, flightdetail[2].ArrivalAirport, flightdetail[2].Date, flightdetail[2].DepartureTime, pickedrow[x1], pickedcolumn[x1], totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[55] = true;
                                                                }
                                                                else if (yesno[1].ToUpper() == "N")
                                                                {
                                                                    stopper[92] = false;
                                                                    stopper[90] = false;
                                                                    stopper[91] = false;
                                                                    Random rnd1 = new Random();
                                                                    Random rnd2 = new Random();
                                                                    string thiscolumn = "A";
                                                                    int thisrow;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            int anyrow = rnd1.Next(6, 32);
                                                                            if (anyrow != 12 && anyrow != 13 && anyrow != 14)
                                                                            {
                                                                                stopper[90] = true;
                                                                            }
                                                                            thisrow = anyrow;
                                                                        } while (stopper[90] == false);
                                                                        do
                                                                        {
                                                                            int anycolumn = rnd2.Next(1, 7);
                                                                            if (anycolumn == 1)
                                                                            { thiscolumn = "A"; }
                                                                            else if (anycolumn == 2)
                                                                            { thiscolumn = "B"; }
                                                                            else if (anycolumn == 3)
                                                                            { thiscolumn = "C"; }
                                                                            else if (anycolumn == 4)
                                                                            { thiscolumn = "D"; }
                                                                            else if (anycolumn == 5)
                                                                            { thiscolumn = "E"; }
                                                                            else if (anycolumn == 6)
                                                                            { thiscolumn = "F"; }

                                                                            stopper[91] = true;
                                                                        } while (stopper[91] == false);
                                                                        seatstatus = flightdetail[2].CheckSeat(thisrow, thiscolumn);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            seatingcharge = flightdetail[2].BuySeating(thisrow, thiscolumn);
                                                                            stopper[92] = true;
                                                                        }
                                                                    } while (stopper[92] == false);
                                                                    seatingcharge = 0;
                                                                    totalfee = destinationfee;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[2].PrintTicket(inputname[x1], inputic[x1], flightdetail[2].Code, flightdetail[2].ArrivalAirport, flightdetail[2].Date, flightdetail[2].DepartureTime, thisrow, thiscolumn, totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[55] = true;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Invalid input. Please try again. (Y/N)");
                                                                }
                                                            } while (stopper[55] == false);
                                                            stopper[11] = true;
                                                        }
                                                        else if (decision[5] == 2)
                                                        {
                                                            flightdetail[5].AddPassenger(currentpassenger[x1]);
                                                            stopper[56] = false;

                                                            bool seatstatus;
                                                            do
                                                            {
                                                                Console.Write("Would you like to choose your seat (Y/N)?   ");
                                                                yesno[1] = Console.ReadLine();
                                                                if (yesno[1].ToUpper() == "Y")
                                                                {
                                                                    flightdetail[5].ShowSeating();
                                                                    stopper[75] = false;
                                                                    stopper[76] = false;
                                                                    stopper[77] = false;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            Console.Write("Enter row number:   ");
                                                                            pickedrow[x1] = Convert.ToInt32(Console.ReadLine());
                                                                            if (pickedrow[x1] != 13 && pickedrow[x1] <= 31 && pickedrow[x1] >= 1)
                                                                            {
                                                                                stopper[75] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid row. Try again.");
                                                                            }
                                                                        } while (stopper[75] == false);
                                                                        do
                                                                        {
                                                                            Console.Write("Enter column alphabet:   ");
                                                                            pickedcolumn[x1] = Console.ReadLine();
                                                                            if (pickedcolumn[x1].ToUpper() == "A" || pickedcolumn[x1].ToUpper() == "B" || pickedcolumn[x1].ToUpper() == "C" || pickedcolumn[x1].ToUpper() == "D" || pickedcolumn[x1].ToUpper() == "E" || pickedcolumn[x1].ToUpper() == "F")
                                                                            {
                                                                                stopper[76] = true;
                                                                            }
                                                                            else
                                                                            {
                                                                                Console.WriteLine("Invalid column. Try again.");
                                                                            }
                                                                        } while (stopper[76] == false);
                                                                        seatstatus = flightdetail[5].CheckSeat(pickedrow[x1], pickedcolumn[x1]);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            stopper[77] = true;
                                                                        }
                                                                        else
                                                                        {
                                                                            Console.WriteLine("The seat has already been taken. Please pick another one.");
                                                                        }
                                                                    } while (stopper[77] == false);
                                                                    seatingcharge = flightdetail[5].BuySeating(pickedrow[x1], pickedcolumn[x1]);
                                                                    if (claimPoints > 1000 && seatingcharge == 38)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 1000);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 1000 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    else if (claimPoints > 400 && seatingcharge == 18)
                                                                    {
                                                                        stopper[100] = false;
                                                                        do
                                                                        {
                                                                            Console.WriteLine("Do you wish to exchange your points for free seat charges?");
                                                                            Console.Write("( Y / N )   ");
                                                                            yesno[2] = Console.ReadLine();
                                                                            if (yesno[2].ToUpper() == "Y" || yesno[2].ToUpper() == "N")
                                                                            { stopper[100] = true; }
                                                                            else
                                                                            { Console.WriteLine("Invalid input. Please try again. ( Y / N )"); }
                                                                        } while (stopper[100] == false);
                                                                        if (yesno[2].ToUpper() == "Y")
                                                                        {
                                                                            memberlist.DeductPoints(loginusername, 400);
                                                                            seatingcharge = 0;
                                                                        }
                                                                    }
                                                                    totalfee = destinationfee + seatingcharge;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[5].PrintTicket(inputname[x1], inputic[x1], flightdetail[5].Code, flightdetail[5].ArrivalAirport, flightdetail[5].Date, flightdetail[5].DepartureTime, pickedrow[x1], pickedcolumn[x1], totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[56] = true;
                                                                }
                                                                else if (yesno[1].ToUpper() == "N")
                                                                {
                                                                    stopper[95] = false;
                                                                    stopper[93] = false;
                                                                    stopper[94] = false;
                                                                    Random rnd1 = new Random();
                                                                    Random rnd2 = new Random();
                                                                    string thiscolumn = "A";
                                                                    int thisrow;
                                                                    do
                                                                    {
                                                                        do
                                                                        {
                                                                            int anyrow = rnd1.Next(6, 32);
                                                                            if (anyrow != 12 && anyrow != 13 && anyrow != 14)
                                                                            {
                                                                                stopper[93] = true;
                                                                            }
                                                                            thisrow = anyrow;
                                                                        } while (stopper[93] == false);
                                                                        do
                                                                        {
                                                                            int anycolumn = rnd2.Next(1, 7);
                                                                            if (anycolumn == 1)
                                                                            { thiscolumn = "A"; }
                                                                            else if (anycolumn == 2)
                                                                            { thiscolumn = "B"; }
                                                                            else if (anycolumn == 3)
                                                                            { thiscolumn = "C"; }
                                                                            else if (anycolumn == 4)
                                                                            { thiscolumn = "D"; }
                                                                            else if (anycolumn == 5)
                                                                            { thiscolumn = "E"; }
                                                                            else if (anycolumn == 6)
                                                                            { thiscolumn = "F"; }

                                                                            stopper[94] = true;
                                                                        } while (stopper[94] == false);
                                                                        seatstatus = flightdetail[5].CheckSeat(thisrow, thiscolumn);
                                                                        if (seatstatus == false)
                                                                        {
                                                                            seatingcharge = flightdetail[5].BuySeating(thisrow, thiscolumn);
                                                                            stopper[95] = true;
                                                                        }
                                                                    } while (stopper[95] == false);
                                                                    seatingcharge = 0;
                                                                    totalfee = destinationfee;
                                                                    memberlist.AddPoints(loginusername, totalfee / 2);
                                                                    flightdetail[5].PrintTicket(inputname[x1], inputic[x1], flightdetail[5].Code, flightdetail[5].ArrivalAirport, flightdetail[5].Date, flightdetail[5].DepartureTime, thisrow, thiscolumn, totalfee, memberlist.CurrentPoints(loginusername));
                                                                    stopper[56] = true;
                                                                }
                                                                else
                                                                {
                                                                    Console.WriteLine("Invalid input. Please try again. (Y/N)");
                                                                }
                                                            } while (stopper[56] == false);
                                                            stopper[11] = true;
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine("Invalid input. Please enter (1/2).");
                                                        }
                                                    } while (stopper[11] == false);
                                                    stopper[8] = true;
                                                }
                                                else
                                                { Console.WriteLine("Invalid input. Please choose (1/2/3)"); }
                                            } while (stopper[8] == false);

                                        }
                                        stopper[4] = true;
                                    }
                                    //
                                    //          MEMBER ACTION 3 : VIEW FLIGHT SEAT STATUS
                                    //
                                    else if (decision[1] == 3)
                                    {
                                        stopper[12] = false;
                                        stopper[6] = false;
                                        string viewseatcode;
                                        do
                                        {
                                            do
                                            {
                                                Console.Write("Enter flight code(LAxxxx):   ");
                                                viewseatcode = Console.ReadLine();
                                                if (viewseatcode == flightdetail[0].Code)
                                                {
                                                    flightdetail[0].ShowSeating();
                                                    stopper[6] = true;
                                                }
                                                else if (viewseatcode == flightdetail[1].Code)
                                                {
                                                    flightdetail[1].ShowSeating();
                                                    stopper[6] = true;
                                                }
                                                else if (viewseatcode == flightdetail[2].Code)
                                                {
                                                    flightdetail[2].ShowSeating();
                                                    stopper[6] = true;
                                                }
                                                else if (viewseatcode == flightdetail[3].Code)
                                                {
                                                    flightdetail[3].ShowSeating();
                                                    stopper[6] = true;
                                                }
                                                else if (viewseatcode == flightdetail[4].Code)
                                                {
                                                    flightdetail[4].ShowSeating();
                                                    stopper[6] = true;
                                                }
                                                else if (viewseatcode == flightdetail[5].Code)
                                                {
                                                    flightdetail[5].ShowSeating();
                                                    stopper[6] = true;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid flight code. Try again.");
                                                }
                                            } while (stopper[6] == false);
                                            stopper[7] = false;
                                            do
                                            {
                                                Console.Write("\nReturn (Y/N)?   ");
                                                yesno[0] = Console.ReadLine();
                                                if (yesno[0].ToUpper() == "Y" || yesno[0].ToUpper() == "N")
                                                { stopper[7] = true; }
                                                else
                                                { Console.WriteLine("Invalid input. Try again (Y/N)"); }
                                            } while (stopper[7] == false);
                                            if (yesno[0].ToUpper() == "Y")
                                            {
                                                stopper[12] = true;
                                            }
                                            else if (yesno[0].ToUpper() == "N")
                                            { }
                                        } while (stopper[12] == false);
                                        stopper[4] = true;
                                    }
                                    //
                                    //          MEMBER ACTION 4 : CANCEL AIR TICKET
                                    //
                                    else if (decision[1] == 4)
                                    {
                                        string cancelcode, cancelname, cancelcolumn;
                                        int cancelrow, canceltarget;
                                        double cancelfee;
                                        stopper[400] = false;
                                        do
                                        {
                                            Console.Write("Enter flight code:   ");
                                            cancelcode = Console.ReadLine();
                                            if (cancelcode == flightdetail[0].Code || cancelcode == flightdetail[1].Code || cancelcode == flightdetail[2].Code || cancelcode == flightdetail[3].Code || cancelcode == flightdetail[4].Code || cancelcode == flightdetail[5].Code)
                                            { stopper[400] = true; }
                                            else
                                            { Console.WriteLine("Invalid flight code. Please try again."); }
                                        } while (stopper[400] == false);
                                        if (cancelcode == flightdetail[0].Code)
                                        {
                                            if (flightdetail[0].NumberOfPassengers > 0)
                                            {
                                                Console.Write("Enter name displayed on ticket:   ");
                                                cancelname = Console.ReadLine();
                                                canceltarget = flightdetail[0].FindName(cancelname);
                                                if (canceltarget >= 0)
                                                {
                                                    cancelrow = flightdetail[0].PassengerList[canceltarget].PassengSeatRow; ;
                                                    cancelcolumn = flightdetail[0].PassengerList[canceltarget].PassengSeatColumn;
                                                    cancelfee = flightdetail[0].CancelSeat(cancelrow, cancelcolumn);
                                                    flightdetail[0].PrintBill(cancelname, cancelcode, cancelrow, cancelcolumn, cancelfee);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("{0} cannot be found in passenger list.", cancelname);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("This flight has no passengers yet.");
                                                Console.WriteLine();
                                            }
                                        }
                                        else if (cancelcode == flightdetail[1].Code)
                                        {
                                            if (flightdetail[1].NumberOfPassengers > 0)
                                            {
                                                Console.Write("Enter name displayed on ticket:   ");
                                                cancelname = Console.ReadLine();
                                                canceltarget = flightdetail[1].FindName(cancelname);
                                                if (canceltarget >= 0)
                                                {
                                                    cancelrow = flightdetail[1].PassengerList[canceltarget].PassengSeatRow; ;
                                                    cancelcolumn = flightdetail[1].PassengerList[canceltarget].PassengSeatColumn;
                                                    cancelfee = flightdetail[1].CancelSeat(cancelrow, cancelcolumn);
                                                    flightdetail[1].PrintBill(cancelname, cancelcode, cancelrow, cancelcolumn, cancelfee);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("{0} cannot be found in passenger list.", cancelname);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("This flight has no passengers yet.");
                                                Console.WriteLine();
                                            }
                                        }
                                        else if (cancelcode == flightdetail[2].Code)
                                        {
                                            if (flightdetail[2].NumberOfPassengers > 0)
                                            {
                                                Console.Write("Enter name displayed on ticket:   ");
                                                cancelname = Console.ReadLine();
                                                canceltarget = flightdetail[2].FindName(cancelname);
                                                if (canceltarget >= 0)
                                                {
                                                    cancelrow = flightdetail[2].PassengerList[canceltarget].PassengSeatRow; ;
                                                    cancelcolumn = flightdetail[2].PassengerList[canceltarget].PassengSeatColumn;
                                                    cancelfee = flightdetail[2].CancelSeat(cancelrow, cancelcolumn);
                                                    flightdetail[2].PrintBill(cancelname, cancelcode, cancelrow, cancelcolumn, cancelfee);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("{0} cannot be found in passenger list.", cancelname);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("This flight has no passengers yet.");
                                                Console.WriteLine();
                                            }
                                        }
                                        else if (cancelcode == flightdetail[3].Code)
                                        {
                                            if (flightdetail[3].NumberOfPassengers > 0)
                                            {
                                                Console.Write("Enter name displayed on ticket:   ");
                                                cancelname = Console.ReadLine();
                                                canceltarget = flightdetail[3].FindName(cancelname);
                                                if (canceltarget >= 0)
                                                {
                                                    cancelrow = flightdetail[3].PassengerList[canceltarget].PassengSeatRow; ;
                                                    cancelcolumn = flightdetail[3].PassengerList[canceltarget].PassengSeatColumn;
                                                    cancelfee = flightdetail[3].CancelSeat(cancelrow, cancelcolumn);
                                                    flightdetail[3].PrintBill(cancelname, cancelcode, cancelrow, cancelcolumn, cancelfee);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("{0} cannot be found in passenger list.", cancelname);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("This flight has no passengers yet.");
                                                Console.WriteLine();
                                            }
                                        }
                                        else if (cancelcode == flightdetail[4].Code)
                                        {
                                            if (flightdetail[4].NumberOfPassengers > 0)
                                            {
                                                Console.Write("Enter name displayed on ticket:   ");
                                                cancelname = Console.ReadLine();
                                                canceltarget = flightdetail[4].FindName(cancelname);
                                                if (canceltarget >= 0)
                                                {
                                                    cancelrow = flightdetail[4].PassengerList[canceltarget].PassengSeatRow; ;
                                                    cancelcolumn = flightdetail[4].PassengerList[canceltarget].PassengSeatColumn;
                                                    cancelfee = flightdetail[4].CancelSeat(cancelrow, cancelcolumn);
                                                    flightdetail[4].PrintBill(cancelname, cancelcode, cancelrow, cancelcolumn, cancelfee);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("{0} cannot be found in passenger list.", cancelname);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("This flight has no passengers yet.");
                                                Console.WriteLine();
                                            }
                                        }
                                        else if (cancelcode == flightdetail[5].Code)
                                        {
                                            if (flightdetail[5].NumberOfPassengers > 0)
                                            {
                                                Console.Write("Enter name displayed on ticket:   ");
                                                cancelname = Console.ReadLine();
                                                canceltarget = flightdetail[5].FindName(cancelname);
                                                if (canceltarget >= 0)
                                                {
                                                    cancelrow = flightdetail[5].PassengerList[canceltarget].PassengSeatRow; ;
                                                    cancelcolumn = flightdetail[5].PassengerList[canceltarget].PassengSeatColumn;
                                                    cancelfee = flightdetail[5].CancelSeat(cancelrow, cancelcolumn);
                                                    flightdetail[5].PrintBill(cancelname, cancelcode, cancelrow, cancelcolumn, cancelfee);
                                                }
                                                else
                                                {
                                                    Console.WriteLine("{0} cannot be found in passenger list.", cancelname);
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("This flight has no passengers yet.");
                                                Console.WriteLine();
                                            }
                                        }
                                        else
                                        {
                                            Console.WriteLine("Invalid code. Try again.");
                                        }
                                        
                                        stopper[4] = true;
                                    }
                                    //
                                    //          MEMBER ACTION 5 : CHANGE SEATING
                                    //
                                    else if (decision[1] == 5)
                                    {
                                        string changeName, changeCode, changeColumn, actualColumn;
                                        int changeTarget, changeRow, actualRow;
                                        double changePoints, changeFee;
                                        bool changeSeatStatus;
                                        stopper[500] = false;
                                        stopper[501] = false;
                                        do
                                        {
                                            do
                                            {
                                                Console.Write("Eneter a flight code:   ");
                                                changeCode = Console.ReadLine();
                                                if (changeCode == flightdetail[0].Code || changeCode == flightdetail[1].Code || changeCode == flightdetail[2].Code || changeCode == flightdetail[3].Code || changeCode == flightdetail[4].Code || changeCode == flightdetail[5].Code)
                                                {
                                                    stopper[501] = true;
                                                }
                                                else
                                                {
                                                    Console.WriteLine("Invalid flight code. Try again.");
                                                }
                                            } while (stopper[501] == false);
                                            if (changeCode == flightdetail[0].Code)
                                                {
                                                    if (flightdetail[0].NumberOfPassengers > 0)
                                                    {
                                                        stopper[502] = false;
                                                        do
                                                        {
                                                            Console.Write("Enter name displayed on ticket:   ");
                                                            changeName = Console.ReadLine();
                                                            if (changeName != "" || changeName != " " || changeName != "  ")
                                                            {
                                                                stopper[502] = true;
                                                            }
                                                        } while (stopper[502] == false);
                                                        changeTarget = flightdetail[0].FindName(changeName);
                                                        if (changeTarget >= 0)
                                                        {
                                                            actualRow = flightdetail[0].PassengerList[changeTarget].PassengSeatRow;
                                                            actualColumn = flightdetail[0].PassengerList[changeTarget].PassengSeatColumn;
                                                            stopper[503] = false;
                                                            stopper[504] = false;
                                                            stopper[505] = false;
                                                            do
                                                            {
                                                                do
                                                                {
                                                                    Console.Write("Enter new seat row:   ");
                                                                    changeRow = Convert.ToInt32(Console.ReadLine());
                                                                    if (changeRow != 13 && changeRow >= 1 && changeRow <= 31)
                                                                    { stopper[503] = true; }
                                                                    else
                                                                    { Console.WriteLine("Invalid row number. Please try again."); }
                                                                } while (stopper[503] == false);
                                                                do
                                                                {
                                                                    Console.Write("Enter new seat column:   ");
                                                                    changeColumn = Console.ReadLine();
                                                                    if (changeColumn.ToUpper() == "A" || changeColumn.ToUpper() == "B" || changeColumn.ToUpper() == "C" || changeColumn.ToUpper() == "D" || changeColumn.ToUpper() == "E" || changeColumn.ToUpper() == "F")
                                                                    { stopper[504] = true; }
                                                                    else
                                                                    { Console.WriteLine("Invalid column alphabet. Please try again."); }
                                                                } while (stopper[504] == false);
                                                                changeSeatStatus = flightdetail[0].CheckSeat(changeRow, changeColumn);
                                                                if (changeSeatStatus == false)
                                                                { stopper[505] = true; }
                                                                else
                                                                { Console.WriteLine("The seat has already been taken. Pick another one."); }
                                                            } while (stopper[505] == false);
                                                            changeFee = flightdetail[0].BuySeating(changeRow, changeColumn);
                                                            changeFee = flightdetail[0].CancelSeat(actualRow, actualColumn);
                                                            changeFee = 99;
                                                            changePoints = changeFee / 2;
                                                            memberlist.DeductPoints(loginusername, changePoints);
                                                        stopper[500] = true;
                                                    }
                                                        else
                                                        { Console.WriteLine("{0} cannot be found in the passenger list.", changeName); }
                                                    }
                                                else
                                                {
                                                    Console.WriteLine("No passengers in this flight.");
                                                    stopper[500] = true;
                                                }
                                                }
                                            else if (changeCode == flightdetail[1].Code)
                                            {
                                                if (flightdetail[1].NumberOfPassengers > 0)
                                                {
                                                    stopper[502] = false;
                                                    do
                                                    {
                                                        Console.Write("Enter name displayed on ticket:   ");
                                                        changeName = Console.ReadLine();
                                                        if (changeName != "" || changeName != " " || changeName != "  ")
                                                        {
                                                            stopper[502] = true;
                                                        }
                                                    } while (stopper[502] == false);
                                                    changeTarget = flightdetail[1].FindName(changeName);
                                                    if (changeTarget >= 0)
                                                    {
                                                        actualRow = flightdetail[1].PassengerList[changeTarget].PassengSeatRow;
                                                        actualColumn = flightdetail[1].PassengerList[changeTarget].PassengSeatColumn;
                                                        stopper[503] = false;
                                                        stopper[504] = false;
                                                        stopper[505] = false;
                                                        do
                                                        {
                                                            do
                                                            {
                                                                Console.Write("Enter new seat row:   ");
                                                                changeRow = Convert.ToInt32(Console.ReadLine());
                                                                if (changeRow != 13 && changeRow >= 1 && changeRow <= 31)
                                                                { stopper[503] = true; }
                                                                else
                                                                { Console.WriteLine("Invalid row number. Please try again."); }
                                                            } while (stopper[503] == false);
                                                            do
                                                            {
                                                                Console.Write("Enter new seat column:   ");
                                                                changeColumn = Console.ReadLine();
                                                                if (changeColumn.ToUpper() == "A" || changeColumn.ToUpper() == "B" || changeColumn.ToUpper() == "C" || changeColumn.ToUpper() == "D" || changeColumn.ToUpper() == "E" || changeColumn.ToUpper() == "F")
                                                                { stopper[504] = true; }
                                                                else
                                                                { Console.WriteLine("Invalid column alphabet. Please try again."); }
                                                            } while (stopper[504] == false);
                                                            changeSeatStatus = flightdetail[0].CheckSeat(changeRow, changeColumn);
                                                            if (changeSeatStatus == false)
                                                            { stopper[505] = true; }
                                                            else
                                                            { Console.WriteLine("The seat has already been taken. Pick another one."); }
                                                        } while (stopper[505] == false);
                                                        changeFee = flightdetail[1].BuySeating(changeRow, changeColumn);
                                                        changeFee = flightdetail[1].CancelSeat(actualRow, actualColumn);
                                                        changeFee = 99;
                                                        changePoints = changeFee / 2;
                                                        memberlist.DeductPoints(loginusername, changePoints);
                                                        stopper[500] = true;
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine("{0} cannot be found in the passenger list.", changeName);
                                                    }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No passengers in this flight.");
                                                    stopper[500] = true;
                                                }
                                            }
                                            else if (changeCode == flightdetail[2].Code)
                                            {
                                                if (flightdetail[2].NumberOfPassengers > 0)
                                                {
                                                    stopper[502] = false;
                                                    do
                                                    {
                                                        Console.Write("Enter name displayed on ticket:   ");
                                                        changeName = Console.ReadLine();
                                                        if (changeName != "" || changeName != " " || changeName != "  ")
                                                        {
                                                            stopper[502] = true;
                                                        }
                                                    } while (stopper[502] == false);
                                                    changeTarget = flightdetail[2].FindName(changeName);
                                                    if (changeTarget >= 0)
                                                    {
                                                        actualRow = flightdetail[2].PassengerList[changeTarget].PassengSeatRow;
                                                        actualColumn = flightdetail[2].PassengerList[changeTarget].PassengSeatColumn;
                                                        stopper[503] = false;
                                                        stopper[504] = false;
                                                        stopper[505] = false;
                                                        do
                                                        {
                                                            do
                                                            {
                                                                Console.Write("Enter new seat row:   ");
                                                                changeRow = Convert.ToInt32(Console.ReadLine());
                                                                if (changeRow != 13 && changeRow >= 1 && changeRow <= 31)
                                                                { stopper[503] = true; }
                                                                else
                                                                { Console.WriteLine("Invalid row number. Please try again."); }
                                                            } while (stopper[503] == false);
                                                            do
                                                            {
                                                                Console.Write("Enter new seat column:   ");
                                                                changeColumn = Console.ReadLine();
                                                                if (changeColumn.ToUpper() == "A" || changeColumn.ToUpper() == "B" || changeColumn.ToUpper() == "C" || changeColumn.ToUpper() == "D" || changeColumn.ToUpper() == "E" || changeColumn.ToUpper() == "F")
                                                                { stopper[504] = true; }
                                                                else
                                                                { Console.WriteLine("Invalid column alphabet. Please try again."); }
                                                            } while (stopper[504] == false);
                                                            changeSeatStatus = flightdetail[2].CheckSeat(changeRow, changeColumn);
                                                            if (changeSeatStatus == false)
                                                            { stopper[505] = true; }
                                                            else
                                                            { Console.WriteLine("The seat has already been taken. Pick another one."); }
                                                        } while (stopper[505] == false);
                                                        changeFee = flightdetail[2].BuySeating(changeRow, changeColumn);
                                                        changeFee = flightdetail[2].CancelSeat(actualRow, actualColumn);
                                                        changeFee = 99;
                                                        changePoints = changeFee / 2;
                                                        memberlist.DeductPoints(loginusername, changePoints);
                                                        stopper[500] = true;
                                                    }
                                                    else
                                                    { Console.WriteLine("{0} cannot be found in the passenger list.", changeName); }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No passengers in this flight.");
                                                    stopper[500] = true;
                                                }
                                            }
                                            else if (changeCode == flightdetail[3].Code)
                                            {
                                                if (flightdetail[3].NumberOfPassengers > 0)
                                                {
                                                    stopper[502] = false;
                                                    do
                                                    {
                                                        Console.Write("Enter name displayed on ticket:   ");
                                                        changeName = Console.ReadLine();
                                                        if (changeName != "" || changeName != " " || changeName != "  ")
                                                        {
                                                            stopper[502] = true;
                                                        }
                                                    } while (stopper[502] == false);
                                                    changeTarget = flightdetail[3].FindName(changeName);
                                                    if (changeTarget >= 0)
                                                    {
                                                        actualRow = flightdetail[3].PassengerList[changeTarget].PassengSeatRow;
                                                        actualColumn = flightdetail[3].PassengerList[changeTarget].PassengSeatColumn;
                                                        stopper[503] = false;
                                                        stopper[504] = false;
                                                        stopper[505] = false;
                                                        do
                                                        {
                                                            do
                                                            {
                                                                Console.Write("Enter new seat row:   ");
                                                                changeRow = Convert.ToInt32(Console.ReadLine());
                                                                if (changeRow != 13 && changeRow >= 1 && changeRow <= 31)
                                                                { stopper[503] = true; }
                                                                else
                                                                { Console.WriteLine("Invalid row number. Please try again."); }
                                                            } while (stopper[503] == false);
                                                            do
                                                            {
                                                                Console.Write("Enter new seat column:   ");
                                                                changeColumn = Console.ReadLine();
                                                                if (changeColumn.ToUpper() == "A" || changeColumn.ToUpper() == "B" || changeColumn.ToUpper() == "C" || changeColumn.ToUpper() == "D" || changeColumn.ToUpper() == "E" || changeColumn.ToUpper() == "F")
                                                                { stopper[504] = true; }
                                                                else
                                                                { Console.WriteLine("Invalid column alphabet. Please try again."); }
                                                            } while (stopper[504] == false);
                                                            changeSeatStatus = flightdetail[3].CheckSeat(changeRow, changeColumn);
                                                            if (changeSeatStatus == false)
                                                            { stopper[505] = true; }
                                                            else
                                                            { Console.WriteLine("The seat has already been taken. Pick another one."); }
                                                        } while (stopper[505] == false);
                                                        changeFee = flightdetail[3].BuySeating(changeRow, changeColumn);
                                                        changeFee = flightdetail[3].CancelSeat(actualRow, actualColumn);
                                                        changeFee = 99;
                                                        changePoints = changeFee / 2;
                                                        memberlist.DeductPoints(loginusername, changePoints);
                                                        stopper[500] = true;
                                                    }
                                                    else
                                                    { Console.WriteLine("{0} cannot be found in the passenger list.", changeName); }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No passengers in this flight.");
                                                    stopper[500] = true;
                                                }
                                            }
                                            else if (changeCode == flightdetail[4].Code)
                                            {
                                                if (flightdetail[4].NumberOfPassengers > 0)
                                                {
                                                    stopper[502] = false;
                                                    do
                                                    {
                                                        Console.Write("Enter name displayed on ticket:   ");
                                                        changeName = Console.ReadLine();
                                                        if (changeName != "" || changeName != " " || changeName != "  ")
                                                        {
                                                            stopper[502] = true;
                                                        }
                                                    } while (stopper[502] == false);
                                                    changeTarget = flightdetail[4].FindName(changeName);
                                                    if (changeTarget >= 0)
                                                    {
                                                        actualRow = flightdetail[4].PassengerList[changeTarget].PassengSeatRow;
                                                        actualColumn = flightdetail[4].PassengerList[changeTarget].PassengSeatColumn;
                                                        stopper[503] = false;
                                                        stopper[504] = false;
                                                        stopper[505] = false;
                                                        do
                                                        {
                                                            do
                                                            {
                                                                Console.Write("Enter new seat row:   ");
                                                                changeRow = Convert.ToInt32(Console.ReadLine());
                                                                if (changeRow != 13 && changeRow >= 1 && changeRow <= 31)
                                                                { stopper[503] = true; }
                                                                else
                                                                { Console.WriteLine("Invalid row number. Please try again."); }
                                                            } while (stopper[503] == false);
                                                            do
                                                            {
                                                                Console.Write("Enter new seat column:   ");
                                                                changeColumn = Console.ReadLine();
                                                                if (changeColumn.ToUpper() == "A" || changeColumn.ToUpper() == "B" || changeColumn.ToUpper() == "C" || changeColumn.ToUpper() == "D" || changeColumn.ToUpper() == "E" || changeColumn.ToUpper() == "F")
                                                                { stopper[504] = true; }
                                                                else
                                                                { Console.WriteLine("Invalid column alphabet. Please try again."); }
                                                            } while (stopper[504] == false);
                                                            changeSeatStatus = flightdetail[4].CheckSeat(changeRow, changeColumn);
                                                            if (changeSeatStatus == false)
                                                            { stopper[505] = true; }
                                                            else
                                                            { Console.WriteLine("The seat has already been taken. Pick another one."); }
                                                        } while (stopper[505] == false);
                                                        changeFee = flightdetail[4].BuySeating(changeRow, changeColumn);
                                                        changeFee = flightdetail[4].CancelSeat(actualRow, actualColumn);
                                                        changeFee = 99;
                                                        changePoints = changeFee / 2;
                                                        memberlist.DeductPoints(loginusername, changePoints);
                                                        stopper[500] = true;
                                                    }
                                                    else
                                                    { Console.WriteLine("{0} cannot be found in the passenger list.", changeName); }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No passengers in this flight.");
                                                    stopper[500] = true;
                                                }
                                            }
                                            else if (changeCode == flightdetail[5].Code)
                                            {
                                                if (flightdetail[5].NumberOfPassengers > 0)
                                                {
                                                    stopper[502] = false;
                                                    do
                                                    {
                                                        Console.Write("Enter name displayed on ticket:   ");
                                                        changeName = Console.ReadLine();
                                                        if (changeName != "" || changeName != " " || changeName != "  ")
                                                        {
                                                            stopper[502] = true;
                                                        }
                                                    } while (stopper[502] == false);
                                                    changeTarget = flightdetail[5].FindName(changeName);
                                                    if (changeTarget >= 0)
                                                    {
                                                        actualRow = flightdetail[5].PassengerList[changeTarget].PassengSeatRow;
                                                        actualColumn = flightdetail[5].PassengerList[changeTarget].PassengSeatColumn;
                                                        stopper[503] = false;
                                                        stopper[504] = false;
                                                        stopper[505] = false;
                                                        do
                                                        {
                                                            do
                                                            {
                                                                Console.Write("Enter new seat row:   ");
                                                                changeRow = Convert.ToInt32(Console.ReadLine());
                                                                if (changeRow != 13 && changeRow >= 1 && changeRow <= 31)
                                                                { stopper[503] = true; }
                                                                else
                                                                { Console.WriteLine("Invalid row number. Please try again."); }
                                                            } while (stopper[503] == false);
                                                            do
                                                            {
                                                                Console.Write("Enter new seat column:   ");
                                                                changeColumn = Console.ReadLine();
                                                                if (changeColumn.ToUpper() == "A" || changeColumn.ToUpper() == "B" || changeColumn.ToUpper() == "C" || changeColumn.ToUpper() == "D" || changeColumn.ToUpper() == "E" || changeColumn.ToUpper() == "F")
                                                                { stopper[504] = true; }
                                                                else
                                                                { Console.WriteLine("Invalid column alphabet. Please try again."); }
                                                            } while (stopper[504] == false);
                                                            changeSeatStatus = flightdetail[5].CheckSeat(changeRow, changeColumn);
                                                            if (changeSeatStatus == false)
                                                            { stopper[505] = true; }
                                                            else
                                                            { Console.WriteLine("The seat has already been taken. Pick another one."); }
                                                        } while (stopper[505] == false);
                                                        changeFee = flightdetail[5].BuySeating(changeRow, changeColumn);
                                                        changeFee = flightdetail[5].CancelSeat(actualRow, actualColumn);
                                                        changeFee = 99;
                                                        changePoints = changeFee / 2;
                                                        memberlist.DeductPoints(loginusername, changePoints);
                                                        stopper[500] = true;
                                                    }
                                                    else
                                                    { Console.WriteLine("{0} cannot be found in the passenger list.", changeName); }
                                                }
                                                else
                                                {
                                                    Console.WriteLine("No passengers in this flight.");
                                                    stopper[500] = true;
                                                }
                                            }
                                        } while (stopper[500] == false);
                                        stopper[4] = true;
                                    }
                                    //
                                    //          MEMBER ACTION 6 : VIEW MEMBERSHIP POINTS BALANCE
                                    //
                                    else if (decision[1] == 6)
                                    {
                                        double searchPoints;
                                        searchPoints = memberlist.CurrentPoints(loginusername);
                                        memberlist.PrintPoints(loginusername, searchPoints);
                                        stopper[4] = true;
                                    }
                                    //
                                    //          MEMBER ACTION 7 : BACK TO MAIN MENU
                                    //
                                    else if (decision[1] == 7)
                                    {
                                        stopper[2] = true;
                                        stopper[5] = true;
                                        stopper[4] = true;
                                    }
                                    //
                                    //          MEMBER ACTION 2 : DISPLAY FLIGHT SCHEDULE
                                    //
                                    else if (decision[1] == 2)
                                    {
                                        Console.WriteLine("\tFlight Code\tDestination\t\tDate\t\tDeparture Time");
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                                        Console.WriteLine("(1.)\t{0}\t\t{1}\t\t{2}\t\t{3}", flightdetail[0].Code, flightdetail[0].ArrivalAirport, flightdetail[0].Date, flightdetail[0].DepartureTime);
                                        Console.WriteLine("(2.)\t{0}\t\t{1}\t\t\t{2}\t\t{3}", flightdetail[1].Code, flightdetail[1].ArrivalAirport, flightdetail[1].Date, flightdetail[1].DepartureTime);
                                        Console.WriteLine("(3.)\t{0}\t\t{1}\t\t{2}\t\t{3}", flightdetail[2].Code, flightdetail[2].ArrivalAirport, flightdetail[2].Date, flightdetail[2].DepartureTime);
                                        Console.WriteLine("(4.)\t{0}\t\t{1}\t\t{2}\t\t{3}", flightdetail[3].Code, flightdetail[3].ArrivalAirport, flightdetail[3].Date, flightdetail[3].DepartureTime);
                                        Console.WriteLine("(5.)\t{0}\t\t{1}\t\t\t{2}\t\t{3}", flightdetail[4].Code, flightdetail[4].ArrivalAirport, flightdetail[4].Date, flightdetail[4].DepartureTime);
                                        Console.WriteLine("(6.)\t{0}\t\t{1}\t\t{2}\t\t{3}", flightdetail[5].Code, flightdetail[5].ArrivalAirport, flightdetail[5].Date, flightdetail[5].DepartureTime);
                                        Console.WriteLine("-----------------------------------------------------------------------------------------------------");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Invalid input. Please try again.");
                                    }
                                } while (stopper[4] == false);
                            } while (stopper[5] == false);
                        }
                    } while (stopper[2] == false || loginusername == "" || loginusername == " " || loginusername == "  ");
                }
                //
                //          MAIN MENU OPTION 2: SIGNUP
                //
                else if (decision[0] == 2)
                {
                    stopper[3] = false;
                    string signupusername, signuppassword;
                    bool usedusername;
                    do
                    {
                        Console.Write("Enter new username:   ");
                        signupusername = Console.ReadLine();
                        usedusername = memberlist.SignupMember(signupusername);
                        if (usedusername == true)
                        {
                            Console.WriteLine("This username has already been used. Try another one.\n");
                        }
                        else if (usedusername == false)
                        {
                            Console.Write("Enter new password:   ");
                            signuppassword = Console.ReadLine();
                            memberlist.Register(signupusername, signuppassword);
                            Console.WriteLine("Username has been successfully registered.");
                            stopper[3] = true;
                        }
                    } while (stopper[3] == false || signupusername == "" || signupusername == " " || signupusername == "  ");
                  }
                //
                //          MAIN MENU OPTION 3: EXIT
                //
                else if (decision[0] == 3)
                {
                    stopper[0] = true;
                }
             } while (stopper[0] == false);
        }
        
    }
}

